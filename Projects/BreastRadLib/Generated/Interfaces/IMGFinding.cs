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
		/// Access AbnormalityCyst
		/// </summary>
		ElementItemReferenceMultiple<AbnormalityCyst> AbnormalityCyst { get ; }                                                                   // BuildMemberListReference.cs:55
		/// <summary>
		/// Access AbnormalityDuct
		/// </summary>
		ElementItemReferenceMultiple<AbnormalityDuct> AbnormalityDuct { get ; }                                                                   // BuildMemberListReference.cs:55
		/// <summary>
		/// Access AbnormalityForeignObject
		/// </summary>
		ElementItemReferenceMultiple<AbnormalityForeignObject> AbnormalityForeignObject { get ; }                                                 // BuildMemberListReference.cs:55
		/// <summary>
		/// Access AbnormalityLymphNode
		/// </summary>
		ElementItemReferenceMultiple<AbnormalityLymphNode> AbnormalityLymphNode { get ; }                                                         // BuildMemberListReference.cs:55
		/// <summary>
		/// Access AbnormalityMass
		/// </summary>
		ElementItemReferenceMultiple<AbnormalityMass> AbnormalityMass { get ; }                                                                   // BuildMemberListReference.cs:55
		/// <summary>
		/// Access AssociatedFeatures
		/// </summary>
		ElementItemReferenceMultiple<AssociatedFeatures> AssociatedFeatures { get ; }                                                             // BuildMemberListReference.cs:55
		/// <summary>
		/// Access AbnormalityFibroadenoma
		/// </summary>
		ElementItemReferenceMultiple<AbnormalityFibroadenoma> AbnormalityFibroadenoma { get ; }                                                   // BuildMemberListReference.cs:55
		/// <summary>
		/// Access MGAbnormalityArchitecturalDistortion
		/// </summary>
		ElementItemReferenceMultiple<MGAbnormalityArchitecturalDistortion> MGAbnormalityArchitecturalDistortion { get ; }                         // BuildMemberListReference.cs:55
		/// <summary>
		/// Access MGAbnormalityAsymmetry
		/// </summary>
		ElementItemReferenceMultiple<MGAbnormalityAsymmetry> MGAbnormalityAsymmetry { get ; }                                                     // BuildMemberListReference.cs:55
		/// <summary>
		/// Access MGAbnormalityCalcification
		/// </summary>
		ElementItemReferenceMultiple<MGAbnormalityCalcification> MGAbnormalityCalcification { get ; }                                             // BuildMemberListReference.cs:55
		/// <summary>
		/// Access MGAbnormalityDensity
		/// </summary>
		ElementItemReferenceMultiple<MGAbnormalityDensity> MGAbnormalityDensity { get ; }                                                         // BuildMemberListReference.cs:55
		/// <summary>
		/// Access MGAbnormalityFatNecrosis
		/// </summary>
		ElementItemReferenceMultiple<MGAbnormalityFatNecrosis> MGAbnormalityFatNecrosis { get ; }                                                 // BuildMemberListReference.cs:55
		/// <summary>
		/// Access MGBreastDensity
		/// </summary>
		ElementItemReferenceSingle<MGBreastDensity> MGBreastDensity { get ; }                                                                     // BuildMemberListReference.cs:55
		//- Properties

		//+ Methods
		//- Methods
	}
}
