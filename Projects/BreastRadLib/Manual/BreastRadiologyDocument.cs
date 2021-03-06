﻿using Hl7.Fhir.Model;
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
        /// Date when this document was instantiated.
        /// </summary>
        public FhirDateTime Date = new FhirDateTime(DateTimeOffset.Now);

        /// <summary>
        /// Reference to Subject of document. This is propagated to all observations in this document that reference
        /// a subject.
        /// </summary>
        public ResourceReference SubjectReference => this.Subject.ResourceReference();


        /// <summary>
        /// Reference to Author of document.
        /// a subject.
        /// </summary>
        public ResourceReference AuthorReference => this.Author.ResourceReference();


        /// <summary>
        /// Reference to Encounter of document. This is propagated to all observations in this document that reference
        /// an encounter.
        /// </summary>
        public ResourceReference EncounterReference => this.Encounter.ResourceReference();

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

        public Patient Subject { get; set; }

        public Encounter Encounter { get; set; }
        public DomainResource Author { get; set; }


        /// <summary>
        /// Private constructor. Use the static helper methods.
        /// </summary>
        private BreastRadiologyDocument()
        {
        }

        public void Register(BaseBase baseItem)
        {
            this.ResourceBag.AddResource((DomainResource)baseItem.BaseResource);
            this.items.Add(baseItem.BaseResource, baseItem);
        }

        public bool TryGetRegisteredItem<T>(Base fhirBase, out T item)
            where T : BaseBase
        {
            item = null;
            if (this.items.TryGetValue(fhirBase, out BaseBase temp) == false)
                return false;
            item = temp as T;
            if (item == null)
                throw new Exception($"Item of class {temp.GetType().Name} can not be converted to class {typeof(T).Name}");
            return true;
        }

        /// <summary>
        /// Create a new BreastRadiologyDocument.
        /// </summary>
        /// <returns></returns>
        public static BreastRadiologyDocument Create()
        {
            BreastRadiologyDocument retVal = new BreastRadiologyDocument();
            retVal.ResourceBag = new ResourceBag();
            Composition index = new Composition();
            index.Id = "Index";
            retVal.Index = new BreastRadComposition(retVal, index);
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

            //$retVal.Subject = retVal.Index.Resource.Subject;
            //$retVal.Encounter = retVal.Index.Resource.Encounter;
            return retVal;
        }

        /// <summary>
        /// Read FhirDocument from a bundle.
        /// </summary>
        /// <returns></returns>
        void LoadBundle(Bundle bundle)
        {
            this.ResourceBag = new ResourceBag(bundle);

            // First entry is always composition item.
            {
                Composition index = bundle.Entry?.First().Resource as Composition;
                if (index == null)
                    throw new Exception($"Invalid bundle. First item is not a Composition");
                this.Index = new BreastRadComposition(this, index);
            }
            foreach (Bundle.EntryComponent entry in bundle.Entry.Skip(1))
            {
                String profile = entry.Resource?.Meta?.Profile?.First();
                if (profile == null)
                    throw new Exception("Resource in bundle lacks Meta.Profile element to identify the profile.");
                var item = ResourceFactory.CreateBreastRadProfileResource(this,
                    profile,
                    entry.Resource);
                if (item == null)
                    item = new ResourceBase(this, (DomainResource)entry.Resource);
            }
        }

        /// <summary>
        /// Validate resource.
        /// Throw exception if obvious error.
        /// </summary>
        public bool Validate(StringBuilder sb)
        {
            bool retVal = true;
            if (this.Subject == null)
            {
                sb.Append($"BreastRadiologyDocument.Subject not set");
                retVal = false;
            }

            if (this.Encounter == null)
            {
                sb.Append($"BreastRadiologyDocument.Encounter not set");
                retVal = false;
            }

            foreach (BaseBase baseItem in this.items.Values)
            {
                if (baseItem.Validate(sb) == false)
                    retVal = false;
            }

            return retVal;
        }

        /// <summary>
        /// Write FhirDocument to a bundle and return it.
        /// </summary>
        /// <returns></returns>
        public Bundle Write()
        {
            Bundle retVal = new Bundle
            {
                Type = Bundle.BundleType.Document,
                Timestamp = DateTimeOffset.Now,
                Identifier = new Identifier("urn:ietf:rfc:3986", Guid.NewGuid().ToString()),
                Id = "FhirDocumentBundle"
            };
            retVal.Meta = new Meta
            {
                LastUpdated = DateTimeOffset.Now
            };

            void WriteItem(BaseBase baseItem)
            {
                if (String.IsNullOrEmpty(baseItem.Id) == true)
                    throw new Exception($"Error saving resource. Resource has no id!");

                baseItem.Write();
                retVal.AddResourceEntry((Resource)baseItem.BaseResource,
                    baseItem.RelativeUrl());
            }

            void AppendAdmin(DomainResource r, String name)
            {
                if (r == null)
                    throw new Exception("Required field {name} is null");
                this.Index.Admin.Append(new ResourceBase(this, r));
            }

            AppendAdmin(this.Subject, "Subject");
            AppendAdmin(this.Encounter, "Encounter");
            AppendAdmin(this.Author, "Author");

            this.Index.Resource.Author.Add(this.AuthorReference);
            this.Index.Resource.Subject = this.SubjectReference;
            //this.Index.Resource.Type = this.SubjectReference;

            // Composition must be written first....
            WriteItem(this.Index);

            // now write all the others.
            foreach (BaseBase baseItem in this.items.Values)
            {
                if (baseItem != this.Index)
                    WriteItem(baseItem);
            }

            return retVal;
        }

        public T ReferencedResource<T>(ResourceReference resRef)
            where T : Base
        {
            if (this.ResourceBag.TryGetEntry(resRef.Reference, out var entry) == false)
                throw new Exception($"Error referencing section resource '{resRef.Reference}'");
            Resource referencedResource = entry.Resource;
            if (referencedResource.Meta.Profile.Count() != 1)
                throw new Exception($"Invalid Meta.profile. Expected 1, got {referencedResource.Meta.Profile.Count()}");
            T retVal = referencedResource as T;
            if (retVal == null)
                throw new Exception($"Resource can not be converted to {typeof(T).Name}");
            return retVal;
        }

        public ResourceBase GetResource(ResourceReference resRef)
        {
            Resource referencedResource = this.ReferencedResource<Resource>(resRef);
            if (this.TryGetRegisteredItem(referencedResource, out ResourceBase item) == false)
                throw new Exception($"Referenced resource {referencedResource.Id} not found in bundle");
            return item;
        }
    }
}
