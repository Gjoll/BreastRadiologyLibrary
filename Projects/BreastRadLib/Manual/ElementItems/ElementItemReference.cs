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
    /// Interface for implementing ElementItemReference classes.
    /// </summary>
    public interface IElementItemReference
    {
        String ProfileUrl { get; }
        IEnumerable<ResourceBase> GetElements();
        void SetElements(IEnumerable<ResourceBase> elements);
    }

    /// <summary>
    /// Base class for all CodedReference single accessors
    /// </summary>
    public class ElementItemReferenceSingle<BaseType> : ElementItemSingle<BaseType>, IElementItemReference
            where BaseType : ResourceBase, new()
    {
        /// <summary>
        /// Get value.
        /// </summary>
        /// <returns></returns>
        public BaseType Get() => this.Value;

        /// <summary>
        /// Set value
        /// </summary>
        public void Set(BaseType value) => this.Value = value;

        BreastRadiologyDocument doc;
        public String ProfileUrl { get; }

        /// <summary>
        /// Create item if it doesn't already exist, and return item.
        /// </summary>
        public BaseType Create()
        {
            if (this.Value == null)
            {
                BaseType item = new BaseType();
                item.Init(this.doc);
                this.Value = item;
            }
            return this.Value;
        }

        public ElementItemReferenceSingle(String listName,
            Int32 min,
            Int32 max,
            BreastRadiologyDocument doc,
            String profileUrl) : base(listName, min, max)
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
                case 1: this.Value = (BaseType)items.First(); break;
                default: throw new Exception($"HasMember item {this.listName} can not be set to multiple items");
            }
        }
    }

    /// <summary>
    /// Base class for all CodedReference multiple accessors
    /// </summary>
    public class ElementItemReferenceMultiple<BaseType> : ElementItemMultiple<BaseType>, IElementItemReference
            where BaseType : ResourceBase, new()
    {
        BreastRadiologyDocument doc;
        public String ProfileUrl { get; }

        public IEnumerable<BaseType> Items => this.items;

        public BaseType At(Int32 i) => this.items[i];

        public BaseType Append()
        {
            BaseType retVal = new BaseType();
            retVal.Init(this.doc);
            this.items.Add(retVal);
            return retVal;
        }

        public ElementItemReferenceMultiple(String listName,
            Int32 min,
            Int32 max,
            BreastRadiologyDocument doc,
            String profileUrl) : base(listName, min, max)
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
                this.items.Add((BaseType) item);
        }
    }
}
