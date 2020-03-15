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
	#region Observation.hasMember:abnormalityCyst Container Class                                                                              // BuildMemberBase.cs:137
	/// <summary>
	/// Container class for Observation.hasMember:abnormalityCyst.
	/// </summary>
	public class AbnormalityCystContainer : MContainer, ITMItem<ResourceReference>                                                             // BuildMemberBase.cs:141
	{                                                                                                                                          // BuildMemberBase.cs:142
	    #region Observation.hasMember:abnormalityCyst Item Class                                                                               // BuildMemberBase.cs:73
	    /// <summary>
	    /// Item class for Observation.hasMember:abnormalityCyst.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:77
	    {                                                                                                                                      // BuildMemberBase.cs:78
	        // Properties                                                                                                                      // BuildMemberBase.cs:79
	        /// <summary>
	        /// Value
	        /// </summary>
	        public AbnormalityCyst Value { get; set; }                                                                                         // BuildMemberBase.cs:83
	                                                                                                                                           // BuildMemberBase.cs:85
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(AbnormalityCyst value)                                                                                                 // BuildMemberBase.cs:89
	        {                                                                                                                                  // BuildMemberBase.cs:90
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:91
	        }                                                                                                                                  // BuildMemberBase.cs:93
	                                                                                                                                           // BuildMemberBase.cs:95
	        // Methods                                                                                                                         // BuildMemberBase.cs:96
	    }                                                                                                                                      // BuildMemberBase.cs:98
	    #endregion                                                                                                                             // BuildMemberBase.cs:99
	                                                                                                                                           // BuildMemberBase.cs:144
	    // Properties                                                                                                                          // BuildMemberBase.cs:145
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:118
	    {                                                                                                                                      // BuildMemberBase.cs:119
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityCyst"                                                      // BuildMemberBase.cs:126
	    };                                                                                                                                     // BuildMemberBase.cs:127
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:232
	                                                                                                                                           // BuildMemberBase.cs:234
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:238
	                                                                                                                                           // BuildMemberBase.cs:240
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:244
	                                                                                                                                           // BuildMemberBase.cs:246
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:250
	                                                                                                                                           // BuildMemberBase.cs:252
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<AbnormalityCyst> All()                                                                                              // BuildMemberBase.cs:256
	    {                                                                                                                                      // BuildMemberBase.cs:257
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:258
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:259
	    }                                                                                                                                      // BuildMemberBase.cs:260
	                                                                                                                                           // BuildMemberBase.cs:262
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public AbnormalityCyst GetAt(Int32 i) => this.items[i].Value;                                                                          // BuildMemberBase.cs:266
	                                                                                                                                           // BuildMemberBase.cs:268
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:272
	                                                                                                                                           // BuildMemberBase.cs:274
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:278
	                                                                                                                                           // BuildMemberBase.cs:147
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public AbnormalityCystContainer(Int32 min, Int32 max) : base("Observation.hasMember:abnormalityCyst", min, max)                        // BuildMemberBase.cs:151
	    {                                                                                                                                      // BuildMemberBase.cs:152
	    }                                                                                                                                      // BuildMemberBase.cs:154
	                                                                                                                                           // BuildMemberBase.cs:155
	    // Methods                                                                                                                             // BuildMemberBase.cs:156
	                                                                                                                                           // BuildMemberBase.cs:284
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public AbnormalityCyst Append(AbnormalityCyst value)                                                                                   // BuildMemberBase.cs:288
	    {                                                                                                                                      // BuildMemberBase.cs:289
	        this.items.Add(new Item(value));                                                                                                   // BuildMemberBase.cs:290
	        return value;                                                                                                                      // BuildMemberBase.cs:291
	    }                                                                                                                                      // BuildMemberBase.cs:292
	                                                                                                                                           // BuildMemberBase.cs:298
	    /// <summary>
	    /// Write single item as a fhir element.
	    /// </summary>
	    public IEnumerable<ResourceReference> Write(BreastRadiologyDocument doc)                                                               // BuildMemberReferences.cs:70
	    {                                                                                                                                      // BuildMemberReferences.cs:71
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberReferences.cs:72
	        {                                                                                                                                  // BuildMemberReferences.cs:73
	            ResourceReference reference = new ResourceReference                                                                            // BuildMemberReferences.cs:74
	            {                                                                                                                              // BuildMemberReferences.cs:75
	                Reference = item.Value.Id                                                                                                  // BuildMemberReferences.cs:76
	            };                                                                                                                             // BuildMemberReferences.cs:77
	            yield return reference;                                                                                                        // BuildMemberReferences.cs:78
	        }                                                                                                                                  // BuildMemberReferences.cs:79
	    }                                                                                                                                      // BuildMemberReferences.cs:80
	                                                                                                                                           // BuildMemberBase.cs:304
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	                                                                                                                                           // BuildMemberReferences.cs:46
	    public void Read(BreastRadiologyDocument doc, IEnumerable<ResourceReference> references)                                               // BuildMemberReferences.cs:47
	    {                                                                                                                                      // BuildMemberReferences.cs:48
	        IEnumerable<ResourceBase> resources = base.IsMember(doc,                                                                           // BuildMemberReferences.cs:49
	            references,                                                                                                                    // BuildMemberReferences.cs:50
	            this.targetUrls);                                                                                                              // BuildMemberReferences.cs:51
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberReferences.cs:52
	        foreach (ResourceBase resource in resources)                                                                                       // BuildMemberReferences.cs:53
	        {                                                                                                                                  // BuildMemberReferences.cs:54
	            Item item = new Item((AbnormalityCyst) resource);                                                                              // BuildMemberReferences.cs:55
	            items.Add(item);                                                                                                               // BuildMemberReferences.cs:56
	        }                                                                                                                                  // BuildMemberReferences.cs:57
	        this.SetAllItems(items);                                                                                                           // BuildMemberReferences.cs:58
	    }                                                                                                                                      // BuildMemberReferences.cs:59
	}                                                                                                                                          // BuildMemberBase.cs:158
	#endregion                                                                                                                                 // BuildMemberBase.cs:159
	#region Observation.hasMember:abnormalityDuct Container Class                                                                              // BuildMemberBase.cs:137
	/// <summary>
	/// Container class for Observation.hasMember:abnormalityDuct.
	/// </summary>
	public class AbnormalityDuctContainer : MContainer, ITMItem<ResourceReference>                                                             // BuildMemberBase.cs:141
	{                                                                                                                                          // BuildMemberBase.cs:142
	    #region Observation.hasMember:abnormalityDuct Item Class                                                                               // BuildMemberBase.cs:73
	    /// <summary>
	    /// Item class for Observation.hasMember:abnormalityDuct.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:77
	    {                                                                                                                                      // BuildMemberBase.cs:78
	        // Properties                                                                                                                      // BuildMemberBase.cs:79
	        /// <summary>
	        /// Value
	        /// </summary>
	        public AbnormalityDuct Value { get; set; }                                                                                         // BuildMemberBase.cs:83
	                                                                                                                                           // BuildMemberBase.cs:85
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(AbnormalityDuct value)                                                                                                 // BuildMemberBase.cs:89
	        {                                                                                                                                  // BuildMemberBase.cs:90
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:91
	        }                                                                                                                                  // BuildMemberBase.cs:93
	                                                                                                                                           // BuildMemberBase.cs:95
	        // Methods                                                                                                                         // BuildMemberBase.cs:96
	    }                                                                                                                                      // BuildMemberBase.cs:98
	    #endregion                                                                                                                             // BuildMemberBase.cs:99
	                                                                                                                                           // BuildMemberBase.cs:144
	    // Properties                                                                                                                          // BuildMemberBase.cs:145
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:118
	    {                                                                                                                                      // BuildMemberBase.cs:119
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityDuct"                                                      // BuildMemberBase.cs:126
	    };                                                                                                                                     // BuildMemberBase.cs:127
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:232
	                                                                                                                                           // BuildMemberBase.cs:234
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:238
	                                                                                                                                           // BuildMemberBase.cs:240
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:244
	                                                                                                                                           // BuildMemberBase.cs:246
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:250
	                                                                                                                                           // BuildMemberBase.cs:252
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<AbnormalityDuct> All()                                                                                              // BuildMemberBase.cs:256
	    {                                                                                                                                      // BuildMemberBase.cs:257
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:258
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:259
	    }                                                                                                                                      // BuildMemberBase.cs:260
	                                                                                                                                           // BuildMemberBase.cs:262
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public AbnormalityDuct GetAt(Int32 i) => this.items[i].Value;                                                                          // BuildMemberBase.cs:266
	                                                                                                                                           // BuildMemberBase.cs:268
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:272
	                                                                                                                                           // BuildMemberBase.cs:274
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:278
	                                                                                                                                           // BuildMemberBase.cs:147
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public AbnormalityDuctContainer(Int32 min, Int32 max) : base("Observation.hasMember:abnormalityDuct", min, max)                        // BuildMemberBase.cs:151
	    {                                                                                                                                      // BuildMemberBase.cs:152
	    }                                                                                                                                      // BuildMemberBase.cs:154
	                                                                                                                                           // BuildMemberBase.cs:155
	    // Methods                                                                                                                             // BuildMemberBase.cs:156
	                                                                                                                                           // BuildMemberBase.cs:284
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public AbnormalityDuct Append(AbnormalityDuct value)                                                                                   // BuildMemberBase.cs:288
	    {                                                                                                                                      // BuildMemberBase.cs:289
	        this.items.Add(new Item(value));                                                                                                   // BuildMemberBase.cs:290
	        return value;                                                                                                                      // BuildMemberBase.cs:291
	    }                                                                                                                                      // BuildMemberBase.cs:292
	                                                                                                                                           // BuildMemberBase.cs:298
	    /// <summary>
	    /// Write single item as a fhir element.
	    /// </summary>
	    public IEnumerable<ResourceReference> Write(BreastRadiologyDocument doc)                                                               // BuildMemberReferences.cs:70
	    {                                                                                                                                      // BuildMemberReferences.cs:71
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberReferences.cs:72
	        {                                                                                                                                  // BuildMemberReferences.cs:73
	            ResourceReference reference = new ResourceReference                                                                            // BuildMemberReferences.cs:74
	            {                                                                                                                              // BuildMemberReferences.cs:75
	                Reference = item.Value.Id                                                                                                  // BuildMemberReferences.cs:76
	            };                                                                                                                             // BuildMemberReferences.cs:77
	            yield return reference;                                                                                                        // BuildMemberReferences.cs:78
	        }                                                                                                                                  // BuildMemberReferences.cs:79
	    }                                                                                                                                      // BuildMemberReferences.cs:80
	                                                                                                                                           // BuildMemberBase.cs:304
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	                                                                                                                                           // BuildMemberReferences.cs:46
	    public void Read(BreastRadiologyDocument doc, IEnumerable<ResourceReference> references)                                               // BuildMemberReferences.cs:47
	    {                                                                                                                                      // BuildMemberReferences.cs:48
	        IEnumerable<ResourceBase> resources = base.IsMember(doc,                                                                           // BuildMemberReferences.cs:49
	            references,                                                                                                                    // BuildMemberReferences.cs:50
	            this.targetUrls);                                                                                                              // BuildMemberReferences.cs:51
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberReferences.cs:52
	        foreach (ResourceBase resource in resources)                                                                                       // BuildMemberReferences.cs:53
	        {                                                                                                                                  // BuildMemberReferences.cs:54
	            Item item = new Item((AbnormalityDuct) resource);                                                                              // BuildMemberReferences.cs:55
	            items.Add(item);                                                                                                               // BuildMemberReferences.cs:56
	        }                                                                                                                                  // BuildMemberReferences.cs:57
	        this.SetAllItems(items);                                                                                                           // BuildMemberReferences.cs:58
	    }                                                                                                                                      // BuildMemberReferences.cs:59
	}                                                                                                                                          // BuildMemberBase.cs:158
	#endregion                                                                                                                                 // BuildMemberBase.cs:159
	#region Observation.hasMember:abnormalityForeignObject Container Class                                                                     // BuildMemberBase.cs:137
	/// <summary>
	/// Container class for Observation.hasMember:abnormalityForeignObject.
	/// </summary>
	public class AbnormalityForeignObjectContainer : MContainer, ITMItem<ResourceReference>                                                    // BuildMemberBase.cs:141
	{                                                                                                                                          // BuildMemberBase.cs:142
	    #region Observation.hasMember:abnormalityForeignObject Item Class                                                                      // BuildMemberBase.cs:73
	    /// <summary>
	    /// Item class for Observation.hasMember:abnormalityForeignObject.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:77
	    {                                                                                                                                      // BuildMemberBase.cs:78
	        // Properties                                                                                                                      // BuildMemberBase.cs:79
	        /// <summary>
	        /// Value
	        /// </summary>
	        public AbnormalityForeignObject Value { get; set; }                                                                                // BuildMemberBase.cs:83
	                                                                                                                                           // BuildMemberBase.cs:85
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(AbnormalityForeignObject value)                                                                                        // BuildMemberBase.cs:89
	        {                                                                                                                                  // BuildMemberBase.cs:90
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:91
	        }                                                                                                                                  // BuildMemberBase.cs:93
	                                                                                                                                           // BuildMemberBase.cs:95
	        // Methods                                                                                                                         // BuildMemberBase.cs:96
	    }                                                                                                                                      // BuildMemberBase.cs:98
	    #endregion                                                                                                                             // BuildMemberBase.cs:99
	                                                                                                                                           // BuildMemberBase.cs:144
	    // Properties                                                                                                                          // BuildMemberBase.cs:145
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:118
	    {                                                                                                                                      // BuildMemberBase.cs:119
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityForeignObject"                                             // BuildMemberBase.cs:126
	    };                                                                                                                                     // BuildMemberBase.cs:127
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:232
	                                                                                                                                           // BuildMemberBase.cs:234
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:238
	                                                                                                                                           // BuildMemberBase.cs:240
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:244
	                                                                                                                                           // BuildMemberBase.cs:246
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:250
	                                                                                                                                           // BuildMemberBase.cs:252
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<AbnormalityForeignObject> All()                                                                                     // BuildMemberBase.cs:256
	    {                                                                                                                                      // BuildMemberBase.cs:257
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:258
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:259
	    }                                                                                                                                      // BuildMemberBase.cs:260
	                                                                                                                                           // BuildMemberBase.cs:262
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public AbnormalityForeignObject GetAt(Int32 i) => this.items[i].Value;                                                                 // BuildMemberBase.cs:266
	                                                                                                                                           // BuildMemberBase.cs:268
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:272
	                                                                                                                                           // BuildMemberBase.cs:274
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:278
	                                                                                                                                           // BuildMemberBase.cs:147
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public AbnormalityForeignObjectContainer(Int32 min, Int32 max) : base("Observation.hasMember:abnormalityForeignObject", min, max)      // BuildMemberBase.cs:151
	    {                                                                                                                                      // BuildMemberBase.cs:152
	    }                                                                                                                                      // BuildMemberBase.cs:154
	                                                                                                                                           // BuildMemberBase.cs:155
	    // Methods                                                                                                                             // BuildMemberBase.cs:156
	                                                                                                                                           // BuildMemberBase.cs:284
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public AbnormalityForeignObject Append(AbnormalityForeignObject value)                                                                 // BuildMemberBase.cs:288
	    {                                                                                                                                      // BuildMemberBase.cs:289
	        this.items.Add(new Item(value));                                                                                                   // BuildMemberBase.cs:290
	        return value;                                                                                                                      // BuildMemberBase.cs:291
	    }                                                                                                                                      // BuildMemberBase.cs:292
	                                                                                                                                           // BuildMemberBase.cs:298
	    /// <summary>
	    /// Write single item as a fhir element.
	    /// </summary>
	    public IEnumerable<ResourceReference> Write(BreastRadiologyDocument doc)                                                               // BuildMemberReferences.cs:70
	    {                                                                                                                                      // BuildMemberReferences.cs:71
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberReferences.cs:72
	        {                                                                                                                                  // BuildMemberReferences.cs:73
	            ResourceReference reference = new ResourceReference                                                                            // BuildMemberReferences.cs:74
	            {                                                                                                                              // BuildMemberReferences.cs:75
	                Reference = item.Value.Id                                                                                                  // BuildMemberReferences.cs:76
	            };                                                                                                                             // BuildMemberReferences.cs:77
	            yield return reference;                                                                                                        // BuildMemberReferences.cs:78
	        }                                                                                                                                  // BuildMemberReferences.cs:79
	    }                                                                                                                                      // BuildMemberReferences.cs:80
	                                                                                                                                           // BuildMemberBase.cs:304
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	                                                                                                                                           // BuildMemberReferences.cs:46
	    public void Read(BreastRadiologyDocument doc, IEnumerable<ResourceReference> references)                                               // BuildMemberReferences.cs:47
	    {                                                                                                                                      // BuildMemberReferences.cs:48
	        IEnumerable<ResourceBase> resources = base.IsMember(doc,                                                                           // BuildMemberReferences.cs:49
	            references,                                                                                                                    // BuildMemberReferences.cs:50
	            this.targetUrls);                                                                                                              // BuildMemberReferences.cs:51
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberReferences.cs:52
	        foreach (ResourceBase resource in resources)                                                                                       // BuildMemberReferences.cs:53
	        {                                                                                                                                  // BuildMemberReferences.cs:54
	            Item item = new Item((AbnormalityForeignObject) resource);                                                                     // BuildMemberReferences.cs:55
	            items.Add(item);                                                                                                               // BuildMemberReferences.cs:56
	        }                                                                                                                                  // BuildMemberReferences.cs:57
	        this.SetAllItems(items);                                                                                                           // BuildMemberReferences.cs:58
	    }                                                                                                                                      // BuildMemberReferences.cs:59
	}                                                                                                                                          // BuildMemberBase.cs:158
	#endregion                                                                                                                                 // BuildMemberBase.cs:159
	#region Observation.hasMember:abnormalityLymphNode Container Class                                                                         // BuildMemberBase.cs:137
	/// <summary>
	/// Container class for Observation.hasMember:abnormalityLymphNode.
	/// </summary>
	public class AbnormalityLymphNodeContainer : MContainer, ITMItem<ResourceReference>                                                        // BuildMemberBase.cs:141
	{                                                                                                                                          // BuildMemberBase.cs:142
	    #region Observation.hasMember:abnormalityLymphNode Item Class                                                                          // BuildMemberBase.cs:73
	    /// <summary>
	    /// Item class for Observation.hasMember:abnormalityLymphNode.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:77
	    {                                                                                                                                      // BuildMemberBase.cs:78
	        // Properties                                                                                                                      // BuildMemberBase.cs:79
	        /// <summary>
	        /// Value
	        /// </summary>
	        public AbnormalityLymphNode Value { get; set; }                                                                                    // BuildMemberBase.cs:83
	                                                                                                                                           // BuildMemberBase.cs:85
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(AbnormalityLymphNode value)                                                                                            // BuildMemberBase.cs:89
	        {                                                                                                                                  // BuildMemberBase.cs:90
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:91
	        }                                                                                                                                  // BuildMemberBase.cs:93
	                                                                                                                                           // BuildMemberBase.cs:95
	        // Methods                                                                                                                         // BuildMemberBase.cs:96
	    }                                                                                                                                      // BuildMemberBase.cs:98
	    #endregion                                                                                                                             // BuildMemberBase.cs:99
	                                                                                                                                           // BuildMemberBase.cs:144
	    // Properties                                                                                                                          // BuildMemberBase.cs:145
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:118
	    {                                                                                                                                      // BuildMemberBase.cs:119
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityLymphNode"                                                 // BuildMemberBase.cs:126
	    };                                                                                                                                     // BuildMemberBase.cs:127
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:232
	                                                                                                                                           // BuildMemberBase.cs:234
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:238
	                                                                                                                                           // BuildMemberBase.cs:240
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:244
	                                                                                                                                           // BuildMemberBase.cs:246
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:250
	                                                                                                                                           // BuildMemberBase.cs:252
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<AbnormalityLymphNode> All()                                                                                         // BuildMemberBase.cs:256
	    {                                                                                                                                      // BuildMemberBase.cs:257
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:258
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:259
	    }                                                                                                                                      // BuildMemberBase.cs:260
	                                                                                                                                           // BuildMemberBase.cs:262
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public AbnormalityLymphNode GetAt(Int32 i) => this.items[i].Value;                                                                     // BuildMemberBase.cs:266
	                                                                                                                                           // BuildMemberBase.cs:268
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:272
	                                                                                                                                           // BuildMemberBase.cs:274
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:278
	                                                                                                                                           // BuildMemberBase.cs:147
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public AbnormalityLymphNodeContainer(Int32 min, Int32 max) : base("Observation.hasMember:abnormalityLymphNode", min, max)              // BuildMemberBase.cs:151
	    {                                                                                                                                      // BuildMemberBase.cs:152
	    }                                                                                                                                      // BuildMemberBase.cs:154
	                                                                                                                                           // BuildMemberBase.cs:155
	    // Methods                                                                                                                             // BuildMemberBase.cs:156
	                                                                                                                                           // BuildMemberBase.cs:284
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public AbnormalityLymphNode Append(AbnormalityLymphNode value)                                                                         // BuildMemberBase.cs:288
	    {                                                                                                                                      // BuildMemberBase.cs:289
	        this.items.Add(new Item(value));                                                                                                   // BuildMemberBase.cs:290
	        return value;                                                                                                                      // BuildMemberBase.cs:291
	    }                                                                                                                                      // BuildMemberBase.cs:292
	                                                                                                                                           // BuildMemberBase.cs:298
	    /// <summary>
	    /// Write single item as a fhir element.
	    /// </summary>
	    public IEnumerable<ResourceReference> Write(BreastRadiologyDocument doc)                                                               // BuildMemberReferences.cs:70
	    {                                                                                                                                      // BuildMemberReferences.cs:71
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberReferences.cs:72
	        {                                                                                                                                  // BuildMemberReferences.cs:73
	            ResourceReference reference = new ResourceReference                                                                            // BuildMemberReferences.cs:74
	            {                                                                                                                              // BuildMemberReferences.cs:75
	                Reference = item.Value.Id                                                                                                  // BuildMemberReferences.cs:76
	            };                                                                                                                             // BuildMemberReferences.cs:77
	            yield return reference;                                                                                                        // BuildMemberReferences.cs:78
	        }                                                                                                                                  // BuildMemberReferences.cs:79
	    }                                                                                                                                      // BuildMemberReferences.cs:80
	                                                                                                                                           // BuildMemberBase.cs:304
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	                                                                                                                                           // BuildMemberReferences.cs:46
	    public void Read(BreastRadiologyDocument doc, IEnumerable<ResourceReference> references)                                               // BuildMemberReferences.cs:47
	    {                                                                                                                                      // BuildMemberReferences.cs:48
	        IEnumerable<ResourceBase> resources = base.IsMember(doc,                                                                           // BuildMemberReferences.cs:49
	            references,                                                                                                                    // BuildMemberReferences.cs:50
	            this.targetUrls);                                                                                                              // BuildMemberReferences.cs:51
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberReferences.cs:52
	        foreach (ResourceBase resource in resources)                                                                                       // BuildMemberReferences.cs:53
	        {                                                                                                                                  // BuildMemberReferences.cs:54
	            Item item = new Item((AbnormalityLymphNode) resource);                                                                         // BuildMemberReferences.cs:55
	            items.Add(item);                                                                                                               // BuildMemberReferences.cs:56
	        }                                                                                                                                  // BuildMemberReferences.cs:57
	        this.SetAllItems(items);                                                                                                           // BuildMemberReferences.cs:58
	    }                                                                                                                                      // BuildMemberReferences.cs:59
	}                                                                                                                                          // BuildMemberBase.cs:158
	#endregion                                                                                                                                 // BuildMemberBase.cs:159
	#region Observation.hasMember:abnormalityMass Container Class                                                                              // BuildMemberBase.cs:137
	/// <summary>
	/// Container class for Observation.hasMember:abnormalityMass.
	/// </summary>
	public class AbnormalityMassContainer : MContainer, ITMItem<ResourceReference>                                                             // BuildMemberBase.cs:141
	{                                                                                                                                          // BuildMemberBase.cs:142
	    #region Observation.hasMember:abnormalityMass Item Class                                                                               // BuildMemberBase.cs:73
	    /// <summary>
	    /// Item class for Observation.hasMember:abnormalityMass.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:77
	    {                                                                                                                                      // BuildMemberBase.cs:78
	        // Properties                                                                                                                      // BuildMemberBase.cs:79
	        /// <summary>
	        /// Value
	        /// </summary>
	        public AbnormalityMass Value { get; set; }                                                                                         // BuildMemberBase.cs:83
	                                                                                                                                           // BuildMemberBase.cs:85
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(AbnormalityMass value)                                                                                                 // BuildMemberBase.cs:89
	        {                                                                                                                                  // BuildMemberBase.cs:90
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:91
	        }                                                                                                                                  // BuildMemberBase.cs:93
	                                                                                                                                           // BuildMemberBase.cs:95
	        // Methods                                                                                                                         // BuildMemberBase.cs:96
	    }                                                                                                                                      // BuildMemberBase.cs:98
	    #endregion                                                                                                                             // BuildMemberBase.cs:99
	                                                                                                                                           // BuildMemberBase.cs:144
	    // Properties                                                                                                                          // BuildMemberBase.cs:145
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:118
	    {                                                                                                                                      // BuildMemberBase.cs:119
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityMass"                                                      // BuildMemberBase.cs:126
	    };                                                                                                                                     // BuildMemberBase.cs:127
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:232
	                                                                                                                                           // BuildMemberBase.cs:234
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:238
	                                                                                                                                           // BuildMemberBase.cs:240
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:244
	                                                                                                                                           // BuildMemberBase.cs:246
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:250
	                                                                                                                                           // BuildMemberBase.cs:252
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<AbnormalityMass> All()                                                                                              // BuildMemberBase.cs:256
	    {                                                                                                                                      // BuildMemberBase.cs:257
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:258
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:259
	    }                                                                                                                                      // BuildMemberBase.cs:260
	                                                                                                                                           // BuildMemberBase.cs:262
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public AbnormalityMass GetAt(Int32 i) => this.items[i].Value;                                                                          // BuildMemberBase.cs:266
	                                                                                                                                           // BuildMemberBase.cs:268
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:272
	                                                                                                                                           // BuildMemberBase.cs:274
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:278
	                                                                                                                                           // BuildMemberBase.cs:147
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public AbnormalityMassContainer(Int32 min, Int32 max) : base("Observation.hasMember:abnormalityMass", min, max)                        // BuildMemberBase.cs:151
	    {                                                                                                                                      // BuildMemberBase.cs:152
	    }                                                                                                                                      // BuildMemberBase.cs:154
	                                                                                                                                           // BuildMemberBase.cs:155
	    // Methods                                                                                                                             // BuildMemberBase.cs:156
	                                                                                                                                           // BuildMemberBase.cs:284
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public AbnormalityMass Append(AbnormalityMass value)                                                                                   // BuildMemberBase.cs:288
	    {                                                                                                                                      // BuildMemberBase.cs:289
	        this.items.Add(new Item(value));                                                                                                   // BuildMemberBase.cs:290
	        return value;                                                                                                                      // BuildMemberBase.cs:291
	    }                                                                                                                                      // BuildMemberBase.cs:292
	                                                                                                                                           // BuildMemberBase.cs:298
	    /// <summary>
	    /// Write single item as a fhir element.
	    /// </summary>
	    public IEnumerable<ResourceReference> Write(BreastRadiologyDocument doc)                                                               // BuildMemberReferences.cs:70
	    {                                                                                                                                      // BuildMemberReferences.cs:71
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberReferences.cs:72
	        {                                                                                                                                  // BuildMemberReferences.cs:73
	            ResourceReference reference = new ResourceReference                                                                            // BuildMemberReferences.cs:74
	            {                                                                                                                              // BuildMemberReferences.cs:75
	                Reference = item.Value.Id                                                                                                  // BuildMemberReferences.cs:76
	            };                                                                                                                             // BuildMemberReferences.cs:77
	            yield return reference;                                                                                                        // BuildMemberReferences.cs:78
	        }                                                                                                                                  // BuildMemberReferences.cs:79
	    }                                                                                                                                      // BuildMemberReferences.cs:80
	                                                                                                                                           // BuildMemberBase.cs:304
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	                                                                                                                                           // BuildMemberReferences.cs:46
	    public void Read(BreastRadiologyDocument doc, IEnumerable<ResourceReference> references)                                               // BuildMemberReferences.cs:47
	    {                                                                                                                                      // BuildMemberReferences.cs:48
	        IEnumerable<ResourceBase> resources = base.IsMember(doc,                                                                           // BuildMemberReferences.cs:49
	            references,                                                                                                                    // BuildMemberReferences.cs:50
	            this.targetUrls);                                                                                                              // BuildMemberReferences.cs:51
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberReferences.cs:52
	        foreach (ResourceBase resource in resources)                                                                                       // BuildMemberReferences.cs:53
	        {                                                                                                                                  // BuildMemberReferences.cs:54
	            Item item = new Item((AbnormalityMass) resource);                                                                              // BuildMemberReferences.cs:55
	            items.Add(item);                                                                                                               // BuildMemberReferences.cs:56
	        }                                                                                                                                  // BuildMemberReferences.cs:57
	        this.SetAllItems(items);                                                                                                           // BuildMemberReferences.cs:58
	    }                                                                                                                                      // BuildMemberReferences.cs:59
	}                                                                                                                                          // BuildMemberBase.cs:158
	#endregion                                                                                                                                 // BuildMemberBase.cs:159
	#region Observation.hasMember:associatedFeature Container Class                                                                            // BuildMemberBase.cs:137
	/// <summary>
	/// Container class for Observation.hasMember:associatedFeature.
	/// </summary>
	public class AssociatedFeatureContainer : MContainer, ITMItem<ResourceReference>                                                           // BuildMemberBase.cs:141
	{                                                                                                                                          // BuildMemberBase.cs:142
	    #region Observation.hasMember:associatedFeature Item Class                                                                             // BuildMemberBase.cs:73
	    /// <summary>
	    /// Item class for Observation.hasMember:associatedFeature.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:77
	    {                                                                                                                                      // BuildMemberBase.cs:78
	        // Properties                                                                                                                      // BuildMemberBase.cs:79
	        /// <summary>
	        /// Value
	        /// </summary>
	        public AssociatedFeature Value { get; set; }                                                                                       // BuildMemberBase.cs:83
	                                                                                                                                           // BuildMemberBase.cs:85
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(AssociatedFeature value)                                                                                               // BuildMemberBase.cs:89
	        {                                                                                                                                  // BuildMemberBase.cs:90
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:91
	        }                                                                                                                                  // BuildMemberBase.cs:93
	                                                                                                                                           // BuildMemberBase.cs:95
	        // Methods                                                                                                                         // BuildMemberBase.cs:96
	    }                                                                                                                                      // BuildMemberBase.cs:98
	    #endregion                                                                                                                             // BuildMemberBase.cs:99
	                                                                                                                                           // BuildMemberBase.cs:144
	    // Properties                                                                                                                          // BuildMemberBase.cs:145
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:118
	    {                                                                                                                                      // BuildMemberBase.cs:119
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AssociatedFeature"                                                    // BuildMemberBase.cs:126
	    };                                                                                                                                     // BuildMemberBase.cs:127
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:232
	                                                                                                                                           // BuildMemberBase.cs:234
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:238
	                                                                                                                                           // BuildMemberBase.cs:240
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:244
	                                                                                                                                           // BuildMemberBase.cs:246
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:250
	                                                                                                                                           // BuildMemberBase.cs:252
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<AssociatedFeature> All()                                                                                            // BuildMemberBase.cs:256
	    {                                                                                                                                      // BuildMemberBase.cs:257
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:258
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:259
	    }                                                                                                                                      // BuildMemberBase.cs:260
	                                                                                                                                           // BuildMemberBase.cs:262
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public AssociatedFeature GetAt(Int32 i) => this.items[i].Value;                                                                        // BuildMemberBase.cs:266
	                                                                                                                                           // BuildMemberBase.cs:268
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:272
	                                                                                                                                           // BuildMemberBase.cs:274
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:278
	                                                                                                                                           // BuildMemberBase.cs:147
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public AssociatedFeatureContainer(Int32 min, Int32 max) : base("Observation.hasMember:associatedFeature", min, max)                    // BuildMemberBase.cs:151
	    {                                                                                                                                      // BuildMemberBase.cs:152
	    }                                                                                                                                      // BuildMemberBase.cs:154
	                                                                                                                                           // BuildMemberBase.cs:155
	    // Methods                                                                                                                             // BuildMemberBase.cs:156
	                                                                                                                                           // BuildMemberBase.cs:284
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public AssociatedFeature Append(AssociatedFeature value)                                                                               // BuildMemberBase.cs:288
	    {                                                                                                                                      // BuildMemberBase.cs:289
	        this.items.Add(new Item(value));                                                                                                   // BuildMemberBase.cs:290
	        return value;                                                                                                                      // BuildMemberBase.cs:291
	    }                                                                                                                                      // BuildMemberBase.cs:292
	                                                                                                                                           // BuildMemberBase.cs:298
	    /// <summary>
	    /// Write single item as a fhir element.
	    /// </summary>
	    public IEnumerable<ResourceReference> Write(BreastRadiologyDocument doc)                                                               // BuildMemberReferences.cs:70
	    {                                                                                                                                      // BuildMemberReferences.cs:71
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberReferences.cs:72
	        {                                                                                                                                  // BuildMemberReferences.cs:73
	            ResourceReference reference = new ResourceReference                                                                            // BuildMemberReferences.cs:74
	            {                                                                                                                              // BuildMemberReferences.cs:75
	                Reference = item.Value.Id                                                                                                  // BuildMemberReferences.cs:76
	            };                                                                                                                             // BuildMemberReferences.cs:77
	            yield return reference;                                                                                                        // BuildMemberReferences.cs:78
	        }                                                                                                                                  // BuildMemberReferences.cs:79
	    }                                                                                                                                      // BuildMemberReferences.cs:80
	                                                                                                                                           // BuildMemberBase.cs:304
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	                                                                                                                                           // BuildMemberReferences.cs:46
	    public void Read(BreastRadiologyDocument doc, IEnumerable<ResourceReference> references)                                               // BuildMemberReferences.cs:47
	    {                                                                                                                                      // BuildMemberReferences.cs:48
	        IEnumerable<ResourceBase> resources = base.IsMember(doc,                                                                           // BuildMemberReferences.cs:49
	            references,                                                                                                                    // BuildMemberReferences.cs:50
	            this.targetUrls);                                                                                                              // BuildMemberReferences.cs:51
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberReferences.cs:52
	        foreach (ResourceBase resource in resources)                                                                                       // BuildMemberReferences.cs:53
	        {                                                                                                                                  // BuildMemberReferences.cs:54
	            Item item = new Item((AssociatedFeature) resource);                                                                            // BuildMemberReferences.cs:55
	            items.Add(item);                                                                                                               // BuildMemberReferences.cs:56
	        }                                                                                                                                  // BuildMemberReferences.cs:57
	        this.SetAllItems(items);                                                                                                           // BuildMemberReferences.cs:58
	    }                                                                                                                                      // BuildMemberReferences.cs:59
	}                                                                                                                                          // BuildMemberBase.cs:158
	#endregion                                                                                                                                 // BuildMemberBase.cs:159
	#region Observation.hasMember:abnormalityFibroadenoma Container Class                                                                      // BuildMemberBase.cs:137
	/// <summary>
	/// Container class for Observation.hasMember:abnormalityFibroadenoma.
	/// </summary>
	public class AbnormalityFibroadenomaContainer : MContainer, ITMItem<ResourceReference>                                                     // BuildMemberBase.cs:141
	{                                                                                                                                          // BuildMemberBase.cs:142
	    #region Observation.hasMember:abnormalityFibroadenoma Item Class                                                                       // BuildMemberBase.cs:73
	    /// <summary>
	    /// Item class for Observation.hasMember:abnormalityFibroadenoma.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:77
	    {                                                                                                                                      // BuildMemberBase.cs:78
	        // Properties                                                                                                                      // BuildMemberBase.cs:79
	        /// <summary>
	        /// Value
	        /// </summary>
	        public AbnormalityFibroadenoma Value { get; set; }                                                                                 // BuildMemberBase.cs:83
	                                                                                                                                           // BuildMemberBase.cs:85
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(AbnormalityFibroadenoma value)                                                                                         // BuildMemberBase.cs:89
	        {                                                                                                                                  // BuildMemberBase.cs:90
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:91
	        }                                                                                                                                  // BuildMemberBase.cs:93
	                                                                                                                                           // BuildMemberBase.cs:95
	        // Methods                                                                                                                         // BuildMemberBase.cs:96
	    }                                                                                                                                      // BuildMemberBase.cs:98
	    #endregion                                                                                                                             // BuildMemberBase.cs:99
	                                                                                                                                           // BuildMemberBase.cs:144
	    // Properties                                                                                                                          // BuildMemberBase.cs:145
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:118
	    {                                                                                                                                      // BuildMemberBase.cs:119
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityFibroadenoma"                                              // BuildMemberBase.cs:126
	    };                                                                                                                                     // BuildMemberBase.cs:127
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:232
	                                                                                                                                           // BuildMemberBase.cs:234
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:238
	                                                                                                                                           // BuildMemberBase.cs:240
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:244
	                                                                                                                                           // BuildMemberBase.cs:246
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:250
	                                                                                                                                           // BuildMemberBase.cs:252
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<AbnormalityFibroadenoma> All()                                                                                      // BuildMemberBase.cs:256
	    {                                                                                                                                      // BuildMemberBase.cs:257
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:258
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:259
	    }                                                                                                                                      // BuildMemberBase.cs:260
	                                                                                                                                           // BuildMemberBase.cs:262
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public AbnormalityFibroadenoma GetAt(Int32 i) => this.items[i].Value;                                                                  // BuildMemberBase.cs:266
	                                                                                                                                           // BuildMemberBase.cs:268
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:272
	                                                                                                                                           // BuildMemberBase.cs:274
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:278
	                                                                                                                                           // BuildMemberBase.cs:147
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public AbnormalityFibroadenomaContainer(Int32 min, Int32 max) : base("Observation.hasMember:abnormalityFibroadenoma", min, max)        // BuildMemberBase.cs:151
	    {                                                                                                                                      // BuildMemberBase.cs:152
	    }                                                                                                                                      // BuildMemberBase.cs:154
	                                                                                                                                           // BuildMemberBase.cs:155
	    // Methods                                                                                                                             // BuildMemberBase.cs:156
	                                                                                                                                           // BuildMemberBase.cs:284
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public AbnormalityFibroadenoma Append(AbnormalityFibroadenoma value)                                                                   // BuildMemberBase.cs:288
	    {                                                                                                                                      // BuildMemberBase.cs:289
	        this.items.Add(new Item(value));                                                                                                   // BuildMemberBase.cs:290
	        return value;                                                                                                                      // BuildMemberBase.cs:291
	    }                                                                                                                                      // BuildMemberBase.cs:292
	                                                                                                                                           // BuildMemberBase.cs:298
	    /// <summary>
	    /// Write single item as a fhir element.
	    /// </summary>
	    public IEnumerable<ResourceReference> Write(BreastRadiologyDocument doc)                                                               // BuildMemberReferences.cs:70
	    {                                                                                                                                      // BuildMemberReferences.cs:71
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberReferences.cs:72
	        {                                                                                                                                  // BuildMemberReferences.cs:73
	            ResourceReference reference = new ResourceReference                                                                            // BuildMemberReferences.cs:74
	            {                                                                                                                              // BuildMemberReferences.cs:75
	                Reference = item.Value.Id                                                                                                  // BuildMemberReferences.cs:76
	            };                                                                                                                             // BuildMemberReferences.cs:77
	            yield return reference;                                                                                                        // BuildMemberReferences.cs:78
	        }                                                                                                                                  // BuildMemberReferences.cs:79
	    }                                                                                                                                      // BuildMemberReferences.cs:80
	                                                                                                                                           // BuildMemberBase.cs:304
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	                                                                                                                                           // BuildMemberReferences.cs:46
	    public void Read(BreastRadiologyDocument doc, IEnumerable<ResourceReference> references)                                               // BuildMemberReferences.cs:47
	    {                                                                                                                                      // BuildMemberReferences.cs:48
	        IEnumerable<ResourceBase> resources = base.IsMember(doc,                                                                           // BuildMemberReferences.cs:49
	            references,                                                                                                                    // BuildMemberReferences.cs:50
	            this.targetUrls);                                                                                                              // BuildMemberReferences.cs:51
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberReferences.cs:52
	        foreach (ResourceBase resource in resources)                                                                                       // BuildMemberReferences.cs:53
	        {                                                                                                                                  // BuildMemberReferences.cs:54
	            Item item = new Item((AbnormalityFibroadenoma) resource);                                                                      // BuildMemberReferences.cs:55
	            items.Add(item);                                                                                                               // BuildMemberReferences.cs:56
	        }                                                                                                                                  // BuildMemberReferences.cs:57
	        this.SetAllItems(items);                                                                                                           // BuildMemberReferences.cs:58
	    }                                                                                                                                      // BuildMemberReferences.cs:59
	}                                                                                                                                          // BuildMemberBase.cs:158
	#endregion                                                                                                                                 // BuildMemberBase.cs:159
	#region Observation.hasMember:mGAbnormalityArchitecturalDistortion Container Class                                                         // BuildMemberBase.cs:137
	/// <summary>
	/// Container class for Observation.hasMember:mGAbnormalityArchitecturalDistortion.
	/// </summary>
	public class MGAbnormalityArchitecturalDistortionContainer : MContainer, ITMItem<ResourceReference>                                        // BuildMemberBase.cs:141
	{                                                                                                                                          // BuildMemberBase.cs:142
	    #region Observation.hasMember:mGAbnormalityArchitecturalDistortion Item Class                                                          // BuildMemberBase.cs:73
	    /// <summary>
	    /// Item class for Observation.hasMember:mGAbnormalityArchitecturalDistortion.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:77
	    {                                                                                                                                      // BuildMemberBase.cs:78
	        // Properties                                                                                                                      // BuildMemberBase.cs:79
	        /// <summary>
	        /// Value
	        /// </summary>
	        public MGAbnormalityArchitecturalDistortion Value { get; set; }                                                                    // BuildMemberBase.cs:83
	                                                                                                                                           // BuildMemberBase.cs:85
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(MGAbnormalityArchitecturalDistortion value)                                                                            // BuildMemberBase.cs:89
	        {                                                                                                                                  // BuildMemberBase.cs:90
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:91
	        }                                                                                                                                  // BuildMemberBase.cs:93
	                                                                                                                                           // BuildMemberBase.cs:95
	        // Methods                                                                                                                         // BuildMemberBase.cs:96
	    }                                                                                                                                      // BuildMemberBase.cs:98
	    #endregion                                                                                                                             // BuildMemberBase.cs:99
	                                                                                                                                           // BuildMemberBase.cs:144
	    // Properties                                                                                                                          // BuildMemberBase.cs:145
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:118
	    {                                                                                                                                      // BuildMemberBase.cs:119
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityArchitecturalDistortion"                                 // BuildMemberBase.cs:126
	    };                                                                                                                                     // BuildMemberBase.cs:127
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:232
	                                                                                                                                           // BuildMemberBase.cs:234
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:238
	                                                                                                                                           // BuildMemberBase.cs:240
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:244
	                                                                                                                                           // BuildMemberBase.cs:246
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:250
	                                                                                                                                           // BuildMemberBase.cs:252
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<MGAbnormalityArchitecturalDistortion> All()                                                                         // BuildMemberBase.cs:256
	    {                                                                                                                                      // BuildMemberBase.cs:257
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:258
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:259
	    }                                                                                                                                      // BuildMemberBase.cs:260
	                                                                                                                                           // BuildMemberBase.cs:262
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public MGAbnormalityArchitecturalDistortion GetAt(Int32 i) => this.items[i].Value;                                                     // BuildMemberBase.cs:266
	                                                                                                                                           // BuildMemberBase.cs:268
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:272
	                                                                                                                                           // BuildMemberBase.cs:274
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:278
	                                                                                                                                           // BuildMemberBase.cs:147
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public MGAbnormalityArchitecturalDistortionContainer(Int32 min, Int32 max) : base("Observation.hasMember:mGAbnormalityArchitecturalDistortion", min, max)// BuildMemberBase.cs:151
	    {                                                                                                                                      // BuildMemberBase.cs:152
	    }                                                                                                                                      // BuildMemberBase.cs:154
	                                                                                                                                           // BuildMemberBase.cs:155
	    // Methods                                                                                                                             // BuildMemberBase.cs:156
	                                                                                                                                           // BuildMemberBase.cs:284
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public MGAbnormalityArchitecturalDistortion Append(MGAbnormalityArchitecturalDistortion value)                                         // BuildMemberBase.cs:288
	    {                                                                                                                                      // BuildMemberBase.cs:289
	        this.items.Add(new Item(value));                                                                                                   // BuildMemberBase.cs:290
	        return value;                                                                                                                      // BuildMemberBase.cs:291
	    }                                                                                                                                      // BuildMemberBase.cs:292
	                                                                                                                                           // BuildMemberBase.cs:298
	    /// <summary>
	    /// Write single item as a fhir element.
	    /// </summary>
	    public IEnumerable<ResourceReference> Write(BreastRadiologyDocument doc)                                                               // BuildMemberReferences.cs:70
	    {                                                                                                                                      // BuildMemberReferences.cs:71
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberReferences.cs:72
	        {                                                                                                                                  // BuildMemberReferences.cs:73
	            ResourceReference reference = new ResourceReference                                                                            // BuildMemberReferences.cs:74
	            {                                                                                                                              // BuildMemberReferences.cs:75
	                Reference = item.Value.Id                                                                                                  // BuildMemberReferences.cs:76
	            };                                                                                                                             // BuildMemberReferences.cs:77
	            yield return reference;                                                                                                        // BuildMemberReferences.cs:78
	        }                                                                                                                                  // BuildMemberReferences.cs:79
	    }                                                                                                                                      // BuildMemberReferences.cs:80
	                                                                                                                                           // BuildMemberBase.cs:304
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	                                                                                                                                           // BuildMemberReferences.cs:46
	    public void Read(BreastRadiologyDocument doc, IEnumerable<ResourceReference> references)                                               // BuildMemberReferences.cs:47
	    {                                                                                                                                      // BuildMemberReferences.cs:48
	        IEnumerable<ResourceBase> resources = base.IsMember(doc,                                                                           // BuildMemberReferences.cs:49
	            references,                                                                                                                    // BuildMemberReferences.cs:50
	            this.targetUrls);                                                                                                              // BuildMemberReferences.cs:51
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberReferences.cs:52
	        foreach (ResourceBase resource in resources)                                                                                       // BuildMemberReferences.cs:53
	        {                                                                                                                                  // BuildMemberReferences.cs:54
	            Item item = new Item((MGAbnormalityArchitecturalDistortion) resource);                                                         // BuildMemberReferences.cs:55
	            items.Add(item);                                                                                                               // BuildMemberReferences.cs:56
	        }                                                                                                                                  // BuildMemberReferences.cs:57
	        this.SetAllItems(items);                                                                                                           // BuildMemberReferences.cs:58
	    }                                                                                                                                      // BuildMemberReferences.cs:59
	}                                                                                                                                          // BuildMemberBase.cs:158
	#endregion                                                                                                                                 // BuildMemberBase.cs:159
	#region Observation.hasMember:mGAbnormalityAsymmetry Container Class                                                                       // BuildMemberBase.cs:137
	/// <summary>
	/// Container class for Observation.hasMember:mGAbnormalityAsymmetry.
	/// </summary>
	public class MGAbnormalityAsymmetryContainer : MContainer, ITMItem<ResourceReference>                                                      // BuildMemberBase.cs:141
	{                                                                                                                                          // BuildMemberBase.cs:142
	    #region Observation.hasMember:mGAbnormalityAsymmetry Item Class                                                                        // BuildMemberBase.cs:73
	    /// <summary>
	    /// Item class for Observation.hasMember:mGAbnormalityAsymmetry.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:77
	    {                                                                                                                                      // BuildMemberBase.cs:78
	        // Properties                                                                                                                      // BuildMemberBase.cs:79
	        /// <summary>
	        /// Value
	        /// </summary>
	        public MGAbnormalityAsymmetry Value { get; set; }                                                                                  // BuildMemberBase.cs:83
	                                                                                                                                           // BuildMemberBase.cs:85
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(MGAbnormalityAsymmetry value)                                                                                          // BuildMemberBase.cs:89
	        {                                                                                                                                  // BuildMemberBase.cs:90
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:91
	        }                                                                                                                                  // BuildMemberBase.cs:93
	                                                                                                                                           // BuildMemberBase.cs:95
	        // Methods                                                                                                                         // BuildMemberBase.cs:96
	    }                                                                                                                                      // BuildMemberBase.cs:98
	    #endregion                                                                                                                             // BuildMemberBase.cs:99
	                                                                                                                                           // BuildMemberBase.cs:144
	    // Properties                                                                                                                          // BuildMemberBase.cs:145
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:118
	    {                                                                                                                                      // BuildMemberBase.cs:119
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityAsymmetry"                                               // BuildMemberBase.cs:126
	    };                                                                                                                                     // BuildMemberBase.cs:127
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:232
	                                                                                                                                           // BuildMemberBase.cs:234
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:238
	                                                                                                                                           // BuildMemberBase.cs:240
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:244
	                                                                                                                                           // BuildMemberBase.cs:246
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:250
	                                                                                                                                           // BuildMemberBase.cs:252
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<MGAbnormalityAsymmetry> All()                                                                                       // BuildMemberBase.cs:256
	    {                                                                                                                                      // BuildMemberBase.cs:257
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:258
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:259
	    }                                                                                                                                      // BuildMemberBase.cs:260
	                                                                                                                                           // BuildMemberBase.cs:262
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public MGAbnormalityAsymmetry GetAt(Int32 i) => this.items[i].Value;                                                                   // BuildMemberBase.cs:266
	                                                                                                                                           // BuildMemberBase.cs:268
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:272
	                                                                                                                                           // BuildMemberBase.cs:274
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:278
	                                                                                                                                           // BuildMemberBase.cs:147
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public MGAbnormalityAsymmetryContainer(Int32 min, Int32 max) : base("Observation.hasMember:mGAbnormalityAsymmetry", min, max)          // BuildMemberBase.cs:151
	    {                                                                                                                                      // BuildMemberBase.cs:152
	    }                                                                                                                                      // BuildMemberBase.cs:154
	                                                                                                                                           // BuildMemberBase.cs:155
	    // Methods                                                                                                                             // BuildMemberBase.cs:156
	                                                                                                                                           // BuildMemberBase.cs:284
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public MGAbnormalityAsymmetry Append(MGAbnormalityAsymmetry value)                                                                     // BuildMemberBase.cs:288
	    {                                                                                                                                      // BuildMemberBase.cs:289
	        this.items.Add(new Item(value));                                                                                                   // BuildMemberBase.cs:290
	        return value;                                                                                                                      // BuildMemberBase.cs:291
	    }                                                                                                                                      // BuildMemberBase.cs:292
	                                                                                                                                           // BuildMemberBase.cs:298
	    /// <summary>
	    /// Write single item as a fhir element.
	    /// </summary>
	    public IEnumerable<ResourceReference> Write(BreastRadiologyDocument doc)                                                               // BuildMemberReferences.cs:70
	    {                                                                                                                                      // BuildMemberReferences.cs:71
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberReferences.cs:72
	        {                                                                                                                                  // BuildMemberReferences.cs:73
	            ResourceReference reference = new ResourceReference                                                                            // BuildMemberReferences.cs:74
	            {                                                                                                                              // BuildMemberReferences.cs:75
	                Reference = item.Value.Id                                                                                                  // BuildMemberReferences.cs:76
	            };                                                                                                                             // BuildMemberReferences.cs:77
	            yield return reference;                                                                                                        // BuildMemberReferences.cs:78
	        }                                                                                                                                  // BuildMemberReferences.cs:79
	    }                                                                                                                                      // BuildMemberReferences.cs:80
	                                                                                                                                           // BuildMemberBase.cs:304
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	                                                                                                                                           // BuildMemberReferences.cs:46
	    public void Read(BreastRadiologyDocument doc, IEnumerable<ResourceReference> references)                                               // BuildMemberReferences.cs:47
	    {                                                                                                                                      // BuildMemberReferences.cs:48
	        IEnumerable<ResourceBase> resources = base.IsMember(doc,                                                                           // BuildMemberReferences.cs:49
	            references,                                                                                                                    // BuildMemberReferences.cs:50
	            this.targetUrls);                                                                                                              // BuildMemberReferences.cs:51
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberReferences.cs:52
	        foreach (ResourceBase resource in resources)                                                                                       // BuildMemberReferences.cs:53
	        {                                                                                                                                  // BuildMemberReferences.cs:54
	            Item item = new Item((MGAbnormalityAsymmetry) resource);                                                                       // BuildMemberReferences.cs:55
	            items.Add(item);                                                                                                               // BuildMemberReferences.cs:56
	        }                                                                                                                                  // BuildMemberReferences.cs:57
	        this.SetAllItems(items);                                                                                                           // BuildMemberReferences.cs:58
	    }                                                                                                                                      // BuildMemberReferences.cs:59
	}                                                                                                                                          // BuildMemberBase.cs:158
	#endregion                                                                                                                                 // BuildMemberBase.cs:159
	#region Observation.hasMember:mGAbnormalityCalcification Container Class                                                                   // BuildMemberBase.cs:137
	/// <summary>
	/// Container class for Observation.hasMember:mGAbnormalityCalcification.
	/// </summary>
	public class MGAbnormalityCalcificationContainer : MContainer, ITMItem<ResourceReference>                                                  // BuildMemberBase.cs:141
	{                                                                                                                                          // BuildMemberBase.cs:142
	    #region Observation.hasMember:mGAbnormalityCalcification Item Class                                                                    // BuildMemberBase.cs:73
	    /// <summary>
	    /// Item class for Observation.hasMember:mGAbnormalityCalcification.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:77
	    {                                                                                                                                      // BuildMemberBase.cs:78
	        // Properties                                                                                                                      // BuildMemberBase.cs:79
	        /// <summary>
	        /// Value
	        /// </summary>
	        public MGAbnormalityCalcification Value { get; set; }                                                                              // BuildMemberBase.cs:83
	                                                                                                                                           // BuildMemberBase.cs:85
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(MGAbnormalityCalcification value)                                                                                      // BuildMemberBase.cs:89
	        {                                                                                                                                  // BuildMemberBase.cs:90
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:91
	        }                                                                                                                                  // BuildMemberBase.cs:93
	                                                                                                                                           // BuildMemberBase.cs:95
	        // Methods                                                                                                                         // BuildMemberBase.cs:96
	    }                                                                                                                                      // BuildMemberBase.cs:98
	    #endregion                                                                                                                             // BuildMemberBase.cs:99
	                                                                                                                                           // BuildMemberBase.cs:144
	    // Properties                                                                                                                          // BuildMemberBase.cs:145
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:118
	    {                                                                                                                                      // BuildMemberBase.cs:119
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityCalcification"                                           // BuildMemberBase.cs:126
	    };                                                                                                                                     // BuildMemberBase.cs:127
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:232
	                                                                                                                                           // BuildMemberBase.cs:234
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:238
	                                                                                                                                           // BuildMemberBase.cs:240
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:244
	                                                                                                                                           // BuildMemberBase.cs:246
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:250
	                                                                                                                                           // BuildMemberBase.cs:252
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<MGAbnormalityCalcification> All()                                                                                   // BuildMemberBase.cs:256
	    {                                                                                                                                      // BuildMemberBase.cs:257
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:258
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:259
	    }                                                                                                                                      // BuildMemberBase.cs:260
	                                                                                                                                           // BuildMemberBase.cs:262
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public MGAbnormalityCalcification GetAt(Int32 i) => this.items[i].Value;                                                               // BuildMemberBase.cs:266
	                                                                                                                                           // BuildMemberBase.cs:268
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:272
	                                                                                                                                           // BuildMemberBase.cs:274
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:278
	                                                                                                                                           // BuildMemberBase.cs:147
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public MGAbnormalityCalcificationContainer(Int32 min, Int32 max) : base("Observation.hasMember:mGAbnormalityCalcification", min, max)  // BuildMemberBase.cs:151
	    {                                                                                                                                      // BuildMemberBase.cs:152
	    }                                                                                                                                      // BuildMemberBase.cs:154
	                                                                                                                                           // BuildMemberBase.cs:155
	    // Methods                                                                                                                             // BuildMemberBase.cs:156
	                                                                                                                                           // BuildMemberBase.cs:284
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public MGAbnormalityCalcification Append(MGAbnormalityCalcification value)                                                             // BuildMemberBase.cs:288
	    {                                                                                                                                      // BuildMemberBase.cs:289
	        this.items.Add(new Item(value));                                                                                                   // BuildMemberBase.cs:290
	        return value;                                                                                                                      // BuildMemberBase.cs:291
	    }                                                                                                                                      // BuildMemberBase.cs:292
	                                                                                                                                           // BuildMemberBase.cs:298
	    /// <summary>
	    /// Write single item as a fhir element.
	    /// </summary>
	    public IEnumerable<ResourceReference> Write(BreastRadiologyDocument doc)                                                               // BuildMemberReferences.cs:70
	    {                                                                                                                                      // BuildMemberReferences.cs:71
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberReferences.cs:72
	        {                                                                                                                                  // BuildMemberReferences.cs:73
	            ResourceReference reference = new ResourceReference                                                                            // BuildMemberReferences.cs:74
	            {                                                                                                                              // BuildMemberReferences.cs:75
	                Reference = item.Value.Id                                                                                                  // BuildMemberReferences.cs:76
	            };                                                                                                                             // BuildMemberReferences.cs:77
	            yield return reference;                                                                                                        // BuildMemberReferences.cs:78
	        }                                                                                                                                  // BuildMemberReferences.cs:79
	    }                                                                                                                                      // BuildMemberReferences.cs:80
	                                                                                                                                           // BuildMemberBase.cs:304
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	                                                                                                                                           // BuildMemberReferences.cs:46
	    public void Read(BreastRadiologyDocument doc, IEnumerable<ResourceReference> references)                                               // BuildMemberReferences.cs:47
	    {                                                                                                                                      // BuildMemberReferences.cs:48
	        IEnumerable<ResourceBase> resources = base.IsMember(doc,                                                                           // BuildMemberReferences.cs:49
	            references,                                                                                                                    // BuildMemberReferences.cs:50
	            this.targetUrls);                                                                                                              // BuildMemberReferences.cs:51
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberReferences.cs:52
	        foreach (ResourceBase resource in resources)                                                                                       // BuildMemberReferences.cs:53
	        {                                                                                                                                  // BuildMemberReferences.cs:54
	            Item item = new Item((MGAbnormalityCalcification) resource);                                                                   // BuildMemberReferences.cs:55
	            items.Add(item);                                                                                                               // BuildMemberReferences.cs:56
	        }                                                                                                                                  // BuildMemberReferences.cs:57
	        this.SetAllItems(items);                                                                                                           // BuildMemberReferences.cs:58
	    }                                                                                                                                      // BuildMemberReferences.cs:59
	}                                                                                                                                          // BuildMemberBase.cs:158
	#endregion                                                                                                                                 // BuildMemberBase.cs:159
	#region Observation.hasMember:mGAbnormalityDensity Container Class                                                                         // BuildMemberBase.cs:137
	/// <summary>
	/// Container class for Observation.hasMember:mGAbnormalityDensity.
	/// </summary>
	public class MGAbnormalityDensityContainer : MContainer, ITMItem<ResourceReference>                                                        // BuildMemberBase.cs:141
	{                                                                                                                                          // BuildMemberBase.cs:142
	    #region Observation.hasMember:mGAbnormalityDensity Item Class                                                                          // BuildMemberBase.cs:73
	    /// <summary>
	    /// Item class for Observation.hasMember:mGAbnormalityDensity.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:77
	    {                                                                                                                                      // BuildMemberBase.cs:78
	        // Properties                                                                                                                      // BuildMemberBase.cs:79
	        /// <summary>
	        /// Value
	        /// </summary>
	        public MGAbnormalityDensity Value { get; set; }                                                                                    // BuildMemberBase.cs:83
	                                                                                                                                           // BuildMemberBase.cs:85
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(MGAbnormalityDensity value)                                                                                            // BuildMemberBase.cs:89
	        {                                                                                                                                  // BuildMemberBase.cs:90
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:91
	        }                                                                                                                                  // BuildMemberBase.cs:93
	                                                                                                                                           // BuildMemberBase.cs:95
	        // Methods                                                                                                                         // BuildMemberBase.cs:96
	    }                                                                                                                                      // BuildMemberBase.cs:98
	    #endregion                                                                                                                             // BuildMemberBase.cs:99
	                                                                                                                                           // BuildMemberBase.cs:144
	    // Properties                                                                                                                          // BuildMemberBase.cs:145
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:118
	    {                                                                                                                                      // BuildMemberBase.cs:119
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityDensity"                                                 // BuildMemberBase.cs:126
	    };                                                                                                                                     // BuildMemberBase.cs:127
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:232
	                                                                                                                                           // BuildMemberBase.cs:234
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:238
	                                                                                                                                           // BuildMemberBase.cs:240
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:244
	                                                                                                                                           // BuildMemberBase.cs:246
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:250
	                                                                                                                                           // BuildMemberBase.cs:252
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<MGAbnormalityDensity> All()                                                                                         // BuildMemberBase.cs:256
	    {                                                                                                                                      // BuildMemberBase.cs:257
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:258
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:259
	    }                                                                                                                                      // BuildMemberBase.cs:260
	                                                                                                                                           // BuildMemberBase.cs:262
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public MGAbnormalityDensity GetAt(Int32 i) => this.items[i].Value;                                                                     // BuildMemberBase.cs:266
	                                                                                                                                           // BuildMemberBase.cs:268
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:272
	                                                                                                                                           // BuildMemberBase.cs:274
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:278
	                                                                                                                                           // BuildMemberBase.cs:147
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public MGAbnormalityDensityContainer(Int32 min, Int32 max) : base("Observation.hasMember:mGAbnormalityDensity", min, max)              // BuildMemberBase.cs:151
	    {                                                                                                                                      // BuildMemberBase.cs:152
	    }                                                                                                                                      // BuildMemberBase.cs:154
	                                                                                                                                           // BuildMemberBase.cs:155
	    // Methods                                                                                                                             // BuildMemberBase.cs:156
	                                                                                                                                           // BuildMemberBase.cs:284
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public MGAbnormalityDensity Append(MGAbnormalityDensity value)                                                                         // BuildMemberBase.cs:288
	    {                                                                                                                                      // BuildMemberBase.cs:289
	        this.items.Add(new Item(value));                                                                                                   // BuildMemberBase.cs:290
	        return value;                                                                                                                      // BuildMemberBase.cs:291
	    }                                                                                                                                      // BuildMemberBase.cs:292
	                                                                                                                                           // BuildMemberBase.cs:298
	    /// <summary>
	    /// Write single item as a fhir element.
	    /// </summary>
	    public IEnumerable<ResourceReference> Write(BreastRadiologyDocument doc)                                                               // BuildMemberReferences.cs:70
	    {                                                                                                                                      // BuildMemberReferences.cs:71
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberReferences.cs:72
	        {                                                                                                                                  // BuildMemberReferences.cs:73
	            ResourceReference reference = new ResourceReference                                                                            // BuildMemberReferences.cs:74
	            {                                                                                                                              // BuildMemberReferences.cs:75
	                Reference = item.Value.Id                                                                                                  // BuildMemberReferences.cs:76
	            };                                                                                                                             // BuildMemberReferences.cs:77
	            yield return reference;                                                                                                        // BuildMemberReferences.cs:78
	        }                                                                                                                                  // BuildMemberReferences.cs:79
	    }                                                                                                                                      // BuildMemberReferences.cs:80
	                                                                                                                                           // BuildMemberBase.cs:304
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	                                                                                                                                           // BuildMemberReferences.cs:46
	    public void Read(BreastRadiologyDocument doc, IEnumerable<ResourceReference> references)                                               // BuildMemberReferences.cs:47
	    {                                                                                                                                      // BuildMemberReferences.cs:48
	        IEnumerable<ResourceBase> resources = base.IsMember(doc,                                                                           // BuildMemberReferences.cs:49
	            references,                                                                                                                    // BuildMemberReferences.cs:50
	            this.targetUrls);                                                                                                              // BuildMemberReferences.cs:51
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberReferences.cs:52
	        foreach (ResourceBase resource in resources)                                                                                       // BuildMemberReferences.cs:53
	        {                                                                                                                                  // BuildMemberReferences.cs:54
	            Item item = new Item((MGAbnormalityDensity) resource);                                                                         // BuildMemberReferences.cs:55
	            items.Add(item);                                                                                                               // BuildMemberReferences.cs:56
	        }                                                                                                                                  // BuildMemberReferences.cs:57
	        this.SetAllItems(items);                                                                                                           // BuildMemberReferences.cs:58
	    }                                                                                                                                      // BuildMemberReferences.cs:59
	}                                                                                                                                          // BuildMemberBase.cs:158
	#endregion                                                                                                                                 // BuildMemberBase.cs:159
	#region Observation.hasMember:mGAbnormalityFatNecrosis Container Class                                                                     // BuildMemberBase.cs:137
	/// <summary>
	/// Container class for Observation.hasMember:mGAbnormalityFatNecrosis.
	/// </summary>
	public class MGAbnormalityFatNecrosisContainer : MContainer, ITMItem<ResourceReference>                                                    // BuildMemberBase.cs:141
	{                                                                                                                                          // BuildMemberBase.cs:142
	    #region Observation.hasMember:mGAbnormalityFatNecrosis Item Class                                                                      // BuildMemberBase.cs:73
	    /// <summary>
	    /// Item class for Observation.hasMember:mGAbnormalityFatNecrosis.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:77
	    {                                                                                                                                      // BuildMemberBase.cs:78
	        // Properties                                                                                                                      // BuildMemberBase.cs:79
	        /// <summary>
	        /// Value
	        /// </summary>
	        public MGAbnormalityFatNecrosis Value { get; set; }                                                                                // BuildMemberBase.cs:83
	                                                                                                                                           // BuildMemberBase.cs:85
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(MGAbnormalityFatNecrosis value)                                                                                        // BuildMemberBase.cs:89
	        {                                                                                                                                  // BuildMemberBase.cs:90
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:91
	        }                                                                                                                                  // BuildMemberBase.cs:93
	                                                                                                                                           // BuildMemberBase.cs:95
	        // Methods                                                                                                                         // BuildMemberBase.cs:96
	    }                                                                                                                                      // BuildMemberBase.cs:98
	    #endregion                                                                                                                             // BuildMemberBase.cs:99
	                                                                                                                                           // BuildMemberBase.cs:144
	    // Properties                                                                                                                          // BuildMemberBase.cs:145
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:118
	    {                                                                                                                                      // BuildMemberBase.cs:119
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityFatNecrosis"                                             // BuildMemberBase.cs:126
	    };                                                                                                                                     // BuildMemberBase.cs:127
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:232
	                                                                                                                                           // BuildMemberBase.cs:234
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:238
	                                                                                                                                           // BuildMemberBase.cs:240
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:244
	                                                                                                                                           // BuildMemberBase.cs:246
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:250
	                                                                                                                                           // BuildMemberBase.cs:252
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<MGAbnormalityFatNecrosis> All()                                                                                     // BuildMemberBase.cs:256
	    {                                                                                                                                      // BuildMemberBase.cs:257
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:258
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:259
	    }                                                                                                                                      // BuildMemberBase.cs:260
	                                                                                                                                           // BuildMemberBase.cs:262
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public MGAbnormalityFatNecrosis GetAt(Int32 i) => this.items[i].Value;                                                                 // BuildMemberBase.cs:266
	                                                                                                                                           // BuildMemberBase.cs:268
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:272
	                                                                                                                                           // BuildMemberBase.cs:274
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:278
	                                                                                                                                           // BuildMemberBase.cs:147
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public MGAbnormalityFatNecrosisContainer(Int32 min, Int32 max) : base("Observation.hasMember:mGAbnormalityFatNecrosis", min, max)      // BuildMemberBase.cs:151
	    {                                                                                                                                      // BuildMemberBase.cs:152
	    }                                                                                                                                      // BuildMemberBase.cs:154
	                                                                                                                                           // BuildMemberBase.cs:155
	    // Methods                                                                                                                             // BuildMemberBase.cs:156
	                                                                                                                                           // BuildMemberBase.cs:284
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public MGAbnormalityFatNecrosis Append(MGAbnormalityFatNecrosis value)                                                                 // BuildMemberBase.cs:288
	    {                                                                                                                                      // BuildMemberBase.cs:289
	        this.items.Add(new Item(value));                                                                                                   // BuildMemberBase.cs:290
	        return value;                                                                                                                      // BuildMemberBase.cs:291
	    }                                                                                                                                      // BuildMemberBase.cs:292
	                                                                                                                                           // BuildMemberBase.cs:298
	    /// <summary>
	    /// Write single item as a fhir element.
	    /// </summary>
	    public IEnumerable<ResourceReference> Write(BreastRadiologyDocument doc)                                                               // BuildMemberReferences.cs:70
	    {                                                                                                                                      // BuildMemberReferences.cs:71
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberReferences.cs:72
	        {                                                                                                                                  // BuildMemberReferences.cs:73
	            ResourceReference reference = new ResourceReference                                                                            // BuildMemberReferences.cs:74
	            {                                                                                                                              // BuildMemberReferences.cs:75
	                Reference = item.Value.Id                                                                                                  // BuildMemberReferences.cs:76
	            };                                                                                                                             // BuildMemberReferences.cs:77
	            yield return reference;                                                                                                        // BuildMemberReferences.cs:78
	        }                                                                                                                                  // BuildMemberReferences.cs:79
	    }                                                                                                                                      // BuildMemberReferences.cs:80
	                                                                                                                                           // BuildMemberBase.cs:304
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	                                                                                                                                           // BuildMemberReferences.cs:46
	    public void Read(BreastRadiologyDocument doc, IEnumerable<ResourceReference> references)                                               // BuildMemberReferences.cs:47
	    {                                                                                                                                      // BuildMemberReferences.cs:48
	        IEnumerable<ResourceBase> resources = base.IsMember(doc,                                                                           // BuildMemberReferences.cs:49
	            references,                                                                                                                    // BuildMemberReferences.cs:50
	            this.targetUrls);                                                                                                              // BuildMemberReferences.cs:51
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberReferences.cs:52
	        foreach (ResourceBase resource in resources)                                                                                       // BuildMemberReferences.cs:53
	        {                                                                                                                                  // BuildMemberReferences.cs:54
	            Item item = new Item((MGAbnormalityFatNecrosis) resource);                                                                     // BuildMemberReferences.cs:55
	            items.Add(item);                                                                                                               // BuildMemberReferences.cs:56
	        }                                                                                                                                  // BuildMemberReferences.cs:57
	        this.SetAllItems(items);                                                                                                           // BuildMemberReferences.cs:58
	    }                                                                                                                                      // BuildMemberReferences.cs:59
	}                                                                                                                                          // BuildMemberBase.cs:158
	#endregion                                                                                                                                 // BuildMemberBase.cs:159
	#region Observation.hasMember:mGBreastDensity Container Class                                                                              // BuildMemberBase.cs:137
	/// <summary>
	/// Container class for Observation.hasMember:mGBreastDensity.
	/// </summary>
	public class MGBreastDensityContainer : MContainer, ITMItem<ResourceReference>                                                             // BuildMemberBase.cs:141
	{                                                                                                                                          // BuildMemberBase.cs:142
	    #region Observation.hasMember:mGBreastDensity Item Class                                                                               // BuildMemberBase.cs:73
	    /// <summary>
	    /// Item class for Observation.hasMember:mGBreastDensity.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:77
	    {                                                                                                                                      // BuildMemberBase.cs:78
	        // Properties                                                                                                                      // BuildMemberBase.cs:79
	        /// <summary>
	        /// Value
	        /// </summary>
	        public MGBreastDensity Value { get; set; }                                                                                         // BuildMemberBase.cs:83
	                                                                                                                                           // BuildMemberBase.cs:85
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(MGBreastDensity value)                                                                                                 // BuildMemberBase.cs:89
	        {                                                                                                                                  // BuildMemberBase.cs:90
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:91
	        }                                                                                                                                  // BuildMemberBase.cs:93
	                                                                                                                                           // BuildMemberBase.cs:95
	        // Methods                                                                                                                         // BuildMemberBase.cs:96
	    }                                                                                                                                      // BuildMemberBase.cs:98
	    #endregion                                                                                                                             // BuildMemberBase.cs:99
	                                                                                                                                           // BuildMemberBase.cs:144
	    // Properties                                                                                                                          // BuildMemberBase.cs:145
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:118
	    {                                                                                                                                      // BuildMemberBase.cs:119
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGBreastDensity"                                                      // BuildMemberBase.cs:126
	    };                                                                                                                                     // BuildMemberBase.cs:127
	                                                                                                                                           // BuildMemberBase.cs:167
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems()                                                                                                        // BuildMemberBase.cs:171
	    {                                                                                                                                      // BuildMemberBase.cs:172
	        if (this.item != null) yield return this.item;                                                                                     // BuildMemberBase.cs:173
	    }                                                                                                                                      // BuildMemberBase.cs:174
	                                                                                                                                           // BuildMemberBase.cs:176
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items)                                                                                              // BuildMemberBase.cs:180
	    {                                                                                                                                      // BuildMemberBase.cs:181
	        switch (items.Count())                                                                                                             // BuildMemberBase.cs:182
	        {                                                                                                                                  // BuildMemberBase.cs:183
	            case 0: break;                                                                                                                 // BuildMemberBase.cs:184
	            case 1: this.item = items.First(); break;                                                                                      // BuildMemberBase.cs:185
	            default: throw new Exception("Found multiple elements while reading single item");                                             // BuildMemberBase.cs:186
	        }                                                                                                                                  // BuildMemberBase.cs:187
	    }                                                                                                                                      // BuildMemberBase.cs:188
	                                                                                                                                           // BuildMemberBase.cs:190
	    /// <summary>
	    /// Item
	    /// </summary>
	    Item item;                                                                                                                             // BuildMemberBase.cs:194
	                                                                                                                                           // BuildMemberBase.cs:196
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => this.item == null ? 0 : 1;                                                                              // BuildMemberBase.cs:200
	                                                                                                                                           // BuildMemberBase.cs:202
	    /// <summary>
	    /// Get Item's Value
	    /// </summary>
	    public MGBreastDensity Get()                                                                                                           // BuildMemberBase.cs:206
	    {                                                                                                                                      // BuildMemberBase.cs:207
	        if (item == null)                                                                                                                  // BuildMemberBase.cs:208
	            return null;                                                                                                                   // BuildMemberBase.cs:209
	        return item.Value;                                                                                                                 // BuildMemberBase.cs:210
	    }                                                                                                                                      // BuildMemberBase.cs:211
	                                                                                                                                           // BuildMemberBase.cs:217
	    /// <summary>
	    /// Set Item's Value
	    /// </summary>
	    public MGBreastDensity Set(MGBreastDensity value)                                                                                      // BuildMemberBase.cs:221
	    {                                                                                                                                      // BuildMemberBase.cs:222
	        this.item = new Item(value);                                                                                                       // BuildMemberBase.cs:223
	        return value;                                                                                                                      // BuildMemberBase.cs:224
	    }                                                                                                                                      // BuildMemberBase.cs:225
	                                                                                                                                           // BuildMemberBase.cs:147
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public MGBreastDensityContainer(Int32 min, Int32 max) : base("Observation.hasMember:mGBreastDensity", min, max)                        // BuildMemberBase.cs:151
	    {                                                                                                                                      // BuildMemberBase.cs:152
	    }                                                                                                                                      // BuildMemberBase.cs:154
	                                                                                                                                           // BuildMemberBase.cs:155
	    // Methods                                                                                                                             // BuildMemberBase.cs:156
	                                                                                                                                           // BuildMemberBase.cs:298
	    /// <summary>
	    /// Write single item as a fhir element.
	    /// </summary>
	    public IEnumerable<ResourceReference> Write(BreastRadiologyDocument doc)                                                               // BuildMemberReferences.cs:70
	    {                                                                                                                                      // BuildMemberReferences.cs:71
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberReferences.cs:72
	        {                                                                                                                                  // BuildMemberReferences.cs:73
	            ResourceReference reference = new ResourceReference                                                                            // BuildMemberReferences.cs:74
	            {                                                                                                                              // BuildMemberReferences.cs:75
	                Reference = item.Value.Id                                                                                                  // BuildMemberReferences.cs:76
	            };                                                                                                                             // BuildMemberReferences.cs:77
	            yield return reference;                                                                                                        // BuildMemberReferences.cs:78
	        }                                                                                                                                  // BuildMemberReferences.cs:79
	    }                                                                                                                                      // BuildMemberReferences.cs:80
	                                                                                                                                           // BuildMemberBase.cs:304
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	                                                                                                                                           // BuildMemberReferences.cs:46
	    public void Read(BreastRadiologyDocument doc, IEnumerable<ResourceReference> references)                                               // BuildMemberReferences.cs:47
	    {                                                                                                                                      // BuildMemberReferences.cs:48
	        IEnumerable<ResourceBase> resources = base.IsMember(doc,                                                                           // BuildMemberReferences.cs:49
	            references,                                                                                                                    // BuildMemberReferences.cs:50
	            this.targetUrls);                                                                                                              // BuildMemberReferences.cs:51
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberReferences.cs:52
	        foreach (ResourceBase resource in resources)                                                                                       // BuildMemberReferences.cs:53
	        {                                                                                                                                  // BuildMemberReferences.cs:54
	            Item item = new Item((MGBreastDensity) resource);                                                                              // BuildMemberReferences.cs:55
	            items.Add(item);                                                                                                               // BuildMemberReferences.cs:56
	        }                                                                                                                                  // BuildMemberReferences.cs:57
	        this.SetAllItems(items);                                                                                                           // BuildMemberReferences.cs:58
	    }                                                                                                                                      // BuildMemberReferences.cs:59
	}                                                                                                                                          // BuildMemberBase.cs:158
	#endregion                                                                                                                                 // BuildMemberBase.cs:159
	//- LocalClassDefs
}
