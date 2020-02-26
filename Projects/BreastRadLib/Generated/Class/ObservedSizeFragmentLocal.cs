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
	public class ObsSize_Accessor : MemberListCodedValueBase<Element>                                                                          // BuildMemberListCodedValue.cs:72
	{                                                                                                                                          // BuildMemberListCodedValue.cs:73
	    // Properties                                                                                                                          // BuildMemberListCodedValue.cs:74
	    /// <summary>
	    /// Access propertyName
	    /// </summary>
	    public IEnumerable<Element> All() => this.items;                                                                                       // BuildMemberListCodedValue.cs:142
	                                                                                                                                           // BuildMemberListCodedValue.cs:144
	    /// <summary>
	    /// Access item at indicated location in list
	    /// </summary>
	    public Element At(Int32 i) => base.items[i];                                                                                           // BuildMemberListCodedValue.cs:148
	                                                                                                                                           // BuildMemberListCodedValue.cs:150
	    /// <summary>
	    /// Access first item in list
	    /// </summary>
	    public new Element First() => base.First();                                                                                            // BuildMemberListCodedValue.cs:154
	                                                                                                                                           // BuildMemberListCodedValue.cs:155
	    /// <summary>
	    /// Access first item in list or default value if empty
	    /// </summary>
	    public new Element FirstOrDefault() => base.FirstOrDefault();                                                                          // BuildMemberListCodedValue.cs:159
	                                                                                                                                           // BuildMemberListCodedValue.cs:76
	    // Methods                                                                                                                             // BuildMemberListCodedValue.cs:77
	                                                                                                                                           // BuildMemberListCodedValue.cs:126
	    /// <summary>
	    /// Append item to end of list
	    /// </summary>
	    public void AppendQuantity(Quantity value)                                                                                             // BuildMemberListCodedValue.cs:130
	    {                                                                                                                                      // BuildMemberListCodedValue.cs:131
	        this.RawItems.Add(value);                                                                                                          // BuildMemberListCodedValue.cs:132
	    }                                                                                                                                      // BuildMemberListCodedValue.cs:133
	                                                                                                                                           // BuildMemberListCodedValue.cs:126
	    /// <summary>
	    /// Append item to end of list
	    /// </summary>
	    public void AppendRange(Quantity value)                                                                                                // BuildMemberListCodedValue.cs:130
	    {                                                                                                                                      // BuildMemberListCodedValue.cs:131
	        this.RawItems.Add(value);                                                                                                          // BuildMemberListCodedValue.cs:132
	    }                                                                                                                                      // BuildMemberListCodedValue.cs:133
	                                                                                                                                           // BuildMemberListCodedValue.cs:79
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public ObsSize_Accessor(BreastRadiologyDocument doc) : base("ObsSize_Accessor")                                                        // BuildMemberListCodedValue.cs:83
	    {                                                                                                                                      // BuildMemberListCodedValue.cs:84
	        this.Init(doc, 0, 3, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes", "obsSize"));  // BuildMemberListCodedValue.cs:85
	    }                                                                                                                                      // BuildMemberListCodedValue.cs:87
	}                                                                                                                                          // BuildMemberListCodedValue.cs:88
	//- LocalClassDefs
}
