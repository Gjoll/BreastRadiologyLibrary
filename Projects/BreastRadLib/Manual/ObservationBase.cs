using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BreastRadLib
{
    public interface IObservationBase : IResourceBase
    {
    }

    public class ObservationBase : ResourceBase, IObservationBase
    {
        /// <summary>
        /// Base class for all HasMember accessors
        /// </summary>
        public class HasMemberBase<BaseType> : MemberList<BaseType>
                where BaseType : ObservationBase
        {
            public String ProfileUrl { get; private set; }

            public HasMemberBase()
            {
            }

            public void Create(BreastRadiologyDocument doc,
                    Int32 min,
                    Int32 max,
                    String profileUrl)
            {
                this.ProfileUrl = profileUrl;
                base.Create(doc, min, max);
            }
        }

        /// <summary>
        /// Base class for all HasMember single accessors
        /// </summary>
        public class HasMemberSingle<BaseType> : HasMemberBase<BaseType>
                where BaseType : ObservationBase, new()
        {
            /// <summary>
            /// Get item
            /// </summary>
            public BaseType Get() => base.GetSingleItem();

            /// <summary>
            /// Create item if it doesn't already exist, and return item.
            /// </summary>
            public BaseType Create()
            {
                if (this.items.Count == 0)
                {
                    BaseType item = new BaseType();
                    item.Create(this.doc, new Observation());
                    this.items.Add(item);
                }
                return this.items.First();
            }

            /// <summary>
            /// Set item
            /// </summary>
            public BaseType Set(BaseType item = null)
            {
                if (item == null)
                {
                    item = new BaseType();
                    item.Create(this.doc, new Observation());
                }
                base.SetSingleItem(item);
                return item;
            }

            public HasMemberSingle() : base()
            {
            }
        }

        /// <summary>
        /// Base class for all HasMember multiple accessors
        /// </summary>
        public class HasMemberMultiple<BaseType> : HasMemberBase<BaseType>
                where BaseType : ObservationBase
        {
            public HasMemberMultiple() : base()
            {
            }
        }

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

        protected void ClearHasMembers()
        {
            this.Resource.HasMember.Clear();
        }

        protected void WriteHasMember<BaseType>(HasMemberBase<BaseType> hasMemberList)
             where BaseType : ObservationBase
        {
            foreach (BaseType item in hasMemberList.RawItems)
            {
                if (Misc.SameUrl(item.Meta.Profile.FirstOrDefault(), hasMemberList.ProfileUrl))
                {
                    this.Resource.HasMember.Add(
                        new ResourceReference
                        {
                            Reference = item.Resource.IdElement.Value
                        }); ;
                }
            }
        }

        protected void ReadHasMember<BaseType>(HasMemberBase<BaseType> hasMemberList)
             where BaseType : ObservationBase, new()
        {
            foreach (ResourceReference resRef in this.Resource.HasMember)
            {
                Observation referencedResource = ReferencedResource<Observation>(resRef);
                String profile = referencedResource.Meta.Profile.First();
                if (Misc.SameUrl(profile, hasMemberList.ProfileUrl))
                {
                    BaseType item = new BaseType();
                    item.Create(this.doc, referencedResource);
                    hasMemberList.RawItems.Add(item);
                }
            }
        }

        protected void ClearComponents()
        {
            this.Resource.Component.Clear();
        }

        protected void WriteComponent<BaseType>(ComponentBase<BaseType> componentList)
             where BaseType : Base
        {
            throw new NotImplementedException();
        }

        protected void ReadComponent<BaseType>(ComponentBase<BaseType> componentList)
             where BaseType : Base
        {
            throw new NotImplementedException();
        }
    }
}
