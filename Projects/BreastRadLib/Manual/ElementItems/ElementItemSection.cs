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
    public class ElementItemSectionSingle<BaseType> : ElementItemSingle<BaseType>, IElementItemSection
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

        public BreastRadiologyDocument Doc { get; private set; }

        /// <summary>
        /// Create item if it doesn't already exist, and return item.
        /// </summary>
        public BaseType Create()
        {
            if (this.Value == null)
            {
                BaseType item = new BaseType();
                item.Init(this.Doc);
                this.Value = item;
            }
            return this.Value;
        }

        public ElementItemSectionSingle(String listName,
            Int32 min,
            Int32 max,
            BreastRadiologyDocument doc,
            String title,
            CodeableConcept code) : base(listName, min, max)
        {
            this.Doc = doc;
            this.Title = title;
            this.Code = code;
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
    public class ElementItemSectionMultiple<BaseType> : ElementItemMultiple<BaseType>, IElementItemSection
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

        BreastRadiologyDocument Doc;

        public IEnumerable<BaseType> Items => this.items;

        public BaseType At(Int32 i) => this.items[i];

        public BaseType Append()
        {
            BaseType retVal = new BaseType();
            retVal.Init(this.Doc);
            this.items.Add(retVal);
            return retVal;
        }

        public ElementItemSectionMultiple(String listName,
            Int32 min,
            Int32 max,
            BreastRadiologyDocument doc,
            String title,
            CodeableConcept code) : base(listName, min, max)
        {
            this.Doc = doc;
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
    public class ElementItemSectionMultiple<BaseType1, BaseType2, BaseType3> : ElementItemMultiple<ResourceBase>, IElementItemSection
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

        public BreastRadiologyDocument Doc { get; private set; }

        public ResourceBase At(Int32 i) => this.items[i];

        public BaseType1 Append(BaseType1 item)
        {
            if (item.Doc != this.Doc)
                throw new Exception("Item is bound to a different document");
            this.items.Add(item);
            return item;
        }

        public BaseType2 Append(BaseType2 item)
        {
            if (item.Doc != this.Doc)
                throw new Exception("Item is bound to a different document");
            this.items.Add(item);
            return item;
        }

        public BaseType3 Append(BaseType3 item)
        {
            if (item.Doc != this.Doc)
                throw new Exception("Item is bound to a different document");
            this.items.Add(item);
            return item;
        }

        public ElementItemSectionMultiple(String listName,
            Int32 min,
            Int32 max,
            BreastRadiologyDocument doc,
            String title,
            CodeableConcept code) : base(listName, min, max)
        {
            this.Doc = doc;
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
