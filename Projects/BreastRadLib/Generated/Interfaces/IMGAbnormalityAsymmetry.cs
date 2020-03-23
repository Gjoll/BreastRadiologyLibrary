using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.MGAbnormalityAsymmetryLocal;

namespace BreastRadLib
{
	/// <summary>
	/// Interface MGAbnormalityAsymmetry.
	/// This interface is automatically generated.
	/// </summary>
	public interface IMGAbnormalityAsymmetry : IObservationLeafFragment,
        IBreastRadObservationNoDeviceFragment,
        IBreastRadObservationNoComponentFragment,
        IBreastRadObservationNoValueFragment,
        ICommonComponentsFragment,
        IShapeComponentsFragment,
        INotPreviouslySeenComponentFragment,
        IObservedCountFragment,
        ICorrespondsWithFragment,
        IPreviouslyDemonstratedByFragment,
        IAssociatedFeaturesHasMemberFragment,
        IConsistentWithHasMemberFragment

	{
		//+ Properties
		// Called from BuildMemberComponents.cs, Line 202
		// BuildMemberBase.cs:382
		/// <summary>
		/// AsymmetryType
		/// </summary>
		MAsymmetryType AsymmetryType { get ; }                                                                                                    // BuildMemberBase.cs:385
		//- Properties

		//+ Methods
		//- Methods
	}
}
