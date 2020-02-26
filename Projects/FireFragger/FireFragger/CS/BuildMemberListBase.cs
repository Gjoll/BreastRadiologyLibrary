using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FireFragger.CS
{
    /// <summary>
    /// Build the class that implements a list of coded references, such as
    /// Observation.hasMember
    /// </summary>
    internal class BuildMemberListBase
    {
        protected Builder csBuilder;
        protected ClassCodeBlocks codeBlocks;
        string type;

        public BuildMemberListBase(Builder csBuilder,
            ClassCodeBlocks codeBlocks,
            String type)
        {
            this.type = type;
            this.csBuilder = csBuilder;
            this.codeBlocks = codeBlocks;
        }

        protected void DefineCommon(String componentClassName,
            String propertyName,
            String methodSuffix)
        {
            if (this.codeBlocks.ClassEditor != null)
            {
                this.codeBlocks.InterfaceProperties
                    .SummaryOpen()
                    .Summary($"Access {this.type} value {propertyName}")
                    .SummaryClose()
                    .AppendCode($"{componentClassName} {propertyName} {{ get ; }}")
                    ;

                this.codeBlocks.ClassProperties
                    .SummaryOpen()
                    .Summary($"Access {this.type} value {propertyName}")
                    .SummaryClose()
                    .AppendCode($"public {componentClassName} {propertyName} {{ get ; protected set; }}")
                    ;
                this.codeBlocks.ClassConstructor
                    .SummaryOpen()
                    .Summary($"Constructor")
                    .SummaryClose()
                    .AppendCode($"this.{propertyName} = new {componentClassName}(doc);")
                    ;
                this.codeBlocks.ClassWriteCode
                    .AppendCode($"this.Write{methodSuffix}(this.{propertyName});")
                    ;
                this.codeBlocks.ClassReadCode
                    .AppendCode($"this.Read{methodSuffix}(this.{propertyName});")
                    ;
                this.codeBlocks.ClassValidateCode
                    .AppendCode($"if (this.{propertyName}.Validate(sb) == false) retVal = false;")
                    ;
            }
        }
    }
}
