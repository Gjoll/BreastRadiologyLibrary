using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
    /// <summary>
    /// </summary>
    public interface IItemElementMember
    {
        Element GetElement();
        void SetElement(Element e);
    }

    /// <summary>
    /// Interface for implementing ItemElement classes.
    /// </summary>
    public interface IItemElement
    {
        String FhirPath { get; }
        IEnumerable<Element> GetElements();
        void SetElements(IEnumerable<Element> elements);

    }

    /// <summary>
    /// </summary>
    public class TItemElementSingle<TBase> : 
        TItemSingle<TBase>, 
        IItemElement
        where TBase : IItemElementMember, new()
    {
        String FhirPath { get; }

        public TItemElementSingle(String fhirPath,
            Int32 min,
            Int32 max) : base(fhirPath, min, max)
        {
        }

        /// <summary>
        /// Get value.
        /// </summary>
        /// <returns></returns>
        public TBase Get() => this.Value;

        /// <summary>
        /// Set value
        /// </summary>
        public void Set(TBase value) => this.Value = value;

        /// <summary>
        /// Create item if it doesn't already exist, and return item.
        /// </summary>
        public TBase Create()
        {
            if (this.Value == null)
            {
                TBase item = new TBase();
                this.Value = item;
            }
            return this.Value;
        }

        public IEnumerable<Element> GetElements()
        {
            if (this.Value != null)
                yield return this.Value.GetElement(); 
        }
        public void SetElements(IEnumerable<Element> items)
        {
            switch (items.Count())
            {
                case 0: 
                    break;
                case 1:
                    this.Value = new TBase();
                    this.Value.SetElement(items.First());
                    break;
                default: 
                    throw new Exception($"{this.FhirPath} can not be set to multiple items");
            }
        }
    }
#if NEVER
    /// <summary>
    /// Base class for all CodedElement multiple accessors
    /// </summary>
    public class TItemElementMultiple<TBase> : TItemMultiple<TBase>, IItemElement
            where TBase : ResourceBase, new()
    {
        BreastRadiologyDocument doc;
        public String ProfileUrl { get; }

        public IEnumerable<TBase> Items => this.items;

        public TBase At(Int32 i) => this.items[i];

        public TBase Append()
        {
            TBase retVal = new TBase();
            retVal.Init(this.doc);
            this.items.Add(retVal);
            return retVal;
        }

        public TItemElementMultiple(String fhirPath,
            Int32 min,
            Int32 max,
            BreastRadiologyDocument doc,
            String profileUrl) : base(fhirPath, min, max)
        {
            this.doc = doc;
            this.ProfileUrl = profileUrl;
        }

        public IEnumerable<ResourceBase> GetElements()
        {
            foreach (var item in this.items)
                yield return item;
        }

        public void SetElements(IEnumerable<ResourceBase> items)
        {
            foreach (var item in items)
                this.items.Add((TBase) item);
        }
    }
#endif
}
