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
	public class AbnormalityCyst_Accessor : MemberListReferenceMultiple<AbnormalityCyst>                                                       // BuildMemberListReference.cs:67
	{                                                                                                                                          // BuildMemberListReference.cs:68
	    /// <summary>
	    /// AbnormalityCyst_Accessor class constructor
	    /// </summary>
	    public AbnormalityCyst_Accessor(BreastRadiologyDocument doc) : base("AbnormalityCyst_Accessor")                                        // BuildMemberListReference.cs:73
	    {                                                                                                                                      // BuildMemberListReference.cs:74
	        this.Init(doc, 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityCyst");                              // BuildMemberListReference.cs:75
	    }                                                                                                                                      // BuildMemberListReference.cs:76
	}                                                                                                                                          // BuildMemberListReference.cs:77
	/// <summary>
	/// Accessor class for slice 'abnormalityDuct'
	/// [Fhir Element 'Observation.hasMember:abnormalityDuct]'
	/// </summary>
	public class AbnormalityDuct_Accessor : MemberListReferenceMultiple<AbnormalityDuct>                                                       // BuildMemberListReference.cs:67
	{                                                                                                                                          // BuildMemberListReference.cs:68
	    /// <summary>
	    /// AbnormalityDuct_Accessor class constructor
	    /// </summary>
	    public AbnormalityDuct_Accessor(BreastRadiologyDocument doc) : base("AbnormalityDuct_Accessor")                                        // BuildMemberListReference.cs:73
	    {                                                                                                                                      // BuildMemberListReference.cs:74
	        this.Init(doc, 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityDuct");                              // BuildMemberListReference.cs:75
	    }                                                                                                                                      // BuildMemberListReference.cs:76
	}                                                                                                                                          // BuildMemberListReference.cs:77
	/// <summary>
	/// Accessor class for slice 'abnormalityForeignObject'
	/// [Fhir Element 'Observation.hasMember:abnormalityForeignObject]'
	/// </summary>
	public class AbnormalityForeignObject_Accessor : MemberListReferenceMultiple<AbnormalityForeignObject>                                     // BuildMemberListReference.cs:67
	{                                                                                                                                          // BuildMemberListReference.cs:68
	    /// <summary>
	    /// AbnormalityForeignObject_Accessor class constructor
	    /// </summary>
	    public AbnormalityForeignObject_Accessor(BreastRadiologyDocument doc) : base("AbnormalityForeignObject_Accessor")                      // BuildMemberListReference.cs:73
	    {                                                                                                                                      // BuildMemberListReference.cs:74
	        this.Init(doc, 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityForeignObject");                     // BuildMemberListReference.cs:75
	    }                                                                                                                                      // BuildMemberListReference.cs:76
	}                                                                                                                                          // BuildMemberListReference.cs:77
	/// <summary>
	/// Accessor class for slice 'abnormalityLymphNode'
	/// [Fhir Element 'Observation.hasMember:abnormalityLymphNode]'
	/// </summary>
	public class AbnormalityLymphNode_Accessor : MemberListReferenceMultiple<AbnormalityLymphNode>                                             // BuildMemberListReference.cs:67
	{                                                                                                                                          // BuildMemberListReference.cs:68
	    /// <summary>
	    /// AbnormalityLymphNode_Accessor class constructor
	    /// </summary>
	    public AbnormalityLymphNode_Accessor(BreastRadiologyDocument doc) : base("AbnormalityLymphNode_Accessor")                              // BuildMemberListReference.cs:73
	    {                                                                                                                                      // BuildMemberListReference.cs:74
	        this.Init(doc, 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityLymphNode");                         // BuildMemberListReference.cs:75
	    }                                                                                                                                      // BuildMemberListReference.cs:76
	}                                                                                                                                          // BuildMemberListReference.cs:77
	/// <summary>
	/// Accessor class for slice 'abnormalityMass'
	/// [Fhir Element 'Observation.hasMember:abnormalityMass]'
	/// </summary>
	public class AbnormalityMass_Accessor : MemberListReferenceMultiple<AbnormalityMass>                                                       // BuildMemberListReference.cs:67
	{                                                                                                                                          // BuildMemberListReference.cs:68
	    /// <summary>
	    /// AbnormalityMass_Accessor class constructor
	    /// </summary>
	    public AbnormalityMass_Accessor(BreastRadiologyDocument doc) : base("AbnormalityMass_Accessor")                                        // BuildMemberListReference.cs:73
	    {                                                                                                                                      // BuildMemberListReference.cs:74
	        this.Init(doc, 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityMass");                              // BuildMemberListReference.cs:75
	    }                                                                                                                                      // BuildMemberListReference.cs:76
	}                                                                                                                                          // BuildMemberListReference.cs:77
	/// <summary>
	/// Accessor class for slice 'associatedFeatures'
	/// [Fhir Element 'Observation.hasMember:associatedFeatures]'
	/// </summary>
	public class AssociatedFeatures_Accessor : MemberListReferenceMultiple<AssociatedFeatures>                                                 // BuildMemberListReference.cs:67
	{                                                                                                                                          // BuildMemberListReference.cs:68
	    /// <summary>
	    /// AssociatedFeatures_Accessor class constructor
	    /// </summary>
	    public AssociatedFeatures_Accessor(BreastRadiologyDocument doc) : base("AssociatedFeatures_Accessor")                                  // BuildMemberListReference.cs:73
	    {                                                                                                                                      // BuildMemberListReference.cs:74
	        this.Init(doc, 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AssociatedFeatures");                           // BuildMemberListReference.cs:75
	    }                                                                                                                                      // BuildMemberListReference.cs:76
	}                                                                                                                                          // BuildMemberListReference.cs:77
	/// <summary>
	/// Accessor class for slice 'abnormalityFibroadenoma'
	/// [Fhir Element 'Observation.hasMember:abnormalityFibroadenoma]'
	/// </summary>
	public class AbnormalityFibroadenoma_Accessor : MemberListReferenceMultiple<AbnormalityFibroadenoma>                                       // BuildMemberListReference.cs:67
	{                                                                                                                                          // BuildMemberListReference.cs:68
	    /// <summary>
	    /// AbnormalityFibroadenoma_Accessor class constructor
	    /// </summary>
	    public AbnormalityFibroadenoma_Accessor(BreastRadiologyDocument doc) : base("AbnormalityFibroadenoma_Accessor")                        // BuildMemberListReference.cs:73
	    {                                                                                                                                      // BuildMemberListReference.cs:74
	        this.Init(doc, 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityFibroadenoma");                      // BuildMemberListReference.cs:75
	    }                                                                                                                                      // BuildMemberListReference.cs:76
	}                                                                                                                                          // BuildMemberListReference.cs:77
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
	/// Accessor class for slice 'mGAbnormalityAsymmetry'
	/// [Fhir Element 'Observation.hasMember:mGAbnormalityAsymmetry]'
	/// </summary>
	public class MGAbnormalityAsymmetry_Accessor : MemberListReferenceMultiple<MGAbnormalityAsymmetry>                                         // BuildMemberListReference.cs:67
	{                                                                                                                                          // BuildMemberListReference.cs:68
	    /// <summary>
	    /// MGAbnormalityAsymmetry_Accessor class constructor
	    /// </summary>
	    public MGAbnormalityAsymmetry_Accessor(BreastRadiologyDocument doc) : base("MGAbnormalityAsymmetry_Accessor")                          // BuildMemberListReference.cs:73
	    {                                                                                                                                      // BuildMemberListReference.cs:74
	        this.Init(doc, 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityAsymmetry");                       // BuildMemberListReference.cs:75
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
	/// Accessor class for slice 'mGAbnormalityDensity'
	/// [Fhir Element 'Observation.hasMember:mGAbnormalityDensity]'
	/// </summary>
	public class MGAbnormalityDensity_Accessor : MemberListReferenceMultiple<MGAbnormalityDensity>                                             // BuildMemberListReference.cs:67
	{                                                                                                                                          // BuildMemberListReference.cs:68
	    /// <summary>
	    /// MGAbnormalityDensity_Accessor class constructor
	    /// </summary>
	    public MGAbnormalityDensity_Accessor(BreastRadiologyDocument doc) : base("MGAbnormalityDensity_Accessor")                              // BuildMemberListReference.cs:73
	    {                                                                                                                                      // BuildMemberListReference.cs:74
	        this.Init(doc, 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityDensity");                         // BuildMemberListReference.cs:75
	    }                                                                                                                                      // BuildMemberListReference.cs:76
	}                                                                                                                                          // BuildMemberListReference.cs:77
	/// <summary>
	/// Accessor class for slice 'mGAbnormalityFatNecrosis'
	/// [Fhir Element 'Observation.hasMember:mGAbnormalityFatNecrosis]'
	/// </summary>
	public class MGAbnormalityFatNecrosis_Accessor : MemberListReferenceMultiple<MGAbnormalityFatNecrosis>                                     // BuildMemberListReference.cs:67
	{                                                                                                                                          // BuildMemberListReference.cs:68
	    /// <summary>
	    /// MGAbnormalityFatNecrosis_Accessor class constructor
	    /// </summary>
	    public MGAbnormalityFatNecrosis_Accessor(BreastRadiologyDocument doc) : base("MGAbnormalityFatNecrosis_Accessor")                      // BuildMemberListReference.cs:73
	    {                                                                                                                                      // BuildMemberListReference.cs:74
	        this.Init(doc, 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityFatNecrosis");                     // BuildMemberListReference.cs:75
	    }                                                                                                                                      // BuildMemberListReference.cs:76
	}                                                                                                                                          // BuildMemberListReference.cs:77
	/// <summary>
	/// Accessor class for slice 'mGBreastDensity'
	/// [Fhir Element 'Observation.hasMember:mGBreastDensity]'
	/// </summary>
	public class MGBreastDensity_Accessor : MemberListReferenceSingle<MGBreastDensity>                                                         // BuildMemberListReference.cs:51
	{                                                                                                                                          // BuildMemberListReference.cs:52
	    /// <summary>
	    /// MGBreastDensity_Accessor class constructor
	    /// </summary>
	    public MGBreastDensity_Accessor(BreastRadiologyDocument doc) : base("MGBreastDensity_Accessor")                                        // BuildMemberListReference.cs:57
	    {                                                                                                                                      // BuildMemberListReference.cs:58
	        this.Init(doc, 1, 1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGBreastDensity");                               // BuildMemberListReference.cs:59
	    }                                                                                                                                      // BuildMemberListReference.cs:60
	}                                                                                                                                          // BuildMemberListReference.cs:61
	//- LocalClassDefs
}
