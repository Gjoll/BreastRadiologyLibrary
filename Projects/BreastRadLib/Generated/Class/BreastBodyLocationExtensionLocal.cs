using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.ExtensionLocal;

namespace BreastRadLib.BreastBodyLocationExtensionLocal
{
	//+ LocalClassDefs
	/// <summary>
	/// Accessor class for 'quadrant'
	/// [Fhir Element 'Extension.extension:quadrant]'
	/// </summary>
	public class Quadrant_Accessor : MemberListExtensionValueBase                                                                              // CSBuildMemberListExtensionValue.cs:95
	{                                                                                                                                          // CSBuildMemberListExtensionValue.cs:96
	    // Properties                                                                                                                          // CSBuildMemberListExtensionValue.cs:97
	    /// <summary>
	    /// get {propertyName} value
	    /// </summary>
	    public CodeableConcept Get() => (CodeableConcept) base.FirstOrDefault();                                                               // CSBuildMemberListExtensionValue.cs:182
	                                                                                                                                           // CSBuildMemberListExtensionValue.cs:99
	    // Methods                                                                                                                             // CSBuildMemberListExtensionValue.cs:100
	                                                                                                                                           // CSBuildMemberListExtensionValue.cs:119
	    /// <summary>
	    /// Set Quadrant value
	    /// </summary>
	    public void Set(BreastLocationQuadrantVS.TCoding value) => this.SetFirst((CodeableConcept)value);                                      // CSBuildMemberListExtensionValue.cs:123
	                                                                                                                                           // CSBuildMemberListExtensionValue.cs:102
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public Quadrant_Accessor(BreastRadiologyDocument doc) : base("Quadrant_Accessor")                                                      // CSBuildMemberListExtensionValue.cs:106
	    {                                                                                                                                      // CSBuildMemberListExtensionValue.cs:107
	        this.Init(doc, 0, 1, "quadrant");                                                                                                  // CSBuildMemberListExtensionValue.cs:108
	    }                                                                                                                                      // CSBuildMemberListExtensionValue.cs:110
	}                                                                                                                                          // CSBuildMemberListExtensionValue.cs:111
	/// <summary>
	/// Accessor class for 'region'
	/// [Fhir Element 'Extension.extension:region]'
	/// </summary>
	public class Region_Accessor : MemberListExtensionValueBase                                                                                // CSBuildMemberListExtensionValue.cs:95
	{                                                                                                                                          // CSBuildMemberListExtensionValue.cs:96
	    // Properties                                                                                                                          // CSBuildMemberListExtensionValue.cs:97
	    /// <summary>
	    /// Access propertyName
	    /// </summary>
	    public IEnumerable<CodeableConcept> All()                                                                                              // CSBuildMemberListExtensionValue.cs:262
	    {                                                                                                                                      // CSBuildMemberListExtensionValue.cs:263
	        foreach (var item in items)                                                                                                        // CSBuildMemberListExtensionValue.cs:264
	            yield return (CodeableConcept) item;                                                                                           // CSBuildMemberListExtensionValue.cs:265
	    }                                                                                                                                      // CSBuildMemberListExtensionValue.cs:266
	                                                                                                                                           // CSBuildMemberListExtensionValue.cs:268
	    /// <summary>
	    /// Access item at indicated location in list
	    /// </summary>
	    public CodeableConcept At(Int32 i) => (CodeableConcept) base.items[i];                                                                 // CSBuildMemberListExtensionValue.cs:272
	                                                                                                                                           // CSBuildMemberListExtensionValue.cs:274
	    /// <summary>
	    /// Access first item in list
	    /// </summary>
	    public new CodeableConcept First() => (CodeableConcept) base.First();                                                                  // CSBuildMemberListExtensionValue.cs:278
	                                                                                                                                           // CSBuildMemberListExtensionValue.cs:279
	    /// <summary>
	    /// Access first item in list or default value if empty
	    /// </summary>
	    public new CodeableConcept FirstOrDefault() => (CodeableConcept) base.FirstOrDefault();                                                // CSBuildMemberListExtensionValue.cs:283
	                                                                                                                                           // CSBuildMemberListExtensionValue.cs:99
	    // Methods                                                                                                                             // CSBuildMemberListExtensionValue.cs:100
	                                                                                                                                           // CSBuildMemberListExtensionValue.cs:210
	    /// <summary>
	    /// Append item to end of list
	    /// </summary>
	    public void Append(BreastLocationRegionVS.TCoding value)                                                                               // CSBuildMemberListExtensionValue.cs:214
	    {                                                                                                                                      // CSBuildMemberListExtensionValue.cs:215
	        this.RawItems.Add((CodeableConcept) value);                                                                                        // CSBuildMemberListExtensionValue.cs:216
	    }                                                                                                                                      // CSBuildMemberListExtensionValue.cs:217
	                                                                                                                                           // CSBuildMemberListExtensionValue.cs:102
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public Region_Accessor(BreastRadiologyDocument doc) : base("Region_Accessor")                                                          // CSBuildMemberListExtensionValue.cs:106
	    {                                                                                                                                      // CSBuildMemberListExtensionValue.cs:107
	        this.Init(doc, 0, -1, "region");                                                                                                   // CSBuildMemberListExtensionValue.cs:108
	    }                                                                                                                                      // CSBuildMemberListExtensionValue.cs:110
	}                                                                                                                                          // CSBuildMemberListExtensionValue.cs:111
	/// <summary>
	/// Accessor class for 'clockDirection'
	/// [Fhir Element 'Extension.extension:clockDirection]'
	/// </summary>
	public class ClockDirection_Accessor : MemberListExtensionValueBase                                                                        // CSBuildMemberListExtensionValue.cs:95
	{                                                                                                                                          // CSBuildMemberListExtensionValue.cs:96
	    // Properties                                                                                                                          // CSBuildMemberListExtensionValue.cs:97
	    /// <summary>
	    /// get {propertyName} value
	    /// </summary>
	    public CodeableConcept Get() => (CodeableConcept) base.FirstOrDefault();                                                               // CSBuildMemberListExtensionValue.cs:182
	                                                                                                                                           // CSBuildMemberListExtensionValue.cs:99
	    // Methods                                                                                                                             // CSBuildMemberListExtensionValue.cs:100
	                                                                                                                                           // CSBuildMemberListExtensionValue.cs:119
	    /// <summary>
	    /// Set ClockDirection value
	    /// </summary>
	    public void Set(BreastLocationClockVS.TCoding value) => this.SetFirst((CodeableConcept)value);                                         // CSBuildMemberListExtensionValue.cs:123
	                                                                                                                                           // CSBuildMemberListExtensionValue.cs:102
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public ClockDirection_Accessor(BreastRadiologyDocument doc) : base("ClockDirection_Accessor")                                          // CSBuildMemberListExtensionValue.cs:106
	    {                                                                                                                                      // CSBuildMemberListExtensionValue.cs:107
	        this.Init(doc, 0, 1, "clockDirection");                                                                                            // CSBuildMemberListExtensionValue.cs:108
	    }                                                                                                                                      // CSBuildMemberListExtensionValue.cs:110
	}                                                                                                                                          // CSBuildMemberListExtensionValue.cs:111
	/// <summary>
	/// Accessor class for 'depth'
	/// [Fhir Element 'Extension.extension:depth]'
	/// </summary>
	public class Depth_Accessor : MemberListExtensionValueBase                                                                                 // CSBuildMemberListExtensionValue.cs:95
	{                                                                                                                                          // CSBuildMemberListExtensionValue.cs:96
	    // Properties                                                                                                                          // CSBuildMemberListExtensionValue.cs:97
	    /// <summary>
	    /// get {propertyName} value
	    /// </summary>
	    public CodeableConcept Get() => (CodeableConcept) base.FirstOrDefault();                                                               // CSBuildMemberListExtensionValue.cs:182
	                                                                                                                                           // CSBuildMemberListExtensionValue.cs:99
	    // Methods                                                                                                                             // CSBuildMemberListExtensionValue.cs:100
	                                                                                                                                           // CSBuildMemberListExtensionValue.cs:119
	    /// <summary>
	    /// Set Depth value
	    /// </summary>
	    public void Set(BreastLocationDepthVS.TCoding value) => this.SetFirst((CodeableConcept)value);                                         // CSBuildMemberListExtensionValue.cs:123
	                                                                                                                                           // CSBuildMemberListExtensionValue.cs:102
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public Depth_Accessor(BreastRadiologyDocument doc) : base("Depth_Accessor")                                                            // CSBuildMemberListExtensionValue.cs:106
	    {                                                                                                                                      // CSBuildMemberListExtensionValue.cs:107
	        this.Init(doc, 0, 1, "depth");                                                                                                     // CSBuildMemberListExtensionValue.cs:108
	    }                                                                                                                                      // CSBuildMemberListExtensionValue.cs:110
	}                                                                                                                                          // CSBuildMemberListExtensionValue.cs:111
	//- LocalClassDefs
}
