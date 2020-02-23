using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FireFragger
{
    public static class ElementDefinitionExtensions
    {
        public static Element DefaultValueExtension(this ElementDefinition e)
        {
            Extension[] extensions = e.GetExtensions(Global.DefaultValueExtensionUrl).ToArray();
            switch (extensions.Length)
            {
                case 0: return null;
                case 1: return extensions[0].Value;
                default: throw new Exception($"Multiple default value extensions found in element {e.ElementId}");
            }
        }
    }
}
