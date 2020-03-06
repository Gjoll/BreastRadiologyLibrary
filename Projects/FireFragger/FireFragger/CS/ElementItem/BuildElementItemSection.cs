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
    /// Build the class that implements a list of titled coded sections, such as
    /// Composition.section
    /// </summary>
    internal class BuildItemSection : BuildMemberListBase
    {
        protected ElementTreeNode memberNode;
        protected String MemberName => this.memberNode.Path.LastPathPart().ToMachineName();
        String suffix;
        public BuildItemSection(DefineBase defineBase,
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
            String[] profileUrls,
            String title,
            String codeValue)
        {
            String ResourceBaseName(String profileUrl)
            {
                String retVal = profileUrl.LastUriPart();
                if (profileUrl.StartsWith("http://hl7.org/fhir/StructureDefinition/"))
                    retVal += "Base";
                return retVal;
            }

            String propertyTypes = ResourceBaseName(profileUrls[0]);
            for (Int32 i = 1; i < profileUrls.Length; i++)
                propertyTypes += $", {ResourceBaseName(profileUrls[i])}";

            String propertyClass;
            if (max == 1)
            {
                propertyClass = $"TItemSectionSingle<{propertyTypes}>";
            }
            else
            {
                propertyClass = $"TItemSectionMultiple<{propertyTypes}>";
            }

            this.codeBlocks.ClassConstructor
                .AppendCode($"this.{propertyName} = new {propertyClass}(\"{CSMisc.FhirPath(memberSlice)}\", {min}, {max}, \"{title}\", {codeValue});")
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
                .AppendCode($"this.{propertyName}.WriteItem{this.suffix}(this.Doc, this.Resource);")
                ;
            this.codeBlocks.ClassReadCode
                .AppendCode($"this.{propertyName}.ReadItem{this.suffix}(this.Doc, this.Resource);")
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

                if (memberSlice.Nodes.TryGetItem("entry", out ElementTreeNode entryNode) == false)
                    throw new Exception("Section missing entry node");
                if (memberSlice.Nodes.TryGetItem("title", out ElementTreeNode titleNode) == false)
                    throw new Exception("Section missing title node");
                if (memberSlice.Nodes.TryGetItem("code", out ElementTreeNode codeNode) == false)
                    throw new Exception("Section missing code node");

                Element sectionCode = codeNode.ElementDefinition.Fixed;
                if (sectionCode == null)
                    sectionCode = codeNode.ElementDefinition.Pattern;
                if (sectionCode == null)
                    throw new Exception("Missing section.code fixed value");

                String title = ((FhirString)titleNode.ElementDefinition?.Fixed)?.Value;
                if (String.IsNullOrEmpty(title) == true)
                    throw new Exception("Section missing title value");

                ElementDefinition entryDef = entryNode.ElementDefinition;
                Int32 max = CSMisc.ToMax(entryDef.Max);
                Int32 min = entryDef.Min.Value;
                String propertyName = sliceName.ToMachineName();

                if (entryDef.Type.Count != 1)
                    throw new Exception($"Error processing slice {sliceName}. Expected single type. Got {entryDef.Type.Count}");
                if (entryDef.Type[0].Code != "Reference")
                    throw new Exception($"Error processing slice {sliceName}. Expected type Section. Got {entryDef.Type[0].Code}");
                String[] profileUrls = entryDef.Type[0].TargetProfile.ToArray();

                String codeMethodName = this.defineBase.DefineFixed(codeNode.ElementDefinition.ElementId, sectionCode);
                this.DefineProperty(memberSlice, 
                    max, 
                    min, 
                    propertyName, 
                    profileUrls, 
                    title,
                    $"{codeMethodName}()");
            }
        }
    }
}
