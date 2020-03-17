using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
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
        /// <summary>
        /// Code blocks for the container class.
        /// </summary>
        protected ClassCodeBlocks containerCodeBlocks = new ClassCodeBlocks();

        /// <summary>
        /// Code blocks for the item class.
        /// </summary>
        protected ClassCodeBlocks itemCodeBlocks = new ClassCodeBlocks();

        protected CodeBlockNested containerCode;
        protected CodeBlockNested itemCode;
        /// <summary>
        /// Name for debugging/documentation. Uniquely identifies element.
        /// </summary>
        protected String pathName;
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

        protected virtual void BuildItemClass(String buildMsg)
        {
            this.itemCode
                 .AppendCode($"#region {this.pathName} Item Class")
                 .AppendLine($"// {buildMsg}")
                 .SummaryOpen()
                 .Summary($"Item class for {this.pathName}.")
                 .SummaryClose()
                 .AppendCode($"public class Item")
                 .OpenBrace()
                 .AppendCode($"// Properties")
                 .DefineBlock(out itemCodeBlocks.LocalClassDefs)
                 .SummaryOpen()
                 .Summary($"Value")
                 .SummaryClose()
                 .AppendCode($"public {ElementGetName} Value {{ get; set; }}")
                 .DefineBlock(out itemCodeBlocks.ClassProperties)
   
                 .BlankLine()
                 .SummaryOpen()
                 .Summary($"Constructor")
                 .SummaryClose()
                 .AppendCode($"public Item()")
                 .OpenBrace()
                 .DefineBlock(out itemCodeBlocks.ClassConstructor)
                 .CloseBrace()

                 .BlankLine()
                 .AppendCode($"// Methods")

                .BlankLine()
                .SummaryOpen()
                .Summary("Write item.")
                .SummaryClose()
                .Call(BuildItemWrite)

                .BlankLine()
                .SummaryOpen()
                .Summary("Read item.")
                .SummaryClose()
                .Call(BuildItemRead)

                .DefineBlock(out itemCodeBlocks.ClassMethods)
                .CloseBrace()
                .AppendCode($"#endregion")
                ;

            BuildItemClassLocal(this.itemCodeBlocks);
        }

        /// <summary>
        /// Child classes can overload this to do local processing of item class.
        /// </summary>
        protected virtual void BuildItemClassLocal(ClassCodeBlocks itemCodeBlocks)
        {
        }

        protected abstract void BuildItemWrite(CodeBlockNested b);
        protected abstract void BuildItemRead(CodeBlockNested b);

        protected abstract void BuildContainerWrite(CodeBlockNested b);
        protected abstract void BuildContainerRead(CodeBlockNested b);

        protected void BuildTargeturls(CodeBlockNested containerPropertiesBlock,
            List<String> targetProfiles)
        {
            containerPropertiesBlock
                .AppendCode("String[] targetUrls = new string[]")
                .OpenBrace()
                ;

            for (Int32 i = 0; i < targetProfiles.Count - 1; i++)
                containerPropertiesBlock.AppendCode($"\"{targetProfiles[i]}\",");

            containerPropertiesBlock
                .AppendCode($"\"{targetProfiles[targetProfiles.Count - 1]}\"")
                .CloseBrace(";")
               ;

        }

        protected virtual void BuildContainerClass(String buildMsg)
        {
            Debug.Assert(String.IsNullOrEmpty(this.ContainerClassName) == false);

            this.containerCode
                .AppendCode($"#region {this.pathName} Container Class")
                .AppendLine($"// {buildMsg}")
                .SummaryOpen()
                .Summary($"Container class for {this.pathName}.")
                .SummaryClose()
                .AppendCode($"public class {this.ContainerClassName} : MContainer, ITMItem<{FhirClassName}> ")
                .OpenBrace()
                .DefineBlock(out this.itemCode)

                .BlankLine()
                .AppendCode($"// Properties")
                .DefineBlock(out this.containerCodeBlocks.ClassProperties)

                .BlankLine()
                .SummaryOpen()
                .Summary($"Constructor")
                .SummaryClose()
                .AppendCode($"public {this.ContainerClassName}(Int32 min, Int32 max) : base(\"{pathName}\", min, max)")
                .OpenBrace()
                .DefineBlock(out this.containerCodeBlocks.ClassConstructor)
                .CloseBrace()

                .BlankLine()
                .AppendCode($"// Methods")
                .DefineBlock(out this.containerCodeBlocks.ClassMethods)
                .CloseBrace()
                .AppendCode($"#endregion")
                ;

            this.BuildContainerClassLocal(this.containerCodeBlocks);

            if (this.Singleton)
            {
                this.containerCodeBlocks.ClassProperties
                    .AppendCode($"#region Common Singleton Properties")

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
                    this.containerCodeBlocks.ClassProperties
                        .BlankLine()
                        .SummaryOpen()
                        .Summary($"Set Item's Value")
                        .SummaryClose()
                        .AppendCode($"public {elementSetName} Set({elementSetName} value)")
                        .OpenBrace()
                        .AppendCode($"Item item = new Item();")
                        .AppendCode($"item.Value = value;")
                        .AppendCode($"this.item = item;")
                        .AppendCode($"return value;")
                        .CloseBrace()
                        ;
                }
            }
            else
            {
                this.containerCodeBlocks.ClassProperties
                    .AppendCode($"#region Common Non-Singleton Properties")
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
                    this.containerCodeBlocks.ClassMethods
                        .BlankLine()
                        .SummaryOpen()
                        .Summary($"Append value to collection")
                        .SummaryClose()
                        .AppendCode($"public {elementSetName} Append({elementSetName} value)")
                        .OpenBrace()
                        .AppendCode($"Item item = new Item();")
                        .AppendCode($"item.Value = value;")
                        .AppendCode($"this.items.Add(item);")
                        .AppendCode($"return value;")
                        .CloseBrace()
                        ;
                }
            }

            this.containerCodeBlocks.ClassProperties
                .AppendCode($"#endregion")
                ;

            this.containerCodeBlocks.ClassMethods
               .BlankLine()
               .SummaryOpen()
               .Summary("Write container items.")
               .SummaryClose()
               .Call(BuildContainerWrite)

               .BlankLine()
               .SummaryOpen()
               .Summary("Read container items.")
               .SummaryClose()
               .Call(BuildContainerRead)
               ;
        }


        /// <summary>
        /// Child classes can overload this to do local processing of container class.
        /// </summary>
        protected virtual void BuildContainerClassLocal(ClassCodeBlocks itemCodeBlocks)
        {
        }

        protected virtual void BuildProperty(String buildMsg)
        {
            this.codeBlocks.ClassConstructor
                .AppendLine($"// {buildMsg}")
                .AppendCode($"this.{this.PropertyName} = new {this.ContainerClassName}({this.Min}, {this.Min});")
                ;

            if (this.codeBlocks.InterfaceProperties != null)
            {
                this.codeBlocks.InterfaceProperties
                    .AppendLine($"// {buildMsg}")
                    .SummaryOpen()
                    .Summary($"{PropertyName}")
                    .SummaryClose()
                    .AppendCode($"{this.ContainerClassName} {this.PropertyName} {{ get ; }}")
                    ;
            }

            this.codeBlocks.ClassProperties
                .BlankLine()
                .AppendLine($"// {buildMsg}")
                .SummaryOpen()
                .Summary($"{this.PropertyName}")
                .Summary($"Access fhir element '{this.pathName}'")
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

        public virtual void BuildOne(String pathName,
            Int32 min,
            Int32 max,
            [CallerFilePath] String filePath = "",
            [CallerLineNumber] Int32 lineNumber = 0)
        {
            this.pathName = pathName;
            this.Min = min;
            this.Max = max;

            String buildMsg = $"Called from {Path.GetFileName(filePath)}, Line {lineNumber}";
            this.containerCode = this.codeBlocks.LocalClassDefs.AppendBlock();
            BuildContainerClass(buildMsg);
            BuildItemClass(buildMsg);
            BuildProperty(buildMsg);
        }

        public abstract void Build();
    }
}
