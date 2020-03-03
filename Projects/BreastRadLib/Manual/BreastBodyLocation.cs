using BreastRadLib.BreastBodyLocationExtensionLocal;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadLib
{
    public class BreastBodyLocation : BreastBodyLocationExtension
    {
        public CodeableConcept BodySite { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public BreastBodyLocation(BreastRadiologyDocument doc) : base(doc)                                                                      
        {                                                     
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
