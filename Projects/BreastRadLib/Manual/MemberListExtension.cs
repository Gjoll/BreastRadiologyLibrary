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
    public interface IMemberListExtension
    {

    };

    public interface IMemberListExtensionItem
    {

    };

    /// <summary>
    /// Base class for all component accessors
    /// </summary>
    public abstract class MemberListExtension<T> : MemberList<T>, IMemberListExtension
    {
        protected MemberListExtension(String listName) : base(listName)
        {
        }

        /// <summary>
        /// Extension url
        /// </summary>
        public String Url { get; protected set; }

        protected void Init(BreastRadiologyDocument doc,
            Int32 min,
            Int32 max,
            String url)
        {
            base.Init(doc, min, max);
            this.Url = url;
        }

        protected void SetFirst(T value)
        {
            this.items.Clear();
            this.items.Add(value);
        }

        public abstract IEnumerable<Extension> WriteItems();

        public abstract void ReadItems(IEnumerable<Extension> e);
    }


    /// <summary>
    /// Base class for all component accessors
    /// </summary>
    public abstract class MemberListExtensionComplex : MemberListBase
    {
        protected MemberListExtensionComplex(String listName) : base(listName)
        {
        }

        public void Read(Extension e)
        {
        }

        protected abstract void ReadItems(IEnumerable<Extension> extensions);

        public void Write(Extension e)
        {
        }

        protected abstract IEnumerable<Extension> WriteItems();
    }

    /// <summary>
    /// Base class for all component accessors
    /// </summary>
    public class MemberListExtensionSimple<T> : MemberListExtension<T>, 
                                              IMemberListExtensionItem
        where T : Element
    {
        protected MemberListExtensionSimple(String listName) : base(listName)
        {
        }

        public override void ReadItems(IEnumerable<Extension> extensions)
        {
            foreach (Extension extension in extensions)
            {
                if (extension.Url == this.Url)
                    this.RawItems.Add((T)extension.Value);
            }
        }

        public override IEnumerable<Extension> WriteItems()
        {
            List<Extension> retVal = new List<Extension>();
            foreach (T item in this.RawItems)
            {
                retVal.Add(new Extension
                {
                    Url = this.Url,
                    Value = item
                });
            }
            return retVal;
        }
    }
}

