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
                    Id = "Patient/1"
                };
                p.Name.Add(new HumanName
                {
                    Given = new String[] {"Bullwinkle"},
                    Family = "Moose"
                });
                doc.Subject = p;
            }
            {
                Encounter e = new Encounter
                {
                    Id = "Encounter/1",
                    Status = Encounter.EncounterStatus.Finished,
                    Class = new Coding("http://terminology.hl7.org/CodeSystem/v3-ActCode",
                        "CASH")
                };
                doc.Encounter = e;
            }

            {
                Device e = new Device
                {
                    Id = "Device/1"
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

        [TestMethod]
        public void A_CreateExamples()
        {
            SimpleNarrative();
        }

        void SimpleNarrative()
        {
            Bundle b;
            {
                BreastRadiologyDocument doc = MakeDoc();
                Assert.IsTrue(doc.Index != null);
                {
                    doc.Index.Resource.DateElement = new FhirDateTime(2019, 11, 1);
                    BreastRadReport report = doc.Index.Report.Set(new BreastRadReport(doc));

                    DiagnosticReport r = report.Resource;
                    r.Id = "ReportId";
                    r.Status = DiagnosticReport.DiagnosticReportStatus.Final;
                    r.Category.Add(new CodeableConcept("http://terminology.hl7.org/CodeSystem/observation-category",
                        "Imaging"));
                    r.Code = new CodeableConcept("http://loinc.org", "10193-1");
                    r.Conclusion = "Report Narrative conclusion.";
                    report.SetConclusionCode(BiRadsAssessmentCategoriesVS.Code_Category2);
                }
                b = doc.Write();
                b.SaveJson(Path.Combine(OutDir, "FhirDocument.SimpleNarrativeOnlyReport.json"));
            }
        }
    }
}

