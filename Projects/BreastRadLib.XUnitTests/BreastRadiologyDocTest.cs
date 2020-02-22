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

namespace BreastRadiology.XUnitTests
{
    [TestClass]
    public sealed class BreastRadiologyDocumentTests
    {
        [TestMethod]
        public void CreateBreastRadiologyDocument()
        {
            Bundle b;
            {
                BreastRadiologyDocument doc = MakeDoc();
                Debug.Assert(doc.Index != null);
                {
                    BreastRadReport report = doc.Index.Report.Create();
                    Debug.Assert(report.Resource.Meta.Profile.Count() == 1);
                    Debug.Assert(report.Resource.Meta.Profile.First() == "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/BreastRadReport");
                    Debug.Assert(report.Resource.Code.Coding[0].System == "http://loinc.org");
                    Debug.Assert(report.Resource.Code.Coding[0].Code == "10193-1");
                }
                b = doc.Write();
            }

            {
                BreastRadiologyDocument doc = BreastRadiologyDocument.Read(b);
                Debug.Assert(doc.Index != null);
                {
                    BreastRadReport report = doc.Index.Report.Create();
                    Debug.Assert(report != null);
                    Debug.Assert(report.Resource.Meta.Profile.Count() == 1);
                    Debug.Assert(report.Resource.Meta.Profile.First() == "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/BreastRadReport");
                    Debug.Assert(report.Resource.Code.Coding[0].System == "http://loinc.org");
                    Debug.Assert(report.Resource.Code.Coding[0].Code == "10193-1");
                }
            }
        }


        BreastRadiologyDocument MakeDoc()
        {
            BreastRadiologyDocument doc = BreastRadiologyDocument.Create();
            doc.Subject = new ResourceReference { Reference = "xxyyz" };
            doc.Encounter = new ResourceReference { Reference = "xxyyz" };
            return doc;
        }

        [TestMethod]
        public void Document_Validate()
        {
            BreastRadiologyDocument doc = MakeDoc();
            StringBuilder sb = new StringBuilder();
            bool retVal = doc.Validate(sb);
            Trace.WriteLine(sb.ToString());
            Debug.Assert(retVal == true);
        }

        [TestMethod]
        public void Composition_Sections()
        {
            Bundle b;
            {
                BreastRadiologyDocument doc = MakeDoc();
                {
                    BreastRadReport report = doc.Index.Report.Create();
                    Assert.IsTrue(doc.Index.FindingsLeftBreast.Get() == null);
                    Assert.IsTrue(doc.Index.FindingsRightBreast.Get() == null);
                    {
                        SectionFindingsLeftBreast findLeft = doc.Index.FindingsLeftBreast.Create();
                        Assert.IsTrue(doc.Index.FindingsLeftBreast.Get() != null);
                        Assert.IsTrue(doc.Index.FindingsLeftBreast.Get().Resource.Code.Coding[0].System == "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationCodes");
                        Assert.IsTrue(doc.Index.FindingsLeftBreast.Get().Resource.Code.Coding[0].Code == "findingsLeftBreastObservation");
                    }
                    {
                        SectionFindingsRightBreast findRight = doc.Index.FindingsRightBreast.Create();
                        Assert.IsTrue(doc.Index.FindingsRightBreast.Get() != null);
                        Assert.IsTrue(doc.Index.FindingsRightBreast.Get().Resource.Code.Coding[0].System == "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationCodes");
                        Assert.IsTrue(doc.Index.FindingsRightBreast.Get().Resource.Code.Coding[0].Code == "findingsRightBreastObservation");
                    }
                    {
                        ServiceRecommendation rec = doc.Index.Recommendations.AppendServiceRecommendation();
                        Debug.Assert(rec.Resource.Meta.Profile.Count() == 1);
                        Debug.Assert(rec.Resource.Meta.Profile.First() == "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/ServiceRecommendation");
                        rec.SetCode(RecommendationsVS.Code_3DSpotCC);
                        Debug.Assert(rec.Resource.Code.Coding[0].System == RecommendationsVS.Code_3DSpotCC.Value.System);
                        Debug.Assert(rec.Resource.Code.Coding[0].Code == RecommendationsVS.Code_3DSpotCC.Value.Code);
                    }
                    {
                        ServiceRecommendation rec = doc.Index.Recommendations.AppendServiceRecommendation();
                        Debug.Assert(rec.Resource.Meta.Profile.Count() == 1);
                        Debug.Assert(rec.Resource.Meta.Profile.First() == "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/ServiceRecommendation");
                        rec.SetCode(RecommendationsVS.Code_3DSpotLM);
                        Debug.Assert(rec.Resource.Code.Coding[0].System == RecommendationsVS.Code_3DSpotLM.Value.System);
                        Debug.Assert(rec.Resource.Code.Coding[0].Code == RecommendationsVS.Code_3DSpotLM.Value.Code);
                    }
                }
                b = doc.Write();
            }

            {
                BreastRadiologyDocument doc = BreastRadiologyDocument.Read(b);
                BreastRadReport report = doc.Index.Report.Get();
                Assert.IsTrue(report != null);
                {
                    SectionFindingsLeftBreast findLeft = doc.Index.FindingsLeftBreast.Get();
                    Assert.IsTrue(doc.Index.FindingsLeftBreast.Get() != null);
                    Assert.IsTrue(doc.Index.FindingsLeftBreast.Get().Resource.Code.Coding[0].System == "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationCodes");
                    Assert.IsTrue(doc.Index.FindingsLeftBreast.Get().Resource.Code.Coding[0].Code == "findingsLeftBreastObservation");
                }
                {
                    SectionFindingsRightBreast findRight = doc.Index.FindingsRightBreast.Get();
                    Assert.IsTrue(doc.Index.FindingsRightBreast.Get() != null);
                    Assert.IsTrue(doc.Index.FindingsRightBreast.Get().Resource.Code.Coding[0].System == "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationCodes");
                    Assert.IsTrue(doc.Index.FindingsRightBreast.Get().Resource.Code.Coding[0].Code == "findingsRightBreastObservation");
                }
                Debug.Assert(doc.Index.Recommendations.Count == 2);
                {
                    ServiceRecommendation rec = doc.Index.Recommendations.At(0)  as ServiceRecommendation;
                    Debug.Assert(rec != null);
                    Debug.Assert(rec.Resource.Meta.Profile.Count() == 1);
                    Debug.Assert(rec.Resource.Meta.Profile.First() == "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/ServiceRecommendation");
                    Debug.Assert(rec.Resource.Code.Coding[0].System == RecommendationsVS.Code_3DSpotCC.Value.System);
                    Debug.Assert(rec.Resource.Code.Coding[0].Code == RecommendationsVS.Code_3DSpotCC.Value.Code);
                }
                {
                    ServiceRecommendation rec = doc.Index.Recommendations.At(1) as ServiceRecommendation;
                    Debug.Assert(rec != null);
                    Debug.Assert(rec.Resource.Meta.Profile.Count() == 1);
                    Debug.Assert(rec.Resource.Meta.Profile.First() == "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/ServiceRecommendation");
                    Debug.Assert(rec.Resource.Code.Coding[0].System == RecommendationsVS.Code_3DSpotLM.Value.System);
                    Debug.Assert(rec.Resource.Code.Coding[0].Code == RecommendationsVS.Code_3DSpotLM.Value.Code);
                }
            }
        }

        [TestMethod]
        public void Observation_HasMemberTest()
        {
            Bundle b;
            {
                BreastRadiologyDocument doc = MakeDoc();
                {
                    BreastRadReport report = doc.Index.Report.Create();
                    SectionFindingsLeftBreast findLeft = doc.Index.FindingsLeftBreast.Create();
                    MGFinding mgFinding = findLeft.MGFinding.Append();
                    MGAbnormalityAsymmetry asymmetry = mgFinding.MGAbnormalityAsymmetry.Append();
                    asymmetry = mgFinding.MGAbnormalityAsymmetry.Append();
                    asymmetry = mgFinding.MGAbnormalityAsymmetry.Append();
                }
                b = doc.Write();
            }

            {
                BreastRadiologyDocument doc = BreastRadiologyDocument.Read(b);
                BreastRadReport report = doc.Index.Report.Get();
                Debug.Assert(report != null);

                SectionFindingsLeftBreast findLeft = doc.Index.FindingsLeftBreast.Get();
                Debug.Assert(findLeft != null);

                MGFinding mgFinding = findLeft.MGFinding.First();
                Debug.Assert(mgFinding != null);

                MGAbnormalityAsymmetry[] asymmetry = mgFinding.MGAbnormalityAsymmetry.All().ToArray();
                Debug.Assert(asymmetry.Length == 3);
            }
        }


        [TestMethod]
        public void Observation_ComponentTest()
        {
            Bundle b;
            {
                BreastRadiologyDocument doc = MakeDoc();
                {
                    BreastRadReport report = doc.Index.Report.Create();
                    SectionFindingsLeftBreast findLeft = doc.Index.FindingsLeftBreast.Create();
                    MGFinding mgFinding = findLeft.MGFinding.Append();
                    MGAbnormalityAsymmetry asymmetry = mgFinding.MGAbnormalityAsymmetry.Append();
                    asymmetry.ObsChanges.Append(ObservedChangesVS.Code_DecreaseInCalcifications);
                    asymmetry.ObsChanges.Append(ObservedChangesVS.Code_DecreaseInSize);
                }
                b = doc.Write();
            }

            {
                BreastRadiologyDocument doc = BreastRadiologyDocument.Read(b);
                BreastRadReport report = doc.Index.Report.Get();
                Debug.Assert(report != null);

                SectionFindingsLeftBreast findLeft = doc.Index.FindingsLeftBreast.Get();
                Debug.Assert(findLeft != null);

                MGFinding mgFinding = findLeft.MGFinding.First();
                Debug.Assert(mgFinding != null);

                MGAbnormalityAsymmetry[] asymmetry = mgFinding.MGAbnormalityAsymmetry.All().ToArray();
                Debug.Assert(asymmetry.Length == 1);
                Debug.Assert(asymmetry[0].ObsChanges.Count == 2);
                Debug.Assert(BLMisc.SameCode(asymmetry[0].ObsChanges.At(0), ObservedChangesVS.Code_DecreaseInCalcifications));
                Debug.Assert(BLMisc.SameCode(asymmetry[0].ObsChanges.At(1), ObservedChangesVS.Code_DecreaseInSize));
            }
        }





        [TestMethod]
        public void ExtensionTest()
        {
            Bundle b;
            {
                BreastRadiologyDocument doc = MakeDoc();
                {
                    BreastRadReport report = doc.Index.Report.Create();
                    SectionFindingsLeftBreast findLeft = doc.Index.FindingsLeftBreast.Create();
                    MGFinding mgFinding = findLeft.MGFinding.Append();
                    MGAbnormalityAsymmetry asymmetry = mgFinding.MGAbnormalityAsymmetry.Append();
                }
                b = doc.Write();
            }

            {
                BreastRadiologyDocument doc = BreastRadiologyDocument.Read(b);
                BreastRadReport report = doc.Index.Report.Get();
                Debug.Assert(report != null);

                SectionFindingsLeftBreast findLeft = doc.Index.FindingsLeftBreast.Get();
                Debug.Assert(findLeft != null);

                MGFinding mgFinding = findLeft.MGFinding.First();
                Debug.Assert(mgFinding != null);

                MGAbnormalityAsymmetry[] asymmetry = mgFinding.MGAbnormalityAsymmetry.All().ToArray();
                Debug.Assert(asymmetry.Length == 3);
            }
        }
    }
}

