using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
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

        protected void Create(BreastRadiologyDocument doc, Base resource)
        {
            this.doc = doc;
            this.resource = resource;
            this.doc.Register(this);
        }

       
        public virtual void Write()
        {
        }

        public virtual void Read()
        {
        }
    }
}
