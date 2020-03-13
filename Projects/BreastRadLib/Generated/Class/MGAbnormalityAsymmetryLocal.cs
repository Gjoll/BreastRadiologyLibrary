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

namespace BreastRadLib.MGAbnormalityAsymmetryLocal
{
	//+ LocalClassDefs
	/// <summary>
	/// Container class for Observation.component.
	/// </summary>
	public class AsymmetryTypeContainer : MContainer, ITMItem<Observation.ComponentComponent>                                                  // BuildMemberBase.cs:111
	{                                                                                                                                          // BuildMemberBase.cs:112
	    /// <summary>
	    /// Item class for Observation.component.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:63
	    {                                                                                                                                      // BuildMemberBase.cs:64
	        // Properties                                                                                                                      // BuildMemberBase.cs:65
	        /// <summary>
	        /// Value
	        /// </summary>
	        public CodeableConcept Value { get; set; }                                                                                         // BuildMemberBase.cs:69
	                                                                                                                                           // BuildMemberBase.cs:71
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(CodeableConcept value)                                                                                                 // BuildMemberBase.cs:75
	        {                                                                                                                                  // BuildMemberBase.cs:76
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:77
	        }                                                                                                                                  // BuildMemberBase.cs:79
	                                                                                                                                           // BuildMemberBase.cs:81
	        // Methods                                                                                                                         // BuildMemberBase.cs:82
	    }                                                                                                                                      // BuildMemberBase.cs:84
	                                                                                                                                           // BuildMemberBase.cs:114
	    // Properties                                                                                                                          // BuildMemberBase.cs:115
	                                                                                                                                           // BuildMemberBase.cs:138
	    /// <summary>
	    /// All Items
	    /// </summary>
	    IEnumerable<Item> AllItems => new Item[] { this.item };                                                                                // BuildMemberBase.cs:142
	                                                                                                                                           // BuildMemberBase.cs:144
	    /// <summary>
	    /// Item
	    /// </summary>
	    Item item;                                                                                                                             // BuildMemberBase.cs:148
	                                                                                                                                           // BuildMemberBase.cs:150
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => this.item == null ? 0 : 1;                                                                              // BuildMemberBase.cs:154
	                                                                                                                                           // BuildMemberBase.cs:156
	    /// <summary>
	    /// Get Item's Value
	    /// </summary>
	    public CodeableConcept Get()                                                                                                           // BuildMemberBase.cs:160
	    {                                                                                                                                      // BuildMemberBase.cs:161
	        if (item == null)                                                                                                                  // BuildMemberBase.cs:162
	            return null;                                                                                                                   // BuildMemberBase.cs:163
	        return item.Value;                                                                                                                 // BuildMemberBase.cs:164
	    }                                                                                                                                      // BuildMemberBase.cs:165
	                                                                                                                                           // BuildMemberBase.cs:171
	    /// <summary>
	    /// Set Item's Value
	    /// </summary>
	    public void Set(CodeableConcept value)                                                                                                 // BuildMemberBase.cs:175
	    {                                                                                                                                      // BuildMemberBase.cs:176
	        this.item = new Item(value);                                                                                                       // BuildMemberBase.cs:177
	    }                                                                                                                                      // BuildMemberBase.cs:178
	                                                                                                                                           // BuildMemberBase.cs:117
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public AsymmetryTypeContainer(Int32 min, Int32 max) : base("Observation.component", min, max)                                          // BuildMemberBase.cs:121
	    {                                                                                                                                      // BuildMemberBase.cs:122
	    }                                                                                                                                      // BuildMemberBase.cs:124
	                                                                                                                                           // BuildMemberBase.cs:125
	    // Methods                                                                                                                             // BuildMemberBase.cs:126
	    public CodeableConcept AsymmetryType_ComponentCode()                                                                                   // FhirConstruct.cs:753
	    {                                                                                                                                      // FhirConstruct.cs:754
	        CodeableConcept retVal = new CodeableConcept();                                                                                    // FhirConstruct.cs:755
	        retVal.Coding = new List<Coding>();                                                                                                // FhirConstruct.cs:761
	        {                                                                                                                                  // FhirConstruct.cs:764
	            var temp4 = new Coding();                                                                                                      // FhirConstruct.cs:765
	            temp4.SystemElement = new FhirUri();                                                                                           // FhirConstruct.cs:768
	            temp4.SystemElement.Value = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes";               // FhirConstruct.cs:770
	            temp4.CodeElement = new Code();                                                                                                // FhirConstruct.cs:784
	            temp4.CodeElement.Value = "mgAbnormalityAsymmetryType";                                                                        // FhirConstruct.cs:786
	            retVal.Coding.Add(temp4);                                                                                                      // FhirConstruct.cs:813
	        }                                                                                                                                  // FhirConstruct.cs:814
	        return retVal;                                                                                                                     // FhirConstruct.cs:829
	    }                                                                                                                                      // FhirConstruct.cs:830
	                                                                                                                                           // BuildMemberBase.cs:241
	    /// <summary>
	    /// Write single item as a fhir element.
	    /// </summary>
	    public Observation.ComponentComponent WriteItem(BreastRadiologyDocument doc, Item item)                                                // BuildMemberBase.cs:245
	    {                                                                                                                                      // BuildMemberBase.cs:246
	        return new Observation.ComponentComponent                                                                                          // BuildMemberBase.cs:247
	        {                                                                                                                                  // BuildMemberBase.cs:248
	            Value = item.Value,                                                                                                            // BuildMemberComponents.cs:61
	            Code = AsymmetryType_ComponentCode()                                                                                           // BuildMemberComponents.cs:62
	        };                                                                                                                                 // BuildMemberBase.cs:250
	    }                                                                                                                                      // BuildMemberBase.cs:251
	                                                                                                                                           // BuildMemberBase.cs:253
	    /// <summary>
	    /// Write out member item as a fhir element.
	    /// </summary>
	    public IEnumerable<Observation.ComponentComponent> Write(BreastRadiologyDocument doc)                                                  // BuildMemberBase.cs:257
	    {                                                                                                                                      // BuildMemberBase.cs:258
	        foreach (Item item in this.AllItems)                                                                                               // BuildMemberBase.cs:259
	            yield return WriteItem(doc, item);                                                                                             // BuildMemberBase.cs:260
	    }                                                                                                                                      // BuildMemberBase.cs:261
	                                                                                                                                           // BuildMemberBase.cs:263
	    /// <summary>
	    /// Read single item as a fhir element.
	    /// </summary>
	    public Item ReadItem(BreastRadiologyDocument doc, Observation.ComponentComponent element)                                              // BuildMemberBase.cs:267
	    {                                                                                                                                      // BuildMemberBase.cs:268
	        Item item = null;                                                                                                                  // BuildMemberComponents.cs:51
	        if (element.Code.IsCode(this.AsymmetryType_ComponentCode()))                                                                       // BuildMemberComponents.cs:52
	            item = new Item((CodeableConcept) element.Value);                                                                              // BuildMemberComponents.cs:53
	        return item;                                                                                                                       // BuildMemberComponents.cs:54
	    }                                                                                                                                      // BuildMemberBase.cs:270
	                                                                                                                                           // BuildMemberBase.cs:272
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	    public void Read(BreastRadiologyDocument doc, IEnumerable<Observation.ComponentComponent> elements)                                    // BuildMemberBase.cs:276
	    {                                                                                                                                      // BuildMemberBase.cs:277
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberBase.cs:278
	        foreach (Observation.ComponentComponent element in elements)                                                                       // BuildMemberBase.cs:279
	        {                                                                                                                                  // BuildMemberBase.cs:280
	            Item item = ReadItem(doc, element);                                                                                            // BuildMemberBase.cs:281
	            if (item != null)                                                                                                              // BuildMemberBase.cs:282
	               items.Add(item);                                                                                                            // BuildMemberBase.cs:283
	        }                                                                                                                                  // BuildMemberBase.cs:284
	        switch (items.Count)                                                                                                               // BuildMemberBase.cs:289
	        {                                                                                                                                  // BuildMemberBase.cs:290
	            case 0:                                                                                                                        // BuildMemberBase.cs:291
	                break;                                                                                                                     // BuildMemberBase.cs:292
	            case 1:                                                                                                                        // BuildMemberBase.cs:293
	                this.item = items[0];                                                                                                      // BuildMemberBase.cs:294
	                break;                                                                                                                     // BuildMemberBase.cs:295
	            default:                                                                                                                       // BuildMemberBase.cs:296
	                throw new Exception("error reading component Observation.ComponentComponent. Multiple items found. Expected single element");// BuildMemberBase.cs:297
	        }                                                                                                                                  // BuildMemberBase.cs:298
	    }                                                                                                                                      // BuildMemberBase.cs:310
	}                                                                                                                                          // BuildMemberBase.cs:128
	//- LocalClassDefs
}
