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
	public class ObsSize_Accessor : ObservationLocal.ComponentBase<Element>                                                                    // CSDefineObservation.cs:66
	{                                                                                                                                          // CSDefineObservation.cs:67
	    // Properties                                                                                                                          // CSDefineObservation.cs:68
	    /// <summary>
	    /// Access propertyName
	    /// </summary>
	    public IEnumerable<Element> All() => this.items;                                                                                       // CSDefineObservation.cs:136
	                                                                                                                                           // CSDefineObservation.cs:138
	    /// <summary>
	    /// Access item at indicated location in list
	    /// </summary>
	    public Element At(Int32 i) => base.items[i];                                                                                           // CSDefineObservation.cs:142
	                                                                                                                                           // CSDefineObservation.cs:144
	    /// <summary>
	    /// Access first item in list
	    /// </summary>
	    public new Element First() => base.First();                                                                                            // CSDefineObservation.cs:148
	                                                                                                                                           // CSDefineObservation.cs:149
	    /// <summary>
	    /// Access first item in list or default value if empty
	    /// </summary>
	    public new Element FirstOrDefault() => base.FirstOrDefault();                                                                          // CSDefineObservation.cs:153
	                                                                                                                                           // CSDefineObservation.cs:70
	    // Methods                                                                                                                             // CSDefineObservation.cs:71
	                                                                                                                                           // CSDefineObservation.cs:120
	    /// <summary>
	    /// Append item to end of list
	    /// </summary>
	    public void AppendQuantity(Quantity value)                                                                                             // CSDefineObservation.cs:124
	    {                                                                                                                                      // CSDefineObservation.cs:125
	        this.RawItems.Add(value);                                                                                                          // CSDefineObservation.cs:126
	    }                                                                                                                                      // CSDefineObservation.cs:127
	                                                                                                                                           // CSDefineObservation.cs:120
	    /// <summary>
	    /// Append item to end of list
	    /// </summary>
	    public void AppendRange(Quantity value)                                                                                                // CSDefineObservation.cs:124
	    {                                                                                                                                      // CSDefineObservation.cs:125
	        this.RawItems.Add(value);                                                                                                          // CSDefineObservation.cs:126
	    }                                                                                                                                      // CSDefineObservation.cs:127
	                                                                                                                                           // CSDefineObservation.cs:73
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public ObsSize_Accessor(BreastRadiologyDocument doc) : base("ObsSize_Accessor")                                                        // CSDefineObservation.cs:77
	    {                                                                                                                                      // CSDefineObservation.cs:78
	        this.Init(doc, 0, 3, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes", "obsSize"));  // CSDefineObservation.cs:79
	    }                                                                                                                                      // CSDefineObservation.cs:81
	}                                                                                                                                          // CSDefineObservation.cs:82
	//- LocalClassDefs
}
