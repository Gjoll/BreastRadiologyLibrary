using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.ObservationLocal;

namespace BreastRadLib.ShapeComponentsFragmentLocal
{
	//+ LocalClassDefs
	/// <summary>
	/// Accessor class for 'orientation'
	/// [Fhir Element 'Observation.component:orientation]'
	/// </summary>
	public class Orientation_Accessor : ObservationLocal.ComponentBase<CodeableConcept>                                                        // CSDefineObservation.cs:64
	{                                                                                                                                          // CSDefineObservation.cs:65
	    // Properties                                                                                                                          // CSDefineObservation.cs:66
	    /// <summary>
	    /// get {propertyName} value
	    /// </summary>
	    public CodeableConcept Get() => base.FirstOrDefault();                                                                                 // CSDefineObservation.cs:103
	                                                                                                                                           // CSDefineObservation.cs:68
	    // Methods                                                                                                                             // CSDefineObservation.cs:69
	                                                                                                                                           // CSDefineObservation.cs:90
	    /// <summary>
	    /// Set Orientation value
	    /// </summary>
	    public void Set(CodeableConcept value) => this.SetFirst(value);                                                                        // CSDefineObservation.cs:94
	                                                                                                                                           // CSDefineObservation.cs:71
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public Orientation_Accessor(BreastRadiologyDocument doc) : base()                                                                      // CSDefineObservation.cs:75
	    {                                                                                                                                      // CSDefineObservation.cs:76
	        this.Init(doc, 0, 1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes", "orientation"));// CSDefineObservation.cs:77
	    }                                                                                                                                      // CSDefineObservation.cs:79
	}                                                                                                                                          // CSDefineObservation.cs:80
	/// <summary>
	/// Accessor class for 'shape'
	/// [Fhir Element 'Observation.component:shape]'
	/// </summary>
	public class Shape_Accessor : ObservationLocal.ComponentBase<CodeableConcept>                                                              // CSDefineObservation.cs:64
	{                                                                                                                                          // CSDefineObservation.cs:65
	    // Properties                                                                                                                          // CSDefineObservation.cs:66
	    /// <summary>
	    /// get {propertyName} value
	    /// </summary>
	    public CodeableConcept Get() => base.FirstOrDefault();                                                                                 // CSDefineObservation.cs:103
	                                                                                                                                           // CSDefineObservation.cs:68
	    // Methods                                                                                                                             // CSDefineObservation.cs:69
	                                                                                                                                           // CSDefineObservation.cs:90
	    /// <summary>
	    /// Set Shape value
	    /// </summary>
	    public void Set(CodeableConcept value) => this.SetFirst(value);                                                                        // CSDefineObservation.cs:94
	                                                                                                                                           // CSDefineObservation.cs:71
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public Shape_Accessor(BreastRadiologyDocument doc) : base()                                                                            // CSDefineObservation.cs:75
	    {                                                                                                                                      // CSDefineObservation.cs:76
	        this.Init(doc, 0, 1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes", "shape"));    // CSDefineObservation.cs:77
	    }                                                                                                                                      // CSDefineObservation.cs:79
	}                                                                                                                                          // CSDefineObservation.cs:80
	/// <summary>
	/// Accessor class for 'margin'
	/// [Fhir Element 'Observation.component:margin]'
	/// </summary>
	public class Margin_Accessor : ObservationLocal.ComponentBase<CodeableConcept>                                                             // CSDefineObservation.cs:64
	{                                                                                                                                          // CSDefineObservation.cs:65
	    // Properties                                                                                                                          // CSDefineObservation.cs:66
	    /// <summary>
	    /// get {propertyName} value
	    /// </summary>
	    public CodeableConcept Get() => base.FirstOrDefault();                                                                                 // CSDefineObservation.cs:103
	                                                                                                                                           // CSDefineObservation.cs:68
	    // Methods                                                                                                                             // CSDefineObservation.cs:69
	                                                                                                                                           // CSDefineObservation.cs:90
	    /// <summary>
	    /// Set Margin value
	    /// </summary>
	    public void Set(CodeableConcept value) => this.SetFirst(value);                                                                        // CSDefineObservation.cs:94
	                                                                                                                                           // CSDefineObservation.cs:71
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public Margin_Accessor(BreastRadiologyDocument doc) : base()                                                                           // CSDefineObservation.cs:75
	    {                                                                                                                                      // CSDefineObservation.cs:76
	        this.Init(doc, 0, 1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes", "margin"));   // CSDefineObservation.cs:77
	    }                                                                                                                                      // CSDefineObservation.cs:79
	}                                                                                                                                          // CSDefineObservation.cs:80
	/// <summary>
	/// Accessor class for 'mgDensity'
	/// [Fhir Element 'Observation.component:mgDensity]'
	/// </summary>
	public class MgDensity_Accessor : ObservationLocal.ComponentBase<CodeableConcept>                                                          // CSDefineObservation.cs:64
	{                                                                                                                                          // CSDefineObservation.cs:65
	    // Properties                                                                                                                          // CSDefineObservation.cs:66
	    /// <summary>
	    /// get {propertyName} value
	    /// </summary>
	    public CodeableConcept Get() => base.FirstOrDefault();                                                                                 // CSDefineObservation.cs:103
	                                                                                                                                           // CSDefineObservation.cs:68
	    // Methods                                                                                                                             // CSDefineObservation.cs:69
	                                                                                                                                           // CSDefineObservation.cs:90
	    /// <summary>
	    /// Set MgDensity value
	    /// </summary>
	    public void Set(CodeableConcept value) => this.SetFirst(value);                                                                        // CSDefineObservation.cs:94
	                                                                                                                                           // CSDefineObservation.cs:71
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public MgDensity_Accessor(BreastRadiologyDocument doc) : base()                                                                        // CSDefineObservation.cs:75
	    {                                                                                                                                      // CSDefineObservation.cs:76
	        this.Init(doc, 0, 1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes", "mgDensity"));// CSDefineObservation.cs:77
	    }                                                                                                                                      // CSDefineObservation.cs:79
	}                                                                                                                                          // CSDefineObservation.cs:80
	//- LocalClassDefs
}
