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
	#region Observation.hasMember:tumorSatellite Container Class                                                                               // BuildMemberBase.cs:174
	// Called from BuildMemberReferences.cs, Line 191
	// BuildMemberBase.cs:176
	/// <summary>
	/// Container class for Observation.hasMember:tumorSatellite.
	/// </summary>
	public class MTumorSatellite : MContainer, ITMItem<ResourceReference>                                                                      // BuildMemberBase.cs:179
	{                                                                                                                                          // BuildMemberBase.cs:180
	    #region Observation.hasMember:tumorSatellite Item Class                                                                                // BuildMemberBase.cs:81
	    // Called from BuildMemberReferences.cs, Line 191
	    // BuildMemberBase.cs:83
	    /// <summary>
	    /// Item class for Observation.hasMember:tumorSatellite.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:86
	    {                                                                                                                                      // BuildMemberBase.cs:87
	        // Properties                                                                                                                      // BuildMemberBase.cs:88
	        // BuildMemberBase.cs:90
	        /// <summary>
	        /// Value
	        /// </summary>
	        public TumorSatellite Value { get; set; }                                                                                          // BuildMemberBase.cs:93
	                                                                                                                                           // BuildMemberBase.cs:96
	        // BuildMemberBase.cs:97
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item()                                                                                                                      // BuildMemberBase.cs:100
	        {                                                                                                                                  // BuildMemberBase.cs:101
	        }                                                                                                                                  // BuildMemberBase.cs:103
	                                                                                                                                           // BuildMemberBase.cs:105
	        // Methods                                                                                                                         // BuildMemberBase.cs:106
	                                                                                                                                           // BuildMemberBase.cs:108
	        // BuildMemberBase.cs:109
	        /// <summary>
	        /// Write item.
	        /// </summary>
	        public ResourceReference WriteItem(BreastRadiologyDocument doc)                                                                    // BuildMemberBase.cs:112
	        {                                                                                                                                  // BuildMemberBase.cs:113
	            ResourceReference retVal = new ResourceReference                                                                               // BuildMemberReferences.cs:53
	            {                                                                                                                              // BuildMemberReferences.cs:54
	                Reference = this.Value.Id                                                                                                  // BuildMemberReferences.cs:55
	            };                                                                                                                             // BuildMemberReferences.cs:56
	            return retVal;                                                                                                                 // BuildMemberBase.cs:116
	        }                                                                                                                                  // BuildMemberBase.cs:117
	                                                                                                                                           // BuildMemberBase.cs:119
	        // BuildMemberBase.cs:120
	        /// <summary>
	        /// Read item.
	        /// </summary>
	        public void ReadItem(BreastRadiologyDocument doc, ResourceReference item)                                                          // BuildMemberBase.cs:123
	        {                                                                                                                                  // BuildMemberBase.cs:124
	            this.Value = (TumorSatellite) doc.GetResource(item);                                                                           // BuildMemberReferences.cs:46
	        }                                                                                                                                  // BuildMemberBase.cs:127
	    }                                                                                                                                      // BuildMemberBase.cs:130
	    #endregion                                                                                                                             // BuildMemberBase.cs:131
	                                                                                                                                           // BuildMemberBase.cs:183
	    // Properties                                                                                                                          // BuildMemberBase.cs:184
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:154
	    {                                                                                                                                      // BuildMemberBase.cs:155
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/TumorSatellite"                                                       // BuildMemberBase.cs:162
	    };                                                                                                                                     // BuildMemberBase.cs:163
	    #region Common Properties (Non-Singleton)                                                                                              // BuildMemberBase.cs:277
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:278
	                                                                                                                                           // BuildMemberBase.cs:280
	    // BuildMemberBase.cs:281
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:284
	                                                                                                                                           // BuildMemberBase.cs:286
	    // BuildMemberBase.cs:287
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:290
	                                                                                                                                           // BuildMemberBase.cs:292
	    // BuildMemberBase.cs:293
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:296
	                                                                                                                                           // BuildMemberBase.cs:298
	    // BuildMemberBase.cs:299
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<TumorSatellite> All()                                                                                               // BuildMemberBase.cs:302
	    {                                                                                                                                      // BuildMemberBase.cs:303
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:304
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:305
	    }                                                                                                                                      // BuildMemberBase.cs:306
	                                                                                                                                           // BuildMemberBase.cs:308
	    // BuildMemberBase.cs:309
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public TumorSatellite GetAt(Int32 i) => this.items[i].Value;                                                                           // BuildMemberBase.cs:312
	                                                                                                                                           // BuildMemberBase.cs:314
	    // BuildMemberBase.cs:315
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:318
	                                                                                                                                           // BuildMemberBase.cs:320
	    // BuildMemberBase.cs:321
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:324
	    #endregion                                                                                                                             // BuildMemberBase.cs:349
	                                                                                                                                           // BuildMemberBase.cs:187
	    // BuildMemberBase.cs:188
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public MTumorSatellite(Int32 min, Int32 max) : base("Observation.hasMember:tumorSatellite", min, max)                                  // BuildMemberBase.cs:191
	    {                                                                                                                                      // BuildMemberBase.cs:192
	    }                                                                                                                                      // BuildMemberBase.cs:194
	                                                                                                                                           // BuildMemberBase.cs:196
	    // Methods                                                                                                                             // BuildMemberBase.cs:197
	                                                                                                                                           // BuildMemberBase.cs:333
	    // BuildMemberBase.cs:334
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public TumorSatellite Append(TumorSatellite value)                                                                                     // BuildMemberBase.cs:337
	    {                                                                                                                                      // BuildMemberBase.cs:338
	        Item item = new Item();                                                                                                            // BuildMemberBase.cs:339
	        item.Value = value;                                                                                                                // BuildMemberBase.cs:340
	        this.items.Add(item);                                                                                                              // BuildMemberBase.cs:341
	        return value;                                                                                                                      // BuildMemberBase.cs:342
	    }                                                                                                                                      // BuildMemberBase.cs:343
	                                                                                                                                           // BuildMemberBase.cs:353
	    // BuildMemberBase.cs:354
	    /// <summary>
	    /// Write container items.
	    /// </summary>
	    public IEnumerable<ResourceReference> Write(BreastRadiologyDocument doc)                                                               // BuildMemberReferences.cs:88
	    {                                                                                                                                      // BuildMemberReferences.cs:89
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberReferences.cs:90
	        {                                                                                                                                  // BuildMemberReferences.cs:91
	            ResourceReference reference = item.WriteItem(doc);                                                                             // BuildMemberReferences.cs:92
	            yield return reference;                                                                                                        // BuildMemberReferences.cs:93
	        }                                                                                                                                  // BuildMemberReferences.cs:94
	    }                                                                                                                                      // BuildMemberReferences.cs:95
	                                                                                                                                           // BuildMemberBase.cs:359
	    // BuildMemberBase.cs:360
	    /// <summary>
	    /// Read container items.
	    /// </summary>
	                                                                                                                                           // BuildMemberReferences.cs:63
	    public void Read(BreastRadiologyDocument doc, IEnumerable<ResourceReference> references)                                               // BuildMemberReferences.cs:64
	    {                                                                                                                                      // BuildMemberReferences.cs:65
	        IEnumerable<ResourceReference> resourceReferences = base.IsMember(doc,                                                             // BuildMemberReferences.cs:66
	            references,                                                                                                                    // BuildMemberReferences.cs:67
	            this.targetUrls);                                                                                                              // BuildMemberReferences.cs:68
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberReferences.cs:69
	        foreach (ResourceReference resourceReference in resourceReferences)                                                                // BuildMemberReferences.cs:70
	        {                                                                                                                                  // BuildMemberReferences.cs:71
	            Item item = new Item();                                                                                                        // BuildMemberReferences.cs:72
	            item.ReadItem(doc, resourceReference);                                                                                         // BuildMemberReferences.cs:73
	            items.Add(item);                                                                                                               // BuildMemberReferences.cs:74
	        }                                                                                                                                  // BuildMemberReferences.cs:75
	        this.SetAllItems(items);                                                                                                           // BuildMemberReferences.cs:76
	    }                                                                                                                                      // BuildMemberReferences.cs:77
	}                                                                                                                                          // BuildMemberBase.cs:199
	#endregion                                                                                                                                 // BuildMemberBase.cs:200
	//- LocalClassDefs
}
