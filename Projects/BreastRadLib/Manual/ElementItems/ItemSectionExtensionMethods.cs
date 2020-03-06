using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BreastRadLib
{
    internal static class ItemSectionExtensionMethods
    {
        public static Composition.SectionComponent FindSection(this IItemSection itemSection,
            Resource resource)
        {
            bool IsCode(CodeableConcept sectionCode)
            {
                foreach (Coding c in sectionCode.Coding)
                {
                    foreach (Coding d in itemSection.Code.Coding)
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

            foreach (Composition.SectionComponent section in itemSection.GetResourceValues<Composition.SectionComponent>(resource))
            {
                if (IsCode(section.Code))
                    return section;
            }
            return null;
        }

        public static void CheckCardinality(this IItemSection itemSection)
        {
            if (itemSection.Count < itemSection.Min)
                throw new Exception($"Error writing Composition.section '{itemSection.Title}'. Min cardinality sb {itemSection.Min}, is {itemSection.Count}");
            if ((itemSection.Max > 0) && (itemSection.Count > itemSection.Max))
                throw new Exception($"Error writing Composition.section '{itemSection.Title}'. Max cardinality sb {itemSection.Max}, is {itemSection.Count}");
        }

        public static void ReadItemSection(this IItemSection itemSection, 
            BreastRadiologyDocument doc,
            Resource resource)
        {
            Composition.SectionComponent section = itemSection.FindSection(resource);
            if (section == null)
                return;

            List<ResourceBase> items = new List<ResourceBase>();

            foreach (ResourceReference resRef in section.Entry)
            {
                Resource referencedResource = doc.ReferencedResource<Resource>(resRef);
                String profile = referencedResource.Meta.Profile.First();
                if (doc.TryGetRegisteredItem(referencedResource, out ResourceBase item) == false)
                    throw new Exception($"Referenced resource {referencedResource.Id} not found in bundle");

                if (item == null)
                    throw new Exception($"Error creating resource of profile {profile}");
                items.Add(item);
            }
            itemSection.SetElements(items);
            itemSection.CheckCardinality();
        }

        public static void WriteItemSection(this IItemSection itemSection,
            BreastRadiologyDocument doc,
            Resource resource)
        {
            itemSection.CheckCardinality();

            Composition.SectionComponent sectionComponent = new Composition.SectionComponent
            {
                Code = itemSection.Code,
                Title = itemSection.Title
            };

            foreach (ResourceBase item in itemSection.GetElements())
                sectionComponent.Entry.Add(new ResourceReference(item.Id));

            List<Composition.SectionComponent> items = itemSection.GetResourceValues< Composition.SectionComponent>(resource).ToList();
            items.Add(sectionComponent);
            itemSection.SetResourceValues(resource, items);
        }
    }
}
