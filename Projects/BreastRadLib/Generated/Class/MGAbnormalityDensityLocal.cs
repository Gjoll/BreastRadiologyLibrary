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

namespace BreastRadLib.MGAbnormalityDensityLocal
{
	//+ LocalClassDefs
	/// <summary>
	/// Container class for Observation.component:densityType.
	/// </summary>
	public class DensityTypeContainer : MContainer, ITMItem<Observation.ComponentComponent>                                                    // BuildMemberBase.cs:135
	{                                                                                                                                          // BuildMemberBase.cs:136
	    /// <summary>
	    /// Item class for Observation.component:densityType.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:67
	    {                                                                                                                                      // BuildMemberBase.cs:68
	        // Properties                                                                                                                      // BuildMemberBase.cs:69
	        /// <summary>
	        /// Value
	        /// </summary>
	        public CodeableConcept Value { get; set; }                                                                                         // BuildMemberBase.cs:73
	                                                                                                                                           // BuildMemberBase.cs:75
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(CodeableConcept value)                                                                                                 // BuildMemberBase.cs:79
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
	    public CodeableConcept Get()                                                                                                           // BuildMemberBase.cs:201
	    {                                                                                                                                      // BuildMemberBase.cs:202
	        if (item == null)                                                                                                                  // BuildMemberBase.cs:203
	            return null;                                                                                                                   // BuildMemberBase.cs:204
	        return item.Value;                                                                                                                 // BuildMemberBase.cs:205
	    }                                                                                                                                      // BuildMemberBase.cs:206
	                                                                                                                                           // BuildMemberBase.cs:212
	    /// <summary>
	    /// Set Item's Value
	    /// </summary>
	    public CodeableConcept Set(CodeableConcept value)                                                                                      // BuildMemberBase.cs:216
	    {                                                                                                                                      // BuildMemberBase.cs:217
	        this.item = new Item(value);                                                                                                       // BuildMemberBase.cs:218
	        return value;                                                                                                                      // BuildMemberBase.cs:219
	    }                                                                                                                                      // BuildMemberBase.cs:220
	                                                                                                                                           // BuildMemberBase.cs:141
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public DensityTypeContainer(Int32 min, Int32 max) : base("Observation.component:densityType", min, max)                                // BuildMemberBase.cs:145
	    {                                                                                                                                      // BuildMemberBase.cs:146
	    }                                                                                                                                      // BuildMemberBase.cs:148
	                                                                                                                                           // BuildMemberBase.cs:149
	    // Methods                                                                                                                             // BuildMemberBase.cs:150
	    public CodeableConcept DensityType_ComponentCode()                                                                                     // FhirConstruct.cs:753
	    {                                                                                                                                      // FhirConstruct.cs:754
	        CodeableConcept retVal = new CodeableConcept();                                                                                    // FhirConstruct.cs:755
	        retVal.Coding = new List<Coding>();                                                                                                // FhirConstruct.cs:761
	        {                                                                                                                                  // FhirConstruct.cs:764
	            var temp4 = new Coding();                                                                                                      // FhirConstruct.cs:765
	            temp4.SystemElement = new FhirUri();                                                                                           // FhirConstruct.cs:768
	            temp4.SystemElement.Value = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes";               // FhirConstruct.cs:770
	            temp4.CodeElement = new Code();                                                                                                // FhirConstruct.cs:784
	            temp4.CodeElement.Value = "mgAbnormalityDensityType";                                                                          // FhirConstruct.cs:786
	            retVal.Coding.Add(temp4);                                                                                                      // FhirConstruct.cs:813
	        }                                                                                                                                  // FhirConstruct.cs:814
	        return retVal;                                                                                                                     // FhirConstruct.cs:829
	    }                                                                                                                                      // FhirConstruct.cs:830
	                                                                                                                                           // BuildMemberBase.cs:293
	    /// <summary>
	    /// Write single item as a fhir element.
	    /// </summary>
	    public IEnumerable<Observation.ComponentComponent> Write(BreastRadiologyDocument doc)                                                  // BuildMemberComponents.cs:74
	    {                                                                                                                                      // BuildMemberComponents.cs:75
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberComponents.cs:76
	        {                                                                                                                                  // BuildMemberComponents.cs:77
	            Observation.ComponentComponent component = new Observation.ComponentComponent                                                  // BuildMemberComponents.cs:78
	            {                                                                                                                              // BuildMemberComponents.cs:79
	                Value = item.Value,                                                                                                        // BuildMemberComponents.cs:80
	                Code = DensityType_ComponentCode()                                                                                         // BuildMemberComponents.cs:81
	            };                                                                                                                             // BuildMemberComponents.cs:82
	            yield return component;                                                                                                        // BuildMemberComponents.cs:83
	        }                                                                                                                                  // BuildMemberComponents.cs:84
	    }                                                                                                                                      // BuildMemberComponents.cs:85
	                                                                                                                                           // BuildMemberBase.cs:299
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	                                                                                                                                           // BuildMemberComponents.cs:53
	    public void Read(BreastRadiologyDocument doc, IEnumerable<Observation.ComponentComponent> components)                                  // BuildMemberComponents.cs:54
	    {                                                                                                                                      // BuildMemberComponents.cs:55
	        IEnumerable<Element> elements = base.IsMember(doc,                                                                                 // BuildMemberComponents.cs:56
	            components,                                                                                                                    // BuildMemberComponents.cs:57
	            this.DensityType_ComponentCode());                                                                                             // BuildMemberComponents.cs:58
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberComponents.cs:59
	        foreach (Element element in elements)                                                                                              // BuildMemberComponents.cs:60
	            items.Add(new Item((CodeableConcept) element));                                                                                // BuildMemberComponents.cs:61
	        this.SetAllItems(items);                                                                                                           // BuildMemberComponents.cs:62
	    }                                                                                                                                      // BuildMemberComponents.cs:63
	}                                                                                                                                          // BuildMemberBase.cs:152
	//- LocalClassDefs
}
