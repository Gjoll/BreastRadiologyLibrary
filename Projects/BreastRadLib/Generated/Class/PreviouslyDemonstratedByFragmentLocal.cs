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

namespace BreastRadLib.PreviouslyDemonstratedByFragmentLocal
{
	//+ LocalClassDefs
	/// <summary>
	/// Container class for Observation.component:PreviouslyDemonstratedBy.
	/// </summary>
	public class PreviouslyDemonstratedByContainer : MContainer, ITMItem<Observation.ComponentComponent>                                       // BuildMemberBase.cs:137
	{                                                                                                                                          // BuildMemberBase.cs:138
	    /// <summary>
	    /// Item class for Observation.component:PreviouslyDemonstratedBy.
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
	                                                                                                                                           // BuildMemberBase.cs:140
	    // Properties                                                                                                                          // BuildMemberBase.cs:141
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
	    public IEnumerable<CodeableConcept> All()                                                                                              // BuildMemberBase.cs:251
	    {                                                                                                                                      // BuildMemberBase.cs:252
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:253
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:254
	    }                                                                                                                                      // BuildMemberBase.cs:255
	                                                                                                                                           // BuildMemberBase.cs:257
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public CodeableConcept GetAt(Int32 i) => this.items[i].Value;                                                                          // BuildMemberBase.cs:261
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
	                                                                                                                                           // BuildMemberBase.cs:143
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public PreviouslyDemonstratedByContainer(Int32 min, Int32 max) : base("Observation.component:PreviouslyDemonstratedBy", min, max)      // BuildMemberBase.cs:147
	    {                                                                                                                                      // BuildMemberBase.cs:148
	    }                                                                                                                                      // BuildMemberBase.cs:150
	                                                                                                                                           // BuildMemberBase.cs:151
	    // Methods                                                                                                                             // BuildMemberBase.cs:152
	    public CodeableConcept PreviouslyDemonstratedBy_ComponentCode()                                                                        // FhirConstruct.cs:753
	    {                                                                                                                                      // FhirConstruct.cs:754
	        CodeableConcept retVal = new CodeableConcept();                                                                                    // FhirConstruct.cs:755
	        retVal.Coding = new List<Coding>();                                                                                                // FhirConstruct.cs:761
	        {                                                                                                                                  // FhirConstruct.cs:764
	            var temp4 = new Coding();                                                                                                      // FhirConstruct.cs:765
	            temp4.SystemElement = new FhirUri();                                                                                           // FhirConstruct.cs:768
	            temp4.SystemElement.Value = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes";               // FhirConstruct.cs:770
	            temp4.CodeElement = new Code();                                                                                                // FhirConstruct.cs:784
	            temp4.CodeElement.Value = "prevDemBy";                                                                                         // FhirConstruct.cs:786
	            retVal.Coding.Add(temp4);                                                                                                      // FhirConstruct.cs:813
	        }                                                                                                                                  // FhirConstruct.cs:814
	        return retVal;                                                                                                                     // FhirConstruct.cs:829
	    }                                                                                                                                      // FhirConstruct.cs:830
	                                                                                                                                           // BuildMemberBase.cs:279
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public CodeableConcept Append(CodeableConcept value)                                                                                   // BuildMemberBase.cs:283
	    {                                                                                                                                      // BuildMemberBase.cs:284
	        this.items.Add(new Item(value));                                                                                                   // BuildMemberBase.cs:285
	        return value;                                                                                                                      // BuildMemberBase.cs:286
	    }                                                                                                                                      // BuildMemberBase.cs:287
	                                                                                                                                           // BuildMemberBase.cs:293
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
	                Code = PreviouslyDemonstratedBy_ComponentCode()                                                                            // BuildMemberComponents.cs:77
	            };                                                                                                                             // BuildMemberComponents.cs:78
	            yield return component;                                                                                                        // BuildMemberComponents.cs:79
	        }                                                                                                                                  // BuildMemberComponents.cs:80
	    }                                                                                                                                      // BuildMemberComponents.cs:81
	                                                                                                                                           // BuildMemberBase.cs:299
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	                                                                                                                                           // BuildMemberComponents.cs:49
	    public void Read(BreastRadiologyDocument doc, IEnumerable<Observation.ComponentComponent> components)                                  // BuildMemberComponents.cs:50
	    {                                                                                                                                      // BuildMemberComponents.cs:51
	        IEnumerable<Element> elements = base.IsMember(doc,                                                                                 // BuildMemberComponents.cs:52
	            components,                                                                                                                    // BuildMemberComponents.cs:53
	            this.PreviouslyDemonstratedBy_ComponentCode());                                                                                // BuildMemberComponents.cs:54
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberComponents.cs:55
	        foreach (Element element in elements)                                                                                              // BuildMemberComponents.cs:56
	            items.Add(new Item((CodeableConcept) element));                                                                                // BuildMemberComponents.cs:57
	        this.SetAllItems(items);                                                                                                           // BuildMemberComponents.cs:58
	    }                                                                                                                                      // BuildMemberComponents.cs:59
	}                                                                                                                                          // BuildMemberBase.cs:154
	//- LocalClassDefs
}
