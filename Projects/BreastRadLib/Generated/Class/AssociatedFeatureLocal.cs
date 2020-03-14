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

namespace BreastRadLib.AssociatedFeatureLocal
{
	//+ LocalClassDefs
	/// <summary>
	/// Container class for Observation.component:featureType.
	/// </summary>
	public class FeatureTypeContainer : MContainer, ITMItem<Observation.ComponentComponent>                                                    // BuildMemberBase.cs:131
	{                                                                                                                                          // BuildMemberBase.cs:132
	    /// <summary>
	    /// Item class for Observation.component:featureType.
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
	    public CodeableConcept Get()                                                                                                           // BuildMemberBase.cs:197
	    {                                                                                                                                      // BuildMemberBase.cs:198
	        if (item == null)                                                                                                                  // BuildMemberBase.cs:199
	            return null;                                                                                                                   // BuildMemberBase.cs:200
	        return item.Value;                                                                                                                 // BuildMemberBase.cs:201
	    }                                                                                                                                      // BuildMemberBase.cs:202
	                                                                                                                                           // BuildMemberBase.cs:208
	    /// <summary>
	    /// Set Item's Value
	    /// </summary>
	    public CodeableConcept Set(CodeableConcept value)                                                                                      // BuildMemberBase.cs:212
	    {                                                                                                                                      // BuildMemberBase.cs:213
	        this.item = new Item(value);                                                                                                       // BuildMemberBase.cs:214
	        return value;                                                                                                                      // BuildMemberBase.cs:215
	    }                                                                                                                                      // BuildMemberBase.cs:216
	                                                                                                                                           // BuildMemberBase.cs:137
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public FeatureTypeContainer(Int32 min, Int32 max) : base("Observation.component:featureType", min, max)                                // BuildMemberBase.cs:141
	    {                                                                                                                                      // BuildMemberBase.cs:142
	    }                                                                                                                                      // BuildMemberBase.cs:144
	                                                                                                                                           // BuildMemberBase.cs:145
	    // Methods                                                                                                                             // BuildMemberBase.cs:146
	    public CodeableConcept FeatureType_ComponentCode()                                                                                     // FhirConstruct.cs:753
	    {                                                                                                                                      // FhirConstruct.cs:754
	        CodeableConcept retVal = new CodeableConcept();                                                                                    // FhirConstruct.cs:755
	        retVal.Coding = new List<Coding>();                                                                                                // FhirConstruct.cs:761
	        {                                                                                                                                  // FhirConstruct.cs:764
	            var temp4 = new Coding();                                                                                                      // FhirConstruct.cs:765
	            temp4.SystemElement = new FhirUri();                                                                                           // FhirConstruct.cs:768
	            temp4.SystemElement.Value = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes";               // FhirConstruct.cs:770
	            temp4.CodeElement = new Code();                                                                                                // FhirConstruct.cs:784
	            temp4.CodeElement.Value = "featureType";                                                                                       // FhirConstruct.cs:786
	            retVal.Coding.Add(temp4);                                                                                                      // FhirConstruct.cs:813
	        }                                                                                                                                  // FhirConstruct.cs:814
	        return retVal;                                                                                                                     // FhirConstruct.cs:829
	    }                                                                                                                                      // FhirConstruct.cs:830
	                                                                                                                                           // BuildMemberBase.cs:289
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
	                Code = FeatureType_ComponentCode()                                                                                         // BuildMemberComponents.cs:81
	            };                                                                                                                             // BuildMemberComponents.cs:82
	            yield return component;                                                                                                        // BuildMemberComponents.cs:83
	        }                                                                                                                                  // BuildMemberComponents.cs:84
	    }                                                                                                                                      // BuildMemberComponents.cs:85
	                                                                                                                                           // BuildMemberBase.cs:295
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	                                                                                                                                           // BuildMemberComponents.cs:53
	    public void Read(BreastRadiologyDocument doc, IEnumerable<Observation.ComponentComponent> components)                                  // BuildMemberComponents.cs:54
	    {                                                                                                                                      // BuildMemberComponents.cs:55
	        IEnumerable<Element> elements = base.IsMember(doc,                                                                                 // BuildMemberComponents.cs:56
	            components,                                                                                                                    // BuildMemberComponents.cs:57
	            this.FeatureType_ComponentCode());                                                                                             // BuildMemberComponents.cs:58
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberComponents.cs:59
	        foreach (Element element in elements)                                                                                              // BuildMemberComponents.cs:60
	            items.Add(new Item((CodeableConcept) element));                                                                                // BuildMemberComponents.cs:61
	        this.SetAllItems(items);                                                                                                           // BuildMemberComponents.cs:62
	    }                                                                                                                                      // BuildMemberComponents.cs:63
	}                                                                                                                                          // BuildMemberBase.cs:148
	//- LocalClassDefs
}
