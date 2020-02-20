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
		AbnormalityCyst_Accessor AbnormalityCyst { get ; }                                                                                        // CSBuildMemberListBase.cs:34
		AbnormalityDuct_Accessor AbnormalityDuct { get ; }                                                                                        // CSBuildMemberListBase.cs:34
		AbnormalityForeignObject_Accessor AbnormalityForeignObject { get ; }                                                                      // CSBuildMemberListBase.cs:34
		AbnormalityLymphNode_Accessor AbnormalityLymphNode { get ; }                                                                              // CSBuildMemberListBase.cs:34
		AbnormalityMass_Accessor AbnormalityMass { get ; }                                                                                        // CSBuildMemberListBase.cs:34
		AssociatedFeatures_Accessor AssociatedFeatures { get ; }                                                                                  // CSBuildMemberListBase.cs:34
		AbnormalityFibroadenoma_Accessor AbnormalityFibroadenoma { get ; }                                                                        // CSBuildMemberListBase.cs:34
		MGAbnormalityArchitecturalDistortion_Accessor MGAbnormalityArchitecturalDistortion { get ; }                                              // CSBuildMemberListBase.cs:34
		MGAbnormalityAsymmetry_Accessor MGAbnormalityAsymmetry { get ; }                                                                          // CSBuildMemberListBase.cs:34
		MGAbnormalityCalcification_Accessor MGAbnormalityCalcification { get ; }                                                                  // CSBuildMemberListBase.cs:34
		MGAbnormalityDensity_Accessor MGAbnormalityDensity { get ; }                                                                              // CSBuildMemberListBase.cs:34
		MGAbnormalityFatNecrosis_Accessor MGAbnormalityFatNecrosis { get ; }                                                                      // CSBuildMemberListBase.cs:34
		MGBreastDensity_Accessor MGBreastDensity { get ; }                                                                                        // CSBuildMemberListBase.cs:34
		//- Fields

		//+ Methods
		//- Methods
	}
}
