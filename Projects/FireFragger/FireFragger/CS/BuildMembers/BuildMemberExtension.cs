using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace FireFragger.CS.BuildMembers
{
    /// <summary>
    /// </summary>
    internal class BuildMemberExtension
    {
        protected Builder csBuilder => this.defineBase.CSBuilder;
        protected DefineBase defineBase;
        protected ClassCodeBlocks codeBlocks;
        protected ElementTreeSlice extensionSlice;
        String extensionName;

        public BuildMemberExtension(DefineBase defineBase,
            ClassCodeBlocks codeBlocks,
            ElementTreeSlice extensionSlice,
            String extensionName)
        {
            this.extensionName = extensionName;
            this.defineBase = defineBase;
            this.codeBlocks = codeBlocks;
            this.extensionSlice = extensionSlice;
        }

        void BuildOneComplexExtension(String extensionName)
        {
            BuildMemberExtensionComplex bm = new BuildMemberExtensionComplex(this.defineBase,
                this.codeBlocks,
                this.extensionSlice,
                extensionName);
            bm.Build();
        }

        void BuildOneSimpleExtension(String extensionName)
        {
            BuildMemberExtensionSimple bm = new BuildMemberExtensionSimple(this.defineBase,
                this.codeBlocks,
                this.extensionSlice,
                extensionName);
            bm.Build();
        }

        /// <summary>
        /// Extension is a reference to a predefined extension. Build a reference to the
        /// class that implements that extension.
        /// </summary>
        void BuildExtensionReference(ElementDefinition extensionDef)
        {
            const String fcn = "BuildExtensionReference";

            if (extensionDef.Type[0].Profile.Count() > 1)
            {
                this.defineBase.CSBuilder.ConversionError(this.GetType().Name,
                    fcn,
                    $"Don't know how to handle multiple extension type profiles.");
                return;
            }
            String extensionUrl = extensionDef.Type[0].Profile.First();
            if (extensionUrl.StartsWith(Global.BreastRadBaseUrl) == false)
            {
                this.defineBase.CSBuilder.ConversionError(this.GetType().Name,
                    fcn,
                    $"Don't know how to handle externally defined extension profiles.");
                return;
            }

            String extensionClass = CSMisc.ClassName(extensionUrl.LastUriPart());
            String propertyName = this.extensionSlice.ElementDefinition.SliceName.ToMachineName();

            this.codeBlocks.LocalUsings
                .AppendUniqueLine($"using {CSMisc.LocalClassNameSpace(extensionClass)}")
                ;
            this.codeBlocks.ClassProperties
                .AppendCode($"M{extensionClass} {propertyName};")
                ;

            Int32 min = this.extensionSlice.ElementDefinition.Min.Value;
            Int32 max = this.extensionSlice.ElementDefinition.Max.ToMax();
            this.codeBlocks.ClassConstructor
                .AppendCode($"this.{propertyName} = new M{extensionClass}({min}, {max});")
                ;

            this.codeBlocks.ClassWriteCode
                .AppendCode($"items.AddRange(this.{propertyName}.Write(doc));")
                ;

            this.codeBlocks.ClassReadCode
                .AppendCode($"this.{propertyName}.Read(doc, extensions);")
                ;

        }

        /// <summary>
        /// Build a class to implement an extension.
        /// This determines if a simple extension is to be defined,
        /// or a complex extension.
        /// </summary>
        public void Build()
        {
            //$ TODO: Implement validation

            const String fcn = "Build";
            ElementDefinition extensionDef = this.extensionSlice.ElementDefinition;
            if (
                (extensionDef.Type.Count == 1) &&
                (extensionDef.Type[0].Code == "Extension")
                )
            {
                if (extensionDef.Type[0].Profile.Count() > 0)
                {
                    if (extensionDef.Type[0].Profile.Count() != 1)
                        throw new Exception($"Invalid extension ProfileProfile definition {this.extensionName}");
                    if (this.extensionSlice.Nodes.Count > 0)
                        throw new Exception($"Invalid eternal extension {this.extensionName}. Nodes.Count ==  {this.extensionSlice.Nodes.Count}. Expected 0.");
                    BuildExtensionReference(extensionDef);
                    return;
                }
            }

            ElementTreeNode valueXNode = this.extensionSlice.Nodes.GetItem("value[x]");
            ElementTreeNode subExtensionNode = this.extensionSlice.Nodes.GetItem("extension");
            Int32 valueXCardMax = CSMisc.ToMax(valueXNode.ElementDefinition.Max);

            if ((valueXCardMax != 0) && (subExtensionNode.Slices.Count > 1))
            {
                // Cant build both simple and complex extension.
                throw new Exception($"Both Simple and Complex extension found. Not implemented");
            }
            else if ((valueXCardMax == 0) && (subExtensionNode.Slices.Count == 0))
            {
                // Neither simple and complex extension?
                throw new Exception($"Neither Simple and Complex extension found. Not implemented");
            }
            else if (valueXCardMax != 0)
            {
                // Build Simple Extension
                this.BuildOneSimpleExtension(this.extensionName);
            }
            else
            {
                // Build Complex Extension
                this.BuildOneComplexExtension(this.extensionName);
            }
        }
    }
}
