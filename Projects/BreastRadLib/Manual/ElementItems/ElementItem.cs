using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BreastRadLib
{
    /// <summary>
    /// Interface for implementing ElementItem classes.
    /// </summary>
    public interface IElementItem
    {
        String listName { get; }
        Int32 Min { get; }
        Int32 Max { get; }
    }

    /// <summary>
    /// Base class for all Element Items.
    /// </summary>
    public abstract class ElementItem : IElementItem
    {
        public String listName { get; }

        // Properties
        /// <summary>
        /// Access Min cardinality
        /// </summary>
        public Int32 Min { get; }

        /// <summary>
        /// Access Max cardinality
        /// </summary>
        public Int32 Max { get; }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="listName"></param>
        protected ElementItem(String listName,
            Int32 min,
            Int32 max)
        {
            this.listName = listName;
            this.Min = min;
            this.Max = max;
        }

        public abstract bool Validate(StringBuilder sb);
    }


    /// <summary>
    /// Base class for all class member single item class's
    /// </summary>
    public class ElementItemSingle<BaseType> : ElementItem
    {
        /// <summary>
        /// Count
        /// </summary>
        public bool Exists => this.Value != null;

        /// <summary>
        /// Access value.
        /// </summary>
        public BaseType Value { get; set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        protected ElementItemSingle(String listName,
            Int32 min,
            Int32 max) : base(listName, min, max)
        {
        }

        /// <summary>
        /// Validate list.
        /// </summary>
        public override bool Validate(StringBuilder sb)
        {
            bool retVal = true;
            //if (this.items.Count < this.Min)
            //{
            //    sb.Append($"{this.listName} min cardinality is invalid. Found {this.items.Count} items, expected at least {this.Min} items.");
            //    retVal = false;
            //}

            //if ((this.Max >= 0) && (this.items.Count > this.Max))
            //{
            //    sb.Append($"{this.listName} max cardinality is invalid. Found {this.items.Count} items, expected less than {this.Max} items.");
            //    retVal = false;
            //}

            return retVal;
        }
    }


    /// <summary>
    /// Base class for all ElementItem multiple member clases
    /// </summary>
    public class ElementItemMultiple<BaseType> : ElementItem
    {
        protected List<BaseType> items = new List<BaseType>();

        /// <summary>
        /// Count
        /// </summary>
        public Int32 Count => this.items.Count;

        /// <summary>
        /// Constructor.
        /// </summary>
        protected ElementItemMultiple(String listName,
            Int32 min,
            Int32 max) : base(listName, min, max)
        {
        }

        /// <summary>
        /// Validate list.
        /// </summary>
        public override bool Validate(StringBuilder sb)
        {
            bool retVal = true;
            //if (this.items.Count < this.Min)
            //{
            //    sb.Append($"{this.listName} min cardinality is invalid. Found {this.items.Count} items, expected at least {this.Min} items.");
            //    retVal = false;
            //}

            //if ((this.Max >= 0) && (this.items.Count > this.Max))
            //{
            //    sb.Append($"{this.listName} max cardinality is invalid. Found {this.items.Count} items, expected less than {this.Max} items.");
            //    retVal = false;
            //}

            return retVal;
        }
    }
}
