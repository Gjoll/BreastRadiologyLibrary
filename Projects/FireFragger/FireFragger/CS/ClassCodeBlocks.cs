using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace FireFragger.CS
{
    [DebuggerDisplay("{StructDef.Url}")]
    class ClassCodeBlocks
    {
        public CodeEditor InterfaceEditor;
        public CodeEditor ClassEditor;
        public CodeEditor SubClassEditor;

        public CodeBlockNested ClassProperties => this.ClassEditor?.Blocks.Find("Properties", false);
        public CodeBlockNested ClassConstructor => this.ClassEditor?.Blocks.Find("Constructor", false);
        public CodeBlockNested ClassMethods => this.ClassEditor?.Blocks.Find("Methods", false);
        public CodeBlockNested ClassValidateCodeStart => this.ClassEditor?.Blocks.Find("ValidateCodeStart", false);
        public CodeBlockNested ClassValidateCode => this.ClassEditor?.Blocks.Find("ValidateCode", false);
        public CodeBlockNested ClassWriteCodeStart => this.ClassEditor?.Blocks.Find("WriteCodeStart", false);
        public CodeBlockNested ClassWriteCode => this.ClassEditor?.Blocks.Find("WriteCode", false);
        public CodeBlockNested ClassReadCodeStart => this.ClassEditor?.Blocks.Find("ReadCodeStart", false);
        public CodeBlockNested ClassReadCode => this.ClassEditor?.Blocks.Find("ReadCode", false);

        public CodeBlockNested LocalClassDefs => this.SubClassEditor?.Blocks.Find("LocalClassDefs", false);

        public CodeBlockNested InterfaceProperties => this.InterfaceEditor?.Blocks.Find("Properties", false);
        public CodeBlockNested InterfaceMethods => this.InterfaceEditor?.Blocks.Find("Methods", false);

        public ClassCodeBlocks()
        {
            this.InterfaceEditor = new CodeEditor();
            this.SubClassEditor = new CodeEditor();
            this.ClassEditor = new CodeEditor();
        }
    };
}
