using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.ObservationLocal;

namespace BreastRadLib.AbnormalityMassLocal
{
	//+ LocalClassDefs
	/// <summary>
	/// Accessor class for 'massType'
	/// [Fhir Element 'Observation.component:massType]'
	/// </summary>
	public class MassType_Accessor : MemberListCodedValueBase<CodeableConcept>                                                                 // CSBuildMemberListCodedValue.cs:69
	{                                                                                                                                          // CSBuildMemberListCodedValue.cs:70
	    // Properties                                                                                                                          // CSBuildMemberListCodedValue.cs:71
	    /// <summary>
	    /// get {propertyName} value
	    /// </summary>
	    public CodeableConcept Get() => base.FirstOrDefault();                                                                                 // CSBuildMemberListCodedValue.cs:108
	                                                                                                                                           // CSBuildMemberListCodedValue.cs:73
	    // Methods                                                                                                                             // CSBuildMemberListCodedValue.cs:74
	                                                                                                                                           // CSBuildMemberListCodedValue.cs:95
	    /// <summary>
	    /// Set MassType value
	    /// </summary>
	    public void Set(MassTypeValueSetVS.TCoding value) => this.SetFirst(value);                                                             // CSBuildMemberListCodedValue.cs:99
	                                                                                                                                           // CSBuildMemberListCodedValue.cs:76
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public MassType_Accessor(BreastRadiologyDocument doc) : base("MassType_Accessor")                                                      // CSBuildMemberListCodedValue.cs:80
	    {                                                                                                                                      // CSBuildMemberListCodedValue.cs:81
	        this.Init(doc, 0, 1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes", "abnormalityMassType"));// CSBuildMemberListCodedValue.cs:82
	    }                                                                                                                                      // CSBuildMemberListCodedValue.cs:84
	}                                                                                                                                          // CSBuildMemberListCodedValue.cs:85
	//- LocalClassDefs
}
