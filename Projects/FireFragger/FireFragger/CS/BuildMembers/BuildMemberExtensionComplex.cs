﻿using FhirKhit.Tools;
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
            ClassCodeBlocks itemClassBlocks = new ClassCodeBlocks();

            this.itemCode
                .SummaryOpen()
                .Summary($"Extension Item class for {this.extensionName}.")
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
