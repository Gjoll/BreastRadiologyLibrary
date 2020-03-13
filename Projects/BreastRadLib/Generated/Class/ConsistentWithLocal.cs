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
	/// <summary>
	/// Container class for Observation.component:value.
	/// </summary>
	public class ValueContainer : MContainer, ITMItem<Observation.ComponentComponent>                                                          // BuildMemberBase.cs:110
	{                                                                                                                                          // BuildMemberBase.cs:111
	    /// <summary>
	    /// Item class for Observation.component:value.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:62
	    {                                                                                                                                      // BuildMemberBase.cs:63
	        // Properties                                                                                                                      // BuildMemberBase.cs:64
	        /// <summary>
	        /// Value
	        /// </summary>
	        public CodeableConcept Value { get; set; }                                                                                         // BuildMemberBase.cs:68
	                                                                                                                                           // BuildMemberBase.cs:70
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(CodeableConcept value)                                                                                                 // BuildMemberBase.cs:74
	        {                                                                                                                                  // BuildMemberBase.cs:75
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:76
	        }                                                                                                                                  // BuildMemberBase.cs:78
	                                                                                                                                           // BuildMemberBase.cs:80
	        // Methods                                                                                                                         // BuildMemberBase.cs:81
	    }                                                                                                                                      // BuildMemberBase.cs:83
	                                                                                                                                           // BuildMemberBase.cs:113
	    // Properties                                                                                                                          // BuildMemberBase.cs:114
	                                                                                                                                           // BuildMemberBase.cs:137
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems()                                                                                                        // BuildMemberBase.cs:141
	    {                                                                                                                                      // BuildMemberBase.cs:142
	        if (this.item != null) yield return this.item;                                                                                     // BuildMemberBase.cs:143
	    }                                                                                                                                      // BuildMemberBase.cs:144
	                                                                                                                                           // BuildMemberBase.cs:146
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items)                                                                                              // BuildMemberBase.cs:150
	    {                                                                                                                                      // BuildMemberBase.cs:151
	        switch (items.Count())                                                                                                             // BuildMemberBase.cs:152
	        {                                                                                                                                  // BuildMemberBase.cs:153
	            case 0: break;                                                                                                                 // BuildMemberBase.cs:154
	            case 1: this.item = items.First(); break;                                                                                      // BuildMemberBase.cs:155
	            default: throw new Exception("Found multiple elements while reading single item");                                             // BuildMemberBase.cs:156
	        }                                                                                                                                  // BuildMemberBase.cs:157
	    }                                                                                                                                      // BuildMemberBase.cs:158
	                                                                                                                                           // BuildMemberBase.cs:160
	    /// <summary>
	    /// Item
	    /// </summary>
	    Item item;                                                                                                                             // BuildMemberBase.cs:164
	                                                                                                                                           // BuildMemberBase.cs:166
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => this.item == null ? 0 : 1;                                                                              // BuildMemberBase.cs:170
	                                                                                                                                           // BuildMemberBase.cs:172
	    /// <summary>
	    /// Get Item's Value
	    /// </summary>
	    public CodeableConcept Get()                                                                                                           // BuildMemberBase.cs:176
	    {                                                                                                                                      // BuildMemberBase.cs:177
	        if (item == null)                                                                                                                  // BuildMemberBase.cs:178
	            return null;                                                                                                                   // BuildMemberBase.cs:179
	        return item.Value;                                                                                                                 // BuildMemberBase.cs:180
	    }                                                                                                                                      // BuildMemberBase.cs:181
	                                                                                                                                           // BuildMemberBase.cs:187
	    /// <summary>
	    /// Set Item's Value
	    /// </summary>
	    public CodeableConcept Set(CodeableConcept value)                                                                                      // BuildMemberBase.cs:191
	    {                                                                                                                                      // BuildMemberBase.cs:192
	        this.item = new Item(value);                                                                                                       // BuildMemberBase.cs:193
	        return value;                                                                                                                      // BuildMemberBase.cs:194
	    }                                                                                                                                      // BuildMemberBase.cs:195
	                                                                                                                                           // BuildMemberBase.cs:116
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public ValueContainer(Int32 min, Int32 max) : base("Observation.component:value", min, max)                                            // BuildMemberBase.cs:120
	    {                                                                                                                                      // BuildMemberBase.cs:121
	    }                                                                                                                                      // BuildMemberBase.cs:123
	                                                                                                                                           // BuildMemberBase.cs:124
	    // Methods                                                                                                                             // BuildMemberBase.cs:125
	    public CodeableConcept Value_ComponentCode()                                                                                           // FhirConstruct.cs:753
	    {                                                                                                                                      // FhirConstruct.cs:754
	        CodeableConcept retVal = new CodeableConcept();                                                                                    // FhirConstruct.cs:755
	        retVal.Coding = new List<Coding>();                                                                                                // FhirConstruct.cs:761
	        {                                                                                                                                  // FhirConstruct.cs:764
	            var temp4 = new Coding();                                                                                                      // FhirConstruct.cs:765
	            temp4.SystemElement = new FhirUri();                                                                                           // FhirConstruct.cs:768
	            temp4.SystemElement.Value = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes";               // FhirConstruct.cs:770
	            temp4.CodeElement = new Code();                                                                                                // FhirConstruct.cs:784
	            temp4.CodeElement.Value = "consistentWithValue";                                                                               // FhirConstruct.cs:786
	            retVal.Coding.Add(temp4);                                                                                                      // FhirConstruct.cs:813
	        }                                                                                                                                  // FhirConstruct.cs:814
	        return retVal;                                                                                                                     // FhirConstruct.cs:829
	    }                                                                                                                                      // FhirConstruct.cs:830
	                                                                                                                                           // BuildMemberBase.cs:268
	    /// <summary>
	    /// Write single item as a fhir element.
	    /// </summary>
	    public IEnumerable<Observation.ComponentComponent> Write(BreastRadiologyDocument doc)                                                  // BuildMemberComponents.cs:75
	    {                                                                                                                                      // BuildMemberComponents.cs:76
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberComponents.cs:77
	        {                                                                                                                                  // BuildMemberComponents.cs:78
	            Observation.ComponentComponent component = new Observation.ComponentComponent                                                  // BuildMemberComponents.cs:79
	            {                                                                                                                              // BuildMemberComponents.cs:80
	                Value = item.Value,                                                                                                        // BuildMemberComponents.cs:81
	                Code = Value_ComponentCode()                                                                                               // BuildMemberComponents.cs:82
	            };                                                                                                                             // BuildMemberComponents.cs:83
	            yield return component;                                                                                                        // BuildMemberComponents.cs:84
	        }                                                                                                                                  // BuildMemberComponents.cs:85
	    }                                                                                                                                      // BuildMemberComponents.cs:86
	                                                                                                                                           // BuildMemberBase.cs:274
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	                                                                                                                                           // BuildMemberComponents.cs:54
	    public void Read(BreastRadiologyDocument doc, IEnumerable<Observation.ComponentComponent> components)                                  // BuildMemberComponents.cs:55
	    {                                                                                                                                      // BuildMemberComponents.cs:56
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberComponents.cs:57
	        foreach (Observation.ComponentComponent component in components)                                                                   // BuildMemberComponents.cs:58
	        {                                                                                                                                  // BuildMemberComponents.cs:59
	            if (component.Code.IsCode(this.Value_ComponentCode()))                                                                         // BuildMemberComponents.cs:60
	                items.Add(new Item((CodeableConcept) component.Value));                                                                    // BuildMemberComponents.cs:61
	        }                                                                                                                                  // BuildMemberComponents.cs:62
	        this.SetAllItems(items);                                                                                                           // BuildMemberComponents.cs:63
	    }                                                                                                                                      // BuildMemberComponents.cs:64
	}                                                                                                                                          // BuildMemberBase.cs:127
	/// <summary>
	/// Container class for Observation.component:qualifier.
	/// </summary>
	public class QualifierContainer : MContainer, ITMItem<Observation.ComponentComponent>                                                      // BuildMemberBase.cs:110
	{                                                                                                                                          // BuildMemberBase.cs:111
	    /// <summary>
	    /// Item class for Observation.component:qualifier.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:62
	    {                                                                                                                                      // BuildMemberBase.cs:63
	        // Properties                                                                                                                      // BuildMemberBase.cs:64
	        /// <summary>
	        /// Value
	        /// </summary>
	        public CodeableConcept Value { get; set; }                                                                                         // BuildMemberBase.cs:68
	                                                                                                                                           // BuildMemberBase.cs:70
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(CodeableConcept value)                                                                                                 // BuildMemberBase.cs:74
	        {                                                                                                                                  // BuildMemberBase.cs:75
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:76
	        }                                                                                                                                  // BuildMemberBase.cs:78
	                                                                                                                                           // BuildMemberBase.cs:80
	        // Methods                                                                                                                         // BuildMemberBase.cs:81
	    }                                                                                                                                      // BuildMemberBase.cs:83
	                                                                                                                                           // BuildMemberBase.cs:113
	    // Properties                                                                                                                          // BuildMemberBase.cs:114
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:202
	                                                                                                                                           // BuildMemberBase.cs:204
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:208
	                                                                                                                                           // BuildMemberBase.cs:210
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:214
	                                                                                                                                           // BuildMemberBase.cs:216
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:220
	                                                                                                                                           // BuildMemberBase.cs:222
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<CodeableConcept> All()                                                                                              // BuildMemberBase.cs:226
	    {                                                                                                                                      // BuildMemberBase.cs:227
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:228
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:229
	    }                                                                                                                                      // BuildMemberBase.cs:230
	                                                                                                                                           // BuildMemberBase.cs:232
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public CodeableConcept GetAt(Int32 i) => this.items[i].Value;                                                                          // BuildMemberBase.cs:236
	                                                                                                                                           // BuildMemberBase.cs:238
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:242
	                                                                                                                                           // BuildMemberBase.cs:244
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:248
	                                                                                                                                           // BuildMemberBase.cs:116
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public QualifierContainer(Int32 min, Int32 max) : base("Observation.component:qualifier", min, max)                                    // BuildMemberBase.cs:120
	    {                                                                                                                                      // BuildMemberBase.cs:121
	    }                                                                                                                                      // BuildMemberBase.cs:123
	                                                                                                                                           // BuildMemberBase.cs:124
	    // Methods                                                                                                                             // BuildMemberBase.cs:125
	    public CodeableConcept Qualifier_ComponentCode()                                                                                       // FhirConstruct.cs:753
	    {                                                                                                                                      // FhirConstruct.cs:754
	        CodeableConcept retVal = new CodeableConcept();                                                                                    // FhirConstruct.cs:755
	        retVal.Coding = new List<Coding>();                                                                                                // FhirConstruct.cs:761
	        {                                                                                                                                  // FhirConstruct.cs:764
	            var temp4 = new Coding();                                                                                                      // FhirConstruct.cs:765
	            temp4.SystemElement = new FhirUri();                                                                                           // FhirConstruct.cs:768
	            temp4.SystemElement.Value = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes";               // FhirConstruct.cs:770
	            temp4.CodeElement = new Code();                                                                                                // FhirConstruct.cs:784
	            temp4.CodeElement.Value = "consistentWithQualifier";                                                                           // FhirConstruct.cs:786
	            retVal.Coding.Add(temp4);                                                                                                      // FhirConstruct.cs:813
	        }                                                                                                                                  // FhirConstruct.cs:814
	        return retVal;                                                                                                                     // FhirConstruct.cs:829
	    }                                                                                                                                      // FhirConstruct.cs:830
	                                                                                                                                           // BuildMemberBase.cs:254
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public CodeableConcept Append(CodeableConcept value)                                                                                   // BuildMemberBase.cs:258
	    {                                                                                                                                      // BuildMemberBase.cs:259
	        this.items.Add(new Item(value));                                                                                                   // BuildMemberBase.cs:260
	        return value;                                                                                                                      // BuildMemberBase.cs:261
	    }                                                                                                                                      // BuildMemberBase.cs:262
	                                                                                                                                           // BuildMemberBase.cs:268
	    /// <summary>
	    /// Write single item as a fhir element.
	    /// </summary>
	    public IEnumerable<Observation.ComponentComponent> Write(BreastRadiologyDocument doc)                                                  // BuildMemberComponents.cs:75
	    {                                                                                                                                      // BuildMemberComponents.cs:76
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberComponents.cs:77
	        {                                                                                                                                  // BuildMemberComponents.cs:78
	            Observation.ComponentComponent component = new Observation.ComponentComponent                                                  // BuildMemberComponents.cs:79
	            {                                                                                                                              // BuildMemberComponents.cs:80
	                Value = item.Value,                                                                                                        // BuildMemberComponents.cs:81
	                Code = Qualifier_ComponentCode()                                                                                           // BuildMemberComponents.cs:82
	            };                                                                                                                             // BuildMemberComponents.cs:83
	            yield return component;                                                                                                        // BuildMemberComponents.cs:84
	        }                                                                                                                                  // BuildMemberComponents.cs:85
	    }                                                                                                                                      // BuildMemberComponents.cs:86
	                                                                                                                                           // BuildMemberBase.cs:274
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	                                                                                                                                           // BuildMemberComponents.cs:54
	    public void Read(BreastRadiologyDocument doc, IEnumerable<Observation.ComponentComponent> components)                                  // BuildMemberComponents.cs:55
	    {                                                                                                                                      // BuildMemberComponents.cs:56
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberComponents.cs:57
	        foreach (Observation.ComponentComponent component in components)                                                                   // BuildMemberComponents.cs:58
	        {                                                                                                                                  // BuildMemberComponents.cs:59
	            if (component.Code.IsCode(this.Qualifier_ComponentCode()))                                                                     // BuildMemberComponents.cs:60
	                items.Add(new Item((CodeableConcept) component.Value));                                                                    // BuildMemberComponents.cs:61
	        }                                                                                                                                  // BuildMemberComponents.cs:62
	        this.SetAllItems(items);                                                                                                           // BuildMemberComponents.cs:63
	    }                                                                                                                                      // BuildMemberComponents.cs:64
	}                                                                                                                                          // BuildMemberBase.cs:127
	//- LocalClassDefs
}
