using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FireFragger.CS.BuildMembers
{
    /// <summary>
    /// </summary>
    internal abstract class BuildMemberBase
    {
        protected Builder csBuilder => this.defineBase.CSBuilder;
        protected DefineBase defineBase;
        protected ClassCodeBlocks codeBlocks;
        protected CodeBlockNested containerCode;
        protected CodeBlockNested itemCode;

        /// <summary>
        /// true if cardinality is 0..1 or 1..1. False if max is > 1.
        /// </summary>
        protected abstract bool Single { get; }

        /// <summary>
        /// Name of class that acesses a .
        /// </summary>
        protected abstract String ItemClassName { get; }

        /// <summary>
        /// Name of each item
        /// </summary>
        protected abstract String ItemElementName { get; }
        protected abstract String ContainerClassName { get; }

        protected String elementId;

        public BuildMemberBase(DefineBase defineBase,
            ClassCodeBlocks codeBlocks,
            String elementId)
        {
            this.defineBase = defineBase;
            this.codeBlocks = codeBlocks;
            this.elementId = elementId;
        }

        void BuildItemClass()
        {
            this.containerCode
                .SummaryOpen()
                .Summary($"Item class for {this.elementId}.")
                .SummaryClose()
                .AppendCode($"public class Item")
                .OpenBrace()
                .CloseBrace()
                ;
        }

        void BuildContainerClass()
        {
            this.containerCode
                .SummaryOpen()
                .Summary($"Container class for {this.elementId}.")
                .SummaryClose()
                .AppendCode($"public class {this.ContainerClassName}")
                .OpenBrace()
                .DefineBlock(out this.itemCode)
                .CloseBrace()
                ;
        }


        public virtual void Build()
        {
            this.containerCode = this.codeBlocks.LocalClassDefs.AppendBlock();
            BuildContainerClass();
            BuildItemClass();
        }

    }
}
