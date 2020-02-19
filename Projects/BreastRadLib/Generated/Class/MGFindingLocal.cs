using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.ObservationLocal;

namespace BreastRadLib.MGFindingLocal
{
	//+ LocalClassDefs
	/// <summary>
	/// Accessor class for slice 'abnormalityCyst'
	/// [Fhir Element 'Observation.hasMember:abnormalityCyst]'
	/// </summary>
	public class AbnormalityCyst_Accessor : MemberListCodedReferenceMultiple<AbnormalityCyst>                                                  // CSBuildMemberListReference.cs:66
	{                                                                                                                                          // CSBuildMemberListReference.cs:67
	    /// <summary>
	    /// AbnormalityCyst_Accessor class constructor
	    /// </summary>
	    public AbnormalityCyst_Accessor(BreastRadiologyDocument doc) : base("AbnormalityCyst_Accessor")                                        // CSBuildMemberListReference.cs:72
	    {                                                                                                                                      // CSBuildMemberListReference.cs:73
	        this.Init(doc, 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityCyst");                              // CSBuildMemberListReference.cs:74
	    }                                                                                                                                      // CSBuildMemberListReference.cs:75
	}                                                                                                                                          // CSBuildMemberListReference.cs:76
	/// <summary>
	/// Accessor class for slice 'abnormalityDuct'
	/// [Fhir Element 'Observation.hasMember:abnormalityDuct]'
	/// </summary>
	public class AbnormalityDuct_Accessor : MemberListCodedReferenceMultiple<AbnormalityDuct>                                                  // CSBuildMemberListReference.cs:66
	{                                                                                                                                          // CSBuildMemberListReference.cs:67
	    /// <summary>
	    /// AbnormalityDuct_Accessor class constructor
	    /// </summary>
	    public AbnormalityDuct_Accessor(BreastRadiologyDocument doc) : base("AbnormalityDuct_Accessor")                                        // CSBuildMemberListReference.cs:72
	    {                                                                                                                                      // CSBuildMemberListReference.cs:73
	        this.Init(doc, 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityDuct");                              // CSBuildMemberListReference.cs:74
	    }                                                                                                                                      // CSBuildMemberListReference.cs:75
	}                                                                                                                                          // CSBuildMemberListReference.cs:76
	/// <summary>
	/// Accessor class for slice 'abnormalityForeignObject'
	/// [Fhir Element 'Observation.hasMember:abnormalityForeignObject]'
	/// </summary>
	public class AbnormalityForeignObject_Accessor : MemberListCodedReferenceMultiple<AbnormalityForeignObject>                                // CSBuildMemberListReference.cs:66
	{                                                                                                                                          // CSBuildMemberListReference.cs:67
	    /// <summary>
	    /// AbnormalityForeignObject_Accessor class constructor
	    /// </summary>
	    public AbnormalityForeignObject_Accessor(BreastRadiologyDocument doc) : base("AbnormalityForeignObject_Accessor")                      // CSBuildMemberListReference.cs:72
	    {                                                                                                                                      // CSBuildMemberListReference.cs:73
	        this.Init(doc, 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityForeignObject");                     // CSBuildMemberListReference.cs:74
	    }                                                                                                                                      // CSBuildMemberListReference.cs:75
	}                                                                                                                                          // CSBuildMemberListReference.cs:76
	/// <summary>
	/// Accessor class for slice 'abnormalityLymphNode'
	/// [Fhir Element 'Observation.hasMember:abnormalityLymphNode]'
	/// </summary>
	public class AbnormalityLymphNode_Accessor : MemberListCodedReferenceMultiple<AbnormalityLymphNode>                                        // CSBuildMemberListReference.cs:66
	{                                                                                                                                          // CSBuildMemberListReference.cs:67
	    /// <summary>
	    /// AbnormalityLymphNode_Accessor class constructor
	    /// </summary>
	    public AbnormalityLymphNode_Accessor(BreastRadiologyDocument doc) : base("AbnormalityLymphNode_Accessor")                              // CSBuildMemberListReference.cs:72
	    {                                                                                                                                      // CSBuildMemberListReference.cs:73
	        this.Init(doc, 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityLymphNode");                         // CSBuildMemberListReference.cs:74
	    }                                                                                                                                      // CSBuildMemberListReference.cs:75
	}                                                                                                                                          // CSBuildMemberListReference.cs:76
	/// <summary>
	/// Accessor class for slice 'abnormalityMass'
	/// [Fhir Element 'Observation.hasMember:abnormalityMass]'
	/// </summary>
	public class AbnormalityMass_Accessor : MemberListCodedReferenceMultiple<AbnormalityMass>                                                  // CSBuildMemberListReference.cs:66
	{                                                                                                                                          // CSBuildMemberListReference.cs:67
	    /// <summary>
	    /// AbnormalityMass_Accessor class constructor
	    /// </summary>
	    public AbnormalityMass_Accessor(BreastRadiologyDocument doc) : base("AbnormalityMass_Accessor")                                        // CSBuildMemberListReference.cs:72
	    {                                                                                                                                      // CSBuildMemberListReference.cs:73
	        this.Init(doc, 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityMass");                              // CSBuildMemberListReference.cs:74
	    }                                                                                                                                      // CSBuildMemberListReference.cs:75
	}                                                                                                                                          // CSBuildMemberListReference.cs:76
	/// <summary>
	/// Accessor class for slice 'associatedFeatures'
	/// [Fhir Element 'Observation.hasMember:associatedFeatures]'
	/// </summary>
	public class AssociatedFeatures_Accessor : MemberListCodedReferenceMultiple<AssociatedFeatures>                                            // CSBuildMemberListReference.cs:66
	{                                                                                                                                          // CSBuildMemberListReference.cs:67
	    /// <summary>
	    /// AssociatedFeatures_Accessor class constructor
	    /// </summary>
	    public AssociatedFeatures_Accessor(BreastRadiologyDocument doc) : base("AssociatedFeatures_Accessor")                                  // CSBuildMemberListReference.cs:72
	    {                                                                                                                                      // CSBuildMemberListReference.cs:73
	        this.Init(doc, 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AssociatedFeatures");                           // CSBuildMemberListReference.cs:74
	    }                                                                                                                                      // CSBuildMemberListReference.cs:75
	}                                                                                                                                          // CSBuildMemberListReference.cs:76
	/// <summary>
	/// Accessor class for slice 'abnormalityFibroadenoma'
	/// [Fhir Element 'Observation.hasMember:abnormalityFibroadenoma]'
	/// </summary>
	public class AbnormalityFibroadenoma_Accessor : MemberListCodedReferenceMultiple<AbnormalityFibroadenoma>                                  // CSBuildMemberListReference.cs:66
	{                                                                                                                                          // CSBuildMemberListReference.cs:67
	    /// <summary>
	    /// AbnormalityFibroadenoma_Accessor class constructor
	    /// </summary>
	    public AbnormalityFibroadenoma_Accessor(BreastRadiologyDocument doc) : base("AbnormalityFibroadenoma_Accessor")                        // CSBuildMemberListReference.cs:72
	    {                                                                                                                                      // CSBuildMemberListReference.cs:73
	        this.Init(doc, 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityFibroadenoma");                      // CSBuildMemberListReference.cs:74
	    }                                                                                                                                      // CSBuildMemberListReference.cs:75
	}                                                                                                                                          // CSBuildMemberListReference.cs:76
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
	/// Accessor class for slice 'mGAbnormalityAsymmetry'
	/// [Fhir Element 'Observation.hasMember:mGAbnormalityAsymmetry]'
	/// </summary>
	public class MGAbnormalityAsymmetry_Accessor : MemberListCodedReferenceMultiple<MGAbnormalityAsymmetry>                                    // CSBuildMemberListReference.cs:66
	{                                                                                                                                          // CSBuildMemberListReference.cs:67
	    /// <summary>
	    /// MGAbnormalityAsymmetry_Accessor class constructor
	    /// </summary>
	    public MGAbnormalityAsymmetry_Accessor(BreastRadiologyDocument doc) : base("MGAbnormalityAsymmetry_Accessor")                          // CSBuildMemberListReference.cs:72
	    {                                                                                                                                      // CSBuildMemberListReference.cs:73
	        this.Init(doc, 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityAsymmetry");                       // CSBuildMemberListReference.cs:74
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
	/// Accessor class for slice 'mGAbnormalityDensity'
	/// [Fhir Element 'Observation.hasMember:mGAbnormalityDensity]'
	/// </summary>
	public class MGAbnormalityDensity_Accessor : MemberListCodedReferenceMultiple<MGAbnormalityDensity>                                        // CSBuildMemberListReference.cs:66
	{                                                                                                                                          // CSBuildMemberListReference.cs:67
	    /// <summary>
	    /// MGAbnormalityDensity_Accessor class constructor
	    /// </summary>
	    public MGAbnormalityDensity_Accessor(BreastRadiologyDocument doc) : base("MGAbnormalityDensity_Accessor")                              // CSBuildMemberListReference.cs:72
	    {                                                                                                                                      // CSBuildMemberListReference.cs:73
	        this.Init(doc, 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityDensity");                         // CSBuildMemberListReference.cs:74
	    }                                                                                                                                      // CSBuildMemberListReference.cs:75
	}                                                                                                                                          // CSBuildMemberListReference.cs:76
	/// <summary>
	/// Accessor class for slice 'mGAbnormalityFatNecrosis'
	/// [Fhir Element 'Observation.hasMember:mGAbnormalityFatNecrosis]'
	/// </summary>
	public class MGAbnormalityFatNecrosis_Accessor : MemberListCodedReferenceMultiple<MGAbnormalityFatNecrosis>                                // CSBuildMemberListReference.cs:66
	{                                                                                                                                          // CSBuildMemberListReference.cs:67
	    /// <summary>
	    /// MGAbnormalityFatNecrosis_Accessor class constructor
	    /// </summary>
	    public MGAbnormalityFatNecrosis_Accessor(BreastRadiologyDocument doc) : base("MGAbnormalityFatNecrosis_Accessor")                      // CSBuildMemberListReference.cs:72
	    {                                                                                                                                      // CSBuildMemberListReference.cs:73
	        this.Init(doc, 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityFatNecrosis");                     // CSBuildMemberListReference.cs:74
	    }                                                                                                                                      // CSBuildMemberListReference.cs:75
	}                                                                                                                                          // CSBuildMemberListReference.cs:76
	/// <summary>
	/// Accessor class for slice 'mGBreastDensity'
	/// [Fhir Element 'Observation.hasMember:mGBreastDensity]'
	/// </summary>
	public class MGBreastDensity_Accessor : MemberListCodedReferenceSingle<MGBreastDensity>                                                    // CSBuildMemberListReference.cs:50
	{                                                                                                                                          // CSBuildMemberListReference.cs:51
	    /// <summary>
	    /// MGBreastDensity_Accessor class constructor
	    /// </summary>
	    public MGBreastDensity_Accessor(BreastRadiologyDocument doc) : base("MGBreastDensity_Accessor")                                        // CSBuildMemberListReference.cs:56
	    {                                                                                                                                      // CSBuildMemberListReference.cs:57
	        this.Init(doc, 1, 1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGBreastDensity");                               // CSBuildMemberListReference.cs:58
	    }                                                                                                                                      // CSBuildMemberListReference.cs:59
	}                                                                                                                                          // CSBuildMemberListReference.cs:60
	//- LocalClassDefs
}
