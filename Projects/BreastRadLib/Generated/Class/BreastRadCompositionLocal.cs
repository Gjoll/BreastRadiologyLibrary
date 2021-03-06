using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib;
using BreastRadLib.CompositionLocal;

//+Usings
//-Usings

namespace BreastRadLib.BreastRadCompositionLocal
{
	//+ LocalClassDefs
	#region Composition.section:report Container Class                                                                                         // BuildMemberBase.cs:174
	// Called from BuildMemberSection.cs, Line 225
	// BuildMemberBase.cs:176
	/// <summary>
	/// Container class for Composition.section:report.
	/// </summary>
	public class MReport : MContainer, ITMItem<Composition.SectionComponent>                                                                   // BuildMemberBase.cs:179
	{                                                                                                                                          // BuildMemberBase.cs:180
	    #region Composition.section:report Item Class                                                                                          // BuildMemberBase.cs:81
	    // Called from BuildMemberSection.cs, Line 225
	    // BuildMemberBase.cs:83
	    /// <summary>
	    /// Item class for Composition.section:report.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:86
	    {                                                                                                                                      // BuildMemberBase.cs:87
	        // Properties                                                                                                                      // BuildMemberBase.cs:88
	        // BuildMemberBase.cs:90
	        /// <summary>
	        /// Value
	        /// </summary>
	        public BreastRadReport Value { get; set; }                                                                                         // BuildMemberBase.cs:93
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
	        public ResourceReference WriteItem(BreastRadiologyDocument doc)                                                                    // BuildMemberBase.cs:112
	        {                                                                                                                                  // BuildMemberBase.cs:113
	            ResourceReference retVal = this.Value.ResourceReference();                                                                     // BuildMemberSection.cs:62
	            return retVal;                                                                                                                 // BuildMemberBase.cs:116
	        }                                                                                                                                  // BuildMemberBase.cs:117
	                                                                                                                                           // BuildMemberBase.cs:119
	        // BuildMemberBase.cs:120
	        /// <summary>
	        /// Read item.
	        /// </summary>
	        public void ReadItem(BreastRadiologyDocument doc, ResourceReference item)                                                          // BuildMemberBase.cs:123
	        {                                                                                                                                  // BuildMemberBase.cs:124
	            this.Value = (BreastRadReport) doc.GetResource(item);                                                                          // BuildMemberSection.cs:55
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
	    public BreastRadReport Get()                                                                                                           // BuildMemberBase.cs:249
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
	    public BreastRadReport Set(BreastRadReport value)                                                                                      // BuildMemberBase.cs:264
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
	    public MReport(Int32 min = 1, Int32 max = 1) : base("Composition.section:report", min, max)                                            // BuildMemberBase.cs:191
	    {                                                                                                                                      // BuildMemberBase.cs:192
	    }                                                                                                                                      // BuildMemberBase.cs:194
	                                                                                                                                           // BuildMemberBase.cs:196
	    // Methods                                                                                                                             // BuildMemberBase.cs:197
	    public CodeableConcept SectionCode()                                                                                                   // FhirConstruct.cs:759
	    {                                                                                                                                      // FhirConstruct.cs:760
	        CodeableConcept retVal = new CodeableConcept();                                                                                    // FhirConstruct.cs:761
	        retVal.Coding = new List<Coding>();                                                                                                // FhirConstruct.cs:767
	        {                                                                                                                                  // FhirConstruct.cs:770
	            var temp4 = new Coding();                                                                                                      // FhirConstruct.cs:771
	            temp4.SystemElement = new FhirUri();                                                                                           // FhirConstruct.cs:774
	            temp4.SystemElement.Value = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes";                 // FhirConstruct.cs:776
	            temp4.CodeElement = new Code();                                                                                                // FhirConstruct.cs:790
	            temp4.CodeElement.Value = "sectionReport";                                                                                     // FhirConstruct.cs:792
	            retVal.Coding.Add(temp4);                                                                                                      // FhirConstruct.cs:819
	        }                                                                                                                                  // FhirConstruct.cs:820
	        return retVal;                                                                                                                     // FhirConstruct.cs:835
	    }                                                                                                                                      // FhirConstruct.cs:836
	                                                                                                                                           // BuildMemberBase.cs:353
	    // BuildMemberBase.cs:354
	    /// <summary>
	    /// Write container items.
	    /// </summary>
	    public IEnumerable<Composition.SectionComponent> Write(BreastRadiologyDocument doc)                                                    // BuildMemberSection.cs:98
	    {                                                                                                                                      // BuildMemberSection.cs:99
	        if (this.Count == 0)                                                                                                               // BuildMemberSection.cs:100
	            return new Composition.SectionComponent[0];                                                                                    // BuildMemberSection.cs:101
	        Composition.SectionComponent section = new Composition.SectionComponent                                                            // BuildMemberSection.cs:102
	        {                                                                                                                                  // BuildMemberSection.cs:103
	            Title = "Breast Radiology Report",                                                                                             // BuildMemberSection.cs:104
	            Code = SectionCode()                                                                                                           // BuildMemberSection.cs:105
	        };                                                                                                                                 // BuildMemberSection.cs:106
	        section.Author.Add(doc.Author.ResourceReference());                                                                                // BuildMemberSection.cs:107
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberSection.cs:108
	        {                                                                                                                                  // BuildMemberSection.cs:109
	            section.Entry.Add(item.WriteItem(doc));                                                                                        // BuildMemberSection.cs:110
	        }                                                                                                                                  // BuildMemberSection.cs:111
	        return new Composition.SectionComponent[] { section };                                                                             // BuildMemberSection.cs:112
	    }                                                                                                                                      // BuildMemberSection.cs:113
	                                                                                                                                           // BuildMemberBase.cs:359
	    // BuildMemberBase.cs:360
	    /// <summary>
	    /// Read container items.
	    /// </summary>
	                                                                                                                                           // BuildMemberSection.cs:69
	    public void Read(BreastRadiologyDocument doc, IEnumerable<Composition.SectionComponent> sections)                                      // BuildMemberSection.cs:70
	    {                                                                                                                                      // BuildMemberSection.cs:71
	        IEnumerable<Composition.SectionComponent> memberSections = base.IsMember(doc,                                                      // BuildMemberSection.cs:72
	            sections,                                                                                                                      // BuildMemberSection.cs:73
	            SectionCode());                                                                                                                // BuildMemberSection.cs:74
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberSection.cs:75
	        // There really should only ever be one section...                                                                                 // BuildMemberSection.cs:76
	        foreach (Composition.SectionComponent memberSection in memberSections)                                                             // BuildMemberSection.cs:77
	        {                                                                                                                                  // BuildMemberSection.cs:78
	            foreach (ResourceReference entryRef in memberSection.Entry)                                                                    // BuildMemberSection.cs:79
	            {                                                                                                                              // BuildMemberSection.cs:80
	                Item item = new Item();                                                                                                    // BuildMemberSection.cs:81
	                item.ReadItem(doc, entryRef);                                                                                              // BuildMemberSection.cs:82
	                items.Add(item);                                                                                                           // BuildMemberSection.cs:83
	            }                                                                                                                              // BuildMemberSection.cs:84
	        }                                                                                                                                  // BuildMemberSection.cs:85
	        this.SetAllItems(items);                                                                                                           // BuildMemberSection.cs:86
	    }                                                                                                                                      // BuildMemberSection.cs:87
	}                                                                                                                                          // BuildMemberBase.cs:199
	#endregion                                                                                                                                 // BuildMemberBase.cs:200
	#region Composition.section:impressions Container Class                                                                                    // BuildMemberBase.cs:174
	// Called from BuildMemberSection.cs, Line 225
	// BuildMemberBase.cs:176
	/// <summary>
	/// Container class for Composition.section:impressions.
	/// </summary>
	public class MImpressions : MContainer, ITMItem<Composition.SectionComponent>                                                              // BuildMemberBase.cs:179
	{                                                                                                                                          // BuildMemberBase.cs:180
	    #region Composition.section:impressions Item Class                                                                                     // BuildMemberBase.cs:81
	    // Called from BuildMemberSection.cs, Line 225
	    // BuildMemberBase.cs:83
	    /// <summary>
	    /// Item class for Composition.section:impressions.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:86
	    {                                                                                                                                      // BuildMemberBase.cs:87
	        // Properties                                                                                                                      // BuildMemberBase.cs:88
	        // BuildMemberBase.cs:90
	        /// <summary>
	        /// Value
	        /// </summary>
	        public ClinicalImpressionBase Value { get; set; }                                                                                  // BuildMemberBase.cs:93
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
	        public ResourceReference WriteItem(BreastRadiologyDocument doc)                                                                    // BuildMemberBase.cs:112
	        {                                                                                                                                  // BuildMemberBase.cs:113
	            ResourceReference retVal = this.Value.ResourceReference();                                                                     // BuildMemberSection.cs:62
	            return retVal;                                                                                                                 // BuildMemberBase.cs:116
	        }                                                                                                                                  // BuildMemberBase.cs:117
	                                                                                                                                           // BuildMemberBase.cs:119
	        // BuildMemberBase.cs:120
	        /// <summary>
	        /// Read item.
	        /// </summary>
	        public void ReadItem(BreastRadiologyDocument doc, ResourceReference item)                                                          // BuildMemberBase.cs:123
	        {                                                                                                                                  // BuildMemberBase.cs:124
	            this.Value = (ClinicalImpressionBase) doc.GetResource(item);                                                                   // BuildMemberSection.cs:55
	        }                                                                                                                                  // BuildMemberBase.cs:127
	    }                                                                                                                                      // BuildMemberBase.cs:130
	    #endregion                                                                                                                             // BuildMemberBase.cs:131
	                                                                                                                                           // BuildMemberBase.cs:183
	    // Properties                                                                                                                          // BuildMemberBase.cs:184
	    #region Common Properties (Non-Singleton)                                                                                              // BuildMemberBase.cs:277
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:278
	                                                                                                                                           // BuildMemberBase.cs:280
	    // BuildMemberBase.cs:281
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:284
	                                                                                                                                           // BuildMemberBase.cs:286
	    // BuildMemberBase.cs:287
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:290
	                                                                                                                                           // BuildMemberBase.cs:292
	    // BuildMemberBase.cs:293
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:296
	                                                                                                                                           // BuildMemberBase.cs:298
	    // BuildMemberBase.cs:299
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<ClinicalImpressionBase> All()                                                                                       // BuildMemberBase.cs:302
	    {                                                                                                                                      // BuildMemberBase.cs:303
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:304
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:305
	    }                                                                                                                                      // BuildMemberBase.cs:306
	                                                                                                                                           // BuildMemberBase.cs:308
	    // BuildMemberBase.cs:309
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public ClinicalImpressionBase GetAt(Int32 i) => this.items[i].Value;                                                                   // BuildMemberBase.cs:312
	                                                                                                                                           // BuildMemberBase.cs:314
	    // BuildMemberBase.cs:315
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:318
	                                                                                                                                           // BuildMemberBase.cs:320
	    // BuildMemberBase.cs:321
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:324
	    #endregion                                                                                                                             // BuildMemberBase.cs:349
	                                                                                                                                           // BuildMemberBase.cs:187
	    // BuildMemberBase.cs:188
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public MImpressions(Int32 min = 0, Int32 max = -1) : base("Composition.section:impressions", min, max)                                 // BuildMemberBase.cs:191
	    {                                                                                                                                      // BuildMemberBase.cs:192
	    }                                                                                                                                      // BuildMemberBase.cs:194
	                                                                                                                                           // BuildMemberBase.cs:196
	    // Methods                                                                                                                             // BuildMemberBase.cs:197
	    public CodeableConcept SectionCode()                                                                                                   // FhirConstruct.cs:759
	    {                                                                                                                                      // FhirConstruct.cs:760
	        CodeableConcept retVal = new CodeableConcept();                                                                                    // FhirConstruct.cs:761
	        retVal.Coding = new List<Coding>();                                                                                                // FhirConstruct.cs:767
	        {                                                                                                                                  // FhirConstruct.cs:770
	            var temp4 = new Coding();                                                                                                      // FhirConstruct.cs:771
	            temp4.SystemElement = new FhirUri();                                                                                           // FhirConstruct.cs:774
	            temp4.SystemElement.Value = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes";                 // FhirConstruct.cs:776
	            temp4.CodeElement = new Code();                                                                                                // FhirConstruct.cs:790
	            temp4.CodeElement.Value = "sectionImpressions";                                                                                // FhirConstruct.cs:792
	            retVal.Coding.Add(temp4);                                                                                                      // FhirConstruct.cs:819
	        }                                                                                                                                  // FhirConstruct.cs:820
	        return retVal;                                                                                                                     // FhirConstruct.cs:835
	    }                                                                                                                                      // FhirConstruct.cs:836
	                                                                                                                                           // BuildMemberBase.cs:333
	    // BuildMemberBase.cs:334
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public ClinicalImpressionBase Append(ClinicalImpressionBase value)                                                                     // BuildMemberBase.cs:337
	    {                                                                                                                                      // BuildMemberBase.cs:338
	        Item item = new Item();                                                                                                            // BuildMemberBase.cs:339
	        item.Value = value;                                                                                                                // BuildMemberBase.cs:340
	        this.items.Add(item);                                                                                                              // BuildMemberBase.cs:341
	        return value;                                                                                                                      // BuildMemberBase.cs:342
	    }                                                                                                                                      // BuildMemberBase.cs:343
	                                                                                                                                           // BuildMemberBase.cs:353
	    // BuildMemberBase.cs:354
	    /// <summary>
	    /// Write container items.
	    /// </summary>
	    public IEnumerable<Composition.SectionComponent> Write(BreastRadiologyDocument doc)                                                    // BuildMemberSection.cs:98
	    {                                                                                                                                      // BuildMemberSection.cs:99
	        if (this.Count == 0)                                                                                                               // BuildMemberSection.cs:100
	            return new Composition.SectionComponent[0];                                                                                    // BuildMemberSection.cs:101
	        Composition.SectionComponent section = new Composition.SectionComponent                                                            // BuildMemberSection.cs:102
	        {                                                                                                                                  // BuildMemberSection.cs:103
	            Title = "Clinical Impressions",                                                                                                // BuildMemberSection.cs:104
	            Code = SectionCode()                                                                                                           // BuildMemberSection.cs:105
	        };                                                                                                                                 // BuildMemberSection.cs:106
	        section.Author.Add(doc.Author.ResourceReference());                                                                                // BuildMemberSection.cs:107
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberSection.cs:108
	        {                                                                                                                                  // BuildMemberSection.cs:109
	            section.Entry.Add(item.WriteItem(doc));                                                                                        // BuildMemberSection.cs:110
	        }                                                                                                                                  // BuildMemberSection.cs:111
	        return new Composition.SectionComponent[] { section };                                                                             // BuildMemberSection.cs:112
	    }                                                                                                                                      // BuildMemberSection.cs:113
	                                                                                                                                           // BuildMemberBase.cs:359
	    // BuildMemberBase.cs:360
	    /// <summary>
	    /// Read container items.
	    /// </summary>
	                                                                                                                                           // BuildMemberSection.cs:69
	    public void Read(BreastRadiologyDocument doc, IEnumerable<Composition.SectionComponent> sections)                                      // BuildMemberSection.cs:70
	    {                                                                                                                                      // BuildMemberSection.cs:71
	        IEnumerable<Composition.SectionComponent> memberSections = base.IsMember(doc,                                                      // BuildMemberSection.cs:72
	            sections,                                                                                                                      // BuildMemberSection.cs:73
	            SectionCode());                                                                                                                // BuildMemberSection.cs:74
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberSection.cs:75
	        // There really should only ever be one section...                                                                                 // BuildMemberSection.cs:76
	        foreach (Composition.SectionComponent memberSection in memberSections)                                                             // BuildMemberSection.cs:77
	        {                                                                                                                                  // BuildMemberSection.cs:78
	            foreach (ResourceReference entryRef in memberSection.Entry)                                                                    // BuildMemberSection.cs:79
	            {                                                                                                                              // BuildMemberSection.cs:80
	                Item item = new Item();                                                                                                    // BuildMemberSection.cs:81
	                item.ReadItem(doc, entryRef);                                                                                              // BuildMemberSection.cs:82
	                items.Add(item);                                                                                                           // BuildMemberSection.cs:83
	            }                                                                                                                              // BuildMemberSection.cs:84
	        }                                                                                                                                  // BuildMemberSection.cs:85
	        this.SetAllItems(items);                                                                                                           // BuildMemberSection.cs:86
	    }                                                                                                                                      // BuildMemberSection.cs:87
	}                                                                                                                                          // BuildMemberBase.cs:199
	#endregion                                                                                                                                 // BuildMemberBase.cs:200
	#region Composition.section:findingsRightBreast Container Class                                                                            // BuildMemberBase.cs:174
	// Called from BuildMemberSection.cs, Line 225
	// BuildMemberBase.cs:176
	/// <summary>
	/// Container class for Composition.section:findingsRightBreast.
	/// </summary>
	public class MFindingsRightBreast : MContainer, ITMItem<Composition.SectionComponent>                                                      // BuildMemberBase.cs:179
	{                                                                                                                                          // BuildMemberBase.cs:180
	    #region Composition.section:findingsRightBreast Item Class                                                                             // BuildMemberBase.cs:81
	    // Called from BuildMemberSection.cs, Line 225
	    // BuildMemberBase.cs:83
	    /// <summary>
	    /// Item class for Composition.section:findingsRightBreast.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:86
	    {                                                                                                                                      // BuildMemberBase.cs:87
	        // Properties                                                                                                                      // BuildMemberBase.cs:88
	        // BuildMemberBase.cs:90
	        /// <summary>
	        /// Value
	        /// </summary>
	        public SectionFindingsRightBreast Value { get; set; }                                                                              // BuildMemberBase.cs:93
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
	        public ResourceReference WriteItem(BreastRadiologyDocument doc)                                                                    // BuildMemberBase.cs:112
	        {                                                                                                                                  // BuildMemberBase.cs:113
	            ResourceReference retVal = this.Value.ResourceReference();                                                                     // BuildMemberSection.cs:62
	            return retVal;                                                                                                                 // BuildMemberBase.cs:116
	        }                                                                                                                                  // BuildMemberBase.cs:117
	                                                                                                                                           // BuildMemberBase.cs:119
	        // BuildMemberBase.cs:120
	        /// <summary>
	        /// Read item.
	        /// </summary>
	        public void ReadItem(BreastRadiologyDocument doc, ResourceReference item)                                                          // BuildMemberBase.cs:123
	        {                                                                                                                                  // BuildMemberBase.cs:124
	            this.Value = (SectionFindingsRightBreast) doc.GetResource(item);                                                               // BuildMemberSection.cs:55
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
	    public SectionFindingsRightBreast Get()                                                                                                // BuildMemberBase.cs:249
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
	    public SectionFindingsRightBreast Set(SectionFindingsRightBreast value)                                                                // BuildMemberBase.cs:264
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
	    public MFindingsRightBreast(Int32 min = 0, Int32 max = 1) : base("Composition.section:findingsRightBreast", min, max)                  // BuildMemberBase.cs:191
	    {                                                                                                                                      // BuildMemberBase.cs:192
	    }                                                                                                                                      // BuildMemberBase.cs:194
	                                                                                                                                           // BuildMemberBase.cs:196
	    // Methods                                                                                                                             // BuildMemberBase.cs:197
	    public CodeableConcept SectionCode()                                                                                                   // FhirConstruct.cs:759
	    {                                                                                                                                      // FhirConstruct.cs:760
	        CodeableConcept retVal = new CodeableConcept();                                                                                    // FhirConstruct.cs:761
	        retVal.Coding = new List<Coding>();                                                                                                // FhirConstruct.cs:767
	        {                                                                                                                                  // FhirConstruct.cs:770
	            var temp4 = new Coding();                                                                                                      // FhirConstruct.cs:771
	            temp4.SystemElement = new FhirUri();                                                                                           // FhirConstruct.cs:774
	            temp4.SystemElement.Value = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes";                 // FhirConstruct.cs:776
	            temp4.CodeElement = new Code();                                                                                                // FhirConstruct.cs:790
	            temp4.CodeElement.Value = "sectionCodeFindingsRightBreast";                                                                    // FhirConstruct.cs:792
	            retVal.Coding.Add(temp4);                                                                                                      // FhirConstruct.cs:819
	        }                                                                                                                                  // FhirConstruct.cs:820
	        return retVal;                                                                                                                     // FhirConstruct.cs:835
	    }                                                                                                                                      // FhirConstruct.cs:836
	                                                                                                                                           // BuildMemberBase.cs:353
	    // BuildMemberBase.cs:354
	    /// <summary>
	    /// Write container items.
	    /// </summary>
	    public IEnumerable<Composition.SectionComponent> Write(BreastRadiologyDocument doc)                                                    // BuildMemberSection.cs:98
	    {                                                                                                                                      // BuildMemberSection.cs:99
	        if (this.Count == 0)                                                                                                               // BuildMemberSection.cs:100
	            return new Composition.SectionComponent[0];                                                                                    // BuildMemberSection.cs:101
	        Composition.SectionComponent section = new Composition.SectionComponent                                                            // BuildMemberSection.cs:102
	        {                                                                                                                                  // BuildMemberSection.cs:103
	            Title = "Findings Right Breast",                                                                                               // BuildMemberSection.cs:104
	            Code = SectionCode()                                                                                                           // BuildMemberSection.cs:105
	        };                                                                                                                                 // BuildMemberSection.cs:106
	        section.Author.Add(doc.Author.ResourceReference());                                                                                // BuildMemberSection.cs:107
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberSection.cs:108
	        {                                                                                                                                  // BuildMemberSection.cs:109
	            section.Entry.Add(item.WriteItem(doc));                                                                                        // BuildMemberSection.cs:110
	        }                                                                                                                                  // BuildMemberSection.cs:111
	        return new Composition.SectionComponent[] { section };                                                                             // BuildMemberSection.cs:112
	    }                                                                                                                                      // BuildMemberSection.cs:113
	                                                                                                                                           // BuildMemberBase.cs:359
	    // BuildMemberBase.cs:360
	    /// <summary>
	    /// Read container items.
	    /// </summary>
	                                                                                                                                           // BuildMemberSection.cs:69
	    public void Read(BreastRadiologyDocument doc, IEnumerable<Composition.SectionComponent> sections)                                      // BuildMemberSection.cs:70
	    {                                                                                                                                      // BuildMemberSection.cs:71
	        IEnumerable<Composition.SectionComponent> memberSections = base.IsMember(doc,                                                      // BuildMemberSection.cs:72
	            sections,                                                                                                                      // BuildMemberSection.cs:73
	            SectionCode());                                                                                                                // BuildMemberSection.cs:74
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberSection.cs:75
	        // There really should only ever be one section...                                                                                 // BuildMemberSection.cs:76
	        foreach (Composition.SectionComponent memberSection in memberSections)                                                             // BuildMemberSection.cs:77
	        {                                                                                                                                  // BuildMemberSection.cs:78
	            foreach (ResourceReference entryRef in memberSection.Entry)                                                                    // BuildMemberSection.cs:79
	            {                                                                                                                              // BuildMemberSection.cs:80
	                Item item = new Item();                                                                                                    // BuildMemberSection.cs:81
	                item.ReadItem(doc, entryRef);                                                                                              // BuildMemberSection.cs:82
	                items.Add(item);                                                                                                           // BuildMemberSection.cs:83
	            }                                                                                                                              // BuildMemberSection.cs:84
	        }                                                                                                                                  // BuildMemberSection.cs:85
	        this.SetAllItems(items);                                                                                                           // BuildMemberSection.cs:86
	    }                                                                                                                                      // BuildMemberSection.cs:87
	}                                                                                                                                          // BuildMemberBase.cs:199
	#endregion                                                                                                                                 // BuildMemberBase.cs:200
	#region Composition.section:findingsLeftBreast Container Class                                                                             // BuildMemberBase.cs:174
	// Called from BuildMemberSection.cs, Line 225
	// BuildMemberBase.cs:176
	/// <summary>
	/// Container class for Composition.section:findingsLeftBreast.
	/// </summary>
	public class MFindingsLeftBreast : MContainer, ITMItem<Composition.SectionComponent>                                                       // BuildMemberBase.cs:179
	{                                                                                                                                          // BuildMemberBase.cs:180
	    #region Composition.section:findingsLeftBreast Item Class                                                                              // BuildMemberBase.cs:81
	    // Called from BuildMemberSection.cs, Line 225
	    // BuildMemberBase.cs:83
	    /// <summary>
	    /// Item class for Composition.section:findingsLeftBreast.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:86
	    {                                                                                                                                      // BuildMemberBase.cs:87
	        // Properties                                                                                                                      // BuildMemberBase.cs:88
	        // BuildMemberBase.cs:90
	        /// <summary>
	        /// Value
	        /// </summary>
	        public SectionFindingsLeftBreast Value { get; set; }                                                                               // BuildMemberBase.cs:93
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
	        public ResourceReference WriteItem(BreastRadiologyDocument doc)                                                                    // BuildMemberBase.cs:112
	        {                                                                                                                                  // BuildMemberBase.cs:113
	            ResourceReference retVal = this.Value.ResourceReference();                                                                     // BuildMemberSection.cs:62
	            return retVal;                                                                                                                 // BuildMemberBase.cs:116
	        }                                                                                                                                  // BuildMemberBase.cs:117
	                                                                                                                                           // BuildMemberBase.cs:119
	        // BuildMemberBase.cs:120
	        /// <summary>
	        /// Read item.
	        /// </summary>
	        public void ReadItem(BreastRadiologyDocument doc, ResourceReference item)                                                          // BuildMemberBase.cs:123
	        {                                                                                                                                  // BuildMemberBase.cs:124
	            this.Value = (SectionFindingsLeftBreast) doc.GetResource(item);                                                                // BuildMemberSection.cs:55
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
	    public SectionFindingsLeftBreast Get()                                                                                                 // BuildMemberBase.cs:249
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
	    public SectionFindingsLeftBreast Set(SectionFindingsLeftBreast value)                                                                  // BuildMemberBase.cs:264
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
	    public MFindingsLeftBreast(Int32 min = 0, Int32 max = 1) : base("Composition.section:findingsLeftBreast", min, max)                    // BuildMemberBase.cs:191
	    {                                                                                                                                      // BuildMemberBase.cs:192
	    }                                                                                                                                      // BuildMemberBase.cs:194
	                                                                                                                                           // BuildMemberBase.cs:196
	    // Methods                                                                                                                             // BuildMemberBase.cs:197
	    public CodeableConcept SectionCode()                                                                                                   // FhirConstruct.cs:759
	    {                                                                                                                                      // FhirConstruct.cs:760
	        CodeableConcept retVal = new CodeableConcept();                                                                                    // FhirConstruct.cs:761
	        retVal.Coding = new List<Coding>();                                                                                                // FhirConstruct.cs:767
	        {                                                                                                                                  // FhirConstruct.cs:770
	            var temp4 = new Coding();                                                                                                      // FhirConstruct.cs:771
	            temp4.SystemElement = new FhirUri();                                                                                           // FhirConstruct.cs:774
	            temp4.SystemElement.Value = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes";                 // FhirConstruct.cs:776
	            temp4.CodeElement = new Code();                                                                                                // FhirConstruct.cs:790
	            temp4.CodeElement.Value = "sectionCodeFindingsLeftBreast";                                                                     // FhirConstruct.cs:792
	            retVal.Coding.Add(temp4);                                                                                                      // FhirConstruct.cs:819
	        }                                                                                                                                  // FhirConstruct.cs:820
	        return retVal;                                                                                                                     // FhirConstruct.cs:835
	    }                                                                                                                                      // FhirConstruct.cs:836
	                                                                                                                                           // BuildMemberBase.cs:353
	    // BuildMemberBase.cs:354
	    /// <summary>
	    /// Write container items.
	    /// </summary>
	    public IEnumerable<Composition.SectionComponent> Write(BreastRadiologyDocument doc)                                                    // BuildMemberSection.cs:98
	    {                                                                                                                                      // BuildMemberSection.cs:99
	        if (this.Count == 0)                                                                                                               // BuildMemberSection.cs:100
	            return new Composition.SectionComponent[0];                                                                                    // BuildMemberSection.cs:101
	        Composition.SectionComponent section = new Composition.SectionComponent                                                            // BuildMemberSection.cs:102
	        {                                                                                                                                  // BuildMemberSection.cs:103
	            Title = "Findings Left Breast",                                                                                                // BuildMemberSection.cs:104
	            Code = SectionCode()                                                                                                           // BuildMemberSection.cs:105
	        };                                                                                                                                 // BuildMemberSection.cs:106
	        section.Author.Add(doc.Author.ResourceReference());                                                                                // BuildMemberSection.cs:107
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberSection.cs:108
	        {                                                                                                                                  // BuildMemberSection.cs:109
	            section.Entry.Add(item.WriteItem(doc));                                                                                        // BuildMemberSection.cs:110
	        }                                                                                                                                  // BuildMemberSection.cs:111
	        return new Composition.SectionComponent[] { section };                                                                             // BuildMemberSection.cs:112
	    }                                                                                                                                      // BuildMemberSection.cs:113
	                                                                                                                                           // BuildMemberBase.cs:359
	    // BuildMemberBase.cs:360
	    /// <summary>
	    /// Read container items.
	    /// </summary>
	                                                                                                                                           // BuildMemberSection.cs:69
	    public void Read(BreastRadiologyDocument doc, IEnumerable<Composition.SectionComponent> sections)                                      // BuildMemberSection.cs:70
	    {                                                                                                                                      // BuildMemberSection.cs:71
	        IEnumerable<Composition.SectionComponent> memberSections = base.IsMember(doc,                                                      // BuildMemberSection.cs:72
	            sections,                                                                                                                      // BuildMemberSection.cs:73
	            SectionCode());                                                                                                                // BuildMemberSection.cs:74
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberSection.cs:75
	        // There really should only ever be one section...                                                                                 // BuildMemberSection.cs:76
	        foreach (Composition.SectionComponent memberSection in memberSections)                                                             // BuildMemberSection.cs:77
	        {                                                                                                                                  // BuildMemberSection.cs:78
	            foreach (ResourceReference entryRef in memberSection.Entry)                                                                    // BuildMemberSection.cs:79
	            {                                                                                                                              // BuildMemberSection.cs:80
	                Item item = new Item();                                                                                                    // BuildMemberSection.cs:81
	                item.ReadItem(doc, entryRef);                                                                                              // BuildMemberSection.cs:82
	                items.Add(item);                                                                                                           // BuildMemberSection.cs:83
	            }                                                                                                                              // BuildMemberSection.cs:84
	        }                                                                                                                                  // BuildMemberSection.cs:85
	        this.SetAllItems(items);                                                                                                           // BuildMemberSection.cs:86
	    }                                                                                                                                      // BuildMemberSection.cs:87
	}                                                                                                                                          // BuildMemberBase.cs:199
	#endregion                                                                                                                                 // BuildMemberBase.cs:200
	#region Composition.section:relatedResources Container Class                                                                               // BuildMemberBase.cs:174
	// Called from BuildMemberSection.cs, Line 225
	// BuildMemberBase.cs:176
	/// <summary>
	/// Container class for Composition.section:relatedResources.
	/// </summary>
	public class MRelatedResources : MContainer, ITMItem<Composition.SectionComponent>                                                         // BuildMemberBase.cs:179
	{                                                                                                                                          // BuildMemberBase.cs:180
	    #region Composition.section:relatedResources Item Class                                                                                // BuildMemberBase.cs:81
	    // Called from BuildMemberSection.cs, Line 225
	    // BuildMemberBase.cs:83
	    /// <summary>
	    /// Item class for Composition.section:relatedResources.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:86
	    {                                                                                                                                      // BuildMemberBase.cs:87
	        // Properties                                                                                                                      // BuildMemberBase.cs:88
	        // BuildMemberBase.cs:90
	        /// <summary>
	        /// Value
	        /// </summary>
	        public ResourceBase Value { get; set; }                                                                                            // BuildMemberBase.cs:93
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
	        public ResourceReference WriteItem(BreastRadiologyDocument doc)                                                                    // BuildMemberBase.cs:112
	        {                                                                                                                                  // BuildMemberBase.cs:113
	            ResourceReference retVal = this.Value.ResourceReference();                                                                     // BuildMemberSection.cs:62
	            return retVal;                                                                                                                 // BuildMemberBase.cs:116
	        }                                                                                                                                  // BuildMemberBase.cs:117
	                                                                                                                                           // BuildMemberBase.cs:119
	        // BuildMemberBase.cs:120
	        /// <summary>
	        /// Read item.
	        /// </summary>
	        public void ReadItem(BreastRadiologyDocument doc, ResourceReference item)                                                          // BuildMemberBase.cs:123
	        {                                                                                                                                  // BuildMemberBase.cs:124
	            this.Value = (ResourceBase) doc.GetResource(item);                                                                             // BuildMemberSection.cs:55
	        }                                                                                                                                  // BuildMemberBase.cs:127
	    }                                                                                                                                      // BuildMemberBase.cs:130
	    #endregion                                                                                                                             // BuildMemberBase.cs:131
	                                                                                                                                           // BuildMemberBase.cs:183
	    // Properties                                                                                                                          // BuildMemberBase.cs:184
	    #region Common Properties (Non-Singleton)                                                                                              // BuildMemberBase.cs:277
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:278
	                                                                                                                                           // BuildMemberBase.cs:280
	    // BuildMemberBase.cs:281
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:284
	                                                                                                                                           // BuildMemberBase.cs:286
	    // BuildMemberBase.cs:287
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:290
	                                                                                                                                           // BuildMemberBase.cs:292
	    // BuildMemberBase.cs:293
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:296
	                                                                                                                                           // BuildMemberBase.cs:298
	    // BuildMemberBase.cs:299
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<ResourceBase> All()                                                                                                 // BuildMemberBase.cs:302
	    {                                                                                                                                      // BuildMemberBase.cs:303
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:304
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:305
	    }                                                                                                                                      // BuildMemberBase.cs:306
	                                                                                                                                           // BuildMemberBase.cs:308
	    // BuildMemberBase.cs:309
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public ResourceBase GetAt(Int32 i) => this.items[i].Value;                                                                             // BuildMemberBase.cs:312
	                                                                                                                                           // BuildMemberBase.cs:314
	    // BuildMemberBase.cs:315
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:318
	                                                                                                                                           // BuildMemberBase.cs:320
	    // BuildMemberBase.cs:321
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:324
	    #endregion                                                                                                                             // BuildMemberBase.cs:349
	                                                                                                                                           // BuildMemberBase.cs:187
	    // BuildMemberBase.cs:188
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public MRelatedResources(Int32 min = 0, Int32 max = -1) : base("Composition.section:relatedResources", min, max)                       // BuildMemberBase.cs:191
	    {                                                                                                                                      // BuildMemberBase.cs:192
	    }                                                                                                                                      // BuildMemberBase.cs:194
	                                                                                                                                           // BuildMemberBase.cs:196
	    // Methods                                                                                                                             // BuildMemberBase.cs:197
	    public CodeableConcept SectionCode()                                                                                                   // FhirConstruct.cs:759
	    {                                                                                                                                      // FhirConstruct.cs:760
	        CodeableConcept retVal = new CodeableConcept();                                                                                    // FhirConstruct.cs:761
	        retVal.Coding = new List<Coding>();                                                                                                // FhirConstruct.cs:767
	        {                                                                                                                                  // FhirConstruct.cs:770
	            var temp4 = new Coding();                                                                                                      // FhirConstruct.cs:771
	            temp4.SystemElement = new FhirUri();                                                                                           // FhirConstruct.cs:774
	            temp4.SystemElement.Value = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes";                 // FhirConstruct.cs:776
	            temp4.CodeElement = new Code();                                                                                                // FhirConstruct.cs:790
	            temp4.CodeElement.Value = "sectionRelatedResources";                                                                           // FhirConstruct.cs:792
	            retVal.Coding.Add(temp4);                                                                                                      // FhirConstruct.cs:819
	        }                                                                                                                                  // FhirConstruct.cs:820
	        return retVal;                                                                                                                     // FhirConstruct.cs:835
	    }                                                                                                                                      // FhirConstruct.cs:836
	                                                                                                                                           // BuildMemberBase.cs:333
	    // BuildMemberBase.cs:334
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public ResourceBase Append(ResourceBase value)                                                                                         // BuildMemberBase.cs:337
	    {                                                                                                                                      // BuildMemberBase.cs:338
	        Item item = new Item();                                                                                                            // BuildMemberBase.cs:339
	        item.Value = value;                                                                                                                // BuildMemberBase.cs:340
	        this.items.Add(item);                                                                                                              // BuildMemberBase.cs:341
	        return value;                                                                                                                      // BuildMemberBase.cs:342
	    }                                                                                                                                      // BuildMemberBase.cs:343
	                                                                                                                                           // BuildMemberBase.cs:353
	    // BuildMemberBase.cs:354
	    /// <summary>
	    /// Write container items.
	    /// </summary>
	    public IEnumerable<Composition.SectionComponent> Write(BreastRadiologyDocument doc)                                                    // BuildMemberSection.cs:98
	    {                                                                                                                                      // BuildMemberSection.cs:99
	        if (this.Count == 0)                                                                                                               // BuildMemberSection.cs:100
	            return new Composition.SectionComponent[0];                                                                                    // BuildMemberSection.cs:101
	        Composition.SectionComponent section = new Composition.SectionComponent                                                            // BuildMemberSection.cs:102
	        {                                                                                                                                  // BuildMemberSection.cs:103
	            Title = "Related Resources",                                                                                                   // BuildMemberSection.cs:104
	            Code = SectionCode()                                                                                                           // BuildMemberSection.cs:105
	        };                                                                                                                                 // BuildMemberSection.cs:106
	        section.Author.Add(doc.Author.ResourceReference());                                                                                // BuildMemberSection.cs:107
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberSection.cs:108
	        {                                                                                                                                  // BuildMemberSection.cs:109
	            section.Entry.Add(item.WriteItem(doc));                                                                                        // BuildMemberSection.cs:110
	        }                                                                                                                                  // BuildMemberSection.cs:111
	        return new Composition.SectionComponent[] { section };                                                                             // BuildMemberSection.cs:112
	    }                                                                                                                                      // BuildMemberSection.cs:113
	                                                                                                                                           // BuildMemberBase.cs:359
	    // BuildMemberBase.cs:360
	    /// <summary>
	    /// Read container items.
	    /// </summary>
	                                                                                                                                           // BuildMemberSection.cs:69
	    public void Read(BreastRadiologyDocument doc, IEnumerable<Composition.SectionComponent> sections)                                      // BuildMemberSection.cs:70
	    {                                                                                                                                      // BuildMemberSection.cs:71
	        IEnumerable<Composition.SectionComponent> memberSections = base.IsMember(doc,                                                      // BuildMemberSection.cs:72
	            sections,                                                                                                                      // BuildMemberSection.cs:73
	            SectionCode());                                                                                                                // BuildMemberSection.cs:74
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberSection.cs:75
	        // There really should only ever be one section...                                                                                 // BuildMemberSection.cs:76
	        foreach (Composition.SectionComponent memberSection in memberSections)                                                             // BuildMemberSection.cs:77
	        {                                                                                                                                  // BuildMemberSection.cs:78
	            foreach (ResourceReference entryRef in memberSection.Entry)                                                                    // BuildMemberSection.cs:79
	            {                                                                                                                              // BuildMemberSection.cs:80
	                Item item = new Item();                                                                                                    // BuildMemberSection.cs:81
	                item.ReadItem(doc, entryRef);                                                                                              // BuildMemberSection.cs:82
	                items.Add(item);                                                                                                           // BuildMemberSection.cs:83
	            }                                                                                                                              // BuildMemberSection.cs:84
	        }                                                                                                                                  // BuildMemberSection.cs:85
	        this.SetAllItems(items);                                                                                                           // BuildMemberSection.cs:86
	    }                                                                                                                                      // BuildMemberSection.cs:87
	}                                                                                                                                          // BuildMemberBase.cs:199
	#endregion                                                                                                                                 // BuildMemberBase.cs:200
	#region Composition.section:recommendations Container Class                                                                                // BuildMemberBase.cs:174
	// Called from BuildMemberSection.cs, Line 225
	// BuildMemberBase.cs:176
	/// <summary>
	/// Container class for Composition.section:recommendations.
	/// </summary>
	public class MRecommendations : MContainer, ITMItem<Composition.SectionComponent>                                                          // BuildMemberBase.cs:179
	{                                                                                                                                          // BuildMemberBase.cs:180
	    #region Composition.section:recommendations Item Class                                                                                 // BuildMemberBase.cs:81
	    // Called from BuildMemberSection.cs, Line 225
	    // BuildMemberBase.cs:83
	    /// <summary>
	    /// Item class for Composition.section:recommendations.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:86
	    {                                                                                                                                      // BuildMemberBase.cs:87
	        // Properties                                                                                                                      // BuildMemberBase.cs:88
	        // BuildMemberBase.cs:90
	        /// <summary>
	        /// Value
	        /// </summary>
	        public ResourceBase Value { get; set; }                                                                                            // BuildMemberBase.cs:93
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
	        public ResourceReference WriteItem(BreastRadiologyDocument doc)                                                                    // BuildMemberBase.cs:112
	        {                                                                                                                                  // BuildMemberBase.cs:113
	            ResourceReference retVal = this.Value.ResourceReference();                                                                     // BuildMemberSection.cs:62
	            return retVal;                                                                                                                 // BuildMemberBase.cs:116
	        }                                                                                                                                  // BuildMemberBase.cs:117
	                                                                                                                                           // BuildMemberBase.cs:119
	        // BuildMemberBase.cs:120
	        /// <summary>
	        /// Read item.
	        /// </summary>
	        public void ReadItem(BreastRadiologyDocument doc, ResourceReference item)                                                          // BuildMemberBase.cs:123
	        {                                                                                                                                  // BuildMemberBase.cs:124
	            this.Value = (ResourceBase) doc.GetResource(item);                                                                             // BuildMemberSection.cs:55
	        }                                                                                                                                  // BuildMemberBase.cs:127
	    }                                                                                                                                      // BuildMemberBase.cs:130
	    #endregion                                                                                                                             // BuildMemberBase.cs:131
	                                                                                                                                           // BuildMemberBase.cs:183
	    // Properties                                                                                                                          // BuildMemberBase.cs:184
	    #region Common Properties (Non-Singleton)                                                                                              // BuildMemberBase.cs:277
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:278
	                                                                                                                                           // BuildMemberBase.cs:280
	    // BuildMemberBase.cs:281
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:284
	                                                                                                                                           // BuildMemberBase.cs:286
	    // BuildMemberBase.cs:287
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:290
	                                                                                                                                           // BuildMemberBase.cs:292
	    // BuildMemberBase.cs:293
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:296
	                                                                                                                                           // BuildMemberBase.cs:298
	    // BuildMemberBase.cs:299
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<ResourceBase> All()                                                                                                 // BuildMemberBase.cs:302
	    {                                                                                                                                      // BuildMemberBase.cs:303
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:304
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:305
	    }                                                                                                                                      // BuildMemberBase.cs:306
	                                                                                                                                           // BuildMemberBase.cs:308
	    // BuildMemberBase.cs:309
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public ResourceBase GetAt(Int32 i) => this.items[i].Value;                                                                             // BuildMemberBase.cs:312
	                                                                                                                                           // BuildMemberBase.cs:314
	    // BuildMemberBase.cs:315
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:318
	                                                                                                                                           // BuildMemberBase.cs:320
	    // BuildMemberBase.cs:321
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:324
	    #endregion                                                                                                                             // BuildMemberBase.cs:349
	                                                                                                                                           // BuildMemberBase.cs:187
	    // BuildMemberBase.cs:188
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public MRecommendations(Int32 min = 0, Int32 max = -1) : base("Composition.section:recommendations", min, max)                         // BuildMemberBase.cs:191
	    {                                                                                                                                      // BuildMemberBase.cs:192
	    }                                                                                                                                      // BuildMemberBase.cs:194
	                                                                                                                                           // BuildMemberBase.cs:196
	    // Methods                                                                                                                             // BuildMemberBase.cs:197
	    public CodeableConcept SectionCode()                                                                                                   // FhirConstruct.cs:759
	    {                                                                                                                                      // FhirConstruct.cs:760
	        CodeableConcept retVal = new CodeableConcept();                                                                                    // FhirConstruct.cs:761
	        retVal.Coding = new List<Coding>();                                                                                                // FhirConstruct.cs:767
	        {                                                                                                                                  // FhirConstruct.cs:770
	            var temp4 = new Coding();                                                                                                      // FhirConstruct.cs:771
	            temp4.SystemElement = new FhirUri();                                                                                           // FhirConstruct.cs:774
	            temp4.SystemElement.Value = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes";                 // FhirConstruct.cs:776
	            temp4.CodeElement = new Code();                                                                                                // FhirConstruct.cs:790
	            temp4.CodeElement.Value = "sectionCodeRecommendations";                                                                        // FhirConstruct.cs:792
	            retVal.Coding.Add(temp4);                                                                                                      // FhirConstruct.cs:819
	        }                                                                                                                                  // FhirConstruct.cs:820
	        return retVal;                                                                                                                     // FhirConstruct.cs:835
	    }                                                                                                                                      // FhirConstruct.cs:836
	                                                                                                                                           // BuildMemberBase.cs:333
	    // BuildMemberBase.cs:334
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public MedicationRequestBase Append(MedicationRequestBase value)                                                                       // BuildMemberBase.cs:337
	    {                                                                                                                                      // BuildMemberBase.cs:338
	        Item item = new Item();                                                                                                            // BuildMemberBase.cs:339
	        item.Value = value;                                                                                                                // BuildMemberBase.cs:340
	        this.items.Add(item);                                                                                                              // BuildMemberBase.cs:341
	        return value;                                                                                                                      // BuildMemberBase.cs:342
	    }                                                                                                                                      // BuildMemberBase.cs:343
	                                                                                                                                           // BuildMemberBase.cs:333
	    // BuildMemberBase.cs:334
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public ServiceRequestBase Append(ServiceRequestBase value)                                                                             // BuildMemberBase.cs:337
	    {                                                                                                                                      // BuildMemberBase.cs:338
	        Item item = new Item();                                                                                                            // BuildMemberBase.cs:339
	        item.Value = value;                                                                                                                // BuildMemberBase.cs:340
	        this.items.Add(item);                                                                                                              // BuildMemberBase.cs:341
	        return value;                                                                                                                      // BuildMemberBase.cs:342
	    }                                                                                                                                      // BuildMemberBase.cs:343
	                                                                                                                                           // BuildMemberBase.cs:333
	    // BuildMemberBase.cs:334
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public ServiceRecommendation Append(ServiceRecommendation value)                                                                       // BuildMemberBase.cs:337
	    {                                                                                                                                      // BuildMemberBase.cs:338
	        Item item = new Item();                                                                                                            // BuildMemberBase.cs:339
	        item.Value = value;                                                                                                                // BuildMemberBase.cs:340
	        this.items.Add(item);                                                                                                              // BuildMemberBase.cs:341
	        return value;                                                                                                                      // BuildMemberBase.cs:342
	    }                                                                                                                                      // BuildMemberBase.cs:343
	                                                                                                                                           // BuildMemberBase.cs:353
	    // BuildMemberBase.cs:354
	    /// <summary>
	    /// Write container items.
	    /// </summary>
	    public IEnumerable<Composition.SectionComponent> Write(BreastRadiologyDocument doc)                                                    // BuildMemberSection.cs:98
	    {                                                                                                                                      // BuildMemberSection.cs:99
	        if (this.Count == 0)                                                                                                               // BuildMemberSection.cs:100
	            return new Composition.SectionComponent[0];                                                                                    // BuildMemberSection.cs:101
	        Composition.SectionComponent section = new Composition.SectionComponent                                                            // BuildMemberSection.cs:102
	        {                                                                                                                                  // BuildMemberSection.cs:103
	            Title = "Recommendations",                                                                                                     // BuildMemberSection.cs:104
	            Code = SectionCode()                                                                                                           // BuildMemberSection.cs:105
	        };                                                                                                                                 // BuildMemberSection.cs:106
	        section.Author.Add(doc.Author.ResourceReference());                                                                                // BuildMemberSection.cs:107
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberSection.cs:108
	        {                                                                                                                                  // BuildMemberSection.cs:109
	            section.Entry.Add(item.WriteItem(doc));                                                                                        // BuildMemberSection.cs:110
	        }                                                                                                                                  // BuildMemberSection.cs:111
	        return new Composition.SectionComponent[] { section };                                                                             // BuildMemberSection.cs:112
	    }                                                                                                                                      // BuildMemberSection.cs:113
	                                                                                                                                           // BuildMemberBase.cs:359
	    // BuildMemberBase.cs:360
	    /// <summary>
	    /// Read container items.
	    /// </summary>
	                                                                                                                                           // BuildMemberSection.cs:69
	    public void Read(BreastRadiologyDocument doc, IEnumerable<Composition.SectionComponent> sections)                                      // BuildMemberSection.cs:70
	    {                                                                                                                                      // BuildMemberSection.cs:71
	        IEnumerable<Composition.SectionComponent> memberSections = base.IsMember(doc,                                                      // BuildMemberSection.cs:72
	            sections,                                                                                                                      // BuildMemberSection.cs:73
	            SectionCode());                                                                                                                // BuildMemberSection.cs:74
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberSection.cs:75
	        // There really should only ever be one section...                                                                                 // BuildMemberSection.cs:76
	        foreach (Composition.SectionComponent memberSection in memberSections)                                                             // BuildMemberSection.cs:77
	        {                                                                                                                                  // BuildMemberSection.cs:78
	            foreach (ResourceReference entryRef in memberSection.Entry)                                                                    // BuildMemberSection.cs:79
	            {                                                                                                                              // BuildMemberSection.cs:80
	                Item item = new Item();                                                                                                    // BuildMemberSection.cs:81
	                item.ReadItem(doc, entryRef);                                                                                              // BuildMemberSection.cs:82
	                items.Add(item);                                                                                                           // BuildMemberSection.cs:83
	            }                                                                                                                              // BuildMemberSection.cs:84
	        }                                                                                                                                  // BuildMemberSection.cs:85
	        this.SetAllItems(items);                                                                                                           // BuildMemberSection.cs:86
	    }                                                                                                                                      // BuildMemberSection.cs:87
	}                                                                                                                                          // BuildMemberBase.cs:199
	#endregion                                                                                                                                 // BuildMemberBase.cs:200
	#region Composition.section:admin Container Class                                                                                          // BuildMemberBase.cs:174
	// Called from BuildMemberSection.cs, Line 225
	// BuildMemberBase.cs:176
	/// <summary>
	/// Container class for Composition.section:admin.
	/// </summary>
	public class MAdmin : MContainer, ITMItem<Composition.SectionComponent>                                                                    // BuildMemberBase.cs:179
	{                                                                                                                                          // BuildMemberBase.cs:180
	    #region Composition.section:admin Item Class                                                                                           // BuildMemberBase.cs:81
	    // Called from BuildMemberSection.cs, Line 225
	    // BuildMemberBase.cs:83
	    /// <summary>
	    /// Item class for Composition.section:admin.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:86
	    {                                                                                                                                      // BuildMemberBase.cs:87
	        // Properties                                                                                                                      // BuildMemberBase.cs:88
	        // BuildMemberBase.cs:90
	        /// <summary>
	        /// Value
	        /// </summary>
	        public ResourceBase Value { get; set; }                                                                                            // BuildMemberBase.cs:93
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
	        public ResourceReference WriteItem(BreastRadiologyDocument doc)                                                                    // BuildMemberBase.cs:112
	        {                                                                                                                                  // BuildMemberBase.cs:113
	            ResourceReference retVal = this.Value.ResourceReference();                                                                     // BuildMemberSection.cs:62
	            return retVal;                                                                                                                 // BuildMemberBase.cs:116
	        }                                                                                                                                  // BuildMemberBase.cs:117
	                                                                                                                                           // BuildMemberBase.cs:119
	        // BuildMemberBase.cs:120
	        /// <summary>
	        /// Read item.
	        /// </summary>
	        public void ReadItem(BreastRadiologyDocument doc, ResourceReference item)                                                          // BuildMemberBase.cs:123
	        {                                                                                                                                  // BuildMemberBase.cs:124
	            this.Value = (ResourceBase) doc.GetResource(item);                                                                             // BuildMemberSection.cs:55
	        }                                                                                                                                  // BuildMemberBase.cs:127
	    }                                                                                                                                      // BuildMemberBase.cs:130
	    #endregion                                                                                                                             // BuildMemberBase.cs:131
	                                                                                                                                           // BuildMemberBase.cs:183
	    // Properties                                                                                                                          // BuildMemberBase.cs:184
	    #region Common Properties (Non-Singleton)                                                                                              // BuildMemberBase.cs:277
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:278
	                                                                                                                                           // BuildMemberBase.cs:280
	    // BuildMemberBase.cs:281
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:284
	                                                                                                                                           // BuildMemberBase.cs:286
	    // BuildMemberBase.cs:287
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:290
	                                                                                                                                           // BuildMemberBase.cs:292
	    // BuildMemberBase.cs:293
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:296
	                                                                                                                                           // BuildMemberBase.cs:298
	    // BuildMemberBase.cs:299
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<ResourceBase> All()                                                                                                 // BuildMemberBase.cs:302
	    {                                                                                                                                      // BuildMemberBase.cs:303
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:304
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:305
	    }                                                                                                                                      // BuildMemberBase.cs:306
	                                                                                                                                           // BuildMemberBase.cs:308
	    // BuildMemberBase.cs:309
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public ResourceBase GetAt(Int32 i) => this.items[i].Value;                                                                             // BuildMemberBase.cs:312
	                                                                                                                                           // BuildMemberBase.cs:314
	    // BuildMemberBase.cs:315
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:318
	                                                                                                                                           // BuildMemberBase.cs:320
	    // BuildMemberBase.cs:321
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:324
	    #endregion                                                                                                                             // BuildMemberBase.cs:349
	                                                                                                                                           // BuildMemberBase.cs:187
	    // BuildMemberBase.cs:188
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public MAdmin(Int32 min = 0, Int32 max = -1) : base("Composition.section:admin", min, max)                                             // BuildMemberBase.cs:191
	    {                                                                                                                                      // BuildMemberBase.cs:192
	    }                                                                                                                                      // BuildMemberBase.cs:194
	                                                                                                                                           // BuildMemberBase.cs:196
	    // Methods                                                                                                                             // BuildMemberBase.cs:197
	    public CodeableConcept SectionCode()                                                                                                   // FhirConstruct.cs:759
	    {                                                                                                                                      // FhirConstruct.cs:760
	        CodeableConcept retVal = new CodeableConcept();                                                                                    // FhirConstruct.cs:761
	        retVal.Coding = new List<Coding>();                                                                                                // FhirConstruct.cs:767
	        {                                                                                                                                  // FhirConstruct.cs:770
	            var temp4 = new Coding();                                                                                                      // FhirConstruct.cs:771
	            temp4.SystemElement = new FhirUri();                                                                                           // FhirConstruct.cs:774
	            temp4.SystemElement.Value = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes";                 // FhirConstruct.cs:776
	            temp4.CodeElement = new Code();                                                                                                // FhirConstruct.cs:790
	            temp4.CodeElement.Value = "sectionCodeAdmin";                                                                                  // FhirConstruct.cs:792
	            retVal.Coding.Add(temp4);                                                                                                      // FhirConstruct.cs:819
	        }                                                                                                                                  // FhirConstruct.cs:820
	        return retVal;                                                                                                                     // FhirConstruct.cs:835
	    }                                                                                                                                      // FhirConstruct.cs:836
	                                                                                                                                           // BuildMemberBase.cs:333
	    // BuildMemberBase.cs:334
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public ResourceBase Append(ResourceBase value)                                                                                         // BuildMemberBase.cs:337
	    {                                                                                                                                      // BuildMemberBase.cs:338
	        Item item = new Item();                                                                                                            // BuildMemberBase.cs:339
	        item.Value = value;                                                                                                                // BuildMemberBase.cs:340
	        this.items.Add(item);                                                                                                              // BuildMemberBase.cs:341
	        return value;                                                                                                                      // BuildMemberBase.cs:342
	    }                                                                                                                                      // BuildMemberBase.cs:343
	                                                                                                                                           // BuildMemberBase.cs:353
	    // BuildMemberBase.cs:354
	    /// <summary>
	    /// Write container items.
	    /// </summary>
	    public IEnumerable<Composition.SectionComponent> Write(BreastRadiologyDocument doc)                                                    // BuildMemberSection.cs:98
	    {                                                                                                                                      // BuildMemberSection.cs:99
	        if (this.Count == 0)                                                                                                               // BuildMemberSection.cs:100
	            return new Composition.SectionComponent[0];                                                                                    // BuildMemberSection.cs:101
	        Composition.SectionComponent section = new Composition.SectionComponent                                                            // BuildMemberSection.cs:102
	        {                                                                                                                                  // BuildMemberSection.cs:103
	            Title = "Admin",                                                                                                               // BuildMemberSection.cs:104
	            Code = SectionCode()                                                                                                           // BuildMemberSection.cs:105
	        };                                                                                                                                 // BuildMemberSection.cs:106
	        section.Author.Add(doc.Author.ResourceReference());                                                                                // BuildMemberSection.cs:107
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberSection.cs:108
	        {                                                                                                                                  // BuildMemberSection.cs:109
	            section.Entry.Add(item.WriteItem(doc));                                                                                        // BuildMemberSection.cs:110
	        }                                                                                                                                  // BuildMemberSection.cs:111
	        return new Composition.SectionComponent[] { section };                                                                             // BuildMemberSection.cs:112
	    }                                                                                                                                      // BuildMemberSection.cs:113
	                                                                                                                                           // BuildMemberBase.cs:359
	    // BuildMemberBase.cs:360
	    /// <summary>
	    /// Read container items.
	    /// </summary>
	                                                                                                                                           // BuildMemberSection.cs:69
	    public void Read(BreastRadiologyDocument doc, IEnumerable<Composition.SectionComponent> sections)                                      // BuildMemberSection.cs:70
	    {                                                                                                                                      // BuildMemberSection.cs:71
	        IEnumerable<Composition.SectionComponent> memberSections = base.IsMember(doc,                                                      // BuildMemberSection.cs:72
	            sections,                                                                                                                      // BuildMemberSection.cs:73
	            SectionCode());                                                                                                                // BuildMemberSection.cs:74
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberSection.cs:75
	        // There really should only ever be one section...                                                                                 // BuildMemberSection.cs:76
	        foreach (Composition.SectionComponent memberSection in memberSections)                                                             // BuildMemberSection.cs:77
	        {                                                                                                                                  // BuildMemberSection.cs:78
	            foreach (ResourceReference entryRef in memberSection.Entry)                                                                    // BuildMemberSection.cs:79
	            {                                                                                                                              // BuildMemberSection.cs:80
	                Item item = new Item();                                                                                                    // BuildMemberSection.cs:81
	                item.ReadItem(doc, entryRef);                                                                                              // BuildMemberSection.cs:82
	                items.Add(item);                                                                                                           // BuildMemberSection.cs:83
	            }                                                                                                                              // BuildMemberSection.cs:84
	        }                                                                                                                                  // BuildMemberSection.cs:85
	        this.SetAllItems(items);                                                                                                           // BuildMemberSection.cs:86
	    }                                                                                                                                      // BuildMemberSection.cs:87
	}                                                                                                                                          // BuildMemberBase.cs:199
	#endregion                                                                                                                                 // BuildMemberBase.cs:200
	//- LocalClassDefs
}
