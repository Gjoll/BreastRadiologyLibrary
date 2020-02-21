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
	public class PreviouslyDemonstratedBy_Accessor : MemberListCodedValueBase<CodeableConcept>                                                 // CSBuildMemberListCodedValue.cs:64
	{                                                                                                                                          // CSBuildMemberListCodedValue.cs:65
	    // Properties                                                                                                                          // CSBuildMemberListCodedValue.cs:66
	    /// <summary>
	    /// Access propertyName
	    /// </summary>
	    public IEnumerable<CodeableConcept> All() => this.items;                                                                               // CSBuildMemberListCodedValue.cs:134
	                                                                                                                                           // CSBuildMemberListCodedValue.cs:136
	    /// <summary>
	    /// Access item at indicated location in list
	    /// </summary>
	    public CodeableConcept At(Int32 i) => base.items[i];                                                                                   // CSBuildMemberListCodedValue.cs:140
	                                                                                                                                           // CSBuildMemberListCodedValue.cs:142
	    /// <summary>
	    /// Access first item in list
	    /// </summary>
	    public new CodeableConcept First() => base.First();                                                                                    // CSBuildMemberListCodedValue.cs:146
	                                                                                                                                           // CSBuildMemberListCodedValue.cs:147
	    /// <summary>
	    /// Access first item in list or default value if empty
	    /// </summary>
	    public new CodeableConcept FirstOrDefault() => base.FirstOrDefault();                                                                  // CSBuildMemberListCodedValue.cs:151
	                                                                                                                                           // CSBuildMemberListCodedValue.cs:68
	    // Methods                                                                                                                             // CSBuildMemberListCodedValue.cs:69
	                                                                                                                                           // CSBuildMemberListCodedValue.cs:118
	    /// <summary>
	    /// Append item to end of list
	    /// </summary>
	    public void Append(CodeableConcept value)                                                                                              // CSBuildMemberListCodedValue.cs:122
	    {                                                                                                                                      // CSBuildMemberListCodedValue.cs:123
	        this.RawItems.Add(value);                                                                                                          // CSBuildMemberListCodedValue.cs:124
	    }                                                                                                                                      // CSBuildMemberListCodedValue.cs:125
	                                                                                                                                           // CSBuildMemberListCodedValue.cs:118
	    /// <summary>
	    /// Append item to end of list
	    /// </summary>
	    public void Append(PreviouslyDemonstratedByVS.TCoding value)                                                                           // CSBuildMemberListCodedValue.cs:122
	    {                                                                                                                                      // CSBuildMemberListCodedValue.cs:123
	        this.RawItems.Add(value);                                                                                                          // CSBuildMemberListCodedValue.cs:124
	    }                                                                                                                                      // CSBuildMemberListCodedValue.cs:125
	                                                                                                                                           // CSBuildMemberListCodedValue.cs:71
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public PreviouslyDemonstratedBy_Accessor(BreastRadiologyDocument doc) : base("PreviouslyDemonstratedBy_Accessor")                      // CSBuildMemberListCodedValue.cs:75
	    {                                                                                                                                      // CSBuildMemberListCodedValue.cs:76
	        this.Init(doc, 0, -1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes", "prevDemBy"));// CSBuildMemberListCodedValue.cs:77
	    }                                                                                                                                      // CSBuildMemberListCodedValue.cs:79
	}                                                                                                                                          // CSBuildMemberListCodedValue.cs:80
	//- LocalClassDefs
}
