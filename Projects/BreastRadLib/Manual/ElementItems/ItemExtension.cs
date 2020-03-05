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
    public interface IExtensionItem
    {
        String ExtensionUrl { get; }
    }

    /// <summary>
    /// </summary>
    public interface IComplexExtensionItem
    {
        IEnumerable<IExtensionItem> Items();
    }

    /// <summary>
    /// Interface for implementing ItemExtension classes.
    /// </summary>
    public interface IElementExtensionItem : IExtensionItem
    {
        IEnumerable<Element> GetElements();
        void SetElements(IEnumerable<Element> elements);
    }

    /// <summary>
    /// Interface for implementing ItemExtension classes.
    /// </summary>
    public interface IComplexExtension
    {
        String ExtensionUrl { get; }
        IEnumerable<IComplexExtensionItem> GetElements();
        void SetElements(IEnumerable<IComplexExtensionItem> elements);
    }

    /// <summary>
    /// Base class for all CodedReference single accessors
    /// </summary>
    public class TItemExtensionSingle<TBase> : TItemSingle<TBase>, IElementExtensionItem
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

        public TItemExtensionSingle(String listName,
            Int32 min,
            Int32 max,
            String extensionUrl) : base(listName, min, max)
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
                default: throw new Exception($"HasMember item {this.listName} can not be set to multiple items");
            }
        }
    }

    /// <summary>
    /// </summary>
    public class TItemExtensionMultiple<TBase> : TItemMultiple<TBase>, IElementExtensionItem
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

        public TItemExtensionMultiple(String listName,
            Int32 min,
            Int32 max,
            String extensionUrl) : base(listName, min, max)
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
        IComplexExtension
        where TBase : IComplexExtensionItem, new()
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

        public TItemExtensionComplexSingle(String listName,
            Int32 min,
            Int32 max,
            String extensionUrl) : base(listName, min, max)
        {
            this.ExtensionUrl = extensionUrl;
        }

        public IEnumerable<IComplexExtensionItem> GetElements()
        {
            if (this.Value != null)
                yield return this.Value;
        }
        public void SetElements(IEnumerable<IComplexExtensionItem> items)
        {
            switch (items.Count())
            {
                case 0: break;
                case 1: this.Value = (TBase)items.First(); break;
                default: throw new Exception($"HasMember item {this.listName} can not be set to multiple items");
            }
        }
    }

    /// <summary>
    /// Base class for all CodedReference multiple accessors
    /// </summary>
    public class TItemExtensionComplexMultiple<TBase> : 
        TItemMultiple<TBase>, 
        IComplexExtension
        where TBase : IComplexExtensionItem, new()
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

        public TItemExtensionComplexMultiple(String listName,
            Int32 min,
            Int32 max,
            String extensionUrl) : base(listName, min, max)
        {
            this.ExtensionUrl = extensionUrl;
        }

        public IEnumerable<IComplexExtensionItem> GetElements()
        {
            foreach (var item in this.items)
                yield return item;
        }

        public void SetElements(IEnumerable<IComplexExtensionItem> items)
        {
            foreach (var item in items)
                this.items.Add((TBase)item);
        }
    }
}
