using FhirKhit.Tools;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FireFragger.CS
{
    class CSInfo
    {
        public CodeSystem CodeSystem;
        public CodeEditor ClassCode { get; }

        public CSInfo(CodeSystem cs)
        {
            this.CodeSystem = cs;
            this.ClassCode = new CodeEditor();
            this.ClassCode.TryAddUserMacro("ClassName", CSMisc.CodeSystemName(this));
            this.ClassCode.Load(Path.Combine("Templates", "CodeSystem.txt"));
        }
    };
}
