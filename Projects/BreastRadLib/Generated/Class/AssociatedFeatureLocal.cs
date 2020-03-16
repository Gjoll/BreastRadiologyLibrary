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
	#region Observation.component:featureType Container Class                                                                                  // BuildMemberBase.cs:157
	// Called from BuildMemberComponents.cs, Line 206
	// BuildMemberBase.cs:159
	/// <summary>
	/// Container class for Observation.component:featureType.
	/// </summary>
	public class FeatureTypeContainer : MContainer, ITMItem<Observation.ComponentComponent>                                                    // BuildMemberBase.cs:162
	{                                                                                                                                          // BuildMemberBase.cs:163
	    #region Observation.component:featureType Item Class                                                                                   // BuildMemberBase.cs:75
	    // Called from BuildMemberComponents.cs, Line 206
	    // BuildMemberBase.cs:77
	    /// <summary>
	    /// Item class for Observation.component:featureType.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:80
	    {                                                                                                                                      // BuildMemberBase.cs:81
	        // Properties                                                                                                                      // BuildMemberBase.cs:82
	        // BuildMemberBase.cs:83
	        /// <summary>
	        /// Value
	        /// </summary>
	        public CodeableConcept Value { get; set; }                                                                                         // BuildMemberBase.cs:86
	                                                                                                                                           // BuildMemberBase.cs:89
	        // BuildMemberBase.cs:90
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item()                                                                                                                      // BuildMemberBase.cs:93
	        {                                                                                                                                  // BuildMemberBase.cs:94
	        }                                                                                                                                  // BuildMemberBase.cs:96
	                                                                                                                                           // BuildMemberBase.cs:98
	        // Methods                                                                                                                         // BuildMemberBase.cs:99
	                                                                                                                                           // BuildMemberBase.cs:101
	        // BuildMemberBase.cs:102
	        /// <summary>
	        /// Write item.
	        /// </summary>
	                                                                                                                                           // BuildMemberComponents.cs:60
	        public void Write(BreastRadiologyDocument doc, Observation.ComponentComponent component)                                           // BuildMemberComponents.cs:61
	        {                                                                                                                                  // BuildMemberComponents.cs:62
	            component.Value = this.Value;                                                                                                  // BuildMemberComponents.cs:63
	        }                                                                                                                                  // BuildMemberComponents.cs:64
	                                                                                                                                           // BuildMemberBase.cs:107
	        // BuildMemberBase.cs:108
	        /// <summary>
	        /// Read item.
	        /// </summary>
	                                                                                                                                           // BuildMemberComponents.cs:49
	        public void Read(BreastRadiologyDocument doc, Observation.ComponentComponent component)                                            // BuildMemberComponents.cs:50
	        {                                                                                                                                  // BuildMemberComponents.cs:51
	            this.Value = (CodeableConcept) component.Value;                                                                                // BuildMemberComponents.cs:52
	        }                                                                                                                                  // BuildMemberComponents.cs:53
	    }                                                                                                                                      // BuildMemberBase.cs:114
	    #endregion                                                                                                                             // BuildMemberBase.cs:115
	                                                                                                                                           // BuildMemberBase.cs:166
	    // Properties                                                                                                                          // BuildMemberBase.cs:167
	    #region Common Singleton Properties                                                                                                    // BuildMemberBase.cs:191
	                                                                                                                                           // BuildMemberBase.cs:193
	    // BuildMemberBase.cs:194
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems()                                                                                                        // BuildMemberBase.cs:197
	    {                                                                                                                                      // BuildMemberBase.cs:198
	        if (this.item != null) yield return this.item;                                                                                     // BuildMemberBase.cs:199
	    }                                                                                                                                      // BuildMemberBase.cs:200
	                                                                                                                                           // BuildMemberBase.cs:202
	    // BuildMemberBase.cs:203
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items)                                                                                              // BuildMemberBase.cs:206
	    {                                                                                                                                      // BuildMemberBase.cs:207
	        switch (items.Count())                                                                                                             // BuildMemberBase.cs:208
	        {                                                                                                                                  // BuildMemberBase.cs:209
	            case 0: break;                                                                                                                 // BuildMemberBase.cs:210
	            case 1: this.item = items.First(); break;                                                                                      // BuildMemberBase.cs:211
	            default: throw new Exception("Found multiple elements while reading single item");                                             // BuildMemberBase.cs:212
	        }                                                                                                                                  // BuildMemberBase.cs:213
	    }                                                                                                                                      // BuildMemberBase.cs:214
	                                                                                                                                           // BuildMemberBase.cs:216
	    // BuildMemberBase.cs:217
	    /// <summary>
	    /// Item
	    /// </summary>
	    Item item;                                                                                                                             // BuildMemberBase.cs:220
	                                                                                                                                           // BuildMemberBase.cs:222
	    // BuildMemberBase.cs:223
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => this.item == null ? 0 : 1;                                                                              // BuildMemberBase.cs:226
	                                                                                                                                           // BuildMemberBase.cs:228
	    // BuildMemberBase.cs:229
	    /// <summary>
	    /// Get Item's Value
	    /// </summary>
	    public CodeableConcept Get()                                                                                                           // BuildMemberBase.cs:232
	    {                                                                                                                                      // BuildMemberBase.cs:233
	        if (item == null)                                                                                                                  // BuildMemberBase.cs:234
	            return null;                                                                                                                   // BuildMemberBase.cs:235
	        return item.Value;                                                                                                                 // BuildMemberBase.cs:236
	    }                                                                                                                                      // BuildMemberBase.cs:237
	                                                                                                                                           // BuildMemberBase.cs:243
	    // BuildMemberBase.cs:244
	    /// <summary>
	    /// Set Item's Value
	    /// </summary>
	    public CodeableConcept Set(CodeableConcept value)                                                                                      // BuildMemberBase.cs:247
	    {                                                                                                                                      // BuildMemberBase.cs:248
	        Item item = new Item();                                                                                                            // BuildMemberBase.cs:249
	        item.Value = value;                                                                                                                // BuildMemberBase.cs:250
	        this.item = item;                                                                                                                  // BuildMemberBase.cs:251
	        return value;                                                                                                                      // BuildMemberBase.cs:252
	    }                                                                                                                                      // BuildMemberBase.cs:253
	    #endregion                                                                                                                             // BuildMemberBase.cs:329
	                                                                                                                                           // BuildMemberBase.cs:170
	    // BuildMemberBase.cs:171
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public FeatureTypeContainer(Int32 min, Int32 max) : base("Observation.component:featureType", min, max)                                // BuildMemberBase.cs:174
	    {                                                                                                                                      // BuildMemberBase.cs:175
	    }                                                                                                                                      // BuildMemberBase.cs:177
	                                                                                                                                           // BuildMemberBase.cs:179
	    // Methods                                                                                                                             // BuildMemberBase.cs:180
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
	                                                                                                                                           // BuildMemberBase.cs:333
	    // BuildMemberBase.cs:334
	    /// <summary>
	    /// Write container items.
	    /// </summary>
	    public IEnumerable<Observation.ComponentComponent> Write(BreastRadiologyDocument doc)                                                  // BuildMemberComponents.cs:97
	    {                                                                                                                                      // BuildMemberComponents.cs:98
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberComponents.cs:99
	        {                                                                                                                                  // BuildMemberComponents.cs:100
	            Observation.ComponentComponent component = new Observation.ComponentComponent                                                  // BuildMemberComponents.cs:101
	            {                                                                                                                              // BuildMemberComponents.cs:102
	                Value = item.Value,                                                                                                        // BuildMemberComponents.cs:103
	                Code = FeatureType_ComponentCode()                                                                                         // BuildMemberComponents.cs:104
	            };                                                                                                                             // BuildMemberComponents.cs:105
	            yield return component;                                                                                                        // BuildMemberComponents.cs:106
	        }                                                                                                                                  // BuildMemberComponents.cs:107
	    }                                                                                                                                      // BuildMemberComponents.cs:108
	                                                                                                                                           // BuildMemberBase.cs:339
	    // BuildMemberBase.cs:340
	    /// <summary>
	    /// Read container items.
	    /// </summary>
	                                                                                                                                           // BuildMemberComponents.cs:72
	    public void Read(BreastRadiologyDocument doc, IEnumerable<Observation.ComponentComponent> components)                                  // BuildMemberComponents.cs:73
	    {                                                                                                                                      // BuildMemberComponents.cs:74
	        IEnumerable<Element> elements = base.IsMember(doc,                                                                                 // BuildMemberComponents.cs:75
	            components,                                                                                                                    // BuildMemberComponents.cs:76
	            this.FeatureType_ComponentCode());                                                                                             // BuildMemberComponents.cs:77
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberComponents.cs:78
	        foreach (Element element in elements)                                                                                              // BuildMemberComponents.cs:79
	        {                                                                                                                                  // BuildMemberComponents.cs:80
	            Item item = new Item();                                                                                                        // BuildMemberComponents.cs:81
	            item.Value = (CodeableConcept) element;                                                                                        // BuildMemberComponents.cs:82
	            items.Add(item);                                                                                                               // BuildMemberComponents.cs:83
	        }                                                                                                                                  // BuildMemberComponents.cs:84
	        this.SetAllItems(items);                                                                                                           // BuildMemberComponents.cs:85
	    }                                                                                                                                      // BuildMemberComponents.cs:86
	}                                                                                                                                          // BuildMemberBase.cs:182
	#endregion                                                                                                                                 // BuildMemberBase.cs:183
	//- LocalClassDefs
}
