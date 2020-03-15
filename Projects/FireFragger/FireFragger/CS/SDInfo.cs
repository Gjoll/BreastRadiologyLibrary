using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace FireFragger.CS
{
    [DebuggerDisplay("{StructDef.Url}")]
    class SDInfo
    {
        public List<SDInfo> DirectReferencedFragments = new List<SDInfo>();
        public List<SDInfo> AllReferencedFragments = new List<SDInfo>();
        public StructureDefinition StructDef;
        public ElementTreeNode DiffNodes;
        public ElementTreeNode SnapNodes;

        public CodeEditor InterfaceEditor;
        public CodeEditor ClassEditor;
        public CodeEditor SubClassEditor;
        public ClassCodeBlocks CodeBlocks;

        public CodeBlockNested ClassProperties => this.CodeBlocks.ClassProperties;
        public CodeBlockNested ClassConstructor => CodeBlocks.ClassConstructor;
        public CodeBlockNested ClassMethods => CodeBlocks.ClassMethods;
        public CodeBlockNested ClassValidateCodeStart => CodeBlocks.ClassValidateCodeStart;
        public CodeBlockNested ClassValidateCode => CodeBlocks.ClassValidateCode;
        public CodeBlockNested ClassWriteCodeStart => CodeBlocks.ClassWriteCodeStart;
        public CodeBlockNested ClassWriteCode => CodeBlocks.ClassWriteCode;
        public CodeBlockNested ClassReadCodeStart => CodeBlocks.ClassReadCodeStart;
        public CodeBlockNested ClassReadCode => CodeBlocks.ClassReadCode;

        public CodeBlockNested LocalClassDefs => CodeBlocks.LocalClassDefs;

        public CodeBlockNested InterfaceProperties => CodeBlocks.InterfaceProperties;
        public CodeBlockNested InterfaceMethods => CodeBlocks.InterfaceMethods;

        public String FhirBase => this.StructDef.BaseDefinition.LastUriPart();

        public SDInfo(IConversionInfo ci, StructureDefinition sd)
        {
            this.StructDef = sd;
            ElementTreeLoader l = new ElementTreeLoader(ci);
            if (sd.Snapshot == null)
                SnapshotCreator.Create(sd);

            this.DiffNodes = l.Create(sd.Differential.Element);
            this.SnapNodes = l.Create(sd.Snapshot.Element);

            this.InterfaceEditor = new CodeEditor();
            this.InterfaceEditor.TryAddUserMacro("ClassName", CS.CSMisc.ClassName(this));
            this.InterfaceEditor.TryAddUserMacro("InterfaceName", CS.CSMisc.InterfaceName(this));
            this.InterfaceEditor.Load(Path.Combine("Templates", "Interface.txt"));
            this.AddMacros(this.InterfaceEditor, this);

            this.SubClassEditor = new CodeEditor();
            this.AddMacros(this.SubClassEditor, this);
            this.SubClassEditor.TryAddUserMacro("FhirBase", this.StructDef.BaseDefinition.LastUriPart());
            this.SubClassEditor.TryAddUserMacro("BaseClass", CS.CSMisc.ClassName(this));
            this.SubClassEditor.Load(Path.Combine("Templates", "SubClass.txt"));

            this.ClassEditor = new CodeEditor();
            this.AddMacros(this.ClassEditor, this);
            this.ClassEditor.TryAddUserMacro("ClassName", CS.CSMisc.ClassName(this));
            if (this.IsFragment())
                this.ClassEditor.Load(Path.Combine("Templates", "Fragment.txt"));
            else
                this.ClassEditor.Load(Path.Combine("Templates", "Class.txt"));

            this.CodeBlocks = ClassCodeBlocks.Create(this.InterfaceEditor,
                    this.ClassEditor,
                    this.SubClassEditor);
        }

        public String BaseDefinitionUrl => this.StructDef.BaseDefinition;
        public String BaseDefinitionName => this.BaseDefinitionUrl.LastUriPart();

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
