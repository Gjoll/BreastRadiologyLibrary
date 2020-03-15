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
    class ClassCodeBlocks
    {
        public CodeBlockNested ClassProperties { get; set; }
        public CodeBlockNested ClassConstructor { get; set; }
        public CodeBlockNested ClassMethods { get; set; }
        public CodeBlockNested ClassValidateCodeStart { get; set; }
        public CodeBlockNested ClassValidateCode { get; set; }
        public CodeBlockNested ClassWriteCodeStart { get; set; }
        public CodeBlockNested ClassWriteCode { get; set; }
        public CodeBlockNested ClassReadCodeStart { get; set; }
        public CodeBlockNested ClassReadCode { get; set; }

        public CodeBlockNested LocalClassDefs { get; set; }
        public CodeBlockNested LocalUsings { get; set; }

        public CodeBlockNested InterfaceProperties { get; set; }
        public CodeBlockNested InterfaceMethods { get; set; }

        public static ClassCodeBlocks Create(CodeEditor interfaceEditor,
            CodeEditor classEditor,
            CodeEditor subClassEditor)
        {
            ClassCodeBlocks retVal = new ClassCodeBlocks();

            retVal.ClassProperties = classEditor?.Blocks.Find("Properties", false);
            retVal.ClassConstructor = classEditor?.Blocks.Find("Constructor", false);
            retVal.ClassMethods = classEditor?.Blocks.Find("Methods", false);
            retVal.ClassValidateCodeStart = classEditor?.Blocks.Find("ValidateCodeStart", false);
            retVal.ClassValidateCode = classEditor?.Blocks.Find("ValidateCode", false);
            retVal.ClassWriteCodeStart = classEditor?.Blocks.Find("WriteCodeStart", false);
            retVal.ClassWriteCode = classEditor?.Blocks.Find("WriteCode", false);
            retVal.ClassReadCodeStart = classEditor?.Blocks.Find("ReadCodeStart", false);
            retVal.ClassReadCode = classEditor?.Blocks.Find("ReadCode", false);

            retVal.LocalClassDefs = subClassEditor?.Blocks.Find("LocalClassDefs", false);
            retVal.LocalUsings = subClassEditor?.Blocks.Find("Usings", false);

            retVal.InterfaceProperties = interfaceEditor?.Blocks.Find("Properties", false);
            retVal.InterfaceMethods = interfaceEditor?.Blocks.Find("Methods", false);

            return retVal;
        }
    };
}
