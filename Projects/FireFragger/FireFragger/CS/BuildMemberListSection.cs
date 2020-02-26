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
    /// Build the class that implements a list of coded references, such as
    /// Observation.hasMember
    /// </summary>
    internal class BuildMemberListSection : BuildMemberListBase
    {
        ElementTreeNode DiffNodes;
        ElementTreeNode SnapNodes;

        public BuildMemberListSection(Builder csBuilder,
            ClassCodeBlocks fragBase,
            ElementTreeNode snapNodes,
            ElementTreeNode diffNodes) : base(csBuilder, fragBase, "Section")
        {
            this.DiffNodes = diffNodes;
            this.SnapNodes = snapNodes;
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
            if (this.codeBlocks.LocalClassDefs == null)
                return className;

            this.codeBlocks.LocalClassDefs
                .SummaryOpen()
                .Summary($"Accessor class for '{title}'")
                .Summary($"[Fhir Element '{sectionSlice.ElementDefinition.ElementId}]'")
                .SummaryClose()
                .AppendCode($"public class {className} : MemberListSectionBase<{brClass}>")
                .OpenBrace()
                .DefineBlock(out CodeBlockNested propertiesBlock)
                .BlankLine()
                .DefineBlock(out CodeBlockNested methodsBlock)
                .BlankLine()
                .SummaryOpen()
                .Summary($"Accessor class constructor")
                .SummaryClose()
                .AppendCode($"public {className}(BreastRadiologyDocument doc) : base(\"{className}\")")
                .OpenBrace()
                .AppendCode($"this.Init(doc, \"{title}\", {min}, {max}, new Coding(\"{code.System}\", \"{code.Code}\"));")
                .DefineBlock(out CodeBlockNested constructorBlock)
                .CloseBrace()
                .CloseBrace()
                ;

            if (max == 1)
            {
                void DefineCreate(String fhirType, String propertyType, String targetName)
                {
                    propertiesBlock
                        .BlankLine()
                        .SummaryOpen()
                        .Summary($"Create new blank {propertyName} if one doesnt already exist, and return it")
                        .SummaryClose()
                        .AppendCode($"public {propertyType} Create{targetName}()")
                        .OpenBrace()
                        .AppendCode($"if (this.Count == 0)")
                        .OpenBrace()
                        .AppendCode($"{propertyType} brItem = new {propertyType}();")
                        .AppendCode($"brItem.Init(this.doc);")
                        .AppendCode($"this.AppendItem(brItem);")
                        .CloseBrace()
                        .AppendCode($"return this.First();")
                        .CloseBrace()
                        ;
                }

                propertiesBlock
                    .SummaryOpen()
                    .Summary("Access propertyName")
                    .SummaryClose()
                    .AppendCode($"public {brClass} Get() => this.FirstOrDefault();")
                    ;

                if (references.Length == 1)
                {
                    String fhirType = this.csBuilder.FhirClass(references[0]);
                    String propertyType = CSMisc.BRClass(references[0]);
                    DefineCreate(fhirType, propertyType, "");
                }
                else
                {
                    foreach (String target in references)
                    {
                        String targetName = target.LastUriPart();
                        String fhirType = this.csBuilder.FhirClass(target);
                        String propertyType = CSMisc.BRClass(target);
                        DefineCreate(fhirType, propertyType, targetName);
                    }
                }
            }
            else
            {
                void DefineAppend(String fhirType, String propertyType, String targetName)
                {
                    methodsBlock
                        .BlankLine()
                        .SummaryOpen()
                        .Summary($"Create new blank {propertyName} of type {fhirType} and add to end of list")
                        .SummaryClose()

                        .IfElse(propertyType == "ResourceBase",
                            code1 => code1.AppendCode($"public {propertyType} Append{targetName}(Resource r)"),
                            code1 => code1.AppendCode($"public {propertyType} Append{targetName}()")
                        )
                        .OpenBrace()
                        .AppendCode($"{propertyType} brItem = new {propertyType}();")
                        .IfElse(propertyType == "ResourceBase",
                            code1 => code1.AppendCode($"brItem.Init(this.doc, r);"),
                            code1 => code1.AppendCode($"brItem.Init(this.doc);")
                        )
                        .AppendCode($"this.AppendItem(brItem);")
                        .AppendCode($"return brItem;")
                        .CloseBrace();
                    ;
                }

                propertiesBlock
                    .SummaryOpen()
                    .Summary("Access propertyName")
                    .SummaryClose()
                    .AppendCode($"public IEnumerable<{brClass}> All() => this.items;")

                    .BlankLine()
                    .SummaryOpen()
                    .Summary("Access item at indicated location in list")
                    .SummaryClose()
                    .AppendCode($"public {brClass} At(Int32 i) => base.items[i];")

                    .BlankLine()
                    .SummaryOpen()
                    .Summary("Access first item in list")
                    .SummaryClose()
                    .AppendCode($"public new {brClass} First() => base.First();")
                    .BlankLine()
                    .SummaryOpen()
                    .Summary("Access first item in list or default value if empty")
                    .SummaryClose()
                    .AppendCode($"public new {brClass} FirstOrDefault() => base.FirstOrDefault();")
                    ;

                if (references.Length == 1)
                {
                    String fhirType = this.csBuilder.FhirClass(references[0]);
                    String propertyType = CSMisc.BRClass(references[0]);
                    DefineAppend(fhirType, propertyType, "");
                }
                else
                {
                    foreach (String target in references)
                    {
                        String targetName = target.LastUriPart();
                        String fhirType = this.csBuilder.FhirClass(target);
                        String propertyType = CSMisc.BRClass(target);
                        DefineAppend(fhirType, propertyType, targetName);
                    }
                }
            }
            return className;
        }


        public void Define()
        {
            if (this.DiffNodes.TryGetElementNode("Composition.section", out ElementTreeNode sectionNode) == false)
                return;

            this.codeBlocks.ClassWriteCode
                .AppendCode($"ClearSection();")
                ;

            foreach (ElementTreeSlice sectionSlice in sectionNode.Slices.Skip(1))
            {
                String sliceName = sectionSlice.ElementDefinition.SliceName;

                ElementTreeNode GetChild(String name)
                {
                    if (this.DiffNodes.TryGetElementNode($"{sectionSlice.ElementDefinition.ElementId}.{name}", out ElementTreeNode n) == false)
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

                String[] references = CSMisc.References(entryNode);

                Int32 max = CSMisc.ToMax(entryNode.ElementDefinition.Max);
                Int32 min = entryNode.ElementDefinition.Min.Value;
                String propertyName = sliceName.ToMachineName();

                String brClass;

                if (references.Length == 1)
                    brClass = CSMisc.BRClass(references[0]);
                else
                    brClass = "ResourceBase";
                String sectionClassName =
                    this.DefineSectionLocalClass(sectionSlice, code, max, min, title, propertyName, references, brClass);
                this.DefineCommon(sectionClassName, propertyName, "Section");
            }
        }
    }
}
