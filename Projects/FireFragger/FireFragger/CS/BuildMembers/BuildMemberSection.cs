using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FireFragger.CS.BuildMembers
{
    internal class BuildMemberSection : BuildMemberBase
    {
        String fhirName;
        String sliceName;
        String itemElementGetName;
        List<String> itemElementSetName = new List<String>();
        String containerClassName;
        String sectionCodeMethodName;
        CodeableConcept sectionCode;
        CodeBlockNested readBlock;
        CodeBlockNested writeBlock;
        String title;

        protected ElementTreeNode memberNode;

        protected override string PropertyName => $"{this.sliceName.ToMachineName()}";
        protected override string ElementGetName => this.itemElementGetName;
        protected override IEnumerable<string> ElementSetNames => this.itemElementSetName;
        protected override string ContainerClassName => this.containerClassName;

        /// <summary>
        /// Name of fhir element (as stored in resource).
        /// </summary>
        protected override String FhirClassName => "Composition.SectionComponent";

        /// <summary>
        /// Name of fhir item class. Usually the same as the FhirClassName.
        /// </summary>
        protected override String ItemClassName => "ResourceReference";

        /// <summary>
        /// Perform local processing of container class.
        /// </summary>
        protected override void BuildContainerClassLocal(ClassCodeBlocks itemCodeBlocks)
        {
            base.BuildContainerClassLocal(itemCodeBlocks);

            this.sectionCodeMethodName = $"SectionCode";
            FhirConstruct.Construct(itemCodeBlocks.ClassMethods, this.sectionCode, this.sectionCodeMethodName, out String dummy);
        }

        protected override void BuildItemRead(CodeBlockNested b)
        {
            b
                .AppendCode($"this.Value = ({this.ElementGetName}) doc.GetResource(item);")
                ;
        }

        protected override void BuildItemWrite(CodeBlockNested b)
        {
            b
                .AppendCode($"ResourceReference retVal = new ResourceReference")
                .OpenBrace()
                .AppendCode($"Reference = this.Value.Id")
                .CloseBrace(";")
                ;
        }

        protected override void BuildContainerRead(CodeBlockNested b)
        {
            b
                .BlankLine()
                .AppendCode($"public void Read(BreastRadiologyDocument doc, IEnumerable<Composition.SectionComponent> sections)")
                .OpenBrace()
                .AppendCode($"IEnumerable<Composition.SectionComponent> memberSections = base.IsMember(doc,")
                .AppendCode($"    sections,")
                .AppendCode($"    {this.sectionCodeMethodName}());")
                .AppendCode($"List<Item> items = new List<Item>();")
                .AppendCode($"// There really should only ever be one section...")
                .AppendCode($"foreach (Composition.SectionComponent memberSection in memberSections)")
                .OpenBrace()
                .AppendCode($"foreach (ResourceReference entryRef in memberSection.Entry)")
                .OpenBrace()
                .AppendCode($"Item item = new Item();")
                .AppendCode($"item.ReadItem(doc, entryRef);")
                .AppendCode($"items.Add(item);")
                .CloseBrace()
                .CloseBrace()
                .AppendCode($"this.SetAllItems(items);")
                .CloseBrace()
                ;

            this.readBlock
                .AppendCode($"this.{this.PropertyName}.Read(this.Doc, items);")
                ;
        }

        protected override void BuildContainerWrite(CodeBlockNested b)
        {
            b
                .AppendCode("public IEnumerable<Composition.SectionComponent> Write(BreastRadiologyDocument doc)")
                .OpenBrace()
                .AppendCode($"Composition.SectionComponent section = new Composition.SectionComponent")
                .OpenBrace()
                .AppendCode($"Title = \"{this.title}\",")
                .AppendCode($"Code = {this.sectionCodeMethodName}()")
                .CloseBrace(";")
                .AppendCode($"foreach (Item item in this.GetAllItems())")
                .OpenBrace()
                .AppendCode($"section.Entry.Add(item.WriteItem(doc));")
                .CloseBrace()
                .AppendCode($"return new Composition.SectionComponent[] {{ section }};")
                .CloseBrace()
               ;

            this.writeBlock
                .AppendCode($"items.AddRange(this.{this.PropertyName}.Write(this.Doc));")
                ;
        }

        public override void Build()
        {
            if (this.memberNode.Slices.Count <= 1)
                return;

            // Block is marked with !, so the top level lines are not merged, so we
            // dont have duplicate Read/Write methods.
            // block may have been defined in a class merged into this one,
            // so check to see if it exists.
            String readBlockName = $"ReadSections";
            String writeBlockName = $"WriteSections";
            String sectionBlockName = $"!Sections";
            CodeBlockNested sectionBlock = this.codeBlocks.ClassMethods.Find(sectionBlockName, false);
            if (sectionBlock == null)
            {
                this.codeBlocks.ClassMethods
                    .BlankLine()
                    .StartBlock(sectionBlockName)

                    .BlankLine()
                    .SummaryOpen()
                    .Summary($"Read all values from resource into this instance")
                    .SummaryClose()
                    .AppendCode($"private void ReadSections(BreastRadiologyDocument doc)")
                    .OpenBrace()
                    .AppendCode($"List<{this.FhirClassName}> items = this.Resource.GetValue<{this.FhirClassName}>(\"{this.fhirName}\").ToList();")
                    .DefineBlock(out this.readBlock, readBlockName)
                    .CloseBrace()

                    .BlankLine()
                    .SummaryOpen()
                    .Summary($"Write all values from this instance into resource")
                    .SummaryClose()
                    .AppendCode($"private void WriteSections(BreastRadiologyDocument doc)")
                    .OpenBrace()
                    .AppendCode($"List<{this.FhirClassName}> items = new List<{this.FhirClassName}>();")
                    .DefineBlock(out this.writeBlock, writeBlockName)
                    .AppendCode($"this.Resource.SetValue(\"{this.fhirName}\", items);")
                    .CloseBrace()
                    .EndBlock()
                    ;
            }
            else
            {
                this.readBlock = sectionBlock.Find(readBlockName);
                this.writeBlock = sectionBlock.Find(writeBlockName);
            }

            if (this.codeBlocks.ClassWriteCode.Find("!WriteSections") == null)
            {
                this.codeBlocks.ClassWriteCode
                .StartBlock("!WriteSections")
                .AppendCode($"this.WriteSections(this.Doc);")
                .EndBlock()
                ;
            }

            if (this.codeBlocks.ClassReadCode.Find("!ReadSections") == null)
            {
                this.codeBlocks.ClassReadCode
                    .StartBlock("!ReadSections")
                    .AppendCode($"this.ReadSections(this.Doc);")
                    .EndBlock()
                    ;
            }

            foreach (ElementTreeSlice memberSlice in this.memberNode.Slices.Skip(1))
            {
                ElementDefinition memberDef = memberSlice.ElementDefinition;
                this.sliceName = memberDef.SliceName;

                ElementTreeNode entryNode = memberSlice.Nodes.GetItem("entry");
                ElementTreeNode titleNode = memberSlice.Nodes.GetItem("title");
                ElementTreeNode codeNode = memberSlice.Nodes.GetItem("code");

                this.sectionCode = (CodeableConcept)codeNode.ElementDefinition.Fixed;
                if (this.sectionCode == null)
                    this.sectionCode = (CodeableConcept)codeNode.ElementDefinition.Pattern;
                if (this.sectionCode == null)
                    throw new Exception("Missing section.code fixed value");

                this.title = ((FhirString)titleNode.ElementDefinition?.Fixed)?.Value;
                if (String.IsNullOrEmpty(this.title) == true)
                    throw new Exception("Section missing title value");

                ElementDefinition entryDef = entryNode.ElementDefinition;
                Int32 max = CSMisc.ToMax(entryDef.Max);
                Int32 min = entryDef.Min.Value;
                String propertyName = this.sliceName.ToMachineName();

                if (entryDef.Type.Count != 1)
                    throw new Exception($"Error processing slice {this.sliceName}. Expected single type. Got {entryDef.Type.Count}");
                if (entryDef.Type[0].Code != "Reference")
                    throw new Exception($"Error processing slice {this.sliceName}. Expected type Section. Got {entryDef.Type[0].Code}");

                this.itemElementSetName.Clear();
                foreach (String profile in entryDef.Type[0].TargetProfile)
                {
                    String propertyClassName = CSMisc.ResourceClassName(profile);
                    this.itemElementSetName.Add(propertyClassName);
                }

                this.containerClassName = $"M{this.sliceName.ToMachineName()}";
                this.itemElementGetName = (this.itemElementSetName.Count == 1) ? this.itemElementSetName[0] : "ResourceBase";
                base.BuildOne(memberDef.ElementId, min, max);
            }
        }

        public BuildMemberSection(DefineBase defineBase,
            ClassCodeBlocks codeBlocks,
            ElementTreeNode sectionNode) : 
            base(defineBase, codeBlocks)
        {
            this.memberNode = sectionNode;
            this.fhirName = this.memberNode.ElementDefinition.Path.LastPathPart();
        }
    }
}
