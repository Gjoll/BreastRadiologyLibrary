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
	/// <summary>
	/// Container class for Observation.hasMember:consistentWith.
	/// </summary>
	public class ConsistentWithContainer : MContainer, ITMItem<ResourceReference>                                                              // BuildMemberBase.cs:131
	{                                                                                                                                          // BuildMemberBase.cs:132
	    /// <summary>
	    /// Item class for Observation.hasMember:consistentWith.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:63
	    {                                                                                                                                      // BuildMemberBase.cs:64
	        // Properties                                                                                                                      // BuildMemberBase.cs:65
	        /// <summary>
	        /// Value
	        /// </summary>
	        public ConsistentWith Value { get; set; }                                                                                          // BuildMemberBase.cs:69
	                                                                                                                                           // BuildMemberBase.cs:71
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(ConsistentWith value)                                                                                                  // BuildMemberBase.cs:75
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
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/ConsistentWith"                                                       // BuildMemberBase.cs:117
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
	    public IEnumerable<ConsistentWith> All()                                                                                               // BuildMemberBase.cs:247
	    {                                                                                                                                      // BuildMemberBase.cs:248
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:249
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:250
	    }                                                                                                                                      // BuildMemberBase.cs:251
	                                                                                                                                           // BuildMemberBase.cs:253
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public ConsistentWith GetAt(Int32 i) => this.items[i].Value;                                                                           // BuildMemberBase.cs:257
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
	    public ConsistentWithContainer(Int32 min, Int32 max) : base("Observation.hasMember:consistentWith", min, max)                          // BuildMemberBase.cs:141
	    {                                                                                                                                      // BuildMemberBase.cs:142
	    }                                                                                                                                      // BuildMemberBase.cs:144
	                                                                                                                                           // BuildMemberBase.cs:145
	    // Methods                                                                                                                             // BuildMemberBase.cs:146
	                                                                                                                                           // BuildMemberBase.cs:275
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public ConsistentWith Append(ConsistentWith value)                                                                                     // BuildMemberBase.cs:279
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
	            Item item = new Item((ConsistentWith) resource);                                                                               // BuildMemberReferences.cs:59
	            items.Add(item);                                                                                                               // BuildMemberReferences.cs:60
	        }                                                                                                                                  // BuildMemberReferences.cs:61
	        this.SetAllItems(items);                                                                                                           // BuildMemberReferences.cs:62
	    }                                                                                                                                      // BuildMemberReferences.cs:63
	}                                                                                                                                          // BuildMemberBase.cs:148
	//- LocalClassDefs
}
