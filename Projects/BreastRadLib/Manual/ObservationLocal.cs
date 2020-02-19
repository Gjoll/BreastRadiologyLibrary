using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib.ObservationLocal
{
    /// <summary>
    /// Base class for all component accessors
    /// </summary>
    public class ComponentBase<BaseType> : MemberList<BaseType>
        where BaseType : Element
    {
        /// <summary>
        /// Section coding
        /// </summary>
        public Coding Code { get; protected set; }

        protected ComponentBase(String listName) : base(listName)
        {
        }

        protected void Init(BreastRadiologyDocument doc,
            Int32 min,
            Int32 max,
            Coding code)
        {
            base.Init(doc, min, max);
            this.Code = code;
        }

        protected void SetFirst(BaseType value)
        {
            this.items.Clear();
            this.items.Add(value);
        }
    }
}
