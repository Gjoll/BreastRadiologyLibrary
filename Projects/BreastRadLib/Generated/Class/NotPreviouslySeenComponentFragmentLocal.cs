using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.ObservationLocal;

namespace BreastRadLib.NotPreviouslySeenComponentFragmentLocal
{
	//+ LocalClassDefs
	/// <summary>
	/// Accessor class for 'notPreviouslySeen'
	/// [Fhir Element 'Observation.component:notPreviouslySeen]'
	/// </summary>
	public class NotPreviouslySeen_Accessor : MemberListCodedValueBase<CodeableConcept>                                                        // CSBuildMemberListCodedValue.cs:65
	{                                                                                                                                          // CSBuildMemberListCodedValue.cs:66
	    // Properties                                                                                                                          // CSBuildMemberListCodedValue.cs:67
	    /// <summary>
	    /// Access propertyName
	    /// </summary>
	    public IEnumerable<CodeableConcept> All() => this.items;                                                                               // CSBuildMemberListCodedValue.cs:135
	                                                                                                                                           // CSBuildMemberListCodedValue.cs:137
	    /// <summary>
	    /// Access item at indicated location in list
	    /// </summary>
	    public CodeableConcept At(Int32 i) => base.items[i];                                                                                   // CSBuildMemberListCodedValue.cs:141
	                                                                                                                                           // CSBuildMemberListCodedValue.cs:143
	    /// <summary>
	    /// Access first item in list
	    /// </summary>
	    public new CodeableConcept First() => base.First();                                                                                    // CSBuildMemberListCodedValue.cs:147
	                                                                                                                                           // CSBuildMemberListCodedValue.cs:148
	    /// <summary>
	    /// Access first item in list or default value if empty
	    /// </summary>
	    public new CodeableConcept FirstOrDefault() => base.FirstOrDefault();                                                                  // CSBuildMemberListCodedValue.cs:152
	                                                                                                                                           // CSBuildMemberListCodedValue.cs:69
	    // Methods                                                                                                                             // CSBuildMemberListCodedValue.cs:70
	                                                                                                                                           // CSBuildMemberListCodedValue.cs:119
	    /// <summary>
	    /// Append item to end of list
	    /// </summary>
	    public void Append(NotPreviouslySeenVS.TCoding value)                                                                                  // CSBuildMemberListCodedValue.cs:123
	    {                                                                                                                                      // CSBuildMemberListCodedValue.cs:124
	        this.RawItems.Add(value);                                                                                                          // CSBuildMemberListCodedValue.cs:125
	    }                                                                                                                                      // CSBuildMemberListCodedValue.cs:126
	                                                                                                                                           // CSBuildMemberListCodedValue.cs:72
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public NotPreviouslySeen_Accessor(BreastRadiologyDocument doc) : base("NotPreviouslySeen_Accessor")                                    // CSBuildMemberListCodedValue.cs:76
	    {                                                                                                                                      // CSBuildMemberListCodedValue.cs:77
	        this.Init(doc, 0, -1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes", "notPreviouslySeen"));// CSBuildMemberListCodedValue.cs:78
	    }                                                                                                                                      // CSBuildMemberListCodedValue.cs:80
	}                                                                                                                                          // CSBuildMemberListCodedValue.cs:81
	//- LocalClassDefs
}
