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
    /// Interface for implementing ItemSection classes.
    /// </summary>
    public interface IItemSection : IItem
    {
        /// <summary>
        /// Section Title
        /// </summary>
        String Title { get; }

        /// <summary>
        /// Section coding
        /// </summary>
        CodeableConcept Code { get; }

        IEnumerable<ResourceBase> GetElements();
        void SetElements(IEnumerable<ResourceBase> elements);
    }

    /// <summary>
    /// </summary>
    public class TItemSectionSingle<TBase> : TItemSingle<TBase>, IItemSection
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


        /// <summary>
        /// Section Title
        /// </summary>
        public String Title { get; }

        /// <summary>
        /// Section coding
        /// </summary>
        public CodeableConcept Code { get; }

        public TItemSectionSingle(String fhirPath,
            Int32 min,
            Int32 max,
            String title,
            CodeableConcept code) : base(fhirPath, min, max)
        {
            this.Title = title;
            this.Code = code;
        }

        /// <summary>
        /// Create item if it doesn't already exist, and return item.
        /// </summary>
        public TBase Create(BreastRadiologyDocument doc)
        {
            if (this.Value == null)
            {
                TBase item = new TBase();
                item.Init(doc);
                this.Value = item;
            }
            return this.Value;
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
    /// Base class for all CodedSection multiple accessors
    /// </summary>
    public class TItemSectionMultiple<TBase> : TItemMultiple<TBase>, IItemSection
            where TBase : ResourceBase, new()
    {
        /// <summary>
        /// Section Title
        /// </summary>
        public String Title { get; }

        /// <summary>
        /// Section coding
        /// </summary>
        public CodeableConcept Code { get; }

        public IEnumerable<TBase> Items => this.items;

        public TBase At(Int32 i) => this.items[i];

        /// <summary>
        /// Create item, append it to list, and return it.
        /// </summary>
        public TBase Create(BreastRadiologyDocument doc)
        {
            TBase item = new TBase();
            item.Init(doc);
            this.Append(item);
            return item;
        }

        public TBase Append(TBase item)
        {
            this.items.Add(item);
            return item;
        }

        public TItemSectionMultiple(String fhirPath,
            Int32 min,
            Int32 max,
            String title,
            CodeableConcept code) : base(fhirPath, min, max)
        {
            this.Title = title;
            this.Code = code;
        }

        public void Write(BreastRadiologyDocument doc,
            Resource resource)
        {
            this.WriteItemSection(doc, resource);
        }

        public void Read(BreastRadiologyDocument doc,
            Resource resource)
        {
            this.ReadItemSection(doc, resource);
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

    /// <summary>
    /// Base class for all CodedSection multiple accessors
    /// </summary>
    public class TItemSectionMultiple<TBase1, TBase2, TBase3> : TItemMultiple<ResourceBase>, IItemSection
            where TBase1 : ResourceBase, new()
            where TBase2 : ResourceBase, new()
            where TBase3 : ResourceBase, new()
    {
        /// <summary>
        /// Section Title
        /// </summary>
        public String Title { get; }

        /// <summary>
        /// Section coding
        /// </summary>
        public CodeableConcept Code { get; }

        public ResourceBase At(Int32 i) => this.items[i];

        public TBase1 Append(TBase1 item)
        {
            this.items.Add(item);
            return item;
        }

        public TBase2 Append(TBase2 item)
        {
            this.items.Add(item);
            return item;
        }

        public TBase3 Append(TBase3 item)
        {
            this.items.Add(item);
            return item;
        }

        public TItemSectionMultiple(String listName,
            Int32 min,
            Int32 max,
            String title,
            CodeableConcept code) : base(listName, min, max)
        {
            this.Title = title;
            this.Code = code;
        }

        public IEnumerable<ResourceBase> GetElements()
        {
            foreach (var item in this.items)
                yield return item;
        }

        public void SetElements(IEnumerable<ResourceBase> items)
        {
            foreach (var item in items)
                this.items.Add(item);
        }
    }
}
