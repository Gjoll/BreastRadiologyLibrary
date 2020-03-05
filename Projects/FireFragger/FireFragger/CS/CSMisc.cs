using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FireFragger.CS
{
    internal static class CSMisc
    {
        public static Int32 ToMax(String max)
        {
            if (max == "*")
                return -1;
            return Int32.Parse(max);
        }

        public static String BRClass(String url)
        {
            if (Stuff.UrlStartsWith(url, "http://hl7.org/fhir/structuredefinition/"))
                return "ResourceBase";
            String reference = url.LastUriPart();
            return reference;
        }


        public static bool BindingClassName(ElementDefinition elementDefinition,
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
            if (valueSet.StartsWith(Global.LocalValueSetUrl) == false)
                return false;
            String vsClassName = CSMisc.MachineName(valueSet.LastUriPart());
            bindingClassName = $"{vsClassName}.TCoding";
            return true;
        }

        public static String[] References(ElementTreeNode entryNode)
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


        public static String FieldName(String s)
        {
            return s.Replace("<", " Less Than ")
            .Replace(">", " Greater Than ")
            .Replace("  ", " ")
            .Replace("  ", " ")
            .ToLocalName();
        }

        public static String MachineName(String s)
        {
            return s.Replace("<", " Less Than ")
            .Replace(">", " Greater Than ")
            .Replace("  ", " ")
            .Replace("  ", " ")
            .ToMachineName();
        }
        public static String CodeName(string code) => $"Code_{MachineName(code)}";
        public static String InterfaceName(SDInfo fi) => $"I{MachineName(fi.StructDef.Name)}";
        public static String ClassName(SDInfo fi) => $"{MachineName(fi.StructDef.Name)}";
        public static String ClassName(String name) => $"{MachineName(name)}";
        public static String CodeSystemName(CSInfo ci) => $"{MachineName(ci.CodeSystem.Name)}";
        public static String ValueSetName(VSInfo vi) => $"{MachineName(vi.ValueSet.Name)}";
        public static String PropertyName(string name) => $"{MachineName(name)}";

        public static String LocalClassNameSpace(SDInfo fi) => $"BreastRadLib.{CSMisc.ClassName(fi)}Local;";

        public static String FhirPath(ElementTreeSlice slice)
        {
            return slice.ElementDefinition.ElementId;
        }
    }
}
