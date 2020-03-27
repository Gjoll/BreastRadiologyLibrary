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
		// Called from BuildMemberReferences.cs, Line 188
		// BuildMemberBase.cs:385
		/// <summary>
		/// AbnormalityCyst
		/// </summary>
		MAbnormalityCyst AbnormalityCyst { get ; }                                                                                                // BuildMemberBase.cs:388
		// Called from BuildMemberReferences.cs, Line 188
		// BuildMemberBase.cs:385
		/// <summary>
		/// AbnormalityDuct
		/// </summary>
		MAbnormalityDuct AbnormalityDuct { get ; }                                                                                                // BuildMemberBase.cs:388
		// Called from BuildMemberReferences.cs, Line 188
		// BuildMemberBase.cs:385
		/// <summary>
		/// AbnormalityForeignObject
		/// </summary>
		MAbnormalityForeignObject AbnormalityForeignObject { get ; }                                                                              // BuildMemberBase.cs:388
		// Called from BuildMemberReferences.cs, Line 188
		// BuildMemberBase.cs:385
		/// <summary>
		/// AbnormalityLymphNode
		/// </summary>
		MAbnormalityLymphNode AbnormalityLymphNode { get ; }                                                                                      // BuildMemberBase.cs:388
		// Called from BuildMemberReferences.cs, Line 188
		// BuildMemberBase.cs:385
		/// <summary>
		/// AbnormalityMass
		/// </summary>
		MAbnormalityMass AbnormalityMass { get ; }                                                                                                // BuildMemberBase.cs:388
		// Called from BuildMemberReferences.cs, Line 188
		// BuildMemberBase.cs:385
		/// <summary>
		/// AssociatedFeature
		/// </summary>
		MAssociatedFeature AssociatedFeature { get ; }                                                                                            // BuildMemberBase.cs:388
		// Called from BuildMemberReferences.cs, Line 188
		// BuildMemberBase.cs:385
		/// <summary>
		/// AbnormalityFibroadenoma
		/// </summary>
		MAbnormalityFibroadenoma AbnormalityFibroadenoma { get ; }                                                                                // BuildMemberBase.cs:388
		// Called from BuildMemberReferences.cs, Line 188
		// BuildMemberBase.cs:385
		/// <summary>
		/// MGAbnormalityArchitecturalDistortion
		/// </summary>
		MMGAbnormalityArchitecturalDistortion MGAbnormalityArchitecturalDistortion { get ; }                                                      // BuildMemberBase.cs:388
		// Called from BuildMemberReferences.cs, Line 188
		// BuildMemberBase.cs:385
		/// <summary>
		/// MGAbnormalityAsymmetry
		/// </summary>
		MMGAbnormalityAsymmetry MGAbnormalityAsymmetry { get ; }                                                                                  // BuildMemberBase.cs:388
		// Called from BuildMemberReferences.cs, Line 188
		// BuildMemberBase.cs:385
		/// <summary>
		/// MGAbnormalityCalcification
		/// </summary>
		MMGAbnormalityCalcification MGAbnormalityCalcification { get ; }                                                                          // BuildMemberBase.cs:388
		// Called from BuildMemberReferences.cs, Line 188
		// BuildMemberBase.cs:385
		/// <summary>
		/// MGAbnormalityDensity
		/// </summary>
		MMGAbnormalityDensity MGAbnormalityDensity { get ; }                                                                                      // BuildMemberBase.cs:388
		// Called from BuildMemberReferences.cs, Line 188
		// BuildMemberBase.cs:385
		/// <summary>
		/// MGAbnormalityFatNecrosis
		/// </summary>
		MMGAbnormalityFatNecrosis MGAbnormalityFatNecrosis { get ; }                                                                              // BuildMemberBase.cs:388
		// Called from BuildMemberReferences.cs, Line 188
		// BuildMemberBase.cs:385
		/// <summary>
		/// MGBreastDensity
		/// </summary>
		MMGBreastDensity MGBreastDensity { get ; }                                                                                                // BuildMemberBase.cs:388
		//- Properties

		//+ Methods
		//- Methods
	}
}
