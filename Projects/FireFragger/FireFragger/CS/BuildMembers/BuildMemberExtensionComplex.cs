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
        protected override string ElementGetName => this.extensionName;
        protected override IEnumerable<string> ElementSetNames => new String[] { this.extensionName };
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
            String extensionUrl = ((FhirUri)urlNode.ElementDefinition.Fixed).Value;
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
                .AppendCode($"throw new NotImplementedException();")
                //.AppendCode($"IEnumerable<Extension> extensions = base.IsMember(doc,")
                //.AppendCode($"    extensions,")
                //.AppendCode($"    ExtensionUrl);")
                //.AppendCode($"List<Item> items = new List<Item>();")
                //.AppendCode($"foreach (Extension extension in extensions)")
                //.OpenBrace()
                //.AppendCode($"    Item item = new Item();")
                //.AppendCode($"    item.Read(extension);")
                //.AppendCode($"    items.Add(item);")
                //.CloseBrace()
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
               //.AppendCode($"{FhirClassName} extension = new {FhirClassName}")
               //.OpenBrace()
               //.AppendCode($"Url = ExtensionUrl")
               //.CloseBrace(";")
               //.AppendCode($"extension.Extension.AddRange(item.Value.Write(doc));")
               //.AppendCode($"yield return extension;")
               //.CloseBrace()
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
                .SummaryOpen()
                .Summary($"Extension class for {this.extensionName}.")
                .SummaryClose()
                .AppendCode($"public class {ElementGetName}")
                .OpenBrace()
                .AppendCode($"// Definitions")
                .DefineBlock(out itemClassBlocks.LocalClassDefs)
                .AppendCode($"// Properties")
                .DefineBlock(out itemClassBlocks.ClassProperties)
                .BlankLine()
                .SummaryOpen()
                .Summary($"Constructor")
                .SummaryClose()
                .AppendCode($"public {ElementGetName}()")
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
                .AppendCode($"public IEnumerable<{FhirClassName}> Write(BreastRadiologyDocument doc)")
                .OpenBrace()
                .AppendCode($"List<Extension> items = new List<Extension>();")
                .DefineBlock(out itemClassBlocks.ClassWriteCode)
                .AppendCode($"yield return new {FhirClassName}")
                .OpenBrace()
                .AppendCode($"Url = ExtensionUrl,")
                .AppendCode($"Extension = items")
                .CloseBrace(";")
                .CloseBrace()

                .BlankLine()
                .SummaryOpen()
                .Summary("Read from fhir element into member item.")
                .SummaryClose()
                .AppendCode($"public void Read(BreastRadiologyDocument doc, IEnumerable<{FhirClassName}> extensions)")
                .OpenBrace()
                .DefineBlock(out itemClassBlocks.ClassReadCode)
                .CloseBrace()

                .CloseBrace()
                ;

            ElementTreeNode extension = this.extensionSlice.Nodes.GetItem("extension");
            foreach (var extensionSlice in extension.Slices.Skip(1))
            {
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
            base.BuildOne(extensionName, min, max);
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
