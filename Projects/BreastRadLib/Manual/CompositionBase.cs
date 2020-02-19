using BreastRadLib.CompositionLocal;
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

        public CompositionBase() : base()
        {
        }

        public CompositionBase(BreastRadiologyDocument doc) : base()
        {
            this.Init(doc, new Composition());
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

        protected void ReadSection<T>(MemberListSectionBase<T> section)
            where T : ResourceBase, new()
        {
            List<T> items = new List<T>();
            Composition.SectionComponent sectionComponent = this.FindSection(section.Code);
            if (sectionComponent == null)
                return;
            foreach (ResourceReference resRef in sectionComponent.Entry)
            {
                Resource referencedResource = ReferencedResource<Resource>(resRef);
                String profile = referencedResource.Meta.Profile.First();
                if (this.doc.TryGetRegisteredItem(referencedResource, out T item) == false)
                    throw new Exception($"Referenced resource {referencedResource.Id} not found in bundle");

                if (item == null)
                    throw new Exception($"Error creating resource of profile {profile}");
                items.Add(item);
            }

            if (items.Count < section.Min)
                throw new Exception($"Error reading Composition.section '{section.Title}'. Min cardinality sb {section.Min}, is {items.Count}");
            if ((section.Max > 0) && (items.Count > section.Max))
                throw new Exception($"Error reading Composition.section '{section.Title}'. Max cardinality sb {section.Max}, is {items.Count}");
            section.RawItems = items;
        }

        protected void WriteSection<T>(MemberListSectionBase<T> section)
            where T : ResourceBase, new()
        {
            if (section.Count < section.Min)
                throw new Exception($"Error writing Composition.section '{section.Title}'. Min cardinality sb {section.Min}, is {section.Count}");
            if ((section.Max > 0) && (section.Count > section.Max))
                throw new Exception($"Error writing Composition.section '{section.Title}'. Max cardinality sb {section.Max}, is {section.Count}");

            Composition.SectionComponent sectionComponent = new Composition.SectionComponent
            {
                Code = new CodeableConcept(section.Code.System, section.Code.Code, section.Code.Display),
                Title = section.Title
            };

            foreach (var item in section.RawItems)
                sectionComponent.Entry.Add(new ResourceReference(item.Id));

            this.Resource.Section.Add(sectionComponent);
        }
    }
}
