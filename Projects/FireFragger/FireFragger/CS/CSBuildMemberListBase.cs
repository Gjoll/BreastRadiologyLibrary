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
        protected ElementTreeNode memberNode;
        protected String MemberName => memberNode.Path.LastPathPart().ToMachineName();

        public CSBuildMemberListBase(CSBuilder csBuilder,
            SDInfo fragBase,
            ElementTreeNode memberNode) : base(csBuilder, fragBase)
        {
            this.memberNode = memberNode;
        }

        protected void DefineCommon(String componentClassName,
            String propertyName,
            String methodSuffix)
        {
            String interfaceName = CSBuilder.InterfaceName(fragBase);
            String className = CSBuilder.ClassName(fragBase);
            this.InterfaceFields
                .AppendCode($"{componentClassName} {propertyName} {{ get ; }}")
                ;

            if (this.fragBase.ClassEditor != null)
            {
                this.ClassFields
                    .AppendCode($"public {componentClassName} {propertyName} {{ get ; protected set; }}")
                    ;
                this.ClassConstructor
                    .AppendCode($"this.{propertyName} = new {componentClassName}(doc);")
                    ;
                this.ClassWriteCode
                    .AppendCode($"this.Write{methodSuffix}(this.{propertyName});")
                    ;
                this.ClassReadCode
                    .AppendCode($"this.Read{methodSuffix}(this.{propertyName});")
                    ;
            }
        }
    }
}
