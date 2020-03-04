﻿using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BreastRadLib
{
    public interface IObservationBase : IResourceBase
    {
        Observation Resource { get; }
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

        protected void ClearHasMember()
        {
            this.Resource.HasMember.Clear();
        }

        protected void WriteHasMembers(IElementItemReference hasMemberList)
        {
            foreach (ResourceBase member in hasMemberList.GetElements())
                this.Resource.HasMember.Add(new ResourceReference
                {
                    Reference = member.Id
                });
        }

        protected void ReadHasMembers(IElementItemReference hasMemberList)
        {
            List<ResourceBase> items = new List<ResourceBase>();
            foreach (ResourceReference resRef in this.Resource.HasMember)
            {
                Observation referencedResource = this.ReferencedResource<Observation>(resRef);
                String profile = referencedResource.Meta.Profile.First();
                if (BLMisc.SameUrl(profile, hasMemberList.ProfileUrl))
                {
                    if (this.Doc.TryGetRegisteredItem(referencedResource, out ObservationBase item) == false)
                        throw new Exception($"Referenced resource {referencedResource.Id} not found in bundle");
                    items.Add(item);
                }
            }
            hasMemberList.SetElements(items);
        }

        protected void ClearComponents()
        {
            this.Resource.Component.Clear();
        }

        public override void Write()
        {
            base.Write();
            this.Resource.Encounter = this.Doc.Encounter;
            this.Resource.Subject = this.Doc.Subject;
        }

        protected void WriteComponent<BaseType>(MemberListCodedValue<BaseType> componentList)
             where BaseType : Element
        {
            CodeableConcept code = new CodeableConcept(componentList.Code.System,
                componentList.Code.Code,
                componentList.Code.Display);
            foreach (BaseType baseType in componentList.RawItems)
            {
                Observation.ComponentComponent comp = new Observation.ComponentComponent
                {
                    Code = code,
                    Value = baseType
                };
                this.Resource.Component.Add(comp);
            }
        }

        protected void ReadComponent<BaseType>(MemberListCodedValue<BaseType> componentList)
             where BaseType : Element
        {
            foreach (Observation.ComponentComponent comp in this.Resource.Component)
            {
                if (BLMisc.SameCode(comp.Code, componentList.Code))
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
