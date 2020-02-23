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

		//+ Properties
		//- Properties

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
		public override void Init(BreastRadiologyDocument doc, Base baseResource = null)
		{
			ServiceRequest resource = (ServiceRequest) baseResource;
			if (resource == null)
				resource = new ServiceRequest();
			base.Init(doc, resource);
			//+ Constructor
			SetProfileUrl("http://hl7.org/fhir/us/breast-radiology/StructureDefinition/ServiceRecommendation");                                      // CSDefineBase.cs:192
			//- Constructor
		}

		public override bool Validate(StringBuilder sb)
		{
			bool retVal = true;
			if (base.Validate(sb) == false)
				retVal = false;
			//+ ValidateCodeStart
			//- ValidateCodeStart
			//+ ValidateCode
			//- ValidateCode
			return retVal;
		}

		public override void Write()
		{
			base.Write();
			//+ WriteCodeStart
			//- WriteCodeStart
			//+ WriteCode
			//- WriteCode
		}

		public override void Read()
		{
			base.Read();
			//+ ReadCodeStart
			//- ReadCodeStart
			//+ ReadCode
			//- ReadCode
		}

		//+ Methods
		/// <summary>
		/// Set ServiceRequest.code to one of the predefined items
		/// </summary>
		public void SetCode(RecommendationsVS.TCoding code)                                                                                       // CSDefineBase.cs:156
		{                                                                                                                                         // CSDefineBase.cs:157
		    //If: C:\Development\HL7\BreastRadiologyLibrary\Projects\FireFragger\FireFragger\CS\CSDefineBase.cs 158                               // CodeBlockNested.cs:588
		    this.Resource.Code = (CodeableConcept) code;                                                                                          // CSDefineBase.cs:159
		}                                                                                                                                         // CSDefineBase.cs:162
		//- Methods
	}
}
