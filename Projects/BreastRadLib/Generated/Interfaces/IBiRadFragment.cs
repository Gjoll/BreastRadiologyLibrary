using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.BiRadFragmentLocal;

namespace BreastRadLib
{
	/// <summary>
	/// Interface BiRadFragment.
	/// This interface is automatically generated.
	/// </summary>
	public interface IBiRadFragment 
	{
		//+ Properties
		/// <summary>
		/// Access BiRadsAssessmentCategory
		/// </summary>
		TItemComponentSingle<CodeableConcept> BiRadsAssessmentCategory { get ; }                                                            // BuildItemComponent.cs:66
		//- Properties

		//+ Methods
		//- Methods
	}
}
