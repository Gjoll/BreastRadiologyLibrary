using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.ObservationLocal;

namespace BreastRadLib.AssociatedFeaturesLocal
{
	//+ LocalClassDefs
	/// <summary>
	/// Accessor class for ObservationhasMember slice 'mGAbnormalityArchitecturalDistortion'
	/// [Fhir Element 'Observation.hasMember:mGAbnormalityArchitecturalDistortion]'
	/// </summary>
	public class MGAbnormalityArchitecturalDistortion_Accessor : ObservationLocal.HasMemberMultiple<MGAbnormalityArchitecturalDistortion>      // CSDefineObservation.cs:263
	{                                                                                                                                          // CSDefineObservation.cs:264
	    /// <summary>
	    /// Accessor HasMember slice MGAbnormalityArchitecturalDistortion_Accessor class constructor
	    /// </summary>
	    public MGAbnormalityArchitecturalDistortion_Accessor(BreastRadiologyDocument doc) : base()                                             // CSDefineObservation.cs:269
	    {                                                                                                                                      // CSDefineObservation.cs:270
	        this.Init(doc, 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityArchitecturalDistortion");         // CSDefineObservation.cs:271
	    }                                                                                                                                      // CSDefineObservation.cs:272
	}                                                                                                                                          // CSDefineObservation.cs:273
	/// <summary>
	/// Accessor class for ObservationhasMember slice 'mGAbnormalityCalcification'
	/// [Fhir Element 'Observation.hasMember:mGAbnormalityCalcification]'
	/// </summary>
	public class MGAbnormalityCalcification_Accessor : ObservationLocal.HasMemberMultiple<MGAbnormalityCalcification>                          // CSDefineObservation.cs:263
	{                                                                                                                                          // CSDefineObservation.cs:264
	    /// <summary>
	    /// Accessor HasMember slice MGAbnormalityCalcification_Accessor class constructor
	    /// </summary>
	    public MGAbnormalityCalcification_Accessor(BreastRadiologyDocument doc) : base()                                                       // CSDefineObservation.cs:269
	    {                                                                                                                                      // CSDefineObservation.cs:270
	        this.Init(doc, 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityCalcification");                   // CSDefineObservation.cs:271
	    }                                                                                                                                      // CSDefineObservation.cs:272
	}                                                                                                                                          // CSDefineObservation.cs:273
	/// <summary>
	/// Accessor class for ObservationhasMember slice 'observedFeature'
	/// [Fhir Element 'Observation.hasMember:observedFeature]'
	/// </summary>
	public class ObservedFeature_Accessor : ObservationLocal.HasMemberMultiple<ObservedFeature>                                                // CSDefineObservation.cs:263
	{                                                                                                                                          // CSDefineObservation.cs:264
	    /// <summary>
	    /// Accessor HasMember slice ObservedFeature_Accessor class constructor
	    /// </summary>
	    public ObservedFeature_Accessor(BreastRadiologyDocument doc) : base()                                                                  // CSDefineObservation.cs:269
	    {                                                                                                                                      // CSDefineObservation.cs:270
	        this.Init(doc, 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/ObservedFeature");                              // CSDefineObservation.cs:271
	    }                                                                                                                                      // CSDefineObservation.cs:272
	}                                                                                                                                          // CSDefineObservation.cs:273
	//- LocalClassDefs
}
