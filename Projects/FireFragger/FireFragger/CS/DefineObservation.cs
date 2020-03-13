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
    /// <summary>
    /// Perform Observation specific build
    /// </summary>
    class DefineObservation : DefineBase
    {
        public DefineObservation(Builder csBuilder,
                    SDInfo fragBase) : base(csBuilder, fragBase)
        {
        }

        void DefineComponents()
        {
            if (this.fragBase.DiffNodes.TryGetElementNode("Observation.component", out ElementTreeNode componentNode) == false)
                return;
            {
                BuildMembers.BuildMemberComponents bm = new BuildMembers.BuildMemberComponents(this,
                    this.fragBase.CodeBlocks,
                    componentNode);
                bm.Build();
            }
        }

        void DefineHasMembers()
        {
            if (this.fragBase.DiffNodes.TryGetElementNode("Observation.hasMember", out ElementTreeNode hasMemberNode) == false)
                return;
            //{
            //    BuildItemReference bcr = new BuildItemReference(this,
            //        this.fragBase.CodeBlocks,
            //        "HasMembers",
            //        hasMemberNode);
            //    bcr.Define();
            //}

            {
                BuildMembers.BuildMemberReferences bcr = new BuildMembers.BuildMemberReferences(this,
                    this.fragBase.CodeBlocks,
                    hasMemberNode);
                bcr.Build();
            }
        }

        public override void Build()
        {
            const String fcn = "Build";

            this.CSBuilder.ConversionInfo(this.GetType().Name,
               fcn,
               $"Building {this.fragBase.StructDef.Url.LastUriPart()}");

            //if (fragBase.StructDef.Url.LastUriPart().Contains("AbnormalityCyst") == true)
            //    Trace.WriteLine("xxyyz");
            base.Build();
            this.DefineBodySite();
            this.DefineComponents();
            this.DefineHasMembers();
            ClearDuplicateLines(this.fragBase.ClassWriteCodeStart);
            ClearDuplicateLines(this.fragBase.ClassReadCodeStart);
            this.CSBuilder.ConversionInfo(this.GetType().Name,
               fcn,
               $"Completed {this.fragBase.StructDef.Url.LastUriPart()}");
        }

        void ClearDuplicateLines(CodeBlockNested block)
        {
            List<String> lines = block.Lines().ToList();
            for (Int32 i = 0; i < lines.Count(); i++)
                lines[i] = lines[i].Trim();
            {
                Int32 i = 0;
                while (i < lines.Count())
                {
                    Int32 j = i + 1;
                    while (j < lines.Count())
                    {
                        if (String.Compare(lines[i], lines[j]) == 0)
                            lines.RemoveAt(j);
                        else
                            j += 1;
                    }
                    i += 1;
                }
            }
            block.Clear();
            block.AppendLines("", lines);
        }
    }
}
