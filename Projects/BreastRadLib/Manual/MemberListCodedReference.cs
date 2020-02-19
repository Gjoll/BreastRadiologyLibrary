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
    /// Base class for all CodedReference accessors
    /// </summary>
    public class MemberListCodedReferenceBase<BaseType> : MemberList<BaseType>
            where BaseType : ObservationBase
    {
        public String ProfileUrl { get; private set; }
        public String Title { get; private set; }

        public MemberListCodedReferenceBase(String listName) : base(listName)
        {
        }

        public void Init(BreastRadiologyDocument doc,
            string title,
            Int32 min,
            Int32 max,
            String profileUrl)
        {
            this.ProfileUrl = profileUrl;
            base.Init(doc, min, max);
            this.Title = title;
        }
    }

    /// <summary>
    /// Base class for all CodedReference single accessors
    /// </summary>
    public class MemberListCodedReferenceSingle<BaseType> : MemberListCodedReferenceBase<BaseType>
            where BaseType : ObservationBase, new()
    {
        /// <summary>
        /// Get item
        /// </summary>
        public BaseType Get() => this.FirstOrDefault();

        /// <summary>
        /// Create item if it doesn't already exist, and return item.
        /// </summary>
        public BaseType Create => DoCreate();

        /// <summary>
        /// Create item if it doesn't already exist, and return item.
        /// </summary>
        protected BaseType DoCreate()
        {
            if (this.items.Count == 0)
            {
                BaseType item = new BaseType();
                item.Init(this.doc, new Observation());
                this.items.Add(item);
            }
            return this.items.First();
        }


        public MemberListCodedReferenceSingle(String listName) : base(listName)
        {
        }
    }

    /// <summary>
    /// Base class for all CodedReference multiple accessors
    /// </summary>
    public class MemberListCodedReferenceMultiple<BaseType> : MemberListCodedReferenceBase<BaseType>
            where BaseType : ObservationBase, new()
    {
        public IEnumerable<BaseType> All() => this.items;

        public BaseType At(Int32 i) => this.items[i];

        public new BaseType First() => (BaseType)base.First();

        public BaseType Append()
        {
            BaseType retVal = new BaseType();
            retVal.Init(this.doc, new Observation());
            this.items.Add(retVal);
            return retVal;
        }

        public MemberListCodedReferenceMultiple(String listName) : base(listName)
        {
        }
    }
}