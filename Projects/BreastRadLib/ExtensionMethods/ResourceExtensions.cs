using System;
using System.Collections.Generic;
using System.Text;
using Hl7.Fhir.Model;

namespace BreastRadLib.ExtensionMethods
{
    public static class ResourceExtensions
    {
        public static String RelativeUrl(this Resource r) => $"{r.TypeName}/{r.Id}";

        public static ResourceReference ResourceReference(this Resource r)
        {
            return new ResourceReference
            {
                Reference = r.RelativeUrl()
            };
        }
    }
}
