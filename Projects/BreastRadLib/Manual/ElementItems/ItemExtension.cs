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
    /// All simple and complex extensions implement this.
    /// </summary>
    public interface IItemExtension : IItem
    {
        String ExtensionUrl { get; }
    }

    /// <summary>
    /// All simple extensions implement this.
    /// </summary>
    public interface IItemExtensionSimple : IItemExtension
    {
        IEnumerable<Element> GetElements();
        void SetElements(IEnumerable<Element> elements);
    }

    /// <summary>
    /// </summary>
    public interface IItemExtensionComplex : IItemExtension
    {
        IEnumerable<IItemExtensionComplexInstance> GetElements();
        void SetElements(IEnumerable<IItemExtensionComplexInstance> elements);
    }




    /// <summary>
    /// All classes that implement a complex extension instance implement this.
    /// </summary>
    public interface IItemExtensionComplexInstance
    {
        IEnumerable<IItemExtension> Items();
    }


    /// <summary>
    /// Simple extension container, with single member.
    /// </summary>
    public class TItemExtensionSingle<TBase> :
        TItemSingle<TBase>,
        IItemExtension
        where TBase : Element, new()
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
        public String ExtensionUrl { get; }

        /// <summary>
        /// Create item if it doesn't already exist, and return item.
        /// </summary>
        protected TBase Create()
        {
            if (this.Value == null)
            {
                TBase item = new TBase();
                this.Value = item;
            }
            return this.Value;
        }
        public TItemExtensionSingle(String fhirPath,
            Int32 min,
            Int32 max,
            String extensionUrl) : base(fhirPath, min, max)
        {
            this.ExtensionUrl = extensionUrl;
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
    /// Simple extension container, with multiple members.
    /// </summary>
    public class TItemExtensionMultiple<TBase> : 
        TItemMultiple<TBase>,
        IItemExtension
        where TBase : Element, new()
    {
        public String ExtensionUrl { get; }

        public IEnumerable<TBase> Items => this.items;

        public TBase At(Int32 i) => this.items[i];

        public TBase Append()
        {
            TBase retVal = new TBase();
            this.items.Add(retVal);
            return retVal;
        }

        public TItemExtensionMultiple(String fhirPath,
            Int32 min,
            Int32 max,
            String extensionUrl) : base(fhirPath, min, max)
        {
            this.ExtensionUrl = extensionUrl;
        }

        public IEnumerable<Element> GetElements()
        {
            foreach (var item in this.items)
                yield return item;
        }

        public void SetElements(IEnumerable<Element> items)
        {
            foreach (var item in items)
                this.items.Add((TBase)item);
        }
    }










    /// <summary>
    /// </summary>
    public class TItemExtensionComplexSingle<TBase> : 
        TItemSingle<TBase>, 
        IItemExtensionComplex
        where TBase : IItemExtensionComplexInstance, new()
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

        public String ExtensionUrl { get; }

        /// <summary>
        /// Create item if it doesn't already exist, and return item.
        /// </summary>
        protected TBase Create()
        {
            if (this.Value == null)
            {
                TBase item = new TBase();
                this.Value = item;
            }
            return this.Value;
        }

        public TItemExtensionComplexSingle(String fhirPath,
            Int32 min,
            Int32 max,
            String extensionUrl) : base(fhirPath, min, max)
        {
            this.ExtensionUrl = extensionUrl;
        }

        public IEnumerable<IItemExtensionComplexInstance> GetElements()
        {
            if (this.Value != null)
                yield return this.Value;
        }
        public void SetElements(IEnumerable<IItemExtensionComplexInstance> items)
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
    public class TItemExtensionComplexMultiple<TBase> : 
        TItemMultiple<TBase>, 
        IItemExtensionComplex
        where TBase : IItemExtensionComplexInstance, new()
    {
        public String ExtensionUrl { get; }

        public IEnumerable<TBase> Items => this.items;

        public TBase At(Int32 i) => this.items[i];

        public TBase Append()
        {
            TBase retVal = new TBase();
            this.items.Add(retVal);
            return retVal;
        }

        public TItemExtensionComplexMultiple(String fhirPath,
            Int32 min,
            Int32 max,
            String extensionUrl) : base(fhirPath, min, max)
        {
            this.ExtensionUrl = extensionUrl;
        }

        public IEnumerable<IItemExtensionComplexInstance> GetElements()
        {
            foreach (var item in this.items)
                yield return item;
        }

        public void SetElements(IEnumerable<IItemExtensionComplexInstance> items)
        {
            foreach (var item in items)
                this.items.Add((TBase)item);
        }
    }
}
