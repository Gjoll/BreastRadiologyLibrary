using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.AbnormalityDuctLocal;

namespace BreastRadLib
{
	/// <summary>
	/// Interface AbnormalityDuct.
	/// This interface is automatically generated.
	/// </summary>
	public interface IAbnormalityDuct : IObservationLeafFragment,
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
        IConsistentWithHasMemberFragment

	{
		//+ Properties
		// Called from BuildMemberComponents.cs, Line 208
		// BuildMemberBase.cs:366
		/// <summary>
		/// DuctType
		/// </summary>
		DuctTypeContainer DuctType { get ; }                                                                                                      // BuildMemberBase.cs:369
		//- Properties

		//+ Methods
		//- Methods
	}
}
