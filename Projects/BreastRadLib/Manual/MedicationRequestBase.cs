﻿using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadLib
{
    public interface IMedicationRequestBase : IResourceBase
    {
    }

    public class MedicationRequestBase: ResourceBase, IMedicationRequestBase
    {
        public MedicationRequest Resource => (MedicationRequest) this.resource;

        List<IMemberList> hasMemberLists = new List<IMemberList>();

        public MedicationRequestBase(BreastRadiologyDocument doc, MedicationRequest resource) : base(doc, resource)
        {
        }

        public MedicationRequestBase(BreastRadiologyDocument doc) : base(doc, new MedicationRequest())
        {
        }

        protected MemberList<T> CreateHasMemberList<T>(Int32 min, Int32 max)
            where T : IResourceBase
        {
            MemberList<T> retVal = new MemberList<T>(min, max);
            hasMemberLists.Add(retVal);
            return retVal;
        }

        public void LoadHasMembers(ResourceBag resourceBag)
        {
            //foreach (ResourceReference hasMember in resource.HasMember)
            //{
            //    //if (resourceBag.TryGetEntry(hasMember.Url, out Bundle.EntryComponent entry) == false)
            //    //    throw new Exception("Reference '{hasMember.Url}' not found in bag");
            //}
        }

        public void Unload(ResourceBag resourceBag)
        {
            UnloadHasMembers(resourceBag);
        }

        public void UnloadHasMembers(ResourceBag resourceBag)
        {
        }
    }
}
