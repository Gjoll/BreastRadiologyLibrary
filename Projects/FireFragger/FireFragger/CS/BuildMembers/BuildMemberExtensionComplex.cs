using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FireFragger.CS.BuildMembers
{
    internal class BuildMemberExtensionComplex : BuildMemberBase
    {
        String extensionName;
        protected ElementTreeNode valueNode;

        protected override string PropertyName => $"{extensionName.ToMachineName()}";
        protected override string ElementGetName => this.extensionName;
        protected override IEnumerable<string> ElementSetNames => new String[] { this.extensionName };
        protected override string ContainerClassName => $"{extensionName.ToMachineName()}Collection";

        /// <summary>
        /// Name of fhir element (as stored in resource).
        /// </summary>
        protected override String FhirClassName => "Extension";

        /// <summary>
        /// Perform local processing of container class.
        /// </summary>
        protected override void BuildContainerClassLocal(ClassCodeBlocks itemCodeBlocks)
        {
            base.BuildContainerClassLocal(itemCodeBlocks);
        }

        protected override void BuildRead(CodeBlockNested b)
        {
            b
                .BlankLine()
                .AppendCode($"public void Read(BreastRadiologyDocument doc, IEnumerable<{FhirClassName}> components)")
                .OpenBrace()
                .AppendCode($"throw new NotImplementedException();")
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

        protected override void BuildWrite(CodeBlockNested b)
        {
            b
               .AppendCode($"public IEnumerable<{FhirClassName}> Write(BreastRadiologyDocument doc)")
               .OpenBrace()
               .AppendCode($"throw new NotImplementedException();")
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

        void BuildExtensionItemClass()
        {
            this.itemCode
                .SummaryOpen()
                .Summary($"Extension Item class for {this.extensionName}.")
                .SummaryClose()
                .AppendCode($"public class {ElementGetName}")
                .OpenBrace()
                .AppendCode($"// Properties")
                .DefineBlock(out CodeBlockNested extensionItemPropertiesBlock)
                .BlankLine()
                .SummaryOpen()
                .Summary($"Constructor")
                .SummaryClose()
                .AppendCode($"public {ElementGetName}()")
                .OpenBrace()
                .DefineBlock(out CodeBlockNested extensionItemConstructorBlock)
                .CloseBrace()

                .BlankLine()
                .AppendCode($"// Methods")
                .DefineBlock(out CodeBlockNested extensionItemMethodsBlock)
                .CloseBrace()
                ;
        }

        public override void Build()
        {
            Int32 max = CSMisc.ToMax(this.valueNode.ElementDefinition.Max);
            Int32 min = this.valueNode.ElementDefinition.Min.Value;
            base.BuildOne(valueNode.ElementDefinition.ElementId, min, max);
            this.BuildExtensionItemClass();
        }

        public BuildMemberExtensionComplex(DefineBase defineBase,
            ClassCodeBlocks codeBlocks,
            ElementTreeNode valueNode,
            String extensionName) :
            base(defineBase, codeBlocks)
        {
            this.extensionName = extensionName;
            this.valueNode = valueNode;
        }
    }
}
