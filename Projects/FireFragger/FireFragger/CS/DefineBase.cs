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
    abstract class DefineBase
    {
        public Builder CSBuilder;
        protected SDInfo fragBase;
        protected delegate void VisitFragment(SDInfo fi, Int32 level);

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
                foreach (SDInfo refFrag in fragBase.AllReferencedFragments)
                    Visit(vi, refFrag, level + 1);
            }

            Visit(vi, fragBase, 0);
        }

        public DefineBase(Builder csBuilder,
                    SDInfo fragBase)
        {
            this.CSBuilder = csBuilder;
            this.fragBase = fragBase;
        }

        public void Clear()
        {
            //this.fragBase.ClassProperties?.Clear();
            //this.fragBase.ClassMethods?.Clear();
            //this.fragBase.ClassConstructor?.Clear();
        }

        /// <summary>
        /// We hard code bodySite to be a reference to a hand coded body referrence
        /// class.
        /// </summary>
        protected void DefineBodySite()
        {
            String baseName = this.fragBase.StructDef.Differential.Element[0].Path;
            if (this.fragBase.DiffNodes.TryGetElementNode($"{baseName}.bodySite",
                out ElementTreeNode bodySiteNode) == false)
                return;
            if (this.fragBase.DiffNodes.TryGetElementNode($"{baseName}.bodySite.extension",
                out ElementTreeNode bodySiteExtensionNode) == false)
                return;
            if (bodySiteExtensionNode.Slices.Count <= 1)
                return;
            Int32 min = bodySiteNode.ElementDefinition.Min.Value;
            Int32 max = CSMisc.ToMax(bodySiteNode.ElementDefinition.Max);
            if (max != 1)
                throw new Exception($"Expected bodySite max of 1");
            this.fragBase.ClassProperties
                .AppendCode($"public TItemElementSingle<BodySiteExtended> BodySite {{ get; private set; }}")
                ;
            this.fragBase.ClassConstructor
                .AppendCode($"this.BodySite = new TItemElementSingle<BodySiteExtended>(\"BodySite\", {min}, {max});")
                ;
            this.fragBase.ClassReadCode
                .AppendCode($"this.ReadElement(this.BodySite);")
                ;
            this.fragBase.ClassWriteCode
                .AppendCode($"this.WriteElement(this.BodySite);")
                ;
        }

        public virtual void Build()
        {
            this.MergeFragments();
        }

        /// <summary>
        /// Merge code blocks in eah referencedframent into mqin class.
        /// This is not done for the interfaces, only the class.
        /// </summary>
        protected void MergeFragments()
        {
            if (this.fragBase.IsFragment() == true)
                return;

            CodeBlockNested usingBlock = this.fragBase.ClassEditor.Blocks.Find("Usings", false);

            foreach (SDInfo fiRef in this.fragBase.AllReferencedFragments)
            {
                usingBlock.AppendUniqueLine($"using {CSMisc.LocalClassNameSpace(fiRef)}");
                this.MergeFragment(fiRef);
            }
        }

        protected void MergeFragment(SDInfo fi)
        {
            const String fcn = "MergeFragment";

            this.CSBuilder.ConversionInfo(this.GetType().Name,
               fcn,
               $"Integrating fragment {fi.StructDef.Url.LastUriPart()}");

            if (fi != this.fragBase)
            {
                if (fi.ClassEditor != null)
                {
                    CodeBlockMerger cbm = new CodeBlockMerger(this.fragBase.ClassEditor);
                    foreach (CodeBlockNested codeBlock in fi.ClassEditor.Blocks.AllNamedBlocks)
                        cbm.Merge(codeBlock);
                }
            }
        }

        public String DefineFixed(String path, Element fixedValue)
        {

            if (this.fragBase.StructDef.Url.LastUriPart().Contains("ObservedFeature") == true)
                Trace.WriteLine("xxyyz");
            this.fragBase.ClassMethods
                .SummaryOpen()
                .Summary($"Method to create fixed value")
                .SummaryClose()
                ;
            String methodName = $"FixedValue_{path}".ToMachineName();
            FhirConstruct.Construct(this.fragBase.ClassMethods, fixedValue, methodName, out String propertyType);
            return methodName;
        }

        void DefineDefaultElement(CodeBlockNested constructCode,
            ElementDefinition elementDefinition)
        {
            if (elementDefinition.Min == 0)
                return;
            Element defaultValueElement = elementDefinition.DefaultValueExtension();
            if (defaultValueElement == null)
                return;
            String[] pathElements = elementDefinition.Path.Split('.').ToArray();
            if (pathElements.Length != 2)
                return;
            String methodName = DefineFixed(elementDefinition.ElementId, defaultValueElement);
            constructCode
                .AppendCode($"this.Resource.{elementDefinition.Path.LastPathPart().ToMachineName()} = {methodName}();")
                ;
        }

        void DefineBinding(ElementDefinition elementDefinition)
        {
            if (CSMisc.BindingClassName(elementDefinition,
                out String bindingClassName,
                out ElementDefinition.ElementDefinitionBindingComponent binding) == false)
                return;

            String fieldName = $"{elementDefinition.Path.LastPathPart().ToMachineName()}";
            String methodName = $"Set{elementDefinition.Path.LastPathPart().ToMachineName()}";
            String fhirFieldName = $"{elementDefinition.Path.LastPathPart().ToMachineName()}";
            switch (fhirFieldName)
            {
                case "ValueX":
                    fhirFieldName = "Value";
                    break;
            }
            String thisClass = CSMisc.ClassName(this.fragBase);
            this.fragBase.ClassMethods
                .SummaryOpen()
                .Summary($"Set {elementDefinition.ElementId} to one of the predefined items")
                .SummaryClose()
                .AppendCode($"public void {methodName}({bindingClassName} code)")
                .OpenBrace()
                .IfElse(elementDefinition.Base.Max == "1",
                    code1 => code1.AppendCode($"this.Resource.{fhirFieldName} = ({elementDefinition.Type[0].Code}) code;"),
                    code1 => code1.AppendCode($"this.Resource.{fhirFieldName}.Add(({elementDefinition.Type[0].Code}) code);")
                    )
                .CloseBrace()
                ;
        }

        void DefineCodeElements()
        {
            foreach (ElementDefinition elementDefinitionDiff in this.fragBase.DiffNodes.ElementDefinitions)
            {
                if (this.fragBase.SnapNodes.TryGetElementNode(elementDefinitionDiff.ElementId,
                   out ElementTreeNode snapNode) == false)
                    throw new Exception($"error finding snapnode");
                ElementDefinition elementDefinition = snapNode.ElementDefinition;
                String[] pathElements = elementDefinition.Path.Split('.').ToArray();
                if (pathElements.Length == 2)
                {
                    this.DefineDefaultElement(this.fragBase.ClassConstructor, elementDefinition);
                    this.DefineBinding(elementDefinition);
                }
            }
        }

        public void DefBase()
        {
            if (this.fragBase.ClassEditor == null)
                return;
            this.DefineCodeElements();
            String profileUrl = this.fragBase.StructDef.Url;
            if (this.fragBase.IsFragment() == false)
            {
                this.fragBase.ClassConstructor
                    .AppendCode($"SetProfileUrl(\"{profileUrl}\");")
                    ;
            }
        }
    }
}
