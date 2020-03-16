using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.AbnormalityFibroadenomaLocal;

namespace BreastRadLib
{
	/// <summary>
	/// Interface AbnormalityFibroadenoma.
	/// This interface is automatically generated.
	/// </summary>
	public interface IAbnormalityFibroadenoma : IObservationLeafFragment,
        IBreastRadObservationNoDeviceFragment,
        IBreastRadObservationNoValueFragment,
        IBreastRadObservationNoComponentFragment,
        ICommonComponentsFragment,
        IShapeComponentsFragment,
        IObservedCountFragment,
        IObservedDistributionFragment,
        IObservedSizeFragment,
        IPreviouslyDemonstratedByFragment,
        IAssociatedFeaturesHasMemberFragment

	{
		//+ Properties
		// Called from BuildMemberComponents.cs, Line 179
		// BuildMemberBase.cs:341
		/// <summary>
		/// FibroAdenomaType
		/// </summary>
		FibroAdenomaTypeContainer FibroAdenomaType { get ; }                                                                                      // BuildMemberBase.cs:344
		//- Properties

		//+ Methods
		//- Methods
	}
}
