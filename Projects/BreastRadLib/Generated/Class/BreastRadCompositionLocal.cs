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
	#region Composition.section:report Container Class                                                                                         // BuildMemberBase.cs:158
	// Called from BuildMemberSection.cs, Line 226
	// BuildMemberBase.cs:160
	/// <summary>
	/// Container class for Composition.section:report.
	/// </summary>
	public class ReportContainer : MContainer, ITMItem<Composition.SectionComponent>                                                           // BuildMemberBase.cs:163
	{                                                                                                                                          // BuildMemberBase.cs:164
	    #region Composition.section:report Item Class                                                                                          // BuildMemberBase.cs:75
	    // Called from BuildMemberSection.cs, Line 226
	    // BuildMemberBase.cs:77
	    /// <summary>
	    /// Item class for Composition.section:report.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:80
	    {                                                                                                                                      // BuildMemberBase.cs:81
	        // Properties                                                                                                                      // BuildMemberBase.cs:82
	        // BuildMemberBase.cs:84
	        /// <summary>
	        /// Value
	        /// </summary>
	        public BreastRadReport Value { get; set; }                                                                                         // BuildMemberBase.cs:87
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
	        public ResourceReference WriteItem(BreastRadiologyDocument doc)                                                                    // BuildMemberSection.cs:60
	        {                                                                                                                                  // BuildMemberSection.cs:61
	            return new ResourceReference                                                                                                   // BuildMemberSection.cs:62
	            {                                                                                                                              // BuildMemberSection.cs:63
	                Reference = this.Value.Id                                                                                                  // BuildMemberSection.cs:64
	            };                                                                                                                             // BuildMemberSection.cs:65
	        }                                                                                                                                  // BuildMemberSection.cs:66
	                                                                                                                                           // BuildMemberBase.cs:108
	        // BuildMemberBase.cs:109
	        /// <summary>
	        /// Read item.
	        /// </summary>
	        public void ReadItem(BreastRadiologyDocument doc, ResourceReference resourceReference)                                             // BuildMemberSection.cs:50
	        {                                                                                                                                  // BuildMemberSection.cs:51
	            this.Value = (BreastRadReport) doc.GetResource(resourceReference);                                                             // BuildMemberSection.cs:52
	        }                                                                                                                                  // BuildMemberSection.cs:53
	    }                                                                                                                                      // BuildMemberBase.cs:115
	    #endregion                                                                                                                             // BuildMemberBase.cs:116
	                                                                                                                                           // BuildMemberBase.cs:167
	    // Properties                                                                                                                          // BuildMemberBase.cs:168
	    #region Common Singleton Properties                                                                                                    // BuildMemberBase.cs:192
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
	    public BreastRadReport Get()                                                                                                           // BuildMemberBase.cs:233
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
	    public BreastRadReport Set(BreastRadReport value)                                                                                      // BuildMemberBase.cs:248
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
	    public ReportContainer(Int32 min, Int32 max) : base("Composition.section:report", min, max)                                            // BuildMemberBase.cs:175
	    {                                                                                                                                      // BuildMemberBase.cs:176
	    }                                                                                                                                      // BuildMemberBase.cs:178
	                                                                                                                                           // BuildMemberBase.cs:180
	    // Methods                                                                                                                             // BuildMemberBase.cs:181
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
	                                                                                                                                           // BuildMemberBase.cs:334
	    // BuildMemberBase.cs:335
	    /// <summary>
	    /// Write container items.
	    /// </summary>
	    public IEnumerable<Composition.SectionComponent> Write(BreastRadiologyDocument doc)                                                    // BuildMemberSection.cs:102
	    {                                                                                                                                      // BuildMemberSection.cs:103
	        Composition.SectionComponent section = new Composition.SectionComponent                                                            // BuildMemberSection.cs:104
	        {                                                                                                                                  // BuildMemberSection.cs:105
	            Title = "Breast Radiology Report",                                                                                             // BuildMemberSection.cs:106
	            Code = SectionCode()                                                                                                           // BuildMemberSection.cs:107
	        };                                                                                                                                 // BuildMemberSection.cs:108
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberSection.cs:109
	        {                                                                                                                                  // BuildMemberSection.cs:110
	            section.Entry.Add(item.WriteItem(doc));                                                                                        // BuildMemberSection.cs:111
	        }                                                                                                                                  // BuildMemberSection.cs:112
	        return new Composition.SectionComponent[] { section };                                                                             // BuildMemberSection.cs:113
	    }                                                                                                                                      // BuildMemberSection.cs:114
	                                                                                                                                           // BuildMemberBase.cs:340
	    // BuildMemberBase.cs:341
	    /// <summary>
	    /// Read container items.
	    /// </summary>
	                                                                                                                                           // BuildMemberSection.cs:73
	    public void Read(BreastRadiologyDocument doc, IEnumerable<Composition.SectionComponent> sections)                                      // BuildMemberSection.cs:74
	    {                                                                                                                                      // BuildMemberSection.cs:75
	        IEnumerable<Composition.SectionComponent> memberSections = base.IsMember(doc,                                                      // BuildMemberSection.cs:76
	            sections,                                                                                                                      // BuildMemberSection.cs:77
	            SectionCode());                                                                                                                // BuildMemberSection.cs:78
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberSection.cs:79
	        // There really should only ever be one section...                                                                                 // BuildMemberSection.cs:80
	        foreach (Composition.SectionComponent memberSection in memberSections)                                                             // BuildMemberSection.cs:81
	        {                                                                                                                                  // BuildMemberSection.cs:82
	            foreach (ResourceReference entryRef in memberSection.Entry)                                                                    // BuildMemberSection.cs:83
	            {                                                                                                                              // BuildMemberSection.cs:84
	                Item item = new Item();                                                                                                    // BuildMemberSection.cs:85
	                item.ReadItem(doc, entryRef);                                                                                              // BuildMemberSection.cs:86
	                items.Add(item);                                                                                                           // BuildMemberSection.cs:87
	            }                                                                                                                              // BuildMemberSection.cs:88
	        }                                                                                                                                  // BuildMemberSection.cs:89
	        this.SetAllItems(items);                                                                                                           // BuildMemberSection.cs:90
	    }                                                                                                                                      // BuildMemberSection.cs:91
	}                                                                                                                                          // BuildMemberBase.cs:183
	#endregion                                                                                                                                 // BuildMemberBase.cs:184
	#region Composition.section:impressions Container Class                                                                                    // BuildMemberBase.cs:158
	// Called from BuildMemberSection.cs, Line 226
	// BuildMemberBase.cs:160
	/// <summary>
	/// Container class for Composition.section:impressions.
	/// </summary>
	public class ImpressionsContainer : MContainer, ITMItem<Composition.SectionComponent>                                                      // BuildMemberBase.cs:163
	{                                                                                                                                          // BuildMemberBase.cs:164
	    #region Composition.section:impressions Item Class                                                                                     // BuildMemberBase.cs:75
	    // Called from BuildMemberSection.cs, Line 226
	    // BuildMemberBase.cs:77
	    /// <summary>
	    /// Item class for Composition.section:impressions.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:80
	    {                                                                                                                                      // BuildMemberBase.cs:81
	        // Properties                                                                                                                      // BuildMemberBase.cs:82
	        // BuildMemberBase.cs:84
	        /// <summary>
	        /// Value
	        /// </summary>
	        public ClinicalImpressionBase Value { get; set; }                                                                                  // BuildMemberBase.cs:87
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
	        public ResourceReference WriteItem(BreastRadiologyDocument doc)                                                                    // BuildMemberSection.cs:60
	        {                                                                                                                                  // BuildMemberSection.cs:61
	            return new ResourceReference                                                                                                   // BuildMemberSection.cs:62
	            {                                                                                                                              // BuildMemberSection.cs:63
	                Reference = this.Value.Id                                                                                                  // BuildMemberSection.cs:64
	            };                                                                                                                             // BuildMemberSection.cs:65
	        }                                                                                                                                  // BuildMemberSection.cs:66
	                                                                                                                                           // BuildMemberBase.cs:108
	        // BuildMemberBase.cs:109
	        /// <summary>
	        /// Read item.
	        /// </summary>
	        public void ReadItem(BreastRadiologyDocument doc, ResourceReference resourceReference)                                             // BuildMemberSection.cs:50
	        {                                                                                                                                  // BuildMemberSection.cs:51
	            this.Value = (ClinicalImpressionBase) doc.GetResource(resourceReference);                                                      // BuildMemberSection.cs:52
	        }                                                                                                                                  // BuildMemberSection.cs:53
	    }                                                                                                                                      // BuildMemberBase.cs:115
	    #endregion                                                                                                                             // BuildMemberBase.cs:116
	                                                                                                                                           // BuildMemberBase.cs:167
	    // Properties                                                                                                                          // BuildMemberBase.cs:168
	    #region Common Non-Singleton Properties                                                                                                // BuildMemberBase.cs:261
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:262
	                                                                                                                                           // BuildMemberBase.cs:264
	    // BuildMemberBase.cs:265
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:268
	                                                                                                                                           // BuildMemberBase.cs:270
	    // BuildMemberBase.cs:271
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:274
	                                                                                                                                           // BuildMemberBase.cs:276
	    // BuildMemberBase.cs:277
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:280
	                                                                                                                                           // BuildMemberBase.cs:282
	    // BuildMemberBase.cs:283
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<ClinicalImpressionBase> All()                                                                                       // BuildMemberBase.cs:286
	    {                                                                                                                                      // BuildMemberBase.cs:287
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:288
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:289
	    }                                                                                                                                      // BuildMemberBase.cs:290
	                                                                                                                                           // BuildMemberBase.cs:292
	    // BuildMemberBase.cs:293
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public ClinicalImpressionBase GetAt(Int32 i) => this.items[i].Value;                                                                   // BuildMemberBase.cs:296
	                                                                                                                                           // BuildMemberBase.cs:298
	    // BuildMemberBase.cs:299
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:302
	                                                                                                                                           // BuildMemberBase.cs:304
	    // BuildMemberBase.cs:305
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:308
	    #endregion                                                                                                                             // BuildMemberBase.cs:330
	                                                                                                                                           // BuildMemberBase.cs:171
	    // BuildMemberBase.cs:172
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public ImpressionsContainer(Int32 min, Int32 max) : base("Composition.section:impressions", min, max)                                  // BuildMemberBase.cs:175
	    {                                                                                                                                      // BuildMemberBase.cs:176
	    }                                                                                                                                      // BuildMemberBase.cs:178
	                                                                                                                                           // BuildMemberBase.cs:180
	    // Methods                                                                                                                             // BuildMemberBase.cs:181
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
	                                                                                                                                           // BuildMemberBase.cs:314
	    // BuildMemberBase.cs:315
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public ClinicalImpressionBase Append(ClinicalImpressionBase value)                                                                     // BuildMemberBase.cs:318
	    {                                                                                                                                      // BuildMemberBase.cs:319
	        Item item = new Item();                                                                                                            // BuildMemberBase.cs:320
	        item.Value = value;                                                                                                                // BuildMemberBase.cs:321
	        this.items.Add(item);                                                                                                              // BuildMemberBase.cs:322
	        return value;                                                                                                                      // BuildMemberBase.cs:323
	    }                                                                                                                                      // BuildMemberBase.cs:324
	                                                                                                                                           // BuildMemberBase.cs:334
	    // BuildMemberBase.cs:335
	    /// <summary>
	    /// Write container items.
	    /// </summary>
	    public IEnumerable<Composition.SectionComponent> Write(BreastRadiologyDocument doc)                                                    // BuildMemberSection.cs:102
	    {                                                                                                                                      // BuildMemberSection.cs:103
	        Composition.SectionComponent section = new Composition.SectionComponent                                                            // BuildMemberSection.cs:104
	        {                                                                                                                                  // BuildMemberSection.cs:105
	            Title = "Clinical Impressions",                                                                                                // BuildMemberSection.cs:106
	            Code = SectionCode()                                                                                                           // BuildMemberSection.cs:107
	        };                                                                                                                                 // BuildMemberSection.cs:108
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberSection.cs:109
	        {                                                                                                                                  // BuildMemberSection.cs:110
	            section.Entry.Add(item.WriteItem(doc));                                                                                        // BuildMemberSection.cs:111
	        }                                                                                                                                  // BuildMemberSection.cs:112
	        return new Composition.SectionComponent[] { section };                                                                             // BuildMemberSection.cs:113
	    }                                                                                                                                      // BuildMemberSection.cs:114
	                                                                                                                                           // BuildMemberBase.cs:340
	    // BuildMemberBase.cs:341
	    /// <summary>
	    /// Read container items.
	    /// </summary>
	                                                                                                                                           // BuildMemberSection.cs:73
	    public void Read(BreastRadiologyDocument doc, IEnumerable<Composition.SectionComponent> sections)                                      // BuildMemberSection.cs:74
	    {                                                                                                                                      // BuildMemberSection.cs:75
	        IEnumerable<Composition.SectionComponent> memberSections = base.IsMember(doc,                                                      // BuildMemberSection.cs:76
	            sections,                                                                                                                      // BuildMemberSection.cs:77
	            SectionCode());                                                                                                                // BuildMemberSection.cs:78
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberSection.cs:79
	        // There really should only ever be one section...                                                                                 // BuildMemberSection.cs:80
	        foreach (Composition.SectionComponent memberSection in memberSections)                                                             // BuildMemberSection.cs:81
	        {                                                                                                                                  // BuildMemberSection.cs:82
	            foreach (ResourceReference entryRef in memberSection.Entry)                                                                    // BuildMemberSection.cs:83
	            {                                                                                                                              // BuildMemberSection.cs:84
	                Item item = new Item();                                                                                                    // BuildMemberSection.cs:85
	                item.ReadItem(doc, entryRef);                                                                                              // BuildMemberSection.cs:86
	                items.Add(item);                                                                                                           // BuildMemberSection.cs:87
	            }                                                                                                                              // BuildMemberSection.cs:88
	        }                                                                                                                                  // BuildMemberSection.cs:89
	        this.SetAllItems(items);                                                                                                           // BuildMemberSection.cs:90
	    }                                                                                                                                      // BuildMemberSection.cs:91
	}                                                                                                                                          // BuildMemberBase.cs:183
	#endregion                                                                                                                                 // BuildMemberBase.cs:184
	#region Composition.section:findingsRightBreast Container Class                                                                            // BuildMemberBase.cs:158
	// Called from BuildMemberSection.cs, Line 226
	// BuildMemberBase.cs:160
	/// <summary>
	/// Container class for Composition.section:findingsRightBreast.
	/// </summary>
	public class FindingsRightBreastContainer : MContainer, ITMItem<Composition.SectionComponent>                                              // BuildMemberBase.cs:163
	{                                                                                                                                          // BuildMemberBase.cs:164
	    #region Composition.section:findingsRightBreast Item Class                                                                             // BuildMemberBase.cs:75
	    // Called from BuildMemberSection.cs, Line 226
	    // BuildMemberBase.cs:77
	    /// <summary>
	    /// Item class for Composition.section:findingsRightBreast.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:80
	    {                                                                                                                                      // BuildMemberBase.cs:81
	        // Properties                                                                                                                      // BuildMemberBase.cs:82
	        // BuildMemberBase.cs:84
	        /// <summary>
	        /// Value
	        /// </summary>
	        public SectionFindingsRightBreast Value { get; set; }                                                                              // BuildMemberBase.cs:87
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
	        public ResourceReference WriteItem(BreastRadiologyDocument doc)                                                                    // BuildMemberSection.cs:60
	        {                                                                                                                                  // BuildMemberSection.cs:61
	            return new ResourceReference                                                                                                   // BuildMemberSection.cs:62
	            {                                                                                                                              // BuildMemberSection.cs:63
	                Reference = this.Value.Id                                                                                                  // BuildMemberSection.cs:64
	            };                                                                                                                             // BuildMemberSection.cs:65
	        }                                                                                                                                  // BuildMemberSection.cs:66
	                                                                                                                                           // BuildMemberBase.cs:108
	        // BuildMemberBase.cs:109
	        /// <summary>
	        /// Read item.
	        /// </summary>
	        public void ReadItem(BreastRadiologyDocument doc, ResourceReference resourceReference)                                             // BuildMemberSection.cs:50
	        {                                                                                                                                  // BuildMemberSection.cs:51
	            this.Value = (SectionFindingsRightBreast) doc.GetResource(resourceReference);                                                  // BuildMemberSection.cs:52
	        }                                                                                                                                  // BuildMemberSection.cs:53
	    }                                                                                                                                      // BuildMemberBase.cs:115
	    #endregion                                                                                                                             // BuildMemberBase.cs:116
	                                                                                                                                           // BuildMemberBase.cs:167
	    // Properties                                                                                                                          // BuildMemberBase.cs:168
	    #region Common Singleton Properties                                                                                                    // BuildMemberBase.cs:192
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
	    public SectionFindingsRightBreast Get()                                                                                                // BuildMemberBase.cs:233
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
	    public SectionFindingsRightBreast Set(SectionFindingsRightBreast value)                                                                // BuildMemberBase.cs:248
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
	    public FindingsRightBreastContainer(Int32 min, Int32 max) : base("Composition.section:findingsRightBreast", min, max)                  // BuildMemberBase.cs:175
	    {                                                                                                                                      // BuildMemberBase.cs:176
	    }                                                                                                                                      // BuildMemberBase.cs:178
	                                                                                                                                           // BuildMemberBase.cs:180
	    // Methods                                                                                                                             // BuildMemberBase.cs:181
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
	                                                                                                                                           // BuildMemberBase.cs:334
	    // BuildMemberBase.cs:335
	    /// <summary>
	    /// Write container items.
	    /// </summary>
	    public IEnumerable<Composition.SectionComponent> Write(BreastRadiologyDocument doc)                                                    // BuildMemberSection.cs:102
	    {                                                                                                                                      // BuildMemberSection.cs:103
	        Composition.SectionComponent section = new Composition.SectionComponent                                                            // BuildMemberSection.cs:104
	        {                                                                                                                                  // BuildMemberSection.cs:105
	            Title = "Findings Right Breast",                                                                                               // BuildMemberSection.cs:106
	            Code = SectionCode()                                                                                                           // BuildMemberSection.cs:107
	        };                                                                                                                                 // BuildMemberSection.cs:108
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberSection.cs:109
	        {                                                                                                                                  // BuildMemberSection.cs:110
	            section.Entry.Add(item.WriteItem(doc));                                                                                        // BuildMemberSection.cs:111
	        }                                                                                                                                  // BuildMemberSection.cs:112
	        return new Composition.SectionComponent[] { section };                                                                             // BuildMemberSection.cs:113
	    }                                                                                                                                      // BuildMemberSection.cs:114
	                                                                                                                                           // BuildMemberBase.cs:340
	    // BuildMemberBase.cs:341
	    /// <summary>
	    /// Read container items.
	    /// </summary>
	                                                                                                                                           // BuildMemberSection.cs:73
	    public void Read(BreastRadiologyDocument doc, IEnumerable<Composition.SectionComponent> sections)                                      // BuildMemberSection.cs:74
	    {                                                                                                                                      // BuildMemberSection.cs:75
	        IEnumerable<Composition.SectionComponent> memberSections = base.IsMember(doc,                                                      // BuildMemberSection.cs:76
	            sections,                                                                                                                      // BuildMemberSection.cs:77
	            SectionCode());                                                                                                                // BuildMemberSection.cs:78
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberSection.cs:79
	        // There really should only ever be one section...                                                                                 // BuildMemberSection.cs:80
	        foreach (Composition.SectionComponent memberSection in memberSections)                                                             // BuildMemberSection.cs:81
	        {                                                                                                                                  // BuildMemberSection.cs:82
	            foreach (ResourceReference entryRef in memberSection.Entry)                                                                    // BuildMemberSection.cs:83
	            {                                                                                                                              // BuildMemberSection.cs:84
	                Item item = new Item();                                                                                                    // BuildMemberSection.cs:85
	                item.ReadItem(doc, entryRef);                                                                                              // BuildMemberSection.cs:86
	                items.Add(item);                                                                                                           // BuildMemberSection.cs:87
	            }                                                                                                                              // BuildMemberSection.cs:88
	        }                                                                                                                                  // BuildMemberSection.cs:89
	        this.SetAllItems(items);                                                                                                           // BuildMemberSection.cs:90
	    }                                                                                                                                      // BuildMemberSection.cs:91
	}                                                                                                                                          // BuildMemberBase.cs:183
	#endregion                                                                                                                                 // BuildMemberBase.cs:184
	#region Composition.section:findingsLeftBreast Container Class                                                                             // BuildMemberBase.cs:158
	// Called from BuildMemberSection.cs, Line 226
	// BuildMemberBase.cs:160
	/// <summary>
	/// Container class for Composition.section:findingsLeftBreast.
	/// </summary>
	public class FindingsLeftBreastContainer : MContainer, ITMItem<Composition.SectionComponent>                                               // BuildMemberBase.cs:163
	{                                                                                                                                          // BuildMemberBase.cs:164
	    #region Composition.section:findingsLeftBreast Item Class                                                                              // BuildMemberBase.cs:75
	    // Called from BuildMemberSection.cs, Line 226
	    // BuildMemberBase.cs:77
	    /// <summary>
	    /// Item class for Composition.section:findingsLeftBreast.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:80
	    {                                                                                                                                      // BuildMemberBase.cs:81
	        // Properties                                                                                                                      // BuildMemberBase.cs:82
	        // BuildMemberBase.cs:84
	        /// <summary>
	        /// Value
	        /// </summary>
	        public SectionFindingsLeftBreast Value { get; set; }                                                                               // BuildMemberBase.cs:87
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
	        public ResourceReference WriteItem(BreastRadiologyDocument doc)                                                                    // BuildMemberSection.cs:60
	        {                                                                                                                                  // BuildMemberSection.cs:61
	            return new ResourceReference                                                                                                   // BuildMemberSection.cs:62
	            {                                                                                                                              // BuildMemberSection.cs:63
	                Reference = this.Value.Id                                                                                                  // BuildMemberSection.cs:64
	            };                                                                                                                             // BuildMemberSection.cs:65
	        }                                                                                                                                  // BuildMemberSection.cs:66
	                                                                                                                                           // BuildMemberBase.cs:108
	        // BuildMemberBase.cs:109
	        /// <summary>
	        /// Read item.
	        /// </summary>
	        public void ReadItem(BreastRadiologyDocument doc, ResourceReference resourceReference)                                             // BuildMemberSection.cs:50
	        {                                                                                                                                  // BuildMemberSection.cs:51
	            this.Value = (SectionFindingsLeftBreast) doc.GetResource(resourceReference);                                                   // BuildMemberSection.cs:52
	        }                                                                                                                                  // BuildMemberSection.cs:53
	    }                                                                                                                                      // BuildMemberBase.cs:115
	    #endregion                                                                                                                             // BuildMemberBase.cs:116
	                                                                                                                                           // BuildMemberBase.cs:167
	    // Properties                                                                                                                          // BuildMemberBase.cs:168
	    #region Common Singleton Properties                                                                                                    // BuildMemberBase.cs:192
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
	    public SectionFindingsLeftBreast Get()                                                                                                 // BuildMemberBase.cs:233
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
	    public SectionFindingsLeftBreast Set(SectionFindingsLeftBreast value)                                                                  // BuildMemberBase.cs:248
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
	    public FindingsLeftBreastContainer(Int32 min, Int32 max) : base("Composition.section:findingsLeftBreast", min, max)                    // BuildMemberBase.cs:175
	    {                                                                                                                                      // BuildMemberBase.cs:176
	    }                                                                                                                                      // BuildMemberBase.cs:178
	                                                                                                                                           // BuildMemberBase.cs:180
	    // Methods                                                                                                                             // BuildMemberBase.cs:181
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
	                                                                                                                                           // BuildMemberBase.cs:334
	    // BuildMemberBase.cs:335
	    /// <summary>
	    /// Write container items.
	    /// </summary>
	    public IEnumerable<Composition.SectionComponent> Write(BreastRadiologyDocument doc)                                                    // BuildMemberSection.cs:102
	    {                                                                                                                                      // BuildMemberSection.cs:103
	        Composition.SectionComponent section = new Composition.SectionComponent                                                            // BuildMemberSection.cs:104
	        {                                                                                                                                  // BuildMemberSection.cs:105
	            Title = "Findings Left Breast",                                                                                                // BuildMemberSection.cs:106
	            Code = SectionCode()                                                                                                           // BuildMemberSection.cs:107
	        };                                                                                                                                 // BuildMemberSection.cs:108
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberSection.cs:109
	        {                                                                                                                                  // BuildMemberSection.cs:110
	            section.Entry.Add(item.WriteItem(doc));                                                                                        // BuildMemberSection.cs:111
	        }                                                                                                                                  // BuildMemberSection.cs:112
	        return new Composition.SectionComponent[] { section };                                                                             // BuildMemberSection.cs:113
	    }                                                                                                                                      // BuildMemberSection.cs:114
	                                                                                                                                           // BuildMemberBase.cs:340
	    // BuildMemberBase.cs:341
	    /// <summary>
	    /// Read container items.
	    /// </summary>
	                                                                                                                                           // BuildMemberSection.cs:73
	    public void Read(BreastRadiologyDocument doc, IEnumerable<Composition.SectionComponent> sections)                                      // BuildMemberSection.cs:74
	    {                                                                                                                                      // BuildMemberSection.cs:75
	        IEnumerable<Composition.SectionComponent> memberSections = base.IsMember(doc,                                                      // BuildMemberSection.cs:76
	            sections,                                                                                                                      // BuildMemberSection.cs:77
	            SectionCode());                                                                                                                // BuildMemberSection.cs:78
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberSection.cs:79
	        // There really should only ever be one section...                                                                                 // BuildMemberSection.cs:80
	        foreach (Composition.SectionComponent memberSection in memberSections)                                                             // BuildMemberSection.cs:81
	        {                                                                                                                                  // BuildMemberSection.cs:82
	            foreach (ResourceReference entryRef in memberSection.Entry)                                                                    // BuildMemberSection.cs:83
	            {                                                                                                                              // BuildMemberSection.cs:84
	                Item item = new Item();                                                                                                    // BuildMemberSection.cs:85
	                item.ReadItem(doc, entryRef);                                                                                              // BuildMemberSection.cs:86
	                items.Add(item);                                                                                                           // BuildMemberSection.cs:87
	            }                                                                                                                              // BuildMemberSection.cs:88
	        }                                                                                                                                  // BuildMemberSection.cs:89
	        this.SetAllItems(items);                                                                                                           // BuildMemberSection.cs:90
	    }                                                                                                                                      // BuildMemberSection.cs:91
	}                                                                                                                                          // BuildMemberBase.cs:183
	#endregion                                                                                                                                 // BuildMemberBase.cs:184
	#region Composition.section:relatedResources Container Class                                                                               // BuildMemberBase.cs:158
	// Called from BuildMemberSection.cs, Line 226
	// BuildMemberBase.cs:160
	/// <summary>
	/// Container class for Composition.section:relatedResources.
	/// </summary>
	public class RelatedResourcesContainer : MContainer, ITMItem<Composition.SectionComponent>                                                 // BuildMemberBase.cs:163
	{                                                                                                                                          // BuildMemberBase.cs:164
	    #region Composition.section:relatedResources Item Class                                                                                // BuildMemberBase.cs:75
	    // Called from BuildMemberSection.cs, Line 226
	    // BuildMemberBase.cs:77
	    /// <summary>
	    /// Item class for Composition.section:relatedResources.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:80
	    {                                                                                                                                      // BuildMemberBase.cs:81
	        // Properties                                                                                                                      // BuildMemberBase.cs:82
	        // BuildMemberBase.cs:84
	        /// <summary>
	        /// Value
	        /// </summary>
	        public ResourceBase Value { get; set; }                                                                                            // BuildMemberBase.cs:87
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
	        public ResourceReference WriteItem(BreastRadiologyDocument doc)                                                                    // BuildMemberSection.cs:60
	        {                                                                                                                                  // BuildMemberSection.cs:61
	            return new ResourceReference                                                                                                   // BuildMemberSection.cs:62
	            {                                                                                                                              // BuildMemberSection.cs:63
	                Reference = this.Value.Id                                                                                                  // BuildMemberSection.cs:64
	            };                                                                                                                             // BuildMemberSection.cs:65
	        }                                                                                                                                  // BuildMemberSection.cs:66
	                                                                                                                                           // BuildMemberBase.cs:108
	        // BuildMemberBase.cs:109
	        /// <summary>
	        /// Read item.
	        /// </summary>
	        public void ReadItem(BreastRadiologyDocument doc, ResourceReference resourceReference)                                             // BuildMemberSection.cs:50
	        {                                                                                                                                  // BuildMemberSection.cs:51
	            this.Value = (ResourceBase) doc.GetResource(resourceReference);                                                                // BuildMemberSection.cs:52
	        }                                                                                                                                  // BuildMemberSection.cs:53
	    }                                                                                                                                      // BuildMemberBase.cs:115
	    #endregion                                                                                                                             // BuildMemberBase.cs:116
	                                                                                                                                           // BuildMemberBase.cs:167
	    // Properties                                                                                                                          // BuildMemberBase.cs:168
	    #region Common Non-Singleton Properties                                                                                                // BuildMemberBase.cs:261
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:262
	                                                                                                                                           // BuildMemberBase.cs:264
	    // BuildMemberBase.cs:265
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:268
	                                                                                                                                           // BuildMemberBase.cs:270
	    // BuildMemberBase.cs:271
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:274
	                                                                                                                                           // BuildMemberBase.cs:276
	    // BuildMemberBase.cs:277
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:280
	                                                                                                                                           // BuildMemberBase.cs:282
	    // BuildMemberBase.cs:283
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<ResourceBase> All()                                                                                                 // BuildMemberBase.cs:286
	    {                                                                                                                                      // BuildMemberBase.cs:287
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:288
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:289
	    }                                                                                                                                      // BuildMemberBase.cs:290
	                                                                                                                                           // BuildMemberBase.cs:292
	    // BuildMemberBase.cs:293
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public ResourceBase GetAt(Int32 i) => this.items[i].Value;                                                                             // BuildMemberBase.cs:296
	                                                                                                                                           // BuildMemberBase.cs:298
	    // BuildMemberBase.cs:299
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:302
	                                                                                                                                           // BuildMemberBase.cs:304
	    // BuildMemberBase.cs:305
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:308
	    #endregion                                                                                                                             // BuildMemberBase.cs:330
	                                                                                                                                           // BuildMemberBase.cs:171
	    // BuildMemberBase.cs:172
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public RelatedResourcesContainer(Int32 min, Int32 max) : base("Composition.section:relatedResources", min, max)                        // BuildMemberBase.cs:175
	    {                                                                                                                                      // BuildMemberBase.cs:176
	    }                                                                                                                                      // BuildMemberBase.cs:178
	                                                                                                                                           // BuildMemberBase.cs:180
	    // Methods                                                                                                                             // BuildMemberBase.cs:181
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
	                                                                                                                                           // BuildMemberBase.cs:314
	    // BuildMemberBase.cs:315
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public ResourceBase Append(ResourceBase value)                                                                                         // BuildMemberBase.cs:318
	    {                                                                                                                                      // BuildMemberBase.cs:319
	        Item item = new Item();                                                                                                            // BuildMemberBase.cs:320
	        item.Value = value;                                                                                                                // BuildMemberBase.cs:321
	        this.items.Add(item);                                                                                                              // BuildMemberBase.cs:322
	        return value;                                                                                                                      // BuildMemberBase.cs:323
	    }                                                                                                                                      // BuildMemberBase.cs:324
	                                                                                                                                           // BuildMemberBase.cs:334
	    // BuildMemberBase.cs:335
	    /// <summary>
	    /// Write container items.
	    /// </summary>
	    public IEnumerable<Composition.SectionComponent> Write(BreastRadiologyDocument doc)                                                    // BuildMemberSection.cs:102
	    {                                                                                                                                      // BuildMemberSection.cs:103
	        Composition.SectionComponent section = new Composition.SectionComponent                                                            // BuildMemberSection.cs:104
	        {                                                                                                                                  // BuildMemberSection.cs:105
	            Title = "Related Resources",                                                                                                   // BuildMemberSection.cs:106
	            Code = SectionCode()                                                                                                           // BuildMemberSection.cs:107
	        };                                                                                                                                 // BuildMemberSection.cs:108
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberSection.cs:109
	        {                                                                                                                                  // BuildMemberSection.cs:110
	            section.Entry.Add(item.WriteItem(doc));                                                                                        // BuildMemberSection.cs:111
	        }                                                                                                                                  // BuildMemberSection.cs:112
	        return new Composition.SectionComponent[] { section };                                                                             // BuildMemberSection.cs:113
	    }                                                                                                                                      // BuildMemberSection.cs:114
	                                                                                                                                           // BuildMemberBase.cs:340
	    // BuildMemberBase.cs:341
	    /// <summary>
	    /// Read container items.
	    /// </summary>
	                                                                                                                                           // BuildMemberSection.cs:73
	    public void Read(BreastRadiologyDocument doc, IEnumerable<Composition.SectionComponent> sections)                                      // BuildMemberSection.cs:74
	    {                                                                                                                                      // BuildMemberSection.cs:75
	        IEnumerable<Composition.SectionComponent> memberSections = base.IsMember(doc,                                                      // BuildMemberSection.cs:76
	            sections,                                                                                                                      // BuildMemberSection.cs:77
	            SectionCode());                                                                                                                // BuildMemberSection.cs:78
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberSection.cs:79
	        // There really should only ever be one section...                                                                                 // BuildMemberSection.cs:80
	        foreach (Composition.SectionComponent memberSection in memberSections)                                                             // BuildMemberSection.cs:81
	        {                                                                                                                                  // BuildMemberSection.cs:82
	            foreach (ResourceReference entryRef in memberSection.Entry)                                                                    // BuildMemberSection.cs:83
	            {                                                                                                                              // BuildMemberSection.cs:84
	                Item item = new Item();                                                                                                    // BuildMemberSection.cs:85
	                item.ReadItem(doc, entryRef);                                                                                              // BuildMemberSection.cs:86
	                items.Add(item);                                                                                                           // BuildMemberSection.cs:87
	            }                                                                                                                              // BuildMemberSection.cs:88
	        }                                                                                                                                  // BuildMemberSection.cs:89
	        this.SetAllItems(items);                                                                                                           // BuildMemberSection.cs:90
	    }                                                                                                                                      // BuildMemberSection.cs:91
	}                                                                                                                                          // BuildMemberBase.cs:183
	#endregion                                                                                                                                 // BuildMemberBase.cs:184
	#region Composition.section:recommendations Container Class                                                                                // BuildMemberBase.cs:158
	// Called from BuildMemberSection.cs, Line 226
	// BuildMemberBase.cs:160
	/// <summary>
	/// Container class for Composition.section:recommendations.
	/// </summary>
	public class RecommendationsContainer : MContainer, ITMItem<Composition.SectionComponent>                                                  // BuildMemberBase.cs:163
	{                                                                                                                                          // BuildMemberBase.cs:164
	    #region Composition.section:recommendations Item Class                                                                                 // BuildMemberBase.cs:75
	    // Called from BuildMemberSection.cs, Line 226
	    // BuildMemberBase.cs:77
	    /// <summary>
	    /// Item class for Composition.section:recommendations.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:80
	    {                                                                                                                                      // BuildMemberBase.cs:81
	        // Properties                                                                                                                      // BuildMemberBase.cs:82
	        // BuildMemberBase.cs:84
	        /// <summary>
	        /// Value
	        /// </summary>
	        public ResourceBase Value { get; set; }                                                                                            // BuildMemberBase.cs:87
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
	        public ResourceReference WriteItem(BreastRadiologyDocument doc)                                                                    // BuildMemberSection.cs:60
	        {                                                                                                                                  // BuildMemberSection.cs:61
	            return new ResourceReference                                                                                                   // BuildMemberSection.cs:62
	            {                                                                                                                              // BuildMemberSection.cs:63
	                Reference = this.Value.Id                                                                                                  // BuildMemberSection.cs:64
	            };                                                                                                                             // BuildMemberSection.cs:65
	        }                                                                                                                                  // BuildMemberSection.cs:66
	                                                                                                                                           // BuildMemberBase.cs:108
	        // BuildMemberBase.cs:109
	        /// <summary>
	        /// Read item.
	        /// </summary>
	        public void ReadItem(BreastRadiologyDocument doc, ResourceReference resourceReference)                                             // BuildMemberSection.cs:50
	        {                                                                                                                                  // BuildMemberSection.cs:51
	            this.Value = (ResourceBase) doc.GetResource(resourceReference);                                                                // BuildMemberSection.cs:52
	        }                                                                                                                                  // BuildMemberSection.cs:53
	    }                                                                                                                                      // BuildMemberBase.cs:115
	    #endregion                                                                                                                             // BuildMemberBase.cs:116
	                                                                                                                                           // BuildMemberBase.cs:167
	    // Properties                                                                                                                          // BuildMemberBase.cs:168
	    #region Common Non-Singleton Properties                                                                                                // BuildMemberBase.cs:261
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:262
	                                                                                                                                           // BuildMemberBase.cs:264
	    // BuildMemberBase.cs:265
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:268
	                                                                                                                                           // BuildMemberBase.cs:270
	    // BuildMemberBase.cs:271
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:274
	                                                                                                                                           // BuildMemberBase.cs:276
	    // BuildMemberBase.cs:277
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:280
	                                                                                                                                           // BuildMemberBase.cs:282
	    // BuildMemberBase.cs:283
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<ResourceBase> All()                                                                                                 // BuildMemberBase.cs:286
	    {                                                                                                                                      // BuildMemberBase.cs:287
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:288
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:289
	    }                                                                                                                                      // BuildMemberBase.cs:290
	                                                                                                                                           // BuildMemberBase.cs:292
	    // BuildMemberBase.cs:293
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public ResourceBase GetAt(Int32 i) => this.items[i].Value;                                                                             // BuildMemberBase.cs:296
	                                                                                                                                           // BuildMemberBase.cs:298
	    // BuildMemberBase.cs:299
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:302
	                                                                                                                                           // BuildMemberBase.cs:304
	    // BuildMemberBase.cs:305
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:308
	    #endregion                                                                                                                             // BuildMemberBase.cs:330
	                                                                                                                                           // BuildMemberBase.cs:171
	    // BuildMemberBase.cs:172
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public RecommendationsContainer(Int32 min, Int32 max) : base("Composition.section:recommendations", min, max)                          // BuildMemberBase.cs:175
	    {                                                                                                                                      // BuildMemberBase.cs:176
	    }                                                                                                                                      // BuildMemberBase.cs:178
	                                                                                                                                           // BuildMemberBase.cs:180
	    // Methods                                                                                                                             // BuildMemberBase.cs:181
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
	                                                                                                                                           // BuildMemberBase.cs:314
	    // BuildMemberBase.cs:315
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public MedicationRequestBase Append(MedicationRequestBase value)                                                                       // BuildMemberBase.cs:318
	    {                                                                                                                                      // BuildMemberBase.cs:319
	        Item item = new Item();                                                                                                            // BuildMemberBase.cs:320
	        item.Value = value;                                                                                                                // BuildMemberBase.cs:321
	        this.items.Add(item);                                                                                                              // BuildMemberBase.cs:322
	        return value;                                                                                                                      // BuildMemberBase.cs:323
	    }                                                                                                                                      // BuildMemberBase.cs:324
	                                                                                                                                           // BuildMemberBase.cs:314
	    // BuildMemberBase.cs:315
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public ServiceRequestBase Append(ServiceRequestBase value)                                                                             // BuildMemberBase.cs:318
	    {                                                                                                                                      // BuildMemberBase.cs:319
	        Item item = new Item();                                                                                                            // BuildMemberBase.cs:320
	        item.Value = value;                                                                                                                // BuildMemberBase.cs:321
	        this.items.Add(item);                                                                                                              // BuildMemberBase.cs:322
	        return value;                                                                                                                      // BuildMemberBase.cs:323
	    }                                                                                                                                      // BuildMemberBase.cs:324
	                                                                                                                                           // BuildMemberBase.cs:314
	    // BuildMemberBase.cs:315
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public ServiceRecommendation Append(ServiceRecommendation value)                                                                       // BuildMemberBase.cs:318
	    {                                                                                                                                      // BuildMemberBase.cs:319
	        Item item = new Item();                                                                                                            // BuildMemberBase.cs:320
	        item.Value = value;                                                                                                                // BuildMemberBase.cs:321
	        this.items.Add(item);                                                                                                              // BuildMemberBase.cs:322
	        return value;                                                                                                                      // BuildMemberBase.cs:323
	    }                                                                                                                                      // BuildMemberBase.cs:324
	                                                                                                                                           // BuildMemberBase.cs:334
	    // BuildMemberBase.cs:335
	    /// <summary>
	    /// Write container items.
	    /// </summary>
	    public IEnumerable<Composition.SectionComponent> Write(BreastRadiologyDocument doc)                                                    // BuildMemberSection.cs:102
	    {                                                                                                                                      // BuildMemberSection.cs:103
	        Composition.SectionComponent section = new Composition.SectionComponent                                                            // BuildMemberSection.cs:104
	        {                                                                                                                                  // BuildMemberSection.cs:105
	            Title = "Recommendations",                                                                                                     // BuildMemberSection.cs:106
	            Code = SectionCode()                                                                                                           // BuildMemberSection.cs:107
	        };                                                                                                                                 // BuildMemberSection.cs:108
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberSection.cs:109
	        {                                                                                                                                  // BuildMemberSection.cs:110
	            section.Entry.Add(item.WriteItem(doc));                                                                                        // BuildMemberSection.cs:111
	        }                                                                                                                                  // BuildMemberSection.cs:112
	        return new Composition.SectionComponent[] { section };                                                                             // BuildMemberSection.cs:113
	    }                                                                                                                                      // BuildMemberSection.cs:114
	                                                                                                                                           // BuildMemberBase.cs:340
	    // BuildMemberBase.cs:341
	    /// <summary>
	    /// Read container items.
	    /// </summary>
	                                                                                                                                           // BuildMemberSection.cs:73
	    public void Read(BreastRadiologyDocument doc, IEnumerable<Composition.SectionComponent> sections)                                      // BuildMemberSection.cs:74
	    {                                                                                                                                      // BuildMemberSection.cs:75
	        IEnumerable<Composition.SectionComponent> memberSections = base.IsMember(doc,                                                      // BuildMemberSection.cs:76
	            sections,                                                                                                                      // BuildMemberSection.cs:77
	            SectionCode());                                                                                                                // BuildMemberSection.cs:78
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberSection.cs:79
	        // There really should only ever be one section...                                                                                 // BuildMemberSection.cs:80
	        foreach (Composition.SectionComponent memberSection in memberSections)                                                             // BuildMemberSection.cs:81
	        {                                                                                                                                  // BuildMemberSection.cs:82
	            foreach (ResourceReference entryRef in memberSection.Entry)                                                                    // BuildMemberSection.cs:83
	            {                                                                                                                              // BuildMemberSection.cs:84
	                Item item = new Item();                                                                                                    // BuildMemberSection.cs:85
	                item.ReadItem(doc, entryRef);                                                                                              // BuildMemberSection.cs:86
	                items.Add(item);                                                                                                           // BuildMemberSection.cs:87
	            }                                                                                                                              // BuildMemberSection.cs:88
	        }                                                                                                                                  // BuildMemberSection.cs:89
	        this.SetAllItems(items);                                                                                                           // BuildMemberSection.cs:90
	    }                                                                                                                                      // BuildMemberSection.cs:91
	}                                                                                                                                          // BuildMemberBase.cs:183
	#endregion                                                                                                                                 // BuildMemberBase.cs:184
	//- LocalClassDefs
}
