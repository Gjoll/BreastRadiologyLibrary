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

        String FhirType(String url)
        {
            if (url.Trim().ToLower().StartsWith("http://hl7.org/fhir/structuredefinition/"))
                return url.LastUriPart();
            if (this.csBuilder.SDFragments.TryGetValue(url, out FragInfo fragInfo) == false)
                throw new Exception($"{url.LastUriPart()} not found");
            return fragInfo.BaseDefinitionName;
        }

        void CreateKnownResourceType(String className, 
            String fhirType,
            String pName, 
            String fName)
        {
            this.ClassFields
                .BlankLine()
                .SummaryOpen()
                .Summary($"Append new blank {pName}")
                .SummaryClose()
                .AppendCode($"public {className} Append{pName}({fhirType} resource = null)")
                .OpenBrace()
                .AppendCode($"if (resource == null)")
                .AppendCode($"    resource = new {fhirType}();")
                .AppendCode($"{className} retVal = new {className}(this.doc, resource);")
                .AppendCode($"this.{fName}.Add(retVal);")
                .AppendCode($"return retVal;")
                .CloseBrace()
                ;
        }

        String BRClass(String url)
        {
            if (url.Trim().ToLower().StartsWith("http://hl7.org/fhir/structuredefinition/"))
                return "ResourceBase";
            String reference = url.LastUriPart();
            return reference;
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
                String brClass;

                if (references.Length == 1)
                    brClass = BRClass(references[0]);
                else
                    brClass = "ResourceBase";

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
                        .AppendCode($"{brClass} {fieldName};")
                        .BlankLine()
                        .SummaryOpen()
                        .Summary("Access propertyName")
                        .SummaryClose()
                        .AppendCode($"public {brClass} {propertyName} => this.{fieldName};")

                        .BlankLine()
                        .SummaryOpen()
                        .Summary("Create new blank {propertyName}")
                        .SummaryClose()
                        .AppendCode($"public {brClass} Create{propertyName}()")
                        .OpenBrace()
                        .AppendCode($"if (this.{propertyName} != null)")
                        .AppendCode($"    throw new Exception(\"{propertyName} already has a value\");")
                        .AppendCode($"{brClass} retVal = new {brClass}(this.doc);")
                        .AppendCode($"this.{fieldName} = retVal;")
                        .AppendCode($"return retVal;")
                        .CloseBrace()
                        ;

                    this.ClassReadCode
                        .BlankLine()
                        .AppendCode($"this.{fieldName} = ReadSection<{brClass}>(this.{sectionCodeName});")
                        ;
                }
                else
                {
                    this.ClassFields
                        .BlankLine()
                        .SummaryOpen()
                        .Summary("propertyName field")
                        .SummaryClose()
                        .AppendCode($"List<{brClass}> {fieldName} = new List<{brClass}>();")
                        .BlankLine()
                        .SummaryOpen()
                        .Summary("Access propertyName")
                        .SummaryClose()
                        .AppendCode($"public IEnumerable<{brClass}> {propertyName} => this.{fieldName};")
                        ;

                    if (references.Length == 1)
                    {
                        if (brClass == "ResourceBase")
                            CreateUnknownResourceType("ResourceBase", "DomainResource", propertyName, fieldName);
                        else
                            CreateKnownResourceType(brClass, FhirType(references[0]), propertyName, fieldName);
                    }
                    else
                    {
                        foreach (String target in references)
                        {
                            if (target.Trim().ToLower().StartsWith("http://hl7.org/fhir/structuredefinition/"))
                            {
                                CreateKnownResourceType("ResourceBase", FhirType(target), propertyName, fieldName);
                            }
                            else
                            {
                                CreateKnownResourceType(BRClass(target), FhirType(target), propertyName, fieldName);
                            }
                        }
                    }

                    this.ClassReadCode
                        .AppendCode($"ReadSection<{brClass}>({sectionCodeName}, {min}, {max}, this.{fieldName});")
                        ;
                }

                this.ClassWriteCode
                    .AppendCode($"WriteSection<{brClass}>(\"{title}\", {sectionCodeName}, {min}, {max}, this.{fieldName});")
                    ;

                if (max == 1)
                    this.InterfaceFields
                            .AppendCode($"{brClass} {propertyName} {{ get; set; }}")
                        ;
                else
                    this.InterfaceFields
                            .AppendCode($"List<{brClass}> {propertyName} {{ get; }}")
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
