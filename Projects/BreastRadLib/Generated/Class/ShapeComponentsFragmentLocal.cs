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
	public class Orientation_Accessor : MemberListCodedValueBase<CodeableConcept>                                                              // CSBuildMemberListCodedValue.cs:69
	{                                                                                                                                          // CSBuildMemberListCodedValue.cs:70
	    // Properties                                                                                                                          // CSBuildMemberListCodedValue.cs:71
	    /// <summary>
	    /// get {propertyName} value
	    /// </summary>
	    public CodeableConcept Get() => base.FirstOrDefault();                                                                                 // CSBuildMemberListCodedValue.cs:108
	                                                                                                                                           // CSBuildMemberListCodedValue.cs:73
	    // Methods                                                                                                                             // CSBuildMemberListCodedValue.cs:74
	                                                                                                                                           // CSBuildMemberListCodedValue.cs:95
	    /// <summary>
	    /// Set Orientation value
	    /// </summary>
	    public void Set(OrientationVS.TCoding value) => this.SetFirst(value);                                                                  // CSBuildMemberListCodedValue.cs:99
	                                                                                                                                           // CSBuildMemberListCodedValue.cs:76
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public Orientation_Accessor(BreastRadiologyDocument doc) : base("Orientation_Accessor")                                                // CSBuildMemberListCodedValue.cs:80
	    {                                                                                                                                      // CSBuildMemberListCodedValue.cs:81
	        this.Init(doc, 0, 1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes", "orientation"));// CSBuildMemberListCodedValue.cs:82
	    }                                                                                                                                      // CSBuildMemberListCodedValue.cs:84
	}                                                                                                                                          // CSBuildMemberListCodedValue.cs:85
	/// <summary>
	/// Accessor class for 'shape'
	/// [Fhir Element 'Observation.component:shape]'
	/// </summary>
	public class Shape_Accessor : MemberListCodedValueBase<CodeableConcept>                                                                    // CSBuildMemberListCodedValue.cs:69
	{                                                                                                                                          // CSBuildMemberListCodedValue.cs:70
	    // Properties                                                                                                                          // CSBuildMemberListCodedValue.cs:71
	    /// <summary>
	    /// get {propertyName} value
	    /// </summary>
	    public CodeableConcept Get() => base.FirstOrDefault();                                                                                 // CSBuildMemberListCodedValue.cs:108
	                                                                                                                                           // CSBuildMemberListCodedValue.cs:73
	    // Methods                                                                                                                             // CSBuildMemberListCodedValue.cs:74
	                                                                                                                                           // CSBuildMemberListCodedValue.cs:95
	    /// <summary>
	    /// Set Shape value
	    /// </summary>
	    public void Set(ShapeVS.TCoding value) => this.SetFirst(value);                                                                        // CSBuildMemberListCodedValue.cs:99
	                                                                                                                                           // CSBuildMemberListCodedValue.cs:76
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public Shape_Accessor(BreastRadiologyDocument doc) : base("Shape_Accessor")                                                            // CSBuildMemberListCodedValue.cs:80
	    {                                                                                                                                      // CSBuildMemberListCodedValue.cs:81
	        this.Init(doc, 0, 1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes", "shape"));    // CSBuildMemberListCodedValue.cs:82
	    }                                                                                                                                      // CSBuildMemberListCodedValue.cs:84
	}                                                                                                                                          // CSBuildMemberListCodedValue.cs:85
	/// <summary>
	/// Accessor class for 'margin'
	/// [Fhir Element 'Observation.component:margin]'
	/// </summary>
	public class Margin_Accessor : MemberListCodedValueBase<CodeableConcept>                                                                   // CSBuildMemberListCodedValue.cs:69
	{                                                                                                                                          // CSBuildMemberListCodedValue.cs:70
	    // Properties                                                                                                                          // CSBuildMemberListCodedValue.cs:71
	    /// <summary>
	    /// get {propertyName} value
	    /// </summary>
	    public CodeableConcept Get() => base.FirstOrDefault();                                                                                 // CSBuildMemberListCodedValue.cs:108
	                                                                                                                                           // CSBuildMemberListCodedValue.cs:73
	    // Methods                                                                                                                             // CSBuildMemberListCodedValue.cs:74
	                                                                                                                                           // CSBuildMemberListCodedValue.cs:95
	    /// <summary>
	    /// Set Margin value
	    /// </summary>
	    public void Set(MarginVS.TCoding value) => this.SetFirst(value);                                                                       // CSBuildMemberListCodedValue.cs:99
	                                                                                                                                           // CSBuildMemberListCodedValue.cs:76
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public Margin_Accessor(BreastRadiologyDocument doc) : base("Margin_Accessor")                                                          // CSBuildMemberListCodedValue.cs:80
	    {                                                                                                                                      // CSBuildMemberListCodedValue.cs:81
	        this.Init(doc, 0, 1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes", "margin"));   // CSBuildMemberListCodedValue.cs:82
	    }                                                                                                                                      // CSBuildMemberListCodedValue.cs:84
	}                                                                                                                                          // CSBuildMemberListCodedValue.cs:85
	/// <summary>
	/// Accessor class for 'mgDensity'
	/// [Fhir Element 'Observation.component:mgDensity]'
	/// </summary>
	public class MgDensity_Accessor : MemberListCodedValueBase<CodeableConcept>                                                                // CSBuildMemberListCodedValue.cs:69
	{                                                                                                                                          // CSBuildMemberListCodedValue.cs:70
	    // Properties                                                                                                                          // CSBuildMemberListCodedValue.cs:71
	    /// <summary>
	    /// get {propertyName} value
	    /// </summary>
	    public CodeableConcept Get() => base.FirstOrDefault();                                                                                 // CSBuildMemberListCodedValue.cs:108
	                                                                                                                                           // CSBuildMemberListCodedValue.cs:73
	    // Methods                                                                                                                             // CSBuildMemberListCodedValue.cs:74
	                                                                                                                                           // CSBuildMemberListCodedValue.cs:95
	    /// <summary>
	    /// Set MgDensity value
	    /// </summary>
	    public void Set(MGDensityVS.TCoding value) => this.SetFirst(value);                                                                    // CSBuildMemberListCodedValue.cs:99
	                                                                                                                                           // CSBuildMemberListCodedValue.cs:76
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public MgDensity_Accessor(BreastRadiologyDocument doc) : base("MgDensity_Accessor")                                                    // CSBuildMemberListCodedValue.cs:80
	    {                                                                                                                                      // CSBuildMemberListCodedValue.cs:81
	        this.Init(doc, 0, 1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes", "mgDensity"));// CSBuildMemberListCodedValue.cs:82
	    }                                                                                                                                      // CSBuildMemberListCodedValue.cs:84
	}                                                                                                                                          // CSBuildMemberListCodedValue.cs:85
	//- LocalClassDefs
}
