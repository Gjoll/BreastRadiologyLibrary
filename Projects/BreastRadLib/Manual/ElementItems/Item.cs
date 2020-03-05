using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BreastRadLib
{
    /// <summary>
    /// Interface for implementing Item classes.
    /// </summary>
    public interface IItem
    {
        String listName { get; }
        Int32 Count { get; }
        Int32 Min { get; }
        Int32 Max { get; }
    }

    /// <summary>
    /// Base class for all Element Items.
    /// </summary>
    public abstract class Item : IItem
    {
        public String listName { get; }

        public abstract Int32 Count { get; }

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
        protected Item(String listName,
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
    public class TItemSingle<TBase> : Item
    {
        /// <summary>
        /// Count
        /// </summary>
        public override Int32 Count => this.Value == null ? 0 : 1;

        /// <summary>
        /// Access value.
        /// </summary>
        protected TBase Value { get; set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        protected TItemSingle(String listName,
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
            if (this.Count < this.Min)
            {
                sb.Append($"{this.listName} min cardinality is invalid. Found {this.Count} items, expected at least {this.Min} items.");
                retVal = false;
            }

            if ((this.Max >= 0) && (this.Count > this.Max))
            {
                sb.Append($"{this.listName} max cardinality is invalid. Found {this.Count} items, expected less than {this.Max} items.");
                retVal = false;
            }

            return retVal;
        }
    }


    /// <summary>
    /// Base class for all Item multiple member clases
    /// </summary>
    public class TItemMultiple<TBase> : Item
    {
        protected List<TBase> items = new List<TBase>();

        /// <summary>
        /// Count
        /// </summary>
        public override Int32 Count => this.items.Count;

        /// <summary>
        /// Constructor.
        /// </summary>
        protected TItemMultiple(String listName,
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
            if (this.items.Count < this.Min)
            {
                sb.Append($"{this.listName} min cardinality is invalid. Found {this.items.Count} items, expected at least {this.Min} items.");
                retVal = false;
            }

            if ((this.Max >= 0) && (this.items.Count > this.Max))
            {
                sb.Append($"{this.listName} max cardinality is invalid. Found {this.items.Count} items, expected less than {this.Max} items.");
                retVal = false;
            }

            return retVal;
        }
    }
}
