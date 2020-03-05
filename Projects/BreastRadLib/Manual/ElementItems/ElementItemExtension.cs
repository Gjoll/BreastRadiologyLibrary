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
    /// Interface for implementing ElementItemExtension classes.
    /// </summary>
    public interface IElementExtensionItem : IExtensionItem
    {
        IEnumerable<Element> GetElements();
        void SetElements(IEnumerable<Element> elements);
    }

    /// <summary>
    /// Interface for implementing ElementItemExtension classes.
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
    public class TElementItemExtensionSingle<BaseType> : TElementItemSingle<BaseType>, IElementExtensionItem
            where BaseType : Element, new()
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

        public String ExtensionUrl { get; }

        /// <summary>
        /// Create item if it doesn't already exist, and return item.
        /// </summary>
        protected BaseType Create()
        {
            if (this.Value == null)
            {
                BaseType item = new BaseType();
                this.Value = item;
            }
            return this.Value;
        }

        public TElementItemExtensionSingle(String listName,
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
                case 1: this.Value = (BaseType)items.First(); break;
                default: throw new Exception($"HasMember item {this.listName} can not be set to multiple items");
            }
        }
    }

    /// <summary>
    /// </summary>
    public class TElementItemExtensionMultiple<BaseType> : TElementItemMultiple<BaseType>, IElementExtensionItem
            where BaseType : Element, new()
    {
        public String ExtensionUrl { get; }

        public IEnumerable<BaseType> Items => this.items;

        public BaseType At(Int32 i) => this.items[i];

        public BaseType Append()
        {
            BaseType retVal = new BaseType();
            this.items.Add(retVal);
            return retVal;
        }

        public TElementItemExtensionMultiple(String listName,
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
                this.items.Add((BaseType)item);
        }
    }










    /// <summary>
    /// </summary>
    public class TElementItemExtensionComplexSingle<BaseType> : 
        TElementItemSingle<BaseType>, 
        IComplexExtension
        where BaseType : IComplexExtensionItem, new()
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

        public String ExtensionUrl { get; }

        /// <summary>
        /// Create item if it doesn't already exist, and return item.
        /// </summary>
        protected BaseType Create()
        {
            if (this.Value == null)
            {
                BaseType item = new BaseType();
                this.Value = item;
            }
            return this.Value;
        }

        public TElementItemExtensionComplexSingle(String listName,
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
                case 1: this.Value = (BaseType)items.First(); break;
                default: throw new Exception($"HasMember item {this.listName} can not be set to multiple items");
            }
        }
    }

    /// <summary>
    /// Base class for all CodedReference multiple accessors
    /// </summary>
    public class TElementItemExtensionComplexMultiple<BaseType> : 
        TElementItemMultiple<BaseType>, 
        IComplexExtension
        where BaseType : IComplexExtensionItem, new()
    {
        public String ExtensionUrl { get; }

        public IEnumerable<BaseType> Items => this.items;

        public BaseType At(Int32 i) => this.items[i];

        public BaseType Append()
        {
            BaseType retVal = new BaseType();
            this.items.Add(retVal);
            return retVal;
        }

        public TElementItemExtensionComplexMultiple(String listName,
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
                this.items.Add((BaseType)item);
        }
    }
}
