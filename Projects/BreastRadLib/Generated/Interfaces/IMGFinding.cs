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
	/// <summary>
	/// Interface MGFinding.
	/// This interface is automatically generated.
	/// </summary>
	public interface IMGFinding : IObservationSectionFragment

	{
		//+ Properties
		/// <summary>
		/// Access HasMembers value AbnormalityCyst
		/// </summary>
		AbnormalityCyst_Accessor AbnormalityCyst { get ; }                                                                                        // BuildMemberListBase.cs:62
		/// <summary>
		/// Access HasMembers value AbnormalityDuct
		/// </summary>
		AbnormalityDuct_Accessor AbnormalityDuct { get ; }                                                                                        // BuildMemberListBase.cs:62
		/// <summary>
		/// Access HasMembers value AbnormalityForeignObject
		/// </summary>
		AbnormalityForeignObject_Accessor AbnormalityForeignObject { get ; }                                                                      // BuildMemberListBase.cs:62
		/// <summary>
		/// Access HasMembers value AbnormalityLymphNode
		/// </summary>
		AbnormalityLymphNode_Accessor AbnormalityLymphNode { get ; }                                                                              // BuildMemberListBase.cs:62
		/// <summary>
		/// Access HasMembers value AbnormalityMass
		/// </summary>
		AbnormalityMass_Accessor AbnormalityMass { get ; }                                                                                        // BuildMemberListBase.cs:62
		/// <summary>
		/// Access HasMembers value AssociatedFeatures
		/// </summary>
		AssociatedFeatures_Accessor AssociatedFeatures { get ; }                                                                                  // BuildMemberListBase.cs:62
		/// <summary>
		/// Access HasMembers value AbnormalityFibroadenoma
		/// </summary>
		AbnormalityFibroadenoma_Accessor AbnormalityFibroadenoma { get ; }                                                                        // BuildMemberListBase.cs:62
		/// <summary>
		/// Access HasMembers value MGAbnormalityArchitecturalDistortion
		/// </summary>
		MGAbnormalityArchitecturalDistortion_Accessor MGAbnormalityArchitecturalDistortion { get ; }                                              // BuildMemberListBase.cs:62
		/// <summary>
		/// Access HasMembers value MGAbnormalityAsymmetry
		/// </summary>
		MGAbnormalityAsymmetry_Accessor MGAbnormalityAsymmetry { get ; }                                                                          // BuildMemberListBase.cs:62
		/// <summary>
		/// Access HasMembers value MGAbnormalityCalcification
		/// </summary>
		MGAbnormalityCalcification_Accessor MGAbnormalityCalcification { get ; }                                                                  // BuildMemberListBase.cs:62
		/// <summary>
		/// Access HasMembers value MGAbnormalityDensity
		/// </summary>
		MGAbnormalityDensity_Accessor MGAbnormalityDensity { get ; }                                                                              // BuildMemberListBase.cs:62
		/// <summary>
		/// Access HasMembers value MGAbnormalityFatNecrosis
		/// </summary>
		MGAbnormalityFatNecrosis_Accessor MGAbnormalityFatNecrosis { get ; }                                                                      // BuildMemberListBase.cs:62
		/// <summary>
		/// Access HasMembers value MGBreastDensity
		/// </summary>
		MGBreastDensity_Accessor MGBreastDensity { get ; }                                                                                        // BuildMemberListBase.cs:62
		//- Properties

		//+ Methods
		//- Methods
	}
}
