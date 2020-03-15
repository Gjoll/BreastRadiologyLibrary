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
	#region BreastBodyLocationExtension Container Class                                                                                        // BuildMemberBase.cs:137
	/// <summary>
	/// Container class for BreastBodyLocationExtension.
	/// </summary>
	public class BreastBodyLocationExtensionCollection : MContainer, ITMItem<Extension>                                                        // BuildMemberBase.cs:141
	{                                                                                                                                          // BuildMemberBase.cs:142
	    #region BreastBodyLocationExtension Item Class                                                                                         // BuildMemberBase.cs:73
	    /// <summary>
	    /// Item class for BreastBodyLocationExtension.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:77
	    {                                                                                                                                      // BuildMemberBase.cs:78
	        // Properties                                                                                                                      // BuildMemberBase.cs:79
	        /// <summary>
	        /// Value
	        /// </summary>
	        public BreastBodyLocationExtension Value { get; set; }                                                                             // BuildMemberBase.cs:83
	                                                                                                                                           // BuildMemberBase.cs:85
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(BreastBodyLocationExtension value)                                                                                     // BuildMemberBase.cs:89
	        {                                                                                                                                  // BuildMemberBase.cs:90
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:91
	        }                                                                                                                                  // BuildMemberBase.cs:93
	                                                                                                                                           // BuildMemberBase.cs:95
	        // Methods                                                                                                                         // BuildMemberBase.cs:96
	    }                                                                                                                                      // BuildMemberBase.cs:98
	    #endregion                                                                                                                             // BuildMemberBase.cs:99
	    /// <summary>
	    /// Extension Item class for BreastBodyLocationExtension.
	    /// </summary>
	    public class BreastBodyLocationExtension                                                                                               // BuildMemberExtensionComplex.cs:84
	    {                                                                                                                                      // BuildMemberExtensionComplex.cs:85
	        // Definitions                                                                                                                     // BuildMemberExtensionComplex.cs:86
	        #region Extension.extension:quadrant Container Class                                                                               // BuildMemberBase.cs:137
	        /// <summary>
	        /// Container class for Extension.extension:quadrant.
	        /// </summary>
	        public class QuadrantCollection : MContainer, ITMItem<Extension>                                                                   // BuildMemberBase.cs:141
	        {                                                                                                                                  // BuildMemberBase.cs:142
	            #region Extension.extension:quadrant Item Class                                                                                // BuildMemberBase.cs:73
	            /// <summary>
	            /// Item class for Extension.extension:quadrant.
	            /// </summary>
	            public class Item                                                                                                              // BuildMemberBase.cs:77
	            {                                                                                                                              // BuildMemberBase.cs:78
	                // Properties                                                                                                              // BuildMemberBase.cs:79
	                /// <summary>
	                /// Value
	                /// </summary>
	                public CodeableConcept Value { get; set; }                                                                                 // BuildMemberBase.cs:83
	                                                                                                                                           // BuildMemberBase.cs:85
	                /// <summary>
	                /// Constructor
	                /// </summary>
	                public Item(CodeableConcept value)                                                                                         // BuildMemberBase.cs:89
	                {                                                                                                                          // BuildMemberBase.cs:90
	                    this.Value = value;                                                                                                    // BuildMemberBase.cs:91
	                }                                                                                                                          // BuildMemberBase.cs:93
	                                                                                                                                           // BuildMemberBase.cs:95
	                // Methods                                                                                                                 // BuildMemberBase.cs:96
	            }                                                                                                                              // BuildMemberBase.cs:98
	            #endregion                                                                                                                     // BuildMemberBase.cs:99
	                                                                                                                                           // BuildMemberBase.cs:144
	            // Properties                                                                                                                  // BuildMemberBase.cs:145
	            public const String ExtensionUrl = "quadrant";                                                                                 // BuildMemberExtensionSimple.cs:39
	                                                                                                                                           // BuildMemberBase.cs:167
	            /// <summary>
	            /// Get All Items
	            /// </summary>
	            IEnumerable<Item> GetAllItems()                                                                                                // BuildMemberBase.cs:171
	            {                                                                                                                              // BuildMemberBase.cs:172
	                if (this.item != null) yield return this.item;                                                                             // BuildMemberBase.cs:173
	            }                                                                                                                              // BuildMemberBase.cs:174
	                                                                                                                                           // BuildMemberBase.cs:176
	            /// <summary>
	            /// Set All Items
	            /// </summary>
	            void SetAllItems(IEnumerable<Item> items)                                                                                      // BuildMemberBase.cs:180
	            {                                                                                                                              // BuildMemberBase.cs:181
	                switch (items.Count())                                                                                                     // BuildMemberBase.cs:182
	                {                                                                                                                          // BuildMemberBase.cs:183
	                    case 0: break;                                                                                                         // BuildMemberBase.cs:184
	                    case 1: this.item = items.First(); break;                                                                              // BuildMemberBase.cs:185
	                    default: throw new Exception("Found multiple elements while reading single item");                                     // BuildMemberBase.cs:186
	                }                                                                                                                          // BuildMemberBase.cs:187
	            }                                                                                                                              // BuildMemberBase.cs:188
	                                                                                                                                           // BuildMemberBase.cs:190
	            /// <summary>
	            /// Item
	            /// </summary>
	            Item item;                                                                                                                     // BuildMemberBase.cs:194
	                                                                                                                                           // BuildMemberBase.cs:196
	            /// <summary>
	            /// Count property
	            /// </summary>
	            public override Int32 Count => this.item == null ? 0 : 1;                                                                      // BuildMemberBase.cs:200
	                                                                                                                                           // BuildMemberBase.cs:202
	            /// <summary>
	            /// Get Item's Value
	            /// </summary>
	            public CodeableConcept Get()                                                                                                   // BuildMemberBase.cs:206
	            {                                                                                                                              // BuildMemberBase.cs:207
	                if (item == null)                                                                                                          // BuildMemberBase.cs:208
	                    return null;                                                                                                           // BuildMemberBase.cs:209
	                return item.Value;                                                                                                         // BuildMemberBase.cs:210
	            }                                                                                                                              // BuildMemberBase.cs:211
	                                                                                                                                           // BuildMemberBase.cs:217
	            /// <summary>
	            /// Set Item's Value
	            /// </summary>
	            public CodeableConcept Set(CodeableConcept value)                                                                              // BuildMemberBase.cs:221
	            {                                                                                                                              // BuildMemberBase.cs:222
	                this.item = new Item(value);                                                                                               // BuildMemberBase.cs:223
	                return value;                                                                                                              // BuildMemberBase.cs:224
	            }                                                                                                                              // BuildMemberBase.cs:225
	                                                                                                                                           // BuildMemberBase.cs:147
	            /// <summary>
	            /// Constructor
	            /// </summary>
	            public QuadrantCollection(Int32 min, Int32 max) : base("Extension.extension:quadrant", min, max)                               // BuildMemberBase.cs:151
	            {                                                                                                                              // BuildMemberBase.cs:152
	            }                                                                                                                              // BuildMemberBase.cs:154
	                                                                                                                                           // BuildMemberBase.cs:155
	            // Methods                                                                                                                     // BuildMemberBase.cs:156
	                                                                                                                                           // BuildMemberBase.cs:298
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
	                                                                                                                                           // BuildMemberBase.cs:304
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
	        }                                                                                                                                  // BuildMemberBase.cs:158
	        #endregion                                                                                                                         // BuildMemberBase.cs:159
	        #region Extension.extension:region Container Class                                                                                 // BuildMemberBase.cs:137
	        /// <summary>
	        /// Container class for Extension.extension:region.
	        /// </summary>
	        public class RegionCollection : MContainer, ITMItem<Extension>                                                                     // BuildMemberBase.cs:141
	        {                                                                                                                                  // BuildMemberBase.cs:142
	            #region Extension.extension:region Item Class                                                                                  // BuildMemberBase.cs:73
	            /// <summary>
	            /// Item class for Extension.extension:region.
	            /// </summary>
	            public class Item                                                                                                              // BuildMemberBase.cs:77
	            {                                                                                                                              // BuildMemberBase.cs:78
	                // Properties                                                                                                              // BuildMemberBase.cs:79
	                /// <summary>
	                /// Value
	                /// </summary>
	                public CodeableConcept Value { get; set; }                                                                                 // BuildMemberBase.cs:83
	                                                                                                                                           // BuildMemberBase.cs:85
	                /// <summary>
	                /// Constructor
	                /// </summary>
	                public Item(CodeableConcept value)                                                                                         // BuildMemberBase.cs:89
	                {                                                                                                                          // BuildMemberBase.cs:90
	                    this.Value = value;                                                                                                    // BuildMemberBase.cs:91
	                }                                                                                                                          // BuildMemberBase.cs:93
	                                                                                                                                           // BuildMemberBase.cs:95
	                // Methods                                                                                                                 // BuildMemberBase.cs:96
	            }                                                                                                                              // BuildMemberBase.cs:98
	            #endregion                                                                                                                     // BuildMemberBase.cs:99
	                                                                                                                                           // BuildMemberBase.cs:144
	            // Properties                                                                                                                  // BuildMemberBase.cs:145
	            public const String ExtensionUrl = "region";                                                                                   // BuildMemberExtensionSimple.cs:39
	            List<Item> items = new List<Item>();                                                                                           // BuildMemberBase.cs:232
	                                                                                                                                           // BuildMemberBase.cs:234
	            /// <summary>
	            /// Get All Items
	            /// </summary>
	            IEnumerable<Item> GetAllItems() => this.items;                                                                                 // BuildMemberBase.cs:238
	                                                                                                                                           // BuildMemberBase.cs:240
	            /// <summary>
	            /// Set All Items
	            /// </summary>
	            void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                      // BuildMemberBase.cs:244
	                                                                                                                                           // BuildMemberBase.cs:246
	            /// <summary>
	            /// Count property
	            /// </summary>
	            public override Int32 Count => items.Count;                                                                                    // BuildMemberBase.cs:250
	                                                                                                                                           // BuildMemberBase.cs:252
	            /// <summary>
	            /// Return all items
	            /// </summary>
	            public IEnumerable<CodeableConcept> All()                                                                                      // BuildMemberBase.cs:256
	            {                                                                                                                              // BuildMemberBase.cs:257
	                foreach (Item item in items)                                                                                               // BuildMemberBase.cs:258
	                   yield return item.Value;                                                                                                // BuildMemberBase.cs:259
	            }                                                                                                                              // BuildMemberBase.cs:260
	                                                                                                                                           // BuildMemberBase.cs:262
	            /// <summary>
	            /// Get Item's Value at indicated index
	            /// </summary>
	            public CodeableConcept GetAt(Int32 i) => this.items[i].Value;                                                                  // BuildMemberBase.cs:266
	                                                                                                                                           // BuildMemberBase.cs:268
	            /// <summary>
	            /// Remove Item at indicated index
	            /// </summary>
	            public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                       // BuildMemberBase.cs:272
	                                                                                                                                           // BuildMemberBase.cs:274
	            /// <summary>
	            /// Clear all items from collection
	            /// </summary>
	            public void Clear() => this.items.Clear();                                                                                     // BuildMemberBase.cs:278
	                                                                                                                                           // BuildMemberBase.cs:147
	            /// <summary>
	            /// Constructor
	            /// </summary>
	            public RegionCollection(Int32 min, Int32 max) : base("Extension.extension:region", min, max)                                   // BuildMemberBase.cs:151
	            {                                                                                                                              // BuildMemberBase.cs:152
	            }                                                                                                                              // BuildMemberBase.cs:154
	                                                                                                                                           // BuildMemberBase.cs:155
	            // Methods                                                                                                                     // BuildMemberBase.cs:156
	                                                                                                                                           // BuildMemberBase.cs:284
	            /// <summary>
	            /// Append value to collection
	            /// </summary>
	            public CodeableConcept Append(CodeableConcept value)                                                                           // BuildMemberBase.cs:288
	            {                                                                                                                              // BuildMemberBase.cs:289
	                this.items.Add(new Item(value));                                                                                           // BuildMemberBase.cs:290
	                return value;                                                                                                              // BuildMemberBase.cs:291
	            }                                                                                                                              // BuildMemberBase.cs:292
	                                                                                                                                           // BuildMemberBase.cs:298
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
	                                                                                                                                           // BuildMemberBase.cs:304
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
	        }                                                                                                                                  // BuildMemberBase.cs:158
	        #endregion                                                                                                                         // BuildMemberBase.cs:159
	        #region Extension.extension:clockDirection Container Class                                                                         // BuildMemberBase.cs:137
	        /// <summary>
	        /// Container class for Extension.extension:clockDirection.
	        /// </summary>
	        public class ClockDirectionCollection : MContainer, ITMItem<Extension>                                                             // BuildMemberBase.cs:141
	        {                                                                                                                                  // BuildMemberBase.cs:142
	            #region Extension.extension:clockDirection Item Class                                                                          // BuildMemberBase.cs:73
	            /// <summary>
	            /// Item class for Extension.extension:clockDirection.
	            /// </summary>
	            public class Item                                                                                                              // BuildMemberBase.cs:77
	            {                                                                                                                              // BuildMemberBase.cs:78
	                // Properties                                                                                                              // BuildMemberBase.cs:79
	                /// <summary>
	                /// Value
	                /// </summary>
	                public CodeableConcept Value { get; set; }                                                                                 // BuildMemberBase.cs:83
	                                                                                                                                           // BuildMemberBase.cs:85
	                /// <summary>
	                /// Constructor
	                /// </summary>
	                public Item(CodeableConcept value)                                                                                         // BuildMemberBase.cs:89
	                {                                                                                                                          // BuildMemberBase.cs:90
	                    this.Value = value;                                                                                                    // BuildMemberBase.cs:91
	                }                                                                                                                          // BuildMemberBase.cs:93
	                                                                                                                                           // BuildMemberBase.cs:95
	                // Methods                                                                                                                 // BuildMemberBase.cs:96
	            }                                                                                                                              // BuildMemberBase.cs:98
	            #endregion                                                                                                                     // BuildMemberBase.cs:99
	                                                                                                                                           // BuildMemberBase.cs:144
	            // Properties                                                                                                                  // BuildMemberBase.cs:145
	            public const String ExtensionUrl = "clockDirection";                                                                           // BuildMemberExtensionSimple.cs:39
	                                                                                                                                           // BuildMemberBase.cs:167
	            /// <summary>
	            /// Get All Items
	            /// </summary>
	            IEnumerable<Item> GetAllItems()                                                                                                // BuildMemberBase.cs:171
	            {                                                                                                                              // BuildMemberBase.cs:172
	                if (this.item != null) yield return this.item;                                                                             // BuildMemberBase.cs:173
	            }                                                                                                                              // BuildMemberBase.cs:174
	                                                                                                                                           // BuildMemberBase.cs:176
	            /// <summary>
	            /// Set All Items
	            /// </summary>
	            void SetAllItems(IEnumerable<Item> items)                                                                                      // BuildMemberBase.cs:180
	            {                                                                                                                              // BuildMemberBase.cs:181
	                switch (items.Count())                                                                                                     // BuildMemberBase.cs:182
	                {                                                                                                                          // BuildMemberBase.cs:183
	                    case 0: break;                                                                                                         // BuildMemberBase.cs:184
	                    case 1: this.item = items.First(); break;                                                                              // BuildMemberBase.cs:185
	                    default: throw new Exception("Found multiple elements while reading single item");                                     // BuildMemberBase.cs:186
	                }                                                                                                                          // BuildMemberBase.cs:187
	            }                                                                                                                              // BuildMemberBase.cs:188
	                                                                                                                                           // BuildMemberBase.cs:190
	            /// <summary>
	            /// Item
	            /// </summary>
	            Item item;                                                                                                                     // BuildMemberBase.cs:194
	                                                                                                                                           // BuildMemberBase.cs:196
	            /// <summary>
	            /// Count property
	            /// </summary>
	            public override Int32 Count => this.item == null ? 0 : 1;                                                                      // BuildMemberBase.cs:200
	                                                                                                                                           // BuildMemberBase.cs:202
	            /// <summary>
	            /// Get Item's Value
	            /// </summary>
	            public CodeableConcept Get()                                                                                                   // BuildMemberBase.cs:206
	            {                                                                                                                              // BuildMemberBase.cs:207
	                if (item == null)                                                                                                          // BuildMemberBase.cs:208
	                    return null;                                                                                                           // BuildMemberBase.cs:209
	                return item.Value;                                                                                                         // BuildMemberBase.cs:210
	            }                                                                                                                              // BuildMemberBase.cs:211
	                                                                                                                                           // BuildMemberBase.cs:217
	            /// <summary>
	            /// Set Item's Value
	            /// </summary>
	            public CodeableConcept Set(CodeableConcept value)                                                                              // BuildMemberBase.cs:221
	            {                                                                                                                              // BuildMemberBase.cs:222
	                this.item = new Item(value);                                                                                               // BuildMemberBase.cs:223
	                return value;                                                                                                              // BuildMemberBase.cs:224
	            }                                                                                                                              // BuildMemberBase.cs:225
	                                                                                                                                           // BuildMemberBase.cs:147
	            /// <summary>
	            /// Constructor
	            /// </summary>
	            public ClockDirectionCollection(Int32 min, Int32 max) : base("Extension.extension:clockDirection", min, max)                   // BuildMemberBase.cs:151
	            {                                                                                                                              // BuildMemberBase.cs:152
	            }                                                                                                                              // BuildMemberBase.cs:154
	                                                                                                                                           // BuildMemberBase.cs:155
	            // Methods                                                                                                                     // BuildMemberBase.cs:156
	                                                                                                                                           // BuildMemberBase.cs:298
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
	                                                                                                                                           // BuildMemberBase.cs:304
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
	        }                                                                                                                                  // BuildMemberBase.cs:158
	        #endregion                                                                                                                         // BuildMemberBase.cs:159
	        #region Extension.extension:depth Container Class                                                                                  // BuildMemberBase.cs:137
	        /// <summary>
	        /// Container class for Extension.extension:depth.
	        /// </summary>
	        public class DepthCollection : MContainer, ITMItem<Extension>                                                                      // BuildMemberBase.cs:141
	        {                                                                                                                                  // BuildMemberBase.cs:142
	            #region Extension.extension:depth Item Class                                                                                   // BuildMemberBase.cs:73
	            /// <summary>
	            /// Item class for Extension.extension:depth.
	            /// </summary>
	            public class Item                                                                                                              // BuildMemberBase.cs:77
	            {                                                                                                                              // BuildMemberBase.cs:78
	                // Properties                                                                                                              // BuildMemberBase.cs:79
	                /// <summary>
	                /// Value
	                /// </summary>
	                public CodeableConcept Value { get; set; }                                                                                 // BuildMemberBase.cs:83
	                                                                                                                                           // BuildMemberBase.cs:85
	                /// <summary>
	                /// Constructor
	                /// </summary>
	                public Item(CodeableConcept value)                                                                                         // BuildMemberBase.cs:89
	                {                                                                                                                          // BuildMemberBase.cs:90
	                    this.Value = value;                                                                                                    // BuildMemberBase.cs:91
	                }                                                                                                                          // BuildMemberBase.cs:93
	                                                                                                                                           // BuildMemberBase.cs:95
	                // Methods                                                                                                                 // BuildMemberBase.cs:96
	            }                                                                                                                              // BuildMemberBase.cs:98
	            #endregion                                                                                                                     // BuildMemberBase.cs:99
	                                                                                                                                           // BuildMemberBase.cs:144
	            // Properties                                                                                                                  // BuildMemberBase.cs:145
	            public const String ExtensionUrl = "depth";                                                                                    // BuildMemberExtensionSimple.cs:39
	                                                                                                                                           // BuildMemberBase.cs:167
	            /// <summary>
	            /// Get All Items
	            /// </summary>
	            IEnumerable<Item> GetAllItems()                                                                                                // BuildMemberBase.cs:171
	            {                                                                                                                              // BuildMemberBase.cs:172
	                if (this.item != null) yield return this.item;                                                                             // BuildMemberBase.cs:173
	            }                                                                                                                              // BuildMemberBase.cs:174
	                                                                                                                                           // BuildMemberBase.cs:176
	            /// <summary>
	            /// Set All Items
	            /// </summary>
	            void SetAllItems(IEnumerable<Item> items)                                                                                      // BuildMemberBase.cs:180
	            {                                                                                                                              // BuildMemberBase.cs:181
	                switch (items.Count())                                                                                                     // BuildMemberBase.cs:182
	                {                                                                                                                          // BuildMemberBase.cs:183
	                    case 0: break;                                                                                                         // BuildMemberBase.cs:184
	                    case 1: this.item = items.First(); break;                                                                              // BuildMemberBase.cs:185
	                    default: throw new Exception("Found multiple elements while reading single item");                                     // BuildMemberBase.cs:186
	                }                                                                                                                          // BuildMemberBase.cs:187
	            }                                                                                                                              // BuildMemberBase.cs:188
	                                                                                                                                           // BuildMemberBase.cs:190
	            /// <summary>
	            /// Item
	            /// </summary>
	            Item item;                                                                                                                     // BuildMemberBase.cs:194
	                                                                                                                                           // BuildMemberBase.cs:196
	            /// <summary>
	            /// Count property
	            /// </summary>
	            public override Int32 Count => this.item == null ? 0 : 1;                                                                      // BuildMemberBase.cs:200
	                                                                                                                                           // BuildMemberBase.cs:202
	            /// <summary>
	            /// Get Item's Value
	            /// </summary>
	            public CodeableConcept Get()                                                                                                   // BuildMemberBase.cs:206
	            {                                                                                                                              // BuildMemberBase.cs:207
	                if (item == null)                                                                                                          // BuildMemberBase.cs:208
	                    return null;                                                                                                           // BuildMemberBase.cs:209
	                return item.Value;                                                                                                         // BuildMemberBase.cs:210
	            }                                                                                                                              // BuildMemberBase.cs:211
	                                                                                                                                           // BuildMemberBase.cs:217
	            /// <summary>
	            /// Set Item's Value
	            /// </summary>
	            public CodeableConcept Set(CodeableConcept value)                                                                              // BuildMemberBase.cs:221
	            {                                                                                                                              // BuildMemberBase.cs:222
	                this.item = new Item(value);                                                                                               // BuildMemberBase.cs:223
	                return value;                                                                                                              // BuildMemberBase.cs:224
	            }                                                                                                                              // BuildMemberBase.cs:225
	                                                                                                                                           // BuildMemberBase.cs:147
	            /// <summary>
	            /// Constructor
	            /// </summary>
	            public DepthCollection(Int32 min, Int32 max) : base("Extension.extension:depth", min, max)                                     // BuildMemberBase.cs:151
	            {                                                                                                                              // BuildMemberBase.cs:152
	            }                                                                                                                              // BuildMemberBase.cs:154
	                                                                                                                                           // BuildMemberBase.cs:155
	            // Methods                                                                                                                     // BuildMemberBase.cs:156
	                                                                                                                                           // BuildMemberBase.cs:298
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
	                                                                                                                                           // BuildMemberBase.cs:304
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
	        }                                                                                                                                  // BuildMemberBase.cs:158
	        #endregion                                                                                                                         // BuildMemberBase.cs:159
	        // Properties                                                                                                                      // BuildMemberExtensionComplex.cs:88
	                                                                                                                                           // BuildMemberBase.cs:337
	        /// <summary>
	        /// Quadrant
	        /// Access fhir element 'Extension.extension:quadrant'
	        /// </summary>
	        public QuadrantCollection Quadrant { get ; protected set; }                                                                        // BuildMemberBase.cs:342
	                                                                                                                                           // BuildMemberBase.cs:337
	        /// <summary>
	        /// Region
	        /// Access fhir element 'Extension.extension:region'
	        /// </summary>
	        public RegionCollection Region { get ; protected set; }                                                                            // BuildMemberBase.cs:342
	                                                                                                                                           // BuildMemberBase.cs:337
	        /// <summary>
	        /// ClockDirection
	        /// Access fhir element 'Extension.extension:clockDirection'
	        /// </summary>
	        public ClockDirectionCollection ClockDirection { get ; protected set; }                                                            // BuildMemberBase.cs:342
	                                                                                                                                           // BuildMemberBase.cs:337
	        /// <summary>
	        /// Depth
	        /// Access fhir element 'Extension.extension:depth'
	        /// </summary>
	        public DepthCollection Depth { get ; protected set; }                                                                              // BuildMemberBase.cs:342
	                                                                                                                                           // BuildMemberExtensionComplex.cs:90
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public BreastBodyLocationExtension()                                                                                               // BuildMemberExtensionComplex.cs:94
	        {                                                                                                                                  // BuildMemberExtensionComplex.cs:95
	            this.Quadrant = new QuadrantCollection(0, 0);                                                                                  // BuildMemberBase.cs:323
	            this.Region = new RegionCollection(0, 0);                                                                                      // BuildMemberBase.cs:323
	            this.ClockDirection = new ClockDirectionCollection(0, 0);                                                                      // BuildMemberBase.cs:323
	            this.Depth = new DepthCollection(0, 0);                                                                                        // BuildMemberBase.cs:323
	        }                                                                                                                                  // BuildMemberExtensionComplex.cs:97
	                                                                                                                                           // BuildMemberExtensionComplex.cs:99
	        // Methods                                                                                                                         // BuildMemberExtensionComplex.cs:100
	    }                                                                                                                                      // BuildMemberExtensionComplex.cs:102
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
	    public IEnumerable<BreastBodyLocationExtension> All()                                                                                  // BuildMemberBase.cs:256
	    {                                                                                                                                      // BuildMemberBase.cs:257
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:258
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:259
	    }                                                                                                                                      // BuildMemberBase.cs:260
	                                                                                                                                           // BuildMemberBase.cs:262
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public BreastBodyLocationExtension GetAt(Int32 i) => this.items[i].Value;                                                              // BuildMemberBase.cs:266
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
	    public BreastBodyLocationExtensionCollection(Int32 min, Int32 max) : base("BreastBodyLocationExtension", min, max)                     // BuildMemberBase.cs:151
	    {                                                                                                                                      // BuildMemberBase.cs:152
	    }                                                                                                                                      // BuildMemberBase.cs:154
	                                                                                                                                           // BuildMemberBase.cs:155
	    // Methods                                                                                                                             // BuildMemberBase.cs:156
	                                                                                                                                           // BuildMemberBase.cs:284
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public BreastBodyLocationExtension Append(BreastBodyLocationExtension value)                                                           // BuildMemberBase.cs:288
	    {                                                                                                                                      // BuildMemberBase.cs:289
	        this.items.Add(new Item(value));                                                                                                   // BuildMemberBase.cs:290
	        return value;                                                                                                                      // BuildMemberBase.cs:291
	    }                                                                                                                                      // BuildMemberBase.cs:292
	                                                                                                                                           // BuildMemberBase.cs:298
	    /// <summary>
	    /// Write single item as a fhir element.
	    /// </summary>
	    public IEnumerable<Extension> Write(BreastRadiologyDocument doc)                                                                       // BuildMemberExtensionComplex.cs:56
	    {                                                                                                                                      // BuildMemberExtensionComplex.cs:57
	        throw new NotImplementedException();                                                                                               // BuildMemberExtensionComplex.cs:58
	    }                                                                                                                                      // BuildMemberExtensionComplex.cs:68
	                                                                                                                                           // BuildMemberBase.cs:304
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	                                                                                                                                           // BuildMemberExtensionComplex.cs:37
	    public void Read(BreastRadiologyDocument doc, IEnumerable<Extension> components)                                                       // BuildMemberExtensionComplex.cs:38
	    {                                                                                                                                      // BuildMemberExtensionComplex.cs:39
	        throw new NotImplementedException();                                                                                               // BuildMemberExtensionComplex.cs:40
	    }                                                                                                                                      // BuildMemberExtensionComplex.cs:45
	}                                                                                                                                          // BuildMemberBase.cs:158
	#endregion                                                                                                                                 // BuildMemberBase.cs:159
	//- LocalClassDefs
}
