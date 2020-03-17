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
        public String PathName { get; }

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
        protected MContainer(String pathName,
            Int32 min,
            Int32 max)
        {
            this.PathName = pathName;
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
            throw new NotImplementedException();
            //bool retVal = true;
            //if (this.Count < this.Min)
            //{
            //    sb.Append($"{this.FhirPath} min cardinality is invalid. Found {this.Count} items, expected at least {this.Min} items.");
            //    retVal = false;
            //}

            //if ((this.Max >= 0) && (this.Count > this.Max))
            //{
            //    sb.Append($"{this.FhirPath} max cardinality is invalid. Found {this.Count} items, expected less than {this.Max} items.");
            //    retVal = false;
            //}

            //return retVal;
        }

        protected IEnumerable<Extension> IsMember(BreastRadiologyDocument doc,
            IEnumerable<Extension> extensions,
            String url)
        {
            foreach (Extension extension in extensions)
            {
                if (String.Compare(extension.Url, url, StringComparison.OrdinalIgnoreCase) == 0)
                    yield return extension;
            }
        }

        protected IEnumerable<Element> IsMember(BreastRadiologyDocument doc,
            IEnumerable<Observation.ComponentComponent> components,
            CodeableConcept code)
        {
            foreach (Observation.ComponentComponent component in components)
            {
                if (component.Code.IsCode(code))
                    yield return component.Value;
            }
        }

        protected IEnumerable<ResourceBase> IsMember(BreastRadiologyDocument doc,
            IEnumerable<Composition.SectionComponent> sections,
            CodeableConcept code)
        {
            foreach (Composition.SectionComponent section in sections)
            {
                if (section.Code.IsCode(code))
                {
                    foreach (ResourceReference resRef in section.Entry)
                    {
                        Resource referencedResource = doc.ReferencedResource<Resource>(resRef);
                        if (doc.TryGetRegisteredItem(referencedResource, out ResourceBase item) == false)
                            throw new Exception($"Referenced resource {referencedResource.Id} not found in bundle");
                        yield return item;
                    }
                }
            }
        }

        protected IEnumerable<ResourceReference> IsMember(BreastRadiologyDocument doc,
            IEnumerable<ResourceReference> references,
            IEnumerable<String> targetUrls)
        {
            foreach (ResourceReference resRef in references)
            {
                Observation referencedResource = doc.ReferencedResource<Observation>(resRef);
                String profile = referencedResource.Meta.Profile.First();
                foreach (String targetUrl in targetUrls)
                {
                    if (BLMisc.SameUrl(profile, targetUrl))
                    {
                        yield return resRef;
                        break;
                    }
                }
            }
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
