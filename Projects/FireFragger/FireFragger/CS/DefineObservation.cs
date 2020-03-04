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
            BuildElementItemComponent bml = new BuildElementItemComponent(this, 
                this.fragBase.CodeBlocks, 
                "Component",
                componentNode);
            bml.Define();
        }

        void DefineHasMembers()
        {
            if (this.fragBase.DiffNodes.TryGetElementNode("Observation.hasMember", out ElementTreeNode hasMemberNode) == false)
                return;
            BuildElementItemReference bcr = new BuildElementItemReference(this,
                this.fragBase.CodeBlocks, 
                "HasMembers", 
                hasMemberNode);
            bcr.Define();
        }

        public override void Build()
        {
            const String fcn = "Build";

            this.CSBuilder.ConversionInfo(this.GetType().Name,
               fcn,
               $"Building {this.fragBase.StructDef.Url.LastUriPart()}");

            //if (fragBase.StructDef.Url.LastUriPart().Contains("ObservedFeature") == true)
            //    Trace.WriteLine("xxyyz");
            base.Build();
            this.DefineBodySite();
            this.DefineComponents();
            this.DefineHasMembers();
            this.CSBuilder.ConversionInfo(this.GetType().Name,
               fcn,
               $"Completed {this.fragBase.StructDef.Url.LastUriPart()}");
        }
    }
}
