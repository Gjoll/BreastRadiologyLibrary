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
    /// Interface for implementing ElementItemSection classes.
    /// </summary>
    public interface IElementItemSection : IElementItem
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
    public class TElementItemSectionSingle<BaseType> : TElementItemSingle<BaseType>, IElementItemSection
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


        /// <summary>
        /// Section Title
        /// </summary>
        public String Title { get; }

        /// <summary>
        /// Section coding
        /// </summary>
        public CodeableConcept Code { get; }

        public TElementItemSectionSingle(String listName,
            Int32 min,
            Int32 max,
            String title,
            CodeableConcept code) : base(listName, min, max)
        {
            this.Title = title;
            this.Code = code;
        }

        /// <summary>
        /// Create item if it doesn't already exist, and return item.
        /// </summary>
        public BaseType Create(BreastRadiologyDocument doc)
        {
            if (this.Value == null)
            {
                BaseType item = new BaseType();
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
                case 1: this.Value = (BaseType)items.First(); break;
                default: throw new Exception($"HasMember item {this.listName} can not be set to multiple items");
            }
        }
    }

    /// <summary>
    /// Base class for all CodedSection multiple accessors
    /// </summary>
    public class TElementItemSectionMultiple<BaseType> : TElementItemMultiple<BaseType>, IElementItemSection
            where BaseType : ResourceBase, new()
    {
        /// <summary>
        /// Section Title
        /// </summary>
        public String Title { get; }

        /// <summary>
        /// Section coding
        /// </summary>
        public CodeableConcept Code { get; }

        public IEnumerable<BaseType> Items => this.items;

        public BaseType At(Int32 i) => this.items[i];

        /// <summary>
        /// Create item, append it to list, and return it.
        /// </summary>
        public BaseType Create(BreastRadiologyDocument doc)
        {
            BaseType item = new BaseType();
            item.Init(doc);
            this.Append(item);
            return item;
        }

        public BaseType Append(BaseType item)
        {
            this.items.Add(item);
            return item;
        }

        public TElementItemSectionMultiple(String listName,
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
                this.items.Add((BaseType)item);
        }
    }

    /// <summary>
    /// Base class for all CodedSection multiple accessors
    /// </summary>
    public class TElementItemSectionMultiple<BaseType1, BaseType2, BaseType3> : TElementItemMultiple<ResourceBase>, IElementItemSection
            where BaseType1 : ResourceBase, new()
            where BaseType2 : ResourceBase, new()
            where BaseType3 : ResourceBase, new()
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

        public BaseType1 Append(BaseType1 item)
        {
            this.items.Add(item);
            return item;
        }

        public BaseType2 Append(BaseType2 item)
        {
            this.items.Add(item);
            return item;
        }

        public BaseType3 Append(BaseType3 item)
        {
            this.items.Add(item);
            return item;
        }

        public TElementItemSectionMultiple(String listName,
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
