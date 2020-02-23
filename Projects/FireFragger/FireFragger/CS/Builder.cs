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

namespace FireFragger.CS
{
    class Builder : ConverterBase, IDisposable
    {
        String BreakOnClass = "";
        CodeEditor resourceFactoryEditor;
        CodeBlockNested resourceFactoryProfileBlock;

        public Dictionary<String, CSInfo> CodeSystems;
        public Dictionary<String, CSInfo> LocalCodeSystems;
        public Dictionary<String, VSInfo> ValueSets;
        public Dictionary<String, SDInfo> SDFragments;

        public String OutputDir { get; set; } = ".";
        public bool CleanFlag { get; set; } = false;
        FileCleaner fc = new FileCleaner();

        public Builder()
        {
            var comparer = StringComparer.OrdinalIgnoreCase;
            this.CodeSystems = new Dictionary<string, CSInfo>(comparer);
            this.LocalCodeSystems = new Dictionary<string, CSInfo>(comparer);
            this.ValueSets = new Dictionary<string, VSInfo>(comparer);
            this.SDFragments = new Dictionary<string, SDInfo>(comparer);
        }

        public static String MachineName(String s)
        {
            return s.Replace("<", " Less Than ")
            .Replace(">", " Greater Than ")
            .Replace("  ", " ")
            .Replace("  ", " ")
            .ToMachineName();
        }
        public static String CodeName(string code) => $"Code_{MachineName(code)}";
        public static String InterfaceName(SDInfo fi) => $"I{MachineName(fi.StructDef.Name)}";
        public static String ClassName(SDInfo fi) => $"{MachineName(fi.StructDef.Name)}";
        public static String CodeSystemName(CSInfo ci) => $"{MachineName(ci.CodeSystem.Name)}";
        public static String ValueSetName(VSInfo vi) => $"{MachineName(vi.ValueSet.Name)}";
        public static String PropertyName(string name) => $"{MachineName(name)}";

        /// <summary>
        /// Add all fragment resources in indicated directory.
        /// </summary>
        public void AddFragmentDir(String fragDir,
                String searchPattern)
        {
            foreach (String filePath in Directory.GetFiles(fragDir, searchPattern))
            {
                this.AddFragment(filePath);
            }

            foreach (String subDir in Directory.GetDirectories(fragDir))
            {
                this.AddFragmentDir(subDir, searchPattern);
            }
        }

        public void AddFragment(String filePath)
        {
            const String fcn = "AddFragment";

            DomainResource domainResource;

            switch (Path.GetExtension(filePath).ToUpper(CultureInfo.InvariantCulture))
            {
                case ".XML":
                    {
                        FhirXmlParser parser = new FhirXmlParser();
                        domainResource = parser.Parse<DomainResource>(File.ReadAllText(filePath));
                        break;
                    }

                case ".JSON":
                    {
                        FhirJsonParser parser = new FhirJsonParser();
                        domainResource = parser.Parse<DomainResource>(File.ReadAllText(filePath));
                        break;
                    }

                default:
                    throw new Exception($"Unknown extension for serialized fhir resource '{filePath}'");
            }

            switch (domainResource)
            {
                case CodeSystem cs:
                    {
                        CSInfo ci = new CSInfo(cs);
                        this.CodeSystems.Add(cs.Url, ci);
                    }
                    break;

                case ValueSet vs:
                    {
                        VSInfo vi = new VSInfo(vs);
                        this.ValueSets.Add(vs.Url, vi);
                    }
                    break;

                case StructureDefinition sd:
                    {
                        SDInfo fi = new SDInfo(this, sd);
                        this.SDFragments.Add(sd.Url.Trim(), fi);
                    }
                    break;

                default:
                    this.ConversionError(this.GetType().Name,
                       fcn,
                       $"Unimplemented fragment resource type {domainResource.GetType().Name} file {filePath}");
                    return;
            }
        }

        void BuildFragment(SDInfo fi)
        {
            const String fcn = "BuildFragment";

            String fhirType = fi.BaseDefinitionName;
            this.ConversionInfo(this.GetType().Name,
               fcn,
               $"Processing fragment {fi.StructDef.Name}");

            if (String.Compare(ClassName(fi), this.BreakOnClass, StringComparison.OrdinalIgnoreCase) == 0)
                Debugger.Break();

            if (fi.IsFragment() == false)
            {
                String url = fi.StructDef.Url.Trim().ToLower();
                this.resourceFactoryProfileBlock
                    .AppendCode($"case \"{url}\":")
                    .AppendCode($"    return new {ClassName(fi)}(doc, ({fhirType}) resource);")
                    ;
            }

            this.DefineInterfaces(fi);
            DefineBase csDef = null;
            switch (fi.StructDef.BaseDefinition)
            {
                case Global.ExtensionUrl:
                    csDef = new DefineExtension(this, fi);
                    break;
                case Global.ResourceUrl:
                    break;

                case Global.ObservationUrl:
                    csDef = new DefineObservation(this, fi);
                    break;

                case Global.DiagnosticReportUrl:
                    csDef = new DefineDiagnosticReport(this, fi);
                    break;

                case Global.CompositionUrl:
                    csDef = new DefineComposition(this, fi);
                    break;

                case Global.ServiceRequestUrl:
                    csDef = new DefineServiceRequest(this, fi);
                    break;

                default:
                    this.ConversionError(this.GetType().Name,
                       fcn,
                       $"No builder defined for class {fi.StructDef.BaseDefinition}");
                    break;
            }

            if (csDef != null)
            {
                csDef.Clear();
                csDef.DefBase();
                csDef.Build();
            }
        }

        void DefineInterfaces(SDInfo fi)
        {
            StringBuilder interfaces = new StringBuilder();
            SDInfo[] refFrags = fi.DirectReferencedFragments.ToArray();
            if (refFrags.Length > 0)
            {
                if (refFrags.Length == 1)
                {
                    interfaces
                        .AppendLine($": {InterfaceName(refFrags[0])}")
                    ;
                }
                else
                {
                    interfaces
                        .AppendLine($": {InterfaceName(refFrags[0])},")
                    ;
                    for (Int32 i = 1; i < refFrags.Length - 1; i++)
                    {
                        SDInfo refFrag = refFrags[i];
                        interfaces
                            .AppendLine($"        {InterfaceName(refFrag)},")
                        ;
                    }
                    interfaces
                        .AppendLine($"        {InterfaceName(refFrags[refFrags.Length - 1])}")
                    ;
                }
            }

            fi.InterfaceEditor.TryAddUserMacro("Interfaces", interfaces.ToString());
            fi.InterfaceEditor.Blocks.Find("*Header").Reload();
        }


        void Save(CodeEditor code, String path)
        {
            String dir = Path.GetDirectoryName(path);
            if (Directory.Exists(dir) == false)
                Directory.CreateDirectory(dir);
            this.fc.Mark(path);
            code.Save(path);
        }

        void BuildFragments()
        {
            List<SDInfo> unprocessed = new List<SDInfo>();
            unprocessed.AddRange(this.SDFragments.Values);

            bool Buildable(SDInfo fi)
            {
                foreach (SDInfo refFrag in fi.AllReferencedFragments)
                {
                    if (unprocessed.Contains(refFrag) == true)
                        return false;
                }
                return true;
            }

            IEnumerable<SDInfo> OrderedFragments()
            {
                bool buildFlag = true;
                while (unprocessed.Count > 0)
                {
                    if (buildFlag == false)
                        throw new Exception("Unbuildable fragments. Circular reference?");
                    buildFlag = false;
                    Int32 index = 0;
                    while (index < unprocessed.Count)
                    {
                        SDInfo fi = unprocessed[index];
                        if (Buildable(fi))
                        {
                            buildFlag = true;
                            unprocessed.Remove(fi);
                            yield return fi;
                        }
                        else
                            index += 1;
                    }
                }
            }

            foreach (SDInfo fi in OrderedFragments())
                this.BuildFragment(fi);
        }

        /// <summary>
        /// Create local code systems for those that are not defined in this project.
        /// Add all value set codes taht reference this code system into it.
        /// </summary>
        /// <param name="vi"></param>
        void BuildLocalCodeSystem(VSInfo vi)
        {
            foreach (ValueSet.ConceptSetComponent component in vi.ValueSet.Compose.Include)
            {
                foreach (ValueSet.ConceptReferenceComponent concept in component.Concept)
                {
                    // if code system not found
                    if (this.CodeSystems.TryGetValue(component.System, out CSInfo ci) == false)
                    {
                        if (this.LocalCodeSystems.TryGetValue(component.System, out ci) == false)
                        {
                            ci = new CSInfo(new CodeSystem
                            {
                                Name = component.System.LastUriPart(),
                                Url = component.System
                            });
                            this.LocalCodeSystems.Add(component.System, ci);
                        }

                        CodeSystem.ConceptDefinitionComponent c = new CodeSystem.ConceptDefinitionComponent
                        {
                            Code = concept.Code,
                            Display = concept.Display
                        };
                        ci.CodeSystem.Concept.Add(c);
                    }
                }
            }
        }

        void BuildLocalCodeSystems()
        {
            foreach (VSInfo vi in this.ValueSets.Values)
                this.BuildLocalCodeSystem(vi);
            foreach (KeyValuePair<string, CSInfo> item in this.LocalCodeSystems)
                this.CodeSystems.Add(item.Key, item.Value);
            this.LocalCodeSystems = null;
        }

        void BuildValueSet(VSInfo vi)
        {
            vi.ClassCode.Blocks.Find("Fields")
                .DefineBlock(out CodeBlockNested fieldsBlock)
                ;

            vi.ClassCode.Blocks.Find("Methods")
                .DefineBlock(out CodeBlockNested methodBlock)
                ;

            if (vi.ValueSet.Compose.Exclude.Count > 0)
                throw new NotImplementedException("Have not implemented ValueSet.Compose.Exclude");

            methodBlock
                .AppendCode($"public static IEnumerable<TCoding> Codes()")
                .OpenBrace()
                ;
            foreach (ValueSet.ConceptSetComponent component in vi.ValueSet.Compose.Include)
            {
                if (component.Filter.Count > 0)
                    throw new NotImplementedException("Have not implemented ValueSet.Compose.Include.Filter");
                foreach (ValueSet.ConceptReferenceComponent concept in component.Concept)
                {
                    if (this.CodeSystems.TryGetValue(component.System, out CSInfo ci) == false)
                        throw new Exception($"CodeSystem {component.System} not found");
                    String codeName = Builder.CodeName(concept.Code);
                    String codingReference = $"{Builder.CodeSystemName(ci)}.{codeName}";
                    fieldsBlock
                        .AppendCode($"public static TCoding {codeName} = new TCoding({codingReference});")
                        ;
                    methodBlock
                        .AppendCode($"yield return {codeName};")
                        ;
                }
            }

            methodBlock
                .CloseBrace()
                ;
        }

        void BuildValueSets()
        {
            foreach (VSInfo vi in this.ValueSets.Values)
                this.BuildValueSet(vi);
        }

        void BuildCodeSystem(CSInfo ci)
        {
            CodeBlockNested csFields = ci.ClassCode.Blocks.Find("Fields");

            csFields
                .AppendCode($"const string System = \"{ci.CodeSystem.Url}\";");
            ;

            if (ci.CodeSystem.Filter.Count > 0)
                throw new NotImplementedException("Have not implemented CodeSystem.Filter");

            foreach (CodeSystem.ConceptDefinitionComponent component in ci.CodeSystem.Concept)
            {
                String display = component.Display?.Replace("\"", "'");
                String code = component.Code;

                csFields
                    .BlankLine()
                    .AppendLine("/// <summary>")
                    ;
                if (component.Definition != null)
                {
                    foreach (String line in component.Definition.Split('\n'))
                    {
                        String s = line.Trim().Replace("\r", "").Replace("%", "\\%");
                        csFields.AppendLine($"/// {s}");
                    }
                }

                csFields
                    .AppendLine("/// </summary>")
                    .AppendCode($"public static Coding {CodeName(component.Code)} = new Coding(System, \"{code}\", \"{display}\");")
                    ;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        void BuildCodeSystems()
        {
            foreach (CSInfo ci in this.CodeSystems.Values)
                this.BuildCodeSystem(ci);
        }

        void SaveAll()
        {
            this.resourceFactoryEditor.Save();
            this.fc.Mark(this.resourceFactoryEditor.SavePath);
            foreach (SDInfo fi in this.SDFragments.Values)
            {
                this.Save(fi.InterfaceEditor, Path.Combine(this.OutputDir, "Generated", "Interfaces", $"{InterfaceName(fi)}.cs"));
                if (fi.ClassEditor != null)
                {
                    if (fi.IsFragment() == false)
                        this.Save(fi.ClassEditor, Path.Combine(this.OutputDir, "Generated", "Class", $"{ClassName(fi)}.cs"));
                    else
                        this.Save(fi.ClassEditor, Path.Combine(this.OutputDir, "Generated", "Class", $"{ClassName(fi)}.txt"));
                }
                if (fi.SubClassEditor != null)
                    this.Save(fi.SubClassEditor, Path.Combine(this.OutputDir, "Generated", "Class", $"{ClassName(fi)}Local.cs"));
            }

            foreach (CSInfo ci in this.CodeSystems.Values)
                this.Save(ci.ClassCode, Path.Combine(this.OutputDir, "Generated", "CodeSystems", $"{CodeSystemName(ci)}.cs"));

            foreach (VSInfo vi in this.ValueSets.Values)
                this.Save(vi.ClassCode, Path.Combine(this.OutputDir, "Generated", "ValueSets", $"{ValueSetName(vi)}.cs"));
        }

        public void Build()
        {
            CodeEditor.DebugFlag = true;
            this.resourceFactoryEditor = new CodeEditor();
            this.resourceFactoryEditor.Load(Path.Combine(this.OutputDir, "Generated", "ResourceFactory.cs"));
            this.resourceFactoryProfileBlock = this.resourceFactoryEditor.Blocks.Find("Profile");
            this.resourceFactoryProfileBlock.Clear();

            if (Directory.Exists(this.OutputDir) == false)
                Directory.CreateDirectory(this.OutputDir);

            if (this.CleanFlag)
            {
                this.fc = new FileCleaner();
                this.fc.Add(Path.Combine(this.OutputDir, "Generated"));
            }

            this.BuildReferences();
            this.BuildLocalCodeSystems();
            this.BuildCodeSystems();
            this.BuildValueSets();
            this.BuildFragments();
            this.SaveAll();

            this.fc?.Dispose();
        }

        void BuildReferences(SDInfo fi,
            List<SDInfo> references,
            bool recurseFlag)
        {
            const String fcn = "BuildReferences";

            foreach (Extension e in fi.StructDef.Extension.ToArray())
            {
                if (e.Url.ToLower().Trim() == Global.FragmentUrl)
                {
                    FhirUrl extUrl = (FhirUrl)e.Value;
                    if (this.SDFragments.TryGetValue(extUrl.Value.Trim(), out SDInfo reference) == false)
                    {
                        this.ConversionError(this.GetType().Name,
                           fcn,
                           $"Can't find fragment {extUrl}");
                    }
                    else if (references.Contains(reference) == false)
                    {
                        if (recurseFlag)
                            this.BuildReferences(reference, references, recurseFlag);
                        references.Add(reference);
                    }
                }
            }
        }

        void BuildReferences()
        {
            foreach (SDInfo fi in this.SDFragments.Values)
            {
                this.BuildReferences(fi, fi.DirectReferencedFragments, false);
                this.BuildReferences(fi, fi.AllReferencedFragments, true);
            }
        }

        public void Dispose()
        {
            this?.fc.Dispose();
        }
    }
}
