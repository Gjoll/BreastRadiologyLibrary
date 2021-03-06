﻿using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FireFragger.CS.BuildMembers
{
    internal class BuildMemberComponents : BuildMemberBase
    {
        String fhirName;
        String sliceName;
        String itemElementGetName;
        List<String> itemElementSetName = new List<String>();
        String containerClassName;
        String componentCodeMethodName;
        CodeableConcept componentCode;
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
        protected override String FhirClassName => "Observation.ComponentComponent";

        /// <summary>
        /// Perform local processing of container class.
        /// </summary>
        protected override void BuildContainerClassLocal(ClassCodeBlocks itemCodeBlocks)
        {
            base.BuildContainerClassLocal(itemCodeBlocks);

            this.componentCodeMethodName = $"{this.sliceName.ToMachineName()}_ComponentCode";
            FhirConstruct.Construct(itemCodeBlocks.ClassMethods,
                this.componentCode,
                this.componentCodeMethodName, 
                out String dummy,
                "private static");
        }

        protected override void BuildItemRead(CodeBlockNested b)
        {
            b
                .AppendCode($"this.Value = ({this.ElementGetName}) item.Value;")
                ;
        }

        protected override void BuildItemWrite(CodeBlockNested b)
        {
            b
                .AppendCode($"{this.FhirClassName} retVal = new {this.FhirClassName}")
                .OpenBrace()
                .AppendCode($"Value = this.Value,")
                .AppendCode($"Code = {this.componentCodeMethodName}()")
                .CloseBrace(";")
                ;
        }


        protected override void BuildContainerRead(CodeBlockNested b)
        {
            b
                .BlankLine()
                .AppendCode($"public void Read(BreastRadiologyDocument doc, IEnumerable<{this.FhirClassName}> components)")
                .OpenBrace()
                .AppendCode($"IEnumerable<Observation.ComponentComponent> memberComponents = base.IsMember(doc,")
                .AppendCode($"    components,")
                .AppendCode($"    {this.componentCodeMethodName}());")
                .AppendCode($"List<Item> items = new List<Item>();")
                .AppendCode($"foreach (Observation.ComponentComponent memberComponent in memberComponents)")
                .OpenBrace()
                .AppendCode($"Item item = new Item();")
                .AppendCode($"item.ReadItem(doc, memberComponent);")
                .AppendCode($"items.Add(item);")
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
               .AppendCode($"public IEnumerable<{this.FhirClassName}> Write(BreastRadiologyDocument doc)")
               .OpenBrace()
               .AppendCode($"foreach (Item item in this.GetAllItems())")
               .OpenBrace()
               .AppendCode($"{this.FhirClassName} component = item.WriteItem(doc);")
               .AppendCode($"yield return component;")
               .CloseBrace()
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
            // dont have duplicate Read/Write Components methods.
            // component block may have been defined in a class merged into this one,
            // so check to see if it exists.
            String readBlockName = $"ReadComponents";
            String writeBlockName = $"WriteComponents";
            String componentBlockName = $"!Components";
            CodeBlockNested componentBlock = this.codeBlocks.ClassMethods?.Find(componentBlockName, false);
            if (componentBlock == null)
            {
                this.codeBlocks.ClassMethods
                    .BlankLine()
                    .StartBlock(componentBlockName)

                    .BlankLine()
                    .SummaryOpen()
                    .Summary($"Read all component values from resource into this instance")
                    .SummaryClose()
                    .AppendCode($"private void ReadComponents(BreastRadiologyDocument doc)")
                    .OpenBrace()
                    .AppendCode($"List<{this.FhirClassName}> items = this.Resource.GetValue<{this.FhirClassName}>(\"{this.fhirName}\").ToList();")
                    .DefineBlock(out this.readBlock, readBlockName)
                    .CloseBrace()

                    .BlankLine()
                    .SummaryOpen()
                    .Summary($"Write all values from this instance into resource")
                    .SummaryClose()
                    .AppendCode($"private void WriteComponents(BreastRadiologyDocument doc)")
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
                this.readBlock = componentBlock.Find(readBlockName);
                this.writeBlock = componentBlock.Find(writeBlockName);
            }

            if (this.codeBlocks.ClassWriteCode.Find("!WriteComponents") == null)
            {
                this.codeBlocks.ClassWriteCode
                .StartBlock("!WriteComponents")
                .AppendCode($"this.WriteComponents(this.Doc);")
                .EndBlock()
                ;
            }

            if (this.codeBlocks.ClassReadCode.Find("!ReadComponents") == null)
            {
                this.codeBlocks.ClassReadCode
                    .StartBlock("!ReadComponents")
                    .AppendCode($"this.ReadComponents(this.Doc);")
                    .EndBlock()
                    ;
            }

            foreach (ElementTreeSlice memberSlice in this.memberNode.Slices.Skip(1))
            {
                this.sliceName = memberSlice.ElementDefinition.SliceName;

                ElementTreeNode valueNode = memberSlice.Nodes.GetItem("value[x]");
                ElementTreeNode codeNode = memberSlice.Nodes.GetItem("code");

                this.componentCode = (CodeableConcept)codeNode.ElementDefinition.Fixed;
                if (this.componentCode == null)
                    this.componentCode = (CodeableConcept)codeNode.ElementDefinition.Pattern;
                if (this.componentCode == null)
                    throw new Exception("Missing {this.fhirName}.code fixed value");

                ElementDefinition sliceDef = memberSlice.ElementDefinition;
                Int32 max = CSMisc.ToMax(sliceDef.Max);
                Int32 min = sliceDef.Min.Value;
                this.sliceName = this.sliceName.ToMachineName();

                this.itemElementSetName.Clear();
                foreach (var type in valueNode.ElementDefinition.Type)
                    this.itemElementSetName.Add(type.Code);

                this.containerClassName = $"M{this.sliceName.ToMachineName()}";
                this.itemElementGetName = (this.itemElementSetName.Count == 1) ? valueNode.ElementDefinition.Type[0].Code : "Element";
                base.BuildOne(memberSlice.ElementDefinition.ElementId, min, max);
            }
        }

        public BuildMemberComponents(DefineBase defineBase,
            ClassCodeBlocks codeBlocks,
            ElementTreeNode componentNode) : 
            base(defineBase, codeBlocks)
        {
            this.memberNode = componentNode;
            this.fhirName = this.memberNode.ElementDefinition.Path.LastPathPart();
        }
    }
}
