using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.AssociatedFeaturesLocal;

namespace BreastRadLib
{
	/// <summary>
	/// Interface AssociatedFeatures.
	/// This interface is automatically generated.
	/// </summary>
	public interface IAssociatedFeatures : IObservationSectionFragment

	{
		//+ Properties
		/// <summary>
		/// Access MGAbnormalityArchitecturalDistortion
		/// </summary>
		TItemReferenceMultiple<MGAbnormalityArchitecturalDistortion> MGAbnormalityArchitecturalDistortion { get ; }                               // BuildElementItemReference.cs:55
		/// <summary>
		/// Access MGAbnormalityCalcification
		/// </summary>
		TItemReferenceMultiple<MGAbnormalityCalcification> MGAbnormalityCalcification { get ; }                                                   // BuildElementItemReference.cs:55
		/// <summary>
		/// Access ObservedFeature
		/// </summary>
		TItemReferenceMultiple<ObservedFeature> ObservedFeature { get ; }                                                                         // BuildElementItemReference.cs:55
		//- Properties

		//+ Methods
		//- Methods
	}
}
