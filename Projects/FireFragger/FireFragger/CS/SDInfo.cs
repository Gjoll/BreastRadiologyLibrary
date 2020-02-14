using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FireFragger
{
    class SDInfo
    {
        public List<SDInfo> ReferencedFragments = new List<SDInfo>();
        public StructureDefinition StructDef;
        public CodeEditor InterfaceEditor;
        public CodeEditor ClassEditor;
        public ElementTreeNode DiffNodes;

        public String BaseDefinitionUrl => this.StructDef.BaseDefinition;
        public String BaseDefinitionName => this.BaseDefinitionUrl.LastUriPart();

        public SDInfo(IConversionInfo ci, StructureDefinition sd)
        {
            this.StructDef = sd;
            ElementTreeLoader l = new ElementTreeLoader(ci);
            InterfaceEditor = new CodeEditor();
            DiffNodes = l.Create(sd.Differential.Element);
        }
    };
}
