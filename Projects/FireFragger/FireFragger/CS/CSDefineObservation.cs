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

        void DefineComponents(SDInfo fragInfo)
        {
            CodeBlockNested classComponentFields = null;
            CodeBlockNested classComponentConstruction = null;
            CodeBlockNested classComponentWrite = null;
            CodeBlockNested classComponentRead = null;
            CodeBlockNested interfaceComponentFields = null;

            if (fragInfo.ClassEditor != null)
            {
                classComponentFields = fragInfo.ClassEditor.Blocks.Find("Fields").AppendBlock("");
                classComponentConstruction = fragInfo.ClassEditor.Blocks.Find("Constructor").AppendBlock("");
                classComponentWrite = fragInfo.ClassEditor.Blocks.Find("WriteCode").AppendBlock(""); ;
                classComponentRead = fragInfo.ClassEditor.Blocks.Find("ReadCode").AppendBlock(""); ;

                classComponentFields.Clear();
                classComponentConstruction.Clear();
                classComponentWrite.Clear();
                classComponentRead.Clear();
            }

            interfaceComponentFields = fragInfo.InterfaceEditor.Blocks.Find("Fields").AppendBlock("");
            interfaceComponentFields.Clear();

            HashSet<string> items = new HashSet<string>();
            void BuildSlice(SDInfo fi, ElementTreeSlice slice, Int32 level)
            {
                if (slice.Nodes.TryGetItem("code", out ElementTreeNode codeNode) == false)
                    throw new Exception($"Cant find component.code");
                if (slice.Nodes.TryGetItem("value[x]", out ElementTreeNode valueXNode) == false)
                    throw new Exception($"Can't find component.value[x]");

                if (items.Contains(slice.Name))
                    return;
                items.Add(slice.Name);

                String fieldName;

                if (valueXNode.ElementDefinition.Type.Count == 1)
                {
                    ElementDefinition.TypeRefComponent valueXType = valueXNode.ElementDefinition.Type[0];
                    fieldName = CSBuilder.PropertyName(slice.Name);
                    switch (valueXNode.ElementDefinition.Max)
                    {
                        case "0": throw new Exception($"Unexpected cardinality 0f 0");
                        case "1":
                            //$classComponentFields?
                            //    .AppendCode($"public {valueXType.Code} {fieldName} {{ get; set; }}")
                            //    ;
                            //classComponentWrite?
                            //    .AppendCode($"this.WriteComponent({fieldName});")
                            //    ;
                            //classComponentWrite?
                            //    .AppendCode($"{fieldName} = this.ReadComponent();")
                            //    ;
                            break;
                        default:
                            break;
                    }
                    //$classComponentFields?.AppendCode($"public ComponentList<{valueXType.Code}> {fieldName} {{ get; protected set; }}");
                    //if (level == 0)
                    //    interfaceComponentFields.AppendCode($"ComponentList<{valueXType.Code}> {fieldName} {{ get; protected set; }}");

                    Int32 min = 0;
                    if (slice.ElementDefinition.Min.HasValue)
                        min = slice.ElementDefinition.Min.Value;
                    Int32 max = -1;
                    if (String.IsNullOrEmpty(slice.ElementDefinition.Max) == false)
                    {
                        if (slice.ElementDefinition.Max != "*")
                            max = Int32.Parse(slice.ElementDefinition.Max);
                    }

                    //$classComponentConstruction?.AppendCode($"this.{fieldName} = CreateComponentList<{valueXType.Code}>({min}, {max});");
                }
                else if (valueXNode.ElementDefinition.Type.Count > 1)
                {
                }
                else
                    throw new Exception($"invalid component type count");

            }

            void Build(SDInfo fi, Int32 level)
            {
                if (fi.BaseDefinitionUrl != Global.ObservationUrl)
                    return;
                if (fi.DiffNodes.TryGetElementNode("Observation.component", out ElementTreeNode componentNode) == false)
                    return;
                if (componentNode.Slices.Count <= 1)
                    return;
                foreach (ElementTreeSlice slice in componentNode.Slices.Skip(1))
                    BuildSlice(fi, slice, level);
            }

            if (fragInfo.ClassEditor == null)
                return;

            VisitFragments(Build, fragInfo);
        }

        void DefineHasMembers(SDInfo fragInfo)
        {
            CodeBlockNested classHasMemberFields = null;
            CodeBlockNested classHasMemberConstruction = null;
            CodeBlockNested interfaceHasMemberFields = null;

            if (fragInfo.ClassEditor != null)
            {
                classHasMemberFields = fragInfo.ClassEditor.Blocks.Find("Fields").AppendBlock("");
                classHasMemberConstruction = fragInfo.ClassEditor.Blocks.Find("Constructor").AppendBlock("");
            }
            interfaceHasMemberFields = fragInfo.InterfaceEditor.Blocks.Find("Fields").AppendBlock("");

            HashSet<string> items = new HashSet<string>();

            void BuildSlice(SDInfo fi, ElementTreeSlice slice, Int32 level)
            {
                if (slice.ElementDefinition.Type.Count != 1)
                    throw new Exception($"invalid hasMember type count");
                if (slice.ElementDefinition.Type[0].Code != "Reference")
                    throw new Exception($"invalid hasMember type");
                if (slice.ElementDefinition.Type[0].TargetProfile.Count() != 1)
                    throw new Exception($"invalid hasMember targetProfile count");
                String reference = slice.ElementDefinition.Type[0].TargetProfile.First();
                if (this.csBuilder.SDFragments.TryGetValue(reference.Trim(), out SDInfo refFrag) == false)
                    throw new Exception($"missing hasMember reference {reference}");
                if (items.Contains(slice.Name))
                    return;

                items.Add(slice.Name);
                String refClassName = CSBuilder.ClassName(refFrag);
                String refInterfaceName = CSBuilder.InterfaceName(refFrag);
                String fieldName = CSBuilder.PropertyName(slice.Name);

                classHasMemberFields?.AppendCode($"public MemberList<{refInterfaceName}> {fieldName} {{ get; protected set; }}");
                if (level == 0)
                    interfaceHasMemberFields.AppendCode($"MemberList<{refInterfaceName}> {fieldName} {{ get; }}");

                Int32 min = 0;
                if (slice.ElementDefinition.Min.HasValue)
                    min = slice.ElementDefinition.Min.Value;
                Int32 max = -1;
                if (String.IsNullOrEmpty(slice.ElementDefinition.Max) == false)
                {
                    if (slice.ElementDefinition.Max != "*")
                        max = Int32.Parse(slice.ElementDefinition.Max);
                }

                classHasMemberConstruction?.AppendCode($"this.{fieldName} = CreateHasMemberList<{refInterfaceName}>({min}, {max});");
            }

            void Build(SDInfo fi, Int32 level)
            {
                if (fi.BaseDefinitionUrl != Global.ObservationUrl)
                    return;
                if (fi.DiffNodes.TryGetElementNode("Observation.hasMember", out ElementTreeNode hasMemberNode) == false)
                    return;
                if (hasMemberNode.Slices.Count <= 1)
                    return;
                foreach (ElementTreeSlice slice in hasMemberNode.Slices.Skip(1))
                    BuildSlice(fi, slice, level);
            }

            if (fragInfo.ClassEditor == null)
                return;

            VisitFragments(Build, fragInfo);
        }

        public override void Build()
        {
            DefineHasMembers(this.fragBase);
            DefineComponents(this.fragBase);
        }
    }
}
