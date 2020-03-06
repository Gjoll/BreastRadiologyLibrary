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
		TItemReferenceMultiple<AbnormalityCyst> AbnormalityCyst { get ; }                                                                         // BuildElementItemReference.cs:54
		/// <summary>
		/// Access AbnormalityDuct
		/// </summary>
		TItemReferenceMultiple<AbnormalityDuct> AbnormalityDuct { get ; }                                                                         // BuildElementItemReference.cs:54
		/// <summary>
		/// Access AbnormalityForeignObject
		/// </summary>
		TItemReferenceMultiple<AbnormalityForeignObject> AbnormalityForeignObject { get ; }                                                       // BuildElementItemReference.cs:54
		/// <summary>
		/// Access AbnormalityLymphNode
		/// </summary>
		TItemReferenceMultiple<AbnormalityLymphNode> AbnormalityLymphNode { get ; }                                                               // BuildElementItemReference.cs:54
		/// <summary>
		/// Access AbnormalityMass
		/// </summary>
		TItemReferenceMultiple<AbnormalityMass> AbnormalityMass { get ; }                                                                         // BuildElementItemReference.cs:54
		/// <summary>
		/// Access AssociatedFeatures
		/// </summary>
		TItemReferenceMultiple<AssociatedFeatures> AssociatedFeatures { get ; }                                                                   // BuildElementItemReference.cs:54
		/// <summary>
		/// Access AbnormalityFibroadenoma
		/// </summary>
		TItemReferenceMultiple<AbnormalityFibroadenoma> AbnormalityFibroadenoma { get ; }                                                         // BuildElementItemReference.cs:54
		/// <summary>
		/// Access MGAbnormalityArchitecturalDistortion
		/// </summary>
		TItemReferenceMultiple<MGAbnormalityArchitecturalDistortion> MGAbnormalityArchitecturalDistortion { get ; }                               // BuildElementItemReference.cs:54
		/// <summary>
		/// Access MGAbnormalityAsymmetry
		/// </summary>
		TItemReferenceMultiple<MGAbnormalityAsymmetry> MGAbnormalityAsymmetry { get ; }                                                           // BuildElementItemReference.cs:54
		/// <summary>
		/// Access MGAbnormalityCalcification
		/// </summary>
		TItemReferenceMultiple<MGAbnormalityCalcification> MGAbnormalityCalcification { get ; }                                                   // BuildElementItemReference.cs:54
		/// <summary>
		/// Access MGAbnormalityDensity
		/// </summary>
		TItemReferenceMultiple<MGAbnormalityDensity> MGAbnormalityDensity { get ; }                                                               // BuildElementItemReference.cs:54
		/// <summary>
		/// Access MGAbnormalityFatNecrosis
		/// </summary>
		TItemReferenceMultiple<MGAbnormalityFatNecrosis> MGAbnormalityFatNecrosis { get ; }                                                       // BuildElementItemReference.cs:54
		/// <summary>
		/// Access MGBreastDensity
		/// </summary>
		TItemReferenceSingle<MGBreastDensity> MGBreastDensity { get ; }                                                                           // BuildElementItemReference.cs:54
		//- Properties

		//+ Methods
		//- Methods
	}
}
