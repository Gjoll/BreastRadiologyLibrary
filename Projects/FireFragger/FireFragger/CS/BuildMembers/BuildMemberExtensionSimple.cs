using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FireFragger.CS.BuildMembers
{
    internal class BuildMemberExtensionSimple : BuildMemberBase
    {
        String itemElementGetName;
        List<String> itemElementSetName = new List<String>();
        String extensionName;
        protected ElementTreeSlice extensionSlice;

        protected override string PropertyName => $"{this.extensionName.ToMachineName()}";
        protected override string ElementGetName => this.itemElementGetName;
        protected override IEnumerable<string> ElementSetNames => this.itemElementSetName;
        protected override string ContainerClassName => $"{this.extensionName.ToMachineName()}Collection";

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

            ElementTreeNode urlNode = extensionSlice.Nodes["url"];
            String extensionUrl = ((FhirUrl)urlNode.ElementDefinition.Fixed).Value;

            itemCodeBlocks.ClassProperties
                .AppendCode($"public const String ExtensionUrl = \"{extensionUrl}\";")
                ;
        }

        protected override void BuildRead(CodeBlockNested b)
        {
            b
               .BlankLine()
               .AppendCode($"public void Read(BreastRadiologyDocument doc, IEnumerable<{FhirClassName}> extensions)")
               .OpenBrace()
               .AppendCode($"List<Extension> myExtensions = extensions")
               .AppendCode($"    .Where((a) => String.Compare(a.Url, ExtensionUrl, true) == 0)")
               .AppendCode($"    .ToList()")
               .AppendCode($"    ;")
               .AppendCode($"List<Item> items = new List<Item>();")
               .AppendCode($"foreach (Extension myExtension in myExtensions)")
               .AppendCode($"    items.Add(new Item(({this.ElementGetName}) myExtension.Value));")
               .AppendCode($"this.SetAllItems(items);")
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
               .AppendCode($"foreach (Item item in this.GetAllItems())")
               .OpenBrace()
               .AppendCode($"yield return new Extension")
               .OpenBrace()
               .AppendCode($"Value = item.Value,")
               .AppendCode($"Url = ExtensionUrl")
               .CloseBrace(";")
               .CloseBrace()
               .CloseBrace()
               ;

            //this.writeBlock
            //    .AppendCode($"items.AddRange(this.{PropertyName}.Write(this.Doc));")
            //    ;
        }

        public override void Build()
        {
            Int32 max = CSMisc.ToMax(this.extensionSlice.ElementDefinition.Max);
            Int32 min = this.extensionSlice.ElementDefinition.Min.Value;

            ElementTreeNode valueNode = this.extensionSlice.Nodes["value[x]"];
            this.itemElementSetName.Clear();
            foreach (var type in valueNode.ElementDefinition.Type)
                itemElementSetName.Add(type.Code);
            this.itemElementGetName = (itemElementSetName.Count == 1) ? valueNode.ElementDefinition.Type[0].Code : "Element";

            base.BuildOne(extensionSlice.ElementDefinition.ElementId, min, max);
        }

        public BuildMemberExtensionSimple(DefineBase defineBase,
            ClassCodeBlocks codeBlocks,
            ElementTreeSlice extensionSlice,
            String extensionName) :
            base(defineBase, codeBlocks)
        {
            this.extensionSlice = extensionSlice;
            this.extensionName = extensionName;
        }
    }
}
