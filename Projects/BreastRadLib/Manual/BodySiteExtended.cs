using BreastRadLib.BreastBodyLocationExtensionLocal;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadLib
{
    public class BodySiteExtended : IItemElementMember
    {
        public CodeableConcept BodySite { get; set; }
        TItemExtensionComplexSingle<BreastBodyLocationExtensionItem> BreastBodyLocation;

        /// <summary>
        /// Constructor
        /// </summary>
        public BodySiteExtended()                                                                     
        {
            this.BreastBodyLocation = 
                new TItemExtensionComplexSingle<BreastBodyLocationExtensionItem>("BreastBodyLocation",
                    0, 
                    1,
                    "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/BreastBodyLocationExtension");
        }

        /// <summary>
        /// Read extension values
        /// </summary>
        public void Read(BreastRadiologyDocument doc, Resource resource)
        {
            throw new NotImplementedException();
            //base.ReadItems(e);
        }

        /// <summary>
        /// Write extension values
        /// </summary>
        public void Write(BreastRadiologyDocument doc, Resource resource)
        {
            throw new NotImplementedException();
            // return base.WriteItems();
        }

        public Element GetElement() => this.BodySite;
        public void SetElement(Element e) => throw new NotImplementedException();
    }
}
