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
	public class DensityTypeContainer : MContainer, ITMItem<Observation.ComponentComponent>                                                    // BuildMemberBase.cs:110
	{                                                                                                                                          // BuildMemberBase.cs:111
	    /// <summary>
	    /// Item class for Observation.component:densityType.
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
	    IEnumerable<Item> GetAllItems() => new Item[] { this.item };                                                                           // BuildMemberBase.cs:141
	                                                                                                                                           // BuildMemberBase.cs:143
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items)                                                                                              // BuildMemberBase.cs:147
	    {                                                                                                                                      // BuildMemberBase.cs:148
	        switch (items.Count())                                                                                                             // BuildMemberBase.cs:149
	        {                                                                                                                                  // BuildMemberBase.cs:150
	            case 0: break;                                                                                                                 // BuildMemberBase.cs:151
	            case 1: this.item = items.First(); break;                                                                                      // BuildMemberBase.cs:152
	            default: throw new Exception("Found multiple elements while reading single item");                                             // BuildMemberBase.cs:153
	        }                                                                                                                                  // BuildMemberBase.cs:154
	    }                                                                                                                                      // BuildMemberBase.cs:155
	                                                                                                                                           // BuildMemberBase.cs:157
	    /// <summary>
	    /// Item
	    /// </summary>
	    Item item;                                                                                                                             // BuildMemberBase.cs:161
	                                                                                                                                           // BuildMemberBase.cs:163
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => this.item == null ? 0 : 1;                                                                              // BuildMemberBase.cs:167
	                                                                                                                                           // BuildMemberBase.cs:169
	    /// <summary>
	    /// Get Item's Value
	    /// </summary>
	    public CodeableConcept Get()                                                                                                           // BuildMemberBase.cs:173
	    {                                                                                                                                      // BuildMemberBase.cs:174
	        if (item == null)                                                                                                                  // BuildMemberBase.cs:175
	            return null;                                                                                                                   // BuildMemberBase.cs:176
	        return item.Value;                                                                                                                 // BuildMemberBase.cs:177
	    }                                                                                                                                      // BuildMemberBase.cs:178
	                                                                                                                                           // BuildMemberBase.cs:184
	    /// <summary>
	    /// Set Item's Value
	    /// </summary>
	    public void Set(CodeableConcept value)                                                                                                 // BuildMemberBase.cs:188
	    {                                                                                                                                      // BuildMemberBase.cs:189
	        this.item = new Item(value);                                                                                                       // BuildMemberBase.cs:190
	    }                                                                                                                                      // BuildMemberBase.cs:191
	                                                                                                                                           // BuildMemberBase.cs:116
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public DensityTypeContainer(Int32 min, Int32 max) : base("Observation.component:densityType", min, max)                                // BuildMemberBase.cs:120
	    {                                                                                                                                      // BuildMemberBase.cs:121
	    }                                                                                                                                      // BuildMemberBase.cs:123
	                                                                                                                                           // BuildMemberBase.cs:124
	    // Methods                                                                                                                             // BuildMemberBase.cs:125
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
	                                                                                                                                           // BuildMemberBase.cs:260
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
	                Code = DensityType_ComponentCode()                                                                                         // BuildMemberComponents.cs:82
	            };                                                                                                                             // BuildMemberComponents.cs:83
	            yield return component;                                                                                                        // BuildMemberComponents.cs:84
	        }                                                                                                                                  // BuildMemberComponents.cs:85
	    }                                                                                                                                      // BuildMemberComponents.cs:86
	                                                                                                                                           // BuildMemberBase.cs:266
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	                                                                                                                                           // BuildMemberComponents.cs:54
	    public void Read(BreastRadiologyDocument doc, IEnumerable<Observation.ComponentComponent> components)                                  // BuildMemberComponents.cs:55
	    {                                                                                                                                      // BuildMemberComponents.cs:56
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberComponents.cs:57
	        foreach (Observation.ComponentComponent component in components)                                                                   // BuildMemberComponents.cs:58
	        {                                                                                                                                  // BuildMemberComponents.cs:59
	            if (component.Code.IsCode(this.DensityType_ComponentCode()))                                                                   // BuildMemberComponents.cs:60
	                items.Add(new Item((CodeableConcept) component.Value));                                                                    // BuildMemberComponents.cs:61
	        }                                                                                                                                  // BuildMemberComponents.cs:62
	        this.SetAllItems(items);                                                                                                           // BuildMemberComponents.cs:63
	    }                                                                                                                                      // BuildMemberComponents.cs:64
	}                                                                                                                                          // BuildMemberBase.cs:127
	//- LocalClassDefs
}
