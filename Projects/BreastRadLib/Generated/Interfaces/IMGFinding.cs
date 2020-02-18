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
		AbnormalityCyst_Accessor AbnormalityCyst { get ; }                                                                                        // CSDefineObservation.cs:244
		AbnormalityDuct_Accessor AbnormalityDuct { get ; }                                                                                        // CSDefineObservation.cs:244
		AbnormalityForeignObject_Accessor AbnormalityForeignObject { get ; }                                                                      // CSDefineObservation.cs:244
		AbnormalityLymphNode_Accessor AbnormalityLymphNode { get ; }                                                                              // CSDefineObservation.cs:244
		AbnormalityMass_Accessor AbnormalityMass { get ; }                                                                                        // CSDefineObservation.cs:244
		AssociatedFeatures_Accessor AssociatedFeatures { get ; }                                                                                  // CSDefineObservation.cs:244
		AbnormalityFibroadenoma_Accessor AbnormalityFibroadenoma { get ; }                                                                        // CSDefineObservation.cs:244
		MGAbnormalityArchitecturalDistortion_Accessor MGAbnormalityArchitecturalDistortion { get ; }                                              // CSDefineObservation.cs:244
		MGAbnormalityAsymmetry_Accessor MGAbnormalityAsymmetry { get ; }                                                                          // CSDefineObservation.cs:244
		MGAbnormalityCalcification_Accessor MGAbnormalityCalcification { get ; }                                                                  // CSDefineObservation.cs:244
		MGAbnormalityDensity_Accessor MGAbnormalityDensity { get ; }                                                                              // CSDefineObservation.cs:244
		MGAbnormalityFatNecrosis_Accessor MGAbnormalityFatNecrosis { get ; }                                                                      // CSDefineObservation.cs:244
		MGBreastDensity_Accessor MGBreastDensity { get ; }                                                                                        // CSDefineObservation.cs:244
		//- Fields

		//+ Methods
		//- Methods
	}
}
