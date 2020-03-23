using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadLib
{
    /// <summary>
    /// Interface that all Member classes implement.
    /// </summary>
    public interface ITMItem<T>
    {
        /// <summary>
        /// Write out member item as a fhir element.
        /// </summary>
        IEnumerable<T> Write(BreastRadiologyDocument doc);

        /// <summary>
        /// Read data from fhir element into member item.
        /// </summary>
        void Read(BreastRadiologyDocument doc,
            IEnumerable<T> element);
    }
}
