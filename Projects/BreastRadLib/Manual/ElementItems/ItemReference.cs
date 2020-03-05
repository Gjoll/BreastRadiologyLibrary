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
    /// Interface for implementing ItemReference classes.
    /// </summary>
    public interface IItemReference
    {
        String ProfileUrl { get; }
        IEnumerable<ResourceBase> GetElements();
        void SetElements(IEnumerable<ResourceBase> elements);
    }

    /// <summary>
    /// Base class for all CodedReference single accessors
    /// </summary>
    public class TItemReferenceSingle<TBase> : TItemSingle<TBase>, IItemReference
            where TBase : ResourceBase, new()
    {
        /// <summary>
        /// Get value.
        /// </summary>
        /// <returns></returns>
        public TBase Get() => this.Value;

        /// <summary>
        /// Set value
        /// </summary>
        public void Set(TBase value) => this.Value = value;

        BreastRadiologyDocument doc;
        public String ProfileUrl { get; }

        /// <summary>
        /// Create item if it doesn't already exist, and return item.
        /// </summary>
        public TBase Create()
        {
            if (this.Value == null)
            {
                TBase item = new TBase();
                item.Init(this.doc);
                this.Value = item;
            }
            return this.Value;
        }

        public TItemReferenceSingle(String fhirPath,
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
            if (this.Value != null)
                yield return this.Value; 
        }
        public void SetElements(IEnumerable<ResourceBase> items)
        {
            switch (items.Count())
            {
                case 0: break;
                case 1: this.Value = (TBase)items.First(); break;
                default: throw new Exception($"HasMember item {this.FhirPath} can not be set to multiple items");
            }
        }
    }

    /// <summary>
    /// Base class for all CodedReference multiple accessors
    /// </summary>
    public class TItemReferenceMultiple<TBase> : TItemMultiple<TBase>, IItemReference
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

        public TItemReferenceMultiple(String fhirPath,
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
}
