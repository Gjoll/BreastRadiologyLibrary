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
        protected override void BuildContainerClassLocal(ClassCodeBlocks codeBlocks)
        {
            base.BuildContainerClassLocal(codeBlocks);

            ElementTreeNode urlNode = extensionSlice.Nodes["url"];
            String extensionUrl = ((FhirUri)urlNode.ElementDefinition.Fixed).Value;

            codeBlocks.ClassProperties
                .AppendCode($"public const String ExtensionUrl = \"{extensionUrl}\";")
                ;
        }

        protected override void BuildItemRead(CodeBlockNested b)
        {
            b
                .BlankLine()
                .AppendCode($"public void ReadItem(BreastRadiologyDocument doc, {FhirClassName} extension)")
                .OpenBrace()
                .AppendCode($"this.Value = ({this.ElementGetName}) extension.Value;")
                .CloseBrace()
                ;
        }

        protected override void BuildItemWrite(CodeBlockNested b)
        {
            b
                .BlankLine()
                .AppendCode($"public {FhirClassName} WriteItem(BreastRadiologyDocument doc)")
                .OpenBrace()
                .AppendCode($"return new Extension")
                .OpenBrace()
                .AppendCode($"Value = this.Value,")
                .AppendCode($"Url = ExtensionUrl")
                .CloseBrace(";")
                .CloseBrace()
                ;
        }

        protected override void BuildContainerRead(CodeBlockNested b)
        {
            b
               .BlankLine()
               .AppendCode($"public void Read(BreastRadiologyDocument doc, IEnumerable<{FhirClassName}> extensions)")
               .OpenBrace()
               .AppendCode($"List<Extension> memberExtensions = extensions")
               .AppendCode($"    .Where((a) => String.Compare(a.Url, ExtensionUrl, true) == 0)")
               .AppendCode($"    .ToList()")
               .AppendCode($"    ;")
               .AppendCode($"List<Item> items = new List<Item>();")
               .AppendCode($"foreach (Extension memberExtension in memberExtensions)")
               .OpenBrace()
               .AppendCode($"    Item item = new Item();")
               .AppendCode($"    item.ReadItem(doc, memberExtension);")
               .AppendCode($"    items.Add(item);")
               .CloseBrace()
               .AppendCode($"this.SetAllItems(items);")
               .CloseBrace()
               ;

            this.codeBlocks.ClassReadCode
                .AppendCode($"this.{PropertyName}.Read(doc, extensions);")
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
                .AppendCode($"items.AddRange(this.{PropertyName}.Write(doc));")
                ;
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
