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
		/// <summary>
		/// DuctType
		/// </summary>
		DuctTypeContainer DuctType { get ; }                                                                                                      // BuildMemberBase.cs:323
		//- Properties

		//+ Methods
		//- Methods
	}
}
