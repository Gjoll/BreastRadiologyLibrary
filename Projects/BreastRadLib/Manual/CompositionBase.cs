using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BreastRadLib
{
    public interface ICompositionBase : IResourceBase
    {
    }

    public class CompositionBase : ResourceBase, ICompositionBase
    {
        public Composition Resource => (Composition)this.resource;

        public CompositionBase(BreastRadiologyDocument doc, Composition resource) : base(doc, resource)
        {
        }

        public CompositionBase(BreastRadiologyDocument doc) : base(doc, new Composition())
        {
        }

        protected void ClearSection()
        {
            this.Resource.Section.Clear();
        }


        Composition.SectionComponent FindSection(Coding code)
        {

            bool IsCode(CodeableConcept sectionCode)
            {
                foreach (Coding c in sectionCode.Coding)
                {
                    if (
                        (String.Compare(c.System, code.System, true) == 0) &&
                        (String.Compare(c.Code, code.Code, true) == 0)
                        )
                        return true;
                }
                return false;
            }

            foreach (Composition.SectionComponent section in this.Resource.Section)
            {
                if (IsCode(section.Code))
                    return section;
            }
            return null;
        }

        protected List<T> ReadSection<T>(String title,
            Coding code,
            Int32 min,
            Int32 max)
            where T : ResourceBase
        {
            List<T> items = new List<T>();
            Composition.SectionComponent section = this.FindSection(code);
            if (section == null)
                return items;
            foreach (ResourceReference resRef in section.Entry)
            {
                if (this.doc.ResourceBag.TryGetEntry(resRef.Reference, out var entry) == false)
                    throw new Exception($"Error referencing section resource '{resRef.Reference}'");
                Resource referencedResource = entry.Resource;
                if (referencedResource.Meta.Profile.Count() != 1)
                    throw new Exception($"Invalid Meta.profile. Expected 1, got {referencedResource.Meta.Profile.Count()}");
                String profile = referencedResource.Meta.Profile.First();
                T item = ResourceFactory.CreateBreastRadProfileResource(this.doc, profile, referencedResource) as T;

                if (item == null)
                    throw new Exception($"Error creating resource of profile {profile}");
                items.Add(item);
            }

            if (items.Count < min)
                throw new Exception($"Error reading Composition.section '{title}'. Min cardinality sb {min}, is {items.Count}");
            if ((max > 0) && (items.Count > max))
                throw new Exception($"Error reading Composition.section '{title}'. Max cardinality sb {max}, is {items.Count}");
            return items;
        }

        protected void WriteSection<T>(String title, Coding code, Int32 min, Int32 max, T item)
            where T : IBaseBase
        {
            List<T> items = new List<T>();
            items.Add(item);
            this.WriteSection(title, code, min, max, items);
        }

        protected void WriteSection<T>(String title, Coding code, Int32 min, Int32 max, List<T> items)
            where T : IBaseBase
        {
            if (items.Count < min)
                throw new Exception($"Error writing Composition.section '{title}'. Min cardinality sb {min}, is {items.Count}");
            if ((max > 0) && (items.Count > max))
                throw new Exception($"Error writing Composition.section '{title}'. Max cardinality sb {max}, is {items.Count}");

            Composition.SectionComponent section = new Composition.SectionComponent
            {
                Code = new CodeableConcept(code.System, code.Code, code.Display),
                Title = title
            };

            foreach (T item in items)
                section.Entry.Add(new ResourceReference(item.Id));

            this.Resource.Section.Add(section);
        }
    }
}
