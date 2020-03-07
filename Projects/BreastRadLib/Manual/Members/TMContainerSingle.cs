using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadLib
{
    /// <summary>
    /// Base class for all single item (max cardinality = 1) member container classes.
    /// </summary>
    public class TMContainerSingle<T> : MContainer, ITMItem
        where T : IItem
    {
        /// <summary>
        /// Count
        /// </summary>
        public override Int32 Count => this.Value == null ? 0 : 1;

        /// <summary>
        /// Access value.
        /// </summary>
        protected T Value { get; set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        protected TMContainerSingle(String fhirPath,
            Int32 min) : base(fhirPath, min, 1)
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
