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
	/// <summary>
	/// Container class for Observation.hasMember:associatedFeature.
	/// </summary>
	public class AssociatedFeatureContainer : MContainer, ITMItem<ResourceReference>                                                           // BuildMemberBase.cs:110
	{                                                                                                                                          // BuildMemberBase.cs:111
	    /// <summary>
	    /// Item class for Observation.hasMember:associatedFeature.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:62
	    {                                                                                                                                      // BuildMemberBase.cs:63
	        // Properties                                                                                                                      // BuildMemberBase.cs:64
	        /// <summary>
	        /// Value
	        /// </summary>
	        public AssociatedFeature Value { get; set; }                                                                                       // BuildMemberBase.cs:68
	                                                                                                                                           // BuildMemberBase.cs:70
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(AssociatedFeature value)                                                                                               // BuildMemberBase.cs:74
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
	        "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AssociatedFeature"                                                    // BuildMemberReferences.cs:54
	    };                                                                                                                                     // BuildMemberReferences.cs:55
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:202
	                                                                                                                                           // BuildMemberBase.cs:204
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:208
	                                                                                                                                           // BuildMemberBase.cs:210
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:214
	                                                                                                                                           // BuildMemberBase.cs:216
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:220
	                                                                                                                                           // BuildMemberBase.cs:222
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<AssociatedFeature> All()                                                                                            // BuildMemberBase.cs:226
	    {                                                                                                                                      // BuildMemberBase.cs:227
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:228
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:229
	    }                                                                                                                                      // BuildMemberBase.cs:230
	                                                                                                                                           // BuildMemberBase.cs:232
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public AssociatedFeature GetAt(Int32 i) => this.items[i].Value;                                                                        // BuildMemberBase.cs:236
	                                                                                                                                           // BuildMemberBase.cs:238
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:242
	                                                                                                                                           // BuildMemberBase.cs:244
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:248
	                                                                                                                                           // BuildMemberBase.cs:116
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public AssociatedFeatureContainer(Int32 min, Int32 max) : base("Observation.hasMember:associatedFeature", min, max)                    // BuildMemberBase.cs:120
	    {                                                                                                                                      // BuildMemberBase.cs:121
	    }                                                                                                                                      // BuildMemberBase.cs:123
	                                                                                                                                           // BuildMemberBase.cs:124
	    // Methods                                                                                                                             // BuildMemberBase.cs:125
	                                                                                                                                           // BuildMemberBase.cs:254
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public AssociatedFeature Append(AssociatedFeature value)                                                                               // BuildMemberBase.cs:258
	    {                                                                                                                                      // BuildMemberBase.cs:259
	        this.items.Add(new Item(value));                                                                                                   // BuildMemberBase.cs:260
	        return value;                                                                                                                      // BuildMemberBase.cs:261
	    }                                                                                                                                      // BuildMemberBase.cs:262
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
	            Item item = new Item((AssociatedFeature) resource);                                                                            // BuildMemberReferences.cs:72
	            items.Add(item);                                                                                                               // BuildMemberReferences.cs:73
	        }                                                                                                                                  // BuildMemberReferences.cs:74
	        this.SetAllItems(items);                                                                                                           // BuildMemberReferences.cs:75
	    }                                                                                                                                      // BuildMemberReferences.cs:76
	}                                                                                                                                          // BuildMemberBase.cs:127
	//- LocalClassDefs
}
