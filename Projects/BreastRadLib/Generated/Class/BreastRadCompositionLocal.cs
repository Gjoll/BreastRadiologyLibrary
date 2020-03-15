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
	    public class Item                                                                                                                      // BuildMemberBase.cs:67
	    {                                                                                                                                      // BuildMemberBase.cs:68
	        // Properties                                                                                                                      // BuildMemberBase.cs:69
	        /// <summary>
	        /// Value
	        /// </summary>
	        public BreastRadReport Value { get; set; }                                                                                         // BuildMemberBase.cs:73
	                                                                                                                                           // BuildMemberBase.cs:75
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(BreastRadReport value)                                                                                                 // BuildMemberBase.cs:79
	        {                                                                                                                                  // BuildMemberBase.cs:80
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:81
	        }                                                                                                                                  // BuildMemberBase.cs:83
	                                                                                                                                           // BuildMemberBase.cs:85
	        // Methods                                                                                                                         // BuildMemberBase.cs:86
	    }                                                                                                                                      // BuildMemberBase.cs:88
	                                                                                                                                           // BuildMemberBase.cs:138
	    // Properties                                                                                                                          // BuildMemberBase.cs:139
	                                                                                                                                           // BuildMemberBase.cs:162
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems()                                                                                                        // BuildMemberBase.cs:166
	    {                                                                                                                                      // BuildMemberBase.cs:167
	        if (this.item != null) yield return this.item;                                                                                     // BuildMemberBase.cs:168
	    }                                                                                                                                      // BuildMemberBase.cs:169
	                                                                                                                                           // BuildMemberBase.cs:171
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items)                                                                                              // BuildMemberBase.cs:175
	    {                                                                                                                                      // BuildMemberBase.cs:176
	        switch (items.Count())                                                                                                             // BuildMemberBase.cs:177
	        {                                                                                                                                  // BuildMemberBase.cs:178
	            case 0: break;                                                                                                                 // BuildMemberBase.cs:179
	            case 1: this.item = items.First(); break;                                                                                      // BuildMemberBase.cs:180
	            default: throw new Exception("Found multiple elements while reading single item");                                             // BuildMemberBase.cs:181
	        }                                                                                                                                  // BuildMemberBase.cs:182
	    }                                                                                                                                      // BuildMemberBase.cs:183
	                                                                                                                                           // BuildMemberBase.cs:185
	    /// <summary>
	    /// Item
	    /// </summary>
	    Item item;                                                                                                                             // BuildMemberBase.cs:189
	                                                                                                                                           // BuildMemberBase.cs:191
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => this.item == null ? 0 : 1;                                                                              // BuildMemberBase.cs:195
	                                                                                                                                           // BuildMemberBase.cs:197
	    /// <summary>
	    /// Get Item's Value
	    /// </summary>
	    public BreastRadReport Get()                                                                                                           // BuildMemberBase.cs:201
	    {                                                                                                                                      // BuildMemberBase.cs:202
	        if (item == null)                                                                                                                  // BuildMemberBase.cs:203
	            return null;                                                                                                                   // BuildMemberBase.cs:204
	        return item.Value;                                                                                                                 // BuildMemberBase.cs:205
	    }                                                                                                                                      // BuildMemberBase.cs:206
	                                                                                                                                           // BuildMemberBase.cs:212
	    /// <summary>
	    /// Set Item's Value
	    /// </summary>
	    public BreastRadReport Set(BreastRadReport value)                                                                                      // BuildMemberBase.cs:216
	    {                                                                                                                                      // BuildMemberBase.cs:217
	        this.item = new Item(value);                                                                                                       // BuildMemberBase.cs:218
	        return value;                                                                                                                      // BuildMemberBase.cs:219
	    }                                                                                                                                      // BuildMemberBase.cs:220
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
	                                                                                                                                           // BuildMemberBase.cs:293
	    /// <summary>
	    /// Write single item as a fhir element.
	    /// </summary>
	    public IEnumerable<Composition.SectionComponent> Write(BreastRadiologyDocument doc)                                                    // BuildMemberSection.cs:78
	    {                                                                                                                                      // BuildMemberSection.cs:79
	        Composition.SectionComponent section = new Composition.SectionComponent                                                            // BuildMemberSection.cs:80
	        {                                                                                                                                  // BuildMemberSection.cs:81
	            Title = "Breast Radiology Report",                                                                                             // BuildMemberSection.cs:82
	            Code = SectionCode()                                                                                                           // BuildMemberSection.cs:83
	        };                                                                                                                                 // BuildMemberSection.cs:84
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberSection.cs:85
	        {                                                                                                                                  // BuildMemberSection.cs:86
	            section.Entry.Add(new ResourceReference                                                                                        // BuildMemberSection.cs:87
	            {                                                                                                                              // BuildMemberSection.cs:88
	                Reference = item.Value.Id                                                                                                  // BuildMemberSection.cs:89
	            });                                                                                                                            // BuildMemberSection.cs:90
	        }                                                                                                                                  // BuildMemberSection.cs:91
	        yield return section;                                                                                                              // BuildMemberSection.cs:92
	    }                                                                                                                                      // BuildMemberSection.cs:93
	                                                                                                                                           // BuildMemberBase.cs:299
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	                                                                                                                                           // BuildMemberSection.cs:54
	    public void Read(BreastRadiologyDocument doc, IEnumerable<Composition.SectionComponent> sections)                                      // BuildMemberSection.cs:55
	    {                                                                                                                                      // BuildMemberSection.cs:56
	        IEnumerable<ResourceBase> resources = base.IsMember(doc,                                                                           // BuildMemberSection.cs:57
	            sections,                                                                                                                      // BuildMemberSection.cs:58
	            SectionCode());                                                                                                                // BuildMemberSection.cs:59
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberSection.cs:60
	        foreach (ResourceBase resource in resources)                                                                                       // BuildMemberSection.cs:61
	        {                                                                                                                                  // BuildMemberSection.cs:62
	            Item item = new Item((BreastRadReport) resource);                                                                              // BuildMemberSection.cs:63
	            items.Add(item);                                                                                                               // BuildMemberSection.cs:64
	        }                                                                                                                                  // BuildMemberSection.cs:65
	        this.SetAllItems(items);                                                                                                           // BuildMemberSection.cs:66
	    }                                                                                                                                      // BuildMemberSection.cs:67
	}                                                                                                                                          // BuildMemberBase.cs:152
	/// <summary>
	/// Container class for Composition.section:impressions.
	/// </summary>
	public class ImpressionsContainer : MContainer, ITMItem<Composition.SectionComponent>                                                      // BuildMemberBase.cs:135
	{                                                                                                                                          // BuildMemberBase.cs:136
	    /// <summary>
	    /// Item class for Composition.section:impressions.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:67
	    {                                                                                                                                      // BuildMemberBase.cs:68
	        // Properties                                                                                                                      // BuildMemberBase.cs:69
	        /// <summary>
	        /// Value
	        /// </summary>
	        public ClinicalImpressionBase Value { get; set; }                                                                                  // BuildMemberBase.cs:73
	                                                                                                                                           // BuildMemberBase.cs:75
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(ClinicalImpressionBase value)                                                                                          // BuildMemberBase.cs:79
	        {                                                                                                                                  // BuildMemberBase.cs:80
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:81
	        }                                                                                                                                  // BuildMemberBase.cs:83
	                                                                                                                                           // BuildMemberBase.cs:85
	        // Methods                                                                                                                         // BuildMemberBase.cs:86
	    }                                                                                                                                      // BuildMemberBase.cs:88
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
	    public IEnumerable<ClinicalImpressionBase> All()                                                                                       // BuildMemberBase.cs:251
	    {                                                                                                                                      // BuildMemberBase.cs:252
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:253
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:254
	    }                                                                                                                                      // BuildMemberBase.cs:255
	                                                                                                                                           // BuildMemberBase.cs:257
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public ClinicalImpressionBase GetAt(Int32 i) => this.items[i].Value;                                                                   // BuildMemberBase.cs:261
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
	                                                                                                                                           // BuildMemberBase.cs:279
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public ClinicalImpressionBase Append(ClinicalImpressionBase value)                                                                     // BuildMemberBase.cs:283
	    {                                                                                                                                      // BuildMemberBase.cs:284
	        this.items.Add(new Item(value));                                                                                                   // BuildMemberBase.cs:285
	        return value;                                                                                                                      // BuildMemberBase.cs:286
	    }                                                                                                                                      // BuildMemberBase.cs:287
	                                                                                                                                           // BuildMemberBase.cs:293
	    /// <summary>
	    /// Write single item as a fhir element.
	    /// </summary>
	    public IEnumerable<Composition.SectionComponent> Write(BreastRadiologyDocument doc)                                                    // BuildMemberSection.cs:78
	    {                                                                                                                                      // BuildMemberSection.cs:79
	        Composition.SectionComponent section = new Composition.SectionComponent                                                            // BuildMemberSection.cs:80
	        {                                                                                                                                  // BuildMemberSection.cs:81
	            Title = "Clinical Impressions",                                                                                                // BuildMemberSection.cs:82
	            Code = SectionCode()                                                                                                           // BuildMemberSection.cs:83
	        };                                                                                                                                 // BuildMemberSection.cs:84
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberSection.cs:85
	        {                                                                                                                                  // BuildMemberSection.cs:86
	            section.Entry.Add(new ResourceReference                                                                                        // BuildMemberSection.cs:87
	            {                                                                                                                              // BuildMemberSection.cs:88
	                Reference = item.Value.Id                                                                                                  // BuildMemberSection.cs:89
	            });                                                                                                                            // BuildMemberSection.cs:90
	        }                                                                                                                                  // BuildMemberSection.cs:91
	        yield return section;                                                                                                              // BuildMemberSection.cs:92
	    }                                                                                                                                      // BuildMemberSection.cs:93
	                                                                                                                                           // BuildMemberBase.cs:299
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	                                                                                                                                           // BuildMemberSection.cs:54
	    public void Read(BreastRadiologyDocument doc, IEnumerable<Composition.SectionComponent> sections)                                      // BuildMemberSection.cs:55
	    {                                                                                                                                      // BuildMemberSection.cs:56
	        IEnumerable<ResourceBase> resources = base.IsMember(doc,                                                                           // BuildMemberSection.cs:57
	            sections,                                                                                                                      // BuildMemberSection.cs:58
	            SectionCode());                                                                                                                // BuildMemberSection.cs:59
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberSection.cs:60
	        foreach (ResourceBase resource in resources)                                                                                       // BuildMemberSection.cs:61
	        {                                                                                                                                  // BuildMemberSection.cs:62
	            Item item = new Item((ClinicalImpressionBase) resource);                                                                       // BuildMemberSection.cs:63
	            items.Add(item);                                                                                                               // BuildMemberSection.cs:64
	        }                                                                                                                                  // BuildMemberSection.cs:65
	        this.SetAllItems(items);                                                                                                           // BuildMemberSection.cs:66
	    }                                                                                                                                      // BuildMemberSection.cs:67
	}                                                                                                                                          // BuildMemberBase.cs:152
	/// <summary>
	/// Container class for Composition.section:findingsRightBreast.
	/// </summary>
	public class FindingsRightBreastContainer : MContainer, ITMItem<Composition.SectionComponent>                                              // BuildMemberBase.cs:135
	{                                                                                                                                          // BuildMemberBase.cs:136
	    /// <summary>
	    /// Item class for Composition.section:findingsRightBreast.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:67
	    {                                                                                                                                      // BuildMemberBase.cs:68
	        // Properties                                                                                                                      // BuildMemberBase.cs:69
	        /// <summary>
	        /// Value
	        /// </summary>
	        public SectionFindingsRightBreast Value { get; set; }                                                                              // BuildMemberBase.cs:73
	                                                                                                                                           // BuildMemberBase.cs:75
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(SectionFindingsRightBreast value)                                                                                      // BuildMemberBase.cs:79
	        {                                                                                                                                  // BuildMemberBase.cs:80
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:81
	        }                                                                                                                                  // BuildMemberBase.cs:83
	                                                                                                                                           // BuildMemberBase.cs:85
	        // Methods                                                                                                                         // BuildMemberBase.cs:86
	    }                                                                                                                                      // BuildMemberBase.cs:88
	                                                                                                                                           // BuildMemberBase.cs:138
	    // Properties                                                                                                                          // BuildMemberBase.cs:139
	                                                                                                                                           // BuildMemberBase.cs:162
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems()                                                                                                        // BuildMemberBase.cs:166
	    {                                                                                                                                      // BuildMemberBase.cs:167
	        if (this.item != null) yield return this.item;                                                                                     // BuildMemberBase.cs:168
	    }                                                                                                                                      // BuildMemberBase.cs:169
	                                                                                                                                           // BuildMemberBase.cs:171
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items)                                                                                              // BuildMemberBase.cs:175
	    {                                                                                                                                      // BuildMemberBase.cs:176
	        switch (items.Count())                                                                                                             // BuildMemberBase.cs:177
	        {                                                                                                                                  // BuildMemberBase.cs:178
	            case 0: break;                                                                                                                 // BuildMemberBase.cs:179
	            case 1: this.item = items.First(); break;                                                                                      // BuildMemberBase.cs:180
	            default: throw new Exception("Found multiple elements while reading single item");                                             // BuildMemberBase.cs:181
	        }                                                                                                                                  // BuildMemberBase.cs:182
	    }                                                                                                                                      // BuildMemberBase.cs:183
	                                                                                                                                           // BuildMemberBase.cs:185
	    /// <summary>
	    /// Item
	    /// </summary>
	    Item item;                                                                                                                             // BuildMemberBase.cs:189
	                                                                                                                                           // BuildMemberBase.cs:191
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => this.item == null ? 0 : 1;                                                                              // BuildMemberBase.cs:195
	                                                                                                                                           // BuildMemberBase.cs:197
	    /// <summary>
	    /// Get Item's Value
	    /// </summary>
	    public SectionFindingsRightBreast Get()                                                                                                // BuildMemberBase.cs:201
	    {                                                                                                                                      // BuildMemberBase.cs:202
	        if (item == null)                                                                                                                  // BuildMemberBase.cs:203
	            return null;                                                                                                                   // BuildMemberBase.cs:204
	        return item.Value;                                                                                                                 // BuildMemberBase.cs:205
	    }                                                                                                                                      // BuildMemberBase.cs:206
	                                                                                                                                           // BuildMemberBase.cs:212
	    /// <summary>
	    /// Set Item's Value
	    /// </summary>
	    public SectionFindingsRightBreast Set(SectionFindingsRightBreast value)                                                                // BuildMemberBase.cs:216
	    {                                                                                                                                      // BuildMemberBase.cs:217
	        this.item = new Item(value);                                                                                                       // BuildMemberBase.cs:218
	        return value;                                                                                                                      // BuildMemberBase.cs:219
	    }                                                                                                                                      // BuildMemberBase.cs:220
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
	                                                                                                                                           // BuildMemberBase.cs:293
	    /// <summary>
	    /// Write single item as a fhir element.
	    /// </summary>
	    public IEnumerable<Composition.SectionComponent> Write(BreastRadiologyDocument doc)                                                    // BuildMemberSection.cs:78
	    {                                                                                                                                      // BuildMemberSection.cs:79
	        Composition.SectionComponent section = new Composition.SectionComponent                                                            // BuildMemberSection.cs:80
	        {                                                                                                                                  // BuildMemberSection.cs:81
	            Title = "Findings Right Breast",                                                                                               // BuildMemberSection.cs:82
	            Code = SectionCode()                                                                                                           // BuildMemberSection.cs:83
	        };                                                                                                                                 // BuildMemberSection.cs:84
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberSection.cs:85
	        {                                                                                                                                  // BuildMemberSection.cs:86
	            section.Entry.Add(new ResourceReference                                                                                        // BuildMemberSection.cs:87
	            {                                                                                                                              // BuildMemberSection.cs:88
	                Reference = item.Value.Id                                                                                                  // BuildMemberSection.cs:89
	            });                                                                                                                            // BuildMemberSection.cs:90
	        }                                                                                                                                  // BuildMemberSection.cs:91
	        yield return section;                                                                                                              // BuildMemberSection.cs:92
	    }                                                                                                                                      // BuildMemberSection.cs:93
	                                                                                                                                           // BuildMemberBase.cs:299
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	                                                                                                                                           // BuildMemberSection.cs:54
	    public void Read(BreastRadiologyDocument doc, IEnumerable<Composition.SectionComponent> sections)                                      // BuildMemberSection.cs:55
	    {                                                                                                                                      // BuildMemberSection.cs:56
	        IEnumerable<ResourceBase> resources = base.IsMember(doc,                                                                           // BuildMemberSection.cs:57
	            sections,                                                                                                                      // BuildMemberSection.cs:58
	            SectionCode());                                                                                                                // BuildMemberSection.cs:59
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberSection.cs:60
	        foreach (ResourceBase resource in resources)                                                                                       // BuildMemberSection.cs:61
	        {                                                                                                                                  // BuildMemberSection.cs:62
	            Item item = new Item((SectionFindingsRightBreast) resource);                                                                   // BuildMemberSection.cs:63
	            items.Add(item);                                                                                                               // BuildMemberSection.cs:64
	        }                                                                                                                                  // BuildMemberSection.cs:65
	        this.SetAllItems(items);                                                                                                           // BuildMemberSection.cs:66
	    }                                                                                                                                      // BuildMemberSection.cs:67
	}                                                                                                                                          // BuildMemberBase.cs:152
	/// <summary>
	/// Container class for Composition.section:findingsLeftBreast.
	/// </summary>
	public class FindingsLeftBreastContainer : MContainer, ITMItem<Composition.SectionComponent>                                               // BuildMemberBase.cs:135
	{                                                                                                                                          // BuildMemberBase.cs:136
	    /// <summary>
	    /// Item class for Composition.section:findingsLeftBreast.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:67
	    {                                                                                                                                      // BuildMemberBase.cs:68
	        // Properties                                                                                                                      // BuildMemberBase.cs:69
	        /// <summary>
	        /// Value
	        /// </summary>
	        public SectionFindingsLeftBreast Value { get; set; }                                                                               // BuildMemberBase.cs:73
	                                                                                                                                           // BuildMemberBase.cs:75
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(SectionFindingsLeftBreast value)                                                                                       // BuildMemberBase.cs:79
	        {                                                                                                                                  // BuildMemberBase.cs:80
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:81
	        }                                                                                                                                  // BuildMemberBase.cs:83
	                                                                                                                                           // BuildMemberBase.cs:85
	        // Methods                                                                                                                         // BuildMemberBase.cs:86
	    }                                                                                                                                      // BuildMemberBase.cs:88
	                                                                                                                                           // BuildMemberBase.cs:138
	    // Properties                                                                                                                          // BuildMemberBase.cs:139
	                                                                                                                                           // BuildMemberBase.cs:162
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems()                                                                                                        // BuildMemberBase.cs:166
	    {                                                                                                                                      // BuildMemberBase.cs:167
	        if (this.item != null) yield return this.item;                                                                                     // BuildMemberBase.cs:168
	    }                                                                                                                                      // BuildMemberBase.cs:169
	                                                                                                                                           // BuildMemberBase.cs:171
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items)                                                                                              // BuildMemberBase.cs:175
	    {                                                                                                                                      // BuildMemberBase.cs:176
	        switch (items.Count())                                                                                                             // BuildMemberBase.cs:177
	        {                                                                                                                                  // BuildMemberBase.cs:178
	            case 0: break;                                                                                                                 // BuildMemberBase.cs:179
	            case 1: this.item = items.First(); break;                                                                                      // BuildMemberBase.cs:180
	            default: throw new Exception("Found multiple elements while reading single item");                                             // BuildMemberBase.cs:181
	        }                                                                                                                                  // BuildMemberBase.cs:182
	    }                                                                                                                                      // BuildMemberBase.cs:183
	                                                                                                                                           // BuildMemberBase.cs:185
	    /// <summary>
	    /// Item
	    /// </summary>
	    Item item;                                                                                                                             // BuildMemberBase.cs:189
	                                                                                                                                           // BuildMemberBase.cs:191
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => this.item == null ? 0 : 1;                                                                              // BuildMemberBase.cs:195
	                                                                                                                                           // BuildMemberBase.cs:197
	    /// <summary>
	    /// Get Item's Value
	    /// </summary>
	    public SectionFindingsLeftBreast Get()                                                                                                 // BuildMemberBase.cs:201
	    {                                                                                                                                      // BuildMemberBase.cs:202
	        if (item == null)                                                                                                                  // BuildMemberBase.cs:203
	            return null;                                                                                                                   // BuildMemberBase.cs:204
	        return item.Value;                                                                                                                 // BuildMemberBase.cs:205
	    }                                                                                                                                      // BuildMemberBase.cs:206
	                                                                                                                                           // BuildMemberBase.cs:212
	    /// <summary>
	    /// Set Item's Value
	    /// </summary>
	    public SectionFindingsLeftBreast Set(SectionFindingsLeftBreast value)                                                                  // BuildMemberBase.cs:216
	    {                                                                                                                                      // BuildMemberBase.cs:217
	        this.item = new Item(value);                                                                                                       // BuildMemberBase.cs:218
	        return value;                                                                                                                      // BuildMemberBase.cs:219
	    }                                                                                                                                      // BuildMemberBase.cs:220
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
	                                                                                                                                           // BuildMemberBase.cs:293
	    /// <summary>
	    /// Write single item as a fhir element.
	    /// </summary>
	    public IEnumerable<Composition.SectionComponent> Write(BreastRadiologyDocument doc)                                                    // BuildMemberSection.cs:78
	    {                                                                                                                                      // BuildMemberSection.cs:79
	        Composition.SectionComponent section = new Composition.SectionComponent                                                            // BuildMemberSection.cs:80
	        {                                                                                                                                  // BuildMemberSection.cs:81
	            Title = "Findings Left Breast",                                                                                                // BuildMemberSection.cs:82
	            Code = SectionCode()                                                                                                           // BuildMemberSection.cs:83
	        };                                                                                                                                 // BuildMemberSection.cs:84
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberSection.cs:85
	        {                                                                                                                                  // BuildMemberSection.cs:86
	            section.Entry.Add(new ResourceReference                                                                                        // BuildMemberSection.cs:87
	            {                                                                                                                              // BuildMemberSection.cs:88
	                Reference = item.Value.Id                                                                                                  // BuildMemberSection.cs:89
	            });                                                                                                                            // BuildMemberSection.cs:90
	        }                                                                                                                                  // BuildMemberSection.cs:91
	        yield return section;                                                                                                              // BuildMemberSection.cs:92
	    }                                                                                                                                      // BuildMemberSection.cs:93
	                                                                                                                                           // BuildMemberBase.cs:299
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	                                                                                                                                           // BuildMemberSection.cs:54
	    public void Read(BreastRadiologyDocument doc, IEnumerable<Composition.SectionComponent> sections)                                      // BuildMemberSection.cs:55
	    {                                                                                                                                      // BuildMemberSection.cs:56
	        IEnumerable<ResourceBase> resources = base.IsMember(doc,                                                                           // BuildMemberSection.cs:57
	            sections,                                                                                                                      // BuildMemberSection.cs:58
	            SectionCode());                                                                                                                // BuildMemberSection.cs:59
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberSection.cs:60
	        foreach (ResourceBase resource in resources)                                                                                       // BuildMemberSection.cs:61
	        {                                                                                                                                  // BuildMemberSection.cs:62
	            Item item = new Item((SectionFindingsLeftBreast) resource);                                                                    // BuildMemberSection.cs:63
	            items.Add(item);                                                                                                               // BuildMemberSection.cs:64
	        }                                                                                                                                  // BuildMemberSection.cs:65
	        this.SetAllItems(items);                                                                                                           // BuildMemberSection.cs:66
	    }                                                                                                                                      // BuildMemberSection.cs:67
	}                                                                                                                                          // BuildMemberBase.cs:152
	/// <summary>
	/// Container class for Composition.section:relatedResources.
	/// </summary>
	public class RelatedResourcesContainer : MContainer, ITMItem<Composition.SectionComponent>                                                 // BuildMemberBase.cs:135
	{                                                                                                                                          // BuildMemberBase.cs:136
	    /// <summary>
	    /// Item class for Composition.section:relatedResources.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:67
	    {                                                                                                                                      // BuildMemberBase.cs:68
	        // Properties                                                                                                                      // BuildMemberBase.cs:69
	        /// <summary>
	        /// Value
	        /// </summary>
	        public ResourceBase Value { get; set; }                                                                                            // BuildMemberBase.cs:73
	                                                                                                                                           // BuildMemberBase.cs:75
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(ResourceBase value)                                                                                                    // BuildMemberBase.cs:79
	        {                                                                                                                                  // BuildMemberBase.cs:80
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:81
	        }                                                                                                                                  // BuildMemberBase.cs:83
	                                                                                                                                           // BuildMemberBase.cs:85
	        // Methods                                                                                                                         // BuildMemberBase.cs:86
	    }                                                                                                                                      // BuildMemberBase.cs:88
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
	    public IEnumerable<ResourceBase> All()                                                                                                 // BuildMemberBase.cs:251
	    {                                                                                                                                      // BuildMemberBase.cs:252
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:253
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:254
	    }                                                                                                                                      // BuildMemberBase.cs:255
	                                                                                                                                           // BuildMemberBase.cs:257
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public ResourceBase GetAt(Int32 i) => this.items[i].Value;                                                                             // BuildMemberBase.cs:261
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
	                                                                                                                                           // BuildMemberBase.cs:279
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public ResourceBase Append(ResourceBase value)                                                                                         // BuildMemberBase.cs:283
	    {                                                                                                                                      // BuildMemberBase.cs:284
	        this.items.Add(new Item(value));                                                                                                   // BuildMemberBase.cs:285
	        return value;                                                                                                                      // BuildMemberBase.cs:286
	    }                                                                                                                                      // BuildMemberBase.cs:287
	                                                                                                                                           // BuildMemberBase.cs:293
	    /// <summary>
	    /// Write single item as a fhir element.
	    /// </summary>
	    public IEnumerable<Composition.SectionComponent> Write(BreastRadiologyDocument doc)                                                    // BuildMemberSection.cs:78
	    {                                                                                                                                      // BuildMemberSection.cs:79
	        Composition.SectionComponent section = new Composition.SectionComponent                                                            // BuildMemberSection.cs:80
	        {                                                                                                                                  // BuildMemberSection.cs:81
	            Title = "Related Resources",                                                                                                   // BuildMemberSection.cs:82
	            Code = SectionCode()                                                                                                           // BuildMemberSection.cs:83
	        };                                                                                                                                 // BuildMemberSection.cs:84
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberSection.cs:85
	        {                                                                                                                                  // BuildMemberSection.cs:86
	            section.Entry.Add(new ResourceReference                                                                                        // BuildMemberSection.cs:87
	            {                                                                                                                              // BuildMemberSection.cs:88
	                Reference = item.Value.Id                                                                                                  // BuildMemberSection.cs:89
	            });                                                                                                                            // BuildMemberSection.cs:90
	        }                                                                                                                                  // BuildMemberSection.cs:91
	        yield return section;                                                                                                              // BuildMemberSection.cs:92
	    }                                                                                                                                      // BuildMemberSection.cs:93
	                                                                                                                                           // BuildMemberBase.cs:299
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	                                                                                                                                           // BuildMemberSection.cs:54
	    public void Read(BreastRadiologyDocument doc, IEnumerable<Composition.SectionComponent> sections)                                      // BuildMemberSection.cs:55
	    {                                                                                                                                      // BuildMemberSection.cs:56
	        IEnumerable<ResourceBase> resources = base.IsMember(doc,                                                                           // BuildMemberSection.cs:57
	            sections,                                                                                                                      // BuildMemberSection.cs:58
	            SectionCode());                                                                                                                // BuildMemberSection.cs:59
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberSection.cs:60
	        foreach (ResourceBase resource in resources)                                                                                       // BuildMemberSection.cs:61
	        {                                                                                                                                  // BuildMemberSection.cs:62
	            Item item = new Item((ResourceBase) resource);                                                                                 // BuildMemberSection.cs:63
	            items.Add(item);                                                                                                               // BuildMemberSection.cs:64
	        }                                                                                                                                  // BuildMemberSection.cs:65
	        this.SetAllItems(items);                                                                                                           // BuildMemberSection.cs:66
	    }                                                                                                                                      // BuildMemberSection.cs:67
	}                                                                                                                                          // BuildMemberBase.cs:152
	/// <summary>
	/// Container class for Composition.section:recommendations.
	/// </summary>
	public class RecommendationsContainer : MContainer, ITMItem<Composition.SectionComponent>                                                  // BuildMemberBase.cs:135
	{                                                                                                                                          // BuildMemberBase.cs:136
	    /// <summary>
	    /// Item class for Composition.section:recommendations.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:67
	    {                                                                                                                                      // BuildMemberBase.cs:68
	        // Properties                                                                                                                      // BuildMemberBase.cs:69
	        /// <summary>
	        /// Value
	        /// </summary>
	        public ResourceBase Value { get; set; }                                                                                            // BuildMemberBase.cs:73
	                                                                                                                                           // BuildMemberBase.cs:75
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(ResourceBase value)                                                                                                    // BuildMemberBase.cs:79
	        {                                                                                                                                  // BuildMemberBase.cs:80
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:81
	        }                                                                                                                                  // BuildMemberBase.cs:83
	                                                                                                                                           // BuildMemberBase.cs:85
	        // Methods                                                                                                                         // BuildMemberBase.cs:86
	    }                                                                                                                                      // BuildMemberBase.cs:88
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
	    public IEnumerable<ResourceBase> All()                                                                                                 // BuildMemberBase.cs:251
	    {                                                                                                                                      // BuildMemberBase.cs:252
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:253
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:254
	    }                                                                                                                                      // BuildMemberBase.cs:255
	                                                                                                                                           // BuildMemberBase.cs:257
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public ResourceBase GetAt(Int32 i) => this.items[i].Value;                                                                             // BuildMemberBase.cs:261
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
	                                                                                                                                           // BuildMemberBase.cs:279
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public MedicationRequestBase Append(MedicationRequestBase value)                                                                       // BuildMemberBase.cs:283
	    {                                                                                                                                      // BuildMemberBase.cs:284
	        this.items.Add(new Item(value));                                                                                                   // BuildMemberBase.cs:285
	        return value;                                                                                                                      // BuildMemberBase.cs:286
	    }                                                                                                                                      // BuildMemberBase.cs:287
	                                                                                                                                           // BuildMemberBase.cs:279
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public ServiceRequestBase Append(ServiceRequestBase value)                                                                             // BuildMemberBase.cs:283
	    {                                                                                                                                      // BuildMemberBase.cs:284
	        this.items.Add(new Item(value));                                                                                                   // BuildMemberBase.cs:285
	        return value;                                                                                                                      // BuildMemberBase.cs:286
	    }                                                                                                                                      // BuildMemberBase.cs:287
	                                                                                                                                           // BuildMemberBase.cs:279
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public ServiceRecommendation Append(ServiceRecommendation value)                                                                       // BuildMemberBase.cs:283
	    {                                                                                                                                      // BuildMemberBase.cs:284
	        this.items.Add(new Item(value));                                                                                                   // BuildMemberBase.cs:285
	        return value;                                                                                                                      // BuildMemberBase.cs:286
	    }                                                                                                                                      // BuildMemberBase.cs:287
	                                                                                                                                           // BuildMemberBase.cs:293
	    /// <summary>
	    /// Write single item as a fhir element.
	    /// </summary>
	    public IEnumerable<Composition.SectionComponent> Write(BreastRadiologyDocument doc)                                                    // BuildMemberSection.cs:78
	    {                                                                                                                                      // BuildMemberSection.cs:79
	        Composition.SectionComponent section = new Composition.SectionComponent                                                            // BuildMemberSection.cs:80
	        {                                                                                                                                  // BuildMemberSection.cs:81
	            Title = "Recommendations",                                                                                                     // BuildMemberSection.cs:82
	            Code = SectionCode()                                                                                                           // BuildMemberSection.cs:83
	        };                                                                                                                                 // BuildMemberSection.cs:84
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberSection.cs:85
	        {                                                                                                                                  // BuildMemberSection.cs:86
	            section.Entry.Add(new ResourceReference                                                                                        // BuildMemberSection.cs:87
	            {                                                                                                                              // BuildMemberSection.cs:88
	                Reference = item.Value.Id                                                                                                  // BuildMemberSection.cs:89
	            });                                                                                                                            // BuildMemberSection.cs:90
	        }                                                                                                                                  // BuildMemberSection.cs:91
	        yield return section;                                                                                                              // BuildMemberSection.cs:92
	    }                                                                                                                                      // BuildMemberSection.cs:93
	                                                                                                                                           // BuildMemberBase.cs:299
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	                                                                                                                                           // BuildMemberSection.cs:54
	    public void Read(BreastRadiologyDocument doc, IEnumerable<Composition.SectionComponent> sections)                                      // BuildMemberSection.cs:55
	    {                                                                                                                                      // BuildMemberSection.cs:56
	        IEnumerable<ResourceBase> resources = base.IsMember(doc,                                                                           // BuildMemberSection.cs:57
	            sections,                                                                                                                      // BuildMemberSection.cs:58
	            SectionCode());                                                                                                                // BuildMemberSection.cs:59
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberSection.cs:60
	        foreach (ResourceBase resource in resources)                                                                                       // BuildMemberSection.cs:61
	        {                                                                                                                                  // BuildMemberSection.cs:62
	            Item item = new Item((ResourceBase) resource);                                                                                 // BuildMemberSection.cs:63
	            items.Add(item);                                                                                                               // BuildMemberSection.cs:64
	        }                                                                                                                                  // BuildMemberSection.cs:65
	        this.SetAllItems(items);                                                                                                           // BuildMemberSection.cs:66
	    }                                                                                                                                      // BuildMemberSection.cs:67
	}                                                                                                                                          // BuildMemberBase.cs:152
	//- LocalClassDefs
}
