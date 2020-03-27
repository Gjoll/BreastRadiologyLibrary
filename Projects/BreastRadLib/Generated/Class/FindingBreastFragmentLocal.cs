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
	#region Observation.hasMember:mGFinding Container Class                                                                                    // BuildMemberBase.cs:173
	// Called from BuildMemberReferences.cs, Line 188
	// BuildMemberBase.cs:175
	/// <summary>
	/// Container class for Observation.hasMember:mGFinding.
	/// </summary>
	public class MMGFinding : MContainer, ITMItem<ResourceReference>                                                                           // BuildMemberBase.cs:178
	{                                                                                                                                          // BuildMemberBase.cs:179
	    #region Observation.hasMember:mGFinding Item Class                                                                                     // BuildMemberBase.cs:81
	    // Called from BuildMemberReferences.cs, Line 188
	    // BuildMemberBase.cs:83
	    /// <summary>
	    /// Item class for Observation.hasMember:mGFinding.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:86
	    {                                                                                                                                      // BuildMemberBase.cs:87
	        // Properties                                                                                                                      // BuildMemberBase.cs:88
	        // BuildMemberBase.cs:90
	        /// <summary>
	        /// Value
	        /// </summary>
	        public MGFinding Value { get; set; }                                                                                               // BuildMemberBase.cs:93
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
	            ResourceReference retVal = this.Value.ResourceReference();                                                                     // BuildMemberReferences.cs:53
	            return retVal;                                                                                                                 // BuildMemberBase.cs:116
	        }                                                                                                                                  // BuildMemberBase.cs:117
	                                                                                                                                           // BuildMemberBase.cs:119
	        // BuildMemberBase.cs:120
	        /// <summary>
	        /// Read item.
	        /// </summary>
	        public void ReadItem(BreastRadiologyDocument doc, ResourceReference item)                                                          // BuildMemberBase.cs:123
	        {                                                                                                                                  // BuildMemberBase.cs:124
	            this.Value = (MGFinding) doc.GetResource(item);                                                                                // BuildMemberReferences.cs:46
	        }                                                                                                                                  // BuildMemberBase.cs:127
	    }                                                                                                                                      // BuildMemberBase.cs:130
	    #endregion                                                                                                                             // BuildMemberBase.cs:131
	                                                                                                                                           // BuildMemberBase.cs:182
	    // Properties                                                                                                                          // BuildMemberBase.cs:183
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:154
	    {                                                                                                                                      // BuildMemberBase.cs:155
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGFinding"                                                            // BuildMemberBase.cs:162
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
	    public MGFinding Get()                                                                                                                 // BuildMemberBase.cs:248
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
	    public MGFinding Set(MGFinding value)                                                                                                  // BuildMemberBase.cs:263
	    {                                                                                                                                      // BuildMemberBase.cs:264
	        Item item = new Item();                                                                                                            // BuildMemberBase.cs:265
	        item.Value = value;                                                                                                                // BuildMemberBase.cs:266
	        this.item = item;                                                                                                                  // BuildMemberBase.cs:267
	        return value;                                                                                                                      // BuildMemberBase.cs:268
	    }                                                                                                                                      // BuildMemberBase.cs:269
	    #endregion                                                                                                                             // BuildMemberBase.cs:348
	                                                                                                                                           // BuildMemberBase.cs:186
	    // BuildMemberBase.cs:187
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public MMGFinding(Int32 min, Int32 max) : base("Observation.hasMember:mGFinding", min, max)                                            // BuildMemberBase.cs:190
	    {                                                                                                                                      // BuildMemberBase.cs:191
	    }                                                                                                                                      // BuildMemberBase.cs:193
	                                                                                                                                           // BuildMemberBase.cs:195
	    // Methods                                                                                                                             // BuildMemberBase.cs:196
	                                                                                                                                           // BuildMemberBase.cs:352
	    // BuildMemberBase.cs:353
	    /// <summary>
	    /// Write container items.
	    /// </summary>
	    public IEnumerable<ResourceReference> Write(BreastRadiologyDocument doc)                                                               // BuildMemberReferences.cs:85
	    {                                                                                                                                      // BuildMemberReferences.cs:86
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberReferences.cs:87
	        {                                                                                                                                  // BuildMemberReferences.cs:88
	            ResourceReference reference = item.WriteItem(doc);                                                                             // BuildMemberReferences.cs:89
	            yield return reference;                                                                                                        // BuildMemberReferences.cs:90
	        }                                                                                                                                  // BuildMemberReferences.cs:91
	    }                                                                                                                                      // BuildMemberReferences.cs:92
	                                                                                                                                           // BuildMemberBase.cs:358
	    // BuildMemberBase.cs:359
	    /// <summary>
	    /// Read container items.
	    /// </summary>
	                                                                                                                                           // BuildMemberReferences.cs:60
	    public void Read(BreastRadiologyDocument doc, IEnumerable<ResourceReference> references)                                               // BuildMemberReferences.cs:61
	    {                                                                                                                                      // BuildMemberReferences.cs:62
	        IEnumerable<ResourceReference> resourceReferences = base.IsMember(doc,                                                             // BuildMemberReferences.cs:63
	            references,                                                                                                                    // BuildMemberReferences.cs:64
	            this.targetUrls);                                                                                                              // BuildMemberReferences.cs:65
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberReferences.cs:66
	        foreach (ResourceReference resourceReference in resourceReferences)                                                                // BuildMemberReferences.cs:67
	        {                                                                                                                                  // BuildMemberReferences.cs:68
	            Item item = new Item();                                                                                                        // BuildMemberReferences.cs:69
	            item.ReadItem(doc, resourceReference);                                                                                         // BuildMemberReferences.cs:70
	            items.Add(item);                                                                                                               // BuildMemberReferences.cs:71
	        }                                                                                                                                  // BuildMemberReferences.cs:72
	        this.SetAllItems(items);                                                                                                           // BuildMemberReferences.cs:73
	    }                                                                                                                                      // BuildMemberReferences.cs:74
	}                                                                                                                                          // BuildMemberBase.cs:198
	#endregion                                                                                                                                 // BuildMemberBase.cs:199
	#region Observation.hasMember:mRIFinding Container Class                                                                                   // BuildMemberBase.cs:173
	// Called from BuildMemberReferences.cs, Line 188
	// BuildMemberBase.cs:175
	/// <summary>
	/// Container class for Observation.hasMember:mRIFinding.
	/// </summary>
	public class MMRIFinding : MContainer, ITMItem<ResourceReference>                                                                          // BuildMemberBase.cs:178
	{                                                                                                                                          // BuildMemberBase.cs:179
	    #region Observation.hasMember:mRIFinding Item Class                                                                                    // BuildMemberBase.cs:81
	    // Called from BuildMemberReferences.cs, Line 188
	    // BuildMemberBase.cs:83
	    /// <summary>
	    /// Item class for Observation.hasMember:mRIFinding.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:86
	    {                                                                                                                                      // BuildMemberBase.cs:87
	        // Properties                                                                                                                      // BuildMemberBase.cs:88
	        // BuildMemberBase.cs:90
	        /// <summary>
	        /// Value
	        /// </summary>
	        public MRIFinding Value { get; set; }                                                                                              // BuildMemberBase.cs:93
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
	            ResourceReference retVal = this.Value.ResourceReference();                                                                     // BuildMemberReferences.cs:53
	            return retVal;                                                                                                                 // BuildMemberBase.cs:116
	        }                                                                                                                                  // BuildMemberBase.cs:117
	                                                                                                                                           // BuildMemberBase.cs:119
	        // BuildMemberBase.cs:120
	        /// <summary>
	        /// Read item.
	        /// </summary>
	        public void ReadItem(BreastRadiologyDocument doc, ResourceReference item)                                                          // BuildMemberBase.cs:123
	        {                                                                                                                                  // BuildMemberBase.cs:124
	            this.Value = (MRIFinding) doc.GetResource(item);                                                                               // BuildMemberReferences.cs:46
	        }                                                                                                                                  // BuildMemberBase.cs:127
	    }                                                                                                                                      // BuildMemberBase.cs:130
	    #endregion                                                                                                                             // BuildMemberBase.cs:131
	                                                                                                                                           // BuildMemberBase.cs:182
	    // Properties                                                                                                                          // BuildMemberBase.cs:183
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:154
	    {                                                                                                                                      // BuildMemberBase.cs:155
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MRIFinding"                                                           // BuildMemberBase.cs:162
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
	    public MRIFinding Get()                                                                                                                // BuildMemberBase.cs:248
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
	    public MRIFinding Set(MRIFinding value)                                                                                                // BuildMemberBase.cs:263
	    {                                                                                                                                      // BuildMemberBase.cs:264
	        Item item = new Item();                                                                                                            // BuildMemberBase.cs:265
	        item.Value = value;                                                                                                                // BuildMemberBase.cs:266
	        this.item = item;                                                                                                                  // BuildMemberBase.cs:267
	        return value;                                                                                                                      // BuildMemberBase.cs:268
	    }                                                                                                                                      // BuildMemberBase.cs:269
	    #endregion                                                                                                                             // BuildMemberBase.cs:348
	                                                                                                                                           // BuildMemberBase.cs:186
	    // BuildMemberBase.cs:187
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public MMRIFinding(Int32 min, Int32 max) : base("Observation.hasMember:mRIFinding", min, max)                                          // BuildMemberBase.cs:190
	    {                                                                                                                                      // BuildMemberBase.cs:191
	    }                                                                                                                                      // BuildMemberBase.cs:193
	                                                                                                                                           // BuildMemberBase.cs:195
	    // Methods                                                                                                                             // BuildMemberBase.cs:196
	                                                                                                                                           // BuildMemberBase.cs:352
	    // BuildMemberBase.cs:353
	    /// <summary>
	    /// Write container items.
	    /// </summary>
	    public IEnumerable<ResourceReference> Write(BreastRadiologyDocument doc)                                                               // BuildMemberReferences.cs:85
	    {                                                                                                                                      // BuildMemberReferences.cs:86
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberReferences.cs:87
	        {                                                                                                                                  // BuildMemberReferences.cs:88
	            ResourceReference reference = item.WriteItem(doc);                                                                             // BuildMemberReferences.cs:89
	            yield return reference;                                                                                                        // BuildMemberReferences.cs:90
	        }                                                                                                                                  // BuildMemberReferences.cs:91
	    }                                                                                                                                      // BuildMemberReferences.cs:92
	                                                                                                                                           // BuildMemberBase.cs:358
	    // BuildMemberBase.cs:359
	    /// <summary>
	    /// Read container items.
	    /// </summary>
	                                                                                                                                           // BuildMemberReferences.cs:60
	    public void Read(BreastRadiologyDocument doc, IEnumerable<ResourceReference> references)                                               // BuildMemberReferences.cs:61
	    {                                                                                                                                      // BuildMemberReferences.cs:62
	        IEnumerable<ResourceReference> resourceReferences = base.IsMember(doc,                                                             // BuildMemberReferences.cs:63
	            references,                                                                                                                    // BuildMemberReferences.cs:64
	            this.targetUrls);                                                                                                              // BuildMemberReferences.cs:65
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberReferences.cs:66
	        foreach (ResourceReference resourceReference in resourceReferences)                                                                // BuildMemberReferences.cs:67
	        {                                                                                                                                  // BuildMemberReferences.cs:68
	            Item item = new Item();                                                                                                        // BuildMemberReferences.cs:69
	            item.ReadItem(doc, resourceReference);                                                                                         // BuildMemberReferences.cs:70
	            items.Add(item);                                                                                                               // BuildMemberReferences.cs:71
	        }                                                                                                                                  // BuildMemberReferences.cs:72
	        this.SetAllItems(items);                                                                                                           // BuildMemberReferences.cs:73
	    }                                                                                                                                      // BuildMemberReferences.cs:74
	}                                                                                                                                          // BuildMemberBase.cs:198
	#endregion                                                                                                                                 // BuildMemberBase.cs:199
	#region Observation.hasMember:nMFinding Container Class                                                                                    // BuildMemberBase.cs:173
	// Called from BuildMemberReferences.cs, Line 188
	// BuildMemberBase.cs:175
	/// <summary>
	/// Container class for Observation.hasMember:nMFinding.
	/// </summary>
	public class MNMFinding : MContainer, ITMItem<ResourceReference>                                                                           // BuildMemberBase.cs:178
	{                                                                                                                                          // BuildMemberBase.cs:179
	    #region Observation.hasMember:nMFinding Item Class                                                                                     // BuildMemberBase.cs:81
	    // Called from BuildMemberReferences.cs, Line 188
	    // BuildMemberBase.cs:83
	    /// <summary>
	    /// Item class for Observation.hasMember:nMFinding.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:86
	    {                                                                                                                                      // BuildMemberBase.cs:87
	        // Properties                                                                                                                      // BuildMemberBase.cs:88
	        // BuildMemberBase.cs:90
	        /// <summary>
	        /// Value
	        /// </summary>
	        public NMFinding Value { get; set; }                                                                                               // BuildMemberBase.cs:93
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
	            ResourceReference retVal = this.Value.ResourceReference();                                                                     // BuildMemberReferences.cs:53
	            return retVal;                                                                                                                 // BuildMemberBase.cs:116
	        }                                                                                                                                  // BuildMemberBase.cs:117
	                                                                                                                                           // BuildMemberBase.cs:119
	        // BuildMemberBase.cs:120
	        /// <summary>
	        /// Read item.
	        /// </summary>
	        public void ReadItem(BreastRadiologyDocument doc, ResourceReference item)                                                          // BuildMemberBase.cs:123
	        {                                                                                                                                  // BuildMemberBase.cs:124
	            this.Value = (NMFinding) doc.GetResource(item);                                                                                // BuildMemberReferences.cs:46
	        }                                                                                                                                  // BuildMemberBase.cs:127
	    }                                                                                                                                      // BuildMemberBase.cs:130
	    #endregion                                                                                                                             // BuildMemberBase.cs:131
	                                                                                                                                           // BuildMemberBase.cs:182
	    // Properties                                                                                                                          // BuildMemberBase.cs:183
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:154
	    {                                                                                                                                      // BuildMemberBase.cs:155
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/NMFinding"                                                            // BuildMemberBase.cs:162
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
	    public NMFinding Get()                                                                                                                 // BuildMemberBase.cs:248
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
	    public NMFinding Set(NMFinding value)                                                                                                  // BuildMemberBase.cs:263
	    {                                                                                                                                      // BuildMemberBase.cs:264
	        Item item = new Item();                                                                                                            // BuildMemberBase.cs:265
	        item.Value = value;                                                                                                                // BuildMemberBase.cs:266
	        this.item = item;                                                                                                                  // BuildMemberBase.cs:267
	        return value;                                                                                                                      // BuildMemberBase.cs:268
	    }                                                                                                                                      // BuildMemberBase.cs:269
	    #endregion                                                                                                                             // BuildMemberBase.cs:348
	                                                                                                                                           // BuildMemberBase.cs:186
	    // BuildMemberBase.cs:187
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public MNMFinding(Int32 min, Int32 max) : base("Observation.hasMember:nMFinding", min, max)                                            // BuildMemberBase.cs:190
	    {                                                                                                                                      // BuildMemberBase.cs:191
	    }                                                                                                                                      // BuildMemberBase.cs:193
	                                                                                                                                           // BuildMemberBase.cs:195
	    // Methods                                                                                                                             // BuildMemberBase.cs:196
	                                                                                                                                           // BuildMemberBase.cs:352
	    // BuildMemberBase.cs:353
	    /// <summary>
	    /// Write container items.
	    /// </summary>
	    public IEnumerable<ResourceReference> Write(BreastRadiologyDocument doc)                                                               // BuildMemberReferences.cs:85
	    {                                                                                                                                      // BuildMemberReferences.cs:86
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberReferences.cs:87
	        {                                                                                                                                  // BuildMemberReferences.cs:88
	            ResourceReference reference = item.WriteItem(doc);                                                                             // BuildMemberReferences.cs:89
	            yield return reference;                                                                                                        // BuildMemberReferences.cs:90
	        }                                                                                                                                  // BuildMemberReferences.cs:91
	    }                                                                                                                                      // BuildMemberReferences.cs:92
	                                                                                                                                           // BuildMemberBase.cs:358
	    // BuildMemberBase.cs:359
	    /// <summary>
	    /// Read container items.
	    /// </summary>
	                                                                                                                                           // BuildMemberReferences.cs:60
	    public void Read(BreastRadiologyDocument doc, IEnumerable<ResourceReference> references)                                               // BuildMemberReferences.cs:61
	    {                                                                                                                                      // BuildMemberReferences.cs:62
	        IEnumerable<ResourceReference> resourceReferences = base.IsMember(doc,                                                             // BuildMemberReferences.cs:63
	            references,                                                                                                                    // BuildMemberReferences.cs:64
	            this.targetUrls);                                                                                                              // BuildMemberReferences.cs:65
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberReferences.cs:66
	        foreach (ResourceReference resourceReference in resourceReferences)                                                                // BuildMemberReferences.cs:67
	        {                                                                                                                                  // BuildMemberReferences.cs:68
	            Item item = new Item();                                                                                                        // BuildMemberReferences.cs:69
	            item.ReadItem(doc, resourceReference);                                                                                         // BuildMemberReferences.cs:70
	            items.Add(item);                                                                                                               // BuildMemberReferences.cs:71
	        }                                                                                                                                  // BuildMemberReferences.cs:72
	        this.SetAllItems(items);                                                                                                           // BuildMemberReferences.cs:73
	    }                                                                                                                                      // BuildMemberReferences.cs:74
	}                                                                                                                                          // BuildMemberBase.cs:198
	#endregion                                                                                                                                 // BuildMemberBase.cs:199
	#region Observation.hasMember:uSFinding Container Class                                                                                    // BuildMemberBase.cs:173
	// Called from BuildMemberReferences.cs, Line 188
	// BuildMemberBase.cs:175
	/// <summary>
	/// Container class for Observation.hasMember:uSFinding.
	/// </summary>
	public class MUSFinding : MContainer, ITMItem<ResourceReference>                                                                           // BuildMemberBase.cs:178
	{                                                                                                                                          // BuildMemberBase.cs:179
	    #region Observation.hasMember:uSFinding Item Class                                                                                     // BuildMemberBase.cs:81
	    // Called from BuildMemberReferences.cs, Line 188
	    // BuildMemberBase.cs:83
	    /// <summary>
	    /// Item class for Observation.hasMember:uSFinding.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:86
	    {                                                                                                                                      // BuildMemberBase.cs:87
	        // Properties                                                                                                                      // BuildMemberBase.cs:88
	        // BuildMemberBase.cs:90
	        /// <summary>
	        /// Value
	        /// </summary>
	        public USFinding Value { get; set; }                                                                                               // BuildMemberBase.cs:93
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
	            ResourceReference retVal = this.Value.ResourceReference();                                                                     // BuildMemberReferences.cs:53
	            return retVal;                                                                                                                 // BuildMemberBase.cs:116
	        }                                                                                                                                  // BuildMemberBase.cs:117
	                                                                                                                                           // BuildMemberBase.cs:119
	        // BuildMemberBase.cs:120
	        /// <summary>
	        /// Read item.
	        /// </summary>
	        public void ReadItem(BreastRadiologyDocument doc, ResourceReference item)                                                          // BuildMemberBase.cs:123
	        {                                                                                                                                  // BuildMemberBase.cs:124
	            this.Value = (USFinding) doc.GetResource(item);                                                                                // BuildMemberReferences.cs:46
	        }                                                                                                                                  // BuildMemberBase.cs:127
	    }                                                                                                                                      // BuildMemberBase.cs:130
	    #endregion                                                                                                                             // BuildMemberBase.cs:131
	                                                                                                                                           // BuildMemberBase.cs:182
	    // Properties                                                                                                                          // BuildMemberBase.cs:183
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:154
	    {                                                                                                                                      // BuildMemberBase.cs:155
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/USFinding"                                                            // BuildMemberBase.cs:162
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
	    public USFinding Get()                                                                                                                 // BuildMemberBase.cs:248
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
	    public USFinding Set(USFinding value)                                                                                                  // BuildMemberBase.cs:263
	    {                                                                                                                                      // BuildMemberBase.cs:264
	        Item item = new Item();                                                                                                            // BuildMemberBase.cs:265
	        item.Value = value;                                                                                                                // BuildMemberBase.cs:266
	        this.item = item;                                                                                                                  // BuildMemberBase.cs:267
	        return value;                                                                                                                      // BuildMemberBase.cs:268
	    }                                                                                                                                      // BuildMemberBase.cs:269
	    #endregion                                                                                                                             // BuildMemberBase.cs:348
	                                                                                                                                           // BuildMemberBase.cs:186
	    // BuildMemberBase.cs:187
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public MUSFinding(Int32 min, Int32 max) : base("Observation.hasMember:uSFinding", min, max)                                            // BuildMemberBase.cs:190
	    {                                                                                                                                      // BuildMemberBase.cs:191
	    }                                                                                                                                      // BuildMemberBase.cs:193
	                                                                                                                                           // BuildMemberBase.cs:195
	    // Methods                                                                                                                             // BuildMemberBase.cs:196
	                                                                                                                                           // BuildMemberBase.cs:352
	    // BuildMemberBase.cs:353
	    /// <summary>
	    /// Write container items.
	    /// </summary>
	    public IEnumerable<ResourceReference> Write(BreastRadiologyDocument doc)                                                               // BuildMemberReferences.cs:85
	    {                                                                                                                                      // BuildMemberReferences.cs:86
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberReferences.cs:87
	        {                                                                                                                                  // BuildMemberReferences.cs:88
	            ResourceReference reference = item.WriteItem(doc);                                                                             // BuildMemberReferences.cs:89
	            yield return reference;                                                                                                        // BuildMemberReferences.cs:90
	        }                                                                                                                                  // BuildMemberReferences.cs:91
	    }                                                                                                                                      // BuildMemberReferences.cs:92
	                                                                                                                                           // BuildMemberBase.cs:358
	    // BuildMemberBase.cs:359
	    /// <summary>
	    /// Read container items.
	    /// </summary>
	                                                                                                                                           // BuildMemberReferences.cs:60
	    public void Read(BreastRadiologyDocument doc, IEnumerable<ResourceReference> references)                                               // BuildMemberReferences.cs:61
	    {                                                                                                                                      // BuildMemberReferences.cs:62
	        IEnumerable<ResourceReference> resourceReferences = base.IsMember(doc,                                                             // BuildMemberReferences.cs:63
	            references,                                                                                                                    // BuildMemberReferences.cs:64
	            this.targetUrls);                                                                                                              // BuildMemberReferences.cs:65
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberReferences.cs:66
	        foreach (ResourceReference resourceReference in resourceReferences)                                                                // BuildMemberReferences.cs:67
	        {                                                                                                                                  // BuildMemberReferences.cs:68
	            Item item = new Item();                                                                                                        // BuildMemberReferences.cs:69
	            item.ReadItem(doc, resourceReference);                                                                                         // BuildMemberReferences.cs:70
	            items.Add(item);                                                                                                               // BuildMemberReferences.cs:71
	        }                                                                                                                                  // BuildMemberReferences.cs:72
	        this.SetAllItems(items);                                                                                                           // BuildMemberReferences.cs:73
	    }                                                                                                                                      // BuildMemberReferences.cs:74
	}                                                                                                                                          // BuildMemberBase.cs:198
	#endregion                                                                                                                                 // BuildMemberBase.cs:199
	//- LocalClassDefs
}
