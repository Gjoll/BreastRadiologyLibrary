using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.ObservationLocal;

namespace BreastRadLib.ConsistentWithLocal
{
	//+ LocalClassDefs
	/// <summary>
	/// Accessor class for 'value'
	/// [Fhir Element 'Observation.component:value]'
	/// </summary>
	public class Value_Accessor : MemberListCodedValue<CodeableConcept>                                                                        // BuildMemberListCodedValue.cs:51
	{                                                                                                                                          // BuildMemberListCodedValue.cs:52
	    // Properties                                                                                                                          // BuildMemberListCodedValue.cs:53
	    /// <summary>
	    /// get {propertyName} value
	    /// </summary>
	    public CodeableConcept Get() => base.FirstOrDefault();                                                                                 // BuildMemberListCodedValue.cs:90
	                                                                                                                                           // BuildMemberListCodedValue.cs:55
	    // Methods                                                                                                                             // BuildMemberListCodedValue.cs:56
	                                                                                                                                           // BuildMemberListCodedValue.cs:77
	    /// <summary>
	    /// Set Value value
	    /// </summary>
	    public void Set(CodeableConcept value) => this.SetFirst(value);                                                                        // BuildMemberListCodedValue.cs:81
	                                                                                                                                           // BuildMemberListCodedValue.cs:77
	    /// <summary>
	    /// Set Value value
	    /// </summary>
	    public void Set(ConsistentWithVS.TCoding value) => this.SetFirst(value);                                                               // BuildMemberListCodedValue.cs:81
	                                                                                                                                           // BuildMemberListCodedValue.cs:58
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public Value_Accessor(BreastRadiologyDocument doc) : base("Value_Accessor")                                                            // BuildMemberListCodedValue.cs:62
	    {                                                                                                                                      // BuildMemberListCodedValue.cs:63
	        this.Init(doc, 1, 1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes", "consistentWithValue"));// BuildMemberListCodedValue.cs:64
	    }                                                                                                                                      // BuildMemberListCodedValue.cs:66
	}                                                                                                                                          // BuildMemberListCodedValue.cs:67
	/// <summary>
	/// Accessor class for 'qualifier'
	/// [Fhir Element 'Observation.component:qualifier]'
	/// </summary>
	public class Qualifier_Accessor : MemberListCodedValue<CodeableConcept>                                                                    // BuildMemberListCodedValue.cs:51
	{                                                                                                                                          // BuildMemberListCodedValue.cs:52
	    // Properties                                                                                                                          // BuildMemberListCodedValue.cs:53
	    /// <summary>
	    /// Access propertyName
	    /// </summary>
	    public IEnumerable<CodeableConcept> All() => this.items;                                                                               // BuildMemberListCodedValue.cs:118
	                                                                                                                                           // BuildMemberListCodedValue.cs:120
	    /// <summary>
	    /// Access item at indicated location in list
	    /// </summary>
	    public CodeableConcept At(Int32 i) => base.items[i];                                                                                   // BuildMemberListCodedValue.cs:124
	                                                                                                                                           // BuildMemberListCodedValue.cs:126
	    /// <summary>
	    /// Access first item in list
	    /// </summary>
	    public new CodeableConcept First() => base.First();                                                                                    // BuildMemberListCodedValue.cs:130
	                                                                                                                                           // BuildMemberListCodedValue.cs:131
	    /// <summary>
	    /// Access first item in list or default value if empty
	    /// </summary>
	    public new CodeableConcept FirstOrDefault() => base.FirstOrDefault();                                                                  // BuildMemberListCodedValue.cs:135
	                                                                                                                                           // BuildMemberListCodedValue.cs:55
	    // Methods                                                                                                                             // BuildMemberListCodedValue.cs:56
	                                                                                                                                           // BuildMemberListCodedValue.cs:105
	    /// <summary>
	    /// Append item to end of list
	    /// </summary>
	    public void Append(ConsistentWithQualifierVS.TCoding value) => this.RawItems.Add(value);                                               // BuildMemberListCodedValue.cs:109
	                                                                                                                                           // BuildMemberListCodedValue.cs:58
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public Qualifier_Accessor(BreastRadiologyDocument doc) : base("Qualifier_Accessor")                                                    // BuildMemberListCodedValue.cs:62
	    {                                                                                                                                      // BuildMemberListCodedValue.cs:63
	        this.Init(doc, 0, -1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes", "consistentWithQualifier"));// BuildMemberListCodedValue.cs:64
	    }                                                                                                                                      // BuildMemberListCodedValue.cs:66
	}                                                                                                                                          // BuildMemberListCodedValue.cs:67
	//- LocalClassDefs
}
