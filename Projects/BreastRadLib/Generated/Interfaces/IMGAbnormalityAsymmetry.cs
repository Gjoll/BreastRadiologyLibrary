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
		// Called from BuildMemberComponents.cs, Line 204
		// BuildMemberBase.cs:366
		/// <summary>
		/// AsymmetryType
		/// </summary>
		AsymmetryTypeContainer AsymmetryType { get ; }                                                                                            // BuildMemberBase.cs:369
		//- Properties

		//+ Methods
		//- Methods
	}
}
