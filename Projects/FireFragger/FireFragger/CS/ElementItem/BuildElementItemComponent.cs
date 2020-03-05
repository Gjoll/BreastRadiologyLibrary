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
    /// Build the class that implements a list of Components, such as
    /// Observation.Component
    /// </summary>
    internal class BuildItemComponent : BuildMemberListBase
    {
        protected ElementTreeNode memberNode;
        protected String MemberName => this.memberNode.Path.LastPathPart().ToMachineName();
        String suffix;
        public BuildItemComponent(DefineBase defineBase,
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
            String[] types,
            String codeValue)
        {
            String TypeName(String profileUrl)
            {
                String retVal = profileUrl.LastUriPart();
                if (profileUrl.StartsWith("http://hl7.org/fhir/StructureDefinition/"))
                    retVal += "Base";
                return retVal;
            }

            String propertyTypes = TypeName(types[0]);
            for (Int32 i = 1; i < types.Length; i++)
                propertyTypes += $", {TypeName(types[i])}";

            String propertyClass;
            if (max == 1)
            {
                propertyClass = $"TItemComponentSingle<{propertyTypes}>";
            }
            else
            {
                propertyClass = $"TItemComponentMultiple<{propertyTypes}>";
            }

            this.codeBlocks.ClassConstructor
                .AppendCode($"this.{propertyName} = new {propertyClass}(\"{CSMisc.FhirPath(memberSlice)}\", {min}, {max}, {codeValue});")
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

                if (memberSlice.Nodes.TryGetItem("value[x]", out ElementTreeNode valueNode) == false)
                    throw new Exception("Component missing value[x] node");
                if (memberSlice.Nodes.TryGetItem("code", out ElementTreeNode codeNode) == false)
                    throw new Exception("Component missing code node");

                Element componentCode = codeNode.ElementDefinition.Fixed;
                if (componentCode == null)
                    componentCode = codeNode.ElementDefinition.Pattern;
                if (componentCode == null)
                    throw new Exception("Missing Component.code fixed value");

                ElementDefinition componentDef = memberSlice.ElementDefinition;
                Int32 max = CSMisc.ToMax(componentDef.Max);
                Int32 min = componentDef.Min.Value;
                String propertyName = sliceName.ToMachineName();

                List<String> types = new List<String>();
                foreach (var type in valueNode.ElementDefinition.Type)
                    types.Add(type.Code);

                String codeMethodName = this.defineBase.DefineFixed(codeNode.ElementDefinition.ElementId, componentCode);
                this.DefineProperty(memberSlice, 
                    max, 
                    min, 
                    propertyName, 
                    types.ToArray(), 
                    $"{codeMethodName}()");
            }
        }
    }
}
