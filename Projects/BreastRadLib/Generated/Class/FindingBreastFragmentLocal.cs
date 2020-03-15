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

namespace BreastRadLib.FindingBreastFragmentLocal
{
	//+ LocalClassDefs
	/// <summary>
	/// Container class for Observation.hasMember:mGFinding.
	/// </summary>
	public class MGFindingContainer : MContainer, ITMItem<ResourceReference>                                                                   // BuildMemberBase.cs:137
	{                                                                                                                                          // BuildMemberBase.cs:138
	    /// <summary>
	    /// Item class for Observation.hasMember:mGFinding.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:73
	    {                                                                                                                                      // BuildMemberBase.cs:74
	        // Properties                                                                                                                      // BuildMemberBase.cs:75
	        /// <summary>
	        /// Value
	        /// </summary>
	        public MGFinding Value { get; set; }                                                                                               // BuildMemberBase.cs:79
	                                                                                                                                           // BuildMemberBase.cs:81
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(MGFinding value)                                                                                                       // BuildMemberBase.cs:85
	        {                                                                                                                                  // BuildMemberBase.cs:86
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:87
	        }                                                                                                                                  // BuildMemberBase.cs:89
	                                                                                                                                           // BuildMemberBase.cs:91
	        // Methods                                                                                                                         // BuildMemberBase.cs:92
	    }                                                                                                                                      // BuildMemberBase.cs:94
	                                                                                                                                           // BuildMemberBase.cs:140
	    // Properties                                                                                                                          // BuildMemberBase.cs:141
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:115
	    {                                                                                                                                      // BuildMemberBase.cs:116
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGFinding"                                                            // BuildMemberBase.cs:123
	    };                                                                                                                                     // BuildMemberBase.cs:124
	                                                                                                                                           // BuildMemberBase.cs:162
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems()                                                                                                        // BuildMemberBase.cs:166
	    {                                                                                                                                      // BuildMemberBase.cs:167
	        if (this.item != null) yield return this.item;                                                                                     // BuildMemberBase.cs:168
	    }                                                                                                                                      // BuildMemberBase.cs:169
	                                                                                                                                           // BuildMemberBase.cs:171
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items)                                                                                              // BuildMemberBase.cs:175
	    {                                                                                                                                      // BuildMemberBase.cs:176
	        switch (items.Count())                                                                                                             // BuildMemberBase.cs:177
	        {                                                                                                                                  // BuildMemberBase.cs:178
	            case 0: break;                                                                                                                 // BuildMemberBase.cs:179
	            case 1: this.item = items.First(); break;                                                                                      // BuildMemberBase.cs:180
	            default: throw new Exception("Found multiple elements while reading single item");                                             // BuildMemberBase.cs:181
	        }                                                                                                                                  // BuildMemberBase.cs:182
	    }                                                                                                                                      // BuildMemberBase.cs:183
	                                                                                                                                           // BuildMemberBase.cs:185
	    /// <summary>
	    /// Item
	    /// </summary>
	    Item item;                                                                                                                             // BuildMemberBase.cs:189
	                                                                                                                                           // BuildMemberBase.cs:191
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => this.item == null ? 0 : 1;                                                                              // BuildMemberBase.cs:195
	                                                                                                                                           // BuildMemberBase.cs:197
	    /// <summary>
	    /// Get Item's Value
	    /// </summary>
	    public MGFinding Get()                                                                                                                 // BuildMemberBase.cs:201
	    {                                                                                                                                      // BuildMemberBase.cs:202
	        if (item == null)                                                                                                                  // BuildMemberBase.cs:203
	            return null;                                                                                                                   // BuildMemberBase.cs:204
	        return item.Value;                                                                                                                 // BuildMemberBase.cs:205
	    }                                                                                                                                      // BuildMemberBase.cs:206
	                                                                                                                                           // BuildMemberBase.cs:212
	    /// <summary>
	    /// Set Item's Value
	    /// </summary>
	    public MGFinding Set(MGFinding value)                                                                                                  // BuildMemberBase.cs:216
	    {                                                                                                                                      // BuildMemberBase.cs:217
	        this.item = new Item(value);                                                                                                       // BuildMemberBase.cs:218
	        return value;                                                                                                                      // BuildMemberBase.cs:219
	    }                                                                                                                                      // BuildMemberBase.cs:220
	                                                                                                                                           // BuildMemberBase.cs:143
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public MGFindingContainer(Int32 min, Int32 max) : base("Observation.hasMember:mGFinding", min, max)                                    // BuildMemberBase.cs:147
	    {                                                                                                                                      // BuildMemberBase.cs:148
	    }                                                                                                                                      // BuildMemberBase.cs:150
	                                                                                                                                           // BuildMemberBase.cs:151
	    // Methods                                                                                                                             // BuildMemberBase.cs:152
	                                                                                                                                           // BuildMemberBase.cs:293
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
	                                                                                                                                           // BuildMemberBase.cs:299
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
	            Item item = new Item((MGFinding) resource);                                                                                    // BuildMemberReferences.cs:55
	            items.Add(item);                                                                                                               // BuildMemberReferences.cs:56
	        }                                                                                                                                  // BuildMemberReferences.cs:57
	        this.SetAllItems(items);                                                                                                           // BuildMemberReferences.cs:58
	    }                                                                                                                                      // BuildMemberReferences.cs:59
	}                                                                                                                                          // BuildMemberBase.cs:154
	/// <summary>
	/// Container class for Observation.hasMember:mRIFinding.
	/// </summary>
	public class MRIFindingContainer : MContainer, ITMItem<ResourceReference>                                                                  // BuildMemberBase.cs:137
	{                                                                                                                                          // BuildMemberBase.cs:138
	    /// <summary>
	    /// Item class for Observation.hasMember:mRIFinding.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:73
	    {                                                                                                                                      // BuildMemberBase.cs:74
	        // Properties                                                                                                                      // BuildMemberBase.cs:75
	        /// <summary>
	        /// Value
	        /// </summary>
	        public MRIFinding Value { get; set; }                                                                                              // BuildMemberBase.cs:79
	                                                                                                                                           // BuildMemberBase.cs:81
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(MRIFinding value)                                                                                                      // BuildMemberBase.cs:85
	        {                                                                                                                                  // BuildMemberBase.cs:86
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:87
	        }                                                                                                                                  // BuildMemberBase.cs:89
	                                                                                                                                           // BuildMemberBase.cs:91
	        // Methods                                                                                                                         // BuildMemberBase.cs:92
	    }                                                                                                                                      // BuildMemberBase.cs:94
	                                                                                                                                           // BuildMemberBase.cs:140
	    // Properties                                                                                                                          // BuildMemberBase.cs:141
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:115
	    {                                                                                                                                      // BuildMemberBase.cs:116
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MRIFinding"                                                           // BuildMemberBase.cs:123
	    };                                                                                                                                     // BuildMemberBase.cs:124
	                                                                                                                                           // BuildMemberBase.cs:162
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems()                                                                                                        // BuildMemberBase.cs:166
	    {                                                                                                                                      // BuildMemberBase.cs:167
	        if (this.item != null) yield return this.item;                                                                                     // BuildMemberBase.cs:168
	    }                                                                                                                                      // BuildMemberBase.cs:169
	                                                                                                                                           // BuildMemberBase.cs:171
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items)                                                                                              // BuildMemberBase.cs:175
	    {                                                                                                                                      // BuildMemberBase.cs:176
	        switch (items.Count())                                                                                                             // BuildMemberBase.cs:177
	        {                                                                                                                                  // BuildMemberBase.cs:178
	            case 0: break;                                                                                                                 // BuildMemberBase.cs:179
	            case 1: this.item = items.First(); break;                                                                                      // BuildMemberBase.cs:180
	            default: throw new Exception("Found multiple elements while reading single item");                                             // BuildMemberBase.cs:181
	        }                                                                                                                                  // BuildMemberBase.cs:182
	    }                                                                                                                                      // BuildMemberBase.cs:183
	                                                                                                                                           // BuildMemberBase.cs:185
	    /// <summary>
	    /// Item
	    /// </summary>
	    Item item;                                                                                                                             // BuildMemberBase.cs:189
	                                                                                                                                           // BuildMemberBase.cs:191
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => this.item == null ? 0 : 1;                                                                              // BuildMemberBase.cs:195
	                                                                                                                                           // BuildMemberBase.cs:197
	    /// <summary>
	    /// Get Item's Value
	    /// </summary>
	    public MRIFinding Get()                                                                                                                // BuildMemberBase.cs:201
	    {                                                                                                                                      // BuildMemberBase.cs:202
	        if (item == null)                                                                                                                  // BuildMemberBase.cs:203
	            return null;                                                                                                                   // BuildMemberBase.cs:204
	        return item.Value;                                                                                                                 // BuildMemberBase.cs:205
	    }                                                                                                                                      // BuildMemberBase.cs:206
	                                                                                                                                           // BuildMemberBase.cs:212
	    /// <summary>
	    /// Set Item's Value
	    /// </summary>
	    public MRIFinding Set(MRIFinding value)                                                                                                // BuildMemberBase.cs:216
	    {                                                                                                                                      // BuildMemberBase.cs:217
	        this.item = new Item(value);                                                                                                       // BuildMemberBase.cs:218
	        return value;                                                                                                                      // BuildMemberBase.cs:219
	    }                                                                                                                                      // BuildMemberBase.cs:220
	                                                                                                                                           // BuildMemberBase.cs:143
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public MRIFindingContainer(Int32 min, Int32 max) : base("Observation.hasMember:mRIFinding", min, max)                                  // BuildMemberBase.cs:147
	    {                                                                                                                                      // BuildMemberBase.cs:148
	    }                                                                                                                                      // BuildMemberBase.cs:150
	                                                                                                                                           // BuildMemberBase.cs:151
	    // Methods                                                                                                                             // BuildMemberBase.cs:152
	                                                                                                                                           // BuildMemberBase.cs:293
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
	                                                                                                                                           // BuildMemberBase.cs:299
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
	            Item item = new Item((MRIFinding) resource);                                                                                   // BuildMemberReferences.cs:55
	            items.Add(item);                                                                                                               // BuildMemberReferences.cs:56
	        }                                                                                                                                  // BuildMemberReferences.cs:57
	        this.SetAllItems(items);                                                                                                           // BuildMemberReferences.cs:58
	    }                                                                                                                                      // BuildMemberReferences.cs:59
	}                                                                                                                                          // BuildMemberBase.cs:154
	/// <summary>
	/// Container class for Observation.hasMember:nMFinding.
	/// </summary>
	public class NMFindingContainer : MContainer, ITMItem<ResourceReference>                                                                   // BuildMemberBase.cs:137
	{                                                                                                                                          // BuildMemberBase.cs:138
	    /// <summary>
	    /// Item class for Observation.hasMember:nMFinding.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:73
	    {                                                                                                                                      // BuildMemberBase.cs:74
	        // Properties                                                                                                                      // BuildMemberBase.cs:75
	        /// <summary>
	        /// Value
	        /// </summary>
	        public NMFinding Value { get; set; }                                                                                               // BuildMemberBase.cs:79
	                                                                                                                                           // BuildMemberBase.cs:81
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(NMFinding value)                                                                                                       // BuildMemberBase.cs:85
	        {                                                                                                                                  // BuildMemberBase.cs:86
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:87
	        }                                                                                                                                  // BuildMemberBase.cs:89
	                                                                                                                                           // BuildMemberBase.cs:91
	        // Methods                                                                                                                         // BuildMemberBase.cs:92
	    }                                                                                                                                      // BuildMemberBase.cs:94
	                                                                                                                                           // BuildMemberBase.cs:140
	    // Properties                                                                                                                          // BuildMemberBase.cs:141
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:115
	    {                                                                                                                                      // BuildMemberBase.cs:116
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/NMFinding"                                                            // BuildMemberBase.cs:123
	    };                                                                                                                                     // BuildMemberBase.cs:124
	                                                                                                                                           // BuildMemberBase.cs:162
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems()                                                                                                        // BuildMemberBase.cs:166
	    {                                                                                                                                      // BuildMemberBase.cs:167
	        if (this.item != null) yield return this.item;                                                                                     // BuildMemberBase.cs:168
	    }                                                                                                                                      // BuildMemberBase.cs:169
	                                                                                                                                           // BuildMemberBase.cs:171
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items)                                                                                              // BuildMemberBase.cs:175
	    {                                                                                                                                      // BuildMemberBase.cs:176
	        switch (items.Count())                                                                                                             // BuildMemberBase.cs:177
	        {                                                                                                                                  // BuildMemberBase.cs:178
	            case 0: break;                                                                                                                 // BuildMemberBase.cs:179
	            case 1: this.item = items.First(); break;                                                                                      // BuildMemberBase.cs:180
	            default: throw new Exception("Found multiple elements while reading single item");                                             // BuildMemberBase.cs:181
	        }                                                                                                                                  // BuildMemberBase.cs:182
	    }                                                                                                                                      // BuildMemberBase.cs:183
	                                                                                                                                           // BuildMemberBase.cs:185
	    /// <summary>
	    /// Item
	    /// </summary>
	    Item item;                                                                                                                             // BuildMemberBase.cs:189
	                                                                                                                                           // BuildMemberBase.cs:191
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => this.item == null ? 0 : 1;                                                                              // BuildMemberBase.cs:195
	                                                                                                                                           // BuildMemberBase.cs:197
	    /// <summary>
	    /// Get Item's Value
	    /// </summary>
	    public NMFinding Get()                                                                                                                 // BuildMemberBase.cs:201
	    {                                                                                                                                      // BuildMemberBase.cs:202
	        if (item == null)                                                                                                                  // BuildMemberBase.cs:203
	            return null;                                                                                                                   // BuildMemberBase.cs:204
	        return item.Value;                                                                                                                 // BuildMemberBase.cs:205
	    }                                                                                                                                      // BuildMemberBase.cs:206
	                                                                                                                                           // BuildMemberBase.cs:212
	    /// <summary>
	    /// Set Item's Value
	    /// </summary>
	    public NMFinding Set(NMFinding value)                                                                                                  // BuildMemberBase.cs:216
	    {                                                                                                                                      // BuildMemberBase.cs:217
	        this.item = new Item(value);                                                                                                       // BuildMemberBase.cs:218
	        return value;                                                                                                                      // BuildMemberBase.cs:219
	    }                                                                                                                                      // BuildMemberBase.cs:220
	                                                                                                                                           // BuildMemberBase.cs:143
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public NMFindingContainer(Int32 min, Int32 max) : base("Observation.hasMember:nMFinding", min, max)                                    // BuildMemberBase.cs:147
	    {                                                                                                                                      // BuildMemberBase.cs:148
	    }                                                                                                                                      // BuildMemberBase.cs:150
	                                                                                                                                           // BuildMemberBase.cs:151
	    // Methods                                                                                                                             // BuildMemberBase.cs:152
	                                                                                                                                           // BuildMemberBase.cs:293
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
	                                                                                                                                           // BuildMemberBase.cs:299
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
	            Item item = new Item((NMFinding) resource);                                                                                    // BuildMemberReferences.cs:55
	            items.Add(item);                                                                                                               // BuildMemberReferences.cs:56
	        }                                                                                                                                  // BuildMemberReferences.cs:57
	        this.SetAllItems(items);                                                                                                           // BuildMemberReferences.cs:58
	    }                                                                                                                                      // BuildMemberReferences.cs:59
	}                                                                                                                                          // BuildMemberBase.cs:154
	/// <summary>
	/// Container class for Observation.hasMember:uSFinding.
	/// </summary>
	public class USFindingContainer : MContainer, ITMItem<ResourceReference>                                                                   // BuildMemberBase.cs:137
	{                                                                                                                                          // BuildMemberBase.cs:138
	    /// <summary>
	    /// Item class for Observation.hasMember:uSFinding.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:73
	    {                                                                                                                                      // BuildMemberBase.cs:74
	        // Properties                                                                                                                      // BuildMemberBase.cs:75
	        /// <summary>
	        /// Value
	        /// </summary>
	        public USFinding Value { get; set; }                                                                                               // BuildMemberBase.cs:79
	                                                                                                                                           // BuildMemberBase.cs:81
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(USFinding value)                                                                                                       // BuildMemberBase.cs:85
	        {                                                                                                                                  // BuildMemberBase.cs:86
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:87
	        }                                                                                                                                  // BuildMemberBase.cs:89
	                                                                                                                                           // BuildMemberBase.cs:91
	        // Methods                                                                                                                         // BuildMemberBase.cs:92
	    }                                                                                                                                      // BuildMemberBase.cs:94
	                                                                                                                                           // BuildMemberBase.cs:140
	    // Properties                                                                                                                          // BuildMemberBase.cs:141
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:115
	    {                                                                                                                                      // BuildMemberBase.cs:116
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/USFinding"                                                            // BuildMemberBase.cs:123
	    };                                                                                                                                     // BuildMemberBase.cs:124
	                                                                                                                                           // BuildMemberBase.cs:162
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems()                                                                                                        // BuildMemberBase.cs:166
	    {                                                                                                                                      // BuildMemberBase.cs:167
	        if (this.item != null) yield return this.item;                                                                                     // BuildMemberBase.cs:168
	    }                                                                                                                                      // BuildMemberBase.cs:169
	                                                                                                                                           // BuildMemberBase.cs:171
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items)                                                                                              // BuildMemberBase.cs:175
	    {                                                                                                                                      // BuildMemberBase.cs:176
	        switch (items.Count())                                                                                                             // BuildMemberBase.cs:177
	        {                                                                                                                                  // BuildMemberBase.cs:178
	            case 0: break;                                                                                                                 // BuildMemberBase.cs:179
	            case 1: this.item = items.First(); break;                                                                                      // BuildMemberBase.cs:180
	            default: throw new Exception("Found multiple elements while reading single item");                                             // BuildMemberBase.cs:181
	        }                                                                                                                                  // BuildMemberBase.cs:182
	    }                                                                                                                                      // BuildMemberBase.cs:183
	                                                                                                                                           // BuildMemberBase.cs:185
	    /// <summary>
	    /// Item
	    /// </summary>
	    Item item;                                                                                                                             // BuildMemberBase.cs:189
	                                                                                                                                           // BuildMemberBase.cs:191
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => this.item == null ? 0 : 1;                                                                              // BuildMemberBase.cs:195
	                                                                                                                                           // BuildMemberBase.cs:197
	    /// <summary>
	    /// Get Item's Value
	    /// </summary>
	    public USFinding Get()                                                                                                                 // BuildMemberBase.cs:201
	    {                                                                                                                                      // BuildMemberBase.cs:202
	        if (item == null)                                                                                                                  // BuildMemberBase.cs:203
	            return null;                                                                                                                   // BuildMemberBase.cs:204
	        return item.Value;                                                                                                                 // BuildMemberBase.cs:205
	    }                                                                                                                                      // BuildMemberBase.cs:206
	                                                                                                                                           // BuildMemberBase.cs:212
	    /// <summary>
	    /// Set Item's Value
	    /// </summary>
	    public USFinding Set(USFinding value)                                                                                                  // BuildMemberBase.cs:216
	    {                                                                                                                                      // BuildMemberBase.cs:217
	        this.item = new Item(value);                                                                                                       // BuildMemberBase.cs:218
	        return value;                                                                                                                      // BuildMemberBase.cs:219
	    }                                                                                                                                      // BuildMemberBase.cs:220
	                                                                                                                                           // BuildMemberBase.cs:143
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public USFindingContainer(Int32 min, Int32 max) : base("Observation.hasMember:uSFinding", min, max)                                    // BuildMemberBase.cs:147
	    {                                                                                                                                      // BuildMemberBase.cs:148
	    }                                                                                                                                      // BuildMemberBase.cs:150
	                                                                                                                                           // BuildMemberBase.cs:151
	    // Methods                                                                                                                             // BuildMemberBase.cs:152
	                                                                                                                                           // BuildMemberBase.cs:293
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
	                                                                                                                                           // BuildMemberBase.cs:299
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
	            Item item = new Item((USFinding) resource);                                                                                    // BuildMemberReferences.cs:55
	            items.Add(item);                                                                                                               // BuildMemberReferences.cs:56
	        }                                                                                                                                  // BuildMemberReferences.cs:57
	        this.SetAllItems(items);                                                                                                           // BuildMemberReferences.cs:58
	    }                                                                                                                                      // BuildMemberReferences.cs:59
	}                                                                                                                                          // BuildMemberBase.cs:154
	//- LocalClassDefs
}
