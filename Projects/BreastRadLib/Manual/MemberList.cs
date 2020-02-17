using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BreastRadLib
{
    /// <summary>
    /// Base class for all class member lists
    /// </summary>
    public class MemberList<BaseType>
            where BaseType : Base, new()
    {
        /// <summary>
        /// Parent document
        /// </summary>
        public Int32 Count => this.items.Count;

        /// <summary>
        /// For internal use only. Access all items.
        /// </summary>
        internal List<BaseType> RawItems
        {
            get => this.items;
            set => this.items = value;
        }

        /// <summary>
        /// Parent document
        /// </summary>
        protected BreastRadiologyDocument doc;

        /// <summary>
        /// Section item list
        /// </summary>
        protected List<BaseType> items = new List<BaseType>();

        // Properties
        /// <summary>
        /// Access Min cardinality
        /// </summary>
        public Int32 Min { get; protected set; }

        /// <summary>
        /// Access Max cardinality
        /// </summary>
        public Int32 Max { get; protected set; }

        protected MemberList()
        {
        }

        protected void Create(BreastRadiologyDocument doc,
            Int32 min,
            Int32 max)
        {
            this.doc = doc;
            this.Min = min;
            this.Max = max;
        }

        /// <summary>
        /// Get single item or null.
        /// </summary>
        /// <returns></returns>
        protected T GetSingleItem<T>()
            where T : BaseType
        {
            return (T)this.items.FirstOrDefault();
        }

        /// <summary>
        /// Append new item to end of items list.
        /// </summary>
        /// <param name="item"></param>
        protected BaseType AppendItem<T>(T itemContainer)
            where T : BaseType
        {
            this.items.Add(itemContainer);
            return itemContainer;
        }

        /// <summary>
        /// Set single item
        /// </summary>
        /// <param name="item"></param>
        protected BaseType CreateSingleItem<T>(T itemContainer)
            where T : BaseType
        {
            if (this.items.Count > 0)
                throw new Exception("Item already has a value");
            return AppendItem(itemContainer);
        }
    }
}
