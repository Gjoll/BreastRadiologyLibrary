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
    class CSDefineExtension : CSDefineBase
    {
        public CSDefineExtension(CSBuilder csBuilder,
                    SDInfo fragBase) : base(csBuilder, fragBase)
        {
        }

        void BuildSimpleExtension(ElementTreeNode valueXNode)
        {
            throw new NotImplementedException("Simple extensions not yet implemented");
        }

        void BuildComplexExternalExtension(ElementTreeSlice extensionSlice, String profile)
        {
        }

        void BuildComplexInternalExtension(ElementTreeSlice extensionSlice)
        {
            String sliceName = extensionSlice.Name;

            void CheckExtension()
            {
                    ElementTreeNode subSubExtensionNode = extensionSlice.Nodes["extension"];
                    if (subSubExtensionNode.ElementDefinition.Max != "0")
                        throw new Exception($"Slice '{sliceName}' sub extension node should be zero cardinality");
            }
            String GetExtensionUrl()
            {
                ElementTreeNode urlNode = extensionSlice.Nodes["url"];
                return ((FhirUrl)urlNode.ElementDefinition.Fixed).Value;
            }

            void GetValueNode(out String typeCode,
                out ElementTreeNode valueXNode)
            {
                valueXNode = extensionSlice.Nodes["value[x]"];
                ElementDefinition valueXElement = valueXNode.ElementDefinition;
                if ((valueXElement.Min.Value != 1) || (valueXElement.Max != "1"))
                        throw new Exception($"Slice '{sliceName}' value[x] node invalid cardinality");
                if (valueXElement.Type.Count != 1)
                    throw new Exception($"{extensionSlice.Name} invalid value[x].type count. Expected 1, got {valueXElement.Type.Count}");
                typeCode = valueXElement.Type[0].Code;
            }

            Int32 cardMin = extensionSlice.ElementDefinition.Min.Value;
            Int32 cardMax = ToMax(extensionSlice.ElementDefinition.Max);

            CheckExtension();
            String extensionUrl = GetExtensionUrl();
            GetValueNode(out String typeCode, out ElementTreeNode valueNode);
            switch (typeCode)
            {
                case "CodeableConcept":
                    BuildPropertyCoding(extensionSlice.ElementDefinition.Max.ToMax(), 
                        sliceName,
                        valueNode,
                        this.ClassProperties);
                    break;

                case "Quantity":
                    break;

                case "Range":
                    break;

                default:
                    throw new NotImplementedException($"Extension value of type {typeCode} not yet implemented.");
            }
        }

        void BuildComplexExtension(ElementTreeNode subExtensionNode)
        {
            foreach (ElementTreeSlice extensionSlice in subExtensionNode.Slices.Skip(1))
            {
                if (extensionSlice.ElementDefinition.Type.Count != 1)
                    throw new Exception($"{extensionSlice.Name} invalid type count. Expected 1, got {extensionSlice.ElementDefinition.Type.Count}");
                ElementDefinition.TypeRefComponent type = extensionSlice.ElementDefinition.Type[0];
                switch (type.Code)
                {
                    case "Extension":
                        if (type.Profile.Count() > 0)
                        {
                            if (type.Profile.Count() != 1)
                                throw new Exception($"Multiple extension profiels not supported");
                            BuildComplexExternalExtension(extensionSlice, type.Profile.First());
                        }
                        else
                            BuildComplexInternalExtension(extensionSlice);
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        public override void Build()
        {
            const String fcn = "Build";

            this.csBuilder.ConversionInfo(this.GetType().Name,
               fcn,
               $"Building {fragBase.StructDef.Url.LastUriPart()}");

            base.Build();
            if (this.fragBase.SnapNodes.TryGetElementNode("Extension.value[x]", out ElementTreeNode valueXNode) == false)
                throw new Exception($"Extension.value[x] is missing");
            if (this.fragBase.SnapNodes.TryGetElementNode("Extension.extension", out ElementTreeNode subExtensionNode) == false)
                throw new Exception($"Extension.extension is missing");
            Int32 valueXCardMax = this.ToMax(valueXNode.ElementDefinition.Max);
            if ((valueXCardMax > 0) && (subExtensionNode.Slices.Count > 0))
                throw new Exception($"Both Simple and Complex extension found. Not implemented");
            else if ((valueXCardMax == 0) && (subExtensionNode.Slices.Count == 0))
                throw new Exception($"Neither Simple and Complex extension found. Not implemented");
            else if (valueXCardMax > 0)
                BuildSimpleExtension(valueXNode);
            else
                BuildComplexExtension(subExtensionNode);

            this.csBuilder.ConversionInfo(this.GetType().Name,
               fcn,
               $"Completed {fragBase.StructDef.Url.LastUriPart()}");
        }
    }
}
