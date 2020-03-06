using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.ObservedCountFragmentLocal;

namespace BreastRadLib
{
	/// <summary>
	/// Interface ObservedCountFragment.
	/// This interface is automatically generated.
	/// </summary>
	public interface IObservedCountFragment 
	{
		//+ Properties
		/// <summary>
		/// Access ObsCount
		/// </summary>
		TItemComponentSingle<Quantity, Range> ObsCount { get ; }                                                                                  // BuildElementItemComponent.cs:64
		//- Properties

		//+ Methods
		//- Methods
	}
}
