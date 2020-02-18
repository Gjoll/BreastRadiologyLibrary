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
	public class ObsCount_Accessor : ObservationBase.ComponentBase<Base>                                                                       // CSDefineObservation.cs:42
	{                                                                                                                                          // CSDefineObservation.cs:43
	    // Properties                                                                                                                          // CSDefineObservation.cs:44
	    /// <summary>
	    /// get {propertyName} value
	    /// </summary>
	    public Base Value() => base.FirstOrDefault();                                                                                          // CSDefineObservation.cs:67
	                                                                                                                                           // CSDefineObservation.cs:46
	    // Methods                                                                                                                             // CSDefineObservation.cs:47
	                                                                                                                                           // CSDefineObservation.cs:72
	    /// <summary>
	    /// Set ObsCount value
	    /// </summary>
	    public void ValueQuantity(Quantity value) => this.SetFirst(value);                                                                     // CSDefineObservation.cs:76
	                                                                                                                                           // CSDefineObservation.cs:72
	    /// <summary>
	    /// Set ObsCount value
	    /// </summary>
	    public void ValueRange(Range value) => this.SetFirst(value);                                                                           // CSDefineObservation.cs:76
	                                                                                                                                           // CSDefineObservation.cs:49
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public ObsCount_Accessor(BreastRadiologyDocument doc) : base()                                                                         // CSDefineObservation.cs:53
	    {                                                                                                                                      // CSDefineObservation.cs:54
	        this.Init(doc, 1, 1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes", "obsCount")); // CSDefineObservation.cs:55
	    }                                                                                                                                      // CSDefineObservation.cs:57
	}                                                                                                                                          // CSDefineObservation.cs:58
	//- LocalClassDefs
}
