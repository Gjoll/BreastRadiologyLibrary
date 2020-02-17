using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FireFragger
{
    class SDInfo
    {
        public List<SDInfo> ReferencedFragments = new List<SDInfo>();
        public StructureDefinition StructDef;
        public CodeEditor InterfaceEditor;
        public CodeEditor ClassEditor;
        public CodeEditor SubClassEditor;
        public ElementTreeNode DiffNodes;

        public String BaseDefinitionUrl => this.StructDef.BaseDefinition;
        public String BaseDefinitionName => this.BaseDefinitionUrl.LastUriPart();

        public SDInfo(IConversionInfo ci, StructureDefinition sd)
        {
            this.StructDef = sd;
            ElementTreeLoader l = new ElementTreeLoader(ci);
            InterfaceEditor = new CodeEditor();
            DiffNodes = l.Create(sd.Differential.Element);

            this.InterfaceEditor.TryAddUserMacro("ClassName", CSBuilder.ClassName(this));
            this.InterfaceEditor.TryAddUserMacro("InterfaceName", CSBuilder.InterfaceName(this));
            this.InterfaceEditor.Load(Path.Combine("Templates", "Interface.txt"));
            this.AddMacros(this.InterfaceEditor, this);

            this.SubClassEditor = new CodeEditor();
            this.AddMacros(this.SubClassEditor, this);

            this.SubClassEditor.TryAddUserMacro("FhirBase", this.StructDef.BaseDefinition.LastUriPart());
            this.SubClassEditor.TryAddUserMacro("BaseClass", CSBuilder.ClassName(this));
            this.SubClassEditor.Load(Path.Combine("Templates", "SubClass.txt"));

            if (this.IsFragment() == false)
            {
                this.ClassEditor = new CodeEditor();
                this.AddMacros(this.ClassEditor, this);
                this.ClassEditor.TryAddUserMacro("ClassName", CSBuilder.ClassName(this));
                this.ClassEditor.Load(Path.Combine("Templates", "Class.txt"));
            }
        }

        public void SetInterfaces(String interfaces)
        {
            this.InterfaceEditor.TryAddUserMacro("Interfaces", interfaces);
            this.InterfaceEditor.Blocks.Find("*Header").Reload();
            if (this.ClassEditor != null)
            {
                this.ClassEditor.TryAddUserMacro("Interfaces", interfaces);
                this.ClassEditor.Blocks.Find("*Header").Reload();
            }
        }

        void AddMacros(CodeEditor ce,
            SDInfo fi)
        {
            ce.TryAddUserMacro("FhirBase", fi.StructDef.BaseDefinition.LastUriPart());
        }

        public bool IsFragment()
        {
            Extension isFragmentExtension = this.StructDef.GetExtension(Global.IsFragmentExtensionUrl);
            return (isFragmentExtension != null);
        }
    };
}
