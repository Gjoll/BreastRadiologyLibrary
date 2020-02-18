using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.ServiceRecommendationLocal;
//+Usings
using BreastRadLib.HeaderFragmentLocal;
//-Usings

namespace BreastRadLib
{
	public class ServiceRecommendation : ServiceRequestBase, IHeaderFragment
	{
		//+ Fields
		//- Fields

		/// <summary>
		/// No parameters constructor.
		// Caller must call Init();
		/// </summary>
		public ServiceRecommendation() : base()
		{
		}

		/// <summary>
		/// Parametersize constructur.
		/// User must not call Init().
		/// </summary>
		public ServiceRecommendation(BreastRadiologyDocument doc, ServiceRequest resource)
		{
			this.Init(doc, resource);
		}

		/// <summary>
		/// Parametersize constructur.
		/// User must not call Init().
		/// </summary>
		public ServiceRecommendation(BreastRadiologyDocument doc)
		{
		this.Init(doc, new ServiceRequest());
		}

		/// <summary>
		/// Init object.
		/// </summary>
		public void Init(BreastRadiologyDocument doc, ServiceRequest resource = null)
		{
			if (resource == null)
				resource = new ServiceRequest();
			base.Init(doc, resource);
			//+ Constructor
			SetProfileUrl("http://hl7.org/fhir/us/breast-radiology/StructureDefinition/ServiceRecommendation");                                      // CSDefineBase.cs:208
			//- Constructor
		}

		public override void Write()
		{
			//+ WriteCodeStart
			//- WriteCodeStart
			//+ WriteCode
			//- WriteCode
		}

		public override void Read()
		{
			//+ ReadCodeStart
			//- ReadCodeStart
			//+ ReadCode
			//- ReadCode
		}

		//+ Methods
		/// <summary>
		/// Set ServiceRequest.code to one of the predefined items
		/// </summary>
		public ServiceRecommendation SetCode(RecommendationsVS.TCoding code)                                                                      // CSDefineBase.cs:178
		{                                                                                                                                         // CSDefineBase.cs:179
		    this.Resource.Code = code;                                                                                                            // CSDefineBase.cs:180
		    return this;                                                                                                                          // CSDefineBase.cs:181
		}                                                                                                                                         // CSDefineBase.cs:182
		//- Methods
	}
}
