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

namespace BreastRadLib.ConsistentWithHasMemberFragmentLocal
{
	//+ LocalClassDefs
	#region Observation.hasMember:consistentWith Container Class                                                                               // BuildMemberBase.cs:157
	// Called from BuildMemberReferences.cs, Line 197
	// BuildMemberBase.cs:159
	/// <summary>
	/// Container class for Observation.hasMember:consistentWith.
	/// </summary>
	public class ConsistentWithContainer : MContainer, ITMItem<ResourceReference>                                                              // BuildMemberBase.cs:162
	{                                                                                                                                          // BuildMemberBase.cs:163
	    #region Observation.hasMember:consistentWith Item Class                                                                                // BuildMemberBase.cs:75
	    // Called from BuildMemberReferences.cs, Line 197
	    // BuildMemberBase.cs:77
	    /// <summary>
	    /// Item class for Observation.hasMember:consistentWith.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:80
	    {                                                                                                                                      // BuildMemberBase.cs:81
	        // Properties                                                                                                                      // BuildMemberBase.cs:82
	        // BuildMemberBase.cs:83
	        /// <summary>
	        /// Value
	        /// </summary>
	        public ConsistentWith Value { get; set; }                                                                                          // BuildMemberBase.cs:86
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
	            this.Value = (ConsistentWith) doc.GetResource(reference);                                                                      // BuildMemberReferences.cs:49
	        }                                                                                                                                  // BuildMemberReferences.cs:50
	    }                                                                                                                                      // BuildMemberBase.cs:114
	    #endregion                                                                                                                             // BuildMemberBase.cs:115
	                                                                                                                                           // BuildMemberBase.cs:166
	    // Properties                                                                                                                          // BuildMemberBase.cs:167
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:138
	    {                                                                                                                                      // BuildMemberBase.cs:139
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/ConsistentWith"                                                       // BuildMemberBase.cs:146
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
	    public IEnumerable<ConsistentWith> All()                                                                                               // BuildMemberBase.cs:285
	    {                                                                                                                                      // BuildMemberBase.cs:286
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:287
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:288
	    }                                                                                                                                      // BuildMemberBase.cs:289
	                                                                                                                                           // BuildMemberBase.cs:291
	    // BuildMemberBase.cs:292
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public ConsistentWith GetAt(Int32 i) => this.items[i].Value;                                                                           // BuildMemberBase.cs:295
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
	    public ConsistentWithContainer(Int32 min, Int32 max) : base("Observation.hasMember:consistentWith", min, max)                          // BuildMemberBase.cs:174
	    {                                                                                                                                      // BuildMemberBase.cs:175
	    }                                                                                                                                      // BuildMemberBase.cs:177
	                                                                                                                                           // BuildMemberBase.cs:179
	    // Methods                                                                                                                             // BuildMemberBase.cs:180
	                                                                                                                                           // BuildMemberBase.cs:313
	    // BuildMemberBase.cs:314
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public ConsistentWith Append(ConsistentWith value)                                                                                     // BuildMemberBase.cs:317
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
