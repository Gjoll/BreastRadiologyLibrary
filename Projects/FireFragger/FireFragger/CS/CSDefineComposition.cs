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
    class CSDefineComposition : CSDefineBase
    {
        public CSDefineComposition(CSBuilder csBuilder,
                    FragInfo fragBase) : base(csBuilder, fragBase)
        {
        }

        void CreateUnknownResourceType(String className, String resourceName, String propertyName, String fieldName)
        {
            this.ClassFields
                .BlankLine()
                .SummaryOpen()
                .Summary($"Append new blank {propertyName} of type {className}")
                .SummaryClose()
                .AppendCode($"public {className} Append{propertyName}({resourceName} resource)")
                .OpenBrace()
                .AppendCode($"{className} retVal = new {className}(this.doc, resource);")
                .AppendCode($"this.{fieldName}.Add(retVal);")
                .AppendCode($"return retVal;")
                .CloseBrace()
                ;
        }

        void CreateKnownResourceType(String className, String pName, String fName)
        {
            this.ClassFields
                .BlankLine()
                .SummaryOpen()
                .Summary($"Append new blank {pName}")
                .SummaryClose()
                .AppendCode($"public {className} Append{pName}()")
                .OpenBrace()
                .AppendCode($"{className} retVal = new {className}(this.doc);")
                .AppendCode($"this.{fName}.Add(retVal);")
                .AppendCode($"return retVal;")
                .CloseBrace()
                ;
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
                String reference;

                String TargetClass(String url)
                {
                    reference = url.LastUriPart();
                    if (url.Trim().ToLower().StartsWith("http://hl7.org/fhir/structuredefinition/"))
                        reference += "Base";
                    return reference;
                }

                if (references.Length == 1)
                    reference = TargetClass(references[0]);
                else
                    reference = "ResourceBase";

                Int32 max = ToMax(entryNode.ElementDefinition.Max);
                Int32 min = entryNode.ElementDefinition.Min.Value;
                String propertyName = sliceName.ToMachineName();
                String fieldName = sliceName.ToLocalName();
                String sectionCodeName = $"{propertyName}SectionCode";

                this.ClassFields
                    .BlankLine()
                    .SummaryOpen()
                    .Summary($"Section {sliceName}")
                    .Summary($"{sectionSlice.ElementDefinition.ElementId}")
                    .SummaryClose()
                    .AppendCode($"Coding {sectionCodeName} = new Coding(\"{code.System}\", \"{code.Code}\");")
                    ;

                if (max == 1)
                {
                    this.ClassFields
                        .BlankLine()
                        .SummaryOpen()
                        .Summary("propertyName field")
                        .SummaryClose()
                        .AppendCode($"{reference} {fieldName};")
                        .BlankLine()
                        .SummaryOpen()
                        .Summary("Access propertyName")
                        .SummaryClose()
                        .AppendCode($"public {reference} {propertyName} => this.{fieldName};")

                        .BlankLine()
                        .SummaryOpen()
                        .Summary("Create new blank {propertyName}")
                        .SummaryClose()
                        .AppendCode($"public {reference} Create{propertyName}()")
                        .OpenBrace()
                        .AppendCode($"if (this.{propertyName} != null)")
                        .AppendCode($"    throw new Exception(\"{propertyName} already has a value\");")
                        .AppendCode($"{reference} retVal = new {reference}(this.doc);")
                        .AppendCode($"this.{fieldName} = retVal;")
                        .AppendCode($"return retVal;")
                        .CloseBrace()
                        ;

                    this.ClassReadCode
                        .BlankLine()
                        .AppendCode($"this.{fieldName} = ReadSection<{reference}>(this.{sectionCodeName});")
                        ;
                }
                else
                {
                    this.ClassFields
                        .BlankLine()
                        .SummaryOpen()
                        .Summary("propertyName field")
                        .SummaryClose()
                        .AppendCode($"List<{reference}> {fieldName} = new List<{reference}>();")
                        .BlankLine()
                        .SummaryOpen()
                        .Summary("Access propertyName")
                        .SummaryClose()
                        .AppendCode($"public IEnumerable<{reference}> {propertyName} => this.{fieldName};")
                        ;


                    if (references.Length == 1)
                    {
                        if (reference == "Resource")
                            CreateUnknownResourceType("ResourceBase", "Resource", propertyName, fieldName);
                        else
                            CreateKnownResourceType(reference, propertyName, fieldName);
                    }
                    else
                    {
                        foreach (String target in references)
                        {
                            String shortName = target.LastUriPart();
                            String targetName = $"{shortName}Base";
                            CreateUnknownResourceType(targetName, "xxyyz", $"{propertyName}_{shortName}", fieldName);
                        }
                    }

                    this.ClassReadCode
                        .AppendCode($"ReadSection<{reference}>({sectionCodeName}, {min}, {max}, this.{fieldName});")
                        ;
                }

                this.ClassWriteCode
                    .AppendCode($"WriteSection<{reference}>(\"{title}\", {sectionCodeName}, {min}, {max}, this.{fieldName});")
                    ;

                if (max == 1)
                    this.InterfaceFields
                            .AppendCode($"{reference} {propertyName} {{ get; set; }}")
                        ;
                else
                    this.InterfaceFields
                            .AppendCode($"List<{reference}> {propertyName} {{ get; }}")
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
            this.DefineBase();
            this.DefineSections();
            this.csBuilder.ConversionInfo(this.GetType().Name,
               fcn,
               $"Completed {fragBase.StructDef.Url.LastUriPart()}");
        }
    }
}
