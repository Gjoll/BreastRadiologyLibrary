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
	public class AbnormalityCyst_Accessor : ObservationBase.HasMemberBase<AbnormalityCyst>                                                     // CSDefineObservation.cs:180
	{                                                                                                                                          // CSDefineObservation.cs:181
	    /// <summary>
	    /// Get items
	    /// </summary>
	    public IEnumerable<AbnormalityCyst> Get() => base.items;                                                                               // CSDefineObservation.cs:221
	                                                                                                                                           // CSDefineObservation.cs:222
	    /// <summary>
	    /// Add item
	    /// </summary>
	    public AbnormalityCyst Add(AbnormalityCyst item = null)                                                                                // CSDefineObservation.cs:226
	    {                                                                                                                                      // CSDefineObservation.cs:227
	        if (item == null)                                                                                                                  // CSDefineObservation.cs:228
	        {                                                                                                                                  // CSDefineObservation.cs:229
	            item = new AbnormalityCyst();                                                                                                  // CSDefineObservation.cs:230
	            item.Create(this.doc);                                                                                                         // CSDefineObservation.cs:231
	        }                                                                                                                                  // CSDefineObservation.cs:232
	        base.AppendItem(item);                                                                                                             // CSDefineObservation.cs:233
	        return item;                                                                                                                       // CSDefineObservation.cs:234
	    }                                                                                                                                      // CSDefineObservation.cs:235
	    /// <summary>
	    /// Accessor HasMember slice AbnormalityCyst_Accessor class constructor
	    /// </summary>
	    public AbnormalityCyst_Accessor(BreastRadiologyDocument doc) : base()                                                                  // CSDefineObservation.cs:186
	    {                                                                                                                                      // CSDefineObservation.cs:187
	        this.Create(doc, 0, -1);                                                                                                           // CSDefineObservation.cs:188
	    }                                                                                                                                      // CSDefineObservation.cs:189
	}                                                                                                                                          // CSDefineObservation.cs:190
	/// <summary>
	/// Accessor class for ObservationhasMember slice 'abnormalityDuct'
	/// [Fhir Element 'Observation.hasMember:abnormalityDuct]'
	/// </summary>
	public class AbnormalityDuct_Accessor : ObservationBase.HasMemberBase<AbnormalityDuct>                                                     // CSDefineObservation.cs:180
	{                                                                                                                                          // CSDefineObservation.cs:181
	    /// <summary>
	    /// Get items
	    /// </summary>
	    public IEnumerable<AbnormalityDuct> Get() => base.items;                                                                               // CSDefineObservation.cs:221
	                                                                                                                                           // CSDefineObservation.cs:222
	    /// <summary>
	    /// Add item
	    /// </summary>
	    public AbnormalityDuct Add(AbnormalityDuct item = null)                                                                                // CSDefineObservation.cs:226
	    {                                                                                                                                      // CSDefineObservation.cs:227
	        if (item == null)                                                                                                                  // CSDefineObservation.cs:228
	        {                                                                                                                                  // CSDefineObservation.cs:229
	            item = new AbnormalityDuct();                                                                                                  // CSDefineObservation.cs:230
	            item.Create(this.doc);                                                                                                         // CSDefineObservation.cs:231
	        }                                                                                                                                  // CSDefineObservation.cs:232
	        base.AppendItem(item);                                                                                                             // CSDefineObservation.cs:233
	        return item;                                                                                                                       // CSDefineObservation.cs:234
	    }                                                                                                                                      // CSDefineObservation.cs:235
	    /// <summary>
	    /// Accessor HasMember slice AbnormalityDuct_Accessor class constructor
	    /// </summary>
	    public AbnormalityDuct_Accessor(BreastRadiologyDocument doc) : base()                                                                  // CSDefineObservation.cs:186
	    {                                                                                                                                      // CSDefineObservation.cs:187
	        this.Create(doc, 0, -1);                                                                                                           // CSDefineObservation.cs:188
	    }                                                                                                                                      // CSDefineObservation.cs:189
	}                                                                                                                                          // CSDefineObservation.cs:190
	/// <summary>
	/// Accessor class for ObservationhasMember slice 'abnormalityForeignObject'
	/// [Fhir Element 'Observation.hasMember:abnormalityForeignObject]'
	/// </summary>
	public class AbnormalityForeignObject_Accessor : ObservationBase.HasMemberBase<AbnormalityForeignObject>                                   // CSDefineObservation.cs:180
	{                                                                                                                                          // CSDefineObservation.cs:181
	    /// <summary>
	    /// Get items
	    /// </summary>
	    public IEnumerable<AbnormalityForeignObject> Get() => base.items;                                                                      // CSDefineObservation.cs:221
	                                                                                                                                           // CSDefineObservation.cs:222
	    /// <summary>
	    /// Add item
	    /// </summary>
	    public AbnormalityForeignObject Add(AbnormalityForeignObject item = null)                                                              // CSDefineObservation.cs:226
	    {                                                                                                                                      // CSDefineObservation.cs:227
	        if (item == null)                                                                                                                  // CSDefineObservation.cs:228
	        {                                                                                                                                  // CSDefineObservation.cs:229
	            item = new AbnormalityForeignObject();                                                                                         // CSDefineObservation.cs:230
	            item.Create(this.doc);                                                                                                         // CSDefineObservation.cs:231
	        }                                                                                                                                  // CSDefineObservation.cs:232
	        base.AppendItem(item);                                                                                                             // CSDefineObservation.cs:233
	        return item;                                                                                                                       // CSDefineObservation.cs:234
	    }                                                                                                                                      // CSDefineObservation.cs:235
	    /// <summary>
	    /// Accessor HasMember slice AbnormalityForeignObject_Accessor class constructor
	    /// </summary>
	    public AbnormalityForeignObject_Accessor(BreastRadiologyDocument doc) : base()                                                         // CSDefineObservation.cs:186
	    {                                                                                                                                      // CSDefineObservation.cs:187
	        this.Create(doc, 0, -1);                                                                                                           // CSDefineObservation.cs:188
	    }                                                                                                                                      // CSDefineObservation.cs:189
	}                                                                                                                                          // CSDefineObservation.cs:190
	/// <summary>
	/// Accessor class for ObservationhasMember slice 'abnormalityLymphNode'
	/// [Fhir Element 'Observation.hasMember:abnormalityLymphNode]'
	/// </summary>
	public class AbnormalityLymphNode_Accessor : ObservationBase.HasMemberBase<AbnormalityLymphNode>                                           // CSDefineObservation.cs:180
	{                                                                                                                                          // CSDefineObservation.cs:181
	    /// <summary>
	    /// Get items
	    /// </summary>
	    public IEnumerable<AbnormalityLymphNode> Get() => base.items;                                                                          // CSDefineObservation.cs:221
	                                                                                                                                           // CSDefineObservation.cs:222
	    /// <summary>
	    /// Add item
	    /// </summary>
	    public AbnormalityLymphNode Add(AbnormalityLymphNode item = null)                                                                      // CSDefineObservation.cs:226
	    {                                                                                                                                      // CSDefineObservation.cs:227
	        if (item == null)                                                                                                                  // CSDefineObservation.cs:228
	        {                                                                                                                                  // CSDefineObservation.cs:229
	            item = new AbnormalityLymphNode();                                                                                             // CSDefineObservation.cs:230
	            item.Create(this.doc);                                                                                                         // CSDefineObservation.cs:231
	        }                                                                                                                                  // CSDefineObservation.cs:232
	        base.AppendItem(item);                                                                                                             // CSDefineObservation.cs:233
	        return item;                                                                                                                       // CSDefineObservation.cs:234
	    }                                                                                                                                      // CSDefineObservation.cs:235
	    /// <summary>
	    /// Accessor HasMember slice AbnormalityLymphNode_Accessor class constructor
	    /// </summary>
	    public AbnormalityLymphNode_Accessor(BreastRadiologyDocument doc) : base()                                                             // CSDefineObservation.cs:186
	    {                                                                                                                                      // CSDefineObservation.cs:187
	        this.Create(doc, 0, -1);                                                                                                           // CSDefineObservation.cs:188
	    }                                                                                                                                      // CSDefineObservation.cs:189
	}                                                                                                                                          // CSDefineObservation.cs:190
	/// <summary>
	/// Accessor class for ObservationhasMember slice 'abnormalityMass'
	/// [Fhir Element 'Observation.hasMember:abnormalityMass]'
	/// </summary>
	public class AbnormalityMass_Accessor : ObservationBase.HasMemberBase<AbnormalityMass>                                                     // CSDefineObservation.cs:180
	{                                                                                                                                          // CSDefineObservation.cs:181
	    /// <summary>
	    /// Get items
	    /// </summary>
	    public IEnumerable<AbnormalityMass> Get() => base.items;                                                                               // CSDefineObservation.cs:221
	                                                                                                                                           // CSDefineObservation.cs:222
	    /// <summary>
	    /// Add item
	    /// </summary>
	    public AbnormalityMass Add(AbnormalityMass item = null)                                                                                // CSDefineObservation.cs:226
	    {                                                                                                                                      // CSDefineObservation.cs:227
	        if (item == null)                                                                                                                  // CSDefineObservation.cs:228
	        {                                                                                                                                  // CSDefineObservation.cs:229
	            item = new AbnormalityMass();                                                                                                  // CSDefineObservation.cs:230
	            item.Create(this.doc);                                                                                                         // CSDefineObservation.cs:231
	        }                                                                                                                                  // CSDefineObservation.cs:232
	        base.AppendItem(item);                                                                                                             // CSDefineObservation.cs:233
	        return item;                                                                                                                       // CSDefineObservation.cs:234
	    }                                                                                                                                      // CSDefineObservation.cs:235
	    /// <summary>
	    /// Accessor HasMember slice AbnormalityMass_Accessor class constructor
	    /// </summary>
	    public AbnormalityMass_Accessor(BreastRadiologyDocument doc) : base()                                                                  // CSDefineObservation.cs:186
	    {                                                                                                                                      // CSDefineObservation.cs:187
	        this.Create(doc, 0, -1);                                                                                                           // CSDefineObservation.cs:188
	    }                                                                                                                                      // CSDefineObservation.cs:189
	}                                                                                                                                          // CSDefineObservation.cs:190
	/// <summary>
	/// Accessor class for ObservationhasMember slice 'associatedFeatures'
	/// [Fhir Element 'Observation.hasMember:associatedFeatures]'
	/// </summary>
	public class AssociatedFeatures_Accessor : ObservationBase.HasMemberBase<AssociatedFeatures>                                               // CSDefineObservation.cs:180
	{                                                                                                                                          // CSDefineObservation.cs:181
	    /// <summary>
	    /// Get items
	    /// </summary>
	    public IEnumerable<AssociatedFeatures> Get() => base.items;                                                                            // CSDefineObservation.cs:221
	                                                                                                                                           // CSDefineObservation.cs:222
	    /// <summary>
	    /// Add item
	    /// </summary>
	    public AssociatedFeatures Add(AssociatedFeatures item = null)                                                                          // CSDefineObservation.cs:226
	    {                                                                                                                                      // CSDefineObservation.cs:227
	        if (item == null)                                                                                                                  // CSDefineObservation.cs:228
	        {                                                                                                                                  // CSDefineObservation.cs:229
	            item = new AssociatedFeatures();                                                                                               // CSDefineObservation.cs:230
	            item.Create(this.doc);                                                                                                         // CSDefineObservation.cs:231
	        }                                                                                                                                  // CSDefineObservation.cs:232
	        base.AppendItem(item);                                                                                                             // CSDefineObservation.cs:233
	        return item;                                                                                                                       // CSDefineObservation.cs:234
	    }                                                                                                                                      // CSDefineObservation.cs:235
	    /// <summary>
	    /// Accessor HasMember slice AssociatedFeatures_Accessor class constructor
	    /// </summary>
	    public AssociatedFeatures_Accessor(BreastRadiologyDocument doc) : base()                                                               // CSDefineObservation.cs:186
	    {                                                                                                                                      // CSDefineObservation.cs:187
	        this.Create(doc, 0, -1);                                                                                                           // CSDefineObservation.cs:188
	    }                                                                                                                                      // CSDefineObservation.cs:189
	}                                                                                                                                          // CSDefineObservation.cs:190
	/// <summary>
	/// Accessor class for ObservationhasMember slice 'abnormalityFibroadenoma'
	/// [Fhir Element 'Observation.hasMember:abnormalityFibroadenoma]'
	/// </summary>
	public class AbnormalityFibroadenoma_Accessor : ObservationBase.HasMemberBase<AbnormalityFibroadenoma>                                     // CSDefineObservation.cs:180
	{                                                                                                                                          // CSDefineObservation.cs:181
	    /// <summary>
	    /// Get items
	    /// </summary>
	    public IEnumerable<AbnormalityFibroadenoma> Get() => base.items;                                                                       // CSDefineObservation.cs:221
	                                                                                                                                           // CSDefineObservation.cs:222
	    /// <summary>
	    /// Add item
	    /// </summary>
	    public AbnormalityFibroadenoma Add(AbnormalityFibroadenoma item = null)                                                                // CSDefineObservation.cs:226
	    {                                                                                                                                      // CSDefineObservation.cs:227
	        if (item == null)                                                                                                                  // CSDefineObservation.cs:228
	        {                                                                                                                                  // CSDefineObservation.cs:229
	            item = new AbnormalityFibroadenoma();                                                                                          // CSDefineObservation.cs:230
	            item.Create(this.doc);                                                                                                         // CSDefineObservation.cs:231
	        }                                                                                                                                  // CSDefineObservation.cs:232
	        base.AppendItem(item);                                                                                                             // CSDefineObservation.cs:233
	        return item;                                                                                                                       // CSDefineObservation.cs:234
	    }                                                                                                                                      // CSDefineObservation.cs:235
	    /// <summary>
	    /// Accessor HasMember slice AbnormalityFibroadenoma_Accessor class constructor
	    /// </summary>
	    public AbnormalityFibroadenoma_Accessor(BreastRadiologyDocument doc) : base()                                                          // CSDefineObservation.cs:186
	    {                                                                                                                                      // CSDefineObservation.cs:187
	        this.Create(doc, 0, -1);                                                                                                           // CSDefineObservation.cs:188
	    }                                                                                                                                      // CSDefineObservation.cs:189
	}                                                                                                                                          // CSDefineObservation.cs:190
	/// <summary>
	/// Accessor class for ObservationhasMember slice 'mGAbnormalityArchitecturalDistortion'
	/// [Fhir Element 'Observation.hasMember:mGAbnormalityArchitecturalDistortion]'
	/// </summary>
	public class MGAbnormalityArchitecturalDistortion_Accessor : ObservationBase.HasMemberBase<MGAbnormalityArchitecturalDistortion>           // CSDefineObservation.cs:180
	{                                                                                                                                          // CSDefineObservation.cs:181
	    /// <summary>
	    /// Get items
	    /// </summary>
	    public IEnumerable<MGAbnormalityArchitecturalDistortion> Get() => base.items;                                                          // CSDefineObservation.cs:221
	                                                                                                                                           // CSDefineObservation.cs:222
	    /// <summary>
	    /// Add item
	    /// </summary>
	    public MGAbnormalityArchitecturalDistortion Add(MGAbnormalityArchitecturalDistortion item = null)                                      // CSDefineObservation.cs:226
	    {                                                                                                                                      // CSDefineObservation.cs:227
	        if (item == null)                                                                                                                  // CSDefineObservation.cs:228
	        {                                                                                                                                  // CSDefineObservation.cs:229
	            item = new MGAbnormalityArchitecturalDistortion();                                                                             // CSDefineObservation.cs:230
	            item.Create(this.doc);                                                                                                         // CSDefineObservation.cs:231
	        }                                                                                                                                  // CSDefineObservation.cs:232
	        base.AppendItem(item);                                                                                                             // CSDefineObservation.cs:233
	        return item;                                                                                                                       // CSDefineObservation.cs:234
	    }                                                                                                                                      // CSDefineObservation.cs:235
	    /// <summary>
	    /// Accessor HasMember slice MGAbnormalityArchitecturalDistortion_Accessor class constructor
	    /// </summary>
	    public MGAbnormalityArchitecturalDistortion_Accessor(BreastRadiologyDocument doc) : base()                                             // CSDefineObservation.cs:186
	    {                                                                                                                                      // CSDefineObservation.cs:187
	        this.Create(doc, 0, -1);                                                                                                           // CSDefineObservation.cs:188
	    }                                                                                                                                      // CSDefineObservation.cs:189
	}                                                                                                                                          // CSDefineObservation.cs:190
	/// <summary>
	/// Accessor class for ObservationhasMember slice 'mGAbnormalityAsymmetry'
	/// [Fhir Element 'Observation.hasMember:mGAbnormalityAsymmetry]'
	/// </summary>
	public class MGAbnormalityAsymmetry_Accessor : ObservationBase.HasMemberBase<MGAbnormalityAsymmetry>                                       // CSDefineObservation.cs:180
	{                                                                                                                                          // CSDefineObservation.cs:181
	    /// <summary>
	    /// Get items
	    /// </summary>
	    public IEnumerable<MGAbnormalityAsymmetry> Get() => base.items;                                                                        // CSDefineObservation.cs:221
	                                                                                                                                           // CSDefineObservation.cs:222
	    /// <summary>
	    /// Add item
	    /// </summary>
	    public MGAbnormalityAsymmetry Add(MGAbnormalityAsymmetry item = null)                                                                  // CSDefineObservation.cs:226
	    {                                                                                                                                      // CSDefineObservation.cs:227
	        if (item == null)                                                                                                                  // CSDefineObservation.cs:228
	        {                                                                                                                                  // CSDefineObservation.cs:229
	            item = new MGAbnormalityAsymmetry();                                                                                           // CSDefineObservation.cs:230
	            item.Create(this.doc);                                                                                                         // CSDefineObservation.cs:231
	        }                                                                                                                                  // CSDefineObservation.cs:232
	        base.AppendItem(item);                                                                                                             // CSDefineObservation.cs:233
	        return item;                                                                                                                       // CSDefineObservation.cs:234
	    }                                                                                                                                      // CSDefineObservation.cs:235
	    /// <summary>
	    /// Accessor HasMember slice MGAbnormalityAsymmetry_Accessor class constructor
	    /// </summary>
	    public MGAbnormalityAsymmetry_Accessor(BreastRadiologyDocument doc) : base()                                                           // CSDefineObservation.cs:186
	    {                                                                                                                                      // CSDefineObservation.cs:187
	        this.Create(doc, 0, -1);                                                                                                           // CSDefineObservation.cs:188
	    }                                                                                                                                      // CSDefineObservation.cs:189
	}                                                                                                                                          // CSDefineObservation.cs:190
	/// <summary>
	/// Accessor class for ObservationhasMember slice 'mGAbnormalityCalcification'
	/// [Fhir Element 'Observation.hasMember:mGAbnormalityCalcification]'
	/// </summary>
	public class MGAbnormalityCalcification_Accessor : ObservationBase.HasMemberBase<MGAbnormalityCalcification>                               // CSDefineObservation.cs:180
	{                                                                                                                                          // CSDefineObservation.cs:181
	    /// <summary>
	    /// Get items
	    /// </summary>
	    public IEnumerable<MGAbnormalityCalcification> Get() => base.items;                                                                    // CSDefineObservation.cs:221
	                                                                                                                                           // CSDefineObservation.cs:222
	    /// <summary>
	    /// Add item
	    /// </summary>
	    public MGAbnormalityCalcification Add(MGAbnormalityCalcification item = null)                                                          // CSDefineObservation.cs:226
	    {                                                                                                                                      // CSDefineObservation.cs:227
	        if (item == null)                                                                                                                  // CSDefineObservation.cs:228
	        {                                                                                                                                  // CSDefineObservation.cs:229
	            item = new MGAbnormalityCalcification();                                                                                       // CSDefineObservation.cs:230
	            item.Create(this.doc);                                                                                                         // CSDefineObservation.cs:231
	        }                                                                                                                                  // CSDefineObservation.cs:232
	        base.AppendItem(item);                                                                                                             // CSDefineObservation.cs:233
	        return item;                                                                                                                       // CSDefineObservation.cs:234
	    }                                                                                                                                      // CSDefineObservation.cs:235
	    /// <summary>
	    /// Accessor HasMember slice MGAbnormalityCalcification_Accessor class constructor
	    /// </summary>
	    public MGAbnormalityCalcification_Accessor(BreastRadiologyDocument doc) : base()                                                       // CSDefineObservation.cs:186
	    {                                                                                                                                      // CSDefineObservation.cs:187
	        this.Create(doc, 0, -1);                                                                                                           // CSDefineObservation.cs:188
	    }                                                                                                                                      // CSDefineObservation.cs:189
	}                                                                                                                                          // CSDefineObservation.cs:190
	/// <summary>
	/// Accessor class for ObservationhasMember slice 'mGAbnormalityDensity'
	/// [Fhir Element 'Observation.hasMember:mGAbnormalityDensity]'
	/// </summary>
	public class MGAbnormalityDensity_Accessor : ObservationBase.HasMemberBase<MGAbnormalityDensity>                                           // CSDefineObservation.cs:180
	{                                                                                                                                          // CSDefineObservation.cs:181
	    /// <summary>
	    /// Get items
	    /// </summary>
	    public IEnumerable<MGAbnormalityDensity> Get() => base.items;                                                                          // CSDefineObservation.cs:221
	                                                                                                                                           // CSDefineObservation.cs:222
	    /// <summary>
	    /// Add item
	    /// </summary>
	    public MGAbnormalityDensity Add(MGAbnormalityDensity item = null)                                                                      // CSDefineObservation.cs:226
	    {                                                                                                                                      // CSDefineObservation.cs:227
	        if (item == null)                                                                                                                  // CSDefineObservation.cs:228
	        {                                                                                                                                  // CSDefineObservation.cs:229
	            item = new MGAbnormalityDensity();                                                                                             // CSDefineObservation.cs:230
	            item.Create(this.doc);                                                                                                         // CSDefineObservation.cs:231
	        }                                                                                                                                  // CSDefineObservation.cs:232
	        base.AppendItem(item);                                                                                                             // CSDefineObservation.cs:233
	        return item;                                                                                                                       // CSDefineObservation.cs:234
	    }                                                                                                                                      // CSDefineObservation.cs:235
	    /// <summary>
	    /// Accessor HasMember slice MGAbnormalityDensity_Accessor class constructor
	    /// </summary>
	    public MGAbnormalityDensity_Accessor(BreastRadiologyDocument doc) : base()                                                             // CSDefineObservation.cs:186
	    {                                                                                                                                      // CSDefineObservation.cs:187
	        this.Create(doc, 0, -1);                                                                                                           // CSDefineObservation.cs:188
	    }                                                                                                                                      // CSDefineObservation.cs:189
	}                                                                                                                                          // CSDefineObservation.cs:190
	/// <summary>
	/// Accessor class for ObservationhasMember slice 'mGAbnormalityFatNecrosis'
	/// [Fhir Element 'Observation.hasMember:mGAbnormalityFatNecrosis]'
	/// </summary>
	public class MGAbnormalityFatNecrosis_Accessor : ObservationBase.HasMemberBase<MGAbnormalityFatNecrosis>                                   // CSDefineObservation.cs:180
	{                                                                                                                                          // CSDefineObservation.cs:181
	    /// <summary>
	    /// Get items
	    /// </summary>
	    public IEnumerable<MGAbnormalityFatNecrosis> Get() => base.items;                                                                      // CSDefineObservation.cs:221
	                                                                                                                                           // CSDefineObservation.cs:222
	    /// <summary>
	    /// Add item
	    /// </summary>
	    public MGAbnormalityFatNecrosis Add(MGAbnormalityFatNecrosis item = null)                                                              // CSDefineObservation.cs:226
	    {                                                                                                                                      // CSDefineObservation.cs:227
	        if (item == null)                                                                                                                  // CSDefineObservation.cs:228
	        {                                                                                                                                  // CSDefineObservation.cs:229
	            item = new MGAbnormalityFatNecrosis();                                                                                         // CSDefineObservation.cs:230
	            item.Create(this.doc);                                                                                                         // CSDefineObservation.cs:231
	        }                                                                                                                                  // CSDefineObservation.cs:232
	        base.AppendItem(item);                                                                                                             // CSDefineObservation.cs:233
	        return item;                                                                                                                       // CSDefineObservation.cs:234
	    }                                                                                                                                      // CSDefineObservation.cs:235
	    /// <summary>
	    /// Accessor HasMember slice MGAbnormalityFatNecrosis_Accessor class constructor
	    /// </summary>
	    public MGAbnormalityFatNecrosis_Accessor(BreastRadiologyDocument doc) : base()                                                         // CSDefineObservation.cs:186
	    {                                                                                                                                      // CSDefineObservation.cs:187
	        this.Create(doc, 0, -1);                                                                                                           // CSDefineObservation.cs:188
	    }                                                                                                                                      // CSDefineObservation.cs:189
	}                                                                                                                                          // CSDefineObservation.cs:190
	/// <summary>
	/// Accessor class for ObservationhasMember slice 'mGBreastDensity'
	/// [Fhir Element 'Observation.hasMember:mGBreastDensity]'
	/// </summary>
	public class MGBreastDensity_Accessor : ObservationBase.HasMemberBase<MGBreastDensity>                                                     // CSDefineObservation.cs:180
	{                                                                                                                                          // CSDefineObservation.cs:181
	    /// <summary>
	    /// Get item
	    /// </summary>
	    public MGBreastDensity Get() => base.GetSingleItem();                                                                                  // CSDefineObservation.cs:198
	                                                                                                                                           // CSDefineObservation.cs:199
	    /// <summary>
	    /// Set item
	    /// </summary>
	    public MGBreastDensity Set(MGBreastDensity item = null)                                                                                // CSDefineObservation.cs:203
	    {                                                                                                                                      // CSDefineObservation.cs:204
	        if (item == null)                                                                                                                  // CSDefineObservation.cs:205
	        {                                                                                                                                  // CSDefineObservation.cs:206
	            item = new MGBreastDensity();                                                                                                  // CSDefineObservation.cs:207
	            item.Create(this.doc);                                                                                                         // CSDefineObservation.cs:208
	        }                                                                                                                                  // CSDefineObservation.cs:209
	        base.SetSingleItem(item);                                                                                                          // CSDefineObservation.cs:210
	        return item;                                                                                                                       // CSDefineObservation.cs:211
	    }                                                                                                                                      // CSDefineObservation.cs:212
	    /// <summary>
	    /// Accessor HasMember slice MGBreastDensity_Accessor class constructor
	    /// </summary>
	    public MGBreastDensity_Accessor(BreastRadiologyDocument doc) : base()                                                                  // CSDefineObservation.cs:186
	    {                                                                                                                                      // CSDefineObservation.cs:187
	        this.Create(doc, 1, 1);                                                                                                            // CSDefineObservation.cs:188
	    }                                                                                                                                      // CSDefineObservation.cs:189
	}                                                                                                                                          // CSDefineObservation.cs:190
	//- LocalClassDefs
}
