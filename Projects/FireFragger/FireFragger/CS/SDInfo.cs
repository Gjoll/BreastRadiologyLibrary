using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace FireFragger
{
    [DebuggerDisplay("{StructDef.Url}")]
    class SDInfo
    {
        public List<SDInfo> DirectReferencedFragments = new List<SDInfo>();
        public List<SDInfo> AllReferencedFragments = new List<SDInfo>();
        public StructureDefinition StructDef;
        public CodeEditor InterfaceEditor;
        public CodeEditor ClassEditor;
        public CodeEditor SubClassEditor;
        public ElementTreeNode DiffNodes;
        public ElementTreeNode SnapNodes;

        public CodeBlockNested ClassFields => this.ClassEditor?.Blocks.Find("Fields", false);
        public CodeBlockNested LocalClassDefs => this.SubClassEditor?.Blocks.Find("LocalClassDefs", false);
        public CodeBlockNested ClassConstructor => this.ClassEditor?.Blocks.Find("Constructor", false);
        public CodeBlockNested ClassMethods => this.ClassEditor?.Blocks.Find("Methods", false);
        public CodeBlockNested ClassValidateCodeStart => this.ClassEditor?.Blocks.Find("ValidateCodeStart", false);
        public CodeBlockNested ClassValidateCode => this.ClassEditor?.Blocks.Find("ValidateCode", false);
        public CodeBlockNested ClassWriteCodeStart => this.ClassEditor?.Blocks.Find("WriteCodeStart", false);
        public CodeBlockNested ClassWriteCode => this.ClassEditor?.Blocks.Find("WriteCode", false);
        public CodeBlockNested ClassReadCodeStart => this.ClassEditor?.Blocks.Find("ReadCodeStart", false);
        public CodeBlockNested ClassReadCode => this.ClassEditor?.Blocks.Find("ReadCode", false);
        public CodeBlockNested InterfaceFields => this.InterfaceEditor?.Blocks.Find("Fields", false);
        public CodeBlockNested InterfaceMethods => this.InterfaceEditor?.Blocks.Find("Methods", false);
        public String FhirBase => this.StructDef.BaseDefinition.LastUriPart();

        public SDInfo(IConversionInfo ci, StructureDefinition sd)
        {
            this.StructDef = sd;
            ElementTreeLoader l = new ElementTreeLoader(ci);
            if (sd.Snapshot == null)
                SnapshotCreator.Create(sd);

            this.InterfaceEditor = new CodeEditor();
            this.DiffNodes = l.Create(sd.Differential.Element);
            this.SnapNodes = l.Create(sd.Snapshot.Element);

            this.InterfaceEditor.TryAddUserMacro("ClassName", CSBuilder.ClassName(this));
            this.InterfaceEditor.TryAddUserMacro("InterfaceName", CSBuilder.InterfaceName(this));
            this.InterfaceEditor.Load(Path.Combine("Templates", "Interface.txt"));
            this.AddMacros(this.InterfaceEditor, this);

            this.SubClassEditor = new CodeEditor();
            this.AddMacros(this.SubClassEditor, this);

            this.SubClassEditor.TryAddUserMacro("FhirBase", this.StructDef.BaseDefinition.LastUriPart());
            this.SubClassEditor.TryAddUserMacro("BaseClass", CSBuilder.ClassName(this));
            this.SubClassEditor.Load(Path.Combine("Templates", "SubClass.txt"));

            this.ClassEditor = new CodeEditor();
            this.AddMacros(this.ClassEditor, this);
            this.ClassEditor.TryAddUserMacro("ClassName", CSBuilder.ClassName(this));
            if (this.IsFragment())
                this.ClassEditor.Load(Path.Combine("Templates", "Fragment.txt"));
            else
                this.ClassEditor.Load(Path.Combine("Templates", "Class.txt"));
        }

        public String BaseDefinitionUrl => this.StructDef.BaseDefinition;
        public String BaseDefinitionName => this.BaseDefinitionUrl.LastUriPart();


        public void SetInterfaces(String interfaces)
        {
            this.InterfaceEditor.TryAddUserMacro("Interfaces", interfaces);
            this.InterfaceEditor.Blocks.Find("*Header").Reload();
            if (this.ClassEditor != null)
            {
                this.ClassEditor.TryAddUserMacro("Interfaces", interfaces);
                this.ClassEditor.Blocks.Find("*Header")?.Reload();
            }
        }

        public bool IsFragment()
        {
            Extension isFragmentExtension = this.StructDef.GetExtension(Global.IsFragmentExtensionUrl);
            return (isFragmentExtension != null);
        }

        void AddMacros(CodeEditor ce,
            SDInfo fi)
        {
            ce.TryAddUserMacro("FhirBase", fi.StructDef.BaseDefinition.LastUriPart());
        }
    };
}
