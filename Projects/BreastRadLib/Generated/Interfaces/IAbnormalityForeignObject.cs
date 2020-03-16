using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.AbnormalityForeignObjectLocal;

namespace BreastRadLib
{
	/// <summary>
	/// Interface AbnormalityForeignObject.
	/// This interface is automatically generated.
	/// </summary>
	public interface IAbnormalityForeignObject : IBreastRadObservationNoDeviceFragment,
        IBreastRadObservationNoValueFragment,
        IBreastRadObservationNoComponentFragment,
        ICommonComponentsFragment,
        INotPreviouslySeenComponentFragment,
        ICorrespondsWithFragment,
        IBiRadFragment,
        IPreviouslyDemonstratedByFragment,
        IAssociatedFeaturesHasMemberFragment,
        IConsistentWithHasMemberFragment

	{
		//+ Properties
		// Called from BuildMemberComponents.cs, Line 206
		// BuildMemberBase.cs:366
		/// <summary>
		/// AbnormalityForeignObjectType
		/// </summary>
		AbnormalityForeignObjectTypeContainer AbnormalityForeignObjectType { get ; }                                                              // BuildMemberBase.cs:369
		//- Properties

		//+ Methods
		//- Methods
	}
}
