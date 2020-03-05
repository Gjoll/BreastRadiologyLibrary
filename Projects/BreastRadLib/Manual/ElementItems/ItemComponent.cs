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
    /// Interface for implementing ItemComponent classes.
    /// </summary>
    public interface IItemComponent : IItem
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
    public class TItemComponentSingle<TBase> : TItemSingle<TBase>, IItemComponent
            where TBase : Element, new()
    {
        /// <summary>
        /// Component coding
        /// </summary>
        public CodeableConcept Code { get; }

        /// <summary>
        /// Get value.
        /// </summary>
        /// <returns></returns>
        public TBase Get() => this.Value;

        /// <summary>
        /// Set value
        /// </summary>
        public void Set(TBase value) => this.Value = value;

        public TItemComponentSingle(String fhirPath,
            Int32 min,
            Int32 max,
            CodeableConcept code) : base(fhirPath, min, max)
        {
            this.Code = code;
        }

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
                yield return this.Value;
        }
        public void SetElements(IEnumerable<Element> items)
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
    /// </summary>
    public class TItemComponentSingle<TBase1, TBase2> : TItemSingle<Element>, IItemComponent
        where TBase1 : Element, new()
        where TBase2 : Element, new()
    {
        /// <summary>
        /// Get value.
        /// </summary>
        /// <returns></returns>
        public Element Get() => this.Value;

        /// <summary>
        /// Set value
        /// </summary>
        public void Set(TBase1 value) => this.Value = value;

        /// <summary>
        /// Set value
        /// </summary>
        public void Set(TBase2 value) => this.Value = value;

        /// <summary>
        /// Component coding
        /// </summary>
        public CodeableConcept Code { get; }

        public TItemComponentSingle(String fhirPath,
            Int32 min,
            Int32 max,
            CodeableConcept code) : base(fhirPath, min, max)
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
                default: throw new Exception($"HasMember item {this.FhirPath} can not be set to multiple items");
            }
        }
    }




    /// <summary>
    /// Base class for all CodedComponent multiple accessors
    /// </summary>
    public class TItemComponentMultiple<TBase> : TItemMultiple<TBase>, IItemComponent
            where TBase : Element, new()
    {
        /// <summary>
        /// Component coding
        /// </summary>
        public CodeableConcept Code { get; }

        public IEnumerable<TBase> Items => this.items;

        public TBase At(Int32 i) => this.items[i];

        /// <summary>
        /// Create item, append it to list, and return it.
        /// </summary>
        public TBase Create()
        {
            TBase item = new TBase();
            this.Append(item);
            return item;
        }

        public TBase Append(TBase item)
        {
            this.items.Add(item);
            return item;
        }

        public TItemComponentMultiple(String fhirPath,
            Int32 min,
            Int32 max,
            CodeableConcept code) : base(fhirPath, min, max)
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
                this.items.Add((TBase) item);
        }
    }



    /// <summary>
    /// Base class for all CodedComponent multiple accessors
    /// </summary>
    public class TItemComponentMultiple<TBase1, TBase2> : TItemMultiple<Element>, IItemComponent
            where TBase1 : Element, new()
            where TBase2 : Element, new()
    {
        /// <summary>
        /// Component coding
        /// </summary>
        public CodeableConcept Code { get; }

        public IEnumerable<Element> Items => this.items;

        public Element At(Int32 i) => this.items[i];

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

        public TItemComponentMultiple(String fhirPath,
            Int32 min,
            Int32 max,
            CodeableConcept code) : base(fhirPath, min, max)
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
