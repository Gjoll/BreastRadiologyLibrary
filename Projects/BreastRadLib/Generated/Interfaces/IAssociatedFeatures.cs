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
	public interface IAssociatedFeatures : IObservationBase, IObservationSectionFragment
	{
		//+ LocalClassDefs
		//- LocalClassDefs

		//+ Fields
		MGAbnormalityArchitecturalDistortion_Accessor MGAbnormalityArchitecturalDistortion { get ; }                                              // CSBuildCodedReferenceList.cs:120
		MGAbnormalityCalcification_Accessor MGAbnormalityCalcification { get ; }                                                                  // CSBuildCodedReferenceList.cs:120
		ObservedFeature_Accessor ObservedFeature { get ; }                                                                                        // CSBuildCodedReferenceList.cs:120
		//- Fields

		//+ Methods
		//- Methods
	}
}
