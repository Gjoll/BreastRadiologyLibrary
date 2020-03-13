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
	public class AbnormalityCystContainer : MContainer, ITMItem<ResourceReference>                                                             // BuildMemberBase.cs:110
	{                                                                                                                                          // BuildMemberBase.cs:111
	    /// <summary>
	    /// Item class for Observation.hasMember:abnormalityCyst.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:62
	    {                                                                                                                                      // BuildMemberBase.cs:63
	        // Properties                                                                                                                      // BuildMemberBase.cs:64
	        /// <summary>
	        /// Value
	        /// </summary>
	        public AbnormalityCyst Value { get; set; }                                                                                         // BuildMemberBase.cs:68
	                                                                                                                                           // BuildMemberBase.cs:70
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(AbnormalityCyst value)                                                                                                 // BuildMemberBase.cs:74
	        {                                                                                                                                  // BuildMemberBase.cs:75
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:76
	        }                                                                                                                                  // BuildMemberBase.cs:78
	                                                                                                                                           // BuildMemberBase.cs:80
	        // Methods                                                                                                                         // BuildMemberBase.cs:81
	    }                                                                                                                                      // BuildMemberBase.cs:83
	                                                                                                                                           // BuildMemberBase.cs:113
	    // Properties                                                                                                                          // BuildMemberBase.cs:114
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberReferences.cs:46
	    {                                                                                                                                      // BuildMemberReferences.cs:47
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityCyst"                                                      // BuildMemberReferences.cs:54
	    };                                                                                                                                     // BuildMemberReferences.cs:55
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:202
	                                                                                                                                           // BuildMemberBase.cs:204
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:208
	                                                                                                                                           // BuildMemberBase.cs:210
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:214
	                                                                                                                                           // BuildMemberBase.cs:216
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:220
	                                                                                                                                           // BuildMemberBase.cs:222
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<AbnormalityCyst> All()                                                                                              // BuildMemberBase.cs:226
	    {                                                                                                                                      // BuildMemberBase.cs:227
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:228
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:229
	    }                                                                                                                                      // BuildMemberBase.cs:230
	                                                                                                                                           // BuildMemberBase.cs:232
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public AbnormalityCyst GetAt(Int32 i) => this.items[i].Value;                                                                          // BuildMemberBase.cs:236
	                                                                                                                                           // BuildMemberBase.cs:238
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:242
	                                                                                                                                           // BuildMemberBase.cs:244
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:248
	                                                                                                                                           // BuildMemberBase.cs:116
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public AbnormalityCystContainer(Int32 min, Int32 max) : base("Observation.hasMember:abnormalityCyst", min, max)                        // BuildMemberBase.cs:120
	    {                                                                                                                                      // BuildMemberBase.cs:121
	    }                                                                                                                                      // BuildMemberBase.cs:123
	                                                                                                                                           // BuildMemberBase.cs:124
	    // Methods                                                                                                                             // BuildMemberBase.cs:125
	                                                                                                                                           // BuildMemberBase.cs:254
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public AbnormalityCyst Append(AbnormalityCyst value)                                                                                   // BuildMemberBase.cs:258
	    {                                                                                                                                      // BuildMemberBase.cs:259
	        this.items.Add(new Item(value));                                                                                                   // BuildMemberBase.cs:260
	        return value;                                                                                                                      // BuildMemberBase.cs:261
	    }                                                                                                                                      // BuildMemberBase.cs:262
	                                                                                                                                           // BuildMemberBase.cs:268
	    /// <summary>
	    /// Write single item as a fhir element.
	    /// </summary>
	    public IEnumerable<ResourceReference> Write(BreastRadiologyDocument doc)                                                               // BuildMemberReferences.cs:87
	    {                                                                                                                                      // BuildMemberReferences.cs:88
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberReferences.cs:89
	        {                                                                                                                                  // BuildMemberReferences.cs:90
	            ResourceReference reference = new ResourceReference                                                                            // BuildMemberReferences.cs:91
	            {                                                                                                                              // BuildMemberReferences.cs:92
	                Reference = item.Value.Id                                                                                                  // BuildMemberReferences.cs:93
	            };                                                                                                                             // BuildMemberReferences.cs:94
	            yield return reference;                                                                                                        // BuildMemberReferences.cs:95
	        }                                                                                                                                  // BuildMemberReferences.cs:96
	    }                                                                                                                                      // BuildMemberReferences.cs:97
	                                                                                                                                           // BuildMemberBase.cs:274
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	                                                                                                                                           // BuildMemberReferences.cs:63
	    public void Read(BreastRadiologyDocument doc, IEnumerable<ResourceReference> references)                                               // BuildMemberReferences.cs:64
	    {                                                                                                                                      // BuildMemberReferences.cs:65
	        IEnumerable<ResourceBase> resources = base.IsMember(doc,                                                                           // BuildMemberReferences.cs:66
	            references,                                                                                                                    // BuildMemberReferences.cs:67
	            this.targetUrls);                                                                                                              // BuildMemberReferences.cs:68
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberReferences.cs:69
	        foreach (ResourceBase resource in resources)                                                                                       // BuildMemberReferences.cs:70
	        {                                                                                                                                  // BuildMemberReferences.cs:71
	            Item item = new Item((AbnormalityCyst) resource);                                                                              // BuildMemberReferences.cs:72
	            items.Add(item);                                                                                                               // BuildMemberReferences.cs:73
	        }                                                                                                                                  // BuildMemberReferences.cs:74
	        this.SetAllItems(items);                                                                                                           // BuildMemberReferences.cs:75
	    }                                                                                                                                      // BuildMemberReferences.cs:76
	}                                                                                                                                          // BuildMemberBase.cs:127
	/// <summary>
	/// Container class for Observation.hasMember:abnormalityDuct.
	/// </summary>
	public class AbnormalityDuctContainer : MContainer, ITMItem<ResourceReference>                                                             // BuildMemberBase.cs:110
	{                                                                                                                                          // BuildMemberBase.cs:111
	    /// <summary>
	    /// Item class for Observation.hasMember:abnormalityDuct.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:62
	    {                                                                                                                                      // BuildMemberBase.cs:63
	        // Properties                                                                                                                      // BuildMemberBase.cs:64
	        /// <summary>
	        /// Value
	        /// </summary>
	        public AbnormalityDuct Value { get; set; }                                                                                         // BuildMemberBase.cs:68
	                                                                                                                                           // BuildMemberBase.cs:70
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(AbnormalityDuct value)                                                                                                 // BuildMemberBase.cs:74
	        {                                                                                                                                  // BuildMemberBase.cs:75
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:76
	        }                                                                                                                                  // BuildMemberBase.cs:78
	                                                                                                                                           // BuildMemberBase.cs:80
	        // Methods                                                                                                                         // BuildMemberBase.cs:81
	    }                                                                                                                                      // BuildMemberBase.cs:83
	                                                                                                                                           // BuildMemberBase.cs:113
	    // Properties                                                                                                                          // BuildMemberBase.cs:114
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberReferences.cs:46
	    {                                                                                                                                      // BuildMemberReferences.cs:47
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityDuct"                                                      // BuildMemberReferences.cs:54
	    };                                                                                                                                     // BuildMemberReferences.cs:55
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:202
	                                                                                                                                           // BuildMemberBase.cs:204
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:208
	                                                                                                                                           // BuildMemberBase.cs:210
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:214
	                                                                                                                                           // BuildMemberBase.cs:216
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:220
	                                                                                                                                           // BuildMemberBase.cs:222
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<AbnormalityDuct> All()                                                                                              // BuildMemberBase.cs:226
	    {                                                                                                                                      // BuildMemberBase.cs:227
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:228
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:229
	    }                                                                                                                                      // BuildMemberBase.cs:230
	                                                                                                                                           // BuildMemberBase.cs:232
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public AbnormalityDuct GetAt(Int32 i) => this.items[i].Value;                                                                          // BuildMemberBase.cs:236
	                                                                                                                                           // BuildMemberBase.cs:238
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:242
	                                                                                                                                           // BuildMemberBase.cs:244
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:248
	                                                                                                                                           // BuildMemberBase.cs:116
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public AbnormalityDuctContainer(Int32 min, Int32 max) : base("Observation.hasMember:abnormalityDuct", min, max)                        // BuildMemberBase.cs:120
	    {                                                                                                                                      // BuildMemberBase.cs:121
	    }                                                                                                                                      // BuildMemberBase.cs:123
	                                                                                                                                           // BuildMemberBase.cs:124
	    // Methods                                                                                                                             // BuildMemberBase.cs:125
	                                                                                                                                           // BuildMemberBase.cs:254
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public AbnormalityDuct Append(AbnormalityDuct value)                                                                                   // BuildMemberBase.cs:258
	    {                                                                                                                                      // BuildMemberBase.cs:259
	        this.items.Add(new Item(value));                                                                                                   // BuildMemberBase.cs:260
	        return value;                                                                                                                      // BuildMemberBase.cs:261
	    }                                                                                                                                      // BuildMemberBase.cs:262
	                                                                                                                                           // BuildMemberBase.cs:268
	    /// <summary>
	    /// Write single item as a fhir element.
	    /// </summary>
	    public IEnumerable<ResourceReference> Write(BreastRadiologyDocument doc)                                                               // BuildMemberReferences.cs:87
	    {                                                                                                                                      // BuildMemberReferences.cs:88
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberReferences.cs:89
	        {                                                                                                                                  // BuildMemberReferences.cs:90
	            ResourceReference reference = new ResourceReference                                                                            // BuildMemberReferences.cs:91
	            {                                                                                                                              // BuildMemberReferences.cs:92
	                Reference = item.Value.Id                                                                                                  // BuildMemberReferences.cs:93
	            };                                                                                                                             // BuildMemberReferences.cs:94
	            yield return reference;                                                                                                        // BuildMemberReferences.cs:95
	        }                                                                                                                                  // BuildMemberReferences.cs:96
	    }                                                                                                                                      // BuildMemberReferences.cs:97
	                                                                                                                                           // BuildMemberBase.cs:274
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	                                                                                                                                           // BuildMemberReferences.cs:63
	    public void Read(BreastRadiologyDocument doc, IEnumerable<ResourceReference> references)                                               // BuildMemberReferences.cs:64
	    {                                                                                                                                      // BuildMemberReferences.cs:65
	        IEnumerable<ResourceBase> resources = base.IsMember(doc,                                                                           // BuildMemberReferences.cs:66
	            references,                                                                                                                    // BuildMemberReferences.cs:67
	            this.targetUrls);                                                                                                              // BuildMemberReferences.cs:68
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberReferences.cs:69
	        foreach (ResourceBase resource in resources)                                                                                       // BuildMemberReferences.cs:70
	        {                                                                                                                                  // BuildMemberReferences.cs:71
	            Item item = new Item((AbnormalityDuct) resource);                                                                              // BuildMemberReferences.cs:72
	            items.Add(item);                                                                                                               // BuildMemberReferences.cs:73
	        }                                                                                                                                  // BuildMemberReferences.cs:74
	        this.SetAllItems(items);                                                                                                           // BuildMemberReferences.cs:75
	    }                                                                                                                                      // BuildMemberReferences.cs:76
	}                                                                                                                                          // BuildMemberBase.cs:127
	/// <summary>
	/// Container class for Observation.hasMember:abnormalityForeignObject.
	/// </summary>
	public class AbnormalityForeignObjectContainer : MContainer, ITMItem<ResourceReference>                                                    // BuildMemberBase.cs:110
	{                                                                                                                                          // BuildMemberBase.cs:111
	    /// <summary>
	    /// Item class for Observation.hasMember:abnormalityForeignObject.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:62
	    {                                                                                                                                      // BuildMemberBase.cs:63
	        // Properties                                                                                                                      // BuildMemberBase.cs:64
	        /// <summary>
	        /// Value
	        /// </summary>
	        public AbnormalityForeignObject Value { get; set; }                                                                                // BuildMemberBase.cs:68
	                                                                                                                                           // BuildMemberBase.cs:70
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(AbnormalityForeignObject value)                                                                                        // BuildMemberBase.cs:74
	        {                                                                                                                                  // BuildMemberBase.cs:75
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:76
	        }                                                                                                                                  // BuildMemberBase.cs:78
	                                                                                                                                           // BuildMemberBase.cs:80
	        // Methods                                                                                                                         // BuildMemberBase.cs:81
	    }                                                                                                                                      // BuildMemberBase.cs:83
	                                                                                                                                           // BuildMemberBase.cs:113
	    // Properties                                                                                                                          // BuildMemberBase.cs:114
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberReferences.cs:46
	    {                                                                                                                                      // BuildMemberReferences.cs:47
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityForeignObject"                                             // BuildMemberReferences.cs:54
	    };                                                                                                                                     // BuildMemberReferences.cs:55
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:202
	                                                                                                                                           // BuildMemberBase.cs:204
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:208
	                                                                                                                                           // BuildMemberBase.cs:210
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:214
	                                                                                                                                           // BuildMemberBase.cs:216
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:220
	                                                                                                                                           // BuildMemberBase.cs:222
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<AbnormalityForeignObject> All()                                                                                     // BuildMemberBase.cs:226
	    {                                                                                                                                      // BuildMemberBase.cs:227
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:228
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:229
	    }                                                                                                                                      // BuildMemberBase.cs:230
	                                                                                                                                           // BuildMemberBase.cs:232
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public AbnormalityForeignObject GetAt(Int32 i) => this.items[i].Value;                                                                 // BuildMemberBase.cs:236
	                                                                                                                                           // BuildMemberBase.cs:238
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:242
	                                                                                                                                           // BuildMemberBase.cs:244
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:248
	                                                                                                                                           // BuildMemberBase.cs:116
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public AbnormalityForeignObjectContainer(Int32 min, Int32 max) : base("Observation.hasMember:abnormalityForeignObject", min, max)      // BuildMemberBase.cs:120
	    {                                                                                                                                      // BuildMemberBase.cs:121
	    }                                                                                                                                      // BuildMemberBase.cs:123
	                                                                                                                                           // BuildMemberBase.cs:124
	    // Methods                                                                                                                             // BuildMemberBase.cs:125
	                                                                                                                                           // BuildMemberBase.cs:254
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public AbnormalityForeignObject Append(AbnormalityForeignObject value)                                                                 // BuildMemberBase.cs:258
	    {                                                                                                                                      // BuildMemberBase.cs:259
	        this.items.Add(new Item(value));                                                                                                   // BuildMemberBase.cs:260
	        return value;                                                                                                                      // BuildMemberBase.cs:261
	    }                                                                                                                                      // BuildMemberBase.cs:262
	                                                                                                                                           // BuildMemberBase.cs:268
	    /// <summary>
	    /// Write single item as a fhir element.
	    /// </summary>
	    public IEnumerable<ResourceReference> Write(BreastRadiologyDocument doc)                                                               // BuildMemberReferences.cs:87
	    {                                                                                                                                      // BuildMemberReferences.cs:88
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberReferences.cs:89
	        {                                                                                                                                  // BuildMemberReferences.cs:90
	            ResourceReference reference = new ResourceReference                                                                            // BuildMemberReferences.cs:91
	            {                                                                                                                              // BuildMemberReferences.cs:92
	                Reference = item.Value.Id                                                                                                  // BuildMemberReferences.cs:93
	            };                                                                                                                             // BuildMemberReferences.cs:94
	            yield return reference;                                                                                                        // BuildMemberReferences.cs:95
	        }                                                                                                                                  // BuildMemberReferences.cs:96
	    }                                                                                                                                      // BuildMemberReferences.cs:97
	                                                                                                                                           // BuildMemberBase.cs:274
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	                                                                                                                                           // BuildMemberReferences.cs:63
	    public void Read(BreastRadiologyDocument doc, IEnumerable<ResourceReference> references)                                               // BuildMemberReferences.cs:64
	    {                                                                                                                                      // BuildMemberReferences.cs:65
	        IEnumerable<ResourceBase> resources = base.IsMember(doc,                                                                           // BuildMemberReferences.cs:66
	            references,                                                                                                                    // BuildMemberReferences.cs:67
	            this.targetUrls);                                                                                                              // BuildMemberReferences.cs:68
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberReferences.cs:69
	        foreach (ResourceBase resource in resources)                                                                                       // BuildMemberReferences.cs:70
	        {                                                                                                                                  // BuildMemberReferences.cs:71
	            Item item = new Item((AbnormalityForeignObject) resource);                                                                     // BuildMemberReferences.cs:72
	            items.Add(item);                                                                                                               // BuildMemberReferences.cs:73
	        }                                                                                                                                  // BuildMemberReferences.cs:74
	        this.SetAllItems(items);                                                                                                           // BuildMemberReferences.cs:75
	    }                                                                                                                                      // BuildMemberReferences.cs:76
	}                                                                                                                                          // BuildMemberBase.cs:127
	/// <summary>
	/// Container class for Observation.hasMember:abnormalityLymphNode.
	/// </summary>
	public class AbnormalityLymphNodeContainer : MContainer, ITMItem<ResourceReference>                                                        // BuildMemberBase.cs:110
	{                                                                                                                                          // BuildMemberBase.cs:111
	    /// <summary>
	    /// Item class for Observation.hasMember:abnormalityLymphNode.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:62
	    {                                                                                                                                      // BuildMemberBase.cs:63
	        // Properties                                                                                                                      // BuildMemberBase.cs:64
	        /// <summary>
	        /// Value
	        /// </summary>
	        public AbnormalityLymphNode Value { get; set; }                                                                                    // BuildMemberBase.cs:68
	                                                                                                                                           // BuildMemberBase.cs:70
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(AbnormalityLymphNode value)                                                                                            // BuildMemberBase.cs:74
	        {                                                                                                                                  // BuildMemberBase.cs:75
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:76
	        }                                                                                                                                  // BuildMemberBase.cs:78
	                                                                                                                                           // BuildMemberBase.cs:80
	        // Methods                                                                                                                         // BuildMemberBase.cs:81
	    }                                                                                                                                      // BuildMemberBase.cs:83
	                                                                                                                                           // BuildMemberBase.cs:113
	    // Properties                                                                                                                          // BuildMemberBase.cs:114
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberReferences.cs:46
	    {                                                                                                                                      // BuildMemberReferences.cs:47
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityLymphNode"                                                 // BuildMemberReferences.cs:54
	    };                                                                                                                                     // BuildMemberReferences.cs:55
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:202
	                                                                                                                                           // BuildMemberBase.cs:204
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:208
	                                                                                                                                           // BuildMemberBase.cs:210
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:214
	                                                                                                                                           // BuildMemberBase.cs:216
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:220
	                                                                                                                                           // BuildMemberBase.cs:222
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<AbnormalityLymphNode> All()                                                                                         // BuildMemberBase.cs:226
	    {                                                                                                                                      // BuildMemberBase.cs:227
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:228
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:229
	    }                                                                                                                                      // BuildMemberBase.cs:230
	                                                                                                                                           // BuildMemberBase.cs:232
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public AbnormalityLymphNode GetAt(Int32 i) => this.items[i].Value;                                                                     // BuildMemberBase.cs:236
	                                                                                                                                           // BuildMemberBase.cs:238
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:242
	                                                                                                                                           // BuildMemberBase.cs:244
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:248
	                                                                                                                                           // BuildMemberBase.cs:116
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public AbnormalityLymphNodeContainer(Int32 min, Int32 max) : base("Observation.hasMember:abnormalityLymphNode", min, max)              // BuildMemberBase.cs:120
	    {                                                                                                                                      // BuildMemberBase.cs:121
	    }                                                                                                                                      // BuildMemberBase.cs:123
	                                                                                                                                           // BuildMemberBase.cs:124
	    // Methods                                                                                                                             // BuildMemberBase.cs:125
	                                                                                                                                           // BuildMemberBase.cs:254
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public AbnormalityLymphNode Append(AbnormalityLymphNode value)                                                                         // BuildMemberBase.cs:258
	    {                                                                                                                                      // BuildMemberBase.cs:259
	        this.items.Add(new Item(value));                                                                                                   // BuildMemberBase.cs:260
	        return value;                                                                                                                      // BuildMemberBase.cs:261
	    }                                                                                                                                      // BuildMemberBase.cs:262
	                                                                                                                                           // BuildMemberBase.cs:268
	    /// <summary>
	    /// Write single item as a fhir element.
	    /// </summary>
	    public IEnumerable<ResourceReference> Write(BreastRadiologyDocument doc)                                                               // BuildMemberReferences.cs:87
	    {                                                                                                                                      // BuildMemberReferences.cs:88
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberReferences.cs:89
	        {                                                                                                                                  // BuildMemberReferences.cs:90
	            ResourceReference reference = new ResourceReference                                                                            // BuildMemberReferences.cs:91
	            {                                                                                                                              // BuildMemberReferences.cs:92
	                Reference = item.Value.Id                                                                                                  // BuildMemberReferences.cs:93
	            };                                                                                                                             // BuildMemberReferences.cs:94
	            yield return reference;                                                                                                        // BuildMemberReferences.cs:95
	        }                                                                                                                                  // BuildMemberReferences.cs:96
	    }                                                                                                                                      // BuildMemberReferences.cs:97
	                                                                                                                                           // BuildMemberBase.cs:274
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	                                                                                                                                           // BuildMemberReferences.cs:63
	    public void Read(BreastRadiologyDocument doc, IEnumerable<ResourceReference> references)                                               // BuildMemberReferences.cs:64
	    {                                                                                                                                      // BuildMemberReferences.cs:65
	        IEnumerable<ResourceBase> resources = base.IsMember(doc,                                                                           // BuildMemberReferences.cs:66
	            references,                                                                                                                    // BuildMemberReferences.cs:67
	            this.targetUrls);                                                                                                              // BuildMemberReferences.cs:68
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberReferences.cs:69
	        foreach (ResourceBase resource in resources)                                                                                       // BuildMemberReferences.cs:70
	        {                                                                                                                                  // BuildMemberReferences.cs:71
	            Item item = new Item((AbnormalityLymphNode) resource);                                                                         // BuildMemberReferences.cs:72
	            items.Add(item);                                                                                                               // BuildMemberReferences.cs:73
	        }                                                                                                                                  // BuildMemberReferences.cs:74
	        this.SetAllItems(items);                                                                                                           // BuildMemberReferences.cs:75
	    }                                                                                                                                      // BuildMemberReferences.cs:76
	}                                                                                                                                          // BuildMemberBase.cs:127
	/// <summary>
	/// Container class for Observation.hasMember:abnormalityMass.
	/// </summary>
	public class AbnormalityMassContainer : MContainer, ITMItem<ResourceReference>                                                             // BuildMemberBase.cs:110
	{                                                                                                                                          // BuildMemberBase.cs:111
	    /// <summary>
	    /// Item class for Observation.hasMember:abnormalityMass.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:62
	    {                                                                                                                                      // BuildMemberBase.cs:63
	        // Properties                                                                                                                      // BuildMemberBase.cs:64
	        /// <summary>
	        /// Value
	        /// </summary>
	        public AbnormalityMass Value { get; set; }                                                                                         // BuildMemberBase.cs:68
	                                                                                                                                           // BuildMemberBase.cs:70
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(AbnormalityMass value)                                                                                                 // BuildMemberBase.cs:74
	        {                                                                                                                                  // BuildMemberBase.cs:75
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:76
	        }                                                                                                                                  // BuildMemberBase.cs:78
	                                                                                                                                           // BuildMemberBase.cs:80
	        // Methods                                                                                                                         // BuildMemberBase.cs:81
	    }                                                                                                                                      // BuildMemberBase.cs:83
	                                                                                                                                           // BuildMemberBase.cs:113
	    // Properties                                                                                                                          // BuildMemberBase.cs:114
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberReferences.cs:46
	    {                                                                                                                                      // BuildMemberReferences.cs:47
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityMass"                                                      // BuildMemberReferences.cs:54
	    };                                                                                                                                     // BuildMemberReferences.cs:55
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:202
	                                                                                                                                           // BuildMemberBase.cs:204
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:208
	                                                                                                                                           // BuildMemberBase.cs:210
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:214
	                                                                                                                                           // BuildMemberBase.cs:216
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:220
	                                                                                                                                           // BuildMemberBase.cs:222
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<AbnormalityMass> All()                                                                                              // BuildMemberBase.cs:226
	    {                                                                                                                                      // BuildMemberBase.cs:227
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:228
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:229
	    }                                                                                                                                      // BuildMemberBase.cs:230
	                                                                                                                                           // BuildMemberBase.cs:232
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public AbnormalityMass GetAt(Int32 i) => this.items[i].Value;                                                                          // BuildMemberBase.cs:236
	                                                                                                                                           // BuildMemberBase.cs:238
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:242
	                                                                                                                                           // BuildMemberBase.cs:244
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:248
	                                                                                                                                           // BuildMemberBase.cs:116
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public AbnormalityMassContainer(Int32 min, Int32 max) : base("Observation.hasMember:abnormalityMass", min, max)                        // BuildMemberBase.cs:120
	    {                                                                                                                                      // BuildMemberBase.cs:121
	    }                                                                                                                                      // BuildMemberBase.cs:123
	                                                                                                                                           // BuildMemberBase.cs:124
	    // Methods                                                                                                                             // BuildMemberBase.cs:125
	                                                                                                                                           // BuildMemberBase.cs:254
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public AbnormalityMass Append(AbnormalityMass value)                                                                                   // BuildMemberBase.cs:258
	    {                                                                                                                                      // BuildMemberBase.cs:259
	        this.items.Add(new Item(value));                                                                                                   // BuildMemberBase.cs:260
	        return value;                                                                                                                      // BuildMemberBase.cs:261
	    }                                                                                                                                      // BuildMemberBase.cs:262
	                                                                                                                                           // BuildMemberBase.cs:268
	    /// <summary>
	    /// Write single item as a fhir element.
	    /// </summary>
	    public IEnumerable<ResourceReference> Write(BreastRadiologyDocument doc)                                                               // BuildMemberReferences.cs:87
	    {                                                                                                                                      // BuildMemberReferences.cs:88
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberReferences.cs:89
	        {                                                                                                                                  // BuildMemberReferences.cs:90
	            ResourceReference reference = new ResourceReference                                                                            // BuildMemberReferences.cs:91
	            {                                                                                                                              // BuildMemberReferences.cs:92
	                Reference = item.Value.Id                                                                                                  // BuildMemberReferences.cs:93
	            };                                                                                                                             // BuildMemberReferences.cs:94
	            yield return reference;                                                                                                        // BuildMemberReferences.cs:95
	        }                                                                                                                                  // BuildMemberReferences.cs:96
	    }                                                                                                                                      // BuildMemberReferences.cs:97
	                                                                                                                                           // BuildMemberBase.cs:274
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	                                                                                                                                           // BuildMemberReferences.cs:63
	    public void Read(BreastRadiologyDocument doc, IEnumerable<ResourceReference> references)                                               // BuildMemberReferences.cs:64
	    {                                                                                                                                      // BuildMemberReferences.cs:65
	        IEnumerable<ResourceBase> resources = base.IsMember(doc,                                                                           // BuildMemberReferences.cs:66
	            references,                                                                                                                    // BuildMemberReferences.cs:67
	            this.targetUrls);                                                                                                              // BuildMemberReferences.cs:68
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberReferences.cs:69
	        foreach (ResourceBase resource in resources)                                                                                       // BuildMemberReferences.cs:70
	        {                                                                                                                                  // BuildMemberReferences.cs:71
	            Item item = new Item((AbnormalityMass) resource);                                                                              // BuildMemberReferences.cs:72
	            items.Add(item);                                                                                                               // BuildMemberReferences.cs:73
	        }                                                                                                                                  // BuildMemberReferences.cs:74
	        this.SetAllItems(items);                                                                                                           // BuildMemberReferences.cs:75
	    }                                                                                                                                      // BuildMemberReferences.cs:76
	}                                                                                                                                          // BuildMemberBase.cs:127
	/// <summary>
	/// Container class for Observation.hasMember:associatedFeature.
	/// </summary>
	public class AssociatedFeatureContainer : MContainer, ITMItem<ResourceReference>                                                           // BuildMemberBase.cs:110
	{                                                                                                                                          // BuildMemberBase.cs:111
	    /// <summary>
	    /// Item class for Observation.hasMember:associatedFeature.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:62
	    {                                                                                                                                      // BuildMemberBase.cs:63
	        // Properties                                                                                                                      // BuildMemberBase.cs:64
	        /// <summary>
	        /// Value
	        /// </summary>
	        public AssociatedFeature Value { get; set; }                                                                                       // BuildMemberBase.cs:68
	                                                                                                                                           // BuildMemberBase.cs:70
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(AssociatedFeature value)                                                                                               // BuildMemberBase.cs:74
	        {                                                                                                                                  // BuildMemberBase.cs:75
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:76
	        }                                                                                                                                  // BuildMemberBase.cs:78
	                                                                                                                                           // BuildMemberBase.cs:80
	        // Methods                                                                                                                         // BuildMemberBase.cs:81
	    }                                                                                                                                      // BuildMemberBase.cs:83
	                                                                                                                                           // BuildMemberBase.cs:113
	    // Properties                                                                                                                          // BuildMemberBase.cs:114
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberReferences.cs:46
	    {                                                                                                                                      // BuildMemberReferences.cs:47
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AssociatedFeature"                                                    // BuildMemberReferences.cs:54
	    };                                                                                                                                     // BuildMemberReferences.cs:55
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:202
	                                                                                                                                           // BuildMemberBase.cs:204
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:208
	                                                                                                                                           // BuildMemberBase.cs:210
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:214
	                                                                                                                                           // BuildMemberBase.cs:216
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:220
	                                                                                                                                           // BuildMemberBase.cs:222
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<AssociatedFeature> All()                                                                                            // BuildMemberBase.cs:226
	    {                                                                                                                                      // BuildMemberBase.cs:227
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:228
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:229
	    }                                                                                                                                      // BuildMemberBase.cs:230
	                                                                                                                                           // BuildMemberBase.cs:232
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public AssociatedFeature GetAt(Int32 i) => this.items[i].Value;                                                                        // BuildMemberBase.cs:236
	                                                                                                                                           // BuildMemberBase.cs:238
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:242
	                                                                                                                                           // BuildMemberBase.cs:244
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:248
	                                                                                                                                           // BuildMemberBase.cs:116
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public AssociatedFeatureContainer(Int32 min, Int32 max) : base("Observation.hasMember:associatedFeature", min, max)                    // BuildMemberBase.cs:120
	    {                                                                                                                                      // BuildMemberBase.cs:121
	    }                                                                                                                                      // BuildMemberBase.cs:123
	                                                                                                                                           // BuildMemberBase.cs:124
	    // Methods                                                                                                                             // BuildMemberBase.cs:125
	                                                                                                                                           // BuildMemberBase.cs:254
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public AssociatedFeature Append(AssociatedFeature value)                                                                               // BuildMemberBase.cs:258
	    {                                                                                                                                      // BuildMemberBase.cs:259
	        this.items.Add(new Item(value));                                                                                                   // BuildMemberBase.cs:260
	        return value;                                                                                                                      // BuildMemberBase.cs:261
	    }                                                                                                                                      // BuildMemberBase.cs:262
	                                                                                                                                           // BuildMemberBase.cs:268
	    /// <summary>
	    /// Write single item as a fhir element.
	    /// </summary>
	    public IEnumerable<ResourceReference> Write(BreastRadiologyDocument doc)                                                               // BuildMemberReferences.cs:87
	    {                                                                                                                                      // BuildMemberReferences.cs:88
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberReferences.cs:89
	        {                                                                                                                                  // BuildMemberReferences.cs:90
	            ResourceReference reference = new ResourceReference                                                                            // BuildMemberReferences.cs:91
	            {                                                                                                                              // BuildMemberReferences.cs:92
	                Reference = item.Value.Id                                                                                                  // BuildMemberReferences.cs:93
	            };                                                                                                                             // BuildMemberReferences.cs:94
	            yield return reference;                                                                                                        // BuildMemberReferences.cs:95
	        }                                                                                                                                  // BuildMemberReferences.cs:96
	    }                                                                                                                                      // BuildMemberReferences.cs:97
	                                                                                                                                           // BuildMemberBase.cs:274
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	                                                                                                                                           // BuildMemberReferences.cs:63
	    public void Read(BreastRadiologyDocument doc, IEnumerable<ResourceReference> references)                                               // BuildMemberReferences.cs:64
	    {                                                                                                                                      // BuildMemberReferences.cs:65
	        IEnumerable<ResourceBase> resources = base.IsMember(doc,                                                                           // BuildMemberReferences.cs:66
	            references,                                                                                                                    // BuildMemberReferences.cs:67
	            this.targetUrls);                                                                                                              // BuildMemberReferences.cs:68
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberReferences.cs:69
	        foreach (ResourceBase resource in resources)                                                                                       // BuildMemberReferences.cs:70
	        {                                                                                                                                  // BuildMemberReferences.cs:71
	            Item item = new Item((AssociatedFeature) resource);                                                                            // BuildMemberReferences.cs:72
	            items.Add(item);                                                                                                               // BuildMemberReferences.cs:73
	        }                                                                                                                                  // BuildMemberReferences.cs:74
	        this.SetAllItems(items);                                                                                                           // BuildMemberReferences.cs:75
	    }                                                                                                                                      // BuildMemberReferences.cs:76
	}                                                                                                                                          // BuildMemberBase.cs:127
	/// <summary>
	/// Container class for Observation.hasMember:abnormalityFibroadenoma.
	/// </summary>
	public class AbnormalityFibroadenomaContainer : MContainer, ITMItem<ResourceReference>                                                     // BuildMemberBase.cs:110
	{                                                                                                                                          // BuildMemberBase.cs:111
	    /// <summary>
	    /// Item class for Observation.hasMember:abnormalityFibroadenoma.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:62
	    {                                                                                                                                      // BuildMemberBase.cs:63
	        // Properties                                                                                                                      // BuildMemberBase.cs:64
	        /// <summary>
	        /// Value
	        /// </summary>
	        public AbnormalityFibroadenoma Value { get; set; }                                                                                 // BuildMemberBase.cs:68
	                                                                                                                                           // BuildMemberBase.cs:70
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(AbnormalityFibroadenoma value)                                                                                         // BuildMemberBase.cs:74
	        {                                                                                                                                  // BuildMemberBase.cs:75
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:76
	        }                                                                                                                                  // BuildMemberBase.cs:78
	                                                                                                                                           // BuildMemberBase.cs:80
	        // Methods                                                                                                                         // BuildMemberBase.cs:81
	    }                                                                                                                                      // BuildMemberBase.cs:83
	                                                                                                                                           // BuildMemberBase.cs:113
	    // Properties                                                                                                                          // BuildMemberBase.cs:114
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberReferences.cs:46
	    {                                                                                                                                      // BuildMemberReferences.cs:47
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityFibroadenoma"                                              // BuildMemberReferences.cs:54
	    };                                                                                                                                     // BuildMemberReferences.cs:55
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:202
	                                                                                                                                           // BuildMemberBase.cs:204
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:208
	                                                                                                                                           // BuildMemberBase.cs:210
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:214
	                                                                                                                                           // BuildMemberBase.cs:216
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:220
	                                                                                                                                           // BuildMemberBase.cs:222
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<AbnormalityFibroadenoma> All()                                                                                      // BuildMemberBase.cs:226
	    {                                                                                                                                      // BuildMemberBase.cs:227
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:228
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:229
	    }                                                                                                                                      // BuildMemberBase.cs:230
	                                                                                                                                           // BuildMemberBase.cs:232
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public AbnormalityFibroadenoma GetAt(Int32 i) => this.items[i].Value;                                                                  // BuildMemberBase.cs:236
	                                                                                                                                           // BuildMemberBase.cs:238
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:242
	                                                                                                                                           // BuildMemberBase.cs:244
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:248
	                                                                                                                                           // BuildMemberBase.cs:116
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public AbnormalityFibroadenomaContainer(Int32 min, Int32 max) : base("Observation.hasMember:abnormalityFibroadenoma", min, max)        // BuildMemberBase.cs:120
	    {                                                                                                                                      // BuildMemberBase.cs:121
	    }                                                                                                                                      // BuildMemberBase.cs:123
	                                                                                                                                           // BuildMemberBase.cs:124
	    // Methods                                                                                                                             // BuildMemberBase.cs:125
	                                                                                                                                           // BuildMemberBase.cs:254
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public AbnormalityFibroadenoma Append(AbnormalityFibroadenoma value)                                                                   // BuildMemberBase.cs:258
	    {                                                                                                                                      // BuildMemberBase.cs:259
	        this.items.Add(new Item(value));                                                                                                   // BuildMemberBase.cs:260
	        return value;                                                                                                                      // BuildMemberBase.cs:261
	    }                                                                                                                                      // BuildMemberBase.cs:262
	                                                                                                                                           // BuildMemberBase.cs:268
	    /// <summary>
	    /// Write single item as a fhir element.
	    /// </summary>
	    public IEnumerable<ResourceReference> Write(BreastRadiologyDocument doc)                                                               // BuildMemberReferences.cs:87
	    {                                                                                                                                      // BuildMemberReferences.cs:88
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberReferences.cs:89
	        {                                                                                                                                  // BuildMemberReferences.cs:90
	            ResourceReference reference = new ResourceReference                                                                            // BuildMemberReferences.cs:91
	            {                                                                                                                              // BuildMemberReferences.cs:92
	                Reference = item.Value.Id                                                                                                  // BuildMemberReferences.cs:93
	            };                                                                                                                             // BuildMemberReferences.cs:94
	            yield return reference;                                                                                                        // BuildMemberReferences.cs:95
	        }                                                                                                                                  // BuildMemberReferences.cs:96
	    }                                                                                                                                      // BuildMemberReferences.cs:97
	                                                                                                                                           // BuildMemberBase.cs:274
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	                                                                                                                                           // BuildMemberReferences.cs:63
	    public void Read(BreastRadiologyDocument doc, IEnumerable<ResourceReference> references)                                               // BuildMemberReferences.cs:64
	    {                                                                                                                                      // BuildMemberReferences.cs:65
	        IEnumerable<ResourceBase> resources = base.IsMember(doc,                                                                           // BuildMemberReferences.cs:66
	            references,                                                                                                                    // BuildMemberReferences.cs:67
	            this.targetUrls);                                                                                                              // BuildMemberReferences.cs:68
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberReferences.cs:69
	        foreach (ResourceBase resource in resources)                                                                                       // BuildMemberReferences.cs:70
	        {                                                                                                                                  // BuildMemberReferences.cs:71
	            Item item = new Item((AbnormalityFibroadenoma) resource);                                                                      // BuildMemberReferences.cs:72
	            items.Add(item);                                                                                                               // BuildMemberReferences.cs:73
	        }                                                                                                                                  // BuildMemberReferences.cs:74
	        this.SetAllItems(items);                                                                                                           // BuildMemberReferences.cs:75
	    }                                                                                                                                      // BuildMemberReferences.cs:76
	}                                                                                                                                          // BuildMemberBase.cs:127
	/// <summary>
	/// Container class for Observation.hasMember:mGAbnormalityArchitecturalDistortion.
	/// </summary>
	public class MGAbnormalityArchitecturalDistortionContainer : MContainer, ITMItem<ResourceReference>                                        // BuildMemberBase.cs:110
	{                                                                                                                                          // BuildMemberBase.cs:111
	    /// <summary>
	    /// Item class for Observation.hasMember:mGAbnormalityArchitecturalDistortion.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:62
	    {                                                                                                                                      // BuildMemberBase.cs:63
	        // Properties                                                                                                                      // BuildMemberBase.cs:64
	        /// <summary>
	        /// Value
	        /// </summary>
	        public MGAbnormalityArchitecturalDistortion Value { get; set; }                                                                    // BuildMemberBase.cs:68
	                                                                                                                                           // BuildMemberBase.cs:70
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(MGAbnormalityArchitecturalDistortion value)                                                                            // BuildMemberBase.cs:74
	        {                                                                                                                                  // BuildMemberBase.cs:75
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:76
	        }                                                                                                                                  // BuildMemberBase.cs:78
	                                                                                                                                           // BuildMemberBase.cs:80
	        // Methods                                                                                                                         // BuildMemberBase.cs:81
	    }                                                                                                                                      // BuildMemberBase.cs:83
	                                                                                                                                           // BuildMemberBase.cs:113
	    // Properties                                                                                                                          // BuildMemberBase.cs:114
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberReferences.cs:46
	    {                                                                                                                                      // BuildMemberReferences.cs:47
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityArchitecturalDistortion"                                 // BuildMemberReferences.cs:54
	    };                                                                                                                                     // BuildMemberReferences.cs:55
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:202
	                                                                                                                                           // BuildMemberBase.cs:204
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:208
	                                                                                                                                           // BuildMemberBase.cs:210
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:214
	                                                                                                                                           // BuildMemberBase.cs:216
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:220
	                                                                                                                                           // BuildMemberBase.cs:222
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<MGAbnormalityArchitecturalDistortion> All()                                                                         // BuildMemberBase.cs:226
	    {                                                                                                                                      // BuildMemberBase.cs:227
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:228
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:229
	    }                                                                                                                                      // BuildMemberBase.cs:230
	                                                                                                                                           // BuildMemberBase.cs:232
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public MGAbnormalityArchitecturalDistortion GetAt(Int32 i) => this.items[i].Value;                                                     // BuildMemberBase.cs:236
	                                                                                                                                           // BuildMemberBase.cs:238
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:242
	                                                                                                                                           // BuildMemberBase.cs:244
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:248
	                                                                                                                                           // BuildMemberBase.cs:116
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public MGAbnormalityArchitecturalDistortionContainer(Int32 min, Int32 max) : base("Observation.hasMember:mGAbnormalityArchitecturalDistortion", min, max)// BuildMemberBase.cs:120
	    {                                                                                                                                      // BuildMemberBase.cs:121
	    }                                                                                                                                      // BuildMemberBase.cs:123
	                                                                                                                                           // BuildMemberBase.cs:124
	    // Methods                                                                                                                             // BuildMemberBase.cs:125
	                                                                                                                                           // BuildMemberBase.cs:254
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public MGAbnormalityArchitecturalDistortion Append(MGAbnormalityArchitecturalDistortion value)                                         // BuildMemberBase.cs:258
	    {                                                                                                                                      // BuildMemberBase.cs:259
	        this.items.Add(new Item(value));                                                                                                   // BuildMemberBase.cs:260
	        return value;                                                                                                                      // BuildMemberBase.cs:261
	    }                                                                                                                                      // BuildMemberBase.cs:262
	                                                                                                                                           // BuildMemberBase.cs:268
	    /// <summary>
	    /// Write single item as a fhir element.
	    /// </summary>
	    public IEnumerable<ResourceReference> Write(BreastRadiologyDocument doc)                                                               // BuildMemberReferences.cs:87
	    {                                                                                                                                      // BuildMemberReferences.cs:88
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberReferences.cs:89
	        {                                                                                                                                  // BuildMemberReferences.cs:90
	            ResourceReference reference = new ResourceReference                                                                            // BuildMemberReferences.cs:91
	            {                                                                                                                              // BuildMemberReferences.cs:92
	                Reference = item.Value.Id                                                                                                  // BuildMemberReferences.cs:93
	            };                                                                                                                             // BuildMemberReferences.cs:94
	            yield return reference;                                                                                                        // BuildMemberReferences.cs:95
	        }                                                                                                                                  // BuildMemberReferences.cs:96
	    }                                                                                                                                      // BuildMemberReferences.cs:97
	                                                                                                                                           // BuildMemberBase.cs:274
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	                                                                                                                                           // BuildMemberReferences.cs:63
	    public void Read(BreastRadiologyDocument doc, IEnumerable<ResourceReference> references)                                               // BuildMemberReferences.cs:64
	    {                                                                                                                                      // BuildMemberReferences.cs:65
	        IEnumerable<ResourceBase> resources = base.IsMember(doc,                                                                           // BuildMemberReferences.cs:66
	            references,                                                                                                                    // BuildMemberReferences.cs:67
	            this.targetUrls);                                                                                                              // BuildMemberReferences.cs:68
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberReferences.cs:69
	        foreach (ResourceBase resource in resources)                                                                                       // BuildMemberReferences.cs:70
	        {                                                                                                                                  // BuildMemberReferences.cs:71
	            Item item = new Item((MGAbnormalityArchitecturalDistortion) resource);                                                         // BuildMemberReferences.cs:72
	            items.Add(item);                                                                                                               // BuildMemberReferences.cs:73
	        }                                                                                                                                  // BuildMemberReferences.cs:74
	        this.SetAllItems(items);                                                                                                           // BuildMemberReferences.cs:75
	    }                                                                                                                                      // BuildMemberReferences.cs:76
	}                                                                                                                                          // BuildMemberBase.cs:127
	/// <summary>
	/// Container class for Observation.hasMember:mGAbnormalityAsymmetry.
	/// </summary>
	public class MGAbnormalityAsymmetryContainer : MContainer, ITMItem<ResourceReference>                                                      // BuildMemberBase.cs:110
	{                                                                                                                                          // BuildMemberBase.cs:111
	    /// <summary>
	    /// Item class for Observation.hasMember:mGAbnormalityAsymmetry.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:62
	    {                                                                                                                                      // BuildMemberBase.cs:63
	        // Properties                                                                                                                      // BuildMemberBase.cs:64
	        /// <summary>
	        /// Value
	        /// </summary>
	        public MGAbnormalityAsymmetry Value { get; set; }                                                                                  // BuildMemberBase.cs:68
	                                                                                                                                           // BuildMemberBase.cs:70
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(MGAbnormalityAsymmetry value)                                                                                          // BuildMemberBase.cs:74
	        {                                                                                                                                  // BuildMemberBase.cs:75
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:76
	        }                                                                                                                                  // BuildMemberBase.cs:78
	                                                                                                                                           // BuildMemberBase.cs:80
	        // Methods                                                                                                                         // BuildMemberBase.cs:81
	    }                                                                                                                                      // BuildMemberBase.cs:83
	                                                                                                                                           // BuildMemberBase.cs:113
	    // Properties                                                                                                                          // BuildMemberBase.cs:114
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberReferences.cs:46
	    {                                                                                                                                      // BuildMemberReferences.cs:47
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityAsymmetry"                                               // BuildMemberReferences.cs:54
	    };                                                                                                                                     // BuildMemberReferences.cs:55
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:202
	                                                                                                                                           // BuildMemberBase.cs:204
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:208
	                                                                                                                                           // BuildMemberBase.cs:210
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:214
	                                                                                                                                           // BuildMemberBase.cs:216
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:220
	                                                                                                                                           // BuildMemberBase.cs:222
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<MGAbnormalityAsymmetry> All()                                                                                       // BuildMemberBase.cs:226
	    {                                                                                                                                      // BuildMemberBase.cs:227
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:228
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:229
	    }                                                                                                                                      // BuildMemberBase.cs:230
	                                                                                                                                           // BuildMemberBase.cs:232
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public MGAbnormalityAsymmetry GetAt(Int32 i) => this.items[i].Value;                                                                   // BuildMemberBase.cs:236
	                                                                                                                                           // BuildMemberBase.cs:238
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:242
	                                                                                                                                           // BuildMemberBase.cs:244
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:248
	                                                                                                                                           // BuildMemberBase.cs:116
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public MGAbnormalityAsymmetryContainer(Int32 min, Int32 max) : base("Observation.hasMember:mGAbnormalityAsymmetry", min, max)          // BuildMemberBase.cs:120
	    {                                                                                                                                      // BuildMemberBase.cs:121
	    }                                                                                                                                      // BuildMemberBase.cs:123
	                                                                                                                                           // BuildMemberBase.cs:124
	    // Methods                                                                                                                             // BuildMemberBase.cs:125
	                                                                                                                                           // BuildMemberBase.cs:254
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public MGAbnormalityAsymmetry Append(MGAbnormalityAsymmetry value)                                                                     // BuildMemberBase.cs:258
	    {                                                                                                                                      // BuildMemberBase.cs:259
	        this.items.Add(new Item(value));                                                                                                   // BuildMemberBase.cs:260
	        return value;                                                                                                                      // BuildMemberBase.cs:261
	    }                                                                                                                                      // BuildMemberBase.cs:262
	                                                                                                                                           // BuildMemberBase.cs:268
	    /// <summary>
	    /// Write single item as a fhir element.
	    /// </summary>
	    public IEnumerable<ResourceReference> Write(BreastRadiologyDocument doc)                                                               // BuildMemberReferences.cs:87
	    {                                                                                                                                      // BuildMemberReferences.cs:88
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberReferences.cs:89
	        {                                                                                                                                  // BuildMemberReferences.cs:90
	            ResourceReference reference = new ResourceReference                                                                            // BuildMemberReferences.cs:91
	            {                                                                                                                              // BuildMemberReferences.cs:92
	                Reference = item.Value.Id                                                                                                  // BuildMemberReferences.cs:93
	            };                                                                                                                             // BuildMemberReferences.cs:94
	            yield return reference;                                                                                                        // BuildMemberReferences.cs:95
	        }                                                                                                                                  // BuildMemberReferences.cs:96
	    }                                                                                                                                      // BuildMemberReferences.cs:97
	                                                                                                                                           // BuildMemberBase.cs:274
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	                                                                                                                                           // BuildMemberReferences.cs:63
	    public void Read(BreastRadiologyDocument doc, IEnumerable<ResourceReference> references)                                               // BuildMemberReferences.cs:64
	    {                                                                                                                                      // BuildMemberReferences.cs:65
	        IEnumerable<ResourceBase> resources = base.IsMember(doc,                                                                           // BuildMemberReferences.cs:66
	            references,                                                                                                                    // BuildMemberReferences.cs:67
	            this.targetUrls);                                                                                                              // BuildMemberReferences.cs:68
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberReferences.cs:69
	        foreach (ResourceBase resource in resources)                                                                                       // BuildMemberReferences.cs:70
	        {                                                                                                                                  // BuildMemberReferences.cs:71
	            Item item = new Item((MGAbnormalityAsymmetry) resource);                                                                       // BuildMemberReferences.cs:72
	            items.Add(item);                                                                                                               // BuildMemberReferences.cs:73
	        }                                                                                                                                  // BuildMemberReferences.cs:74
	        this.SetAllItems(items);                                                                                                           // BuildMemberReferences.cs:75
	    }                                                                                                                                      // BuildMemberReferences.cs:76
	}                                                                                                                                          // BuildMemberBase.cs:127
	/// <summary>
	/// Container class for Observation.hasMember:mGAbnormalityCalcification.
	/// </summary>
	public class MGAbnormalityCalcificationContainer : MContainer, ITMItem<ResourceReference>                                                  // BuildMemberBase.cs:110
	{                                                                                                                                          // BuildMemberBase.cs:111
	    /// <summary>
	    /// Item class for Observation.hasMember:mGAbnormalityCalcification.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:62
	    {                                                                                                                                      // BuildMemberBase.cs:63
	        // Properties                                                                                                                      // BuildMemberBase.cs:64
	        /// <summary>
	        /// Value
	        /// </summary>
	        public MGAbnormalityCalcification Value { get; set; }                                                                              // BuildMemberBase.cs:68
	                                                                                                                                           // BuildMemberBase.cs:70
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(MGAbnormalityCalcification value)                                                                                      // BuildMemberBase.cs:74
	        {                                                                                                                                  // BuildMemberBase.cs:75
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:76
	        }                                                                                                                                  // BuildMemberBase.cs:78
	                                                                                                                                           // BuildMemberBase.cs:80
	        // Methods                                                                                                                         // BuildMemberBase.cs:81
	    }                                                                                                                                      // BuildMemberBase.cs:83
	                                                                                                                                           // BuildMemberBase.cs:113
	    // Properties                                                                                                                          // BuildMemberBase.cs:114
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberReferences.cs:46
	    {                                                                                                                                      // BuildMemberReferences.cs:47
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityCalcification"                                           // BuildMemberReferences.cs:54
	    };                                                                                                                                     // BuildMemberReferences.cs:55
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:202
	                                                                                                                                           // BuildMemberBase.cs:204
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:208
	                                                                                                                                           // BuildMemberBase.cs:210
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:214
	                                                                                                                                           // BuildMemberBase.cs:216
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:220
	                                                                                                                                           // BuildMemberBase.cs:222
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<MGAbnormalityCalcification> All()                                                                                   // BuildMemberBase.cs:226
	    {                                                                                                                                      // BuildMemberBase.cs:227
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:228
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:229
	    }                                                                                                                                      // BuildMemberBase.cs:230
	                                                                                                                                           // BuildMemberBase.cs:232
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public MGAbnormalityCalcification GetAt(Int32 i) => this.items[i].Value;                                                               // BuildMemberBase.cs:236
	                                                                                                                                           // BuildMemberBase.cs:238
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:242
	                                                                                                                                           // BuildMemberBase.cs:244
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:248
	                                                                                                                                           // BuildMemberBase.cs:116
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public MGAbnormalityCalcificationContainer(Int32 min, Int32 max) : base("Observation.hasMember:mGAbnormalityCalcification", min, max)  // BuildMemberBase.cs:120
	    {                                                                                                                                      // BuildMemberBase.cs:121
	    }                                                                                                                                      // BuildMemberBase.cs:123
	                                                                                                                                           // BuildMemberBase.cs:124
	    // Methods                                                                                                                             // BuildMemberBase.cs:125
	                                                                                                                                           // BuildMemberBase.cs:254
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public MGAbnormalityCalcification Append(MGAbnormalityCalcification value)                                                             // BuildMemberBase.cs:258
	    {                                                                                                                                      // BuildMemberBase.cs:259
	        this.items.Add(new Item(value));                                                                                                   // BuildMemberBase.cs:260
	        return value;                                                                                                                      // BuildMemberBase.cs:261
	    }                                                                                                                                      // BuildMemberBase.cs:262
	                                                                                                                                           // BuildMemberBase.cs:268
	    /// <summary>
	    /// Write single item as a fhir element.
	    /// </summary>
	    public IEnumerable<ResourceReference> Write(BreastRadiologyDocument doc)                                                               // BuildMemberReferences.cs:87
	    {                                                                                                                                      // BuildMemberReferences.cs:88
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberReferences.cs:89
	        {                                                                                                                                  // BuildMemberReferences.cs:90
	            ResourceReference reference = new ResourceReference                                                                            // BuildMemberReferences.cs:91
	            {                                                                                                                              // BuildMemberReferences.cs:92
	                Reference = item.Value.Id                                                                                                  // BuildMemberReferences.cs:93
	            };                                                                                                                             // BuildMemberReferences.cs:94
	            yield return reference;                                                                                                        // BuildMemberReferences.cs:95
	        }                                                                                                                                  // BuildMemberReferences.cs:96
	    }                                                                                                                                      // BuildMemberReferences.cs:97
	                                                                                                                                           // BuildMemberBase.cs:274
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	                                                                                                                                           // BuildMemberReferences.cs:63
	    public void Read(BreastRadiologyDocument doc, IEnumerable<ResourceReference> references)                                               // BuildMemberReferences.cs:64
	    {                                                                                                                                      // BuildMemberReferences.cs:65
	        IEnumerable<ResourceBase> resources = base.IsMember(doc,                                                                           // BuildMemberReferences.cs:66
	            references,                                                                                                                    // BuildMemberReferences.cs:67
	            this.targetUrls);                                                                                                              // BuildMemberReferences.cs:68
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberReferences.cs:69
	        foreach (ResourceBase resource in resources)                                                                                       // BuildMemberReferences.cs:70
	        {                                                                                                                                  // BuildMemberReferences.cs:71
	            Item item = new Item((MGAbnormalityCalcification) resource);                                                                   // BuildMemberReferences.cs:72
	            items.Add(item);                                                                                                               // BuildMemberReferences.cs:73
	        }                                                                                                                                  // BuildMemberReferences.cs:74
	        this.SetAllItems(items);                                                                                                           // BuildMemberReferences.cs:75
	    }                                                                                                                                      // BuildMemberReferences.cs:76
	}                                                                                                                                          // BuildMemberBase.cs:127
	/// <summary>
	/// Container class for Observation.hasMember:mGAbnormalityDensity.
	/// </summary>
	public class MGAbnormalityDensityContainer : MContainer, ITMItem<ResourceReference>                                                        // BuildMemberBase.cs:110
	{                                                                                                                                          // BuildMemberBase.cs:111
	    /// <summary>
	    /// Item class for Observation.hasMember:mGAbnormalityDensity.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:62
	    {                                                                                                                                      // BuildMemberBase.cs:63
	        // Properties                                                                                                                      // BuildMemberBase.cs:64
	        /// <summary>
	        /// Value
	        /// </summary>
	        public MGAbnormalityDensity Value { get; set; }                                                                                    // BuildMemberBase.cs:68
	                                                                                                                                           // BuildMemberBase.cs:70
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(MGAbnormalityDensity value)                                                                                            // BuildMemberBase.cs:74
	        {                                                                                                                                  // BuildMemberBase.cs:75
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:76
	        }                                                                                                                                  // BuildMemberBase.cs:78
	                                                                                                                                           // BuildMemberBase.cs:80
	        // Methods                                                                                                                         // BuildMemberBase.cs:81
	    }                                                                                                                                      // BuildMemberBase.cs:83
	                                                                                                                                           // BuildMemberBase.cs:113
	    // Properties                                                                                                                          // BuildMemberBase.cs:114
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberReferences.cs:46
	    {                                                                                                                                      // BuildMemberReferences.cs:47
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityDensity"                                                 // BuildMemberReferences.cs:54
	    };                                                                                                                                     // BuildMemberReferences.cs:55
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:202
	                                                                                                                                           // BuildMemberBase.cs:204
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:208
	                                                                                                                                           // BuildMemberBase.cs:210
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:214
	                                                                                                                                           // BuildMemberBase.cs:216
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:220
	                                                                                                                                           // BuildMemberBase.cs:222
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<MGAbnormalityDensity> All()                                                                                         // BuildMemberBase.cs:226
	    {                                                                                                                                      // BuildMemberBase.cs:227
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:228
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:229
	    }                                                                                                                                      // BuildMemberBase.cs:230
	                                                                                                                                           // BuildMemberBase.cs:232
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public MGAbnormalityDensity GetAt(Int32 i) => this.items[i].Value;                                                                     // BuildMemberBase.cs:236
	                                                                                                                                           // BuildMemberBase.cs:238
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:242
	                                                                                                                                           // BuildMemberBase.cs:244
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:248
	                                                                                                                                           // BuildMemberBase.cs:116
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public MGAbnormalityDensityContainer(Int32 min, Int32 max) : base("Observation.hasMember:mGAbnormalityDensity", min, max)              // BuildMemberBase.cs:120
	    {                                                                                                                                      // BuildMemberBase.cs:121
	    }                                                                                                                                      // BuildMemberBase.cs:123
	                                                                                                                                           // BuildMemberBase.cs:124
	    // Methods                                                                                                                             // BuildMemberBase.cs:125
	                                                                                                                                           // BuildMemberBase.cs:254
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public MGAbnormalityDensity Append(MGAbnormalityDensity value)                                                                         // BuildMemberBase.cs:258
	    {                                                                                                                                      // BuildMemberBase.cs:259
	        this.items.Add(new Item(value));                                                                                                   // BuildMemberBase.cs:260
	        return value;                                                                                                                      // BuildMemberBase.cs:261
	    }                                                                                                                                      // BuildMemberBase.cs:262
	                                                                                                                                           // BuildMemberBase.cs:268
	    /// <summary>
	    /// Write single item as a fhir element.
	    /// </summary>
	    public IEnumerable<ResourceReference> Write(BreastRadiologyDocument doc)                                                               // BuildMemberReferences.cs:87
	    {                                                                                                                                      // BuildMemberReferences.cs:88
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberReferences.cs:89
	        {                                                                                                                                  // BuildMemberReferences.cs:90
	            ResourceReference reference = new ResourceReference                                                                            // BuildMemberReferences.cs:91
	            {                                                                                                                              // BuildMemberReferences.cs:92
	                Reference = item.Value.Id                                                                                                  // BuildMemberReferences.cs:93
	            };                                                                                                                             // BuildMemberReferences.cs:94
	            yield return reference;                                                                                                        // BuildMemberReferences.cs:95
	        }                                                                                                                                  // BuildMemberReferences.cs:96
	    }                                                                                                                                      // BuildMemberReferences.cs:97
	                                                                                                                                           // BuildMemberBase.cs:274
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	                                                                                                                                           // BuildMemberReferences.cs:63
	    public void Read(BreastRadiologyDocument doc, IEnumerable<ResourceReference> references)                                               // BuildMemberReferences.cs:64
	    {                                                                                                                                      // BuildMemberReferences.cs:65
	        IEnumerable<ResourceBase> resources = base.IsMember(doc,                                                                           // BuildMemberReferences.cs:66
	            references,                                                                                                                    // BuildMemberReferences.cs:67
	            this.targetUrls);                                                                                                              // BuildMemberReferences.cs:68
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberReferences.cs:69
	        foreach (ResourceBase resource in resources)                                                                                       // BuildMemberReferences.cs:70
	        {                                                                                                                                  // BuildMemberReferences.cs:71
	            Item item = new Item((MGAbnormalityDensity) resource);                                                                         // BuildMemberReferences.cs:72
	            items.Add(item);                                                                                                               // BuildMemberReferences.cs:73
	        }                                                                                                                                  // BuildMemberReferences.cs:74
	        this.SetAllItems(items);                                                                                                           // BuildMemberReferences.cs:75
	    }                                                                                                                                      // BuildMemberReferences.cs:76
	}                                                                                                                                          // BuildMemberBase.cs:127
	/// <summary>
	/// Container class for Observation.hasMember:mGAbnormalityFatNecrosis.
	/// </summary>
	public class MGAbnormalityFatNecrosisContainer : MContainer, ITMItem<ResourceReference>                                                    // BuildMemberBase.cs:110
	{                                                                                                                                          // BuildMemberBase.cs:111
	    /// <summary>
	    /// Item class for Observation.hasMember:mGAbnormalityFatNecrosis.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:62
	    {                                                                                                                                      // BuildMemberBase.cs:63
	        // Properties                                                                                                                      // BuildMemberBase.cs:64
	        /// <summary>
	        /// Value
	        /// </summary>
	        public MGAbnormalityFatNecrosis Value { get; set; }                                                                                // BuildMemberBase.cs:68
	                                                                                                                                           // BuildMemberBase.cs:70
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(MGAbnormalityFatNecrosis value)                                                                                        // BuildMemberBase.cs:74
	        {                                                                                                                                  // BuildMemberBase.cs:75
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:76
	        }                                                                                                                                  // BuildMemberBase.cs:78
	                                                                                                                                           // BuildMemberBase.cs:80
	        // Methods                                                                                                                         // BuildMemberBase.cs:81
	    }                                                                                                                                      // BuildMemberBase.cs:83
	                                                                                                                                           // BuildMemberBase.cs:113
	    // Properties                                                                                                                          // BuildMemberBase.cs:114
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberReferences.cs:46
	    {                                                                                                                                      // BuildMemberReferences.cs:47
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityFatNecrosis"                                             // BuildMemberReferences.cs:54
	    };                                                                                                                                     // BuildMemberReferences.cs:55
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:202
	                                                                                                                                           // BuildMemberBase.cs:204
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:208
	                                                                                                                                           // BuildMemberBase.cs:210
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:214
	                                                                                                                                           // BuildMemberBase.cs:216
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:220
	                                                                                                                                           // BuildMemberBase.cs:222
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<MGAbnormalityFatNecrosis> All()                                                                                     // BuildMemberBase.cs:226
	    {                                                                                                                                      // BuildMemberBase.cs:227
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:228
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:229
	    }                                                                                                                                      // BuildMemberBase.cs:230
	                                                                                                                                           // BuildMemberBase.cs:232
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public MGAbnormalityFatNecrosis GetAt(Int32 i) => this.items[i].Value;                                                                 // BuildMemberBase.cs:236
	                                                                                                                                           // BuildMemberBase.cs:238
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:242
	                                                                                                                                           // BuildMemberBase.cs:244
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:248
	                                                                                                                                           // BuildMemberBase.cs:116
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public MGAbnormalityFatNecrosisContainer(Int32 min, Int32 max) : base("Observation.hasMember:mGAbnormalityFatNecrosis", min, max)      // BuildMemberBase.cs:120
	    {                                                                                                                                      // BuildMemberBase.cs:121
	    }                                                                                                                                      // BuildMemberBase.cs:123
	                                                                                                                                           // BuildMemberBase.cs:124
	    // Methods                                                                                                                             // BuildMemberBase.cs:125
	                                                                                                                                           // BuildMemberBase.cs:254
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public MGAbnormalityFatNecrosis Append(MGAbnormalityFatNecrosis value)                                                                 // BuildMemberBase.cs:258
	    {                                                                                                                                      // BuildMemberBase.cs:259
	        this.items.Add(new Item(value));                                                                                                   // BuildMemberBase.cs:260
	        return value;                                                                                                                      // BuildMemberBase.cs:261
	    }                                                                                                                                      // BuildMemberBase.cs:262
	                                                                                                                                           // BuildMemberBase.cs:268
	    /// <summary>
	    /// Write single item as a fhir element.
	    /// </summary>
	    public IEnumerable<ResourceReference> Write(BreastRadiologyDocument doc)                                                               // BuildMemberReferences.cs:87
	    {                                                                                                                                      // BuildMemberReferences.cs:88
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberReferences.cs:89
	        {                                                                                                                                  // BuildMemberReferences.cs:90
	            ResourceReference reference = new ResourceReference                                                                            // BuildMemberReferences.cs:91
	            {                                                                                                                              // BuildMemberReferences.cs:92
	                Reference = item.Value.Id                                                                                                  // BuildMemberReferences.cs:93
	            };                                                                                                                             // BuildMemberReferences.cs:94
	            yield return reference;                                                                                                        // BuildMemberReferences.cs:95
	        }                                                                                                                                  // BuildMemberReferences.cs:96
	    }                                                                                                                                      // BuildMemberReferences.cs:97
	                                                                                                                                           // BuildMemberBase.cs:274
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	                                                                                                                                           // BuildMemberReferences.cs:63
	    public void Read(BreastRadiologyDocument doc, IEnumerable<ResourceReference> references)                                               // BuildMemberReferences.cs:64
	    {                                                                                                                                      // BuildMemberReferences.cs:65
	        IEnumerable<ResourceBase> resources = base.IsMember(doc,                                                                           // BuildMemberReferences.cs:66
	            references,                                                                                                                    // BuildMemberReferences.cs:67
	            this.targetUrls);                                                                                                              // BuildMemberReferences.cs:68
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberReferences.cs:69
	        foreach (ResourceBase resource in resources)                                                                                       // BuildMemberReferences.cs:70
	        {                                                                                                                                  // BuildMemberReferences.cs:71
	            Item item = new Item((MGAbnormalityFatNecrosis) resource);                                                                     // BuildMemberReferences.cs:72
	            items.Add(item);                                                                                                               // BuildMemberReferences.cs:73
	        }                                                                                                                                  // BuildMemberReferences.cs:74
	        this.SetAllItems(items);                                                                                                           // BuildMemberReferences.cs:75
	    }                                                                                                                                      // BuildMemberReferences.cs:76
	}                                                                                                                                          // BuildMemberBase.cs:127
	/// <summary>
	/// Container class for Observation.hasMember:mGBreastDensity.
	/// </summary>
	public class MGBreastDensityContainer : MContainer, ITMItem<ResourceReference>                                                             // BuildMemberBase.cs:110
	{                                                                                                                                          // BuildMemberBase.cs:111
	    /// <summary>
	    /// Item class for Observation.hasMember:mGBreastDensity.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:62
	    {                                                                                                                                      // BuildMemberBase.cs:63
	        // Properties                                                                                                                      // BuildMemberBase.cs:64
	        /// <summary>
	        /// Value
	        /// </summary>
	        public MGBreastDensity Value { get; set; }                                                                                         // BuildMemberBase.cs:68
	                                                                                                                                           // BuildMemberBase.cs:70
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(MGBreastDensity value)                                                                                                 // BuildMemberBase.cs:74
	        {                                                                                                                                  // BuildMemberBase.cs:75
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:76
	        }                                                                                                                                  // BuildMemberBase.cs:78
	                                                                                                                                           // BuildMemberBase.cs:80
	        // Methods                                                                                                                         // BuildMemberBase.cs:81
	    }                                                                                                                                      // BuildMemberBase.cs:83
	                                                                                                                                           // BuildMemberBase.cs:113
	    // Properties                                                                                                                          // BuildMemberBase.cs:114
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberReferences.cs:46
	    {                                                                                                                                      // BuildMemberReferences.cs:47
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGBreastDensity"                                                      // BuildMemberReferences.cs:54
	    };                                                                                                                                     // BuildMemberReferences.cs:55
	                                                                                                                                           // BuildMemberBase.cs:137
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems()                                                                                                        // BuildMemberBase.cs:141
	    {                                                                                                                                      // BuildMemberBase.cs:142
	        if (this.item != null) yield return this.item;                                                                                     // BuildMemberBase.cs:143
	    }                                                                                                                                      // BuildMemberBase.cs:144
	                                                                                                                                           // BuildMemberBase.cs:146
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items)                                                                                              // BuildMemberBase.cs:150
	    {                                                                                                                                      // BuildMemberBase.cs:151
	        switch (items.Count())                                                                                                             // BuildMemberBase.cs:152
	        {                                                                                                                                  // BuildMemberBase.cs:153
	            case 0: break;                                                                                                                 // BuildMemberBase.cs:154
	            case 1: this.item = items.First(); break;                                                                                      // BuildMemberBase.cs:155
	            default: throw new Exception("Found multiple elements while reading single item");                                             // BuildMemberBase.cs:156
	        }                                                                                                                                  // BuildMemberBase.cs:157
	    }                                                                                                                                      // BuildMemberBase.cs:158
	                                                                                                                                           // BuildMemberBase.cs:160
	    /// <summary>
	    /// Item
	    /// </summary>
	    Item item;                                                                                                                             // BuildMemberBase.cs:164
	                                                                                                                                           // BuildMemberBase.cs:166
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => this.item == null ? 0 : 1;                                                                              // BuildMemberBase.cs:170
	                                                                                                                                           // BuildMemberBase.cs:172
	    /// <summary>
	    /// Get Item's Value
	    /// </summary>
	    public MGBreastDensity Get()                                                                                                           // BuildMemberBase.cs:176
	    {                                                                                                                                      // BuildMemberBase.cs:177
	        if (item == null)                                                                                                                  // BuildMemberBase.cs:178
	            return null;                                                                                                                   // BuildMemberBase.cs:179
	        return item.Value;                                                                                                                 // BuildMemberBase.cs:180
	    }                                                                                                                                      // BuildMemberBase.cs:181
	                                                                                                                                           // BuildMemberBase.cs:187
	    /// <summary>
	    /// Set Item's Value
	    /// </summary>
	    public MGBreastDensity Set(MGBreastDensity value)                                                                                      // BuildMemberBase.cs:191
	    {                                                                                                                                      // BuildMemberBase.cs:192
	        this.item = new Item(value);                                                                                                       // BuildMemberBase.cs:193
	        return value;                                                                                                                      // BuildMemberBase.cs:194
	    }                                                                                                                                      // BuildMemberBase.cs:195
	                                                                                                                                           // BuildMemberBase.cs:116
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public MGBreastDensityContainer(Int32 min, Int32 max) : base("Observation.hasMember:mGBreastDensity", min, max)                        // BuildMemberBase.cs:120
	    {                                                                                                                                      // BuildMemberBase.cs:121
	    }                                                                                                                                      // BuildMemberBase.cs:123
	                                                                                                                                           // BuildMemberBase.cs:124
	    // Methods                                                                                                                             // BuildMemberBase.cs:125
	                                                                                                                                           // BuildMemberBase.cs:268
	    /// <summary>
	    /// Write single item as a fhir element.
	    /// </summary>
	    public IEnumerable<ResourceReference> Write(BreastRadiologyDocument doc)                                                               // BuildMemberReferences.cs:87
	    {                                                                                                                                      // BuildMemberReferences.cs:88
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberReferences.cs:89
	        {                                                                                                                                  // BuildMemberReferences.cs:90
	            ResourceReference reference = new ResourceReference                                                                            // BuildMemberReferences.cs:91
	            {                                                                                                                              // BuildMemberReferences.cs:92
	                Reference = item.Value.Id                                                                                                  // BuildMemberReferences.cs:93
	            };                                                                                                                             // BuildMemberReferences.cs:94
	            yield return reference;                                                                                                        // BuildMemberReferences.cs:95
	        }                                                                                                                                  // BuildMemberReferences.cs:96
	    }                                                                                                                                      // BuildMemberReferences.cs:97
	                                                                                                                                           // BuildMemberBase.cs:274
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	                                                                                                                                           // BuildMemberReferences.cs:63
	    public void Read(BreastRadiologyDocument doc, IEnumerable<ResourceReference> references)                                               // BuildMemberReferences.cs:64
	    {                                                                                                                                      // BuildMemberReferences.cs:65
	        IEnumerable<ResourceBase> resources = base.IsMember(doc,                                                                           // BuildMemberReferences.cs:66
	            references,                                                                                                                    // BuildMemberReferences.cs:67
	            this.targetUrls);                                                                                                              // BuildMemberReferences.cs:68
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberReferences.cs:69
	        foreach (ResourceBase resource in resources)                                                                                       // BuildMemberReferences.cs:70
	        {                                                                                                                                  // BuildMemberReferences.cs:71
	            Item item = new Item((MGBreastDensity) resource);                                                                              // BuildMemberReferences.cs:72
	            items.Add(item);                                                                                                               // BuildMemberReferences.cs:73
	        }                                                                                                                                  // BuildMemberReferences.cs:74
	        this.SetAllItems(items);                                                                                                           // BuildMemberReferences.cs:75
	    }                                                                                                                                      // BuildMemberReferences.cs:76
	}                                                                                                                                          // BuildMemberBase.cs:127
	//- LocalClassDefs
}
