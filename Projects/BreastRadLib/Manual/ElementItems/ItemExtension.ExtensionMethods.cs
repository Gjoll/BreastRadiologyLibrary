using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BreastRadLib
{
    public static class ItemExtensionExtensionMethods
    {
        public static void Read(this IItemExtension itemExtension,
            BreastRadiologyDocument doc,
            Resource resource)
        {
            throw new NotImplementedException();
            //List<ResourceBase> items = new List<ResourceBase>();
            //foreach (ResourceExtension resRef in itemExtension.GetResourceValues<ResourceExtension>(resource))
            //{
            //    Observation ExtensiondResource = doc.ExtensiondResource<Observation>(resRef);
            //    String profile = ExtensiondResource.Meta.Profile.First();
            //    if (BLMisc.SameUrl(profile, itemExtension.ProfileUrl))
            //    {
            //        if (doc.TryGetRegisteredItem(ExtensiondResource, out ObservationBase item) == false)
            //            throw new Exception($"Extensiond resource {ExtensiondResource.Id} not found in bundle");
            //        items.Add(item);
            //    }
            //}
            //itemExtension.SetElements(items);
            //itemExtension.CheckCardinality();
        }

        public static void Write(this IItemExtension itemExtension,
            BreastRadiologyDocument doc,
            Resource resource)
        {
            throw new NotImplementedException();
            //itemExtension.CheckCardinality();

            //List<ResourceExtension> items = itemExtension.GetResourceValues<ResourceExtension>(resource).ToList();
            //foreach (ResourceBase item in itemExtension.GetElements())
            //{
            //    items.Add(new ResourceExtension
            //    {
            //        Extension = item.Id
            //    });
            //}
            //itemExtension.SetResourceValues(resource, items);
        }
    }
}
