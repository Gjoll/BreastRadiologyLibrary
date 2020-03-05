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
		TItemReferenceMultiple<AbnormalityCyst> AbnormalityCyst { get ; }                                                                   // BuildItemReference.cs:55
		/// <summary>
		/// Access AbnormalityDuct
		/// </summary>
		TItemReferenceMultiple<AbnormalityDuct> AbnormalityDuct { get ; }                                                                   // BuildItemReference.cs:55
		/// <summary>
		/// Access AbnormalityForeignObject
		/// </summary>
		TItemReferenceMultiple<AbnormalityForeignObject> AbnormalityForeignObject { get ; }                                                 // BuildItemReference.cs:55
		/// <summary>
		/// Access AbnormalityLymphNode
		/// </summary>
		TItemReferenceMultiple<AbnormalityLymphNode> AbnormalityLymphNode { get ; }                                                         // BuildItemReference.cs:55
		/// <summary>
		/// Access AbnormalityMass
		/// </summary>
		TItemReferenceMultiple<AbnormalityMass> AbnormalityMass { get ; }                                                                   // BuildItemReference.cs:55
		/// <summary>
		/// Access AssociatedFeatures
		/// </summary>
		TItemReferenceMultiple<AssociatedFeatures> AssociatedFeatures { get ; }                                                             // BuildItemReference.cs:55
		/// <summary>
		/// Access AbnormalityFibroadenoma
		/// </summary>
		TItemReferenceMultiple<AbnormalityFibroadenoma> AbnormalityFibroadenoma { get ; }                                                   // BuildItemReference.cs:55
		/// <summary>
		/// Access MGAbnormalityArchitecturalDistortion
		/// </summary>
		TItemReferenceMultiple<MGAbnormalityArchitecturalDistortion> MGAbnormalityArchitecturalDistortion { get ; }                         // BuildItemReference.cs:55
		/// <summary>
		/// Access MGAbnormalityAsymmetry
		/// </summary>
		TItemReferenceMultiple<MGAbnormalityAsymmetry> MGAbnormalityAsymmetry { get ; }                                                     // BuildItemReference.cs:55
		/// <summary>
		/// Access MGAbnormalityCalcification
		/// </summary>
		TItemReferenceMultiple<MGAbnormalityCalcification> MGAbnormalityCalcification { get ; }                                             // BuildItemReference.cs:55
		/// <summary>
		/// Access MGAbnormalityDensity
		/// </summary>
		TItemReferenceMultiple<MGAbnormalityDensity> MGAbnormalityDensity { get ; }                                                         // BuildItemReference.cs:55
		/// <summary>
		/// Access MGAbnormalityFatNecrosis
		/// </summary>
		TItemReferenceMultiple<MGAbnormalityFatNecrosis> MGAbnormalityFatNecrosis { get ; }                                                 // BuildItemReference.cs:55
		/// <summary>
		/// Access MGBreastDensity
		/// </summary>
		TItemReferenceSingle<MGBreastDensity> MGBreastDensity { get ; }                                                                     // BuildItemReference.cs:55
		//- Properties

		//+ Methods
		//- Methods
	}
}
