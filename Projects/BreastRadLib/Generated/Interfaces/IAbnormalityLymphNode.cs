using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.AbnormalityLymphNodeLocal;

namespace BreastRadLib
{
	/// <summary>
	/// Interface AbnormalityLymphNode.
	/// This interface is automatically generated.
	/// </summary>
	public interface IAbnormalityLymphNode : IObservationLeafFragment,
        ITumorSatelliteFragment,
        IBreastRadObservationNoDeviceFragment,
        IBreastRadObservationNoValueFragment,
        IBreastRadObservationNoComponentFragment,
        ICommonComponentsFragment,
        IShapeComponentsFragment,
        IObservedCountFragment,
        IObservedDistributionFragment,
        IObservedSizeFragment,
        INotPreviouslySeenComponentFragment,
        ICorrespondsWithFragment,
        IPreviouslyDemonstratedByFragment,
        IAssociatedFeaturesHasMemberFragment

	{
		//+ Properties
		/// <summary>
		/// Access LymphNodeType
		/// </summary>
		TElementItemComponentSingle<CodeableConcept> LymphNodeType { get ; }                                                                       // BuildElementItemComponent.cs:66
		//- Properties

		//+ Methods
		//- Methods
	}
}
