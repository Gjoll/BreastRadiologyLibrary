using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FireFragger
{
    /// <summary>
    /// Build the class that implements a list of coded references, such as
    /// Observation.hasMember
    /// </summary>
    internal class CSBuildMemberListBase : CSCodeBlockDefinitions
    {
        public CSBuildMemberListBase(CSBuilder csBuilder,
            SDInfo fragBase) : base(csBuilder, fragBase)
        {
        }

        protected void DefineCommon(String componentClassName,
            String propertyName,
            String methodSuffix)
        {
            this.fragBase.InterfaceFields
                .AppendCode($"{componentClassName} {propertyName} {{ get ; }}")
                ;

            if (this.fragBase.ClassEditor != null)
            {
                this.fragBase.ClassFields
                    .AppendCode($"public {componentClassName} {propertyName} {{ get ; protected set; }}")
                    ;
                this.fragBase.ClassConstructor
                    .AppendCode($"this.{propertyName} = new {componentClassName}(doc);")
                    ;
                this.fragBase.ClassWriteCode
                    .AppendCode($"this.Write{methodSuffix}(this.{propertyName});")
                    ;
                this.fragBase.ClassReadCode
                    .AppendCode($"this.Read{methodSuffix}(this.{propertyName});")
                    ;
                this.fragBase.ClassValidateCode
                    .AppendCode($"if (this.{propertyName}.Validate(sb) == false) retVal = false;")
                    ;
            }
        }
    }
}
