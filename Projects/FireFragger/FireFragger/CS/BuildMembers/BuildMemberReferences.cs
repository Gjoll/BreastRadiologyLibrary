using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FireFragger.CS.BuildMembers
{
    internal class BuildMemberReferences : BuildMemberBase
    {
        String fhirName;
        String sliceName;
        String itemElementGetName;
        List<String> itemElementSetName = new List<String>();
        List<String> targetProfiles = new List<string>();
        String containerClassName;
        CodeBlockNested readBlock;
        CodeBlockNested writeBlock;

        protected ElementTreeNode memberNode;
        protected override string PropertyName => $"{this.sliceName.ToMachineName()}";
        protected override string ElementGetName => this.itemElementGetName;
        protected override IEnumerable<string> ElementSetNames => this.itemElementSetName;
        protected override string ContainerClassName => this.containerClassName;

        /// <summary>
        /// Name of fhir element (as stored in resource).
        /// </summary>
        protected override String FhirClassName => "ResourceReference";

        /// <summary>
        /// Perform local processing of container class.
        /// </summary>
        protected override void BuildContainerClassLocal(ClassCodeBlocks itemCodeBlocks)
        {
            base.BuildContainerClassLocal(itemCodeBlocks);

            BuildTargeturls(itemCodeBlocks.ClassProperties, targetProfiles);
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
                .AppendCode($"public void Read(BreastRadiologyDocument doc, IEnumerable<{FhirClassName}> references)")
                .OpenBrace()
                .AppendCode("IEnumerable<ResourceBase> resources = base.IsMember(doc,")
                .AppendCode("    references,")
                .AppendCode("    this.targetUrls);")
                .AppendCode($"List<Item> items = new List<Item>();")
                .AppendCode($"foreach (ResourceBase resource in resources)")
                .OpenBrace()
                .AppendCode($"Item item = new Item();")
                .AppendCode($"item.Value = ({this.itemElementGetName}) resource;")
                .AppendCode($"items.Add(item);")
                .CloseBrace()
                .AppendCode($"this.SetAllItems(items);")
                .CloseBrace()
                ;

            this.readBlock
                .AppendCode($"this.{PropertyName}.Read(this.Doc, items);")
                ;
        }

        protected override void BuildContainerWrite(CodeBlockNested b)
        {
            b
               .AppendCode($"public IEnumerable<{FhirClassName}> Write(BreastRadiologyDocument doc)")
               .OpenBrace()
               .AppendCode($"foreach (Item item in this.GetAllItems())")
               .OpenBrace()
               .AppendCode($"{FhirClassName} reference = new {FhirClassName}")
               .OpenBrace()
               .AppendCode($"Reference = item.Value.Id")
               .CloseBrace(";")
               .AppendCode($"yield return reference;")
               .CloseBrace()
               .CloseBrace()
               ;

            this.writeBlock
                .AppendCode($"items.AddRange(this.{PropertyName}.Write(this.Doc));")
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
            String readBlockName = $"ReadHasMembers";
            String writeBlockName = $"WriteHasMembers";
            String referenceBlockName = $"!HasMembers";
            CodeBlockNested memberBlock = this.codeBlocks.ClassMethods.Find(referenceBlockName, false);
            if (memberBlock == null)
            {
                this.codeBlocks.ClassMethods
                    .BlankLine()
                    .StartBlock(referenceBlockName)

                    .BlankLine()
                    .SummaryOpen()
                    .Summary($"Read all values from resource into this instance")
                    .SummaryClose()
                    .AppendCode($"private void ReadHasMembers(BreastRadiologyDocument doc)")
                    .OpenBrace()
                    .AppendCode($"List<{FhirClassName}> items = this.Resource.GetValue<{FhirClassName}>(\"hasMember\").ToList();")
                    .DefineBlock(out this.readBlock, readBlockName)
                    .CloseBrace()

                    .BlankLine()
                    .SummaryOpen()
                    .Summary($"Write all values from this instance into resource")
                    .SummaryClose()
                    .AppendCode($"private void WriteHasMembers(BreastRadiologyDocument doc)")
                    .OpenBrace()
                    .AppendCode($"List<{FhirClassName}> items = new List<{FhirClassName}>();")
                    .DefineBlock(out this.writeBlock, writeBlockName)
                    .AppendCode($"this.Resource.SetValue(\"hasMember\", items);")
                    .CloseBrace()
                    .EndBlock()
                    ;
            }
            else
            {
                this.readBlock = memberBlock.Find(readBlockName);
                this.writeBlock = memberBlock.Find(writeBlockName);
            }

            if (this.codeBlocks.ClassWriteCode.Find("!WriteHasMembers") == null)
            {
                this.codeBlocks.ClassWriteCode
                .StartBlock("!WriteHasMembers")
                .AppendCode($"this.WriteHasMembers(this.Doc);")
                .EndBlock()
                ;
            }

            if (this.codeBlocks.ClassReadCode.Find("!ReadHasMembers") == null)
            {
                this.codeBlocks.ClassReadCode
                    .StartBlock("!ReadHasMembers")
                    .AppendCode($"this.ReadHasMembers(this.Doc);")
                    .EndBlock()
                    ;
            }

            foreach (ElementTreeSlice memberSlice in this.memberNode.Slices.Skip(1))
            {
                ElementDefinition sliceDef = memberSlice.ElementDefinition;
                this.sliceName = sliceDef.SliceName;

                Int32 max = CSMisc.ToMax(sliceDef.Max);
                Int32 min = sliceDef.Min.Value;
                this.sliceName = this.sliceName.ToMachineName();

                if ((sliceDef.Type.Count != 1) || (sliceDef.Type[0].Code != "Reference"))
                    throw new Exception($"Invalid reference types");
                this.itemElementSetName.Clear();
                this.targetProfiles.Clear();
                foreach (String profile in sliceDef.Type[0].TargetProfile)
                {
                    this.targetProfiles.Add(profile);
                    String propertyClassName = CSMisc.ResourceClassName(profile);
                    this.itemElementSetName.Add(propertyClassName);
                }

                this.containerClassName = $"{this.sliceName.ToMachineName()}Container";
                this.itemElementGetName = (itemElementSetName.Count == 1) ? itemElementSetName [0] : "ResourceBase";
                base.BuildOne(memberSlice.ElementDefinition.ElementId, min, max);
            }
        }

        public BuildMemberReferences(DefineBase defineBase,
            ClassCodeBlocks codeBlocks,
            ElementTreeNode memberNode) : 
            base(defineBase, codeBlocks)
        {
            this.memberNode = memberNode;
            this.fhirName = memberNode.ElementDefinition.Path.LastPathPart();
        }
    }
}
