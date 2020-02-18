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
	/// Accessor class for 'mGAbnormalityArchitecturalDistortion'
	/// [Fhir Element 'Observation.hasMember:mGAbnormalityArchitecturalDistortion]'
	/// </summary>
	public class MGAbnormalityArchitecturalDistortion_Accessor : ObservationBase.HasMemberMultiple<MGAbnormalityArchitecturalDistortion>       // CSDefineObservation.cs:194
	{                                                                                                                                          // CSDefineObservation.cs:195
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public MGAbnormalityArchitecturalDistortion_Accessor(BreastRadiologyDocument doc) : base()                                             // CSDefineObservation.cs:199
	    {                                                                                                                                      // CSDefineObservation.cs:200
	        this.Create(doc, 0, -1);                                                                                                           // CSDefineObservation.cs:201
	    }                                                                                                                                      // CSDefineObservation.cs:202
	}                                                                                                                                          // CSDefineObservation.cs:203
	/// <summary>
	/// Accessor class for 'mGAbnormalityCalcification'
	/// [Fhir Element 'Observation.hasMember:mGAbnormalityCalcification]'
	/// </summary>
	public class MGAbnormalityCalcification_Accessor : ObservationBase.HasMemberMultiple<MGAbnormalityCalcification>                           // CSDefineObservation.cs:194
	{                                                                                                                                          // CSDefineObservation.cs:195
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public MGAbnormalityCalcification_Accessor(BreastRadiologyDocument doc) : base()                                                       // CSDefineObservation.cs:199
	    {                                                                                                                                      // CSDefineObservation.cs:200
	        this.Create(doc, 0, -1);                                                                                                           // CSDefineObservation.cs:201
	    }                                                                                                                                      // CSDefineObservation.cs:202
	}                                                                                                                                          // CSDefineObservation.cs:203
	/// <summary>
	/// Accessor class for 'observedFeature'
	/// [Fhir Element 'Observation.hasMember:observedFeature]'
	/// </summary>
	public class ObservedFeature_Accessor : ObservationBase.HasMemberMultiple<ObservedFeature>                                                 // CSDefineObservation.cs:194
	{                                                                                                                                          // CSDefineObservation.cs:195
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public ObservedFeature_Accessor(BreastRadiologyDocument doc) : base()                                                                  // CSDefineObservation.cs:199
	    {                                                                                                                                      // CSDefineObservation.cs:200
	        this.Create(doc, 0, -1);                                                                                                           // CSDefineObservation.cs:201
	    }                                                                                                                                      // CSDefineObservation.cs:202
	}                                                                                                                                          // CSDefineObservation.cs:203
	//- LocalClassDefs
}
