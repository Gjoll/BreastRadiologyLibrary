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
	/// Accessor class for ObservationhasMember slice 'abnormalityCyst'
	/// [Fhir Element 'Observation.hasMember:abnormalityCyst]'
	/// </summary>
	public class AbnormalityCyst_Accessor : ObservationBase.HasMemberMultiple<AbnormalityCyst>                                                 // CSDefineObservation.cs:199
	{                                                                                                                                          // CSDefineObservation.cs:200
	    /// <summary>
	    /// Accessor HasMember slice AbnormalityCyst_Accessor class constructor
	    /// </summary>
	    public AbnormalityCyst_Accessor(BreastRadiologyDocument doc) : base()                                                                  // CSDefineObservation.cs:205
	    {                                                                                                                                      // CSDefineObservation.cs:206
	        this.Init(doc, 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityCyst");                              // CSDefineObservation.cs:207
	    }                                                                                                                                      // CSDefineObservation.cs:208
	}                                                                                                                                          // CSDefineObservation.cs:209
	/// <summary>
	/// Accessor class for ObservationhasMember slice 'abnormalityDuct'
	/// [Fhir Element 'Observation.hasMember:abnormalityDuct]'
	/// </summary>
	public class AbnormalityDuct_Accessor : ObservationBase.HasMemberMultiple<AbnormalityDuct>                                                 // CSDefineObservation.cs:199
	{                                                                                                                                          // CSDefineObservation.cs:200
	    /// <summary>
	    /// Accessor HasMember slice AbnormalityDuct_Accessor class constructor
	    /// </summary>
	    public AbnormalityDuct_Accessor(BreastRadiologyDocument doc) : base()                                                                  // CSDefineObservation.cs:205
	    {                                                                                                                                      // CSDefineObservation.cs:206
	        this.Init(doc, 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityDuct");                              // CSDefineObservation.cs:207
	    }                                                                                                                                      // CSDefineObservation.cs:208
	}                                                                                                                                          // CSDefineObservation.cs:209
	/// <summary>
	/// Accessor class for ObservationhasMember slice 'abnormalityForeignObject'
	/// [Fhir Element 'Observation.hasMember:abnormalityForeignObject]'
	/// </summary>
	public class AbnormalityForeignObject_Accessor : ObservationBase.HasMemberMultiple<AbnormalityForeignObject>                               // CSDefineObservation.cs:199
	{                                                                                                                                          // CSDefineObservation.cs:200
	    /// <summary>
	    /// Accessor HasMember slice AbnormalityForeignObject_Accessor class constructor
	    /// </summary>
	    public AbnormalityForeignObject_Accessor(BreastRadiologyDocument doc) : base()                                                         // CSDefineObservation.cs:205
	    {                                                                                                                                      // CSDefineObservation.cs:206
	        this.Init(doc, 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityForeignObject");                     // CSDefineObservation.cs:207
	    }                                                                                                                                      // CSDefineObservation.cs:208
	}                                                                                                                                          // CSDefineObservation.cs:209
	/// <summary>
	/// Accessor class for ObservationhasMember slice 'abnormalityLymphNode'
	/// [Fhir Element 'Observation.hasMember:abnormalityLymphNode]'
	/// </summary>
	public class AbnormalityLymphNode_Accessor : ObservationBase.HasMemberMultiple<AbnormalityLymphNode>                                       // CSDefineObservation.cs:199
	{                                                                                                                                          // CSDefineObservation.cs:200
	    /// <summary>
	    /// Accessor HasMember slice AbnormalityLymphNode_Accessor class constructor
	    /// </summary>
	    public AbnormalityLymphNode_Accessor(BreastRadiologyDocument doc) : base()                                                             // CSDefineObservation.cs:205
	    {                                                                                                                                      // CSDefineObservation.cs:206
	        this.Init(doc, 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityLymphNode");                         // CSDefineObservation.cs:207
	    }                                                                                                                                      // CSDefineObservation.cs:208
	}                                                                                                                                          // CSDefineObservation.cs:209
	/// <summary>
	/// Accessor class for ObservationhasMember slice 'abnormalityMass'
	/// [Fhir Element 'Observation.hasMember:abnormalityMass]'
	/// </summary>
	public class AbnormalityMass_Accessor : ObservationBase.HasMemberMultiple<AbnormalityMass>                                                 // CSDefineObservation.cs:199
	{                                                                                                                                          // CSDefineObservation.cs:200
	    /// <summary>
	    /// Accessor HasMember slice AbnormalityMass_Accessor class constructor
	    /// </summary>
	    public AbnormalityMass_Accessor(BreastRadiologyDocument doc) : base()                                                                  // CSDefineObservation.cs:205
	    {                                                                                                                                      // CSDefineObservation.cs:206
	        this.Init(doc, 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityMass");                              // CSDefineObservation.cs:207
	    }                                                                                                                                      // CSDefineObservation.cs:208
	}                                                                                                                                          // CSDefineObservation.cs:209
	/// <summary>
	/// Accessor class for ObservationhasMember slice 'associatedFeatures'
	/// [Fhir Element 'Observation.hasMember:associatedFeatures]'
	/// </summary>
	public class AssociatedFeatures_Accessor : ObservationBase.HasMemberMultiple<AssociatedFeatures>                                           // CSDefineObservation.cs:199
	{                                                                                                                                          // CSDefineObservation.cs:200
	    /// <summary>
	    /// Accessor HasMember slice AssociatedFeatures_Accessor class constructor
	    /// </summary>
	    public AssociatedFeatures_Accessor(BreastRadiologyDocument doc) : base()                                                               // CSDefineObservation.cs:205
	    {                                                                                                                                      // CSDefineObservation.cs:206
	        this.Init(doc, 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AssociatedFeatures");                           // CSDefineObservation.cs:207
	    }                                                                                                                                      // CSDefineObservation.cs:208
	}                                                                                                                                          // CSDefineObservation.cs:209
	/// <summary>
	/// Accessor class for ObservationhasMember slice 'abnormalityFibroadenoma'
	/// [Fhir Element 'Observation.hasMember:abnormalityFibroadenoma]'
	/// </summary>
	public class AbnormalityFibroadenoma_Accessor : ObservationBase.HasMemberMultiple<AbnormalityFibroadenoma>                                 // CSDefineObservation.cs:199
	{                                                                                                                                          // CSDefineObservation.cs:200
	    /// <summary>
	    /// Accessor HasMember slice AbnormalityFibroadenoma_Accessor class constructor
	    /// </summary>
	    public AbnormalityFibroadenoma_Accessor(BreastRadiologyDocument doc) : base()                                                          // CSDefineObservation.cs:205
	    {                                                                                                                                      // CSDefineObservation.cs:206
	        this.Init(doc, 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityFibroadenoma");                      // CSDefineObservation.cs:207
	    }                                                                                                                                      // CSDefineObservation.cs:208
	}                                                                                                                                          // CSDefineObservation.cs:209
	/// <summary>
	/// Accessor class for ObservationhasMember slice 'mGAbnormalityArchitecturalDistortion'
	/// [Fhir Element 'Observation.hasMember:mGAbnormalityArchitecturalDistortion]'
	/// </summary>
	public class MGAbnormalityArchitecturalDistortion_Accessor : ObservationBase.HasMemberMultiple<MGAbnormalityArchitecturalDistortion>       // CSDefineObservation.cs:199
	{                                                                                                                                          // CSDefineObservation.cs:200
	    /// <summary>
	    /// Accessor HasMember slice MGAbnormalityArchitecturalDistortion_Accessor class constructor
	    /// </summary>
	    public MGAbnormalityArchitecturalDistortion_Accessor(BreastRadiologyDocument doc) : base()                                             // CSDefineObservation.cs:205
	    {                                                                                                                                      // CSDefineObservation.cs:206
	        this.Init(doc, 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityArchitecturalDistortion");         // CSDefineObservation.cs:207
	    }                                                                                                                                      // CSDefineObservation.cs:208
	}                                                                                                                                          // CSDefineObservation.cs:209
	/// <summary>
	/// Accessor class for ObservationhasMember slice 'mGAbnormalityAsymmetry'
	/// [Fhir Element 'Observation.hasMember:mGAbnormalityAsymmetry]'
	/// </summary>
	public class MGAbnormalityAsymmetry_Accessor : ObservationBase.HasMemberMultiple<MGAbnormalityAsymmetry>                                   // CSDefineObservation.cs:199
	{                                                                                                                                          // CSDefineObservation.cs:200
	    /// <summary>
	    /// Accessor HasMember slice MGAbnormalityAsymmetry_Accessor class constructor
	    /// </summary>
	    public MGAbnormalityAsymmetry_Accessor(BreastRadiologyDocument doc) : base()                                                           // CSDefineObservation.cs:205
	    {                                                                                                                                      // CSDefineObservation.cs:206
	        this.Init(doc, 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityAsymmetry");                       // CSDefineObservation.cs:207
	    }                                                                                                                                      // CSDefineObservation.cs:208
	}                                                                                                                                          // CSDefineObservation.cs:209
	/// <summary>
	/// Accessor class for ObservationhasMember slice 'mGAbnormalityCalcification'
	/// [Fhir Element 'Observation.hasMember:mGAbnormalityCalcification]'
	/// </summary>
	public class MGAbnormalityCalcification_Accessor : ObservationBase.HasMemberMultiple<MGAbnormalityCalcification>                           // CSDefineObservation.cs:199
	{                                                                                                                                          // CSDefineObservation.cs:200
	    /// <summary>
	    /// Accessor HasMember slice MGAbnormalityCalcification_Accessor class constructor
	    /// </summary>
	    public MGAbnormalityCalcification_Accessor(BreastRadiologyDocument doc) : base()                                                       // CSDefineObservation.cs:205
	    {                                                                                                                                      // CSDefineObservation.cs:206
	        this.Init(doc, 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityCalcification");                   // CSDefineObservation.cs:207
	    }                                                                                                                                      // CSDefineObservation.cs:208
	}                                                                                                                                          // CSDefineObservation.cs:209
	/// <summary>
	/// Accessor class for ObservationhasMember slice 'mGAbnormalityDensity'
	/// [Fhir Element 'Observation.hasMember:mGAbnormalityDensity]'
	/// </summary>
	public class MGAbnormalityDensity_Accessor : ObservationBase.HasMemberMultiple<MGAbnormalityDensity>                                       // CSDefineObservation.cs:199
	{                                                                                                                                          // CSDefineObservation.cs:200
	    /// <summary>
	    /// Accessor HasMember slice MGAbnormalityDensity_Accessor class constructor
	    /// </summary>
	    public MGAbnormalityDensity_Accessor(BreastRadiologyDocument doc) : base()                                                             // CSDefineObservation.cs:205
	    {                                                                                                                                      // CSDefineObservation.cs:206
	        this.Init(doc, 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityDensity");                         // CSDefineObservation.cs:207
	    }                                                                                                                                      // CSDefineObservation.cs:208
	}                                                                                                                                          // CSDefineObservation.cs:209
	/// <summary>
	/// Accessor class for ObservationhasMember slice 'mGAbnormalityFatNecrosis'
	/// [Fhir Element 'Observation.hasMember:mGAbnormalityFatNecrosis]'
	/// </summary>
	public class MGAbnormalityFatNecrosis_Accessor : ObservationBase.HasMemberMultiple<MGAbnormalityFatNecrosis>                               // CSDefineObservation.cs:199
	{                                                                                                                                          // CSDefineObservation.cs:200
	    /// <summary>
	    /// Accessor HasMember slice MGAbnormalityFatNecrosis_Accessor class constructor
	    /// </summary>
	    public MGAbnormalityFatNecrosis_Accessor(BreastRadiologyDocument doc) : base()                                                         // CSDefineObservation.cs:205
	    {                                                                                                                                      // CSDefineObservation.cs:206
	        this.Init(doc, 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityFatNecrosis");                     // CSDefineObservation.cs:207
	    }                                                                                                                                      // CSDefineObservation.cs:208
	}                                                                                                                                          // CSDefineObservation.cs:209
	/// <summary>
	/// Accessor class for ObservationhasMember slice 'mGBreastDensity'
	/// [Fhir Element 'Observation.hasMember:mGBreastDensity]'
	/// </summary>
	public class MGBreastDensity_Accessor : ObservationBase.HasMemberSingle<MGBreastDensity>                                                   // CSDefineObservation.cs:183
	{                                                                                                                                          // CSDefineObservation.cs:184
	    /// <summary>
	    /// Accessor HasMember slice MGBreastDensity_Accessor class constructor
	    /// </summary>
	    public MGBreastDensity_Accessor(BreastRadiologyDocument doc) : base()                                                                  // CSDefineObservation.cs:189
	    {                                                                                                                                      // CSDefineObservation.cs:190
	        this.Init(doc, 1, 1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGBreastDensity");                               // CSDefineObservation.cs:191
	    }                                                                                                                                      // CSDefineObservation.cs:192
	}                                                                                                                                          // CSDefineObservation.cs:193
	//- LocalClassDefs
}
