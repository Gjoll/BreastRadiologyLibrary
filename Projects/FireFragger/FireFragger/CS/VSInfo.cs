﻿using FhirKhit.Tools;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FireFragger.CS
{
    class VSInfo
    {
        public ValueSet ValueSet;
        public CodeEditor ClassCode;

        public VSInfo(ValueSet vs)
        {
            this.ValueSet = vs;
            this.ClassCode = new CodeEditor();
            this.ClassCode.TryAddUserMacro("ClassName", CSMisc.ValueSetName(this));
            this.ClassCode.Load(Path.Combine("Templates", "ValueSet.txt"));
        }
    };
}
