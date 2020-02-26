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
        public ClassCodeBlocks CodeBlocks = new ClassCodeBlocks();
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

        public CodeEditor ClassEditor => this.CodeBlocks.ClassEditor;
        public CodeEditor SubClassEditor => this.CodeBlocks.SubClassEditor;
        public CodeEditor InterfaceEditor => this.CodeBlocks.InterfaceEditor;

        public String FhirBase => this.StructDef.BaseDefinition.LastUriPart();

        public SDInfo(IConversionInfo ci, StructureDefinition sd)
        {
            this.StructDef = sd;
            ElementTreeLoader l = new ElementTreeLoader(ci);
            if (sd.Snapshot == null)
                SnapshotCreator.Create(sd);

            this.DiffNodes = l.Create(sd.Differential.Element);
            this.SnapNodes = l.Create(sd.Snapshot.Element);

            this.CodeBlocks.InterfaceEditor.TryAddUserMacro("ClassName", CS.CSMisc.ClassName(this));
            this.CodeBlocks.InterfaceEditor.TryAddUserMacro("InterfaceName", CS.CSMisc.InterfaceName(this));
            this.CodeBlocks.InterfaceEditor.Load(Path.Combine("Templates", "Interface.txt"));
            this.AddMacros(this.CodeBlocks.InterfaceEditor, this);

            this.AddMacros(this.CodeBlocks.SubClassEditor, this);

            this.CodeBlocks.SubClassEditor.TryAddUserMacro("FhirBase", this.StructDef.BaseDefinition.LastUriPart());
            this.CodeBlocks.SubClassEditor.TryAddUserMacro("BaseClass", CS.CSMisc.ClassName(this));
            this.CodeBlocks.SubClassEditor.Load(Path.Combine("Templates", "SubClass.txt"));

            this.CodeBlocks.ClassEditor = new CodeEditor();
            this.AddMacros(this.CodeBlocks.ClassEditor, this);
            this.CodeBlocks.ClassEditor.TryAddUserMacro("ClassName", CS.CSMisc.ClassName(this));
            if (this.IsFragment())
                this.CodeBlocks.ClassEditor.Load(Path.Combine("Templates", "Fragment.txt"));
            else
                this.CodeBlocks.ClassEditor.Load(Path.Combine("Templates", "Class.txt"));
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
