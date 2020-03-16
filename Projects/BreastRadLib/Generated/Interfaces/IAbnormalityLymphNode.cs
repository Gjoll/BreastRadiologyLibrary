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
		// Called from BuildMemberComponents.cs, Line 179
		// BuildMemberBase.cs:341
		/// <summary>
		/// LymphNodeType
		/// </summary>
		LymphNodeTypeContainer LymphNodeType { get ; }                                                                                            // BuildMemberBase.cs:344
		//- Properties

		//+ Methods
		//- Methods
	}
}
