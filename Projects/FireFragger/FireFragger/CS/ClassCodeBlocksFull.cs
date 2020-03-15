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
    struct ClassCodeBlocks
    {
        public CodeBlockNested ClassProperties;
        public CodeBlockNested ClassConstructor;
        public CodeBlockNested ClassMethods;
        public CodeBlockNested ClassValidateCodeStart;
        public CodeBlockNested ClassValidateCode;
        public CodeBlockNested ClassWriteCodeStart;
        public CodeBlockNested ClassWriteCode;
        public CodeBlockNested ClassReadCodeStart;
        public CodeBlockNested ClassReadCode;

        public CodeBlockNested LocalClassDefs;
        public CodeBlockNested LocalUsings;

        public CodeBlockNested InterfaceProperties;
        public CodeBlockNested InterfaceMethods;

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
