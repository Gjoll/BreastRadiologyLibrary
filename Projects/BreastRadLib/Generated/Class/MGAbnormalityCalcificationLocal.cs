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

namespace BreastRadLib.MGAbnormalityCalcificationLocal
{
	//+ LocalClassDefs
	#region Observation.component:calcificationType Container Class                                                                            // BuildMemberBase.cs:137
	/// <summary>
	/// Container class for Observation.component:calcificationType.
	/// </summary>
	public class CalcificationTypeContainer : MContainer, ITMItem<Observation.ComponentComponent>                                              // BuildMemberBase.cs:141
	{                                                                                                                                          // BuildMemberBase.cs:142
	    #region Observation.component:calcificationType Item Class                                                                             // BuildMemberBase.cs:73
	    /// <summary>
	    /// Item class for Observation.component:calcificationType.
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
	                                                                                                                                           // BuildMemberBase.cs:167
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems()                                                                                                        // BuildMemberBase.cs:171
	    {                                                                                                                                      // BuildMemberBase.cs:172
	        if (this.item != null) yield return this.item;                                                                                     // BuildMemberBase.cs:173
	    }                                                                                                                                      // BuildMemberBase.cs:174
	                                                                                                                                           // BuildMemberBase.cs:176
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items)                                                                                              // BuildMemberBase.cs:180
	    {                                                                                                                                      // BuildMemberBase.cs:181
	        switch (items.Count())                                                                                                             // BuildMemberBase.cs:182
	        {                                                                                                                                  // BuildMemberBase.cs:183
	            case 0: break;                                                                                                                 // BuildMemberBase.cs:184
	            case 1: this.item = items.First(); break;                                                                                      // BuildMemberBase.cs:185
	            default: throw new Exception("Found multiple elements while reading single item");                                             // BuildMemberBase.cs:186
	        }                                                                                                                                  // BuildMemberBase.cs:187
	    }                                                                                                                                      // BuildMemberBase.cs:188
	                                                                                                                                           // BuildMemberBase.cs:190
	    /// <summary>
	    /// Item
	    /// </summary>
	    Item item;                                                                                                                             // BuildMemberBase.cs:194
	                                                                                                                                           // BuildMemberBase.cs:196
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => this.item == null ? 0 : 1;                                                                              // BuildMemberBase.cs:200
	                                                                                                                                           // BuildMemberBase.cs:202
	    /// <summary>
	    /// Get Item's Value
	    /// </summary>
	    public CodeableConcept Get()                                                                                                           // BuildMemberBase.cs:206
	    {                                                                                                                                      // BuildMemberBase.cs:207
	        if (item == null)                                                                                                                  // BuildMemberBase.cs:208
	            return null;                                                                                                                   // BuildMemberBase.cs:209
	        return item.Value;                                                                                                                 // BuildMemberBase.cs:210
	    }                                                                                                                                      // BuildMemberBase.cs:211
	                                                                                                                                           // BuildMemberBase.cs:217
	    /// <summary>
	    /// Set Item's Value
	    /// </summary>
	    public CodeableConcept Set(CodeableConcept value)                                                                                      // BuildMemberBase.cs:221
	    {                                                                                                                                      // BuildMemberBase.cs:222
	        this.item = new Item(value);                                                                                                       // BuildMemberBase.cs:223
	        return value;                                                                                                                      // BuildMemberBase.cs:224
	    }                                                                                                                                      // BuildMemberBase.cs:225
	                                                                                                                                           // BuildMemberBase.cs:147
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public CalcificationTypeContainer(Int32 min, Int32 max) : base("Observation.component:calcificationType", min, max)                    // BuildMemberBase.cs:151
	    {                                                                                                                                      // BuildMemberBase.cs:152
	    }                                                                                                                                      // BuildMemberBase.cs:154
	                                                                                                                                           // BuildMemberBase.cs:155
	    // Methods                                                                                                                             // BuildMemberBase.cs:156
	    public CodeableConcept CalcificationType_ComponentCode()                                                                               // FhirConstruct.cs:753
	    {                                                                                                                                      // FhirConstruct.cs:754
	        CodeableConcept retVal = new CodeableConcept();                                                                                    // FhirConstruct.cs:755
	        retVal.Coding = new List<Coding>();                                                                                                // FhirConstruct.cs:761
	        {                                                                                                                                  // FhirConstruct.cs:764
	            var temp4 = new Coding();                                                                                                      // FhirConstruct.cs:765
	            temp4.SystemElement = new FhirUri();                                                                                           // FhirConstruct.cs:768
	            temp4.SystemElement.Value = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes";               // FhirConstruct.cs:770
	            temp4.CodeElement = new Code();                                                                                                // FhirConstruct.cs:784
	            temp4.CodeElement.Value = "mgCalcificationType";                                                                               // FhirConstruct.cs:786
	            retVal.Coding.Add(temp4);                                                                                                      // FhirConstruct.cs:813
	        }                                                                                                                                  // FhirConstruct.cs:814
	        return retVal;                                                                                                                     // FhirConstruct.cs:829
	    }                                                                                                                                      // FhirConstruct.cs:830
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
	                Code = CalcificationType_ComponentCode()                                                                                   // BuildMemberComponents.cs:77
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
	            this.CalcificationType_ComponentCode());                                                                                       // BuildMemberComponents.cs:54
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberComponents.cs:55
	        foreach (Element element in elements)                                                                                              // BuildMemberComponents.cs:56
	            items.Add(new Item((CodeableConcept) element));                                                                                // BuildMemberComponents.cs:57
	        this.SetAllItems(items);                                                                                                           // BuildMemberComponents.cs:58
	    }                                                                                                                                      // BuildMemberComponents.cs:59
	}                                                                                                                                          // BuildMemberBase.cs:158
	#endregion                                                                                                                                 // BuildMemberBase.cs:159
	#region Observation.component:calcificationDistribution Container Class                                                                    // BuildMemberBase.cs:137
	/// <summary>
	/// Container class for Observation.component:calcificationDistribution.
	/// </summary>
	public class CalcificationDistributionContainer : MContainer, ITMItem<Observation.ComponentComponent>                                      // BuildMemberBase.cs:141
	{                                                                                                                                          // BuildMemberBase.cs:142
	    #region Observation.component:calcificationDistribution Item Class                                                                     // BuildMemberBase.cs:73
	    /// <summary>
	    /// Item class for Observation.component:calcificationDistribution.
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
	                                                                                                                                           // BuildMemberBase.cs:167
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems()                                                                                                        // BuildMemberBase.cs:171
	    {                                                                                                                                      // BuildMemberBase.cs:172
	        if (this.item != null) yield return this.item;                                                                                     // BuildMemberBase.cs:173
	    }                                                                                                                                      // BuildMemberBase.cs:174
	                                                                                                                                           // BuildMemberBase.cs:176
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items)                                                                                              // BuildMemberBase.cs:180
	    {                                                                                                                                      // BuildMemberBase.cs:181
	        switch (items.Count())                                                                                                             // BuildMemberBase.cs:182
	        {                                                                                                                                  // BuildMemberBase.cs:183
	            case 0: break;                                                                                                                 // BuildMemberBase.cs:184
	            case 1: this.item = items.First(); break;                                                                                      // BuildMemberBase.cs:185
	            default: throw new Exception("Found multiple elements while reading single item");                                             // BuildMemberBase.cs:186
	        }                                                                                                                                  // BuildMemberBase.cs:187
	    }                                                                                                                                      // BuildMemberBase.cs:188
	                                                                                                                                           // BuildMemberBase.cs:190
	    /// <summary>
	    /// Item
	    /// </summary>
	    Item item;                                                                                                                             // BuildMemberBase.cs:194
	                                                                                                                                           // BuildMemberBase.cs:196
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => this.item == null ? 0 : 1;                                                                              // BuildMemberBase.cs:200
	                                                                                                                                           // BuildMemberBase.cs:202
	    /// <summary>
	    /// Get Item's Value
	    /// </summary>
	    public CodeableConcept Get()                                                                                                           // BuildMemberBase.cs:206
	    {                                                                                                                                      // BuildMemberBase.cs:207
	        if (item == null)                                                                                                                  // BuildMemberBase.cs:208
	            return null;                                                                                                                   // BuildMemberBase.cs:209
	        return item.Value;                                                                                                                 // BuildMemberBase.cs:210
	    }                                                                                                                                      // BuildMemberBase.cs:211
	                                                                                                                                           // BuildMemberBase.cs:217
	    /// <summary>
	    /// Set Item's Value
	    /// </summary>
	    public CodeableConcept Set(CodeableConcept value)                                                                                      // BuildMemberBase.cs:221
	    {                                                                                                                                      // BuildMemberBase.cs:222
	        this.item = new Item(value);                                                                                                       // BuildMemberBase.cs:223
	        return value;                                                                                                                      // BuildMemberBase.cs:224
	    }                                                                                                                                      // BuildMemberBase.cs:225
	                                                                                                                                           // BuildMemberBase.cs:147
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public CalcificationDistributionContainer(Int32 min, Int32 max) : base("Observation.component:calcificationDistribution", min, max)    // BuildMemberBase.cs:151
	    {                                                                                                                                      // BuildMemberBase.cs:152
	    }                                                                                                                                      // BuildMemberBase.cs:154
	                                                                                                                                           // BuildMemberBase.cs:155
	    // Methods                                                                                                                             // BuildMemberBase.cs:156
	    public CodeableConcept CalcificationDistribution_ComponentCode()                                                                       // FhirConstruct.cs:753
	    {                                                                                                                                      // FhirConstruct.cs:754
	        CodeableConcept retVal = new CodeableConcept();                                                                                    // FhirConstruct.cs:755
	        retVal.Coding = new List<Coding>();                                                                                                // FhirConstruct.cs:761
	        {                                                                                                                                  // FhirConstruct.cs:764
	            var temp4 = new Coding();                                                                                                      // FhirConstruct.cs:765
	            temp4.SystemElement = new FhirUri();                                                                                           // FhirConstruct.cs:768
	            temp4.SystemElement.Value = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes";               // FhirConstruct.cs:770
	            temp4.CodeElement = new Code();                                                                                                // FhirConstruct.cs:784
	            temp4.CodeElement.Value = "mgCalcificationDistribution";                                                                       // FhirConstruct.cs:786
	            retVal.Coding.Add(temp4);                                                                                                      // FhirConstruct.cs:813
	        }                                                                                                                                  // FhirConstruct.cs:814
	        return retVal;                                                                                                                     // FhirConstruct.cs:829
	    }                                                                                                                                      // FhirConstruct.cs:830
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
	                Code = CalcificationDistribution_ComponentCode()                                                                           // BuildMemberComponents.cs:77
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
	            this.CalcificationDistribution_ComponentCode());                                                                               // BuildMemberComponents.cs:54
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberComponents.cs:55
	        foreach (Element element in elements)                                                                                              // BuildMemberComponents.cs:56
	            items.Add(new Item((CodeableConcept) element));                                                                                // BuildMemberComponents.cs:57
	        this.SetAllItems(items);                                                                                                           // BuildMemberComponents.cs:58
	    }                                                                                                                                      // BuildMemberComponents.cs:59
	}                                                                                                                                          // BuildMemberBase.cs:158
	#endregion                                                                                                                                 // BuildMemberBase.cs:159
	//- LocalClassDefs
}
