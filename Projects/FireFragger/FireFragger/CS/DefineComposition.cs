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
    class DefineComposition : DefineBase
    {
        public DefineComposition(Builder csBuilder,
                    SDInfo fragBase) : base(csBuilder, fragBase)
        {
        }

        public override void Build()
        {
            const String fcn = "Build";

            this.CSBuilder.ConversionInfo(this.GetType().Name,
               fcn,
               $"Building {this.fragBase.StructDef.Url.LastUriPart()}");

            base.Build();
            this.DefineSections();
            this.DefineBodySite();
            this.CSBuilder.ConversionInfo(this.GetType().Name,
               fcn,
               $"Completed {this.fragBase.StructDef.Url.LastUriPart()}");
        }

        void DefineSections()
        {
            if (this.fragBase.DiffNodes.TryGetElementNode("Composition.section", out ElementTreeNode hasMemberNode) == false)
                return;
            BuildItemSection bcr = new BuildItemSection(this,
                this.fragBase.CodeBlocks,
                "Section",
                hasMemberNode);
            bcr.Define();
        }
    }
}
