using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FireFragger.CS.BuildMembers
{
    internal class BuildMemberElement : BuildMemberBase
    {
        String itemElementGetName;
        List<String> itemElementSetName = new List<String>();
        String containerClassName;
        protected ElementTreeNode valueNode;

        protected string ElementName => $"{this.valueNode.ElementDefinition.Path.LastPathPart()}";
        protected override string PropertyName => $"{ElementName.ToMachineName()}";
        protected override string ElementGetName => this.itemElementGetName;
        protected override IEnumerable<string> ElementSetNames => this.itemElementSetName;
        protected override string ContainerClassName => this.containerClassName;

        /// <summary>
        /// Name of fhir element (as stored in resource).
        /// </summary>
        protected override String FhirClassName => this.itemElementGetName;

        /// <summary>
        /// Perform local processing of container class.
        /// </summary>
        protected override void BuildContainerClassLocal(ClassCodeBlocks itemCodeBlocks)
        {
            base.BuildContainerClassLocal(itemCodeBlocks);
        }

        protected override void BuildItemRead(CodeBlockNested b)
        {
            b
                .BlankLine()
                .AppendCode($"public void ReadItem(BreastRadiologyDocument doc, {FhirClassName} element)")
                .OpenBrace()
                .AppendCode("this.Value = element;")
                .CloseBrace()
                ;
        }

        protected override void BuildItemWrite(CodeBlockNested b)
        {
            b
                .BlankLine()
                .AppendCode($"public {FhirClassName} WriteItem(BreastRadiologyDocument doc)")
                .OpenBrace()
                .AppendCode($"{FhirClassName} retVal = this.Value;")
                .AppendCode($"return retVal;")
                .CloseBrace()
                ;
        }

        protected override void BuildContainerRead(CodeBlockNested b)
        {
            b
                .BlankLine()
                .AppendCode($"public void Read(BreastRadiologyDocument doc, IEnumerable<{FhirClassName}> elements)")
                .OpenBrace()
                .AppendCode($"List<Item> items = new List<Item>();")
                .AppendCode($"foreach (Element element in elements)")
                .OpenBrace()
                .AppendCode($"Item item = new Item();")
                .AppendCode($"item.ReadItem(doc, ({this.ElementGetName}) element);")
                .AppendCode($"items.Add(item);")
                .CloseBrace()
                .AppendCode($"this.SetAllItems(items);")
                .CloseBrace()
                ;

            this.codeBlocks.ClassReadCode
                .AppendCode($"this.BodySite.Read(this.Doc, this.Resource.GetValue<CodeableConcept>(\"bodySite\"));")
                ;
        }

        protected override void BuildContainerWrite(CodeBlockNested b)
        {
            b
                .AppendCode($"public IEnumerable<{FhirClassName}> Write(BreastRadiologyDocument doc)")
                .OpenBrace()
                .AppendCode($"foreach (Item item in this.GetAllItems())")
                .AppendCode($"    yield return item.WriteItem(doc);")
                .CloseBrace()
                ;

            this.codeBlocks.ClassWriteCode
                .AppendCode($"this.Resource.SetValue(\"bodySite\", this.BodySite.Write(this.Doc));")
            ;
        }

        public override void Build()
        {
            Int32 max = CSMisc.ToMax(this.valueNode.ElementDefinition.Max);
            Int32 min = this.valueNode.ElementDefinition.Min.Value;

            this.itemElementSetName.Clear();
            foreach (var type in valueNode.ElementDefinition.Type)
                itemElementSetName.Add(type.Code);

            this.containerClassName = $"M{this.ElementName.ToMachineName()}";
            this.itemElementGetName = (itemElementSetName.Count == 1) ? valueNode.ElementDefinition.Type[0].Code : "Element";
            base.BuildOne(valueNode.ElementDefinition.ElementId, min, max);
        }

        public BuildMemberElement(DefineBase defineBase,
            ClassCodeBlocks codeBlocks,
            ElementTreeNode valueNode) :
            base(defineBase, codeBlocks)
        {
            this.valueNode = valueNode;
        }
    }
}
