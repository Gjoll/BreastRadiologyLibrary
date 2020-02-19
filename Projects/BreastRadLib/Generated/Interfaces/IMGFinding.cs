using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.MGFindingLocal;

namespace BreastRadLib
{
	public interface IMGFinding : IObservationBase, IObservationSectionFragment
	{
		//+ LocalClassDefs
		//- LocalClassDefs

		//+ Fields
		AbnormalityCyst_Accessor AbnormalityCyst { get ; }                                                                                        // CSBuildCodedReferenceList.cs:114
		AbnormalityDuct_Accessor AbnormalityDuct { get ; }                                                                                        // CSBuildCodedReferenceList.cs:114
		AbnormalityForeignObject_Accessor AbnormalityForeignObject { get ; }                                                                      // CSBuildCodedReferenceList.cs:114
		AbnormalityLymphNode_Accessor AbnormalityLymphNode { get ; }                                                                              // CSBuildCodedReferenceList.cs:114
		AbnormalityMass_Accessor AbnormalityMass { get ; }                                                                                        // CSBuildCodedReferenceList.cs:114
		AssociatedFeatures_Accessor AssociatedFeatures { get ; }                                                                                  // CSBuildCodedReferenceList.cs:114
		AbnormalityFibroadenoma_Accessor AbnormalityFibroadenoma { get ; }                                                                        // CSBuildCodedReferenceList.cs:114
		MGAbnormalityArchitecturalDistortion_Accessor MGAbnormalityArchitecturalDistortion { get ; }                                              // CSBuildCodedReferenceList.cs:114
		MGAbnormalityAsymmetry_Accessor MGAbnormalityAsymmetry { get ; }                                                                          // CSBuildCodedReferenceList.cs:114
		MGAbnormalityCalcification_Accessor MGAbnormalityCalcification { get ; }                                                                  // CSBuildCodedReferenceList.cs:114
		MGAbnormalityDensity_Accessor MGAbnormalityDensity { get ; }                                                                              // CSBuildCodedReferenceList.cs:114
		MGAbnormalityFatNecrosis_Accessor MGAbnormalityFatNecrosis { get ; }                                                                      // CSBuildCodedReferenceList.cs:114
		MGBreastDensity_Accessor MGBreastDensity { get ; }                                                                                        // CSBuildCodedReferenceList.cs:114
		//- Fields

		//+ Methods
		//- Methods
	}
}
