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
        protected ElementTreeSlice extensionSlice;

        protected override string PropertyName => $"{this.extensionName.ToMachineName()}";
        protected override string ElementGetName => "Members";
        protected override IEnumerable<string> ElementSetNames => new String[] { "Members" };
        protected override string ContainerClassName => $"M{this.extensionName.ToMachineName()}";

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

            ElementTreeNode urlNode = this.extensionSlice.Nodes["url"];
            String extensionUrl = ((FhirUri)urlNode.ElementDefinition.Fixed).Value;
            itemCodeBlocks.ClassProperties
                .AppendCode($"public const String ExtensionUrl = \"{extensionUrl}\";")
                ;
        }

        protected override void BuildItemRead(CodeBlockNested b)
        {
            b
                .BlankLine()
                .AppendCode($"public void ReadItem(BreastRadiologyDocument doc, {this.FhirClassName} extension)")
                .OpenBrace()
                .AppendCode("this.Value = new Members();")
                .AppendCode("this.Value.ReadMember(doc, extension);")
                .CloseBrace()
                ;
        }

        protected override void BuildItemWrite(CodeBlockNested b)
        {
            b
                .BlankLine()
                .AppendCode($"public Extension WriteItem(BreastRadiologyDocument doc)")
                .OpenBrace()
                .DefineBlock(out this.itemCodeBlocks.ClassWriteCode)
                .AppendCode("return this.Value.WriteMember(doc);")
                .CloseBrace()
                ;
        }

        protected override void BuildContainerRead(CodeBlockNested b)
        {
            b
                .BlankLine()
                .AppendCode($"public void Read(BreastRadiologyDocument doc, IEnumerable<{this.FhirClassName}> extensions)")
                .OpenBrace()
                .DefineBlock(out this.itemCodeBlocks.ClassReadCode)
                .AppendCode($"IEnumerable<Extension> memberExtensions = base.IsMember(doc,")
                .AppendCode($"    extensions,")
                .AppendCode($"    ExtensionUrl);")
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

            //this.readBlock
            //    .AppendCode($"this.{PropertyName}.Read(this.Doc, items);")
            //    ;
        }

        protected override void BuildContainerWrite(CodeBlockNested b)
        {
            b
               .AppendCode($"public IEnumerable<{this.FhirClassName}> Write(BreastRadiologyDocument doc)")
               .OpenBrace()
               .AppendCode($"foreach (Item item in this.GetAllItems())")
               .AppendCode($"    yield return item.WriteItem(doc);")
               .CloseBrace()
               ;

            //this.writeBlock
            //    .AppendCode($"items.AddRange(this.{PropertyName}.Write(this.Doc));")
            //    ;
        }

        void BuildExtensionItemClass()
        {
            ClassCodeBlocks itemClassBlocks = new ClassCodeBlocks();

            this.itemCode
                .AppendCode($"#region {this.pathName} Member Class")
                .SummaryOpen()
                .Summary($"Extension class for {this.extensionName}.")
                .SummaryClose()
                .AppendCode($"public class {this.ElementGetName}")
                .OpenBrace()
                .AppendCode($"// Definitions")
                .DefineBlock(out itemClassBlocks.LocalClassDefs)
                .AppendCode($"// Properties")
                .DefineBlock(out itemClassBlocks.ClassProperties)
                .BlankLine()
                .SummaryOpen()
                .Summary($"Constructor")
                .SummaryClose()
                .AppendCode($"public {this.ElementGetName}()")
                .OpenBrace()
                .DefineBlock(out itemClassBlocks.ClassConstructor)
                .CloseBrace()

                .BlankLine()
                .AppendCode($"// Methods")
                .DefineBlock(out itemClassBlocks.ClassMethods)

                .BlankLine()
                .SummaryOpen()
                .Summary("Write item as a fhir element.")
                .SummaryClose()
                .AppendCode($"public Extension WriteMember(BreastRadiologyDocument doc)")
                .OpenBrace()
                .AppendCode($"List<Extension> items = new List<Extension>();")
                .DefineBlock(out itemClassBlocks.ClassWriteCode)
                .AppendCode($"return new {this.FhirClassName}")
                .OpenBrace()
                .AppendCode($"Url = ExtensionUrl,")
                .AppendCode($"Extension = items")
                .CloseBrace(";")
                .CloseBrace()

                .BlankLine()
                .SummaryOpen()
                .Summary("Read from fhir element into member item.")
                .SummaryClose()
                .AppendCode($"public void ReadMember(BreastRadiologyDocument doc, Extension extension)")
                .OpenBrace()
                .AppendCode($"if (extension.Url != ExtensionUrl)")
                .AppendCode($"    throw new Exception($\"Invalid extension url '{{extension.Url}}', expected '{{ExtensionUrl}}'\");")
                .AppendCode($"List<Extension> extensions = extension.Extension;")
                .DefineBlock(out itemClassBlocks.ClassReadCode)
                .CloseBrace()

                .CloseBrace()
                .AppendCode($"#endregion")
                ;

            ElementTreeNode extension = this.extensionSlice.Nodes.GetItem("extension");
            foreach (var extensionSlice in extension.Slices.Skip(1))
            {
                itemClassBlocks.LocalUsings = this.codeBlocks.LocalUsings;
                BuildMemberExtension bm = new BuildMemberExtension(this.defineBase,
                    itemClassBlocks,
                    extensionSlice,
                    extensionSlice.ElementDefinition.SliceName);
                bm.Build();
            }
        }

        /// <summary>
        /// Child classes can overload this to do local processing of item class.
        /// </summary>
        protected override void BuildItemClassLocal(ClassCodeBlocks itemCodeBlocks)
        {
            base.BuildItemClassLocal(itemCodeBlocks);

        }

        public override void Build()
        {
            Int32 max = CSMisc.ToMax(this.extensionSlice.ElementDefinition.Max);
            Int32 min = this.extensionSlice.ElementDefinition.Min.Value;
            base.BuildOne(this.extensionName, min, max);
            this.BuildExtensionItemClass();
        }

        public BuildMemberExtensionComplex(DefineBase defineBase,
            ClassCodeBlocks codeBlocks,
            ElementTreeSlice extensionSlice,
            String extensionName) :
            base(defineBase, codeBlocks)
        {
            this.extensionName = extensionName;
            this.extensionSlice = extensionSlice;
        }
    }
}
