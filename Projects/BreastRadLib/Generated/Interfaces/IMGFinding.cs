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
	public interface IMGFinding : IObservationBase, IObservationSectionFragment
	{
		//+ LocalClassDefs
		//- LocalClassDefs

		//+ Fields
		AbnormalityCyst_Accessor AbnormalityCyst { get ; }                                                                                        // CSDefineObservation.cs:276
		AbnormalityDuct_Accessor AbnormalityDuct { get ; }                                                                                        // CSDefineObservation.cs:276
		AbnormalityForeignObject_Accessor AbnormalityForeignObject { get ; }                                                                      // CSDefineObservation.cs:276
		AbnormalityLymphNode_Accessor AbnormalityLymphNode { get ; }                                                                              // CSDefineObservation.cs:276
		AbnormalityMass_Accessor AbnormalityMass { get ; }                                                                                        // CSDefineObservation.cs:276
		AssociatedFeatures_Accessor AssociatedFeatures { get ; }                                                                                  // CSDefineObservation.cs:276
		AbnormalityFibroadenoma_Accessor AbnormalityFibroadenoma { get ; }                                                                        // CSDefineObservation.cs:276
		MGAbnormalityArchitecturalDistortion_Accessor MGAbnormalityArchitecturalDistortion { get ; }                                              // CSDefineObservation.cs:276
		MGAbnormalityAsymmetry_Accessor MGAbnormalityAsymmetry { get ; }                                                                          // CSDefineObservation.cs:276
		MGAbnormalityCalcification_Accessor MGAbnormalityCalcification { get ; }                                                                  // CSDefineObservation.cs:276
		MGAbnormalityDensity_Accessor MGAbnormalityDensity { get ; }                                                                              // CSDefineObservation.cs:276
		MGAbnormalityFatNecrosis_Accessor MGAbnormalityFatNecrosis { get ; }                                                                      // CSDefineObservation.cs:276
		MGBreastDensity_Accessor MGBreastDensity { get ; }                                                                                        // CSDefineObservation.cs:276
		//- Fields

		//+ Methods
		//- Methods
	}
}
