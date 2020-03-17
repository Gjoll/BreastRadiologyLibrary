using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib;
using BreastRadLib.ObservationLocal;

//+Usings
//-Usings

namespace BreastRadLib.TumorSatelliteFragmentLocal
{
	//+ LocalClassDefs
	#region Observation.hasMember:tumorSatellite Container Class                                                                               // BuildMemberBase.cs:158
	// Called from BuildMemberReferences.cs, Line 199
	// BuildMemberBase.cs:160
	/// <summary>
	/// Container class for Observation.hasMember:tumorSatellite.
	/// </summary>
	public class MTumorSatellite : MContainer, ITMItem<ResourceReference>                                                                      // BuildMemberBase.cs:163
	{                                                                                                                                          // BuildMemberBase.cs:164
	    #region Observation.hasMember:tumorSatellite Item Class                                                                                // BuildMemberBase.cs:75
	    // Called from BuildMemberReferences.cs, Line 199
	    // BuildMemberBase.cs:77
	    /// <summary>
	    /// Item class for Observation.hasMember:tumorSatellite.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:80
	    {                                                                                                                                      // BuildMemberBase.cs:81
	        // Properties                                                                                                                      // BuildMemberBase.cs:82
	        // BuildMemberBase.cs:84
	        /// <summary>
	        /// Value
	        /// </summary>
	        public TumorSatellite Value { get; set; }                                                                                          // BuildMemberBase.cs:87
	                                                                                                                                           // BuildMemberBase.cs:90
	        // BuildMemberBase.cs:91
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item()                                                                                                                      // BuildMemberBase.cs:94
	        {                                                                                                                                  // BuildMemberBase.cs:95
	        }                                                                                                                                  // BuildMemberBase.cs:97
	                                                                                                                                           // BuildMemberBase.cs:99
	        // Methods                                                                                                                         // BuildMemberBase.cs:100
	                                                                                                                                           // BuildMemberBase.cs:102
	        // BuildMemberBase.cs:103
	        /// <summary>
	        /// Write item.
	        /// </summary>
	                                                                                                                                           // BuildMemberReferences.cs:57
	        public ResourceReference WriteItem(BreastRadiologyDocument doc)                                                                    // BuildMemberReferences.cs:58
	        {                                                                                                                                  // BuildMemberReferences.cs:59
	            return new ResourceReference                                                                                                   // BuildMemberReferences.cs:60
	            {                                                                                                                              // BuildMemberReferences.cs:61
	                Reference = this.Value.Id                                                                                                  // BuildMemberReferences.cs:62
	            };                                                                                                                             // BuildMemberReferences.cs:63
	        }                                                                                                                                  // BuildMemberReferences.cs:64
	                                                                                                                                           // BuildMemberBase.cs:108
	        // BuildMemberBase.cs:109
	        /// <summary>
	        /// Read item.
	        /// </summary>
	                                                                                                                                           // BuildMemberReferences.cs:46
	        public void ReadItem(BreastRadiologyDocument doc, ResourceReference reference)                                                     // BuildMemberReferences.cs:47
	        {                                                                                                                                  // BuildMemberReferences.cs:48
	            this.Value = (TumorSatellite) doc.GetResource(reference);                                                                      // BuildMemberReferences.cs:49
	        }                                                                                                                                  // BuildMemberReferences.cs:50
	    }                                                                                                                                      // BuildMemberBase.cs:115
	    #endregion                                                                                                                             // BuildMemberBase.cs:116
	                                                                                                                                           // BuildMemberBase.cs:167
	    // Properties                                                                                                                          // BuildMemberBase.cs:168
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:139
	    {                                                                                                                                      // BuildMemberBase.cs:140
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/TumorSatellite"                                                       // BuildMemberBase.cs:147
	    };                                                                                                                                     // BuildMemberBase.cs:148
	    #region Common Properties (Non-Singleton)                                                                                              // BuildMemberBase.cs:261
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:262
	                                                                                                                                           // BuildMemberBase.cs:264
	    // BuildMemberBase.cs:265
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:268
	                                                                                                                                           // BuildMemberBase.cs:270
	    // BuildMemberBase.cs:271
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:274
	                                                                                                                                           // BuildMemberBase.cs:276
	    // BuildMemberBase.cs:277
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:280
	                                                                                                                                           // BuildMemberBase.cs:282
	    // BuildMemberBase.cs:283
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<TumorSatellite> All()                                                                                               // BuildMemberBase.cs:286
	    {                                                                                                                                      // BuildMemberBase.cs:287
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:288
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:289
	    }                                                                                                                                      // BuildMemberBase.cs:290
	                                                                                                                                           // BuildMemberBase.cs:292
	    // BuildMemberBase.cs:293
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public TumorSatellite GetAt(Int32 i) => this.items[i].Value;                                                                           // BuildMemberBase.cs:296
	                                                                                                                                           // BuildMemberBase.cs:298
	    // BuildMemberBase.cs:299
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:302
	                                                                                                                                           // BuildMemberBase.cs:304
	    // BuildMemberBase.cs:305
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:308
	    #endregion                                                                                                                             // BuildMemberBase.cs:330
	                                                                                                                                           // BuildMemberBase.cs:171
	    // BuildMemberBase.cs:172
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public MTumorSatellite(Int32 min, Int32 max) : base("Observation.hasMember:tumorSatellite", min, max)                                  // BuildMemberBase.cs:175
	    {                                                                                                                                      // BuildMemberBase.cs:176
	    }                                                                                                                                      // BuildMemberBase.cs:178
	                                                                                                                                           // BuildMemberBase.cs:180
	    // Methods                                                                                                                             // BuildMemberBase.cs:181
	                                                                                                                                           // BuildMemberBase.cs:314
	    // BuildMemberBase.cs:315
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public TumorSatellite Append(TumorSatellite value)                                                                                     // BuildMemberBase.cs:318
	    {                                                                                                                                      // BuildMemberBase.cs:319
	        Item item = new Item();                                                                                                            // BuildMemberBase.cs:320
	        item.Value = value;                                                                                                                // BuildMemberBase.cs:321
	        this.items.Add(item);                                                                                                              // BuildMemberBase.cs:322
	        return value;                                                                                                                      // BuildMemberBase.cs:323
	    }                                                                                                                                      // BuildMemberBase.cs:324
	                                                                                                                                           // BuildMemberBase.cs:334
	    // BuildMemberBase.cs:335
	    /// <summary>
	    /// Write container items.
	    /// </summary>
	    public IEnumerable<ResourceReference> Write(BreastRadiologyDocument doc)                                                               // BuildMemberReferences.cs:96
	    {                                                                                                                                      // BuildMemberReferences.cs:97
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberReferences.cs:98
	        {                                                                                                                                  // BuildMemberReferences.cs:99
	            ResourceReference reference = item.WriteItem(doc);                                                                             // BuildMemberReferences.cs:100
	            yield return reference;                                                                                                        // BuildMemberReferences.cs:101
	        }                                                                                                                                  // BuildMemberReferences.cs:102
	    }                                                                                                                                      // BuildMemberReferences.cs:103
	                                                                                                                                           // BuildMemberBase.cs:340
	    // BuildMemberBase.cs:341
	    /// <summary>
	    /// Read container items.
	    /// </summary>
	                                                                                                                                           // BuildMemberReferences.cs:71
	    public void Read(BreastRadiologyDocument doc, IEnumerable<ResourceReference> references)                                               // BuildMemberReferences.cs:72
	    {                                                                                                                                      // BuildMemberReferences.cs:73
	        IEnumerable<ResourceReference> resourceReferences = base.IsMember(doc,                                                             // BuildMemberReferences.cs:74
	            references,                                                                                                                    // BuildMemberReferences.cs:75
	            this.targetUrls);                                                                                                              // BuildMemberReferences.cs:76
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberReferences.cs:77
	        foreach (ResourceReference resourceReference in resourceReferences)                                                                // BuildMemberReferences.cs:78
	        {                                                                                                                                  // BuildMemberReferences.cs:79
	            Item item = new Item();                                                                                                        // BuildMemberReferences.cs:80
	            item.ReadItem(doc, resourceReference);                                                                                         // BuildMemberReferences.cs:81
	            items.Add(item);                                                                                                               // BuildMemberReferences.cs:82
	        }                                                                                                                                  // BuildMemberReferences.cs:83
	        this.SetAllItems(items);                                                                                                           // BuildMemberReferences.cs:84
	    }                                                                                                                                      // BuildMemberReferences.cs:85
	}                                                                                                                                          // BuildMemberBase.cs:183
	#endregion                                                                                                                                 // BuildMemberBase.cs:184
	//- LocalClassDefs
}
