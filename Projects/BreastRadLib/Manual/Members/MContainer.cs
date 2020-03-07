using Hl7.Fhir.Introspection;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace BreastRadLib
{
    /// <summary>
    /// Base class for all member classes.
    /// </summary>
    public abstract class MContainer : IMContainer
    {
        /// <summary>
        /// Path to the item that this references.
        /// This includes slice names, so it is really the same as the Fhir element id.
        /// </summary>
        public String FhirPath { get; }

        /// <summary>
        /// Count of items
        /// </summary>
        public abstract Int32 Count { get; }

        /// <summary>
        /// Min cardinality
        /// </summary>
        public Int32 Min { get; }

        /// <summary>
        /// Max cardinality
        /// </summary>
        public Int32 Max { get; }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="fhirPath"></param>
        protected MContainer(String fhirPath,
            Int32 min,
            Int32 max)
        {
            this.FhirPath = fhirPath;
            this.Min = min;
            this.Max = max;
        }

        /// <summary>
        /// Validate member. Mostly checks that cardinalities are value.
        /// </summary>
        /// <param name="sb"></param>
        /// <returns></returns>
        public virtual bool Validate(StringBuilder sb)
        {
            bool retVal = true;
            if (this.Count < this.Min)
            {
                sb.Append($"{this.FhirPath} min cardinality is invalid. Found {this.Count} items, expected at least {this.Min} items.");
                retVal = false;
            }

            if ((this.Max >= 0) && (this.Count > this.Max))
            {
                sb.Append($"{this.FhirPath} max cardinality is invalid. Found {this.Count} items, expected less than {this.Max} items.");
                retVal = false;
            }

            return retVal;
        }

        //PropertyInfo PInfo(Base resource, String fhirName)
        //{
        //    foreach (var propertyInfo in resource.GetType().GetProperties())
        //    {
        //        object[] attributes = propertyInfo.GetCustomAttributes(typeof(FhirElementAttribute), false);
        //        foreach (FhirElementAttribute attribute in attributes)
        //        {
        //            if (String.Compare(attribute.Name, fhirName, StringComparison.OrdinalIgnoreCase) == 0)
        //                return propertyInfo;
        //        }
        //    }
        //    return null;
        //}

        ///// <summary>
        ///// Use reflection to set the child property of fhirItem that is
        ///// marked with the FhirAttribute .name that matches this items name.
        ///// </summary>
        //public void SetResourceValues<T>(Base fhirItem, IEnumerable<T> items)
        //{
        //    if (items.Count() == 0)
        //        return;

        //    String fhirPath = this.FhirPath.RemoveSliceNames();
        //    String fhirName = fhirPath.LastPathPart();

        //    PropertyInfo pInfo = PInfo(fhirItem, fhirName);
        //    if (pInfo == null)
        //        throw new Exception($"Internal error. {fhirName} not found in {fhirItem.GetType().Name}");
        //    if (pInfo.PropertyType.IsAssignableFrom(typeof(List<T>)))
        //    {
        //        pInfo.SetValue(fhirItem, items.ToList());
        //        return;
        //    }

        //    if (items.Count() > 1)
        //        throw new Exception($"Internal error. Can not set single item to multipel value array");
        //    pInfo.SetValue(fhirItem, items.First());
        //}

        ///// <summary>
        ///// Use reflection to find and retrieve all the
        ///// child properties of fhirItem that are marked
        ///// with the FhirAttribute .name that matches this items name.
        ///// Return their c# instances as an IEnumerable.
        ///// </summary>
        //public IEnumerable<T> GetResourceValues<T>(Base fhirItem)
        //{
        //    String fhirPath = this.FhirPath.RemoveSliceNames();
        //    String fhirName = fhirPath.LastPathPart();

        //    PropertyInfo pInfo = PInfo(fhirItem, fhirName);
        //    if (pInfo == null)
        //        throw new Exception($"Internal error. {fhirName} not found in {fhirItem.GetType().Name}");
        //    Object value = pInfo.GetValue(fhirItem);
        //    switch (value)
        //    {
        //        case null:
        //            yield break;

        //        case System.Collections.IEnumerable list:
        //            foreach (T item in list)
        //                yield return item;
        //            break;

        //        case T b:
        //            yield return b;
        //            break;
        //    }
        //}
    }
}
