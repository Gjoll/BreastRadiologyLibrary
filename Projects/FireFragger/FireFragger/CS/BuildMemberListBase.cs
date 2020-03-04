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
        protected Builder csBuilder => this.defineBase.CSBuilder;
        protected DefineBase defineBase;
        protected ClassCodeBlocks codeBlocks;
        string type;

        public BuildMemberListBase(DefineBase defineBase,
            ClassCodeBlocks codeBlocks,
            String type)
        {
            this.type = type;
            this.defineBase = defineBase;
            this.codeBlocks = codeBlocks;
        }

        protected String[] ParamTypes(ElementDefinition valueNode,
            ElementDefinition.TypeRefComponent type)
        {
            if (CSMisc.BindingClassName(valueNode,
                out String bindingClassName,
                out ElementDefinition.ElementDefinitionBindingComponent binding) == false)
                return new string[] { type.Code };

            switch (binding.Strength)
            {
                case BindingStrength.Required:
                    return new string[] { bindingClassName };

                case BindingStrength.Preferred:
                case BindingStrength.Extensible:
                    return new string[] { type.Code, bindingClassName };

                default:
                    return new string[] { type.Code };
            }
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
                    .BlankLine()
                    .SummaryOpen()
                    .Summary($"Access {this.type} value {propertyName}")
                    .SummaryClose()
                    .AppendCode($"public {componentClassName} {propertyName} {{ get ; protected set; }}")
                    ;
                this.codeBlocks.ClassConstructor
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
