using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.AssociatedFeatureLocal;

namespace BreastRadLib
{
	/// <summary>
	/// Interface AssociatedFeature.
	/// This interface is automatically generated.
	/// </summary>
	public interface IAssociatedFeature : IObservationLeafFragment,
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
		TItemComponentSingle<CodeableConcept> FeatureType { get ; }                                                                               // BuildElementItemComponent.cs:64
		//- Properties

		//+ Methods
		//- Methods
	}
}
