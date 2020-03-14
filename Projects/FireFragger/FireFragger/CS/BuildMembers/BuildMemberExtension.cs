using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace FireFragger.CS.BuildMembers
{
    /// <summary>
    /// </summary>
    internal abstract class BuildMemberExtension
    {
        protected Builder csBuilder => this.defineBase.CSBuilder;
        protected DefineBase defineBase;
        protected ClassCodeBlocks codeBlocks;
        protected ElementTreeNode memberNode;

        public BuildMemberExtension(DefineBase defineBase,
            ClassCodeBlocks codeBlocks,
            ElementTreeNode extensionNode)
        {
            this.defineBase = defineBase;
            this.codeBlocks = codeBlocks;
            this.memberNode = extensionNode;
        }

        void BuildOneComplexExtension()
        {
        }

        void BuildOneSimpleExtension(ElementTreeNode valueXNode)
        {
            BuildMemberExtensionSimple bm = new BuildMemberExtensionSimple(this.defineBase,
                this.codeBlocks,
                valueXNode);
            bm.Build();
        }

        public void BuildOne(ElementTreeSlice extensionSlice)
        {
            //$ TODO: Implement validation
            const String fcn = "BuildSlice";

            if (extensionSlice.Nodes.TryGetItem("value[x]", out ElementTreeNode valueXNode) == false)
            {
                this.csBuilder.ConversionError(this.GetType().Name,
                       fcn,
                       $"Unimplemented code. value[x] not found");
                return;
            }

            if (extensionSlice.Nodes.TryGetItem("extension", out ElementTreeNode subExtensionNode) == false)
                throw new Exception($"extension.extension is missing");
            Int32 valueXCardMax = CSMisc.ToMax(valueXNode.ElementDefinition.Max);

            if ((valueXCardMax != 0) && (subExtensionNode.Slices.Count > 1))
            {
                // Cant build both simple and complex extension.
                throw new Exception($"Both Simple and Complex extension found. Not implemented");
            }
            else if ((valueXCardMax == 0) && (subExtensionNode.Slices.Count == 0))
            {
                // Neither simple and complex extension?
                throw new Exception($"Neither Simple and Complex extension found. Not implemented");
            }
            else if (valueXCardMax != 0)
            {
                // Build Simple Extension
                BuildOneSimpleExtension(valueXNode);
            }
            else
            {
                // Build Complex Extension
                BuildOneComplexExtension();
            }
        }

        public void Build()
        {
            foreach (ElementTreeSlice memberSlice in this.memberNode.Slices.Skip(1))
                BuildOne(memberSlice);
        }
    }
}
