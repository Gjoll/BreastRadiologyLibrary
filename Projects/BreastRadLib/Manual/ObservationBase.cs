﻿using Hl7.Fhir.Model;
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
        public Observation Resource => (Observation)this.resource;


        public ObservationBase() : base()
        {
        }

        public ObservationBase(BreastRadiologyDocument doc, Observation resource) : base()
        {
            this.Init(doc, resource);
        }

        public ObservationBase(BreastRadiologyDocument doc) : base()
        {
            this.Init(doc, new Observation());
        }

        protected void ClearHasMembers()
        {
            this.Resource.HasMember.Clear();
        }

        protected void WriteHasMember<BaseType>(ObservationLocal.HasMemberBase<BaseType> hasMemberList)
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

        protected void ReadHasMember<BaseType>(ObservationLocal.HasMemberBase<BaseType> hasMemberList)
             where BaseType : ObservationBase, new()
        {
            foreach (ResourceReference resRef in this.Resource.HasMember)
            {
                Observation referencedResource = ReferencedResource<Observation>(resRef);
                String profile = referencedResource.Meta.Profile.First();
                if (Misc.SameUrl(profile, hasMemberList.ProfileUrl))
                {
                    if (this.doc.TryGetRegisteredItem(referencedResource, out BaseType item) == false)
                        throw new Exception($"Referenced resource {referencedResource.Id} not found in bundle");
                    hasMemberList.RawItems.Add(item);
                }
            }
        }

        protected void ClearComponents()
        {
            this.Resource.Component.Clear();
        }

        protected void WriteComponent<BaseType>(ObservationLocal.ComponentBase<BaseType> componentList)
             where BaseType : Base
        {
            CodeableConcept code = new CodeableConcept(componentList.Code.System,
                componentList.Code.Code,
                componentList.Code.Display);
            foreach (BaseType baseType in componentList.RawItems)
            {
                Observation.ComponentComponent comp = new Observation.ComponentComponent
                {
                    Code = code
                };
                this.Resource.Component.Add(comp);
            }
        }

        protected void ReadComponent<BaseType>(ObservationLocal.ComponentBase<BaseType> componentList)
             where BaseType : Base
        {
            foreach (Observation.ComponentComponent comp in this.Resource.Component)
            {
                if (Misc.SameCode(comp.Code, componentList.Code))
                {
                    BaseType baseType = comp.Value as BaseType;
                    if (baseType == null)
                        throw new Exception($"Can cot convert item from {comp.Value.GetType().Name} to {typeof(BaseType).Name}");
                    componentList.RawItems.Add(baseType);
                }
            }
        }
    }
}
