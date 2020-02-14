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
                BreastRadReport report = doc.Index.CreateReport();
                Debug.Assert(report.Resource.Code.Coding[0].System == "http://loinc.org");
                Debug.Assert(report.Resource.Code.Coding[0].Code == "10193-1");
                b = doc.Write();
            }

            {
                BreastRadiologyDocument doc = BreastRadiologyDocument.Read(b);
                Debug.Assert(doc.Index != null);
                BreastRadReport report = doc.Index.Report;
                Debug.Assert(report != null);
                Debug.Assert(report.Resource.Code.Coding[0].System == "http://loinc.org");
                Debug.Assert(report.Resource.Code.Coding[0].Code == "10193-1");
            }
        }
    }
}

