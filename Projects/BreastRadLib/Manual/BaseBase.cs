using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BreastRadLib
{
    public interface IBaseBase
    {
        /// <summary>
        /// Fhir instance id.
        /// </summary>
        String Id { get; set; }
    }

    public abstract class BaseBase : IBaseBase
    {
        public abstract String Id { get; set; }

        public Base BaseResource => resource;
        protected Base resource;
        protected BreastRadiologyDocument doc;

        public BaseBase()
        {
        }

        public virtual void Init(BreastRadiologyDocument doc, Base resource)
        {
            this.doc = doc;
            this.resource = resource;
            this.doc.Register(this);
        }

        protected T ReferencedResource<T>(ResourceReference resRef)
            where T : Base
        {
            if (this.doc.ResourceBag.TryGetEntry(resRef.Reference, out var entry) == false)
                throw new Exception($"Error referencing section resource '{resRef.Reference}'");
            Resource referencedResource = entry.Resource;
            if (referencedResource.Meta.Profile.Count() != 1)
                throw new Exception($"Invalid Meta.profile. Expected 1, got {referencedResource.Meta.Profile.Count()}");
            T retVal = referencedResource as T;
            if (retVal == null)
                throw new Exception($"Resource can not be converted to {typeof(T).Name}");
            return retVal;
        }

        public virtual void Write()
        {
        }

        public virtual void Read()
        {
        }
    }
}
