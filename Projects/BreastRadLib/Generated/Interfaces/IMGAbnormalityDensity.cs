using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.MGAbnormalityDensityLocal;

namespace BreastRadLib
{
	/// <summary>
	/// Interface MGAbnormalityDensity.
	/// This interface is automatically generated.
	/// </summary>
	public interface IMGAbnormalityDensity : IObservationLeafFragment,
        IBreastRadObservationNoDeviceFragment,
        IBreastRadObservationNoComponentFragment,
        IBreastRadObservationNoValueFragment,
        ICommonComponentsFragment,
        IShapeComponentsFragment,
        INotPreviouslySeenComponentFragment,
        IObservedCountFragment,
        IObservedSizeFragment,
        IObservedDistributionFragment,
        ICorrespondsWithFragment,
        IPreviouslyDemonstratedByFragment,
        IAssociatedFeaturesHasMemberFragment,
        IConsistentWithHasMemberFragment

	{
		//+ Properties
		/// <summary>
		/// Access DensityType
		/// </summary>
		TItemComponentSingle<CodeableConcept> DensityType { get ; }                                                                         // BuildItemComponent.cs:66
		//- Properties

		//+ Methods
		//- Methods
	}
}
