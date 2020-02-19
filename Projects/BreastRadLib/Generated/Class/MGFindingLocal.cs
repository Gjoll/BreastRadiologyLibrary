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
	public class AbnormalityCyst_Accessor : MemberListCodedReferenceMultiple<AbnormalityCyst>                                                  // CSBuildCodedReferenceList.cs:67
	{                                                                                                                                          // CSBuildCodedReferenceList.cs:68
	    /// <summary>
	    /// AbnormalityCyst_Accessor class constructor
	    /// </summary>
	    public AbnormalityCyst_Accessor(BreastRadiologyDocument doc) : base("AbnormalityCyst_Accessor")                                        // CSBuildCodedReferenceList.cs:73
	    {                                                                                                                                      // CSBuildCodedReferenceList.cs:74
	        this.Init(doc, "", 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityCyst");                          // CSBuildCodedReferenceList.cs:75
	    }                                                                                                                                      // CSBuildCodedReferenceList.cs:76
	}                                                                                                                                          // CSBuildCodedReferenceList.cs:77
	/// <summary>
	/// Accessor class for slice 'abnormalityDuct'
	/// [Fhir Element 'Observation.hasMember:abnormalityDuct]'
	/// </summary>
	public class AbnormalityDuct_Accessor : MemberListCodedReferenceMultiple<AbnormalityDuct>                                                  // CSBuildCodedReferenceList.cs:67
	{                                                                                                                                          // CSBuildCodedReferenceList.cs:68
	    /// <summary>
	    /// AbnormalityDuct_Accessor class constructor
	    /// </summary>
	    public AbnormalityDuct_Accessor(BreastRadiologyDocument doc) : base("AbnormalityDuct_Accessor")                                        // CSBuildCodedReferenceList.cs:73
	    {                                                                                                                                      // CSBuildCodedReferenceList.cs:74
	        this.Init(doc, "", 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityDuct");                          // CSBuildCodedReferenceList.cs:75
	    }                                                                                                                                      // CSBuildCodedReferenceList.cs:76
	}                                                                                                                                          // CSBuildCodedReferenceList.cs:77
	/// <summary>
	/// Accessor class for slice 'abnormalityForeignObject'
	/// [Fhir Element 'Observation.hasMember:abnormalityForeignObject]'
	/// </summary>
	public class AbnormalityForeignObject_Accessor : MemberListCodedReferenceMultiple<AbnormalityForeignObject>                                // CSBuildCodedReferenceList.cs:67
	{                                                                                                                                          // CSBuildCodedReferenceList.cs:68
	    /// <summary>
	    /// AbnormalityForeignObject_Accessor class constructor
	    /// </summary>
	    public AbnormalityForeignObject_Accessor(BreastRadiologyDocument doc) : base("AbnormalityForeignObject_Accessor")                      // CSBuildCodedReferenceList.cs:73
	    {                                                                                                                                      // CSBuildCodedReferenceList.cs:74
	        this.Init(doc, "", 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityForeignObject");                 // CSBuildCodedReferenceList.cs:75
	    }                                                                                                                                      // CSBuildCodedReferenceList.cs:76
	}                                                                                                                                          // CSBuildCodedReferenceList.cs:77
	/// <summary>
	/// Accessor class for slice 'abnormalityLymphNode'
	/// [Fhir Element 'Observation.hasMember:abnormalityLymphNode]'
	/// </summary>
	public class AbnormalityLymphNode_Accessor : MemberListCodedReferenceMultiple<AbnormalityLymphNode>                                        // CSBuildCodedReferenceList.cs:67
	{                                                                                                                                          // CSBuildCodedReferenceList.cs:68
	    /// <summary>
	    /// AbnormalityLymphNode_Accessor class constructor
	    /// </summary>
	    public AbnormalityLymphNode_Accessor(BreastRadiologyDocument doc) : base("AbnormalityLymphNode_Accessor")                              // CSBuildCodedReferenceList.cs:73
	    {                                                                                                                                      // CSBuildCodedReferenceList.cs:74
	        this.Init(doc, "", 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityLymphNode");                     // CSBuildCodedReferenceList.cs:75
	    }                                                                                                                                      // CSBuildCodedReferenceList.cs:76
	}                                                                                                                                          // CSBuildCodedReferenceList.cs:77
	/// <summary>
	/// Accessor class for slice 'abnormalityMass'
	/// [Fhir Element 'Observation.hasMember:abnormalityMass]'
	/// </summary>
	public class AbnormalityMass_Accessor : MemberListCodedReferenceMultiple<AbnormalityMass>                                                  // CSBuildCodedReferenceList.cs:67
	{                                                                                                                                          // CSBuildCodedReferenceList.cs:68
	    /// <summary>
	    /// AbnormalityMass_Accessor class constructor
	    /// </summary>
	    public AbnormalityMass_Accessor(BreastRadiologyDocument doc) : base("AbnormalityMass_Accessor")                                        // CSBuildCodedReferenceList.cs:73
	    {                                                                                                                                      // CSBuildCodedReferenceList.cs:74
	        this.Init(doc, "", 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityMass");                          // CSBuildCodedReferenceList.cs:75
	    }                                                                                                                                      // CSBuildCodedReferenceList.cs:76
	}                                                                                                                                          // CSBuildCodedReferenceList.cs:77
	/// <summary>
	/// Accessor class for slice 'associatedFeatures'
	/// [Fhir Element 'Observation.hasMember:associatedFeatures]'
	/// </summary>
	public class AssociatedFeatures_Accessor : MemberListCodedReferenceMultiple<AssociatedFeatures>                                            // CSBuildCodedReferenceList.cs:67
	{                                                                                                                                          // CSBuildCodedReferenceList.cs:68
	    /// <summary>
	    /// AssociatedFeatures_Accessor class constructor
	    /// </summary>
	    public AssociatedFeatures_Accessor(BreastRadiologyDocument doc) : base("AssociatedFeatures_Accessor")                                  // CSBuildCodedReferenceList.cs:73
	    {                                                                                                                                      // CSBuildCodedReferenceList.cs:74
	        this.Init(doc, "", 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AssociatedFeatures");                       // CSBuildCodedReferenceList.cs:75
	    }                                                                                                                                      // CSBuildCodedReferenceList.cs:76
	}                                                                                                                                          // CSBuildCodedReferenceList.cs:77
	/// <summary>
	/// Accessor class for slice 'abnormalityFibroadenoma'
	/// [Fhir Element 'Observation.hasMember:abnormalityFibroadenoma]'
	/// </summary>
	public class AbnormalityFibroadenoma_Accessor : MemberListCodedReferenceMultiple<AbnormalityFibroadenoma>                                  // CSBuildCodedReferenceList.cs:67
	{                                                                                                                                          // CSBuildCodedReferenceList.cs:68
	    /// <summary>
	    /// AbnormalityFibroadenoma_Accessor class constructor
	    /// </summary>
	    public AbnormalityFibroadenoma_Accessor(BreastRadiologyDocument doc) : base("AbnormalityFibroadenoma_Accessor")                        // CSBuildCodedReferenceList.cs:73
	    {                                                                                                                                      // CSBuildCodedReferenceList.cs:74
	        this.Init(doc, "", 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityFibroadenoma");                  // CSBuildCodedReferenceList.cs:75
	    }                                                                                                                                      // CSBuildCodedReferenceList.cs:76
	}                                                                                                                                          // CSBuildCodedReferenceList.cs:77
	/// <summary>
	/// Accessor class for slice 'mGAbnormalityArchitecturalDistortion'
	/// [Fhir Element 'Observation.hasMember:mGAbnormalityArchitecturalDistortion]'
	/// </summary>
	public class MGAbnormalityArchitecturalDistortion_Accessor : MemberListCodedReferenceMultiple<MGAbnormalityArchitecturalDistortion>        // CSBuildCodedReferenceList.cs:67
	{                                                                                                                                          // CSBuildCodedReferenceList.cs:68
	    /// <summary>
	    /// MGAbnormalityArchitecturalDistortion_Accessor class constructor
	    /// </summary>
	    public MGAbnormalityArchitecturalDistortion_Accessor(BreastRadiologyDocument doc) : base("MGAbnormalityArchitecturalDistortion_Accessor")// CSBuildCodedReferenceList.cs:73
	    {                                                                                                                                      // CSBuildCodedReferenceList.cs:74
	        this.Init(doc, "", 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityArchitecturalDistortion");     // CSBuildCodedReferenceList.cs:75
	    }                                                                                                                                      // CSBuildCodedReferenceList.cs:76
	}                                                                                                                                          // CSBuildCodedReferenceList.cs:77
	/// <summary>
	/// Accessor class for slice 'mGAbnormalityAsymmetry'
	/// [Fhir Element 'Observation.hasMember:mGAbnormalityAsymmetry]'
	/// </summary>
	public class MGAbnormalityAsymmetry_Accessor : MemberListCodedReferenceMultiple<MGAbnormalityAsymmetry>                                    // CSBuildCodedReferenceList.cs:67
	{                                                                                                                                          // CSBuildCodedReferenceList.cs:68
	    /// <summary>
	    /// MGAbnormalityAsymmetry_Accessor class constructor
	    /// </summary>
	    public MGAbnormalityAsymmetry_Accessor(BreastRadiologyDocument doc) : base("MGAbnormalityAsymmetry_Accessor")                          // CSBuildCodedReferenceList.cs:73
	    {                                                                                                                                      // CSBuildCodedReferenceList.cs:74
	        this.Init(doc, "", 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityAsymmetry");                   // CSBuildCodedReferenceList.cs:75
	    }                                                                                                                                      // CSBuildCodedReferenceList.cs:76
	}                                                                                                                                          // CSBuildCodedReferenceList.cs:77
	/// <summary>
	/// Accessor class for slice 'mGAbnormalityCalcification'
	/// [Fhir Element 'Observation.hasMember:mGAbnormalityCalcification]'
	/// </summary>
	public class MGAbnormalityCalcification_Accessor : MemberListCodedReferenceMultiple<MGAbnormalityCalcification>                            // CSBuildCodedReferenceList.cs:67
	{                                                                                                                                          // CSBuildCodedReferenceList.cs:68
	    /// <summary>
	    /// MGAbnormalityCalcification_Accessor class constructor
	    /// </summary>
	    public MGAbnormalityCalcification_Accessor(BreastRadiologyDocument doc) : base("MGAbnormalityCalcification_Accessor")                  // CSBuildCodedReferenceList.cs:73
	    {                                                                                                                                      // CSBuildCodedReferenceList.cs:74
	        this.Init(doc, "", 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityCalcification");               // CSBuildCodedReferenceList.cs:75
	    }                                                                                                                                      // CSBuildCodedReferenceList.cs:76
	}                                                                                                                                          // CSBuildCodedReferenceList.cs:77
	/// <summary>
	/// Accessor class for slice 'mGAbnormalityDensity'
	/// [Fhir Element 'Observation.hasMember:mGAbnormalityDensity]'
	/// </summary>
	public class MGAbnormalityDensity_Accessor : MemberListCodedReferenceMultiple<MGAbnormalityDensity>                                        // CSBuildCodedReferenceList.cs:67
	{                                                                                                                                          // CSBuildCodedReferenceList.cs:68
	    /// <summary>
	    /// MGAbnormalityDensity_Accessor class constructor
	    /// </summary>
	    public MGAbnormalityDensity_Accessor(BreastRadiologyDocument doc) : base("MGAbnormalityDensity_Accessor")                              // CSBuildCodedReferenceList.cs:73
	    {                                                                                                                                      // CSBuildCodedReferenceList.cs:74
	        this.Init(doc, "", 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityDensity");                     // CSBuildCodedReferenceList.cs:75
	    }                                                                                                                                      // CSBuildCodedReferenceList.cs:76
	}                                                                                                                                          // CSBuildCodedReferenceList.cs:77
	/// <summary>
	/// Accessor class for slice 'mGAbnormalityFatNecrosis'
	/// [Fhir Element 'Observation.hasMember:mGAbnormalityFatNecrosis]'
	/// </summary>
	public class MGAbnormalityFatNecrosis_Accessor : MemberListCodedReferenceMultiple<MGAbnormalityFatNecrosis>                                // CSBuildCodedReferenceList.cs:67
	{                                                                                                                                          // CSBuildCodedReferenceList.cs:68
	    /// <summary>
	    /// MGAbnormalityFatNecrosis_Accessor class constructor
	    /// </summary>
	    public MGAbnormalityFatNecrosis_Accessor(BreastRadiologyDocument doc) : base("MGAbnormalityFatNecrosis_Accessor")                      // CSBuildCodedReferenceList.cs:73
	    {                                                                                                                                      // CSBuildCodedReferenceList.cs:74
	        this.Init(doc, "", 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityFatNecrosis");                 // CSBuildCodedReferenceList.cs:75
	    }                                                                                                                                      // CSBuildCodedReferenceList.cs:76
	}                                                                                                                                          // CSBuildCodedReferenceList.cs:77
	/// <summary>
	/// Accessor class for slice 'mGBreastDensity'
	/// [Fhir Element 'Observation.hasMember:mGBreastDensity]'
	/// </summary>
	public class MGBreastDensity_Accessor : MemberListCodedReferenceSingle<MGBreastDensity>                                                    // CSBuildCodedReferenceList.cs:51
	{                                                                                                                                          // CSBuildCodedReferenceList.cs:52
	    /// <summary>
	    /// MGBreastDensity_Accessor class constructor
	    /// </summary>
	    public MGBreastDensity_Accessor(BreastRadiologyDocument doc) : base("MGBreastDensity_Accessor")                                        // CSBuildCodedReferenceList.cs:57
	    {                                                                                                                                      // CSBuildCodedReferenceList.cs:58
	        this.Init(doc, "", 1, 1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGBreastDensity");                           // CSBuildCodedReferenceList.cs:59
	    }                                                                                                                                      // CSBuildCodedReferenceList.cs:60
	}                                                                                                                                          // CSBuildCodedReferenceList.cs:61
	//- LocalClassDefs
}
