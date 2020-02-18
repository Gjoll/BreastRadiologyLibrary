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
	/// Accessor class for 'abnormalityCyst'
	/// [Fhir Element 'Observation.hasMember:abnormalityCyst]'
	/// </summary>
	public class AbnormalityCyst_Accessor : ObservationBase.HasMemberMultiple<AbnormalityCyst>                                                 // CSDefineObservation.cs:194
	{                                                                                                                                          // CSDefineObservation.cs:195
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public AbnormalityCyst_Accessor(BreastRadiologyDocument doc) : base()                                                                  // CSDefineObservation.cs:199
	    {                                                                                                                                      // CSDefineObservation.cs:200
	        this.Create(doc, 0, -1);                                                                                                           // CSDefineObservation.cs:201
	    }                                                                                                                                      // CSDefineObservation.cs:202
	}                                                                                                                                          // CSDefineObservation.cs:203
	/// <summary>
	/// Accessor class for 'abnormalityDuct'
	/// [Fhir Element 'Observation.hasMember:abnormalityDuct]'
	/// </summary>
	public class AbnormalityDuct_Accessor : ObservationBase.HasMemberMultiple<AbnormalityDuct>                                                 // CSDefineObservation.cs:194
	{                                                                                                                                          // CSDefineObservation.cs:195
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public AbnormalityDuct_Accessor(BreastRadiologyDocument doc) : base()                                                                  // CSDefineObservation.cs:199
	    {                                                                                                                                      // CSDefineObservation.cs:200
	        this.Create(doc, 0, -1);                                                                                                           // CSDefineObservation.cs:201
	    }                                                                                                                                      // CSDefineObservation.cs:202
	}                                                                                                                                          // CSDefineObservation.cs:203
	/// <summary>
	/// Accessor class for 'abnormalityForeignObject'
	/// [Fhir Element 'Observation.hasMember:abnormalityForeignObject]'
	/// </summary>
	public class AbnormalityForeignObject_Accessor : ObservationBase.HasMemberMultiple<AbnormalityForeignObject>                               // CSDefineObservation.cs:194
	{                                                                                                                                          // CSDefineObservation.cs:195
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public AbnormalityForeignObject_Accessor(BreastRadiologyDocument doc) : base()                                                         // CSDefineObservation.cs:199
	    {                                                                                                                                      // CSDefineObservation.cs:200
	        this.Create(doc, 0, -1);                                                                                                           // CSDefineObservation.cs:201
	    }                                                                                                                                      // CSDefineObservation.cs:202
	}                                                                                                                                          // CSDefineObservation.cs:203
	/// <summary>
	/// Accessor class for 'abnormalityLymphNode'
	/// [Fhir Element 'Observation.hasMember:abnormalityLymphNode]'
	/// </summary>
	public class AbnormalityLymphNode_Accessor : ObservationBase.HasMemberMultiple<AbnormalityLymphNode>                                       // CSDefineObservation.cs:194
	{                                                                                                                                          // CSDefineObservation.cs:195
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public AbnormalityLymphNode_Accessor(BreastRadiologyDocument doc) : base()                                                             // CSDefineObservation.cs:199
	    {                                                                                                                                      // CSDefineObservation.cs:200
	        this.Create(doc, 0, -1);                                                                                                           // CSDefineObservation.cs:201
	    }                                                                                                                                      // CSDefineObservation.cs:202
	}                                                                                                                                          // CSDefineObservation.cs:203
	/// <summary>
	/// Accessor class for 'abnormalityMass'
	/// [Fhir Element 'Observation.hasMember:abnormalityMass]'
	/// </summary>
	public class AbnormalityMass_Accessor : ObservationBase.HasMemberMultiple<AbnormalityMass>                                                 // CSDefineObservation.cs:194
	{                                                                                                                                          // CSDefineObservation.cs:195
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public AbnormalityMass_Accessor(BreastRadiologyDocument doc) : base()                                                                  // CSDefineObservation.cs:199
	    {                                                                                                                                      // CSDefineObservation.cs:200
	        this.Create(doc, 0, -1);                                                                                                           // CSDefineObservation.cs:201
	    }                                                                                                                                      // CSDefineObservation.cs:202
	}                                                                                                                                          // CSDefineObservation.cs:203
	/// <summary>
	/// Accessor class for 'associatedFeatures'
	/// [Fhir Element 'Observation.hasMember:associatedFeatures]'
	/// </summary>
	public class AssociatedFeatures_Accessor : ObservationBase.HasMemberMultiple<AssociatedFeatures>                                           // CSDefineObservation.cs:194
	{                                                                                                                                          // CSDefineObservation.cs:195
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public AssociatedFeatures_Accessor(BreastRadiologyDocument doc) : base()                                                               // CSDefineObservation.cs:199
	    {                                                                                                                                      // CSDefineObservation.cs:200
	        this.Create(doc, 0, -1);                                                                                                           // CSDefineObservation.cs:201
	    }                                                                                                                                      // CSDefineObservation.cs:202
	}                                                                                                                                          // CSDefineObservation.cs:203
	/// <summary>
	/// Accessor class for 'abnormalityFibroadenoma'
	/// [Fhir Element 'Observation.hasMember:abnormalityFibroadenoma]'
	/// </summary>
	public class AbnormalityFibroadenoma_Accessor : ObservationBase.HasMemberMultiple<AbnormalityFibroadenoma>                                 // CSDefineObservation.cs:194
	{                                                                                                                                          // CSDefineObservation.cs:195
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public AbnormalityFibroadenoma_Accessor(BreastRadiologyDocument doc) : base()                                                          // CSDefineObservation.cs:199
	    {                                                                                                                                      // CSDefineObservation.cs:200
	        this.Create(doc, 0, -1);                                                                                                           // CSDefineObservation.cs:201
	    }                                                                                                                                      // CSDefineObservation.cs:202
	}                                                                                                                                          // CSDefineObservation.cs:203
	/// <summary>
	/// Accessor class for 'mGAbnormalityArchitecturalDistortion'
	/// [Fhir Element 'Observation.hasMember:mGAbnormalityArchitecturalDistortion]'
	/// </summary>
	public class MGAbnormalityArchitecturalDistortion_Accessor : ObservationBase.HasMemberMultiple<MGAbnormalityArchitecturalDistortion>       // CSDefineObservation.cs:194
	{                                                                                                                                          // CSDefineObservation.cs:195
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public MGAbnormalityArchitecturalDistortion_Accessor(BreastRadiologyDocument doc) : base()                                             // CSDefineObservation.cs:199
	    {                                                                                                                                      // CSDefineObservation.cs:200
	        this.Create(doc, 0, -1);                                                                                                           // CSDefineObservation.cs:201
	    }                                                                                                                                      // CSDefineObservation.cs:202
	}                                                                                                                                          // CSDefineObservation.cs:203
	/// <summary>
	/// Accessor class for 'mGAbnormalityAsymmetry'
	/// [Fhir Element 'Observation.hasMember:mGAbnormalityAsymmetry]'
	/// </summary>
	public class MGAbnormalityAsymmetry_Accessor : ObservationBase.HasMemberMultiple<MGAbnormalityAsymmetry>                                   // CSDefineObservation.cs:194
	{                                                                                                                                          // CSDefineObservation.cs:195
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public MGAbnormalityAsymmetry_Accessor(BreastRadiologyDocument doc) : base()                                                           // CSDefineObservation.cs:199
	    {                                                                                                                                      // CSDefineObservation.cs:200
	        this.Create(doc, 0, -1);                                                                                                           // CSDefineObservation.cs:201
	    }                                                                                                                                      // CSDefineObservation.cs:202
	}                                                                                                                                          // CSDefineObservation.cs:203
	/// <summary>
	/// Accessor class for 'mGAbnormalityCalcification'
	/// [Fhir Element 'Observation.hasMember:mGAbnormalityCalcification]'
	/// </summary>
	public class MGAbnormalityCalcification_Accessor : ObservationBase.HasMemberMultiple<MGAbnormalityCalcification>                           // CSDefineObservation.cs:194
	{                                                                                                                                          // CSDefineObservation.cs:195
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public MGAbnormalityCalcification_Accessor(BreastRadiologyDocument doc) : base()                                                       // CSDefineObservation.cs:199
	    {                                                                                                                                      // CSDefineObservation.cs:200
	        this.Create(doc, 0, -1);                                                                                                           // CSDefineObservation.cs:201
	    }                                                                                                                                      // CSDefineObservation.cs:202
	}                                                                                                                                          // CSDefineObservation.cs:203
	/// <summary>
	/// Accessor class for 'mGAbnormalityDensity'
	/// [Fhir Element 'Observation.hasMember:mGAbnormalityDensity]'
	/// </summary>
	public class MGAbnormalityDensity_Accessor : ObservationBase.HasMemberMultiple<MGAbnormalityDensity>                                       // CSDefineObservation.cs:194
	{                                                                                                                                          // CSDefineObservation.cs:195
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public MGAbnormalityDensity_Accessor(BreastRadiologyDocument doc) : base()                                                             // CSDefineObservation.cs:199
	    {                                                                                                                                      // CSDefineObservation.cs:200
	        this.Create(doc, 0, -1);                                                                                                           // CSDefineObservation.cs:201
	    }                                                                                                                                      // CSDefineObservation.cs:202
	}                                                                                                                                          // CSDefineObservation.cs:203
	/// <summary>
	/// Accessor class for 'mGAbnormalityFatNecrosis'
	/// [Fhir Element 'Observation.hasMember:mGAbnormalityFatNecrosis]'
	/// </summary>
	public class MGAbnormalityFatNecrosis_Accessor : ObservationBase.HasMemberMultiple<MGAbnormalityFatNecrosis>                               // CSDefineObservation.cs:194
	{                                                                                                                                          // CSDefineObservation.cs:195
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public MGAbnormalityFatNecrosis_Accessor(BreastRadiologyDocument doc) : base()                                                         // CSDefineObservation.cs:199
	    {                                                                                                                                      // CSDefineObservation.cs:200
	        this.Create(doc, 0, -1);                                                                                                           // CSDefineObservation.cs:201
	    }                                                                                                                                      // CSDefineObservation.cs:202
	}                                                                                                                                          // CSDefineObservation.cs:203
	/// <summary>
	/// Accessor class for 'mGBreastDensity'
	/// [Fhir Element 'Observation.hasMember:mGBreastDensity]'
	/// </summary>
	public class MGBreastDensity_Accessor : ObservationBase.HasMemberSingle<MGBreastDensity>                                                   // CSDefineObservation.cs:179
	{                                                                                                                                          // CSDefineObservation.cs:180
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public MGBreastDensity_Accessor(BreastRadiologyDocument doc) : base()                                                                  // CSDefineObservation.cs:184
	    {                                                                                                                                      // CSDefineObservation.cs:185
	        this.Create(doc, 1, 1);                                                                                                            // CSDefineObservation.cs:186
	    }                                                                                                                                      // CSDefineObservation.cs:187
	}                                                                                                                                          // CSDefineObservation.cs:188
	//- LocalClassDefs
}
