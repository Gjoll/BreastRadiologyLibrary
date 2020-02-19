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
	public class Value_Accessor : ObservationLocal.ComponentBase<CodeableConcept>                                                              // CSDefineObservation.cs:66
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
	    /// Set Value value
	    /// </summary>
	    public void Set(CodeableConcept value) => this.SetFirst(value);                                                                        // CSDefineObservation.cs:96
	                                                                                                                                           // CSDefineObservation.cs:92
	    /// <summary>
	    /// Set Value value
	    /// </summary>
	    public void Set(ConsistentWithVS.TCoding value) => this.SetFirst(value);                                                               // CSDefineObservation.cs:96
	                                                                                                                                           // CSDefineObservation.cs:73
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public Value_Accessor(BreastRadiologyDocument doc) : base("Value_Accessor")                                                            // CSDefineObservation.cs:77
	    {                                                                                                                                      // CSDefineObservation.cs:78
	        this.Init(doc, 1, 1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes", "consistentWithValue"));// CSDefineObservation.cs:79
	    }                                                                                                                                      // CSDefineObservation.cs:81
	}                                                                                                                                          // CSDefineObservation.cs:82
	/// <summary>
	/// Accessor class for 'qualifier'
	/// [Fhir Element 'Observation.component:qualifier]'
	/// </summary>
	public class Qualifier_Accessor : ObservationLocal.ComponentBase<CodeableConcept>                                                          // CSDefineObservation.cs:66
	{                                                                                                                                          // CSDefineObservation.cs:67
	    // Properties                                                                                                                          // CSDefineObservation.cs:68
	    /// <summary>
	    /// Access propertyName
	    /// </summary>
	    public IEnumerable<CodeableConcept> All() => this.items;                                                                               // CSDefineObservation.cs:136
	                                                                                                                                           // CSDefineObservation.cs:138
	    /// <summary>
	    /// Access item at indicated location in list
	    /// </summary>
	    public CodeableConcept At(Int32 i) => base.items[i];                                                                                   // CSDefineObservation.cs:142
	                                                                                                                                           // CSDefineObservation.cs:144
	    /// <summary>
	    /// Access first item in list
	    /// </summary>
	    public new CodeableConcept First() => base.First();                                                                                    // CSDefineObservation.cs:148
	                                                                                                                                           // CSDefineObservation.cs:149
	    /// <summary>
	    /// Access first item in list or default value if empty
	    /// </summary>
	    public new CodeableConcept FirstOrDefault() => base.FirstOrDefault();                                                                  // CSDefineObservation.cs:153
	                                                                                                                                           // CSDefineObservation.cs:70
	    // Methods                                                                                                                             // CSDefineObservation.cs:71
	                                                                                                                                           // CSDefineObservation.cs:120
	    /// <summary>
	    /// Append item to end of list
	    /// </summary>
	    public void Append(ConsistentWithQualifierVS.TCoding value)                                                                            // CSDefineObservation.cs:124
	    {                                                                                                                                      // CSDefineObservation.cs:125
	        this.RawItems.Add(value);                                                                                                          // CSDefineObservation.cs:126
	    }                                                                                                                                      // CSDefineObservation.cs:127
	                                                                                                                                           // CSDefineObservation.cs:73
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public Qualifier_Accessor(BreastRadiologyDocument doc) : base("Qualifier_Accessor")                                                    // CSDefineObservation.cs:77
	    {                                                                                                                                      // CSDefineObservation.cs:78
	        this.Init(doc, 0, -1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes", "consistentWithQualifier"));// CSDefineObservation.cs:79
	    }                                                                                                                                      // CSDefineObservation.cs:81
	}                                                                                                                                          // CSDefineObservation.cs:82
	//- LocalClassDefs
}
