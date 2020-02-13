using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadLib
{
    public interface IServiceRequestBase : IResourceBase
    {
    }

    public class ServiceRequestBase : ResourceBase, IServiceRequestBase
    {
        public ServiceRequest Resource => (ServiceRequest)this.resource;

        public ServiceRequestBase(BreastRadiologyDocument doc, ServiceRequest resource) : base(doc, resource)
        {
        }

        public ServiceRequestBase(BreastRadiologyDocument doc) : base(doc, new ServiceRequest())
        {
        }
    }
}
