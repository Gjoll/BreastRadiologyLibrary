using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace FireFragger
{
    /// <summary>
    /// Perform Observation specific build
    /// </summary>
    class CSDefineObservation : CSDefineBase
    {
        public CSDefineObservation(CSBuilder csBuilder,
                    SDInfo fragBase) : base(csBuilder, fragBase)
        {
        }

        String DefineComponentsLocalClass(ElementTreeSlice componentSlice,
            Coding code,
            Int32 max,
            Int32 min,
            String propertyName,
            ElementTreeNode valueNode)
        {
            String[] ParamTypes(ElementDefinition.TypeRefComponent type)
            {
                if (BindingClassName(componentSlice.ElementDefinition, out String bindingClassName) == false)
                    return new string[] { type.Code };

                switch (componentSlice.ElementDefinition.Binding.Strength)
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

            String propertyType = (types.Count == 1) ? valueNode.ElementDefinition.Type[0].Code : "Base";

            String className = $"{propertyName}_Accessor";
            if (this.LocalClassDefs == null)
                return className;

            this.LocalClassDefs
                .SummaryOpen()
                .Summary($"Accessor class for '{componentSlice.Name}'")
                .Summary($"[Fhir Element '{componentSlice.ElementDefinition.ElementId}]'")
                .SummaryClose()
                .AppendCode($"public class {className} : ObservationLocal.ComponentBase<{propertyType}>")
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
                .AppendCode($"public {className}(BreastRadiologyDocument doc) : base()")
                .OpenBrace()
                .AppendCode($"this.Init(doc, {min}, {max}, new Coding(\"{code.System}\", \"{code.Code}\"));")
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

        void DefineComponents()
        {
            if (this.fragBase.DiffNodes.TryGetElementNode("Observation.component", out ElementTreeNode componentNode) == false)
                return;

            if (this.fragBase.ClassEditor != null)
            {
                this.ClassWriteCodeStart
                    ?.AppendCode($"this.ClearComponents();")
                    ;
            }

            foreach (ElementTreeSlice componentSlice in componentNode.Slices.Skip(1))
            {
                String sliceName = componentSlice.ElementDefinition.SliceName;

                ElementTreeNode GetChild(String name)
                {
                    if (this.fragBase.DiffNodes.TryGetElementNode($"{componentSlice.ElementDefinition.ElementId}.{name}", out ElementTreeNode n) == false)
                        throw new Exception($"Cant find child {name}");
                    return n;
                }
                ElementTreeNode codeNode = GetChild("code");
                ElementTreeNode valueNode = GetChild("value[x]");

                CodeableConcept componentCode = (CodeableConcept)codeNode.ElementDefinition.Pattern;
                if (componentCode.Coding.Count != 1)
                    throw new Exception("Invalid component code");
                Coding code = componentCode.Coding[0];

                Int32 max = ToMax(componentSlice.ElementDefinition.Max);
                Int32 min = componentSlice.ElementDefinition.Min.Value;
                String propertyName = sliceName.ToMachineName();

                String componentClassName =
                    DefineComponentsLocalClass(componentSlice, code, max, min, propertyName, valueNode);

                String interfaceName = CSBuilder.InterfaceName(fragBase);
                String className = CSBuilder.ClassName(fragBase);
                this.InterfaceFields
                    .AppendCode($"{componentClassName} {propertyName} {{ get ; }}")
                    ;

                if (this.fragBase.ClassEditor != null)
                {
                    this.ClassFields
                        .AppendCode($"public {componentClassName} {propertyName} {{ get ; protected set; }}")
                        ;
                    this.ClassConstructor
                        .AppendCode($"this.{propertyName} = new {componentClassName}(doc);")
                        ;
                    this.ClassWriteCode
                        .AppendCode($"this.WriteComponent(this.{propertyName});")
                        ;
                    this.ClassReadCode
                        .AppendCode($"this.ReadComponent(this.{propertyName});")
                        ;
                }
            }
        }

        String DefineHasMembersLocalClass(ElementTreeSlice hasMemberSlice,
            Int32 max,
            Int32 min,
            String propertyName,
            String profileUrl)
        {
            String sliceName = hasMemberSlice.ElementDefinition.SliceName;
            String propertyType = profileUrl.LastUriPart();

            String className = $"{propertyName}_Accessor";
            if (this.LocalClassDefs == null)
                return className;

            this.LocalClassDefs
                .SummaryOpen()
                .Summary($"Accessor class for ObservationhasMember slice '{sliceName}'")
                .Summary($"[Fhir Element '{hasMemberSlice.ElementDefinition.ElementId}]'")
                .SummaryClose()
                ;

            if (max == 1)
            {
                this.LocalClassDefs
                    .AppendCode($"public class {className} : ObservationLocal.HasMemberSingle<{propertyType}>")
                    .OpenBrace()
                    .DefineBlock(out CodeBlockNested accessors)
                    .SummaryOpen()
                    .Summary($"Accessor HasMember slice {className} class constructor")
                    .SummaryClose()
                    .AppendCode($"public {className}(BreastRadiologyDocument doc) : base()")
                    .OpenBrace()
                    .AppendCode($"this.Init(doc, {min}, {max}, \"{profileUrl}\");")
                    .CloseBrace()
                    .CloseBrace()
                    ;
            }
            else
            {
                this.LocalClassDefs
                    .AppendCode($"public class {className} : ObservationLocal.HasMemberMultiple<{propertyType}>")
                    .OpenBrace()
                    .DefineBlock(out CodeBlockNested accessors)
                    .SummaryOpen()
                    .Summary($"Accessor HasMember slice {className} class constructor")
                    .SummaryClose()
                    .AppendCode($"public {className}(BreastRadiologyDocument doc) : base()")
                    .OpenBrace()
                    .AppendCode($"this.Init(doc, {min}, {max}, \"{profileUrl}\");")
                    .CloseBrace()
                    .CloseBrace()
                    ;
            }
            return className;
        }

        void DefineHasMembers()
        {
            if (this.fragBase.DiffNodes.TryGetElementNode("Observation.hasMember", out ElementTreeNode hasMemberNode) == false)
                return;

            if (this.fragBase.ClassEditor != null)
            {
                this.ClassWriteCodeStart
                    ?.AppendCode($"this.ClearHasMembers();")
                    ;
            }

            foreach (ElementTreeSlice hasMemberSlice in hasMemberNode.Slices.Skip(1))
            {
                String sliceName = hasMemberSlice.ElementDefinition.SliceName;

                ElementDefinition sliceDef = hasMemberSlice.ElementDefinition;
                Int32 max = ToMax(sliceDef.Max);
                Int32 min = sliceDef.Min.Value;
                String propertyName = sliceName.ToMachineName();

                if (sliceDef.Type.Count != 1)
                    throw new Exception($"Error processing hasMember slice {sliceName}. Expected single type. Got {sliceDef.Type.Count}");
                if (sliceDef.Type[0].Code != "Reference")
                    throw new Exception($"Error processing hasMember slice {sliceName}. Expected type Reference. Got {sliceDef.Type[0].Code}");
                if (sliceDef.Type[0].TargetProfile.Count() != 1)
                    throw new Exception($"Error processing hasMember slice {sliceName}. Expected Target count of 1. Got {sliceDef.Type[0].TargetProfile.Count()}");
                String profileUrl = sliceDef.Type[0].TargetProfile.First();

                String hasMemberClassName =
                    DefineHasMembersLocalClass(hasMemberSlice, max, min, propertyName, profileUrl);

                String interfaceName = CSBuilder.InterfaceName(fragBase);
                String className = CSBuilder.ClassName(fragBase);
                this.InterfaceFields
                    .AppendCode($"{hasMemberClassName} {propertyName} {{ get ; }}")
                    ;

                if (this.fragBase.ClassEditor != null)
                {
                    this.ClassFields
                        .AppendCode($"public {hasMemberClassName} {propertyName} {{ get ; protected set; }}")
                        ;
                    this.ClassConstructor
                        .AppendCode($"this.{propertyName} = new {hasMemberClassName}(doc);")
                        ;
                    this.ClassWriteCode
                        .AppendCode($"this.WriteHasMember(this.{propertyName});")
                        ;
                    this.ClassReadCode
                        .AppendCode($"this.ReadHasMember(this.{propertyName});")
                        ;
                }
            }
        }







        public override void Build()
        {
            const String fcn = "Build";

            this.csBuilder.ConversionInfo(this.GetType().Name,
               fcn,
               $"Building {fragBase.StructDef.Url.LastUriPart()}");

            //Debug.Assert(fragBase.StructDef.Url.LastUriPart().Contains("ObservedChangesFragment") == false);
            base.Build();

            DefineComponents();
            DefineHasMembers();
            this.csBuilder.ConversionInfo(this.GetType().Name,
               fcn,
               $"Completed {fragBase.StructDef.Url.LastUriPart()}");
        }
    }
}
