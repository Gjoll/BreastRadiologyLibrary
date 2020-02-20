using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadLib
{
    public interface IPatientBase : IResourceBase
    {
    }

    public class PatientBase : ResourceBase
    {
        public Patient Resource => (Patient)this.resource;

        public PatientBase() : base()
        {
        }

        public PatientBase(BreastRadiologyDocument doc, Patient resource) : base()
        {
            this.Init(doc, resource);
        }

        public PatientBase(BreastRadiologyDocument doc) : base()
        {
            this.Init(doc, new Patient());
        }
    }
}
