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
	public class ObsSize_Accessor : ObservationLocal.ComponentBase<Base>                                                                       // CSDefineObservation.cs:64
	{                                                                                                                                          // CSDefineObservation.cs:65
	    // Properties                                                                                                                          // CSDefineObservation.cs:66
	    /// <summary>
	    /// Access propertyName
	    /// </summary>
	    public IEnumerable<Base> All() => this.items;                                                                                          // CSDefineObservation.cs:134
	                                                                                                                                           // CSDefineObservation.cs:136
	    /// <summary>
	    /// Access item at indicated location in list
	    /// </summary>
	    public Base At(Int32 i) => base.items[i];                                                                                              // CSDefineObservation.cs:140
	                                                                                                                                           // CSDefineObservation.cs:142
	    /// <summary>
	    /// Access first item in list
	    /// </summary>
	    public new Base First() => base.First();                                                                                               // CSDefineObservation.cs:146
	                                                                                                                                           // CSDefineObservation.cs:147
	    /// <summary>
	    /// Access first item in list or default value if empty
	    /// </summary>
	    public new Base FirstOrDefault() => base.FirstOrDefault();                                                                             // CSDefineObservation.cs:151
	                                                                                                                                           // CSDefineObservation.cs:68
	    // Methods                                                                                                                             // CSDefineObservation.cs:69
	                                                                                                                                           // CSDefineObservation.cs:118
	    /// <summary>
	    /// Append item to end of list
	    /// </summary>
	    public void AppendQuantity(Quantity value)                                                                                             // CSDefineObservation.cs:122
	    {                                                                                                                                      // CSDefineObservation.cs:123
	        this.RawItems.Add(value);                                                                                                          // CSDefineObservation.cs:124
	    }                                                                                                                                      // CSDefineObservation.cs:125
	                                                                                                                                           // CSDefineObservation.cs:118
	    /// <summary>
	    /// Append item to end of list
	    /// </summary>
	    public void AppendRange(Quantity value)                                                                                                // CSDefineObservation.cs:122
	    {                                                                                                                                      // CSDefineObservation.cs:123
	        this.RawItems.Add(value);                                                                                                          // CSDefineObservation.cs:124
	    }                                                                                                                                      // CSDefineObservation.cs:125
	                                                                                                                                           // CSDefineObservation.cs:71
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public ObsSize_Accessor(BreastRadiologyDocument doc) : base()                                                                          // CSDefineObservation.cs:75
	    {                                                                                                                                      // CSDefineObservation.cs:76
	        this.Init(doc, 0, 3, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes", "obsSize"));  // CSDefineObservation.cs:77
	    }                                                                                                                                      // CSDefineObservation.cs:79
	}                                                                                                                                          // CSDefineObservation.cs:80
	//- LocalClassDefs
}
