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
	public class BiRadsAssessmentCategory_Accessor : MemberListCodedValueBase<CodeableConcept>                                                 // CSBuildMemberListCodedValue.cs:65
	{                                                                                                                                          // CSBuildMemberListCodedValue.cs:66
	    // Properties                                                                                                                          // CSBuildMemberListCodedValue.cs:67
	    /// <summary>
	    /// get {propertyName} value
	    /// </summary>
	    public CodeableConcept Get() => base.FirstOrDefault();                                                                                 // CSBuildMemberListCodedValue.cs:104
	                                                                                                                                           // CSBuildMemberListCodedValue.cs:69
	    // Methods                                                                                                                             // CSBuildMemberListCodedValue.cs:70
	                                                                                                                                           // CSBuildMemberListCodedValue.cs:91
	    /// <summary>
	    /// Set BiRadsAssessmentCategory value
	    /// </summary>
	    public void Set(BiRadsAssessmentCategoriesVS.TCoding value) => this.SetFirst(value);                                                   // CSBuildMemberListCodedValue.cs:95
	                                                                                                                                           // CSBuildMemberListCodedValue.cs:72
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public BiRadsAssessmentCategory_Accessor(BreastRadiologyDocument doc) : base("BiRadsAssessmentCategory_Accessor")                      // CSBuildMemberListCodedValue.cs:76
	    {                                                                                                                                      // CSBuildMemberListCodedValue.cs:77
	        this.Init(doc, 0, 1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes", "targetBiRads"));// CSBuildMemberListCodedValue.cs:78
	    }                                                                                                                                      // CSBuildMemberListCodedValue.cs:80
	}                                                                                                                                          // CSBuildMemberListCodedValue.cs:81
	//- LocalClassDefs
}
