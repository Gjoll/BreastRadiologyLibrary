using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib;
using BreastRadLib.ExtensionLocal;

//+Usings
//-Usings

namespace BreastRadLib.BreastBodyLocationExtensionLocal
{
	//+ LocalClassDefs
	/// <summary>
	/// Container class for Extension.
	/// </summary>
	public class BreastBodyLocationExtensionCollection : MContainer, ITMItem<Extension>                                                        // BuildMemberBase.cs:135
	{                                                                                                                                          // BuildMemberBase.cs:136
	    /// <summary>
	    /// Item class for Extension.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:73
	    {                                                                                                                                      // BuildMemberBase.cs:74
	        // Properties                                                                                                                      // BuildMemberBase.cs:75
	        /// <summary>
	        /// Value
	        /// </summary>
	        public BreastBodyLocationExtension Value { get; set; }                                                                             // BuildMemberBase.cs:79
	                                                                                                                                           // BuildMemberBase.cs:81
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(BreastBodyLocationExtension value)                                                                                     // BuildMemberBase.cs:85
	        {                                                                                                                                  // BuildMemberBase.cs:86
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:87
	        }                                                                                                                                  // BuildMemberBase.cs:89
	                                                                                                                                           // BuildMemberBase.cs:91
	        // Methods                                                                                                                         // BuildMemberBase.cs:92
	    }                                                                                                                                      // BuildMemberBase.cs:94
	    /// <summary>
	    /// Extension Item class for BreastBodyLocationExtension.
	    /// </summary>
	    public class BreastBodyLocationExtension                                                                                               // BuildMemberExtensionComplex.cs:84
	    {                                                                                                                                      // BuildMemberExtensionComplex.cs:85
	        // Definitions                                                                                                                     // BuildMemberExtensionComplex.cs:86
	        /// <summary>
	        /// Container class for Extension.extension:quadrant.
	        /// </summary>
	        public class QuadrantCollection : MContainer, ITMItem<Extension>                                                                   // BuildMemberBase.cs:135
	        {                                                                                                                                  // BuildMemberBase.cs:136
	            /// <summary>
	            /// Item class for Extension.extension:quadrant.
	            /// </summary>
	            public class Item                                                                                                              // BuildMemberBase.cs:73
	            {                                                                                                                              // BuildMemberBase.cs:74
	                // Properties                                                                                                              // BuildMemberBase.cs:75
	                /// <summary>
	                /// Value
	                /// </summary>
	                public CodeableConcept Value { get; set; }                                                                                 // BuildMemberBase.cs:79
	                                                                                                                                           // BuildMemberBase.cs:81
	                /// <summary>
	                /// Constructor
	                /// </summary>
	                public Item(CodeableConcept value)                                                                                         // BuildMemberBase.cs:85
	                {                                                                                                                          // BuildMemberBase.cs:86
	                    this.Value = value;                                                                                                    // BuildMemberBase.cs:87
	                }                                                                                                                          // BuildMemberBase.cs:89
	                                                                                                                                           // BuildMemberBase.cs:91
	                // Methods                                                                                                                 // BuildMemberBase.cs:92
	            }                                                                                                                              // BuildMemberBase.cs:94
	                                                                                                                                           // BuildMemberBase.cs:138
	            // Properties                                                                                                                  // BuildMemberBase.cs:139
	            public const String ExtensionUrl = "quadrant";                                                                                 // BuildMemberExtensionSimple.cs:39
	                                                                                                                                           // BuildMemberBase.cs:160
	            /// <summary>
	            /// Get All Items
	            /// </summary>
	            IEnumerable<Item> GetAllItems()                                                                                                // BuildMemberBase.cs:164
	            {                                                                                                                              // BuildMemberBase.cs:165
	                if (this.item != null) yield return this.item;                                                                             // BuildMemberBase.cs:166
	            }                                                                                                                              // BuildMemberBase.cs:167
	                                                                                                                                           // BuildMemberBase.cs:169
	            /// <summary>
	            /// Set All Items
	            /// </summary>
	            void SetAllItems(IEnumerable<Item> items)                                                                                      // BuildMemberBase.cs:173
	            {                                                                                                                              // BuildMemberBase.cs:174
	                switch (items.Count())                                                                                                     // BuildMemberBase.cs:175
	                {                                                                                                                          // BuildMemberBase.cs:176
	                    case 0: break;                                                                                                         // BuildMemberBase.cs:177
	                    case 1: this.item = items.First(); break;                                                                              // BuildMemberBase.cs:178
	                    default: throw new Exception("Found multiple elements while reading single item");                                     // BuildMemberBase.cs:179
	                }                                                                                                                          // BuildMemberBase.cs:180
	            }                                                                                                                              // BuildMemberBase.cs:181
	                                                                                                                                           // BuildMemberBase.cs:183
	            /// <summary>
	            /// Item
	            /// </summary>
	            Item item;                                                                                                                     // BuildMemberBase.cs:187
	                                                                                                                                           // BuildMemberBase.cs:189
	            /// <summary>
	            /// Count property
	            /// </summary>
	            public override Int32 Count => this.item == null ? 0 : 1;                                                                      // BuildMemberBase.cs:193
	                                                                                                                                           // BuildMemberBase.cs:195
	            /// <summary>
	            /// Get Item's Value
	            /// </summary>
	            public CodeableConcept Get()                                                                                                   // BuildMemberBase.cs:199
	            {                                                                                                                              // BuildMemberBase.cs:200
	                if (item == null)                                                                                                          // BuildMemberBase.cs:201
	                    return null;                                                                                                           // BuildMemberBase.cs:202
	                return item.Value;                                                                                                         // BuildMemberBase.cs:203
	            }                                                                                                                              // BuildMemberBase.cs:204
	                                                                                                                                           // BuildMemberBase.cs:210
	            /// <summary>
	            /// Set Item's Value
	            /// </summary>
	            public CodeableConcept Set(CodeableConcept value)                                                                              // BuildMemberBase.cs:214
	            {                                                                                                                              // BuildMemberBase.cs:215
	                this.item = new Item(value);                                                                                               // BuildMemberBase.cs:216
	                return value;                                                                                                              // BuildMemberBase.cs:217
	            }                                                                                                                              // BuildMemberBase.cs:218
	                                                                                                                                           // BuildMemberBase.cs:141
	            /// <summary>
	            /// Constructor
	            /// </summary>
	            public QuadrantCollection(Int32 min, Int32 max) : base("Extension.extension:quadrant", min, max)                               // BuildMemberBase.cs:145
	            {                                                                                                                              // BuildMemberBase.cs:146
	            }                                                                                                                              // BuildMemberBase.cs:148
	                                                                                                                                           // BuildMemberBase.cs:149
	            // Methods                                                                                                                     // BuildMemberBase.cs:150
	                                                                                                                                           // BuildMemberBase.cs:291
	            /// <summary>
	            /// Write single item as a fhir element.
	            /// </summary>
	            public IEnumerable<Extension> Write(BreastRadiologyDocument doc)                                                               // BuildMemberExtensionSimple.cs:68
	            {                                                                                                                              // BuildMemberExtensionSimple.cs:69
	                foreach (Item item in this.GetAllItems())                                                                                  // BuildMemberExtensionSimple.cs:70
	                {                                                                                                                          // BuildMemberExtensionSimple.cs:71
	                    yield return new Extension                                                                                             // BuildMemberExtensionSimple.cs:72
	                    {                                                                                                                      // BuildMemberExtensionSimple.cs:73
	                        Value = item.Value,                                                                                                // BuildMemberExtensionSimple.cs:74
	                        Url = ExtensionUrl                                                                                                 // BuildMemberExtensionSimple.cs:75
	                    };                                                                                                                     // BuildMemberExtensionSimple.cs:76
	                }                                                                                                                          // BuildMemberExtensionSimple.cs:77
	            }                                                                                                                              // BuildMemberExtensionSimple.cs:78
	                                                                                                                                           // BuildMemberBase.cs:297
	            /// <summary>
	            /// Read data from fhir element into member item.
	            /// </summary>
	                                                                                                                                           // BuildMemberExtensionSimple.cs:46
	            public void Read(BreastRadiologyDocument doc, IEnumerable<Extension> extensions)                                               // BuildMemberExtensionSimple.cs:47
	            {                                                                                                                              // BuildMemberExtensionSimple.cs:48
	                List<Extension> myExtensions = extensions                                                                                  // BuildMemberExtensionSimple.cs:49
	                    .Where((a) => String.Compare(a.Url, ExtensionUrl, true) == 0)                                                          // BuildMemberExtensionSimple.cs:50
	                    .ToList()                                                                                                              // BuildMemberExtensionSimple.cs:51
	                    ;                                                                                                                      // BuildMemberExtensionSimple.cs:52
	                List<Item> items = new List<Item>();                                                                                       // BuildMemberExtensionSimple.cs:53
	                foreach (Extension myExtension in myExtensions)                                                                            // BuildMemberExtensionSimple.cs:54
	                    items.Add(new Item((CodeableConcept) myExtension.Value));                                                              // BuildMemberExtensionSimple.cs:55
	                this.SetAllItems(items);                                                                                                   // BuildMemberExtensionSimple.cs:56
	            }                                                                                                                              // BuildMemberExtensionSimple.cs:57
	        }                                                                                                                                  // BuildMemberBase.cs:152
	        /// <summary>
	        /// Container class for Extension.extension:region.
	        /// </summary>
	        public class RegionCollection : MContainer, ITMItem<Extension>                                                                     // BuildMemberBase.cs:135
	        {                                                                                                                                  // BuildMemberBase.cs:136
	            /// <summary>
	            /// Item class for Extension.extension:region.
	            /// </summary>
	            public class Item                                                                                                              // BuildMemberBase.cs:73
	            {                                                                                                                              // BuildMemberBase.cs:74
	                // Properties                                                                                                              // BuildMemberBase.cs:75
	                /// <summary>
	                /// Value
	                /// </summary>
	                public CodeableConcept Value { get; set; }                                                                                 // BuildMemberBase.cs:79
	                                                                                                                                           // BuildMemberBase.cs:81
	                /// <summary>
	                /// Constructor
	                /// </summary>
	                public Item(CodeableConcept value)                                                                                         // BuildMemberBase.cs:85
	                {                                                                                                                          // BuildMemberBase.cs:86
	                    this.Value = value;                                                                                                    // BuildMemberBase.cs:87
	                }                                                                                                                          // BuildMemberBase.cs:89
	                                                                                                                                           // BuildMemberBase.cs:91
	                // Methods                                                                                                                 // BuildMemberBase.cs:92
	            }                                                                                                                              // BuildMemberBase.cs:94
	                                                                                                                                           // BuildMemberBase.cs:138
	            // Properties                                                                                                                  // BuildMemberBase.cs:139
	            public const String ExtensionUrl = "region";                                                                                   // BuildMemberExtensionSimple.cs:39
	            List<Item> items = new List<Item>();                                                                                           // BuildMemberBase.cs:225
	                                                                                                                                           // BuildMemberBase.cs:227
	            /// <summary>
	            /// Get All Items
	            /// </summary>
	            IEnumerable<Item> GetAllItems() => this.items;                                                                                 // BuildMemberBase.cs:231
	                                                                                                                                           // BuildMemberBase.cs:233
	            /// <summary>
	            /// Set All Items
	            /// </summary>
	            void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                      // BuildMemberBase.cs:237
	                                                                                                                                           // BuildMemberBase.cs:239
	            /// <summary>
	            /// Count property
	            /// </summary>
	            public override Int32 Count => items.Count;                                                                                    // BuildMemberBase.cs:243
	                                                                                                                                           // BuildMemberBase.cs:245
	            /// <summary>
	            /// Return all items
	            /// </summary>
	            public IEnumerable<CodeableConcept> All()                                                                                      // BuildMemberBase.cs:249
	            {                                                                                                                              // BuildMemberBase.cs:250
	                foreach (Item item in items)                                                                                               // BuildMemberBase.cs:251
	                   yield return item.Value;                                                                                                // BuildMemberBase.cs:252
	            }                                                                                                                              // BuildMemberBase.cs:253
	                                                                                                                                           // BuildMemberBase.cs:255
	            /// <summary>
	            /// Get Item's Value at indicated index
	            /// </summary>
	            public CodeableConcept GetAt(Int32 i) => this.items[i].Value;                                                                  // BuildMemberBase.cs:259
	                                                                                                                                           // BuildMemberBase.cs:261
	            /// <summary>
	            /// Remove Item at indicated index
	            /// </summary>
	            public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                       // BuildMemberBase.cs:265
	                                                                                                                                           // BuildMemberBase.cs:267
	            /// <summary>
	            /// Clear all items from collection
	            /// </summary>
	            public void Clear() => this.items.Clear();                                                                                     // BuildMemberBase.cs:271
	                                                                                                                                           // BuildMemberBase.cs:141
	            /// <summary>
	            /// Constructor
	            /// </summary>
	            public RegionCollection(Int32 min, Int32 max) : base("Extension.extension:region", min, max)                                   // BuildMemberBase.cs:145
	            {                                                                                                                              // BuildMemberBase.cs:146
	            }                                                                                                                              // BuildMemberBase.cs:148
	                                                                                                                                           // BuildMemberBase.cs:149
	            // Methods                                                                                                                     // BuildMemberBase.cs:150
	                                                                                                                                           // BuildMemberBase.cs:277
	            /// <summary>
	            /// Append value to collection
	            /// </summary>
	            public CodeableConcept Append(CodeableConcept value)                                                                           // BuildMemberBase.cs:281
	            {                                                                                                                              // BuildMemberBase.cs:282
	                this.items.Add(new Item(value));                                                                                           // BuildMemberBase.cs:283
	                return value;                                                                                                              // BuildMemberBase.cs:284
	            }                                                                                                                              // BuildMemberBase.cs:285
	                                                                                                                                           // BuildMemberBase.cs:291
	            /// <summary>
	            /// Write single item as a fhir element.
	            /// </summary>
	            public IEnumerable<Extension> Write(BreastRadiologyDocument doc)                                                               // BuildMemberExtensionSimple.cs:68
	            {                                                                                                                              // BuildMemberExtensionSimple.cs:69
	                foreach (Item item in this.GetAllItems())                                                                                  // BuildMemberExtensionSimple.cs:70
	                {                                                                                                                          // BuildMemberExtensionSimple.cs:71
	                    yield return new Extension                                                                                             // BuildMemberExtensionSimple.cs:72
	                    {                                                                                                                      // BuildMemberExtensionSimple.cs:73
	                        Value = item.Value,                                                                                                // BuildMemberExtensionSimple.cs:74
	                        Url = ExtensionUrl                                                                                                 // BuildMemberExtensionSimple.cs:75
	                    };                                                                                                                     // BuildMemberExtensionSimple.cs:76
	                }                                                                                                                          // BuildMemberExtensionSimple.cs:77
	            }                                                                                                                              // BuildMemberExtensionSimple.cs:78
	                                                                                                                                           // BuildMemberBase.cs:297
	            /// <summary>
	            /// Read data from fhir element into member item.
	            /// </summary>
	                                                                                                                                           // BuildMemberExtensionSimple.cs:46
	            public void Read(BreastRadiologyDocument doc, IEnumerable<Extension> extensions)                                               // BuildMemberExtensionSimple.cs:47
	            {                                                                                                                              // BuildMemberExtensionSimple.cs:48
	                List<Extension> myExtensions = extensions                                                                                  // BuildMemberExtensionSimple.cs:49
	                    .Where((a) => String.Compare(a.Url, ExtensionUrl, true) == 0)                                                          // BuildMemberExtensionSimple.cs:50
	                    .ToList()                                                                                                              // BuildMemberExtensionSimple.cs:51
	                    ;                                                                                                                      // BuildMemberExtensionSimple.cs:52
	                List<Item> items = new List<Item>();                                                                                       // BuildMemberExtensionSimple.cs:53
	                foreach (Extension myExtension in myExtensions)                                                                            // BuildMemberExtensionSimple.cs:54
	                    items.Add(new Item((CodeableConcept) myExtension.Value));                                                              // BuildMemberExtensionSimple.cs:55
	                this.SetAllItems(items);                                                                                                   // BuildMemberExtensionSimple.cs:56
	            }                                                                                                                              // BuildMemberExtensionSimple.cs:57
	        }                                                                                                                                  // BuildMemberBase.cs:152
	        /// <summary>
	        /// Container class for Extension.extension:clockDirection.
	        /// </summary>
	        public class ClockDirectionCollection : MContainer, ITMItem<Extension>                                                             // BuildMemberBase.cs:135
	        {                                                                                                                                  // BuildMemberBase.cs:136
	            /// <summary>
	            /// Item class for Extension.extension:clockDirection.
	            /// </summary>
	            public class Item                                                                                                              // BuildMemberBase.cs:73
	            {                                                                                                                              // BuildMemberBase.cs:74
	                // Properties                                                                                                              // BuildMemberBase.cs:75
	                /// <summary>
	                /// Value
	                /// </summary>
	                public CodeableConcept Value { get; set; }                                                                                 // BuildMemberBase.cs:79
	                                                                                                                                           // BuildMemberBase.cs:81
	                /// <summary>
	                /// Constructor
	                /// </summary>
	                public Item(CodeableConcept value)                                                                                         // BuildMemberBase.cs:85
	                {                                                                                                                          // BuildMemberBase.cs:86
	                    this.Value = value;                                                                                                    // BuildMemberBase.cs:87
	                }                                                                                                                          // BuildMemberBase.cs:89
	                                                                                                                                           // BuildMemberBase.cs:91
	                // Methods                                                                                                                 // BuildMemberBase.cs:92
	            }                                                                                                                              // BuildMemberBase.cs:94
	                                                                                                                                           // BuildMemberBase.cs:138
	            // Properties                                                                                                                  // BuildMemberBase.cs:139
	            public const String ExtensionUrl = "clockDirection";                                                                           // BuildMemberExtensionSimple.cs:39
	                                                                                                                                           // BuildMemberBase.cs:160
	            /// <summary>
	            /// Get All Items
	            /// </summary>
	            IEnumerable<Item> GetAllItems()                                                                                                // BuildMemberBase.cs:164
	            {                                                                                                                              // BuildMemberBase.cs:165
	                if (this.item != null) yield return this.item;                                                                             // BuildMemberBase.cs:166
	            }                                                                                                                              // BuildMemberBase.cs:167
	                                                                                                                                           // BuildMemberBase.cs:169
	            /// <summary>
	            /// Set All Items
	            /// </summary>
	            void SetAllItems(IEnumerable<Item> items)                                                                                      // BuildMemberBase.cs:173
	            {                                                                                                                              // BuildMemberBase.cs:174
	                switch (items.Count())                                                                                                     // BuildMemberBase.cs:175
	                {                                                                                                                          // BuildMemberBase.cs:176
	                    case 0: break;                                                                                                         // BuildMemberBase.cs:177
	                    case 1: this.item = items.First(); break;                                                                              // BuildMemberBase.cs:178
	                    default: throw new Exception("Found multiple elements while reading single item");                                     // BuildMemberBase.cs:179
	                }                                                                                                                          // BuildMemberBase.cs:180
	            }                                                                                                                              // BuildMemberBase.cs:181
	                                                                                                                                           // BuildMemberBase.cs:183
	            /// <summary>
	            /// Item
	            /// </summary>
	            Item item;                                                                                                                     // BuildMemberBase.cs:187
	                                                                                                                                           // BuildMemberBase.cs:189
	            /// <summary>
	            /// Count property
	            /// </summary>
	            public override Int32 Count => this.item == null ? 0 : 1;                                                                      // BuildMemberBase.cs:193
	                                                                                                                                           // BuildMemberBase.cs:195
	            /// <summary>
	            /// Get Item's Value
	            /// </summary>
	            public CodeableConcept Get()                                                                                                   // BuildMemberBase.cs:199
	            {                                                                                                                              // BuildMemberBase.cs:200
	                if (item == null)                                                                                                          // BuildMemberBase.cs:201
	                    return null;                                                                                                           // BuildMemberBase.cs:202
	                return item.Value;                                                                                                         // BuildMemberBase.cs:203
	            }                                                                                                                              // BuildMemberBase.cs:204
	                                                                                                                                           // BuildMemberBase.cs:210
	            /// <summary>
	            /// Set Item's Value
	            /// </summary>
	            public CodeableConcept Set(CodeableConcept value)                                                                              // BuildMemberBase.cs:214
	            {                                                                                                                              // BuildMemberBase.cs:215
	                this.item = new Item(value);                                                                                               // BuildMemberBase.cs:216
	                return value;                                                                                                              // BuildMemberBase.cs:217
	            }                                                                                                                              // BuildMemberBase.cs:218
	                                                                                                                                           // BuildMemberBase.cs:141
	            /// <summary>
	            /// Constructor
	            /// </summary>
	            public ClockDirectionCollection(Int32 min, Int32 max) : base("Extension.extension:clockDirection", min, max)                   // BuildMemberBase.cs:145
	            {                                                                                                                              // BuildMemberBase.cs:146
	            }                                                                                                                              // BuildMemberBase.cs:148
	                                                                                                                                           // BuildMemberBase.cs:149
	            // Methods                                                                                                                     // BuildMemberBase.cs:150
	                                                                                                                                           // BuildMemberBase.cs:291
	            /// <summary>
	            /// Write single item as a fhir element.
	            /// </summary>
	            public IEnumerable<Extension> Write(BreastRadiologyDocument doc)                                                               // BuildMemberExtensionSimple.cs:68
	            {                                                                                                                              // BuildMemberExtensionSimple.cs:69
	                foreach (Item item in this.GetAllItems())                                                                                  // BuildMemberExtensionSimple.cs:70
	                {                                                                                                                          // BuildMemberExtensionSimple.cs:71
	                    yield return new Extension                                                                                             // BuildMemberExtensionSimple.cs:72
	                    {                                                                                                                      // BuildMemberExtensionSimple.cs:73
	                        Value = item.Value,                                                                                                // BuildMemberExtensionSimple.cs:74
	                        Url = ExtensionUrl                                                                                                 // BuildMemberExtensionSimple.cs:75
	                    };                                                                                                                     // BuildMemberExtensionSimple.cs:76
	                }                                                                                                                          // BuildMemberExtensionSimple.cs:77
	            }                                                                                                                              // BuildMemberExtensionSimple.cs:78
	                                                                                                                                           // BuildMemberBase.cs:297
	            /// <summary>
	            /// Read data from fhir element into member item.
	            /// </summary>
	                                                                                                                                           // BuildMemberExtensionSimple.cs:46
	            public void Read(BreastRadiologyDocument doc, IEnumerable<Extension> extensions)                                               // BuildMemberExtensionSimple.cs:47
	            {                                                                                                                              // BuildMemberExtensionSimple.cs:48
	                List<Extension> myExtensions = extensions                                                                                  // BuildMemberExtensionSimple.cs:49
	                    .Where((a) => String.Compare(a.Url, ExtensionUrl, true) == 0)                                                          // BuildMemberExtensionSimple.cs:50
	                    .ToList()                                                                                                              // BuildMemberExtensionSimple.cs:51
	                    ;                                                                                                                      // BuildMemberExtensionSimple.cs:52
	                List<Item> items = new List<Item>();                                                                                       // BuildMemberExtensionSimple.cs:53
	                foreach (Extension myExtension in myExtensions)                                                                            // BuildMemberExtensionSimple.cs:54
	                    items.Add(new Item((CodeableConcept) myExtension.Value));                                                              // BuildMemberExtensionSimple.cs:55
	                this.SetAllItems(items);                                                                                                   // BuildMemberExtensionSimple.cs:56
	            }                                                                                                                              // BuildMemberExtensionSimple.cs:57
	        }                                                                                                                                  // BuildMemberBase.cs:152
	        /// <summary>
	        /// Container class for Extension.extension:depth.
	        /// </summary>
	        public class DepthCollection : MContainer, ITMItem<Extension>                                                                      // BuildMemberBase.cs:135
	        {                                                                                                                                  // BuildMemberBase.cs:136
	            /// <summary>
	            /// Item class for Extension.extension:depth.
	            /// </summary>
	            public class Item                                                                                                              // BuildMemberBase.cs:73
	            {                                                                                                                              // BuildMemberBase.cs:74
	                // Properties                                                                                                              // BuildMemberBase.cs:75
	                /// <summary>
	                /// Value
	                /// </summary>
	                public CodeableConcept Value { get; set; }                                                                                 // BuildMemberBase.cs:79
	                                                                                                                                           // BuildMemberBase.cs:81
	                /// <summary>
	                /// Constructor
	                /// </summary>
	                public Item(CodeableConcept value)                                                                                         // BuildMemberBase.cs:85
	                {                                                                                                                          // BuildMemberBase.cs:86
	                    this.Value = value;                                                                                                    // BuildMemberBase.cs:87
	                }                                                                                                                          // BuildMemberBase.cs:89
	                                                                                                                                           // BuildMemberBase.cs:91
	                // Methods                                                                                                                 // BuildMemberBase.cs:92
	            }                                                                                                                              // BuildMemberBase.cs:94
	                                                                                                                                           // BuildMemberBase.cs:138
	            // Properties                                                                                                                  // BuildMemberBase.cs:139
	            public const String ExtensionUrl = "depth";                                                                                    // BuildMemberExtensionSimple.cs:39
	                                                                                                                                           // BuildMemberBase.cs:160
	            /// <summary>
	            /// Get All Items
	            /// </summary>
	            IEnumerable<Item> GetAllItems()                                                                                                // BuildMemberBase.cs:164
	            {                                                                                                                              // BuildMemberBase.cs:165
	                if (this.item != null) yield return this.item;                                                                             // BuildMemberBase.cs:166
	            }                                                                                                                              // BuildMemberBase.cs:167
	                                                                                                                                           // BuildMemberBase.cs:169
	            /// <summary>
	            /// Set All Items
	            /// </summary>
	            void SetAllItems(IEnumerable<Item> items)                                                                                      // BuildMemberBase.cs:173
	            {                                                                                                                              // BuildMemberBase.cs:174
	                switch (items.Count())                                                                                                     // BuildMemberBase.cs:175
	                {                                                                                                                          // BuildMemberBase.cs:176
	                    case 0: break;                                                                                                         // BuildMemberBase.cs:177
	                    case 1: this.item = items.First(); break;                                                                              // BuildMemberBase.cs:178
	                    default: throw new Exception("Found multiple elements while reading single item");                                     // BuildMemberBase.cs:179
	                }                                                                                                                          // BuildMemberBase.cs:180
	            }                                                                                                                              // BuildMemberBase.cs:181
	                                                                                                                                           // BuildMemberBase.cs:183
	            /// <summary>
	            /// Item
	            /// </summary>
	            Item item;                                                                                                                     // BuildMemberBase.cs:187
	                                                                                                                                           // BuildMemberBase.cs:189
	            /// <summary>
	            /// Count property
	            /// </summary>
	            public override Int32 Count => this.item == null ? 0 : 1;                                                                      // BuildMemberBase.cs:193
	                                                                                                                                           // BuildMemberBase.cs:195
	            /// <summary>
	            /// Get Item's Value
	            /// </summary>
	            public CodeableConcept Get()                                                                                                   // BuildMemberBase.cs:199
	            {                                                                                                                              // BuildMemberBase.cs:200
	                if (item == null)                                                                                                          // BuildMemberBase.cs:201
	                    return null;                                                                                                           // BuildMemberBase.cs:202
	                return item.Value;                                                                                                         // BuildMemberBase.cs:203
	            }                                                                                                                              // BuildMemberBase.cs:204
	                                                                                                                                           // BuildMemberBase.cs:210
	            /// <summary>
	            /// Set Item's Value
	            /// </summary>
	            public CodeableConcept Set(CodeableConcept value)                                                                              // BuildMemberBase.cs:214
	            {                                                                                                                              // BuildMemberBase.cs:215
	                this.item = new Item(value);                                                                                               // BuildMemberBase.cs:216
	                return value;                                                                                                              // BuildMemberBase.cs:217
	            }                                                                                                                              // BuildMemberBase.cs:218
	                                                                                                                                           // BuildMemberBase.cs:141
	            /// <summary>
	            /// Constructor
	            /// </summary>
	            public DepthCollection(Int32 min, Int32 max) : base("Extension.extension:depth", min, max)                                     // BuildMemberBase.cs:145
	            {                                                                                                                              // BuildMemberBase.cs:146
	            }                                                                                                                              // BuildMemberBase.cs:148
	                                                                                                                                           // BuildMemberBase.cs:149
	            // Methods                                                                                                                     // BuildMemberBase.cs:150
	                                                                                                                                           // BuildMemberBase.cs:291
	            /// <summary>
	            /// Write single item as a fhir element.
	            /// </summary>
	            public IEnumerable<Extension> Write(BreastRadiologyDocument doc)                                                               // BuildMemberExtensionSimple.cs:68
	            {                                                                                                                              // BuildMemberExtensionSimple.cs:69
	                foreach (Item item in this.GetAllItems())                                                                                  // BuildMemberExtensionSimple.cs:70
	                {                                                                                                                          // BuildMemberExtensionSimple.cs:71
	                    yield return new Extension                                                                                             // BuildMemberExtensionSimple.cs:72
	                    {                                                                                                                      // BuildMemberExtensionSimple.cs:73
	                        Value = item.Value,                                                                                                // BuildMemberExtensionSimple.cs:74
	                        Url = ExtensionUrl                                                                                                 // BuildMemberExtensionSimple.cs:75
	                    };                                                                                                                     // BuildMemberExtensionSimple.cs:76
	                }                                                                                                                          // BuildMemberExtensionSimple.cs:77
	            }                                                                                                                              // BuildMemberExtensionSimple.cs:78
	                                                                                                                                           // BuildMemberBase.cs:297
	            /// <summary>
	            /// Read data from fhir element into member item.
	            /// </summary>
	                                                                                                                                           // BuildMemberExtensionSimple.cs:46
	            public void Read(BreastRadiologyDocument doc, IEnumerable<Extension> extensions)                                               // BuildMemberExtensionSimple.cs:47
	            {                                                                                                                              // BuildMemberExtensionSimple.cs:48
	                List<Extension> myExtensions = extensions                                                                                  // BuildMemberExtensionSimple.cs:49
	                    .Where((a) => String.Compare(a.Url, ExtensionUrl, true) == 0)                                                          // BuildMemberExtensionSimple.cs:50
	                    .ToList()                                                                                                              // BuildMemberExtensionSimple.cs:51
	                    ;                                                                                                                      // BuildMemberExtensionSimple.cs:52
	                List<Item> items = new List<Item>();                                                                                       // BuildMemberExtensionSimple.cs:53
	                foreach (Extension myExtension in myExtensions)                                                                            // BuildMemberExtensionSimple.cs:54
	                    items.Add(new Item((CodeableConcept) myExtension.Value));                                                              // BuildMemberExtensionSimple.cs:55
	                this.SetAllItems(items);                                                                                                   // BuildMemberExtensionSimple.cs:56
	            }                                                                                                                              // BuildMemberExtensionSimple.cs:57
	        }                                                                                                                                  // BuildMemberBase.cs:152
	        // Properties                                                                                                                      // BuildMemberExtensionComplex.cs:88
	                                                                                                                                           // BuildMemberBase.cs:330
	        /// <summary>
	        /// Quadrant
	        /// Access fhir element 'Extension.extension:quadrant'
	        /// </summary>
	        public QuadrantCollection Quadrant { get ; protected set; }                                                                        // BuildMemberBase.cs:335
	                                                                                                                                           // BuildMemberBase.cs:330
	        /// <summary>
	        /// Region
	        /// Access fhir element 'Extension.extension:region'
	        /// </summary>
	        public RegionCollection Region { get ; protected set; }                                                                            // BuildMemberBase.cs:335
	                                                                                                                                           // BuildMemberBase.cs:330
	        /// <summary>
	        /// ClockDirection
	        /// Access fhir element 'Extension.extension:clockDirection'
	        /// </summary>
	        public ClockDirectionCollection ClockDirection { get ; protected set; }                                                            // BuildMemberBase.cs:335
	                                                                                                                                           // BuildMemberBase.cs:330
	        /// <summary>
	        /// Depth
	        /// Access fhir element 'Extension.extension:depth'
	        /// </summary>
	        public DepthCollection Depth { get ; protected set; }                                                                              // BuildMemberBase.cs:335
	                                                                                                                                           // BuildMemberExtensionComplex.cs:90
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public BreastBodyLocationExtension()                                                                                               // BuildMemberExtensionComplex.cs:94
	        {                                                                                                                                  // BuildMemberExtensionComplex.cs:95
	            this.Quadrant = new QuadrantCollection(0, 0);                                                                                  // BuildMemberBase.cs:316
	            this.Region = new RegionCollection(0, 0);                                                                                      // BuildMemberBase.cs:316
	            this.ClockDirection = new ClockDirectionCollection(0, 0);                                                                      // BuildMemberBase.cs:316
	            this.Depth = new DepthCollection(0, 0);                                                                                        // BuildMemberBase.cs:316
	        }                                                                                                                                  // BuildMemberExtensionComplex.cs:97
	                                                                                                                                           // BuildMemberExtensionComplex.cs:99
	        // Methods                                                                                                                         // BuildMemberExtensionComplex.cs:100
	    }                                                                                                                                      // BuildMemberExtensionComplex.cs:102
	                                                                                                                                           // BuildMemberBase.cs:138
	    // Properties                                                                                                                          // BuildMemberBase.cs:139
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:225
	                                                                                                                                           // BuildMemberBase.cs:227
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:231
	                                                                                                                                           // BuildMemberBase.cs:233
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:237
	                                                                                                                                           // BuildMemberBase.cs:239
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:243
	                                                                                                                                           // BuildMemberBase.cs:245
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<BreastBodyLocationExtension> All()                                                                                  // BuildMemberBase.cs:249
	    {                                                                                                                                      // BuildMemberBase.cs:250
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:251
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:252
	    }                                                                                                                                      // BuildMemberBase.cs:253
	                                                                                                                                           // BuildMemberBase.cs:255
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public BreastBodyLocationExtension GetAt(Int32 i) => this.items[i].Value;                                                              // BuildMemberBase.cs:259
	                                                                                                                                           // BuildMemberBase.cs:261
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:265
	                                                                                                                                           // BuildMemberBase.cs:267
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:271
	                                                                                                                                           // BuildMemberBase.cs:141
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public BreastBodyLocationExtensionCollection(Int32 min, Int32 max) : base("Extension", min, max)                                       // BuildMemberBase.cs:145
	    {                                                                                                                                      // BuildMemberBase.cs:146
	    }                                                                                                                                      // BuildMemberBase.cs:148
	                                                                                                                                           // BuildMemberBase.cs:149
	    // Methods                                                                                                                             // BuildMemberBase.cs:150
	                                                                                                                                           // BuildMemberBase.cs:277
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public BreastBodyLocationExtension Append(BreastBodyLocationExtension value)                                                           // BuildMemberBase.cs:281
	    {                                                                                                                                      // BuildMemberBase.cs:282
	        this.items.Add(new Item(value));                                                                                                   // BuildMemberBase.cs:283
	        return value;                                                                                                                      // BuildMemberBase.cs:284
	    }                                                                                                                                      // BuildMemberBase.cs:285
	                                                                                                                                           // BuildMemberBase.cs:291
	    /// <summary>
	    /// Write single item as a fhir element.
	    /// </summary>
	    public IEnumerable<Extension> Write(BreastRadiologyDocument doc)                                                                       // BuildMemberExtensionComplex.cs:56
	    {                                                                                                                                      // BuildMemberExtensionComplex.cs:57
	        throw new NotImplementedException();                                                                                               // BuildMemberExtensionComplex.cs:58
	    }                                                                                                                                      // BuildMemberExtensionComplex.cs:68
	                                                                                                                                           // BuildMemberBase.cs:297
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	                                                                                                                                           // BuildMemberExtensionComplex.cs:37
	    public void Read(BreastRadiologyDocument doc, IEnumerable<Extension> components)                                                       // BuildMemberExtensionComplex.cs:38
	    {                                                                                                                                      // BuildMemberExtensionComplex.cs:39
	        throw new NotImplementedException();                                                                                               // BuildMemberExtensionComplex.cs:40
	    }                                                                                                                                      // BuildMemberExtensionComplex.cs:45
	}                                                                                                                                          // BuildMemberBase.cs:152
	//- LocalClassDefs
}
