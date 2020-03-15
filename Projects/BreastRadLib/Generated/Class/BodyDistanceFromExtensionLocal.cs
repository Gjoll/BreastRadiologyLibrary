using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib;
using BreastRadLib.ExtensionLocal;

//+Usings
//-Usings

namespace BreastRadLib.BodyDistanceFromExtensionLocal
{
	//+ LocalClassDefs
	/// <summary>
	/// Container class for Extension.
	/// </summary>
	public class BodyDistanceFromExtensionCollection : MContainer, ITMItem<Extension>                                                          // BuildMemberBase.cs:137
	{                                                                                                                                          // BuildMemberBase.cs:138
	    /// <summary>
	    /// Item class for Extension.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:73
	    {                                                                                                                                      // BuildMemberBase.cs:74
	        // Properties                                                                                                                      // BuildMemberBase.cs:75
	        /// <summary>
	        /// Value
	        /// </summary>
	        public BodyDistanceFromExtension Value { get; set; }                                                                               // BuildMemberBase.cs:79
	                                                                                                                                           // BuildMemberBase.cs:81
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(BodyDistanceFromExtension value)                                                                                       // BuildMemberBase.cs:85
	        {                                                                                                                                  // BuildMemberBase.cs:86
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:87
	        }                                                                                                                                  // BuildMemberBase.cs:89
	                                                                                                                                           // BuildMemberBase.cs:91
	        // Methods                                                                                                                         // BuildMemberBase.cs:92
	    }                                                                                                                                      // BuildMemberBase.cs:94
	    /// <summary>
	    /// Extension Item class for BodyDistanceFromExtension.
	    /// </summary>
	    public class BodyDistanceFromExtension                                                                                                 // BuildMemberExtensionComplex.cs:82
	    {                                                                                                                                      // BuildMemberExtensionComplex.cs:83
	        // Properties                                                                                                                      // BuildMemberExtensionComplex.cs:84
	                                                                                                                                           // BuildMemberExtensionComplex.cs:86
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public BodyDistanceFromExtension()                                                                                                 // BuildMemberExtensionComplex.cs:90
	        {                                                                                                                                  // BuildMemberExtensionComplex.cs:91
	        }                                                                                                                                  // BuildMemberExtensionComplex.cs:93
	                                                                                                                                           // BuildMemberExtensionComplex.cs:95
	        // Methods                                                                                                                         // BuildMemberExtensionComplex.cs:96
	    }                                                                                                                                      // BuildMemberExtensionComplex.cs:98
	                                                                                                                                           // BuildMemberBase.cs:140
	    // Properties                                                                                                                          // BuildMemberBase.cs:141
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
	    public IEnumerable<BodyDistanceFromExtension> All()                                                                                    // BuildMemberBase.cs:251
	    {                                                                                                                                      // BuildMemberBase.cs:252
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:253
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:254
	    }                                                                                                                                      // BuildMemberBase.cs:255
	                                                                                                                                           // BuildMemberBase.cs:257
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public BodyDistanceFromExtension GetAt(Int32 i) => this.items[i].Value;                                                                // BuildMemberBase.cs:261
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
	                                                                                                                                           // BuildMemberBase.cs:143
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public BodyDistanceFromExtensionCollection(Int32 min, Int32 max) : base("Extension", min, max)                                         // BuildMemberBase.cs:147
	    {                                                                                                                                      // BuildMemberBase.cs:148
	    }                                                                                                                                      // BuildMemberBase.cs:150
	                                                                                                                                           // BuildMemberBase.cs:151
	    // Methods                                                                                                                             // BuildMemberBase.cs:152
	                                                                                                                                           // BuildMemberBase.cs:279
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public BodyDistanceFromExtension Append(BodyDistanceFromExtension value)                                                               // BuildMemberBase.cs:283
	    {                                                                                                                                      // BuildMemberBase.cs:284
	        this.items.Add(new Item(value));                                                                                                   // BuildMemberBase.cs:285
	        return value;                                                                                                                      // BuildMemberBase.cs:286
	    }                                                                                                                                      // BuildMemberBase.cs:287
	                                                                                                                                           // BuildMemberBase.cs:293
	    /// <summary>
	    /// Write single item as a fhir element.
	    /// </summary>
	    public IEnumerable<Extension> Write(BreastRadiologyDocument doc)                                                                       // BuildMemberExtensionComplex.cs:56
	    {                                                                                                                                      // BuildMemberExtensionComplex.cs:57
	        throw new NotImplementedException();                                                                                               // BuildMemberExtensionComplex.cs:58
	    }                                                                                                                                      // BuildMemberExtensionComplex.cs:68
	                                                                                                                                           // BuildMemberBase.cs:299
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	                                                                                                                                           // BuildMemberExtensionComplex.cs:37
	    public void Read(BreastRadiologyDocument doc, IEnumerable<Extension> components)                                                       // BuildMemberExtensionComplex.cs:38
	    {                                                                                                                                      // BuildMemberExtensionComplex.cs:39
	        throw new NotImplementedException();                                                                                               // BuildMemberExtensionComplex.cs:40
	    }                                                                                                                                      // BuildMemberExtensionComplex.cs:45
	}                                                                                                                                          // BuildMemberBase.cs:154
	//- LocalClassDefs
}
