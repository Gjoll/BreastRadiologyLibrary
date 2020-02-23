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
    internal class BuildMemberListReference : BuildMemberListBase
    {
        protected ElementTreeNode memberNode;
        protected String MemberName => this.memberNode.Path.LastPathPart().ToMachineName();

        public BuildMemberListReference(Builder csBuilder,
            SDInfo fragBase,
            ElementTreeNode memberNode) : base(csBuilder, fragBase)
        {
            this.memberNode = memberNode;
        }

        String DefineLocalClass(ElementTreeSlice memberSlice,
            Int32 max,
            Int32 min,
            String propertyName,
            String profileUrl)
        {
            String sliceName = memberSlice.ElementDefinition.SliceName;
            String propertyType = profileUrl.LastUriPart();

            String className = $"{propertyName}_Accessor";
            if (this.fragBase.LocalClassDefs == null)
                return className;

            this.fragBase.LocalClassDefs
                .SummaryOpen()
                .Summary($"Accessor class for slice '{sliceName}'")
                .Summary($"[Fhir Element '{memberSlice.ElementDefinition.ElementId}]'")
                .SummaryClose()
                ;

            if (max == 1)
            {
                this.fragBase.LocalClassDefs
                    .AppendCode($"public class {className} : MemberListReferenceSingle<{propertyType}>")
                    .OpenBrace()
                    .DefineBlock(out CodeBlockNested accessors)
                    .SummaryOpen()
                    .Summary($"{className} class constructor")
                    .SummaryClose()
                    .AppendCode($"public {className}(BreastRadiologyDocument doc) : base(\"{className}\")")
                    .OpenBrace()
                    .AppendCode($"this.Init(doc, {min}, {max}, \"{profileUrl}\");")
                    .CloseBrace()
                    .CloseBrace()
                    ;
            }
            else
            {
                this.fragBase.LocalClassDefs
                    .AppendCode($"public class {className} : MemberListReferenceMultiple<{propertyType}>")
                    .OpenBrace()
                    .DefineBlock(out CodeBlockNested accessors)
                    .SummaryOpen()
                    .Summary($"{className} class constructor")
                    .SummaryClose()
                    .AppendCode($"public {className}(BreastRadiologyDocument doc) : base(\"{className}\")")
                    .OpenBrace()
                    .AppendCode($"this.Init(doc, {min}, {max}, \"{profileUrl}\");")
                    .CloseBrace()
                    .CloseBrace()
                    ;
            }
            return className;
        }

        public void Define()
        {
            if (this.fragBase.ClassEditor != null)
            {
                this.fragBase.ClassWriteCodeStart
                    ?.AppendCode($"this.Clear{this.MemberName}();")
                    ;
            }

            foreach (ElementTreeSlice memberSlice in this.memberNode.Slices.Skip(1))
            {
                String sliceName = memberSlice.ElementDefinition.SliceName;

                ElementDefinition sliceDef = memberSlice.ElementDefinition;
                Int32 max = this.ToMax(sliceDef.Max);
                Int32 min = sliceDef.Min.Value;
                String propertyName = sliceName.ToMachineName();

                if (sliceDef.Type.Count != 1)
                    throw new Exception($"Error processing slice {sliceName}. Expected single type. Got {sliceDef.Type.Count}");
                if (sliceDef.Type[0].Code != "Reference")
                    throw new Exception($"Error processing slice {sliceName}. Expected type Reference. Got {sliceDef.Type[0].Code}");
                if (sliceDef.Type[0].TargetProfile.Count() != 1)
                    throw new Exception($"Error processing slice {sliceName}. Expected Target count of 1. Got {sliceDef.Type[0].TargetProfile.Count()}");
                String profileUrl = sliceDef.Type[0].TargetProfile.First();

                String memberClassName =
                    this.DefineLocalClass(memberSlice, max, min, propertyName, profileUrl);

                this.DefineCommon(memberClassName, propertyName, this.MemberName);
            }
        }
    }
}
