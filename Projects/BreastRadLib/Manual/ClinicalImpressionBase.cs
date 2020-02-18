using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadLib
{
    public interface IImpressionBase : IResourceBase
    {
    }

    public class ClinicalImpressionBase : ResourceBase, IImpressionBase
    {
        public ClinicalImpression Resource => (ClinicalImpression)this.resource;

        public ClinicalImpressionBase() : base()
        {
        }

        public ClinicalImpressionBase(BreastRadiologyDocument doc, ClinicalImpression resource) : base()
        {
            this.Init(doc, resource);
        }

        public ClinicalImpressionBase(BreastRadiologyDocument doc) : base()
        {
            this.Init(doc, new ClinicalImpression());
        }
    }
}
