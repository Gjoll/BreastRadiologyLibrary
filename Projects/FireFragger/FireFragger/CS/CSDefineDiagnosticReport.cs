﻿using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace FireFragger
{
    /// <summary>
    /// Perform Observation specific build
    /// </summary>
    class CSDefineDiagnosticReport : CSDefineBase
    {
        public CSDefineDiagnosticReport(CSBuilder csBuilder,
                    SDInfo fragBase) : base(csBuilder, fragBase)
        {
        }

        public override void Build()
        {
        }
    }
}
