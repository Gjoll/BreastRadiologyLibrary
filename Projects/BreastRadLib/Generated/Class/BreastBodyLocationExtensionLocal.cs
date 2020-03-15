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

namespace BreastRadLib.BreastBodyLocationExtensionLocal
{
	//+ LocalClassDefs
	/// <summary>
	/// Container class for Extension.
	/// </summary>
	public class BreastBodyLocationExtensionCollection : MContainer, ITMItem<Extension>                                                        // BuildMemberBase.cs:135
	{                                                                                                                                          // BuildMemberBase.cs:136
	    /// <summary>
	    /// Item class for Extension.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:67
	    {                                                                                                                                      // BuildMemberBase.cs:68
	        // Properties                                                                                                                      // BuildMemberBase.cs:69
	        /// <summary>
	        /// Value
	        /// </summary>
	        public BreastBodyLocationExtension Value { get; set; }                                                                             // BuildMemberBase.cs:73
	                                                                                                                                           // BuildMemberBase.cs:75
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(BreastBodyLocationExtension value)                                                                                     // BuildMemberBase.cs:79
	        {                                                                                                                                  // BuildMemberBase.cs:80
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:81
	        }                                                                                                                                  // BuildMemberBase.cs:83
	                                                                                                                                           // BuildMemberBase.cs:85
	        // Methods                                                                                                                         // BuildMemberBase.cs:86
	    }                                                                                                                                      // BuildMemberBase.cs:88
	    /// <summary>
	    /// Extension Item class for BreastBodyLocationExtension.
	    /// </summary>
	    public class BreastBodyLocationExtension                                                                                               // BuildMemberExtensionComplex.cs:87
	    {                                                                                                                                      // BuildMemberExtensionComplex.cs:88
	        // Properties                                                                                                                      // BuildMemberExtensionComplex.cs:89
	                                                                                                                                           // BuildMemberExtensionComplex.cs:91
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public BreastBodyLocationExtension()                                                                                               // BuildMemberExtensionComplex.cs:95
	        {                                                                                                                                  // BuildMemberExtensionComplex.cs:96
	        }                                                                                                                                  // BuildMemberExtensionComplex.cs:98
	                                                                                                                                           // BuildMemberExtensionComplex.cs:100
	        // Methods                                                                                                                         // BuildMemberExtensionComplex.cs:101
	    }                                                                                                                                      // BuildMemberExtensionComplex.cs:103
	                                                                                                                                           // BuildMemberBase.cs:138
	    // Properties                                                                                                                          // BuildMemberBase.cs:139
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
	    public IEnumerable<BreastBodyLocationExtension> All()                                                                                  // BuildMemberBase.cs:251
	    {                                                                                                                                      // BuildMemberBase.cs:252
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:253
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:254
	    }                                                                                                                                      // BuildMemberBase.cs:255
	                                                                                                                                           // BuildMemberBase.cs:257
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public BreastBodyLocationExtension GetAt(Int32 i) => this.items[i].Value;                                                              // BuildMemberBase.cs:261
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
	    public BreastBodyLocationExtensionCollection(Int32 min, Int32 max) : base("Extension", min, max)                                       // BuildMemberBase.cs:145
	    {                                                                                                                                      // BuildMemberBase.cs:146
	    }                                                                                                                                      // BuildMemberBase.cs:148
	                                                                                                                                           // BuildMemberBase.cs:149
	    // Methods                                                                                                                             // BuildMemberBase.cs:150
	                                                                                                                                           // BuildMemberBase.cs:279
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public BreastBodyLocationExtension Append(BreastBodyLocationExtension value)                                                           // BuildMemberBase.cs:283
	    {                                                                                                                                      // BuildMemberBase.cs:284
	        this.items.Add(new Item(value));                                                                                                   // BuildMemberBase.cs:285
	        return value;                                                                                                                      // BuildMemberBase.cs:286
	    }                                                                                                                                      // BuildMemberBase.cs:287
	                                                                                                                                           // BuildMemberBase.cs:293
	    /// <summary>
	    /// Write single item as a fhir element.
	    /// </summary>
	    public IEnumerable<Extension> Write(BreastRadiologyDocument doc)                                                                       // BuildMemberExtensionComplex.cs:61
	    {                                                                                                                                      // BuildMemberExtensionComplex.cs:62
	        throw new NotImplementedException();                                                                                               // BuildMemberExtensionComplex.cs:63
	    }                                                                                                                                      // BuildMemberExtensionComplex.cs:73
	                                                                                                                                           // BuildMemberBase.cs:299
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	                                                                                                                                           // BuildMemberExtensionComplex.cs:42
	    public void Read(BreastRadiologyDocument doc, IEnumerable<Extension> components)                                                       // BuildMemberExtensionComplex.cs:43
	    {                                                                                                                                      // BuildMemberExtensionComplex.cs:44
	        throw new NotImplementedException();                                                                                               // BuildMemberExtensionComplex.cs:45
	    }                                                                                                                                      // BuildMemberExtensionComplex.cs:50
	}                                                                                                                                          // BuildMemberBase.cs:152
	//- LocalClassDefs
}
