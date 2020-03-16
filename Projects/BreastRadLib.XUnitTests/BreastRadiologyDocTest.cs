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

namespace BreastRadiology.XUnitTests
{
    [TestClass]
    public sealed class BreastRadiologyDocumentTests
    {
        [TestMethod]
        public void A_CreateBreastRadiologyDocument()
        {
            Bundle b;
            {
                BreastRadiologyDocument doc = MakeDoc();
                Assert.IsTrue(doc.Index != null);
                {
                    BreastRadReport report = doc.Index.Report.Set(new BreastRadReport(doc));
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
                    BreastRadReport report = doc.Index.Report.Set(new BreastRadReport(doc));
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
        public void B_Composition_Sections()
        {
            GlobalSettings.IgnoreCardinalityErrors = true;
            Bundle b;
            {
                BreastRadiologyDocument doc = MakeDoc();
                {
                    BreastRadReport report = doc.Index.Report.Set(new BreastRadReport(doc));
                    Assert.IsTrue(doc.Index.FindingsLeftBreast.Get() == null);
                    Assert.IsTrue(doc.Index.FindingsRightBreast.Get() == null);
                    {
                        SectionFindingsLeftBreast findLeft = doc.Index.FindingsLeftBreast.Set(new SectionFindingsLeftBreast(doc));
                        Assert.IsTrue(doc.Index.FindingsLeftBreast.Get() != null);
                        Assert.IsTrue(doc.Index.FindingsLeftBreast.Get().Resource.Code.Coding[0].System == "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationCodes");
                        Assert.IsTrue(doc.Index.FindingsLeftBreast.Get().Resource.Code.Coding[0].Code == "findingsLeftBreastObservation");
                    }
                    {
                        SectionFindingsRightBreast findRight = doc.Index.FindingsRightBreast.Set(new SectionFindingsRightBreast(doc));
                        Assert.IsTrue(doc.Index.FindingsRightBreast.Get() != null);
                        Assert.IsTrue(doc.Index.FindingsRightBreast.Get().Resource.Code.Coding[0].System == "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationCodes");
                        Assert.IsTrue(doc.Index.FindingsRightBreast.Get().Resource.Code.Coding[0].Code == "findingsRightBreastObservation");
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
                Assert.IsTrue(doc.Index.Recommendations.Count == 2);
                {
                    ServiceRecommendation rec = doc.Index.Recommendations.GetAt(0) as ServiceRecommendation;
                    Assert.IsTrue(rec != null);
                    Assert.IsTrue(rec.Resource.Meta.Profile.Count() == 1);
                    Assert.IsTrue(rec.Resource.Meta.Profile.First() == "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/ServiceRecommendation");
                    Assert.IsTrue(rec.Resource.Code.Coding[0].System == RecommendationsVS.Code_3DSpotCC.Value.System);
                    Assert.IsTrue(rec.Resource.Code.Coding[0].Code == RecommendationsVS.Code_3DSpotCC.Value.Code);
                }
                {
                    ServiceRecommendation rec = doc.Index.Recommendations.GetAt(1) as ServiceRecommendation;
                    Assert.IsTrue(rec != null);
                    Assert.IsTrue(rec.Resource.Meta.Profile.Count() == 1);
                    Assert.IsTrue(rec.Resource.Meta.Profile.First() == "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/ServiceRecommendation");
                    Assert.IsTrue(rec.Resource.Code.Coding[0].System == RecommendationsVS.Code_3DSpotLM.Value.System);
                    Assert.IsTrue(rec.Resource.Code.Coding[0].Code == RecommendationsVS.Code_3DSpotLM.Value.Code);
                }
            }
        }

        [TestMethod]
        public void C_Observation_ComponentTest()
        {
            GlobalSettings.IgnoreCardinalityErrors = true;
            Bundle b;
            {
                BreastRadiologyDocument doc = MakeDoc();
                {
                    BreastRadReport report = doc.Index.Report.Set(new BreastRadReport(doc));
                    SectionFindingsLeftBreast findLeft = doc.Index.FindingsLeftBreast.Set(new SectionFindingsLeftBreast(doc));
                    MGFinding mgFinding = findLeft.MGFinding.Set(new MGFinding(doc));
                    MGAbnormalityAsymmetry asymmetry = mgFinding.MGAbnormalityAsymmetry.Append(new MGAbnormalityAsymmetry(doc));
                    asymmetry.ObsChanges.Append(ObservedChangesVS.Code_DecreaseInCalcifications);
                    asymmetry.ObsChanges.Append(ObservedChangesVS.Code_DecreaseInSize);
                }
                b = doc.Write();
            }

            {
                BreastRadiologyDocument doc = BreastRadiologyDocument.Read(b);
                BreastRadReport report = doc.Index.Report.Get();
                Assert.IsTrue(report != null);

                SectionFindingsLeftBreast findLeft = doc.Index.FindingsLeftBreast.Get();
                Assert.IsTrue(findLeft != null);

                MGFinding mgFinding = findLeft.MGFinding.Get();
                Assert.IsTrue(mgFinding != null);

                MGAbnormalityAsymmetry[] asymmetry = mgFinding.MGAbnormalityAsymmetry.All().ToArray();
                Assert.IsTrue(asymmetry.Length == 1);
                Assert.IsTrue(asymmetry[0].ObsChanges.Count == 2);
                Assert.IsTrue(BLMisc.SameConcept(asymmetry[0].ObsChanges.GetAt(0), ObservedChangesVS.Code_DecreaseInCalcifications));
                Assert.IsTrue(BLMisc.SameConcept(asymmetry[0].ObsChanges.GetAt(1), ObservedChangesVS.Code_DecreaseInSize));
            }
        }

        [TestMethod]
        public void D_Observation_HasMemberTest()
        {
            GlobalSettings.IgnoreCardinalityErrors = true;
            Bundle b;
            {
                BreastRadiologyDocument doc = MakeDoc();
                {
                    BreastRadReport report = doc.Index.Report.Set(new BreastRadReport(doc));
                    SectionFindingsLeftBreast findLeft = doc.Index.FindingsLeftBreast.Set(new SectionFindingsLeftBreast(doc));
                    MGFinding mgFinding = findLeft.MGFinding.Set(new MGFinding(doc));
                    MGAbnormalityAsymmetry asymmetry = mgFinding.MGAbnormalityAsymmetry.Append(new MGAbnormalityAsymmetry(doc));
                    asymmetry = mgFinding.MGAbnormalityAsymmetry.Append(new MGAbnormalityAsymmetry(doc));
                    asymmetry = mgFinding.MGAbnormalityAsymmetry.Append(new MGAbnormalityAsymmetry(doc));
                }
                b = doc.Write();
            }

            {
                BreastRadiologyDocument doc = BreastRadiologyDocument.Read(b);
                BreastRadReport report = doc.Index.Report.Get();
                Assert.IsTrue(report != null);

                SectionFindingsLeftBreast findLeft = doc.Index.FindingsLeftBreast.Get();
                Assert.IsTrue(findLeft != null);

                MGFinding mgFinding = findLeft.MGFinding.Get();
                Assert.IsTrue(mgFinding != null);

                MGAbnormalityAsymmetry[] asymmetry = mgFinding.MGAbnormalityAsymmetry.All().ToArray();
                Assert.IsTrue(asymmetry.Length == 3);
            }
        }

        [TestMethod]
        public void E_BodyDistanceFromExtension()
        {
            IEnumerable<Extension> Write()
            {
                BreastRadiologyDocument doc = MakeDoc();
                BodyDistanceFromExtensionCollection bdc = new BodyDistanceFromExtensionCollection(0, 10);
                {
                    BodyDistanceFromExtensionCollection.BodyDistanceFromExtension item = bdc.Append(new BodyDistanceFromExtensionCollection.BodyDistanceFromExtension());
                    item.DistanceFromLandMark.Set(new Quantity(1, "m"));
                }
                {
                    BodyDistanceFromExtensionCollection.BodyDistanceFromExtension item = bdc.Append(new BodyDistanceFromExtensionCollection.BodyDistanceFromExtension());
                    item.DistanceFromLandMark.Set(new Quantity(2, "m"));
                }
                return bdc.Write(doc);
            }

            BodyDistanceFromExtensionCollection Read(IEnumerable<Extension> extensions)
            {
                BreastRadiologyDocument doc = MakeDoc();
                BodyDistanceFromExtensionCollection bdc = new BodyDistanceFromExtensionCollection(0, 10);
                bdc.Read(doc, extensions);
                return bdc;
            }
            IEnumerable<Extension> extensions = Write();
            BodyDistanceFromExtensionCollection bdc = Read(extensions);
        }

        [TestMethod]
        public void E_Observation_BodySite()
        {
            GlobalSettings.IgnoreCardinalityErrors = true;

            CodeableConcept bodySiteCode = new CodeableConcept("bsSys", "bsCode", "bsDisplay");
            Bundle b;
            {
                BreastRadiologyDocument doc = MakeDoc();
                BreastRadReport report = doc.Index.Report.Set(new BreastRadReport(doc));
                SectionFindingsLeftBreast findLeft = doc.Index.FindingsLeftBreast.Set(new SectionFindingsLeftBreast(doc));
                MGFinding mgFinding = findLeft.MGFinding.Set(new MGFinding(doc));
                AbnormalityCyst abCyst = mgFinding.AbnormalityCyst.Append(new AbnormalityCyst(doc));
                //$BodySiteExtended bodySite = abCyst.BodySite.Create();
                //$bodySite.BodySite = bodySiteCode;
                //$b = doc.Write();
            }
        }

        [TestMethod]
        public void Z_Validate()
        {
            BreastRadiologyDocument doc = MakeDoc();
            StringBuilder sb = new StringBuilder();
            bool retVal = doc.Validate(sb);
            Trace.WriteLine(sb.ToString());
            Assert.IsTrue(retVal == true);
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

