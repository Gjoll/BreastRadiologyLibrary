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
		/// <summary>
		/// Access Component value CalcificationType
		/// </summary>
		CalcificationType_Accessor CalcificationType { get ; }                                                                                    // BuildMemberListBase.cs:62
		/// <summary>
		/// Access Component value CalcificationDistribution
		/// </summary>
		CalcificationDistribution_Accessor CalcificationDistribution { get ; }                                                                    // BuildMemberListBase.cs:62
		//- Properties

		//+ Methods
		//- Methods
	}
}
