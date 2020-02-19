using FhirKhit.Tools;
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

        protected CodeBlockNested ClassFields => fragBase.ClassEditor?.Blocks.Find("Fields", false);
        protected CodeBlockNested LocalClassDefs => fragBase.SubClassEditor?.Blocks.Find("LocalClassDefs", false);
        protected CodeBlockNested ClassConstructor => fragBase.ClassEditor?.Blocks.Find("Constructor", false);
        protected CodeBlockNested ClassMethods => fragBase.ClassEditor?.Blocks.Find("Methods", false);
        protected CodeBlockNested ClassWriteCodeStart => fragBase.ClassEditor?.Blocks.Find("WriteCodeStart", false);
        protected CodeBlockNested ClassWriteCode => fragBase.ClassEditor?.Blocks.Find("WriteCode", false);
        protected CodeBlockNested ClassReadCodeStart => fragBase.ClassEditor?.Blocks.Find("ReadCodeStart", false);
        protected CodeBlockNested ClassReadCode => fragBase.ClassEditor?.Blocks.Find("ReadCode", false);
        protected CodeBlockNested InterfaceFields => fragBase.InterfaceEditor?.Blocks.Find("Fields", false);
        protected CodeBlockNested InterfaceMethods => fragBase.InterfaceEditor?.Blocks.Find("Methods", false);
        protected String FhirBase => this.fragBase.StructDef.BaseDefinition.LastUriPart();

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

    }
}
