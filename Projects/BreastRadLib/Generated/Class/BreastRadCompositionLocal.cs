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
	public class ReportContainer : MContainer, ITMItem<Composition.SectionComponent>                                                           // BuildMemberBase.cs:131
	{                                                                                                                                          // BuildMemberBase.cs:132
	    /// <summary>
	    /// Item class for Composition.section:report.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:63
	    {                                                                                                                                      // BuildMemberBase.cs:64
	        // Properties                                                                                                                      // BuildMemberBase.cs:65
	        /// <summary>
	        /// Value
	        /// </summary>
	        public BreastRadReport Value { get; set; }                                                                                         // BuildMemberBase.cs:69
	                                                                                                                                           // BuildMemberBase.cs:71
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(BreastRadReport value)                                                                                                 // BuildMemberBase.cs:75
	        {                                                                                                                                  // BuildMemberBase.cs:76
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:77
	        }                                                                                                                                  // BuildMemberBase.cs:79
	                                                                                                                                           // BuildMemberBase.cs:81
	        // Methods                                                                                                                         // BuildMemberBase.cs:82
	    }                                                                                                                                      // BuildMemberBase.cs:84
	                                                                                                                                           // BuildMemberBase.cs:134
	    // Properties                                                                                                                          // BuildMemberBase.cs:135
	                                                                                                                                           // BuildMemberBase.cs:158
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems()                                                                                                        // BuildMemberBase.cs:162
	    {                                                                                                                                      // BuildMemberBase.cs:163
	        if (this.item != null) yield return this.item;                                                                                     // BuildMemberBase.cs:164
	    }                                                                                                                                      // BuildMemberBase.cs:165
	                                                                                                                                           // BuildMemberBase.cs:167
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items)                                                                                              // BuildMemberBase.cs:171
	    {                                                                                                                                      // BuildMemberBase.cs:172
	        switch (items.Count())                                                                                                             // BuildMemberBase.cs:173
	        {                                                                                                                                  // BuildMemberBase.cs:174
	            case 0: break;                                                                                                                 // BuildMemberBase.cs:175
	            case 1: this.item = items.First(); break;                                                                                      // BuildMemberBase.cs:176
	            default: throw new Exception("Found multiple elements while reading single item");                                             // BuildMemberBase.cs:177
	        }                                                                                                                                  // BuildMemberBase.cs:178
	    }                                                                                                                                      // BuildMemberBase.cs:179
	                                                                                                                                           // BuildMemberBase.cs:181
	    /// <summary>
	    /// Item
	    /// </summary>
	    Item item;                                                                                                                             // BuildMemberBase.cs:185
	                                                                                                                                           // BuildMemberBase.cs:187
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => this.item == null ? 0 : 1;                                                                              // BuildMemberBase.cs:191
	                                                                                                                                           // BuildMemberBase.cs:193
	    /// <summary>
	    /// Get Item's Value
	    /// </summary>
	    public BreastRadReport Get()                                                                                                           // BuildMemberBase.cs:197
	    {                                                                                                                                      // BuildMemberBase.cs:198
	        if (item == null)                                                                                                                  // BuildMemberBase.cs:199
	            return null;                                                                                                                   // BuildMemberBase.cs:200
	        return item.Value;                                                                                                                 // BuildMemberBase.cs:201
	    }                                                                                                                                      // BuildMemberBase.cs:202
	                                                                                                                                           // BuildMemberBase.cs:208
	    /// <summary>
	    /// Set Item's Value
	    /// </summary>
	    public BreastRadReport Set(BreastRadReport value)                                                                                      // BuildMemberBase.cs:212
	    {                                                                                                                                      // BuildMemberBase.cs:213
	        this.item = new Item(value);                                                                                                       // BuildMemberBase.cs:214
	        return value;                                                                                                                      // BuildMemberBase.cs:215
	    }                                                                                                                                      // BuildMemberBase.cs:216
	                                                                                                                                           // BuildMemberBase.cs:137
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public ReportContainer(Int32 min, Int32 max) : base("Composition.section:report", min, max)                                            // BuildMemberBase.cs:141
	    {                                                                                                                                      // BuildMemberBase.cs:142
	    }                                                                                                                                      // BuildMemberBase.cs:144
	                                                                                                                                           // BuildMemberBase.cs:145
	    // Methods                                                                                                                             // BuildMemberBase.cs:146
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
	                                                                                                                                           // BuildMemberBase.cs:289
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
	                                                                                                                                           // BuildMemberBase.cs:295
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
	}                                                                                                                                          // BuildMemberBase.cs:148
	/// <summary>
	/// Container class for Composition.section:impressions.
	/// </summary>
	public class ImpressionsContainer : MContainer, ITMItem<Composition.SectionComponent>                                                      // BuildMemberBase.cs:131
	{                                                                                                                                          // BuildMemberBase.cs:132
	    /// <summary>
	    /// Item class for Composition.section:impressions.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:63
	    {                                                                                                                                      // BuildMemberBase.cs:64
	        // Properties                                                                                                                      // BuildMemberBase.cs:65
	        /// <summary>
	        /// Value
	        /// </summary>
	        public ClinicalImpressionBase Value { get; set; }                                                                                  // BuildMemberBase.cs:69
	                                                                                                                                           // BuildMemberBase.cs:71
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(ClinicalImpressionBase value)                                                                                          // BuildMemberBase.cs:75
	        {                                                                                                                                  // BuildMemberBase.cs:76
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:77
	        }                                                                                                                                  // BuildMemberBase.cs:79
	                                                                                                                                           // BuildMemberBase.cs:81
	        // Methods                                                                                                                         // BuildMemberBase.cs:82
	    }                                                                                                                                      // BuildMemberBase.cs:84
	                                                                                                                                           // BuildMemberBase.cs:134
	    // Properties                                                                                                                          // BuildMemberBase.cs:135
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:223
	                                                                                                                                           // BuildMemberBase.cs:225
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:229
	                                                                                                                                           // BuildMemberBase.cs:231
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:235
	                                                                                                                                           // BuildMemberBase.cs:237
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:241
	                                                                                                                                           // BuildMemberBase.cs:243
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<ClinicalImpressionBase> All()                                                                                       // BuildMemberBase.cs:247
	    {                                                                                                                                      // BuildMemberBase.cs:248
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:249
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:250
	    }                                                                                                                                      // BuildMemberBase.cs:251
	                                                                                                                                           // BuildMemberBase.cs:253
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public ClinicalImpressionBase GetAt(Int32 i) => this.items[i].Value;                                                                   // BuildMemberBase.cs:257
	                                                                                                                                           // BuildMemberBase.cs:259
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:263
	                                                                                                                                           // BuildMemberBase.cs:265
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:269
	                                                                                                                                           // BuildMemberBase.cs:137
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public ImpressionsContainer(Int32 min, Int32 max) : base("Composition.section:impressions", min, max)                                  // BuildMemberBase.cs:141
	    {                                                                                                                                      // BuildMemberBase.cs:142
	    }                                                                                                                                      // BuildMemberBase.cs:144
	                                                                                                                                           // BuildMemberBase.cs:145
	    // Methods                                                                                                                             // BuildMemberBase.cs:146
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
	                                                                                                                                           // BuildMemberBase.cs:275
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public ClinicalImpressionBase Append(ClinicalImpressionBase value)                                                                     // BuildMemberBase.cs:279
	    {                                                                                                                                      // BuildMemberBase.cs:280
	        this.items.Add(new Item(value));                                                                                                   // BuildMemberBase.cs:281
	        return value;                                                                                                                      // BuildMemberBase.cs:282
	    }                                                                                                                                      // BuildMemberBase.cs:283
	                                                                                                                                           // BuildMemberBase.cs:289
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
	                                                                                                                                           // BuildMemberBase.cs:295
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
	}                                                                                                                                          // BuildMemberBase.cs:148
	/// <summary>
	/// Container class for Composition.section:findingsRightBreast.
	/// </summary>
	public class FindingsRightBreastContainer : MContainer, ITMItem<Composition.SectionComponent>                                              // BuildMemberBase.cs:131
	{                                                                                                                                          // BuildMemberBase.cs:132
	    /// <summary>
	    /// Item class for Composition.section:findingsRightBreast.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:63
	    {                                                                                                                                      // BuildMemberBase.cs:64
	        // Properties                                                                                                                      // BuildMemberBase.cs:65
	        /// <summary>
	        /// Value
	        /// </summary>
	        public SectionFindingsRightBreast Value { get; set; }                                                                              // BuildMemberBase.cs:69
	                                                                                                                                           // BuildMemberBase.cs:71
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(SectionFindingsRightBreast value)                                                                                      // BuildMemberBase.cs:75
	        {                                                                                                                                  // BuildMemberBase.cs:76
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:77
	        }                                                                                                                                  // BuildMemberBase.cs:79
	                                                                                                                                           // BuildMemberBase.cs:81
	        // Methods                                                                                                                         // BuildMemberBase.cs:82
	    }                                                                                                                                      // BuildMemberBase.cs:84
	                                                                                                                                           // BuildMemberBase.cs:134
	    // Properties                                                                                                                          // BuildMemberBase.cs:135
	                                                                                                                                           // BuildMemberBase.cs:158
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems()                                                                                                        // BuildMemberBase.cs:162
	    {                                                                                                                                      // BuildMemberBase.cs:163
	        if (this.item != null) yield return this.item;                                                                                     // BuildMemberBase.cs:164
	    }                                                                                                                                      // BuildMemberBase.cs:165
	                                                                                                                                           // BuildMemberBase.cs:167
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items)                                                                                              // BuildMemberBase.cs:171
	    {                                                                                                                                      // BuildMemberBase.cs:172
	        switch (items.Count())                                                                                                             // BuildMemberBase.cs:173
	        {                                                                                                                                  // BuildMemberBase.cs:174
	            case 0: break;                                                                                                                 // BuildMemberBase.cs:175
	            case 1: this.item = items.First(); break;                                                                                      // BuildMemberBase.cs:176
	            default: throw new Exception("Found multiple elements while reading single item");                                             // BuildMemberBase.cs:177
	        }                                                                                                                                  // BuildMemberBase.cs:178
	    }                                                                                                                                      // BuildMemberBase.cs:179
	                                                                                                                                           // BuildMemberBase.cs:181
	    /// <summary>
	    /// Item
	    /// </summary>
	    Item item;                                                                                                                             // BuildMemberBase.cs:185
	                                                                                                                                           // BuildMemberBase.cs:187
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => this.item == null ? 0 : 1;                                                                              // BuildMemberBase.cs:191
	                                                                                                                                           // BuildMemberBase.cs:193
	    /// <summary>
	    /// Get Item's Value
	    /// </summary>
	    public SectionFindingsRightBreast Get()                                                                                                // BuildMemberBase.cs:197
	    {                                                                                                                                      // BuildMemberBase.cs:198
	        if (item == null)                                                                                                                  // BuildMemberBase.cs:199
	            return null;                                                                                                                   // BuildMemberBase.cs:200
	        return item.Value;                                                                                                                 // BuildMemberBase.cs:201
	    }                                                                                                                                      // BuildMemberBase.cs:202
	                                                                                                                                           // BuildMemberBase.cs:208
	    /// <summary>
	    /// Set Item's Value
	    /// </summary>
	    public SectionFindingsRightBreast Set(SectionFindingsRightBreast value)                                                                // BuildMemberBase.cs:212
	    {                                                                                                                                      // BuildMemberBase.cs:213
	        this.item = new Item(value);                                                                                                       // BuildMemberBase.cs:214
	        return value;                                                                                                                      // BuildMemberBase.cs:215
	    }                                                                                                                                      // BuildMemberBase.cs:216
	                                                                                                                                           // BuildMemberBase.cs:137
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public FindingsRightBreastContainer(Int32 min, Int32 max) : base("Composition.section:findingsRightBreast", min, max)                  // BuildMemberBase.cs:141
	    {                                                                                                                                      // BuildMemberBase.cs:142
	    }                                                                                                                                      // BuildMemberBase.cs:144
	                                                                                                                                           // BuildMemberBase.cs:145
	    // Methods                                                                                                                             // BuildMemberBase.cs:146
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
	                                                                                                                                           // BuildMemberBase.cs:289
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
	                                                                                                                                           // BuildMemberBase.cs:295
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
	}                                                                                                                                          // BuildMemberBase.cs:148
	/// <summary>
	/// Container class for Composition.section:findingsLeftBreast.
	/// </summary>
	public class FindingsLeftBreastContainer : MContainer, ITMItem<Composition.SectionComponent>                                               // BuildMemberBase.cs:131
	{                                                                                                                                          // BuildMemberBase.cs:132
	    /// <summary>
	    /// Item class for Composition.section:findingsLeftBreast.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:63
	    {                                                                                                                                      // BuildMemberBase.cs:64
	        // Properties                                                                                                                      // BuildMemberBase.cs:65
	        /// <summary>
	        /// Value
	        /// </summary>
	        public SectionFindingsLeftBreast Value { get; set; }                                                                               // BuildMemberBase.cs:69
	                                                                                                                                           // BuildMemberBase.cs:71
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(SectionFindingsLeftBreast value)                                                                                       // BuildMemberBase.cs:75
	        {                                                                                                                                  // BuildMemberBase.cs:76
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:77
	        }                                                                                                                                  // BuildMemberBase.cs:79
	                                                                                                                                           // BuildMemberBase.cs:81
	        // Methods                                                                                                                         // BuildMemberBase.cs:82
	    }                                                                                                                                      // BuildMemberBase.cs:84
	                                                                                                                                           // BuildMemberBase.cs:134
	    // Properties                                                                                                                          // BuildMemberBase.cs:135
	                                                                                                                                           // BuildMemberBase.cs:158
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems()                                                                                                        // BuildMemberBase.cs:162
	    {                                                                                                                                      // BuildMemberBase.cs:163
	        if (this.item != null) yield return this.item;                                                                                     // BuildMemberBase.cs:164
	    }                                                                                                                                      // BuildMemberBase.cs:165
	                                                                                                                                           // BuildMemberBase.cs:167
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items)                                                                                              // BuildMemberBase.cs:171
	    {                                                                                                                                      // BuildMemberBase.cs:172
	        switch (items.Count())                                                                                                             // BuildMemberBase.cs:173
	        {                                                                                                                                  // BuildMemberBase.cs:174
	            case 0: break;                                                                                                                 // BuildMemberBase.cs:175
	            case 1: this.item = items.First(); break;                                                                                      // BuildMemberBase.cs:176
	            default: throw new Exception("Found multiple elements while reading single item");                                             // BuildMemberBase.cs:177
	        }                                                                                                                                  // BuildMemberBase.cs:178
	    }                                                                                                                                      // BuildMemberBase.cs:179
	                                                                                                                                           // BuildMemberBase.cs:181
	    /// <summary>
	    /// Item
	    /// </summary>
	    Item item;                                                                                                                             // BuildMemberBase.cs:185
	                                                                                                                                           // BuildMemberBase.cs:187
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => this.item == null ? 0 : 1;                                                                              // BuildMemberBase.cs:191
	                                                                                                                                           // BuildMemberBase.cs:193
	    /// <summary>
	    /// Get Item's Value
	    /// </summary>
	    public SectionFindingsLeftBreast Get()                                                                                                 // BuildMemberBase.cs:197
	    {                                                                                                                                      // BuildMemberBase.cs:198
	        if (item == null)                                                                                                                  // BuildMemberBase.cs:199
	            return null;                                                                                                                   // BuildMemberBase.cs:200
	        return item.Value;                                                                                                                 // BuildMemberBase.cs:201
	    }                                                                                                                                      // BuildMemberBase.cs:202
	                                                                                                                                           // BuildMemberBase.cs:208
	    /// <summary>
	    /// Set Item's Value
	    /// </summary>
	    public SectionFindingsLeftBreast Set(SectionFindingsLeftBreast value)                                                                  // BuildMemberBase.cs:212
	    {                                                                                                                                      // BuildMemberBase.cs:213
	        this.item = new Item(value);                                                                                                       // BuildMemberBase.cs:214
	        return value;                                                                                                                      // BuildMemberBase.cs:215
	    }                                                                                                                                      // BuildMemberBase.cs:216
	                                                                                                                                           // BuildMemberBase.cs:137
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public FindingsLeftBreastContainer(Int32 min, Int32 max) : base("Composition.section:findingsLeftBreast", min, max)                    // BuildMemberBase.cs:141
	    {                                                                                                                                      // BuildMemberBase.cs:142
	    }                                                                                                                                      // BuildMemberBase.cs:144
	                                                                                                                                           // BuildMemberBase.cs:145
	    // Methods                                                                                                                             // BuildMemberBase.cs:146
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
	                                                                                                                                           // BuildMemberBase.cs:289
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
	                                                                                                                                           // BuildMemberBase.cs:295
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
	}                                                                                                                                          // BuildMemberBase.cs:148
	/// <summary>
	/// Container class for Composition.section:relatedResources.
	/// </summary>
	public class RelatedResourcesContainer : MContainer, ITMItem<Composition.SectionComponent>                                                 // BuildMemberBase.cs:131
	{                                                                                                                                          // BuildMemberBase.cs:132
	    /// <summary>
	    /// Item class for Composition.section:relatedResources.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:63
	    {                                                                                                                                      // BuildMemberBase.cs:64
	        // Properties                                                                                                                      // BuildMemberBase.cs:65
	        /// <summary>
	        /// Value
	        /// </summary>
	        public ResourceBase Value { get; set; }                                                                                            // BuildMemberBase.cs:69
	                                                                                                                                           // BuildMemberBase.cs:71
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(ResourceBase value)                                                                                                    // BuildMemberBase.cs:75
	        {                                                                                                                                  // BuildMemberBase.cs:76
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:77
	        }                                                                                                                                  // BuildMemberBase.cs:79
	                                                                                                                                           // BuildMemberBase.cs:81
	        // Methods                                                                                                                         // BuildMemberBase.cs:82
	    }                                                                                                                                      // BuildMemberBase.cs:84
	                                                                                                                                           // BuildMemberBase.cs:134
	    // Properties                                                                                                                          // BuildMemberBase.cs:135
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:223
	                                                                                                                                           // BuildMemberBase.cs:225
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:229
	                                                                                                                                           // BuildMemberBase.cs:231
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:235
	                                                                                                                                           // BuildMemberBase.cs:237
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:241
	                                                                                                                                           // BuildMemberBase.cs:243
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<ResourceBase> All()                                                                                                 // BuildMemberBase.cs:247
	    {                                                                                                                                      // BuildMemberBase.cs:248
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:249
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:250
	    }                                                                                                                                      // BuildMemberBase.cs:251
	                                                                                                                                           // BuildMemberBase.cs:253
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public ResourceBase GetAt(Int32 i) => this.items[i].Value;                                                                             // BuildMemberBase.cs:257
	                                                                                                                                           // BuildMemberBase.cs:259
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:263
	                                                                                                                                           // BuildMemberBase.cs:265
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:269
	                                                                                                                                           // BuildMemberBase.cs:137
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public RelatedResourcesContainer(Int32 min, Int32 max) : base("Composition.section:relatedResources", min, max)                        // BuildMemberBase.cs:141
	    {                                                                                                                                      // BuildMemberBase.cs:142
	    }                                                                                                                                      // BuildMemberBase.cs:144
	                                                                                                                                           // BuildMemberBase.cs:145
	    // Methods                                                                                                                             // BuildMemberBase.cs:146
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
	                                                                                                                                           // BuildMemberBase.cs:275
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public ResourceBase Append(ResourceBase value)                                                                                         // BuildMemberBase.cs:279
	    {                                                                                                                                      // BuildMemberBase.cs:280
	        this.items.Add(new Item(value));                                                                                                   // BuildMemberBase.cs:281
	        return value;                                                                                                                      // BuildMemberBase.cs:282
	    }                                                                                                                                      // BuildMemberBase.cs:283
	                                                                                                                                           // BuildMemberBase.cs:289
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
	                                                                                                                                           // BuildMemberBase.cs:295
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
	}                                                                                                                                          // BuildMemberBase.cs:148
	/// <summary>
	/// Container class for Composition.section:recommendations.
	/// </summary>
	public class RecommendationsContainer : MContainer, ITMItem<Composition.SectionComponent>                                                  // BuildMemberBase.cs:131
	{                                                                                                                                          // BuildMemberBase.cs:132
	    /// <summary>
	    /// Item class for Composition.section:recommendations.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:63
	    {                                                                                                                                      // BuildMemberBase.cs:64
	        // Properties                                                                                                                      // BuildMemberBase.cs:65
	        /// <summary>
	        /// Value
	        /// </summary>
	        public ResourceBase Value { get; set; }                                                                                            // BuildMemberBase.cs:69
	                                                                                                                                           // BuildMemberBase.cs:71
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(ResourceBase value)                                                                                                    // BuildMemberBase.cs:75
	        {                                                                                                                                  // BuildMemberBase.cs:76
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:77
	        }                                                                                                                                  // BuildMemberBase.cs:79
	                                                                                                                                           // BuildMemberBase.cs:81
	        // Methods                                                                                                                         // BuildMemberBase.cs:82
	    }                                                                                                                                      // BuildMemberBase.cs:84
	                                                                                                                                           // BuildMemberBase.cs:134
	    // Properties                                                                                                                          // BuildMemberBase.cs:135
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:223
	                                                                                                                                           // BuildMemberBase.cs:225
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:229
	                                                                                                                                           // BuildMemberBase.cs:231
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:235
	                                                                                                                                           // BuildMemberBase.cs:237
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:241
	                                                                                                                                           // BuildMemberBase.cs:243
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<ResourceBase> All()                                                                                                 // BuildMemberBase.cs:247
	    {                                                                                                                                      // BuildMemberBase.cs:248
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:249
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:250
	    }                                                                                                                                      // BuildMemberBase.cs:251
	                                                                                                                                           // BuildMemberBase.cs:253
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public ResourceBase GetAt(Int32 i) => this.items[i].Value;                                                                             // BuildMemberBase.cs:257
	                                                                                                                                           // BuildMemberBase.cs:259
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:263
	                                                                                                                                           // BuildMemberBase.cs:265
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:269
	                                                                                                                                           // BuildMemberBase.cs:137
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public RecommendationsContainer(Int32 min, Int32 max) : base("Composition.section:recommendations", min, max)                          // BuildMemberBase.cs:141
	    {                                                                                                                                      // BuildMemberBase.cs:142
	    }                                                                                                                                      // BuildMemberBase.cs:144
	                                                                                                                                           // BuildMemberBase.cs:145
	    // Methods                                                                                                                             // BuildMemberBase.cs:146
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
	                                                                                                                                           // BuildMemberBase.cs:275
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public MedicationRequestBase Append(MedicationRequestBase value)                                                                       // BuildMemberBase.cs:279
	    {                                                                                                                                      // BuildMemberBase.cs:280
	        this.items.Add(new Item(value));                                                                                                   // BuildMemberBase.cs:281
	        return value;                                                                                                                      // BuildMemberBase.cs:282
	    }                                                                                                                                      // BuildMemberBase.cs:283
	                                                                                                                                           // BuildMemberBase.cs:275
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public ServiceRequestBase Append(ServiceRequestBase value)                                                                             // BuildMemberBase.cs:279
	    {                                                                                                                                      // BuildMemberBase.cs:280
	        this.items.Add(new Item(value));                                                                                                   // BuildMemberBase.cs:281
	        return value;                                                                                                                      // BuildMemberBase.cs:282
	    }                                                                                                                                      // BuildMemberBase.cs:283
	                                                                                                                                           // BuildMemberBase.cs:275
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public ServiceRecommendation Append(ServiceRecommendation value)                                                                       // BuildMemberBase.cs:279
	    {                                                                                                                                      // BuildMemberBase.cs:280
	        this.items.Add(new Item(value));                                                                                                   // BuildMemberBase.cs:281
	        return value;                                                                                                                      // BuildMemberBase.cs:282
	    }                                                                                                                                      // BuildMemberBase.cs:283
	                                                                                                                                           // BuildMemberBase.cs:289
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
	                                                                                                                                           // BuildMemberBase.cs:295
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
	}                                                                                                                                          // BuildMemberBase.cs:148
	//- LocalClassDefs
}
