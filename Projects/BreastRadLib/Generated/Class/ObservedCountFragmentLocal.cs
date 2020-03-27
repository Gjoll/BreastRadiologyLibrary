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

namespace BreastRadLib.ObservedCountFragmentLocal
{
	//+ LocalClassDefs
	#region Observation.component:obsCount Container Class                                                                                     // BuildMemberBase.cs:174
	// Called from BuildMemberComponents.cs, Line 202
	// BuildMemberBase.cs:176
	/// <summary>
	/// Container class for Observation.component:obsCount.
	/// </summary>
	public class MObsCount : MContainer, ITMItem<Observation.ComponentComponent>                                                               // BuildMemberBase.cs:179
	{                                                                                                                                          // BuildMemberBase.cs:180
	    #region Observation.component:obsCount Item Class                                                                                      // BuildMemberBase.cs:81
	    // Called from BuildMemberComponents.cs, Line 202
	    // BuildMemberBase.cs:83
	    /// <summary>
	    /// Item class for Observation.component:obsCount.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:86
	    {                                                                                                                                      // BuildMemberBase.cs:87
	        // Properties                                                                                                                      // BuildMemberBase.cs:88
	        // BuildMemberBase.cs:90
	        /// <summary>
	        /// Value
	        /// </summary>
	        public Element Value { get; set; }                                                                                                 // BuildMemberBase.cs:93
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
	        public Observation.ComponentComponent WriteItem(BreastRadiologyDocument doc)                                                       // BuildMemberBase.cs:112
	        {                                                                                                                                  // BuildMemberBase.cs:113
	            Observation.ComponentComponent retVal = new Observation.ComponentComponent                                                     // BuildMemberComponents.cs:60
	            {                                                                                                                              // BuildMemberComponents.cs:61
	                Value = this.Value,                                                                                                        // BuildMemberComponents.cs:62
	                Code = ObsCount_ComponentCode()                                                                                            // BuildMemberComponents.cs:63
	            };                                                                                                                             // BuildMemberComponents.cs:64
	            return retVal;                                                                                                                 // BuildMemberBase.cs:116
	        }                                                                                                                                  // BuildMemberBase.cs:117
	                                                                                                                                           // BuildMemberBase.cs:119
	        // BuildMemberBase.cs:120
	        /// <summary>
	        /// Read item.
	        /// </summary>
	        public void ReadItem(BreastRadiologyDocument doc, Observation.ComponentComponent item)                                             // BuildMemberBase.cs:123
	        {                                                                                                                                  // BuildMemberBase.cs:124
	            this.Value = (Element) item.Value;                                                                                             // BuildMemberComponents.cs:53
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
	    public Element Get()                                                                                                                   // BuildMemberBase.cs:249
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
	    public Quantity Set(Quantity value)                                                                                                    // BuildMemberBase.cs:264
	    {                                                                                                                                      // BuildMemberBase.cs:265
	        Item item = new Item();                                                                                                            // BuildMemberBase.cs:266
	        item.Value = value;                                                                                                                // BuildMemberBase.cs:267
	        this.item = item;                                                                                                                  // BuildMemberBase.cs:268
	        return value;                                                                                                                      // BuildMemberBase.cs:269
	    }                                                                                                                                      // BuildMemberBase.cs:270
	                                                                                                                                           // BuildMemberBase.cs:260
	    // BuildMemberBase.cs:261
	    /// <summary>
	    /// Set Item's Value
	    /// </summary>
	    public Range Set(Range value)                                                                                                          // BuildMemberBase.cs:264
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
	    public MObsCount(Int32 min, Int32 max) : base("Observation.component:obsCount", min, max)                                              // BuildMemberBase.cs:191
	    {                                                                                                                                      // BuildMemberBase.cs:192
	    }                                                                                                                                      // BuildMemberBase.cs:194
	                                                                                                                                           // BuildMemberBase.cs:196
	    // Methods                                                                                                                             // BuildMemberBase.cs:197
	    private static CodeableConcept ObsCount_ComponentCode()                                                                                // FhirConstruct.cs:759
	    {                                                                                                                                      // FhirConstruct.cs:760
	        CodeableConcept retVal = new CodeableConcept();                                                                                    // FhirConstruct.cs:761
	        retVal.Coding = new List<Coding>();                                                                                                // FhirConstruct.cs:767
	        {                                                                                                                                  // FhirConstruct.cs:770
	            var temp4 = new Coding();                                                                                                      // FhirConstruct.cs:771
	            temp4.SystemElement = new FhirUri();                                                                                           // FhirConstruct.cs:774
	            temp4.SystemElement.Value = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes";               // FhirConstruct.cs:776
	            temp4.CodeElement = new Code();                                                                                                // FhirConstruct.cs:790
	            temp4.CodeElement.Value = "obsCount";                                                                                          // FhirConstruct.cs:792
	            retVal.Coding.Add(temp4);                                                                                                      // FhirConstruct.cs:819
	        }                                                                                                                                  // FhirConstruct.cs:820
	        return retVal;                                                                                                                     // FhirConstruct.cs:835
	    }                                                                                                                                      // FhirConstruct.cs:836
	                                                                                                                                           // BuildMemberBase.cs:353
	    // BuildMemberBase.cs:354
	    /// <summary>
	    /// Write container items.
	    /// </summary>
	    public IEnumerable<Observation.ComponentComponent> Write(BreastRadiologyDocument doc)                                                  // BuildMemberComponents.cs:97
	    {                                                                                                                                      // BuildMemberComponents.cs:98
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberComponents.cs:99
	        {                                                                                                                                  // BuildMemberComponents.cs:100
	            Observation.ComponentComponent component = item.WriteItem(doc);                                                                // BuildMemberComponents.cs:101
	            yield return component;                                                                                                        // BuildMemberComponents.cs:102
	        }                                                                                                                                  // BuildMemberComponents.cs:103
	    }                                                                                                                                      // BuildMemberComponents.cs:104
	                                                                                                                                           // BuildMemberBase.cs:359
	    // BuildMemberBase.cs:360
	    /// <summary>
	    /// Read container items.
	    /// </summary>
	                                                                                                                                           // BuildMemberComponents.cs:72
	    public void Read(BreastRadiologyDocument doc, IEnumerable<Observation.ComponentComponent> components)                                  // BuildMemberComponents.cs:73
	    {                                                                                                                                      // BuildMemberComponents.cs:74
	        IEnumerable<Observation.ComponentComponent> memberComponents = base.IsMember(doc,                                                  // BuildMemberComponents.cs:75
	            components,                                                                                                                    // BuildMemberComponents.cs:76
	            ObsCount_ComponentCode());                                                                                                     // BuildMemberComponents.cs:77
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberComponents.cs:78
	        foreach (Observation.ComponentComponent memberComponent in memberComponents)                                                       // BuildMemberComponents.cs:79
	        {                                                                                                                                  // BuildMemberComponents.cs:80
	            Item item = new Item();                                                                                                        // BuildMemberComponents.cs:81
	            item.ReadItem(doc, memberComponent);                                                                                           // BuildMemberComponents.cs:82
	            items.Add(item);                                                                                                               // BuildMemberComponents.cs:83
	        }                                                                                                                                  // BuildMemberComponents.cs:84
	        this.SetAllItems(items);                                                                                                           // BuildMemberComponents.cs:85
	    }                                                                                                                                      // BuildMemberComponents.cs:86
	}                                                                                                                                          // BuildMemberBase.cs:199
	#endregion                                                                                                                                 // BuildMemberBase.cs:200
	//- LocalClassDefs
}
