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
	/// <summary>
	/// Container class for Observation.hasMember:abnormalityCyst.
	/// </summary>
	public class AbnormalityCystContainer : MContainer, ITMItem<ResourceReference>                                                             // BuildMemberBase.cs:131
	{                                                                                                                                          // BuildMemberBase.cs:132
	    /// <summary>
	    /// Item class for Observation.hasMember:abnormalityCyst.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:63
	    {                                                                                                                                      // BuildMemberBase.cs:64
	        // Properties                                                                                                                      // BuildMemberBase.cs:65
	        /// <summary>
	        /// Value
	        /// </summary>
	        public AbnormalityCyst Value { get; set; }                                                                                         // BuildMemberBase.cs:69
	                                                                                                                                           // BuildMemberBase.cs:71
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(AbnormalityCyst value)                                                                                                 // BuildMemberBase.cs:75
	        {                                                                                                                                  // BuildMemberBase.cs:76
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:77
	        }                                                                                                                                  // BuildMemberBase.cs:79
	                                                                                                                                           // BuildMemberBase.cs:81
	        // Methods                                                                                                                         // BuildMemberBase.cs:82
	    }                                                                                                                                      // BuildMemberBase.cs:84
	                                                                                                                                           // BuildMemberBase.cs:134
	    // Properties                                                                                                                          // BuildMemberBase.cs:135
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:109
	    {                                                                                                                                      // BuildMemberBase.cs:110
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityCyst"                                                      // BuildMemberBase.cs:117
	    };                                                                                                                                     // BuildMemberBase.cs:118
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:223
	                                                                                                                                           // BuildMemberBase.cs:225
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:229
	                                                                                                                                           // BuildMemberBase.cs:231
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:235
	                                                                                                                                           // BuildMemberBase.cs:237
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:241
	                                                                                                                                           // BuildMemberBase.cs:243
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<AbnormalityCyst> All()                                                                                              // BuildMemberBase.cs:247
	    {                                                                                                                                      // BuildMemberBase.cs:248
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:249
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:250
	    }                                                                                                                                      // BuildMemberBase.cs:251
	                                                                                                                                           // BuildMemberBase.cs:253
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public AbnormalityCyst GetAt(Int32 i) => this.items[i].Value;                                                                          // BuildMemberBase.cs:257
	                                                                                                                                           // BuildMemberBase.cs:259
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:263
	                                                                                                                                           // BuildMemberBase.cs:265
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:269
	                                                                                                                                           // BuildMemberBase.cs:137
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public AbnormalityCystContainer(Int32 min, Int32 max) : base("Observation.hasMember:abnormalityCyst", min, max)                        // BuildMemberBase.cs:141
	    {                                                                                                                                      // BuildMemberBase.cs:142
	    }                                                                                                                                      // BuildMemberBase.cs:144
	                                                                                                                                           // BuildMemberBase.cs:145
	    // Methods                                                                                                                             // BuildMemberBase.cs:146
	                                                                                                                                           // BuildMemberBase.cs:275
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public AbnormalityCyst Append(AbnormalityCyst value)                                                                                   // BuildMemberBase.cs:279
	    {                                                                                                                                      // BuildMemberBase.cs:280
	        this.items.Add(new Item(value));                                                                                                   // BuildMemberBase.cs:281
	        return value;                                                                                                                      // BuildMemberBase.cs:282
	    }                                                                                                                                      // BuildMemberBase.cs:283
	                                                                                                                                           // BuildMemberBase.cs:289
	    /// <summary>
	    /// Write single item as a fhir element.
	    /// </summary>
	    public IEnumerable<ResourceReference> Write(BreastRadiologyDocument doc)                                                               // BuildMemberReferences.cs:74
	    {                                                                                                                                      // BuildMemberReferences.cs:75
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberReferences.cs:76
	        {                                                                                                                                  // BuildMemberReferences.cs:77
	            ResourceReference reference = new ResourceReference                                                                            // BuildMemberReferences.cs:78
	            {                                                                                                                              // BuildMemberReferences.cs:79
	                Reference = item.Value.Id                                                                                                  // BuildMemberReferences.cs:80
	            };                                                                                                                             // BuildMemberReferences.cs:81
	            yield return reference;                                                                                                        // BuildMemberReferences.cs:82
	        }                                                                                                                                  // BuildMemberReferences.cs:83
	    }                                                                                                                                      // BuildMemberReferences.cs:84
	                                                                                                                                           // BuildMemberBase.cs:295
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	                                                                                                                                           // BuildMemberReferences.cs:50
	    public void Read(BreastRadiologyDocument doc, IEnumerable<ResourceReference> references)                                               // BuildMemberReferences.cs:51
	    {                                                                                                                                      // BuildMemberReferences.cs:52
	        IEnumerable<ResourceBase> resources = base.IsMember(doc,                                                                           // BuildMemberReferences.cs:53
	            references,                                                                                                                    // BuildMemberReferences.cs:54
	            this.targetUrls);                                                                                                              // BuildMemberReferences.cs:55
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberReferences.cs:56
	        foreach (ResourceBase resource in resources)                                                                                       // BuildMemberReferences.cs:57
	        {                                                                                                                                  // BuildMemberReferences.cs:58
	            Item item = new Item((AbnormalityCyst) resource);                                                                              // BuildMemberReferences.cs:59
	            items.Add(item);                                                                                                               // BuildMemberReferences.cs:60
	        }                                                                                                                                  // BuildMemberReferences.cs:61
	        this.SetAllItems(items);                                                                                                           // BuildMemberReferences.cs:62
	    }                                                                                                                                      // BuildMemberReferences.cs:63
	}                                                                                                                                          // BuildMemberBase.cs:148
	/// <summary>
	/// Container class for Observation.hasMember:abnormalityDuct.
	/// </summary>
	public class AbnormalityDuctContainer : MContainer, ITMItem<ResourceReference>                                                             // BuildMemberBase.cs:131
	{                                                                                                                                          // BuildMemberBase.cs:132
	    /// <summary>
	    /// Item class for Observation.hasMember:abnormalityDuct.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:63
	    {                                                                                                                                      // BuildMemberBase.cs:64
	        // Properties                                                                                                                      // BuildMemberBase.cs:65
	        /// <summary>
	        /// Value
	        /// </summary>
	        public AbnormalityDuct Value { get; set; }                                                                                         // BuildMemberBase.cs:69
	                                                                                                                                           // BuildMemberBase.cs:71
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(AbnormalityDuct value)                                                                                                 // BuildMemberBase.cs:75
	        {                                                                                                                                  // BuildMemberBase.cs:76
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:77
	        }                                                                                                                                  // BuildMemberBase.cs:79
	                                                                                                                                           // BuildMemberBase.cs:81
	        // Methods                                                                                                                         // BuildMemberBase.cs:82
	    }                                                                                                                                      // BuildMemberBase.cs:84
	                                                                                                                                           // BuildMemberBase.cs:134
	    // Properties                                                                                                                          // BuildMemberBase.cs:135
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:109
	    {                                                                                                                                      // BuildMemberBase.cs:110
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityDuct"                                                      // BuildMemberBase.cs:117
	    };                                                                                                                                     // BuildMemberBase.cs:118
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:223
	                                                                                                                                           // BuildMemberBase.cs:225
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:229
	                                                                                                                                           // BuildMemberBase.cs:231
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:235
	                                                                                                                                           // BuildMemberBase.cs:237
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:241
	                                                                                                                                           // BuildMemberBase.cs:243
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<AbnormalityDuct> All()                                                                                              // BuildMemberBase.cs:247
	    {                                                                                                                                      // BuildMemberBase.cs:248
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:249
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:250
	    }                                                                                                                                      // BuildMemberBase.cs:251
	                                                                                                                                           // BuildMemberBase.cs:253
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public AbnormalityDuct GetAt(Int32 i) => this.items[i].Value;                                                                          // BuildMemberBase.cs:257
	                                                                                                                                           // BuildMemberBase.cs:259
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:263
	                                                                                                                                           // BuildMemberBase.cs:265
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:269
	                                                                                                                                           // BuildMemberBase.cs:137
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public AbnormalityDuctContainer(Int32 min, Int32 max) : base("Observation.hasMember:abnormalityDuct", min, max)                        // BuildMemberBase.cs:141
	    {                                                                                                                                      // BuildMemberBase.cs:142
	    }                                                                                                                                      // BuildMemberBase.cs:144
	                                                                                                                                           // BuildMemberBase.cs:145
	    // Methods                                                                                                                             // BuildMemberBase.cs:146
	                                                                                                                                           // BuildMemberBase.cs:275
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public AbnormalityDuct Append(AbnormalityDuct value)                                                                                   // BuildMemberBase.cs:279
	    {                                                                                                                                      // BuildMemberBase.cs:280
	        this.items.Add(new Item(value));                                                                                                   // BuildMemberBase.cs:281
	        return value;                                                                                                                      // BuildMemberBase.cs:282
	    }                                                                                                                                      // BuildMemberBase.cs:283
	                                                                                                                                           // BuildMemberBase.cs:289
	    /// <summary>
	    /// Write single item as a fhir element.
	    /// </summary>
	    public IEnumerable<ResourceReference> Write(BreastRadiologyDocument doc)                                                               // BuildMemberReferences.cs:74
	    {                                                                                                                                      // BuildMemberReferences.cs:75
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberReferences.cs:76
	        {                                                                                                                                  // BuildMemberReferences.cs:77
	            ResourceReference reference = new ResourceReference                                                                            // BuildMemberReferences.cs:78
	            {                                                                                                                              // BuildMemberReferences.cs:79
	                Reference = item.Value.Id                                                                                                  // BuildMemberReferences.cs:80
	            };                                                                                                                             // BuildMemberReferences.cs:81
	            yield return reference;                                                                                                        // BuildMemberReferences.cs:82
	        }                                                                                                                                  // BuildMemberReferences.cs:83
	    }                                                                                                                                      // BuildMemberReferences.cs:84
	                                                                                                                                           // BuildMemberBase.cs:295
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	                                                                                                                                           // BuildMemberReferences.cs:50
	    public void Read(BreastRadiologyDocument doc, IEnumerable<ResourceReference> references)                                               // BuildMemberReferences.cs:51
	    {                                                                                                                                      // BuildMemberReferences.cs:52
	        IEnumerable<ResourceBase> resources = base.IsMember(doc,                                                                           // BuildMemberReferences.cs:53
	            references,                                                                                                                    // BuildMemberReferences.cs:54
	            this.targetUrls);                                                                                                              // BuildMemberReferences.cs:55
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberReferences.cs:56
	        foreach (ResourceBase resource in resources)                                                                                       // BuildMemberReferences.cs:57
	        {                                                                                                                                  // BuildMemberReferences.cs:58
	            Item item = new Item((AbnormalityDuct) resource);                                                                              // BuildMemberReferences.cs:59
	            items.Add(item);                                                                                                               // BuildMemberReferences.cs:60
	        }                                                                                                                                  // BuildMemberReferences.cs:61
	        this.SetAllItems(items);                                                                                                           // BuildMemberReferences.cs:62
	    }                                                                                                                                      // BuildMemberReferences.cs:63
	}                                                                                                                                          // BuildMemberBase.cs:148
	/// <summary>
	/// Container class for Observation.hasMember:abnormalityForeignObject.
	/// </summary>
	public class AbnormalityForeignObjectContainer : MContainer, ITMItem<ResourceReference>                                                    // BuildMemberBase.cs:131
	{                                                                                                                                          // BuildMemberBase.cs:132
	    /// <summary>
	    /// Item class for Observation.hasMember:abnormalityForeignObject.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:63
	    {                                                                                                                                      // BuildMemberBase.cs:64
	        // Properties                                                                                                                      // BuildMemberBase.cs:65
	        /// <summary>
	        /// Value
	        /// </summary>
	        public AbnormalityForeignObject Value { get; set; }                                                                                // BuildMemberBase.cs:69
	                                                                                                                                           // BuildMemberBase.cs:71
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(AbnormalityForeignObject value)                                                                                        // BuildMemberBase.cs:75
	        {                                                                                                                                  // BuildMemberBase.cs:76
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:77
	        }                                                                                                                                  // BuildMemberBase.cs:79
	                                                                                                                                           // BuildMemberBase.cs:81
	        // Methods                                                                                                                         // BuildMemberBase.cs:82
	    }                                                                                                                                      // BuildMemberBase.cs:84
	                                                                                                                                           // BuildMemberBase.cs:134
	    // Properties                                                                                                                          // BuildMemberBase.cs:135
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:109
	    {                                                                                                                                      // BuildMemberBase.cs:110
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityForeignObject"                                             // BuildMemberBase.cs:117
	    };                                                                                                                                     // BuildMemberBase.cs:118
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:223
	                                                                                                                                           // BuildMemberBase.cs:225
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:229
	                                                                                                                                           // BuildMemberBase.cs:231
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:235
	                                                                                                                                           // BuildMemberBase.cs:237
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:241
	                                                                                                                                           // BuildMemberBase.cs:243
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<AbnormalityForeignObject> All()                                                                                     // BuildMemberBase.cs:247
	    {                                                                                                                                      // BuildMemberBase.cs:248
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:249
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:250
	    }                                                                                                                                      // BuildMemberBase.cs:251
	                                                                                                                                           // BuildMemberBase.cs:253
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public AbnormalityForeignObject GetAt(Int32 i) => this.items[i].Value;                                                                 // BuildMemberBase.cs:257
	                                                                                                                                           // BuildMemberBase.cs:259
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:263
	                                                                                                                                           // BuildMemberBase.cs:265
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:269
	                                                                                                                                           // BuildMemberBase.cs:137
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public AbnormalityForeignObjectContainer(Int32 min, Int32 max) : base("Observation.hasMember:abnormalityForeignObject", min, max)      // BuildMemberBase.cs:141
	    {                                                                                                                                      // BuildMemberBase.cs:142
	    }                                                                                                                                      // BuildMemberBase.cs:144
	                                                                                                                                           // BuildMemberBase.cs:145
	    // Methods                                                                                                                             // BuildMemberBase.cs:146
	                                                                                                                                           // BuildMemberBase.cs:275
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public AbnormalityForeignObject Append(AbnormalityForeignObject value)                                                                 // BuildMemberBase.cs:279
	    {                                                                                                                                      // BuildMemberBase.cs:280
	        this.items.Add(new Item(value));                                                                                                   // BuildMemberBase.cs:281
	        return value;                                                                                                                      // BuildMemberBase.cs:282
	    }                                                                                                                                      // BuildMemberBase.cs:283
	                                                                                                                                           // BuildMemberBase.cs:289
	    /// <summary>
	    /// Write single item as a fhir element.
	    /// </summary>
	    public IEnumerable<ResourceReference> Write(BreastRadiologyDocument doc)                                                               // BuildMemberReferences.cs:74
	    {                                                                                                                                      // BuildMemberReferences.cs:75
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberReferences.cs:76
	        {                                                                                                                                  // BuildMemberReferences.cs:77
	            ResourceReference reference = new ResourceReference                                                                            // BuildMemberReferences.cs:78
	            {                                                                                                                              // BuildMemberReferences.cs:79
	                Reference = item.Value.Id                                                                                                  // BuildMemberReferences.cs:80
	            };                                                                                                                             // BuildMemberReferences.cs:81
	            yield return reference;                                                                                                        // BuildMemberReferences.cs:82
	        }                                                                                                                                  // BuildMemberReferences.cs:83
	    }                                                                                                                                      // BuildMemberReferences.cs:84
	                                                                                                                                           // BuildMemberBase.cs:295
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	                                                                                                                                           // BuildMemberReferences.cs:50
	    public void Read(BreastRadiologyDocument doc, IEnumerable<ResourceReference> references)                                               // BuildMemberReferences.cs:51
	    {                                                                                                                                      // BuildMemberReferences.cs:52
	        IEnumerable<ResourceBase> resources = base.IsMember(doc,                                                                           // BuildMemberReferences.cs:53
	            references,                                                                                                                    // BuildMemberReferences.cs:54
	            this.targetUrls);                                                                                                              // BuildMemberReferences.cs:55
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberReferences.cs:56
	        foreach (ResourceBase resource in resources)                                                                                       // BuildMemberReferences.cs:57
	        {                                                                                                                                  // BuildMemberReferences.cs:58
	            Item item = new Item((AbnormalityForeignObject) resource);                                                                     // BuildMemberReferences.cs:59
	            items.Add(item);                                                                                                               // BuildMemberReferences.cs:60
	        }                                                                                                                                  // BuildMemberReferences.cs:61
	        this.SetAllItems(items);                                                                                                           // BuildMemberReferences.cs:62
	    }                                                                                                                                      // BuildMemberReferences.cs:63
	}                                                                                                                                          // BuildMemberBase.cs:148
	/// <summary>
	/// Container class for Observation.hasMember:abnormalityLymphNode.
	/// </summary>
	public class AbnormalityLymphNodeContainer : MContainer, ITMItem<ResourceReference>                                                        // BuildMemberBase.cs:131
	{                                                                                                                                          // BuildMemberBase.cs:132
	    /// <summary>
	    /// Item class for Observation.hasMember:abnormalityLymphNode.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:63
	    {                                                                                                                                      // BuildMemberBase.cs:64
	        // Properties                                                                                                                      // BuildMemberBase.cs:65
	        /// <summary>
	        /// Value
	        /// </summary>
	        public AbnormalityLymphNode Value { get; set; }                                                                                    // BuildMemberBase.cs:69
	                                                                                                                                           // BuildMemberBase.cs:71
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(AbnormalityLymphNode value)                                                                                            // BuildMemberBase.cs:75
	        {                                                                                                                                  // BuildMemberBase.cs:76
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:77
	        }                                                                                                                                  // BuildMemberBase.cs:79
	                                                                                                                                           // BuildMemberBase.cs:81
	        // Methods                                                                                                                         // BuildMemberBase.cs:82
	    }                                                                                                                                      // BuildMemberBase.cs:84
	                                                                                                                                           // BuildMemberBase.cs:134
	    // Properties                                                                                                                          // BuildMemberBase.cs:135
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:109
	    {                                                                                                                                      // BuildMemberBase.cs:110
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityLymphNode"                                                 // BuildMemberBase.cs:117
	    };                                                                                                                                     // BuildMemberBase.cs:118
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:223
	                                                                                                                                           // BuildMemberBase.cs:225
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:229
	                                                                                                                                           // BuildMemberBase.cs:231
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:235
	                                                                                                                                           // BuildMemberBase.cs:237
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:241
	                                                                                                                                           // BuildMemberBase.cs:243
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<AbnormalityLymphNode> All()                                                                                         // BuildMemberBase.cs:247
	    {                                                                                                                                      // BuildMemberBase.cs:248
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:249
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:250
	    }                                                                                                                                      // BuildMemberBase.cs:251
	                                                                                                                                           // BuildMemberBase.cs:253
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public AbnormalityLymphNode GetAt(Int32 i) => this.items[i].Value;                                                                     // BuildMemberBase.cs:257
	                                                                                                                                           // BuildMemberBase.cs:259
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:263
	                                                                                                                                           // BuildMemberBase.cs:265
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:269
	                                                                                                                                           // BuildMemberBase.cs:137
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public AbnormalityLymphNodeContainer(Int32 min, Int32 max) : base("Observation.hasMember:abnormalityLymphNode", min, max)              // BuildMemberBase.cs:141
	    {                                                                                                                                      // BuildMemberBase.cs:142
	    }                                                                                                                                      // BuildMemberBase.cs:144
	                                                                                                                                           // BuildMemberBase.cs:145
	    // Methods                                                                                                                             // BuildMemberBase.cs:146
	                                                                                                                                           // BuildMemberBase.cs:275
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public AbnormalityLymphNode Append(AbnormalityLymphNode value)                                                                         // BuildMemberBase.cs:279
	    {                                                                                                                                      // BuildMemberBase.cs:280
	        this.items.Add(new Item(value));                                                                                                   // BuildMemberBase.cs:281
	        return value;                                                                                                                      // BuildMemberBase.cs:282
	    }                                                                                                                                      // BuildMemberBase.cs:283
	                                                                                                                                           // BuildMemberBase.cs:289
	    /// <summary>
	    /// Write single item as a fhir element.
	    /// </summary>
	    public IEnumerable<ResourceReference> Write(BreastRadiologyDocument doc)                                                               // BuildMemberReferences.cs:74
	    {                                                                                                                                      // BuildMemberReferences.cs:75
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberReferences.cs:76
	        {                                                                                                                                  // BuildMemberReferences.cs:77
	            ResourceReference reference = new ResourceReference                                                                            // BuildMemberReferences.cs:78
	            {                                                                                                                              // BuildMemberReferences.cs:79
	                Reference = item.Value.Id                                                                                                  // BuildMemberReferences.cs:80
	            };                                                                                                                             // BuildMemberReferences.cs:81
	            yield return reference;                                                                                                        // BuildMemberReferences.cs:82
	        }                                                                                                                                  // BuildMemberReferences.cs:83
	    }                                                                                                                                      // BuildMemberReferences.cs:84
	                                                                                                                                           // BuildMemberBase.cs:295
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	                                                                                                                                           // BuildMemberReferences.cs:50
	    public void Read(BreastRadiologyDocument doc, IEnumerable<ResourceReference> references)                                               // BuildMemberReferences.cs:51
	    {                                                                                                                                      // BuildMemberReferences.cs:52
	        IEnumerable<ResourceBase> resources = base.IsMember(doc,                                                                           // BuildMemberReferences.cs:53
	            references,                                                                                                                    // BuildMemberReferences.cs:54
	            this.targetUrls);                                                                                                              // BuildMemberReferences.cs:55
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberReferences.cs:56
	        foreach (ResourceBase resource in resources)                                                                                       // BuildMemberReferences.cs:57
	        {                                                                                                                                  // BuildMemberReferences.cs:58
	            Item item = new Item((AbnormalityLymphNode) resource);                                                                         // BuildMemberReferences.cs:59
	            items.Add(item);                                                                                                               // BuildMemberReferences.cs:60
	        }                                                                                                                                  // BuildMemberReferences.cs:61
	        this.SetAllItems(items);                                                                                                           // BuildMemberReferences.cs:62
	    }                                                                                                                                      // BuildMemberReferences.cs:63
	}                                                                                                                                          // BuildMemberBase.cs:148
	/// <summary>
	/// Container class for Observation.hasMember:abnormalityMass.
	/// </summary>
	public class AbnormalityMassContainer : MContainer, ITMItem<ResourceReference>                                                             // BuildMemberBase.cs:131
	{                                                                                                                                          // BuildMemberBase.cs:132
	    /// <summary>
	    /// Item class for Observation.hasMember:abnormalityMass.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:63
	    {                                                                                                                                      // BuildMemberBase.cs:64
	        // Properties                                                                                                                      // BuildMemberBase.cs:65
	        /// <summary>
	        /// Value
	        /// </summary>
	        public AbnormalityMass Value { get; set; }                                                                                         // BuildMemberBase.cs:69
	                                                                                                                                           // BuildMemberBase.cs:71
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(AbnormalityMass value)                                                                                                 // BuildMemberBase.cs:75
	        {                                                                                                                                  // BuildMemberBase.cs:76
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:77
	        }                                                                                                                                  // BuildMemberBase.cs:79
	                                                                                                                                           // BuildMemberBase.cs:81
	        // Methods                                                                                                                         // BuildMemberBase.cs:82
	    }                                                                                                                                      // BuildMemberBase.cs:84
	                                                                                                                                           // BuildMemberBase.cs:134
	    // Properties                                                                                                                          // BuildMemberBase.cs:135
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:109
	    {                                                                                                                                      // BuildMemberBase.cs:110
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityMass"                                                      // BuildMemberBase.cs:117
	    };                                                                                                                                     // BuildMemberBase.cs:118
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:223
	                                                                                                                                           // BuildMemberBase.cs:225
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:229
	                                                                                                                                           // BuildMemberBase.cs:231
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:235
	                                                                                                                                           // BuildMemberBase.cs:237
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:241
	                                                                                                                                           // BuildMemberBase.cs:243
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<AbnormalityMass> All()                                                                                              // BuildMemberBase.cs:247
	    {                                                                                                                                      // BuildMemberBase.cs:248
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:249
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:250
	    }                                                                                                                                      // BuildMemberBase.cs:251
	                                                                                                                                           // BuildMemberBase.cs:253
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public AbnormalityMass GetAt(Int32 i) => this.items[i].Value;                                                                          // BuildMemberBase.cs:257
	                                                                                                                                           // BuildMemberBase.cs:259
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:263
	                                                                                                                                           // BuildMemberBase.cs:265
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:269
	                                                                                                                                           // BuildMemberBase.cs:137
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public AbnormalityMassContainer(Int32 min, Int32 max) : base("Observation.hasMember:abnormalityMass", min, max)                        // BuildMemberBase.cs:141
	    {                                                                                                                                      // BuildMemberBase.cs:142
	    }                                                                                                                                      // BuildMemberBase.cs:144
	                                                                                                                                           // BuildMemberBase.cs:145
	    // Methods                                                                                                                             // BuildMemberBase.cs:146
	                                                                                                                                           // BuildMemberBase.cs:275
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public AbnormalityMass Append(AbnormalityMass value)                                                                                   // BuildMemberBase.cs:279
	    {                                                                                                                                      // BuildMemberBase.cs:280
	        this.items.Add(new Item(value));                                                                                                   // BuildMemberBase.cs:281
	        return value;                                                                                                                      // BuildMemberBase.cs:282
	    }                                                                                                                                      // BuildMemberBase.cs:283
	                                                                                                                                           // BuildMemberBase.cs:289
	    /// <summary>
	    /// Write single item as a fhir element.
	    /// </summary>
	    public IEnumerable<ResourceReference> Write(BreastRadiologyDocument doc)                                                               // BuildMemberReferences.cs:74
	    {                                                                                                                                      // BuildMemberReferences.cs:75
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberReferences.cs:76
	        {                                                                                                                                  // BuildMemberReferences.cs:77
	            ResourceReference reference = new ResourceReference                                                                            // BuildMemberReferences.cs:78
	            {                                                                                                                              // BuildMemberReferences.cs:79
	                Reference = item.Value.Id                                                                                                  // BuildMemberReferences.cs:80
	            };                                                                                                                             // BuildMemberReferences.cs:81
	            yield return reference;                                                                                                        // BuildMemberReferences.cs:82
	        }                                                                                                                                  // BuildMemberReferences.cs:83
	    }                                                                                                                                      // BuildMemberReferences.cs:84
	                                                                                                                                           // BuildMemberBase.cs:295
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	                                                                                                                                           // BuildMemberReferences.cs:50
	    public void Read(BreastRadiologyDocument doc, IEnumerable<ResourceReference> references)                                               // BuildMemberReferences.cs:51
	    {                                                                                                                                      // BuildMemberReferences.cs:52
	        IEnumerable<ResourceBase> resources = base.IsMember(doc,                                                                           // BuildMemberReferences.cs:53
	            references,                                                                                                                    // BuildMemberReferences.cs:54
	            this.targetUrls);                                                                                                              // BuildMemberReferences.cs:55
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberReferences.cs:56
	        foreach (ResourceBase resource in resources)                                                                                       // BuildMemberReferences.cs:57
	        {                                                                                                                                  // BuildMemberReferences.cs:58
	            Item item = new Item((AbnormalityMass) resource);                                                                              // BuildMemberReferences.cs:59
	            items.Add(item);                                                                                                               // BuildMemberReferences.cs:60
	        }                                                                                                                                  // BuildMemberReferences.cs:61
	        this.SetAllItems(items);                                                                                                           // BuildMemberReferences.cs:62
	    }                                                                                                                                      // BuildMemberReferences.cs:63
	}                                                                                                                                          // BuildMemberBase.cs:148
	/// <summary>
	/// Container class for Observation.hasMember:associatedFeature.
	/// </summary>
	public class AssociatedFeatureContainer : MContainer, ITMItem<ResourceReference>                                                           // BuildMemberBase.cs:131
	{                                                                                                                                          // BuildMemberBase.cs:132
	    /// <summary>
	    /// Item class for Observation.hasMember:associatedFeature.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:63
	    {                                                                                                                                      // BuildMemberBase.cs:64
	        // Properties                                                                                                                      // BuildMemberBase.cs:65
	        /// <summary>
	        /// Value
	        /// </summary>
	        public AssociatedFeature Value { get; set; }                                                                                       // BuildMemberBase.cs:69
	                                                                                                                                           // BuildMemberBase.cs:71
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(AssociatedFeature value)                                                                                               // BuildMemberBase.cs:75
	        {                                                                                                                                  // BuildMemberBase.cs:76
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:77
	        }                                                                                                                                  // BuildMemberBase.cs:79
	                                                                                                                                           // BuildMemberBase.cs:81
	        // Methods                                                                                                                         // BuildMemberBase.cs:82
	    }                                                                                                                                      // BuildMemberBase.cs:84
	                                                                                                                                           // BuildMemberBase.cs:134
	    // Properties                                                                                                                          // BuildMemberBase.cs:135
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:109
	    {                                                                                                                                      // BuildMemberBase.cs:110
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AssociatedFeature"                                                    // BuildMemberBase.cs:117
	    };                                                                                                                                     // BuildMemberBase.cs:118
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:223
	                                                                                                                                           // BuildMemberBase.cs:225
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:229
	                                                                                                                                           // BuildMemberBase.cs:231
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:235
	                                                                                                                                           // BuildMemberBase.cs:237
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:241
	                                                                                                                                           // BuildMemberBase.cs:243
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<AssociatedFeature> All()                                                                                            // BuildMemberBase.cs:247
	    {                                                                                                                                      // BuildMemberBase.cs:248
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:249
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:250
	    }                                                                                                                                      // BuildMemberBase.cs:251
	                                                                                                                                           // BuildMemberBase.cs:253
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public AssociatedFeature GetAt(Int32 i) => this.items[i].Value;                                                                        // BuildMemberBase.cs:257
	                                                                                                                                           // BuildMemberBase.cs:259
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:263
	                                                                                                                                           // BuildMemberBase.cs:265
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:269
	                                                                                                                                           // BuildMemberBase.cs:137
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public AssociatedFeatureContainer(Int32 min, Int32 max) : base("Observation.hasMember:associatedFeature", min, max)                    // BuildMemberBase.cs:141
	    {                                                                                                                                      // BuildMemberBase.cs:142
	    }                                                                                                                                      // BuildMemberBase.cs:144
	                                                                                                                                           // BuildMemberBase.cs:145
	    // Methods                                                                                                                             // BuildMemberBase.cs:146
	                                                                                                                                           // BuildMemberBase.cs:275
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public AssociatedFeature Append(AssociatedFeature value)                                                                               // BuildMemberBase.cs:279
	    {                                                                                                                                      // BuildMemberBase.cs:280
	        this.items.Add(new Item(value));                                                                                                   // BuildMemberBase.cs:281
	        return value;                                                                                                                      // BuildMemberBase.cs:282
	    }                                                                                                                                      // BuildMemberBase.cs:283
	                                                                                                                                           // BuildMemberBase.cs:289
	    /// <summary>
	    /// Write single item as a fhir element.
	    /// </summary>
	    public IEnumerable<ResourceReference> Write(BreastRadiologyDocument doc)                                                               // BuildMemberReferences.cs:74
	    {                                                                                                                                      // BuildMemberReferences.cs:75
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberReferences.cs:76
	        {                                                                                                                                  // BuildMemberReferences.cs:77
	            ResourceReference reference = new ResourceReference                                                                            // BuildMemberReferences.cs:78
	            {                                                                                                                              // BuildMemberReferences.cs:79
	                Reference = item.Value.Id                                                                                                  // BuildMemberReferences.cs:80
	            };                                                                                                                             // BuildMemberReferences.cs:81
	            yield return reference;                                                                                                        // BuildMemberReferences.cs:82
	        }                                                                                                                                  // BuildMemberReferences.cs:83
	    }                                                                                                                                      // BuildMemberReferences.cs:84
	                                                                                                                                           // BuildMemberBase.cs:295
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	                                                                                                                                           // BuildMemberReferences.cs:50
	    public void Read(BreastRadiologyDocument doc, IEnumerable<ResourceReference> references)                                               // BuildMemberReferences.cs:51
	    {                                                                                                                                      // BuildMemberReferences.cs:52
	        IEnumerable<ResourceBase> resources = base.IsMember(doc,                                                                           // BuildMemberReferences.cs:53
	            references,                                                                                                                    // BuildMemberReferences.cs:54
	            this.targetUrls);                                                                                                              // BuildMemberReferences.cs:55
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberReferences.cs:56
	        foreach (ResourceBase resource in resources)                                                                                       // BuildMemberReferences.cs:57
	        {                                                                                                                                  // BuildMemberReferences.cs:58
	            Item item = new Item((AssociatedFeature) resource);                                                                            // BuildMemberReferences.cs:59
	            items.Add(item);                                                                                                               // BuildMemberReferences.cs:60
	        }                                                                                                                                  // BuildMemberReferences.cs:61
	        this.SetAllItems(items);                                                                                                           // BuildMemberReferences.cs:62
	    }                                                                                                                                      // BuildMemberReferences.cs:63
	}                                                                                                                                          // BuildMemberBase.cs:148
	/// <summary>
	/// Container class for Observation.hasMember:abnormalityFibroadenoma.
	/// </summary>
	public class AbnormalityFibroadenomaContainer : MContainer, ITMItem<ResourceReference>                                                     // BuildMemberBase.cs:131
	{                                                                                                                                          // BuildMemberBase.cs:132
	    /// <summary>
	    /// Item class for Observation.hasMember:abnormalityFibroadenoma.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:63
	    {                                                                                                                                      // BuildMemberBase.cs:64
	        // Properties                                                                                                                      // BuildMemberBase.cs:65
	        /// <summary>
	        /// Value
	        /// </summary>
	        public AbnormalityFibroadenoma Value { get; set; }                                                                                 // BuildMemberBase.cs:69
	                                                                                                                                           // BuildMemberBase.cs:71
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(AbnormalityFibroadenoma value)                                                                                         // BuildMemberBase.cs:75
	        {                                                                                                                                  // BuildMemberBase.cs:76
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:77
	        }                                                                                                                                  // BuildMemberBase.cs:79
	                                                                                                                                           // BuildMemberBase.cs:81
	        // Methods                                                                                                                         // BuildMemberBase.cs:82
	    }                                                                                                                                      // BuildMemberBase.cs:84
	                                                                                                                                           // BuildMemberBase.cs:134
	    // Properties                                                                                                                          // BuildMemberBase.cs:135
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:109
	    {                                                                                                                                      // BuildMemberBase.cs:110
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityFibroadenoma"                                              // BuildMemberBase.cs:117
	    };                                                                                                                                     // BuildMemberBase.cs:118
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:223
	                                                                                                                                           // BuildMemberBase.cs:225
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:229
	                                                                                                                                           // BuildMemberBase.cs:231
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:235
	                                                                                                                                           // BuildMemberBase.cs:237
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:241
	                                                                                                                                           // BuildMemberBase.cs:243
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<AbnormalityFibroadenoma> All()                                                                                      // BuildMemberBase.cs:247
	    {                                                                                                                                      // BuildMemberBase.cs:248
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:249
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:250
	    }                                                                                                                                      // BuildMemberBase.cs:251
	                                                                                                                                           // BuildMemberBase.cs:253
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public AbnormalityFibroadenoma GetAt(Int32 i) => this.items[i].Value;                                                                  // BuildMemberBase.cs:257
	                                                                                                                                           // BuildMemberBase.cs:259
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:263
	                                                                                                                                           // BuildMemberBase.cs:265
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:269
	                                                                                                                                           // BuildMemberBase.cs:137
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public AbnormalityFibroadenomaContainer(Int32 min, Int32 max) : base("Observation.hasMember:abnormalityFibroadenoma", min, max)        // BuildMemberBase.cs:141
	    {                                                                                                                                      // BuildMemberBase.cs:142
	    }                                                                                                                                      // BuildMemberBase.cs:144
	                                                                                                                                           // BuildMemberBase.cs:145
	    // Methods                                                                                                                             // BuildMemberBase.cs:146
	                                                                                                                                           // BuildMemberBase.cs:275
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public AbnormalityFibroadenoma Append(AbnormalityFibroadenoma value)                                                                   // BuildMemberBase.cs:279
	    {                                                                                                                                      // BuildMemberBase.cs:280
	        this.items.Add(new Item(value));                                                                                                   // BuildMemberBase.cs:281
	        return value;                                                                                                                      // BuildMemberBase.cs:282
	    }                                                                                                                                      // BuildMemberBase.cs:283
	                                                                                                                                           // BuildMemberBase.cs:289
	    /// <summary>
	    /// Write single item as a fhir element.
	    /// </summary>
	    public IEnumerable<ResourceReference> Write(BreastRadiologyDocument doc)                                                               // BuildMemberReferences.cs:74
	    {                                                                                                                                      // BuildMemberReferences.cs:75
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberReferences.cs:76
	        {                                                                                                                                  // BuildMemberReferences.cs:77
	            ResourceReference reference = new ResourceReference                                                                            // BuildMemberReferences.cs:78
	            {                                                                                                                              // BuildMemberReferences.cs:79
	                Reference = item.Value.Id                                                                                                  // BuildMemberReferences.cs:80
	            };                                                                                                                             // BuildMemberReferences.cs:81
	            yield return reference;                                                                                                        // BuildMemberReferences.cs:82
	        }                                                                                                                                  // BuildMemberReferences.cs:83
	    }                                                                                                                                      // BuildMemberReferences.cs:84
	                                                                                                                                           // BuildMemberBase.cs:295
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	                                                                                                                                           // BuildMemberReferences.cs:50
	    public void Read(BreastRadiologyDocument doc, IEnumerable<ResourceReference> references)                                               // BuildMemberReferences.cs:51
	    {                                                                                                                                      // BuildMemberReferences.cs:52
	        IEnumerable<ResourceBase> resources = base.IsMember(doc,                                                                           // BuildMemberReferences.cs:53
	            references,                                                                                                                    // BuildMemberReferences.cs:54
	            this.targetUrls);                                                                                                              // BuildMemberReferences.cs:55
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberReferences.cs:56
	        foreach (ResourceBase resource in resources)                                                                                       // BuildMemberReferences.cs:57
	        {                                                                                                                                  // BuildMemberReferences.cs:58
	            Item item = new Item((AbnormalityFibroadenoma) resource);                                                                      // BuildMemberReferences.cs:59
	            items.Add(item);                                                                                                               // BuildMemberReferences.cs:60
	        }                                                                                                                                  // BuildMemberReferences.cs:61
	        this.SetAllItems(items);                                                                                                           // BuildMemberReferences.cs:62
	    }                                                                                                                                      // BuildMemberReferences.cs:63
	}                                                                                                                                          // BuildMemberBase.cs:148
	/// <summary>
	/// Container class for Observation.hasMember:mGAbnormalityArchitecturalDistortion.
	/// </summary>
	public class MGAbnormalityArchitecturalDistortionContainer : MContainer, ITMItem<ResourceReference>                                        // BuildMemberBase.cs:131
	{                                                                                                                                          // BuildMemberBase.cs:132
	    /// <summary>
	    /// Item class for Observation.hasMember:mGAbnormalityArchitecturalDistortion.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:63
	    {                                                                                                                                      // BuildMemberBase.cs:64
	        // Properties                                                                                                                      // BuildMemberBase.cs:65
	        /// <summary>
	        /// Value
	        /// </summary>
	        public MGAbnormalityArchitecturalDistortion Value { get; set; }                                                                    // BuildMemberBase.cs:69
	                                                                                                                                           // BuildMemberBase.cs:71
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(MGAbnormalityArchitecturalDistortion value)                                                                            // BuildMemberBase.cs:75
	        {                                                                                                                                  // BuildMemberBase.cs:76
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:77
	        }                                                                                                                                  // BuildMemberBase.cs:79
	                                                                                                                                           // BuildMemberBase.cs:81
	        // Methods                                                                                                                         // BuildMemberBase.cs:82
	    }                                                                                                                                      // BuildMemberBase.cs:84
	                                                                                                                                           // BuildMemberBase.cs:134
	    // Properties                                                                                                                          // BuildMemberBase.cs:135
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:109
	    {                                                                                                                                      // BuildMemberBase.cs:110
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityArchitecturalDistortion"                                 // BuildMemberBase.cs:117
	    };                                                                                                                                     // BuildMemberBase.cs:118
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:223
	                                                                                                                                           // BuildMemberBase.cs:225
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:229
	                                                                                                                                           // BuildMemberBase.cs:231
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:235
	                                                                                                                                           // BuildMemberBase.cs:237
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:241
	                                                                                                                                           // BuildMemberBase.cs:243
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<MGAbnormalityArchitecturalDistortion> All()                                                                         // BuildMemberBase.cs:247
	    {                                                                                                                                      // BuildMemberBase.cs:248
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:249
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:250
	    }                                                                                                                                      // BuildMemberBase.cs:251
	                                                                                                                                           // BuildMemberBase.cs:253
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public MGAbnormalityArchitecturalDistortion GetAt(Int32 i) => this.items[i].Value;                                                     // BuildMemberBase.cs:257
	                                                                                                                                           // BuildMemberBase.cs:259
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:263
	                                                                                                                                           // BuildMemberBase.cs:265
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:269
	                                                                                                                                           // BuildMemberBase.cs:137
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public MGAbnormalityArchitecturalDistortionContainer(Int32 min, Int32 max) : base("Observation.hasMember:mGAbnormalityArchitecturalDistortion", min, max)// BuildMemberBase.cs:141
	    {                                                                                                                                      // BuildMemberBase.cs:142
	    }                                                                                                                                      // BuildMemberBase.cs:144
	                                                                                                                                           // BuildMemberBase.cs:145
	    // Methods                                                                                                                             // BuildMemberBase.cs:146
	                                                                                                                                           // BuildMemberBase.cs:275
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public MGAbnormalityArchitecturalDistortion Append(MGAbnormalityArchitecturalDistortion value)                                         // BuildMemberBase.cs:279
	    {                                                                                                                                      // BuildMemberBase.cs:280
	        this.items.Add(new Item(value));                                                                                                   // BuildMemberBase.cs:281
	        return value;                                                                                                                      // BuildMemberBase.cs:282
	    }                                                                                                                                      // BuildMemberBase.cs:283
	                                                                                                                                           // BuildMemberBase.cs:289
	    /// <summary>
	    /// Write single item as a fhir element.
	    /// </summary>
	    public IEnumerable<ResourceReference> Write(BreastRadiologyDocument doc)                                                               // BuildMemberReferences.cs:74
	    {                                                                                                                                      // BuildMemberReferences.cs:75
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberReferences.cs:76
	        {                                                                                                                                  // BuildMemberReferences.cs:77
	            ResourceReference reference = new ResourceReference                                                                            // BuildMemberReferences.cs:78
	            {                                                                                                                              // BuildMemberReferences.cs:79
	                Reference = item.Value.Id                                                                                                  // BuildMemberReferences.cs:80
	            };                                                                                                                             // BuildMemberReferences.cs:81
	            yield return reference;                                                                                                        // BuildMemberReferences.cs:82
	        }                                                                                                                                  // BuildMemberReferences.cs:83
	    }                                                                                                                                      // BuildMemberReferences.cs:84
	                                                                                                                                           // BuildMemberBase.cs:295
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	                                                                                                                                           // BuildMemberReferences.cs:50
	    public void Read(BreastRadiologyDocument doc, IEnumerable<ResourceReference> references)                                               // BuildMemberReferences.cs:51
	    {                                                                                                                                      // BuildMemberReferences.cs:52
	        IEnumerable<ResourceBase> resources = base.IsMember(doc,                                                                           // BuildMemberReferences.cs:53
	            references,                                                                                                                    // BuildMemberReferences.cs:54
	            this.targetUrls);                                                                                                              // BuildMemberReferences.cs:55
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberReferences.cs:56
	        foreach (ResourceBase resource in resources)                                                                                       // BuildMemberReferences.cs:57
	        {                                                                                                                                  // BuildMemberReferences.cs:58
	            Item item = new Item((MGAbnormalityArchitecturalDistortion) resource);                                                         // BuildMemberReferences.cs:59
	            items.Add(item);                                                                                                               // BuildMemberReferences.cs:60
	        }                                                                                                                                  // BuildMemberReferences.cs:61
	        this.SetAllItems(items);                                                                                                           // BuildMemberReferences.cs:62
	    }                                                                                                                                      // BuildMemberReferences.cs:63
	}                                                                                                                                          // BuildMemberBase.cs:148
	/// <summary>
	/// Container class for Observation.hasMember:mGAbnormalityAsymmetry.
	/// </summary>
	public class MGAbnormalityAsymmetryContainer : MContainer, ITMItem<ResourceReference>                                                      // BuildMemberBase.cs:131
	{                                                                                                                                          // BuildMemberBase.cs:132
	    /// <summary>
	    /// Item class for Observation.hasMember:mGAbnormalityAsymmetry.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:63
	    {                                                                                                                                      // BuildMemberBase.cs:64
	        // Properties                                                                                                                      // BuildMemberBase.cs:65
	        /// <summary>
	        /// Value
	        /// </summary>
	        public MGAbnormalityAsymmetry Value { get; set; }                                                                                  // BuildMemberBase.cs:69
	                                                                                                                                           // BuildMemberBase.cs:71
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(MGAbnormalityAsymmetry value)                                                                                          // BuildMemberBase.cs:75
	        {                                                                                                                                  // BuildMemberBase.cs:76
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:77
	        }                                                                                                                                  // BuildMemberBase.cs:79
	                                                                                                                                           // BuildMemberBase.cs:81
	        // Methods                                                                                                                         // BuildMemberBase.cs:82
	    }                                                                                                                                      // BuildMemberBase.cs:84
	                                                                                                                                           // BuildMemberBase.cs:134
	    // Properties                                                                                                                          // BuildMemberBase.cs:135
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:109
	    {                                                                                                                                      // BuildMemberBase.cs:110
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityAsymmetry"                                               // BuildMemberBase.cs:117
	    };                                                                                                                                     // BuildMemberBase.cs:118
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:223
	                                                                                                                                           // BuildMemberBase.cs:225
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:229
	                                                                                                                                           // BuildMemberBase.cs:231
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:235
	                                                                                                                                           // BuildMemberBase.cs:237
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:241
	                                                                                                                                           // BuildMemberBase.cs:243
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<MGAbnormalityAsymmetry> All()                                                                                       // BuildMemberBase.cs:247
	    {                                                                                                                                      // BuildMemberBase.cs:248
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:249
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:250
	    }                                                                                                                                      // BuildMemberBase.cs:251
	                                                                                                                                           // BuildMemberBase.cs:253
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public MGAbnormalityAsymmetry GetAt(Int32 i) => this.items[i].Value;                                                                   // BuildMemberBase.cs:257
	                                                                                                                                           // BuildMemberBase.cs:259
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:263
	                                                                                                                                           // BuildMemberBase.cs:265
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:269
	                                                                                                                                           // BuildMemberBase.cs:137
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public MGAbnormalityAsymmetryContainer(Int32 min, Int32 max) : base("Observation.hasMember:mGAbnormalityAsymmetry", min, max)          // BuildMemberBase.cs:141
	    {                                                                                                                                      // BuildMemberBase.cs:142
	    }                                                                                                                                      // BuildMemberBase.cs:144
	                                                                                                                                           // BuildMemberBase.cs:145
	    // Methods                                                                                                                             // BuildMemberBase.cs:146
	                                                                                                                                           // BuildMemberBase.cs:275
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public MGAbnormalityAsymmetry Append(MGAbnormalityAsymmetry value)                                                                     // BuildMemberBase.cs:279
	    {                                                                                                                                      // BuildMemberBase.cs:280
	        this.items.Add(new Item(value));                                                                                                   // BuildMemberBase.cs:281
	        return value;                                                                                                                      // BuildMemberBase.cs:282
	    }                                                                                                                                      // BuildMemberBase.cs:283
	                                                                                                                                           // BuildMemberBase.cs:289
	    /// <summary>
	    /// Write single item as a fhir element.
	    /// </summary>
	    public IEnumerable<ResourceReference> Write(BreastRadiologyDocument doc)                                                               // BuildMemberReferences.cs:74
	    {                                                                                                                                      // BuildMemberReferences.cs:75
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberReferences.cs:76
	        {                                                                                                                                  // BuildMemberReferences.cs:77
	            ResourceReference reference = new ResourceReference                                                                            // BuildMemberReferences.cs:78
	            {                                                                                                                              // BuildMemberReferences.cs:79
	                Reference = item.Value.Id                                                                                                  // BuildMemberReferences.cs:80
	            };                                                                                                                             // BuildMemberReferences.cs:81
	            yield return reference;                                                                                                        // BuildMemberReferences.cs:82
	        }                                                                                                                                  // BuildMemberReferences.cs:83
	    }                                                                                                                                      // BuildMemberReferences.cs:84
	                                                                                                                                           // BuildMemberBase.cs:295
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	                                                                                                                                           // BuildMemberReferences.cs:50
	    public void Read(BreastRadiologyDocument doc, IEnumerable<ResourceReference> references)                                               // BuildMemberReferences.cs:51
	    {                                                                                                                                      // BuildMemberReferences.cs:52
	        IEnumerable<ResourceBase> resources = base.IsMember(doc,                                                                           // BuildMemberReferences.cs:53
	            references,                                                                                                                    // BuildMemberReferences.cs:54
	            this.targetUrls);                                                                                                              // BuildMemberReferences.cs:55
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberReferences.cs:56
	        foreach (ResourceBase resource in resources)                                                                                       // BuildMemberReferences.cs:57
	        {                                                                                                                                  // BuildMemberReferences.cs:58
	            Item item = new Item((MGAbnormalityAsymmetry) resource);                                                                       // BuildMemberReferences.cs:59
	            items.Add(item);                                                                                                               // BuildMemberReferences.cs:60
	        }                                                                                                                                  // BuildMemberReferences.cs:61
	        this.SetAllItems(items);                                                                                                           // BuildMemberReferences.cs:62
	    }                                                                                                                                      // BuildMemberReferences.cs:63
	}                                                                                                                                          // BuildMemberBase.cs:148
	/// <summary>
	/// Container class for Observation.hasMember:mGAbnormalityCalcification.
	/// </summary>
	public class MGAbnormalityCalcificationContainer : MContainer, ITMItem<ResourceReference>                                                  // BuildMemberBase.cs:131
	{                                                                                                                                          // BuildMemberBase.cs:132
	    /// <summary>
	    /// Item class for Observation.hasMember:mGAbnormalityCalcification.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:63
	    {                                                                                                                                      // BuildMemberBase.cs:64
	        // Properties                                                                                                                      // BuildMemberBase.cs:65
	        /// <summary>
	        /// Value
	        /// </summary>
	        public MGAbnormalityCalcification Value { get; set; }                                                                              // BuildMemberBase.cs:69
	                                                                                                                                           // BuildMemberBase.cs:71
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(MGAbnormalityCalcification value)                                                                                      // BuildMemberBase.cs:75
	        {                                                                                                                                  // BuildMemberBase.cs:76
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:77
	        }                                                                                                                                  // BuildMemberBase.cs:79
	                                                                                                                                           // BuildMemberBase.cs:81
	        // Methods                                                                                                                         // BuildMemberBase.cs:82
	    }                                                                                                                                      // BuildMemberBase.cs:84
	                                                                                                                                           // BuildMemberBase.cs:134
	    // Properties                                                                                                                          // BuildMemberBase.cs:135
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:109
	    {                                                                                                                                      // BuildMemberBase.cs:110
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityCalcification"                                           // BuildMemberBase.cs:117
	    };                                                                                                                                     // BuildMemberBase.cs:118
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:223
	                                                                                                                                           // BuildMemberBase.cs:225
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:229
	                                                                                                                                           // BuildMemberBase.cs:231
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:235
	                                                                                                                                           // BuildMemberBase.cs:237
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:241
	                                                                                                                                           // BuildMemberBase.cs:243
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<MGAbnormalityCalcification> All()                                                                                   // BuildMemberBase.cs:247
	    {                                                                                                                                      // BuildMemberBase.cs:248
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:249
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:250
	    }                                                                                                                                      // BuildMemberBase.cs:251
	                                                                                                                                           // BuildMemberBase.cs:253
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public MGAbnormalityCalcification GetAt(Int32 i) => this.items[i].Value;                                                               // BuildMemberBase.cs:257
	                                                                                                                                           // BuildMemberBase.cs:259
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:263
	                                                                                                                                           // BuildMemberBase.cs:265
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:269
	                                                                                                                                           // BuildMemberBase.cs:137
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public MGAbnormalityCalcificationContainer(Int32 min, Int32 max) : base("Observation.hasMember:mGAbnormalityCalcification", min, max)  // BuildMemberBase.cs:141
	    {                                                                                                                                      // BuildMemberBase.cs:142
	    }                                                                                                                                      // BuildMemberBase.cs:144
	                                                                                                                                           // BuildMemberBase.cs:145
	    // Methods                                                                                                                             // BuildMemberBase.cs:146
	                                                                                                                                           // BuildMemberBase.cs:275
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public MGAbnormalityCalcification Append(MGAbnormalityCalcification value)                                                             // BuildMemberBase.cs:279
	    {                                                                                                                                      // BuildMemberBase.cs:280
	        this.items.Add(new Item(value));                                                                                                   // BuildMemberBase.cs:281
	        return value;                                                                                                                      // BuildMemberBase.cs:282
	    }                                                                                                                                      // BuildMemberBase.cs:283
	                                                                                                                                           // BuildMemberBase.cs:289
	    /// <summary>
	    /// Write single item as a fhir element.
	    /// </summary>
	    public IEnumerable<ResourceReference> Write(BreastRadiologyDocument doc)                                                               // BuildMemberReferences.cs:74
	    {                                                                                                                                      // BuildMemberReferences.cs:75
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberReferences.cs:76
	        {                                                                                                                                  // BuildMemberReferences.cs:77
	            ResourceReference reference = new ResourceReference                                                                            // BuildMemberReferences.cs:78
	            {                                                                                                                              // BuildMemberReferences.cs:79
	                Reference = item.Value.Id                                                                                                  // BuildMemberReferences.cs:80
	            };                                                                                                                             // BuildMemberReferences.cs:81
	            yield return reference;                                                                                                        // BuildMemberReferences.cs:82
	        }                                                                                                                                  // BuildMemberReferences.cs:83
	    }                                                                                                                                      // BuildMemberReferences.cs:84
	                                                                                                                                           // BuildMemberBase.cs:295
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	                                                                                                                                           // BuildMemberReferences.cs:50
	    public void Read(BreastRadiologyDocument doc, IEnumerable<ResourceReference> references)                                               // BuildMemberReferences.cs:51
	    {                                                                                                                                      // BuildMemberReferences.cs:52
	        IEnumerable<ResourceBase> resources = base.IsMember(doc,                                                                           // BuildMemberReferences.cs:53
	            references,                                                                                                                    // BuildMemberReferences.cs:54
	            this.targetUrls);                                                                                                              // BuildMemberReferences.cs:55
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberReferences.cs:56
	        foreach (ResourceBase resource in resources)                                                                                       // BuildMemberReferences.cs:57
	        {                                                                                                                                  // BuildMemberReferences.cs:58
	            Item item = new Item((MGAbnormalityCalcification) resource);                                                                   // BuildMemberReferences.cs:59
	            items.Add(item);                                                                                                               // BuildMemberReferences.cs:60
	        }                                                                                                                                  // BuildMemberReferences.cs:61
	        this.SetAllItems(items);                                                                                                           // BuildMemberReferences.cs:62
	    }                                                                                                                                      // BuildMemberReferences.cs:63
	}                                                                                                                                          // BuildMemberBase.cs:148
	/// <summary>
	/// Container class for Observation.hasMember:mGAbnormalityDensity.
	/// </summary>
	public class MGAbnormalityDensityContainer : MContainer, ITMItem<ResourceReference>                                                        // BuildMemberBase.cs:131
	{                                                                                                                                          // BuildMemberBase.cs:132
	    /// <summary>
	    /// Item class for Observation.hasMember:mGAbnormalityDensity.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:63
	    {                                                                                                                                      // BuildMemberBase.cs:64
	        // Properties                                                                                                                      // BuildMemberBase.cs:65
	        /// <summary>
	        /// Value
	        /// </summary>
	        public MGAbnormalityDensity Value { get; set; }                                                                                    // BuildMemberBase.cs:69
	                                                                                                                                           // BuildMemberBase.cs:71
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(MGAbnormalityDensity value)                                                                                            // BuildMemberBase.cs:75
	        {                                                                                                                                  // BuildMemberBase.cs:76
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:77
	        }                                                                                                                                  // BuildMemberBase.cs:79
	                                                                                                                                           // BuildMemberBase.cs:81
	        // Methods                                                                                                                         // BuildMemberBase.cs:82
	    }                                                                                                                                      // BuildMemberBase.cs:84
	                                                                                                                                           // BuildMemberBase.cs:134
	    // Properties                                                                                                                          // BuildMemberBase.cs:135
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:109
	    {                                                                                                                                      // BuildMemberBase.cs:110
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityDensity"                                                 // BuildMemberBase.cs:117
	    };                                                                                                                                     // BuildMemberBase.cs:118
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:223
	                                                                                                                                           // BuildMemberBase.cs:225
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:229
	                                                                                                                                           // BuildMemberBase.cs:231
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:235
	                                                                                                                                           // BuildMemberBase.cs:237
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:241
	                                                                                                                                           // BuildMemberBase.cs:243
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<MGAbnormalityDensity> All()                                                                                         // BuildMemberBase.cs:247
	    {                                                                                                                                      // BuildMemberBase.cs:248
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:249
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:250
	    }                                                                                                                                      // BuildMemberBase.cs:251
	                                                                                                                                           // BuildMemberBase.cs:253
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public MGAbnormalityDensity GetAt(Int32 i) => this.items[i].Value;                                                                     // BuildMemberBase.cs:257
	                                                                                                                                           // BuildMemberBase.cs:259
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:263
	                                                                                                                                           // BuildMemberBase.cs:265
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:269
	                                                                                                                                           // BuildMemberBase.cs:137
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public MGAbnormalityDensityContainer(Int32 min, Int32 max) : base("Observation.hasMember:mGAbnormalityDensity", min, max)              // BuildMemberBase.cs:141
	    {                                                                                                                                      // BuildMemberBase.cs:142
	    }                                                                                                                                      // BuildMemberBase.cs:144
	                                                                                                                                           // BuildMemberBase.cs:145
	    // Methods                                                                                                                             // BuildMemberBase.cs:146
	                                                                                                                                           // BuildMemberBase.cs:275
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public MGAbnormalityDensity Append(MGAbnormalityDensity value)                                                                         // BuildMemberBase.cs:279
	    {                                                                                                                                      // BuildMemberBase.cs:280
	        this.items.Add(new Item(value));                                                                                                   // BuildMemberBase.cs:281
	        return value;                                                                                                                      // BuildMemberBase.cs:282
	    }                                                                                                                                      // BuildMemberBase.cs:283
	                                                                                                                                           // BuildMemberBase.cs:289
	    /// <summary>
	    /// Write single item as a fhir element.
	    /// </summary>
	    public IEnumerable<ResourceReference> Write(BreastRadiologyDocument doc)                                                               // BuildMemberReferences.cs:74
	    {                                                                                                                                      // BuildMemberReferences.cs:75
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberReferences.cs:76
	        {                                                                                                                                  // BuildMemberReferences.cs:77
	            ResourceReference reference = new ResourceReference                                                                            // BuildMemberReferences.cs:78
	            {                                                                                                                              // BuildMemberReferences.cs:79
	                Reference = item.Value.Id                                                                                                  // BuildMemberReferences.cs:80
	            };                                                                                                                             // BuildMemberReferences.cs:81
	            yield return reference;                                                                                                        // BuildMemberReferences.cs:82
	        }                                                                                                                                  // BuildMemberReferences.cs:83
	    }                                                                                                                                      // BuildMemberReferences.cs:84
	                                                                                                                                           // BuildMemberBase.cs:295
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	                                                                                                                                           // BuildMemberReferences.cs:50
	    public void Read(BreastRadiologyDocument doc, IEnumerable<ResourceReference> references)                                               // BuildMemberReferences.cs:51
	    {                                                                                                                                      // BuildMemberReferences.cs:52
	        IEnumerable<ResourceBase> resources = base.IsMember(doc,                                                                           // BuildMemberReferences.cs:53
	            references,                                                                                                                    // BuildMemberReferences.cs:54
	            this.targetUrls);                                                                                                              // BuildMemberReferences.cs:55
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberReferences.cs:56
	        foreach (ResourceBase resource in resources)                                                                                       // BuildMemberReferences.cs:57
	        {                                                                                                                                  // BuildMemberReferences.cs:58
	            Item item = new Item((MGAbnormalityDensity) resource);                                                                         // BuildMemberReferences.cs:59
	            items.Add(item);                                                                                                               // BuildMemberReferences.cs:60
	        }                                                                                                                                  // BuildMemberReferences.cs:61
	        this.SetAllItems(items);                                                                                                           // BuildMemberReferences.cs:62
	    }                                                                                                                                      // BuildMemberReferences.cs:63
	}                                                                                                                                          // BuildMemberBase.cs:148
	/// <summary>
	/// Container class for Observation.hasMember:mGAbnormalityFatNecrosis.
	/// </summary>
	public class MGAbnormalityFatNecrosisContainer : MContainer, ITMItem<ResourceReference>                                                    // BuildMemberBase.cs:131
	{                                                                                                                                          // BuildMemberBase.cs:132
	    /// <summary>
	    /// Item class for Observation.hasMember:mGAbnormalityFatNecrosis.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:63
	    {                                                                                                                                      // BuildMemberBase.cs:64
	        // Properties                                                                                                                      // BuildMemberBase.cs:65
	        /// <summary>
	        /// Value
	        /// </summary>
	        public MGAbnormalityFatNecrosis Value { get; set; }                                                                                // BuildMemberBase.cs:69
	                                                                                                                                           // BuildMemberBase.cs:71
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(MGAbnormalityFatNecrosis value)                                                                                        // BuildMemberBase.cs:75
	        {                                                                                                                                  // BuildMemberBase.cs:76
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:77
	        }                                                                                                                                  // BuildMemberBase.cs:79
	                                                                                                                                           // BuildMemberBase.cs:81
	        // Methods                                                                                                                         // BuildMemberBase.cs:82
	    }                                                                                                                                      // BuildMemberBase.cs:84
	                                                                                                                                           // BuildMemberBase.cs:134
	    // Properties                                                                                                                          // BuildMemberBase.cs:135
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:109
	    {                                                                                                                                      // BuildMemberBase.cs:110
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityFatNecrosis"                                             // BuildMemberBase.cs:117
	    };                                                                                                                                     // BuildMemberBase.cs:118
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:223
	                                                                                                                                           // BuildMemberBase.cs:225
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:229
	                                                                                                                                           // BuildMemberBase.cs:231
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:235
	                                                                                                                                           // BuildMemberBase.cs:237
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:241
	                                                                                                                                           // BuildMemberBase.cs:243
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<MGAbnormalityFatNecrosis> All()                                                                                     // BuildMemberBase.cs:247
	    {                                                                                                                                      // BuildMemberBase.cs:248
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:249
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:250
	    }                                                                                                                                      // BuildMemberBase.cs:251
	                                                                                                                                           // BuildMemberBase.cs:253
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public MGAbnormalityFatNecrosis GetAt(Int32 i) => this.items[i].Value;                                                                 // BuildMemberBase.cs:257
	                                                                                                                                           // BuildMemberBase.cs:259
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:263
	                                                                                                                                           // BuildMemberBase.cs:265
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:269
	                                                                                                                                           // BuildMemberBase.cs:137
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public MGAbnormalityFatNecrosisContainer(Int32 min, Int32 max) : base("Observation.hasMember:mGAbnormalityFatNecrosis", min, max)      // BuildMemberBase.cs:141
	    {                                                                                                                                      // BuildMemberBase.cs:142
	    }                                                                                                                                      // BuildMemberBase.cs:144
	                                                                                                                                           // BuildMemberBase.cs:145
	    // Methods                                                                                                                             // BuildMemberBase.cs:146
	                                                                                                                                           // BuildMemberBase.cs:275
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public MGAbnormalityFatNecrosis Append(MGAbnormalityFatNecrosis value)                                                                 // BuildMemberBase.cs:279
	    {                                                                                                                                      // BuildMemberBase.cs:280
	        this.items.Add(new Item(value));                                                                                                   // BuildMemberBase.cs:281
	        return value;                                                                                                                      // BuildMemberBase.cs:282
	    }                                                                                                                                      // BuildMemberBase.cs:283
	                                                                                                                                           // BuildMemberBase.cs:289
	    /// <summary>
	    /// Write single item as a fhir element.
	    /// </summary>
	    public IEnumerable<ResourceReference> Write(BreastRadiologyDocument doc)                                                               // BuildMemberReferences.cs:74
	    {                                                                                                                                      // BuildMemberReferences.cs:75
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberReferences.cs:76
	        {                                                                                                                                  // BuildMemberReferences.cs:77
	            ResourceReference reference = new ResourceReference                                                                            // BuildMemberReferences.cs:78
	            {                                                                                                                              // BuildMemberReferences.cs:79
	                Reference = item.Value.Id                                                                                                  // BuildMemberReferences.cs:80
	            };                                                                                                                             // BuildMemberReferences.cs:81
	            yield return reference;                                                                                                        // BuildMemberReferences.cs:82
	        }                                                                                                                                  // BuildMemberReferences.cs:83
	    }                                                                                                                                      // BuildMemberReferences.cs:84
	                                                                                                                                           // BuildMemberBase.cs:295
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	                                                                                                                                           // BuildMemberReferences.cs:50
	    public void Read(BreastRadiologyDocument doc, IEnumerable<ResourceReference> references)                                               // BuildMemberReferences.cs:51
	    {                                                                                                                                      // BuildMemberReferences.cs:52
	        IEnumerable<ResourceBase> resources = base.IsMember(doc,                                                                           // BuildMemberReferences.cs:53
	            references,                                                                                                                    // BuildMemberReferences.cs:54
	            this.targetUrls);                                                                                                              // BuildMemberReferences.cs:55
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberReferences.cs:56
	        foreach (ResourceBase resource in resources)                                                                                       // BuildMemberReferences.cs:57
	        {                                                                                                                                  // BuildMemberReferences.cs:58
	            Item item = new Item((MGAbnormalityFatNecrosis) resource);                                                                     // BuildMemberReferences.cs:59
	            items.Add(item);                                                                                                               // BuildMemberReferences.cs:60
	        }                                                                                                                                  // BuildMemberReferences.cs:61
	        this.SetAllItems(items);                                                                                                           // BuildMemberReferences.cs:62
	    }                                                                                                                                      // BuildMemberReferences.cs:63
	}                                                                                                                                          // BuildMemberBase.cs:148
	/// <summary>
	/// Container class for Observation.hasMember:mGBreastDensity.
	/// </summary>
	public class MGBreastDensityContainer : MContainer, ITMItem<ResourceReference>                                                             // BuildMemberBase.cs:131
	{                                                                                                                                          // BuildMemberBase.cs:132
	    /// <summary>
	    /// Item class for Observation.hasMember:mGBreastDensity.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:63
	    {                                                                                                                                      // BuildMemberBase.cs:64
	        // Properties                                                                                                                      // BuildMemberBase.cs:65
	        /// <summary>
	        /// Value
	        /// </summary>
	        public MGBreastDensity Value { get; set; }                                                                                         // BuildMemberBase.cs:69
	                                                                                                                                           // BuildMemberBase.cs:71
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(MGBreastDensity value)                                                                                                 // BuildMemberBase.cs:75
	        {                                                                                                                                  // BuildMemberBase.cs:76
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:77
	        }                                                                                                                                  // BuildMemberBase.cs:79
	                                                                                                                                           // BuildMemberBase.cs:81
	        // Methods                                                                                                                         // BuildMemberBase.cs:82
	    }                                                                                                                                      // BuildMemberBase.cs:84
	                                                                                                                                           // BuildMemberBase.cs:134
	    // Properties                                                                                                                          // BuildMemberBase.cs:135
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:109
	    {                                                                                                                                      // BuildMemberBase.cs:110
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGBreastDensity"                                                      // BuildMemberBase.cs:117
	    };                                                                                                                                     // BuildMemberBase.cs:118
	                                                                                                                                           // BuildMemberBase.cs:158
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems()                                                                                                        // BuildMemberBase.cs:162
	    {                                                                                                                                      // BuildMemberBase.cs:163
	        if (this.item != null) yield return this.item;                                                                                     // BuildMemberBase.cs:164
	    }                                                                                                                                      // BuildMemberBase.cs:165
	                                                                                                                                           // BuildMemberBase.cs:167
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items)                                                                                              // BuildMemberBase.cs:171
	    {                                                                                                                                      // BuildMemberBase.cs:172
	        switch (items.Count())                                                                                                             // BuildMemberBase.cs:173
	        {                                                                                                                                  // BuildMemberBase.cs:174
	            case 0: break;                                                                                                                 // BuildMemberBase.cs:175
	            case 1: this.item = items.First(); break;                                                                                      // BuildMemberBase.cs:176
	            default: throw new Exception("Found multiple elements while reading single item");                                             // BuildMemberBase.cs:177
	        }                                                                                                                                  // BuildMemberBase.cs:178
	    }                                                                                                                                      // BuildMemberBase.cs:179
	                                                                                                                                           // BuildMemberBase.cs:181
	    /// <summary>
	    /// Item
	    /// </summary>
	    Item item;                                                                                                                             // BuildMemberBase.cs:185
	                                                                                                                                           // BuildMemberBase.cs:187
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => this.item == null ? 0 : 1;                                                                              // BuildMemberBase.cs:191
	                                                                                                                                           // BuildMemberBase.cs:193
	    /// <summary>
	    /// Get Item's Value
	    /// </summary>
	    public MGBreastDensity Get()                                                                                                           // BuildMemberBase.cs:197
	    {                                                                                                                                      // BuildMemberBase.cs:198
	        if (item == null)                                                                                                                  // BuildMemberBase.cs:199
	            return null;                                                                                                                   // BuildMemberBase.cs:200
	        return item.Value;                                                                                                                 // BuildMemberBase.cs:201
	    }                                                                                                                                      // BuildMemberBase.cs:202
	                                                                                                                                           // BuildMemberBase.cs:208
	    /// <summary>
	    /// Set Item's Value
	    /// </summary>
	    public MGBreastDensity Set(MGBreastDensity value)                                                                                      // BuildMemberBase.cs:212
	    {                                                                                                                                      // BuildMemberBase.cs:213
	        this.item = new Item(value);                                                                                                       // BuildMemberBase.cs:214
	        return value;                                                                                                                      // BuildMemberBase.cs:215
	    }                                                                                                                                      // BuildMemberBase.cs:216
	                                                                                                                                           // BuildMemberBase.cs:137
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public MGBreastDensityContainer(Int32 min, Int32 max) : base("Observation.hasMember:mGBreastDensity", min, max)                        // BuildMemberBase.cs:141
	    {                                                                                                                                      // BuildMemberBase.cs:142
	    }                                                                                                                                      // BuildMemberBase.cs:144
	                                                                                                                                           // BuildMemberBase.cs:145
	    // Methods                                                                                                                             // BuildMemberBase.cs:146
	                                                                                                                                           // BuildMemberBase.cs:289
	    /// <summary>
	    /// Write single item as a fhir element.
	    /// </summary>
	    public IEnumerable<ResourceReference> Write(BreastRadiologyDocument doc)                                                               // BuildMemberReferences.cs:74
	    {                                                                                                                                      // BuildMemberReferences.cs:75
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberReferences.cs:76
	        {                                                                                                                                  // BuildMemberReferences.cs:77
	            ResourceReference reference = new ResourceReference                                                                            // BuildMemberReferences.cs:78
	            {                                                                                                                              // BuildMemberReferences.cs:79
	                Reference = item.Value.Id                                                                                                  // BuildMemberReferences.cs:80
	            };                                                                                                                             // BuildMemberReferences.cs:81
	            yield return reference;                                                                                                        // BuildMemberReferences.cs:82
	        }                                                                                                                                  // BuildMemberReferences.cs:83
	    }                                                                                                                                      // BuildMemberReferences.cs:84
	                                                                                                                                           // BuildMemberBase.cs:295
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	                                                                                                                                           // BuildMemberReferences.cs:50
	    public void Read(BreastRadiologyDocument doc, IEnumerable<ResourceReference> references)                                               // BuildMemberReferences.cs:51
	    {                                                                                                                                      // BuildMemberReferences.cs:52
	        IEnumerable<ResourceBase> resources = base.IsMember(doc,                                                                           // BuildMemberReferences.cs:53
	            references,                                                                                                                    // BuildMemberReferences.cs:54
	            this.targetUrls);                                                                                                              // BuildMemberReferences.cs:55
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberReferences.cs:56
	        foreach (ResourceBase resource in resources)                                                                                       // BuildMemberReferences.cs:57
	        {                                                                                                                                  // BuildMemberReferences.cs:58
	            Item item = new Item((MGBreastDensity) resource);                                                                              // BuildMemberReferences.cs:59
	            items.Add(item);                                                                                                               // BuildMemberReferences.cs:60
	        }                                                                                                                                  // BuildMemberReferences.cs:61
	        this.SetAllItems(items);                                                                                                           // BuildMemberReferences.cs:62
	    }                                                                                                                                      // BuildMemberReferences.cs:63
	}                                                                                                                                          // BuildMemberBase.cs:148
	//- LocalClassDefs
}
