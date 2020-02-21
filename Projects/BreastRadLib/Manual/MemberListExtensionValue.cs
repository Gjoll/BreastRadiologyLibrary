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
    public class MemberListExtensionValueBase<BaseType> : MemberList<BaseType>
        where BaseType : Element
    {
        protected MemberListExtensionValueBase(String listName) : base(listName)
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

        protected void SetFirst(BaseType value)
        {
            this.items.Clear();
            this.items.Add(value);
        }
    }
}
