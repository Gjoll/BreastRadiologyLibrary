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

namespace BreastRadLib.MGAbnormalityCalcificationLocal
{
	//+ LocalClassDefs
	/// <summary>
	/// Container class for Observation.component:calcificationType.
	/// </summary>
	public class CalcificationTypeContainer : MContainer, ITMItem<Observation.ComponentComponent>                                              // BuildMemberBase.cs:135
	{                                                                                                                                          // BuildMemberBase.cs:136
	    /// <summary>
	    /// Item class for Observation.component:calcificationType.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:73
	    {                                                                                                                                      // BuildMemberBase.cs:74
	        // Properties                                                                                                                      // BuildMemberBase.cs:75
	        /// <summary>
	        /// Value
	        /// </summary>
	        public CodeableConcept Value { get; set; }                                                                                         // BuildMemberBase.cs:79
	                                                                                                                                           // BuildMemberBase.cs:81
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(CodeableConcept value)                                                                                                 // BuildMemberBase.cs:85
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
	    public CodeableConcept Get()                                                                                                           // BuildMemberBase.cs:199
	    {                                                                                                                                      // BuildMemberBase.cs:200
	        if (item == null)                                                                                                                  // BuildMemberBase.cs:201
	            return null;                                                                                                                   // BuildMemberBase.cs:202
	        return item.Value;                                                                                                                 // BuildMemberBase.cs:203
	    }                                                                                                                                      // BuildMemberBase.cs:204
	                                                                                                                                           // BuildMemberBase.cs:210
	    /// <summary>
	    /// Set Item's Value
	    /// </summary>
	    public CodeableConcept Set(CodeableConcept value)                                                                                      // BuildMemberBase.cs:214
	    {                                                                                                                                      // BuildMemberBase.cs:215
	        this.item = new Item(value);                                                                                                       // BuildMemberBase.cs:216
	        return value;                                                                                                                      // BuildMemberBase.cs:217
	    }                                                                                                                                      // BuildMemberBase.cs:218
	                                                                                                                                           // BuildMemberBase.cs:141
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public CalcificationTypeContainer(Int32 min, Int32 max) : base("Observation.component:calcificationType", min, max)                    // BuildMemberBase.cs:145
	    {                                                                                                                                      // BuildMemberBase.cs:146
	    }                                                                                                                                      // BuildMemberBase.cs:148
	                                                                                                                                           // BuildMemberBase.cs:149
	    // Methods                                                                                                                             // BuildMemberBase.cs:150
	    public CodeableConcept CalcificationType_ComponentCode()                                                                               // FhirConstruct.cs:753
	    {                                                                                                                                      // FhirConstruct.cs:754
	        CodeableConcept retVal = new CodeableConcept();                                                                                    // FhirConstruct.cs:755
	        retVal.Coding = new List<Coding>();                                                                                                // FhirConstruct.cs:761
	        {                                                                                                                                  // FhirConstruct.cs:764
	            var temp4 = new Coding();                                                                                                      // FhirConstruct.cs:765
	            temp4.SystemElement = new FhirUri();                                                                                           // FhirConstruct.cs:768
	            temp4.SystemElement.Value = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes";               // FhirConstruct.cs:770
	            temp4.CodeElement = new Code();                                                                                                // FhirConstruct.cs:784
	            temp4.CodeElement.Value = "mgCalcificationType";                                                                               // FhirConstruct.cs:786
	            retVal.Coding.Add(temp4);                                                                                                      // FhirConstruct.cs:813
	        }                                                                                                                                  // FhirConstruct.cs:814
	        return retVal;                                                                                                                     // FhirConstruct.cs:829
	    }                                                                                                                                      // FhirConstruct.cs:830
	                                                                                                                                           // BuildMemberBase.cs:291
	    /// <summary>
	    /// Write single item as a fhir element.
	    /// </summary>
	    public IEnumerable<Observation.ComponentComponent> Write(BreastRadiologyDocument doc)                                                  // BuildMemberComponents.cs:70
	    {                                                                                                                                      // BuildMemberComponents.cs:71
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberComponents.cs:72
	        {                                                                                                                                  // BuildMemberComponents.cs:73
	            Observation.ComponentComponent component = new Observation.ComponentComponent                                                  // BuildMemberComponents.cs:74
	            {                                                                                                                              // BuildMemberComponents.cs:75
	                Value = item.Value,                                                                                                        // BuildMemberComponents.cs:76
	                Code = CalcificationType_ComponentCode()                                                                                   // BuildMemberComponents.cs:77
	            };                                                                                                                             // BuildMemberComponents.cs:78
	            yield return component;                                                                                                        // BuildMemberComponents.cs:79
	        }                                                                                                                                  // BuildMemberComponents.cs:80
	    }                                                                                                                                      // BuildMemberComponents.cs:81
	                                                                                                                                           // BuildMemberBase.cs:297
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	                                                                                                                                           // BuildMemberComponents.cs:49
	    public void Read(BreastRadiologyDocument doc, IEnumerable<Observation.ComponentComponent> components)                                  // BuildMemberComponents.cs:50
	    {                                                                                                                                      // BuildMemberComponents.cs:51
	        IEnumerable<Element> elements = base.IsMember(doc,                                                                                 // BuildMemberComponents.cs:52
	            components,                                                                                                                    // BuildMemberComponents.cs:53
	            this.CalcificationType_ComponentCode());                                                                                       // BuildMemberComponents.cs:54
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberComponents.cs:55
	        foreach (Element element in elements)                                                                                              // BuildMemberComponents.cs:56
	            items.Add(new Item((CodeableConcept) element));                                                                                // BuildMemberComponents.cs:57
	        this.SetAllItems(items);                                                                                                           // BuildMemberComponents.cs:58
	    }                                                                                                                                      // BuildMemberComponents.cs:59
	}                                                                                                                                          // BuildMemberBase.cs:152
	/// <summary>
	/// Container class for Observation.component:calcificationDistribution.
	/// </summary>
	public class CalcificationDistributionContainer : MContainer, ITMItem<Observation.ComponentComponent>                                      // BuildMemberBase.cs:135
	{                                                                                                                                          // BuildMemberBase.cs:136
	    /// <summary>
	    /// Item class for Observation.component:calcificationDistribution.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:73
	    {                                                                                                                                      // BuildMemberBase.cs:74
	        // Properties                                                                                                                      // BuildMemberBase.cs:75
	        /// <summary>
	        /// Value
	        /// </summary>
	        public CodeableConcept Value { get; set; }                                                                                         // BuildMemberBase.cs:79
	                                                                                                                                           // BuildMemberBase.cs:81
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(CodeableConcept value)                                                                                                 // BuildMemberBase.cs:85
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
	    public CodeableConcept Get()                                                                                                           // BuildMemberBase.cs:199
	    {                                                                                                                                      // BuildMemberBase.cs:200
	        if (item == null)                                                                                                                  // BuildMemberBase.cs:201
	            return null;                                                                                                                   // BuildMemberBase.cs:202
	        return item.Value;                                                                                                                 // BuildMemberBase.cs:203
	    }                                                                                                                                      // BuildMemberBase.cs:204
	                                                                                                                                           // BuildMemberBase.cs:210
	    /// <summary>
	    /// Set Item's Value
	    /// </summary>
	    public CodeableConcept Set(CodeableConcept value)                                                                                      // BuildMemberBase.cs:214
	    {                                                                                                                                      // BuildMemberBase.cs:215
	        this.item = new Item(value);                                                                                                       // BuildMemberBase.cs:216
	        return value;                                                                                                                      // BuildMemberBase.cs:217
	    }                                                                                                                                      // BuildMemberBase.cs:218
	                                                                                                                                           // BuildMemberBase.cs:141
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public CalcificationDistributionContainer(Int32 min, Int32 max) : base("Observation.component:calcificationDistribution", min, max)    // BuildMemberBase.cs:145
	    {                                                                                                                                      // BuildMemberBase.cs:146
	    }                                                                                                                                      // BuildMemberBase.cs:148
	                                                                                                                                           // BuildMemberBase.cs:149
	    // Methods                                                                                                                             // BuildMemberBase.cs:150
	    public CodeableConcept CalcificationDistribution_ComponentCode()                                                                       // FhirConstruct.cs:753
	    {                                                                                                                                      // FhirConstruct.cs:754
	        CodeableConcept retVal = new CodeableConcept();                                                                                    // FhirConstruct.cs:755
	        retVal.Coding = new List<Coding>();                                                                                                // FhirConstruct.cs:761
	        {                                                                                                                                  // FhirConstruct.cs:764
	            var temp4 = new Coding();                                                                                                      // FhirConstruct.cs:765
	            temp4.SystemElement = new FhirUri();                                                                                           // FhirConstruct.cs:768
	            temp4.SystemElement.Value = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes";               // FhirConstruct.cs:770
	            temp4.CodeElement = new Code();                                                                                                // FhirConstruct.cs:784
	            temp4.CodeElement.Value = "mgCalcificationDistribution";                                                                       // FhirConstruct.cs:786
	            retVal.Coding.Add(temp4);                                                                                                      // FhirConstruct.cs:813
	        }                                                                                                                                  // FhirConstruct.cs:814
	        return retVal;                                                                                                                     // FhirConstruct.cs:829
	    }                                                                                                                                      // FhirConstruct.cs:830
	                                                                                                                                           // BuildMemberBase.cs:291
	    /// <summary>
	    /// Write single item as a fhir element.
	    /// </summary>
	    public IEnumerable<Observation.ComponentComponent> Write(BreastRadiologyDocument doc)                                                  // BuildMemberComponents.cs:70
	    {                                                                                                                                      // BuildMemberComponents.cs:71
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberComponents.cs:72
	        {                                                                                                                                  // BuildMemberComponents.cs:73
	            Observation.ComponentComponent component = new Observation.ComponentComponent                                                  // BuildMemberComponents.cs:74
	            {                                                                                                                              // BuildMemberComponents.cs:75
	                Value = item.Value,                                                                                                        // BuildMemberComponents.cs:76
	                Code = CalcificationDistribution_ComponentCode()                                                                           // BuildMemberComponents.cs:77
	            };                                                                                                                             // BuildMemberComponents.cs:78
	            yield return component;                                                                                                        // BuildMemberComponents.cs:79
	        }                                                                                                                                  // BuildMemberComponents.cs:80
	    }                                                                                                                                      // BuildMemberComponents.cs:81
	                                                                                                                                           // BuildMemberBase.cs:297
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	                                                                                                                                           // BuildMemberComponents.cs:49
	    public void Read(BreastRadiologyDocument doc, IEnumerable<Observation.ComponentComponent> components)                                  // BuildMemberComponents.cs:50
	    {                                                                                                                                      // BuildMemberComponents.cs:51
	        IEnumerable<Element> elements = base.IsMember(doc,                                                                                 // BuildMemberComponents.cs:52
	            components,                                                                                                                    // BuildMemberComponents.cs:53
	            this.CalcificationDistribution_ComponentCode());                                                                               // BuildMemberComponents.cs:54
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberComponents.cs:55
	        foreach (Element element in elements)                                                                                              // BuildMemberComponents.cs:56
	            items.Add(new Item((CodeableConcept) element));                                                                                // BuildMemberComponents.cs:57
	        this.SetAllItems(items);                                                                                                           // BuildMemberComponents.cs:58
	    }                                                                                                                                      // BuildMemberComponents.cs:59
	}                                                                                                                                          // BuildMemberBase.cs:152
	//- LocalClassDefs
}
