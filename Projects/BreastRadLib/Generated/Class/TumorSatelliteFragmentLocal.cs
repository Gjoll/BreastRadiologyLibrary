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

namespace BreastRadLib.TumorSatelliteFragmentLocal
{
	//+ LocalClassDefs
	/// <summary>
	/// Container class for Observation.hasMember:tumorSatellite.
	/// </summary>
	public class TumorSatelliteContainer : MContainer, ITMItem<ResourceReference>                                                              // BuildMemberBase.cs:135
	{                                                                                                                                          // BuildMemberBase.cs:136
	    /// <summary>
	    /// Item class for Observation.hasMember:tumorSatellite.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:67
	    {                                                                                                                                      // BuildMemberBase.cs:68
	        // Properties                                                                                                                      // BuildMemberBase.cs:69
	        /// <summary>
	        /// Value
	        /// </summary>
	        public TumorSatellite Value { get; set; }                                                                                          // BuildMemberBase.cs:73
	                                                                                                                                           // BuildMemberBase.cs:75
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(TumorSatellite value)                                                                                                  // BuildMemberBase.cs:79
	        {                                                                                                                                  // BuildMemberBase.cs:80
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:81
	        }                                                                                                                                  // BuildMemberBase.cs:83
	                                                                                                                                           // BuildMemberBase.cs:85
	        // Methods                                                                                                                         // BuildMemberBase.cs:86
	    }                                                                                                                                      // BuildMemberBase.cs:88
	                                                                                                                                           // BuildMemberBase.cs:138
	    // Properties                                                                                                                          // BuildMemberBase.cs:139
	    String[] targetUrls = new string[]                                                                                                     // BuildMemberBase.cs:113
	    {                                                                                                                                      // BuildMemberBase.cs:114
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/TumorSatellite"                                                       // BuildMemberBase.cs:121
	    };                                                                                                                                     // BuildMemberBase.cs:122
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:227
	                                                                                                                                           // BuildMemberBase.cs:229
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:233
	                                                                                                                                           // BuildMemberBase.cs:235
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:239
	                                                                                                                                           // BuildMemberBase.cs:241
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:245
	                                                                                                                                           // BuildMemberBase.cs:247
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<TumorSatellite> All()                                                                                               // BuildMemberBase.cs:251
	    {                                                                                                                                      // BuildMemberBase.cs:252
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:253
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:254
	    }                                                                                                                                      // BuildMemberBase.cs:255
	                                                                                                                                           // BuildMemberBase.cs:257
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public TumorSatellite GetAt(Int32 i) => this.items[i].Value;                                                                           // BuildMemberBase.cs:261
	                                                                                                                                           // BuildMemberBase.cs:263
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:267
	                                                                                                                                           // BuildMemberBase.cs:269
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:273
	                                                                                                                                           // BuildMemberBase.cs:141
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public TumorSatelliteContainer(Int32 min, Int32 max) : base("Observation.hasMember:tumorSatellite", min, max)                          // BuildMemberBase.cs:145
	    {                                                                                                                                      // BuildMemberBase.cs:146
	    }                                                                                                                                      // BuildMemberBase.cs:148
	                                                                                                                                           // BuildMemberBase.cs:149
	    // Methods                                                                                                                             // BuildMemberBase.cs:150
	                                                                                                                                           // BuildMemberBase.cs:279
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public TumorSatellite Append(TumorSatellite value)                                                                                     // BuildMemberBase.cs:283
	    {                                                                                                                                      // BuildMemberBase.cs:284
	        this.items.Add(new Item(value));                                                                                                   // BuildMemberBase.cs:285
	        return value;                                                                                                                      // BuildMemberBase.cs:286
	    }                                                                                                                                      // BuildMemberBase.cs:287
	                                                                                                                                           // BuildMemberBase.cs:293
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
	                                                                                                                                           // BuildMemberBase.cs:299
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
	            Item item = new Item((TumorSatellite) resource);                                                                               // BuildMemberReferences.cs:59
	            items.Add(item);                                                                                                               // BuildMemberReferences.cs:60
	        }                                                                                                                                  // BuildMemberReferences.cs:61
	        this.SetAllItems(items);                                                                                                           // BuildMemberReferences.cs:62
	    }                                                                                                                                      // BuildMemberReferences.cs:63
	}                                                                                                                                          // BuildMemberBase.cs:152
	//- LocalClassDefs
}
