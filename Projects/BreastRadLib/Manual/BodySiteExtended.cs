using BreastRadLib.BreastBodyLocationExtensionLocal;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadLib
{
    public class BodySiteExtended 
    {
        public CodeableConcept BodySite { get; set; }
        TItemExtensionComplexSingle<BreastBodyLocationExtensionItem> BreastBodyLocation;

        /// <summary>
        /// Constructor
        /// </summary>
        public BodySiteExtended(Int32 min, Int32 max)                                                                     
        {
            this.BreastBodyLocation = 
                new TItemExtensionComplexSingle<BreastBodyLocationExtensionItem>("BreastBodyLocation",
                    min, 
                    max,
                    "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/BreastBodyLocationExtension");
        }

        /// <summary>
        /// Read extension values
        /// </summary>
        public void Read()
        {
            //base.ReadItems(e);
        }

        /// <summary>
        /// Write extension values
        /// </summary>
        public void Write()
        {
            // return base.WriteItems();
        }
    }
}
