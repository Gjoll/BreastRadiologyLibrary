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
		/// Access HasMembers value MGAbnormalityArchitecturalDistortion
		/// </summary>
		MGAbnormalityArchitecturalDistortion_Accessor MGAbnormalityArchitecturalDistortion { get ; }                                              // BuildMemberListBase.cs:40
		/// <summary>
		/// Access HasMembers value MGAbnormalityCalcification
		/// </summary>
		MGAbnormalityCalcification_Accessor MGAbnormalityCalcification { get ; }                                                                  // BuildMemberListBase.cs:40
		/// <summary>
		/// Access HasMembers value ObservedFeature
		/// </summary>
		ObservedFeature_Accessor ObservedFeature { get ; }                                                                                        // BuildMemberListBase.cs:40
		//- Properties

		//+ Methods
		//- Methods
	}
}
