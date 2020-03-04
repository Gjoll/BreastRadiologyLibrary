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
		ElementItemReferenceMultiple<AbnormalityCyst> AbnormalityCyst { get ; }                                                                   // BuildElementItemReference.cs:55
		/// <summary>
		/// Access AbnormalityDuct
		/// </summary>
		ElementItemReferenceMultiple<AbnormalityDuct> AbnormalityDuct { get ; }                                                                   // BuildElementItemReference.cs:55
		/// <summary>
		/// Access AbnormalityForeignObject
		/// </summary>
		ElementItemReferenceMultiple<AbnormalityForeignObject> AbnormalityForeignObject { get ; }                                                 // BuildElementItemReference.cs:55
		/// <summary>
		/// Access AbnormalityLymphNode
		/// </summary>
		ElementItemReferenceMultiple<AbnormalityLymphNode> AbnormalityLymphNode { get ; }                                                         // BuildElementItemReference.cs:55
		/// <summary>
		/// Access AbnormalityMass
		/// </summary>
		ElementItemReferenceMultiple<AbnormalityMass> AbnormalityMass { get ; }                                                                   // BuildElementItemReference.cs:55
		/// <summary>
		/// Access AssociatedFeatures
		/// </summary>
		ElementItemReferenceMultiple<AssociatedFeatures> AssociatedFeatures { get ; }                                                             // BuildElementItemReference.cs:55
		/// <summary>
		/// Access AbnormalityFibroadenoma
		/// </summary>
		ElementItemReferenceMultiple<AbnormalityFibroadenoma> AbnormalityFibroadenoma { get ; }                                                   // BuildElementItemReference.cs:55
		/// <summary>
		/// Access MGAbnormalityArchitecturalDistortion
		/// </summary>
		ElementItemReferenceMultiple<MGAbnormalityArchitecturalDistortion> MGAbnormalityArchitecturalDistortion { get ; }                         // BuildElementItemReference.cs:55
		/// <summary>
		/// Access MGAbnormalityAsymmetry
		/// </summary>
		ElementItemReferenceMultiple<MGAbnormalityAsymmetry> MGAbnormalityAsymmetry { get ; }                                                     // BuildElementItemReference.cs:55
		/// <summary>
		/// Access MGAbnormalityCalcification
		/// </summary>
		ElementItemReferenceMultiple<MGAbnormalityCalcification> MGAbnormalityCalcification { get ; }                                             // BuildElementItemReference.cs:55
		/// <summary>
		/// Access MGAbnormalityDensity
		/// </summary>
		ElementItemReferenceMultiple<MGAbnormalityDensity> MGAbnormalityDensity { get ; }                                                         // BuildElementItemReference.cs:55
		/// <summary>
		/// Access MGAbnormalityFatNecrosis
		/// </summary>
		ElementItemReferenceMultiple<MGAbnormalityFatNecrosis> MGAbnormalityFatNecrosis { get ; }                                                 // BuildElementItemReference.cs:55
		/// <summary>
		/// Access MGBreastDensity
		/// </summary>
		ElementItemReferenceSingle<MGBreastDensity> MGBreastDensity { get ; }                                                                     // BuildElementItemReference.cs:55
		//- Properties

		//+ Methods
		//- Methods
	}
}
