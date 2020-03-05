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
    /// Interface for implementing ElementItemComponent classes.
    /// </summary>
    public interface IElementItemComponent : IElementItem
    {
        /// <summary>
        /// Component coding
        /// </summary>
        CodeableConcept Code { get; }

        IEnumerable<Element> GetElements();
        void SetElements(IEnumerable<Element> elements);
    }

    /// <summary>
    /// </summary>
    public class TElementItemComponentSingle<BaseType> : TElementItemSingle<BaseType>, IElementItemComponent
            where BaseType : Element, new()
    {
        /// <summary>
        /// Component coding
        /// </summary>
        public CodeableConcept Code { get; }

        /// <summary>
        /// Get value.
        /// </summary>
        /// <returns></returns>
        public BaseType Get() => this.Value;

        /// <summary>
        /// Set value
        /// </summary>
        public void Set(BaseType value) => this.Value = value;

        public TElementItemComponentSingle(String listName,
            Int32 min,
            Int32 max,
            CodeableConcept code) : base(listName, min, max)
        {
            this.Code = code;
        }

        /// <summary>
        /// Create item if it doesn't already exist, and return item.
        /// </summary>
        public BaseType Create()
        {
            if (this.Value == null)
            {
                BaseType item = new BaseType();
                this.Value = item;
            }
            return this.Value;
        }

        public IEnumerable<Element> GetElements()
        {
            if (this.Value != null)
                yield return this.Value;
        }
        public void SetElements(IEnumerable<Element> items)
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
    /// </summary>
    public class TElementItemComponentSingle<BaseType1, BaseType2> : TElementItemSingle<Element>, IElementItemComponent
        where BaseType1 : Element, new()
        where BaseType2 : Element, new()
    {
        /// <summary>
        /// Get value.
        /// </summary>
        /// <returns></returns>
        public Element Get() => this.Value;

        /// <summary>
        /// Set value
        /// </summary>
        public void Set(BaseType1 value) => this.Value = value;

        /// <summary>
        /// Set value
        /// </summary>
        public void Set(BaseType2 value) => this.Value = value;

        /// <summary>
        /// Component coding
        /// </summary>
        public CodeableConcept Code { get; }

        public TElementItemComponentSingle(String listName,
            Int32 min,
            Int32 max,
            CodeableConcept code) : base(listName, min, max)
        {
            this.Code = code;
        }

        public IEnumerable<Element> GetElements()
        {
            if (this.Value != null)
                yield return this.Value;
        }
        public void SetElements(IEnumerable<Element> items)
        {
            switch (items.Count())
            {
                case 0: break;
                case 1: this.Value = items.First(); break;
                default: throw new Exception($"HasMember item {this.listName} can not be set to multiple items");
            }
        }
    }




    /// <summary>
    /// Base class for all CodedComponent multiple accessors
    /// </summary>
    public class TElementItemComponentMultiple<BaseType> : TElementItemMultiple<BaseType>, IElementItemComponent
            where BaseType : Element, new()
    {
        /// <summary>
        /// Component coding
        /// </summary>
        public CodeableConcept Code { get; }

        public IEnumerable<BaseType> Items => this.items;

        public BaseType At(Int32 i) => this.items[i];

        /// <summary>
        /// Create item, append it to list, and return it.
        /// </summary>
        public BaseType Create()
        {
            BaseType item = new BaseType();
            this.Append(item);
            return item;
        }

        public BaseType Append(BaseType item)
        {
            this.items.Add(item);
            return item;
        }

        public TElementItemComponentMultiple(String listName,
            Int32 min,
            Int32 max,
            CodeableConcept code) : base(listName, min, max)
        {
            this.Code = code;
        }

        public IEnumerable<Element> GetElements()
        {
            foreach (var item in this.items)
                yield return item;
        }

        public void SetElements(IEnumerable<Element> items)
        {
            foreach (var item in items)
                this.items.Add((BaseType) item);
        }
    }



    /// <summary>
    /// Base class for all CodedComponent multiple accessors
    /// </summary>
    public class TElementItemComponentMultiple<BaseType1, BaseType2> : TElementItemMultiple<Element>, IElementItemComponent
            where BaseType1 : Element, new()
            where BaseType2 : Element, new()
    {
        /// <summary>
        /// Component coding
        /// </summary>
        public CodeableConcept Code { get; }

        public IEnumerable<Element> Items => this.items;

        public Element At(Int32 i) => this.items[i];

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

        public TElementItemComponentMultiple(String listName,
            Int32 min,
            Int32 max,
            CodeableConcept code) : base(listName, min, max)
        {
            this.Code = code;
        }

        public IEnumerable<Element> GetElements()
        {
            foreach (var item in this.items)
                yield return item;
        }

        public void SetElements(IEnumerable<Element> items)
        {
            foreach (var item in items)
                this.items.Add(item);
        }
    }
}
