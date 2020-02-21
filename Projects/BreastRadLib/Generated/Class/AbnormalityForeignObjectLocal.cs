using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.ObservationLocal;

namespace BreastRadLib.AbnormalityForeignObjectLocal
{
	//+ LocalClassDefs
	/// <summary>
	/// Accessor class for 'abnormalityForeignObjectType'
	/// [Fhir Element 'Observation.component:abnormalityForeignObjectType]'
	/// </summary>
	public class AbnormalityForeignObjectType_Accessor : MemberListCodedValueBase<CodeableConcept>                                             // CSBuildMemberListCodedValue.cs:64
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
	    /// Set AbnormalityForeignObjectType value
	    /// </summary>
	    public void Set(ForeignObjectVS.TCoding value) => this.SetFirst(value);                                                                // CSBuildMemberListCodedValue.cs:94
	                                                                                                                                           // CSBuildMemberListCodedValue.cs:71
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public AbnormalityForeignObjectType_Accessor(BreastRadiologyDocument doc) : base("AbnormalityForeignObjectType_Accessor")              // CSBuildMemberListCodedValue.cs:75
	    {                                                                                                                                      // CSBuildMemberListCodedValue.cs:76
	        this.Init(doc, 1, 1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes", "abnormalityForeignObjectType"));// CSBuildMemberListCodedValue.cs:77
	    }                                                                                                                                      // CSBuildMemberListCodedValue.cs:79
	}                                                                                                                                          // CSBuildMemberListCodedValue.cs:80
	//- LocalClassDefs
}
