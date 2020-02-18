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
        /// Base class for all HasMember accessors
        /// </summary>
        public class HasMemberBase<BaseType> : MemberList<BaseType>
                where BaseType : ObservationBase
        {
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
            /// Set item
            /// </summary>
            /// <param name="item"></param>
            /// <returns></returns>
            public BaseType Set(BaseType item = null)
            {
                if (item == null)
                {
                    //item = new BaseType();
                    //item.Create(this.doc);
                }
                base.SetSingleItem(item);
                return item;
            }
        }

        /// <summary>
        /// Base class for all HasMember multiple accessors
        /// </summary>
        public class HasMemberMultiple<BaseType> : HasMemberBase<BaseType>
                where BaseType : ObservationBase
        {
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
            throw new NotImplementedException();
        }

        protected void ReadHasMember<BaseType>(HasMemberBase<BaseType> hasMemberList)
             where BaseType : ObservationBase
        {
            throw new NotImplementedException();
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
