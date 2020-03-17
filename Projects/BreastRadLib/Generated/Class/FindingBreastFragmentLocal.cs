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
	#region Observation.hasMember:mGFinding Container Class                                                                                    // BuildMemberBase.cs:157
	// Called from BuildMemberReferences.cs, Line 197
	// BuildMemberBase.cs:159
	/// <summary>
	/// Container class for Observation.hasMember:mGFinding.
	/// </summary>
	public class MGFindingContainer : MContainer, ITMItem<ResourceReference>                                                                   // BuildMemberBase.cs:162
	{                                                                                                                                          // BuildMemberBase.cs:163
	    #region Observation.hasMember:mGFinding Item Class                                                                                     // BuildMemberBase.cs:75
	    // Called from BuildMemberReferences.cs, Line 197
	    // BuildMemberBase.cs:77
	    /// <summary>
	    /// Item class for Observation.hasMember:mGFinding.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:80
	    {                                                                                                                                      // BuildMemberBase.cs:81
	        // Properties                                                                                                                      // BuildMemberBase.cs:82
	        // BuildMemberBase.cs:83
	        /// <summary>
	        /// Value
	        /// </summary>
	        public MGFinding Value { get; set; }                                                                                               // BuildMemberBase.cs:86
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
	        public void Write(BreastRadiologyDocument doc, ResourceReference reference)                                                        // BuildMemberReferences.cs:58
	        {                                                                                                                                  // BuildMemberReferences.cs:59
	            reference.Reference = this.Value.Id;                                                                                           // BuildMemberReferences.cs:60
	        }                                                                                                                                  // BuildMemberReferences.cs:61
	                                                                                                                                           // BuildMemberBase.cs:107
	        // BuildMemberBase.cs:108
	        /// <summary>
	        /// Read item.
	        /// </summary>
	                                                                                                                                           // BuildMemberReferences.cs:46
	        public void Read(BreastRadiologyDocument doc, ResourceReference reference)                                                         // BuildMemberReferences.cs:47
	        {                                                                                                                                  // BuildMemberReferences.cs:48
	            this.Value = (MGFinding) doc.GetResource(reference);                                                                           // BuildMemberReferences.cs:49
	        }                                                                                                                                  // BuildMemberReferences.cs:50
	    }                                                                                                                                      // BuildMemberBase.cs:114
	    #endregion                                                                                                                             // BuildMemberBase.cs:115
	                                                                                                                                           // BuildMemberBase.cs:166
	    // Properties                                                                                                                          // BuildMemberBase.cs:167
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:138
	    {                                                                                                                                      // BuildMemberBase.cs:139
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGFinding"                                                            // BuildMemberBase.cs:146
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
	    public MGFinding Get()                                                                                                                 // BuildMemberBase.cs:232
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
	    public MGFinding Set(MGFinding value)                                                                                                  // BuildMemberBase.cs:247
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
	    public MGFindingContainer(Int32 min, Int32 max) : base("Observation.hasMember:mGFinding", min, max)                                    // BuildMemberBase.cs:174
	    {                                                                                                                                      // BuildMemberBase.cs:175
	    }                                                                                                                                      // BuildMemberBase.cs:177
	                                                                                                                                           // BuildMemberBase.cs:179
	    // Methods                                                                                                                             // BuildMemberBase.cs:180
	                                                                                                                                           // BuildMemberBase.cs:333
	    // BuildMemberBase.cs:334
	    /// <summary>
	    /// Write container items.
	    /// </summary>
	    public IEnumerable<ResourceReference> Write(BreastRadiologyDocument doc)                                                               // BuildMemberReferences.cs:93
	    {                                                                                                                                      // BuildMemberReferences.cs:94
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberReferences.cs:95
	        {                                                                                                                                  // BuildMemberReferences.cs:96
	            ResourceReference reference = new ResourceReference();                                                                         // BuildMemberReferences.cs:97
	            item.Write(doc, reference);                                                                                                    // BuildMemberReferences.cs:98
	            yield return reference;                                                                                                        // BuildMemberReferences.cs:99
	        }                                                                                                                                  // BuildMemberReferences.cs:100
	    }                                                                                                                                      // BuildMemberReferences.cs:101
	                                                                                                                                           // BuildMemberBase.cs:339
	    // BuildMemberBase.cs:340
	    /// <summary>
	    /// Read container items.
	    /// </summary>
	                                                                                                                                           // BuildMemberReferences.cs:68
	    public void Read(BreastRadiologyDocument doc, IEnumerable<ResourceReference> references)                                               // BuildMemberReferences.cs:69
	    {                                                                                                                                      // BuildMemberReferences.cs:70
	        IEnumerable<ResourceReference> resourceReferences = base.IsMember(doc,                                                             // BuildMemberReferences.cs:71
	            references,                                                                                                                    // BuildMemberReferences.cs:72
	            this.targetUrls);                                                                                                              // BuildMemberReferences.cs:73
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberReferences.cs:74
	        foreach (ResourceReference resourceReference in resourceReferences)                                                                // BuildMemberReferences.cs:75
	        {                                                                                                                                  // BuildMemberReferences.cs:76
	            Item item = new Item();                                                                                                        // BuildMemberReferences.cs:77
	            item.Read(doc, resourceReference);                                                                                             // BuildMemberReferences.cs:78
	            items.Add(item);                                                                                                               // BuildMemberReferences.cs:79
	        }                                                                                                                                  // BuildMemberReferences.cs:80
	        this.SetAllItems(items);                                                                                                           // BuildMemberReferences.cs:81
	    }                                                                                                                                      // BuildMemberReferences.cs:82
	}                                                                                                                                          // BuildMemberBase.cs:182
	#endregion                                                                                                                                 // BuildMemberBase.cs:183
	#region Observation.hasMember:mRIFinding Container Class                                                                                   // BuildMemberBase.cs:157
	// Called from BuildMemberReferences.cs, Line 197
	// BuildMemberBase.cs:159
	/// <summary>
	/// Container class for Observation.hasMember:mRIFinding.
	/// </summary>
	public class MRIFindingContainer : MContainer, ITMItem<ResourceReference>                                                                  // BuildMemberBase.cs:162
	{                                                                                                                                          // BuildMemberBase.cs:163
	    #region Observation.hasMember:mRIFinding Item Class                                                                                    // BuildMemberBase.cs:75
	    // Called from BuildMemberReferences.cs, Line 197
	    // BuildMemberBase.cs:77
	    /// <summary>
	    /// Item class for Observation.hasMember:mRIFinding.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:80
	    {                                                                                                                                      // BuildMemberBase.cs:81
	        // Properties                                                                                                                      // BuildMemberBase.cs:82
	        // BuildMemberBase.cs:83
	        /// <summary>
	        /// Value
	        /// </summary>
	        public MRIFinding Value { get; set; }                                                                                              // BuildMemberBase.cs:86
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
	        public void Write(BreastRadiologyDocument doc, ResourceReference reference)                                                        // BuildMemberReferences.cs:58
	        {                                                                                                                                  // BuildMemberReferences.cs:59
	            reference.Reference = this.Value.Id;                                                                                           // BuildMemberReferences.cs:60
	        }                                                                                                                                  // BuildMemberReferences.cs:61
	                                                                                                                                           // BuildMemberBase.cs:107
	        // BuildMemberBase.cs:108
	        /// <summary>
	        /// Read item.
	        /// </summary>
	                                                                                                                                           // BuildMemberReferences.cs:46
	        public void Read(BreastRadiologyDocument doc, ResourceReference reference)                                                         // BuildMemberReferences.cs:47
	        {                                                                                                                                  // BuildMemberReferences.cs:48
	            this.Value = (MRIFinding) doc.GetResource(reference);                                                                          // BuildMemberReferences.cs:49
	        }                                                                                                                                  // BuildMemberReferences.cs:50
	    }                                                                                                                                      // BuildMemberBase.cs:114
	    #endregion                                                                                                                             // BuildMemberBase.cs:115
	                                                                                                                                           // BuildMemberBase.cs:166
	    // Properties                                                                                                                          // BuildMemberBase.cs:167
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:138
	    {                                                                                                                                      // BuildMemberBase.cs:139
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MRIFinding"                                                           // BuildMemberBase.cs:146
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
	    public MRIFinding Get()                                                                                                                // BuildMemberBase.cs:232
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
	    public MRIFinding Set(MRIFinding value)                                                                                                // BuildMemberBase.cs:247
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
	    public MRIFindingContainer(Int32 min, Int32 max) : base("Observation.hasMember:mRIFinding", min, max)                                  // BuildMemberBase.cs:174
	    {                                                                                                                                      // BuildMemberBase.cs:175
	    }                                                                                                                                      // BuildMemberBase.cs:177
	                                                                                                                                           // BuildMemberBase.cs:179
	    // Methods                                                                                                                             // BuildMemberBase.cs:180
	                                                                                                                                           // BuildMemberBase.cs:333
	    // BuildMemberBase.cs:334
	    /// <summary>
	    /// Write container items.
	    /// </summary>
	    public IEnumerable<ResourceReference> Write(BreastRadiologyDocument doc)                                                               // BuildMemberReferences.cs:93
	    {                                                                                                                                      // BuildMemberReferences.cs:94
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberReferences.cs:95
	        {                                                                                                                                  // BuildMemberReferences.cs:96
	            ResourceReference reference = new ResourceReference();                                                                         // BuildMemberReferences.cs:97
	            item.Write(doc, reference);                                                                                                    // BuildMemberReferences.cs:98
	            yield return reference;                                                                                                        // BuildMemberReferences.cs:99
	        }                                                                                                                                  // BuildMemberReferences.cs:100
	    }                                                                                                                                      // BuildMemberReferences.cs:101
	                                                                                                                                           // BuildMemberBase.cs:339
	    // BuildMemberBase.cs:340
	    /// <summary>
	    /// Read container items.
	    /// </summary>
	                                                                                                                                           // BuildMemberReferences.cs:68
	    public void Read(BreastRadiologyDocument doc, IEnumerable<ResourceReference> references)                                               // BuildMemberReferences.cs:69
	    {                                                                                                                                      // BuildMemberReferences.cs:70
	        IEnumerable<ResourceReference> resourceReferences = base.IsMember(doc,                                                             // BuildMemberReferences.cs:71
	            references,                                                                                                                    // BuildMemberReferences.cs:72
	            this.targetUrls);                                                                                                              // BuildMemberReferences.cs:73
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberReferences.cs:74
	        foreach (ResourceReference resourceReference in resourceReferences)                                                                // BuildMemberReferences.cs:75
	        {                                                                                                                                  // BuildMemberReferences.cs:76
	            Item item = new Item();                                                                                                        // BuildMemberReferences.cs:77
	            item.Read(doc, resourceReference);                                                                                             // BuildMemberReferences.cs:78
	            items.Add(item);                                                                                                               // BuildMemberReferences.cs:79
	        }                                                                                                                                  // BuildMemberReferences.cs:80
	        this.SetAllItems(items);                                                                                                           // BuildMemberReferences.cs:81
	    }                                                                                                                                      // BuildMemberReferences.cs:82
	}                                                                                                                                          // BuildMemberBase.cs:182
	#endregion                                                                                                                                 // BuildMemberBase.cs:183
	#region Observation.hasMember:nMFinding Container Class                                                                                    // BuildMemberBase.cs:157
	// Called from BuildMemberReferences.cs, Line 197
	// BuildMemberBase.cs:159
	/// <summary>
	/// Container class for Observation.hasMember:nMFinding.
	/// </summary>
	public class NMFindingContainer : MContainer, ITMItem<ResourceReference>                                                                   // BuildMemberBase.cs:162
	{                                                                                                                                          // BuildMemberBase.cs:163
	    #region Observation.hasMember:nMFinding Item Class                                                                                     // BuildMemberBase.cs:75
	    // Called from BuildMemberReferences.cs, Line 197
	    // BuildMemberBase.cs:77
	    /// <summary>
	    /// Item class for Observation.hasMember:nMFinding.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:80
	    {                                                                                                                                      // BuildMemberBase.cs:81
	        // Properties                                                                                                                      // BuildMemberBase.cs:82
	        // BuildMemberBase.cs:83
	        /// <summary>
	        /// Value
	        /// </summary>
	        public NMFinding Value { get; set; }                                                                                               // BuildMemberBase.cs:86
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
	        public void Write(BreastRadiologyDocument doc, ResourceReference reference)                                                        // BuildMemberReferences.cs:58
	        {                                                                                                                                  // BuildMemberReferences.cs:59
	            reference.Reference = this.Value.Id;                                                                                           // BuildMemberReferences.cs:60
	        }                                                                                                                                  // BuildMemberReferences.cs:61
	                                                                                                                                           // BuildMemberBase.cs:107
	        // BuildMemberBase.cs:108
	        /// <summary>
	        /// Read item.
	        /// </summary>
	                                                                                                                                           // BuildMemberReferences.cs:46
	        public void Read(BreastRadiologyDocument doc, ResourceReference reference)                                                         // BuildMemberReferences.cs:47
	        {                                                                                                                                  // BuildMemberReferences.cs:48
	            this.Value = (NMFinding) doc.GetResource(reference);                                                                           // BuildMemberReferences.cs:49
	        }                                                                                                                                  // BuildMemberReferences.cs:50
	    }                                                                                                                                      // BuildMemberBase.cs:114
	    #endregion                                                                                                                             // BuildMemberBase.cs:115
	                                                                                                                                           // BuildMemberBase.cs:166
	    // Properties                                                                                                                          // BuildMemberBase.cs:167
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:138
	    {                                                                                                                                      // BuildMemberBase.cs:139
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/NMFinding"                                                            // BuildMemberBase.cs:146
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
	    public NMFinding Get()                                                                                                                 // BuildMemberBase.cs:232
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
	    public NMFinding Set(NMFinding value)                                                                                                  // BuildMemberBase.cs:247
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
	    public NMFindingContainer(Int32 min, Int32 max) : base("Observation.hasMember:nMFinding", min, max)                                    // BuildMemberBase.cs:174
	    {                                                                                                                                      // BuildMemberBase.cs:175
	    }                                                                                                                                      // BuildMemberBase.cs:177
	                                                                                                                                           // BuildMemberBase.cs:179
	    // Methods                                                                                                                             // BuildMemberBase.cs:180
	                                                                                                                                           // BuildMemberBase.cs:333
	    // BuildMemberBase.cs:334
	    /// <summary>
	    /// Write container items.
	    /// </summary>
	    public IEnumerable<ResourceReference> Write(BreastRadiologyDocument doc)                                                               // BuildMemberReferences.cs:93
	    {                                                                                                                                      // BuildMemberReferences.cs:94
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberReferences.cs:95
	        {                                                                                                                                  // BuildMemberReferences.cs:96
	            ResourceReference reference = new ResourceReference();                                                                         // BuildMemberReferences.cs:97
	            item.Write(doc, reference);                                                                                                    // BuildMemberReferences.cs:98
	            yield return reference;                                                                                                        // BuildMemberReferences.cs:99
	        }                                                                                                                                  // BuildMemberReferences.cs:100
	    }                                                                                                                                      // BuildMemberReferences.cs:101
	                                                                                                                                           // BuildMemberBase.cs:339
	    // BuildMemberBase.cs:340
	    /// <summary>
	    /// Read container items.
	    /// </summary>
	                                                                                                                                           // BuildMemberReferences.cs:68
	    public void Read(BreastRadiologyDocument doc, IEnumerable<ResourceReference> references)                                               // BuildMemberReferences.cs:69
	    {                                                                                                                                      // BuildMemberReferences.cs:70
	        IEnumerable<ResourceReference> resourceReferences = base.IsMember(doc,                                                             // BuildMemberReferences.cs:71
	            references,                                                                                                                    // BuildMemberReferences.cs:72
	            this.targetUrls);                                                                                                              // BuildMemberReferences.cs:73
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberReferences.cs:74
	        foreach (ResourceReference resourceReference in resourceReferences)                                                                // BuildMemberReferences.cs:75
	        {                                                                                                                                  // BuildMemberReferences.cs:76
	            Item item = new Item();                                                                                                        // BuildMemberReferences.cs:77
	            item.Read(doc, resourceReference);                                                                                             // BuildMemberReferences.cs:78
	            items.Add(item);                                                                                                               // BuildMemberReferences.cs:79
	        }                                                                                                                                  // BuildMemberReferences.cs:80
	        this.SetAllItems(items);                                                                                                           // BuildMemberReferences.cs:81
	    }                                                                                                                                      // BuildMemberReferences.cs:82
	}                                                                                                                                          // BuildMemberBase.cs:182
	#endregion                                                                                                                                 // BuildMemberBase.cs:183
	#region Observation.hasMember:uSFinding Container Class                                                                                    // BuildMemberBase.cs:157
	// Called from BuildMemberReferences.cs, Line 197
	// BuildMemberBase.cs:159
	/// <summary>
	/// Container class for Observation.hasMember:uSFinding.
	/// </summary>
	public class USFindingContainer : MContainer, ITMItem<ResourceReference>                                                                   // BuildMemberBase.cs:162
	{                                                                                                                                          // BuildMemberBase.cs:163
	    #region Observation.hasMember:uSFinding Item Class                                                                                     // BuildMemberBase.cs:75
	    // Called from BuildMemberReferences.cs, Line 197
	    // BuildMemberBase.cs:77
	    /// <summary>
	    /// Item class for Observation.hasMember:uSFinding.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:80
	    {                                                                                                                                      // BuildMemberBase.cs:81
	        // Properties                                                                                                                      // BuildMemberBase.cs:82
	        // BuildMemberBase.cs:83
	        /// <summary>
	        /// Value
	        /// </summary>
	        public USFinding Value { get; set; }                                                                                               // BuildMemberBase.cs:86
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
	        public void Write(BreastRadiologyDocument doc, ResourceReference reference)                                                        // BuildMemberReferences.cs:58
	        {                                                                                                                                  // BuildMemberReferences.cs:59
	            reference.Reference = this.Value.Id;                                                                                           // BuildMemberReferences.cs:60
	        }                                                                                                                                  // BuildMemberReferences.cs:61
	                                                                                                                                           // BuildMemberBase.cs:107
	        // BuildMemberBase.cs:108
	        /// <summary>
	        /// Read item.
	        /// </summary>
	                                                                                                                                           // BuildMemberReferences.cs:46
	        public void Read(BreastRadiologyDocument doc, ResourceReference reference)                                                         // BuildMemberReferences.cs:47
	        {                                                                                                                                  // BuildMemberReferences.cs:48
	            this.Value = (USFinding) doc.GetResource(reference);                                                                           // BuildMemberReferences.cs:49
	        }                                                                                                                                  // BuildMemberReferences.cs:50
	    }                                                                                                                                      // BuildMemberBase.cs:114
	    #endregion                                                                                                                             // BuildMemberBase.cs:115
	                                                                                                                                           // BuildMemberBase.cs:166
	    // Properties                                                                                                                          // BuildMemberBase.cs:167
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:138
	    {                                                                                                                                      // BuildMemberBase.cs:139
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/USFinding"                                                            // BuildMemberBase.cs:146
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
	    public USFinding Get()                                                                                                                 // BuildMemberBase.cs:232
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
	    public USFinding Set(USFinding value)                                                                                                  // BuildMemberBase.cs:247
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
	    public USFindingContainer(Int32 min, Int32 max) : base("Observation.hasMember:uSFinding", min, max)                                    // BuildMemberBase.cs:174
	    {                                                                                                                                      // BuildMemberBase.cs:175
	    }                                                                                                                                      // BuildMemberBase.cs:177
	                                                                                                                                           // BuildMemberBase.cs:179
	    // Methods                                                                                                                             // BuildMemberBase.cs:180
	                                                                                                                                           // BuildMemberBase.cs:333
	    // BuildMemberBase.cs:334
	    /// <summary>
	    /// Write container items.
	    /// </summary>
	    public IEnumerable<ResourceReference> Write(BreastRadiologyDocument doc)                                                               // BuildMemberReferences.cs:93
	    {                                                                                                                                      // BuildMemberReferences.cs:94
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberReferences.cs:95
	        {                                                                                                                                  // BuildMemberReferences.cs:96
	            ResourceReference reference = new ResourceReference();                                                                         // BuildMemberReferences.cs:97
	            item.Write(doc, reference);                                                                                                    // BuildMemberReferences.cs:98
	            yield return reference;                                                                                                        // BuildMemberReferences.cs:99
	        }                                                                                                                                  // BuildMemberReferences.cs:100
	    }                                                                                                                                      // BuildMemberReferences.cs:101
	                                                                                                                                           // BuildMemberBase.cs:339
	    // BuildMemberBase.cs:340
	    /// <summary>
	    /// Read container items.
	    /// </summary>
	                                                                                                                                           // BuildMemberReferences.cs:68
	    public void Read(BreastRadiologyDocument doc, IEnumerable<ResourceReference> references)                                               // BuildMemberReferences.cs:69
	    {                                                                                                                                      // BuildMemberReferences.cs:70
	        IEnumerable<ResourceReference> resourceReferences = base.IsMember(doc,                                                             // BuildMemberReferences.cs:71
	            references,                                                                                                                    // BuildMemberReferences.cs:72
	            this.targetUrls);                                                                                                              // BuildMemberReferences.cs:73
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberReferences.cs:74
	        foreach (ResourceReference resourceReference in resourceReferences)                                                                // BuildMemberReferences.cs:75
	        {                                                                                                                                  // BuildMemberReferences.cs:76
	            Item item = new Item();                                                                                                        // BuildMemberReferences.cs:77
	            item.Read(doc, resourceReference);                                                                                             // BuildMemberReferences.cs:78
	            items.Add(item);                                                                                                               // BuildMemberReferences.cs:79
	        }                                                                                                                                  // BuildMemberReferences.cs:80
	        this.SetAllItems(items);                                                                                                           // BuildMemberReferences.cs:81
	    }                                                                                                                                      // BuildMemberReferences.cs:82
	}                                                                                                                                          // BuildMemberBase.cs:182
	#endregion                                                                                                                                 // BuildMemberBase.cs:183
	//- LocalClassDefs
}
