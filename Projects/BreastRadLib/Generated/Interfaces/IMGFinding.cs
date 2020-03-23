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
		// Called from BuildMemberReferences.cs, Line 191
		// BuildMemberBase.cs:382
		/// <summary>
		/// AbnormalityCyst
		/// </summary>
		MAbnormalityCyst AbnormalityCyst { get ; }                                                                                                // BuildMemberBase.cs:385
		// Called from BuildMemberReferences.cs, Line 191
		// BuildMemberBase.cs:382
		/// <summary>
		/// AbnormalityDuct
		/// </summary>
		MAbnormalityDuct AbnormalityDuct { get ; }                                                                                                // BuildMemberBase.cs:385
		// Called from BuildMemberReferences.cs, Line 191
		// BuildMemberBase.cs:382
		/// <summary>
		/// AbnormalityForeignObject
		/// </summary>
		MAbnormalityForeignObject AbnormalityForeignObject { get ; }                                                                              // BuildMemberBase.cs:385
		// Called from BuildMemberReferences.cs, Line 191
		// BuildMemberBase.cs:382
		/// <summary>
		/// AbnormalityLymphNode
		/// </summary>
		MAbnormalityLymphNode AbnormalityLymphNode { get ; }                                                                                      // BuildMemberBase.cs:385
		// Called from BuildMemberReferences.cs, Line 191
		// BuildMemberBase.cs:382
		/// <summary>
		/// AbnormalityMass
		/// </summary>
		MAbnormalityMass AbnormalityMass { get ; }                                                                                                // BuildMemberBase.cs:385
		// Called from BuildMemberReferences.cs, Line 191
		// BuildMemberBase.cs:382
		/// <summary>
		/// AssociatedFeature
		/// </summary>
		MAssociatedFeature AssociatedFeature { get ; }                                                                                            // BuildMemberBase.cs:385
		// Called from BuildMemberReferences.cs, Line 191
		// BuildMemberBase.cs:382
		/// <summary>
		/// AbnormalityFibroadenoma
		/// </summary>
		MAbnormalityFibroadenoma AbnormalityFibroadenoma { get ; }                                                                                // BuildMemberBase.cs:385
		// Called from BuildMemberReferences.cs, Line 191
		// BuildMemberBase.cs:382
		/// <summary>
		/// MGAbnormalityArchitecturalDistortion
		/// </summary>
		MMGAbnormalityArchitecturalDistortion MGAbnormalityArchitecturalDistortion { get ; }                                                      // BuildMemberBase.cs:385
		// Called from BuildMemberReferences.cs, Line 191
		// BuildMemberBase.cs:382
		/// <summary>
		/// MGAbnormalityAsymmetry
		/// </summary>
		MMGAbnormalityAsymmetry MGAbnormalityAsymmetry { get ; }                                                                                  // BuildMemberBase.cs:385
		// Called from BuildMemberReferences.cs, Line 191
		// BuildMemberBase.cs:382
		/// <summary>
		/// MGAbnormalityCalcification
		/// </summary>
		MMGAbnormalityCalcification MGAbnormalityCalcification { get ; }                                                                          // BuildMemberBase.cs:385
		// Called from BuildMemberReferences.cs, Line 191
		// BuildMemberBase.cs:382
		/// <summary>
		/// MGAbnormalityDensity
		/// </summary>
		MMGAbnormalityDensity MGAbnormalityDensity { get ; }                                                                                      // BuildMemberBase.cs:385
		// Called from BuildMemberReferences.cs, Line 191
		// BuildMemberBase.cs:382
		/// <summary>
		/// MGAbnormalityFatNecrosis
		/// </summary>
		MMGAbnormalityFatNecrosis MGAbnormalityFatNecrosis { get ; }                                                                              // BuildMemberBase.cs:385
		// Called from BuildMemberReferences.cs, Line 191
		// BuildMemberBase.cs:382
		/// <summary>
		/// MGBreastDensity
		/// </summary>
		MMGBreastDensity MGBreastDensity { get ; }                                                                                                // BuildMemberBase.cs:385
		//- Properties

		//+ Methods
		//- Methods
	}
}
