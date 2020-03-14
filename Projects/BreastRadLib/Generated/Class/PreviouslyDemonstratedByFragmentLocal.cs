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
	public class PreviouslyDemonstratedByContainer : MContainer, ITMItem<Observation.ComponentComponent>                                       // BuildMemberBase.cs:131
	{                                                                                                                                          // BuildMemberBase.cs:132
	    /// <summary>
	    /// Item class for Observation.component:PreviouslyDemonstratedBy.
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
	    public IEnumerable<CodeableConcept> All()                                                                                              // BuildMemberBase.cs:247
	    {                                                                                                                                      // BuildMemberBase.cs:248
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:249
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:250
	    }                                                                                                                                      // BuildMemberBase.cs:251
	                                                                                                                                           // BuildMemberBase.cs:253
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public CodeableConcept GetAt(Int32 i) => this.items[i].Value;                                                                          // BuildMemberBase.cs:257
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
	    public PreviouslyDemonstratedByContainer(Int32 min, Int32 max) : base("Observation.component:PreviouslyDemonstratedBy", min, max)      // BuildMemberBase.cs:141
	    {                                                                                                                                      // BuildMemberBase.cs:142
	    }                                                                                                                                      // BuildMemberBase.cs:144
	                                                                                                                                           // BuildMemberBase.cs:145
	    // Methods                                                                                                                             // BuildMemberBase.cs:146
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
	                                                                                                                                           // BuildMemberBase.cs:275
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public CodeableConcept Append(CodeableConcept value)                                                                                   // BuildMemberBase.cs:279
	    {                                                                                                                                      // BuildMemberBase.cs:280
	        this.items.Add(new Item(value));                                                                                                   // BuildMemberBase.cs:281
	        return value;                                                                                                                      // BuildMemberBase.cs:282
	    }                                                                                                                                      // BuildMemberBase.cs:283
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
	                Code = PreviouslyDemonstratedBy_ComponentCode()                                                                            // BuildMemberComponents.cs:81
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
	            this.PreviouslyDemonstratedBy_ComponentCode());                                                                                // BuildMemberComponents.cs:58
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberComponents.cs:59
	        foreach (Element element in elements)                                                                                              // BuildMemberComponents.cs:60
	            items.Add(new Item((CodeableConcept) element));                                                                                // BuildMemberComponents.cs:61
	        this.SetAllItems(items);                                                                                                           // BuildMemberComponents.cs:62
	    }                                                                                                                                      // BuildMemberComponents.cs:63
	}                                                                                                                                          // BuildMemberBase.cs:148
	//- LocalClassDefs
}
