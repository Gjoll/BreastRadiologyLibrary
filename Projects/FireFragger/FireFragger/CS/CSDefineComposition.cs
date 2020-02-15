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
                    SDInfo fragBase) : base(csBuilder, fragBase)
        {
        }

        void CreateUnknownResourceType(CodeBlockNested fields,
            String className,
            String resourceName,
            String propertyName,
            String fieldName)
        {
            fields
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
            if (this.csBuilder.SDFragments.TryGetValue(url, out SDInfo fragInfo) == false)
                throw new Exception($"{url.LastUriPart()} not found");
            return fragInfo.BaseDefinitionName;
        }

        void CreateKnownResourceType(CodeBlockNested fields,
            String className,
            String pName,
            String fName,
            bool nullFlag)
        {
            String nullText = nullFlag ? "" : " = null";

            fields
                .BlankLine()
                .SummaryOpen()
                .Summary($"Append new blank {pName}")
                .SummaryClose()
                .AppendCode($"public {className} Append{pName}({className} brClass{nullText})")
                .OpenBrace()
                .AppendCode($"if (brClass == null)")
                .AppendCode($"    brClass = new {className}(this.doc);")
                .AppendCode($"this.{fName}.Add(brClass);")
                .AppendCode($"return brClass;")
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
                .AppendCode($"public class {className}")
                .OpenBrace()
                .AppendCode($"// Definitions")
                .DefineBlock(out CodeBlockNested definitionsBlock)
                .BlankLine()
                .AppendCode($"// Fields")
                .DefineBlock(out CodeBlockNested fieldsBlock)
                .BlankLine()
                .AppendCode($"// Properties")
                .DefineBlock(out CodeBlockNested propertiesBlock)
                .BlankLine()
                .AppendCode($"// Methods")
                .DefineBlock(out CodeBlockNested methodsBlock)
                .BlankLine()
                .SummaryOpen()
                .Summary($"Accessor class constructor")
                .SummaryClose()
                .AppendCode($"public {className}(BreastRadiologyDocument doc)")
                .OpenBrace()
                .AppendLine($"this.doc = doc;")
                .DefineBlock(out CodeBlockNested constructorBlock)
                .CloseBrace()
                .CloseBrace()
                ;


            propertiesBlock
                .SummaryOpen()
                .Summary("Access Min cardinality")
                .SummaryClose()
                .AppendCode($"public Int32 Min => {min};")

                .BlankLine()
                .SummaryOpen()
                .Summary("Access Max cardinality")
                .SummaryClose()
                .AppendCode($"public Int32 Max => {max};")

                .BlankLine()
                .SummaryOpen()
                .Summary("Section Title")
                .SummaryClose()
                .AppendCode($"public String SectionTitle => \"{title}\";")

                .BlankLine()
                .SummaryOpen()
                .Summary("Section Code system")
                .SummaryClose()
                .AppendCode($"public String SectionCodeSystem => \"{code.System}\";")

                .BlankLine()
                .SummaryOpen()
                .Summary("Section Code")
                .SummaryClose()
                .AppendCode($"public String SectionCodeCode => \"{code.Code}\";")

                .BlankLine()
                .SummaryOpen()
                .Summary("Section coding")
                .SummaryClose()
                .AppendCode($"public Coding SectionCode => new Coding(SectionCodeSystem, SectionCodeCode);")
                ;

            fieldsBlock
                .SummaryOpen()
                .Summary("Parent document")
                .SummaryClose()
                .AppendCode($"BreastRadiologyDocument doc;")
                ;
            if (max == 1)
            {
                fieldsBlock
                    .BlankLine()
                    .SummaryOpen()
                    .Summary("Section item")
                    .SummaryClose()
                    .AppendCode($"{brClass} item;")
                    ;

                propertiesBlock
                    .Summary("Access propertyName")
                    .SummaryClose()
                    .AppendCode($"public {brClass} Item")
                    .OpenBrace()
                    .AppendCode($"get => this.item;")
                    .AppendCode($"set => this.item = value;")
                    .CloseBrace()
                    ;

                methodsBlock
                    .BlankLine()
                    .SummaryOpen()
                    .Summary($"Create new blank {propertyName}")
                    .SummaryClose()
                    .AppendCode($"public {brClass} Create()")
                    .OpenBrace()
                    .AppendCode($"if (this.Item != null)")
                    .AppendCode($"    throw new Exception(\"Item already has a value\");")
                    .AppendCode($"{brClass} retVal = new {brClass}(this.doc);")
                    .AppendCode($"this.item = retVal;")
                    .AppendCode($"return retVal;")
                    .CloseBrace()
                    .AppendCode($"public void Read(List<{brClass}> items)")
                    .OpenBrace()
                    .AppendCode($"if (this.Item != null)")
                    .AppendCode($"    throw new Exception(\"Item already has a value\");")
                    .AppendCode($"if (items.Count == 0)")
                    .AppendCode($"    return;")
                    .AppendCode($"if (items.Count == 1)")
                    .OpenBrace()
                    .AppendCode($"this.item = items[0];")
                    .CloseBrace()
                    .AppendCode($"throw new Exception(\"Unexpected multiple items. Expected single item\");")
                    .CloseBrace()
                    ;
                ;
            }
            else
            {
                fieldsBlock
                    .BlankLine()
                    .SummaryOpen()
                    .Summary("Section items list")
                    .SummaryClose()
                    .AppendCode($"List<{brClass}> items = new List<{brClass}>();")
                    ;

                propertiesBlock
                    .Summary("Access propertyName")
                    .SummaryClose()
                    .AppendCode($"public IEnumerable<{brClass}> Items => this.items;")
                    ;

                if (references.Length == 1)
                {
                    if (brClass == "ResourceBase")
                        CreateUnknownResourceType(fieldsBlock, "ResourceBase", "DomainResource", propertyName, "items");
                    else
                        CreateKnownResourceType(fieldsBlock, brClass, propertyName, "items", true);
                }
                else
                {
                    foreach (String target in references)
                    {
                        if (target.Trim().ToLower().StartsWith("http://hl7.org/fhir/structuredefinition/"))
                            CreateUnknownResourceType(fieldsBlock, "ResourceBase", FhirType(target), propertyName, "items");
                        else
                            CreateKnownResourceType(fieldsBlock, BRClass(target), propertyName, "items", false);
                    }
                }

                methodsBlock
                    .AppendCode($"public void Read(List<{brClass}> items)")
                    .OpenBrace()
                    .AppendCode($"if (this.items.Count > 0)")
                    .AppendCode($"    throw new Exception(\"Item already has a value\");")
                    .AppendCode($"if (items.Count < Min)")
                    .AppendCode($"    throw new Exception(\"Minimum cardinality error. Expected at least {{Min}}, got {{items.Count}}\");")
                    .AppendCode($"if (items.Count > Max)")
                    .AppendCode($"    throw new Exception(\"Maximum cardinality error. Expected no more than {{Max}}, got {{items.Count}}\");")
                    .AppendCode($"this.items = items;")
                    .CloseBrace()
                    ;
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
                    .AppendCode($"{sectionClassName} {propertyName} {{ get ; }}")
                    ;
                this.ClassConstructor
                    .AppendCode($"this.{propertyName} = new {sectionClassName}(doc);")
                    ;
                String className = CSBuilder.ClassName(fragBase);
                this.InterfaceFields
                    .AppendCode($"{className}.{sectionClassName} {propertyName} {{ get ; }}")
                    ;

                //this.ClassWriteCode
                //    .AppendCode($"WriteSection<{brClass}>(\"{title}\", {sectionCodeName}, {min}, {max}, this.{fieldName});")
                //    ;

                this.ClassReadCode
                    .OpenBrace()
                    .AppendCode($"var items = ReadSection<{brClass}>(this.{propertyName}.SectionTitle,")
                    .AppendCode($"    this.{propertyName}.SectionCode,")
                    .AppendCode($"    this.{propertyName}.Min,")
                    .AppendCode($"    this.{propertyName}.Max);")
                    .AppendCode($"this.{propertyName}.Read(items);")
                    .CloseBrace()
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
