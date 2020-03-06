using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BreastRadLib
{
    public static class ItemReferenceExtensionMethods
    {
        public static void Read(this IItemReference itemReference,
            BreastRadiologyDocument doc,
            Resource resource)
        {
            List<ResourceBase> items = new List<ResourceBase>();
            foreach (ResourceReference resRef in itemReference.GetResourceValues<ResourceReference>(resource))
            {
                Observation referencedResource = doc.ReferencedResource<Observation>(resRef);
                String profile = referencedResource.Meta.Profile.First();
                if (BLMisc.SameUrl(profile, itemReference.ProfileUrl))
                {
                    if (doc.TryGetRegisteredItem(referencedResource, out ObservationBase item) == false)
                        throw new Exception($"Referenced resource {referencedResource.Id} not found in bundle");
                    items.Add(item);
                }
            }
            itemReference.SetElements(items);
            itemReference.CheckCardinality();
        }

        public static void Write(this IItemReference itemReference,
            BreastRadiologyDocument doc,
            Resource resource)
        {
            itemReference.CheckCardinality();

            List<ResourceReference> items = itemReference.GetResourceValues<ResourceReference>(resource).ToList();
            foreach (ResourceBase item in itemReference.GetElements())
            {
                items.Add(new ResourceReference
                {
                    Reference = item.Id
                });
            }
            itemReference.SetResourceValues(resource, items);
        }
    }
}
