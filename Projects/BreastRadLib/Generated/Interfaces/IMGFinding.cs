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
		AbnormalityCyst_Accessor AbnormalityCyst { get ; }                                                                                        // CSDefineObservation.cs:250
		AbnormalityDuct_Accessor AbnormalityDuct { get ; }                                                                                        // CSDefineObservation.cs:250
		AbnormalityForeignObject_Accessor AbnormalityForeignObject { get ; }                                                                      // CSDefineObservation.cs:250
		AbnormalityLymphNode_Accessor AbnormalityLymphNode { get ; }                                                                              // CSDefineObservation.cs:250
		AbnormalityMass_Accessor AbnormalityMass { get ; }                                                                                        // CSDefineObservation.cs:250
		AssociatedFeatures_Accessor AssociatedFeatures { get ; }                                                                                  // CSDefineObservation.cs:250
		AbnormalityFibroadenoma_Accessor AbnormalityFibroadenoma { get ; }                                                                        // CSDefineObservation.cs:250
		MGAbnormalityArchitecturalDistortion_Accessor MGAbnormalityArchitecturalDistortion { get ; }                                              // CSDefineObservation.cs:250
		MGAbnormalityAsymmetry_Accessor MGAbnormalityAsymmetry { get ; }                                                                          // CSDefineObservation.cs:250
		MGAbnormalityCalcification_Accessor MGAbnormalityCalcification { get ; }                                                                  // CSDefineObservation.cs:250
		MGAbnormalityDensity_Accessor MGAbnormalityDensity { get ; }                                                                              // CSDefineObservation.cs:250
		MGAbnormalityFatNecrosis_Accessor MGAbnormalityFatNecrosis { get ; }                                                                      // CSDefineObservation.cs:250
		MGBreastDensity_Accessor MGBreastDensity { get ; }                                                                                        // CSDefineObservation.cs:250
		//- Fields

		//+ Methods
		//- Methods
	}
}
