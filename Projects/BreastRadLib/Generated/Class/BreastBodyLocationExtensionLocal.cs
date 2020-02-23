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
	public class Quadrant_Accessor : MemberListExtensionValueBase                                                                              // BuildMemberListExtensionValue.cs:95
	{                                                                                                                                          // BuildMemberListExtensionValue.cs:96
	    // Properties                                                                                                                          // BuildMemberListExtensionValue.cs:97
	    /// <summary>
	    /// get {propertyName} value
	    /// </summary>
	    public CodeableConcept Get() => (CodeableConcept) base.FirstOrDefault();                                                               // BuildMemberListExtensionValue.cs:182
	                                                                                                                                           // BuildMemberListExtensionValue.cs:99
	    // Methods                                                                                                                             // BuildMemberListExtensionValue.cs:100
	                                                                                                                                           // BuildMemberListExtensionValue.cs:119
	    /// <summary>
	    /// Set Quadrant value
	    /// </summary>
	    public void Set(BreastLocationQuadrantVS.TCoding value) => this.SetFirst((CodeableConcept)value);                                      // BuildMemberListExtensionValue.cs:123
	                                                                                                                                           // BuildMemberListExtensionValue.cs:102
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public Quadrant_Accessor(BreastRadiologyDocument doc) : base("Quadrant_Accessor")                                                      // BuildMemberListExtensionValue.cs:106
	    {                                                                                                                                      // BuildMemberListExtensionValue.cs:107
	        this.Init(doc, 0, 1, "quadrant");                                                                                                  // BuildMemberListExtensionValue.cs:108
	    }                                                                                                                                      // BuildMemberListExtensionValue.cs:110
	}                                                                                                                                          // BuildMemberListExtensionValue.cs:111
	/// <summary>
	/// Accessor class for 'region'
	/// [Fhir Element 'Extension.extension:region]'
	/// </summary>
	public class Region_Accessor : MemberListExtensionValueBase                                                                                // BuildMemberListExtensionValue.cs:95
	{                                                                                                                                          // BuildMemberListExtensionValue.cs:96
	    // Properties                                                                                                                          // BuildMemberListExtensionValue.cs:97
	    /// <summary>
	    /// Access propertyName
	    /// </summary>
	    public IEnumerable<CodeableConcept> All()                                                                                              // BuildMemberListExtensionValue.cs:262
	    {                                                                                                                                      // BuildMemberListExtensionValue.cs:263
	        foreach (var item in items)                                                                                                        // BuildMemberListExtensionValue.cs:264
	            yield return (CodeableConcept) item;                                                                                           // BuildMemberListExtensionValue.cs:265
	    }                                                                                                                                      // BuildMemberListExtensionValue.cs:266
	                                                                                                                                           // BuildMemberListExtensionValue.cs:268
	    /// <summary>
	    /// Access item at indicated location in list
	    /// </summary>
	    public CodeableConcept At(Int32 i) => (CodeableConcept) base.items[i];                                                                 // BuildMemberListExtensionValue.cs:272
	                                                                                                                                           // BuildMemberListExtensionValue.cs:274
	    /// <summary>
	    /// Access first item in list
	    /// </summary>
	    public new CodeableConcept First() => (CodeableConcept) base.First();                                                                  // BuildMemberListExtensionValue.cs:278
	                                                                                                                                           // BuildMemberListExtensionValue.cs:279
	    /// <summary>
	    /// Access first item in list or default value if empty
	    /// </summary>
	    public new CodeableConcept FirstOrDefault() => (CodeableConcept) base.FirstOrDefault();                                                // BuildMemberListExtensionValue.cs:283
	                                                                                                                                           // BuildMemberListExtensionValue.cs:99
	    // Methods                                                                                                                             // BuildMemberListExtensionValue.cs:100
	                                                                                                                                           // BuildMemberListExtensionValue.cs:210
	    /// <summary>
	    /// Append item to end of list
	    /// </summary>
	    public void Append(BreastLocationRegionVS.TCoding value)                                                                               // BuildMemberListExtensionValue.cs:214
	    {                                                                                                                                      // BuildMemberListExtensionValue.cs:215
	        this.RawItems.Add((CodeableConcept) value);                                                                                        // BuildMemberListExtensionValue.cs:216
	    }                                                                                                                                      // BuildMemberListExtensionValue.cs:217
	                                                                                                                                           // BuildMemberListExtensionValue.cs:102
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public Region_Accessor(BreastRadiologyDocument doc) : base("Region_Accessor")                                                          // BuildMemberListExtensionValue.cs:106
	    {                                                                                                                                      // BuildMemberListExtensionValue.cs:107
	        this.Init(doc, 0, -1, "region");                                                                                                   // BuildMemberListExtensionValue.cs:108
	    }                                                                                                                                      // BuildMemberListExtensionValue.cs:110
	}                                                                                                                                          // BuildMemberListExtensionValue.cs:111
	/// <summary>
	/// Accessor class for 'clockDirection'
	/// [Fhir Element 'Extension.extension:clockDirection]'
	/// </summary>
	public class ClockDirection_Accessor : MemberListExtensionValueBase                                                                        // BuildMemberListExtensionValue.cs:95
	{                                                                                                                                          // BuildMemberListExtensionValue.cs:96
	    // Properties                                                                                                                          // BuildMemberListExtensionValue.cs:97
	    /// <summary>
	    /// get {propertyName} value
	    /// </summary>
	    public CodeableConcept Get() => (CodeableConcept) base.FirstOrDefault();                                                               // BuildMemberListExtensionValue.cs:182
	                                                                                                                                           // BuildMemberListExtensionValue.cs:99
	    // Methods                                                                                                                             // BuildMemberListExtensionValue.cs:100
	                                                                                                                                           // BuildMemberListExtensionValue.cs:119
	    /// <summary>
	    /// Set ClockDirection value
	    /// </summary>
	    public void Set(BreastLocationClockVS.TCoding value) => this.SetFirst((CodeableConcept)value);                                         // BuildMemberListExtensionValue.cs:123
	                                                                                                                                           // BuildMemberListExtensionValue.cs:102
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public ClockDirection_Accessor(BreastRadiologyDocument doc) : base("ClockDirection_Accessor")                                          // BuildMemberListExtensionValue.cs:106
	    {                                                                                                                                      // BuildMemberListExtensionValue.cs:107
	        this.Init(doc, 0, 1, "clockDirection");                                                                                            // BuildMemberListExtensionValue.cs:108
	    }                                                                                                                                      // BuildMemberListExtensionValue.cs:110
	}                                                                                                                                          // BuildMemberListExtensionValue.cs:111
	/// <summary>
	/// Accessor class for 'depth'
	/// [Fhir Element 'Extension.extension:depth]'
	/// </summary>
	public class Depth_Accessor : MemberListExtensionValueBase                                                                                 // BuildMemberListExtensionValue.cs:95
	{                                                                                                                                          // BuildMemberListExtensionValue.cs:96
	    // Properties                                                                                                                          // BuildMemberListExtensionValue.cs:97
	    /// <summary>
	    /// get {propertyName} value
	    /// </summary>
	    public CodeableConcept Get() => (CodeableConcept) base.FirstOrDefault();                                                               // BuildMemberListExtensionValue.cs:182
	                                                                                                                                           // BuildMemberListExtensionValue.cs:99
	    // Methods                                                                                                                             // BuildMemberListExtensionValue.cs:100
	                                                                                                                                           // BuildMemberListExtensionValue.cs:119
	    /// <summary>
	    /// Set Depth value
	    /// </summary>
	    public void Set(BreastLocationDepthVS.TCoding value) => this.SetFirst((CodeableConcept)value);                                         // BuildMemberListExtensionValue.cs:123
	                                                                                                                                           // BuildMemberListExtensionValue.cs:102
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public Depth_Accessor(BreastRadiologyDocument doc) : base("Depth_Accessor")                                                            // BuildMemberListExtensionValue.cs:106
	    {                                                                                                                                      // BuildMemberListExtensionValue.cs:107
	        this.Init(doc, 0, 1, "depth");                                                                                                     // BuildMemberListExtensionValue.cs:108
	    }                                                                                                                                      // BuildMemberListExtensionValue.cs:110
	}                                                                                                                                          // BuildMemberListExtensionValue.cs:111
	//- LocalClassDefs
}
