using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.ObservationLocal;

namespace BreastRadLib.MGAbnormalityCalcificationLocal
{
	//+ LocalClassDefs
	/// <summary>
	/// Accessor class for 'calcificationType'
	/// [Fhir Element 'Observation.component:calcificationType]'
	/// </summary>
	public class CalcificationType_Accessor : ObservationBase.ComponentBase<CodeableConcept>                                                   // CSDefineObservation.cs:215
	{                                                                                                                                          // CSDefineObservation.cs:216
	    // Properties                                                                                                                          // CSDefineObservation.cs:222
	    /// <summary>
	    /// get {propertyName} value
	    /// </summary>
	    public CodeableConcept Value() => this.GetSingleItem<CodeableConcept> ();                                                              // CSDefineObservation.cs:251
	                                                                                                                                           // CSDefineObservation.cs:224
	    // Methods                                                                                                                             // CSDefineObservation.cs:225
	                                                                                                                                           // CSDefineObservation.cs:256
	    /// <summary>
	    /// Set CalcificationType value
	    /// </summary>
	    public void ValueCodeableConcept(CodeableConcept value) => this.SetFirst(value);                                                       // CSDefineObservation.cs:260
	                                                                                                                                           // CSDefineObservation.cs:227
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public CalcificationType_Accessor(BreastRadiologyDocument doc) : base()                                                                // CSDefineObservation.cs:231
	    {                                                                                                                                      // CSDefineObservation.cs:232
	        this.Create(doc, 1, 1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes", "mgCalcificationType"));// CSDefineObservation.cs:233
	    }                                                                                                                                      // CSDefineObservation.cs:235
	}                                                                                                                                          // CSDefineObservation.cs:236
	/// <summary>
	/// Accessor class for 'calcificationDistribution'
	/// [Fhir Element 'Observation.component:calcificationDistribution]'
	/// </summary>
	public class CalcificationDistribution_Accessor : ObservationBase.ComponentBase<CodeableConcept>                                           // CSDefineObservation.cs:215
	{                                                                                                                                          // CSDefineObservation.cs:216
	    // Properties                                                                                                                          // CSDefineObservation.cs:222
	    /// <summary>
	    /// get {propertyName} value
	    /// </summary>
	    public CodeableConcept Value() => this.GetSingleItem<CodeableConcept> ();                                                              // CSDefineObservation.cs:251
	                                                                                                                                           // CSDefineObservation.cs:224
	    // Methods                                                                                                                             // CSDefineObservation.cs:225
	                                                                                                                                           // CSDefineObservation.cs:256
	    /// <summary>
	    /// Set CalcificationDistribution value
	    /// </summary>
	    public void ValueCodeableConcept(CodeableConcept value) => this.SetFirst(value);                                                       // CSDefineObservation.cs:260
	                                                                                                                                           // CSDefineObservation.cs:227
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public CalcificationDistribution_Accessor(BreastRadiologyDocument doc) : base()                                                        // CSDefineObservation.cs:231
	    {                                                                                                                                      // CSDefineObservation.cs:232
	        this.Create(doc, 1, 1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes", "mgCalcificationDistribution"));// CSDefineObservation.cs:233
	    }                                                                                                                                      // CSDefineObservation.cs:235
	}                                                                                                                                          // CSDefineObservation.cs:236
	//- LocalClassDefs
}
