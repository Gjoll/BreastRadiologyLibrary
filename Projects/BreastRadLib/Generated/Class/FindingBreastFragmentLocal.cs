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
	public class MGFindingContainer : MContainer, ITMItem<ResourceReference>                                                                   // BuildMemberBase.cs:110
	{                                                                                                                                          // BuildMemberBase.cs:111
	    /// <summary>
	    /// Item class for Observation.hasMember:mGFinding.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:62
	    {                                                                                                                                      // BuildMemberBase.cs:63
	        // Properties                                                                                                                      // BuildMemberBase.cs:64
	        /// <summary>
	        /// Value
	        /// </summary>
	        public MGFinding Value { get; set; }                                                                                               // BuildMemberBase.cs:68
	                                                                                                                                           // BuildMemberBase.cs:70
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(MGFinding value)                                                                                                       // BuildMemberBase.cs:74
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
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGFinding"                                                            // BuildMemberReferences.cs:54
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
	    public MGFinding Get()                                                                                                                 // BuildMemberBase.cs:176
	    {                                                                                                                                      // BuildMemberBase.cs:177
	        if (item == null)                                                                                                                  // BuildMemberBase.cs:178
	            return null;                                                                                                                   // BuildMemberBase.cs:179
	        return item.Value;                                                                                                                 // BuildMemberBase.cs:180
	    }                                                                                                                                      // BuildMemberBase.cs:181
	                                                                                                                                           // BuildMemberBase.cs:187
	    /// <summary>
	    /// Set Item's Value
	    /// </summary>
	    public MGFinding Set(MGFinding value)                                                                                                  // BuildMemberBase.cs:191
	    {                                                                                                                                      // BuildMemberBase.cs:192
	        this.item = new Item(value);                                                                                                       // BuildMemberBase.cs:193
	        return value;                                                                                                                      // BuildMemberBase.cs:194
	    }                                                                                                                                      // BuildMemberBase.cs:195
	                                                                                                                                           // BuildMemberBase.cs:116
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public MGFindingContainer(Int32 min, Int32 max) : base("Observation.hasMember:mGFinding", min, max)                                    // BuildMemberBase.cs:120
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
	            Item item = new Item((MGFinding) resource);                                                                                    // BuildMemberReferences.cs:72
	            items.Add(item);                                                                                                               // BuildMemberReferences.cs:73
	        }                                                                                                                                  // BuildMemberReferences.cs:74
	        this.SetAllItems(items);                                                                                                           // BuildMemberReferences.cs:75
	    }                                                                                                                                      // BuildMemberReferences.cs:76
	}                                                                                                                                          // BuildMemberBase.cs:127
	/// <summary>
	/// Container class for Observation.hasMember:mRIFinding.
	/// </summary>
	public class MRIFindingContainer : MContainer, ITMItem<ResourceReference>                                                                  // BuildMemberBase.cs:110
	{                                                                                                                                          // BuildMemberBase.cs:111
	    /// <summary>
	    /// Item class for Observation.hasMember:mRIFinding.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:62
	    {                                                                                                                                      // BuildMemberBase.cs:63
	        // Properties                                                                                                                      // BuildMemberBase.cs:64
	        /// <summary>
	        /// Value
	        /// </summary>
	        public MRIFinding Value { get; set; }                                                                                              // BuildMemberBase.cs:68
	                                                                                                                                           // BuildMemberBase.cs:70
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(MRIFinding value)                                                                                                      // BuildMemberBase.cs:74
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
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MRIFinding"                                                           // BuildMemberReferences.cs:54
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
	    public MRIFinding Get()                                                                                                                // BuildMemberBase.cs:176
	    {                                                                                                                                      // BuildMemberBase.cs:177
	        if (item == null)                                                                                                                  // BuildMemberBase.cs:178
	            return null;                                                                                                                   // BuildMemberBase.cs:179
	        return item.Value;                                                                                                                 // BuildMemberBase.cs:180
	    }                                                                                                                                      // BuildMemberBase.cs:181
	                                                                                                                                           // BuildMemberBase.cs:187
	    /// <summary>
	    /// Set Item's Value
	    /// </summary>
	    public MRIFinding Set(MRIFinding value)                                                                                                // BuildMemberBase.cs:191
	    {                                                                                                                                      // BuildMemberBase.cs:192
	        this.item = new Item(value);                                                                                                       // BuildMemberBase.cs:193
	        return value;                                                                                                                      // BuildMemberBase.cs:194
	    }                                                                                                                                      // BuildMemberBase.cs:195
	                                                                                                                                           // BuildMemberBase.cs:116
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public MRIFindingContainer(Int32 min, Int32 max) : base("Observation.hasMember:mRIFinding", min, max)                                  // BuildMemberBase.cs:120
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
	            Item item = new Item((MRIFinding) resource);                                                                                   // BuildMemberReferences.cs:72
	            items.Add(item);                                                                                                               // BuildMemberReferences.cs:73
	        }                                                                                                                                  // BuildMemberReferences.cs:74
	        this.SetAllItems(items);                                                                                                           // BuildMemberReferences.cs:75
	    }                                                                                                                                      // BuildMemberReferences.cs:76
	}                                                                                                                                          // BuildMemberBase.cs:127
	/// <summary>
	/// Container class for Observation.hasMember:nMFinding.
	/// </summary>
	public class NMFindingContainer : MContainer, ITMItem<ResourceReference>                                                                   // BuildMemberBase.cs:110
	{                                                                                                                                          // BuildMemberBase.cs:111
	    /// <summary>
	    /// Item class for Observation.hasMember:nMFinding.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:62
	    {                                                                                                                                      // BuildMemberBase.cs:63
	        // Properties                                                                                                                      // BuildMemberBase.cs:64
	        /// <summary>
	        /// Value
	        /// </summary>
	        public NMFinding Value { get; set; }                                                                                               // BuildMemberBase.cs:68
	                                                                                                                                           // BuildMemberBase.cs:70
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(NMFinding value)                                                                                                       // BuildMemberBase.cs:74
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
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/NMFinding"                                                            // BuildMemberReferences.cs:54
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
	    public NMFinding Get()                                                                                                                 // BuildMemberBase.cs:176
	    {                                                                                                                                      // BuildMemberBase.cs:177
	        if (item == null)                                                                                                                  // BuildMemberBase.cs:178
	            return null;                                                                                                                   // BuildMemberBase.cs:179
	        return item.Value;                                                                                                                 // BuildMemberBase.cs:180
	    }                                                                                                                                      // BuildMemberBase.cs:181
	                                                                                                                                           // BuildMemberBase.cs:187
	    /// <summary>
	    /// Set Item's Value
	    /// </summary>
	    public NMFinding Set(NMFinding value)                                                                                                  // BuildMemberBase.cs:191
	    {                                                                                                                                      // BuildMemberBase.cs:192
	        this.item = new Item(value);                                                                                                       // BuildMemberBase.cs:193
	        return value;                                                                                                                      // BuildMemberBase.cs:194
	    }                                                                                                                                      // BuildMemberBase.cs:195
	                                                                                                                                           // BuildMemberBase.cs:116
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public NMFindingContainer(Int32 min, Int32 max) : base("Observation.hasMember:nMFinding", min, max)                                    // BuildMemberBase.cs:120
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
	            Item item = new Item((NMFinding) resource);                                                                                    // BuildMemberReferences.cs:72
	            items.Add(item);                                                                                                               // BuildMemberReferences.cs:73
	        }                                                                                                                                  // BuildMemberReferences.cs:74
	        this.SetAllItems(items);                                                                                                           // BuildMemberReferences.cs:75
	    }                                                                                                                                      // BuildMemberReferences.cs:76
	}                                                                                                                                          // BuildMemberBase.cs:127
	/// <summary>
	/// Container class for Observation.hasMember:uSFinding.
	/// </summary>
	public class USFindingContainer : MContainer, ITMItem<ResourceReference>                                                                   // BuildMemberBase.cs:110
	{                                                                                                                                          // BuildMemberBase.cs:111
	    /// <summary>
	    /// Item class for Observation.hasMember:uSFinding.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:62
	    {                                                                                                                                      // BuildMemberBase.cs:63
	        // Properties                                                                                                                      // BuildMemberBase.cs:64
	        /// <summary>
	        /// Value
	        /// </summary>
	        public USFinding Value { get; set; }                                                                                               // BuildMemberBase.cs:68
	                                                                                                                                           // BuildMemberBase.cs:70
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(USFinding value)                                                                                                       // BuildMemberBase.cs:74
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
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/USFinding"                                                            // BuildMemberReferences.cs:54
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
	    public USFinding Get()                                                                                                                 // BuildMemberBase.cs:176
	    {                                                                                                                                      // BuildMemberBase.cs:177
	        if (item == null)                                                                                                                  // BuildMemberBase.cs:178
	            return null;                                                                                                                   // BuildMemberBase.cs:179
	        return item.Value;                                                                                                                 // BuildMemberBase.cs:180
	    }                                                                                                                                      // BuildMemberBase.cs:181
	                                                                                                                                           // BuildMemberBase.cs:187
	    /// <summary>
	    /// Set Item's Value
	    /// </summary>
	    public USFinding Set(USFinding value)                                                                                                  // BuildMemberBase.cs:191
	    {                                                                                                                                      // BuildMemberBase.cs:192
	        this.item = new Item(value);                                                                                                       // BuildMemberBase.cs:193
	        return value;                                                                                                                      // BuildMemberBase.cs:194
	    }                                                                                                                                      // BuildMemberBase.cs:195
	                                                                                                                                           // BuildMemberBase.cs:116
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public USFindingContainer(Int32 min, Int32 max) : base("Observation.hasMember:uSFinding", min, max)                                    // BuildMemberBase.cs:120
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
	            Item item = new Item((USFinding) resource);                                                                                    // BuildMemberReferences.cs:72
	            items.Add(item);                                                                                                               // BuildMemberReferences.cs:73
	        }                                                                                                                                  // BuildMemberReferences.cs:74
	        this.SetAllItems(items);                                                                                                           // BuildMemberReferences.cs:75
	    }                                                                                                                                      // BuildMemberReferences.cs:76
	}                                                                                                                                          // BuildMemberBase.cs:127
	//- LocalClassDefs
}
