﻿using FhirKhit.Tools;
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
    class CSDefineObservation : CSDefineBase
    {
        public CSDefineObservation(CSBuilder csBuilder,
                    SDInfo fragBase) : base(csBuilder, fragBase)
        {
        }

        void DefineComponents()
        {
            if (this.fragBase.DiffNodes.TryGetElementNode("Observation.component", out ElementTreeNode componentNode) == false)
                return;
            CSBuildMemberListCodedValue bml = new CSBuildMemberListCodedValue(this.csBuilder, this.fragBase);
            bml.Define();
        }

        void DefineHasMembers()
        {
            if (this.fragBase.DiffNodes.TryGetElementNode("Observation.hasMember", out ElementTreeNode hasMemberNode) == false)
                return;
            CSBuildMemberListReference bcr = new CSBuildMemberListReference(this.csBuilder, this.fragBase, hasMemberNode);
            bcr.Define();
        }

        public override void Build()
        {
            const String fcn = "Build";

            this.csBuilder.ConversionInfo(this.GetType().Name,
               fcn,
               $"Building {this.fragBase.StructDef.Url.LastUriPart()}");

            //Debug.Assert(fragBase.StructDef.Url.LastUriPart().Contains("ObservedChangesFragment") == false);
            base.Build();

            this.DefineComponents();
            this.DefineHasMembers();
            this.csBuilder.ConversionInfo(this.GetType().Name,
               fcn,
               $"Completed {this.fragBase.StructDef.Url.LastUriPart()}");
        }
    }
}
