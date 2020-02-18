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
	/// Accessor class for ObservationhasMember slice 'observedFeature'
	/// [Fhir Element 'Observation.hasMember:observedFeature]'
	/// </summary>
	public class ObservedFeature_Accessor : ObservationBase.HasMemberBase<ObservedFeature>                                                     // CSDefineObservation.cs:180
	{                                                                                                                                          // CSDefineObservation.cs:181
	    /// <summary>
	    /// Get items
	    /// </summary>
	    public IEnumerable<ObservedFeature> Get() => base.items;                                                                               // CSDefineObservation.cs:221
	                                                                                                                                           // CSDefineObservation.cs:222
	    /// <summary>
	    /// Add item
	    /// </summary>
	    public ObservedFeature Add(ObservedFeature item = null)                                                                                // CSDefineObservation.cs:226
	    {                                                                                                                                      // CSDefineObservation.cs:227
	        if (item == null)                                                                                                                  // CSDefineObservation.cs:228
	        {                                                                                                                                  // CSDefineObservation.cs:229
	            item = new ObservedFeature();                                                                                                  // CSDefineObservation.cs:230
	            item.Create(this.doc);                                                                                                         // CSDefineObservation.cs:231
	        }                                                                                                                                  // CSDefineObservation.cs:232
	        base.AppendItem(item);                                                                                                             // CSDefineObservation.cs:233
	        return item;                                                                                                                       // CSDefineObservation.cs:234
	    }                                                                                                                                      // CSDefineObservation.cs:235
	    /// <summary>
	    /// Accessor HasMember slice ObservedFeature_Accessor class constructor
	    /// </summary>
	    public ObservedFeature_Accessor(BreastRadiologyDocument doc) : base()                                                                  // CSDefineObservation.cs:186
	    {                                                                                                                                      // CSDefineObservation.cs:187
	        this.Create(doc, 0, -1);                                                                                                           // CSDefineObservation.cs:188
	    }                                                                                                                                      // CSDefineObservation.cs:189
	}                                                                                                                                          // CSDefineObservation.cs:190
	//- LocalClassDefs
}
