using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.ObservationLocal;

namespace BreastRadLib.ObservedSizeFragmentLocal
{
	//+ LocalClassDefs
	/// <summary>
	/// Accessor class for 'obsSize'
	/// [Fhir Element 'Observation.component:obsSize]'
	/// </summary>
	public class ObsSize_Accessor : MemberListCodedValueBase<Element>                                                                          // CSBuildMemberListCodedValue.cs:65
	{                                                                                                                                          // CSBuildMemberListCodedValue.cs:66
	    // Properties                                                                                                                          // CSBuildMemberListCodedValue.cs:67
	    /// <summary>
	    /// Access propertyName
	    /// </summary>
	    public IEnumerable<Element> All() => this.items;                                                                                       // CSBuildMemberListCodedValue.cs:135
	                                                                                                                                           // CSBuildMemberListCodedValue.cs:137
	    /// <summary>
	    /// Access item at indicated location in list
	    /// </summary>
	    public Element At(Int32 i) => base.items[i];                                                                                           // CSBuildMemberListCodedValue.cs:141
	                                                                                                                                           // CSBuildMemberListCodedValue.cs:143
	    /// <summary>
	    /// Access first item in list
	    /// </summary>
	    public new Element First() => base.First();                                                                                            // CSBuildMemberListCodedValue.cs:147
	                                                                                                                                           // CSBuildMemberListCodedValue.cs:148
	    /// <summary>
	    /// Access first item in list or default value if empty
	    /// </summary>
	    public new Element FirstOrDefault() => base.FirstOrDefault();                                                                          // CSBuildMemberListCodedValue.cs:152
	                                                                                                                                           // CSBuildMemberListCodedValue.cs:69
	    // Methods                                                                                                                             // CSBuildMemberListCodedValue.cs:70
	                                                                                                                                           // CSBuildMemberListCodedValue.cs:119
	    /// <summary>
	    /// Append item to end of list
	    /// </summary>
	    public void AppendQuantity(Quantity value)                                                                                             // CSBuildMemberListCodedValue.cs:123
	    {                                                                                                                                      // CSBuildMemberListCodedValue.cs:124
	        this.RawItems.Add(value);                                                                                                          // CSBuildMemberListCodedValue.cs:125
	    }                                                                                                                                      // CSBuildMemberListCodedValue.cs:126
	                                                                                                                                           // CSBuildMemberListCodedValue.cs:119
	    /// <summary>
	    /// Append item to end of list
	    /// </summary>
	    public void AppendRange(Quantity value)                                                                                                // CSBuildMemberListCodedValue.cs:123
	    {                                                                                                                                      // CSBuildMemberListCodedValue.cs:124
	        this.RawItems.Add(value);                                                                                                          // CSBuildMemberListCodedValue.cs:125
	    }                                                                                                                                      // CSBuildMemberListCodedValue.cs:126
	                                                                                                                                           // CSBuildMemberListCodedValue.cs:72
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public ObsSize_Accessor(BreastRadiologyDocument doc) : base("ObsSize_Accessor")                                                        // CSBuildMemberListCodedValue.cs:76
	    {                                                                                                                                      // CSBuildMemberListCodedValue.cs:77
	        this.Init(doc, 0, 3, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes", "obsSize"));  // CSBuildMemberListCodedValue.cs:78
	    }                                                                                                                                      // CSBuildMemberListCodedValue.cs:80
	}                                                                                                                                          // CSBuildMemberListCodedValue.cs:81
	//- LocalClassDefs
}
