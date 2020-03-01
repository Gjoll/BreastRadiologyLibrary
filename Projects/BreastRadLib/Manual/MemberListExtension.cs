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
    /// Base class for all component accessors
    /// </summary>
    public class MemberListExtension : MemberList<Element>
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

        protected void SetFirst(Element value)
        {
            this.items.Clear();
            this.items.Add(value);
        }

        protected void Write(MemberListExtension item)
        {
            throw new NotImplementedException();
        }

        protected void Read(MemberListExtension item)
        {
            throw new NotImplementedException();
        }
    }
}
