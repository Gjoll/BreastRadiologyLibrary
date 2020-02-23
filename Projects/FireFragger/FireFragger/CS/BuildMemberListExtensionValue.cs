using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FireFragger.CS
{
    /// <summary>
    /// Build the class that implements a list of extension values
    /// </summary>
    internal class BuildMemberListExtensionValue : BuildMemberListBase
    {
        public BuildMemberListExtensionValue(Builder csBuilder,
            SDInfo fragBase) : base(csBuilder, fragBase)
        {
        }


        public void DefineStart()
        {
            if (this.fragBase.ClassEditor != null)
            {
                this.fragBase.ClassWriteCodeStart
                    ?.AppendCode($"this.ClearExtensions();")
                    ;
            }
        }

        public void Define(String extensionName,
        String extensionUrl,
        ElementTreeSlice extensionSlice)
        {
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
            if (this.fragBase.LocalClassDefs == null)
                return className;

            this.fragBase.LocalClassDefs
                .SummaryOpen()
                .Summary($"Accessor class for '{extensionSlice.Name}'")
                .Summary($"[Fhir Element '{extensionSlice.ElementDefinition.ElementId}]'")
                .SummaryClose()
                .AppendCode($"public class {className} : MemberListExtensionValueBase")
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
                .AppendCode($"this.Init(doc, {min}, {max}, \"{extensionUrl}\");")
                .DefineBlock(out CodeBlockNested constructorBlock)
                .CloseBrace()
                .CloseBrace()
                ;

            if (max == 1)
            {
                void DefineSet(String suffix, String paramType)
                {
                    methodsBlock
                        .BlankLine()
                        .SummaryOpen()
                        .Summary($"Set {propertyName} value")
                        .SummaryClose()
                        .AppendCode($"public void Set{suffix}({paramType} value) => this.SetFirst(({propertyType})value);")
                        ;
                }

                void DefineSetQuantityCode(String suffix, String bindingClassName)
                {
                    methodsBlock
                        .BlankLine()
                        .SummaryOpen()
                        .Summary($"Set {propertyName} value")
                        .SummaryClose()
                        .AppendCode($"public void Set{suffix}(decimal value, {bindingClassName} code)")
                        .OpenBrace()
                        .AppendCode($"Quantity q = new Quantity(value, code.Value.System, code.Value.Code);")
                        .AppendCode($"this.SetFirst(q);")
                        .CloseBrace()
                        ;
                }

                void Define(String suffix, ElementDefinition.TypeRefComponent type)
                {
                    switch (type.Code)
                    {
                        case "Quantity":
                            if (this.BindingClassName(valueNode.ElementDefinition,
                                out String bindingClassName,
                                out ElementDefinition.ElementDefinitionBindingComponent binding) == false)
                            {
                                DefineSet(suffix, "Quantity");
                            }
                            else
                            {
                                switch (binding.Strength)
                                {
                                    case BindingStrength.Required:
                                        DefineSetQuantityCode(suffix, bindingClassName);
                                        break;
                                    case BindingStrength.Preferred:
                                    case BindingStrength.Extensible:
                                        DefineSetQuantityCode(suffix, bindingClassName);
                                        DefineSet(suffix, "Quantity");
                                        break;
                                    default:
                                        DefineSet(suffix, "Quantity");
                                        break;
                                }
                            }
                            break;
                        default:
                            foreach (String paramType in ParamTypes(type))
                                DefineSet(suffix, paramType);
                            break;
                    }
                }

                propertiesBlock
                    .SummaryOpen()
                    .Summary("get {propertyName} value")
                    .SummaryClose()
                    .AppendCode($"public {propertyType} Get() => ({propertyType}) base.FirstOrDefault();")
                    ;
                if (types.Count == 1)
                    Define("", types[0]);
                else
                    foreach (ElementDefinition.TypeRefComponent type in types)
                        Define(type.Code, type);
            }
            else
            {
                void DefineAppendQuantityCode(String suffix, String bindingClassName)
                {
                    methodsBlock
                        .BlankLine()
                        .SummaryOpen()
                        .Summary($"Set {propertyName} value")
                        .SummaryClose()
                        .AppendCode($"public void Append{suffix}(decimal value, {bindingClassName} code)")
                        .OpenBrace()
                        .AppendCode($"Quantity q = new Quantity(value, code.Value.System, code.Value.Code);")
                        .AppendCode($"this.RawItems.Add(q);")
                        .CloseBrace()
                        ;
                }

                void DefineAppend(String suffix, String paramType)
                {
                    methodsBlock
                        .BlankLine()
                        .SummaryOpen()
                        .Summary($"Append item to end of list")
                        .SummaryClose()
                        .AppendCode($"public void Append{suffix}({paramType} value)")
                        .OpenBrace()
                        .AppendCode($"this.RawItems.Add(({propertyType}) value);")
                        .CloseBrace();
                    ;
                }

                void Define(String suffix, ElementDefinition.TypeRefComponent type)
                {
                    switch (type.Code)
                    {
                        case "Quantity":
                            if (this.BindingClassName(valueNode.ElementDefinition,
                                out String bindingClassName,
                                out ElementDefinition.ElementDefinitionBindingComponent binding) == false)
                            {
                                DefineAppend(suffix, "Quantity");
                            }
                            else
                            {
                                switch (binding.Strength)
                                {
                                    case BindingStrength.Required:
                                        DefineAppendQuantityCode(suffix, bindingClassName);
                                        break;
                                    case BindingStrength.Preferred:
                                    case BindingStrength.Extensible:
                                        DefineAppendQuantityCode(suffix, bindingClassName);
                                        DefineAppend(suffix, "Quantity");
                                        break;
                                    default:
                                        DefineAppend(suffix, "Quantity");
                                        break;
                                }
                            }
                            break;

                        default:
                            foreach (String paramType in ParamTypes(type))
                                DefineAppend(suffix, paramType);
                            break;
                    }
                }

                propertiesBlock
                    .SummaryOpen()
                    .Summary("Access propertyName")
                    .SummaryClose()
                    .AppendCode($"public IEnumerable<{propertyType}> All()")
                    .OpenBrace()
                    .AppendCode($"foreach (var item in items)")
                    .AppendCode($"    yield return ({propertyType}) item;")
                    .CloseBrace()

                    .BlankLine()
                    .SummaryOpen()
                    .Summary("Access item at indicated location in list")
                    .SummaryClose()
                    .AppendCode($"public {propertyType} At(Int32 i) => ({propertyType}) base.items[i];")

                    .BlankLine()
                    .SummaryOpen()
                    .Summary("Access first item in list")
                    .SummaryClose()
                    .AppendCode($"public new {propertyType} First() => ({propertyType}) base.First();")
                    .BlankLine()
                    .SummaryOpen()
                    .Summary("Access first item in list or default value if empty")
                    .SummaryClose()
                    .AppendCode($"public new {propertyType} FirstOrDefault() => ({propertyType}) base.FirstOrDefault();")
                    ;

                if (types.Count == 1)
                    Define("", types[0]);
                else
                    foreach (ElementDefinition.TypeRefComponent type in types)
                        Define(type.Code, type);
            }
            return className;
        }
    }
}
