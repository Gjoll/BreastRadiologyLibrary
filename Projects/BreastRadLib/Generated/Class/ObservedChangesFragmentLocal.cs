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
	#region Observation.component:obsChanges Container Class                                                                                   // BuildMemberBase.cs:158
	// Called from BuildMemberComponents.cs, Line 208
	// BuildMemberBase.cs:160
	/// <summary>
	/// Container class for Observation.component:obsChanges.
	/// </summary>
	public class MObsChanges : MContainer, ITMItem<Observation.ComponentComponent>                                                             // BuildMemberBase.cs:163
	{                                                                                                                                          // BuildMemberBase.cs:164
	    #region Observation.component:obsChanges Item Class                                                                                    // BuildMemberBase.cs:75
	    // Called from BuildMemberComponents.cs, Line 208
	    // BuildMemberBase.cs:77
	    /// <summary>
	    /// Item class for Observation.component:obsChanges.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:80
	    {                                                                                                                                      // BuildMemberBase.cs:81
	        // Properties                                                                                                                      // BuildMemberBase.cs:82
	        // BuildMemberBase.cs:84
	        /// <summary>
	        /// Value
	        /// </summary>
	        public CodeableConcept Value { get; set; }                                                                                         // BuildMemberBase.cs:87
	                                                                                                                                           // BuildMemberBase.cs:90
	        // BuildMemberBase.cs:91
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item()                                                                                                                      // BuildMemberBase.cs:94
	        {                                                                                                                                  // BuildMemberBase.cs:95
	        }                                                                                                                                  // BuildMemberBase.cs:97
	                                                                                                                                           // BuildMemberBase.cs:99
	        // Methods                                                                                                                         // BuildMemberBase.cs:100
	                                                                                                                                           // BuildMemberBase.cs:102
	        // BuildMemberBase.cs:103
	        /// <summary>
	        /// Write item.
	        /// </summary>
	        public Observation.ComponentComponent WriteItem(BreastRadiologyDocument doc)                                                       // BuildMemberComponents.cs:63
	        {                                                                                                                                  // BuildMemberComponents.cs:64
	            return new Observation.ComponentComponent                                                                                      // BuildMemberComponents.cs:65
	            {                                                                                                                              // BuildMemberComponents.cs:66
	                Value = this.Value,                                                                                                        // BuildMemberComponents.cs:67
	                Code = ObsChanges_ComponentCode()                                                                                          // BuildMemberComponents.cs:68
	            };                                                                                                                             // BuildMemberComponents.cs:69
	        }                                                                                                                                  // BuildMemberComponents.cs:70
	                                                                                                                                           // BuildMemberBase.cs:108
	        // BuildMemberBase.cs:109
	        /// <summary>
	        /// Read item.
	        /// </summary>
	        public void ReadItem(BreastRadiologyDocument doc, Observation.ComponentComponent component)                                        // BuildMemberComponents.cs:53
	        {                                                                                                                                  // BuildMemberComponents.cs:54
	            this.Value = (CodeableConcept) component.Value;                                                                                // BuildMemberComponents.cs:55
	        }                                                                                                                                  // BuildMemberComponents.cs:56
	    }                                                                                                                                      // BuildMemberBase.cs:115
	    #endregion                                                                                                                             // BuildMemberBase.cs:116
	                                                                                                                                           // BuildMemberBase.cs:167
	    // Properties                                                                                                                          // BuildMemberBase.cs:168
	    #region Common Non-Singleton Properties                                                                                                // BuildMemberBase.cs:261
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:262
	                                                                                                                                           // BuildMemberBase.cs:264
	    // BuildMemberBase.cs:265
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:268
	                                                                                                                                           // BuildMemberBase.cs:270
	    // BuildMemberBase.cs:271
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:274
	                                                                                                                                           // BuildMemberBase.cs:276
	    // BuildMemberBase.cs:277
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:280
	                                                                                                                                           // BuildMemberBase.cs:282
	    // BuildMemberBase.cs:283
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<CodeableConcept> All()                                                                                              // BuildMemberBase.cs:286
	    {                                                                                                                                      // BuildMemberBase.cs:287
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:288
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:289
	    }                                                                                                                                      // BuildMemberBase.cs:290
	                                                                                                                                           // BuildMemberBase.cs:292
	    // BuildMemberBase.cs:293
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public CodeableConcept GetAt(Int32 i) => this.items[i].Value;                                                                          // BuildMemberBase.cs:296
	                                                                                                                                           // BuildMemberBase.cs:298
	    // BuildMemberBase.cs:299
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:302
	                                                                                                                                           // BuildMemberBase.cs:304
	    // BuildMemberBase.cs:305
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:308
	    #endregion                                                                                                                             // BuildMemberBase.cs:330
	                                                                                                                                           // BuildMemberBase.cs:171
	    // BuildMemberBase.cs:172
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public MObsChanges(Int32 min, Int32 max) : base("Observation.component:obsChanges", min, max)                                          // BuildMemberBase.cs:175
	    {                                                                                                                                      // BuildMemberBase.cs:176
	    }                                                                                                                                      // BuildMemberBase.cs:178
	                                                                                                                                           // BuildMemberBase.cs:180
	    // Methods                                                                                                                             // BuildMemberBase.cs:181
	    private static CodeableConcept ObsChanges_ComponentCode()                                                                              // FhirConstruct.cs:759
	    {                                                                                                                                      // FhirConstruct.cs:760
	        CodeableConcept retVal = new CodeableConcept();                                                                                    // FhirConstruct.cs:761
	        retVal.Coding = new List<Coding>();                                                                                                // FhirConstruct.cs:767
	        {                                                                                                                                  // FhirConstruct.cs:770
	            var temp4 = new Coding();                                                                                                      // FhirConstruct.cs:771
	            temp4.SystemElement = new FhirUri();                                                                                           // FhirConstruct.cs:774
	            temp4.SystemElement.Value = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes";               // FhirConstruct.cs:776
	            temp4.CodeElement = new Code();                                                                                                // FhirConstruct.cs:790
	            temp4.CodeElement.Value = "obsChanges";                                                                                        // FhirConstruct.cs:792
	            retVal.Coding.Add(temp4);                                                                                                      // FhirConstruct.cs:819
	        }                                                                                                                                  // FhirConstruct.cs:820
	        return retVal;                                                                                                                     // FhirConstruct.cs:835
	    }                                                                                                                                      // FhirConstruct.cs:836
	                                                                                                                                           // BuildMemberBase.cs:314
	    // BuildMemberBase.cs:315
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public CodeableConcept Append(CodeableConcept value)                                                                                   // BuildMemberBase.cs:318
	    {                                                                                                                                      // BuildMemberBase.cs:319
	        Item item = new Item();                                                                                                            // BuildMemberBase.cs:320
	        item.Value = value;                                                                                                                // BuildMemberBase.cs:321
	        this.items.Add(item);                                                                                                              // BuildMemberBase.cs:322
	        return value;                                                                                                                      // BuildMemberBase.cs:323
	    }                                                                                                                                      // BuildMemberBase.cs:324
	                                                                                                                                           // BuildMemberBase.cs:334
	    // BuildMemberBase.cs:335
	    /// <summary>
	    /// Write container items.
	    /// </summary>
	    public IEnumerable<Observation.ComponentComponent> Write(BreastRadiologyDocument doc)                                                  // BuildMemberComponents.cs:103
	    {                                                                                                                                      // BuildMemberComponents.cs:104
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberComponents.cs:105
	        {                                                                                                                                  // BuildMemberComponents.cs:106
	            Observation.ComponentComponent component = item.WriteItem(doc);                                                                // BuildMemberComponents.cs:107
	            yield return component;                                                                                                        // BuildMemberComponents.cs:108
	        }                                                                                                                                  // BuildMemberComponents.cs:109
	    }                                                                                                                                      // BuildMemberComponents.cs:110
	                                                                                                                                           // BuildMemberBase.cs:340
	    // BuildMemberBase.cs:341
	    /// <summary>
	    /// Read container items.
	    /// </summary>
	                                                                                                                                           // BuildMemberComponents.cs:78
	    public void Read(BreastRadiologyDocument doc, IEnumerable<Observation.ComponentComponent> components)                                  // BuildMemberComponents.cs:79
	    {                                                                                                                                      // BuildMemberComponents.cs:80
	        IEnumerable<Observation.ComponentComponent> memberComponents = base.IsMember(doc,                                                  // BuildMemberComponents.cs:81
	            components,                                                                                                                    // BuildMemberComponents.cs:82
	            ObsChanges_ComponentCode());                                                                                                   // BuildMemberComponents.cs:83
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberComponents.cs:84
	        foreach (Observation.ComponentComponent memberComponent in memberComponents)                                                       // BuildMemberComponents.cs:85
	        {                                                                                                                                  // BuildMemberComponents.cs:86
	            Item item = new Item();                                                                                                        // BuildMemberComponents.cs:87
	            item.ReadItem(doc, memberComponent);                                                                                           // BuildMemberComponents.cs:88
	            items.Add(item);                                                                                                               // BuildMemberComponents.cs:89
	        }                                                                                                                                  // BuildMemberComponents.cs:90
	        this.SetAllItems(items);                                                                                                           // BuildMemberComponents.cs:91
	    }                                                                                                                                      // BuildMemberComponents.cs:92
	}                                                                                                                                          // BuildMemberBase.cs:183
	#endregion                                                                                                                                 // BuildMemberBase.cs:184
	//- LocalClassDefs
}
