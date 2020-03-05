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
    internal class BuildItemReference : BuildMemberListBase
    {
        protected ElementTreeNode memberNode;
        protected String MemberName => this.memberNode.Path.LastPathPart().ToMachineName();
        String suffix;
        public BuildItemReference(DefineBase defineBase,
            ClassCodeBlocks fragBase,
            String type,
            ElementTreeNode memberNode) : base(defineBase, fragBase, type)
        {
            this.memberNode = memberNode;
            this.suffix = type;
        }

        void DefineProperty(ElementTreeSlice memberSlice,
            Int32 max,
            Int32 min,
            String propertyName,
            String profileUrl)
        {
            String propertyType = profileUrl.LastUriPart();

            String propertyClass;
            if (max == 1)
            {
                propertyClass = $"TItemReferenceSingle<{propertyType}>";
            }
            else
            {
                propertyClass = $"TItemReferenceMultiple<{propertyType}>";
            }

            this.codeBlocks.ClassConstructor
                .AppendCode($"this.{propertyName} = new {propertyClass}(\"{propertyName}\", {min}, {max}, doc, \"{profileUrl}\");")
                ;

            this.codeBlocks.InterfaceProperties
                .SummaryOpen()
                .Summary($"Access {propertyName}")
                .SummaryClose()
                .AppendCode($"{propertyClass} {propertyName} {{ get ; }}")
                ;

            this.codeBlocks.ClassProperties
                .BlankLine()
                .SummaryOpen()
                .Summary($"Access {propertyName}")
                .SummaryClose()
                .AppendCode($"public {propertyClass} {propertyName} {{ get ; protected set; }}")
                ;
            this.codeBlocks.ClassWriteCode
                .AppendCode($"this.Write{this.suffix}(this.{propertyName});")
                ;
            this.codeBlocks.ClassReadCode
                .AppendCode($"this.Read{this.suffix}(this.{propertyName});")
                ;
            this.codeBlocks.ClassValidateCode
                .AppendCode($"if (this.{propertyName}.Validate(sb) == false) retVal = false;")
                ;
        }

        public void Define()
        {
            if (this.codeBlocks.ClassEditor != null)
            {
                this.codeBlocks.ClassWriteCodeStart
                    ?.AppendCode($"this.Clear{this.MemberName}();")
                    ;
            }

            foreach (ElementTreeSlice memberSlice in this.memberNode.Slices.Skip(1))
            {
                String sliceName = memberSlice.ElementDefinition.SliceName;

                ElementDefinition sliceDef = memberSlice.ElementDefinition;
                Int32 max = CSMisc.ToMax(sliceDef.Max);
                Int32 min = sliceDef.Min.Value;
                String propertyName = sliceName.ToMachineName();

                if (sliceDef.Type.Count != 1)
                    throw new Exception($"Error processing slice {sliceName}. Expected single type. Got {sliceDef.Type.Count}");
                if (sliceDef.Type[0].Code != "Reference")
                    throw new Exception($"Error processing slice {sliceName}. Expected type Reference. Got {sliceDef.Type[0].Code}");
                if (sliceDef.Type[0].TargetProfile.Count() != 1)
                    throw new Exception($"Error processing slice {sliceName}. Expected Target count of 1. Got {sliceDef.Type[0].TargetProfile.Count()}");
                String profileUrl = sliceDef.Type[0].TargetProfile.First();
               this.DefineProperty(memberSlice, max, min, propertyName, profileUrl);
            }
        }
    }
}
