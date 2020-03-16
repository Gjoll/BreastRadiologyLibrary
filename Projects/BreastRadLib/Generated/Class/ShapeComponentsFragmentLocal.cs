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

namespace BreastRadLib.ShapeComponentsFragmentLocal
{
	//+ LocalClassDefs
	#region Observation.component:orientation Container Class                                                                                  // BuildMemberBase.cs:140
	// Called from BuildMemberComponents.cs, Line 179
	// BuildMemberBase.cs:142
	/// <summary>
	/// Container class for Observation.component:orientation.
	/// </summary>
	public class OrientationContainer : MContainer, ITMItem<Observation.ComponentComponent>                                                    // BuildMemberBase.cs:145
	{                                                                                                                                          // BuildMemberBase.cs:146
	    #region Observation.component:orientation Item Class                                                                                   // BuildMemberBase.cs:75
	    // Called from BuildMemberComponents.cs, Line 179
	    // BuildMemberBase.cs:77
	    /// <summary>
	    /// Item class for Observation.component:orientation.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:80
	    {                                                                                                                                      // BuildMemberBase.cs:81
	        // Properties                                                                                                                      // BuildMemberBase.cs:82
	        // BuildMemberBase.cs:83
	        /// <summary>
	        /// Value
	        /// </summary>
	        public CodeableConcept Value { get; set; }                                                                                         // BuildMemberBase.cs:86
	                                                                                                                                           // BuildMemberBase.cs:88
	        // BuildMemberBase.cs:89
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(CodeableConcept value)                                                                                                 // BuildMemberBase.cs:92
	        {                                                                                                                                  // BuildMemberBase.cs:93
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:94
	        }                                                                                                                                  // BuildMemberBase.cs:96
	                                                                                                                                           // BuildMemberBase.cs:98
	        // Methods                                                                                                                         // BuildMemberBase.cs:99
	    }                                                                                                                                      // BuildMemberBase.cs:101
	    #endregion                                                                                                                             // BuildMemberBase.cs:102
	                                                                                                                                           // BuildMemberBase.cs:148
	    // Properties                                                                                                                          // BuildMemberBase.cs:149
	    #region Common Singleton Properties                                                                                                    // BuildMemberBase.cs:171
	                                                                                                                                           // BuildMemberBase.cs:172
	    // BuildMemberBase.cs:173
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems()                                                                                                        // BuildMemberBase.cs:176
	    {                                                                                                                                      // BuildMemberBase.cs:177
	        if (this.item != null) yield return this.item;                                                                                     // BuildMemberBase.cs:178
	    }                                                                                                                                      // BuildMemberBase.cs:179
	                                                                                                                                           // BuildMemberBase.cs:181
	    // BuildMemberBase.cs:182
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items)                                                                                              // BuildMemberBase.cs:185
	    {                                                                                                                                      // BuildMemberBase.cs:186
	        switch (items.Count())                                                                                                             // BuildMemberBase.cs:187
	        {                                                                                                                                  // BuildMemberBase.cs:188
	            case 0: break;                                                                                                                 // BuildMemberBase.cs:189
	            case 1: this.item = items.First(); break;                                                                                      // BuildMemberBase.cs:190
	            default: throw new Exception("Found multiple elements while reading single item");                                             // BuildMemberBase.cs:191
	        }                                                                                                                                  // BuildMemberBase.cs:192
	    }                                                                                                                                      // BuildMemberBase.cs:193
	                                                                                                                                           // BuildMemberBase.cs:195
	    // BuildMemberBase.cs:196
	    /// <summary>
	    /// Item
	    /// </summary>
	    Item item;                                                                                                                             // BuildMemberBase.cs:199
	                                                                                                                                           // BuildMemberBase.cs:201
	    // BuildMemberBase.cs:202
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => this.item == null ? 0 : 1;                                                                              // BuildMemberBase.cs:205
	                                                                                                                                           // BuildMemberBase.cs:207
	    // BuildMemberBase.cs:208
	    /// <summary>
	    /// Get Item's Value
	    /// </summary>
	    public CodeableConcept Get()                                                                                                           // BuildMemberBase.cs:211
	    {                                                                                                                                      // BuildMemberBase.cs:212
	        if (item == null)                                                                                                                  // BuildMemberBase.cs:213
	            return null;                                                                                                                   // BuildMemberBase.cs:214
	        return item.Value;                                                                                                                 // BuildMemberBase.cs:215
	    }                                                                                                                                      // BuildMemberBase.cs:216
	                                                                                                                                           // BuildMemberBase.cs:222
	    // BuildMemberBase.cs:223
	    /// <summary>
	    /// Set Item's Value
	    /// </summary>
	    public CodeableConcept Set(CodeableConcept value)                                                                                      // BuildMemberBase.cs:226
	    {                                                                                                                                      // BuildMemberBase.cs:227
	        this.item = new Item(value);                                                                                                       // BuildMemberBase.cs:228
	        return value;                                                                                                                      // BuildMemberBase.cs:229
	    }                                                                                                                                      // BuildMemberBase.cs:230
	    #endregion                                                                                                                             // BuildMemberBase.cs:304
	                                                                                                                                           // BuildMemberBase.cs:151
	    // BuildMemberBase.cs:152
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public OrientationContainer(Int32 min, Int32 max) : base("Observation.component:orientation", min, max)                                // BuildMemberBase.cs:155
	    {                                                                                                                                      // BuildMemberBase.cs:156
	    }                                                                                                                                      // BuildMemberBase.cs:158
	                                                                                                                                           // BuildMemberBase.cs:159
	    // Methods                                                                                                                             // BuildMemberBase.cs:160
	    public CodeableConcept Orientation_ComponentCode()                                                                                     // FhirConstruct.cs:753
	    {                                                                                                                                      // FhirConstruct.cs:754
	        CodeableConcept retVal = new CodeableConcept();                                                                                    // FhirConstruct.cs:755
	        retVal.Coding = new List<Coding>();                                                                                                // FhirConstruct.cs:761
	        {                                                                                                                                  // FhirConstruct.cs:764
	            var temp4 = new Coding();                                                                                                      // FhirConstruct.cs:765
	            temp4.SystemElement = new FhirUri();                                                                                           // FhirConstruct.cs:768
	            temp4.SystemElement.Value = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes";               // FhirConstruct.cs:770
	            temp4.CodeElement = new Code();                                                                                                // FhirConstruct.cs:784
	            temp4.CodeElement.Value = "orientation";                                                                                       // FhirConstruct.cs:786
	            retVal.Coding.Add(temp4);                                                                                                      // FhirConstruct.cs:813
	        }                                                                                                                                  // FhirConstruct.cs:814
	        return retVal;                                                                                                                     // FhirConstruct.cs:829
	    }                                                                                                                                      // FhirConstruct.cs:830
	                                                                                                                                           // BuildMemberBase.cs:308
	    // BuildMemberBase.cs:309
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
	                Code = Orientation_ComponentCode()                                                                                         // BuildMemberComponents.cs:77
	            };                                                                                                                             // BuildMemberComponents.cs:78
	            yield return component;                                                                                                        // BuildMemberComponents.cs:79
	        }                                                                                                                                  // BuildMemberComponents.cs:80
	    }                                                                                                                                      // BuildMemberComponents.cs:81
	                                                                                                                                           // BuildMemberBase.cs:314
	    // BuildMemberBase.cs:315
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	                                                                                                                                           // BuildMemberComponents.cs:49
	    public void Read(BreastRadiologyDocument doc, IEnumerable<Observation.ComponentComponent> components)                                  // BuildMemberComponents.cs:50
	    {                                                                                                                                      // BuildMemberComponents.cs:51
	        IEnumerable<Element> elements = base.IsMember(doc,                                                                                 // BuildMemberComponents.cs:52
	            components,                                                                                                                    // BuildMemberComponents.cs:53
	            this.Orientation_ComponentCode());                                                                                             // BuildMemberComponents.cs:54
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberComponents.cs:55
	        foreach (Element element in elements)                                                                                              // BuildMemberComponents.cs:56
	            items.Add(new Item((CodeableConcept) element));                                                                                // BuildMemberComponents.cs:57
	        this.SetAllItems(items);                                                                                                           // BuildMemberComponents.cs:58
	    }                                                                                                                                      // BuildMemberComponents.cs:59
	}                                                                                                                                          // BuildMemberBase.cs:162
	#endregion                                                                                                                                 // BuildMemberBase.cs:163
	#region Observation.component:shape Container Class                                                                                        // BuildMemberBase.cs:140
	// Called from BuildMemberComponents.cs, Line 179
	// BuildMemberBase.cs:142
	/// <summary>
	/// Container class for Observation.component:shape.
	/// </summary>
	public class ShapeContainer : MContainer, ITMItem<Observation.ComponentComponent>                                                          // BuildMemberBase.cs:145
	{                                                                                                                                          // BuildMemberBase.cs:146
	    #region Observation.component:shape Item Class                                                                                         // BuildMemberBase.cs:75
	    // Called from BuildMemberComponents.cs, Line 179
	    // BuildMemberBase.cs:77
	    /// <summary>
	    /// Item class for Observation.component:shape.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:80
	    {                                                                                                                                      // BuildMemberBase.cs:81
	        // Properties                                                                                                                      // BuildMemberBase.cs:82
	        // BuildMemberBase.cs:83
	        /// <summary>
	        /// Value
	        /// </summary>
	        public CodeableConcept Value { get; set; }                                                                                         // BuildMemberBase.cs:86
	                                                                                                                                           // BuildMemberBase.cs:88
	        // BuildMemberBase.cs:89
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(CodeableConcept value)                                                                                                 // BuildMemberBase.cs:92
	        {                                                                                                                                  // BuildMemberBase.cs:93
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:94
	        }                                                                                                                                  // BuildMemberBase.cs:96
	                                                                                                                                           // BuildMemberBase.cs:98
	        // Methods                                                                                                                         // BuildMemberBase.cs:99
	    }                                                                                                                                      // BuildMemberBase.cs:101
	    #endregion                                                                                                                             // BuildMemberBase.cs:102
	                                                                                                                                           // BuildMemberBase.cs:148
	    // Properties                                                                                                                          // BuildMemberBase.cs:149
	    #region Common Singleton Properties                                                                                                    // BuildMemberBase.cs:171
	                                                                                                                                           // BuildMemberBase.cs:172
	    // BuildMemberBase.cs:173
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems()                                                                                                        // BuildMemberBase.cs:176
	    {                                                                                                                                      // BuildMemberBase.cs:177
	        if (this.item != null) yield return this.item;                                                                                     // BuildMemberBase.cs:178
	    }                                                                                                                                      // BuildMemberBase.cs:179
	                                                                                                                                           // BuildMemberBase.cs:181
	    // BuildMemberBase.cs:182
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items)                                                                                              // BuildMemberBase.cs:185
	    {                                                                                                                                      // BuildMemberBase.cs:186
	        switch (items.Count())                                                                                                             // BuildMemberBase.cs:187
	        {                                                                                                                                  // BuildMemberBase.cs:188
	            case 0: break;                                                                                                                 // BuildMemberBase.cs:189
	            case 1: this.item = items.First(); break;                                                                                      // BuildMemberBase.cs:190
	            default: throw new Exception("Found multiple elements while reading single item");                                             // BuildMemberBase.cs:191
	        }                                                                                                                                  // BuildMemberBase.cs:192
	    }                                                                                                                                      // BuildMemberBase.cs:193
	                                                                                                                                           // BuildMemberBase.cs:195
	    // BuildMemberBase.cs:196
	    /// <summary>
	    /// Item
	    /// </summary>
	    Item item;                                                                                                                             // BuildMemberBase.cs:199
	                                                                                                                                           // BuildMemberBase.cs:201
	    // BuildMemberBase.cs:202
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => this.item == null ? 0 : 1;                                                                              // BuildMemberBase.cs:205
	                                                                                                                                           // BuildMemberBase.cs:207
	    // BuildMemberBase.cs:208
	    /// <summary>
	    /// Get Item's Value
	    /// </summary>
	    public CodeableConcept Get()                                                                                                           // BuildMemberBase.cs:211
	    {                                                                                                                                      // BuildMemberBase.cs:212
	        if (item == null)                                                                                                                  // BuildMemberBase.cs:213
	            return null;                                                                                                                   // BuildMemberBase.cs:214
	        return item.Value;                                                                                                                 // BuildMemberBase.cs:215
	    }                                                                                                                                      // BuildMemberBase.cs:216
	                                                                                                                                           // BuildMemberBase.cs:222
	    // BuildMemberBase.cs:223
	    /// <summary>
	    /// Set Item's Value
	    /// </summary>
	    public CodeableConcept Set(CodeableConcept value)                                                                                      // BuildMemberBase.cs:226
	    {                                                                                                                                      // BuildMemberBase.cs:227
	        this.item = new Item(value);                                                                                                       // BuildMemberBase.cs:228
	        return value;                                                                                                                      // BuildMemberBase.cs:229
	    }                                                                                                                                      // BuildMemberBase.cs:230
	    #endregion                                                                                                                             // BuildMemberBase.cs:304
	                                                                                                                                           // BuildMemberBase.cs:151
	    // BuildMemberBase.cs:152
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public ShapeContainer(Int32 min, Int32 max) : base("Observation.component:shape", min, max)                                            // BuildMemberBase.cs:155
	    {                                                                                                                                      // BuildMemberBase.cs:156
	    }                                                                                                                                      // BuildMemberBase.cs:158
	                                                                                                                                           // BuildMemberBase.cs:159
	    // Methods                                                                                                                             // BuildMemberBase.cs:160
	    public CodeableConcept Shape_ComponentCode()                                                                                           // FhirConstruct.cs:753
	    {                                                                                                                                      // FhirConstruct.cs:754
	        CodeableConcept retVal = new CodeableConcept();                                                                                    // FhirConstruct.cs:755
	        retVal.Coding = new List<Coding>();                                                                                                // FhirConstruct.cs:761
	        {                                                                                                                                  // FhirConstruct.cs:764
	            var temp4 = new Coding();                                                                                                      // FhirConstruct.cs:765
	            temp4.SystemElement = new FhirUri();                                                                                           // FhirConstruct.cs:768
	            temp4.SystemElement.Value = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes";               // FhirConstruct.cs:770
	            temp4.CodeElement = new Code();                                                                                                // FhirConstruct.cs:784
	            temp4.CodeElement.Value = "shape";                                                                                             // FhirConstruct.cs:786
	            retVal.Coding.Add(temp4);                                                                                                      // FhirConstruct.cs:813
	        }                                                                                                                                  // FhirConstruct.cs:814
	        return retVal;                                                                                                                     // FhirConstruct.cs:829
	    }                                                                                                                                      // FhirConstruct.cs:830
	                                                                                                                                           // BuildMemberBase.cs:308
	    // BuildMemberBase.cs:309
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
	                Code = Shape_ComponentCode()                                                                                               // BuildMemberComponents.cs:77
	            };                                                                                                                             // BuildMemberComponents.cs:78
	            yield return component;                                                                                                        // BuildMemberComponents.cs:79
	        }                                                                                                                                  // BuildMemberComponents.cs:80
	    }                                                                                                                                      // BuildMemberComponents.cs:81
	                                                                                                                                           // BuildMemberBase.cs:314
	    // BuildMemberBase.cs:315
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	                                                                                                                                           // BuildMemberComponents.cs:49
	    public void Read(BreastRadiologyDocument doc, IEnumerable<Observation.ComponentComponent> components)                                  // BuildMemberComponents.cs:50
	    {                                                                                                                                      // BuildMemberComponents.cs:51
	        IEnumerable<Element> elements = base.IsMember(doc,                                                                                 // BuildMemberComponents.cs:52
	            components,                                                                                                                    // BuildMemberComponents.cs:53
	            this.Shape_ComponentCode());                                                                                                   // BuildMemberComponents.cs:54
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberComponents.cs:55
	        foreach (Element element in elements)                                                                                              // BuildMemberComponents.cs:56
	            items.Add(new Item((CodeableConcept) element));                                                                                // BuildMemberComponents.cs:57
	        this.SetAllItems(items);                                                                                                           // BuildMemberComponents.cs:58
	    }                                                                                                                                      // BuildMemberComponents.cs:59
	}                                                                                                                                          // BuildMemberBase.cs:162
	#endregion                                                                                                                                 // BuildMemberBase.cs:163
	#region Observation.component:margin Container Class                                                                                       // BuildMemberBase.cs:140
	// Called from BuildMemberComponents.cs, Line 179
	// BuildMemberBase.cs:142
	/// <summary>
	/// Container class for Observation.component:margin.
	/// </summary>
	public class MarginContainer : MContainer, ITMItem<Observation.ComponentComponent>                                                         // BuildMemberBase.cs:145
	{                                                                                                                                          // BuildMemberBase.cs:146
	    #region Observation.component:margin Item Class                                                                                        // BuildMemberBase.cs:75
	    // Called from BuildMemberComponents.cs, Line 179
	    // BuildMemberBase.cs:77
	    /// <summary>
	    /// Item class for Observation.component:margin.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:80
	    {                                                                                                                                      // BuildMemberBase.cs:81
	        // Properties                                                                                                                      // BuildMemberBase.cs:82
	        // BuildMemberBase.cs:83
	        /// <summary>
	        /// Value
	        /// </summary>
	        public CodeableConcept Value { get; set; }                                                                                         // BuildMemberBase.cs:86
	                                                                                                                                           // BuildMemberBase.cs:88
	        // BuildMemberBase.cs:89
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(CodeableConcept value)                                                                                                 // BuildMemberBase.cs:92
	        {                                                                                                                                  // BuildMemberBase.cs:93
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:94
	        }                                                                                                                                  // BuildMemberBase.cs:96
	                                                                                                                                           // BuildMemberBase.cs:98
	        // Methods                                                                                                                         // BuildMemberBase.cs:99
	    }                                                                                                                                      // BuildMemberBase.cs:101
	    #endregion                                                                                                                             // BuildMemberBase.cs:102
	                                                                                                                                           // BuildMemberBase.cs:148
	    // Properties                                                                                                                          // BuildMemberBase.cs:149
	    #region Common Singleton Properties                                                                                                    // BuildMemberBase.cs:171
	                                                                                                                                           // BuildMemberBase.cs:172
	    // BuildMemberBase.cs:173
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems()                                                                                                        // BuildMemberBase.cs:176
	    {                                                                                                                                      // BuildMemberBase.cs:177
	        if (this.item != null) yield return this.item;                                                                                     // BuildMemberBase.cs:178
	    }                                                                                                                                      // BuildMemberBase.cs:179
	                                                                                                                                           // BuildMemberBase.cs:181
	    // BuildMemberBase.cs:182
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items)                                                                                              // BuildMemberBase.cs:185
	    {                                                                                                                                      // BuildMemberBase.cs:186
	        switch (items.Count())                                                                                                             // BuildMemberBase.cs:187
	        {                                                                                                                                  // BuildMemberBase.cs:188
	            case 0: break;                                                                                                                 // BuildMemberBase.cs:189
	            case 1: this.item = items.First(); break;                                                                                      // BuildMemberBase.cs:190
	            default: throw new Exception("Found multiple elements while reading single item");                                             // BuildMemberBase.cs:191
	        }                                                                                                                                  // BuildMemberBase.cs:192
	    }                                                                                                                                      // BuildMemberBase.cs:193
	                                                                                                                                           // BuildMemberBase.cs:195
	    // BuildMemberBase.cs:196
	    /// <summary>
	    /// Item
	    /// </summary>
	    Item item;                                                                                                                             // BuildMemberBase.cs:199
	                                                                                                                                           // BuildMemberBase.cs:201
	    // BuildMemberBase.cs:202
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => this.item == null ? 0 : 1;                                                                              // BuildMemberBase.cs:205
	                                                                                                                                           // BuildMemberBase.cs:207
	    // BuildMemberBase.cs:208
	    /// <summary>
	    /// Get Item's Value
	    /// </summary>
	    public CodeableConcept Get()                                                                                                           // BuildMemberBase.cs:211
	    {                                                                                                                                      // BuildMemberBase.cs:212
	        if (item == null)                                                                                                                  // BuildMemberBase.cs:213
	            return null;                                                                                                                   // BuildMemberBase.cs:214
	        return item.Value;                                                                                                                 // BuildMemberBase.cs:215
	    }                                                                                                                                      // BuildMemberBase.cs:216
	                                                                                                                                           // BuildMemberBase.cs:222
	    // BuildMemberBase.cs:223
	    /// <summary>
	    /// Set Item's Value
	    /// </summary>
	    public CodeableConcept Set(CodeableConcept value)                                                                                      // BuildMemberBase.cs:226
	    {                                                                                                                                      // BuildMemberBase.cs:227
	        this.item = new Item(value);                                                                                                       // BuildMemberBase.cs:228
	        return value;                                                                                                                      // BuildMemberBase.cs:229
	    }                                                                                                                                      // BuildMemberBase.cs:230
	    #endregion                                                                                                                             // BuildMemberBase.cs:304
	                                                                                                                                           // BuildMemberBase.cs:151
	    // BuildMemberBase.cs:152
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public MarginContainer(Int32 min, Int32 max) : base("Observation.component:margin", min, max)                                          // BuildMemberBase.cs:155
	    {                                                                                                                                      // BuildMemberBase.cs:156
	    }                                                                                                                                      // BuildMemberBase.cs:158
	                                                                                                                                           // BuildMemberBase.cs:159
	    // Methods                                                                                                                             // BuildMemberBase.cs:160
	    public CodeableConcept Margin_ComponentCode()                                                                                          // FhirConstruct.cs:753
	    {                                                                                                                                      // FhirConstruct.cs:754
	        CodeableConcept retVal = new CodeableConcept();                                                                                    // FhirConstruct.cs:755
	        retVal.Coding = new List<Coding>();                                                                                                // FhirConstruct.cs:761
	        {                                                                                                                                  // FhirConstruct.cs:764
	            var temp4 = new Coding();                                                                                                      // FhirConstruct.cs:765
	            temp4.SystemElement = new FhirUri();                                                                                           // FhirConstruct.cs:768
	            temp4.SystemElement.Value = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes";               // FhirConstruct.cs:770
	            temp4.CodeElement = new Code();                                                                                                // FhirConstruct.cs:784
	            temp4.CodeElement.Value = "margin";                                                                                            // FhirConstruct.cs:786
	            retVal.Coding.Add(temp4);                                                                                                      // FhirConstruct.cs:813
	        }                                                                                                                                  // FhirConstruct.cs:814
	        return retVal;                                                                                                                     // FhirConstruct.cs:829
	    }                                                                                                                                      // FhirConstruct.cs:830
	                                                                                                                                           // BuildMemberBase.cs:308
	    // BuildMemberBase.cs:309
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
	                Code = Margin_ComponentCode()                                                                                              // BuildMemberComponents.cs:77
	            };                                                                                                                             // BuildMemberComponents.cs:78
	            yield return component;                                                                                                        // BuildMemberComponents.cs:79
	        }                                                                                                                                  // BuildMemberComponents.cs:80
	    }                                                                                                                                      // BuildMemberComponents.cs:81
	                                                                                                                                           // BuildMemberBase.cs:314
	    // BuildMemberBase.cs:315
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	                                                                                                                                           // BuildMemberComponents.cs:49
	    public void Read(BreastRadiologyDocument doc, IEnumerable<Observation.ComponentComponent> components)                                  // BuildMemberComponents.cs:50
	    {                                                                                                                                      // BuildMemberComponents.cs:51
	        IEnumerable<Element> elements = base.IsMember(doc,                                                                                 // BuildMemberComponents.cs:52
	            components,                                                                                                                    // BuildMemberComponents.cs:53
	            this.Margin_ComponentCode());                                                                                                  // BuildMemberComponents.cs:54
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberComponents.cs:55
	        foreach (Element element in elements)                                                                                              // BuildMemberComponents.cs:56
	            items.Add(new Item((CodeableConcept) element));                                                                                // BuildMemberComponents.cs:57
	        this.SetAllItems(items);                                                                                                           // BuildMemberComponents.cs:58
	    }                                                                                                                                      // BuildMemberComponents.cs:59
	}                                                                                                                                          // BuildMemberBase.cs:162
	#endregion                                                                                                                                 // BuildMemberBase.cs:163
	#region Observation.component:mgDensity Container Class                                                                                    // BuildMemberBase.cs:140
	// Called from BuildMemberComponents.cs, Line 179
	// BuildMemberBase.cs:142
	/// <summary>
	/// Container class for Observation.component:mgDensity.
	/// </summary>
	public class MgDensityContainer : MContainer, ITMItem<Observation.ComponentComponent>                                                      // BuildMemberBase.cs:145
	{                                                                                                                                          // BuildMemberBase.cs:146
	    #region Observation.component:mgDensity Item Class                                                                                     // BuildMemberBase.cs:75
	    // Called from BuildMemberComponents.cs, Line 179
	    // BuildMemberBase.cs:77
	    /// <summary>
	    /// Item class for Observation.component:mgDensity.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:80
	    {                                                                                                                                      // BuildMemberBase.cs:81
	        // Properties                                                                                                                      // BuildMemberBase.cs:82
	        // BuildMemberBase.cs:83
	        /// <summary>
	        /// Value
	        /// </summary>
	        public CodeableConcept Value { get; set; }                                                                                         // BuildMemberBase.cs:86
	                                                                                                                                           // BuildMemberBase.cs:88
	        // BuildMemberBase.cs:89
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(CodeableConcept value)                                                                                                 // BuildMemberBase.cs:92
	        {                                                                                                                                  // BuildMemberBase.cs:93
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:94
	        }                                                                                                                                  // BuildMemberBase.cs:96
	                                                                                                                                           // BuildMemberBase.cs:98
	        // Methods                                                                                                                         // BuildMemberBase.cs:99
	    }                                                                                                                                      // BuildMemberBase.cs:101
	    #endregion                                                                                                                             // BuildMemberBase.cs:102
	                                                                                                                                           // BuildMemberBase.cs:148
	    // Properties                                                                                                                          // BuildMemberBase.cs:149
	    #region Common Singleton Properties                                                                                                    // BuildMemberBase.cs:171
	                                                                                                                                           // BuildMemberBase.cs:172
	    // BuildMemberBase.cs:173
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems()                                                                                                        // BuildMemberBase.cs:176
	    {                                                                                                                                      // BuildMemberBase.cs:177
	        if (this.item != null) yield return this.item;                                                                                     // BuildMemberBase.cs:178
	    }                                                                                                                                      // BuildMemberBase.cs:179
	                                                                                                                                           // BuildMemberBase.cs:181
	    // BuildMemberBase.cs:182
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items)                                                                                              // BuildMemberBase.cs:185
	    {                                                                                                                                      // BuildMemberBase.cs:186
	        switch (items.Count())                                                                                                             // BuildMemberBase.cs:187
	        {                                                                                                                                  // BuildMemberBase.cs:188
	            case 0: break;                                                                                                                 // BuildMemberBase.cs:189
	            case 1: this.item = items.First(); break;                                                                                      // BuildMemberBase.cs:190
	            default: throw new Exception("Found multiple elements while reading single item");                                             // BuildMemberBase.cs:191
	        }                                                                                                                                  // BuildMemberBase.cs:192
	    }                                                                                                                                      // BuildMemberBase.cs:193
	                                                                                                                                           // BuildMemberBase.cs:195
	    // BuildMemberBase.cs:196
	    /// <summary>
	    /// Item
	    /// </summary>
	    Item item;                                                                                                                             // BuildMemberBase.cs:199
	                                                                                                                                           // BuildMemberBase.cs:201
	    // BuildMemberBase.cs:202
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => this.item == null ? 0 : 1;                                                                              // BuildMemberBase.cs:205
	                                                                                                                                           // BuildMemberBase.cs:207
	    // BuildMemberBase.cs:208
	    /// <summary>
	    /// Get Item's Value
	    /// </summary>
	    public CodeableConcept Get()                                                                                                           // BuildMemberBase.cs:211
	    {                                                                                                                                      // BuildMemberBase.cs:212
	        if (item == null)                                                                                                                  // BuildMemberBase.cs:213
	            return null;                                                                                                                   // BuildMemberBase.cs:214
	        return item.Value;                                                                                                                 // BuildMemberBase.cs:215
	    }                                                                                                                                      // BuildMemberBase.cs:216
	                                                                                                                                           // BuildMemberBase.cs:222
	    // BuildMemberBase.cs:223
	    /// <summary>
	    /// Set Item's Value
	    /// </summary>
	    public CodeableConcept Set(CodeableConcept value)                                                                                      // BuildMemberBase.cs:226
	    {                                                                                                                                      // BuildMemberBase.cs:227
	        this.item = new Item(value);                                                                                                       // BuildMemberBase.cs:228
	        return value;                                                                                                                      // BuildMemberBase.cs:229
	    }                                                                                                                                      // BuildMemberBase.cs:230
	    #endregion                                                                                                                             // BuildMemberBase.cs:304
	                                                                                                                                           // BuildMemberBase.cs:151
	    // BuildMemberBase.cs:152
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public MgDensityContainer(Int32 min, Int32 max) : base("Observation.component:mgDensity", min, max)                                    // BuildMemberBase.cs:155
	    {                                                                                                                                      // BuildMemberBase.cs:156
	    }                                                                                                                                      // BuildMemberBase.cs:158
	                                                                                                                                           // BuildMemberBase.cs:159
	    // Methods                                                                                                                             // BuildMemberBase.cs:160
	    public CodeableConcept MgDensity_ComponentCode()                                                                                       // FhirConstruct.cs:753
	    {                                                                                                                                      // FhirConstruct.cs:754
	        CodeableConcept retVal = new CodeableConcept();                                                                                    // FhirConstruct.cs:755
	        retVal.Coding = new List<Coding>();                                                                                                // FhirConstruct.cs:761
	        {                                                                                                                                  // FhirConstruct.cs:764
	            var temp4 = new Coding();                                                                                                      // FhirConstruct.cs:765
	            temp4.SystemElement = new FhirUri();                                                                                           // FhirConstruct.cs:768
	            temp4.SystemElement.Value = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes";               // FhirConstruct.cs:770
	            temp4.CodeElement = new Code();                                                                                                // FhirConstruct.cs:784
	            temp4.CodeElement.Value = "mgDensity";                                                                                         // FhirConstruct.cs:786
	            retVal.Coding.Add(temp4);                                                                                                      // FhirConstruct.cs:813
	        }                                                                                                                                  // FhirConstruct.cs:814
	        return retVal;                                                                                                                     // FhirConstruct.cs:829
	    }                                                                                                                                      // FhirConstruct.cs:830
	                                                                                                                                           // BuildMemberBase.cs:308
	    // BuildMemberBase.cs:309
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
	                Code = MgDensity_ComponentCode()                                                                                           // BuildMemberComponents.cs:77
	            };                                                                                                                             // BuildMemberComponents.cs:78
	            yield return component;                                                                                                        // BuildMemberComponents.cs:79
	        }                                                                                                                                  // BuildMemberComponents.cs:80
	    }                                                                                                                                      // BuildMemberComponents.cs:81
	                                                                                                                                           // BuildMemberBase.cs:314
	    // BuildMemberBase.cs:315
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	                                                                                                                                           // BuildMemberComponents.cs:49
	    public void Read(BreastRadiologyDocument doc, IEnumerable<Observation.ComponentComponent> components)                                  // BuildMemberComponents.cs:50
	    {                                                                                                                                      // BuildMemberComponents.cs:51
	        IEnumerable<Element> elements = base.IsMember(doc,                                                                                 // BuildMemberComponents.cs:52
	            components,                                                                                                                    // BuildMemberComponents.cs:53
	            this.MgDensity_ComponentCode());                                                                                               // BuildMemberComponents.cs:54
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberComponents.cs:55
	        foreach (Element element in elements)                                                                                              // BuildMemberComponents.cs:56
	            items.Add(new Item((CodeableConcept) element));                                                                                // BuildMemberComponents.cs:57
	        this.SetAllItems(items);                                                                                                           // BuildMemberComponents.cs:58
	    }                                                                                                                                      // BuildMemberComponents.cs:59
	}                                                                                                                                          // BuildMemberBase.cs:162
	#endregion                                                                                                                                 // BuildMemberBase.cs:163
	//- LocalClassDefs
}
