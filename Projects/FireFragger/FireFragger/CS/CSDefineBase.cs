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
    abstract class CSDefineBase
    {
        protected CSBuilder csBuilder;
        protected SDInfo fragBase;

        protected CodeBlockNested ClassFields => fragBase.ClassEditor.Blocks.Find("Fields", false);
        protected CodeBlockNested ClassConstructor => fragBase.ClassEditor.Blocks.Find("Constructor", false);
        protected CodeBlockNested ClassMethods => fragBase.ClassEditor.Blocks.Find("Methods", false);
        protected CodeBlockNested ClassWriteCode => fragBase.ClassEditor.Blocks.Find("WriteCode", false);
        protected CodeBlockNested ClassReadCode => fragBase.ClassEditor.Blocks.Find("ReadCode", false);

        protected CodeBlockNested InterfaceFields => fragBase.InterfaceEditor.Blocks.Find("Fields", false);
        protected CodeBlockNested InterfaceMethods => fragBase.InterfaceEditor.Blocks.Find("Methods", false);

        protected delegate void VisitFragment(SDInfo fi, Int32 level);
        protected String FhirBase => this.fragBase.StructDef.BaseDefinition.LastUriPart();

        protected void VisitFragments(VisitFragment vi,
            SDInfo fragBase)
        {
            HashSet<SDInfo> visitedFrags = new HashSet<SDInfo>();

            void Visit(VisitFragment vi,
                SDInfo fi,
                Int32 level)
            {
                if (visitedFrags.Contains(fi))
                    return;
                vi(fi, level);
                visitedFrags.Add(fi);
                foreach (SDInfo refFrag in fragBase.ReferencedFragments)
                    Visit(vi, refFrag, level + 1);
            }

            Visit(vi, fragBase, 0);
        }

        protected String[] References(ElementTreeNode entryNode)
        {
            List<ElementDefinition.TypeRefComponent> types = entryNode.ElementDefinition.Type;
            if (types.Count != 1)
                throw new Exception($"SingleReference. Invalid type count. Epected 1, got {types.Count}.");

            ElementDefinition.TypeRefComponent type = types[0];
            if (type.Code != "Reference")
                throw new Exception($"SingleReference. Invalid type code. Expected 'Reference', got {type.Code}.");
            List<String> retVal = new List<string>();
            foreach (String targetProfile in type.TargetProfile)
                retVal.Add(targetProfile);
            return retVal.ToArray();
        }

        public CSDefineBase(CSBuilder csBuilder,
                    SDInfo fragBase)
        {
            this.csBuilder = csBuilder;
            this.fragBase = fragBase;
        }

        public abstract void Build();

        protected void MergeFragments()
        {
            foreach (SDInfo fiRef in this.fragBase.ReferencedFragments)
                MergeFragment(fiRef);
        }

        protected void MergeFragment(SDInfo fi)
        {
            const String fcn = "MergeFragment";

            this.csBuilder.ConversionInfo(this.GetType().Name,
               fcn,
               $"Integrating fragment {fi.StructDef.Url.LastUriPart()}");
            if (fi != fragBase)
            {
                if (fi.InterfaceEditor != null)
                {
                    CodeBlockMerger cbm = new CodeBlockMerger(fragBase.InterfaceEditor);
                    cbm.Merge(this.InterfaceFields);
                    cbm.Merge(this.InterfaceMethods);
                }
                if (fi.ClassEditor != null)
                {
                    CodeBlockMerger cbm = new CodeBlockMerger(fragBase.ClassEditor);
                    cbm.Merge(this.ClassFields);
                    cbm.Merge(this.ClassMethods);
                }
            }
        }


        Int32 defIndex = 1;

        void DefineDefaultElement(ElementDefinition elementDefinition)
        {
            if (elementDefinition.Min == 0)
                return;
            if (elementDefinition.DefaultValue == null)
                return;
            String[] pathElements = elementDefinition.Path.Split('.').ToArray();
            if (pathElements.Length != 2)
                return;

            this.ClassMethods
                .SummaryOpen()
                .Summary($"Method to create default value for element")
                .Summary($"{elementDefinition.ElementId}")
                .SummaryClose()
                ;
            String methodName = $"DefaultValue_{defIndex++}";
            FhirConstruct.Construct(this.ClassMethods, elementDefinition.DefaultValue, methodName, out String propertyType);
            this.ClassConstructor
                .AppendLine($"this.Resource.{pathElements[1].ToMachineName()} = {methodName}();")
                ;
        }

        void DefineDefaultElements()
        {
            foreach (ElementDefinition elementDefinition in this.fragBase.DiffNodes.ElementDefinitions)
                DefineDefaultElement(elementDefinition);
        }

        public void DefineBase()
        {
            if (this.fragBase.ClassEditor == null)
                return;
            DefineDefaultElements();
            String profileUrl = this.fragBase.StructDef.Url;
            this.ClassConstructor
                .AppendCode($"SetProfileUrl(\"{profileUrl}\");")
                ;
        }
    }
}
