using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.ObservationLocal;

namespace BreastRadLib.MGAbnormalityCalcificationLocal
{
	//+ LocalClassDefs
	/// <summary>
	/// Accessor class for 'calcificationType'
	/// [Fhir Element 'Observation.component:calcificationType]'
	/// </summary>
	public class CalcificationType_Accessor : ObservationLocal.ComponentBase<CodeableConcept>                                                  // CSDefineObservation.cs:66
	{                                                                                                                                          // CSDefineObservation.cs:67
	    // Properties                                                                                                                          // CSDefineObservation.cs:68
	    /// <summary>
	    /// get {propertyName} value
	    /// </summary>
	    public CodeableConcept Get() => base.FirstOrDefault();                                                                                 // CSDefineObservation.cs:105
	                                                                                                                                           // CSDefineObservation.cs:70
	    // Methods                                                                                                                             // CSDefineObservation.cs:71
	                                                                                                                                           // CSDefineObservation.cs:92
	    /// <summary>
	    /// Set CalcificationType value
	    /// </summary>
	    public void Set(MammoCalcificationTypeVS.TCoding value) => this.SetFirst(value);                                                       // CSDefineObservation.cs:96
	                                                                                                                                           // CSDefineObservation.cs:73
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public CalcificationType_Accessor(BreastRadiologyDocument doc) : base("CalcificationType_Accessor")                                    // CSDefineObservation.cs:77
	    {                                                                                                                                      // CSDefineObservation.cs:78
	        this.Init(doc, 0, 1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes", "mgCalcificationType"));// CSDefineObservation.cs:79
	    }                                                                                                                                      // CSDefineObservation.cs:81
	}                                                                                                                                          // CSDefineObservation.cs:82
	/// <summary>
	/// Accessor class for 'calcificationDistribution'
	/// [Fhir Element 'Observation.component:calcificationDistribution]'
	/// </summary>
	public class CalcificationDistribution_Accessor : ObservationLocal.ComponentBase<CodeableConcept>                                          // CSDefineObservation.cs:66
	{                                                                                                                                          // CSDefineObservation.cs:67
	    // Properties                                                                                                                          // CSDefineObservation.cs:68
	    /// <summary>
	    /// get {propertyName} value
	    /// </summary>
	    public CodeableConcept Get() => base.FirstOrDefault();                                                                                 // CSDefineObservation.cs:105
	                                                                                                                                           // CSDefineObservation.cs:70
	    // Methods                                                                                                                             // CSDefineObservation.cs:71
	                                                                                                                                           // CSDefineObservation.cs:92
	    /// <summary>
	    /// Set CalcificationDistribution value
	    /// </summary>
	    public void Set(CalcificationDistributionVS.TCoding value) => this.SetFirst(value);                                                    // CSDefineObservation.cs:96
	                                                                                                                                           // CSDefineObservation.cs:73
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public CalcificationDistribution_Accessor(BreastRadiologyDocument doc) : base("CalcificationDistribution_Accessor")                    // CSDefineObservation.cs:77
	    {                                                                                                                                      // CSDefineObservation.cs:78
	        this.Init(doc, 0, 1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes", "mgCalcificationDistribution"));// CSDefineObservation.cs:79
	    }                                                                                                                                      // CSDefineObservation.cs:81
	}                                                                                                                                          // CSDefineObservation.cs:82
	//- LocalClassDefs
}
