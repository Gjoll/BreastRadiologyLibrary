using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BreastRadLib
{
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
        /// For internal use only. Access all items.
        /// </summary>
        public BaseType Value { get; set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        protected ElementItemSingle(String listName) : base(listName)
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
