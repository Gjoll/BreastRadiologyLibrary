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
		AbnormalityCyst_Accessor AbnormalityCyst { get ; }                                                                                        // CSDefineObservation.cs:249
		AbnormalityDuct_Accessor AbnormalityDuct { get ; }                                                                                        // CSDefineObservation.cs:249
		AbnormalityForeignObject_Accessor AbnormalityForeignObject { get ; }                                                                      // CSDefineObservation.cs:249
		AbnormalityLymphNode_Accessor AbnormalityLymphNode { get ; }                                                                              // CSDefineObservation.cs:249
		AbnormalityMass_Accessor AbnormalityMass { get ; }                                                                                        // CSDefineObservation.cs:249
		AssociatedFeatures_Accessor AssociatedFeatures { get ; }                                                                                  // CSDefineObservation.cs:249
		AbnormalityFibroadenoma_Accessor AbnormalityFibroadenoma { get ; }                                                                        // CSDefineObservation.cs:249
		MGAbnormalityArchitecturalDistortion_Accessor MGAbnormalityArchitecturalDistortion { get ; }                                              // CSDefineObservation.cs:249
		MGAbnormalityAsymmetry_Accessor MGAbnormalityAsymmetry { get ; }                                                                          // CSDefineObservation.cs:249
		MGAbnormalityCalcification_Accessor MGAbnormalityCalcification { get ; }                                                                  // CSDefineObservation.cs:249
		MGAbnormalityDensity_Accessor MGAbnormalityDensity { get ; }                                                                              // CSDefineObservation.cs:249
		MGAbnormalityFatNecrosis_Accessor MGAbnormalityFatNecrosis { get ; }                                                                      // CSDefineObservation.cs:249
		MGBreastDensity_Accessor MGBreastDensity { get ; }                                                                                        // CSDefineObservation.cs:249
		//- Fields

		//+ Methods
		//- Methods
	}
}
