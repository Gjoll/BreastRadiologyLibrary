using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.ObservationLocal;

namespace BreastRadLib.AbnormalityLymphNodeLocal
{
	//+ LocalClassDefs
	/// <summary>
	/// Accessor class for 'lymphNodeType'
	/// [Fhir Element 'Observation.component:lymphNodeType]'
	/// </summary>
	public class LymphNodeType_Accessor : MemberListCodedValue<CodeableConcept>                                                                // BuildMemberListCodedValue.cs:72
	{                                                                                                                                          // BuildMemberListCodedValue.cs:73
	    // Properties                                                                                                                          // BuildMemberListCodedValue.cs:74
	    /// <summary>
	    /// get {propertyName} value
	    /// </summary>
	    public CodeableConcept Get() => base.FirstOrDefault();                                                                                 // BuildMemberListCodedValue.cs:111
	                                                                                                                                           // BuildMemberListCodedValue.cs:76
	    // Methods                                                                                                                             // BuildMemberListCodedValue.cs:77
	                                                                                                                                           // BuildMemberListCodedValue.cs:98
	    /// <summary>
	    /// Set LymphNodeType value
	    /// </summary>
	    public void Set(AbnormalityLymphNodeTypeVS.TCoding value) => this.SetFirst(value);                                                     // BuildMemberListCodedValue.cs:102
	                                                                                                                                           // BuildMemberListCodedValue.cs:79
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public LymphNodeType_Accessor(BreastRadiologyDocument doc) : base("LymphNodeType_Accessor")                                            // BuildMemberListCodedValue.cs:83
	    {                                                                                                                                      // BuildMemberListCodedValue.cs:84
	        this.Init(doc, 0, 1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes", "abnormalityLymphNodeType"));// BuildMemberListCodedValue.cs:85
	    }                                                                                                                                      // BuildMemberListCodedValue.cs:87
	}                                                                                                                                          // BuildMemberListCodedValue.cs:88
	//- LocalClassDefs
}
