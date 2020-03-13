using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadLib
{
    public static class FhirElementExtensions
    {
        public static bool IsCode(this CodeableConcept code1,
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
