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
	public class LandMark_Accessor : MemberListExtensionValueBase                                                                              // CSBuildMemberListExtensionValue.cs:95
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
	    /// Set LandMark value
	    /// </summary>
	    public void Set(CodeableConcept value) => this.SetFirst((CodeableConcept)value);                                                       // CSBuildMemberListExtensionValue.cs:123
	                                                                                                                                           // CSBuildMemberListExtensionValue.cs:102
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public LandMark_Accessor(BreastRadiologyDocument doc) : base("LandMark_Accessor")                                                      // CSBuildMemberListExtensionValue.cs:106
	    {                                                                                                                                      // CSBuildMemberListExtensionValue.cs:107
	        this.Init(doc, 0, 1, "landMark");                                                                                                  // CSBuildMemberListExtensionValue.cs:108
	    }                                                                                                                                      // CSBuildMemberListExtensionValue.cs:110
	}                                                                                                                                          // CSBuildMemberListExtensionValue.cs:111
	/// <summary>
	/// Accessor class for 'distanceFromLandMark'
	/// [Fhir Element 'Extension.extension:distanceFromLandMark]'
	/// </summary>
	public class DistanceFromLandMark_Accessor : MemberListExtensionValueBase                                                                  // CSBuildMemberListExtensionValue.cs:95
	{                                                                                                                                          // CSBuildMemberListExtensionValue.cs:96
	    // Properties                                                                                                                          // CSBuildMemberListExtensionValue.cs:97
	    /// <summary>
	    /// get {propertyName} value
	    /// </summary>
	    public Quantity Get() => (Quantity) base.FirstOrDefault();                                                                             // CSBuildMemberListExtensionValue.cs:182
	                                                                                                                                           // CSBuildMemberListExtensionValue.cs:99
	    // Methods                                                                                                                             // CSBuildMemberListExtensionValue.cs:100
	                                                                                                                                           // CSBuildMemberListExtensionValue.cs:130
	    /// <summary>
	    /// Set DistanceFromLandMark value
	    /// </summary>
	    public void Set(decimal value, UnitsOfLengthVS.TCoding code)                                                                           // CSBuildMemberListExtensionValue.cs:134
	    {                                                                                                                                      // CSBuildMemberListExtensionValue.cs:135
	        Quantity q = new Quantity(value, code.Value.System, code.Value.Code);                                                              // CSBuildMemberListExtensionValue.cs:136
	        this.SetFirst(q);                                                                                                                  // CSBuildMemberListExtensionValue.cs:137
	    }                                                                                                                                      // CSBuildMemberListExtensionValue.cs:138
	                                                                                                                                           // CSBuildMemberListExtensionValue.cs:102
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public DistanceFromLandMark_Accessor(BreastRadiologyDocument doc) : base("DistanceFromLandMark_Accessor")                              // CSBuildMemberListExtensionValue.cs:106
	    {                                                                                                                                      // CSBuildMemberListExtensionValue.cs:107
	        this.Init(doc, 0, 1, "distanceFromLandMark");                                                                                      // CSBuildMemberListExtensionValue.cs:108
	    }                                                                                                                                      // CSBuildMemberListExtensionValue.cs:110
	}                                                                                                                                          // CSBuildMemberListExtensionValue.cs:111
	//- LocalClassDefs
}
