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
	public class BiRadsAssessmentCategory_Accessor : MemberListCodedValueBase<CodeableConcept>                                                 // BuildMemberListCodedValue.cs:64
	{                                                                                                                                          // BuildMemberListCodedValue.cs:65
	    // Properties                                                                                                                          // BuildMemberListCodedValue.cs:66
	    /// <summary>
	    /// get {propertyName} value
	    /// </summary>
	    public CodeableConcept Get() => base.FirstOrDefault();                                                                                 // BuildMemberListCodedValue.cs:103
	                                                                                                                                           // BuildMemberListCodedValue.cs:68
	    // Methods                                                                                                                             // BuildMemberListCodedValue.cs:69
	                                                                                                                                           // BuildMemberListCodedValue.cs:90
	    /// <summary>
	    /// Set BiRadsAssessmentCategory value
	    /// </summary>
	    public void Set(BiRadsAssessmentCategoriesVS.TCoding value) => this.SetFirst(value);                                                   // BuildMemberListCodedValue.cs:94
	                                                                                                                                           // BuildMemberListCodedValue.cs:71
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public BiRadsAssessmentCategory_Accessor(BreastRadiologyDocument doc) : base("BiRadsAssessmentCategory_Accessor")                      // BuildMemberListCodedValue.cs:75
	    {                                                                                                                                      // BuildMemberListCodedValue.cs:76
	        this.Init(doc, 0, 1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes", "targetBiRads"));// BuildMemberListCodedValue.cs:77
	    }                                                                                                                                      // BuildMemberListCodedValue.cs:79
	}                                                                                                                                          // BuildMemberListCodedValue.cs:80
	//- LocalClassDefs
}
