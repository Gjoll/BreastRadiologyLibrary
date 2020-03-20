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

namespace BreastRadLib.SectionFindingsRightBreastLocal
{
	//+ LocalClassDefs
	#region Observation.bodySite Container Class                                                                                               // BuildMemberBase.cs:158
	// Called from BuildMemberElement.cs, Line 129
	// BuildMemberBase.cs:160
	/// <summary>
	/// Container class for Observation.bodySite.
	/// </summary>
	public class MBodySite : MContainer, ITMItem<CodeableConcept>                                                                              // BuildMemberBase.cs:163
	{                                                                                                                                          // BuildMemberBase.cs:164
	    #region Observation.bodySite Item Class                                                                                                // BuildMemberBase.cs:75
	    // Called from BuildMemberElement.cs, Line 129
	    // BuildMemberBase.cs:77
	    /// <summary>
	    /// Item class for Observation.bodySite.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:80
	    {                                                                                                                                      // BuildMemberBase.cs:81
	        // Properties                                                                                                                      // BuildMemberBase.cs:82
	        // BuildMemberBase.cs:84
	        /// <summary>
	        /// Value
	        /// </summary>
	        public CodeableConcept Value { get; set; }                                                                                         // BuildMemberBase.cs:87
	                                                                                                                                           // BuildMemberBase.cs:90
	        // BuildMemberBase.cs:91
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item()                                                                                                                      // BuildMemberBase.cs:94
	        {                                                                                                                                  // BuildMemberBase.cs:95
	        }                                                                                                                                  // BuildMemberBase.cs:97
	                                                                                                                                           // BuildMemberBase.cs:99
	        // Methods                                                                                                                         // BuildMemberBase.cs:100
	                                                                                                                                           // BuildMemberBase.cs:102
	        // BuildMemberBase.cs:103
	        /// <summary>
	        /// Write item.
	        /// </summary>
	                                                                                                                                           // BuildMemberElement.cs:51
	        public CodeableConcept WriteItem(BreastRadiologyDocument doc)                                                                      // BuildMemberElement.cs:52
	        {                                                                                                                                  // BuildMemberElement.cs:53
	            CodeableConcept retVal = this.Value;                                                                                           // BuildMemberElement.cs:54
	            return retVal;                                                                                                                 // BuildMemberElement.cs:55
	        }                                                                                                                                  // BuildMemberElement.cs:56
	                                                                                                                                           // BuildMemberBase.cs:108
	        // BuildMemberBase.cs:109
	        /// <summary>
	        /// Read item.
	        /// </summary>
	                                                                                                                                           // BuildMemberElement.cs:40
	        public void ReadItem(BreastRadiologyDocument doc, CodeableConcept element)                                                         // BuildMemberElement.cs:41
	        {                                                                                                                                  // BuildMemberElement.cs:42
	            this.Value = element;                                                                                                          // BuildMemberElement.cs:43
	        }                                                                                                                                  // BuildMemberElement.cs:44
	    }                                                                                                                                      // BuildMemberBase.cs:115
	    #endregion                                                                                                                             // BuildMemberBase.cs:116
	                                                                                                                                           // BuildMemberBase.cs:167
	    // Properties                                                                                                                          // BuildMemberBase.cs:168
	    #region Common Properties (Singleton)                                                                                                  // BuildMemberBase.cs:192
	                                                                                                                                           // BuildMemberBase.cs:194
	    // BuildMemberBase.cs:195
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems()                                                                                                        // BuildMemberBase.cs:198
	    {                                                                                                                                      // BuildMemberBase.cs:199
	        if (this.item != null) yield return this.item;                                                                                     // BuildMemberBase.cs:200
	    }                                                                                                                                      // BuildMemberBase.cs:201
	                                                                                                                                           // BuildMemberBase.cs:203
	    // BuildMemberBase.cs:204
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items)                                                                                              // BuildMemberBase.cs:207
	    {                                                                                                                                      // BuildMemberBase.cs:208
	        switch (items.Count())                                                                                                             // BuildMemberBase.cs:209
	        {                                                                                                                                  // BuildMemberBase.cs:210
	            case 0: break;                                                                                                                 // BuildMemberBase.cs:211
	            case 1: this.item = items.First(); break;                                                                                      // BuildMemberBase.cs:212
	            default: throw new Exception("Found multiple elements while reading single item");                                             // BuildMemberBase.cs:213
	        }                                                                                                                                  // BuildMemberBase.cs:214
	    }                                                                                                                                      // BuildMemberBase.cs:215
	                                                                                                                                           // BuildMemberBase.cs:217
	    // BuildMemberBase.cs:218
	    /// <summary>
	    /// Item
	    /// </summary>
	    Item item;                                                                                                                             // BuildMemberBase.cs:221
	                                                                                                                                           // BuildMemberBase.cs:223
	    // BuildMemberBase.cs:224
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => this.item == null ? 0 : 1;                                                                              // BuildMemberBase.cs:227
	                                                                                                                                           // BuildMemberBase.cs:229
	    // BuildMemberBase.cs:230
	    /// <summary>
	    /// Get Item's Value
	    /// </summary>
	    public CodeableConcept Get()                                                                                                           // BuildMemberBase.cs:233
	    {                                                                                                                                      // BuildMemberBase.cs:234
	        if (item == null)                                                                                                                  // BuildMemberBase.cs:235
	            return null;                                                                                                                   // BuildMemberBase.cs:236
	        return item.Value;                                                                                                                 // BuildMemberBase.cs:237
	    }                                                                                                                                      // BuildMemberBase.cs:238
	                                                                                                                                           // BuildMemberBase.cs:244
	    // BuildMemberBase.cs:245
	    /// <summary>
	    /// Set Item's Value
	    /// </summary>
	    public CodeableConcept Set(CodeableConcept value)                                                                                      // BuildMemberBase.cs:248
	    {                                                                                                                                      // BuildMemberBase.cs:249
	        Item item = new Item();                                                                                                            // BuildMemberBase.cs:250
	        item.Value = value;                                                                                                                // BuildMemberBase.cs:251
	        this.item = item;                                                                                                                  // BuildMemberBase.cs:252
	        return value;                                                                                                                      // BuildMemberBase.cs:253
	    }                                                                                                                                      // BuildMemberBase.cs:254
	    #endregion                                                                                                                             // BuildMemberBase.cs:330
	                                                                                                                                           // BuildMemberBase.cs:171
	    // BuildMemberBase.cs:172
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public MBodySite(Int32 min, Int32 max) : base("Observation.bodySite", min, max)                                                        // BuildMemberBase.cs:175
	    {                                                                                                                                      // BuildMemberBase.cs:176
	    }                                                                                                                                      // BuildMemberBase.cs:178
	                                                                                                                                           // BuildMemberBase.cs:180
	    // Methods                                                                                                                             // BuildMemberBase.cs:181
	                                                                                                                                           // BuildMemberBase.cs:334
	    // BuildMemberBase.cs:335
	    /// <summary>
	    /// Write container items.
	    /// </summary>
	    public IEnumerable<CodeableConcept> Write(BreastRadiologyDocument doc)                                                                 // BuildMemberElement.cs:85
	    {                                                                                                                                      // BuildMemberElement.cs:86
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberElement.cs:87
	            yield return item.WriteItem(doc);                                                                                              // BuildMemberElement.cs:88
	    }                                                                                                                                      // BuildMemberElement.cs:89
	                                                                                                                                           // BuildMemberBase.cs:340
	    // BuildMemberBase.cs:341
	    /// <summary>
	    /// Read container items.
	    /// </summary>
	                                                                                                                                           // BuildMemberElement.cs:63
	    public void Read(BreastRadiologyDocument doc, IEnumerable<CodeableConcept> elements)                                                   // BuildMemberElement.cs:64
	    {                                                                                                                                      // BuildMemberElement.cs:65
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberElement.cs:66
	        foreach (Element element in elements)                                                                                              // BuildMemberElement.cs:67
	        {                                                                                                                                  // BuildMemberElement.cs:68
	            Item item = new Item();                                                                                                        // BuildMemberElement.cs:69
	            item.ReadItem(doc, (CodeableConcept) element);                                                                                 // BuildMemberElement.cs:70
	            items.Add(item);                                                                                                               // BuildMemberElement.cs:71
	        }                                                                                                                                  // BuildMemberElement.cs:72
	        this.SetAllItems(items);                                                                                                           // BuildMemberElement.cs:73
	    }                                                                                                                                      // BuildMemberElement.cs:74
	}                                                                                                                                          // BuildMemberBase.cs:183
	#endregion                                                                                                                                 // BuildMemberBase.cs:184
	//- LocalClassDefs
}
