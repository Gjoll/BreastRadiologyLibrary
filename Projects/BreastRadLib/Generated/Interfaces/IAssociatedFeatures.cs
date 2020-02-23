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
	public interface IAssociatedFeatures : IObservationSectionFragment

	{
		//+ Properties
		MGAbnormalityArchitecturalDistortion_Accessor MGAbnormalityArchitecturalDistortion { get ; }                                              // BuildMemberListBase.cs:29
		MGAbnormalityCalcification_Accessor MGAbnormalityCalcification { get ; }                                                                  // BuildMemberListBase.cs:29
		ObservedFeature_Accessor ObservedFeature { get ; }                                                                                        // BuildMemberListBase.cs:29
		//- Properties

		//+ Methods
		//- Methods
	}
}
