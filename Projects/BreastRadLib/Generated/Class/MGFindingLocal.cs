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

namespace BreastRadLib.MGFindingLocal
{
	//+ LocalClassDefs
	#region Observation.hasMember:abnormalityCyst Container Class                                                                              // BuildMemberBase.cs:157
	// Called from BuildMemberReferences.cs, Line 199
	// BuildMemberBase.cs:159
	/// <summary>
	/// Container class for Observation.hasMember:abnormalityCyst.
	/// </summary>
	public class AbnormalityCystContainer : MContainer, ITMItem<ResourceReference>                                                             // BuildMemberBase.cs:162
	{                                                                                                                                          // BuildMemberBase.cs:163
	    #region Observation.hasMember:abnormalityCyst Item Class                                                                               // BuildMemberBase.cs:75
	    // Called from BuildMemberReferences.cs, Line 199
	    // BuildMemberBase.cs:77
	    /// <summary>
	    /// Item class for Observation.hasMember:abnormalityCyst.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:80
	    {                                                                                                                                      // BuildMemberBase.cs:81
	        // Properties                                                                                                                      // BuildMemberBase.cs:82
	        // BuildMemberBase.cs:83
	        /// <summary>
	        /// Value
	        /// </summary>
	        public AbnormalityCyst Value { get; set; }                                                                                         // BuildMemberBase.cs:86
	                                                                                                                                           // BuildMemberBase.cs:89
	        // BuildMemberBase.cs:90
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item()                                                                                                                      // BuildMemberBase.cs:93
	        {                                                                                                                                  // BuildMemberBase.cs:94
	        }                                                                                                                                  // BuildMemberBase.cs:96
	                                                                                                                                           // BuildMemberBase.cs:98
	        // Methods                                                                                                                         // BuildMemberBase.cs:99
	                                                                                                                                           // BuildMemberBase.cs:101
	        // BuildMemberBase.cs:102
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
	                                                                                                                                           // BuildMemberBase.cs:107
	        // BuildMemberBase.cs:108
	        /// <summary>
	        /// Read item.
	        /// </summary>
	                                                                                                                                           // BuildMemberReferences.cs:46
	        public void ReadItem(BreastRadiologyDocument doc, ResourceReference reference)                                                     // BuildMemberReferences.cs:47
	        {                                                                                                                                  // BuildMemberReferences.cs:48
	            this.Value = (AbnormalityCyst) doc.GetResource(reference);                                                                     // BuildMemberReferences.cs:49
	        }                                                                                                                                  // BuildMemberReferences.cs:50
	    }                                                                                                                                      // BuildMemberBase.cs:114
	    #endregion                                                                                                                             // BuildMemberBase.cs:115
	                                                                                                                                           // BuildMemberBase.cs:166
	    // Properties                                                                                                                          // BuildMemberBase.cs:167
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:138
	    {                                                                                                                                      // BuildMemberBase.cs:139
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityCyst"                                                      // BuildMemberBase.cs:146
	    };                                                                                                                                     // BuildMemberBase.cs:147
	    #region Common Non-Singleton Properties                                                                                                // BuildMemberBase.cs:260
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:261
	                                                                                                                                           // BuildMemberBase.cs:263
	    // BuildMemberBase.cs:264
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:267
	                                                                                                                                           // BuildMemberBase.cs:269
	    // BuildMemberBase.cs:270
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:273
	                                                                                                                                           // BuildMemberBase.cs:275
	    // BuildMemberBase.cs:276
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:279
	                                                                                                                                           // BuildMemberBase.cs:281
	    // BuildMemberBase.cs:282
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<AbnormalityCyst> All()                                                                                              // BuildMemberBase.cs:285
	    {                                                                                                                                      // BuildMemberBase.cs:286
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:287
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:288
	    }                                                                                                                                      // BuildMemberBase.cs:289
	                                                                                                                                           // BuildMemberBase.cs:291
	    // BuildMemberBase.cs:292
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public AbnormalityCyst GetAt(Int32 i) => this.items[i].Value;                                                                          // BuildMemberBase.cs:295
	                                                                                                                                           // BuildMemberBase.cs:297
	    // BuildMemberBase.cs:298
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:301
	                                                                                                                                           // BuildMemberBase.cs:303
	    // BuildMemberBase.cs:304
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:307
	    #endregion                                                                                                                             // BuildMemberBase.cs:329
	                                                                                                                                           // BuildMemberBase.cs:170
	    // BuildMemberBase.cs:171
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public AbnormalityCystContainer(Int32 min, Int32 max) : base("Observation.hasMember:abnormalityCyst", min, max)                        // BuildMemberBase.cs:174
	    {                                                                                                                                      // BuildMemberBase.cs:175
	    }                                                                                                                                      // BuildMemberBase.cs:177
	                                                                                                                                           // BuildMemberBase.cs:179
	    // Methods                                                                                                                             // BuildMemberBase.cs:180
	                                                                                                                                           // BuildMemberBase.cs:313
	    // BuildMemberBase.cs:314
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public AbnormalityCyst Append(AbnormalityCyst value)                                                                                   // BuildMemberBase.cs:317
	    {                                                                                                                                      // BuildMemberBase.cs:318
	        Item item = new Item();                                                                                                            // BuildMemberBase.cs:319
	        item.Value = value;                                                                                                                // BuildMemberBase.cs:320
	        this.items.Add(item);                                                                                                              // BuildMemberBase.cs:321
	        return value;                                                                                                                      // BuildMemberBase.cs:322
	    }                                                                                                                                      // BuildMemberBase.cs:323
	                                                                                                                                           // BuildMemberBase.cs:333
	    // BuildMemberBase.cs:334
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
	                                                                                                                                           // BuildMemberBase.cs:339
	    // BuildMemberBase.cs:340
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
	}                                                                                                                                          // BuildMemberBase.cs:182
	#endregion                                                                                                                                 // BuildMemberBase.cs:183
	#region Observation.hasMember:abnormalityDuct Container Class                                                                              // BuildMemberBase.cs:157
	// Called from BuildMemberReferences.cs, Line 199
	// BuildMemberBase.cs:159
	/// <summary>
	/// Container class for Observation.hasMember:abnormalityDuct.
	/// </summary>
	public class AbnormalityDuctContainer : MContainer, ITMItem<ResourceReference>                                                             // BuildMemberBase.cs:162
	{                                                                                                                                          // BuildMemberBase.cs:163
	    #region Observation.hasMember:abnormalityDuct Item Class                                                                               // BuildMemberBase.cs:75
	    // Called from BuildMemberReferences.cs, Line 199
	    // BuildMemberBase.cs:77
	    /// <summary>
	    /// Item class for Observation.hasMember:abnormalityDuct.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:80
	    {                                                                                                                                      // BuildMemberBase.cs:81
	        // Properties                                                                                                                      // BuildMemberBase.cs:82
	        // BuildMemberBase.cs:83
	        /// <summary>
	        /// Value
	        /// </summary>
	        public AbnormalityDuct Value { get; set; }                                                                                         // BuildMemberBase.cs:86
	                                                                                                                                           // BuildMemberBase.cs:89
	        // BuildMemberBase.cs:90
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item()                                                                                                                      // BuildMemberBase.cs:93
	        {                                                                                                                                  // BuildMemberBase.cs:94
	        }                                                                                                                                  // BuildMemberBase.cs:96
	                                                                                                                                           // BuildMemberBase.cs:98
	        // Methods                                                                                                                         // BuildMemberBase.cs:99
	                                                                                                                                           // BuildMemberBase.cs:101
	        // BuildMemberBase.cs:102
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
	                                                                                                                                           // BuildMemberBase.cs:107
	        // BuildMemberBase.cs:108
	        /// <summary>
	        /// Read item.
	        /// </summary>
	                                                                                                                                           // BuildMemberReferences.cs:46
	        public void ReadItem(BreastRadiologyDocument doc, ResourceReference reference)                                                     // BuildMemberReferences.cs:47
	        {                                                                                                                                  // BuildMemberReferences.cs:48
	            this.Value = (AbnormalityDuct) doc.GetResource(reference);                                                                     // BuildMemberReferences.cs:49
	        }                                                                                                                                  // BuildMemberReferences.cs:50
	    }                                                                                                                                      // BuildMemberBase.cs:114
	    #endregion                                                                                                                             // BuildMemberBase.cs:115
	                                                                                                                                           // BuildMemberBase.cs:166
	    // Properties                                                                                                                          // BuildMemberBase.cs:167
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:138
	    {                                                                                                                                      // BuildMemberBase.cs:139
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityDuct"                                                      // BuildMemberBase.cs:146
	    };                                                                                                                                     // BuildMemberBase.cs:147
	    #region Common Non-Singleton Properties                                                                                                // BuildMemberBase.cs:260
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:261
	                                                                                                                                           // BuildMemberBase.cs:263
	    // BuildMemberBase.cs:264
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:267
	                                                                                                                                           // BuildMemberBase.cs:269
	    // BuildMemberBase.cs:270
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:273
	                                                                                                                                           // BuildMemberBase.cs:275
	    // BuildMemberBase.cs:276
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:279
	                                                                                                                                           // BuildMemberBase.cs:281
	    // BuildMemberBase.cs:282
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<AbnormalityDuct> All()                                                                                              // BuildMemberBase.cs:285
	    {                                                                                                                                      // BuildMemberBase.cs:286
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:287
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:288
	    }                                                                                                                                      // BuildMemberBase.cs:289
	                                                                                                                                           // BuildMemberBase.cs:291
	    // BuildMemberBase.cs:292
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public AbnormalityDuct GetAt(Int32 i) => this.items[i].Value;                                                                          // BuildMemberBase.cs:295
	                                                                                                                                           // BuildMemberBase.cs:297
	    // BuildMemberBase.cs:298
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:301
	                                                                                                                                           // BuildMemberBase.cs:303
	    // BuildMemberBase.cs:304
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:307
	    #endregion                                                                                                                             // BuildMemberBase.cs:329
	                                                                                                                                           // BuildMemberBase.cs:170
	    // BuildMemberBase.cs:171
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public AbnormalityDuctContainer(Int32 min, Int32 max) : base("Observation.hasMember:abnormalityDuct", min, max)                        // BuildMemberBase.cs:174
	    {                                                                                                                                      // BuildMemberBase.cs:175
	    }                                                                                                                                      // BuildMemberBase.cs:177
	                                                                                                                                           // BuildMemberBase.cs:179
	    // Methods                                                                                                                             // BuildMemberBase.cs:180
	                                                                                                                                           // BuildMemberBase.cs:313
	    // BuildMemberBase.cs:314
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public AbnormalityDuct Append(AbnormalityDuct value)                                                                                   // BuildMemberBase.cs:317
	    {                                                                                                                                      // BuildMemberBase.cs:318
	        Item item = new Item();                                                                                                            // BuildMemberBase.cs:319
	        item.Value = value;                                                                                                                // BuildMemberBase.cs:320
	        this.items.Add(item);                                                                                                              // BuildMemberBase.cs:321
	        return value;                                                                                                                      // BuildMemberBase.cs:322
	    }                                                                                                                                      // BuildMemberBase.cs:323
	                                                                                                                                           // BuildMemberBase.cs:333
	    // BuildMemberBase.cs:334
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
	                                                                                                                                           // BuildMemberBase.cs:339
	    // BuildMemberBase.cs:340
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
	}                                                                                                                                          // BuildMemberBase.cs:182
	#endregion                                                                                                                                 // BuildMemberBase.cs:183
	#region Observation.hasMember:abnormalityForeignObject Container Class                                                                     // BuildMemberBase.cs:157
	// Called from BuildMemberReferences.cs, Line 199
	// BuildMemberBase.cs:159
	/// <summary>
	/// Container class for Observation.hasMember:abnormalityForeignObject.
	/// </summary>
	public class AbnormalityForeignObjectContainer : MContainer, ITMItem<ResourceReference>                                                    // BuildMemberBase.cs:162
	{                                                                                                                                          // BuildMemberBase.cs:163
	    #region Observation.hasMember:abnormalityForeignObject Item Class                                                                      // BuildMemberBase.cs:75
	    // Called from BuildMemberReferences.cs, Line 199
	    // BuildMemberBase.cs:77
	    /// <summary>
	    /// Item class for Observation.hasMember:abnormalityForeignObject.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:80
	    {                                                                                                                                      // BuildMemberBase.cs:81
	        // Properties                                                                                                                      // BuildMemberBase.cs:82
	        // BuildMemberBase.cs:83
	        /// <summary>
	        /// Value
	        /// </summary>
	        public AbnormalityForeignObject Value { get; set; }                                                                                // BuildMemberBase.cs:86
	                                                                                                                                           // BuildMemberBase.cs:89
	        // BuildMemberBase.cs:90
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item()                                                                                                                      // BuildMemberBase.cs:93
	        {                                                                                                                                  // BuildMemberBase.cs:94
	        }                                                                                                                                  // BuildMemberBase.cs:96
	                                                                                                                                           // BuildMemberBase.cs:98
	        // Methods                                                                                                                         // BuildMemberBase.cs:99
	                                                                                                                                           // BuildMemberBase.cs:101
	        // BuildMemberBase.cs:102
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
	                                                                                                                                           // BuildMemberBase.cs:107
	        // BuildMemberBase.cs:108
	        /// <summary>
	        /// Read item.
	        /// </summary>
	                                                                                                                                           // BuildMemberReferences.cs:46
	        public void ReadItem(BreastRadiologyDocument doc, ResourceReference reference)                                                     // BuildMemberReferences.cs:47
	        {                                                                                                                                  // BuildMemberReferences.cs:48
	            this.Value = (AbnormalityForeignObject) doc.GetResource(reference);                                                            // BuildMemberReferences.cs:49
	        }                                                                                                                                  // BuildMemberReferences.cs:50
	    }                                                                                                                                      // BuildMemberBase.cs:114
	    #endregion                                                                                                                             // BuildMemberBase.cs:115
	                                                                                                                                           // BuildMemberBase.cs:166
	    // Properties                                                                                                                          // BuildMemberBase.cs:167
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:138
	    {                                                                                                                                      // BuildMemberBase.cs:139
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityForeignObject"                                             // BuildMemberBase.cs:146
	    };                                                                                                                                     // BuildMemberBase.cs:147
	    #region Common Non-Singleton Properties                                                                                                // BuildMemberBase.cs:260
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:261
	                                                                                                                                           // BuildMemberBase.cs:263
	    // BuildMemberBase.cs:264
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:267
	                                                                                                                                           // BuildMemberBase.cs:269
	    // BuildMemberBase.cs:270
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:273
	                                                                                                                                           // BuildMemberBase.cs:275
	    // BuildMemberBase.cs:276
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:279
	                                                                                                                                           // BuildMemberBase.cs:281
	    // BuildMemberBase.cs:282
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<AbnormalityForeignObject> All()                                                                                     // BuildMemberBase.cs:285
	    {                                                                                                                                      // BuildMemberBase.cs:286
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:287
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:288
	    }                                                                                                                                      // BuildMemberBase.cs:289
	                                                                                                                                           // BuildMemberBase.cs:291
	    // BuildMemberBase.cs:292
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public AbnormalityForeignObject GetAt(Int32 i) => this.items[i].Value;                                                                 // BuildMemberBase.cs:295
	                                                                                                                                           // BuildMemberBase.cs:297
	    // BuildMemberBase.cs:298
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:301
	                                                                                                                                           // BuildMemberBase.cs:303
	    // BuildMemberBase.cs:304
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:307
	    #endregion                                                                                                                             // BuildMemberBase.cs:329
	                                                                                                                                           // BuildMemberBase.cs:170
	    // BuildMemberBase.cs:171
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public AbnormalityForeignObjectContainer(Int32 min, Int32 max) : base("Observation.hasMember:abnormalityForeignObject", min, max)      // BuildMemberBase.cs:174
	    {                                                                                                                                      // BuildMemberBase.cs:175
	    }                                                                                                                                      // BuildMemberBase.cs:177
	                                                                                                                                           // BuildMemberBase.cs:179
	    // Methods                                                                                                                             // BuildMemberBase.cs:180
	                                                                                                                                           // BuildMemberBase.cs:313
	    // BuildMemberBase.cs:314
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public AbnormalityForeignObject Append(AbnormalityForeignObject value)                                                                 // BuildMemberBase.cs:317
	    {                                                                                                                                      // BuildMemberBase.cs:318
	        Item item = new Item();                                                                                                            // BuildMemberBase.cs:319
	        item.Value = value;                                                                                                                // BuildMemberBase.cs:320
	        this.items.Add(item);                                                                                                              // BuildMemberBase.cs:321
	        return value;                                                                                                                      // BuildMemberBase.cs:322
	    }                                                                                                                                      // BuildMemberBase.cs:323
	                                                                                                                                           // BuildMemberBase.cs:333
	    // BuildMemberBase.cs:334
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
	                                                                                                                                           // BuildMemberBase.cs:339
	    // BuildMemberBase.cs:340
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
	}                                                                                                                                          // BuildMemberBase.cs:182
	#endregion                                                                                                                                 // BuildMemberBase.cs:183
	#region Observation.hasMember:abnormalityLymphNode Container Class                                                                         // BuildMemberBase.cs:157
	// Called from BuildMemberReferences.cs, Line 199
	// BuildMemberBase.cs:159
	/// <summary>
	/// Container class for Observation.hasMember:abnormalityLymphNode.
	/// </summary>
	public class AbnormalityLymphNodeContainer : MContainer, ITMItem<ResourceReference>                                                        // BuildMemberBase.cs:162
	{                                                                                                                                          // BuildMemberBase.cs:163
	    #region Observation.hasMember:abnormalityLymphNode Item Class                                                                          // BuildMemberBase.cs:75
	    // Called from BuildMemberReferences.cs, Line 199
	    // BuildMemberBase.cs:77
	    /// <summary>
	    /// Item class for Observation.hasMember:abnormalityLymphNode.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:80
	    {                                                                                                                                      // BuildMemberBase.cs:81
	        // Properties                                                                                                                      // BuildMemberBase.cs:82
	        // BuildMemberBase.cs:83
	        /// <summary>
	        /// Value
	        /// </summary>
	        public AbnormalityLymphNode Value { get; set; }                                                                                    // BuildMemberBase.cs:86
	                                                                                                                                           // BuildMemberBase.cs:89
	        // BuildMemberBase.cs:90
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item()                                                                                                                      // BuildMemberBase.cs:93
	        {                                                                                                                                  // BuildMemberBase.cs:94
	        }                                                                                                                                  // BuildMemberBase.cs:96
	                                                                                                                                           // BuildMemberBase.cs:98
	        // Methods                                                                                                                         // BuildMemberBase.cs:99
	                                                                                                                                           // BuildMemberBase.cs:101
	        // BuildMemberBase.cs:102
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
	                                                                                                                                           // BuildMemberBase.cs:107
	        // BuildMemberBase.cs:108
	        /// <summary>
	        /// Read item.
	        /// </summary>
	                                                                                                                                           // BuildMemberReferences.cs:46
	        public void ReadItem(BreastRadiologyDocument doc, ResourceReference reference)                                                     // BuildMemberReferences.cs:47
	        {                                                                                                                                  // BuildMemberReferences.cs:48
	            this.Value = (AbnormalityLymphNode) doc.GetResource(reference);                                                                // BuildMemberReferences.cs:49
	        }                                                                                                                                  // BuildMemberReferences.cs:50
	    }                                                                                                                                      // BuildMemberBase.cs:114
	    #endregion                                                                                                                             // BuildMemberBase.cs:115
	                                                                                                                                           // BuildMemberBase.cs:166
	    // Properties                                                                                                                          // BuildMemberBase.cs:167
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:138
	    {                                                                                                                                      // BuildMemberBase.cs:139
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityLymphNode"                                                 // BuildMemberBase.cs:146
	    };                                                                                                                                     // BuildMemberBase.cs:147
	    #region Common Non-Singleton Properties                                                                                                // BuildMemberBase.cs:260
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:261
	                                                                                                                                           // BuildMemberBase.cs:263
	    // BuildMemberBase.cs:264
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:267
	                                                                                                                                           // BuildMemberBase.cs:269
	    // BuildMemberBase.cs:270
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:273
	                                                                                                                                           // BuildMemberBase.cs:275
	    // BuildMemberBase.cs:276
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:279
	                                                                                                                                           // BuildMemberBase.cs:281
	    // BuildMemberBase.cs:282
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<AbnormalityLymphNode> All()                                                                                         // BuildMemberBase.cs:285
	    {                                                                                                                                      // BuildMemberBase.cs:286
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:287
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:288
	    }                                                                                                                                      // BuildMemberBase.cs:289
	                                                                                                                                           // BuildMemberBase.cs:291
	    // BuildMemberBase.cs:292
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public AbnormalityLymphNode GetAt(Int32 i) => this.items[i].Value;                                                                     // BuildMemberBase.cs:295
	                                                                                                                                           // BuildMemberBase.cs:297
	    // BuildMemberBase.cs:298
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:301
	                                                                                                                                           // BuildMemberBase.cs:303
	    // BuildMemberBase.cs:304
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:307
	    #endregion                                                                                                                             // BuildMemberBase.cs:329
	                                                                                                                                           // BuildMemberBase.cs:170
	    // BuildMemberBase.cs:171
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public AbnormalityLymphNodeContainer(Int32 min, Int32 max) : base("Observation.hasMember:abnormalityLymphNode", min, max)              // BuildMemberBase.cs:174
	    {                                                                                                                                      // BuildMemberBase.cs:175
	    }                                                                                                                                      // BuildMemberBase.cs:177
	                                                                                                                                           // BuildMemberBase.cs:179
	    // Methods                                                                                                                             // BuildMemberBase.cs:180
	                                                                                                                                           // BuildMemberBase.cs:313
	    // BuildMemberBase.cs:314
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public AbnormalityLymphNode Append(AbnormalityLymphNode value)                                                                         // BuildMemberBase.cs:317
	    {                                                                                                                                      // BuildMemberBase.cs:318
	        Item item = new Item();                                                                                                            // BuildMemberBase.cs:319
	        item.Value = value;                                                                                                                // BuildMemberBase.cs:320
	        this.items.Add(item);                                                                                                              // BuildMemberBase.cs:321
	        return value;                                                                                                                      // BuildMemberBase.cs:322
	    }                                                                                                                                      // BuildMemberBase.cs:323
	                                                                                                                                           // BuildMemberBase.cs:333
	    // BuildMemberBase.cs:334
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
	                                                                                                                                           // BuildMemberBase.cs:339
	    // BuildMemberBase.cs:340
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
	}                                                                                                                                          // BuildMemberBase.cs:182
	#endregion                                                                                                                                 // BuildMemberBase.cs:183
	#region Observation.hasMember:abnormalityMass Container Class                                                                              // BuildMemberBase.cs:157
	// Called from BuildMemberReferences.cs, Line 199
	// BuildMemberBase.cs:159
	/// <summary>
	/// Container class for Observation.hasMember:abnormalityMass.
	/// </summary>
	public class AbnormalityMassContainer : MContainer, ITMItem<ResourceReference>                                                             // BuildMemberBase.cs:162
	{                                                                                                                                          // BuildMemberBase.cs:163
	    #region Observation.hasMember:abnormalityMass Item Class                                                                               // BuildMemberBase.cs:75
	    // Called from BuildMemberReferences.cs, Line 199
	    // BuildMemberBase.cs:77
	    /// <summary>
	    /// Item class for Observation.hasMember:abnormalityMass.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:80
	    {                                                                                                                                      // BuildMemberBase.cs:81
	        // Properties                                                                                                                      // BuildMemberBase.cs:82
	        // BuildMemberBase.cs:83
	        /// <summary>
	        /// Value
	        /// </summary>
	        public AbnormalityMass Value { get; set; }                                                                                         // BuildMemberBase.cs:86
	                                                                                                                                           // BuildMemberBase.cs:89
	        // BuildMemberBase.cs:90
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item()                                                                                                                      // BuildMemberBase.cs:93
	        {                                                                                                                                  // BuildMemberBase.cs:94
	        }                                                                                                                                  // BuildMemberBase.cs:96
	                                                                                                                                           // BuildMemberBase.cs:98
	        // Methods                                                                                                                         // BuildMemberBase.cs:99
	                                                                                                                                           // BuildMemberBase.cs:101
	        // BuildMemberBase.cs:102
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
	                                                                                                                                           // BuildMemberBase.cs:107
	        // BuildMemberBase.cs:108
	        /// <summary>
	        /// Read item.
	        /// </summary>
	                                                                                                                                           // BuildMemberReferences.cs:46
	        public void ReadItem(BreastRadiologyDocument doc, ResourceReference reference)                                                     // BuildMemberReferences.cs:47
	        {                                                                                                                                  // BuildMemberReferences.cs:48
	            this.Value = (AbnormalityMass) doc.GetResource(reference);                                                                     // BuildMemberReferences.cs:49
	        }                                                                                                                                  // BuildMemberReferences.cs:50
	    }                                                                                                                                      // BuildMemberBase.cs:114
	    #endregion                                                                                                                             // BuildMemberBase.cs:115
	                                                                                                                                           // BuildMemberBase.cs:166
	    // Properties                                                                                                                          // BuildMemberBase.cs:167
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:138
	    {                                                                                                                                      // BuildMemberBase.cs:139
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityMass"                                                      // BuildMemberBase.cs:146
	    };                                                                                                                                     // BuildMemberBase.cs:147
	    #region Common Non-Singleton Properties                                                                                                // BuildMemberBase.cs:260
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:261
	                                                                                                                                           // BuildMemberBase.cs:263
	    // BuildMemberBase.cs:264
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:267
	                                                                                                                                           // BuildMemberBase.cs:269
	    // BuildMemberBase.cs:270
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:273
	                                                                                                                                           // BuildMemberBase.cs:275
	    // BuildMemberBase.cs:276
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:279
	                                                                                                                                           // BuildMemberBase.cs:281
	    // BuildMemberBase.cs:282
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<AbnormalityMass> All()                                                                                              // BuildMemberBase.cs:285
	    {                                                                                                                                      // BuildMemberBase.cs:286
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:287
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:288
	    }                                                                                                                                      // BuildMemberBase.cs:289
	                                                                                                                                           // BuildMemberBase.cs:291
	    // BuildMemberBase.cs:292
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public AbnormalityMass GetAt(Int32 i) => this.items[i].Value;                                                                          // BuildMemberBase.cs:295
	                                                                                                                                           // BuildMemberBase.cs:297
	    // BuildMemberBase.cs:298
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:301
	                                                                                                                                           // BuildMemberBase.cs:303
	    // BuildMemberBase.cs:304
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:307
	    #endregion                                                                                                                             // BuildMemberBase.cs:329
	                                                                                                                                           // BuildMemberBase.cs:170
	    // BuildMemberBase.cs:171
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public AbnormalityMassContainer(Int32 min, Int32 max) : base("Observation.hasMember:abnormalityMass", min, max)                        // BuildMemberBase.cs:174
	    {                                                                                                                                      // BuildMemberBase.cs:175
	    }                                                                                                                                      // BuildMemberBase.cs:177
	                                                                                                                                           // BuildMemberBase.cs:179
	    // Methods                                                                                                                             // BuildMemberBase.cs:180
	                                                                                                                                           // BuildMemberBase.cs:313
	    // BuildMemberBase.cs:314
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public AbnormalityMass Append(AbnormalityMass value)                                                                                   // BuildMemberBase.cs:317
	    {                                                                                                                                      // BuildMemberBase.cs:318
	        Item item = new Item();                                                                                                            // BuildMemberBase.cs:319
	        item.Value = value;                                                                                                                // BuildMemberBase.cs:320
	        this.items.Add(item);                                                                                                              // BuildMemberBase.cs:321
	        return value;                                                                                                                      // BuildMemberBase.cs:322
	    }                                                                                                                                      // BuildMemberBase.cs:323
	                                                                                                                                           // BuildMemberBase.cs:333
	    // BuildMemberBase.cs:334
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
	                                                                                                                                           // BuildMemberBase.cs:339
	    // BuildMemberBase.cs:340
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
	}                                                                                                                                          // BuildMemberBase.cs:182
	#endregion                                                                                                                                 // BuildMemberBase.cs:183
	#region Observation.hasMember:associatedFeature Container Class                                                                            // BuildMemberBase.cs:157
	// Called from BuildMemberReferences.cs, Line 199
	// BuildMemberBase.cs:159
	/// <summary>
	/// Container class for Observation.hasMember:associatedFeature.
	/// </summary>
	public class AssociatedFeatureContainer : MContainer, ITMItem<ResourceReference>                                                           // BuildMemberBase.cs:162
	{                                                                                                                                          // BuildMemberBase.cs:163
	    #region Observation.hasMember:associatedFeature Item Class                                                                             // BuildMemberBase.cs:75
	    // Called from BuildMemberReferences.cs, Line 199
	    // BuildMemberBase.cs:77
	    /// <summary>
	    /// Item class for Observation.hasMember:associatedFeature.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:80
	    {                                                                                                                                      // BuildMemberBase.cs:81
	        // Properties                                                                                                                      // BuildMemberBase.cs:82
	        // BuildMemberBase.cs:83
	        /// <summary>
	        /// Value
	        /// </summary>
	        public AssociatedFeature Value { get; set; }                                                                                       // BuildMemberBase.cs:86
	                                                                                                                                           // BuildMemberBase.cs:89
	        // BuildMemberBase.cs:90
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item()                                                                                                                      // BuildMemberBase.cs:93
	        {                                                                                                                                  // BuildMemberBase.cs:94
	        }                                                                                                                                  // BuildMemberBase.cs:96
	                                                                                                                                           // BuildMemberBase.cs:98
	        // Methods                                                                                                                         // BuildMemberBase.cs:99
	                                                                                                                                           // BuildMemberBase.cs:101
	        // BuildMemberBase.cs:102
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
	                                                                                                                                           // BuildMemberBase.cs:107
	        // BuildMemberBase.cs:108
	        /// <summary>
	        /// Read item.
	        /// </summary>
	                                                                                                                                           // BuildMemberReferences.cs:46
	        public void ReadItem(BreastRadiologyDocument doc, ResourceReference reference)                                                     // BuildMemberReferences.cs:47
	        {                                                                                                                                  // BuildMemberReferences.cs:48
	            this.Value = (AssociatedFeature) doc.GetResource(reference);                                                                   // BuildMemberReferences.cs:49
	        }                                                                                                                                  // BuildMemberReferences.cs:50
	    }                                                                                                                                      // BuildMemberBase.cs:114
	    #endregion                                                                                                                             // BuildMemberBase.cs:115
	                                                                                                                                           // BuildMemberBase.cs:166
	    // Properties                                                                                                                          // BuildMemberBase.cs:167
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:138
	    {                                                                                                                                      // BuildMemberBase.cs:139
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AssociatedFeature"                                                    // BuildMemberBase.cs:146
	    };                                                                                                                                     // BuildMemberBase.cs:147
	    #region Common Non-Singleton Properties                                                                                                // BuildMemberBase.cs:260
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:261
	                                                                                                                                           // BuildMemberBase.cs:263
	    // BuildMemberBase.cs:264
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:267
	                                                                                                                                           // BuildMemberBase.cs:269
	    // BuildMemberBase.cs:270
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:273
	                                                                                                                                           // BuildMemberBase.cs:275
	    // BuildMemberBase.cs:276
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:279
	                                                                                                                                           // BuildMemberBase.cs:281
	    // BuildMemberBase.cs:282
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<AssociatedFeature> All()                                                                                            // BuildMemberBase.cs:285
	    {                                                                                                                                      // BuildMemberBase.cs:286
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:287
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:288
	    }                                                                                                                                      // BuildMemberBase.cs:289
	                                                                                                                                           // BuildMemberBase.cs:291
	    // BuildMemberBase.cs:292
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public AssociatedFeature GetAt(Int32 i) => this.items[i].Value;                                                                        // BuildMemberBase.cs:295
	                                                                                                                                           // BuildMemberBase.cs:297
	    // BuildMemberBase.cs:298
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:301
	                                                                                                                                           // BuildMemberBase.cs:303
	    // BuildMemberBase.cs:304
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:307
	    #endregion                                                                                                                             // BuildMemberBase.cs:329
	                                                                                                                                           // BuildMemberBase.cs:170
	    // BuildMemberBase.cs:171
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public AssociatedFeatureContainer(Int32 min, Int32 max) : base("Observation.hasMember:associatedFeature", min, max)                    // BuildMemberBase.cs:174
	    {                                                                                                                                      // BuildMemberBase.cs:175
	    }                                                                                                                                      // BuildMemberBase.cs:177
	                                                                                                                                           // BuildMemberBase.cs:179
	    // Methods                                                                                                                             // BuildMemberBase.cs:180
	                                                                                                                                           // BuildMemberBase.cs:313
	    // BuildMemberBase.cs:314
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public AssociatedFeature Append(AssociatedFeature value)                                                                               // BuildMemberBase.cs:317
	    {                                                                                                                                      // BuildMemberBase.cs:318
	        Item item = new Item();                                                                                                            // BuildMemberBase.cs:319
	        item.Value = value;                                                                                                                // BuildMemberBase.cs:320
	        this.items.Add(item);                                                                                                              // BuildMemberBase.cs:321
	        return value;                                                                                                                      // BuildMemberBase.cs:322
	    }                                                                                                                                      // BuildMemberBase.cs:323
	                                                                                                                                           // BuildMemberBase.cs:333
	    // BuildMemberBase.cs:334
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
	                                                                                                                                           // BuildMemberBase.cs:339
	    // BuildMemberBase.cs:340
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
	}                                                                                                                                          // BuildMemberBase.cs:182
	#endregion                                                                                                                                 // BuildMemberBase.cs:183
	#region Observation.hasMember:abnormalityFibroadenoma Container Class                                                                      // BuildMemberBase.cs:157
	// Called from BuildMemberReferences.cs, Line 199
	// BuildMemberBase.cs:159
	/// <summary>
	/// Container class for Observation.hasMember:abnormalityFibroadenoma.
	/// </summary>
	public class AbnormalityFibroadenomaContainer : MContainer, ITMItem<ResourceReference>                                                     // BuildMemberBase.cs:162
	{                                                                                                                                          // BuildMemberBase.cs:163
	    #region Observation.hasMember:abnormalityFibroadenoma Item Class                                                                       // BuildMemberBase.cs:75
	    // Called from BuildMemberReferences.cs, Line 199
	    // BuildMemberBase.cs:77
	    /// <summary>
	    /// Item class for Observation.hasMember:abnormalityFibroadenoma.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:80
	    {                                                                                                                                      // BuildMemberBase.cs:81
	        // Properties                                                                                                                      // BuildMemberBase.cs:82
	        // BuildMemberBase.cs:83
	        /// <summary>
	        /// Value
	        /// </summary>
	        public AbnormalityFibroadenoma Value { get; set; }                                                                                 // BuildMemberBase.cs:86
	                                                                                                                                           // BuildMemberBase.cs:89
	        // BuildMemberBase.cs:90
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item()                                                                                                                      // BuildMemberBase.cs:93
	        {                                                                                                                                  // BuildMemberBase.cs:94
	        }                                                                                                                                  // BuildMemberBase.cs:96
	                                                                                                                                           // BuildMemberBase.cs:98
	        // Methods                                                                                                                         // BuildMemberBase.cs:99
	                                                                                                                                           // BuildMemberBase.cs:101
	        // BuildMemberBase.cs:102
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
	                                                                                                                                           // BuildMemberBase.cs:107
	        // BuildMemberBase.cs:108
	        /// <summary>
	        /// Read item.
	        /// </summary>
	                                                                                                                                           // BuildMemberReferences.cs:46
	        public void ReadItem(BreastRadiologyDocument doc, ResourceReference reference)                                                     // BuildMemberReferences.cs:47
	        {                                                                                                                                  // BuildMemberReferences.cs:48
	            this.Value = (AbnormalityFibroadenoma) doc.GetResource(reference);                                                             // BuildMemberReferences.cs:49
	        }                                                                                                                                  // BuildMemberReferences.cs:50
	    }                                                                                                                                      // BuildMemberBase.cs:114
	    #endregion                                                                                                                             // BuildMemberBase.cs:115
	                                                                                                                                           // BuildMemberBase.cs:166
	    // Properties                                                                                                                          // BuildMemberBase.cs:167
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:138
	    {                                                                                                                                      // BuildMemberBase.cs:139
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityFibroadenoma"                                              // BuildMemberBase.cs:146
	    };                                                                                                                                     // BuildMemberBase.cs:147
	    #region Common Non-Singleton Properties                                                                                                // BuildMemberBase.cs:260
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:261
	                                                                                                                                           // BuildMemberBase.cs:263
	    // BuildMemberBase.cs:264
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:267
	                                                                                                                                           // BuildMemberBase.cs:269
	    // BuildMemberBase.cs:270
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:273
	                                                                                                                                           // BuildMemberBase.cs:275
	    // BuildMemberBase.cs:276
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:279
	                                                                                                                                           // BuildMemberBase.cs:281
	    // BuildMemberBase.cs:282
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<AbnormalityFibroadenoma> All()                                                                                      // BuildMemberBase.cs:285
	    {                                                                                                                                      // BuildMemberBase.cs:286
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:287
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:288
	    }                                                                                                                                      // BuildMemberBase.cs:289
	                                                                                                                                           // BuildMemberBase.cs:291
	    // BuildMemberBase.cs:292
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public AbnormalityFibroadenoma GetAt(Int32 i) => this.items[i].Value;                                                                  // BuildMemberBase.cs:295
	                                                                                                                                           // BuildMemberBase.cs:297
	    // BuildMemberBase.cs:298
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:301
	                                                                                                                                           // BuildMemberBase.cs:303
	    // BuildMemberBase.cs:304
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:307
	    #endregion                                                                                                                             // BuildMemberBase.cs:329
	                                                                                                                                           // BuildMemberBase.cs:170
	    // BuildMemberBase.cs:171
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public AbnormalityFibroadenomaContainer(Int32 min, Int32 max) : base("Observation.hasMember:abnormalityFibroadenoma", min, max)        // BuildMemberBase.cs:174
	    {                                                                                                                                      // BuildMemberBase.cs:175
	    }                                                                                                                                      // BuildMemberBase.cs:177
	                                                                                                                                           // BuildMemberBase.cs:179
	    // Methods                                                                                                                             // BuildMemberBase.cs:180
	                                                                                                                                           // BuildMemberBase.cs:313
	    // BuildMemberBase.cs:314
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public AbnormalityFibroadenoma Append(AbnormalityFibroadenoma value)                                                                   // BuildMemberBase.cs:317
	    {                                                                                                                                      // BuildMemberBase.cs:318
	        Item item = new Item();                                                                                                            // BuildMemberBase.cs:319
	        item.Value = value;                                                                                                                // BuildMemberBase.cs:320
	        this.items.Add(item);                                                                                                              // BuildMemberBase.cs:321
	        return value;                                                                                                                      // BuildMemberBase.cs:322
	    }                                                                                                                                      // BuildMemberBase.cs:323
	                                                                                                                                           // BuildMemberBase.cs:333
	    // BuildMemberBase.cs:334
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
	                                                                                                                                           // BuildMemberBase.cs:339
	    // BuildMemberBase.cs:340
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
	}                                                                                                                                          // BuildMemberBase.cs:182
	#endregion                                                                                                                                 // BuildMemberBase.cs:183
	#region Observation.hasMember:mGAbnormalityArchitecturalDistortion Container Class                                                         // BuildMemberBase.cs:157
	// Called from BuildMemberReferences.cs, Line 199
	// BuildMemberBase.cs:159
	/// <summary>
	/// Container class for Observation.hasMember:mGAbnormalityArchitecturalDistortion.
	/// </summary>
	public class MGAbnormalityArchitecturalDistortionContainer : MContainer, ITMItem<ResourceReference>                                        // BuildMemberBase.cs:162
	{                                                                                                                                          // BuildMemberBase.cs:163
	    #region Observation.hasMember:mGAbnormalityArchitecturalDistortion Item Class                                                          // BuildMemberBase.cs:75
	    // Called from BuildMemberReferences.cs, Line 199
	    // BuildMemberBase.cs:77
	    /// <summary>
	    /// Item class for Observation.hasMember:mGAbnormalityArchitecturalDistortion.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:80
	    {                                                                                                                                      // BuildMemberBase.cs:81
	        // Properties                                                                                                                      // BuildMemberBase.cs:82
	        // BuildMemberBase.cs:83
	        /// <summary>
	        /// Value
	        /// </summary>
	        public MGAbnormalityArchitecturalDistortion Value { get; set; }                                                                    // BuildMemberBase.cs:86
	                                                                                                                                           // BuildMemberBase.cs:89
	        // BuildMemberBase.cs:90
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item()                                                                                                                      // BuildMemberBase.cs:93
	        {                                                                                                                                  // BuildMemberBase.cs:94
	        }                                                                                                                                  // BuildMemberBase.cs:96
	                                                                                                                                           // BuildMemberBase.cs:98
	        // Methods                                                                                                                         // BuildMemberBase.cs:99
	                                                                                                                                           // BuildMemberBase.cs:101
	        // BuildMemberBase.cs:102
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
	                                                                                                                                           // BuildMemberBase.cs:107
	        // BuildMemberBase.cs:108
	        /// <summary>
	        /// Read item.
	        /// </summary>
	                                                                                                                                           // BuildMemberReferences.cs:46
	        public void ReadItem(BreastRadiologyDocument doc, ResourceReference reference)                                                     // BuildMemberReferences.cs:47
	        {                                                                                                                                  // BuildMemberReferences.cs:48
	            this.Value = (MGAbnormalityArchitecturalDistortion) doc.GetResource(reference);                                                // BuildMemberReferences.cs:49
	        }                                                                                                                                  // BuildMemberReferences.cs:50
	    }                                                                                                                                      // BuildMemberBase.cs:114
	    #endregion                                                                                                                             // BuildMemberBase.cs:115
	                                                                                                                                           // BuildMemberBase.cs:166
	    // Properties                                                                                                                          // BuildMemberBase.cs:167
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:138
	    {                                                                                                                                      // BuildMemberBase.cs:139
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityArchitecturalDistortion"                                 // BuildMemberBase.cs:146
	    };                                                                                                                                     // BuildMemberBase.cs:147
	    #region Common Non-Singleton Properties                                                                                                // BuildMemberBase.cs:260
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:261
	                                                                                                                                           // BuildMemberBase.cs:263
	    // BuildMemberBase.cs:264
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:267
	                                                                                                                                           // BuildMemberBase.cs:269
	    // BuildMemberBase.cs:270
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:273
	                                                                                                                                           // BuildMemberBase.cs:275
	    // BuildMemberBase.cs:276
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:279
	                                                                                                                                           // BuildMemberBase.cs:281
	    // BuildMemberBase.cs:282
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<MGAbnormalityArchitecturalDistortion> All()                                                                         // BuildMemberBase.cs:285
	    {                                                                                                                                      // BuildMemberBase.cs:286
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:287
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:288
	    }                                                                                                                                      // BuildMemberBase.cs:289
	                                                                                                                                           // BuildMemberBase.cs:291
	    // BuildMemberBase.cs:292
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public MGAbnormalityArchitecturalDistortion GetAt(Int32 i) => this.items[i].Value;                                                     // BuildMemberBase.cs:295
	                                                                                                                                           // BuildMemberBase.cs:297
	    // BuildMemberBase.cs:298
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:301
	                                                                                                                                           // BuildMemberBase.cs:303
	    // BuildMemberBase.cs:304
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:307
	    #endregion                                                                                                                             // BuildMemberBase.cs:329
	                                                                                                                                           // BuildMemberBase.cs:170
	    // BuildMemberBase.cs:171
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public MGAbnormalityArchitecturalDistortionContainer(Int32 min, Int32 max) : base("Observation.hasMember:mGAbnormalityArchitecturalDistortion", min, max)// BuildMemberBase.cs:174
	    {                                                                                                                                      // BuildMemberBase.cs:175
	    }                                                                                                                                      // BuildMemberBase.cs:177
	                                                                                                                                           // BuildMemberBase.cs:179
	    // Methods                                                                                                                             // BuildMemberBase.cs:180
	                                                                                                                                           // BuildMemberBase.cs:313
	    // BuildMemberBase.cs:314
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public MGAbnormalityArchitecturalDistortion Append(MGAbnormalityArchitecturalDistortion value)                                         // BuildMemberBase.cs:317
	    {                                                                                                                                      // BuildMemberBase.cs:318
	        Item item = new Item();                                                                                                            // BuildMemberBase.cs:319
	        item.Value = value;                                                                                                                // BuildMemberBase.cs:320
	        this.items.Add(item);                                                                                                              // BuildMemberBase.cs:321
	        return value;                                                                                                                      // BuildMemberBase.cs:322
	    }                                                                                                                                      // BuildMemberBase.cs:323
	                                                                                                                                           // BuildMemberBase.cs:333
	    // BuildMemberBase.cs:334
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
	                                                                                                                                           // BuildMemberBase.cs:339
	    // BuildMemberBase.cs:340
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
	}                                                                                                                                          // BuildMemberBase.cs:182
	#endregion                                                                                                                                 // BuildMemberBase.cs:183
	#region Observation.hasMember:mGAbnormalityAsymmetry Container Class                                                                       // BuildMemberBase.cs:157
	// Called from BuildMemberReferences.cs, Line 199
	// BuildMemberBase.cs:159
	/// <summary>
	/// Container class for Observation.hasMember:mGAbnormalityAsymmetry.
	/// </summary>
	public class MGAbnormalityAsymmetryContainer : MContainer, ITMItem<ResourceReference>                                                      // BuildMemberBase.cs:162
	{                                                                                                                                          // BuildMemberBase.cs:163
	    #region Observation.hasMember:mGAbnormalityAsymmetry Item Class                                                                        // BuildMemberBase.cs:75
	    // Called from BuildMemberReferences.cs, Line 199
	    // BuildMemberBase.cs:77
	    /// <summary>
	    /// Item class for Observation.hasMember:mGAbnormalityAsymmetry.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:80
	    {                                                                                                                                      // BuildMemberBase.cs:81
	        // Properties                                                                                                                      // BuildMemberBase.cs:82
	        // BuildMemberBase.cs:83
	        /// <summary>
	        /// Value
	        /// </summary>
	        public MGAbnormalityAsymmetry Value { get; set; }                                                                                  // BuildMemberBase.cs:86
	                                                                                                                                           // BuildMemberBase.cs:89
	        // BuildMemberBase.cs:90
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item()                                                                                                                      // BuildMemberBase.cs:93
	        {                                                                                                                                  // BuildMemberBase.cs:94
	        }                                                                                                                                  // BuildMemberBase.cs:96
	                                                                                                                                           // BuildMemberBase.cs:98
	        // Methods                                                                                                                         // BuildMemberBase.cs:99
	                                                                                                                                           // BuildMemberBase.cs:101
	        // BuildMemberBase.cs:102
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
	                                                                                                                                           // BuildMemberBase.cs:107
	        // BuildMemberBase.cs:108
	        /// <summary>
	        /// Read item.
	        /// </summary>
	                                                                                                                                           // BuildMemberReferences.cs:46
	        public void ReadItem(BreastRadiologyDocument doc, ResourceReference reference)                                                     // BuildMemberReferences.cs:47
	        {                                                                                                                                  // BuildMemberReferences.cs:48
	            this.Value = (MGAbnormalityAsymmetry) doc.GetResource(reference);                                                              // BuildMemberReferences.cs:49
	        }                                                                                                                                  // BuildMemberReferences.cs:50
	    }                                                                                                                                      // BuildMemberBase.cs:114
	    #endregion                                                                                                                             // BuildMemberBase.cs:115
	                                                                                                                                           // BuildMemberBase.cs:166
	    // Properties                                                                                                                          // BuildMemberBase.cs:167
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:138
	    {                                                                                                                                      // BuildMemberBase.cs:139
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityAsymmetry"                                               // BuildMemberBase.cs:146
	    };                                                                                                                                     // BuildMemberBase.cs:147
	    #region Common Non-Singleton Properties                                                                                                // BuildMemberBase.cs:260
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:261
	                                                                                                                                           // BuildMemberBase.cs:263
	    // BuildMemberBase.cs:264
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:267
	                                                                                                                                           // BuildMemberBase.cs:269
	    // BuildMemberBase.cs:270
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:273
	                                                                                                                                           // BuildMemberBase.cs:275
	    // BuildMemberBase.cs:276
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:279
	                                                                                                                                           // BuildMemberBase.cs:281
	    // BuildMemberBase.cs:282
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<MGAbnormalityAsymmetry> All()                                                                                       // BuildMemberBase.cs:285
	    {                                                                                                                                      // BuildMemberBase.cs:286
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:287
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:288
	    }                                                                                                                                      // BuildMemberBase.cs:289
	                                                                                                                                           // BuildMemberBase.cs:291
	    // BuildMemberBase.cs:292
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public MGAbnormalityAsymmetry GetAt(Int32 i) => this.items[i].Value;                                                                   // BuildMemberBase.cs:295
	                                                                                                                                           // BuildMemberBase.cs:297
	    // BuildMemberBase.cs:298
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:301
	                                                                                                                                           // BuildMemberBase.cs:303
	    // BuildMemberBase.cs:304
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:307
	    #endregion                                                                                                                             // BuildMemberBase.cs:329
	                                                                                                                                           // BuildMemberBase.cs:170
	    // BuildMemberBase.cs:171
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public MGAbnormalityAsymmetryContainer(Int32 min, Int32 max) : base("Observation.hasMember:mGAbnormalityAsymmetry", min, max)          // BuildMemberBase.cs:174
	    {                                                                                                                                      // BuildMemberBase.cs:175
	    }                                                                                                                                      // BuildMemberBase.cs:177
	                                                                                                                                           // BuildMemberBase.cs:179
	    // Methods                                                                                                                             // BuildMemberBase.cs:180
	                                                                                                                                           // BuildMemberBase.cs:313
	    // BuildMemberBase.cs:314
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public MGAbnormalityAsymmetry Append(MGAbnormalityAsymmetry value)                                                                     // BuildMemberBase.cs:317
	    {                                                                                                                                      // BuildMemberBase.cs:318
	        Item item = new Item();                                                                                                            // BuildMemberBase.cs:319
	        item.Value = value;                                                                                                                // BuildMemberBase.cs:320
	        this.items.Add(item);                                                                                                              // BuildMemberBase.cs:321
	        return value;                                                                                                                      // BuildMemberBase.cs:322
	    }                                                                                                                                      // BuildMemberBase.cs:323
	                                                                                                                                           // BuildMemberBase.cs:333
	    // BuildMemberBase.cs:334
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
	                                                                                                                                           // BuildMemberBase.cs:339
	    // BuildMemberBase.cs:340
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
	}                                                                                                                                          // BuildMemberBase.cs:182
	#endregion                                                                                                                                 // BuildMemberBase.cs:183
	#region Observation.hasMember:mGAbnormalityCalcification Container Class                                                                   // BuildMemberBase.cs:157
	// Called from BuildMemberReferences.cs, Line 199
	// BuildMemberBase.cs:159
	/// <summary>
	/// Container class for Observation.hasMember:mGAbnormalityCalcification.
	/// </summary>
	public class MGAbnormalityCalcificationContainer : MContainer, ITMItem<ResourceReference>                                                  // BuildMemberBase.cs:162
	{                                                                                                                                          // BuildMemberBase.cs:163
	    #region Observation.hasMember:mGAbnormalityCalcification Item Class                                                                    // BuildMemberBase.cs:75
	    // Called from BuildMemberReferences.cs, Line 199
	    // BuildMemberBase.cs:77
	    /// <summary>
	    /// Item class for Observation.hasMember:mGAbnormalityCalcification.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:80
	    {                                                                                                                                      // BuildMemberBase.cs:81
	        // Properties                                                                                                                      // BuildMemberBase.cs:82
	        // BuildMemberBase.cs:83
	        /// <summary>
	        /// Value
	        /// </summary>
	        public MGAbnormalityCalcification Value { get; set; }                                                                              // BuildMemberBase.cs:86
	                                                                                                                                           // BuildMemberBase.cs:89
	        // BuildMemberBase.cs:90
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item()                                                                                                                      // BuildMemberBase.cs:93
	        {                                                                                                                                  // BuildMemberBase.cs:94
	        }                                                                                                                                  // BuildMemberBase.cs:96
	                                                                                                                                           // BuildMemberBase.cs:98
	        // Methods                                                                                                                         // BuildMemberBase.cs:99
	                                                                                                                                           // BuildMemberBase.cs:101
	        // BuildMemberBase.cs:102
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
	                                                                                                                                           // BuildMemberBase.cs:107
	        // BuildMemberBase.cs:108
	        /// <summary>
	        /// Read item.
	        /// </summary>
	                                                                                                                                           // BuildMemberReferences.cs:46
	        public void ReadItem(BreastRadiologyDocument doc, ResourceReference reference)                                                     // BuildMemberReferences.cs:47
	        {                                                                                                                                  // BuildMemberReferences.cs:48
	            this.Value = (MGAbnormalityCalcification) doc.GetResource(reference);                                                          // BuildMemberReferences.cs:49
	        }                                                                                                                                  // BuildMemberReferences.cs:50
	    }                                                                                                                                      // BuildMemberBase.cs:114
	    #endregion                                                                                                                             // BuildMemberBase.cs:115
	                                                                                                                                           // BuildMemberBase.cs:166
	    // Properties                                                                                                                          // BuildMemberBase.cs:167
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:138
	    {                                                                                                                                      // BuildMemberBase.cs:139
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityCalcification"                                           // BuildMemberBase.cs:146
	    };                                                                                                                                     // BuildMemberBase.cs:147
	    #region Common Non-Singleton Properties                                                                                                // BuildMemberBase.cs:260
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:261
	                                                                                                                                           // BuildMemberBase.cs:263
	    // BuildMemberBase.cs:264
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:267
	                                                                                                                                           // BuildMemberBase.cs:269
	    // BuildMemberBase.cs:270
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:273
	                                                                                                                                           // BuildMemberBase.cs:275
	    // BuildMemberBase.cs:276
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:279
	                                                                                                                                           // BuildMemberBase.cs:281
	    // BuildMemberBase.cs:282
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<MGAbnormalityCalcification> All()                                                                                   // BuildMemberBase.cs:285
	    {                                                                                                                                      // BuildMemberBase.cs:286
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:287
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:288
	    }                                                                                                                                      // BuildMemberBase.cs:289
	                                                                                                                                           // BuildMemberBase.cs:291
	    // BuildMemberBase.cs:292
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public MGAbnormalityCalcification GetAt(Int32 i) => this.items[i].Value;                                                               // BuildMemberBase.cs:295
	                                                                                                                                           // BuildMemberBase.cs:297
	    // BuildMemberBase.cs:298
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:301
	                                                                                                                                           // BuildMemberBase.cs:303
	    // BuildMemberBase.cs:304
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:307
	    #endregion                                                                                                                             // BuildMemberBase.cs:329
	                                                                                                                                           // BuildMemberBase.cs:170
	    // BuildMemberBase.cs:171
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public MGAbnormalityCalcificationContainer(Int32 min, Int32 max) : base("Observation.hasMember:mGAbnormalityCalcification", min, max)  // BuildMemberBase.cs:174
	    {                                                                                                                                      // BuildMemberBase.cs:175
	    }                                                                                                                                      // BuildMemberBase.cs:177
	                                                                                                                                           // BuildMemberBase.cs:179
	    // Methods                                                                                                                             // BuildMemberBase.cs:180
	                                                                                                                                           // BuildMemberBase.cs:313
	    // BuildMemberBase.cs:314
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public MGAbnormalityCalcification Append(MGAbnormalityCalcification value)                                                             // BuildMemberBase.cs:317
	    {                                                                                                                                      // BuildMemberBase.cs:318
	        Item item = new Item();                                                                                                            // BuildMemberBase.cs:319
	        item.Value = value;                                                                                                                // BuildMemberBase.cs:320
	        this.items.Add(item);                                                                                                              // BuildMemberBase.cs:321
	        return value;                                                                                                                      // BuildMemberBase.cs:322
	    }                                                                                                                                      // BuildMemberBase.cs:323
	                                                                                                                                           // BuildMemberBase.cs:333
	    // BuildMemberBase.cs:334
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
	                                                                                                                                           // BuildMemberBase.cs:339
	    // BuildMemberBase.cs:340
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
	}                                                                                                                                          // BuildMemberBase.cs:182
	#endregion                                                                                                                                 // BuildMemberBase.cs:183
	#region Observation.hasMember:mGAbnormalityDensity Container Class                                                                         // BuildMemberBase.cs:157
	// Called from BuildMemberReferences.cs, Line 199
	// BuildMemberBase.cs:159
	/// <summary>
	/// Container class for Observation.hasMember:mGAbnormalityDensity.
	/// </summary>
	public class MGAbnormalityDensityContainer : MContainer, ITMItem<ResourceReference>                                                        // BuildMemberBase.cs:162
	{                                                                                                                                          // BuildMemberBase.cs:163
	    #region Observation.hasMember:mGAbnormalityDensity Item Class                                                                          // BuildMemberBase.cs:75
	    // Called from BuildMemberReferences.cs, Line 199
	    // BuildMemberBase.cs:77
	    /// <summary>
	    /// Item class for Observation.hasMember:mGAbnormalityDensity.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:80
	    {                                                                                                                                      // BuildMemberBase.cs:81
	        // Properties                                                                                                                      // BuildMemberBase.cs:82
	        // BuildMemberBase.cs:83
	        /// <summary>
	        /// Value
	        /// </summary>
	        public MGAbnormalityDensity Value { get; set; }                                                                                    // BuildMemberBase.cs:86
	                                                                                                                                           // BuildMemberBase.cs:89
	        // BuildMemberBase.cs:90
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item()                                                                                                                      // BuildMemberBase.cs:93
	        {                                                                                                                                  // BuildMemberBase.cs:94
	        }                                                                                                                                  // BuildMemberBase.cs:96
	                                                                                                                                           // BuildMemberBase.cs:98
	        // Methods                                                                                                                         // BuildMemberBase.cs:99
	                                                                                                                                           // BuildMemberBase.cs:101
	        // BuildMemberBase.cs:102
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
	                                                                                                                                           // BuildMemberBase.cs:107
	        // BuildMemberBase.cs:108
	        /// <summary>
	        /// Read item.
	        /// </summary>
	                                                                                                                                           // BuildMemberReferences.cs:46
	        public void ReadItem(BreastRadiologyDocument doc, ResourceReference reference)                                                     // BuildMemberReferences.cs:47
	        {                                                                                                                                  // BuildMemberReferences.cs:48
	            this.Value = (MGAbnormalityDensity) doc.GetResource(reference);                                                                // BuildMemberReferences.cs:49
	        }                                                                                                                                  // BuildMemberReferences.cs:50
	    }                                                                                                                                      // BuildMemberBase.cs:114
	    #endregion                                                                                                                             // BuildMemberBase.cs:115
	                                                                                                                                           // BuildMemberBase.cs:166
	    // Properties                                                                                                                          // BuildMemberBase.cs:167
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:138
	    {                                                                                                                                      // BuildMemberBase.cs:139
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityDensity"                                                 // BuildMemberBase.cs:146
	    };                                                                                                                                     // BuildMemberBase.cs:147
	    #region Common Non-Singleton Properties                                                                                                // BuildMemberBase.cs:260
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:261
	                                                                                                                                           // BuildMemberBase.cs:263
	    // BuildMemberBase.cs:264
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:267
	                                                                                                                                           // BuildMemberBase.cs:269
	    // BuildMemberBase.cs:270
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:273
	                                                                                                                                           // BuildMemberBase.cs:275
	    // BuildMemberBase.cs:276
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:279
	                                                                                                                                           // BuildMemberBase.cs:281
	    // BuildMemberBase.cs:282
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<MGAbnormalityDensity> All()                                                                                         // BuildMemberBase.cs:285
	    {                                                                                                                                      // BuildMemberBase.cs:286
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:287
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:288
	    }                                                                                                                                      // BuildMemberBase.cs:289
	                                                                                                                                           // BuildMemberBase.cs:291
	    // BuildMemberBase.cs:292
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public MGAbnormalityDensity GetAt(Int32 i) => this.items[i].Value;                                                                     // BuildMemberBase.cs:295
	                                                                                                                                           // BuildMemberBase.cs:297
	    // BuildMemberBase.cs:298
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:301
	                                                                                                                                           // BuildMemberBase.cs:303
	    // BuildMemberBase.cs:304
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:307
	    #endregion                                                                                                                             // BuildMemberBase.cs:329
	                                                                                                                                           // BuildMemberBase.cs:170
	    // BuildMemberBase.cs:171
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public MGAbnormalityDensityContainer(Int32 min, Int32 max) : base("Observation.hasMember:mGAbnormalityDensity", min, max)              // BuildMemberBase.cs:174
	    {                                                                                                                                      // BuildMemberBase.cs:175
	    }                                                                                                                                      // BuildMemberBase.cs:177
	                                                                                                                                           // BuildMemberBase.cs:179
	    // Methods                                                                                                                             // BuildMemberBase.cs:180
	                                                                                                                                           // BuildMemberBase.cs:313
	    // BuildMemberBase.cs:314
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public MGAbnormalityDensity Append(MGAbnormalityDensity value)                                                                         // BuildMemberBase.cs:317
	    {                                                                                                                                      // BuildMemberBase.cs:318
	        Item item = new Item();                                                                                                            // BuildMemberBase.cs:319
	        item.Value = value;                                                                                                                // BuildMemberBase.cs:320
	        this.items.Add(item);                                                                                                              // BuildMemberBase.cs:321
	        return value;                                                                                                                      // BuildMemberBase.cs:322
	    }                                                                                                                                      // BuildMemberBase.cs:323
	                                                                                                                                           // BuildMemberBase.cs:333
	    // BuildMemberBase.cs:334
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
	                                                                                                                                           // BuildMemberBase.cs:339
	    // BuildMemberBase.cs:340
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
	}                                                                                                                                          // BuildMemberBase.cs:182
	#endregion                                                                                                                                 // BuildMemberBase.cs:183
	#region Observation.hasMember:mGAbnormalityFatNecrosis Container Class                                                                     // BuildMemberBase.cs:157
	// Called from BuildMemberReferences.cs, Line 199
	// BuildMemberBase.cs:159
	/// <summary>
	/// Container class for Observation.hasMember:mGAbnormalityFatNecrosis.
	/// </summary>
	public class MGAbnormalityFatNecrosisContainer : MContainer, ITMItem<ResourceReference>                                                    // BuildMemberBase.cs:162
	{                                                                                                                                          // BuildMemberBase.cs:163
	    #region Observation.hasMember:mGAbnormalityFatNecrosis Item Class                                                                      // BuildMemberBase.cs:75
	    // Called from BuildMemberReferences.cs, Line 199
	    // BuildMemberBase.cs:77
	    /// <summary>
	    /// Item class for Observation.hasMember:mGAbnormalityFatNecrosis.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:80
	    {                                                                                                                                      // BuildMemberBase.cs:81
	        // Properties                                                                                                                      // BuildMemberBase.cs:82
	        // BuildMemberBase.cs:83
	        /// <summary>
	        /// Value
	        /// </summary>
	        public MGAbnormalityFatNecrosis Value { get; set; }                                                                                // BuildMemberBase.cs:86
	                                                                                                                                           // BuildMemberBase.cs:89
	        // BuildMemberBase.cs:90
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item()                                                                                                                      // BuildMemberBase.cs:93
	        {                                                                                                                                  // BuildMemberBase.cs:94
	        }                                                                                                                                  // BuildMemberBase.cs:96
	                                                                                                                                           // BuildMemberBase.cs:98
	        // Methods                                                                                                                         // BuildMemberBase.cs:99
	                                                                                                                                           // BuildMemberBase.cs:101
	        // BuildMemberBase.cs:102
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
	                                                                                                                                           // BuildMemberBase.cs:107
	        // BuildMemberBase.cs:108
	        /// <summary>
	        /// Read item.
	        /// </summary>
	                                                                                                                                           // BuildMemberReferences.cs:46
	        public void ReadItem(BreastRadiologyDocument doc, ResourceReference reference)                                                     // BuildMemberReferences.cs:47
	        {                                                                                                                                  // BuildMemberReferences.cs:48
	            this.Value = (MGAbnormalityFatNecrosis) doc.GetResource(reference);                                                            // BuildMemberReferences.cs:49
	        }                                                                                                                                  // BuildMemberReferences.cs:50
	    }                                                                                                                                      // BuildMemberBase.cs:114
	    #endregion                                                                                                                             // BuildMemberBase.cs:115
	                                                                                                                                           // BuildMemberBase.cs:166
	    // Properties                                                                                                                          // BuildMemberBase.cs:167
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:138
	    {                                                                                                                                      // BuildMemberBase.cs:139
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityFatNecrosis"                                             // BuildMemberBase.cs:146
	    };                                                                                                                                     // BuildMemberBase.cs:147
	    #region Common Non-Singleton Properties                                                                                                // BuildMemberBase.cs:260
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:261
	                                                                                                                                           // BuildMemberBase.cs:263
	    // BuildMemberBase.cs:264
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:267
	                                                                                                                                           // BuildMemberBase.cs:269
	    // BuildMemberBase.cs:270
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:273
	                                                                                                                                           // BuildMemberBase.cs:275
	    // BuildMemberBase.cs:276
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:279
	                                                                                                                                           // BuildMemberBase.cs:281
	    // BuildMemberBase.cs:282
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<MGAbnormalityFatNecrosis> All()                                                                                     // BuildMemberBase.cs:285
	    {                                                                                                                                      // BuildMemberBase.cs:286
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:287
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:288
	    }                                                                                                                                      // BuildMemberBase.cs:289
	                                                                                                                                           // BuildMemberBase.cs:291
	    // BuildMemberBase.cs:292
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public MGAbnormalityFatNecrosis GetAt(Int32 i) => this.items[i].Value;                                                                 // BuildMemberBase.cs:295
	                                                                                                                                           // BuildMemberBase.cs:297
	    // BuildMemberBase.cs:298
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:301
	                                                                                                                                           // BuildMemberBase.cs:303
	    // BuildMemberBase.cs:304
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:307
	    #endregion                                                                                                                             // BuildMemberBase.cs:329
	                                                                                                                                           // BuildMemberBase.cs:170
	    // BuildMemberBase.cs:171
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public MGAbnormalityFatNecrosisContainer(Int32 min, Int32 max) : base("Observation.hasMember:mGAbnormalityFatNecrosis", min, max)      // BuildMemberBase.cs:174
	    {                                                                                                                                      // BuildMemberBase.cs:175
	    }                                                                                                                                      // BuildMemberBase.cs:177
	                                                                                                                                           // BuildMemberBase.cs:179
	    // Methods                                                                                                                             // BuildMemberBase.cs:180
	                                                                                                                                           // BuildMemberBase.cs:313
	    // BuildMemberBase.cs:314
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public MGAbnormalityFatNecrosis Append(MGAbnormalityFatNecrosis value)                                                                 // BuildMemberBase.cs:317
	    {                                                                                                                                      // BuildMemberBase.cs:318
	        Item item = new Item();                                                                                                            // BuildMemberBase.cs:319
	        item.Value = value;                                                                                                                // BuildMemberBase.cs:320
	        this.items.Add(item);                                                                                                              // BuildMemberBase.cs:321
	        return value;                                                                                                                      // BuildMemberBase.cs:322
	    }                                                                                                                                      // BuildMemberBase.cs:323
	                                                                                                                                           // BuildMemberBase.cs:333
	    // BuildMemberBase.cs:334
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
	                                                                                                                                           // BuildMemberBase.cs:339
	    // BuildMemberBase.cs:340
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
	}                                                                                                                                          // BuildMemberBase.cs:182
	#endregion                                                                                                                                 // BuildMemberBase.cs:183
	#region Observation.hasMember:mGBreastDensity Container Class                                                                              // BuildMemberBase.cs:157
	// Called from BuildMemberReferences.cs, Line 199
	// BuildMemberBase.cs:159
	/// <summary>
	/// Container class for Observation.hasMember:mGBreastDensity.
	/// </summary>
	public class MGBreastDensityContainer : MContainer, ITMItem<ResourceReference>                                                             // BuildMemberBase.cs:162
	{                                                                                                                                          // BuildMemberBase.cs:163
	    #region Observation.hasMember:mGBreastDensity Item Class                                                                               // BuildMemberBase.cs:75
	    // Called from BuildMemberReferences.cs, Line 199
	    // BuildMemberBase.cs:77
	    /// <summary>
	    /// Item class for Observation.hasMember:mGBreastDensity.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:80
	    {                                                                                                                                      // BuildMemberBase.cs:81
	        // Properties                                                                                                                      // BuildMemberBase.cs:82
	        // BuildMemberBase.cs:83
	        /// <summary>
	        /// Value
	        /// </summary>
	        public MGBreastDensity Value { get; set; }                                                                                         // BuildMemberBase.cs:86
	                                                                                                                                           // BuildMemberBase.cs:89
	        // BuildMemberBase.cs:90
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item()                                                                                                                      // BuildMemberBase.cs:93
	        {                                                                                                                                  // BuildMemberBase.cs:94
	        }                                                                                                                                  // BuildMemberBase.cs:96
	                                                                                                                                           // BuildMemberBase.cs:98
	        // Methods                                                                                                                         // BuildMemberBase.cs:99
	                                                                                                                                           // BuildMemberBase.cs:101
	        // BuildMemberBase.cs:102
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
	                                                                                                                                           // BuildMemberBase.cs:107
	        // BuildMemberBase.cs:108
	        /// <summary>
	        /// Read item.
	        /// </summary>
	                                                                                                                                           // BuildMemberReferences.cs:46
	        public void ReadItem(BreastRadiologyDocument doc, ResourceReference reference)                                                     // BuildMemberReferences.cs:47
	        {                                                                                                                                  // BuildMemberReferences.cs:48
	            this.Value = (MGBreastDensity) doc.GetResource(reference);                                                                     // BuildMemberReferences.cs:49
	        }                                                                                                                                  // BuildMemberReferences.cs:50
	    }                                                                                                                                      // BuildMemberBase.cs:114
	    #endregion                                                                                                                             // BuildMemberBase.cs:115
	                                                                                                                                           // BuildMemberBase.cs:166
	    // Properties                                                                                                                          // BuildMemberBase.cs:167
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:138
	    {                                                                                                                                      // BuildMemberBase.cs:139
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGBreastDensity"                                                      // BuildMemberBase.cs:146
	    };                                                                                                                                     // BuildMemberBase.cs:147
	    #region Common Singleton Properties                                                                                                    // BuildMemberBase.cs:191
	                                                                                                                                           // BuildMemberBase.cs:193
	    // BuildMemberBase.cs:194
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems()                                                                                                        // BuildMemberBase.cs:197
	    {                                                                                                                                      // BuildMemberBase.cs:198
	        if (this.item != null) yield return this.item;                                                                                     // BuildMemberBase.cs:199
	    }                                                                                                                                      // BuildMemberBase.cs:200
	                                                                                                                                           // BuildMemberBase.cs:202
	    // BuildMemberBase.cs:203
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items)                                                                                              // BuildMemberBase.cs:206
	    {                                                                                                                                      // BuildMemberBase.cs:207
	        switch (items.Count())                                                                                                             // BuildMemberBase.cs:208
	        {                                                                                                                                  // BuildMemberBase.cs:209
	            case 0: break;                                                                                                                 // BuildMemberBase.cs:210
	            case 1: this.item = items.First(); break;                                                                                      // BuildMemberBase.cs:211
	            default: throw new Exception("Found multiple elements while reading single item");                                             // BuildMemberBase.cs:212
	        }                                                                                                                                  // BuildMemberBase.cs:213
	    }                                                                                                                                      // BuildMemberBase.cs:214
	                                                                                                                                           // BuildMemberBase.cs:216
	    // BuildMemberBase.cs:217
	    /// <summary>
	    /// Item
	    /// </summary>
	    Item item;                                                                                                                             // BuildMemberBase.cs:220
	                                                                                                                                           // BuildMemberBase.cs:222
	    // BuildMemberBase.cs:223
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => this.item == null ? 0 : 1;                                                                              // BuildMemberBase.cs:226
	                                                                                                                                           // BuildMemberBase.cs:228
	    // BuildMemberBase.cs:229
	    /// <summary>
	    /// Get Item's Value
	    /// </summary>
	    public MGBreastDensity Get()                                                                                                           // BuildMemberBase.cs:232
	    {                                                                                                                                      // BuildMemberBase.cs:233
	        if (item == null)                                                                                                                  // BuildMemberBase.cs:234
	            return null;                                                                                                                   // BuildMemberBase.cs:235
	        return item.Value;                                                                                                                 // BuildMemberBase.cs:236
	    }                                                                                                                                      // BuildMemberBase.cs:237
	                                                                                                                                           // BuildMemberBase.cs:243
	    // BuildMemberBase.cs:244
	    /// <summary>
	    /// Set Item's Value
	    /// </summary>
	    public MGBreastDensity Set(MGBreastDensity value)                                                                                      // BuildMemberBase.cs:247
	    {                                                                                                                                      // BuildMemberBase.cs:248
	        Item item = new Item();                                                                                                            // BuildMemberBase.cs:249
	        item.Value = value;                                                                                                                // BuildMemberBase.cs:250
	        this.item = item;                                                                                                                  // BuildMemberBase.cs:251
	        return value;                                                                                                                      // BuildMemberBase.cs:252
	    }                                                                                                                                      // BuildMemberBase.cs:253
	    #endregion                                                                                                                             // BuildMemberBase.cs:329
	                                                                                                                                           // BuildMemberBase.cs:170
	    // BuildMemberBase.cs:171
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public MGBreastDensityContainer(Int32 min, Int32 max) : base("Observation.hasMember:mGBreastDensity", min, max)                        // BuildMemberBase.cs:174
	    {                                                                                                                                      // BuildMemberBase.cs:175
	    }                                                                                                                                      // BuildMemberBase.cs:177
	                                                                                                                                           // BuildMemberBase.cs:179
	    // Methods                                                                                                                             // BuildMemberBase.cs:180
	                                                                                                                                           // BuildMemberBase.cs:333
	    // BuildMemberBase.cs:334
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
	                                                                                                                                           // BuildMemberBase.cs:339
	    // BuildMemberBase.cs:340
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
	}                                                                                                                                          // BuildMemberBase.cs:182
	#endregion                                                                                                                                 // BuildMemberBase.cs:183
	//- LocalClassDefs
}
