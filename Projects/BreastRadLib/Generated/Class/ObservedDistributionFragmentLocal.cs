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

namespace BreastRadLib.ObservedDistributionFragmentLocal
{
	//+ LocalClassDefs
	#region Observation.component:obsDistribution Container Class                                                                              // BuildMemberBase.cs:174
	// Called from BuildMemberComponents.cs, Line 202
	// BuildMemberBase.cs:176
	/// <summary>
	/// Container class for Observation.component:obsDistribution.
	/// </summary>
	public class MObsDistribution : MContainer, ITMItem<Observation.ComponentComponent>                                                        // BuildMemberBase.cs:179
	{                                                                                                                                          // BuildMemberBase.cs:180
	    #region Observation.component:obsDistribution Item Class                                                                               // BuildMemberBase.cs:81
	    // Called from BuildMemberComponents.cs, Line 202
	    // BuildMemberBase.cs:83
	    /// <summary>
	    /// Item class for Observation.component:obsDistribution.
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
	                Code = ObsDistribution_ComponentCode()                                                                                     // BuildMemberComponents.cs:63
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
	    public IEnumerable<CodeableConcept> All()                                                                                              // BuildMemberBase.cs:302
	    {                                                                                                                                      // BuildMemberBase.cs:303
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:304
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:305
	    }                                                                                                                                      // BuildMemberBase.cs:306
	                                                                                                                                           // BuildMemberBase.cs:308
	    // BuildMemberBase.cs:309
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public CodeableConcept GetAt(Int32 i) => this.items[i].Value;                                                                          // BuildMemberBase.cs:312
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
	    public MObsDistribution(Int32 min, Int32 max) : base("Observation.component:obsDistribution", min, max)                                // BuildMemberBase.cs:191
	    {                                                                                                                                      // BuildMemberBase.cs:192
	    }                                                                                                                                      // BuildMemberBase.cs:194
	                                                                                                                                           // BuildMemberBase.cs:196
	    // Methods                                                                                                                             // BuildMemberBase.cs:197
	    private static CodeableConcept ObsDistribution_ComponentCode()                                                                         // FhirConstruct.cs:759
	    {                                                                                                                                      // FhirConstruct.cs:760
	        CodeableConcept retVal = new CodeableConcept();                                                                                    // FhirConstruct.cs:761
	        retVal.Coding = new List<Coding>();                                                                                                // FhirConstruct.cs:767
	        {                                                                                                                                  // FhirConstruct.cs:770
	            var temp4 = new Coding();                                                                                                      // FhirConstruct.cs:771
	            temp4.SystemElement = new FhirUri();                                                                                           // FhirConstruct.cs:774
	            temp4.SystemElement.Value = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes";               // FhirConstruct.cs:776
	            temp4.CodeElement = new Code();                                                                                                // FhirConstruct.cs:790
	            temp4.CodeElement.Value = "obsDistribution";                                                                                   // FhirConstruct.cs:792
	            retVal.Coding.Add(temp4);                                                                                                      // FhirConstruct.cs:819
	        }                                                                                                                                  // FhirConstruct.cs:820
	        return retVal;                                                                                                                     // FhirConstruct.cs:835
	    }                                                                                                                                      // FhirConstruct.cs:836
	                                                                                                                                           // BuildMemberBase.cs:333
	    // BuildMemberBase.cs:334
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public CodeableConcept Append(CodeableConcept value)                                                                                   // BuildMemberBase.cs:337
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
	            ObsDistribution_ComponentCode());                                                                                              // BuildMemberComponents.cs:77
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
	#region Observation.component:obsDistRegionSize Container Class                                                                            // BuildMemberBase.cs:174
	// Called from BuildMemberComponents.cs, Line 202
	// BuildMemberBase.cs:176
	/// <summary>
	/// Container class for Observation.component:obsDistRegionSize.
	/// </summary>
	public class MObsDistRegionSize : MContainer, ITMItem<Observation.ComponentComponent>                                                      // BuildMemberBase.cs:179
	{                                                                                                                                          // BuildMemberBase.cs:180
	    #region Observation.component:obsDistRegionSize Item Class                                                                             // BuildMemberBase.cs:81
	    // Called from BuildMemberComponents.cs, Line 202
	    // BuildMemberBase.cs:83
	    /// <summary>
	    /// Item class for Observation.component:obsDistRegionSize.
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
	                Code = ObsDistRegionSize_ComponentCode()                                                                                   // BuildMemberComponents.cs:63
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
	    public IEnumerable<Element> All()                                                                                                      // BuildMemberBase.cs:302
	    {                                                                                                                                      // BuildMemberBase.cs:303
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:304
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:305
	    }                                                                                                                                      // BuildMemberBase.cs:306
	                                                                                                                                           // BuildMemberBase.cs:308
	    // BuildMemberBase.cs:309
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public Element GetAt(Int32 i) => this.items[i].Value;                                                                                  // BuildMemberBase.cs:312
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
	    public MObsDistRegionSize(Int32 min, Int32 max) : base("Observation.component:obsDistRegionSize", min, max)                            // BuildMemberBase.cs:191
	    {                                                                                                                                      // BuildMemberBase.cs:192
	    }                                                                                                                                      // BuildMemberBase.cs:194
	                                                                                                                                           // BuildMemberBase.cs:196
	    // Methods                                                                                                                             // BuildMemberBase.cs:197
	    private static CodeableConcept ObsDistRegionSize_ComponentCode()                                                                       // FhirConstruct.cs:759
	    {                                                                                                                                      // FhirConstruct.cs:760
	        CodeableConcept retVal = new CodeableConcept();                                                                                    // FhirConstruct.cs:761
	        retVal.Coding = new List<Coding>();                                                                                                // FhirConstruct.cs:767
	        {                                                                                                                                  // FhirConstruct.cs:770
	            var temp4 = new Coding();                                                                                                      // FhirConstruct.cs:771
	            temp4.SystemElement = new FhirUri();                                                                                           // FhirConstruct.cs:774
	            temp4.SystemElement.Value = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes";               // FhirConstruct.cs:776
	            temp4.CodeElement = new Code();                                                                                                // FhirConstruct.cs:790
	            temp4.CodeElement.Value = "obsSize";                                                                                           // FhirConstruct.cs:792
	            retVal.Coding.Add(temp4);                                                                                                      // FhirConstruct.cs:819
	        }                                                                                                                                  // FhirConstruct.cs:820
	        return retVal;                                                                                                                     // FhirConstruct.cs:835
	    }                                                                                                                                      // FhirConstruct.cs:836
	                                                                                                                                           // BuildMemberBase.cs:333
	    // BuildMemberBase.cs:334
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public Quantity Append(Quantity value)                                                                                                 // BuildMemberBase.cs:337
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
	    public Range Append(Range value)                                                                                                       // BuildMemberBase.cs:337
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
	            ObsDistRegionSize_ComponentCode());                                                                                            // BuildMemberComponents.cs:77
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
