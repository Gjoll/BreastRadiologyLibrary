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
	public class ObsSize_Accessor : MemberListCodedValue<Element>                                                                              // BuildMemberListCodedValue.cs:51
	{                                                                                                                                          // BuildMemberListCodedValue.cs:52
	    // Properties                                                                                                                          // BuildMemberListCodedValue.cs:53
	    /// <summary>
	    /// Access propertyName
	    /// </summary>
	    public IEnumerable<Element> All() => this.items;                                                                                       // BuildMemberListCodedValue.cs:118
	                                                                                                                                           // BuildMemberListCodedValue.cs:120
	    /// <summary>
	    /// Access item at indicated location in list
	    /// </summary>
	    public Element At(Int32 i) => base.items[i];                                                                                           // BuildMemberListCodedValue.cs:124
	                                                                                                                                           // BuildMemberListCodedValue.cs:126
	    /// <summary>
	    /// Access first item in list
	    /// </summary>
	    public new Element First() => base.First();                                                                                            // BuildMemberListCodedValue.cs:130
	                                                                                                                                           // BuildMemberListCodedValue.cs:131
	    /// <summary>
	    /// Access first item in list or default value if empty
	    /// </summary>
	    public new Element FirstOrDefault() => base.FirstOrDefault();                                                                          // BuildMemberListCodedValue.cs:135
	                                                                                                                                           // BuildMemberListCodedValue.cs:55
	    // Methods                                                                                                                             // BuildMemberListCodedValue.cs:56
	                                                                                                                                           // BuildMemberListCodedValue.cs:105
	    /// <summary>
	    /// Append item to end of list
	    /// </summary>
	    public void AppendQuantity(Quantity value) => this.RawItems.Add(value);                                                                // BuildMemberListCodedValue.cs:109
	                                                                                                                                           // BuildMemberListCodedValue.cs:105
	    /// <summary>
	    /// Append item to end of list
	    /// </summary>
	    public void AppendRange(Quantity value) => this.RawItems.Add(value);                                                                   // BuildMemberListCodedValue.cs:109
	                                                                                                                                           // BuildMemberListCodedValue.cs:58
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public ObsSize_Accessor(BreastRadiologyDocument doc) : base("ObsSize_Accessor")                                                        // BuildMemberListCodedValue.cs:62
	    {                                                                                                                                      // BuildMemberListCodedValue.cs:63
	        this.Init(doc, 0, 3, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes", "obsSize"));  // BuildMemberListCodedValue.cs:64
	    }                                                                                                                                      // BuildMemberListCodedValue.cs:66
	}                                                                                                                                          // BuildMemberListCodedValue.cs:67
	//- LocalClassDefs
}
