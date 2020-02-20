using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadLib
{
    public interface IEncounterBase : IResourceBase
    {
    }

    public class EncounterBase : ResourceBase
    {
        public Encounter Resource => (Encounter)this.resource;

        public EncounterBase() : base()
        {
        }

        public EncounterBase(BreastRadiologyDocument doc, Encounter resource) : base()
        {
            this.Init(doc, resource);
        }

        public EncounterBase(BreastRadiologyDocument doc) : base()
        {
            this.Init(doc, new Encounter());
        }
    }
}
