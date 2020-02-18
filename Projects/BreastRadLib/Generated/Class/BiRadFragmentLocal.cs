using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.ObservationLocal;

namespace BreastRadLib.BiRadFragmentLocal
{
	//+ LocalClassDefs
	/// <summary>
	/// Accessor class for 'biRadsAssessmentCategory'
	/// [Fhir Element 'Observation.component:biRadsAssessmentCategory]'
	/// </summary>
	public class BiRadsAssessmentCategory_Accessor : ObservationBase.ComponentBase<CodeableConcept>                                            // CSDefineObservation.cs:42
	{                                                                                                                                          // CSDefineObservation.cs:43
	    // Properties                                                                                                                          // CSDefineObservation.cs:44
	    /// <summary>
	    /// get {propertyName} value
	    /// </summary>
	    public CodeableConcept Value => base.GetSingleItem();                                                                                  // CSDefineObservation.cs:67
	                                                                                                                                           // CSDefineObservation.cs:46
	    // Methods                                                                                                                             // CSDefineObservation.cs:47
	                                                                                                                                           // CSDefineObservation.cs:72
	    /// <summary>
	    /// Set BiRadsAssessmentCategory value
	    /// </summary>
	    public void ValueCodeableConcept(CodeableConcept value) => this.SetFirst(value);                                                       // CSDefineObservation.cs:76
	                                                                                                                                           // CSDefineObservation.cs:49
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public BiRadsAssessmentCategory_Accessor(BreastRadiologyDocument doc) : base()                                                         // CSDefineObservation.cs:53
	    {                                                                                                                                      // CSDefineObservation.cs:54
	        this.Create(doc, 1, 1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes", "targetBiRads"));// CSDefineObservation.cs:55
	    }                                                                                                                                      // CSDefineObservation.cs:57
	}                                                                                                                                          // CSDefineObservation.cs:58
	//- LocalClassDefs
}
