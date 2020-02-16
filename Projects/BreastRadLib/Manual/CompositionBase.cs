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
        /// <summary>
        /// Base class for all section accessors
        /// </summary>
        public class SectionBase<BaseType>
                where BaseType : ResourceBase, new()
        {
            /// <summary>
            /// Parent document
            /// </summary>
            public Int32 Count => this.items.Count;

            /// <summary>
            /// For internal use only. Access all items.
            /// </summary>
            public IEnumerable<BaseType> RawItems => this.items;

            /// <summary>
            /// Parent document
            /// </summary>
            protected BreastRadiologyDocument doc;

            /// <summary>
            /// Section item list
            /// </summary>
            protected List<BaseType> items = new List<BaseType>();

            // Properties
            /// <summary>
            /// Access Min cardinality
            /// </summary>
            public Int32 Min { get; protected set; }

            /// <summary>
            /// Access Max cardinality
            /// </summary>
            public Int32 Max { get; protected set; }

            /// <summary>
            /// Section Title
            /// </summary>
            public String Title { get; protected set; }

            /// <summary>
            /// Section coding
            /// </summary>
            public Coding Code { get; protected set; }

            protected SectionBase()
            {
            }

            protected void Create(BreastRadiologyDocument doc,
                String title,
                Int32 min,
                Int32 max,
                Coding code)
            {
                this.Title = title;
                this.Min = min;
                this.Max = max;
                this.Code = code;
            }

            /// <summary>
            /// Get single item or null.
            /// </summary>
            /// <returns></returns>
            protected T GetSingleItem<T>()
                where T : BaseType
            {
                return (T) this.items.FirstOrDefault();
            }

            /// <summary>
            /// Append new item to end of items list.
            /// </summary>
            /// <param name="item"></param>
            protected BaseType AppendItem<T>(T itemContainer)
                where T : BaseType
            {
                this.items.Add(itemContainer);
                return itemContainer;
            }

            /// <summary>
            /// Set single item
            /// </summary>
            /// <param name="item"></param>
            protected BaseType CreateSingleItem<T>(T itemContainer)
                where T : BaseType
            {
                if (this.items.Count > 0)
                    throw new Exception("Item already has a value");
                return AppendItem(itemContainer);
            }

            public void Read<T>(List<BaseType> items)
            {
                if (this.items.Count > 0)
                    throw new Exception("Items already set");
                if (items.Count < this.Min)
                    throw new Exception($"Items count {items.Count} is less than required min {this.Min}");
                if (items.Count < this.Max)
                    throw new Exception($"Items count {items.Count} is greater than required max {this.Min}");
                this.items.AddRange(items);
            }                                                                                                                                     // CSDefineComposition.cs:163

        }

        public Composition Resource => (Composition)this.resource;

        public CompositionBase() : base()
        {
        }

        public CompositionBase(BreastRadiologyDocument doc, Composition resource) : base()
        {
            this.Create(doc, resource);
        }

        public CompositionBase(BreastRadiologyDocument doc) : base()
        {
            this.Create(doc, new Composition());
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

        protected void ReadSection<T>(SectionBase<T> section)
            where T : ResourceBase, new()
        {
            List<T> items = new List<T>();
            Composition.SectionComponent sectionComponent = this.FindSection(section.Code);
            if (sectionComponent == null)
                return;
            foreach (ResourceReference resRef in sectionComponent.Entry)
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

            if (items.Count < section.Min)
                throw new Exception($"Error reading Composition.section '{section.Title}'. Min cardinality sb {section.Min}, is {items.Count}");
            if ((section.Max > 0) && (items.Count > section.Max))
                throw new Exception($"Error reading Composition.section '{section.Title}'. Max cardinality sb {section.Max}, is {items.Count}");
        }

        protected void WriteSection<T>(SectionBase<T> section)
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
