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

namespace BreastRadLib.ConsistentWithLocal
{
	//+ LocalClassDefs
	#region Observation.component:value Container Class                                                                                        // BuildMemberBase.cs:157
	// Called from BuildMemberComponents.cs, Line 208
	// BuildMemberBase.cs:159
	/// <summary>
	/// Container class for Observation.component:value.
	/// </summary>
	public class ValueContainer : MContainer, ITMItem<Observation.ComponentComponent>                                                          // BuildMemberBase.cs:162
	{                                                                                                                                          // BuildMemberBase.cs:163
	    #region Observation.component:value Item Class                                                                                         // BuildMemberBase.cs:75
	    // Called from BuildMemberComponents.cs, Line 208
	    // BuildMemberBase.cs:77
	    /// <summary>
	    /// Item class for Observation.component:value.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:80
	    {                                                                                                                                      // BuildMemberBase.cs:81
	        // Properties                                                                                                                      // BuildMemberBase.cs:82
	        // BuildMemberBase.cs:83
	        /// <summary>
	        /// Value
	        /// </summary>
	        public CodeableConcept Value { get; set; }                                                                                         // BuildMemberBase.cs:86
	                                                                                                                                           // BuildMemberBase.cs:89
	        // BuildMemberBase.cs:90
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item()                                                                                                                      // BuildMemberBase.cs:93
	        {                                                                                                                                  // BuildMemberBase.cs:94
	        }                                                                                                                                  // BuildMemberBase.cs:96
	                                                                                                                                           // BuildMemberBase.cs:98
	        // Methods                                                                                                                         // BuildMemberBase.cs:99
	                                                                                                                                           // BuildMemberBase.cs:101
	        // BuildMemberBase.cs:102
	        /// <summary>
	        /// Write item.
	        /// </summary>
	        public Observation.ComponentComponent WriteItem(BreastRadiologyDocument doc)                                                       // BuildMemberComponents.cs:63
	        {                                                                                                                                  // BuildMemberComponents.cs:64
	            return new Observation.ComponentComponent                                                                                      // BuildMemberComponents.cs:65
	            {                                                                                                                              // BuildMemberComponents.cs:66
	                Value = this.Value,                                                                                                        // BuildMemberComponents.cs:67
	                Code = Value_ComponentCode()                                                                                               // BuildMemberComponents.cs:68
	            };                                                                                                                             // BuildMemberComponents.cs:69
	        }                                                                                                                                  // BuildMemberComponents.cs:70
	                                                                                                                                           // BuildMemberBase.cs:107
	        // BuildMemberBase.cs:108
	        /// <summary>
	        /// Read item.
	        /// </summary>
	        public void ReadItem(BreastRadiologyDocument doc, Observation.ComponentComponent component)                                        // BuildMemberComponents.cs:53
	        {                                                                                                                                  // BuildMemberComponents.cs:54
	            this.Value = (CodeableConcept) component.Value;                                                                                // BuildMemberComponents.cs:55
	        }                                                                                                                                  // BuildMemberComponents.cs:56
	    }                                                                                                                                      // BuildMemberBase.cs:114
	    #endregion                                                                                                                             // BuildMemberBase.cs:115
	                                                                                                                                           // BuildMemberBase.cs:166
	    // Properties                                                                                                                          // BuildMemberBase.cs:167
	    #region Common Singleton Properties                                                                                                    // BuildMemberBase.cs:191
	                                                                                                                                           // BuildMemberBase.cs:193
	    // BuildMemberBase.cs:194
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems()                                                                                                        // BuildMemberBase.cs:197
	    {                                                                                                                                      // BuildMemberBase.cs:198
	        if (this.item != null) yield return this.item;                                                                                     // BuildMemberBase.cs:199
	    }                                                                                                                                      // BuildMemberBase.cs:200
	                                                                                                                                           // BuildMemberBase.cs:202
	    // BuildMemberBase.cs:203
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items)                                                                                              // BuildMemberBase.cs:206
	    {                                                                                                                                      // BuildMemberBase.cs:207
	        switch (items.Count())                                                                                                             // BuildMemberBase.cs:208
	        {                                                                                                                                  // BuildMemberBase.cs:209
	            case 0: break;                                                                                                                 // BuildMemberBase.cs:210
	            case 1: this.item = items.First(); break;                                                                                      // BuildMemberBase.cs:211
	            default: throw new Exception("Found multiple elements while reading single item");                                             // BuildMemberBase.cs:212
	        }                                                                                                                                  // BuildMemberBase.cs:213
	    }                                                                                                                                      // BuildMemberBase.cs:214
	                                                                                                                                           // BuildMemberBase.cs:216
	    // BuildMemberBase.cs:217
	    /// <summary>
	    /// Item
	    /// </summary>
	    Item item;                                                                                                                             // BuildMemberBase.cs:220
	                                                                                                                                           // BuildMemberBase.cs:222
	    // BuildMemberBase.cs:223
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => this.item == null ? 0 : 1;                                                                              // BuildMemberBase.cs:226
	                                                                                                                                           // BuildMemberBase.cs:228
	    // BuildMemberBase.cs:229
	    /// <summary>
	    /// Get Item's Value
	    /// </summary>
	    public CodeableConcept Get()                                                                                                           // BuildMemberBase.cs:232
	    {                                                                                                                                      // BuildMemberBase.cs:233
	        if (item == null)                                                                                                                  // BuildMemberBase.cs:234
	            return null;                                                                                                                   // BuildMemberBase.cs:235
	        return item.Value;                                                                                                                 // BuildMemberBase.cs:236
	    }                                                                                                                                      // BuildMemberBase.cs:237
	                                                                                                                                           // BuildMemberBase.cs:243
	    // BuildMemberBase.cs:244
	    /// <summary>
	    /// Set Item's Value
	    /// </summary>
	    public CodeableConcept Set(CodeableConcept value)                                                                                      // BuildMemberBase.cs:247
	    {                                                                                                                                      // BuildMemberBase.cs:248
	        Item item = new Item();                                                                                                            // BuildMemberBase.cs:249
	        item.Value = value;                                                                                                                // BuildMemberBase.cs:250
	        this.item = item;                                                                                                                  // BuildMemberBase.cs:251
	        return value;                                                                                                                      // BuildMemberBase.cs:252
	    }                                                                                                                                      // BuildMemberBase.cs:253
	    #endregion                                                                                                                             // BuildMemberBase.cs:329
	                                                                                                                                           // BuildMemberBase.cs:170
	    // BuildMemberBase.cs:171
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public ValueContainer(Int32 min, Int32 max) : base("Observation.component:value", min, max)                                            // BuildMemberBase.cs:174
	    {                                                                                                                                      // BuildMemberBase.cs:175
	    }                                                                                                                                      // BuildMemberBase.cs:177
	                                                                                                                                           // BuildMemberBase.cs:179
	    // Methods                                                                                                                             // BuildMemberBase.cs:180
	    private static CodeableConcept Value_ComponentCode()                                                                                   // FhirConstruct.cs:759
	    {                                                                                                                                      // FhirConstruct.cs:760
	        CodeableConcept retVal = new CodeableConcept();                                                                                    // FhirConstruct.cs:761
	        retVal.Coding = new List<Coding>();                                                                                                // FhirConstruct.cs:767
	        {                                                                                                                                  // FhirConstruct.cs:770
	            var temp4 = new Coding();                                                                                                      // FhirConstruct.cs:771
	            temp4.SystemElement = new FhirUri();                                                                                           // FhirConstruct.cs:774
	            temp4.SystemElement.Value = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes";               // FhirConstruct.cs:776
	            temp4.CodeElement = new Code();                                                                                                // FhirConstruct.cs:790
	            temp4.CodeElement.Value = "consistentWithValue";                                                                               // FhirConstruct.cs:792
	            retVal.Coding.Add(temp4);                                                                                                      // FhirConstruct.cs:819
	        }                                                                                                                                  // FhirConstruct.cs:820
	        return retVal;                                                                                                                     // FhirConstruct.cs:835
	    }                                                                                                                                      // FhirConstruct.cs:836
	                                                                                                                                           // BuildMemberBase.cs:333
	    // BuildMemberBase.cs:334
	    /// <summary>
	    /// Write container items.
	    /// </summary>
	    public IEnumerable<Observation.ComponentComponent> Write(BreastRadiologyDocument doc)                                                  // BuildMemberComponents.cs:103
	    {                                                                                                                                      // BuildMemberComponents.cs:104
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberComponents.cs:105
	        {                                                                                                                                  // BuildMemberComponents.cs:106
	            Observation.ComponentComponent component = item.WriteItem(doc);                                                                // BuildMemberComponents.cs:107
	            yield return component;                                                                                                        // BuildMemberComponents.cs:108
	        }                                                                                                                                  // BuildMemberComponents.cs:109
	    }                                                                                                                                      // BuildMemberComponents.cs:110
	                                                                                                                                           // BuildMemberBase.cs:339
	    // BuildMemberBase.cs:340
	    /// <summary>
	    /// Read container items.
	    /// </summary>
	                                                                                                                                           // BuildMemberComponents.cs:78
	    public void Read(BreastRadiologyDocument doc, IEnumerable<Observation.ComponentComponent> components)                                  // BuildMemberComponents.cs:79
	    {                                                                                                                                      // BuildMemberComponents.cs:80
	        IEnumerable<Observation.ComponentComponent> memberComponents = base.IsMember(doc,                                                  // BuildMemberComponents.cs:81
	            components,                                                                                                                    // BuildMemberComponents.cs:82
	            Value_ComponentCode());                                                                                                        // BuildMemberComponents.cs:83
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberComponents.cs:84
	        foreach (Observation.ComponentComponent memberComponent in memberComponents)                                                       // BuildMemberComponents.cs:85
	        {                                                                                                                                  // BuildMemberComponents.cs:86
	            Item item = new Item();                                                                                                        // BuildMemberComponents.cs:87
	            item.ReadItem(doc, memberComponent);                                                                                           // BuildMemberComponents.cs:88
	            items.Add(item);                                                                                                               // BuildMemberComponents.cs:89
	        }                                                                                                                                  // BuildMemberComponents.cs:90
	        this.SetAllItems(items);                                                                                                           // BuildMemberComponents.cs:91
	    }                                                                                                                                      // BuildMemberComponents.cs:92
	}                                                                                                                                          // BuildMemberBase.cs:182
	#endregion                                                                                                                                 // BuildMemberBase.cs:183
	#region Observation.component:qualifier Container Class                                                                                    // BuildMemberBase.cs:157
	// Called from BuildMemberComponents.cs, Line 208
	// BuildMemberBase.cs:159
	/// <summary>
	/// Container class for Observation.component:qualifier.
	/// </summary>
	public class QualifierContainer : MContainer, ITMItem<Observation.ComponentComponent>                                                      // BuildMemberBase.cs:162
	{                                                                                                                                          // BuildMemberBase.cs:163
	    #region Observation.component:qualifier Item Class                                                                                     // BuildMemberBase.cs:75
	    // Called from BuildMemberComponents.cs, Line 208
	    // BuildMemberBase.cs:77
	    /// <summary>
	    /// Item class for Observation.component:qualifier.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:80
	    {                                                                                                                                      // BuildMemberBase.cs:81
	        // Properties                                                                                                                      // BuildMemberBase.cs:82
	        // BuildMemberBase.cs:83
	        /// <summary>
	        /// Value
	        /// </summary>
	        public CodeableConcept Value { get; set; }                                                                                         // BuildMemberBase.cs:86
	                                                                                                                                           // BuildMemberBase.cs:89
	        // BuildMemberBase.cs:90
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item()                                                                                                                      // BuildMemberBase.cs:93
	        {                                                                                                                                  // BuildMemberBase.cs:94
	        }                                                                                                                                  // BuildMemberBase.cs:96
	                                                                                                                                           // BuildMemberBase.cs:98
	        // Methods                                                                                                                         // BuildMemberBase.cs:99
	                                                                                                                                           // BuildMemberBase.cs:101
	        // BuildMemberBase.cs:102
	        /// <summary>
	        /// Write item.
	        /// </summary>
	        public Observation.ComponentComponent WriteItem(BreastRadiologyDocument doc)                                                       // BuildMemberComponents.cs:63
	        {                                                                                                                                  // BuildMemberComponents.cs:64
	            return new Observation.ComponentComponent                                                                                      // BuildMemberComponents.cs:65
	            {                                                                                                                              // BuildMemberComponents.cs:66
	                Value = this.Value,                                                                                                        // BuildMemberComponents.cs:67
	                Code = Qualifier_ComponentCode()                                                                                           // BuildMemberComponents.cs:68
	            };                                                                                                                             // BuildMemberComponents.cs:69
	        }                                                                                                                                  // BuildMemberComponents.cs:70
	                                                                                                                                           // BuildMemberBase.cs:107
	        // BuildMemberBase.cs:108
	        /// <summary>
	        /// Read item.
	        /// </summary>
	        public void ReadItem(BreastRadiologyDocument doc, Observation.ComponentComponent component)                                        // BuildMemberComponents.cs:53
	        {                                                                                                                                  // BuildMemberComponents.cs:54
	            this.Value = (CodeableConcept) component.Value;                                                                                // BuildMemberComponents.cs:55
	        }                                                                                                                                  // BuildMemberComponents.cs:56
	    }                                                                                                                                      // BuildMemberBase.cs:114
	    #endregion                                                                                                                             // BuildMemberBase.cs:115
	                                                                                                                                           // BuildMemberBase.cs:166
	    // Properties                                                                                                                          // BuildMemberBase.cs:167
	    #region Common Non-Singleton Properties                                                                                                // BuildMemberBase.cs:260
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:261
	                                                                                                                                           // BuildMemberBase.cs:263
	    // BuildMemberBase.cs:264
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:267
	                                                                                                                                           // BuildMemberBase.cs:269
	    // BuildMemberBase.cs:270
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:273
	                                                                                                                                           // BuildMemberBase.cs:275
	    // BuildMemberBase.cs:276
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:279
	                                                                                                                                           // BuildMemberBase.cs:281
	    // BuildMemberBase.cs:282
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<CodeableConcept> All()                                                                                              // BuildMemberBase.cs:285
	    {                                                                                                                                      // BuildMemberBase.cs:286
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:287
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:288
	    }                                                                                                                                      // BuildMemberBase.cs:289
	                                                                                                                                           // BuildMemberBase.cs:291
	    // BuildMemberBase.cs:292
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public CodeableConcept GetAt(Int32 i) => this.items[i].Value;                                                                          // BuildMemberBase.cs:295
	                                                                                                                                           // BuildMemberBase.cs:297
	    // BuildMemberBase.cs:298
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:301
	                                                                                                                                           // BuildMemberBase.cs:303
	    // BuildMemberBase.cs:304
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:307
	    #endregion                                                                                                                             // BuildMemberBase.cs:329
	                                                                                                                                           // BuildMemberBase.cs:170
	    // BuildMemberBase.cs:171
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public QualifierContainer(Int32 min, Int32 max) : base("Observation.component:qualifier", min, max)                                    // BuildMemberBase.cs:174
	    {                                                                                                                                      // BuildMemberBase.cs:175
	    }                                                                                                                                      // BuildMemberBase.cs:177
	                                                                                                                                           // BuildMemberBase.cs:179
	    // Methods                                                                                                                             // BuildMemberBase.cs:180
	    private static CodeableConcept Qualifier_ComponentCode()                                                                               // FhirConstruct.cs:759
	    {                                                                                                                                      // FhirConstruct.cs:760
	        CodeableConcept retVal = new CodeableConcept();                                                                                    // FhirConstruct.cs:761
	        retVal.Coding = new List<Coding>();                                                                                                // FhirConstruct.cs:767
	        {                                                                                                                                  // FhirConstruct.cs:770
	            var temp4 = new Coding();                                                                                                      // FhirConstruct.cs:771
	            temp4.SystemElement = new FhirUri();                                                                                           // FhirConstruct.cs:774
	            temp4.SystemElement.Value = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes";               // FhirConstruct.cs:776
	            temp4.CodeElement = new Code();                                                                                                // FhirConstruct.cs:790
	            temp4.CodeElement.Value = "consistentWithQualifier";                                                                           // FhirConstruct.cs:792
	            retVal.Coding.Add(temp4);                                                                                                      // FhirConstruct.cs:819
	        }                                                                                                                                  // FhirConstruct.cs:820
	        return retVal;                                                                                                                     // FhirConstruct.cs:835
	    }                                                                                                                                      // FhirConstruct.cs:836
	                                                                                                                                           // BuildMemberBase.cs:313
	    // BuildMemberBase.cs:314
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public CodeableConcept Append(CodeableConcept value)                                                                                   // BuildMemberBase.cs:317
	    {                                                                                                                                      // BuildMemberBase.cs:318
	        Item item = new Item();                                                                                                            // BuildMemberBase.cs:319
	        item.Value = value;                                                                                                                // BuildMemberBase.cs:320
	        this.items.Add(item);                                                                                                              // BuildMemberBase.cs:321
	        return value;                                                                                                                      // BuildMemberBase.cs:322
	    }                                                                                                                                      // BuildMemberBase.cs:323
	                                                                                                                                           // BuildMemberBase.cs:333
	    // BuildMemberBase.cs:334
	    /// <summary>
	    /// Write container items.
	    /// </summary>
	    public IEnumerable<Observation.ComponentComponent> Write(BreastRadiologyDocument doc)                                                  // BuildMemberComponents.cs:103
	    {                                                                                                                                      // BuildMemberComponents.cs:104
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberComponents.cs:105
	        {                                                                                                                                  // BuildMemberComponents.cs:106
	            Observation.ComponentComponent component = item.WriteItem(doc);                                                                // BuildMemberComponents.cs:107
	            yield return component;                                                                                                        // BuildMemberComponents.cs:108
	        }                                                                                                                                  // BuildMemberComponents.cs:109
	    }                                                                                                                                      // BuildMemberComponents.cs:110
	                                                                                                                                           // BuildMemberBase.cs:339
	    // BuildMemberBase.cs:340
	    /// <summary>
	    /// Read container items.
	    /// </summary>
	                                                                                                                                           // BuildMemberComponents.cs:78
	    public void Read(BreastRadiologyDocument doc, IEnumerable<Observation.ComponentComponent> components)                                  // BuildMemberComponents.cs:79
	    {                                                                                                                                      // BuildMemberComponents.cs:80
	        IEnumerable<Observation.ComponentComponent> memberComponents = base.IsMember(doc,                                                  // BuildMemberComponents.cs:81
	            components,                                                                                                                    // BuildMemberComponents.cs:82
	            Qualifier_ComponentCode());                                                                                                    // BuildMemberComponents.cs:83
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberComponents.cs:84
	        foreach (Observation.ComponentComponent memberComponent in memberComponents)                                                       // BuildMemberComponents.cs:85
	        {                                                                                                                                  // BuildMemberComponents.cs:86
	            Item item = new Item();                                                                                                        // BuildMemberComponents.cs:87
	            item.ReadItem(doc, memberComponent);                                                                                           // BuildMemberComponents.cs:88
	            items.Add(item);                                                                                                               // BuildMemberComponents.cs:89
	        }                                                                                                                                  // BuildMemberComponents.cs:90
	        this.SetAllItems(items);                                                                                                           // BuildMemberComponents.cs:91
	    }                                                                                                                                      // BuildMemberComponents.cs:92
	}                                                                                                                                          // BuildMemberBase.cs:182
	#endregion                                                                                                                                 // BuildMemberBase.cs:183
	//- LocalClassDefs
}
