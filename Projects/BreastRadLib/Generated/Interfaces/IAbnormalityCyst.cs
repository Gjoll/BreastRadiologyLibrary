using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.AbnormalityCystLocal;

namespace BreastRadLib
{
	/// <summary>
	/// Interface AbnormalityCyst.
	/// This interface is automatically generated.
	/// </summary>
	public interface IAbnormalityCyst : IObservationLeafFragment,
        ITumorSatelliteFragment,
        IBreastRadObservationNoDeviceFragment,
        IBreastRadObservationNoComponentFragment,
        IBreastRadObservationNoValueFragment,
        ICommonComponentsFragment,
        IShapeComponentsFragment,
        IObservedCountFragment,
        IObservedDistributionFragment,
        IObservedSizeFragment,
        INotPreviouslySeenComponentFragment,
        ICorrespondsWithFragment,
        IPreviouslyDemonstratedByFragment,
        IConsistentWithHasMemberFragment,
        IAssociatedFeaturesHasMemberFragment

	{
		//+ Properties
		// Called from BuildMemberComponents.cs, Line 179
		// BuildMemberBase.cs:341
		/// <summary>
		/// CystType
		/// </summary>
		CystTypeContainer CystType { get ; }                                                                                                      // BuildMemberBase.cs:344
		//- Properties

		//+ Methods
		//- Methods
	}
}
