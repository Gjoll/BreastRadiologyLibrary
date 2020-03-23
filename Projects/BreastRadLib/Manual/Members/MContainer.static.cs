using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadLib
{
    public static class MContainerStatic
    {
        public static void CheckCardinality(this IMContainer item)
        {
            if (GlobalSettings.IgnoreCardinalityErrors == true)
                return;
            if (item.Count < item.Min)
                throw new Exception($"Error writing Composition.section '{item.PathName}'. Min cardinality sb {item.Min}, is {item.Count}");
            if ((item.Max > 0) && (item.Count > item.Max))
                throw new Exception($"Error writing Composition.section '{item.PathName}'. Max cardinality sb {item.Max}, is {item.Count}");
        }
    }
}
