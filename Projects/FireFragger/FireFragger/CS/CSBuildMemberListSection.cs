using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FireFragger
{
    /// <summary>
    /// Build the class that implements a list of coded references, such as
    /// Observation.hasMember
    /// </summary>
    internal class CSBuildMemberListSection : CSBuildMemberListCodedReference
    {
        public CSBuildMemberListSection(CSBuilder csBuilder,
            SDInfo fragBase,
            ElementTreeNode memberNode) : base(csBuilder, fragBase, memberNode)
        {
        }

        protected override String GetTitle(ElementTreeSlice memberSlice)
        {
            ElementTreeNode titleNode = memberSlice.Nodes["title"];
            String title = titleNode.ElementDefinition.Fixed.ToString();
            return title;
        }
    }
}
