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
            // Definitions

            // Fields
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
            /// Set single item
            /// </summary>
            /// <param name="item"></param>
            protected T CreateSingleItem<T>(T item)
                where T : Resource
            {
                if (this.items.Count > 0)
                    throw new Exception("Item already has a value");
                BaseType itemContainer = new BaseType();
                this.items.Add(itemContainer);
                return item;
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
