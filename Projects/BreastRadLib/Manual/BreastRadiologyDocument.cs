using Hl7.Fhir.Model;
using System;
using System.Linq;
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
        public ResourceBag ResourceBag { get; private set; }
        
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
            this.ResourceBag.AddResource((DomainResource) baseItem.BaseResource);
            this.items.Add(baseItem.BaseResource, baseItem);
        }

        /// <summary>
        /// Create a new BreastRadiologyDocument.
        /// </summary>
        /// <returns></returns>
        public static BreastRadiologyDocument Create()
        {
            BreastRadiologyDocument retVal = new BreastRadiologyDocument();
            retVal.ResourceBag = new ResourceBag();
            retVal.Index = new BreastRadComposition(retVal, new Composition());
            retVal.ResourceBag.AddResource(retVal.Index.Resource);
            return retVal;
        }

        /// <summary>
        /// Create a new BreastRadiologyDocument and load it with the passed fhir document.
        /// </summary>
        /// <returns></returns>
        public static BreastRadiologyDocument Read(Bundle bundle)
        {
            BreastRadiologyDocument retVal = new BreastRadiologyDocument();
            retVal.LoadBundle(bundle);

            // now write all the others.
            foreach (BaseBase baseItem in retVal.items.Values.ToArray())
            {
                baseItem.Read(); ;
            }
            return retVal;
        }

        /// <summary>
        /// Read FhirDocument from a bundle.
        /// </summary>
        /// <returns></returns>
        void LoadBundle(Bundle bundle)
        {
            this.ResourceBag = new ResourceBag(bundle);
            Composition index = bundle?.Entry?.First().Resource as Composition;
            if (index == null)
                throw new Exception($"Invalid bundle. First item is not a Composition");
            this.Index = new BreastRadComposition(this, index);
        }

        /// <summary>
        /// Write FhirDocument to a bundle and return it.
        /// </summary>
        /// <returns></returns>
        public Bundle Write()
        {
            Bundle retVal = new Bundle();
            retVal.Type = Bundle.BundleType.Document;

            void WriteItem(BaseBase baseItem)
            {
                baseItem.Write();
                if (String.IsNullOrEmpty(baseItem.Id) == true)
                    throw new Exception($"Error saving resource. Resource has no id!");
                retVal.AddResourceEntry((Resource) baseItem.BaseResource, baseItem.Id);
            }

            // Composition must be written first....
            WriteItem(this.Index);

            // now write all the others.
            foreach (BaseBase baseItem in this.items.Values)
            {
                if (baseItem != this.Index)
                    WriteItem(baseItem);
            }

            return this.ResourceBag.Bundle;
        }
    }
}
