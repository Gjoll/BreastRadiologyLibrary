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
	#region Observation.hasMember:consistentWith Container Class                                                                               // BuildMemberBase.cs:137
	/// <summary>
	/// Container class for Observation.hasMember:consistentWith.
	/// </summary>
	public class ConsistentWithContainer : MContainer, ITMItem<ResourceReference>                                                              // BuildMemberBase.cs:141
	{                                                                                                                                          // BuildMemberBase.cs:142
	    #region Observation.hasMember:consistentWith Item Class                                                                                // BuildMemberBase.cs:73
	    /// <summary>
	    /// Item class for Observation.hasMember:consistentWith.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:77
	    {                                                                                                                                      // BuildMemberBase.cs:78
	        // Properties                                                                                                                      // BuildMemberBase.cs:79
	        /// <summary>
	        /// Value
	        /// </summary>
	        public ConsistentWith Value { get; set; }                                                                                          // BuildMemberBase.cs:83
	                                                                                                                                           // BuildMemberBase.cs:85
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(ConsistentWith value)                                                                                                  // BuildMemberBase.cs:89
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
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/ConsistentWith"                                                       // BuildMemberBase.cs:126
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
	    public IEnumerable<ConsistentWith> All()                                                                                               // BuildMemberBase.cs:256
	    {                                                                                                                                      // BuildMemberBase.cs:257
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:258
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:259
	    }                                                                                                                                      // BuildMemberBase.cs:260
	                                                                                                                                           // BuildMemberBase.cs:262
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public ConsistentWith GetAt(Int32 i) => this.items[i].Value;                                                                           // BuildMemberBase.cs:266
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
	    public ConsistentWithContainer(Int32 min, Int32 max) : base("Observation.hasMember:consistentWith", min, max)                          // BuildMemberBase.cs:151
	    {                                                                                                                                      // BuildMemberBase.cs:152
	    }                                                                                                                                      // BuildMemberBase.cs:154
	                                                                                                                                           // BuildMemberBase.cs:155
	    // Methods                                                                                                                             // BuildMemberBase.cs:156
	                                                                                                                                           // BuildMemberBase.cs:284
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public ConsistentWith Append(ConsistentWith value)                                                                                     // BuildMemberBase.cs:288
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
	            Item item = new Item((ConsistentWith) resource);                                                                               // BuildMemberReferences.cs:55
	            items.Add(item);                                                                                                               // BuildMemberReferences.cs:56
	        }                                                                                                                                  // BuildMemberReferences.cs:57
	        this.SetAllItems(items);                                                                                                           // BuildMemberReferences.cs:58
	    }                                                                                                                                      // BuildMemberReferences.cs:59
	}                                                                                                                                          // BuildMemberBase.cs:158
	#endregion                                                                                                                                 // BuildMemberBase.cs:159
	//- LocalClassDefs
}
