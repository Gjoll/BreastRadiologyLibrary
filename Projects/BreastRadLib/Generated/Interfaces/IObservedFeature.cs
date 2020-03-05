using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.ObservedFeatureLocal;

namespace BreastRadLib
{
	/// <summary>
	/// Interface ObservedFeature.
	/// This interface is automatically generated.
	/// </summary>
	public interface IObservedFeature : IObservationLeafFragment,
        IBreastRadObservationNoDeviceFragment,
        IBreastRadObservationNoValueFragment,
        IBreastRadObservationNoComponentFragment,
        IBreastBodyLocationRequiredFragment,
        IObservedCountFragment

	{
		//+ Properties
		/// <summary>
		/// Access FeatureType
		/// </summary>
		TElementItemComponentSingle<CodeableConcept> FeatureType { get ; }                                                                         // BuildElementItemComponent.cs:66
		//- Properties

		//+ Methods
		//- Methods
	}
}
