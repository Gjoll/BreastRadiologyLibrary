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
	public interface IMGFinding
	{
		//+ LocalClassDefs
		//- LocalClassDefs

		//+ Fields
		AbnormalityCyst_Accessor AbnormalityCyst { get ; }                                                                                        // CSBuildMemberListBase.cs:27
		AbnormalityDuct_Accessor AbnormalityDuct { get ; }                                                                                        // CSBuildMemberListBase.cs:27
		AbnormalityForeignObject_Accessor AbnormalityForeignObject { get ; }                                                                      // CSBuildMemberListBase.cs:27
		AbnormalityLymphNode_Accessor AbnormalityLymphNode { get ; }                                                                              // CSBuildMemberListBase.cs:27
		AbnormalityMass_Accessor AbnormalityMass { get ; }                                                                                        // CSBuildMemberListBase.cs:27
		AssociatedFeatures_Accessor AssociatedFeatures { get ; }                                                                                  // CSBuildMemberListBase.cs:27
		AbnormalityFibroadenoma_Accessor AbnormalityFibroadenoma { get ; }                                                                        // CSBuildMemberListBase.cs:27
		MGAbnormalityArchitecturalDistortion_Accessor MGAbnormalityArchitecturalDistortion { get ; }                                              // CSBuildMemberListBase.cs:27
		MGAbnormalityAsymmetry_Accessor MGAbnormalityAsymmetry { get ; }                                                                          // CSBuildMemberListBase.cs:27
		MGAbnormalityCalcification_Accessor MGAbnormalityCalcification { get ; }                                                                  // CSBuildMemberListBase.cs:27
		MGAbnormalityDensity_Accessor MGAbnormalityDensity { get ; }                                                                              // CSBuildMemberListBase.cs:27
		MGAbnormalityFatNecrosis_Accessor MGAbnormalityFatNecrosis { get ; }                                                                      // CSBuildMemberListBase.cs:27
		MGBreastDensity_Accessor MGBreastDensity { get ; }                                                                                        // CSBuildMemberListBase.cs:27
		//- Fields

		//+ Methods
		//- Methods
	}
}
