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
		AbnormalityCyst_Accessor AbnormalityCyst { get ; }                                                                                        // CSDefineObservation.cs:314
		AbnormalityDuct_Accessor AbnormalityDuct { get ; }                                                                                        // CSDefineObservation.cs:314
		AbnormalityForeignObject_Accessor AbnormalityForeignObject { get ; }                                                                      // CSDefineObservation.cs:314
		AbnormalityLymphNode_Accessor AbnormalityLymphNode { get ; }                                                                              // CSDefineObservation.cs:314
		AbnormalityMass_Accessor AbnormalityMass { get ; }                                                                                        // CSDefineObservation.cs:314
		AssociatedFeatures_Accessor AssociatedFeatures { get ; }                                                                                  // CSDefineObservation.cs:314
		AbnormalityFibroadenoma_Accessor AbnormalityFibroadenoma { get ; }                                                                        // CSDefineObservation.cs:314
		MGAbnormalityArchitecturalDistortion_Accessor MGAbnormalityArchitecturalDistortion { get ; }                                              // CSDefineObservation.cs:314
		MGAbnormalityAsymmetry_Accessor MGAbnormalityAsymmetry { get ; }                                                                          // CSDefineObservation.cs:314
		MGAbnormalityCalcification_Accessor MGAbnormalityCalcification { get ; }                                                                  // CSDefineObservation.cs:314
		MGAbnormalityDensity_Accessor MGAbnormalityDensity { get ; }                                                                              // CSDefineObservation.cs:314
		MGAbnormalityFatNecrosis_Accessor MGAbnormalityFatNecrosis { get ; }                                                                      // CSDefineObservation.cs:314
		MGBreastDensity_Accessor MGBreastDensity { get ; }                                                                                        // CSDefineObservation.cs:314
		//- Fields

		//+ Methods
		//- Methods
	}
}
