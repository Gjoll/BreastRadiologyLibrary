using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.ObservationLocal;

namespace BreastRadLib.AbnormalityDuctLocal
{
	//+ LocalClassDefs
	/// <summary>
	/// Accessor class for 'ductType'
	/// [Fhir Element 'Observation.component:ductType]'
	/// </summary>
	public class DuctType_Accessor : MemberListCodedValue<CodeableConcept>                                                                     // BuildMemberListCodedValue.cs:51
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
	    /// Set DuctType value
	    /// </summary>
	    public void Set(AbnormalityDuctTypeVS.TCoding value) => this.SetFirst(value);                                                          // BuildMemberListCodedValue.cs:81
	                                                                                                                                           // BuildMemberListCodedValue.cs:58
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public DuctType_Accessor(BreastRadiologyDocument doc) : base("DuctType_Accessor")                                                      // BuildMemberListCodedValue.cs:62
	    {                                                                                                                                      // BuildMemberListCodedValue.cs:63
	        this.Init(doc, 0, 1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes", "abnormalityDuctType"));// BuildMemberListCodedValue.cs:64
	    }                                                                                                                                      // BuildMemberListCodedValue.cs:66
	}                                                                                                                                          // BuildMemberListCodedValue.cs:67
	//- LocalClassDefs
}
