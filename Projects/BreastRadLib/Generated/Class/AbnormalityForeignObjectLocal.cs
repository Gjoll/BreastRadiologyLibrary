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

namespace BreastRadLib.AbnormalityForeignObjectLocal
{
	//+ LocalClassDefs
	#region Observation.component:abnormalityForeignObjectType Container Class                                                                 // BuildMemberBase.cs:173
	// Called from BuildMemberComponents.cs, Line 202
	// BuildMemberBase.cs:175
	/// <summary>
	/// Container class for Observation.component:abnormalityForeignObjectType.
	/// </summary>
	public class MAbnormalityForeignObjectType : MContainer, ITMItem<Observation.ComponentComponent>                                           // BuildMemberBase.cs:178
	{                                                                                                                                          // BuildMemberBase.cs:179
	    #region Observation.component:abnormalityForeignObjectType Item Class                                                                  // BuildMemberBase.cs:81
	    // Called from BuildMemberComponents.cs, Line 202
	    // BuildMemberBase.cs:83
	    /// <summary>
	    /// Item class for Observation.component:abnormalityForeignObjectType.
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
	        public Observation.ComponentComponent WriteItem(BreastRadiologyDocument doc)                                                       // BuildMemberBase.cs:112
	        {                                                                                                                                  // BuildMemberBase.cs:113
	            Observation.ComponentComponent retVal = new Observation.ComponentComponent                                                     // BuildMemberComponents.cs:60
	            {                                                                                                                              // BuildMemberComponents.cs:61
	                Value = this.Value,                                                                                                        // BuildMemberComponents.cs:62
	                Code = AbnormalityForeignObjectType_ComponentCode()                                                                        // BuildMemberComponents.cs:63
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
	            this.Value = (CodeableConcept) item.Value;                                                                                     // BuildMemberComponents.cs:53
	        }                                                                                                                                  // BuildMemberBase.cs:127
	    }                                                                                                                                      // BuildMemberBase.cs:130
	    #endregion                                                                                                                             // BuildMemberBase.cs:131
	                                                                                                                                           // BuildMemberBase.cs:182
	    // Properties                                                                                                                          // BuildMemberBase.cs:183
	    #region Common Properties (Singleton)                                                                                                  // BuildMemberBase.cs:207
	                                                                                                                                           // BuildMemberBase.cs:209
	    // BuildMemberBase.cs:210
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems()                                                                                                        // BuildMemberBase.cs:213
	    {                                                                                                                                      // BuildMemberBase.cs:214
	        if (this.item != null) yield return this.item;                                                                                     // BuildMemberBase.cs:215
	    }                                                                                                                                      // BuildMemberBase.cs:216
	                                                                                                                                           // BuildMemberBase.cs:218
	    // BuildMemberBase.cs:219
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items)                                                                                              // BuildMemberBase.cs:222
	    {                                                                                                                                      // BuildMemberBase.cs:223
	        switch (items.Count())                                                                                                             // BuildMemberBase.cs:224
	        {                                                                                                                                  // BuildMemberBase.cs:225
	            case 0: break;                                                                                                                 // BuildMemberBase.cs:226
	            case 1: this.item = items.First(); break;                                                                                      // BuildMemberBase.cs:227
	            default: throw new Exception("Found multiple elements while reading single item");                                             // BuildMemberBase.cs:228
	        }                                                                                                                                  // BuildMemberBase.cs:229
	    }                                                                                                                                      // BuildMemberBase.cs:230
	                                                                                                                                           // BuildMemberBase.cs:232
	    // BuildMemberBase.cs:233
	    /// <summary>
	    /// Item
	    /// </summary>
	    Item item;                                                                                                                             // BuildMemberBase.cs:236
	                                                                                                                                           // BuildMemberBase.cs:238
	    // BuildMemberBase.cs:239
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => this.item == null ? 0 : 1;                                                                              // BuildMemberBase.cs:242
	                                                                                                                                           // BuildMemberBase.cs:244
	    // BuildMemberBase.cs:245
	    /// <summary>
	    /// Get Item's Value
	    /// </summary>
	    public CodeableConcept Get()                                                                                                           // BuildMemberBase.cs:248
	    {                                                                                                                                      // BuildMemberBase.cs:249
	        if (item == null)                                                                                                                  // BuildMemberBase.cs:250
	            return null;                                                                                                                   // BuildMemberBase.cs:251
	        return item.Value;                                                                                                                 // BuildMemberBase.cs:252
	    }                                                                                                                                      // BuildMemberBase.cs:253
	                                                                                                                                           // BuildMemberBase.cs:259
	    // BuildMemberBase.cs:260
	    /// <summary>
	    /// Set Item's Value
	    /// </summary>
	    public CodeableConcept Set(CodeableConcept value)                                                                                      // BuildMemberBase.cs:263
	    {                                                                                                                                      // BuildMemberBase.cs:264
	        Item item = new Item();                                                                                                            // BuildMemberBase.cs:265
	        item.Value = value;                                                                                                                // BuildMemberBase.cs:266
	        this.item = item;                                                                                                                  // BuildMemberBase.cs:267
	        return value;                                                                                                                      // BuildMemberBase.cs:268
	    }                                                                                                                                      // BuildMemberBase.cs:269
	    #endregion                                                                                                                             // BuildMemberBase.cs:348
	                                                                                                                                           // BuildMemberBase.cs:186
	    // BuildMemberBase.cs:187
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public MAbnormalityForeignObjectType(Int32 min, Int32 max) : base("Observation.component:abnormalityForeignObjectType", min, max)      // BuildMemberBase.cs:190
	    {                                                                                                                                      // BuildMemberBase.cs:191
	    }                                                                                                                                      // BuildMemberBase.cs:193
	                                                                                                                                           // BuildMemberBase.cs:195
	    // Methods                                                                                                                             // BuildMemberBase.cs:196
	    private static CodeableConcept AbnormalityForeignObjectType_ComponentCode()                                                            // FhirConstruct.cs:759
	    {                                                                                                                                      // FhirConstruct.cs:760
	        CodeableConcept retVal = new CodeableConcept();                                                                                    // FhirConstruct.cs:761
	        retVal.Coding = new List<Coding>();                                                                                                // FhirConstruct.cs:767
	        {                                                                                                                                  // FhirConstruct.cs:770
	            var temp4 = new Coding();                                                                                                      // FhirConstruct.cs:771
	            temp4.SystemElement = new FhirUri();                                                                                           // FhirConstruct.cs:774
	            temp4.SystemElement.Value = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes";               // FhirConstruct.cs:776
	            temp4.CodeElement = new Code();                                                                                                // FhirConstruct.cs:790
	            temp4.CodeElement.Value = "abnormalityForeignObjectType";                                                                      // FhirConstruct.cs:792
	            retVal.Coding.Add(temp4);                                                                                                      // FhirConstruct.cs:819
	        }                                                                                                                                  // FhirConstruct.cs:820
	        return retVal;                                                                                                                     // FhirConstruct.cs:835
	    }                                                                                                                                      // FhirConstruct.cs:836
	                                                                                                                                           // BuildMemberBase.cs:352
	    // BuildMemberBase.cs:353
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
	                                                                                                                                           // BuildMemberBase.cs:358
	    // BuildMemberBase.cs:359
	    /// <summary>
	    /// Read container items.
	    /// </summary>
	                                                                                                                                           // BuildMemberComponents.cs:72
	    public void Read(BreastRadiologyDocument doc, IEnumerable<Observation.ComponentComponent> components)                                  // BuildMemberComponents.cs:73
	    {                                                                                                                                      // BuildMemberComponents.cs:74
	        IEnumerable<Observation.ComponentComponent> memberComponents = base.IsMember(doc,                                                  // BuildMemberComponents.cs:75
	            components,                                                                                                                    // BuildMemberComponents.cs:76
	            AbnormalityForeignObjectType_ComponentCode());                                                                                 // BuildMemberComponents.cs:77
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberComponents.cs:78
	        foreach (Observation.ComponentComponent memberComponent in memberComponents)                                                       // BuildMemberComponents.cs:79
	        {                                                                                                                                  // BuildMemberComponents.cs:80
	            Item item = new Item();                                                                                                        // BuildMemberComponents.cs:81
	            item.ReadItem(doc, memberComponent);                                                                                           // BuildMemberComponents.cs:82
	            items.Add(item);                                                                                                               // BuildMemberComponents.cs:83
	        }                                                                                                                                  // BuildMemberComponents.cs:84
	        this.SetAllItems(items);                                                                                                           // BuildMemberComponents.cs:85
	    }                                                                                                                                      // BuildMemberComponents.cs:86
	}                                                                                                                                          // BuildMemberBase.cs:198
	#endregion                                                                                                                                 // BuildMemberBase.cs:199
	//- LocalClassDefs
}
