using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.ObservationLocal;

namespace BreastRadLib.PreviouslyDemonstratedByFragmentLocal
{
	//+ LocalClassDefs
	/// <summary>
	/// Accessor class for 'PreviouslyDemonstratedBy'
	/// [Fhir Element 'Observation.component:PreviouslyDemonstratedBy]'
	/// </summary>
	public class PreviouslyDemonstratedBy_Accessor : ObservationLocal.ComponentBase<CodeableConcept>                                           // CSDefineObservation.cs:64
	{                                                                                                                                          // CSDefineObservation.cs:65
	    // Properties                                                                                                                          // CSDefineObservation.cs:66
	    /// <summary>
	    /// Access propertyName
	    /// </summary>
	    public IEnumerable<CodeableConcept> All() => this.items;                                                                               // CSDefineObservation.cs:134
	                                                                                                                                           // CSDefineObservation.cs:136
	    /// <summary>
	    /// Access item at indicated location in list
	    /// </summary>
	    public CodeableConcept At(Int32 i) => base.items[i];                                                                                   // CSDefineObservation.cs:140
	                                                                                                                                           // CSDefineObservation.cs:142
	    /// <summary>
	    /// Access first item in list
	    /// </summary>
	    public new CodeableConcept First() => base.First();                                                                                    // CSDefineObservation.cs:146
	                                                                                                                                           // CSDefineObservation.cs:147
	    /// <summary>
	    /// Access first item in list or default value if empty
	    /// </summary>
	    public new CodeableConcept FirstOrDefault() => base.FirstOrDefault();                                                                  // CSDefineObservation.cs:151
	                                                                                                                                           // CSDefineObservation.cs:68
	    // Methods                                                                                                                             // CSDefineObservation.cs:69
	                                                                                                                                           // CSDefineObservation.cs:118
	    /// <summary>
	    /// Append item to end of list
	    /// </summary>
	    public void Append(CodeableConcept value)                                                                                              // CSDefineObservation.cs:122
	    {                                                                                                                                      // CSDefineObservation.cs:123
	        this.RawItems.Add(value);                                                                                                          // CSDefineObservation.cs:124
	    }                                                                                                                                      // CSDefineObservation.cs:125
	                                                                                                                                           // CSDefineObservation.cs:71
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public PreviouslyDemonstratedBy_Accessor(BreastRadiologyDocument doc) : base()                                                         // CSDefineObservation.cs:75
	    {                                                                                                                                      // CSDefineObservation.cs:76
	        this.Init(doc, 0, -1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes", "prevDemBy"));// CSDefineObservation.cs:77
	    }                                                                                                                                      // CSDefineObservation.cs:79
	}                                                                                                                                          // CSDefineObservation.cs:80
	//- LocalClassDefs
}
