using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FireFragger
{
    class CSCodeBlockDefinitions
    {
        protected CSBuilder csBuilder;
        protected SDInfo fragBase;


        public CSCodeBlockDefinitions(CSBuilder csBuilder,
                    SDInfo fragBase)
        {
            this.csBuilder = csBuilder;
            this.fragBase = fragBase;
        }

        public String FhirClass(String url)
        {
            if (Stuff.UrlStartsWith(url, "http://hl7.org/fhir/structuredefinition/"))
                return url.LastUriPart();
            if (this.csBuilder.SDFragments.TryGetValue(url, out SDInfo fragInfo) == false)
                throw new Exception($"{url.LastUriPart()} not found");
            return fragInfo.BaseDefinitionName;
        }

        protected String BRClass(String url)
        {
            if (Stuff.UrlStartsWith(url, "http://hl7.org/fhir/structuredefinition/"))
                return "ResourceBase";
            String reference = url.LastUriPart();
            return reference;
        }

        protected Int32 ToMax(String max)
        {
            if (max == "*")
                return -1;
            return Int32.Parse(max);
        }

        protected bool BindingClassName(ElementDefinition elementDefinition,
            out String bindingClassName,
            out ElementDefinition.ElementDefinitionBindingComponent binding)
        {
            bindingClassName = null;
            binding = elementDefinition.Binding;
            if (binding == null)
                return false;

            ElementDefinition.ElementDefinitionBindingComponent bindingComp = elementDefinition.Binding;
            String valueSet = bindingComp.ValueSet;

            // currently we only do local value sets.
            if (valueSet.StartsWith(Global.LocalValueSertUrl) == false)
                return false;
            String vsClassName = CSBuilder.MachineName(valueSet.LastUriPart());
            bindingClassName = $"{vsClassName}.TCoding";
            return true;
        }

        protected String[] References(ElementTreeNode entryNode)
        {
            List<ElementDefinition.TypeRefComponent> types = entryNode.ElementDefinition.Type;
            if (types.Count != 1)
                throw new Exception($"SingleReference. Invalid type count. Epected 1, got {types.Count}.");

            ElementDefinition.TypeRefComponent type = types[0];
            if (type.Code != "Reference")
                throw new Exception($"SingleReference. Invalid type code. Expected 'Reference', got {type.Code}.");
            List<String> retVal = new List<string>();
            foreach (String targetProfile in type.TargetProfile)
                retVal.Add(targetProfile);
            return retVal.ToArray();
        }
    }
}
