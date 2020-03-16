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
        protected override String FhirClassName => "Observation.ComponentComponent";

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
                .AppendCode($"public void Read(BreastRadiologyDocument doc, {FhirClassName} component)")
                .OpenBrace()
                .AppendCode("throw new NotImplementedException(\"xxyyz\");")
                .CloseBrace()
                ;
        }

        protected override void BuildItemWrite(CodeBlockNested b)
        {
            b
                .BlankLine()
                .AppendCode($"public void Write(BreastRadiologyDocument doc, {FhirClassName} component)")
                .OpenBrace()
                .AppendCode("throw new NotImplementedException(\"xxyyz\");")
                .CloseBrace()
                ;
        }

        protected override void BuildContainerRead(CodeBlockNested b)
        {
            b
                .BlankLine()
                .AppendCode($"public void Read(BreastRadiologyDocument doc, IEnumerable<{FhirClassName}> components)")
                .OpenBrace()
                //.AppendCode($"List<Item> items = new List<Item>();")
                //.AppendCode($"foreach (Element element in elements)")
                //.AppendCode($"    items.Add(new Item(({this.ElementGetName}) element));")
                //.AppendCode($"this.SetAllItems(items);")
                .CloseBrace()
                ;

            //this.readBlock
            //    .AppendCode($"this.{PropertyName}.Read(this.Doc, items);")
            //    ;
        }

        protected override void BuildContainerWrite(CodeBlockNested b)
        {
            b
               .AppendCode($"public IEnumerable<{FhirClassName}> Write(BreastRadiologyDocument doc)")
               .OpenBrace()
               //.AppendCode($"foreach (Item item in this.GetAllItems())")
               //.OpenBrace()
               //.AppendCode($"{FhirClassName} component = new {FhirClassName}")
               //.OpenBrace()
               //.AppendCode($"Value = item.Value,")
               //.AppendCode($"Code = {componentCodeMethodName}()")
               //.CloseBrace(";")
               //.AppendCode($"yield return component;")
               //.CloseBrace()
               .CloseBrace()
               ;

            //this.writeBlock
            //    .AppendCode($"items.AddRange(this.{PropertyName}.Write(this.Doc));")
            //    ;
        }

        public override void Build()
        {
            Int32 max = CSMisc.ToMax(this.valueNode.ElementDefinition.Max);
            Int32 min = this.valueNode.ElementDefinition.Min.Value;

            this.itemElementSetName.Clear();
            foreach (var type in valueNode.ElementDefinition.Type)
                itemElementSetName.Add(type.Code);

            this.containerClassName = $"{this.ElementName}Container";
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
