using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadLib
{
    public static class Misc
    {
        public static bool SameUrl(String url1, String url2)
        {
            url1 = url1.ToUpper().Trim();
            url2 = url2.ToUpper().Trim();
            return String.Compare(url1, url2) == 0;
        }

        public static bool UrlStartsWith(String url1, String url2)
        {
            return url1.StartsWith(url2, StringComparison.OrdinalIgnoreCase);
        }
    }
}
