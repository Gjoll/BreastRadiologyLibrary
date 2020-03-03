using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BreastRadLib
{
    /// <summary>
    /// Base class for all Element Items.
    /// </summary>
    public abstract class ElementItem
    {
        protected String listName;

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
        /// Constructor.
        /// </summary>
        /// <param name="listName"></param>
        protected ElementItem(String listName)
        {
            this.listName = listName;
        }

        /// <summary>
        /// Initialize item
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        protected void Init(Int32 min,
            Int32 max)
        {
            this.Min = min;
            this.Max = max;
        }

        public abstract bool Validate(StringBuilder sb);

    }
}
