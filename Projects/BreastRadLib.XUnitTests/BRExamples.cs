using Hl7.Fhir.Specification.Source;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using Hl7.Fhir.Serialization;
using Hl7.Fhir.Model;
using System.Collections.Generic;
using BreastRadiology.XUnitTests;
using System.Drawing;
using System.Data;
using System.Globalization;
using System.Linq;
using Newtonsoft.Json.Linq;
using BreastRadLib;
using BreastRadLib.BodyDistanceFromExtensionLocal;
using FhirKhit.Tools;
using FhirKhit.Tools.R4;

namespace BreastRadiology.XUnitTests
{
    [TestClass]
    public sealed class BRExamples
    {
        public String OutDir;

        public BRExamples()
        {
            this.OutDir = Path.Combine(
                DirHelper.FindParentDir("HL7"),
                "BreastRadiologyProfiles",
                "IG",
                "Content",
                "Examples"
                );
        }

        BreastRadiologyDocument MakeDoc()
        {
            BreastRadiologyDocument doc = BreastRadiologyDocument.Create();
            {
                Patient p = new Patient
                {
                    Id = "Patient1"
                };
                p.Name.Add(new HumanName
                {
                    Given = new String[] { "Bullwinkle" },
                    Family = "Moose"
                });
                doc.Subject = p;
            }
            {
                Encounter e = new Encounter
                {
                    Id = "Encounter1",
                    Status = Encounter.EncounterStatus.Finished,
                    Class = new Coding("http://terminology.hl7.org/CodeSystem/v3-ActCode",
                        "CASH")
                };
                doc.Encounter = e;
            }

            {
                Device e = new Device
                {
                    Id = "Device1"
                };
                e.DeviceName.Add(new Device.DeviceNameComponent
                {
                    Name = "Test Author",
                    Type = DeviceNameType.UserFriendlyName
                });
                doc.Author = e;
            }
            return doc;
        }

        void DeleteExamples(String prefix)
        {
            foreach (String fileName in Directory.GetFiles(this.OutDir, $"{prefix}*.json"))
                File.Delete(fileName);
        }

        [TestMethod]
        public void A_CreateExamples()
        {
            this.SimpleNarrative();
        }

        String ExamplePath(String prefix, Resource r)
        {
            return Path.Combine(this.OutDir,
                $"{prefix}.{r.TypeName}.{r.Id}.json");
        }

        /// <summary>
        /// Make all references in resource contained local references.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="prefix"></param>
        /// <returns></returns>
        DomainResource SetReferencesContained(Dictionary<String, DomainResource> entryDict,
            List<String> containNames,
            DomainResource dr)
        {
            String FixRef(String json)
            {
                Int32 start = 0;
                while (true)
                {
                    Int32 i = json.IndexOf("\"reference\":", start);
                    if (i < 0)
                        return json;
                    Int32 refStart = json.IndexOf("\"", i + 12) + 1;
                    String firstPart = json.Substring(0, refStart);
                    Int32 refEnd = json.IndexOf("\"", refStart + 1);
                    String lastPart = json.Substring(refEnd);
                    String reference = json.Substring(refStart, refEnd - refStart);
                    if (containNames.Contains(reference) == false)
                        containNames.Add(reference);
                    reference = reference.Replace("/", ".");
                    json = firstPart + "#" + reference;
                    start = json.Length;
                    json = json + lastPart;
                }
            }

            String json = dr.ToFormatedJson();
            json = FixRef(json);

            FhirJsonParser parser = new FhirJsonParser();
            dr = parser.Parse<DomainResource>(json);
            return dr;
        }


        /// <summary>
        /// Note: This modifies the resource in b.
        /// </summary>
        void SplitExampleBundle(Bundle b, String prefix)
        {
            Dictionary<String, DomainResource> entryDict = new Dictionary<string, DomainResource>();

            void Write(Bundle.EntryComponent entry)
            {
                DomainResource dr = (DomainResource) entry.Resource;
                String profile = dr?.Meta?.Profile?.FirstOrDefault();
                if (profile == null)
                    return;
                if (profile.StartsWith("http://hl7.org/fhir/us/breast-radiology/") == false)
                    return;

                List<String> containNames = new List<string>();
                dr = this.SetReferencesContained(entryDict, containNames, dr);

                // If there are contained resource to add, parse this into a domain resource
                // add the contained resources and write it out again.
                if (containNames.Count > 0)
                {
                    foreach (String containName in containNames)
                    {
                        if (entryDict.TryGetValue(containName,
                                out DomainResource containedResource) == false)
                            throw new Exception($"Can not find bundle entry {containName}");
                        containedResource = this.SetReferencesContained(entryDict,
                            containNames,
                            containedResource);
                        dr.Contained.Add(containedResource);
                    }
                }

                String json = dr.ToFormatedJson();
                String path = this.ExamplePath(prefix, dr);
                File.WriteAllText(path, json);
            }

            foreach (Bundle.EntryComponent entry in b.Entry)
            {
                DomainResource dr = (DomainResource) entry.Resource;

                // make a copy so we dont change the original id.
                String json = dr.ToFormatedJson();
                FhirJsonParser parser = new FhirJsonParser();
                dr = parser.Parse<DomainResource>(json);

                dr.Id = $"{dr.TypeName}.{dr.Id}";
                entryDict.Add(entry.FullUrl, dr);
            }

            foreach (Bundle.EntryComponent entry in b.Entry)
                Write(entry);

        }

        void SimpleNarrative()
        {
            const String prefix = "SimpleNarrativeOnlyReport";

            this.DeleteExamples(prefix);
            Bundle b;
            {
                BreastRadiologyDocument doc = this.MakeDoc();
                {
                    BreastRadComposition index = doc.Index;
                    index.Resource.DateElement = doc.Date;
                    index.Resource.Status = CompositionStatus.Final;
                    index.Resource.Title = "Simple Narrative Only Breast Radiology Report";
                    DiagnosticReport diagnosticReport = new DiagnosticReport
                    {
                        Id = "Report"
                    };
                    BreastRadReport report = index.Report.Set(new BreastRadReport(doc, diagnosticReport));

                    DiagnosticReport r = report.Resource;
                    r.Status = DiagnosticReport.DiagnosticReportStatus.Final;
                    r.Category.Add(new CodeableConcept("http://terminology.hl7.org/CodeSystem/observation-category",
                        "imaging"));
                    r.Code = new CodeableConcept("http://loinc.org", "10193-1");
                    r.Conclusion = "Report Narrative conclusion.";
                    report.SetConclusionCode(BiRadsAssessmentCategoriesVS.Code_Category2);
                }
                b = doc.Write();
                String path = this.ExamplePath(prefix, b);
                b.SaveJson(path);

                this.SplitExampleBundle(b, prefix);
                //doc.Index.Resource.SaveJson(Path.Combine(OutDir, "SimpleNarrativeOnlyReport.BreastRadComposition.json"));
                //doc.Index.Report.Get().Resource.SaveJson(Path.Combine(OutDir, "SimpleNarrativeOnlyReport.BreastRadReport.json"));
            }
        }
    }
}

