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

namespace BreastRadLib.SectionFindingsLeftBreastLocal
{
	//+ LocalClassDefs
	#region Observation.bodySite Container Class                                                                                               // BuildMemberBase.cs:174
	// Called from BuildMemberElement.cs, Line 123
	// BuildMemberBase.cs:176
	/// <summary>
	/// Container class for Observation.bodySite.
	/// </summary>
	public class MBodySite : MContainer, ITMItem<CodeableConcept>                                                                              // BuildMemberBase.cs:179
	{                                                                                                                                          // BuildMemberBase.cs:180
	    #region Observation.bodySite Item Class                                                                                                // BuildMemberBase.cs:81
	    // Called from BuildMemberElement.cs, Line 123
	    // BuildMemberBase.cs:83
	    /// <summary>
	    /// Item class for Observation.bodySite.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:86
	    {                                                                                                                                      // BuildMemberBase.cs:87
	        // Properties                                                                                                                      // BuildMemberBase.cs:88
	        // BuildMemberBase.cs:90
	        /// <summary>
	        /// Value
	        /// </summary>
	        public CodeableConcept Value { get; set; }                                                                                         // BuildMemberBase.cs:93
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
	        public CodeableConcept WriteItem(BreastRadiologyDocument doc)                                                                      // BuildMemberBase.cs:112
	        {                                                                                                                                  // BuildMemberBase.cs:113
	            CodeableConcept retVal = this.Value;                                                                                           // BuildMemberElement.cs:48
	            List<Extension> extensionList = retVal.Extension;                                                                              // BuildMemberElement.cs:49
	            return retVal;                                                                                                                 // BuildMemberBase.cs:116
	        }                                                                                                                                  // BuildMemberBase.cs:117
	                                                                                                                                           // BuildMemberBase.cs:119
	        // BuildMemberBase.cs:120
	        /// <summary>
	        /// Read item.
	        /// </summary>
	        public void ReadItem(BreastRadiologyDocument doc, CodeableConcept item)                                                            // BuildMemberBase.cs:123
	        {                                                                                                                                  // BuildMemberBase.cs:124
	            this.Value = item;                                                                                                             // BuildMemberElement.cs:40
	            List<Extension> extensionList = item.Extension;                                                                                // BuildMemberElement.cs:41
	        }                                                                                                                                  // BuildMemberBase.cs:127
	    }                                                                                                                                      // BuildMemberBase.cs:130
	    #endregion                                                                                                                             // BuildMemberBase.cs:131
	                                                                                                                                           // BuildMemberBase.cs:183
	    // Properties                                                                                                                          // BuildMemberBase.cs:184
	    #region Common Properties (Singleton)                                                                                                  // BuildMemberBase.cs:208
	                                                                                                                                           // BuildMemberBase.cs:210
	    // BuildMemberBase.cs:211
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems()                                                                                                        // BuildMemberBase.cs:214
	    {                                                                                                                                      // BuildMemberBase.cs:215
	        if (this.item != null) yield return this.item;                                                                                     // BuildMemberBase.cs:216
	    }                                                                                                                                      // BuildMemberBase.cs:217
	                                                                                                                                           // BuildMemberBase.cs:219
	    // BuildMemberBase.cs:220
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items)                                                                                              // BuildMemberBase.cs:223
	    {                                                                                                                                      // BuildMemberBase.cs:224
	        switch (items.Count())                                                                                                             // BuildMemberBase.cs:225
	        {                                                                                                                                  // BuildMemberBase.cs:226
	            case 0: break;                                                                                                                 // BuildMemberBase.cs:227
	            case 1: this.item = items.First(); break;                                                                                      // BuildMemberBase.cs:228
	            default: throw new Exception("Found multiple elements while reading single item");                                             // BuildMemberBase.cs:229
	        }                                                                                                                                  // BuildMemberBase.cs:230
	    }                                                                                                                                      // BuildMemberBase.cs:231
	                                                                                                                                           // BuildMemberBase.cs:233
	    // BuildMemberBase.cs:234
	    /// <summary>
	    /// Item
	    /// </summary>
	    Item item;                                                                                                                             // BuildMemberBase.cs:237
	                                                                                                                                           // BuildMemberBase.cs:239
	    // BuildMemberBase.cs:240
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => this.item == null ? 0 : 1;                                                                              // BuildMemberBase.cs:243
	                                                                                                                                           // BuildMemberBase.cs:245
	    // BuildMemberBase.cs:246
	    /// <summary>
	    /// Get Item's Value
	    /// </summary>
	    public CodeableConcept Get()                                                                                                           // BuildMemberBase.cs:249
	    {                                                                                                                                      // BuildMemberBase.cs:250
	        if (item == null)                                                                                                                  // BuildMemberBase.cs:251
	            return null;                                                                                                                   // BuildMemberBase.cs:252
	        return item.Value;                                                                                                                 // BuildMemberBase.cs:253
	    }                                                                                                                                      // BuildMemberBase.cs:254
	                                                                                                                                           // BuildMemberBase.cs:260
	    // BuildMemberBase.cs:261
	    /// <summary>
	    /// Set Item's Value
	    /// </summary>
	    public CodeableConcept Set(CodeableConcept value)                                                                                      // BuildMemberBase.cs:264
	    {                                                                                                                                      // BuildMemberBase.cs:265
	        Item item = new Item();                                                                                                            // BuildMemberBase.cs:266
	        item.Value = value;                                                                                                                // BuildMemberBase.cs:267
	        this.item = item;                                                                                                                  // BuildMemberBase.cs:268
	        return value;                                                                                                                      // BuildMemberBase.cs:269
	    }                                                                                                                                      // BuildMemberBase.cs:270
	    #endregion                                                                                                                             // BuildMemberBase.cs:349
	                                                                                                                                           // BuildMemberBase.cs:187
	    // BuildMemberBase.cs:188
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public MBodySite(Int32 min = 1, Int32 max = 1) : base("Observation.bodySite", min, max)                                                // BuildMemberBase.cs:191
	    {                                                                                                                                      // BuildMemberBase.cs:192
	    }                                                                                                                                      // BuildMemberBase.cs:194
	                                                                                                                                           // BuildMemberBase.cs:196
	    // Methods                                                                                                                             // BuildMemberBase.cs:197
	                                                                                                                                           // BuildMemberBase.cs:353
	    // BuildMemberBase.cs:354
	    /// <summary>
	    /// Write container items.
	    /// </summary>
	    public IEnumerable<CodeableConcept> Write(BreastRadiologyDocument doc)                                                                 // BuildMemberElement.cs:78
	    {                                                                                                                                      // BuildMemberElement.cs:79
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberElement.cs:80
	            yield return item.WriteItem(doc);                                                                                              // BuildMemberElement.cs:81
	    }                                                                                                                                      // BuildMemberElement.cs:82
	                                                                                                                                           // BuildMemberBase.cs:359
	    // BuildMemberBase.cs:360
	    /// <summary>
	    /// Read container items.
	    /// </summary>
	                                                                                                                                           // BuildMemberElement.cs:56
	    public void Read(BreastRadiologyDocument doc, IEnumerable<CodeableConcept> elements)                                                   // BuildMemberElement.cs:57
	    {                                                                                                                                      // BuildMemberElement.cs:58
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberElement.cs:59
	        foreach (Element element in elements)                                                                                              // BuildMemberElement.cs:60
	        {                                                                                                                                  // BuildMemberElement.cs:61
	            Item item = new Item();                                                                                                        // BuildMemberElement.cs:62
	            item.ReadItem(doc, (CodeableConcept) element);                                                                                 // BuildMemberElement.cs:63
	            items.Add(item);                                                                                                               // BuildMemberElement.cs:64
	        }                                                                                                                                  // BuildMemberElement.cs:65
	        this.SetAllItems(items);                                                                                                           // BuildMemberElement.cs:66
	    }                                                                                                                                      // BuildMemberElement.cs:67
	}                                                                                                                                          // BuildMemberBase.cs:199
	#endregion                                                                                                                                 // BuildMemberBase.cs:200
	//- LocalClassDefs
}
