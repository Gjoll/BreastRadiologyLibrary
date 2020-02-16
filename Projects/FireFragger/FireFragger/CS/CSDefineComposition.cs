﻿using FhirKhit.Tools;
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
    class CSDefineComposition : CSDefineBase
    {
        public CSDefineComposition(CSBuilder csBuilder,
                    SDInfo fragBase) : base(csBuilder, fragBase)
        {
        }

        String FhirType(String url)
        {
            if (url.Trim().ToLower().StartsWith("http://hl7.org/fhir/structuredefinition/"))
                return url.LastUriPart();
            if (this.csBuilder.SDFragments.TryGetValue(url, out SDInfo fragInfo) == false)
                throw new Exception($"{url.LastUriPart()} not found");
            return fragInfo.BaseDefinitionName;
        }

        String BRClass(String url)
        {
            if (url.Trim().ToLower().StartsWith("http://hl7.org/fhir/structuredefinition/"))
                return "ResourceBase";
            String reference = url.LastUriPart();
            return reference;
        }

        String DefineSectionLocalClass(ElementTreeSlice sectionSlice,
            Coding code,
            Int32 max,
            Int32 min,
            String title,
            String propertyName,
            String[] references,
            String brClass)
        {
            String className = $"{propertyName}_Accessor";
            if (this.ClassLocalClassDefs == null)
                return className;

            this.ClassLocalClassDefs
                .SummaryOpen()
                .Summary($"Accessor class for '{title}'")
                .Summary($"[Fhir Element '{sectionSlice.ElementDefinition.ElementId}]'")
                .SummaryClose()
                .AppendCode($"public class {className} : SectionBase<{brClass}>")
                .OpenBrace()
                //.AppendCode($"// Definitions")
                //.DefineBlock(out CodeBlockNested definitionsBlock)
                //.BlankLine()
                //.DefineBlock(out CodeBlockNested fieldsBlock)
                //.BlankLine()
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
                .AppendCode($"this.Create(doc, \"{title}\", {min}, {max}, new Coding(\"{code.System}\", \"{code.Code}\"));")
                .DefineBlock(out CodeBlockNested constructorBlock)
                .CloseBrace()
                .CloseBrace()
                ;

            //propertiesBlock
            //    ;

            //fieldsBlock
            //    ;

            if (max == 1)
            {
                propertiesBlock
                    .SummaryOpen()
                    .Summary("Access propertyName")
                    .SummaryClose()
                    .AppendCode($"public {brClass} Item")
                    .OpenBrace()
                    .AppendCode($"get => this.GetSingleItem<{brClass}> ();")
                    .CloseBrace()
                    ;

                foreach (String target in references)
                {
                    String targetName = target.LastUriPart();
                    String fhirType = this.FhirType(target);
                    String propertyType = this.BRClass(target);
                    methodsBlock
                        .BlankLine()
                        .SummaryOpen()
                        .Summary($"Create new blank {propertyName} of type {fhirType}")
                        .SummaryClose()
                        ;
                    if (fhirType == "Resource")
                    {
                        methodsBlock
                            .AppendCode($"public {propertyType} Create{targetName}({fhirType} fhirItem)")
                            .OpenBrace()
                            ;
                    }
                    else
                    {
                        methodsBlock
                            .AppendCode($"public {propertyType} Create{targetName}({fhirType} fhirItem = null)")
                            .OpenBrace()
                            .AppendCode($"if (fhirItem == null) fhirItem = new {fhirType}();")
                            ;
                    }
                    methodsBlock
                        .AppendCode($"{propertyType} brItem = new {propertyType}();")
                        .AppendCode($"brItem.Create(this.doc, fhirItem);")
                        .AppendCode($"this.AppendItem(brItem);")
                        .AppendCode($"return brItem;")
                        .CloseBrace()
                        ;
                }
            }
            else
            {
                propertiesBlock
                    .SummaryOpen()
                    .Summary("Access propertyName")
                    .SummaryClose()
                    .AppendCode($"public IEnumerable<{brClass}> Items => this.items;")
                    .BlankLine()
                    .SummaryOpen()
                    .Summary("Access first item in list or defrault if no first item")
                    .SummaryClose()
                    .AppendCode($"public {brClass} First() => this.items.First();")
                    .BlankLine()
                    .SummaryOpen()
                    .Summary("Access first item in list")
                    .SummaryClose()
                    .AppendCode($"public {brClass} FirstOrDefault() => this.items.FirstOrDefault();")
                    ;

                foreach (String target in references)
                {
                    String targetName = target.LastUriPart();
                    String fhirType = this.FhirType(target);
                    String propertyType = this.BRClass(target);
                    methodsBlock
                        .BlankLine()
                        .SummaryOpen()
                        .Summary($"Create new blank {propertyName} of type {fhirType} and add to end of list")
                        .SummaryClose()
                        ;

                    if (fhirType == "Resource")
                    {
                        methodsBlock
                            .AppendCode($"public {propertyType} Add{targetName}({fhirType} fhirItem)")
                            .OpenBrace()
                            ;
                    }
                    else
                    {
                        methodsBlock
                            .AppendCode($"public {propertyType} Add{targetName}({fhirType} fhirItem = null)")
                            .OpenBrace()
                            .AppendCode($"if (fhirItem == null) fhirItem = new {fhirType}();")
                            ;
                    }
                    methodsBlock
                        .AppendCode($"{propertyType} brItem = new {propertyType}();")
                        .AppendCode($"brItem.Create(this.doc, fhirItem);")
                        .AppendCode($"this.AppendItem(brItem);")
                        .AppendCode($"return brItem;")
                        .CloseBrace();
                        ;
                }
            }
            return className;
        }


        void DefineSections()
        {
            Int32 ToMax(String max)
            {
                if (max == "*")
                    return -1;
                return Int32.Parse(max);
            }

            if (this.fragBase.DiffNodes.TryGetElementNode("Composition.section", out ElementTreeNode sectionNode) == false)
                return;

            this.ClassWriteCode
                .AppendCode($"ClearSection();")
                ;

            foreach (ElementTreeSlice sectionSlice in sectionNode.Slices.Skip(1))
            {
                String sliceName = sectionSlice.ElementDefinition.SliceName;

                ElementTreeNode GetChild(String name)
                {
                    if (this.fragBase.DiffNodes.TryGetElementNode($"{sectionSlice.ElementDefinition.ElementId}.{name}", out ElementTreeNode n) == false)
                        throw new Exception($"Cant find child {name}");
                    return n;
                }
                ElementTreeNode titleNode = GetChild("title");
                ElementTreeNode codeNode = GetChild("code");
                ElementTreeNode entryNode = GetChild("entry");

                String title = titleNode.ElementDefinition.Fixed.ToString();
                CodeableConcept sectionCode = (CodeableConcept)codeNode.ElementDefinition.Pattern;
                if (sectionCode.Coding.Count != 1)
                    throw new Exception("Invalid section code");
                Coding code = sectionCode.Coding[0];

                String[] references = this.References(entryNode);

                Int32 max = ToMax(entryNode.ElementDefinition.Max);
                Int32 min = entryNode.ElementDefinition.Min.Value;
                String propertyName = sliceName.ToMachineName();

                String brClass;

                if (references.Length == 1)
                    brClass = BRClass(references[0]);
                else
                    brClass = "ResourceBase";

                String sectionClassName =
                    DefineSectionLocalClass(sectionSlice, code, max, min, title, propertyName, references, brClass);

                this.ClassFields
                    .AppendCode($"public {sectionClassName} {propertyName} {{ get ; protected set; }}")
                    ;
                this.ClassConstructor
                    .AppendCode($"this.{propertyName} = new {sectionClassName}(doc);")
                    ;
                String className = CSBuilder.ClassName(fragBase);
                this.InterfaceFields
                    .AppendCode($"{className}.{sectionClassName} {propertyName} {{ get ; }}")
                    ;

                this.ClassWriteCode
                    .AppendCode($"this.WriteSection(this.{propertyName});")
                    ;

                this.ClassReadCode
                    .AppendCode($"this.ReadSection(this.{propertyName});")
                    ;
            }
        }

        public override void Build()
        {
            const String fcn = "Build";

            this.csBuilder.ConversionInfo(this.GetType().Name,
               fcn,
               $"Building {fragBase.StructDef.Url.LastUriPart()}");

            this.ClassFields.Clear();
            this.ClassMethods.Clear();
            this.ClassConstructor.Clear();

            this.InterfaceFields.Clear();
            this.InterfaceMethods.Clear();
            this.MergeFragments();
            this.DefineSections();
            this.csBuilder.ConversionInfo(this.GetType().Name,
               fcn,
               $"Completed {fragBase.StructDef.Url.LastUriPart()}");
        }
    }
}
