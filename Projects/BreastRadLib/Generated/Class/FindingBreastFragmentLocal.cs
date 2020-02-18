using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.ObservationLocal;

namespace BreastRadLib.FindingBreastFragmentLocal
{
	//+ LocalClassDefs
	/// <summary>
	/// Accessor class for ObservationhasMember slice 'mGFinding'
	/// [Fhir Element 'Observation.hasMember:mGFinding]'
	/// </summary>
	public class MGFinding_Accessor : ObservationBase.HasMemberBase<MGFinding>                                                                 // CSDefineObservation.cs:180
	{                                                                                                                                          // CSDefineObservation.cs:181
	    /// <summary>
	    /// Get items
	    /// </summary>
	    public IEnumerable<MGFinding> Get() => base.items;                                                                                     // CSDefineObservation.cs:221
	                                                                                                                                           // CSDefineObservation.cs:222
	    /// <summary>
	    /// Add item
	    /// </summary>
	    public MGFinding Add(MGFinding item = null)                                                                                            // CSDefineObservation.cs:226
	    {                                                                                                                                      // CSDefineObservation.cs:227
	        if (item == null)                                                                                                                  // CSDefineObservation.cs:228
	        {                                                                                                                                  // CSDefineObservation.cs:229
	            item = new MGFinding();                                                                                                        // CSDefineObservation.cs:230
	            item.Create(this.doc);                                                                                                         // CSDefineObservation.cs:231
	        }                                                                                                                                  // CSDefineObservation.cs:232
	        base.AppendItem(item);                                                                                                             // CSDefineObservation.cs:233
	        return item;                                                                                                                       // CSDefineObservation.cs:234
	    }                                                                                                                                      // CSDefineObservation.cs:235
	    /// <summary>
	    /// Accessor HasMember slice MGFinding_Accessor class constructor
	    /// </summary>
	    public MGFinding_Accessor(BreastRadiologyDocument doc) : base()                                                                        // CSDefineObservation.cs:186
	    {                                                                                                                                      // CSDefineObservation.cs:187
	        this.Create(doc, 0, -1);                                                                                                           // CSDefineObservation.cs:188
	    }                                                                                                                                      // CSDefineObservation.cs:189
	}                                                                                                                                          // CSDefineObservation.cs:190
	/// <summary>
	/// Accessor class for ObservationhasMember slice 'mRIFinding'
	/// [Fhir Element 'Observation.hasMember:mRIFinding]'
	/// </summary>
	public class MRIFinding_Accessor : ObservationBase.HasMemberBase<MRIFinding>                                                               // CSDefineObservation.cs:180
	{                                                                                                                                          // CSDefineObservation.cs:181
	    /// <summary>
	    /// Get items
	    /// </summary>
	    public IEnumerable<MRIFinding> Get() => base.items;                                                                                    // CSDefineObservation.cs:221
	                                                                                                                                           // CSDefineObservation.cs:222
	    /// <summary>
	    /// Add item
	    /// </summary>
	    public MRIFinding Add(MRIFinding item = null)                                                                                          // CSDefineObservation.cs:226
	    {                                                                                                                                      // CSDefineObservation.cs:227
	        if (item == null)                                                                                                                  // CSDefineObservation.cs:228
	        {                                                                                                                                  // CSDefineObservation.cs:229
	            item = new MRIFinding();                                                                                                       // CSDefineObservation.cs:230
	            item.Create(this.doc);                                                                                                         // CSDefineObservation.cs:231
	        }                                                                                                                                  // CSDefineObservation.cs:232
	        base.AppendItem(item);                                                                                                             // CSDefineObservation.cs:233
	        return item;                                                                                                                       // CSDefineObservation.cs:234
	    }                                                                                                                                      // CSDefineObservation.cs:235
	    /// <summary>
	    /// Accessor HasMember slice MRIFinding_Accessor class constructor
	    /// </summary>
	    public MRIFinding_Accessor(BreastRadiologyDocument doc) : base()                                                                       // CSDefineObservation.cs:186
	    {                                                                                                                                      // CSDefineObservation.cs:187
	        this.Create(doc, 0, -1);                                                                                                           // CSDefineObservation.cs:188
	    }                                                                                                                                      // CSDefineObservation.cs:189
	}                                                                                                                                          // CSDefineObservation.cs:190
	/// <summary>
	/// Accessor class for ObservationhasMember slice 'nMFinding'
	/// [Fhir Element 'Observation.hasMember:nMFinding]'
	/// </summary>
	public class NMFinding_Accessor : ObservationBase.HasMemberBase<NMFinding>                                                                 // CSDefineObservation.cs:180
	{                                                                                                                                          // CSDefineObservation.cs:181
	    /// <summary>
	    /// Get items
	    /// </summary>
	    public IEnumerable<NMFinding> Get() => base.items;                                                                                     // CSDefineObservation.cs:221
	                                                                                                                                           // CSDefineObservation.cs:222
	    /// <summary>
	    /// Add item
	    /// </summary>
	    public NMFinding Add(NMFinding item = null)                                                                                            // CSDefineObservation.cs:226
	    {                                                                                                                                      // CSDefineObservation.cs:227
	        if (item == null)                                                                                                                  // CSDefineObservation.cs:228
	        {                                                                                                                                  // CSDefineObservation.cs:229
	            item = new NMFinding();                                                                                                        // CSDefineObservation.cs:230
	            item.Create(this.doc);                                                                                                         // CSDefineObservation.cs:231
	        }                                                                                                                                  // CSDefineObservation.cs:232
	        base.AppendItem(item);                                                                                                             // CSDefineObservation.cs:233
	        return item;                                                                                                                       // CSDefineObservation.cs:234
	    }                                                                                                                                      // CSDefineObservation.cs:235
	    /// <summary>
	    /// Accessor HasMember slice NMFinding_Accessor class constructor
	    /// </summary>
	    public NMFinding_Accessor(BreastRadiologyDocument doc) : base()                                                                        // CSDefineObservation.cs:186
	    {                                                                                                                                      // CSDefineObservation.cs:187
	        this.Create(doc, 0, -1);                                                                                                           // CSDefineObservation.cs:188
	    }                                                                                                                                      // CSDefineObservation.cs:189
	}                                                                                                                                          // CSDefineObservation.cs:190
	/// <summary>
	/// Accessor class for ObservationhasMember slice 'uSFinding'
	/// [Fhir Element 'Observation.hasMember:uSFinding]'
	/// </summary>
	public class USFinding_Accessor : ObservationBase.HasMemberBase<USFinding>                                                                 // CSDefineObservation.cs:180
	{                                                                                                                                          // CSDefineObservation.cs:181
	    /// <summary>
	    /// Get items
	    /// </summary>
	    public IEnumerable<USFinding> Get() => base.items;                                                                                     // CSDefineObservation.cs:221
	                                                                                                                                           // CSDefineObservation.cs:222
	    /// <summary>
	    /// Add item
	    /// </summary>
	    public USFinding Add(USFinding item = null)                                                                                            // CSDefineObservation.cs:226
	    {                                                                                                                                      // CSDefineObservation.cs:227
	        if (item == null)                                                                                                                  // CSDefineObservation.cs:228
	        {                                                                                                                                  // CSDefineObservation.cs:229
	            item = new USFinding();                                                                                                        // CSDefineObservation.cs:230
	            item.Create(this.doc);                                                                                                         // CSDefineObservation.cs:231
	        }                                                                                                                                  // CSDefineObservation.cs:232
	        base.AppendItem(item);                                                                                                             // CSDefineObservation.cs:233
	        return item;                                                                                                                       // CSDefineObservation.cs:234
	    }                                                                                                                                      // CSDefineObservation.cs:235
	    /// <summary>
	    /// Accessor HasMember slice USFinding_Accessor class constructor
	    /// </summary>
	    public USFinding_Accessor(BreastRadiologyDocument doc) : base()                                                                        // CSDefineObservation.cs:186
	    {                                                                                                                                      // CSDefineObservation.cs:187
	        this.Create(doc, 0, -1);                                                                                                           // CSDefineObservation.cs:188
	    }                                                                                                                                      // CSDefineObservation.cs:189
	}                                                                                                                                          // CSDefineObservation.cs:190
	//- LocalClassDefs
}
