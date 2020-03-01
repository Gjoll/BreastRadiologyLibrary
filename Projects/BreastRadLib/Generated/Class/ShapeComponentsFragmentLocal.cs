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
	public class Orientation_Accessor : MemberListCodedValue<CodeableConcept>                                                                  // BuildMemberListCodedValue.cs:72
	{                                                                                                                                          // BuildMemberListCodedValue.cs:73
	    // Properties                                                                                                                          // BuildMemberListCodedValue.cs:74
	    /// <summary>
	    /// get {propertyName} value
	    /// </summary>
	    public CodeableConcept Get() => base.FirstOrDefault();                                                                                 // BuildMemberListCodedValue.cs:111
	                                                                                                                                           // BuildMemberListCodedValue.cs:76
	    // Methods                                                                                                                             // BuildMemberListCodedValue.cs:77
	                                                                                                                                           // BuildMemberListCodedValue.cs:98
	    /// <summary>
	    /// Set Orientation value
	    /// </summary>
	    public void Set(OrientationVS.TCoding value) => this.SetFirst(value);                                                                  // BuildMemberListCodedValue.cs:102
	                                                                                                                                           // BuildMemberListCodedValue.cs:79
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public Orientation_Accessor(BreastRadiologyDocument doc) : base("Orientation_Accessor")                                                // BuildMemberListCodedValue.cs:83
	    {                                                                                                                                      // BuildMemberListCodedValue.cs:84
	        this.Init(doc, 0, 1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes", "orientation"));// BuildMemberListCodedValue.cs:85
	    }                                                                                                                                      // BuildMemberListCodedValue.cs:87
	}                                                                                                                                          // BuildMemberListCodedValue.cs:88
	/// <summary>
	/// Accessor class for 'shape'
	/// [Fhir Element 'Observation.component:shape]'
	/// </summary>
	public class Shape_Accessor : MemberListCodedValue<CodeableConcept>                                                                        // BuildMemberListCodedValue.cs:72
	{                                                                                                                                          // BuildMemberListCodedValue.cs:73
	    // Properties                                                                                                                          // BuildMemberListCodedValue.cs:74
	    /// <summary>
	    /// get {propertyName} value
	    /// </summary>
	    public CodeableConcept Get() => base.FirstOrDefault();                                                                                 // BuildMemberListCodedValue.cs:111
	                                                                                                                                           // BuildMemberListCodedValue.cs:76
	    // Methods                                                                                                                             // BuildMemberListCodedValue.cs:77
	                                                                                                                                           // BuildMemberListCodedValue.cs:98
	    /// <summary>
	    /// Set Shape value
	    /// </summary>
	    public void Set(ShapeVS.TCoding value) => this.SetFirst(value);                                                                        // BuildMemberListCodedValue.cs:102
	                                                                                                                                           // BuildMemberListCodedValue.cs:79
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public Shape_Accessor(BreastRadiologyDocument doc) : base("Shape_Accessor")                                                            // BuildMemberListCodedValue.cs:83
	    {                                                                                                                                      // BuildMemberListCodedValue.cs:84
	        this.Init(doc, 0, 1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes", "shape"));    // BuildMemberListCodedValue.cs:85
	    }                                                                                                                                      // BuildMemberListCodedValue.cs:87
	}                                                                                                                                          // BuildMemberListCodedValue.cs:88
	/// <summary>
	/// Accessor class for 'margin'
	/// [Fhir Element 'Observation.component:margin]'
	/// </summary>
	public class Margin_Accessor : MemberListCodedValue<CodeableConcept>                                                                       // BuildMemberListCodedValue.cs:72
	{                                                                                                                                          // BuildMemberListCodedValue.cs:73
	    // Properties                                                                                                                          // BuildMemberListCodedValue.cs:74
	    /// <summary>
	    /// get {propertyName} value
	    /// </summary>
	    public CodeableConcept Get() => base.FirstOrDefault();                                                                                 // BuildMemberListCodedValue.cs:111
	                                                                                                                                           // BuildMemberListCodedValue.cs:76
	    // Methods                                                                                                                             // BuildMemberListCodedValue.cs:77
	                                                                                                                                           // BuildMemberListCodedValue.cs:98
	    /// <summary>
	    /// Set Margin value
	    /// </summary>
	    public void Set(MarginVS.TCoding value) => this.SetFirst(value);                                                                       // BuildMemberListCodedValue.cs:102
	                                                                                                                                           // BuildMemberListCodedValue.cs:79
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public Margin_Accessor(BreastRadiologyDocument doc) : base("Margin_Accessor")                                                          // BuildMemberListCodedValue.cs:83
	    {                                                                                                                                      // BuildMemberListCodedValue.cs:84
	        this.Init(doc, 0, 1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes", "margin"));   // BuildMemberListCodedValue.cs:85
	    }                                                                                                                                      // BuildMemberListCodedValue.cs:87
	}                                                                                                                                          // BuildMemberListCodedValue.cs:88
	/// <summary>
	/// Accessor class for 'mgDensity'
	/// [Fhir Element 'Observation.component:mgDensity]'
	/// </summary>
	public class MgDensity_Accessor : MemberListCodedValue<CodeableConcept>                                                                    // BuildMemberListCodedValue.cs:72
	{                                                                                                                                          // BuildMemberListCodedValue.cs:73
	    // Properties                                                                                                                          // BuildMemberListCodedValue.cs:74
	    /// <summary>
	    /// get {propertyName} value
	    /// </summary>
	    public CodeableConcept Get() => base.FirstOrDefault();                                                                                 // BuildMemberListCodedValue.cs:111
	                                                                                                                                           // BuildMemberListCodedValue.cs:76
	    // Methods                                                                                                                             // BuildMemberListCodedValue.cs:77
	                                                                                                                                           // BuildMemberListCodedValue.cs:98
	    /// <summary>
	    /// Set MgDensity value
	    /// </summary>
	    public void Set(MGDensityVS.TCoding value) => this.SetFirst(value);                                                                    // BuildMemberListCodedValue.cs:102
	                                                                                                                                           // BuildMemberListCodedValue.cs:79
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public MgDensity_Accessor(BreastRadiologyDocument doc) : base("MgDensity_Accessor")                                                    // BuildMemberListCodedValue.cs:83
	    {                                                                                                                                      // BuildMemberListCodedValue.cs:84
	        this.Init(doc, 0, 1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes", "mgDensity"));// BuildMemberListCodedValue.cs:85
	    }                                                                                                                                      // BuildMemberListCodedValue.cs:87
	}                                                                                                                                          // BuildMemberListCodedValue.cs:88
	//- LocalClassDefs
}
