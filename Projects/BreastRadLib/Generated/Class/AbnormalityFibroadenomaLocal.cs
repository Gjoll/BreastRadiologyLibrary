using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.ObservationLocal;

namespace BreastRadLib.AbnormalityFibroadenomaLocal
{
	//+ LocalClassDefs
	/// <summary>
	/// Accessor class for 'fibroAdenomaType'
	/// [Fhir Element 'Observation.component:fibroAdenomaType]'
	/// </summary>
	public class FibroAdenomaType_Accessor : MemberListCodedValueBase<CodeableConcept>                                                         // CSBuildMemberListCodedValue.cs:64
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
	    /// Set FibroAdenomaType value
	    /// </summary>
	    public void Set(FibroadenomaVS.TCoding value) => this.SetFirst(value);                                                                 // CSBuildMemberListCodedValue.cs:94
	                                                                                                                                           // CSBuildMemberListCodedValue.cs:71
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public FibroAdenomaType_Accessor(BreastRadiologyDocument doc) : base("FibroAdenomaType_Accessor")                                      // CSBuildMemberListCodedValue.cs:75
	    {                                                                                                                                      // CSBuildMemberListCodedValue.cs:76
	        this.Init(doc, 0, 1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes", "mgAbnormalityFibroAdenomaType"));// CSBuildMemberListCodedValue.cs:77
	    }                                                                                                                                      // CSBuildMemberListCodedValue.cs:79
	}                                                                                                                                          // CSBuildMemberListCodedValue.cs:80
	//- LocalClassDefs
}
