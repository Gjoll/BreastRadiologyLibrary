using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.ExtensionLocal;

namespace BreastRadLib.BodyDistanceFromExtensionLocal
{
	//+ LocalClassDefs
	/// <summary>
	/// Accessor class for 'landMark'
	/// [Fhir Element 'Extension.extension:landMark]'
	/// </summary>
	public class LandMark_Accessor : MemberListExtensionValueBase                                                                              // BuildMemberListExtensionValue.cs:95
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
	    /// Set LandMark value
	    /// </summary>
	    public void Set(CodeableConcept value) => this.SetFirst((CodeableConcept)value);                                                       // BuildMemberListExtensionValue.cs:123
	                                                                                                                                           // BuildMemberListExtensionValue.cs:102
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public LandMark_Accessor(BreastRadiologyDocument doc) : base("LandMark_Accessor")                                                      // BuildMemberListExtensionValue.cs:106
	    {                                                                                                                                      // BuildMemberListExtensionValue.cs:107
	        this.Init(doc, 0, 1, "landMark");                                                                                                  // BuildMemberListExtensionValue.cs:108
	    }                                                                                                                                      // BuildMemberListExtensionValue.cs:110
	}                                                                                                                                          // BuildMemberListExtensionValue.cs:111
	/// <summary>
	/// Accessor class for 'distanceFromLandMark'
	/// [Fhir Element 'Extension.extension:distanceFromLandMark]'
	/// </summary>
	public class DistanceFromLandMark_Accessor : MemberListExtensionValueBase                                                                  // BuildMemberListExtensionValue.cs:95
	{                                                                                                                                          // BuildMemberListExtensionValue.cs:96
	    // Properties                                                                                                                          // BuildMemberListExtensionValue.cs:97
	    /// <summary>
	    /// get {propertyName} value
	    /// </summary>
	    public Quantity Get() => (Quantity) base.FirstOrDefault();                                                                             // BuildMemberListExtensionValue.cs:182
	                                                                                                                                           // BuildMemberListExtensionValue.cs:99
	    // Methods                                                                                                                             // BuildMemberListExtensionValue.cs:100
	                                                                                                                                           // BuildMemberListExtensionValue.cs:130
	    /// <summary>
	    /// Set DistanceFromLandMark value
	    /// </summary>
	    public void Set(decimal value, UnitsOfLengthVS.TCoding code)                                                                           // BuildMemberListExtensionValue.cs:134
	    {                                                                                                                                      // BuildMemberListExtensionValue.cs:135
	        Quantity q = new Quantity(value, code.Value.System, code.Value.Code);                                                              // BuildMemberListExtensionValue.cs:136
	        this.SetFirst(q);                                                                                                                  // BuildMemberListExtensionValue.cs:137
	    }                                                                                                                                      // BuildMemberListExtensionValue.cs:138
	                                                                                                                                           // BuildMemberListExtensionValue.cs:102
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public DistanceFromLandMark_Accessor(BreastRadiologyDocument doc) : base("DistanceFromLandMark_Accessor")                              // BuildMemberListExtensionValue.cs:106
	    {                                                                                                                                      // BuildMemberListExtensionValue.cs:107
	        this.Init(doc, 0, 1, "distanceFromLandMark");                                                                                      // BuildMemberListExtensionValue.cs:108
	    }                                                                                                                                      // BuildMemberListExtensionValue.cs:110
	}                                                                                                                                          // BuildMemberListExtensionValue.cs:111
	//- LocalClassDefs
}
