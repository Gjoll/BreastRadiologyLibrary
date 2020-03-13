using FhirKhit.Tools;
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
        String SliceName;
        String itemElementGetName;
        List<String> itemElementSetName = new List<String>();
        String containerClassName;
        String sliceName;
        String componentCodeMethodName;
        CodeableConcept componentCode;

        protected ElementTreeNode memberNode;

        protected override string ElementGetName => this.itemElementGetName;
        protected override IEnumerable<string> ElementSetNames => this.itemElementSetName;
        protected override string ContainerClassName => this.containerClassName;

        /// <summary>
        /// Name of fhir element (as stored in resource).
        /// </summary>
        protected override String FhirElementItemName => "Observation.ComponentComponent";

        /// <summary>
        /// Perform local processing of container class.
        /// </summary>
        protected override void BuildContainerClassLocal(CodeBlockNested containerConstructorBlock,
            CodeBlockNested containerPropertiesBlock,
            CodeBlockNested containerMethodsBlock)
        {
            base.BuildContainerClassLocal(containerConstructorBlock,
                containerPropertiesBlock,
                containerMethodsBlock);

            componentCodeMethodName = $"{sliceName.ToMachineName()}_ComponentCode";
            FhirConstruct.Construct(containerMethodsBlock, componentCode, componentCodeMethodName, out String dummy);
        }

        protected override void ReadItem(CodeBlockNested b)
        {
            b
                .AppendCode($"Item item = null;")
                .AppendCode($"if (element.Code.IsCode(this.{componentCodeMethodName}()))")
                .AppendCode($"    item = new Item(({this.ElementGetName}) element.Value);")
                .AppendCode($"return item;")
                ;
        }

        protected override void WriteItem(CodeBlockNested b)
        {
            b
            .AppendCode($"Value = item.Value,")
            .AppendCode($"Code = {componentCodeMethodName}()")
            ;
        }

        public override void Build()
        {
            if (this.memberNode.Slices.Count <= 1)
                return;

            // Block is marked with !, so the top level lines are not merged, so we
            // dont have duplicate Read/Write {this.fhirName} methods.
            // component block may have been defined in a class merged into this one,
            // so check to see if it exists.
            String readBlockName = $"Read{this.fhirName}";
            String writeBlockName = $"Write{this.fhirName}";
            String initBlockName = $"Init{this.fhirName}";
            String componentBlockName = $"!{this.fhirName}";
            CodeBlockNested componentBlock = this.codeBlocks.ClassMethods.Find(componentBlockName, false);
            //if (componentBlock == null)
            //{
            //    this.codeBlocks.ClassMethods
            //        .BlankLine()
            //        .StartBlock(componentBlockName)
            //        .SummaryOpen()
            //        .Summary($"Init all {this.fhirName} items")
            //        .SummaryClose()
            //        .AppendCode($"private void Init{this.fhirName}()")
            //        .OpenBrace()
            //        .DefineBlock(out initBlock, initBlockName)
            //        .CloseBrace()

            //        .BlankLine()
            //        .SummaryOpen()
            //        .Summary($"Read all component values from resource into this instance")
            //        .SummaryClose()
            //        .AppendCode($"private void Read{this.fhirName}(BreastRadiologyDocument doc)")
            //        .OpenBrace()
            //        .AppendCode($"List<Observation.ComponentComponent> items = this.Resource.GetValue<Observation.ComponentComponent>(\"component\").ToList();")
            //        .DefineBlock(out readBlock, readBlockName)
            //        .CloseBrace()

            //        .BlankLine()
            //        .SummaryOpen()
            //        .Summary($"Write all component values from this instance into resource")
            //        .SummaryClose()
            //        .AppendCode($"private void Write{this.fhirName}(BreastRadiologyDocument doc)")
            //        .OpenBrace()
            //        .AppendCode($"List<Observation.ComponentComponent> items = new List<Observation.ComponentComponent>();")
            //        .DefineBlock(out writeBlock, writeBlockName)
            //        .AppendCode($"this.Resource.SetValue(\"component\", items);")
            //        .CloseBrace()
            //        .EndBlock()
            //        ;
            //}
            //else
            //{
            //    this.initBlock = componentBlock.Find(initBlockName);
            //    this.readBlock = componentBlock.Find(readBlockName);
            //    this.writeBlock = componentBlock.Find(writeBlockName);
            //    Debug.Assert(this.writeBlock != null);
            //    Debug.Assert(this.readBlock != null);
            //    Debug.Assert(this.initBlock != null);
            //}

            //if (this.codeBlocks.ClassWriteCode.Find("!Write{this.fhirName}") == null)
            //{
            //    this.codeBlocks.ClassWriteCode
            //    .StartBlock("!Write{this.fhirName}")
            //    .AppendCode($"this.Write{this.fhirName}(doc);")
            //    .EndBlock()
            //    ;
            //}

            //if (this.codeBlocks.ClassReadCode.Find("!Read{this.fhirName}") == null)
            //{
            //    this.codeBlocks.ClassReadCode
            //        .StartBlock("!Read{this.fhirName}")
            //        .AppendCode($"this.Read{this.fhirName}(doc);")
            //        .EndBlock()
            //        ;
            //}

            foreach (ElementTreeSlice memberSlice in this.memberNode.Slices.Skip(1))
            {
                this.sliceName = memberSlice.ElementDefinition.SliceName;

                if (memberSlice.Nodes.TryGetItem("value[x]", out ElementTreeNode valueNode) == false)
                    throw new Exception("{this.fhirName} missing value[x] node");
                if (memberSlice.Nodes.TryGetItem("code", out ElementTreeNode codeNode) == false)
                    throw new Exception("{this.fhirName} missing code node");

                componentCode = (CodeableConcept)codeNode.ElementDefinition.Fixed;
                if (componentCode == null)
                    componentCode = (CodeableConcept)codeNode.ElementDefinition.Pattern;
                if (componentCode == null)
                    throw new Exception("Missing {this.fhirName}.code fixed value");

                ElementDefinition sliceDef = memberSlice.ElementDefinition;
                Int32 max = CSMisc.ToMax(sliceDef.Max);
                Int32 min = sliceDef.Min.Value;
                this.SliceName = sliceName.ToMachineName();

                this.itemElementSetName = new List<String>();
                foreach (var type in valueNode.ElementDefinition.Type)
                    itemElementSetName.Add(type.Code);

                this.containerClassName = $"{this.SliceName}Container";
                this.itemElementGetName = (itemElementSetName.Count == 1) ? valueNode.ElementDefinition.Type[0].Code : "Element";
                base.BuildOne(min, max);

                //String localClassName =
                //    this.DefineLocalContainerClass(memberSlice,
                //    componentCode,
                //    min,
                //    max,
                //    propertyName,
                //    valueNode);

                //this.DefineProperty(localClassName,
                //    max,
                //    min,
                //    propertyName,
                //    types.ToArray());
            }
        }

        public BuildMemberComponents(DefineBase defineBase,
            ClassCodeBlocks codeBlocks,
            ElementTreeNode componentNode) : 
            base(defineBase, codeBlocks, componentNode.ElementDefinition.ElementId)
        {
            this.memberNode = componentNode;
            this.fhirName = memberNode.ElementDefinition.Path.LastPathPart().ToMachineName();
        }
    }
}
