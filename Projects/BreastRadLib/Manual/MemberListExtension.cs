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

        public abstract void Write(Extension e);

        public abstract void Read(Extension e);
    }


    /// <summary>
    /// Base class for all component accessors
    /// </summary>
    public class MemberListExtensionItem<T> : MemberListExtension<T>, 
                                              IMemberListExtensionItem
        where T : Element
    {
        protected MemberListExtensionItem(String listName) : base(listName)
        {
        }

        public override void Read(Extension e)
        {
        }

        public override void Write(Extension e)
        {
        }
    }
}

