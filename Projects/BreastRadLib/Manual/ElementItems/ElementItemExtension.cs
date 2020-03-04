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
    /// Interface for implementing ElementItemExtension classes.
    /// </summary>
    public interface IElementItemExtension
    {
        String ExtensionUrl { get; }
        IEnumerable<Element> GetElements();
        void SetElements(IEnumerable<Element> elements);
    }

    /// <summary>
    /// Base class for all CodedReference single accessors
    /// </summary>
    public class ElementItemExtensionSingle<BaseType> : ElementItemSingle<BaseType>, IElementItemExtension
            where BaseType : Element, new()
    {
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

        public ElementItemExtensionSingle(String listName,
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
    /// Base class for all CodedReference multiple accessors
    /// </summary>
    public class ElementItemExtensionMultiple<BaseType> : ElementItemMultiple<BaseType>, IElementItemExtension
            where BaseType : Element, new()
    {
        List<BaseType> items = new List<BaseType>();
        public String ExtensionUrl { get; }

        public IEnumerable<BaseType> Items => this.items;

        public BaseType At(Int32 i) => this.items[i];

        public BaseType Append()
        {
            BaseType retVal = new BaseType();
            this.items.Add(retVal);
            return retVal;
        }

        public ElementItemExtensionMultiple(String listName,
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
                this.items.Add((BaseType) item);
        }
    }


    /// <summary>
    /// Base class for all complex extension classes
    /// </summary>
    public abstract class ElementItemExtensionComplex : MemberListBase
    {
        protected ElementItemExtensionComplex(String listName) : base(listName)
        {
        }

        public void Read(Extension e)
        {
        }

        public abstract void ReadItems(IEnumerable<Extension> extensions);

        public void Write(Extension e)
        {
        }

        public abstract IEnumerable<Extension> WriteItems();
    }
}
