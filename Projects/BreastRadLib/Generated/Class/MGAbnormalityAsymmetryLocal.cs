using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.ObservationLocal;

namespace BreastRadLib.MGAbnormalityAsymmetryLocal
{
	//+ LocalClassDefs
	/// <summary>
	/// Accessor class for 'asymmetryType'
	/// [Fhir Element 'Observation.component:asymmetryType]'
	/// </summary>
	public class AsymmetryType_Accessor : ObservationLocal.ComponentBase<CodeableConcept>                                                      // CSDefineObservation.cs:64
	{                                                                                                                                          // CSDefineObservation.cs:65
	    // Properties                                                                                                                          // CSDefineObservation.cs:66
	    /// <summary>
	    /// get {propertyName} value
	    /// </summary>
	    public CodeableConcept Get() => base.FirstOrDefault();                                                                                 // CSDefineObservation.cs:103
	                                                                                                                                           // CSDefineObservation.cs:68
	    // Methods                                                                                                                             // CSDefineObservation.cs:69
	                                                                                                                                           // CSDefineObservation.cs:90
	    /// <summary>
	    /// Set AsymmetryType value
	    /// </summary>
	    public void Set(CodeableConcept value) => this.SetFirst(value);                                                                        // CSDefineObservation.cs:94
	                                                                                                                                           // CSDefineObservation.cs:71
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public AsymmetryType_Accessor(BreastRadiologyDocument doc) : base()                                                                    // CSDefineObservation.cs:75
	    {                                                                                                                                      // CSDefineObservation.cs:76
	        this.Init(doc, 0, 1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes", "mgAbnormalityAsymmetryType"));// CSDefineObservation.cs:77
	    }                                                                                                                                      // CSDefineObservation.cs:79
	}                                                                                                                                          // CSDefineObservation.cs:80
	//- LocalClassDefs
}
