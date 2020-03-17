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
	#region Observation.hasMember:mGFinding Container Class                                                                                    // BuildMemberBase.cs:158
	// Called from BuildMemberReferences.cs, Line 199
	// BuildMemberBase.cs:160
	/// <summary>
	/// Container class for Observation.hasMember:mGFinding.
	/// </summary>
	public class MMGFinding : MContainer, ITMItem<ResourceReference>                                                                           // BuildMemberBase.cs:163
	{                                                                                                                                          // BuildMemberBase.cs:164
	    #region Observation.hasMember:mGFinding Item Class                                                                                     // BuildMemberBase.cs:75
	    // Called from BuildMemberReferences.cs, Line 199
	    // BuildMemberBase.cs:77
	    /// <summary>
	    /// Item class for Observation.hasMember:mGFinding.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:80
	    {                                                                                                                                      // BuildMemberBase.cs:81
	        // Properties                                                                                                                      // BuildMemberBase.cs:82
	        // BuildMemberBase.cs:84
	        /// <summary>
	        /// Value
	        /// </summary>
	        public MGFinding Value { get; set; }                                                                                               // BuildMemberBase.cs:87
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
	            this.Value = (MGFinding) doc.GetResource(reference);                                                                           // BuildMemberReferences.cs:49
	        }                                                                                                                                  // BuildMemberReferences.cs:50
	    }                                                                                                                                      // BuildMemberBase.cs:115
	    #endregion                                                                                                                             // BuildMemberBase.cs:116
	                                                                                                                                           // BuildMemberBase.cs:167
	    // Properties                                                                                                                          // BuildMemberBase.cs:168
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:139
	    {                                                                                                                                      // BuildMemberBase.cs:140
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGFinding"                                                            // BuildMemberBase.cs:147
	    };                                                                                                                                     // BuildMemberBase.cs:148
	    #region Common Singleton Properties                                                                                                    // BuildMemberBase.cs:192
	                                                                                                                                           // BuildMemberBase.cs:194
	    // BuildMemberBase.cs:195
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems()                                                                                                        // BuildMemberBase.cs:198
	    {                                                                                                                                      // BuildMemberBase.cs:199
	        if (this.item != null) yield return this.item;                                                                                     // BuildMemberBase.cs:200
	    }                                                                                                                                      // BuildMemberBase.cs:201
	                                                                                                                                           // BuildMemberBase.cs:203
	    // BuildMemberBase.cs:204
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items)                                                                                              // BuildMemberBase.cs:207
	    {                                                                                                                                      // BuildMemberBase.cs:208
	        switch (items.Count())                                                                                                             // BuildMemberBase.cs:209
	        {                                                                                                                                  // BuildMemberBase.cs:210
	            case 0: break;                                                                                                                 // BuildMemberBase.cs:211
	            case 1: this.item = items.First(); break;                                                                                      // BuildMemberBase.cs:212
	            default: throw new Exception("Found multiple elements while reading single item");                                             // BuildMemberBase.cs:213
	        }                                                                                                                                  // BuildMemberBase.cs:214
	    }                                                                                                                                      // BuildMemberBase.cs:215
	                                                                                                                                           // BuildMemberBase.cs:217
	    // BuildMemberBase.cs:218
	    /// <summary>
	    /// Item
	    /// </summary>
	    Item item;                                                                                                                             // BuildMemberBase.cs:221
	                                                                                                                                           // BuildMemberBase.cs:223
	    // BuildMemberBase.cs:224
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => this.item == null ? 0 : 1;                                                                              // BuildMemberBase.cs:227
	                                                                                                                                           // BuildMemberBase.cs:229
	    // BuildMemberBase.cs:230
	    /// <summary>
	    /// Get Item's Value
	    /// </summary>
	    public MGFinding Get()                                                                                                                 // BuildMemberBase.cs:233
	    {                                                                                                                                      // BuildMemberBase.cs:234
	        if (item == null)                                                                                                                  // BuildMemberBase.cs:235
	            return null;                                                                                                                   // BuildMemberBase.cs:236
	        return item.Value;                                                                                                                 // BuildMemberBase.cs:237
	    }                                                                                                                                      // BuildMemberBase.cs:238
	                                                                                                                                           // BuildMemberBase.cs:244
	    // BuildMemberBase.cs:245
	    /// <summary>
	    /// Set Item's Value
	    /// </summary>
	    public MGFinding Set(MGFinding value)                                                                                                  // BuildMemberBase.cs:248
	    {                                                                                                                                      // BuildMemberBase.cs:249
	        Item item = new Item();                                                                                                            // BuildMemberBase.cs:250
	        item.Value = value;                                                                                                                // BuildMemberBase.cs:251
	        this.item = item;                                                                                                                  // BuildMemberBase.cs:252
	        return value;                                                                                                                      // BuildMemberBase.cs:253
	    }                                                                                                                                      // BuildMemberBase.cs:254
	    #endregion                                                                                                                             // BuildMemberBase.cs:330
	                                                                                                                                           // BuildMemberBase.cs:171
	    // BuildMemberBase.cs:172
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public MMGFinding(Int32 min, Int32 max) : base("Observation.hasMember:mGFinding", min, max)                                            // BuildMemberBase.cs:175
	    {                                                                                                                                      // BuildMemberBase.cs:176
	    }                                                                                                                                      // BuildMemberBase.cs:178
	                                                                                                                                           // BuildMemberBase.cs:180
	    // Methods                                                                                                                             // BuildMemberBase.cs:181
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
	#region Observation.hasMember:mRIFinding Container Class                                                                                   // BuildMemberBase.cs:158
	// Called from BuildMemberReferences.cs, Line 199
	// BuildMemberBase.cs:160
	/// <summary>
	/// Container class for Observation.hasMember:mRIFinding.
	/// </summary>
	public class MMRIFinding : MContainer, ITMItem<ResourceReference>                                                                          // BuildMemberBase.cs:163
	{                                                                                                                                          // BuildMemberBase.cs:164
	    #region Observation.hasMember:mRIFinding Item Class                                                                                    // BuildMemberBase.cs:75
	    // Called from BuildMemberReferences.cs, Line 199
	    // BuildMemberBase.cs:77
	    /// <summary>
	    /// Item class for Observation.hasMember:mRIFinding.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:80
	    {                                                                                                                                      // BuildMemberBase.cs:81
	        // Properties                                                                                                                      // BuildMemberBase.cs:82
	        // BuildMemberBase.cs:84
	        /// <summary>
	        /// Value
	        /// </summary>
	        public MRIFinding Value { get; set; }                                                                                              // BuildMemberBase.cs:87
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
	            this.Value = (MRIFinding) doc.GetResource(reference);                                                                          // BuildMemberReferences.cs:49
	        }                                                                                                                                  // BuildMemberReferences.cs:50
	    }                                                                                                                                      // BuildMemberBase.cs:115
	    #endregion                                                                                                                             // BuildMemberBase.cs:116
	                                                                                                                                           // BuildMemberBase.cs:167
	    // Properties                                                                                                                          // BuildMemberBase.cs:168
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:139
	    {                                                                                                                                      // BuildMemberBase.cs:140
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MRIFinding"                                                           // BuildMemberBase.cs:147
	    };                                                                                                                                     // BuildMemberBase.cs:148
	    #region Common Singleton Properties                                                                                                    // BuildMemberBase.cs:192
	                                                                                                                                           // BuildMemberBase.cs:194
	    // BuildMemberBase.cs:195
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems()                                                                                                        // BuildMemberBase.cs:198
	    {                                                                                                                                      // BuildMemberBase.cs:199
	        if (this.item != null) yield return this.item;                                                                                     // BuildMemberBase.cs:200
	    }                                                                                                                                      // BuildMemberBase.cs:201
	                                                                                                                                           // BuildMemberBase.cs:203
	    // BuildMemberBase.cs:204
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items)                                                                                              // BuildMemberBase.cs:207
	    {                                                                                                                                      // BuildMemberBase.cs:208
	        switch (items.Count())                                                                                                             // BuildMemberBase.cs:209
	        {                                                                                                                                  // BuildMemberBase.cs:210
	            case 0: break;                                                                                                                 // BuildMemberBase.cs:211
	            case 1: this.item = items.First(); break;                                                                                      // BuildMemberBase.cs:212
	            default: throw new Exception("Found multiple elements while reading single item");                                             // BuildMemberBase.cs:213
	        }                                                                                                                                  // BuildMemberBase.cs:214
	    }                                                                                                                                      // BuildMemberBase.cs:215
	                                                                                                                                           // BuildMemberBase.cs:217
	    // BuildMemberBase.cs:218
	    /// <summary>
	    /// Item
	    /// </summary>
	    Item item;                                                                                                                             // BuildMemberBase.cs:221
	                                                                                                                                           // BuildMemberBase.cs:223
	    // BuildMemberBase.cs:224
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => this.item == null ? 0 : 1;                                                                              // BuildMemberBase.cs:227
	                                                                                                                                           // BuildMemberBase.cs:229
	    // BuildMemberBase.cs:230
	    /// <summary>
	    /// Get Item's Value
	    /// </summary>
	    public MRIFinding Get()                                                                                                                // BuildMemberBase.cs:233
	    {                                                                                                                                      // BuildMemberBase.cs:234
	        if (item == null)                                                                                                                  // BuildMemberBase.cs:235
	            return null;                                                                                                                   // BuildMemberBase.cs:236
	        return item.Value;                                                                                                                 // BuildMemberBase.cs:237
	    }                                                                                                                                      // BuildMemberBase.cs:238
	                                                                                                                                           // BuildMemberBase.cs:244
	    // BuildMemberBase.cs:245
	    /// <summary>
	    /// Set Item's Value
	    /// </summary>
	    public MRIFinding Set(MRIFinding value)                                                                                                // BuildMemberBase.cs:248
	    {                                                                                                                                      // BuildMemberBase.cs:249
	        Item item = new Item();                                                                                                            // BuildMemberBase.cs:250
	        item.Value = value;                                                                                                                // BuildMemberBase.cs:251
	        this.item = item;                                                                                                                  // BuildMemberBase.cs:252
	        return value;                                                                                                                      // BuildMemberBase.cs:253
	    }                                                                                                                                      // BuildMemberBase.cs:254
	    #endregion                                                                                                                             // BuildMemberBase.cs:330
	                                                                                                                                           // BuildMemberBase.cs:171
	    // BuildMemberBase.cs:172
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public MMRIFinding(Int32 min, Int32 max) : base("Observation.hasMember:mRIFinding", min, max)                                          // BuildMemberBase.cs:175
	    {                                                                                                                                      // BuildMemberBase.cs:176
	    }                                                                                                                                      // BuildMemberBase.cs:178
	                                                                                                                                           // BuildMemberBase.cs:180
	    // Methods                                                                                                                             // BuildMemberBase.cs:181
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
	#region Observation.hasMember:nMFinding Container Class                                                                                    // BuildMemberBase.cs:158
	// Called from BuildMemberReferences.cs, Line 199
	// BuildMemberBase.cs:160
	/// <summary>
	/// Container class for Observation.hasMember:nMFinding.
	/// </summary>
	public class MNMFinding : MContainer, ITMItem<ResourceReference>                                                                           // BuildMemberBase.cs:163
	{                                                                                                                                          // BuildMemberBase.cs:164
	    #region Observation.hasMember:nMFinding Item Class                                                                                     // BuildMemberBase.cs:75
	    // Called from BuildMemberReferences.cs, Line 199
	    // BuildMemberBase.cs:77
	    /// <summary>
	    /// Item class for Observation.hasMember:nMFinding.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:80
	    {                                                                                                                                      // BuildMemberBase.cs:81
	        // Properties                                                                                                                      // BuildMemberBase.cs:82
	        // BuildMemberBase.cs:84
	        /// <summary>
	        /// Value
	        /// </summary>
	        public NMFinding Value { get; set; }                                                                                               // BuildMemberBase.cs:87
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
	            this.Value = (NMFinding) doc.GetResource(reference);                                                                           // BuildMemberReferences.cs:49
	        }                                                                                                                                  // BuildMemberReferences.cs:50
	    }                                                                                                                                      // BuildMemberBase.cs:115
	    #endregion                                                                                                                             // BuildMemberBase.cs:116
	                                                                                                                                           // BuildMemberBase.cs:167
	    // Properties                                                                                                                          // BuildMemberBase.cs:168
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:139
	    {                                                                                                                                      // BuildMemberBase.cs:140
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/NMFinding"                                                            // BuildMemberBase.cs:147
	    };                                                                                                                                     // BuildMemberBase.cs:148
	    #region Common Singleton Properties                                                                                                    // BuildMemberBase.cs:192
	                                                                                                                                           // BuildMemberBase.cs:194
	    // BuildMemberBase.cs:195
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems()                                                                                                        // BuildMemberBase.cs:198
	    {                                                                                                                                      // BuildMemberBase.cs:199
	        if (this.item != null) yield return this.item;                                                                                     // BuildMemberBase.cs:200
	    }                                                                                                                                      // BuildMemberBase.cs:201
	                                                                                                                                           // BuildMemberBase.cs:203
	    // BuildMemberBase.cs:204
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items)                                                                                              // BuildMemberBase.cs:207
	    {                                                                                                                                      // BuildMemberBase.cs:208
	        switch (items.Count())                                                                                                             // BuildMemberBase.cs:209
	        {                                                                                                                                  // BuildMemberBase.cs:210
	            case 0: break;                                                                                                                 // BuildMemberBase.cs:211
	            case 1: this.item = items.First(); break;                                                                                      // BuildMemberBase.cs:212
	            default: throw new Exception("Found multiple elements while reading single item");                                             // BuildMemberBase.cs:213
	        }                                                                                                                                  // BuildMemberBase.cs:214
	    }                                                                                                                                      // BuildMemberBase.cs:215
	                                                                                                                                           // BuildMemberBase.cs:217
	    // BuildMemberBase.cs:218
	    /// <summary>
	    /// Item
	    /// </summary>
	    Item item;                                                                                                                             // BuildMemberBase.cs:221
	                                                                                                                                           // BuildMemberBase.cs:223
	    // BuildMemberBase.cs:224
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => this.item == null ? 0 : 1;                                                                              // BuildMemberBase.cs:227
	                                                                                                                                           // BuildMemberBase.cs:229
	    // BuildMemberBase.cs:230
	    /// <summary>
	    /// Get Item's Value
	    /// </summary>
	    public NMFinding Get()                                                                                                                 // BuildMemberBase.cs:233
	    {                                                                                                                                      // BuildMemberBase.cs:234
	        if (item == null)                                                                                                                  // BuildMemberBase.cs:235
	            return null;                                                                                                                   // BuildMemberBase.cs:236
	        return item.Value;                                                                                                                 // BuildMemberBase.cs:237
	    }                                                                                                                                      // BuildMemberBase.cs:238
	                                                                                                                                           // BuildMemberBase.cs:244
	    // BuildMemberBase.cs:245
	    /// <summary>
	    /// Set Item's Value
	    /// </summary>
	    public NMFinding Set(NMFinding value)                                                                                                  // BuildMemberBase.cs:248
	    {                                                                                                                                      // BuildMemberBase.cs:249
	        Item item = new Item();                                                                                                            // BuildMemberBase.cs:250
	        item.Value = value;                                                                                                                // BuildMemberBase.cs:251
	        this.item = item;                                                                                                                  // BuildMemberBase.cs:252
	        return value;                                                                                                                      // BuildMemberBase.cs:253
	    }                                                                                                                                      // BuildMemberBase.cs:254
	    #endregion                                                                                                                             // BuildMemberBase.cs:330
	                                                                                                                                           // BuildMemberBase.cs:171
	    // BuildMemberBase.cs:172
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public MNMFinding(Int32 min, Int32 max) : base("Observation.hasMember:nMFinding", min, max)                                            // BuildMemberBase.cs:175
	    {                                                                                                                                      // BuildMemberBase.cs:176
	    }                                                                                                                                      // BuildMemberBase.cs:178
	                                                                                                                                           // BuildMemberBase.cs:180
	    // Methods                                                                                                                             // BuildMemberBase.cs:181
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
	#region Observation.hasMember:uSFinding Container Class                                                                                    // BuildMemberBase.cs:158
	// Called from BuildMemberReferences.cs, Line 199
	// BuildMemberBase.cs:160
	/// <summary>
	/// Container class for Observation.hasMember:uSFinding.
	/// </summary>
	public class MUSFinding : MContainer, ITMItem<ResourceReference>                                                                           // BuildMemberBase.cs:163
	{                                                                                                                                          // BuildMemberBase.cs:164
	    #region Observation.hasMember:uSFinding Item Class                                                                                     // BuildMemberBase.cs:75
	    // Called from BuildMemberReferences.cs, Line 199
	    // BuildMemberBase.cs:77
	    /// <summary>
	    /// Item class for Observation.hasMember:uSFinding.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:80
	    {                                                                                                                                      // BuildMemberBase.cs:81
	        // Properties                                                                                                                      // BuildMemberBase.cs:82
	        // BuildMemberBase.cs:84
	        /// <summary>
	        /// Value
	        /// </summary>
	        public USFinding Value { get; set; }                                                                                               // BuildMemberBase.cs:87
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
	            this.Value = (USFinding) doc.GetResource(reference);                                                                           // BuildMemberReferences.cs:49
	        }                                                                                                                                  // BuildMemberReferences.cs:50
	    }                                                                                                                                      // BuildMemberBase.cs:115
	    #endregion                                                                                                                             // BuildMemberBase.cs:116
	                                                                                                                                           // BuildMemberBase.cs:167
	    // Properties                                                                                                                          // BuildMemberBase.cs:168
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:139
	    {                                                                                                                                      // BuildMemberBase.cs:140
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/USFinding"                                                            // BuildMemberBase.cs:147
	    };                                                                                                                                     // BuildMemberBase.cs:148
	    #region Common Singleton Properties                                                                                                    // BuildMemberBase.cs:192
	                                                                                                                                           // BuildMemberBase.cs:194
	    // BuildMemberBase.cs:195
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems()                                                                                                        // BuildMemberBase.cs:198
	    {                                                                                                                                      // BuildMemberBase.cs:199
	        if (this.item != null) yield return this.item;                                                                                     // BuildMemberBase.cs:200
	    }                                                                                                                                      // BuildMemberBase.cs:201
	                                                                                                                                           // BuildMemberBase.cs:203
	    // BuildMemberBase.cs:204
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items)                                                                                              // BuildMemberBase.cs:207
	    {                                                                                                                                      // BuildMemberBase.cs:208
	        switch (items.Count())                                                                                                             // BuildMemberBase.cs:209
	        {                                                                                                                                  // BuildMemberBase.cs:210
	            case 0: break;                                                                                                                 // BuildMemberBase.cs:211
	            case 1: this.item = items.First(); break;                                                                                      // BuildMemberBase.cs:212
	            default: throw new Exception("Found multiple elements while reading single item");                                             // BuildMemberBase.cs:213
	        }                                                                                                                                  // BuildMemberBase.cs:214
	    }                                                                                                                                      // BuildMemberBase.cs:215
	                                                                                                                                           // BuildMemberBase.cs:217
	    // BuildMemberBase.cs:218
	    /// <summary>
	    /// Item
	    /// </summary>
	    Item item;                                                                                                                             // BuildMemberBase.cs:221
	                                                                                                                                           // BuildMemberBase.cs:223
	    // BuildMemberBase.cs:224
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => this.item == null ? 0 : 1;                                                                              // BuildMemberBase.cs:227
	                                                                                                                                           // BuildMemberBase.cs:229
	    // BuildMemberBase.cs:230
	    /// <summary>
	    /// Get Item's Value
	    /// </summary>
	    public USFinding Get()                                                                                                                 // BuildMemberBase.cs:233
	    {                                                                                                                                      // BuildMemberBase.cs:234
	        if (item == null)                                                                                                                  // BuildMemberBase.cs:235
	            return null;                                                                                                                   // BuildMemberBase.cs:236
	        return item.Value;                                                                                                                 // BuildMemberBase.cs:237
	    }                                                                                                                                      // BuildMemberBase.cs:238
	                                                                                                                                           // BuildMemberBase.cs:244
	    // BuildMemberBase.cs:245
	    /// <summary>
	    /// Set Item's Value
	    /// </summary>
	    public USFinding Set(USFinding value)                                                                                                  // BuildMemberBase.cs:248
	    {                                                                                                                                      // BuildMemberBase.cs:249
	        Item item = new Item();                                                                                                            // BuildMemberBase.cs:250
	        item.Value = value;                                                                                                                // BuildMemberBase.cs:251
	        this.item = item;                                                                                                                  // BuildMemberBase.cs:252
	        return value;                                                                                                                      // BuildMemberBase.cs:253
	    }                                                                                                                                      // BuildMemberBase.cs:254
	    #endregion                                                                                                                             // BuildMemberBase.cs:330
	                                                                                                                                           // BuildMemberBase.cs:171
	    // BuildMemberBase.cs:172
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public MUSFinding(Int32 min, Int32 max) : base("Observation.hasMember:uSFinding", min, max)                                            // BuildMemberBase.cs:175
	    {                                                                                                                                      // BuildMemberBase.cs:176
	    }                                                                                                                                      // BuildMemberBase.cs:178
	                                                                                                                                           // BuildMemberBase.cs:180
	    // Methods                                                                                                                             // BuildMemberBase.cs:181
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
