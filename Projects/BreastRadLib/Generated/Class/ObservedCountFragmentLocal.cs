using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.ObservationLocal;

namespace BreastRadLib.ObservedCountFragmentLocal
{
	//+ LocalClassDefs
	/// <summary>
	/// Accessor class for 'obsCount'
	/// [Fhir Element 'Observation.component:obsCount]'
	/// </summary>
	public class ObsCount_Accessor : ObservationLocal.ComponentBase<Element>                                                                   // CSDefineObservation.cs:66
	{                                                                                                                                          // CSDefineObservation.cs:67
	    // Properties                                                                                                                          // CSDefineObservation.cs:68
	    /// <summary>
	    /// get {propertyName} value
	    /// </summary>
	    public Element Get() => base.FirstOrDefault();                                                                                         // CSDefineObservation.cs:105
	                                                                                                                                           // CSDefineObservation.cs:70
	    // Methods                                                                                                                             // CSDefineObservation.cs:71
	                                                                                                                                           // CSDefineObservation.cs:92
	    /// <summary>
	    /// Set ObsCount value
	    /// </summary>
	    public void SetQuantity(Quantity value) => this.SetFirst(value);                                                                       // CSDefineObservation.cs:96
	                                                                                                                                           // CSDefineObservation.cs:92
	    /// <summary>
	    /// Set ObsCount value
	    /// </summary>
	    public void SetRange(Quantity value) => this.SetFirst(value);                                                                          // CSDefineObservation.cs:96
	                                                                                                                                           // CSDefineObservation.cs:73
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public ObsCount_Accessor(BreastRadiologyDocument doc) : base()                                                                         // CSDefineObservation.cs:77
	    {                                                                                                                                      // CSDefineObservation.cs:78
	        this.Init(doc, 0, 1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes", "obsCount")); // CSDefineObservation.cs:79
	    }                                                                                                                                      // CSDefineObservation.cs:81
	}                                                                                                                                          // CSDefineObservation.cs:82
	//- LocalClassDefs
}
