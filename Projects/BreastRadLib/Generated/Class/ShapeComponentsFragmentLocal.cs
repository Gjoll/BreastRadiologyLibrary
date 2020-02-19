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
	public class Orientation_Accessor : ObservationLocal.ComponentBase<CodeableConcept>                                                        // CSDefineObservation.cs:66
	{                                                                                                                                          // CSDefineObservation.cs:67
	    // Properties                                                                                                                          // CSDefineObservation.cs:68
	    /// <summary>
	    /// get {propertyName} value
	    /// </summary>
	    public CodeableConcept Get() => base.FirstOrDefault();                                                                                 // CSDefineObservation.cs:105
	                                                                                                                                           // CSDefineObservation.cs:70
	    // Methods                                                                                                                             // CSDefineObservation.cs:71
	                                                                                                                                           // CSDefineObservation.cs:92
	    /// <summary>
	    /// Set Orientation value
	    /// </summary>
	    public void Set(OrientationVS.TCoding value) => this.SetFirst(value);                                                                  // CSDefineObservation.cs:96
	                                                                                                                                           // CSDefineObservation.cs:73
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public Orientation_Accessor(BreastRadiologyDocument doc) : base("Orientation_Accessor")                                                // CSDefineObservation.cs:77
	    {                                                                                                                                      // CSDefineObservation.cs:78
	        this.Init(doc, 0, 1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes", "orientation"));// CSDefineObservation.cs:79
	    }                                                                                                                                      // CSDefineObservation.cs:81
	}                                                                                                                                          // CSDefineObservation.cs:82
	/// <summary>
	/// Accessor class for 'shape'
	/// [Fhir Element 'Observation.component:shape]'
	/// </summary>
	public class Shape_Accessor : ObservationLocal.ComponentBase<CodeableConcept>                                                              // CSDefineObservation.cs:66
	{                                                                                                                                          // CSDefineObservation.cs:67
	    // Properties                                                                                                                          // CSDefineObservation.cs:68
	    /// <summary>
	    /// get {propertyName} value
	    /// </summary>
	    public CodeableConcept Get() => base.FirstOrDefault();                                                                                 // CSDefineObservation.cs:105
	                                                                                                                                           // CSDefineObservation.cs:70
	    // Methods                                                                                                                             // CSDefineObservation.cs:71
	                                                                                                                                           // CSDefineObservation.cs:92
	    /// <summary>
	    /// Set Shape value
	    /// </summary>
	    public void Set(ShapeVS.TCoding value) => this.SetFirst(value);                                                                        // CSDefineObservation.cs:96
	                                                                                                                                           // CSDefineObservation.cs:73
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public Shape_Accessor(BreastRadiologyDocument doc) : base("Shape_Accessor")                                                            // CSDefineObservation.cs:77
	    {                                                                                                                                      // CSDefineObservation.cs:78
	        this.Init(doc, 0, 1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes", "shape"));    // CSDefineObservation.cs:79
	    }                                                                                                                                      // CSDefineObservation.cs:81
	}                                                                                                                                          // CSDefineObservation.cs:82
	/// <summary>
	/// Accessor class for 'margin'
	/// [Fhir Element 'Observation.component:margin]'
	/// </summary>
	public class Margin_Accessor : ObservationLocal.ComponentBase<CodeableConcept>                                                             // CSDefineObservation.cs:66
	{                                                                                                                                          // CSDefineObservation.cs:67
	    // Properties                                                                                                                          // CSDefineObservation.cs:68
	    /// <summary>
	    /// get {propertyName} value
	    /// </summary>
	    public CodeableConcept Get() => base.FirstOrDefault();                                                                                 // CSDefineObservation.cs:105
	                                                                                                                                           // CSDefineObservation.cs:70
	    // Methods                                                                                                                             // CSDefineObservation.cs:71
	                                                                                                                                           // CSDefineObservation.cs:92
	    /// <summary>
	    /// Set Margin value
	    /// </summary>
	    public void Set(MarginVS.TCoding value) => this.SetFirst(value);                                                                       // CSDefineObservation.cs:96
	                                                                                                                                           // CSDefineObservation.cs:73
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public Margin_Accessor(BreastRadiologyDocument doc) : base("Margin_Accessor")                                                          // CSDefineObservation.cs:77
	    {                                                                                                                                      // CSDefineObservation.cs:78
	        this.Init(doc, 0, 1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes", "margin"));   // CSDefineObservation.cs:79
	    }                                                                                                                                      // CSDefineObservation.cs:81
	}                                                                                                                                          // CSDefineObservation.cs:82
	/// <summary>
	/// Accessor class for 'mgDensity'
	/// [Fhir Element 'Observation.component:mgDensity]'
	/// </summary>
	public class MgDensity_Accessor : ObservationLocal.ComponentBase<CodeableConcept>                                                          // CSDefineObservation.cs:66
	{                                                                                                                                          // CSDefineObservation.cs:67
	    // Properties                                                                                                                          // CSDefineObservation.cs:68
	    /// <summary>
	    /// get {propertyName} value
	    /// </summary>
	    public CodeableConcept Get() => base.FirstOrDefault();                                                                                 // CSDefineObservation.cs:105
	                                                                                                                                           // CSDefineObservation.cs:70
	    // Methods                                                                                                                             // CSDefineObservation.cs:71
	                                                                                                                                           // CSDefineObservation.cs:92
	    /// <summary>
	    /// Set MgDensity value
	    /// </summary>
	    public void Set(MGDensityVS.TCoding value) => this.SetFirst(value);                                                                    // CSDefineObservation.cs:96
	                                                                                                                                           // CSDefineObservation.cs:73
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public MgDensity_Accessor(BreastRadiologyDocument doc) : base("MgDensity_Accessor")                                                    // CSDefineObservation.cs:77
	    {                                                                                                                                      // CSDefineObservation.cs:78
	        this.Init(doc, 0, 1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes", "mgDensity"));// CSDefineObservation.cs:79
	    }                                                                                                                                      // CSDefineObservation.cs:81
	}                                                                                                                                          // CSDefineObservation.cs:82
	//- LocalClassDefs
}
