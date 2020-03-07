using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadLib
{
    /// <summary>
    /// Interface that all Member classes implement.
    /// </summary>
    public interface ITMItem
    {
        /// <summary>
        /// Write out member item as a fhir element.
        /// </summary>
        IEnumerable<Element> Write();

        /// <summary>
        /// Read data from fhir element into member item.
        /// </summary>
        void Read(IEnumerable<Element> element);
    }
}
