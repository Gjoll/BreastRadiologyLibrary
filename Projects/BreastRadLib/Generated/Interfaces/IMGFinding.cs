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
		TElementItemReferenceMultiple<AbnormalityCyst> AbnormalityCyst { get ; }                                                                   // BuildElementItemReference.cs:55
		/// <summary>
		/// Access AbnormalityDuct
		/// </summary>
		TElementItemReferenceMultiple<AbnormalityDuct> AbnormalityDuct { get ; }                                                                   // BuildElementItemReference.cs:55
		/// <summary>
		/// Access AbnormalityForeignObject
		/// </summary>
		TElementItemReferenceMultiple<AbnormalityForeignObject> AbnormalityForeignObject { get ; }                                                 // BuildElementItemReference.cs:55
		/// <summary>
		/// Access AbnormalityLymphNode
		/// </summary>
		TElementItemReferenceMultiple<AbnormalityLymphNode> AbnormalityLymphNode { get ; }                                                         // BuildElementItemReference.cs:55
		/// <summary>
		/// Access AbnormalityMass
		/// </summary>
		TElementItemReferenceMultiple<AbnormalityMass> AbnormalityMass { get ; }                                                                   // BuildElementItemReference.cs:55
		/// <summary>
		/// Access AssociatedFeatures
		/// </summary>
		TElementItemReferenceMultiple<AssociatedFeatures> AssociatedFeatures { get ; }                                                             // BuildElementItemReference.cs:55
		/// <summary>
		/// Access AbnormalityFibroadenoma
		/// </summary>
		TElementItemReferenceMultiple<AbnormalityFibroadenoma> AbnormalityFibroadenoma { get ; }                                                   // BuildElementItemReference.cs:55
		/// <summary>
		/// Access MGAbnormalityArchitecturalDistortion
		/// </summary>
		TElementItemReferenceMultiple<MGAbnormalityArchitecturalDistortion> MGAbnormalityArchitecturalDistortion { get ; }                         // BuildElementItemReference.cs:55
		/// <summary>
		/// Access MGAbnormalityAsymmetry
		/// </summary>
		TElementItemReferenceMultiple<MGAbnormalityAsymmetry> MGAbnormalityAsymmetry { get ; }                                                     // BuildElementItemReference.cs:55
		/// <summary>
		/// Access MGAbnormalityCalcification
		/// </summary>
		TElementItemReferenceMultiple<MGAbnormalityCalcification> MGAbnormalityCalcification { get ; }                                             // BuildElementItemReference.cs:55
		/// <summary>
		/// Access MGAbnormalityDensity
		/// </summary>
		TElementItemReferenceMultiple<MGAbnormalityDensity> MGAbnormalityDensity { get ; }                                                         // BuildElementItemReference.cs:55
		/// <summary>
		/// Access MGAbnormalityFatNecrosis
		/// </summary>
		TElementItemReferenceMultiple<MGAbnormalityFatNecrosis> MGAbnormalityFatNecrosis { get ; }                                                 // BuildElementItemReference.cs:55
		/// <summary>
		/// Access MGBreastDensity
		/// </summary>
		TElementItemReferenceSingle<MGBreastDensity> MGBreastDensity { get ; }                                                                     // BuildElementItemReference.cs:55
		//- Properties

		//+ Methods
		//- Methods
	}
}
