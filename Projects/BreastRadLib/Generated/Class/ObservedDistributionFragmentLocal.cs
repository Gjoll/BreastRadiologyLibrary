using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.ObservationLocal;

namespace BreastRadLib.ObservedDistributionFragmentLocal
{
	//+ LocalClassDefs
	/// <summary>
	/// Accessor class for 'obsDistribution'
	/// [Fhir Element 'Observation.component:obsDistribution]'
	/// </summary>
	public class ObsDistribution_Accessor : ObservationBase.ComponentBase<CodeableConcept>                                                     // CSDefineObservation.cs:215
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
	    /// Set ObsDistribution value
	    /// </summary>
	    public void ValueCodeableConcept(CodeableConcept value) => this.SetFirst(value);                                                       // CSDefineObservation.cs:260
	                                                                                                                                           // CSDefineObservation.cs:227
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public ObsDistribution_Accessor(BreastRadiologyDocument doc) : base()                                                                  // CSDefineObservation.cs:231
	    {                                                                                                                                      // CSDefineObservation.cs:232
	        this.Create(doc, 1, 1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes", "obsDistribution"));// CSDefineObservation.cs:233
	    }                                                                                                                                      // CSDefineObservation.cs:235
	}                                                                                                                                          // CSDefineObservation.cs:236
	/// <summary>
	/// Accessor class for 'obsDistRegionSize'
	/// [Fhir Element 'Observation.component:obsDistRegionSize]'
	/// </summary>
	public class ObsDistRegionSize_Accessor : ObservationBase.ComponentBase<Base>                                                              // CSDefineObservation.cs:215
	{                                                                                                                                          // CSDefineObservation.cs:216
	    // Properties                                                                                                                          // CSDefineObservation.cs:222
	    /// <summary>
	    /// get {propertyName} value
	    /// </summary>
	    public Base Value() => this.GetSingleItem<Base> ();                                                                                    // CSDefineObservation.cs:251
	                                                                                                                                           // CSDefineObservation.cs:224
	    // Methods                                                                                                                             // CSDefineObservation.cs:225
	                                                                                                                                           // CSDefineObservation.cs:256
	    /// <summary>
	    /// Set ObsDistRegionSize value
	    /// </summary>
	    public void ValueQuantity(Quantity value) => this.SetFirst(value);                                                                     // CSDefineObservation.cs:260
	                                                                                                                                           // CSDefineObservation.cs:256
	    /// <summary>
	    /// Set ObsDistRegionSize value
	    /// </summary>
	    public void ValueRange(Range value) => this.SetFirst(value);                                                                           // CSDefineObservation.cs:260
	                                                                                                                                           // CSDefineObservation.cs:227
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public ObsDistRegionSize_Accessor(BreastRadiologyDocument doc) : base()                                                                // CSDefineObservation.cs:231
	    {                                                                                                                                      // CSDefineObservation.cs:232
	        this.Create(doc, 1, 1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes", "obsSize"));// CSDefineObservation.cs:233
	    }                                                                                                                                      // CSDefineObservation.cs:235
	}                                                                                                                                          // CSDefineObservation.cs:236
	//- LocalClassDefs
}
