using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.AbnormalityMassLocal;

namespace BreastRadLib
{
	/// <summary>
	/// Interface AbnormalityMass.
	/// This interface is automatically generated.
	/// </summary>
	public interface IAbnormalityMass : IObservationLeafFragment,
        ITumorSatelliteFragment,
        IBreastRadObservationNoDeviceFragment,
        IBreastRadObservationNoValueFragment,
        IBreastRadObservationNoComponentFragment,
        ICommonComponentsFragment,
        IShapeComponentsFragment,
        IObservedCountFragment,
        IObservedSizeFragment,
        IObservedDistributionFragment,
        INotPreviouslySeenComponentFragment,
        ICorrespondsWithFragment,
        IPreviouslyDemonstratedByFragment,
        IAssociatedFeaturesHasMemberFragment,
        IConsistentWithHasMemberFragment

	{
		//+ Properties
		// Called from BuildMemberComponents.cs, Line 202
		// BuildMemberBase.cs:386
		/// <summary>
		/// MassType
		/// </summary>
		MMassType MassType { get ; }                                                                                                              // BuildMemberBase.cs:389
		//- Properties

		//+ Methods
		//- Methods
	}
}
