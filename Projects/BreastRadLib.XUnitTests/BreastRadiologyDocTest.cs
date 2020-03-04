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
                Assert.IsTrue(doc.Index != null);
                {
                    BreastRadReport report = doc.Index.Report.Create();
                    Assert.IsTrue(report.Resource.Meta.Profile.Count() == 1);
                    Assert.IsTrue(report.Resource.Meta.Profile.First() == "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/BreastRadReport");
                    Assert.IsTrue(report.Resource.Code.Coding[0].System == "http://loinc.org");
                    Assert.IsTrue(report.Resource.Code.Coding[0].Code == "10193-1");
                }
                b = doc.Write();
            }

            {
                BreastRadiologyDocument doc = BreastRadiologyDocument.Read(b);
                Assert.IsTrue(doc.Index != null);
                {
                    BreastRadReport report = doc.Index.Report.Create();
                    Assert.IsTrue(report != null);
                    Assert.IsTrue(report.Resource.Meta.Profile.Count() == 1);
                    Assert.IsTrue(report.Resource.Meta.Profile.First() == "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/BreastRadReport");
                    Assert.IsTrue(report.Resource.Code.Coding[0].System == "http://loinc.org");
                    Assert.IsTrue(report.Resource.Code.Coding[0].Code == "10193-1");
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
            Assert.IsTrue(retVal == true);
        }

        [TestMethod]
        public void Composition_Sections()
        {
            Bundle b;
            {
                BreastRadiologyDocument doc = MakeDoc();
                {
                    BreastRadReport report = doc.Index.Report.Create();
                    Assert.IsTrue(doc.Index.FindingsLeftBreast.Value == null);
                    Assert.IsTrue(doc.Index.FindingsRightBreast.Value == null);
                    {
                        SectionFindingsLeftBreast findLeft = doc.Index.FindingsLeftBreast.Create();
                        Assert.IsTrue(doc.Index.FindingsLeftBreast.Value != null);
                        Assert.IsTrue(doc.Index.FindingsLeftBreast.Value.Resource.Code.Coding[0].System == "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationCodes");
                        Assert.IsTrue(doc.Index.FindingsLeftBreast.Value.Resource.Code.Coding[0].Code == "findingsLeftBreastObservation");
                    }
                    {
                        SectionFindingsRightBreast findRight = doc.Index.FindingsRightBreast.Create();
                        Assert.IsTrue(doc.Index.FindingsRightBreast.Value != null);
                        Assert.IsTrue(doc.Index.FindingsRightBreast.Value.Resource.Code.Coding[0].System == "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationCodes");
                        Assert.IsTrue(doc.Index.FindingsRightBreast.Value.Resource.Code.Coding[0].Code == "findingsRightBreastObservation");
                    }
                    {
                        ServiceRecommendation rec = doc.Index.Recommendations.Append(new ServiceRecommendation(doc));
                        Assert.IsTrue(rec.Resource.Meta.Profile.Count() == 1);
                        Assert.IsTrue(rec.Resource.Meta.Profile.First() == "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/ServiceRecommendation");
                        rec.SetCode(RecommendationsVS.Code_3DSpotCC);
                        Assert.IsTrue(rec.Resource.Code.Coding[0].System == RecommendationsVS.Code_3DSpotCC.Value.System);
                        Assert.IsTrue(rec.Resource.Code.Coding[0].Code == RecommendationsVS.Code_3DSpotCC.Value.Code);
                    }
                    {
                        ServiceRecommendation rec = doc.Index.Recommendations.Append(new ServiceRecommendation(doc));
                        Assert.IsTrue(rec.Resource.Meta.Profile.Count() == 1);
                        Assert.IsTrue(rec.Resource.Meta.Profile.First() == "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/ServiceRecommendation");
                        rec.SetCode(RecommendationsVS.Code_3DSpotLM);
                        Assert.IsTrue(rec.Resource.Code.Coding[0].System == RecommendationsVS.Code_3DSpotLM.Value.System);
                        Assert.IsTrue(rec.Resource.Code.Coding[0].Code == RecommendationsVS.Code_3DSpotLM.Value.Code);
                    }
                }
                b = doc.Write();
            }

            {
                BreastRadiologyDocument doc = BreastRadiologyDocument.Read(b);
                BreastRadReport report = doc.Index.Report.Value;
                Assert.IsTrue(report != null);
                {
                    SectionFindingsLeftBreast findLeft = doc.Index.FindingsLeftBreast.Value;
                    Assert.IsTrue(doc.Index.FindingsLeftBreast.Value != null);
                    Assert.IsTrue(doc.Index.FindingsLeftBreast.Value.Resource.Code.Coding[0].System == "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationCodes");
                    Assert.IsTrue(doc.Index.FindingsLeftBreast.Value.Resource.Code.Coding[0].Code == "findingsLeftBreastObservation");
                }
                {
                    SectionFindingsRightBreast findRight = doc.Index.FindingsRightBreast.Value;
                    Assert.IsTrue(doc.Index.FindingsRightBreast.Value != null);
                    Assert.IsTrue(doc.Index.FindingsRightBreast.Value.Resource.Code.Coding[0].System == "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationCodes");
                    Assert.IsTrue(doc.Index.FindingsRightBreast.Value.Resource.Code.Coding[0].Code == "findingsRightBreastObservation");
                }
                Assert.IsTrue(doc.Index.Recommendations.Count == 2);
                {
                    ServiceRecommendation rec = doc.Index.Recommendations.At(0)  as ServiceRecommendation;
                    Assert.IsTrue(rec != null);
                    Assert.IsTrue(rec.Resource.Meta.Profile.Count() == 1);
                    Assert.IsTrue(rec.Resource.Meta.Profile.First() == "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/ServiceRecommendation");
                    Assert.IsTrue(rec.Resource.Code.Coding[0].System == RecommendationsVS.Code_3DSpotCC.Value.System);
                    Assert.IsTrue(rec.Resource.Code.Coding[0].Code == RecommendationsVS.Code_3DSpotCC.Value.Code);
                }
                {
                    ServiceRecommendation rec = doc.Index.Recommendations.At(1) as ServiceRecommendation;
                    Assert.IsTrue(rec != null);
                    Assert.IsTrue(rec.Resource.Meta.Profile.Count() == 1);
                    Assert.IsTrue(rec.Resource.Meta.Profile.First() == "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/ServiceRecommendation");
                    Assert.IsTrue(rec.Resource.Code.Coding[0].System == RecommendationsVS.Code_3DSpotLM.Value.System);
                    Assert.IsTrue(rec.Resource.Code.Coding[0].Code == RecommendationsVS.Code_3DSpotLM.Value.Code);
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
                BreastRadReport report = doc.Index.Report.Value;
                Assert.IsTrue(report != null);

                SectionFindingsLeftBreast findLeft = doc.Index.FindingsLeftBreast.Value;
                Assert.IsTrue(findLeft != null);

                MGFinding mgFinding = findLeft.MGFinding.Items.First();
                Assert.IsTrue(mgFinding != null);

                MGAbnormalityAsymmetry[] asymmetry = mgFinding.MGAbnormalityAsymmetry.Items.ToArray();
                Assert.IsTrue(asymmetry.Length == 3);
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
                BreastRadReport report = doc.Index.Report.Value;
                Assert.IsTrue(report != null);

                SectionFindingsLeftBreast findLeft = doc.Index.FindingsLeftBreast.Value;
                Assert.IsTrue(findLeft != null);

                MGFinding mgFinding = findLeft.MGFinding.Items.First();
                Assert.IsTrue(mgFinding != null);

                MGAbnormalityAsymmetry[] asymmetry = mgFinding.MGAbnormalityAsymmetry.Items.ToArray();
                Assert.IsTrue(asymmetry.Length == 1);
                Assert.IsTrue(asymmetry[0].ObsChanges.Count == 2);
                Assert.IsTrue(BLMisc.SameCode(asymmetry[0].ObsChanges.At(0), ObservedChangesVS.Code_DecreaseInCalcifications));
                Assert.IsTrue(BLMisc.SameCode(asymmetry[0].ObsChanges.At(1), ObservedChangesVS.Code_DecreaseInSize));
            }
        }

        //[TestMethod]
        //public void ExtensionTest()
        //{
        //    Bundle b;
        //    {
        //        BreastRadiologyDocument doc = MakeDoc();
        //        {
        //            BreastRadReport report = doc.Index.Report.Create();
        //            SectionFindingsLeftBreast findLeft = doc.Index.FindingsLeftBreast.Create();
        //            MGFinding mgFinding = findLeft.MGFinding.Append();
        //            MGAbnormalityAsymmetry asymmetry = mgFinding.MGAbnormalityAsymmetry.Append();
        //        }
        //        b = doc.Write();
        //    }

        //    {
        //        BreastRadiologyDocument doc = BreastRadiologyDocument.Read(b);
        //        BreastRadReport report = doc.Index.Report.Value;
        //        Assert.IsTrue(report != null);

        //        SectionFindingsLeftBreast findLeft = doc.Index.FindingsLeftBreast.Value;
        //        Assert.IsTrue(findLeft != null);

        //        MGFinding mgFinding = findLeft.MGFinding.First();
        //        Assert.IsTrue(mgFinding != null);

        //        MGAbnormalityAsymmetry[] asymmetry = mgFinding.MGAbnormalityAsymmetry.All().ToArray();
        //        Assert.IsTrue(asymmetry.Length == 3);
        //    }
        //}
    }
}

