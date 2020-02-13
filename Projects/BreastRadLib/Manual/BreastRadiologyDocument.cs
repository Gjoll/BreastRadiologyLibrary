using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadLib
{
    /// <summary>
    /// This is the base of the Breast Radiology Report
    /// It Implements a Fhir Document, which is a special type of bundle,
    /// and provides access to the index of that document, which is the
    /// Composition instance.
    /// </summary>
    public class BreastRadiologyDocument
    {
        /// <summary>
        /// 
        /// </summary>
        Dictionary<Base, BaseBase> items = new Dictionary<Base, BaseBase>();

        /// <summary>
        /// Contains the Fhir Bundle, and a dictionary of each of the items in the
        /// bundle to allow quick access of each item.
        /// </summary>
        public ResourceBag ResourceBag { get; }  = new ResourceBag();
        
        /// <summary>
        /// Fhir documents main composition item. This is the 'index' of the
        /// fhir document, and must be the first item in the bundle.
        /// </summary>
        public BreastRadComposition Index;

        /// <summary>
        /// Private constructor. Use the static helper methods.
        /// </summary>
        private BreastRadiologyDocument()
        {
        }

        public void Register(BaseBase baseItem)
        {
            this.items.Add(baseItem.BaseResource, baseItem);
        }

        /// <summary>
        /// Create a new BreastRadiologyDocument.
        /// </summary>
        /// <returns></returns>
        public static BreastRadiologyDocument Create()
        {
            BreastRadiologyDocument retVal = new BreastRadiologyDocument();
            retVal.Index = new BreastRadComposition(retVal, new Composition());
            retVal.ResourceBag.AddResource(retVal.Index.Resource);
            return retVal;
        }

        /// <summary>
        /// Write FhirDocument to a bundle and return it.
        /// </summary>
        /// <returns></returns>
        public Bundle Write()
        {
            foreach (BaseBase baseItem in this.items.Values)
            {
                baseItem.Write();
            }
            return this.ResourceBag.Bundle;
        }
    }
}
