using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BreastRadLib
{
    public interface IResourceBase : IBaseBase
    {
    }

    public class ResourceBase : BaseBase, IResourceBase
    {
        DomainResource domainResource => (DomainResource)this.resource;
        String profileUrl;

        protected Meta Meta => GetMeta();

        public override String Id
        {
            get => this.domainResource.Id;
            set => this.domainResource.Id = value;
        }

        public ResourceBase(BreastRadiologyDocument doc, DomainResource resource) : base(doc, resource)
        {
        }

        Meta GetMeta()
        {
            if (this.domainResource.Meta == null)
                this.domainResource.Meta = new Meta();
            return this.domainResource.Meta;
        }

        protected void SetProfileUrl(String profileUrl)
        {
            this.profileUrl = profileUrl;
            List<String> metaProfiles = this.Meta.Profile.ToList();
            if (metaProfiles.Contains(profileUrl) == false)
                metaProfiles.Add(profileUrl);
            this.domainResource.Meta.Profile = metaProfiles;
        }
    }
}
