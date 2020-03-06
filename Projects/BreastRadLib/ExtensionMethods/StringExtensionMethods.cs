using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadLib
{
    public static class StringExtensionMethods
    {
        public static String LastPathPart(this String value)
        {
            Int32 index = value.LastIndexOf('.');
            if (index < 0)
                return value;
            return value.Substring(index+1);
        }

        public static String RemoveSliceNames(this String value)
        {
            while (true)
            {
                Int32 startIndex = value.IndexOf(':');
                if (startIndex < 0)
                    return value;
                String start = value.Substring(0, startIndex);
                String end = value.Substring(startIndex);
                Int32 endIndex = end.IndexOf('.');
                if (endIndex < 0)
                    endIndex = end.Length;
                return start + end.Substring(endIndex);
            }
        }
    }
}
