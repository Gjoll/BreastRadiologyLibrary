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
    internal class BuildMemberListExtension : BuildMemberListBase
    {
        String extensionName = "?";

        public BuildMemberListExtension(Builder csBuilder,
            ClassCodeBlocks codeBlocks) : base(csBuilder, codeBlocks, "Extension")
        {
        }

        public void DefineStart()
        {
            if (this.codeBlocks.ClassEditor != null)
            {
                this.codeBlocks.ClassWriteCodeStart
                    ?.AppendCode($"this.ClearExtensions();")
                    ;
            }
        }

        void Define(String extensionName,
            String extensionUrl,
            ElementTreeSlice extensionSlice)
        {
            ElementTreeNode GetChild(String name)
            {
                if (extensionSlice.Nodes.TryGetItem($"{extensionSlice.ElementDefinition.ElementId}.{name}", out ElementTreeNode n) == false)
                    throw new Exception($"Cant find child {name}");
                return n;
            }
            ElementTreeNode valueNode = GetChild("value[x]");

            Int32 max = CSMisc.ToMax(extensionSlice.ElementDefinition.Max);
            Int32 min = extensionSlice.ElementDefinition.Min.Value;
            String propertyName = extensionName.ToMachineName();

            String extensionClassName =
                this.DefineLocalClass(extensionSlice, extensionUrl, min, max, propertyName, valueNode);

            this.DefineCommon(extensionClassName, propertyName, "Extension");
        }

        String DefineLocalClass(ElementTreeSlice extensionSlice,
            String extensionUrl,
            Int32 min,
            Int32 max,
            String propertyName,
            ElementTreeNode valueNode)
        {
            String[] ParamTypes(ElementDefinition.TypeRefComponent type)
            {
                if (CSMisc.BindingClassName(valueNode.ElementDefinition,
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
            if (this.codeBlocks.LocalClassDefs == null)
                return className;

            this.codeBlocks.LocalClassDefs
                .SummaryOpen()
                .Summary($"Accessor class for '{extensionSlice.Name}'")
                .Summary($"[Fhir Element '{extensionSlice.ElementDefinition.ElementId}]'")
                .SummaryClose()
                .AppendCode($"public class {className} : <{propertyType}>")
                .OpenBrace()
                .AppendCode($"// Properties")
                .DefineBlock(out CodeBlockNested blockProperties)
                .BlankLine()
                .AppendCode($"// Methods")
                .DefineBlock(out CodeBlockNested blockMethods)
                .BlankLine()
                .SummaryOpen()
                .Summary($"Constructor")
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
                    blockMethods
                        .BlankLine()
                        .SummaryOpen()
                        .Summary($"Set {propertyName} value")
                        .SummaryClose()
                        .AppendCode($"public void Set{suffix}({paramType} value) => this.SetFirst(({propertyType})value);")
                        ;
                }

                void DefineSetQuantityCode(String suffix, String bindingClassName)
                {
                    blockMethods
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
                            if (CSMisc.BindingClassName(valueNode.ElementDefinition,
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

                blockProperties
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
                    blockMethods
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
                    blockMethods
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
                            if (CSMisc.BindingClassName(valueNode.ElementDefinition,
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

                blockProperties
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

        public void Build(String className, ElementTreeNode extensionNode)
        {
            if (className.EndsWith("Extension") == false)
                className += "Extension";
            BuildSlices(className, extensionNode);
        }

        /// <summary>
        /// Create a class for every extension slice, and create a class
        /// that has a property for every extension class type defined.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="extensionNode"></param>
        void BuildSlices(String className, ElementTreeNode extensionNode)
        {
            Int32 min = extensionNode.ElementDefinition.Min.Value;
            Int32 max = extensionNode.ElementDefinition.Max.ToMax();

            String extensionName = className.Substring(0, className.Length - 9);
            this.codeBlocks.LocalClassDefs
                .SummaryOpen()
                .Summary($"Class that implements the '{extensionName}' extension class.")
                .SummaryClose()
                .AppendCode($"public class {className} : MemberListExtensionComplex")
                .OpenBrace()
                .DefineBlock(out CodeBlockNested blockProperties)
                .BlankLine()
                .SummaryOpen()
                .Summary($"Constructor")
                .SummaryClose()
                .AppendCode($"public {className}(BreastRadiologyDocument doc) : base(\"{extensionName}\")")
                .OpenBrace()
                .AppendCode($"this.Init(doc, {min}, {max});")
                .DefineBlock(out CodeBlockNested blockConstructor)
                .CloseBrace()
                .BlankLine()
                .SummaryOpen()
                .Summary($"Read extension values")
                .SummaryClose()
                .AppendCode($"public override void ReadItems(IEnumerable<Extension> e)")
                .OpenBrace()
                .DefineBlock(out CodeBlockNested blockRead)
                .CloseBrace()
                .BlankLine()
                .SummaryOpen()
                .Summary($"Write extension values")
                .SummaryClose()
                .AppendCode($"public override IEnumerable<Extension> WriteItems()")
                .OpenBrace()
                .AppendCode($"List<Extension> retVal = new List<Extension>();")
                .DefineBlock(out CodeBlockNested blockWrite)
                .AppendCode($"return retVal.ToArray();")
                .CloseBrace()
                .CloseBrace()
                ;

            foreach (ElementTreeSlice extensionSlice in extensionNode.Slices.Skip(1))
            {
                if (extensionSlice.ElementDefinition.Type.Count != 1)
                    throw new Exception("Invalid extension type count");
                if (extensionSlice.ElementDefinition.Type[0].Code != "Extension")
                    throw new Exception("Invalid extension type Code");
                switch (extensionSlice.ElementDefinition.Type[0].Profile.Count())
                {
                    case 0:
                        BuildSlice(extensionSlice, this.codeBlocks.LocalClassDefs, blockProperties, blockConstructor, blockWrite, blockRead);
                        break;

                    case 1:
                        BuildSliceProfile(extensionSlice,
                            extensionSlice.ElementDefinition.Type[0].Profile.First(),
                            this.codeBlocks.LocalClassDefs,
                            blockProperties,
                            blockConstructor,
                            blockWrite,
                            blockRead);
                        break;

                    default:
                        throw new Exception("Invalid extension type profile count");
                }
            }
        }

        void BuildSliceProfile(ElementTreeSlice extensionSlice,
            String profile,
            CodeBlockNested localClassDefs,
            CodeBlockNested blockProperties,
            CodeBlockNested blockConstructor,
            CodeBlockNested blockWrite,
            CodeBlockNested blockRead)
        {
            const String fcn = "BuildSliceProfile";

            if (this.csBuilder.SDFragments.TryGetValue(profile, out SDInfo fiRef) == false)
            {
                this.csBuilder.ConversionError(this.GetType().Name,
                       fcn,
                       $"Unimplemented code. external extension reference");
                return;
            }
            CodeBlockNested usingBlock = this.codeBlocks.SubClassEditor.Blocks.Find("Usings", false);
            usingBlock.AppendLine($"using {CSMisc.LocalClassNameSpace(fiRef)}");
            String propertyName = CSMisc.PropertyName(extensionSlice.Name);
            String sliceClassName = CSMisc.ClassName(profile.LastUriPart());
            DefineProperty(sliceClassName, propertyName,
                blockProperties, blockConstructor,
                blockWrite, blockRead);
        }

        void BuildSlice(ElementTreeSlice extensionSlice,
            CodeBlockNested localClassDefs,
            CodeBlockNested blockProperties,
            CodeBlockNested blockConstructor,
            CodeBlockNested blockWrite,
            CodeBlockNested blockRead)
        {
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
            String sliceClassName = null;

            this.DefineStart();
            if ((valueXCardMax != 0) && (subExtensionNode.Slices.Count > 1))
                throw new Exception($"Both Simple and Complex extension found. Not implemented");
            else if ((valueXCardMax == 0) && (subExtensionNode.Slices.Count == 0))
                throw new Exception($"Neither Simple and Complex extension found. Not implemented");
            else if (valueXCardMax != 0)
                sliceClassName = this.BuildSimpleExtensionClass(extensionSlice, localClassDefs, valueXNode);
            else
                this.BuildPropertyComplexExtension(subExtensionNode);

            if (sliceClassName == null)
            {
                this.csBuilder.ConversionError(this.GetType().Name,
                       fcn,
                       $"Slice {extensionSlice.Name} not implemented");
                return;
            }
            String propertyName = CSMisc.PropertyName(extensionSlice.Name);
            DefineProperty(sliceClassName, propertyName,
                blockProperties, blockConstructor,
                blockWrite, blockRead);
        }

        void DefineProperty(String sliceClassName,
            String propertyName,
            CodeBlockNested blockProperties,
            CodeBlockNested blockConstructor,
            CodeBlockNested blockWrite,
            CodeBlockNested blockRead)
        {
            blockProperties
                .AppendCode($"{sliceClassName} {propertyName};")
                ;
            blockConstructor
                .AppendCode($"this.{propertyName} = new {sliceClassName}(this.doc);")
                ;
            blockRead
                .AppendCode($"this.{propertyName}.ReadItems(e);")
                ;
            blockWrite
                .AppendCode($"retVal.AddRange(this.{propertyName}.WriteItems());")
                ;
        }

        /// <summary>
        /// Create class for an extension element that has no slices, and a single
        /// defined value.
        /// </summary>
        String BuildSimpleExtensionClass(ElementTreeSlice extensionSlice,
            CodeBlockNested localClassDefs,
            ElementTreeNode valueXNode)
        {
            Int32 max = CSMisc.ToMax(extensionSlice.ElementDefinition.Max);
            Int32 min = extensionSlice.ElementDefinition.Min.Value;

            String sliceName = extensionSlice.ElementDefinition.SliceName;
            String className = CSMisc.ClassName(sliceName);
            if (className.EndsWith("Extension") == false)
                className += "Extension";

            String propertyType;
            switch (valueXNode.ElementDefinition.Type.Count())
            {
                case 0:
                    throw new NotImplementedException($"No type defined for extension Element '{extensionSlice.ElementDefinition.ElementId}");
                case 1:
                    propertyType = valueXNode.ElementDefinition.Type[0].Code;
                    break;
                default:
                    propertyType = "Base";
                    break;
            }

            localClassDefs
                .BlankLine()
                .SummaryOpen()
                .Summary($"Class that implements the {className}' extension slice class.")
                .SummaryClose()
                .AppendCode($"public class {className} : MemberListExtensionSimple<{propertyType}>")
                .OpenBrace()

                .DefineBlock(out CodeBlockNested propertiesBlock)

                .BlankLine()
                .SummaryOpen()
                .Summary($"Constructor")
                .SummaryClose()
                .AppendCode($"public {className}(BreastRadiologyDocument doc) : base(\"{className}\")")
                .OpenBrace()
                .AppendCode($"this.Init(doc, {min}, {max}, \"{sliceName}\");")
                .DefineBlock(out CodeBlockNested constructorBlock)
                .CloseBrace()

                .DefineBlock(out CodeBlockNested blockMethods)
                .BlankLine()
                .CloseBrace()
                ;

            String propertyName = CSMisc.PropertyName(extensionSlice.Name);

            switch (max)
            {
                case 1:
                    {
                        propertiesBlock
                            .BlankLine()
                            .SummaryOpen()
                            .Summary($"Get value of extension slice {extensionSlice.Name}")
                            .SummaryClose()
                            .AppendCode($"public {propertyType} Get() => ({propertyType}) this.First();")
                            ;
                        foreach (ElementDefinition.TypeRefComponent type in valueXNode.ElementDefinition.Type)
                        {
                            propertiesBlock
                                .BlankLine()
                                .SummaryOpen()
                                .Summary($"Set value of extension slice {extensionSlice.Name}")
                                .SummaryClose()
                                .AppendCode($"public void Set({type.Code} value) => this.SetSingleItem(value);")
                                ;
                        }
                    }
                    break;

                case -1:
                    {
                        List<ElementDefinition.TypeRefComponent> types = valueXNode.ElementDefinition.Type;

                        void DefineAppend(ElementDefinition valueXNode, String fhirType, String targetName)
                        {
                            foreach (String paramType in ParamTypes(valueXNode, types[0]))
                            {
                                blockMethods
                                    .BlankLine()
                                    .SummaryOpen()
                                    .Summary($"Append item to end of list")
                                    .SummaryClose()
                                    .AppendCode($"public void Append{targetName}({paramType} value) => this.RawItems.Add(({fhirType}) value);")
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
                            DefineAppend(valueXNode.ElementDefinition, propertyType, "");
                        foreach (ElementDefinition.TypeRefComponent type in types)
                        {
                            DefineAppend(valueXNode.ElementDefinition, type.Code, type.Code);
                        }
                    }
                    break;

                default:
                    throw new NotImplementedException();
            }
            return className;
        }

        void BuildPropertyComplexExternalExtension(ElementTreeSlice extensionSlice, String profile)
        {
            const String fcn = "BuildPropertyComplexExternalExtension";
            this.csBuilder.ConversionError(this.GetType().Name,
                   fcn,
                   $"Unimplemented");
            return;
        }

        void BuildPropertyComplexInternalExtension(ElementTreeSlice extensionSlice)
        {
            void CheckExtension()
            {
                ElementTreeNode subSubExtensionNode = extensionSlice.Nodes["extension"];
                if (subSubExtensionNode.ElementDefinition.Max != "0")
                    throw new Exception($"Slice '{extensionName}' sub extension node should be zero cardinality");
            }
            String GetExtensionUrl()
            {
                ElementTreeNode urlNode = extensionSlice.Nodes["url"];
                return ((FhirUrl)urlNode.ElementDefinition.Fixed).Value;
            }

            void GetValueNode(out String typeCode,
                out ElementTreeNode valueXNode)
            {
                valueXNode = extensionSlice.Nodes["value[x]"];
                ElementDefinition valueXElement = valueXNode.ElementDefinition;
                if ((valueXElement.Min.Value != 1) || (valueXElement.Max != "1"))
                    throw new Exception($"Slice '{extensionName}' value[x] node invalid cardinality");
                if (valueXElement.Type.Count != 1)
                    throw new Exception($"{extensionSlice.Name} invalid value[x].type count. Expected 1, got {valueXElement.Type.Count}");
                typeCode = valueXElement.Type[0].Code;
            }

            CheckExtension();
            String extensionUrl = GetExtensionUrl();
            GetValueNode(out String typeCode, out ElementTreeNode valueNode);

            this.Define(extensionName, extensionUrl, extensionSlice);
        }

        void BuildPropertyComplexExtension(ElementTreeNode subExtensionNode)
        {
            String className = CSMisc.ClassName(subExtensionNode.Name);
            BuildSlices(className, subExtensionNode);
        }
    }
}
