using FhirKhit.Tools;
using FhirKhit.Tools.R4;
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
                BreastRadiologyDocument doc = BreastRadiologyDocument.Create();
                Debug.Assert(doc.Index != null);
                {
                    BreastRadReport report = doc.Index.Report.CreateBreastRadReport();
                    Debug.Assert(report.Resource.Meta.Profile.Count() == 1);
                    Debug.Assert(report.Resource.Meta.Profile.First() == "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/BreastRadReport");
                    Debug.Assert(report.Resource.Code.Coding[0].System == "http://loinc.org");
                    Debug.Assert(report.Resource.Code.Coding[0].Code == "10193-1");
                }
                {
                    ServiceRecommendation rec = doc.Index.Recommendations.AddServiceRecommendation();
                    Debug.Assert(rec.Resource.Meta.Profile.Count() == 1);
                    Debug.Assert(rec.Resource.Meta.Profile.First() == "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/ServiceRecommendation");
                    //$rec.SetCode(RecommendationsVS.Code_3DSpotCC);
                    Debug.Assert(rec.Resource.Code.Coding[0].System == RecommendationsVS.Code_3DSpotCC.Value.System);
                    Debug.Assert(rec.Resource.Code.Coding[0].Code == RecommendationsVS.Code_3DSpotCC.Value.Code);
                }
                b = doc.Write();
            }

            {
                BreastRadiologyDocument doc = BreastRadiologyDocument.Read(b);
                Debug.Assert(doc.Index != null);
                {
                    BreastRadReport report = doc.Index.Report.Item;
                    Debug.Assert(report != null);
                    Debug.Assert(report.Resource.Meta.Profile.Count() == 1);
                    Debug.Assert(report.Resource.Meta.Profile.First() == "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/BreastRadReport");
                    Debug.Assert(report.Resource.Code.Coding[0].System == "http://loinc.org");
                    Debug.Assert(report.Resource.Code.Coding[0].Code == "10193-1");
                }
                {
                    Debug.Assert(doc.Index.Recommendations.Count == 1);
                    ServiceRecommendation rec = doc.Index.Recommendations.First() as ServiceRecommendation;
                    Debug.Assert(rec != null);
                    Debug.Assert(rec.Resource.Meta.Profile.Count() == 1);
                    Debug.Assert(rec.Resource.Meta.Profile.First() == "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/ServiceRecommendation");
                    Debug.Assert(rec.Resource.Code.Coding[0].System == RecommendationsVS.Code_3DSpotCC.Value.System);
                    Debug.Assert(rec.Resource.Code.Coding[0].Code == RecommendationsVS.Code_3DSpotCC.Value.Code);
                }
            }
        }
    }
}

