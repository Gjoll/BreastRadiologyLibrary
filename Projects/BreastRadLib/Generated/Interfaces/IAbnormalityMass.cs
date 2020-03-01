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
		/// <summary>
		/// Access Component value MassType
		/// </summary>
		MassType_Accessor MassType { get ; }                                                                                                      // BuildMemberListBase.cs:62
		//- Properties

		//+ Methods
		//- Methods
	}
}
