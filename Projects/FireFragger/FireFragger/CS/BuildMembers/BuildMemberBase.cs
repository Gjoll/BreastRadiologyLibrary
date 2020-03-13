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
        protected abstract String FhirClassName { get; }
        protected abstract String PropertyName { get; }

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
            ClassCodeBlocks codeBlocks)
        {
            this.defineBase = defineBase;
            this.codeBlocks = codeBlocks;
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

        protected abstract void BuildWrite(CodeBlockNested b);
        protected abstract void BuildRead(CodeBlockNested b);

        void BuildContainerClass()
        {
            this.containerCode
                .SummaryOpen()
                .Summary($"Container class for {this.elementId}.")
                .SummaryClose()
                .AppendCode($"public class {this.ContainerClassName} : MContainer, ITMItem<{FhirClassName}> ")
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
                    .Summary($"Get All Items")
                    .SummaryClose()
                    .AppendCode($"IEnumerable<Item> GetAllItems()")
                    .OpenBrace()
                    .AppendCode($"if (this.item != null) yield return this.item;")
                    .CloseBrace()

                    .BlankLine()
                    .SummaryOpen()
                    .Summary($"Set All Items")
                    .SummaryClose()
                    .AppendCode($"void SetAllItems(IEnumerable<Item> items)")
                    .OpenBrace()
                    .AppendCode($"switch (items.Count())")
                    .OpenBrace()
                    .AppendCode($"case 0: break;")
                    .AppendCode($"case 1: this.item = items.First(); break;")
                    .AppendCode($"default: throw new Exception(\"Found multiple elements while reading single item\");")
                    .CloseBrace()
                    .CloseBrace()

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
                        .AppendCode($"public {elementSetName} Set({elementSetName} value)")
                        .OpenBrace()
                        .AppendCode($"this.item = new Item(value);")
                        .AppendCode($"return value;")
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
                    .Summary($"Get All Items")
                    .SummaryClose()
                    .AppendCode($"IEnumerable<Item> GetAllItems() => this.items;")

                    .BlankLine()
                    .SummaryOpen()
                    .Summary($"Set All Items")
                    .SummaryClose()
                    .AppendCode($"void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();")

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
                    containerMethodsBlock
                        .BlankLine()
                        .SummaryOpen()
                        .Summary($"Append value to collection")
                        .SummaryClose()
                        .AppendCode($"public {elementSetName} Append({elementSetName} value)")
                        .OpenBrace()
                        .AppendCode($"this.items.Add(new Item(value));")
                        .AppendCode($"return value;")
                        .CloseBrace()
                        ;
                }
            }

            containerMethodsBlock
               .BlankLine()
               .SummaryOpen()
               .Summary("Write single item as a fhir element.")
               .SummaryClose()
               .Call(BuildWrite)

               .BlankLine()
               .SummaryOpen()
               .Summary("Read data from fhir element into member item.")
               .SummaryClose()
               .Call(BuildRead)
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

        void BuildProperty()
        {
            this.codeBlocks.ClassConstructor
                .AppendCode($"this.{this.PropertyName} = new {this.ContainerClassName}({this.Min}, {this.Min});")
                ;

            this.codeBlocks.InterfaceProperties
                .SummaryOpen()
                .Summary($"{PropertyName}")
                .SummaryClose()
                .AppendCode($"{this.ContainerClassName} {this.PropertyName} {{ get ; }}")
                ;

            this.codeBlocks.ClassProperties
                .BlankLine()
                .SummaryOpen()
                .Summary($"{this.PropertyName}")
                .Summary($"Access fhir element '{this.elementId}'")
                .SummaryClose()
                .AppendCode($"public {this.ContainerClassName} {this.PropertyName} {{ get ; protected set; }}")
                ;

            //this.codeBlocks.ClassReadCode
            //    .AppendCode($"this.{PropertyName}.Read(this.Doc);")
            //    ;
            //this.codeBlocks.ClassValidateCode
            //    .AppendCode($"if (this.{PropertyName}.Validate(sb) == false) retVal = false;")
            //    ;
        }

        public virtual void BuildOne(String elementId,
            Int32 min,
            Int32 max)
        {
            this.elementId = elementId;
            this.Min = min;
            this.Max = max;

            this.containerCode = this.codeBlocks.LocalClassDefs.AppendBlock();
            BuildContainerClass();
            BuildItemClass();
            BuildProperty();
        }

        public abstract void Build();
    }
}
