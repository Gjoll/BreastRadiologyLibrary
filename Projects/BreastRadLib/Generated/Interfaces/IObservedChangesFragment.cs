using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.ObservedChangesFragmentLocal;

namespace BreastRadLib
{
	/// <summary>
	/// Interface ObservedChangesFragment.
	/// This interface is automatically generated.
	/// </summary>
	public interface IObservedChangesFragment 
	{
		//+ Properties
		/// <summary>
		/// Access ObsChanges
		/// </summary>
		TItemComponentMultiple<CodeableConcept> ObsChanges { get ; }                                                                              // BuildElementItemComponent.cs:64
		//- Properties

		//+ Methods
		//- Methods
	}
}
