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

namespace FireFragger.CS
{
    class DefineExtension : DefineBase
    {
        public DefineExtension(Builder csBuilder,
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

            //{
            //    if (this.fragBase.SnapNodes.TryGetElementNode("Extension.extension", out ElementTreeNode extensionNode) == false)
            //        throw new Exception($"Extension.extension node is missing");
            //    BuildItemExtension bmv = new BuildItemExtension(this, this.fragBase.CodeBlocks);
            //    bmv.Build(CSMisc.ClassName(this.fragBase), extensionNode);
            //}
            {
                BuildMembers.BuildMemberExtension bm = new BuildMembers.BuildMemberExtension(this,
                    this.fragBase.CodeBlocks,
                    this.fragBase.SnapNodes.DefaultSlice,
                    CSMisc.ClassName(this.fragBase));
                bm.Build();
            }
        }
    }
}
