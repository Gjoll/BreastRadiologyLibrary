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

namespace BreastRadLib.ObservedChangesFragmentLocal
{
	//+ LocalClassDefs
	#region Observation.component:obsChanges Container Class                                                                                   // BuildMemberBase.cs:137
	/// <summary>
	/// Container class for Observation.component:obsChanges.
	/// </summary>
	public class ObsChangesContainer : MContainer, ITMItem<Observation.ComponentComponent>                                                     // BuildMemberBase.cs:141
	{                                                                                                                                          // BuildMemberBase.cs:142
	    #region Observation.component:obsChanges Item Class                                                                                    // BuildMemberBase.cs:73
	    /// <summary>
	    /// Item class for Observation.component:obsChanges.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:77
	    {                                                                                                                                      // BuildMemberBase.cs:78
	        // Properties                                                                                                                      // BuildMemberBase.cs:79
	        /// <summary>
	        /// Value
	        /// </summary>
	        public CodeableConcept Value { get; set; }                                                                                         // BuildMemberBase.cs:83
	                                                                                                                                           // BuildMemberBase.cs:85
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(CodeableConcept value)                                                                                                 // BuildMemberBase.cs:89
	        {                                                                                                                                  // BuildMemberBase.cs:90
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:91
	        }                                                                                                                                  // BuildMemberBase.cs:93
	                                                                                                                                           // BuildMemberBase.cs:95
	        // Methods                                                                                                                         // BuildMemberBase.cs:96
	    }                                                                                                                                      // BuildMemberBase.cs:98
	    #endregion                                                                                                                             // BuildMemberBase.cs:99
	                                                                                                                                           // BuildMemberBase.cs:144
	    // Properties                                                                                                                          // BuildMemberBase.cs:145
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:232
	                                                                                                                                           // BuildMemberBase.cs:234
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:238
	                                                                                                                                           // BuildMemberBase.cs:240
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:244
	                                                                                                                                           // BuildMemberBase.cs:246
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:250
	                                                                                                                                           // BuildMemberBase.cs:252
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<CodeableConcept> All()                                                                                              // BuildMemberBase.cs:256
	    {                                                                                                                                      // BuildMemberBase.cs:257
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:258
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:259
	    }                                                                                                                                      // BuildMemberBase.cs:260
	                                                                                                                                           // BuildMemberBase.cs:262
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public CodeableConcept GetAt(Int32 i) => this.items[i].Value;                                                                          // BuildMemberBase.cs:266
	                                                                                                                                           // BuildMemberBase.cs:268
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:272
	                                                                                                                                           // BuildMemberBase.cs:274
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:278
	                                                                                                                                           // BuildMemberBase.cs:147
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public ObsChangesContainer(Int32 min, Int32 max) : base("Observation.component:obsChanges", min, max)                                  // BuildMemberBase.cs:151
	    {                                                                                                                                      // BuildMemberBase.cs:152
	    }                                                                                                                                      // BuildMemberBase.cs:154
	                                                                                                                                           // BuildMemberBase.cs:155
	    // Methods                                                                                                                             // BuildMemberBase.cs:156
	    public CodeableConcept ObsChanges_ComponentCode()                                                                                      // FhirConstruct.cs:753
	    {                                                                                                                                      // FhirConstruct.cs:754
	        CodeableConcept retVal = new CodeableConcept();                                                                                    // FhirConstruct.cs:755
	        retVal.Coding = new List<Coding>();                                                                                                // FhirConstruct.cs:761
	        {                                                                                                                                  // FhirConstruct.cs:764
	            var temp4 = new Coding();                                                                                                      // FhirConstruct.cs:765
	            temp4.SystemElement = new FhirUri();                                                                                           // FhirConstruct.cs:768
	            temp4.SystemElement.Value = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes";               // FhirConstruct.cs:770
	            temp4.CodeElement = new Code();                                                                                                // FhirConstruct.cs:784
	            temp4.CodeElement.Value = "obsChanges";                                                                                        // FhirConstruct.cs:786
	            retVal.Coding.Add(temp4);                                                                                                      // FhirConstruct.cs:813
	        }                                                                                                                                  // FhirConstruct.cs:814
	        return retVal;                                                                                                                     // FhirConstruct.cs:829
	    }                                                                                                                                      // FhirConstruct.cs:830
	                                                                                                                                           // BuildMemberBase.cs:284
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public CodeableConcept Append(CodeableConcept value)                                                                                   // BuildMemberBase.cs:288
	    {                                                                                                                                      // BuildMemberBase.cs:289
	        this.items.Add(new Item(value));                                                                                                   // BuildMemberBase.cs:290
	        return value;                                                                                                                      // BuildMemberBase.cs:291
	    }                                                                                                                                      // BuildMemberBase.cs:292
	                                                                                                                                           // BuildMemberBase.cs:298
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
	                Code = ObsChanges_ComponentCode()                                                                                          // BuildMemberComponents.cs:77
	            };                                                                                                                             // BuildMemberComponents.cs:78
	            yield return component;                                                                                                        // BuildMemberComponents.cs:79
	        }                                                                                                                                  // BuildMemberComponents.cs:80
	    }                                                                                                                                      // BuildMemberComponents.cs:81
	                                                                                                                                           // BuildMemberBase.cs:304
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	                                                                                                                                           // BuildMemberComponents.cs:49
	    public void Read(BreastRadiologyDocument doc, IEnumerable<Observation.ComponentComponent> components)                                  // BuildMemberComponents.cs:50
	    {                                                                                                                                      // BuildMemberComponents.cs:51
	        IEnumerable<Element> elements = base.IsMember(doc,                                                                                 // BuildMemberComponents.cs:52
	            components,                                                                                                                    // BuildMemberComponents.cs:53
	            this.ObsChanges_ComponentCode());                                                                                              // BuildMemberComponents.cs:54
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberComponents.cs:55
	        foreach (Element element in elements)                                                                                              // BuildMemberComponents.cs:56
	            items.Add(new Item((CodeableConcept) element));                                                                                // BuildMemberComponents.cs:57
	        this.SetAllItems(items);                                                                                                           // BuildMemberComponents.cs:58
	    }                                                                                                                                      // BuildMemberComponents.cs:59
	}                                                                                                                                          // BuildMemberBase.cs:158
	#endregion                                                                                                                                 // BuildMemberBase.cs:159
	//- LocalClassDefs
}
