using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.CorrespondsWithFragmentLocal;

namespace BreastRadLib
{
	/// <summary>
	/// Interface CorrespondsWithFragment.
	/// This interface is automatically generated.
	/// </summary>
	public interface ICorrespondsWithFragment 
	{
		//+ Properties
		/// <summary>
		/// Access CorrespondsWith
		/// </summary>
		TItemComponentMultiple<CodeableConcept> CorrespondsWith { get ; }                                                                   // BuildItemComponent.cs:66
		//- Properties

		//+ Methods
		//- Methods
	}
}
