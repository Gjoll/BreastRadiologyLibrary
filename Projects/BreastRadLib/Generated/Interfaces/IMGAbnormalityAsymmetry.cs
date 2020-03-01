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
		/// <summary>
		/// Access Component value AsymmetryType
		/// </summary>
		AsymmetryType_Accessor AsymmetryType { get ; }                                                                                            // BuildMemberListBase.cs:62
		//- Properties

		//+ Methods
		//- Methods
	}
}
