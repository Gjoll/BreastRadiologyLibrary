using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadLib
{
    public static class ItemExtensionMethods
    {
        public static void CheckCardinality(this IItem item)
        {
            if (item.Count < item.Min)
                throw new Exception($"Error writing Composition.section '{item.FhirPath}'. Min cardinality sb {item.Min}, is {item.Count}");
            if ((item.Max > 0) && (item.Count > item.Max))
                throw new Exception($"Error writing Composition.section '{item.FhirPath}'. Max cardinality sb {item.Max}, is {item.Count}");
        }

        public static bool IsCode(CodeableConcept code1,
            CodeableConcept code2)
        {
            foreach (Coding c in code1.Coding)
            {
                foreach (Coding d in code2.Coding)
                {
                    if (
                        (String.Compare(c.System, d.System, true) == 0) &&
                        (String.Compare(c.Code, d.Code, true) == 0)
                        )
                        return true;
                }
            }
            return false;
        }
    }
}
