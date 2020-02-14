using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class ServiceRecommendation : ServiceRequestBase, IHeaderFragment
	{
		//+ Fields
		//- Fields

		public ServiceRecommendation(BreastRadiologyDocument doc, ServiceRequest resource) : base(doc, resource)
		{
			//+ Constructor
			SetProfileUrl("http://hl7.org/fhir/us/breast-radiology/StructureDefinition/ServiceRecommendation");                                      // CSDefineBase.cs:181
			//- Constructor
		}

		public ServiceRecommendation(BreastRadiologyDocument doc) : this(doc, new ServiceRequest())
		{
		}

		public override void Write()
		{
		//+ WriteCode
		//- WriteCode
		}

		public override void Read()
		{
		//+ ReadCode
		//- ReadCode
		}

		//+ Methods
		/// <summary>
		/// Set ServiceRequest.code to one of the predefined items
		/// </summary>
		public ServiceRecommendation SetCode(RecommendationsVS.TCoding code)                                                                      // CSDefineBase.cs:153
		{                                                                                                                                         // CSDefineBase.cs:154
		    this.Resource.Code = code;                                                                                                            // CSDefineBase.cs:155
		    return this;                                                                                                                          // CSDefineBase.cs:156
		}                                                                                                                                         // CSDefineBase.cs:157
		//- Methods
	}
}
