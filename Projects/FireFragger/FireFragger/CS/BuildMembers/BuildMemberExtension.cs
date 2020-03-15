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
    internal class BuildMemberExtension
    {
        protected Builder csBuilder => this.defineBase.CSBuilder;
        protected DefineBase defineBase;
        protected ClassCodeBlocks codeBlocks;
        protected ElementTreeNode memberNode;
        String extensionName;

        public BuildMemberExtension(DefineBase defineBase,
            ClassCodeBlocks codeBlocks,
            ElementTreeNode extensionNode,
            String extensionName)
        {
            this.extensionName = extensionName;
            this.defineBase = defineBase;
            this.codeBlocks = codeBlocks;
            this.memberNode = extensionNode;
        }

        void BuildOneComplexExtension(String extensionName)
        {
            BuildMemberExtensionComplex bm = new BuildMemberExtensionComplex(this.defineBase,
                this.codeBlocks,
                this.memberNode,
                extensionName);
            bm.Build();
        }

        void BuildOneSimpleExtension(ElementTreeNode valueXNode)
        {
            BuildMemberExtensionSimple bm = new BuildMemberExtensionSimple(this.defineBase,
                this.codeBlocks,
                valueXNode);
            bm.Build();
        }

        /// <summary>
        /// Build a class to implement an extension.
        /// This determines if a simple extension is to be defined,
        /// or a complex extension.
        /// </summary>
        public void Build()
        {
            //$ TODO: Implement validation
            //const String fcn = "BuildSlice";

            ElementTreeNode valueXNode = memberNode.GetChild("value[x]");
            ElementTreeNode subExtensionNode = memberNode.GetChild("extension");
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
                BuildOneComplexExtension(extensionName);
            }
        }
    }
}
