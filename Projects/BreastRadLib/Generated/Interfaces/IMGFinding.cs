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
		AbnormalityCyst_Accessor AbnormalityCyst { get ; }                                                                                        // CSBuildCodedReferenceList.cs:120
		AbnormalityDuct_Accessor AbnormalityDuct { get ; }                                                                                        // CSBuildCodedReferenceList.cs:120
		AbnormalityForeignObject_Accessor AbnormalityForeignObject { get ; }                                                                      // CSBuildCodedReferenceList.cs:120
		AbnormalityLymphNode_Accessor AbnormalityLymphNode { get ; }                                                                              // CSBuildCodedReferenceList.cs:120
		AbnormalityMass_Accessor AbnormalityMass { get ; }                                                                                        // CSBuildCodedReferenceList.cs:120
		AssociatedFeatures_Accessor AssociatedFeatures { get ; }                                                                                  // CSBuildCodedReferenceList.cs:120
		AbnormalityFibroadenoma_Accessor AbnormalityFibroadenoma { get ; }                                                                        // CSBuildCodedReferenceList.cs:120
		MGAbnormalityArchitecturalDistortion_Accessor MGAbnormalityArchitecturalDistortion { get ; }                                              // CSBuildCodedReferenceList.cs:120
		MGAbnormalityAsymmetry_Accessor MGAbnormalityAsymmetry { get ; }                                                                          // CSBuildCodedReferenceList.cs:120
		MGAbnormalityCalcification_Accessor MGAbnormalityCalcification { get ; }                                                                  // CSBuildCodedReferenceList.cs:120
		MGAbnormalityDensity_Accessor MGAbnormalityDensity { get ; }                                                                              // CSBuildCodedReferenceList.cs:120
		MGAbnormalityFatNecrosis_Accessor MGAbnormalityFatNecrosis { get ; }                                                                      // CSBuildCodedReferenceList.cs:120
		MGBreastDensity_Accessor MGBreastDensity { get ; }                                                                                        // CSBuildCodedReferenceList.cs:120
		//- Fields

		//+ Methods
		//- Methods
	}
}
