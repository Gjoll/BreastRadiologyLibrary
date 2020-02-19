using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.ObservationLocal;

namespace BreastRadLib.AssociatedFeaturesLocal
{
	//+ LocalClassDefs
	/// <summary>
	/// Accessor class for slice 'mGAbnormalityArchitecturalDistortion'
	/// [Fhir Element 'Observation.hasMember:mGAbnormalityArchitecturalDistortion]'
	/// </summary>
	public class MGAbnormalityArchitecturalDistortion_Accessor : MemberListCodedReferenceMultiple<MGAbnormalityArchitecturalDistortion>        // CSBuildMemberListReference.cs:66
	{                                                                                                                                          // CSBuildMemberListReference.cs:67
	    /// <summary>
	    /// MGAbnormalityArchitecturalDistortion_Accessor class constructor
	    /// </summary>
	    public MGAbnormalityArchitecturalDistortion_Accessor(BreastRadiologyDocument doc) : base("MGAbnormalityArchitecturalDistortion_Accessor")// CSBuildMemberListReference.cs:72
	    {                                                                                                                                      // CSBuildMemberListReference.cs:73
	        this.Init(doc, 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityArchitecturalDistortion");         // CSBuildMemberListReference.cs:74
	    }                                                                                                                                      // CSBuildMemberListReference.cs:75
	}                                                                                                                                          // CSBuildMemberListReference.cs:76
	/// <summary>
	/// Accessor class for slice 'mGAbnormalityCalcification'
	/// [Fhir Element 'Observation.hasMember:mGAbnormalityCalcification]'
	/// </summary>
	public class MGAbnormalityCalcification_Accessor : MemberListCodedReferenceMultiple<MGAbnormalityCalcification>                            // CSBuildMemberListReference.cs:66
	{                                                                                                                                          // CSBuildMemberListReference.cs:67
	    /// <summary>
	    /// MGAbnormalityCalcification_Accessor class constructor
	    /// </summary>
	    public MGAbnormalityCalcification_Accessor(BreastRadiologyDocument doc) : base("MGAbnormalityCalcification_Accessor")                  // CSBuildMemberListReference.cs:72
	    {                                                                                                                                      // CSBuildMemberListReference.cs:73
	        this.Init(doc, 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityCalcification");                   // CSBuildMemberListReference.cs:74
	    }                                                                                                                                      // CSBuildMemberListReference.cs:75
	}                                                                                                                                          // CSBuildMemberListReference.cs:76
	/// <summary>
	/// Accessor class for slice 'observedFeature'
	/// [Fhir Element 'Observation.hasMember:observedFeature]'
	/// </summary>
	public class ObservedFeature_Accessor : MemberListCodedReferenceMultiple<ObservedFeature>                                                  // CSBuildMemberListReference.cs:66
	{                                                                                                                                          // CSBuildMemberListReference.cs:67
	    /// <summary>
	    /// ObservedFeature_Accessor class constructor
	    /// </summary>
	    public ObservedFeature_Accessor(BreastRadiologyDocument doc) : base("ObservedFeature_Accessor")                                        // CSBuildMemberListReference.cs:72
	    {                                                                                                                                      // CSBuildMemberListReference.cs:73
	        this.Init(doc, 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/ObservedFeature");                              // CSBuildMemberListReference.cs:74
	    }                                                                                                                                      // CSBuildMemberListReference.cs:75
	}                                                                                                                                          // CSBuildMemberListReference.cs:76
	//- LocalClassDefs
}
