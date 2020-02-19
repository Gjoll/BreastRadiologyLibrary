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
		AbnormalityCyst_Accessor AbnormalityCyst { get ; }                                                                                        // CSBuildMemberListReference.cs:114
		AbnormalityDuct_Accessor AbnormalityDuct { get ; }                                                                                        // CSBuildMemberListReference.cs:114
		AbnormalityForeignObject_Accessor AbnormalityForeignObject { get ; }                                                                      // CSBuildMemberListReference.cs:114
		AbnormalityLymphNode_Accessor AbnormalityLymphNode { get ; }                                                                              // CSBuildMemberListReference.cs:114
		AbnormalityMass_Accessor AbnormalityMass { get ; }                                                                                        // CSBuildMemberListReference.cs:114
		AssociatedFeatures_Accessor AssociatedFeatures { get ; }                                                                                  // CSBuildMemberListReference.cs:114
		AbnormalityFibroadenoma_Accessor AbnormalityFibroadenoma { get ; }                                                                        // CSBuildMemberListReference.cs:114
		MGAbnormalityArchitecturalDistortion_Accessor MGAbnormalityArchitecturalDistortion { get ; }                                              // CSBuildMemberListReference.cs:114
		MGAbnormalityAsymmetry_Accessor MGAbnormalityAsymmetry { get ; }                                                                          // CSBuildMemberListReference.cs:114
		MGAbnormalityCalcification_Accessor MGAbnormalityCalcification { get ; }                                                                  // CSBuildMemberListReference.cs:114
		MGAbnormalityDensity_Accessor MGAbnormalityDensity { get ; }                                                                              // CSBuildMemberListReference.cs:114
		MGAbnormalityFatNecrosis_Accessor MGAbnormalityFatNecrosis { get ; }                                                                      // CSBuildMemberListReference.cs:114
		MGBreastDensity_Accessor MGBreastDensity { get ; }                                                                                        // CSBuildMemberListReference.cs:114
		//- Fields

		//+ Methods
		//- Methods
	}
}
