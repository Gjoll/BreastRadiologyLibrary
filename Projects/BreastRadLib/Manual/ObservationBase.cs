using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadLib
{
    public interface IObservationBase : IResourceBase
    {
    }

    public class ObservationBase : ResourceBase, IObservationBase
    {
        /// <summary>
        /// Base class for all component accessors
        /// </summary>
        public class ComponentBase<BaseType> : MemberList<BaseType>
                where BaseType : Base
        {
            /// <summary>
            /// Section coding
            /// </summary>
            public Coding Code { get; protected set; }

            protected ComponentBase()
            {
            }

            protected void Create(BreastRadiologyDocument doc,
                Int32 min,
                Int32 max,
                Coding code)
            {
                base.Create(doc, min, max);
                this.Code = code;
            }

            protected void SetFirst(BaseType value)
            {
                this.items.Clear();
                this.items.Add(value);
            }
        }

        public Observation Resource => (Observation)this.resource;


        public ObservationBase() : base()
        {
        }

        public ObservationBase(BreastRadiologyDocument doc, Observation resource) : base()
        {
            this.Create(doc, resource);
        }

        public ObservationBase(BreastRadiologyDocument doc) : base()
        {
            this.Create(doc, new Observation());
        }

        protected void ClearComponents()
        {
            this.Resource.Component.Clear();
        }

        //protected void WriteComponents<BaseType>(ComponentBase<BaseType> componentList )
        //     where BaseType : ResourceBase, new()
        //{
        //}

        //protected MemberList<T> CreateHasMemberList<T>(Int32 min, Int32 max)
        //    where T : IResourceBase
        //{
        //    MemberList<T> retVal = new MemberList<T>(min, max);
        //    hasMemberLists.Add(retVal);
        //    return retVal;
        //}

        //public void LoadHasMembers(ResourceBag resourceBag)
        //{
        //    foreach (ResourceReference hasMember in resource.HasMember)
        //    {
        //        //if (resourceBag.TryGetEntry(hasMember.Url, out Bundle.EntryComponent entry) == false)
        //        //    throw new Exception("Reference '{hasMember.Url}' not found in bag");
        //    }
        //}

        //public void Unload(ResourceBag resourceBag)
        //{
        //    UnloadHasMembers(resourceBag);
        //}

        //public void UnloadHasMembers(ResourceBag resourceBag)
        //{
        //}
    }
}
