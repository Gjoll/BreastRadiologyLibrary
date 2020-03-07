using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadLib
{
    /// <summary>
    /// Base class for all multiple item (max cardinality > 1) member container classes.
    /// </summary>
    public class TMContainerMultiple<T> : MContainer, ITMItem
        where T : IItem
    {
        /// <summary>
        /// List of items in member collection.
        /// </summary>
        protected List<T> items = new List<T>();

        /// <summary>
        /// Count
        /// </summary>
        public override Int32 Count => this.Count;

        /// <summary>
        /// Constructor.
        /// </summary>
        protected TMContainerMultiple(String fhirPath,
            Int32 min,
            Int32 max) : base(fhirPath, min, max)
        {
        }

        /// <summary>
        /// Write out member item as a fhir element.
        /// </summary>
        public IEnumerable<Element> Write()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Read data from fhir element into member item.
        /// </summary>
        public void Read(IEnumerable<Element> element)
        {
            throw new NotImplementedException();
        }
    }
}
