using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FireFragger
{
    /// <summary>
    /// Build the class that implements a list of extension values
    /// </summary>
    internal class CSBuildMemberListExtensionValue : CSBuildMemberListBase
    {
        public CSBuildMemberListExtensionValue(CSBuilder csBuilder,
            SDInfo fragBase) : base(csBuilder, fragBase)
        {
        }


        public void Define(String extensionName,
            String extensionUrl,
            ElementTreeSlice extensionSlice)
        {
            if (this.fragBase.ClassEditor != null)
            {
                this.ClassWriteCodeStart
                    ?.AppendCode($"this.ClearExtensions();")
                    ;
            }

            ElementTreeNode GetChild(String name)
            {
                if (this.fragBase.SnapNodes.TryGetElementNode($"{extensionSlice.ElementDefinition.ElementId}.{name}", out ElementTreeNode n) == false)
                    throw new Exception($"Cant find child {name}");
                return n;
            }
            ElementTreeNode valueNode = GetChild("value[x]");

            Int32 max = this.ToMax(extensionSlice.ElementDefinition.Max);
            Int32 min = extensionSlice.ElementDefinition.Min.Value;
            String propertyName = extensionName.ToMachineName();

            String extensionClassName =
                this.DefineLocalClass(extensionSlice, extensionUrl, max, min, propertyName, valueNode);

            this.DefineCommon(extensionClassName, propertyName, "Extension");
        }

        String DefineLocalClass(ElementTreeSlice extensionSlice,
            String extensionUrl,
            Int32 max,
            Int32 min,
            String propertyName,
            ElementTreeNode valueNode)
        {
            String[] ParamTypes(ElementDefinition.TypeRefComponent type)
            {
                if (this.BindingClassName(valueNode.ElementDefinition,
                    out String bindingClassName,
                    out ElementDefinition.ElementDefinitionBindingComponent binding) == false)
                    return new string[] { type.Code };

                switch (binding.Strength)
                {
                    case BindingStrength.Required:
                        return new string[] { bindingClassName };

                    case BindingStrength.Preferred:
                    case BindingStrength.Extensible:
                        return new string[] { type.Code, bindingClassName };

                    default:
                        return new string[] { type.Code };
                }
            }

            List<ElementDefinition.TypeRefComponent> types = valueNode.ElementDefinition.Type;

            String propertyType = (types.Count == 1) ? valueNode.ElementDefinition.Type[0].Code : "Element";

            String className = $"{propertyName}_Accessor";
            if (this.LocalClassDefs == null)
                return className;

            this.LocalClassDefs
                .SummaryOpen()
                .Summary($"Accessor class for '{extensionSlice.Name}'")
                .Summary($"[Fhir Element '{extensionSlice.ElementDefinition.ElementId}]'")
                .SummaryClose()
                .AppendCode($"public class {className} : MemberListExtensionValueBase<{propertyType}>")
                .OpenBrace()
                .AppendCode($"// Properties")
                .DefineBlock(out CodeBlockNested propertiesBlock)
                .BlankLine()
                .AppendCode($"// Methods")
                .DefineBlock(out CodeBlockNested methodsBlock)
                .BlankLine()
                .SummaryOpen()
                .Summary($"Accessor class constructor")
                .SummaryClose()
                .AppendCode($"public {className}(BreastRadiologyDocument doc) : base(\"{className}\")")
                .OpenBrace()
                .AppendCode($"this.Init(doc, {min}, {max}, \"{extensionUrl}\"));")
                .DefineBlock(out CodeBlockNested constructorBlock)
                .CloseBrace()
                .CloseBrace()
                ;

            if (max == 1)
            {
                void Define(String suffix, String valueType)
                {
                    foreach (String paramType in ParamTypes(types[0]))
                    {
                        methodsBlock
                            .BlankLine()
                            .SummaryOpen()
                            .Summary($"Set {propertyName} value")
                            .SummaryClose()
                            .AppendCode($"public void Set{suffix}({paramType} value) => this.SetFirst(value);")
                            ;
                    }
                }

                propertiesBlock
                    .SummaryOpen()
                    .Summary("get {propertyName} value")
                    .SummaryClose()
                    .AppendCode($"public {propertyType} Get() => base.FirstOrDefault();")
                    ;
                if (types.Count == 1)
                    Define("", types[0].Code);
                else
                    foreach (ElementDefinition.TypeRefComponent type in types)
                        Define(type.Code, type.Code);
            }
            else
            {
                void DefineAppend(String fhirType, String targetName)
                {
                    foreach (String paramType in ParamTypes(types[0]))
                    {
                        methodsBlock
                            .BlankLine()
                            .SummaryOpen()
                            .Summary($"Append item to end of list")
                            .SummaryClose()
                            .AppendCode($"public void Append{targetName}({paramType} value)")
                            .OpenBrace()
                            .AppendCode($"this.RawItems.Add(value);")
                            .CloseBrace();
                        ;
                    }
                }

                propertiesBlock
                    .SummaryOpen()
                    .Summary("Access propertyName")
                    .SummaryClose()
                    .AppendCode($"public IEnumerable<{propertyType}> All() => this.items;")

                    .BlankLine()
                    .SummaryOpen()
                    .Summary("Access item at indicated location in list")
                    .SummaryClose()
                    .AppendCode($"public {propertyType} At(Int32 i) => base.items[i];")

                    .BlankLine()
                    .SummaryOpen()
                    .Summary("Access first item in list")
                    .SummaryClose()
                    .AppendCode($"public new {propertyType} First() => base.First();")
                    .BlankLine()
                    .SummaryOpen()
                    .Summary("Access first item in list or default value if empty")
                    .SummaryClose()
                    .AppendCode($"public new {propertyType} FirstOrDefault() => base.FirstOrDefault();")
                    ;

                if (types.Count == 1)
                    DefineAppend(propertyType, "");
                else
                    foreach (ElementDefinition.TypeRefComponent type in types)
                        DefineAppend(type.Code, type.Code);
            }
            return className;
        }
    }
}
