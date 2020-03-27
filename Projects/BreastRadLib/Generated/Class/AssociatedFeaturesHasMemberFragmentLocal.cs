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

namespace BreastRadLib.AssociatedFeaturesHasMemberFragmentLocal
{
	//+ LocalClassDefs
	#region Observation.hasMember:associatedFeature Container Class                                                                            // BuildMemberBase.cs:173
	// Called from BuildMemberReferences.cs, Line 188
	// BuildMemberBase.cs:175
	/// <summary>
	/// Container class for Observation.hasMember:associatedFeature.
	/// </summary>
	public class MAssociatedFeature : MContainer, ITMItem<ResourceReference>                                                                   // BuildMemberBase.cs:178
	{                                                                                                                                          // BuildMemberBase.cs:179
	    #region Observation.hasMember:associatedFeature Item Class                                                                             // BuildMemberBase.cs:81
	    // Called from BuildMemberReferences.cs, Line 188
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
	    #endregion                                                                                                                             // BuildMemberBase.cs:348
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
	                                                                                                                                           // BuildMemberBase.cs:332
	    // BuildMemberBase.cs:333
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public AssociatedFeature Append(AssociatedFeature value)                                                                               // BuildMemberBase.cs:336
	    {                                                                                                                                      // BuildMemberBase.cs:337
	        Item item = new Item();                                                                                                            // BuildMemberBase.cs:338
	        item.Value = value;                                                                                                                // BuildMemberBase.cs:339
	        this.items.Add(item);                                                                                                              // BuildMemberBase.cs:340
	        return value;                                                                                                                      // BuildMemberBase.cs:341
	    }                                                                                                                                      // BuildMemberBase.cs:342
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
