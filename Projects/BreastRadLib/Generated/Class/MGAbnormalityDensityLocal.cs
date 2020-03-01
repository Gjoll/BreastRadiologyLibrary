using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.ObservationLocal;

namespace BreastRadLib.MGAbnormalityDensityLocal
{
	//+ LocalClassDefs
	/// <summary>
	/// Accessor class for 'densityType'
	/// [Fhir Element 'Observation.component:densityType]'
	/// </summary>
	public class DensityType_Accessor : MemberListCodedValue<CodeableConcept>                                                                  // BuildMemberListCodedValue.cs:72
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
	    /// Set DensityType value
	    /// </summary>
	    public void Set(MGAbnormalityDensityTypeVS.TCoding value) => this.SetFirst(value);                                                     // BuildMemberListCodedValue.cs:102
	                                                                                                                                           // BuildMemberListCodedValue.cs:79
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public DensityType_Accessor(BreastRadiologyDocument doc) : base("DensityType_Accessor")                                                // BuildMemberListCodedValue.cs:83
	    {                                                                                                                                      // BuildMemberListCodedValue.cs:84
	        this.Init(doc, 1, 1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes", "mgAbnormalityDensityType"));// BuildMemberListCodedValue.cs:85
	    }                                                                                                                                      // BuildMemberListCodedValue.cs:87
	}                                                                                                                                          // BuildMemberListCodedValue.cs:88
	//- LocalClassDefs
}
