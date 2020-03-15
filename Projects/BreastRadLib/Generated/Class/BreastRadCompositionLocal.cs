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
	/// <summary>
	/// Container class for Composition.section:report.
	/// </summary>
	public class ReportContainer : MContainer, ITMItem<Composition.SectionComponent>                                                           // BuildMemberBase.cs:135
	{                                                                                                                                          // BuildMemberBase.cs:136
	    /// <summary>
	    /// Item class for Composition.section:report.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:73
	    {                                                                                                                                      // BuildMemberBase.cs:74
	        // Properties                                                                                                                      // BuildMemberBase.cs:75
	        /// <summary>
	        /// Value
	        /// </summary>
	        public BreastRadReport Value { get; set; }                                                                                         // BuildMemberBase.cs:79
	                                                                                                                                           // BuildMemberBase.cs:81
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(BreastRadReport value)                                                                                                 // BuildMemberBase.cs:85
	        {                                                                                                                                  // BuildMemberBase.cs:86
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:87
	        }                                                                                                                                  // BuildMemberBase.cs:89
	                                                                                                                                           // BuildMemberBase.cs:91
	        // Methods                                                                                                                         // BuildMemberBase.cs:92
	    }                                                                                                                                      // BuildMemberBase.cs:94
	                                                                                                                                           // BuildMemberBase.cs:138
	    // Properties                                                                                                                          // BuildMemberBase.cs:139
	                                                                                                                                           // BuildMemberBase.cs:160
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems()                                                                                                        // BuildMemberBase.cs:164
	    {                                                                                                                                      // BuildMemberBase.cs:165
	        if (this.item != null) yield return this.item;                                                                                     // BuildMemberBase.cs:166
	    }                                                                                                                                      // BuildMemberBase.cs:167
	                                                                                                                                           // BuildMemberBase.cs:169
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items)                                                                                              // BuildMemberBase.cs:173
	    {                                                                                                                                      // BuildMemberBase.cs:174
	        switch (items.Count())                                                                                                             // BuildMemberBase.cs:175
	        {                                                                                                                                  // BuildMemberBase.cs:176
	            case 0: break;                                                                                                                 // BuildMemberBase.cs:177
	            case 1: this.item = items.First(); break;                                                                                      // BuildMemberBase.cs:178
	            default: throw new Exception("Found multiple elements while reading single item");                                             // BuildMemberBase.cs:179
	        }                                                                                                                                  // BuildMemberBase.cs:180
	    }                                                                                                                                      // BuildMemberBase.cs:181
	                                                                                                                                           // BuildMemberBase.cs:183
	    /// <summary>
	    /// Item
	    /// </summary>
	    Item item;                                                                                                                             // BuildMemberBase.cs:187
	                                                                                                                                           // BuildMemberBase.cs:189
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => this.item == null ? 0 : 1;                                                                              // BuildMemberBase.cs:193
	                                                                                                                                           // BuildMemberBase.cs:195
	    /// <summary>
	    /// Get Item's Value
	    /// </summary>
	    public BreastRadReport Get()                                                                                                           // BuildMemberBase.cs:199
	    {                                                                                                                                      // BuildMemberBase.cs:200
	        if (item == null)                                                                                                                  // BuildMemberBase.cs:201
	            return null;                                                                                                                   // BuildMemberBase.cs:202
	        return item.Value;                                                                                                                 // BuildMemberBase.cs:203
	    }                                                                                                                                      // BuildMemberBase.cs:204
	                                                                                                                                           // BuildMemberBase.cs:210
	    /// <summary>
	    /// Set Item's Value
	    /// </summary>
	    public BreastRadReport Set(BreastRadReport value)                                                                                      // BuildMemberBase.cs:214
	    {                                                                                                                                      // BuildMemberBase.cs:215
	        this.item = new Item(value);                                                                                                       // BuildMemberBase.cs:216
	        return value;                                                                                                                      // BuildMemberBase.cs:217
	    }                                                                                                                                      // BuildMemberBase.cs:218
	                                                                                                                                           // BuildMemberBase.cs:141
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public ReportContainer(Int32 min, Int32 max) : base("Composition.section:report", min, max)                                            // BuildMemberBase.cs:145
	    {                                                                                                                                      // BuildMemberBase.cs:146
	    }                                                                                                                                      // BuildMemberBase.cs:148
	                                                                                                                                           // BuildMemberBase.cs:149
	    // Methods                                                                                                                             // BuildMemberBase.cs:150
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
	                                                                                                                                           // BuildMemberBase.cs:291
	    /// <summary>
	    /// Write single item as a fhir element.
	    /// </summary>
	    public IEnumerable<Composition.SectionComponent> Write(BreastRadiologyDocument doc)                                                    // BuildMemberSection.cs:74
	    {                                                                                                                                      // BuildMemberSection.cs:75
	        Composition.SectionComponent section = new Composition.SectionComponent                                                            // BuildMemberSection.cs:76
	        {                                                                                                                                  // BuildMemberSection.cs:77
	            Title = "Breast Radiology Report",                                                                                             // BuildMemberSection.cs:78
	            Code = SectionCode()                                                                                                           // BuildMemberSection.cs:79
	        };                                                                                                                                 // BuildMemberSection.cs:80
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberSection.cs:81
	        {                                                                                                                                  // BuildMemberSection.cs:82
	            section.Entry.Add(new ResourceReference                                                                                        // BuildMemberSection.cs:83
	            {                                                                                                                              // BuildMemberSection.cs:84
	                Reference = item.Value.Id                                                                                                  // BuildMemberSection.cs:85
	            });                                                                                                                            // BuildMemberSection.cs:86
	        }                                                                                                                                  // BuildMemberSection.cs:87
	        yield return section;                                                                                                              // BuildMemberSection.cs:88
	    }                                                                                                                                      // BuildMemberSection.cs:89
	                                                                                                                                           // BuildMemberBase.cs:297
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	                                                                                                                                           // BuildMemberSection.cs:50
	    public void Read(BreastRadiologyDocument doc, IEnumerable<Composition.SectionComponent> sections)                                      // BuildMemberSection.cs:51
	    {                                                                                                                                      // BuildMemberSection.cs:52
	        IEnumerable<ResourceBase> resources = base.IsMember(doc,                                                                           // BuildMemberSection.cs:53
	            sections,                                                                                                                      // BuildMemberSection.cs:54
	            SectionCode());                                                                                                                // BuildMemberSection.cs:55
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberSection.cs:56
	        foreach (ResourceBase resource in resources)                                                                                       // BuildMemberSection.cs:57
	        {                                                                                                                                  // BuildMemberSection.cs:58
	            Item item = new Item((BreastRadReport) resource);                                                                              // BuildMemberSection.cs:59
	            items.Add(item);                                                                                                               // BuildMemberSection.cs:60
	        }                                                                                                                                  // BuildMemberSection.cs:61
	        this.SetAllItems(items);                                                                                                           // BuildMemberSection.cs:62
	    }                                                                                                                                      // BuildMemberSection.cs:63
	}                                                                                                                                          // BuildMemberBase.cs:152
	/// <summary>
	/// Container class for Composition.section:impressions.
	/// </summary>
	public class ImpressionsContainer : MContainer, ITMItem<Composition.SectionComponent>                                                      // BuildMemberBase.cs:135
	{                                                                                                                                          // BuildMemberBase.cs:136
	    /// <summary>
	    /// Item class for Composition.section:impressions.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:73
	    {                                                                                                                                      // BuildMemberBase.cs:74
	        // Properties                                                                                                                      // BuildMemberBase.cs:75
	        /// <summary>
	        /// Value
	        /// </summary>
	        public ClinicalImpressionBase Value { get; set; }                                                                                  // BuildMemberBase.cs:79
	                                                                                                                                           // BuildMemberBase.cs:81
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(ClinicalImpressionBase value)                                                                                          // BuildMemberBase.cs:85
	        {                                                                                                                                  // BuildMemberBase.cs:86
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:87
	        }                                                                                                                                  // BuildMemberBase.cs:89
	                                                                                                                                           // BuildMemberBase.cs:91
	        // Methods                                                                                                                         // BuildMemberBase.cs:92
	    }                                                                                                                                      // BuildMemberBase.cs:94
	                                                                                                                                           // BuildMemberBase.cs:138
	    // Properties                                                                                                                          // BuildMemberBase.cs:139
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:225
	                                                                                                                                           // BuildMemberBase.cs:227
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:231
	                                                                                                                                           // BuildMemberBase.cs:233
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:237
	                                                                                                                                           // BuildMemberBase.cs:239
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:243
	                                                                                                                                           // BuildMemberBase.cs:245
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<ClinicalImpressionBase> All()                                                                                       // BuildMemberBase.cs:249
	    {                                                                                                                                      // BuildMemberBase.cs:250
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:251
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:252
	    }                                                                                                                                      // BuildMemberBase.cs:253
	                                                                                                                                           // BuildMemberBase.cs:255
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public ClinicalImpressionBase GetAt(Int32 i) => this.items[i].Value;                                                                   // BuildMemberBase.cs:259
	                                                                                                                                           // BuildMemberBase.cs:261
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:265
	                                                                                                                                           // BuildMemberBase.cs:267
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:271
	                                                                                                                                           // BuildMemberBase.cs:141
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public ImpressionsContainer(Int32 min, Int32 max) : base("Composition.section:impressions", min, max)                                  // BuildMemberBase.cs:145
	    {                                                                                                                                      // BuildMemberBase.cs:146
	    }                                                                                                                                      // BuildMemberBase.cs:148
	                                                                                                                                           // BuildMemberBase.cs:149
	    // Methods                                                                                                                             // BuildMemberBase.cs:150
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
	                                                                                                                                           // BuildMemberBase.cs:277
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public ClinicalImpressionBase Append(ClinicalImpressionBase value)                                                                     // BuildMemberBase.cs:281
	    {                                                                                                                                      // BuildMemberBase.cs:282
	        this.items.Add(new Item(value));                                                                                                   // BuildMemberBase.cs:283
	        return value;                                                                                                                      // BuildMemberBase.cs:284
	    }                                                                                                                                      // BuildMemberBase.cs:285
	                                                                                                                                           // BuildMemberBase.cs:291
	    /// <summary>
	    /// Write single item as a fhir element.
	    /// </summary>
	    public IEnumerable<Composition.SectionComponent> Write(BreastRadiologyDocument doc)                                                    // BuildMemberSection.cs:74
	    {                                                                                                                                      // BuildMemberSection.cs:75
	        Composition.SectionComponent section = new Composition.SectionComponent                                                            // BuildMemberSection.cs:76
	        {                                                                                                                                  // BuildMemberSection.cs:77
	            Title = "Clinical Impressions",                                                                                                // BuildMemberSection.cs:78
	            Code = SectionCode()                                                                                                           // BuildMemberSection.cs:79
	        };                                                                                                                                 // BuildMemberSection.cs:80
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberSection.cs:81
	        {                                                                                                                                  // BuildMemberSection.cs:82
	            section.Entry.Add(new ResourceReference                                                                                        // BuildMemberSection.cs:83
	            {                                                                                                                              // BuildMemberSection.cs:84
	                Reference = item.Value.Id                                                                                                  // BuildMemberSection.cs:85
	            });                                                                                                                            // BuildMemberSection.cs:86
	        }                                                                                                                                  // BuildMemberSection.cs:87
	        yield return section;                                                                                                              // BuildMemberSection.cs:88
	    }                                                                                                                                      // BuildMemberSection.cs:89
	                                                                                                                                           // BuildMemberBase.cs:297
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	                                                                                                                                           // BuildMemberSection.cs:50
	    public void Read(BreastRadiologyDocument doc, IEnumerable<Composition.SectionComponent> sections)                                      // BuildMemberSection.cs:51
	    {                                                                                                                                      // BuildMemberSection.cs:52
	        IEnumerable<ResourceBase> resources = base.IsMember(doc,                                                                           // BuildMemberSection.cs:53
	            sections,                                                                                                                      // BuildMemberSection.cs:54
	            SectionCode());                                                                                                                // BuildMemberSection.cs:55
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberSection.cs:56
	        foreach (ResourceBase resource in resources)                                                                                       // BuildMemberSection.cs:57
	        {                                                                                                                                  // BuildMemberSection.cs:58
	            Item item = new Item((ClinicalImpressionBase) resource);                                                                       // BuildMemberSection.cs:59
	            items.Add(item);                                                                                                               // BuildMemberSection.cs:60
	        }                                                                                                                                  // BuildMemberSection.cs:61
	        this.SetAllItems(items);                                                                                                           // BuildMemberSection.cs:62
	    }                                                                                                                                      // BuildMemberSection.cs:63
	}                                                                                                                                          // BuildMemberBase.cs:152
	/// <summary>
	/// Container class for Composition.section:findingsRightBreast.
	/// </summary>
	public class FindingsRightBreastContainer : MContainer, ITMItem<Composition.SectionComponent>                                              // BuildMemberBase.cs:135
	{                                                                                                                                          // BuildMemberBase.cs:136
	    /// <summary>
	    /// Item class for Composition.section:findingsRightBreast.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:73
	    {                                                                                                                                      // BuildMemberBase.cs:74
	        // Properties                                                                                                                      // BuildMemberBase.cs:75
	        /// <summary>
	        /// Value
	        /// </summary>
	        public SectionFindingsRightBreast Value { get; set; }                                                                              // BuildMemberBase.cs:79
	                                                                                                                                           // BuildMemberBase.cs:81
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(SectionFindingsRightBreast value)                                                                                      // BuildMemberBase.cs:85
	        {                                                                                                                                  // BuildMemberBase.cs:86
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:87
	        }                                                                                                                                  // BuildMemberBase.cs:89
	                                                                                                                                           // BuildMemberBase.cs:91
	        // Methods                                                                                                                         // BuildMemberBase.cs:92
	    }                                                                                                                                      // BuildMemberBase.cs:94
	                                                                                                                                           // BuildMemberBase.cs:138
	    // Properties                                                                                                                          // BuildMemberBase.cs:139
	                                                                                                                                           // BuildMemberBase.cs:160
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems()                                                                                                        // BuildMemberBase.cs:164
	    {                                                                                                                                      // BuildMemberBase.cs:165
	        if (this.item != null) yield return this.item;                                                                                     // BuildMemberBase.cs:166
	    }                                                                                                                                      // BuildMemberBase.cs:167
	                                                                                                                                           // BuildMemberBase.cs:169
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items)                                                                                              // BuildMemberBase.cs:173
	    {                                                                                                                                      // BuildMemberBase.cs:174
	        switch (items.Count())                                                                                                             // BuildMemberBase.cs:175
	        {                                                                                                                                  // BuildMemberBase.cs:176
	            case 0: break;                                                                                                                 // BuildMemberBase.cs:177
	            case 1: this.item = items.First(); break;                                                                                      // BuildMemberBase.cs:178
	            default: throw new Exception("Found multiple elements while reading single item");                                             // BuildMemberBase.cs:179
	        }                                                                                                                                  // BuildMemberBase.cs:180
	    }                                                                                                                                      // BuildMemberBase.cs:181
	                                                                                                                                           // BuildMemberBase.cs:183
	    /// <summary>
	    /// Item
	    /// </summary>
	    Item item;                                                                                                                             // BuildMemberBase.cs:187
	                                                                                                                                           // BuildMemberBase.cs:189
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => this.item == null ? 0 : 1;                                                                              // BuildMemberBase.cs:193
	                                                                                                                                           // BuildMemberBase.cs:195
	    /// <summary>
	    /// Get Item's Value
	    /// </summary>
	    public SectionFindingsRightBreast Get()                                                                                                // BuildMemberBase.cs:199
	    {                                                                                                                                      // BuildMemberBase.cs:200
	        if (item == null)                                                                                                                  // BuildMemberBase.cs:201
	            return null;                                                                                                                   // BuildMemberBase.cs:202
	        return item.Value;                                                                                                                 // BuildMemberBase.cs:203
	    }                                                                                                                                      // BuildMemberBase.cs:204
	                                                                                                                                           // BuildMemberBase.cs:210
	    /// <summary>
	    /// Set Item's Value
	    /// </summary>
	    public SectionFindingsRightBreast Set(SectionFindingsRightBreast value)                                                                // BuildMemberBase.cs:214
	    {                                                                                                                                      // BuildMemberBase.cs:215
	        this.item = new Item(value);                                                                                                       // BuildMemberBase.cs:216
	        return value;                                                                                                                      // BuildMemberBase.cs:217
	    }                                                                                                                                      // BuildMemberBase.cs:218
	                                                                                                                                           // BuildMemberBase.cs:141
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public FindingsRightBreastContainer(Int32 min, Int32 max) : base("Composition.section:findingsRightBreast", min, max)                  // BuildMemberBase.cs:145
	    {                                                                                                                                      // BuildMemberBase.cs:146
	    }                                                                                                                                      // BuildMemberBase.cs:148
	                                                                                                                                           // BuildMemberBase.cs:149
	    // Methods                                                                                                                             // BuildMemberBase.cs:150
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
	                                                                                                                                           // BuildMemberBase.cs:291
	    /// <summary>
	    /// Write single item as a fhir element.
	    /// </summary>
	    public IEnumerable<Composition.SectionComponent> Write(BreastRadiologyDocument doc)                                                    // BuildMemberSection.cs:74
	    {                                                                                                                                      // BuildMemberSection.cs:75
	        Composition.SectionComponent section = new Composition.SectionComponent                                                            // BuildMemberSection.cs:76
	        {                                                                                                                                  // BuildMemberSection.cs:77
	            Title = "Findings Right Breast",                                                                                               // BuildMemberSection.cs:78
	            Code = SectionCode()                                                                                                           // BuildMemberSection.cs:79
	        };                                                                                                                                 // BuildMemberSection.cs:80
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberSection.cs:81
	        {                                                                                                                                  // BuildMemberSection.cs:82
	            section.Entry.Add(new ResourceReference                                                                                        // BuildMemberSection.cs:83
	            {                                                                                                                              // BuildMemberSection.cs:84
	                Reference = item.Value.Id                                                                                                  // BuildMemberSection.cs:85
	            });                                                                                                                            // BuildMemberSection.cs:86
	        }                                                                                                                                  // BuildMemberSection.cs:87
	        yield return section;                                                                                                              // BuildMemberSection.cs:88
	    }                                                                                                                                      // BuildMemberSection.cs:89
	                                                                                                                                           // BuildMemberBase.cs:297
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	                                                                                                                                           // BuildMemberSection.cs:50
	    public void Read(BreastRadiologyDocument doc, IEnumerable<Composition.SectionComponent> sections)                                      // BuildMemberSection.cs:51
	    {                                                                                                                                      // BuildMemberSection.cs:52
	        IEnumerable<ResourceBase> resources = base.IsMember(doc,                                                                           // BuildMemberSection.cs:53
	            sections,                                                                                                                      // BuildMemberSection.cs:54
	            SectionCode());                                                                                                                // BuildMemberSection.cs:55
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberSection.cs:56
	        foreach (ResourceBase resource in resources)                                                                                       // BuildMemberSection.cs:57
	        {                                                                                                                                  // BuildMemberSection.cs:58
	            Item item = new Item((SectionFindingsRightBreast) resource);                                                                   // BuildMemberSection.cs:59
	            items.Add(item);                                                                                                               // BuildMemberSection.cs:60
	        }                                                                                                                                  // BuildMemberSection.cs:61
	        this.SetAllItems(items);                                                                                                           // BuildMemberSection.cs:62
	    }                                                                                                                                      // BuildMemberSection.cs:63
	}                                                                                                                                          // BuildMemberBase.cs:152
	/// <summary>
	/// Container class for Composition.section:findingsLeftBreast.
	/// </summary>
	public class FindingsLeftBreastContainer : MContainer, ITMItem<Composition.SectionComponent>                                               // BuildMemberBase.cs:135
	{                                                                                                                                          // BuildMemberBase.cs:136
	    /// <summary>
	    /// Item class for Composition.section:findingsLeftBreast.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:73
	    {                                                                                                                                      // BuildMemberBase.cs:74
	        // Properties                                                                                                                      // BuildMemberBase.cs:75
	        /// <summary>
	        /// Value
	        /// </summary>
	        public SectionFindingsLeftBreast Value { get; set; }                                                                               // BuildMemberBase.cs:79
	                                                                                                                                           // BuildMemberBase.cs:81
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(SectionFindingsLeftBreast value)                                                                                       // BuildMemberBase.cs:85
	        {                                                                                                                                  // BuildMemberBase.cs:86
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:87
	        }                                                                                                                                  // BuildMemberBase.cs:89
	                                                                                                                                           // BuildMemberBase.cs:91
	        // Methods                                                                                                                         // BuildMemberBase.cs:92
	    }                                                                                                                                      // BuildMemberBase.cs:94
	                                                                                                                                           // BuildMemberBase.cs:138
	    // Properties                                                                                                                          // BuildMemberBase.cs:139
	                                                                                                                                           // BuildMemberBase.cs:160
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems()                                                                                                        // BuildMemberBase.cs:164
	    {                                                                                                                                      // BuildMemberBase.cs:165
	        if (this.item != null) yield return this.item;                                                                                     // BuildMemberBase.cs:166
	    }                                                                                                                                      // BuildMemberBase.cs:167
	                                                                                                                                           // BuildMemberBase.cs:169
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items)                                                                                              // BuildMemberBase.cs:173
	    {                                                                                                                                      // BuildMemberBase.cs:174
	        switch (items.Count())                                                                                                             // BuildMemberBase.cs:175
	        {                                                                                                                                  // BuildMemberBase.cs:176
	            case 0: break;                                                                                                                 // BuildMemberBase.cs:177
	            case 1: this.item = items.First(); break;                                                                                      // BuildMemberBase.cs:178
	            default: throw new Exception("Found multiple elements while reading single item");                                             // BuildMemberBase.cs:179
	        }                                                                                                                                  // BuildMemberBase.cs:180
	    }                                                                                                                                      // BuildMemberBase.cs:181
	                                                                                                                                           // BuildMemberBase.cs:183
	    /// <summary>
	    /// Item
	    /// </summary>
	    Item item;                                                                                                                             // BuildMemberBase.cs:187
	                                                                                                                                           // BuildMemberBase.cs:189
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => this.item == null ? 0 : 1;                                                                              // BuildMemberBase.cs:193
	                                                                                                                                           // BuildMemberBase.cs:195
	    /// <summary>
	    /// Get Item's Value
	    /// </summary>
	    public SectionFindingsLeftBreast Get()                                                                                                 // BuildMemberBase.cs:199
	    {                                                                                                                                      // BuildMemberBase.cs:200
	        if (item == null)                                                                                                                  // BuildMemberBase.cs:201
	            return null;                                                                                                                   // BuildMemberBase.cs:202
	        return item.Value;                                                                                                                 // BuildMemberBase.cs:203
	    }                                                                                                                                      // BuildMemberBase.cs:204
	                                                                                                                                           // BuildMemberBase.cs:210
	    /// <summary>
	    /// Set Item's Value
	    /// </summary>
	    public SectionFindingsLeftBreast Set(SectionFindingsLeftBreast value)                                                                  // BuildMemberBase.cs:214
	    {                                                                                                                                      // BuildMemberBase.cs:215
	        this.item = new Item(value);                                                                                                       // BuildMemberBase.cs:216
	        return value;                                                                                                                      // BuildMemberBase.cs:217
	    }                                                                                                                                      // BuildMemberBase.cs:218
	                                                                                                                                           // BuildMemberBase.cs:141
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public FindingsLeftBreastContainer(Int32 min, Int32 max) : base("Composition.section:findingsLeftBreast", min, max)                    // BuildMemberBase.cs:145
	    {                                                                                                                                      // BuildMemberBase.cs:146
	    }                                                                                                                                      // BuildMemberBase.cs:148
	                                                                                                                                           // BuildMemberBase.cs:149
	    // Methods                                                                                                                             // BuildMemberBase.cs:150
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
	                                                                                                                                           // BuildMemberBase.cs:291
	    /// <summary>
	    /// Write single item as a fhir element.
	    /// </summary>
	    public IEnumerable<Composition.SectionComponent> Write(BreastRadiologyDocument doc)                                                    // BuildMemberSection.cs:74
	    {                                                                                                                                      // BuildMemberSection.cs:75
	        Composition.SectionComponent section = new Composition.SectionComponent                                                            // BuildMemberSection.cs:76
	        {                                                                                                                                  // BuildMemberSection.cs:77
	            Title = "Findings Left Breast",                                                                                                // BuildMemberSection.cs:78
	            Code = SectionCode()                                                                                                           // BuildMemberSection.cs:79
	        };                                                                                                                                 // BuildMemberSection.cs:80
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberSection.cs:81
	        {                                                                                                                                  // BuildMemberSection.cs:82
	            section.Entry.Add(new ResourceReference                                                                                        // BuildMemberSection.cs:83
	            {                                                                                                                              // BuildMemberSection.cs:84
	                Reference = item.Value.Id                                                                                                  // BuildMemberSection.cs:85
	            });                                                                                                                            // BuildMemberSection.cs:86
	        }                                                                                                                                  // BuildMemberSection.cs:87
	        yield return section;                                                                                                              // BuildMemberSection.cs:88
	    }                                                                                                                                      // BuildMemberSection.cs:89
	                                                                                                                                           // BuildMemberBase.cs:297
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	                                                                                                                                           // BuildMemberSection.cs:50
	    public void Read(BreastRadiologyDocument doc, IEnumerable<Composition.SectionComponent> sections)                                      // BuildMemberSection.cs:51
	    {                                                                                                                                      // BuildMemberSection.cs:52
	        IEnumerable<ResourceBase> resources = base.IsMember(doc,                                                                           // BuildMemberSection.cs:53
	            sections,                                                                                                                      // BuildMemberSection.cs:54
	            SectionCode());                                                                                                                // BuildMemberSection.cs:55
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberSection.cs:56
	        foreach (ResourceBase resource in resources)                                                                                       // BuildMemberSection.cs:57
	        {                                                                                                                                  // BuildMemberSection.cs:58
	            Item item = new Item((SectionFindingsLeftBreast) resource);                                                                    // BuildMemberSection.cs:59
	            items.Add(item);                                                                                                               // BuildMemberSection.cs:60
	        }                                                                                                                                  // BuildMemberSection.cs:61
	        this.SetAllItems(items);                                                                                                           // BuildMemberSection.cs:62
	    }                                                                                                                                      // BuildMemberSection.cs:63
	}                                                                                                                                          // BuildMemberBase.cs:152
	/// <summary>
	/// Container class for Composition.section:relatedResources.
	/// </summary>
	public class RelatedResourcesContainer : MContainer, ITMItem<Composition.SectionComponent>                                                 // BuildMemberBase.cs:135
	{                                                                                                                                          // BuildMemberBase.cs:136
	    /// <summary>
	    /// Item class for Composition.section:relatedResources.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:73
	    {                                                                                                                                      // BuildMemberBase.cs:74
	        // Properties                                                                                                                      // BuildMemberBase.cs:75
	        /// <summary>
	        /// Value
	        /// </summary>
	        public ResourceBase Value { get; set; }                                                                                            // BuildMemberBase.cs:79
	                                                                                                                                           // BuildMemberBase.cs:81
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(ResourceBase value)                                                                                                    // BuildMemberBase.cs:85
	        {                                                                                                                                  // BuildMemberBase.cs:86
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:87
	        }                                                                                                                                  // BuildMemberBase.cs:89
	                                                                                                                                           // BuildMemberBase.cs:91
	        // Methods                                                                                                                         // BuildMemberBase.cs:92
	    }                                                                                                                                      // BuildMemberBase.cs:94
	                                                                                                                                           // BuildMemberBase.cs:138
	    // Properties                                                                                                                          // BuildMemberBase.cs:139
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:225
	                                                                                                                                           // BuildMemberBase.cs:227
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:231
	                                                                                                                                           // BuildMemberBase.cs:233
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:237
	                                                                                                                                           // BuildMemberBase.cs:239
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:243
	                                                                                                                                           // BuildMemberBase.cs:245
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<ResourceBase> All()                                                                                                 // BuildMemberBase.cs:249
	    {                                                                                                                                      // BuildMemberBase.cs:250
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:251
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:252
	    }                                                                                                                                      // BuildMemberBase.cs:253
	                                                                                                                                           // BuildMemberBase.cs:255
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public ResourceBase GetAt(Int32 i) => this.items[i].Value;                                                                             // BuildMemberBase.cs:259
	                                                                                                                                           // BuildMemberBase.cs:261
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:265
	                                                                                                                                           // BuildMemberBase.cs:267
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:271
	                                                                                                                                           // BuildMemberBase.cs:141
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public RelatedResourcesContainer(Int32 min, Int32 max) : base("Composition.section:relatedResources", min, max)                        // BuildMemberBase.cs:145
	    {                                                                                                                                      // BuildMemberBase.cs:146
	    }                                                                                                                                      // BuildMemberBase.cs:148
	                                                                                                                                           // BuildMemberBase.cs:149
	    // Methods                                                                                                                             // BuildMemberBase.cs:150
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
	                                                                                                                                           // BuildMemberBase.cs:277
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public ResourceBase Append(ResourceBase value)                                                                                         // BuildMemberBase.cs:281
	    {                                                                                                                                      // BuildMemberBase.cs:282
	        this.items.Add(new Item(value));                                                                                                   // BuildMemberBase.cs:283
	        return value;                                                                                                                      // BuildMemberBase.cs:284
	    }                                                                                                                                      // BuildMemberBase.cs:285
	                                                                                                                                           // BuildMemberBase.cs:291
	    /// <summary>
	    /// Write single item as a fhir element.
	    /// </summary>
	    public IEnumerable<Composition.SectionComponent> Write(BreastRadiologyDocument doc)                                                    // BuildMemberSection.cs:74
	    {                                                                                                                                      // BuildMemberSection.cs:75
	        Composition.SectionComponent section = new Composition.SectionComponent                                                            // BuildMemberSection.cs:76
	        {                                                                                                                                  // BuildMemberSection.cs:77
	            Title = "Related Resources",                                                                                                   // BuildMemberSection.cs:78
	            Code = SectionCode()                                                                                                           // BuildMemberSection.cs:79
	        };                                                                                                                                 // BuildMemberSection.cs:80
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberSection.cs:81
	        {                                                                                                                                  // BuildMemberSection.cs:82
	            section.Entry.Add(new ResourceReference                                                                                        // BuildMemberSection.cs:83
	            {                                                                                                                              // BuildMemberSection.cs:84
	                Reference = item.Value.Id                                                                                                  // BuildMemberSection.cs:85
	            });                                                                                                                            // BuildMemberSection.cs:86
	        }                                                                                                                                  // BuildMemberSection.cs:87
	        yield return section;                                                                                                              // BuildMemberSection.cs:88
	    }                                                                                                                                      // BuildMemberSection.cs:89
	                                                                                                                                           // BuildMemberBase.cs:297
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	                                                                                                                                           // BuildMemberSection.cs:50
	    public void Read(BreastRadiologyDocument doc, IEnumerable<Composition.SectionComponent> sections)                                      // BuildMemberSection.cs:51
	    {                                                                                                                                      // BuildMemberSection.cs:52
	        IEnumerable<ResourceBase> resources = base.IsMember(doc,                                                                           // BuildMemberSection.cs:53
	            sections,                                                                                                                      // BuildMemberSection.cs:54
	            SectionCode());                                                                                                                // BuildMemberSection.cs:55
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberSection.cs:56
	        foreach (ResourceBase resource in resources)                                                                                       // BuildMemberSection.cs:57
	        {                                                                                                                                  // BuildMemberSection.cs:58
	            Item item = new Item((ResourceBase) resource);                                                                                 // BuildMemberSection.cs:59
	            items.Add(item);                                                                                                               // BuildMemberSection.cs:60
	        }                                                                                                                                  // BuildMemberSection.cs:61
	        this.SetAllItems(items);                                                                                                           // BuildMemberSection.cs:62
	    }                                                                                                                                      // BuildMemberSection.cs:63
	}                                                                                                                                          // BuildMemberBase.cs:152
	/// <summary>
	/// Container class for Composition.section:recommendations.
	/// </summary>
	public class RecommendationsContainer : MContainer, ITMItem<Composition.SectionComponent>                                                  // BuildMemberBase.cs:135
	{                                                                                                                                          // BuildMemberBase.cs:136
	    /// <summary>
	    /// Item class for Composition.section:recommendations.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:73
	    {                                                                                                                                      // BuildMemberBase.cs:74
	        // Properties                                                                                                                      // BuildMemberBase.cs:75
	        /// <summary>
	        /// Value
	        /// </summary>
	        public ResourceBase Value { get; set; }                                                                                            // BuildMemberBase.cs:79
	                                                                                                                                           // BuildMemberBase.cs:81
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(ResourceBase value)                                                                                                    // BuildMemberBase.cs:85
	        {                                                                                                                                  // BuildMemberBase.cs:86
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:87
	        }                                                                                                                                  // BuildMemberBase.cs:89
	                                                                                                                                           // BuildMemberBase.cs:91
	        // Methods                                                                                                                         // BuildMemberBase.cs:92
	    }                                                                                                                                      // BuildMemberBase.cs:94
	                                                                                                                                           // BuildMemberBase.cs:138
	    // Properties                                                                                                                          // BuildMemberBase.cs:139
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:225
	                                                                                                                                           // BuildMemberBase.cs:227
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:231
	                                                                                                                                           // BuildMemberBase.cs:233
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:237
	                                                                                                                                           // BuildMemberBase.cs:239
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:243
	                                                                                                                                           // BuildMemberBase.cs:245
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<ResourceBase> All()                                                                                                 // BuildMemberBase.cs:249
	    {                                                                                                                                      // BuildMemberBase.cs:250
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:251
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:252
	    }                                                                                                                                      // BuildMemberBase.cs:253
	                                                                                                                                           // BuildMemberBase.cs:255
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public ResourceBase GetAt(Int32 i) => this.items[i].Value;                                                                             // BuildMemberBase.cs:259
	                                                                                                                                           // BuildMemberBase.cs:261
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:265
	                                                                                                                                           // BuildMemberBase.cs:267
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:271
	                                                                                                                                           // BuildMemberBase.cs:141
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public RecommendationsContainer(Int32 min, Int32 max) : base("Composition.section:recommendations", min, max)                          // BuildMemberBase.cs:145
	    {                                                                                                                                      // BuildMemberBase.cs:146
	    }                                                                                                                                      // BuildMemberBase.cs:148
	                                                                                                                                           // BuildMemberBase.cs:149
	    // Methods                                                                                                                             // BuildMemberBase.cs:150
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
	                                                                                                                                           // BuildMemberBase.cs:277
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public MedicationRequestBase Append(MedicationRequestBase value)                                                                       // BuildMemberBase.cs:281
	    {                                                                                                                                      // BuildMemberBase.cs:282
	        this.items.Add(new Item(value));                                                                                                   // BuildMemberBase.cs:283
	        return value;                                                                                                                      // BuildMemberBase.cs:284
	    }                                                                                                                                      // BuildMemberBase.cs:285
	                                                                                                                                           // BuildMemberBase.cs:277
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public ServiceRequestBase Append(ServiceRequestBase value)                                                                             // BuildMemberBase.cs:281
	    {                                                                                                                                      // BuildMemberBase.cs:282
	        this.items.Add(new Item(value));                                                                                                   // BuildMemberBase.cs:283
	        return value;                                                                                                                      // BuildMemberBase.cs:284
	    }                                                                                                                                      // BuildMemberBase.cs:285
	                                                                                                                                           // BuildMemberBase.cs:277
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public ServiceRecommendation Append(ServiceRecommendation value)                                                                       // BuildMemberBase.cs:281
	    {                                                                                                                                      // BuildMemberBase.cs:282
	        this.items.Add(new Item(value));                                                                                                   // BuildMemberBase.cs:283
	        return value;                                                                                                                      // BuildMemberBase.cs:284
	    }                                                                                                                                      // BuildMemberBase.cs:285
	                                                                                                                                           // BuildMemberBase.cs:291
	    /// <summary>
	    /// Write single item as a fhir element.
	    /// </summary>
	    public IEnumerable<Composition.SectionComponent> Write(BreastRadiologyDocument doc)                                                    // BuildMemberSection.cs:74
	    {                                                                                                                                      // BuildMemberSection.cs:75
	        Composition.SectionComponent section = new Composition.SectionComponent                                                            // BuildMemberSection.cs:76
	        {                                                                                                                                  // BuildMemberSection.cs:77
	            Title = "Recommendations",                                                                                                     // BuildMemberSection.cs:78
	            Code = SectionCode()                                                                                                           // BuildMemberSection.cs:79
	        };                                                                                                                                 // BuildMemberSection.cs:80
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberSection.cs:81
	        {                                                                                                                                  // BuildMemberSection.cs:82
	            section.Entry.Add(new ResourceReference                                                                                        // BuildMemberSection.cs:83
	            {                                                                                                                              // BuildMemberSection.cs:84
	                Reference = item.Value.Id                                                                                                  // BuildMemberSection.cs:85
	            });                                                                                                                            // BuildMemberSection.cs:86
	        }                                                                                                                                  // BuildMemberSection.cs:87
	        yield return section;                                                                                                              // BuildMemberSection.cs:88
	    }                                                                                                                                      // BuildMemberSection.cs:89
	                                                                                                                                           // BuildMemberBase.cs:297
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	                                                                                                                                           // BuildMemberSection.cs:50
	    public void Read(BreastRadiologyDocument doc, IEnumerable<Composition.SectionComponent> sections)                                      // BuildMemberSection.cs:51
	    {                                                                                                                                      // BuildMemberSection.cs:52
	        IEnumerable<ResourceBase> resources = base.IsMember(doc,                                                                           // BuildMemberSection.cs:53
	            sections,                                                                                                                      // BuildMemberSection.cs:54
	            SectionCode());                                                                                                                // BuildMemberSection.cs:55
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberSection.cs:56
	        foreach (ResourceBase resource in resources)                                                                                       // BuildMemberSection.cs:57
	        {                                                                                                                                  // BuildMemberSection.cs:58
	            Item item = new Item((ResourceBase) resource);                                                                                 // BuildMemberSection.cs:59
	            items.Add(item);                                                                                                               // BuildMemberSection.cs:60
	        }                                                                                                                                  // BuildMemberSection.cs:61
	        this.SetAllItems(items);                                                                                                           // BuildMemberSection.cs:62
	    }                                                                                                                                      // BuildMemberSection.cs:63
	}                                                                                                                                          // BuildMemberBase.cs:152
	//- LocalClassDefs
}
