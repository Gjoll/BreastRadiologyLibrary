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
		/// <summary>
		/// Access FibroAdenomaType
		/// </summary>
		ElementItemComponentSingle<CodeableConcept> FibroAdenomaType { get ; }                                                                    // BuildElementItemComponent.cs:66
		//- Properties

		//+ Methods
		//- Methods
	}
}
