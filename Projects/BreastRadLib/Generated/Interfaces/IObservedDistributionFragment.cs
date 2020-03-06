using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.ObservedDistributionFragmentLocal;

namespace BreastRadLib
{
	/// <summary>
	/// Interface ObservedDistributionFragment.
	/// This interface is automatically generated.
	/// </summary>
	public interface IObservedDistributionFragment 
	{
		//+ Properties
		/// <summary>
		/// Access ObsDistribution
		/// </summary>
		TItemComponentMultiple<CodeableConcept> ObsDistribution { get ; }                                                                         // BuildElementItemComponent.cs:64
		/// <summary>
		/// Access ObsDistRegionSize
		/// </summary>
		TItemComponentMultiple<Quantity, Range> ObsDistRegionSize { get ; }                                                                       // BuildElementItemComponent.cs:64
		//- Properties

		//+ Methods
		//- Methods
	}
}
