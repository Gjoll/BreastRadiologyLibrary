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
		// Called from BuildMemberReferences.cs, Line 197
		// BuildMemberBase.cs:366
		/// <summary>
		/// AbnormalityCyst
		/// </summary>
		AbnormalityCystContainer AbnormalityCyst { get ; }                                                                                        // BuildMemberBase.cs:369
		// Called from BuildMemberReferences.cs, Line 197
		// BuildMemberBase.cs:366
		/// <summary>
		/// AbnormalityDuct
		/// </summary>
		AbnormalityDuctContainer AbnormalityDuct { get ; }                                                                                        // BuildMemberBase.cs:369
		// Called from BuildMemberReferences.cs, Line 197
		// BuildMemberBase.cs:366
		/// <summary>
		/// AbnormalityForeignObject
		/// </summary>
		AbnormalityForeignObjectContainer AbnormalityForeignObject { get ; }                                                                      // BuildMemberBase.cs:369
		// Called from BuildMemberReferences.cs, Line 197
		// BuildMemberBase.cs:366
		/// <summary>
		/// AbnormalityLymphNode
		/// </summary>
		AbnormalityLymphNodeContainer AbnormalityLymphNode { get ; }                                                                              // BuildMemberBase.cs:369
		// Called from BuildMemberReferences.cs, Line 197
		// BuildMemberBase.cs:366
		/// <summary>
		/// AbnormalityMass
		/// </summary>
		AbnormalityMassContainer AbnormalityMass { get ; }                                                                                        // BuildMemberBase.cs:369
		// Called from BuildMemberReferences.cs, Line 197
		// BuildMemberBase.cs:366
		/// <summary>
		/// AssociatedFeature
		/// </summary>
		AssociatedFeatureContainer AssociatedFeature { get ; }                                                                                    // BuildMemberBase.cs:369
		// Called from BuildMemberReferences.cs, Line 197
		// BuildMemberBase.cs:366
		/// <summary>
		/// AbnormalityFibroadenoma
		/// </summary>
		AbnormalityFibroadenomaContainer AbnormalityFibroadenoma { get ; }                                                                        // BuildMemberBase.cs:369
		// Called from BuildMemberReferences.cs, Line 197
		// BuildMemberBase.cs:366
		/// <summary>
		/// MGAbnormalityArchitecturalDistortion
		/// </summary>
		MGAbnormalityArchitecturalDistortionContainer MGAbnormalityArchitecturalDistortion { get ; }                                              // BuildMemberBase.cs:369
		// Called from BuildMemberReferences.cs, Line 197
		// BuildMemberBase.cs:366
		/// <summary>
		/// MGAbnormalityAsymmetry
		/// </summary>
		MGAbnormalityAsymmetryContainer MGAbnormalityAsymmetry { get ; }                                                                          // BuildMemberBase.cs:369
		// Called from BuildMemberReferences.cs, Line 197
		// BuildMemberBase.cs:366
		/// <summary>
		/// MGAbnormalityCalcification
		/// </summary>
		MGAbnormalityCalcificationContainer MGAbnormalityCalcification { get ; }                                                                  // BuildMemberBase.cs:369
		// Called from BuildMemberReferences.cs, Line 197
		// BuildMemberBase.cs:366
		/// <summary>
		/// MGAbnormalityDensity
		/// </summary>
		MGAbnormalityDensityContainer MGAbnormalityDensity { get ; }                                                                              // BuildMemberBase.cs:369
		// Called from BuildMemberReferences.cs, Line 197
		// BuildMemberBase.cs:366
		/// <summary>
		/// MGAbnormalityFatNecrosis
		/// </summary>
		MGAbnormalityFatNecrosisContainer MGAbnormalityFatNecrosis { get ; }                                                                      // BuildMemberBase.cs:369
		// Called from BuildMemberReferences.cs, Line 197
		// BuildMemberBase.cs:366
		/// <summary>
		/// MGBreastDensity
		/// </summary>
		MGBreastDensityContainer MGBreastDensity { get ; }                                                                                        // BuildMemberBase.cs:369
		//- Properties

		//+ Methods
		//- Methods
	}
}
