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
	#region Observation.hasMember:abnormalityCyst Container Class                                                                              // BuildMemberBase.cs:173
	// Called from BuildMemberReferences.cs, Line 191
	// BuildMemberBase.cs:175
	/// <summary>
	/// Container class for Observation.hasMember:abnormalityCyst.
	/// </summary>
	public class MAbnormalityCyst : MContainer, ITMItem<ResourceReference>                                                                     // BuildMemberBase.cs:178
	{                                                                                                                                          // BuildMemberBase.cs:179
	    #region Observation.hasMember:abnormalityCyst Item Class                                                                               // BuildMemberBase.cs:81
	    // Called from BuildMemberReferences.cs, Line 191
	    // BuildMemberBase.cs:83
	    /// <summary>
	    /// Item class for Observation.hasMember:abnormalityCyst.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:86
	    {                                                                                                                                      // BuildMemberBase.cs:87
	        // Properties                                                                                                                      // BuildMemberBase.cs:88
	        // BuildMemberBase.cs:90
	        /// <summary>
	        /// Value
	        /// </summary>
	        public AbnormalityCyst Value { get; set; }                                                                                         // BuildMemberBase.cs:93
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
	            this.Value = (AbnormalityCyst) doc.GetResource(item);                                                                          // BuildMemberReferences.cs:46
	        }                                                                                                                                  // BuildMemberBase.cs:127
	    }                                                                                                                                      // BuildMemberBase.cs:130
	    #endregion                                                                                                                             // BuildMemberBase.cs:131
	                                                                                                                                           // BuildMemberBase.cs:182
	    // Properties                                                                                                                          // BuildMemberBase.cs:183
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:154
	    {                                                                                                                                      // BuildMemberBase.cs:155
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityCyst"                                                      // BuildMemberBase.cs:162
	    };                                                                                                                                     // BuildMemberBase.cs:163
	    #region Common Properties (Non-Singleton)                                                                                              // BuildMemberBase.cs:276
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:277
	                                                                                                                                           // BuildMemberBase.cs:279
	    // BuildMemberBase.cs:280
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:283
	                                                                                                                                           // BuildMemberBase.cs:285
	    // BuildMemberBase.cs:286
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:289
	                                                                                                                                           // BuildMemberBase.cs:291
	    // BuildMemberBase.cs:292
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:295
	                                                                                                                                           // BuildMemberBase.cs:297
	    // BuildMemberBase.cs:298
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<AbnormalityCyst> All()                                                                                              // BuildMemberBase.cs:301
	    {                                                                                                                                      // BuildMemberBase.cs:302
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:303
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:304
	    }                                                                                                                                      // BuildMemberBase.cs:305
	                                                                                                                                           // BuildMemberBase.cs:307
	    // BuildMemberBase.cs:308
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public AbnormalityCyst GetAt(Int32 i) => this.items[i].Value;                                                                          // BuildMemberBase.cs:311
	                                                                                                                                           // BuildMemberBase.cs:313
	    // BuildMemberBase.cs:314
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:317
	                                                                                                                                           // BuildMemberBase.cs:319
	    // BuildMemberBase.cs:320
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:323
	    #endregion                                                                                                                             // BuildMemberBase.cs:345
	                                                                                                                                           // BuildMemberBase.cs:186
	    // BuildMemberBase.cs:187
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public MAbnormalityCyst(Int32 min, Int32 max) : base("Observation.hasMember:abnormalityCyst", min, max)                                // BuildMemberBase.cs:190
	    {                                                                                                                                      // BuildMemberBase.cs:191
	    }                                                                                                                                      // BuildMemberBase.cs:193
	                                                                                                                                           // BuildMemberBase.cs:195
	    // Methods                                                                                                                             // BuildMemberBase.cs:196
	                                                                                                                                           // BuildMemberBase.cs:329
	    // BuildMemberBase.cs:330
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public AbnormalityCyst Append(AbnormalityCyst value)                                                                                   // BuildMemberBase.cs:333
	    {                                                                                                                                      // BuildMemberBase.cs:334
	        Item item = new Item();                                                                                                            // BuildMemberBase.cs:335
	        item.Value = value;                                                                                                                // BuildMemberBase.cs:336
	        this.items.Add(item);                                                                                                              // BuildMemberBase.cs:337
	        return value;                                                                                                                      // BuildMemberBase.cs:338
	    }                                                                                                                                      // BuildMemberBase.cs:339
	                                                                                                                                           // BuildMemberBase.cs:349
	    // BuildMemberBase.cs:350
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
	                                                                                                                                           // BuildMemberBase.cs:355
	    // BuildMemberBase.cs:356
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
	}                                                                                                                                          // BuildMemberBase.cs:198
	#endregion                                                                                                                                 // BuildMemberBase.cs:199
	#region Observation.hasMember:abnormalityDuct Container Class                                                                              // BuildMemberBase.cs:173
	// Called from BuildMemberReferences.cs, Line 191
	// BuildMemberBase.cs:175
	/// <summary>
	/// Container class for Observation.hasMember:abnormalityDuct.
	/// </summary>
	public class MAbnormalityDuct : MContainer, ITMItem<ResourceReference>                                                                     // BuildMemberBase.cs:178
	{                                                                                                                                          // BuildMemberBase.cs:179
	    #region Observation.hasMember:abnormalityDuct Item Class                                                                               // BuildMemberBase.cs:81
	    // Called from BuildMemberReferences.cs, Line 191
	    // BuildMemberBase.cs:83
	    /// <summary>
	    /// Item class for Observation.hasMember:abnormalityDuct.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:86
	    {                                                                                                                                      // BuildMemberBase.cs:87
	        // Properties                                                                                                                      // BuildMemberBase.cs:88
	        // BuildMemberBase.cs:90
	        /// <summary>
	        /// Value
	        /// </summary>
	        public AbnormalityDuct Value { get; set; }                                                                                         // BuildMemberBase.cs:93
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
	            this.Value = (AbnormalityDuct) doc.GetResource(item);                                                                          // BuildMemberReferences.cs:46
	        }                                                                                                                                  // BuildMemberBase.cs:127
	    }                                                                                                                                      // BuildMemberBase.cs:130
	    #endregion                                                                                                                             // BuildMemberBase.cs:131
	                                                                                                                                           // BuildMemberBase.cs:182
	    // Properties                                                                                                                          // BuildMemberBase.cs:183
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:154
	    {                                                                                                                                      // BuildMemberBase.cs:155
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityDuct"                                                      // BuildMemberBase.cs:162
	    };                                                                                                                                     // BuildMemberBase.cs:163
	    #region Common Properties (Non-Singleton)                                                                                              // BuildMemberBase.cs:276
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:277
	                                                                                                                                           // BuildMemberBase.cs:279
	    // BuildMemberBase.cs:280
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:283
	                                                                                                                                           // BuildMemberBase.cs:285
	    // BuildMemberBase.cs:286
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:289
	                                                                                                                                           // BuildMemberBase.cs:291
	    // BuildMemberBase.cs:292
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:295
	                                                                                                                                           // BuildMemberBase.cs:297
	    // BuildMemberBase.cs:298
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<AbnormalityDuct> All()                                                                                              // BuildMemberBase.cs:301
	    {                                                                                                                                      // BuildMemberBase.cs:302
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:303
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:304
	    }                                                                                                                                      // BuildMemberBase.cs:305
	                                                                                                                                           // BuildMemberBase.cs:307
	    // BuildMemberBase.cs:308
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public AbnormalityDuct GetAt(Int32 i) => this.items[i].Value;                                                                          // BuildMemberBase.cs:311
	                                                                                                                                           // BuildMemberBase.cs:313
	    // BuildMemberBase.cs:314
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:317
	                                                                                                                                           // BuildMemberBase.cs:319
	    // BuildMemberBase.cs:320
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:323
	    #endregion                                                                                                                             // BuildMemberBase.cs:345
	                                                                                                                                           // BuildMemberBase.cs:186
	    // BuildMemberBase.cs:187
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public MAbnormalityDuct(Int32 min, Int32 max) : base("Observation.hasMember:abnormalityDuct", min, max)                                // BuildMemberBase.cs:190
	    {                                                                                                                                      // BuildMemberBase.cs:191
	    }                                                                                                                                      // BuildMemberBase.cs:193
	                                                                                                                                           // BuildMemberBase.cs:195
	    // Methods                                                                                                                             // BuildMemberBase.cs:196
	                                                                                                                                           // BuildMemberBase.cs:329
	    // BuildMemberBase.cs:330
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public AbnormalityDuct Append(AbnormalityDuct value)                                                                                   // BuildMemberBase.cs:333
	    {                                                                                                                                      // BuildMemberBase.cs:334
	        Item item = new Item();                                                                                                            // BuildMemberBase.cs:335
	        item.Value = value;                                                                                                                // BuildMemberBase.cs:336
	        this.items.Add(item);                                                                                                              // BuildMemberBase.cs:337
	        return value;                                                                                                                      // BuildMemberBase.cs:338
	    }                                                                                                                                      // BuildMemberBase.cs:339
	                                                                                                                                           // BuildMemberBase.cs:349
	    // BuildMemberBase.cs:350
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
	                                                                                                                                           // BuildMemberBase.cs:355
	    // BuildMemberBase.cs:356
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
	}                                                                                                                                          // BuildMemberBase.cs:198
	#endregion                                                                                                                                 // BuildMemberBase.cs:199
	#region Observation.hasMember:abnormalityForeignObject Container Class                                                                     // BuildMemberBase.cs:173
	// Called from BuildMemberReferences.cs, Line 191
	// BuildMemberBase.cs:175
	/// <summary>
	/// Container class for Observation.hasMember:abnormalityForeignObject.
	/// </summary>
	public class MAbnormalityForeignObject : MContainer, ITMItem<ResourceReference>                                                            // BuildMemberBase.cs:178
	{                                                                                                                                          // BuildMemberBase.cs:179
	    #region Observation.hasMember:abnormalityForeignObject Item Class                                                                      // BuildMemberBase.cs:81
	    // Called from BuildMemberReferences.cs, Line 191
	    // BuildMemberBase.cs:83
	    /// <summary>
	    /// Item class for Observation.hasMember:abnormalityForeignObject.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:86
	    {                                                                                                                                      // BuildMemberBase.cs:87
	        // Properties                                                                                                                      // BuildMemberBase.cs:88
	        // BuildMemberBase.cs:90
	        /// <summary>
	        /// Value
	        /// </summary>
	        public AbnormalityForeignObject Value { get; set; }                                                                                // BuildMemberBase.cs:93
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
	            this.Value = (AbnormalityForeignObject) doc.GetResource(item);                                                                 // BuildMemberReferences.cs:46
	        }                                                                                                                                  // BuildMemberBase.cs:127
	    }                                                                                                                                      // BuildMemberBase.cs:130
	    #endregion                                                                                                                             // BuildMemberBase.cs:131
	                                                                                                                                           // BuildMemberBase.cs:182
	    // Properties                                                                                                                          // BuildMemberBase.cs:183
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:154
	    {                                                                                                                                      // BuildMemberBase.cs:155
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityForeignObject"                                             // BuildMemberBase.cs:162
	    };                                                                                                                                     // BuildMemberBase.cs:163
	    #region Common Properties (Non-Singleton)                                                                                              // BuildMemberBase.cs:276
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:277
	                                                                                                                                           // BuildMemberBase.cs:279
	    // BuildMemberBase.cs:280
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:283
	                                                                                                                                           // BuildMemberBase.cs:285
	    // BuildMemberBase.cs:286
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:289
	                                                                                                                                           // BuildMemberBase.cs:291
	    // BuildMemberBase.cs:292
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:295
	                                                                                                                                           // BuildMemberBase.cs:297
	    // BuildMemberBase.cs:298
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<AbnormalityForeignObject> All()                                                                                     // BuildMemberBase.cs:301
	    {                                                                                                                                      // BuildMemberBase.cs:302
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:303
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:304
	    }                                                                                                                                      // BuildMemberBase.cs:305
	                                                                                                                                           // BuildMemberBase.cs:307
	    // BuildMemberBase.cs:308
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public AbnormalityForeignObject GetAt(Int32 i) => this.items[i].Value;                                                                 // BuildMemberBase.cs:311
	                                                                                                                                           // BuildMemberBase.cs:313
	    // BuildMemberBase.cs:314
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:317
	                                                                                                                                           // BuildMemberBase.cs:319
	    // BuildMemberBase.cs:320
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:323
	    #endregion                                                                                                                             // BuildMemberBase.cs:345
	                                                                                                                                           // BuildMemberBase.cs:186
	    // BuildMemberBase.cs:187
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public MAbnormalityForeignObject(Int32 min, Int32 max) : base("Observation.hasMember:abnormalityForeignObject", min, max)              // BuildMemberBase.cs:190
	    {                                                                                                                                      // BuildMemberBase.cs:191
	    }                                                                                                                                      // BuildMemberBase.cs:193
	                                                                                                                                           // BuildMemberBase.cs:195
	    // Methods                                                                                                                             // BuildMemberBase.cs:196
	                                                                                                                                           // BuildMemberBase.cs:329
	    // BuildMemberBase.cs:330
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public AbnormalityForeignObject Append(AbnormalityForeignObject value)                                                                 // BuildMemberBase.cs:333
	    {                                                                                                                                      // BuildMemberBase.cs:334
	        Item item = new Item();                                                                                                            // BuildMemberBase.cs:335
	        item.Value = value;                                                                                                                // BuildMemberBase.cs:336
	        this.items.Add(item);                                                                                                              // BuildMemberBase.cs:337
	        return value;                                                                                                                      // BuildMemberBase.cs:338
	    }                                                                                                                                      // BuildMemberBase.cs:339
	                                                                                                                                           // BuildMemberBase.cs:349
	    // BuildMemberBase.cs:350
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
	                                                                                                                                           // BuildMemberBase.cs:355
	    // BuildMemberBase.cs:356
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
	}                                                                                                                                          // BuildMemberBase.cs:198
	#endregion                                                                                                                                 // BuildMemberBase.cs:199
	#region Observation.hasMember:abnormalityLymphNode Container Class                                                                         // BuildMemberBase.cs:173
	// Called from BuildMemberReferences.cs, Line 191
	// BuildMemberBase.cs:175
	/// <summary>
	/// Container class for Observation.hasMember:abnormalityLymphNode.
	/// </summary>
	public class MAbnormalityLymphNode : MContainer, ITMItem<ResourceReference>                                                                // BuildMemberBase.cs:178
	{                                                                                                                                          // BuildMemberBase.cs:179
	    #region Observation.hasMember:abnormalityLymphNode Item Class                                                                          // BuildMemberBase.cs:81
	    // Called from BuildMemberReferences.cs, Line 191
	    // BuildMemberBase.cs:83
	    /// <summary>
	    /// Item class for Observation.hasMember:abnormalityLymphNode.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:86
	    {                                                                                                                                      // BuildMemberBase.cs:87
	        // Properties                                                                                                                      // BuildMemberBase.cs:88
	        // BuildMemberBase.cs:90
	        /// <summary>
	        /// Value
	        /// </summary>
	        public AbnormalityLymphNode Value { get; set; }                                                                                    // BuildMemberBase.cs:93
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
	            this.Value = (AbnormalityLymphNode) doc.GetResource(item);                                                                     // BuildMemberReferences.cs:46
	        }                                                                                                                                  // BuildMemberBase.cs:127
	    }                                                                                                                                      // BuildMemberBase.cs:130
	    #endregion                                                                                                                             // BuildMemberBase.cs:131
	                                                                                                                                           // BuildMemberBase.cs:182
	    // Properties                                                                                                                          // BuildMemberBase.cs:183
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:154
	    {                                                                                                                                      // BuildMemberBase.cs:155
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityLymphNode"                                                 // BuildMemberBase.cs:162
	    };                                                                                                                                     // BuildMemberBase.cs:163
	    #region Common Properties (Non-Singleton)                                                                                              // BuildMemberBase.cs:276
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:277
	                                                                                                                                           // BuildMemberBase.cs:279
	    // BuildMemberBase.cs:280
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:283
	                                                                                                                                           // BuildMemberBase.cs:285
	    // BuildMemberBase.cs:286
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:289
	                                                                                                                                           // BuildMemberBase.cs:291
	    // BuildMemberBase.cs:292
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:295
	                                                                                                                                           // BuildMemberBase.cs:297
	    // BuildMemberBase.cs:298
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<AbnormalityLymphNode> All()                                                                                         // BuildMemberBase.cs:301
	    {                                                                                                                                      // BuildMemberBase.cs:302
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:303
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:304
	    }                                                                                                                                      // BuildMemberBase.cs:305
	                                                                                                                                           // BuildMemberBase.cs:307
	    // BuildMemberBase.cs:308
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public AbnormalityLymphNode GetAt(Int32 i) => this.items[i].Value;                                                                     // BuildMemberBase.cs:311
	                                                                                                                                           // BuildMemberBase.cs:313
	    // BuildMemberBase.cs:314
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:317
	                                                                                                                                           // BuildMemberBase.cs:319
	    // BuildMemberBase.cs:320
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:323
	    #endregion                                                                                                                             // BuildMemberBase.cs:345
	                                                                                                                                           // BuildMemberBase.cs:186
	    // BuildMemberBase.cs:187
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public MAbnormalityLymphNode(Int32 min, Int32 max) : base("Observation.hasMember:abnormalityLymphNode", min, max)                      // BuildMemberBase.cs:190
	    {                                                                                                                                      // BuildMemberBase.cs:191
	    }                                                                                                                                      // BuildMemberBase.cs:193
	                                                                                                                                           // BuildMemberBase.cs:195
	    // Methods                                                                                                                             // BuildMemberBase.cs:196
	                                                                                                                                           // BuildMemberBase.cs:329
	    // BuildMemberBase.cs:330
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public AbnormalityLymphNode Append(AbnormalityLymphNode value)                                                                         // BuildMemberBase.cs:333
	    {                                                                                                                                      // BuildMemberBase.cs:334
	        Item item = new Item();                                                                                                            // BuildMemberBase.cs:335
	        item.Value = value;                                                                                                                // BuildMemberBase.cs:336
	        this.items.Add(item);                                                                                                              // BuildMemberBase.cs:337
	        return value;                                                                                                                      // BuildMemberBase.cs:338
	    }                                                                                                                                      // BuildMemberBase.cs:339
	                                                                                                                                           // BuildMemberBase.cs:349
	    // BuildMemberBase.cs:350
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
	                                                                                                                                           // BuildMemberBase.cs:355
	    // BuildMemberBase.cs:356
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
	}                                                                                                                                          // BuildMemberBase.cs:198
	#endregion                                                                                                                                 // BuildMemberBase.cs:199
	#region Observation.hasMember:abnormalityMass Container Class                                                                              // BuildMemberBase.cs:173
	// Called from BuildMemberReferences.cs, Line 191
	// BuildMemberBase.cs:175
	/// <summary>
	/// Container class for Observation.hasMember:abnormalityMass.
	/// </summary>
	public class MAbnormalityMass : MContainer, ITMItem<ResourceReference>                                                                     // BuildMemberBase.cs:178
	{                                                                                                                                          // BuildMemberBase.cs:179
	    #region Observation.hasMember:abnormalityMass Item Class                                                                               // BuildMemberBase.cs:81
	    // Called from BuildMemberReferences.cs, Line 191
	    // BuildMemberBase.cs:83
	    /// <summary>
	    /// Item class for Observation.hasMember:abnormalityMass.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:86
	    {                                                                                                                                      // BuildMemberBase.cs:87
	        // Properties                                                                                                                      // BuildMemberBase.cs:88
	        // BuildMemberBase.cs:90
	        /// <summary>
	        /// Value
	        /// </summary>
	        public AbnormalityMass Value { get; set; }                                                                                         // BuildMemberBase.cs:93
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
	            this.Value = (AbnormalityMass) doc.GetResource(item);                                                                          // BuildMemberReferences.cs:46
	        }                                                                                                                                  // BuildMemberBase.cs:127
	    }                                                                                                                                      // BuildMemberBase.cs:130
	    #endregion                                                                                                                             // BuildMemberBase.cs:131
	                                                                                                                                           // BuildMemberBase.cs:182
	    // Properties                                                                                                                          // BuildMemberBase.cs:183
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:154
	    {                                                                                                                                      // BuildMemberBase.cs:155
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityMass"                                                      // BuildMemberBase.cs:162
	    };                                                                                                                                     // BuildMemberBase.cs:163
	    #region Common Properties (Non-Singleton)                                                                                              // BuildMemberBase.cs:276
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:277
	                                                                                                                                           // BuildMemberBase.cs:279
	    // BuildMemberBase.cs:280
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:283
	                                                                                                                                           // BuildMemberBase.cs:285
	    // BuildMemberBase.cs:286
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:289
	                                                                                                                                           // BuildMemberBase.cs:291
	    // BuildMemberBase.cs:292
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:295
	                                                                                                                                           // BuildMemberBase.cs:297
	    // BuildMemberBase.cs:298
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<AbnormalityMass> All()                                                                                              // BuildMemberBase.cs:301
	    {                                                                                                                                      // BuildMemberBase.cs:302
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:303
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:304
	    }                                                                                                                                      // BuildMemberBase.cs:305
	                                                                                                                                           // BuildMemberBase.cs:307
	    // BuildMemberBase.cs:308
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public AbnormalityMass GetAt(Int32 i) => this.items[i].Value;                                                                          // BuildMemberBase.cs:311
	                                                                                                                                           // BuildMemberBase.cs:313
	    // BuildMemberBase.cs:314
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:317
	                                                                                                                                           // BuildMemberBase.cs:319
	    // BuildMemberBase.cs:320
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:323
	    #endregion                                                                                                                             // BuildMemberBase.cs:345
	                                                                                                                                           // BuildMemberBase.cs:186
	    // BuildMemberBase.cs:187
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public MAbnormalityMass(Int32 min, Int32 max) : base("Observation.hasMember:abnormalityMass", min, max)                                // BuildMemberBase.cs:190
	    {                                                                                                                                      // BuildMemberBase.cs:191
	    }                                                                                                                                      // BuildMemberBase.cs:193
	                                                                                                                                           // BuildMemberBase.cs:195
	    // Methods                                                                                                                             // BuildMemberBase.cs:196
	                                                                                                                                           // BuildMemberBase.cs:329
	    // BuildMemberBase.cs:330
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public AbnormalityMass Append(AbnormalityMass value)                                                                                   // BuildMemberBase.cs:333
	    {                                                                                                                                      // BuildMemberBase.cs:334
	        Item item = new Item();                                                                                                            // BuildMemberBase.cs:335
	        item.Value = value;                                                                                                                // BuildMemberBase.cs:336
	        this.items.Add(item);                                                                                                              // BuildMemberBase.cs:337
	        return value;                                                                                                                      // BuildMemberBase.cs:338
	    }                                                                                                                                      // BuildMemberBase.cs:339
	                                                                                                                                           // BuildMemberBase.cs:349
	    // BuildMemberBase.cs:350
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
	                                                                                                                                           // BuildMemberBase.cs:355
	    // BuildMemberBase.cs:356
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
	}                                                                                                                                          // BuildMemberBase.cs:198
	#endregion                                                                                                                                 // BuildMemberBase.cs:199
	#region Observation.hasMember:associatedFeature Container Class                                                                            // BuildMemberBase.cs:173
	// Called from BuildMemberReferences.cs, Line 191
	// BuildMemberBase.cs:175
	/// <summary>
	/// Container class for Observation.hasMember:associatedFeature.
	/// </summary>
	public class MAssociatedFeature : MContainer, ITMItem<ResourceReference>                                                                   // BuildMemberBase.cs:178
	{                                                                                                                                          // BuildMemberBase.cs:179
	    #region Observation.hasMember:associatedFeature Item Class                                                                             // BuildMemberBase.cs:81
	    // Called from BuildMemberReferences.cs, Line 191
	    // BuildMemberBase.cs:83
	    /// <summary>
	    /// Item class for Observation.hasMember:associatedFeature.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:86
	    {                                                                                                                                      // BuildMemberBase.cs:87
	        // Properties                                                                                                                      // BuildMemberBase.cs:88
	        // BuildMemberBase.cs:90
	        /// <summary>
	        /// Value
	        /// </summary>
	        public AssociatedFeature Value { get; set; }                                                                                       // BuildMemberBase.cs:93
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
	            this.Value = (AssociatedFeature) doc.GetResource(item);                                                                        // BuildMemberReferences.cs:46
	        }                                                                                                                                  // BuildMemberBase.cs:127
	    }                                                                                                                                      // BuildMemberBase.cs:130
	    #endregion                                                                                                                             // BuildMemberBase.cs:131
	                                                                                                                                           // BuildMemberBase.cs:182
	    // Properties                                                                                                                          // BuildMemberBase.cs:183
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:154
	    {                                                                                                                                      // BuildMemberBase.cs:155
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AssociatedFeature"                                                    // BuildMemberBase.cs:162
	    };                                                                                                                                     // BuildMemberBase.cs:163
	    #region Common Properties (Non-Singleton)                                                                                              // BuildMemberBase.cs:276
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:277
	                                                                                                                                           // BuildMemberBase.cs:279
	    // BuildMemberBase.cs:280
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:283
	                                                                                                                                           // BuildMemberBase.cs:285
	    // BuildMemberBase.cs:286
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:289
	                                                                                                                                           // BuildMemberBase.cs:291
	    // BuildMemberBase.cs:292
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:295
	                                                                                                                                           // BuildMemberBase.cs:297
	    // BuildMemberBase.cs:298
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<AssociatedFeature> All()                                                                                            // BuildMemberBase.cs:301
	    {                                                                                                                                      // BuildMemberBase.cs:302
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:303
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:304
	    }                                                                                                                                      // BuildMemberBase.cs:305
	                                                                                                                                           // BuildMemberBase.cs:307
	    // BuildMemberBase.cs:308
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public AssociatedFeature GetAt(Int32 i) => this.items[i].Value;                                                                        // BuildMemberBase.cs:311
	                                                                                                                                           // BuildMemberBase.cs:313
	    // BuildMemberBase.cs:314
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:317
	                                                                                                                                           // BuildMemberBase.cs:319
	    // BuildMemberBase.cs:320
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:323
	    #endregion                                                                                                                             // BuildMemberBase.cs:345
	                                                                                                                                           // BuildMemberBase.cs:186
	    // BuildMemberBase.cs:187
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public MAssociatedFeature(Int32 min, Int32 max) : base("Observation.hasMember:associatedFeature", min, max)                            // BuildMemberBase.cs:190
	    {                                                                                                                                      // BuildMemberBase.cs:191
	    }                                                                                                                                      // BuildMemberBase.cs:193
	                                                                                                                                           // BuildMemberBase.cs:195
	    // Methods                                                                                                                             // BuildMemberBase.cs:196
	                                                                                                                                           // BuildMemberBase.cs:329
	    // BuildMemberBase.cs:330
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public AssociatedFeature Append(AssociatedFeature value)                                                                               // BuildMemberBase.cs:333
	    {                                                                                                                                      // BuildMemberBase.cs:334
	        Item item = new Item();                                                                                                            // BuildMemberBase.cs:335
	        item.Value = value;                                                                                                                // BuildMemberBase.cs:336
	        this.items.Add(item);                                                                                                              // BuildMemberBase.cs:337
	        return value;                                                                                                                      // BuildMemberBase.cs:338
	    }                                                                                                                                      // BuildMemberBase.cs:339
	                                                                                                                                           // BuildMemberBase.cs:349
	    // BuildMemberBase.cs:350
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
	                                                                                                                                           // BuildMemberBase.cs:355
	    // BuildMemberBase.cs:356
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
	}                                                                                                                                          // BuildMemberBase.cs:198
	#endregion                                                                                                                                 // BuildMemberBase.cs:199
	#region Observation.hasMember:abnormalityFibroadenoma Container Class                                                                      // BuildMemberBase.cs:173
	// Called from BuildMemberReferences.cs, Line 191
	// BuildMemberBase.cs:175
	/// <summary>
	/// Container class for Observation.hasMember:abnormalityFibroadenoma.
	/// </summary>
	public class MAbnormalityFibroadenoma : MContainer, ITMItem<ResourceReference>                                                             // BuildMemberBase.cs:178
	{                                                                                                                                          // BuildMemberBase.cs:179
	    #region Observation.hasMember:abnormalityFibroadenoma Item Class                                                                       // BuildMemberBase.cs:81
	    // Called from BuildMemberReferences.cs, Line 191
	    // BuildMemberBase.cs:83
	    /// <summary>
	    /// Item class for Observation.hasMember:abnormalityFibroadenoma.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:86
	    {                                                                                                                                      // BuildMemberBase.cs:87
	        // Properties                                                                                                                      // BuildMemberBase.cs:88
	        // BuildMemberBase.cs:90
	        /// <summary>
	        /// Value
	        /// </summary>
	        public AbnormalityFibroadenoma Value { get; set; }                                                                                 // BuildMemberBase.cs:93
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
	            this.Value = (AbnormalityFibroadenoma) doc.GetResource(item);                                                                  // BuildMemberReferences.cs:46
	        }                                                                                                                                  // BuildMemberBase.cs:127
	    }                                                                                                                                      // BuildMemberBase.cs:130
	    #endregion                                                                                                                             // BuildMemberBase.cs:131
	                                                                                                                                           // BuildMemberBase.cs:182
	    // Properties                                                                                                                          // BuildMemberBase.cs:183
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:154
	    {                                                                                                                                      // BuildMemberBase.cs:155
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityFibroadenoma"                                              // BuildMemberBase.cs:162
	    };                                                                                                                                     // BuildMemberBase.cs:163
	    #region Common Properties (Non-Singleton)                                                                                              // BuildMemberBase.cs:276
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:277
	                                                                                                                                           // BuildMemberBase.cs:279
	    // BuildMemberBase.cs:280
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:283
	                                                                                                                                           // BuildMemberBase.cs:285
	    // BuildMemberBase.cs:286
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:289
	                                                                                                                                           // BuildMemberBase.cs:291
	    // BuildMemberBase.cs:292
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:295
	                                                                                                                                           // BuildMemberBase.cs:297
	    // BuildMemberBase.cs:298
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<AbnormalityFibroadenoma> All()                                                                                      // BuildMemberBase.cs:301
	    {                                                                                                                                      // BuildMemberBase.cs:302
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:303
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:304
	    }                                                                                                                                      // BuildMemberBase.cs:305
	                                                                                                                                           // BuildMemberBase.cs:307
	    // BuildMemberBase.cs:308
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public AbnormalityFibroadenoma GetAt(Int32 i) => this.items[i].Value;                                                                  // BuildMemberBase.cs:311
	                                                                                                                                           // BuildMemberBase.cs:313
	    // BuildMemberBase.cs:314
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:317
	                                                                                                                                           // BuildMemberBase.cs:319
	    // BuildMemberBase.cs:320
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:323
	    #endregion                                                                                                                             // BuildMemberBase.cs:345
	                                                                                                                                           // BuildMemberBase.cs:186
	    // BuildMemberBase.cs:187
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public MAbnormalityFibroadenoma(Int32 min, Int32 max) : base("Observation.hasMember:abnormalityFibroadenoma", min, max)                // BuildMemberBase.cs:190
	    {                                                                                                                                      // BuildMemberBase.cs:191
	    }                                                                                                                                      // BuildMemberBase.cs:193
	                                                                                                                                           // BuildMemberBase.cs:195
	    // Methods                                                                                                                             // BuildMemberBase.cs:196
	                                                                                                                                           // BuildMemberBase.cs:329
	    // BuildMemberBase.cs:330
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public AbnormalityFibroadenoma Append(AbnormalityFibroadenoma value)                                                                   // BuildMemberBase.cs:333
	    {                                                                                                                                      // BuildMemberBase.cs:334
	        Item item = new Item();                                                                                                            // BuildMemberBase.cs:335
	        item.Value = value;                                                                                                                // BuildMemberBase.cs:336
	        this.items.Add(item);                                                                                                              // BuildMemberBase.cs:337
	        return value;                                                                                                                      // BuildMemberBase.cs:338
	    }                                                                                                                                      // BuildMemberBase.cs:339
	                                                                                                                                           // BuildMemberBase.cs:349
	    // BuildMemberBase.cs:350
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
	                                                                                                                                           // BuildMemberBase.cs:355
	    // BuildMemberBase.cs:356
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
	}                                                                                                                                          // BuildMemberBase.cs:198
	#endregion                                                                                                                                 // BuildMemberBase.cs:199
	#region Observation.hasMember:mGAbnormalityArchitecturalDistortion Container Class                                                         // BuildMemberBase.cs:173
	// Called from BuildMemberReferences.cs, Line 191
	// BuildMemberBase.cs:175
	/// <summary>
	/// Container class for Observation.hasMember:mGAbnormalityArchitecturalDistortion.
	/// </summary>
	public class MMGAbnormalityArchitecturalDistortion : MContainer, ITMItem<ResourceReference>                                                // BuildMemberBase.cs:178
	{                                                                                                                                          // BuildMemberBase.cs:179
	    #region Observation.hasMember:mGAbnormalityArchitecturalDistortion Item Class                                                          // BuildMemberBase.cs:81
	    // Called from BuildMemberReferences.cs, Line 191
	    // BuildMemberBase.cs:83
	    /// <summary>
	    /// Item class for Observation.hasMember:mGAbnormalityArchitecturalDistortion.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:86
	    {                                                                                                                                      // BuildMemberBase.cs:87
	        // Properties                                                                                                                      // BuildMemberBase.cs:88
	        // BuildMemberBase.cs:90
	        /// <summary>
	        /// Value
	        /// </summary>
	        public MGAbnormalityArchitecturalDistortion Value { get; set; }                                                                    // BuildMemberBase.cs:93
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
	            this.Value = (MGAbnormalityArchitecturalDistortion) doc.GetResource(item);                                                     // BuildMemberReferences.cs:46
	        }                                                                                                                                  // BuildMemberBase.cs:127
	    }                                                                                                                                      // BuildMemberBase.cs:130
	    #endregion                                                                                                                             // BuildMemberBase.cs:131
	                                                                                                                                           // BuildMemberBase.cs:182
	    // Properties                                                                                                                          // BuildMemberBase.cs:183
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:154
	    {                                                                                                                                      // BuildMemberBase.cs:155
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityArchitecturalDistortion"                                 // BuildMemberBase.cs:162
	    };                                                                                                                                     // BuildMemberBase.cs:163
	    #region Common Properties (Non-Singleton)                                                                                              // BuildMemberBase.cs:276
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:277
	                                                                                                                                           // BuildMemberBase.cs:279
	    // BuildMemberBase.cs:280
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:283
	                                                                                                                                           // BuildMemberBase.cs:285
	    // BuildMemberBase.cs:286
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:289
	                                                                                                                                           // BuildMemberBase.cs:291
	    // BuildMemberBase.cs:292
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:295
	                                                                                                                                           // BuildMemberBase.cs:297
	    // BuildMemberBase.cs:298
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<MGAbnormalityArchitecturalDistortion> All()                                                                         // BuildMemberBase.cs:301
	    {                                                                                                                                      // BuildMemberBase.cs:302
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:303
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:304
	    }                                                                                                                                      // BuildMemberBase.cs:305
	                                                                                                                                           // BuildMemberBase.cs:307
	    // BuildMemberBase.cs:308
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public MGAbnormalityArchitecturalDistortion GetAt(Int32 i) => this.items[i].Value;                                                     // BuildMemberBase.cs:311
	                                                                                                                                           // BuildMemberBase.cs:313
	    // BuildMemberBase.cs:314
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:317
	                                                                                                                                           // BuildMemberBase.cs:319
	    // BuildMemberBase.cs:320
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:323
	    #endregion                                                                                                                             // BuildMemberBase.cs:345
	                                                                                                                                           // BuildMemberBase.cs:186
	    // BuildMemberBase.cs:187
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public MMGAbnormalityArchitecturalDistortion(Int32 min, Int32 max) : base("Observation.hasMember:mGAbnormalityArchitecturalDistortion", min, max)// BuildMemberBase.cs:190
	    {                                                                                                                                      // BuildMemberBase.cs:191
	    }                                                                                                                                      // BuildMemberBase.cs:193
	                                                                                                                                           // BuildMemberBase.cs:195
	    // Methods                                                                                                                             // BuildMemberBase.cs:196
	                                                                                                                                           // BuildMemberBase.cs:329
	    // BuildMemberBase.cs:330
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public MGAbnormalityArchitecturalDistortion Append(MGAbnormalityArchitecturalDistortion value)                                         // BuildMemberBase.cs:333
	    {                                                                                                                                      // BuildMemberBase.cs:334
	        Item item = new Item();                                                                                                            // BuildMemberBase.cs:335
	        item.Value = value;                                                                                                                // BuildMemberBase.cs:336
	        this.items.Add(item);                                                                                                              // BuildMemberBase.cs:337
	        return value;                                                                                                                      // BuildMemberBase.cs:338
	    }                                                                                                                                      // BuildMemberBase.cs:339
	                                                                                                                                           // BuildMemberBase.cs:349
	    // BuildMemberBase.cs:350
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
	                                                                                                                                           // BuildMemberBase.cs:355
	    // BuildMemberBase.cs:356
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
	}                                                                                                                                          // BuildMemberBase.cs:198
	#endregion                                                                                                                                 // BuildMemberBase.cs:199
	#region Observation.hasMember:mGAbnormalityAsymmetry Container Class                                                                       // BuildMemberBase.cs:173
	// Called from BuildMemberReferences.cs, Line 191
	// BuildMemberBase.cs:175
	/// <summary>
	/// Container class for Observation.hasMember:mGAbnormalityAsymmetry.
	/// </summary>
	public class MMGAbnormalityAsymmetry : MContainer, ITMItem<ResourceReference>                                                              // BuildMemberBase.cs:178
	{                                                                                                                                          // BuildMemberBase.cs:179
	    #region Observation.hasMember:mGAbnormalityAsymmetry Item Class                                                                        // BuildMemberBase.cs:81
	    // Called from BuildMemberReferences.cs, Line 191
	    // BuildMemberBase.cs:83
	    /// <summary>
	    /// Item class for Observation.hasMember:mGAbnormalityAsymmetry.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:86
	    {                                                                                                                                      // BuildMemberBase.cs:87
	        // Properties                                                                                                                      // BuildMemberBase.cs:88
	        // BuildMemberBase.cs:90
	        /// <summary>
	        /// Value
	        /// </summary>
	        public MGAbnormalityAsymmetry Value { get; set; }                                                                                  // BuildMemberBase.cs:93
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
	            this.Value = (MGAbnormalityAsymmetry) doc.GetResource(item);                                                                   // BuildMemberReferences.cs:46
	        }                                                                                                                                  // BuildMemberBase.cs:127
	    }                                                                                                                                      // BuildMemberBase.cs:130
	    #endregion                                                                                                                             // BuildMemberBase.cs:131
	                                                                                                                                           // BuildMemberBase.cs:182
	    // Properties                                                                                                                          // BuildMemberBase.cs:183
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:154
	    {                                                                                                                                      // BuildMemberBase.cs:155
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityAsymmetry"                                               // BuildMemberBase.cs:162
	    };                                                                                                                                     // BuildMemberBase.cs:163
	    #region Common Properties (Non-Singleton)                                                                                              // BuildMemberBase.cs:276
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:277
	                                                                                                                                           // BuildMemberBase.cs:279
	    // BuildMemberBase.cs:280
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:283
	                                                                                                                                           // BuildMemberBase.cs:285
	    // BuildMemberBase.cs:286
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:289
	                                                                                                                                           // BuildMemberBase.cs:291
	    // BuildMemberBase.cs:292
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:295
	                                                                                                                                           // BuildMemberBase.cs:297
	    // BuildMemberBase.cs:298
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<MGAbnormalityAsymmetry> All()                                                                                       // BuildMemberBase.cs:301
	    {                                                                                                                                      // BuildMemberBase.cs:302
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:303
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:304
	    }                                                                                                                                      // BuildMemberBase.cs:305
	                                                                                                                                           // BuildMemberBase.cs:307
	    // BuildMemberBase.cs:308
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public MGAbnormalityAsymmetry GetAt(Int32 i) => this.items[i].Value;                                                                   // BuildMemberBase.cs:311
	                                                                                                                                           // BuildMemberBase.cs:313
	    // BuildMemberBase.cs:314
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:317
	                                                                                                                                           // BuildMemberBase.cs:319
	    // BuildMemberBase.cs:320
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:323
	    #endregion                                                                                                                             // BuildMemberBase.cs:345
	                                                                                                                                           // BuildMemberBase.cs:186
	    // BuildMemberBase.cs:187
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public MMGAbnormalityAsymmetry(Int32 min, Int32 max) : base("Observation.hasMember:mGAbnormalityAsymmetry", min, max)                  // BuildMemberBase.cs:190
	    {                                                                                                                                      // BuildMemberBase.cs:191
	    }                                                                                                                                      // BuildMemberBase.cs:193
	                                                                                                                                           // BuildMemberBase.cs:195
	    // Methods                                                                                                                             // BuildMemberBase.cs:196
	                                                                                                                                           // BuildMemberBase.cs:329
	    // BuildMemberBase.cs:330
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public MGAbnormalityAsymmetry Append(MGAbnormalityAsymmetry value)                                                                     // BuildMemberBase.cs:333
	    {                                                                                                                                      // BuildMemberBase.cs:334
	        Item item = new Item();                                                                                                            // BuildMemberBase.cs:335
	        item.Value = value;                                                                                                                // BuildMemberBase.cs:336
	        this.items.Add(item);                                                                                                              // BuildMemberBase.cs:337
	        return value;                                                                                                                      // BuildMemberBase.cs:338
	    }                                                                                                                                      // BuildMemberBase.cs:339
	                                                                                                                                           // BuildMemberBase.cs:349
	    // BuildMemberBase.cs:350
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
	                                                                                                                                           // BuildMemberBase.cs:355
	    // BuildMemberBase.cs:356
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
	}                                                                                                                                          // BuildMemberBase.cs:198
	#endregion                                                                                                                                 // BuildMemberBase.cs:199
	#region Observation.hasMember:mGAbnormalityCalcification Container Class                                                                   // BuildMemberBase.cs:173
	// Called from BuildMemberReferences.cs, Line 191
	// BuildMemberBase.cs:175
	/// <summary>
	/// Container class for Observation.hasMember:mGAbnormalityCalcification.
	/// </summary>
	public class MMGAbnormalityCalcification : MContainer, ITMItem<ResourceReference>                                                          // BuildMemberBase.cs:178
	{                                                                                                                                          // BuildMemberBase.cs:179
	    #region Observation.hasMember:mGAbnormalityCalcification Item Class                                                                    // BuildMemberBase.cs:81
	    // Called from BuildMemberReferences.cs, Line 191
	    // BuildMemberBase.cs:83
	    /// <summary>
	    /// Item class for Observation.hasMember:mGAbnormalityCalcification.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:86
	    {                                                                                                                                      // BuildMemberBase.cs:87
	        // Properties                                                                                                                      // BuildMemberBase.cs:88
	        // BuildMemberBase.cs:90
	        /// <summary>
	        /// Value
	        /// </summary>
	        public MGAbnormalityCalcification Value { get; set; }                                                                              // BuildMemberBase.cs:93
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
	            this.Value = (MGAbnormalityCalcification) doc.GetResource(item);                                                               // BuildMemberReferences.cs:46
	        }                                                                                                                                  // BuildMemberBase.cs:127
	    }                                                                                                                                      // BuildMemberBase.cs:130
	    #endregion                                                                                                                             // BuildMemberBase.cs:131
	                                                                                                                                           // BuildMemberBase.cs:182
	    // Properties                                                                                                                          // BuildMemberBase.cs:183
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:154
	    {                                                                                                                                      // BuildMemberBase.cs:155
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityCalcification"                                           // BuildMemberBase.cs:162
	    };                                                                                                                                     // BuildMemberBase.cs:163
	    #region Common Properties (Non-Singleton)                                                                                              // BuildMemberBase.cs:276
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:277
	                                                                                                                                           // BuildMemberBase.cs:279
	    // BuildMemberBase.cs:280
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:283
	                                                                                                                                           // BuildMemberBase.cs:285
	    // BuildMemberBase.cs:286
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:289
	                                                                                                                                           // BuildMemberBase.cs:291
	    // BuildMemberBase.cs:292
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:295
	                                                                                                                                           // BuildMemberBase.cs:297
	    // BuildMemberBase.cs:298
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<MGAbnormalityCalcification> All()                                                                                   // BuildMemberBase.cs:301
	    {                                                                                                                                      // BuildMemberBase.cs:302
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:303
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:304
	    }                                                                                                                                      // BuildMemberBase.cs:305
	                                                                                                                                           // BuildMemberBase.cs:307
	    // BuildMemberBase.cs:308
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public MGAbnormalityCalcification GetAt(Int32 i) => this.items[i].Value;                                                               // BuildMemberBase.cs:311
	                                                                                                                                           // BuildMemberBase.cs:313
	    // BuildMemberBase.cs:314
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:317
	                                                                                                                                           // BuildMemberBase.cs:319
	    // BuildMemberBase.cs:320
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:323
	    #endregion                                                                                                                             // BuildMemberBase.cs:345
	                                                                                                                                           // BuildMemberBase.cs:186
	    // BuildMemberBase.cs:187
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public MMGAbnormalityCalcification(Int32 min, Int32 max) : base("Observation.hasMember:mGAbnormalityCalcification", min, max)          // BuildMemberBase.cs:190
	    {                                                                                                                                      // BuildMemberBase.cs:191
	    }                                                                                                                                      // BuildMemberBase.cs:193
	                                                                                                                                           // BuildMemberBase.cs:195
	    // Methods                                                                                                                             // BuildMemberBase.cs:196
	                                                                                                                                           // BuildMemberBase.cs:329
	    // BuildMemberBase.cs:330
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public MGAbnormalityCalcification Append(MGAbnormalityCalcification value)                                                             // BuildMemberBase.cs:333
	    {                                                                                                                                      // BuildMemberBase.cs:334
	        Item item = new Item();                                                                                                            // BuildMemberBase.cs:335
	        item.Value = value;                                                                                                                // BuildMemberBase.cs:336
	        this.items.Add(item);                                                                                                              // BuildMemberBase.cs:337
	        return value;                                                                                                                      // BuildMemberBase.cs:338
	    }                                                                                                                                      // BuildMemberBase.cs:339
	                                                                                                                                           // BuildMemberBase.cs:349
	    // BuildMemberBase.cs:350
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
	                                                                                                                                           // BuildMemberBase.cs:355
	    // BuildMemberBase.cs:356
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
	}                                                                                                                                          // BuildMemberBase.cs:198
	#endregion                                                                                                                                 // BuildMemberBase.cs:199
	#region Observation.hasMember:mGAbnormalityDensity Container Class                                                                         // BuildMemberBase.cs:173
	// Called from BuildMemberReferences.cs, Line 191
	// BuildMemberBase.cs:175
	/// <summary>
	/// Container class for Observation.hasMember:mGAbnormalityDensity.
	/// </summary>
	public class MMGAbnormalityDensity : MContainer, ITMItem<ResourceReference>                                                                // BuildMemberBase.cs:178
	{                                                                                                                                          // BuildMemberBase.cs:179
	    #region Observation.hasMember:mGAbnormalityDensity Item Class                                                                          // BuildMemberBase.cs:81
	    // Called from BuildMemberReferences.cs, Line 191
	    // BuildMemberBase.cs:83
	    /// <summary>
	    /// Item class for Observation.hasMember:mGAbnormalityDensity.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:86
	    {                                                                                                                                      // BuildMemberBase.cs:87
	        // Properties                                                                                                                      // BuildMemberBase.cs:88
	        // BuildMemberBase.cs:90
	        /// <summary>
	        /// Value
	        /// </summary>
	        public MGAbnormalityDensity Value { get; set; }                                                                                    // BuildMemberBase.cs:93
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
	            this.Value = (MGAbnormalityDensity) doc.GetResource(item);                                                                     // BuildMemberReferences.cs:46
	        }                                                                                                                                  // BuildMemberBase.cs:127
	    }                                                                                                                                      // BuildMemberBase.cs:130
	    #endregion                                                                                                                             // BuildMemberBase.cs:131
	                                                                                                                                           // BuildMemberBase.cs:182
	    // Properties                                                                                                                          // BuildMemberBase.cs:183
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:154
	    {                                                                                                                                      // BuildMemberBase.cs:155
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityDensity"                                                 // BuildMemberBase.cs:162
	    };                                                                                                                                     // BuildMemberBase.cs:163
	    #region Common Properties (Non-Singleton)                                                                                              // BuildMemberBase.cs:276
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:277
	                                                                                                                                           // BuildMemberBase.cs:279
	    // BuildMemberBase.cs:280
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:283
	                                                                                                                                           // BuildMemberBase.cs:285
	    // BuildMemberBase.cs:286
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:289
	                                                                                                                                           // BuildMemberBase.cs:291
	    // BuildMemberBase.cs:292
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:295
	                                                                                                                                           // BuildMemberBase.cs:297
	    // BuildMemberBase.cs:298
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<MGAbnormalityDensity> All()                                                                                         // BuildMemberBase.cs:301
	    {                                                                                                                                      // BuildMemberBase.cs:302
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:303
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:304
	    }                                                                                                                                      // BuildMemberBase.cs:305
	                                                                                                                                           // BuildMemberBase.cs:307
	    // BuildMemberBase.cs:308
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public MGAbnormalityDensity GetAt(Int32 i) => this.items[i].Value;                                                                     // BuildMemberBase.cs:311
	                                                                                                                                           // BuildMemberBase.cs:313
	    // BuildMemberBase.cs:314
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:317
	                                                                                                                                           // BuildMemberBase.cs:319
	    // BuildMemberBase.cs:320
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:323
	    #endregion                                                                                                                             // BuildMemberBase.cs:345
	                                                                                                                                           // BuildMemberBase.cs:186
	    // BuildMemberBase.cs:187
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public MMGAbnormalityDensity(Int32 min, Int32 max) : base("Observation.hasMember:mGAbnormalityDensity", min, max)                      // BuildMemberBase.cs:190
	    {                                                                                                                                      // BuildMemberBase.cs:191
	    }                                                                                                                                      // BuildMemberBase.cs:193
	                                                                                                                                           // BuildMemberBase.cs:195
	    // Methods                                                                                                                             // BuildMemberBase.cs:196
	                                                                                                                                           // BuildMemberBase.cs:329
	    // BuildMemberBase.cs:330
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public MGAbnormalityDensity Append(MGAbnormalityDensity value)                                                                         // BuildMemberBase.cs:333
	    {                                                                                                                                      // BuildMemberBase.cs:334
	        Item item = new Item();                                                                                                            // BuildMemberBase.cs:335
	        item.Value = value;                                                                                                                // BuildMemberBase.cs:336
	        this.items.Add(item);                                                                                                              // BuildMemberBase.cs:337
	        return value;                                                                                                                      // BuildMemberBase.cs:338
	    }                                                                                                                                      // BuildMemberBase.cs:339
	                                                                                                                                           // BuildMemberBase.cs:349
	    // BuildMemberBase.cs:350
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
	                                                                                                                                           // BuildMemberBase.cs:355
	    // BuildMemberBase.cs:356
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
	}                                                                                                                                          // BuildMemberBase.cs:198
	#endregion                                                                                                                                 // BuildMemberBase.cs:199
	#region Observation.hasMember:mGAbnormalityFatNecrosis Container Class                                                                     // BuildMemberBase.cs:173
	// Called from BuildMemberReferences.cs, Line 191
	// BuildMemberBase.cs:175
	/// <summary>
	/// Container class for Observation.hasMember:mGAbnormalityFatNecrosis.
	/// </summary>
	public class MMGAbnormalityFatNecrosis : MContainer, ITMItem<ResourceReference>                                                            // BuildMemberBase.cs:178
	{                                                                                                                                          // BuildMemberBase.cs:179
	    #region Observation.hasMember:mGAbnormalityFatNecrosis Item Class                                                                      // BuildMemberBase.cs:81
	    // Called from BuildMemberReferences.cs, Line 191
	    // BuildMemberBase.cs:83
	    /// <summary>
	    /// Item class for Observation.hasMember:mGAbnormalityFatNecrosis.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:86
	    {                                                                                                                                      // BuildMemberBase.cs:87
	        // Properties                                                                                                                      // BuildMemberBase.cs:88
	        // BuildMemberBase.cs:90
	        /// <summary>
	        /// Value
	        /// </summary>
	        public MGAbnormalityFatNecrosis Value { get; set; }                                                                                // BuildMemberBase.cs:93
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
	            this.Value = (MGAbnormalityFatNecrosis) doc.GetResource(item);                                                                 // BuildMemberReferences.cs:46
	        }                                                                                                                                  // BuildMemberBase.cs:127
	    }                                                                                                                                      // BuildMemberBase.cs:130
	    #endregion                                                                                                                             // BuildMemberBase.cs:131
	                                                                                                                                           // BuildMemberBase.cs:182
	    // Properties                                                                                                                          // BuildMemberBase.cs:183
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:154
	    {                                                                                                                                      // BuildMemberBase.cs:155
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityFatNecrosis"                                             // BuildMemberBase.cs:162
	    };                                                                                                                                     // BuildMemberBase.cs:163
	    #region Common Properties (Non-Singleton)                                                                                              // BuildMemberBase.cs:276
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:277
	                                                                                                                                           // BuildMemberBase.cs:279
	    // BuildMemberBase.cs:280
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:283
	                                                                                                                                           // BuildMemberBase.cs:285
	    // BuildMemberBase.cs:286
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:289
	                                                                                                                                           // BuildMemberBase.cs:291
	    // BuildMemberBase.cs:292
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:295
	                                                                                                                                           // BuildMemberBase.cs:297
	    // BuildMemberBase.cs:298
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<MGAbnormalityFatNecrosis> All()                                                                                     // BuildMemberBase.cs:301
	    {                                                                                                                                      // BuildMemberBase.cs:302
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:303
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:304
	    }                                                                                                                                      // BuildMemberBase.cs:305
	                                                                                                                                           // BuildMemberBase.cs:307
	    // BuildMemberBase.cs:308
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public MGAbnormalityFatNecrosis GetAt(Int32 i) => this.items[i].Value;                                                                 // BuildMemberBase.cs:311
	                                                                                                                                           // BuildMemberBase.cs:313
	    // BuildMemberBase.cs:314
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:317
	                                                                                                                                           // BuildMemberBase.cs:319
	    // BuildMemberBase.cs:320
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:323
	    #endregion                                                                                                                             // BuildMemberBase.cs:345
	                                                                                                                                           // BuildMemberBase.cs:186
	    // BuildMemberBase.cs:187
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public MMGAbnormalityFatNecrosis(Int32 min, Int32 max) : base("Observation.hasMember:mGAbnormalityFatNecrosis", min, max)              // BuildMemberBase.cs:190
	    {                                                                                                                                      // BuildMemberBase.cs:191
	    }                                                                                                                                      // BuildMemberBase.cs:193
	                                                                                                                                           // BuildMemberBase.cs:195
	    // Methods                                                                                                                             // BuildMemberBase.cs:196
	                                                                                                                                           // BuildMemberBase.cs:329
	    // BuildMemberBase.cs:330
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public MGAbnormalityFatNecrosis Append(MGAbnormalityFatNecrosis value)                                                                 // BuildMemberBase.cs:333
	    {                                                                                                                                      // BuildMemberBase.cs:334
	        Item item = new Item();                                                                                                            // BuildMemberBase.cs:335
	        item.Value = value;                                                                                                                // BuildMemberBase.cs:336
	        this.items.Add(item);                                                                                                              // BuildMemberBase.cs:337
	        return value;                                                                                                                      // BuildMemberBase.cs:338
	    }                                                                                                                                      // BuildMemberBase.cs:339
	                                                                                                                                           // BuildMemberBase.cs:349
	    // BuildMemberBase.cs:350
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
	                                                                                                                                           // BuildMemberBase.cs:355
	    // BuildMemberBase.cs:356
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
	}                                                                                                                                          // BuildMemberBase.cs:198
	#endregion                                                                                                                                 // BuildMemberBase.cs:199
	#region Observation.hasMember:mGBreastDensity Container Class                                                                              // BuildMemberBase.cs:173
	// Called from BuildMemberReferences.cs, Line 191
	// BuildMemberBase.cs:175
	/// <summary>
	/// Container class for Observation.hasMember:mGBreastDensity.
	/// </summary>
	public class MMGBreastDensity : MContainer, ITMItem<ResourceReference>                                                                     // BuildMemberBase.cs:178
	{                                                                                                                                          // BuildMemberBase.cs:179
	    #region Observation.hasMember:mGBreastDensity Item Class                                                                               // BuildMemberBase.cs:81
	    // Called from BuildMemberReferences.cs, Line 191
	    // BuildMemberBase.cs:83
	    /// <summary>
	    /// Item class for Observation.hasMember:mGBreastDensity.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:86
	    {                                                                                                                                      // BuildMemberBase.cs:87
	        // Properties                                                                                                                      // BuildMemberBase.cs:88
	        // BuildMemberBase.cs:90
	        /// <summary>
	        /// Value
	        /// </summary>
	        public MGBreastDensity Value { get; set; }                                                                                         // BuildMemberBase.cs:93
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
	            this.Value = (MGBreastDensity) doc.GetResource(item);                                                                          // BuildMemberReferences.cs:46
	        }                                                                                                                                  // BuildMemberBase.cs:127
	    }                                                                                                                                      // BuildMemberBase.cs:130
	    #endregion                                                                                                                             // BuildMemberBase.cs:131
	                                                                                                                                           // BuildMemberBase.cs:182
	    // Properties                                                                                                                          // BuildMemberBase.cs:183
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:154
	    {                                                                                                                                      // BuildMemberBase.cs:155
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGBreastDensity"                                                      // BuildMemberBase.cs:162
	    };                                                                                                                                     // BuildMemberBase.cs:163
	    #region Common Properties (Singleton)                                                                                                  // BuildMemberBase.cs:207
	                                                                                                                                           // BuildMemberBase.cs:209
	    // BuildMemberBase.cs:210
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems()                                                                                                        // BuildMemberBase.cs:213
	    {                                                                                                                                      // BuildMemberBase.cs:214
	        if (this.item != null) yield return this.item;                                                                                     // BuildMemberBase.cs:215
	    }                                                                                                                                      // BuildMemberBase.cs:216
	                                                                                                                                           // BuildMemberBase.cs:218
	    // BuildMemberBase.cs:219
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items)                                                                                              // BuildMemberBase.cs:222
	    {                                                                                                                                      // BuildMemberBase.cs:223
	        switch (items.Count())                                                                                                             // BuildMemberBase.cs:224
	        {                                                                                                                                  // BuildMemberBase.cs:225
	            case 0: break;                                                                                                                 // BuildMemberBase.cs:226
	            case 1: this.item = items.First(); break;                                                                                      // BuildMemberBase.cs:227
	            default: throw new Exception("Found multiple elements while reading single item");                                             // BuildMemberBase.cs:228
	        }                                                                                                                                  // BuildMemberBase.cs:229
	    }                                                                                                                                      // BuildMemberBase.cs:230
	                                                                                                                                           // BuildMemberBase.cs:232
	    // BuildMemberBase.cs:233
	    /// <summary>
	    /// Item
	    /// </summary>
	    Item item;                                                                                                                             // BuildMemberBase.cs:236
	                                                                                                                                           // BuildMemberBase.cs:238
	    // BuildMemberBase.cs:239
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => this.item == null ? 0 : 1;                                                                              // BuildMemberBase.cs:242
	                                                                                                                                           // BuildMemberBase.cs:244
	    // BuildMemberBase.cs:245
	    /// <summary>
	    /// Get Item's Value
	    /// </summary>
	    public MGBreastDensity Get()                                                                                                           // BuildMemberBase.cs:248
	    {                                                                                                                                      // BuildMemberBase.cs:249
	        if (item == null)                                                                                                                  // BuildMemberBase.cs:250
	            return null;                                                                                                                   // BuildMemberBase.cs:251
	        return item.Value;                                                                                                                 // BuildMemberBase.cs:252
	    }                                                                                                                                      // BuildMemberBase.cs:253
	                                                                                                                                           // BuildMemberBase.cs:259
	    // BuildMemberBase.cs:260
	    /// <summary>
	    /// Set Item's Value
	    /// </summary>
	    public MGBreastDensity Set(MGBreastDensity value)                                                                                      // BuildMemberBase.cs:263
	    {                                                                                                                                      // BuildMemberBase.cs:264
	        Item item = new Item();                                                                                                            // BuildMemberBase.cs:265
	        item.Value = value;                                                                                                                // BuildMemberBase.cs:266
	        this.item = item;                                                                                                                  // BuildMemberBase.cs:267
	        return value;                                                                                                                      // BuildMemberBase.cs:268
	    }                                                                                                                                      // BuildMemberBase.cs:269
	    #endregion                                                                                                                             // BuildMemberBase.cs:345
	                                                                                                                                           // BuildMemberBase.cs:186
	    // BuildMemberBase.cs:187
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public MMGBreastDensity(Int32 min, Int32 max) : base("Observation.hasMember:mGBreastDensity", min, max)                                // BuildMemberBase.cs:190
	    {                                                                                                                                      // BuildMemberBase.cs:191
	    }                                                                                                                                      // BuildMemberBase.cs:193
	                                                                                                                                           // BuildMemberBase.cs:195
	    // Methods                                                                                                                             // BuildMemberBase.cs:196
	                                                                                                                                           // BuildMemberBase.cs:349
	    // BuildMemberBase.cs:350
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
	                                                                                                                                           // BuildMemberBase.cs:355
	    // BuildMemberBase.cs:356
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
	}                                                                                                                                          // BuildMemberBase.cs:198
	#endregion                                                                                                                                 // BuildMemberBase.cs:199
	//- LocalClassDefs
}
