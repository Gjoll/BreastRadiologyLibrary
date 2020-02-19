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
    {
        String listName;

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

        /// <summary>
        /// Access first item or default
        /// </summary>
        /// <returns></returns>
        protected BaseType FirstOrDefault() => items.FirstOrDefault();

        /// <summary>
        /// Access first item
        /// </summary>
        /// <returns></returns>
        protected BaseType First() => items.First();

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="listName"></param>
        protected MemberList(String listName)
        {
            this.listName = listName;
        }

        /// <summary>
        /// Initialize item
        /// </summary>
        /// <param name="doc"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        protected void Init(BreastRadiologyDocument doc,
            Int32 min,
            Int32 max)
        {
            this.doc = doc;
            this.Min = min;
            this.Max = max;
        }

        /// <summary>
        /// Validate list.
        /// </summary>
        public void Validate()
        {
            //if (this.items.Count < this.Min)
            //    throw new Exception($"{this.listName} min cardinality is invalid. Found {this.items.Count} items, expected at least {this.Min} items.");
            //if ((this.Max >= 0) && (this.items.Count > this.Max))
            //    throw new Exception($"{this.listName} max cardinality is invalid. Found {this.items.Count} items, expected less than {this.Max} items.");
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
        /// if list already has items, an exception is thrown.
        /// </summary>
        /// <param name="item"></param>
        protected void SetSingleItem(BaseType itemContainer)
        {
            if (this.items.Count > 0)
                throw new Exception("Item already has a value");
            AppendItem(itemContainer);
        }
    }
}
