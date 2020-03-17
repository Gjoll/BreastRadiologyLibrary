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
		// Called from BuildMemberComponents.cs, Line 204
		// BuildMemberBase.cs:366
		/// <summary>
		/// FeatureType
		/// </summary>
		FeatureTypeContainer FeatureType { get ; }                                                                                                // BuildMemberBase.cs:369
		//- Properties

		//+ Methods
		//- Methods
	}
}
