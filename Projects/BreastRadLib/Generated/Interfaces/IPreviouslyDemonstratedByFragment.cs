using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.PreviouslyDemonstratedByFragmentLocal;

namespace BreastRadLib
{
	/// <summary>
	/// Interface PreviouslyDemonstratedByFragment.
	/// This interface is automatically generated.
	/// </summary>
	public interface IPreviouslyDemonstratedByFragment 
	{
		//+ Properties
		/// <summary>
		/// Access PreviouslyDemonstratedBy
		/// </summary>
		TItemComponentMultiple<CodeableConcept> PreviouslyDemonstratedBy { get ; }                                                                // BuildElementItemComponent.cs:66
		//- Properties

		//+ Methods
		//- Methods
	}
}
