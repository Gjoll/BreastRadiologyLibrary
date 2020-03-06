using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BreastRadLib
{
    public static class ItemComponentExtensionMethods
    {
        public static void ReadItemComponent(this IItemComponent itemComponent,
            BreastRadiologyDocument doc,
            Resource resource)
        {
            List<Element> items = new List<Element>();
            foreach (Observation.ComponentComponent component in itemComponent.GetResourceValues<Observation.ComponentComponent>(resource))
            {
                if (ItemExtensionMethods.IsCode(component.Code, itemComponent.Code) == true)
                    items.Add(component.Value);
            }
            itemComponent.SetElements(items);
            itemComponent.CheckCardinality();
        }

        public static void WriteItemComponent(this IItemComponent itemComponent,
            BreastRadiologyDocument doc,
            Resource resource)
        {
            itemComponent.CheckCardinality();

            List<Observation.ComponentComponent> items = itemComponent.GetResourceValues<Observation.ComponentComponent>(resource).ToList();
            foreach (Element item in itemComponent.GetElements())
            {
                Observation.ComponentComponent comp = new Observation.ComponentComponent
                {
                    Code = itemComponent.Code,
                    Value = item
                };
                items.Add(comp);
            }
            itemComponent.SetResourceValues(resource, items);
        }
    }
}
