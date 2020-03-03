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
    /// Base class for all CodedReference single accessors
    /// </summary>
    public class ElementItemReferenceSingle<BaseType> : ElementItemSingle<BaseType>
            where BaseType : ResourceBase, new()
    {
        BreastRadiologyDocument doc;
        public String ProfileUrl { get; private set; }

        public void Init(BreastRadiologyDocument doc,
            Int32 min,
            Int32 max,
            String profileUrl)
        {
            this.doc = doc;
            this.ProfileUrl = profileUrl;
            base.Init(min, max);
        }

        /// <summary>
        /// Create item if it doesn't already exist, and return item.
        /// </summary>
        protected BaseType Create()
        {
            if (this.Value == null)
            {
                BaseType item = new BaseType();
                item.Init(this.doc);
                this.Value = item;
            }
            return this.Value;
        }

        public ElementItemReferenceSingle(String listName) : base(listName)
        {
        }
    }

    /// <summary>
    /// Base class for all CodedReference multiple accessors
    /// </summary>
    public class ElementItemReferenceMultiple<BaseType> : ElementItemMultiple<BaseType>
            where BaseType : ResourceBase, new()
    {
        BreastRadiologyDocument doc;
        List<BaseType> items = new List<BaseType>();
        public String ProfileUrl { get; private set; }

        public IEnumerable<BaseType> Items() => this.items;

        public BaseType At(Int32 i) => this.items[i];

        public void Init(BreastRadiologyDocument doc,
            Int32 min,
            Int32 max,
            String profileUrl)
        {
            this.doc = doc;
            this.ProfileUrl = profileUrl;
            base.Init(min, max);
        }

        public BaseType Append()
        {
            BaseType retVal = new BaseType();
            retVal.Init(this.doc);
            this.items.Add(retVal);
            return retVal;
        }

        public ElementItemReferenceMultiple(String listName) : base(listName)
        {
        }
    }
}
