using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.ObservationLocal;
//+Usings
//-Usings

namespace BreastRadLib.AbnormalityForeignObjectLocal
{
	//+ LocalClassDefs
	/// <summary>
	/// Accessor class for 'abnormalityForeignObjectType'
	/// [Fhir Element 'Observation.component:abnormalityForeignObjectType]'
	/// </summary>
	public class AbnormalityForeignObjectType_Accessor : MemberListCodedValue<CodeableConcept>                                                 // BuildMemberListCodedValue.cs:51
	{                                                                                                                                          // BuildMemberListCodedValue.cs:52
	    // Properties                                                                                                                          // BuildMemberListCodedValue.cs:53
	    /// <summary>
	    /// get {propertyName} value
	    /// </summary>
	    public CodeableConcept Get() => base.FirstOrDefault();                                                                                 // BuildMemberListCodedValue.cs:90
	                                                                                                                                           // BuildMemberListCodedValue.cs:55
	    // Methods                                                                                                                             // BuildMemberListCodedValue.cs:56
	                                                                                                                                           // BuildMemberListCodedValue.cs:77
	    /// <summary>
	    /// Set AbnormalityForeignObjectType value
	    /// </summary>
	    public void Set(ForeignObjectVS.TCoding value) => this.SetFirst(value);                                                                // BuildMemberListCodedValue.cs:81
	                                                                                                                                           // BuildMemberListCodedValue.cs:58
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public AbnormalityForeignObjectType_Accessor(BreastRadiologyDocument doc) : base("AbnormalityForeignObjectType_Accessor")              // BuildMemberListCodedValue.cs:62
	    {                                                                                                                                      // BuildMemberListCodedValue.cs:63
	        this.Init(doc, 1, 1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes", "abnormalityForeignObjectType"));// BuildMemberListCodedValue.cs:64
	    }                                                                                                                                      // BuildMemberListCodedValue.cs:66
	}                                                                                                                                          // BuildMemberListCodedValue.cs:67
	//- LocalClassDefs
}
