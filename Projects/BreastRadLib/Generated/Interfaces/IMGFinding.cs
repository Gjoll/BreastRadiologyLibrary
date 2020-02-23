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
	public interface IMGFinding : IObservationSectionFragment

	{
		//+ Properties
		AbnormalityCyst_Accessor AbnormalityCyst { get ; }                                                                                        // BuildMemberListBase.cs:29
		AbnormalityDuct_Accessor AbnormalityDuct { get ; }                                                                                        // BuildMemberListBase.cs:29
		AbnormalityForeignObject_Accessor AbnormalityForeignObject { get ; }                                                                      // BuildMemberListBase.cs:29
		AbnormalityLymphNode_Accessor AbnormalityLymphNode { get ; }                                                                              // BuildMemberListBase.cs:29
		AbnormalityMass_Accessor AbnormalityMass { get ; }                                                                                        // BuildMemberListBase.cs:29
		AssociatedFeatures_Accessor AssociatedFeatures { get ; }                                                                                  // BuildMemberListBase.cs:29
		AbnormalityFibroadenoma_Accessor AbnormalityFibroadenoma { get ; }                                                                        // BuildMemberListBase.cs:29
		MGAbnormalityArchitecturalDistortion_Accessor MGAbnormalityArchitecturalDistortion { get ; }                                              // BuildMemberListBase.cs:29
		MGAbnormalityAsymmetry_Accessor MGAbnormalityAsymmetry { get ; }                                                                          // BuildMemberListBase.cs:29
		MGAbnormalityCalcification_Accessor MGAbnormalityCalcification { get ; }                                                                  // BuildMemberListBase.cs:29
		MGAbnormalityDensity_Accessor MGAbnormalityDensity { get ; }                                                                              // BuildMemberListBase.cs:29
		MGAbnormalityFatNecrosis_Accessor MGAbnormalityFatNecrosis { get ; }                                                                      // BuildMemberListBase.cs:29
		MGBreastDensity_Accessor MGBreastDensity { get ; }                                                                                        // BuildMemberListBase.cs:29
		//- Properties

		//+ Methods
		//- Methods
	}
}
