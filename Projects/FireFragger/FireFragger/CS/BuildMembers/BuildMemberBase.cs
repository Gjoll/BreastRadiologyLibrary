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
        protected String elementId;
        protected Int32 Min;
        protected Int32 Max;

        protected bool Singleton => this.Max == 1;

        /// <summary>
        /// Name of class that stored each item read/written.
        /// May be same as ItemElementName.
        /// </summary>
        protected abstract String FhirElementItemName { get; }

        /// <summary>
        /// Name of each item.
        /// </summary>
        protected abstract String ItemElementName { get; }

        /// <summary>
        /// Name of item container class.
        /// </summary>
        protected abstract String ContainerClassName { get; }

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
            this.itemCode
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
                .AppendCode($"public class {this.ContainerClassName} : MContainer, ITMItem<{FhirElementItemName}> ")
                .OpenBrace()
                .DefineBlock(out this.itemCode)
                .BlankLine()
                .AppendCode($"// Properties")
                .DefineBlock(out CodeBlockNested propertiesBlock)
                .BlankLine()
                .SummaryOpen()
                .Summary($"Constructor")
                .SummaryClose()
                .AppendCode($"public {this.ContainerClassName}(Int32 min, Int32 max) : base(\"{elementId}\", min, max)")
                .OpenBrace()
                .DefineBlock(out CodeBlockNested constructorBlock)
                .CloseBrace()
                .BlankLine()
                .AppendCode($"// Methods")
                .DefineBlock(out CodeBlockNested methodsBlock)
                .CloseBrace()
                ;

            if (this.Singleton)
            {
                propertiesBlock
                    .SummaryOpen()
                    .Summary($"Value")
                    .SummaryClose()
                    .AppendCode($"public {ItemElementName} Value {{ get; set; }}")

                    .BlankLine()
                    .SummaryOpen()
                    .Summary($"Count property")
                    .SummaryClose()
                    .AppendCode($"public override Int32 Count => this.Value == null ? 0 : 1;")
                    ;
            }
            else
            {
                propertiesBlock
                    .AppendCode($"List<{ItemElementName}> items = new List<{ItemElementName}>();")

                    .BlankLine()
                    .SummaryOpen()
                    .Summary($"Count property")
                    .SummaryClose()
                    .AppendCode($"public override Int32 Count => items.Count;")
                    ;
            }

            methodsBlock

               .BlankLine()
               .SummaryOpen()
               .Summary("Write out member item as a fhir element.")
               .SummaryClose()
               .AppendCode($"public IEnumerable<{FhirElementItemName}> Write(BreastRadiologyDocument doc)")
               .OpenBrace()
               .AppendCode($"throw new NotImplementedException();")
               //.AppendCode($"foreach ({propertyType} item in this.All())")
               //.OpenBrace()
               //.AppendCode($"{ClassItemName} c = new {ClassItemName}")
               //.OpenBrace()
               //.AppendCode($"Value = item,")
               //.AppendCode($"Code = {componentCodeMethodName}()")
               //.CloseBrace(";")
               //.AppendCode($"yield return c;")
               //.CloseBrace()
               .CloseBrace()

               .BlankLine()
               .SummaryOpen()
               .Summary("Read data from fhir element into member item.")
               .SummaryClose()
               .AppendCode($"public void Read(BreastRadiologyDocument doc, IEnumerable<{FhirElementItemName}> element)")
               .OpenBrace()
               .AppendCode($"throw new NotImplementedException();")
            //   .AppendCode($"List<{ClassItemName}> items = element")
            //   .AppendCode($"    .Where((a) => a.Code.IsCode(this.{componentCodeMethodName}()))")
            //   .AppendCode($"    .ToList()")
            //   .AppendCode($"    ;")
            //   ;

            //if (max == 1)
            //{
            //    methodsBlock
            //        .AppendCode($"switch (items.Count)")
            //        .OpenBrace()
            //        .AppendCode($"case 0:")
            //        .AppendCode($"    break;")
            //        .AppendCode($"case 1:")
            //        .AppendCode($"    this.value = ({propertyType}) items[0].Value;")
            //        .AppendCode($"    break;")
            //        .AppendCode($"default:")
            //        .AppendCode($"    throw new Exception(\"error reading component {sliceName}. Multiple items found for single element\");")
            //        .CloseBrace()
            //        ;
            //}
            //else
            //{
            //    methodsBlock
            //        .AppendCode($"this.values.Clear();")
            //        .AppendCode($"foreach ({ClassItemName} c in items)")
            //        .AppendCode($"    this.values.Add(({propertyType}) c.Value);")
            //        ;
            //}

            //methodsBlock
               .CloseBrace()
               ;
            ;
        }


        public virtual void BuildOne(Int32 min, Int32 max)
        {
            this.Min = min;
            this.Max = max;

            this.containerCode = this.codeBlocks.LocalClassDefs.AppendBlock();
            BuildContainerClass();
            BuildItemClass();
        }

        public abstract void Build();
    }
}
