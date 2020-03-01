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
	public class PreviouslyDemonstratedBy_Accessor : MemberListCodedValue<CodeableConcept>                                                     // BuildMemberListCodedValue.cs:72
	{                                                                                                                                          // BuildMemberListCodedValue.cs:73
	    // Properties                                                                                                                          // BuildMemberListCodedValue.cs:74
	    /// <summary>
	    /// Access propertyName
	    /// </summary>
	    public IEnumerable<CodeableConcept> All() => this.items;                                                                               // BuildMemberListCodedValue.cs:142
	                                                                                                                                           // BuildMemberListCodedValue.cs:144
	    /// <summary>
	    /// Access item at indicated location in list
	    /// </summary>
	    public CodeableConcept At(Int32 i) => base.items[i];                                                                                   // BuildMemberListCodedValue.cs:148
	                                                                                                                                           // BuildMemberListCodedValue.cs:150
	    /// <summary>
	    /// Access first item in list
	    /// </summary>
	    public new CodeableConcept First() => base.First();                                                                                    // BuildMemberListCodedValue.cs:154
	                                                                                                                                           // BuildMemberListCodedValue.cs:155
	    /// <summary>
	    /// Access first item in list or default value if empty
	    /// </summary>
	    public new CodeableConcept FirstOrDefault() => base.FirstOrDefault();                                                                  // BuildMemberListCodedValue.cs:159
	                                                                                                                                           // BuildMemberListCodedValue.cs:76
	    // Methods                                                                                                                             // BuildMemberListCodedValue.cs:77
	                                                                                                                                           // BuildMemberListCodedValue.cs:126
	    /// <summary>
	    /// Append item to end of list
	    /// </summary>
	    public void Append(CodeableConcept value)                                                                                              // BuildMemberListCodedValue.cs:130
	    {                                                                                                                                      // BuildMemberListCodedValue.cs:131
	        this.RawItems.Add(value);                                                                                                          // BuildMemberListCodedValue.cs:132
	    }                                                                                                                                      // BuildMemberListCodedValue.cs:133
	                                                                                                                                           // BuildMemberListCodedValue.cs:126
	    /// <summary>
	    /// Append item to end of list
	    /// </summary>
	    public void Append(PreviouslyDemonstratedByVS.TCoding value)                                                                           // BuildMemberListCodedValue.cs:130
	    {                                                                                                                                      // BuildMemberListCodedValue.cs:131
	        this.RawItems.Add(value);                                                                                                          // BuildMemberListCodedValue.cs:132
	    }                                                                                                                                      // BuildMemberListCodedValue.cs:133
	                                                                                                                                           // BuildMemberListCodedValue.cs:79
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public PreviouslyDemonstratedBy_Accessor(BreastRadiologyDocument doc) : base("PreviouslyDemonstratedBy_Accessor")                      // BuildMemberListCodedValue.cs:83
	    {                                                                                                                                      // BuildMemberListCodedValue.cs:84
	        this.Init(doc, 0, -1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes", "prevDemBy"));// BuildMemberListCodedValue.cs:85
	    }                                                                                                                                      // BuildMemberListCodedValue.cs:87
	}                                                                                                                                          // BuildMemberListCodedValue.cs:88
	//- LocalClassDefs
}
