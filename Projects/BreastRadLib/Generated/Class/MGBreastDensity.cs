using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.MGBreastDensityLocal;
//+Usings
using BreastRadLib.ObservationLeafFragmentLocal;
using BreastRadLib.HeaderFragmentLocal;
using BreastRadLib.CategoryFragmentLocal;
using BreastRadLib.BreastRadObservationFragmentLocal;
using BreastRadLib.BreastRadObservationNoComponentFragmentLocal;
using BreastRadLib.BreastRadObservationNoDeviceFragmentLocal;
//-Usings

namespace BreastRadLib
{
	public class MGBreastDensity : ObservationBase, IObservationLeafFragment, IBreastRadObservationNoComponentFragment, IBreastRadObservationNoDeviceFragment
	{
		//+ Fields
		//- Fields

		//+ Properties
		//- Properties

		/// <summary>
		/// No parameters constructor.
		// Caller must call Init();
		/// </summary>
		public MGBreastDensity() : base()
		{
		}

		/// <summary>
		/// Parametersize constructur.
		/// User must not call Init().
		/// </summary>
		public MGBreastDensity(BreastRadiologyDocument doc, Observation resource)
		{
			this.Init(doc, resource);
		}

		/// <summary>
		/// Parametersize constructur.
		/// User must not call Init().
		/// </summary>
		public MGBreastDensity(BreastRadiologyDocument doc)
		{
		this.Init(doc, new Observation());
		}

		/// <summary>
		/// Init object.
		/// </summary>
		public override void Init(BreastRadiologyDocument doc, Base baseResource = null)
		{
			Observation resource = (Observation) baseResource;
			if (resource == null)
				resource = new Observation();
			base.Init(doc, resource);
			//+ Constructor
			this.Resource.Code = DefaultValue_1();                                                                                                   // CSDefineBase.cs:130
			SetProfileUrl("http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGBreastDensity");                                            // CSDefineBase.cs:191
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
			this.ClearHasMember();                                                                                                                   // CSBuildMemberListReference.cs:87
			this.ClearComponents();                                                                                                                  // CSBuildMemberListCodedValue.cs:171
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
		/// Method to create default value for element
		/// Observation.code
		/// </summary>
		public Extension DefaultValue_1()                                                                                                         // FhirConstruct.cs:3044
		{                                                                                                                                         // FhirConstruct.cs:3045
		    Extension retVal = new Extension();                                                                                                   // FhirConstruct.cs:3046
		    retVal.Url = "http://www.fragment.com/DefaultValue";                                                                                  // FhirConstruct.cs:3051
		    return retVal;                                                                                                                        // FhirConstruct.cs:3056
		}                                                                                                                                         // FhirConstruct.cs:3057
		/// <summary>
		/// Set Observation.value[x] to one of the predefined items
		/// </summary>
		public void SetValueX(MGBreastDensityVS.TCoding code)                                                                                     // CSDefineBase.cs:155
		{                                                                                                                                         // CSDefineBase.cs:156
		    //If: C:\Development\HL7\BreastRadiologyLibrary\Projects\FireFragger\FireFragger\CS\CSDefineBase.cs 157                               // CodeBlockNested.cs:588
		    this.Resource.Value = (CodeableConcept) code;                                                                                         // CSDefineBase.cs:158
		}                                                                                                                                         // CSDefineBase.cs:161
		//- Methods
	}
}
