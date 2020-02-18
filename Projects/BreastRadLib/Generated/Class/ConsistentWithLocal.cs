using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.ObservationLocal;

namespace BreastRadLib.ConsistentWithLocal
{
	//+ LocalClassDefs
	/// <summary>
	/// Accessor class for 'value'
	/// [Fhir Element 'Observation.component:value]'
	/// </summary>
	public class Value_Accessor : ObservationLocal.ComponentBase<CodeableConcept>                                                              // CSDefineObservation.cs:42
	{                                                                                                                                          // CSDefineObservation.cs:43
	    // Properties                                                                                                                          // CSDefineObservation.cs:44
	    /// <summary>
	    /// get {propertyName} value
	    /// </summary>
	    public CodeableConcept Value() => base.FirstOrDefault();                                                                               // CSDefineObservation.cs:67
	                                                                                                                                           // CSDefineObservation.cs:46
	    // Methods                                                                                                                             // CSDefineObservation.cs:47
	                                                                                                                                           // CSDefineObservation.cs:72
	    /// <summary>
	    /// Set Value value
	    /// </summary>
	    public void ValueCodeableConcept(CodeableConcept value) => this.SetFirst(value);                                                       // CSDefineObservation.cs:76
	                                                                                                                                           // CSDefineObservation.cs:49
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public Value_Accessor(BreastRadiologyDocument doc) : base()                                                                            // CSDefineObservation.cs:53
	    {                                                                                                                                      // CSDefineObservation.cs:54
	        this.Init(doc, 1, 1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes", "consistentWithValue"));// CSDefineObservation.cs:55
	    }                                                                                                                                      // CSDefineObservation.cs:57
	}                                                                                                                                          // CSDefineObservation.cs:58
	/// <summary>
	/// Accessor class for 'qualifier'
	/// [Fhir Element 'Observation.component:qualifier]'
	/// </summary>
	public class Qualifier_Accessor : ObservationLocal.ComponentBase<CodeableConcept>                                                          // CSDefineObservation.cs:42
	{                                                                                                                                          // CSDefineObservation.cs:43
	    // Properties                                                                                                                          // CSDefineObservation.cs:44
	    /// <summary>
	    /// get {propertyName} value
	    /// </summary>
	    public CodeableConcept Value() => base.FirstOrDefault();                                                                               // CSDefineObservation.cs:67
	                                                                                                                                           // CSDefineObservation.cs:46
	    // Methods                                                                                                                             // CSDefineObservation.cs:47
	                                                                                                                                           // CSDefineObservation.cs:72
	    /// <summary>
	    /// Set Qualifier value
	    /// </summary>
	    public void ValueCodeableConcept(CodeableConcept value) => this.SetFirst(value);                                                       // CSDefineObservation.cs:76
	                                                                                                                                           // CSDefineObservation.cs:49
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public Qualifier_Accessor(BreastRadiologyDocument doc) : base()                                                                        // CSDefineObservation.cs:53
	    {                                                                                                                                      // CSDefineObservation.cs:54
	        this.Init(doc, 1, 1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes", "consistentWithQualifier"));// CSDefineObservation.cs:55
	    }                                                                                                                                      // CSDefineObservation.cs:57
	}                                                                                                                                          // CSDefineObservation.cs:58
	//- LocalClassDefs
}
