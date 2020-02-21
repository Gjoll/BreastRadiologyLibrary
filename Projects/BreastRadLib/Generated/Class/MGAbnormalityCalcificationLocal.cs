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
	public class CalcificationType_Accessor : MemberListCodedValueBase<CodeableConcept>                                                        // CSBuildMemberListCodedValue.cs:64
	{                                                                                                                                          // CSBuildMemberListCodedValue.cs:65
	    // Properties                                                                                                                          // CSBuildMemberListCodedValue.cs:66
	    /// <summary>
	    /// get {propertyName} value
	    /// </summary>
	    public CodeableConcept Get() => base.FirstOrDefault();                                                                                 // CSBuildMemberListCodedValue.cs:103
	                                                                                                                                           // CSBuildMemberListCodedValue.cs:68
	    // Methods                                                                                                                             // CSBuildMemberListCodedValue.cs:69
	                                                                                                                                           // CSBuildMemberListCodedValue.cs:90
	    /// <summary>
	    /// Set CalcificationType value
	    /// </summary>
	    public void Set(MammoCalcificationTypeVS.TCoding value) => this.SetFirst(value);                                                       // CSBuildMemberListCodedValue.cs:94
	                                                                                                                                           // CSBuildMemberListCodedValue.cs:71
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public CalcificationType_Accessor(BreastRadiologyDocument doc) : base("CalcificationType_Accessor")                                    // CSBuildMemberListCodedValue.cs:75
	    {                                                                                                                                      // CSBuildMemberListCodedValue.cs:76
	        this.Init(doc, 0, 1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes", "mgCalcificationType"));// CSBuildMemberListCodedValue.cs:77
	    }                                                                                                                                      // CSBuildMemberListCodedValue.cs:79
	}                                                                                                                                          // CSBuildMemberListCodedValue.cs:80
	/// <summary>
	/// Accessor class for 'calcificationDistribution'
	/// [Fhir Element 'Observation.component:calcificationDistribution]'
	/// </summary>
	public class CalcificationDistribution_Accessor : MemberListCodedValueBase<CodeableConcept>                                                // CSBuildMemberListCodedValue.cs:64
	{                                                                                                                                          // CSBuildMemberListCodedValue.cs:65
	    // Properties                                                                                                                          // CSBuildMemberListCodedValue.cs:66
	    /// <summary>
	    /// get {propertyName} value
	    /// </summary>
	    public CodeableConcept Get() => base.FirstOrDefault();                                                                                 // CSBuildMemberListCodedValue.cs:103
	                                                                                                                                           // CSBuildMemberListCodedValue.cs:68
	    // Methods                                                                                                                             // CSBuildMemberListCodedValue.cs:69
	                                                                                                                                           // CSBuildMemberListCodedValue.cs:90
	    /// <summary>
	    /// Set CalcificationDistribution value
	    /// </summary>
	    public void Set(CalcificationDistributionVS.TCoding value) => this.SetFirst(value);                                                    // CSBuildMemberListCodedValue.cs:94
	                                                                                                                                           // CSBuildMemberListCodedValue.cs:71
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public CalcificationDistribution_Accessor(BreastRadiologyDocument doc) : base("CalcificationDistribution_Accessor")                    // CSBuildMemberListCodedValue.cs:75
	    {                                                                                                                                      // CSBuildMemberListCodedValue.cs:76
	        this.Init(doc, 0, 1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes", "mgCalcificationDistribution"));// CSBuildMemberListCodedValue.cs:77
	    }                                                                                                                                      // CSBuildMemberListCodedValue.cs:79
	}                                                                                                                                          // CSBuildMemberListCodedValue.cs:80
	//- LocalClassDefs
}
