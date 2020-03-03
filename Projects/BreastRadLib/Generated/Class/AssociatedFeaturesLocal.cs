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

namespace BreastRadLib.AssociatedFeaturesLocal
{
	//+ LocalClassDefs
	/// <summary>
	/// Accessor class for slice 'mGAbnormalityArchitecturalDistortion'
	/// [Fhir Element 'Observation.hasMember:mGAbnormalityArchitecturalDistortion]'
	/// </summary>
	public class MGAbnormalityArchitecturalDistortion_Accessor : MemberListReferenceMultiple<MGAbnormalityArchitecturalDistortion>             // BuildMemberListReference.cs:67
	{                                                                                                                                          // BuildMemberListReference.cs:68
	    /// <summary>
	    /// MGAbnormalityArchitecturalDistortion_Accessor class constructor
	    /// </summary>
	    public MGAbnormalityArchitecturalDistortion_Accessor(BreastRadiologyDocument doc) : base("MGAbnormalityArchitecturalDistortion_Accessor")// BuildMemberListReference.cs:73
	    {                                                                                                                                      // BuildMemberListReference.cs:74
	        this.Init(doc, 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityArchitecturalDistortion");         // BuildMemberListReference.cs:75
	    }                                                                                                                                      // BuildMemberListReference.cs:76
	}                                                                                                                                          // BuildMemberListReference.cs:77
	/// <summary>
	/// Accessor class for slice 'mGAbnormalityCalcification'
	/// [Fhir Element 'Observation.hasMember:mGAbnormalityCalcification]'
	/// </summary>
	public class MGAbnormalityCalcification_Accessor : MemberListReferenceMultiple<MGAbnormalityCalcification>                                 // BuildMemberListReference.cs:67
	{                                                                                                                                          // BuildMemberListReference.cs:68
	    /// <summary>
	    /// MGAbnormalityCalcification_Accessor class constructor
	    /// </summary>
	    public MGAbnormalityCalcification_Accessor(BreastRadiologyDocument doc) : base("MGAbnormalityCalcification_Accessor")                  // BuildMemberListReference.cs:73
	    {                                                                                                                                      // BuildMemberListReference.cs:74
	        this.Init(doc, 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityCalcification");                   // BuildMemberListReference.cs:75
	    }                                                                                                                                      // BuildMemberListReference.cs:76
	}                                                                                                                                          // BuildMemberListReference.cs:77
	/// <summary>
	/// Accessor class for slice 'observedFeature'
	/// [Fhir Element 'Observation.hasMember:observedFeature]'
	/// </summary>
	public class ObservedFeature_Accessor : MemberListReferenceMultiple<ObservedFeature>                                                       // BuildMemberListReference.cs:67
	{                                                                                                                                          // BuildMemberListReference.cs:68
	    /// <summary>
	    /// ObservedFeature_Accessor class constructor
	    /// </summary>
	    public ObservedFeature_Accessor(BreastRadiologyDocument doc) : base("ObservedFeature_Accessor")                                        // BuildMemberListReference.cs:73
	    {                                                                                                                                      // BuildMemberListReference.cs:74
	        this.Init(doc, 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/ObservedFeature");                              // BuildMemberListReference.cs:75
	    }                                                                                                                                      // BuildMemberListReference.cs:76
	}                                                                                                                                          // BuildMemberListReference.cs:77
	//- LocalClassDefs
}
