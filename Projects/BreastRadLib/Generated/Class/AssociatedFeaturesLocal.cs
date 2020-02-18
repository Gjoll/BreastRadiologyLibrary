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
	public class MGAbnormalityArchitecturalDistortion_Accessor : ObservationBase.HasMemberMultiple<MGAbnormalityArchitecturalDistortion>       // CSDefineObservation.cs:199
	{                                                                                                                                          // CSDefineObservation.cs:200
	    /// <summary>
	    /// Accessor HasMember slice MGAbnormalityArchitecturalDistortion_Accessor class constructor
	    /// </summary>
	    public MGAbnormalityArchitecturalDistortion_Accessor(BreastRadiologyDocument doc) : base()                                             // CSDefineObservation.cs:205
	    {                                                                                                                                      // CSDefineObservation.cs:206
	        this.Create(doc, 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityArchitecturalDistortion");       // CSDefineObservation.cs:207
	    }                                                                                                                                      // CSDefineObservation.cs:208
	}                                                                                                                                          // CSDefineObservation.cs:209
	/// <summary>
	/// Accessor class for ObservationhasMember slice 'mGAbnormalityCalcification'
	/// [Fhir Element 'Observation.hasMember:mGAbnormalityCalcification]'
	/// </summary>
	public class MGAbnormalityCalcification_Accessor : ObservationBase.HasMemberMultiple<MGAbnormalityCalcification>                           // CSDefineObservation.cs:199
	{                                                                                                                                          // CSDefineObservation.cs:200
	    /// <summary>
	    /// Accessor HasMember slice MGAbnormalityCalcification_Accessor class constructor
	    /// </summary>
	    public MGAbnormalityCalcification_Accessor(BreastRadiologyDocument doc) : base()                                                       // CSDefineObservation.cs:205
	    {                                                                                                                                      // CSDefineObservation.cs:206
	        this.Create(doc, 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityCalcification");                 // CSDefineObservation.cs:207
	    }                                                                                                                                      // CSDefineObservation.cs:208
	}                                                                                                                                          // CSDefineObservation.cs:209
	/// <summary>
	/// Accessor class for ObservationhasMember slice 'observedFeature'
	/// [Fhir Element 'Observation.hasMember:observedFeature]'
	/// </summary>
	public class ObservedFeature_Accessor : ObservationBase.HasMemberMultiple<ObservedFeature>                                                 // CSDefineObservation.cs:199
	{                                                                                                                                          // CSDefineObservation.cs:200
	    /// <summary>
	    /// Accessor HasMember slice ObservedFeature_Accessor class constructor
	    /// </summary>
	    public ObservedFeature_Accessor(BreastRadiologyDocument doc) : base()                                                                  // CSDefineObservation.cs:205
	    {                                                                                                                                      // CSDefineObservation.cs:206
	        this.Create(doc, 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/ObservedFeature");                            // CSDefineObservation.cs:207
	    }                                                                                                                                      // CSDefineObservation.cs:208
	}                                                                                                                                          // CSDefineObservation.cs:209
	//- LocalClassDefs
}
