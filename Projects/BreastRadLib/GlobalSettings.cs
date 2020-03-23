using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadLib
{
    public static class GlobalSettings
    {
        /// <summary>
        /// Turn cardinality checking off.
        /// This is meant for debugging and testing use only.
        /// </summary>
        public static bool IgnoreCardinalityErrors { get; set; } = false;
    }
}
