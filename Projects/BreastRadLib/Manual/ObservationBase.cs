using Hl7.Fhir.Model;
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

        //protected void WriteHasMembers(IItemReference hasMemberList)
        //{
        //    foreach (ResourceBase member in hasMemberList.GetElements())
        //        this.Resource.HasMember.Add(new ResourceReference
        //        {
        //            Reference = member.Id
        //        });
        //}

        //protected void ReadHasMembers(IItemReference hasMemberList)
        //{
        //    List<ResourceBase> items = new List<ResourceBase>();
        //    foreach (ResourceReference resRef in this.Resource.HasMember)
        //    {
        //        Observation referencedResource = this.Doc.ReferencedResource<Observation>(resRef);
        //        String profile = referencedResource.Meta.Profile.First();
        //        if (BLMisc.SameUrl(profile, hasMemberList.ProfileUrl))
        //        {
        //            if (this.Doc.TryGetRegisteredItem(referencedResource, out ObservationBase item) == false)
        //                throw new Exception($"Referenced resource {referencedResource.Id} not found in bundle");
        //            items.Add(item);
        //        }
        //    }
        //    hasMemberList.SetElements(items);
        //}

        protected void ClearComponent()
        {
            this.Resource.Component.Clear();
        }

        public override void Write()
        {
            base.Write();
            this.Resource.Encounter = this.Doc.Encounter;
            this.Resource.Subject = this.Doc.Subject;
        }
    }
}
