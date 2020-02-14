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
			SetProfileUrl("http://hl7.org/fhir/us/breast-radiology/StructureDefinition/ServiceRecommendation");                                      // CSDefineBase.cs:112
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
		//- Methods
	}
}
