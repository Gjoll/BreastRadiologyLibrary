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
	#region Composition.section:report Container Class                                                                                         // BuildMemberBase.cs:157
	// Called from BuildMemberSection.cs, Line 224
	// BuildMemberBase.cs:159
	/// <summary>
	/// Container class for Composition.section:report.
	/// </summary>
	public class ReportContainer : MContainer, ITMItem<Composition.SectionComponent>                                                           // BuildMemberBase.cs:162
	{                                                                                                                                          // BuildMemberBase.cs:163
	    #region Composition.section:report Item Class                                                                                          // BuildMemberBase.cs:75
	    // Called from BuildMemberSection.cs, Line 224
	    // BuildMemberBase.cs:77
	    /// <summary>
	    /// Item class for Composition.section:report.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:80
	    {                                                                                                                                      // BuildMemberBase.cs:81
	        // Properties                                                                                                                      // BuildMemberBase.cs:82
	        // BuildMemberBase.cs:83
	        /// <summary>
	        /// Value
	        /// </summary>
	        public BreastRadReport Value { get; set; }                                                                                         // BuildMemberBase.cs:86
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
	                                                                                                                                           // BuildMemberSection.cs:61
	        public void Write(BreastRadiologyDocument doc, Composition.SectionComponent section)                                               // BuildMemberSection.cs:62
	        {                                                                                                                                  // BuildMemberSection.cs:63
	            throw new NotImplementedException("xxyyz");                                                                                    // BuildMemberSection.cs:64
	        }                                                                                                                                  // BuildMemberSection.cs:65
	                                                                                                                                           // BuildMemberBase.cs:107
	        // BuildMemberBase.cs:108
	        /// <summary>
	        /// Read item.
	        /// </summary>
	                                                                                                                                           // BuildMemberSection.cs:50
	        public void Read(BreastRadiologyDocument doc, Composition.SectionComponent section)                                                // BuildMemberSection.cs:51
	        {                                                                                                                                  // BuildMemberSection.cs:52
	            throw new NotImplementedException("xxyyz");                                                                                    // BuildMemberSection.cs:53
	        }                                                                                                                                  // BuildMemberSection.cs:54
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
	    public BreastRadReport Get()                                                                                                           // BuildMemberBase.cs:232
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
	    public BreastRadReport Set(BreastRadReport value)                                                                                      // BuildMemberBase.cs:247
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
	    public ReportContainer(Int32 min, Int32 max) : base("Composition.section:report", min, max)                                            // BuildMemberBase.cs:174
	    {                                                                                                                                      // BuildMemberBase.cs:175
	    }                                                                                                                                      // BuildMemberBase.cs:177
	                                                                                                                                           // BuildMemberBase.cs:179
	    // Methods                                                                                                                             // BuildMemberBase.cs:180
	    public CodeableConcept SectionCode()                                                                                                   // FhirConstruct.cs:753
	    {                                                                                                                                      // FhirConstruct.cs:754
	        CodeableConcept retVal = new CodeableConcept();                                                                                    // FhirConstruct.cs:755
	        retVal.Coding = new List<Coding>();                                                                                                // FhirConstruct.cs:761
	        {                                                                                                                                  // FhirConstruct.cs:764
	            var temp4 = new Coding();                                                                                                      // FhirConstruct.cs:765
	            temp4.SystemElement = new FhirUri();                                                                                           // FhirConstruct.cs:768
	            temp4.SystemElement.Value = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes";                 // FhirConstruct.cs:770
	            temp4.CodeElement = new Code();                                                                                                // FhirConstruct.cs:784
	            temp4.CodeElement.Value = "sectionReport";                                                                                     // FhirConstruct.cs:786
	            retVal.Coding.Add(temp4);                                                                                                      // FhirConstruct.cs:813
	        }                                                                                                                                  // FhirConstruct.cs:814
	        return retVal;                                                                                                                     // FhirConstruct.cs:829
	    }                                                                                                                                      // FhirConstruct.cs:830
	                                                                                                                                           // BuildMemberBase.cs:333
	    // BuildMemberBase.cs:334
	    /// <summary>
	    /// Write container items.
	    /// </summary>
	    public IEnumerable<Composition.SectionComponent> Write(BreastRadiologyDocument doc)                                                    // BuildMemberSection.cs:97
	    {                                                                                                                                      // BuildMemberSection.cs:98
	        Composition.SectionComponent section = new Composition.SectionComponent                                                            // BuildMemberSection.cs:99
	        {                                                                                                                                  // BuildMemberSection.cs:100
	            Title = "Breast Radiology Report",                                                                                             // BuildMemberSection.cs:101
	            Code = SectionCode()                                                                                                           // BuildMemberSection.cs:102
	        };                                                                                                                                 // BuildMemberSection.cs:103
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberSection.cs:104
	        {                                                                                                                                  // BuildMemberSection.cs:105
	            section.Entry.Add(new ResourceReference                                                                                        // BuildMemberSection.cs:106
	            {                                                                                                                              // BuildMemberSection.cs:107
	                Reference = item.Value.Id                                                                                                  // BuildMemberSection.cs:108
	            });                                                                                                                            // BuildMemberSection.cs:109
	        }                                                                                                                                  // BuildMemberSection.cs:110
	        yield return section;                                                                                                              // BuildMemberSection.cs:111
	    }                                                                                                                                      // BuildMemberSection.cs:112
	                                                                                                                                           // BuildMemberBase.cs:339
	    // BuildMemberBase.cs:340
	    /// <summary>
	    /// Read container items.
	    /// </summary>
	                                                                                                                                           // BuildMemberSection.cs:72
	    public void Read(BreastRadiologyDocument doc, IEnumerable<Composition.SectionComponent> sections)                                      // BuildMemberSection.cs:73
	    {                                                                                                                                      // BuildMemberSection.cs:74
	        IEnumerable<ResourceBase> resources = base.IsMember(doc,                                                                           // BuildMemberSection.cs:75
	            sections,                                                                                                                      // BuildMemberSection.cs:76
	            SectionCode());                                                                                                                // BuildMemberSection.cs:77
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberSection.cs:78
	        foreach (ResourceBase resource in resources)                                                                                       // BuildMemberSection.cs:79
	        {                                                                                                                                  // BuildMemberSection.cs:80
	            Item item = new Item();                                                                                                        // BuildMemberSection.cs:81
	            item.Value = (BreastRadReport) resource;                                                                                       // BuildMemberSection.cs:82
	            items.Add(item);                                                                                                               // BuildMemberSection.cs:83
	        }                                                                                                                                  // BuildMemberSection.cs:84
	        this.SetAllItems(items);                                                                                                           // BuildMemberSection.cs:85
	    }                                                                                                                                      // BuildMemberSection.cs:86
	}                                                                                                                                          // BuildMemberBase.cs:182
	#endregion                                                                                                                                 // BuildMemberBase.cs:183
	#region Composition.section:impressions Container Class                                                                                    // BuildMemberBase.cs:157
	// Called from BuildMemberSection.cs, Line 224
	// BuildMemberBase.cs:159
	/// <summary>
	/// Container class for Composition.section:impressions.
	/// </summary>
	public class ImpressionsContainer : MContainer, ITMItem<Composition.SectionComponent>                                                      // BuildMemberBase.cs:162
	{                                                                                                                                          // BuildMemberBase.cs:163
	    #region Composition.section:impressions Item Class                                                                                     // BuildMemberBase.cs:75
	    // Called from BuildMemberSection.cs, Line 224
	    // BuildMemberBase.cs:77
	    /// <summary>
	    /// Item class for Composition.section:impressions.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:80
	    {                                                                                                                                      // BuildMemberBase.cs:81
	        // Properties                                                                                                                      // BuildMemberBase.cs:82
	        // BuildMemberBase.cs:83
	        /// <summary>
	        /// Value
	        /// </summary>
	        public ClinicalImpressionBase Value { get; set; }                                                                                  // BuildMemberBase.cs:86
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
	                                                                                                                                           // BuildMemberSection.cs:61
	        public void Write(BreastRadiologyDocument doc, Composition.SectionComponent section)                                               // BuildMemberSection.cs:62
	        {                                                                                                                                  // BuildMemberSection.cs:63
	            throw new NotImplementedException("xxyyz");                                                                                    // BuildMemberSection.cs:64
	        }                                                                                                                                  // BuildMemberSection.cs:65
	                                                                                                                                           // BuildMemberBase.cs:107
	        // BuildMemberBase.cs:108
	        /// <summary>
	        /// Read item.
	        /// </summary>
	                                                                                                                                           // BuildMemberSection.cs:50
	        public void Read(BreastRadiologyDocument doc, Composition.SectionComponent section)                                                // BuildMemberSection.cs:51
	        {                                                                                                                                  // BuildMemberSection.cs:52
	            throw new NotImplementedException("xxyyz");                                                                                    // BuildMemberSection.cs:53
	        }                                                                                                                                  // BuildMemberSection.cs:54
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
	    public IEnumerable<ClinicalImpressionBase> All()                                                                                       // BuildMemberBase.cs:285
	    {                                                                                                                                      // BuildMemberBase.cs:286
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:287
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:288
	    }                                                                                                                                      // BuildMemberBase.cs:289
	                                                                                                                                           // BuildMemberBase.cs:291
	    // BuildMemberBase.cs:292
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public ClinicalImpressionBase GetAt(Int32 i) => this.items[i].Value;                                                                   // BuildMemberBase.cs:295
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
	    public ImpressionsContainer(Int32 min, Int32 max) : base("Composition.section:impressions", min, max)                                  // BuildMemberBase.cs:174
	    {                                                                                                                                      // BuildMemberBase.cs:175
	    }                                                                                                                                      // BuildMemberBase.cs:177
	                                                                                                                                           // BuildMemberBase.cs:179
	    // Methods                                                                                                                             // BuildMemberBase.cs:180
	    public CodeableConcept SectionCode()                                                                                                   // FhirConstruct.cs:753
	    {                                                                                                                                      // FhirConstruct.cs:754
	        CodeableConcept retVal = new CodeableConcept();                                                                                    // FhirConstruct.cs:755
	        retVal.Coding = new List<Coding>();                                                                                                // FhirConstruct.cs:761
	        {                                                                                                                                  // FhirConstruct.cs:764
	            var temp4 = new Coding();                                                                                                      // FhirConstruct.cs:765
	            temp4.SystemElement = new FhirUri();                                                                                           // FhirConstruct.cs:768
	            temp4.SystemElement.Value = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes";                 // FhirConstruct.cs:770
	            temp4.CodeElement = new Code();                                                                                                // FhirConstruct.cs:784
	            temp4.CodeElement.Value = "sectionImpressions";                                                                                // FhirConstruct.cs:786
	            retVal.Coding.Add(temp4);                                                                                                      // FhirConstruct.cs:813
	        }                                                                                                                                  // FhirConstruct.cs:814
	        return retVal;                                                                                                                     // FhirConstruct.cs:829
	    }                                                                                                                                      // FhirConstruct.cs:830
	                                                                                                                                           // BuildMemberBase.cs:313
	    // BuildMemberBase.cs:314
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public ClinicalImpressionBase Append(ClinicalImpressionBase value)                                                                     // BuildMemberBase.cs:317
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
	    public IEnumerable<Composition.SectionComponent> Write(BreastRadiologyDocument doc)                                                    // BuildMemberSection.cs:97
	    {                                                                                                                                      // BuildMemberSection.cs:98
	        Composition.SectionComponent section = new Composition.SectionComponent                                                            // BuildMemberSection.cs:99
	        {                                                                                                                                  // BuildMemberSection.cs:100
	            Title = "Clinical Impressions",                                                                                                // BuildMemberSection.cs:101
	            Code = SectionCode()                                                                                                           // BuildMemberSection.cs:102
	        };                                                                                                                                 // BuildMemberSection.cs:103
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberSection.cs:104
	        {                                                                                                                                  // BuildMemberSection.cs:105
	            section.Entry.Add(new ResourceReference                                                                                        // BuildMemberSection.cs:106
	            {                                                                                                                              // BuildMemberSection.cs:107
	                Reference = item.Value.Id                                                                                                  // BuildMemberSection.cs:108
	            });                                                                                                                            // BuildMemberSection.cs:109
	        }                                                                                                                                  // BuildMemberSection.cs:110
	        yield return section;                                                                                                              // BuildMemberSection.cs:111
	    }                                                                                                                                      // BuildMemberSection.cs:112
	                                                                                                                                           // BuildMemberBase.cs:339
	    // BuildMemberBase.cs:340
	    /// <summary>
	    /// Read container items.
	    /// </summary>
	                                                                                                                                           // BuildMemberSection.cs:72
	    public void Read(BreastRadiologyDocument doc, IEnumerable<Composition.SectionComponent> sections)                                      // BuildMemberSection.cs:73
	    {                                                                                                                                      // BuildMemberSection.cs:74
	        IEnumerable<ResourceBase> resources = base.IsMember(doc,                                                                           // BuildMemberSection.cs:75
	            sections,                                                                                                                      // BuildMemberSection.cs:76
	            SectionCode());                                                                                                                // BuildMemberSection.cs:77
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberSection.cs:78
	        foreach (ResourceBase resource in resources)                                                                                       // BuildMemberSection.cs:79
	        {                                                                                                                                  // BuildMemberSection.cs:80
	            Item item = new Item();                                                                                                        // BuildMemberSection.cs:81
	            item.Value = (ClinicalImpressionBase) resource;                                                                                // BuildMemberSection.cs:82
	            items.Add(item);                                                                                                               // BuildMemberSection.cs:83
	        }                                                                                                                                  // BuildMemberSection.cs:84
	        this.SetAllItems(items);                                                                                                           // BuildMemberSection.cs:85
	    }                                                                                                                                      // BuildMemberSection.cs:86
	}                                                                                                                                          // BuildMemberBase.cs:182
	#endregion                                                                                                                                 // BuildMemberBase.cs:183
	#region Composition.section:findingsRightBreast Container Class                                                                            // BuildMemberBase.cs:157
	// Called from BuildMemberSection.cs, Line 224
	// BuildMemberBase.cs:159
	/// <summary>
	/// Container class for Composition.section:findingsRightBreast.
	/// </summary>
	public class FindingsRightBreastContainer : MContainer, ITMItem<Composition.SectionComponent>                                              // BuildMemberBase.cs:162
	{                                                                                                                                          // BuildMemberBase.cs:163
	    #region Composition.section:findingsRightBreast Item Class                                                                             // BuildMemberBase.cs:75
	    // Called from BuildMemberSection.cs, Line 224
	    // BuildMemberBase.cs:77
	    /// <summary>
	    /// Item class for Composition.section:findingsRightBreast.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:80
	    {                                                                                                                                      // BuildMemberBase.cs:81
	        // Properties                                                                                                                      // BuildMemberBase.cs:82
	        // BuildMemberBase.cs:83
	        /// <summary>
	        /// Value
	        /// </summary>
	        public SectionFindingsRightBreast Value { get; set; }                                                                              // BuildMemberBase.cs:86
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
	                                                                                                                                           // BuildMemberSection.cs:61
	        public void Write(BreastRadiologyDocument doc, Composition.SectionComponent section)                                               // BuildMemberSection.cs:62
	        {                                                                                                                                  // BuildMemberSection.cs:63
	            throw new NotImplementedException("xxyyz");                                                                                    // BuildMemberSection.cs:64
	        }                                                                                                                                  // BuildMemberSection.cs:65
	                                                                                                                                           // BuildMemberBase.cs:107
	        // BuildMemberBase.cs:108
	        /// <summary>
	        /// Read item.
	        /// </summary>
	                                                                                                                                           // BuildMemberSection.cs:50
	        public void Read(BreastRadiologyDocument doc, Composition.SectionComponent section)                                                // BuildMemberSection.cs:51
	        {                                                                                                                                  // BuildMemberSection.cs:52
	            throw new NotImplementedException("xxyyz");                                                                                    // BuildMemberSection.cs:53
	        }                                                                                                                                  // BuildMemberSection.cs:54
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
	    public SectionFindingsRightBreast Get()                                                                                                // BuildMemberBase.cs:232
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
	    public SectionFindingsRightBreast Set(SectionFindingsRightBreast value)                                                                // BuildMemberBase.cs:247
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
	    public FindingsRightBreastContainer(Int32 min, Int32 max) : base("Composition.section:findingsRightBreast", min, max)                  // BuildMemberBase.cs:174
	    {                                                                                                                                      // BuildMemberBase.cs:175
	    }                                                                                                                                      // BuildMemberBase.cs:177
	                                                                                                                                           // BuildMemberBase.cs:179
	    // Methods                                                                                                                             // BuildMemberBase.cs:180
	    public CodeableConcept SectionCode()                                                                                                   // FhirConstruct.cs:753
	    {                                                                                                                                      // FhirConstruct.cs:754
	        CodeableConcept retVal = new CodeableConcept();                                                                                    // FhirConstruct.cs:755
	        retVal.Coding = new List<Coding>();                                                                                                // FhirConstruct.cs:761
	        {                                                                                                                                  // FhirConstruct.cs:764
	            var temp4 = new Coding();                                                                                                      // FhirConstruct.cs:765
	            temp4.SystemElement = new FhirUri();                                                                                           // FhirConstruct.cs:768
	            temp4.SystemElement.Value = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes";                 // FhirConstruct.cs:770
	            temp4.CodeElement = new Code();                                                                                                // FhirConstruct.cs:784
	            temp4.CodeElement.Value = "sectionCodeFindingsRightBreast";                                                                    // FhirConstruct.cs:786
	            retVal.Coding.Add(temp4);                                                                                                      // FhirConstruct.cs:813
	        }                                                                                                                                  // FhirConstruct.cs:814
	        return retVal;                                                                                                                     // FhirConstruct.cs:829
	    }                                                                                                                                      // FhirConstruct.cs:830
	                                                                                                                                           // BuildMemberBase.cs:333
	    // BuildMemberBase.cs:334
	    /// <summary>
	    /// Write container items.
	    /// </summary>
	    public IEnumerable<Composition.SectionComponent> Write(BreastRadiologyDocument doc)                                                    // BuildMemberSection.cs:97
	    {                                                                                                                                      // BuildMemberSection.cs:98
	        Composition.SectionComponent section = new Composition.SectionComponent                                                            // BuildMemberSection.cs:99
	        {                                                                                                                                  // BuildMemberSection.cs:100
	            Title = "Findings Right Breast",                                                                                               // BuildMemberSection.cs:101
	            Code = SectionCode()                                                                                                           // BuildMemberSection.cs:102
	        };                                                                                                                                 // BuildMemberSection.cs:103
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberSection.cs:104
	        {                                                                                                                                  // BuildMemberSection.cs:105
	            section.Entry.Add(new ResourceReference                                                                                        // BuildMemberSection.cs:106
	            {                                                                                                                              // BuildMemberSection.cs:107
	                Reference = item.Value.Id                                                                                                  // BuildMemberSection.cs:108
	            });                                                                                                                            // BuildMemberSection.cs:109
	        }                                                                                                                                  // BuildMemberSection.cs:110
	        yield return section;                                                                                                              // BuildMemberSection.cs:111
	    }                                                                                                                                      // BuildMemberSection.cs:112
	                                                                                                                                           // BuildMemberBase.cs:339
	    // BuildMemberBase.cs:340
	    /// <summary>
	    /// Read container items.
	    /// </summary>
	                                                                                                                                           // BuildMemberSection.cs:72
	    public void Read(BreastRadiologyDocument doc, IEnumerable<Composition.SectionComponent> sections)                                      // BuildMemberSection.cs:73
	    {                                                                                                                                      // BuildMemberSection.cs:74
	        IEnumerable<ResourceBase> resources = base.IsMember(doc,                                                                           // BuildMemberSection.cs:75
	            sections,                                                                                                                      // BuildMemberSection.cs:76
	            SectionCode());                                                                                                                // BuildMemberSection.cs:77
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberSection.cs:78
	        foreach (ResourceBase resource in resources)                                                                                       // BuildMemberSection.cs:79
	        {                                                                                                                                  // BuildMemberSection.cs:80
	            Item item = new Item();                                                                                                        // BuildMemberSection.cs:81
	            item.Value = (SectionFindingsRightBreast) resource;                                                                            // BuildMemberSection.cs:82
	            items.Add(item);                                                                                                               // BuildMemberSection.cs:83
	        }                                                                                                                                  // BuildMemberSection.cs:84
	        this.SetAllItems(items);                                                                                                           // BuildMemberSection.cs:85
	    }                                                                                                                                      // BuildMemberSection.cs:86
	}                                                                                                                                          // BuildMemberBase.cs:182
	#endregion                                                                                                                                 // BuildMemberBase.cs:183
	#region Composition.section:findingsLeftBreast Container Class                                                                             // BuildMemberBase.cs:157
	// Called from BuildMemberSection.cs, Line 224
	// BuildMemberBase.cs:159
	/// <summary>
	/// Container class for Composition.section:findingsLeftBreast.
	/// </summary>
	public class FindingsLeftBreastContainer : MContainer, ITMItem<Composition.SectionComponent>                                               // BuildMemberBase.cs:162
	{                                                                                                                                          // BuildMemberBase.cs:163
	    #region Composition.section:findingsLeftBreast Item Class                                                                              // BuildMemberBase.cs:75
	    // Called from BuildMemberSection.cs, Line 224
	    // BuildMemberBase.cs:77
	    /// <summary>
	    /// Item class for Composition.section:findingsLeftBreast.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:80
	    {                                                                                                                                      // BuildMemberBase.cs:81
	        // Properties                                                                                                                      // BuildMemberBase.cs:82
	        // BuildMemberBase.cs:83
	        /// <summary>
	        /// Value
	        /// </summary>
	        public SectionFindingsLeftBreast Value { get; set; }                                                                               // BuildMemberBase.cs:86
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
	                                                                                                                                           // BuildMemberSection.cs:61
	        public void Write(BreastRadiologyDocument doc, Composition.SectionComponent section)                                               // BuildMemberSection.cs:62
	        {                                                                                                                                  // BuildMemberSection.cs:63
	            throw new NotImplementedException("xxyyz");                                                                                    // BuildMemberSection.cs:64
	        }                                                                                                                                  // BuildMemberSection.cs:65
	                                                                                                                                           // BuildMemberBase.cs:107
	        // BuildMemberBase.cs:108
	        /// <summary>
	        /// Read item.
	        /// </summary>
	                                                                                                                                           // BuildMemberSection.cs:50
	        public void Read(BreastRadiologyDocument doc, Composition.SectionComponent section)                                                // BuildMemberSection.cs:51
	        {                                                                                                                                  // BuildMemberSection.cs:52
	            throw new NotImplementedException("xxyyz");                                                                                    // BuildMemberSection.cs:53
	        }                                                                                                                                  // BuildMemberSection.cs:54
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
	    public SectionFindingsLeftBreast Get()                                                                                                 // BuildMemberBase.cs:232
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
	    public SectionFindingsLeftBreast Set(SectionFindingsLeftBreast value)                                                                  // BuildMemberBase.cs:247
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
	    public FindingsLeftBreastContainer(Int32 min, Int32 max) : base("Composition.section:findingsLeftBreast", min, max)                    // BuildMemberBase.cs:174
	    {                                                                                                                                      // BuildMemberBase.cs:175
	    }                                                                                                                                      // BuildMemberBase.cs:177
	                                                                                                                                           // BuildMemberBase.cs:179
	    // Methods                                                                                                                             // BuildMemberBase.cs:180
	    public CodeableConcept SectionCode()                                                                                                   // FhirConstruct.cs:753
	    {                                                                                                                                      // FhirConstruct.cs:754
	        CodeableConcept retVal = new CodeableConcept();                                                                                    // FhirConstruct.cs:755
	        retVal.Coding = new List<Coding>();                                                                                                // FhirConstruct.cs:761
	        {                                                                                                                                  // FhirConstruct.cs:764
	            var temp4 = new Coding();                                                                                                      // FhirConstruct.cs:765
	            temp4.SystemElement = new FhirUri();                                                                                           // FhirConstruct.cs:768
	            temp4.SystemElement.Value = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes";                 // FhirConstruct.cs:770
	            temp4.CodeElement = new Code();                                                                                                // FhirConstruct.cs:784
	            temp4.CodeElement.Value = "sectionCodeFindingsLeftBreast";                                                                     // FhirConstruct.cs:786
	            retVal.Coding.Add(temp4);                                                                                                      // FhirConstruct.cs:813
	        }                                                                                                                                  // FhirConstruct.cs:814
	        return retVal;                                                                                                                     // FhirConstruct.cs:829
	    }                                                                                                                                      // FhirConstruct.cs:830
	                                                                                                                                           // BuildMemberBase.cs:333
	    // BuildMemberBase.cs:334
	    /// <summary>
	    /// Write container items.
	    /// </summary>
	    public IEnumerable<Composition.SectionComponent> Write(BreastRadiologyDocument doc)                                                    // BuildMemberSection.cs:97
	    {                                                                                                                                      // BuildMemberSection.cs:98
	        Composition.SectionComponent section = new Composition.SectionComponent                                                            // BuildMemberSection.cs:99
	        {                                                                                                                                  // BuildMemberSection.cs:100
	            Title = "Findings Left Breast",                                                                                                // BuildMemberSection.cs:101
	            Code = SectionCode()                                                                                                           // BuildMemberSection.cs:102
	        };                                                                                                                                 // BuildMemberSection.cs:103
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberSection.cs:104
	        {                                                                                                                                  // BuildMemberSection.cs:105
	            section.Entry.Add(new ResourceReference                                                                                        // BuildMemberSection.cs:106
	            {                                                                                                                              // BuildMemberSection.cs:107
	                Reference = item.Value.Id                                                                                                  // BuildMemberSection.cs:108
	            });                                                                                                                            // BuildMemberSection.cs:109
	        }                                                                                                                                  // BuildMemberSection.cs:110
	        yield return section;                                                                                                              // BuildMemberSection.cs:111
	    }                                                                                                                                      // BuildMemberSection.cs:112
	                                                                                                                                           // BuildMemberBase.cs:339
	    // BuildMemberBase.cs:340
	    /// <summary>
	    /// Read container items.
	    /// </summary>
	                                                                                                                                           // BuildMemberSection.cs:72
	    public void Read(BreastRadiologyDocument doc, IEnumerable<Composition.SectionComponent> sections)                                      // BuildMemberSection.cs:73
	    {                                                                                                                                      // BuildMemberSection.cs:74
	        IEnumerable<ResourceBase> resources = base.IsMember(doc,                                                                           // BuildMemberSection.cs:75
	            sections,                                                                                                                      // BuildMemberSection.cs:76
	            SectionCode());                                                                                                                // BuildMemberSection.cs:77
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberSection.cs:78
	        foreach (ResourceBase resource in resources)                                                                                       // BuildMemberSection.cs:79
	        {                                                                                                                                  // BuildMemberSection.cs:80
	            Item item = new Item();                                                                                                        // BuildMemberSection.cs:81
	            item.Value = (SectionFindingsLeftBreast) resource;                                                                             // BuildMemberSection.cs:82
	            items.Add(item);                                                                                                               // BuildMemberSection.cs:83
	        }                                                                                                                                  // BuildMemberSection.cs:84
	        this.SetAllItems(items);                                                                                                           // BuildMemberSection.cs:85
	    }                                                                                                                                      // BuildMemberSection.cs:86
	}                                                                                                                                          // BuildMemberBase.cs:182
	#endregion                                                                                                                                 // BuildMemberBase.cs:183
	#region Composition.section:relatedResources Container Class                                                                               // BuildMemberBase.cs:157
	// Called from BuildMemberSection.cs, Line 224
	// BuildMemberBase.cs:159
	/// <summary>
	/// Container class for Composition.section:relatedResources.
	/// </summary>
	public class RelatedResourcesContainer : MContainer, ITMItem<Composition.SectionComponent>                                                 // BuildMemberBase.cs:162
	{                                                                                                                                          // BuildMemberBase.cs:163
	    #region Composition.section:relatedResources Item Class                                                                                // BuildMemberBase.cs:75
	    // Called from BuildMemberSection.cs, Line 224
	    // BuildMemberBase.cs:77
	    /// <summary>
	    /// Item class for Composition.section:relatedResources.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:80
	    {                                                                                                                                      // BuildMemberBase.cs:81
	        // Properties                                                                                                                      // BuildMemberBase.cs:82
	        // BuildMemberBase.cs:83
	        /// <summary>
	        /// Value
	        /// </summary>
	        public ResourceBase Value { get; set; }                                                                                            // BuildMemberBase.cs:86
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
	                                                                                                                                           // BuildMemberSection.cs:61
	        public void Write(BreastRadiologyDocument doc, Composition.SectionComponent section)                                               // BuildMemberSection.cs:62
	        {                                                                                                                                  // BuildMemberSection.cs:63
	            throw new NotImplementedException("xxyyz");                                                                                    // BuildMemberSection.cs:64
	        }                                                                                                                                  // BuildMemberSection.cs:65
	                                                                                                                                           // BuildMemberBase.cs:107
	        // BuildMemberBase.cs:108
	        /// <summary>
	        /// Read item.
	        /// </summary>
	                                                                                                                                           // BuildMemberSection.cs:50
	        public void Read(BreastRadiologyDocument doc, Composition.SectionComponent section)                                                // BuildMemberSection.cs:51
	        {                                                                                                                                  // BuildMemberSection.cs:52
	            throw new NotImplementedException("xxyyz");                                                                                    // BuildMemberSection.cs:53
	        }                                                                                                                                  // BuildMemberSection.cs:54
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
	    public IEnumerable<ResourceBase> All()                                                                                                 // BuildMemberBase.cs:285
	    {                                                                                                                                      // BuildMemberBase.cs:286
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:287
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:288
	    }                                                                                                                                      // BuildMemberBase.cs:289
	                                                                                                                                           // BuildMemberBase.cs:291
	    // BuildMemberBase.cs:292
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public ResourceBase GetAt(Int32 i) => this.items[i].Value;                                                                             // BuildMemberBase.cs:295
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
	    public RelatedResourcesContainer(Int32 min, Int32 max) : base("Composition.section:relatedResources", min, max)                        // BuildMemberBase.cs:174
	    {                                                                                                                                      // BuildMemberBase.cs:175
	    }                                                                                                                                      // BuildMemberBase.cs:177
	                                                                                                                                           // BuildMemberBase.cs:179
	    // Methods                                                                                                                             // BuildMemberBase.cs:180
	    public CodeableConcept SectionCode()                                                                                                   // FhirConstruct.cs:753
	    {                                                                                                                                      // FhirConstruct.cs:754
	        CodeableConcept retVal = new CodeableConcept();                                                                                    // FhirConstruct.cs:755
	        retVal.Coding = new List<Coding>();                                                                                                // FhirConstruct.cs:761
	        {                                                                                                                                  // FhirConstruct.cs:764
	            var temp4 = new Coding();                                                                                                      // FhirConstruct.cs:765
	            temp4.SystemElement = new FhirUri();                                                                                           // FhirConstruct.cs:768
	            temp4.SystemElement.Value = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes";                 // FhirConstruct.cs:770
	            temp4.CodeElement = new Code();                                                                                                // FhirConstruct.cs:784
	            temp4.CodeElement.Value = "sectionRelatedResources";                                                                           // FhirConstruct.cs:786
	            retVal.Coding.Add(temp4);                                                                                                      // FhirConstruct.cs:813
	        }                                                                                                                                  // FhirConstruct.cs:814
	        return retVal;                                                                                                                     // FhirConstruct.cs:829
	    }                                                                                                                                      // FhirConstruct.cs:830
	                                                                                                                                           // BuildMemberBase.cs:313
	    // BuildMemberBase.cs:314
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public ResourceBase Append(ResourceBase value)                                                                                         // BuildMemberBase.cs:317
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
	    public IEnumerable<Composition.SectionComponent> Write(BreastRadiologyDocument doc)                                                    // BuildMemberSection.cs:97
	    {                                                                                                                                      // BuildMemberSection.cs:98
	        Composition.SectionComponent section = new Composition.SectionComponent                                                            // BuildMemberSection.cs:99
	        {                                                                                                                                  // BuildMemberSection.cs:100
	            Title = "Related Resources",                                                                                                   // BuildMemberSection.cs:101
	            Code = SectionCode()                                                                                                           // BuildMemberSection.cs:102
	        };                                                                                                                                 // BuildMemberSection.cs:103
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberSection.cs:104
	        {                                                                                                                                  // BuildMemberSection.cs:105
	            section.Entry.Add(new ResourceReference                                                                                        // BuildMemberSection.cs:106
	            {                                                                                                                              // BuildMemberSection.cs:107
	                Reference = item.Value.Id                                                                                                  // BuildMemberSection.cs:108
	            });                                                                                                                            // BuildMemberSection.cs:109
	        }                                                                                                                                  // BuildMemberSection.cs:110
	        yield return section;                                                                                                              // BuildMemberSection.cs:111
	    }                                                                                                                                      // BuildMemberSection.cs:112
	                                                                                                                                           // BuildMemberBase.cs:339
	    // BuildMemberBase.cs:340
	    /// <summary>
	    /// Read container items.
	    /// </summary>
	                                                                                                                                           // BuildMemberSection.cs:72
	    public void Read(BreastRadiologyDocument doc, IEnumerable<Composition.SectionComponent> sections)                                      // BuildMemberSection.cs:73
	    {                                                                                                                                      // BuildMemberSection.cs:74
	        IEnumerable<ResourceBase> resources = base.IsMember(doc,                                                                           // BuildMemberSection.cs:75
	            sections,                                                                                                                      // BuildMemberSection.cs:76
	            SectionCode());                                                                                                                // BuildMemberSection.cs:77
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberSection.cs:78
	        foreach (ResourceBase resource in resources)                                                                                       // BuildMemberSection.cs:79
	        {                                                                                                                                  // BuildMemberSection.cs:80
	            Item item = new Item();                                                                                                        // BuildMemberSection.cs:81
	            item.Value = (ResourceBase) resource;                                                                                          // BuildMemberSection.cs:82
	            items.Add(item);                                                                                                               // BuildMemberSection.cs:83
	        }                                                                                                                                  // BuildMemberSection.cs:84
	        this.SetAllItems(items);                                                                                                           // BuildMemberSection.cs:85
	    }                                                                                                                                      // BuildMemberSection.cs:86
	}                                                                                                                                          // BuildMemberBase.cs:182
	#endregion                                                                                                                                 // BuildMemberBase.cs:183
	#region Composition.section:recommendations Container Class                                                                                // BuildMemberBase.cs:157
	// Called from BuildMemberSection.cs, Line 224
	// BuildMemberBase.cs:159
	/// <summary>
	/// Container class for Composition.section:recommendations.
	/// </summary>
	public class RecommendationsContainer : MContainer, ITMItem<Composition.SectionComponent>                                                  // BuildMemberBase.cs:162
	{                                                                                                                                          // BuildMemberBase.cs:163
	    #region Composition.section:recommendations Item Class                                                                                 // BuildMemberBase.cs:75
	    // Called from BuildMemberSection.cs, Line 224
	    // BuildMemberBase.cs:77
	    /// <summary>
	    /// Item class for Composition.section:recommendations.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:80
	    {                                                                                                                                      // BuildMemberBase.cs:81
	        // Properties                                                                                                                      // BuildMemberBase.cs:82
	        // BuildMemberBase.cs:83
	        /// <summary>
	        /// Value
	        /// </summary>
	        public ResourceBase Value { get; set; }                                                                                            // BuildMemberBase.cs:86
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
	                                                                                                                                           // BuildMemberSection.cs:61
	        public void Write(BreastRadiologyDocument doc, Composition.SectionComponent section)                                               // BuildMemberSection.cs:62
	        {                                                                                                                                  // BuildMemberSection.cs:63
	            throw new NotImplementedException("xxyyz");                                                                                    // BuildMemberSection.cs:64
	        }                                                                                                                                  // BuildMemberSection.cs:65
	                                                                                                                                           // BuildMemberBase.cs:107
	        // BuildMemberBase.cs:108
	        /// <summary>
	        /// Read item.
	        /// </summary>
	                                                                                                                                           // BuildMemberSection.cs:50
	        public void Read(BreastRadiologyDocument doc, Composition.SectionComponent section)                                                // BuildMemberSection.cs:51
	        {                                                                                                                                  // BuildMemberSection.cs:52
	            throw new NotImplementedException("xxyyz");                                                                                    // BuildMemberSection.cs:53
	        }                                                                                                                                  // BuildMemberSection.cs:54
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
	    public IEnumerable<ResourceBase> All()                                                                                                 // BuildMemberBase.cs:285
	    {                                                                                                                                      // BuildMemberBase.cs:286
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:287
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:288
	    }                                                                                                                                      // BuildMemberBase.cs:289
	                                                                                                                                           // BuildMemberBase.cs:291
	    // BuildMemberBase.cs:292
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public ResourceBase GetAt(Int32 i) => this.items[i].Value;                                                                             // BuildMemberBase.cs:295
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
	    public RecommendationsContainer(Int32 min, Int32 max) : base("Composition.section:recommendations", min, max)                          // BuildMemberBase.cs:174
	    {                                                                                                                                      // BuildMemberBase.cs:175
	    }                                                                                                                                      // BuildMemberBase.cs:177
	                                                                                                                                           // BuildMemberBase.cs:179
	    // Methods                                                                                                                             // BuildMemberBase.cs:180
	    public CodeableConcept SectionCode()                                                                                                   // FhirConstruct.cs:753
	    {                                                                                                                                      // FhirConstruct.cs:754
	        CodeableConcept retVal = new CodeableConcept();                                                                                    // FhirConstruct.cs:755
	        retVal.Coding = new List<Coding>();                                                                                                // FhirConstruct.cs:761
	        {                                                                                                                                  // FhirConstruct.cs:764
	            var temp4 = new Coding();                                                                                                      // FhirConstruct.cs:765
	            temp4.SystemElement = new FhirUri();                                                                                           // FhirConstruct.cs:768
	            temp4.SystemElement.Value = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes";                 // FhirConstruct.cs:770
	            temp4.CodeElement = new Code();                                                                                                // FhirConstruct.cs:784
	            temp4.CodeElement.Value = "sectionCodeRecommendations";                                                                        // FhirConstruct.cs:786
	            retVal.Coding.Add(temp4);                                                                                                      // FhirConstruct.cs:813
	        }                                                                                                                                  // FhirConstruct.cs:814
	        return retVal;                                                                                                                     // FhirConstruct.cs:829
	    }                                                                                                                                      // FhirConstruct.cs:830
	                                                                                                                                           // BuildMemberBase.cs:313
	    // BuildMemberBase.cs:314
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public MedicationRequestBase Append(MedicationRequestBase value)                                                                       // BuildMemberBase.cs:317
	    {                                                                                                                                      // BuildMemberBase.cs:318
	        Item item = new Item();                                                                                                            // BuildMemberBase.cs:319
	        item.Value = value;                                                                                                                // BuildMemberBase.cs:320
	        this.items.Add(item);                                                                                                              // BuildMemberBase.cs:321
	        return value;                                                                                                                      // BuildMemberBase.cs:322
	    }                                                                                                                                      // BuildMemberBase.cs:323
	                                                                                                                                           // BuildMemberBase.cs:313
	    // BuildMemberBase.cs:314
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public ServiceRequestBase Append(ServiceRequestBase value)                                                                             // BuildMemberBase.cs:317
	    {                                                                                                                                      // BuildMemberBase.cs:318
	        Item item = new Item();                                                                                                            // BuildMemberBase.cs:319
	        item.Value = value;                                                                                                                // BuildMemberBase.cs:320
	        this.items.Add(item);                                                                                                              // BuildMemberBase.cs:321
	        return value;                                                                                                                      // BuildMemberBase.cs:322
	    }                                                                                                                                      // BuildMemberBase.cs:323
	                                                                                                                                           // BuildMemberBase.cs:313
	    // BuildMemberBase.cs:314
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public ServiceRecommendation Append(ServiceRecommendation value)                                                                       // BuildMemberBase.cs:317
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
	    public IEnumerable<Composition.SectionComponent> Write(BreastRadiologyDocument doc)                                                    // BuildMemberSection.cs:97
	    {                                                                                                                                      // BuildMemberSection.cs:98
	        Composition.SectionComponent section = new Composition.SectionComponent                                                            // BuildMemberSection.cs:99
	        {                                                                                                                                  // BuildMemberSection.cs:100
	            Title = "Recommendations",                                                                                                     // BuildMemberSection.cs:101
	            Code = SectionCode()                                                                                                           // BuildMemberSection.cs:102
	        };                                                                                                                                 // BuildMemberSection.cs:103
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberSection.cs:104
	        {                                                                                                                                  // BuildMemberSection.cs:105
	            section.Entry.Add(new ResourceReference                                                                                        // BuildMemberSection.cs:106
	            {                                                                                                                              // BuildMemberSection.cs:107
	                Reference = item.Value.Id                                                                                                  // BuildMemberSection.cs:108
	            });                                                                                                                            // BuildMemberSection.cs:109
	        }                                                                                                                                  // BuildMemberSection.cs:110
	        yield return section;                                                                                                              // BuildMemberSection.cs:111
	    }                                                                                                                                      // BuildMemberSection.cs:112
	                                                                                                                                           // BuildMemberBase.cs:339
	    // BuildMemberBase.cs:340
	    /// <summary>
	    /// Read container items.
	    /// </summary>
	                                                                                                                                           // BuildMemberSection.cs:72
	    public void Read(BreastRadiologyDocument doc, IEnumerable<Composition.SectionComponent> sections)                                      // BuildMemberSection.cs:73
	    {                                                                                                                                      // BuildMemberSection.cs:74
	        IEnumerable<ResourceBase> resources = base.IsMember(doc,                                                                           // BuildMemberSection.cs:75
	            sections,                                                                                                                      // BuildMemberSection.cs:76
	            SectionCode());                                                                                                                // BuildMemberSection.cs:77
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberSection.cs:78
	        foreach (ResourceBase resource in resources)                                                                                       // BuildMemberSection.cs:79
	        {                                                                                                                                  // BuildMemberSection.cs:80
	            Item item = new Item();                                                                                                        // BuildMemberSection.cs:81
	            item.Value = (ResourceBase) resource;                                                                                          // BuildMemberSection.cs:82
	            items.Add(item);                                                                                                               // BuildMemberSection.cs:83
	        }                                                                                                                                  // BuildMemberSection.cs:84
	        this.SetAllItems(items);                                                                                                           // BuildMemberSection.cs:85
	    }                                                                                                                                      // BuildMemberSection.cs:86
	}                                                                                                                                          // BuildMemberBase.cs:182
	#endregion                                                                                                                                 // BuildMemberBase.cs:183
	//- LocalClassDefs
}
