using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BreastRadLib
{
    public static class ItemElementExtensionMethods
    {
        public static void Read(this IItemElement itemElement,
            BreastRadiologyDocument doc,
            Resource resource)
        {
            //$throw new NotImplementedException();
            //List<ResourceBase> items = new List<ResourceBase>();
            //foreach (ResourceElement resRef in itemElement.GetResourceValues<ResourceElement>(resource))
            //{
            //    Observation ElementdResource = doc.ElementdResource<Observation>(resRef);
            //    String profile = ElementdResource.Meta.Profile.First();
            //    if (BLMisc.SameUrl(profile, itemElement.ProfileUrl))
            //    {
            //        if (doc.TryGetRegisteredItem(ElementdResource, out ObservationBase item) == false)
            //            throw new Exception($"Elementd resource {ElementdResource.Id} not found in bundle");
            //        items.Add(item);
            //    }
            //}
            //itemElement.SetElements(items);
            //itemElement.CheckCardinality();
        }

        public static void Write(this IItemElement itemElement,
            BreastRadiologyDocument doc,
            Resource resource)
        {
            itemElement.CheckCardinality();

            List<Element> items = itemElement.GetResourceValues<Element>(resource).ToList();
            foreach (Element item in itemElement.GetElements())
                items.Add(item);
            itemElement.SetResourceValues(resource, items);
        }
    }
}
