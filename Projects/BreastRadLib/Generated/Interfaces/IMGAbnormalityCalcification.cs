using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.MGAbnormalityCalcificationLocal;

namespace BreastRadLib
{
	/// <summary>
	/// Interface MGAbnormalityCalcification.
	/// This interface is automatically generated.
	/// </summary>
	public interface IMGAbnormalityCalcification : IObservationLeafFragment,
        IBreastRadObservationNoDeviceFragment,
        IBreastRadObservationNoComponentFragment,
        IBreastRadObservationNoValueFragment,
        ICommonComponentsFragment,
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
		// Called from BuildMemberComponents.cs, Line 208
		// BuildMemberBase.cs:367
		/// <summary>
		/// CalcificationType
		/// </summary>
		MCalcificationType CalcificationType { get ; }                                                                                            // BuildMemberBase.cs:370
		// Called from BuildMemberComponents.cs, Line 208
		// BuildMemberBase.cs:367
		/// <summary>
		/// CalcificationDistribution
		/// </summary>
		MCalcificationDistribution CalcificationDistribution { get ; }                                                                            // BuildMemberBase.cs:370
		//- Properties

		//+ Methods
		//- Methods
	}
}
