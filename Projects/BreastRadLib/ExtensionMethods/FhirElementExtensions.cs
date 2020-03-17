using Hl7.Fhir.Introspection;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

        /// <summary>
        /// Set property of fhir element to passed value.
        /// Uses reflection.
        /// </summary>
        public static IEnumerable<T> GetValue<T>(this Base fhirElement,
            String fhirName)
            where T : Element
        {
            PropertyInfo pi = fhirElement.GetFhirProperty(fhirName);
            if (pi == null)
                throw new Exception($"Fhir property {fhirName} not found in class {fhirElement.GetType()}");
            if (pi.PropertyType.IsAssignableFrom(typeof(List<T>)))
            {
                return (List<T>)pi.GetValue(fhirElement);
            }
            else
            {
                return new T[] { (T)pi.GetValue(fhirElement) };
            }
        }

        /// <summary>
        /// Set property of fhir element to passed value.
        /// Uses reflection.
        /// </summary>
        public static void SetValue<T>(this Base fhirElement,
            String fhirName,
            T value)
            where T : Element
        {
            PropertyInfo pi = fhirElement.GetFhirProperty(fhirName);
            if (pi == null)
                throw new Exception($"Fhir property {fhirName} not found in class {fhirElement.GetType()}");
            if (pi.PropertyType.IsAssignableFrom(typeof(List<T>)))
            {
                List<T> list = new List<T>();
                list.Add(value);
                pi.SetValue(fhirElement, list);
            }
            else
            {
                pi.SetValue(fhirElement, value);
            }
        }

        /// <summary>
        /// Set property of fhir element to passed value.
        /// Uses reflection.
        /// </summary>
        public static void SetValue<T>(this Base fhirElement,
            String fhirName,
            IEnumerable<T> value)
            where T : Element
        {
            PropertyInfo pi = fhirElement.GetFhirProperty(fhirName);
            if (pi == null)
                throw new Exception($"Fhir property {fhirName} not found in class {fhirElement.GetType()}");
            if (pi.PropertyType.IsAssignableFrom(typeof(List<T>)))
            {
                pi.SetValue(fhirElement, value.ToList());
            }
            else
            {
                switch(value.Count())
                {
                    case 0:
                        pi.SetValue(fhirElement, null);
                        break;
                    case 1:
                        pi.SetValue(fhirElement, value.First());
                        break;
                    default:
                        throw new Exception($"Can not set multiple values to single element");
                }
            }
        }

        /// <summary>
        /// Get PropertyInfo on property with the matching
        /// FhirAttribute tag name.
        /// </summary>
        public static PropertyInfo GetFhirProperty(this Base fhirElement,
            String fhirName)
        {
            foreach (PropertyInfo propertyInfo in fhirElement.GetType().GetProperties())
            {
                object[] attributes = propertyInfo.GetCustomAttributes(typeof(FhirElementAttribute), false);
                foreach (FhirElementAttribute attribute in attributes)
                {
                    if (String.Compare(attribute.Name, fhirName, StringComparison.OrdinalIgnoreCase) == 0)
                        return propertyInfo;
                }
            }
            return null;
        }
    }
}
