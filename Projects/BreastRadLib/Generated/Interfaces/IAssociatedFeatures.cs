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
	public interface IAssociatedFeatures
	{
		//+ LocalClassDefs
		//- LocalClassDefs

		//+ Fields
		MGAbnormalityArchitecturalDistortion_Accessor MGAbnormalityArchitecturalDistortion { get ; }                                              // CSBuildMemberListBase.cs:27
		MGAbnormalityCalcification_Accessor MGAbnormalityCalcification { get ; }                                                                  // CSBuildMemberListBase.cs:27
		ObservedFeature_Accessor ObservedFeature { get ; }                                                                                        // CSBuildMemberListBase.cs:27
		//- Fields

		//+ Methods
		//- Methods
	}
}
