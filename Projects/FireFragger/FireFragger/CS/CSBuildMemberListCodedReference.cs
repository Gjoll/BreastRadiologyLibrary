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
    internal class CSBuildMemberListCodedReference : CSCodeBlockDefinitions
    {
        ElementTreeNode memberNode;
        String MemberName => memberNode.Path.LastPathPart().ToMachineName();

        public CSBuildMemberListCodedReference(CSBuilder csBuilder,
            SDInfo fragBase,
            ElementTreeNode memberNode) : base(csBuilder, fragBase)
        {
            this.memberNode = memberNode;
        }

        String DefineLocalClass(ElementTreeSlice memberSlice,
            String title,
            Int32 max,
            Int32 min,
            String propertyName,
            String profileUrl)
        {
            String sliceName = memberSlice.ElementDefinition.SliceName;
            String propertyType = profileUrl.LastUriPart();

            String className = $"{propertyName}_Accessor";
            if (this.LocalClassDefs == null)
                return className;

            this.LocalClassDefs
                .SummaryOpen()
                .Summary($"Accessor class for slice '{sliceName}'")
                .Summary($"[Fhir Element '{memberSlice.ElementDefinition.ElementId}]'")
                .SummaryClose()
                ;

            if (max == 1)
            {
                this.LocalClassDefs
                    .AppendCode($"public class {className} : MemberListCodedReferenceSingle<{propertyType}>")
                    .OpenBrace()
                    .DefineBlock(out CodeBlockNested accessors)
                    .SummaryOpen()
                    .Summary($"{className} class constructor")
                    .SummaryClose()
                    .AppendCode($"public {className}(BreastRadiologyDocument doc) : base(\"{className}\")")
                    .OpenBrace()
                    .AppendCode($"this.Init(doc, \"{title}\", {min}, {max}, \"{profileUrl}\");")
                    .CloseBrace()
                    .CloseBrace()
                    ;
            }
            else
            {
                this.LocalClassDefs
                    .AppendCode($"public class {className} : MemberListCodedReferenceMultiple<{propertyType}>")
                    .OpenBrace()
                    .DefineBlock(out CodeBlockNested accessors)
                    .SummaryOpen()
                    .Summary($"{className} class constructor")
                    .SummaryClose()
                    .AppendCode($"public {className}(BreastRadiologyDocument doc) : base(\"{className}\")")
                    .OpenBrace()
                    .AppendCode($"this.Init(doc, \"{title}\", {min}, {max}, \"{profileUrl}\");")
                    .CloseBrace()
                    .CloseBrace()
                    ;
            }
            return className;
        }

        protected virtual String GetTitle(ElementTreeSlice memberSlice)
        {
            return "";
        }

        public void Define()
        {
            if (this.fragBase.ClassEditor != null)
            {
                this.ClassWriteCodeStart
                    ?.AppendCode($"this.Clear{MemberName}();")
                    ;
            }

            foreach (ElementTreeSlice memberSlice in memberNode.Slices.Skip(1))
            {
                String sliceName = memberSlice.ElementDefinition.SliceName;

                ElementDefinition sliceDef = memberSlice.ElementDefinition;
                Int32 max = ToMax(sliceDef.Max);
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
                    DefineLocalClass(memberSlice, GetTitle(memberSlice), max, min, propertyName, profileUrl);

                String interfaceName = CSBuilder.InterfaceName(fragBase);
                String className = CSBuilder.ClassName(fragBase);
                this.InterfaceFields
                    .AppendCode($"{memberClassName} {propertyName} {{ get ; }}")
                    ;

                if (this.fragBase.ClassEditor != null)
                {
                    this.ClassFields
                        .AppendCode($"public {memberClassName} {propertyName} {{ get ; protected set; }}")
                        ;
                    this.ClassConstructor
                        .AppendCode($"this.{propertyName} = new {memberClassName}(doc);")
                        ;
                    this.ClassWriteCode
                        .AppendCode($"this.Write{MemberName}(this.{propertyName});")
                        ;
                    this.ClassReadCode
                        .AppendCode($"this.Read{MemberName}(this.{propertyName});")
                        ;
                }
            }
        }
    }
}
