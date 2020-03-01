using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
    /// <summary>
    /// Base class for all section accessors
    /// </summary>
    public class MemberListSection<BaseType> : MemberList<BaseType>
            where BaseType : ResourceBase, new()
    {
        /// <summary>
        /// Section Title
        /// </summary>
        public String Title { get; protected set; }

        /// <summary>
        /// Section coding
        /// </summary>
        public Coding Code { get; protected set; }

        protected MemberListSection(String listName) : base(listName)
        {
        }

        protected void Init(BreastRadiologyDocument doc,
            String title,
            Int32 min,
            Int32 max,
            Coding code)
        {
            base.Init(doc, min, max);
            this.Title = title;
            this.Code = code;
        }
    }
}
