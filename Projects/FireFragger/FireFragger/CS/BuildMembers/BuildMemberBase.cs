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
        /// Name of property type that we get (base of all set types)
        /// </summary>
        protected abstract String ElementGetName { get; }

        /// <summary>
        /// Names of each type that we can set. Must be implicit conversion to
        /// ElementGetName. Often is same as ElementGetName.
        /// </summary>
        protected abstract IEnumerable<String> ElementSetNames { get; }

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
                .AppendCode($"// Properties")
                .SummaryOpen()
                .Summary($"Value")
                .SummaryClose()
                .AppendCode($"public {ElementGetName} Value {{ get; set; }}")
                .DefineBlock(out CodeBlockNested itemPropertiesBlock)
                .BlankLine()
                .SummaryOpen()
                .Summary($"Constructor")
                .SummaryClose()
                .AppendCode($"public Item({ElementGetName} value)")
                .OpenBrace()
                .AppendCode($"this.Value = value;")
                .DefineBlock(out CodeBlockNested itemConstructorBlock)
                .CloseBrace()

                .BlankLine()
                .AppendCode($"// Methods")
                .DefineBlock(out CodeBlockNested itemMethodsBlock)
                .CloseBrace()
                ;


            BuildItemClassLocal(itemConstructorBlock,
                itemPropertiesBlock,
                itemMethodsBlock);
        }

        /// <summary>
        /// Child classes can overload this to do local processing of item class.
        /// </summary>
        protected virtual void BuildItemClassLocal(CodeBlockNested itemConstructorBlock,
            CodeBlockNested itemPropertiesBlock,
            CodeBlockNested itemMethodsBlock)
        {
        }

        protected abstract void WriteItem(CodeBlockNested b);
        protected abstract void ReadItem(CodeBlockNested b);

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
                .DefineBlock(out CodeBlockNested containerPropertiesBlock)
                .BlankLine()
                .SummaryOpen()
                .Summary($"Constructor")
                .SummaryClose()
                .AppendCode($"public {this.ContainerClassName}(Int32 min, Int32 max) : base(\"{elementId}\", min, max)")
                .OpenBrace()
                .DefineBlock(out CodeBlockNested containerConstructorBlock)
                .CloseBrace()
                .BlankLine()
                .AppendCode($"// Methods")
                .DefineBlock(out CodeBlockNested containerMethodsBlock)
                .CloseBrace()
                ;

            this.BuildContainerClassLocal(containerConstructorBlock,
                containerPropertiesBlock,
                containerMethodsBlock);

            if (this.Singleton)
            {
                containerPropertiesBlock
                    .BlankLine()
                    .SummaryOpen()
                    .Summary($"All Items")
                    .SummaryClose()
                    .AppendCode($"IEnumerable<Item> AllItems => new Item[] {{ this.item }};")

                    .BlankLine()
                    .SummaryOpen()
                    .Summary($"Item")
                    .SummaryClose()
                    .AppendCode($"Item item;")

                    .BlankLine()
                    .SummaryOpen()
                    .Summary($"Count property")
                    .SummaryClose()
                    .AppendCode($"public override Int32 Count => this.item == null ? 0 : 1;")

                    .BlankLine()
                    .SummaryOpen()
                    .Summary($"Get Item's Value")
                    .SummaryClose()
                    .AppendCode($"public {ElementGetName} Get()")
                    .OpenBrace()
                    .AppendCode($"if (item == null)")
                    .AppendCode($"    return null;")
                    .AppendCode($"return item.Value;")
                    .CloseBrace()
                    ;

                foreach (String elementSetName in this.ElementSetNames)
                {
                    containerPropertiesBlock
                        .BlankLine()
                        .SummaryOpen()
                        .Summary($"Set Item's Value")
                        .SummaryClose()
                        .AppendCode($"public void Set({elementSetName} value)")
                        .OpenBrace()
                        .AppendCode($"this.item = new Item(value);")
                        .CloseBrace()
                        ;
                }
            }
            else
            {
                containerPropertiesBlock
                    .AppendCode($"List<Item> items = new List<Item>();")

                    .BlankLine()
                    .SummaryOpen()
                    .Summary($"All Items")
                    .SummaryClose()
                    .AppendCode($"IEnumerable<Item> AllItems => this.items;")

                    .BlankLine()
                    .SummaryOpen()
                    .Summary($"Count property")
                    .SummaryClose()
                    .AppendCode($"public override Int32 Count => items.Count;")

                    .BlankLine()
                    .SummaryOpen()
                    .Summary($"Return all items")
                    .SummaryClose()
                    .AppendCode($"public IEnumerable<{ElementGetName}> All()")
                    .OpenBrace()
                    .AppendCode($"foreach (Item item in items)")
                    .AppendCode($"   yield return item.Value;")
                    .CloseBrace()

                    .BlankLine()
                    .SummaryOpen()
                    .Summary($"Get Item's Value at indicated index")
                    .SummaryClose()
                    .AppendCode($"public {ElementGetName} GetAt(Int32 i) => this.items[i].Value;")

                    .BlankLine()
                    .SummaryOpen()
                    .Summary($"Remove Item at indicated index")
                    .SummaryClose()
                    .AppendCode($"public void RemoveAt(Int32 i) => this.items.RemoveAt(i);")

                    .BlankLine()
                    .SummaryOpen()
                    .Summary($"Clear all items from collection")
                    .SummaryClose()
                    .AppendCode($"public void Clear() => this.items.Clear();")
                    ;

                foreach (String elementSetName in this.ElementSetNames)
                {
                    containerPropertiesBlock
                        .BlankLine()
                        .SummaryOpen()
                        .Summary($"Append value to collection")
                        .SummaryClose()
                        .AppendCode($"public void Append({elementSetName} value) => this.items.Add(new Item(value));")
                        ;
                }
            }

            containerMethodsBlock
               .BlankLine()
               .SummaryOpen()
               .Summary("Write single item as a fhir element.")
               .SummaryClose()
               .AppendCode($"public {FhirElementItemName} WriteItem(BreastRadiologyDocument doc, Item item)")
               .OpenBrace()
               .AppendCode($"return new {FhirElementItemName}")
               .OpenBrace()
               .Call(WriteItem)
               .CloseBrace(";")
               .CloseBrace()

               .BlankLine()
               .SummaryOpen()
               .Summary("Write out member item as a fhir element.")
               .SummaryClose()
               .AppendCode($"public IEnumerable<{FhirElementItemName}> Write(BreastRadiologyDocument doc)")
               .OpenBrace()
               .AppendCode($"foreach (Item item in this.AllItems)")
               .AppendCode($"    yield return WriteItem(doc, item);")
               .CloseBrace()

               .BlankLine()
               .SummaryOpen()
               .Summary("Read single item as a fhir element.")
               .SummaryClose()
               .AppendCode($"public Item ReadItem(BreastRadiologyDocument doc, {FhirElementItemName} element)")
               .OpenBrace()
               .Call(ReadItem)
               .CloseBrace()

               .BlankLine()
               .SummaryOpen()
               .Summary("Read data from fhir element into member item.")
               .SummaryClose()
               .AppendCode($"public void Read(BreastRadiologyDocument doc, IEnumerable<{FhirElementItemName}> elements)")
               .OpenBrace()
               .AppendCode($"List<Item> items = new List<Item>();")
               .AppendCode($"foreach ({FhirElementItemName} element in elements)")
               .OpenBrace()
               .AppendCode($"Item item = ReadItem(doc, element);")
               .AppendCode($"if (item != null)")
               .AppendCode($"   items.Add(item);")
               .CloseBrace()
            ;
            if (this.Max == 1)
            {
                containerMethodsBlock
                    .AppendCode($"switch (items.Count)")
                    .OpenBrace()
                    .AppendCode($"case 0:")
                    .AppendCode($"    break;")
                    .AppendCode($"case 1:")
                    .AppendCode($"    this.item = items[0];")
                    .AppendCode($"    break;")
                    .AppendCode($"default:")
                    .AppendCode($"    throw new Exception(\"error reading component {this.FhirElementItemName}. Multiple items found. Expected single element\");")
                    .CloseBrace()
                    ;
            }
            else
            {
                containerMethodsBlock
                    .AppendCode($"this.items.Clear();")
                    .AppendCode($"this.items.AddRange(items);")
                    ;
            }

            containerMethodsBlock
               .CloseBrace()
               ;
            ;
        }


        /// <summary>
        /// Child classes can overload this to do local processing of container class.
        /// </summary>
        protected virtual void BuildContainerClassLocal(CodeBlockNested containerConstructorBlock,
            CodeBlockNested containerPropertiesBlock,
            CodeBlockNested containerMethodsBlock)
        {
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
