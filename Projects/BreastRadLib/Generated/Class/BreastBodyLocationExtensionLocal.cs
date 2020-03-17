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
	#region BreastBodyLocationExtension Container Class                                                                                        // BuildMemberBase.cs:158
	// Called from BuildMemberExtensionComplex.cs, Line 191
	// BuildMemberBase.cs:160
	/// <summary>
	/// Container class for BreastBodyLocationExtension.
	/// </summary>
	public class BreastBodyLocationExtensionCollection : MContainer, ITMItem<Extension>                                                        // BuildMemberBase.cs:163
	{                                                                                                                                          // BuildMemberBase.cs:164
	    #region BreastBodyLocationExtension Item Class                                                                                         // BuildMemberBase.cs:75
	    // Called from BuildMemberExtensionComplex.cs, Line 191
	    // BuildMemberBase.cs:77
	    /// <summary>
	    /// Item class for BreastBodyLocationExtension.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:80
	    {                                                                                                                                      // BuildMemberBase.cs:81
	        // Properties                                                                                                                      // BuildMemberBase.cs:82
	        // BuildMemberBase.cs:84
	        /// <summary>
	        /// Value
	        /// </summary>
	        public Members Value { get; set; }                                                                                                 // BuildMemberBase.cs:87
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
	                                                                                                                                           // BuildMemberExtensionComplex.cs:54
	        public Extension WriteItem(BreastRadiologyDocument doc)                                                                            // BuildMemberExtensionComplex.cs:55
	        {                                                                                                                                  // BuildMemberExtensionComplex.cs:56
	            throw new NotImplementedException("xxyyz");                                                                                    // BuildMemberExtensionComplex.cs:58
	        }                                                                                                                                  // BuildMemberExtensionComplex.cs:59
	                                                                                                                                           // BuildMemberBase.cs:108
	        // BuildMemberBase.cs:109
	        /// <summary>
	        /// Read item.
	        /// </summary>
	                                                                                                                                           // BuildMemberExtensionComplex.cs:43
	        public void ReadItem(BreastRadiologyDocument doc, Extension extension)                                                             // BuildMemberExtensionComplex.cs:44
	        {                                                                                                                                  // BuildMemberExtensionComplex.cs:45
	            throw new NotImplementedException("xxyyz");                                                                                    // BuildMemberExtensionComplex.cs:46
	        }                                                                                                                                  // BuildMemberExtensionComplex.cs:47
	    }                                                                                                                                      // BuildMemberBase.cs:115
	    #endregion                                                                                                                             // BuildMemberBase.cs:116
	    // BuildMemberExtensionComplex.cs:118
	    /// <summary>
	    /// Extension class for BreastBodyLocationExtension.
	    /// </summary>
	    public class Members                                                                                                                   // BuildMemberExtensionComplex.cs:121
	    {                                                                                                                                      // BuildMemberExtensionComplex.cs:122
	        // Definitions                                                                                                                     // BuildMemberExtensionComplex.cs:123
	        #region Extension.extension:quadrant Container Class                                                                               // BuildMemberBase.cs:158
	        // Called from BuildMemberExtensionSimple.cs, Line 121
	        // BuildMemberBase.cs:160
	        /// <summary>
	        /// Container class for Extension.extension:quadrant.
	        /// </summary>
	        public class QuadrantCollection : MContainer, ITMItem<Extension>                                                                   // BuildMemberBase.cs:163
	        {                                                                                                                                  // BuildMemberBase.cs:164
	            #region Extension.extension:quadrant Item Class                                                                                // BuildMemberBase.cs:75
	            // Called from BuildMemberExtensionSimple.cs, Line 121
	            // BuildMemberBase.cs:77
	            /// <summary>
	            /// Item class for Extension.extension:quadrant.
	            /// </summary>
	            public class Item                                                                                                              // BuildMemberBase.cs:80
	            {                                                                                                                              // BuildMemberBase.cs:81
	                // Properties                                                                                                              // BuildMemberBase.cs:82
	                // BuildMemberBase.cs:84
	                /// <summary>
	                /// Value
	                /// </summary>
	                public CodeableConcept Value { get; set; }                                                                                 // BuildMemberBase.cs:87
	                                                                                                                                           // BuildMemberBase.cs:90
	                // BuildMemberBase.cs:91
	                /// <summary>
	                /// Constructor
	                /// </summary>
	                public Item()                                                                                                              // BuildMemberBase.cs:94
	                {                                                                                                                          // BuildMemberBase.cs:95
	                }                                                                                                                          // BuildMemberBase.cs:97
	                                                                                                                                           // BuildMemberBase.cs:99
	                // Methods                                                                                                                 // BuildMemberBase.cs:100
	                                                                                                                                           // BuildMemberBase.cs:102
	                // BuildMemberBase.cs:103
	                /// <summary>
	                /// Write item.
	                /// </summary>
	                                                                                                                                           // BuildMemberExtensionSimple.cs:57
	                public Extension WriteItem(BreastRadiologyDocument doc)                                                                    // BuildMemberExtensionSimple.cs:58
	                {                                                                                                                          // BuildMemberExtensionSimple.cs:59
	                    return new Extension                                                                                                   // BuildMemberExtensionSimple.cs:60
	                    {                                                                                                                      // BuildMemberExtensionSimple.cs:61
	                        Value = this.Value,                                                                                                // BuildMemberExtensionSimple.cs:62
	                        Url = ExtensionUrl                                                                                                 // BuildMemberExtensionSimple.cs:63
	                    };                                                                                                                     // BuildMemberExtensionSimple.cs:64
	                }                                                                                                                          // BuildMemberExtensionSimple.cs:65
	                                                                                                                                           // BuildMemberBase.cs:108
	                // BuildMemberBase.cs:109
	                /// <summary>
	                /// Read item.
	                /// </summary>
	                                                                                                                                           // BuildMemberExtensionSimple.cs:46
	                public void ReadItem(BreastRadiologyDocument doc, Extension extension)                                                     // BuildMemberExtensionSimple.cs:47
	                {                                                                                                                          // BuildMemberExtensionSimple.cs:48
	                    this.Value = (CodeableConcept) extension.Value;                                                                        // BuildMemberExtensionSimple.cs:49
	                }                                                                                                                          // BuildMemberExtensionSimple.cs:50
	            }                                                                                                                              // BuildMemberBase.cs:115
	            #endregion                                                                                                                     // BuildMemberBase.cs:116
	                                                                                                                                           // BuildMemberBase.cs:167
	            // Properties                                                                                                                  // BuildMemberBase.cs:168
	            public const String ExtensionUrl = "quadrant";                                                                                 // BuildMemberExtensionSimple.cs:39
	            #region Common Singleton Properties                                                                                            // BuildMemberBase.cs:192
	                                                                                                                                           // BuildMemberBase.cs:194
	            // BuildMemberBase.cs:195
	            /// <summary>
	            /// Get All Items
	            /// </summary>
	            IEnumerable<Item> GetAllItems()                                                                                                // BuildMemberBase.cs:198
	            {                                                                                                                              // BuildMemberBase.cs:199
	                if (this.item != null) yield return this.item;                                                                             // BuildMemberBase.cs:200
	            }                                                                                                                              // BuildMemberBase.cs:201
	                                                                                                                                           // BuildMemberBase.cs:203
	            // BuildMemberBase.cs:204
	            /// <summary>
	            /// Set All Items
	            /// </summary>
	            void SetAllItems(IEnumerable<Item> items)                                                                                      // BuildMemberBase.cs:207
	            {                                                                                                                              // BuildMemberBase.cs:208
	                switch (items.Count())                                                                                                     // BuildMemberBase.cs:209
	                {                                                                                                                          // BuildMemberBase.cs:210
	                    case 0: break;                                                                                                         // BuildMemberBase.cs:211
	                    case 1: this.item = items.First(); break;                                                                              // BuildMemberBase.cs:212
	                    default: throw new Exception("Found multiple elements while reading single item");                                     // BuildMemberBase.cs:213
	                }                                                                                                                          // BuildMemberBase.cs:214
	            }                                                                                                                              // BuildMemberBase.cs:215
	                                                                                                                                           // BuildMemberBase.cs:217
	            // BuildMemberBase.cs:218
	            /// <summary>
	            /// Item
	            /// </summary>
	            Item item;                                                                                                                     // BuildMemberBase.cs:221
	                                                                                                                                           // BuildMemberBase.cs:223
	            // BuildMemberBase.cs:224
	            /// <summary>
	            /// Count property
	            /// </summary>
	            public override Int32 Count => this.item == null ? 0 : 1;                                                                      // BuildMemberBase.cs:227
	                                                                                                                                           // BuildMemberBase.cs:229
	            // BuildMemberBase.cs:230
	            /// <summary>
	            /// Get Item's Value
	            /// </summary>
	            public CodeableConcept Get()                                                                                                   // BuildMemberBase.cs:233
	            {                                                                                                                              // BuildMemberBase.cs:234
	                if (item == null)                                                                                                          // BuildMemberBase.cs:235
	                    return null;                                                                                                           // BuildMemberBase.cs:236
	                return item.Value;                                                                                                         // BuildMemberBase.cs:237
	            }                                                                                                                              // BuildMemberBase.cs:238
	                                                                                                                                           // BuildMemberBase.cs:244
	            // BuildMemberBase.cs:245
	            /// <summary>
	            /// Set Item's Value
	            /// </summary>
	            public CodeableConcept Set(CodeableConcept value)                                                                              // BuildMemberBase.cs:248
	            {                                                                                                                              // BuildMemberBase.cs:249
	                Item item = new Item();                                                                                                    // BuildMemberBase.cs:250
	                item.Value = value;                                                                                                        // BuildMemberBase.cs:251
	                this.item = item;                                                                                                          // BuildMemberBase.cs:252
	                return value;                                                                                                              // BuildMemberBase.cs:253
	            }                                                                                                                              // BuildMemberBase.cs:254
	            #endregion                                                                                                                     // BuildMemberBase.cs:330
	                                                                                                                                           // BuildMemberBase.cs:171
	            // BuildMemberBase.cs:172
	            /// <summary>
	            /// Constructor
	            /// </summary>
	            public QuadrantCollection(Int32 min, Int32 max) : base("Extension.extension:quadrant", min, max)                               // BuildMemberBase.cs:175
	            {                                                                                                                              // BuildMemberBase.cs:176
	            }                                                                                                                              // BuildMemberBase.cs:178
	                                                                                                                                           // BuildMemberBase.cs:180
	            // Methods                                                                                                                     // BuildMemberBase.cs:181
	                                                                                                                                           // BuildMemberBase.cs:334
	            // BuildMemberBase.cs:335
	            /// <summary>
	            /// Write container items.
	            /// </summary>
	            public IEnumerable<Extension> Write(BreastRadiologyDocument doc)                                                               // BuildMemberExtensionSimple.cs:98
	            {                                                                                                                              // BuildMemberExtensionSimple.cs:99
	                foreach (Item item in this.GetAllItems())                                                                                  // BuildMemberExtensionSimple.cs:100
	                    yield return item.WriteItem(doc);                                                                                      // BuildMemberExtensionSimple.cs:101
	            }                                                                                                                              // BuildMemberExtensionSimple.cs:102
	                                                                                                                                           // BuildMemberBase.cs:340
	            // BuildMemberBase.cs:341
	            /// <summary>
	            /// Read container items.
	            /// </summary>
	                                                                                                                                           // BuildMemberExtensionSimple.cs:72
	            public void Read(BreastRadiologyDocument doc, IEnumerable<Extension> extensions)                                               // BuildMemberExtensionSimple.cs:73
	            {                                                                                                                              // BuildMemberExtensionSimple.cs:74
	                List<Extension> memberExtensions = extensions                                                                              // BuildMemberExtensionSimple.cs:75
	                    .Where((a) => String.Compare(a.Url, ExtensionUrl, true) == 0)                                                          // BuildMemberExtensionSimple.cs:76
	                    .ToList()                                                                                                              // BuildMemberExtensionSimple.cs:77
	                    ;                                                                                                                      // BuildMemberExtensionSimple.cs:78
	                List<Item> items = new List<Item>();                                                                                       // BuildMemberExtensionSimple.cs:79
	                foreach (Extension memberExtension in memberExtensions)                                                                    // BuildMemberExtensionSimple.cs:80
	                {                                                                                                                          // BuildMemberExtensionSimple.cs:81
	                        Item item = new Item();                                                                                            // BuildMemberExtensionSimple.cs:82
	                        item.ReadItem(doc, memberExtension);                                                                               // BuildMemberExtensionSimple.cs:83
	                        items.Add(item);                                                                                                   // BuildMemberExtensionSimple.cs:84
	                }                                                                                                                          // BuildMemberExtensionSimple.cs:85
	                this.SetAllItems(items);                                                                                                   // BuildMemberExtensionSimple.cs:86
	            }                                                                                                                              // BuildMemberExtensionSimple.cs:87
	        }                                                                                                                                  // BuildMemberBase.cs:183
	        #endregion                                                                                                                         // BuildMemberBase.cs:184
	        #region Extension.extension:region Container Class                                                                                 // BuildMemberBase.cs:158
	        // Called from BuildMemberExtensionSimple.cs, Line 121
	        // BuildMemberBase.cs:160
	        /// <summary>
	        /// Container class for Extension.extension:region.
	        /// </summary>
	        public class RegionCollection : MContainer, ITMItem<Extension>                                                                     // BuildMemberBase.cs:163
	        {                                                                                                                                  // BuildMemberBase.cs:164
	            #region Extension.extension:region Item Class                                                                                  // BuildMemberBase.cs:75
	            // Called from BuildMemberExtensionSimple.cs, Line 121
	            // BuildMemberBase.cs:77
	            /// <summary>
	            /// Item class for Extension.extension:region.
	            /// </summary>
	            public class Item                                                                                                              // BuildMemberBase.cs:80
	            {                                                                                                                              // BuildMemberBase.cs:81
	                // Properties                                                                                                              // BuildMemberBase.cs:82
	                // BuildMemberBase.cs:84
	                /// <summary>
	                /// Value
	                /// </summary>
	                public CodeableConcept Value { get; set; }                                                                                 // BuildMemberBase.cs:87
	                                                                                                                                           // BuildMemberBase.cs:90
	                // BuildMemberBase.cs:91
	                /// <summary>
	                /// Constructor
	                /// </summary>
	                public Item()                                                                                                              // BuildMemberBase.cs:94
	                {                                                                                                                          // BuildMemberBase.cs:95
	                }                                                                                                                          // BuildMemberBase.cs:97
	                                                                                                                                           // BuildMemberBase.cs:99
	                // Methods                                                                                                                 // BuildMemberBase.cs:100
	                                                                                                                                           // BuildMemberBase.cs:102
	                // BuildMemberBase.cs:103
	                /// <summary>
	                /// Write item.
	                /// </summary>
	                                                                                                                                           // BuildMemberExtensionSimple.cs:57
	                public Extension WriteItem(BreastRadiologyDocument doc)                                                                    // BuildMemberExtensionSimple.cs:58
	                {                                                                                                                          // BuildMemberExtensionSimple.cs:59
	                    return new Extension                                                                                                   // BuildMemberExtensionSimple.cs:60
	                    {                                                                                                                      // BuildMemberExtensionSimple.cs:61
	                        Value = this.Value,                                                                                                // BuildMemberExtensionSimple.cs:62
	                        Url = ExtensionUrl                                                                                                 // BuildMemberExtensionSimple.cs:63
	                    };                                                                                                                     // BuildMemberExtensionSimple.cs:64
	                }                                                                                                                          // BuildMemberExtensionSimple.cs:65
	                                                                                                                                           // BuildMemberBase.cs:108
	                // BuildMemberBase.cs:109
	                /// <summary>
	                /// Read item.
	                /// </summary>
	                                                                                                                                           // BuildMemberExtensionSimple.cs:46
	                public void ReadItem(BreastRadiologyDocument doc, Extension extension)                                                     // BuildMemberExtensionSimple.cs:47
	                {                                                                                                                          // BuildMemberExtensionSimple.cs:48
	                    this.Value = (CodeableConcept) extension.Value;                                                                        // BuildMemberExtensionSimple.cs:49
	                }                                                                                                                          // BuildMemberExtensionSimple.cs:50
	            }                                                                                                                              // BuildMemberBase.cs:115
	            #endregion                                                                                                                     // BuildMemberBase.cs:116
	                                                                                                                                           // BuildMemberBase.cs:167
	            // Properties                                                                                                                  // BuildMemberBase.cs:168
	            public const String ExtensionUrl = "region";                                                                                   // BuildMemberExtensionSimple.cs:39
	            #region Common Non-Singleton Properties                                                                                        // BuildMemberBase.cs:261
	            List<Item> items = new List<Item>();                                                                                           // BuildMemberBase.cs:262
	                                                                                                                                           // BuildMemberBase.cs:264
	            // BuildMemberBase.cs:265
	            /// <summary>
	            /// Get All Items
	            /// </summary>
	            IEnumerable<Item> GetAllItems() => this.items;                                                                                 // BuildMemberBase.cs:268
	                                                                                                                                           // BuildMemberBase.cs:270
	            // BuildMemberBase.cs:271
	            /// <summary>
	            /// Set All Items
	            /// </summary>
	            void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                      // BuildMemberBase.cs:274
	                                                                                                                                           // BuildMemberBase.cs:276
	            // BuildMemberBase.cs:277
	            /// <summary>
	            /// Count property
	            /// </summary>
	            public override Int32 Count => items.Count;                                                                                    // BuildMemberBase.cs:280
	                                                                                                                                           // BuildMemberBase.cs:282
	            // BuildMemberBase.cs:283
	            /// <summary>
	            /// Return all items
	            /// </summary>
	            public IEnumerable<CodeableConcept> All()                                                                                      // BuildMemberBase.cs:286
	            {                                                                                                                              // BuildMemberBase.cs:287
	                foreach (Item item in items)                                                                                               // BuildMemberBase.cs:288
	                   yield return item.Value;                                                                                                // BuildMemberBase.cs:289
	            }                                                                                                                              // BuildMemberBase.cs:290
	                                                                                                                                           // BuildMemberBase.cs:292
	            // BuildMemberBase.cs:293
	            /// <summary>
	            /// Get Item's Value at indicated index
	            /// </summary>
	            public CodeableConcept GetAt(Int32 i) => this.items[i].Value;                                                                  // BuildMemberBase.cs:296
	                                                                                                                                           // BuildMemberBase.cs:298
	            // BuildMemberBase.cs:299
	            /// <summary>
	            /// Remove Item at indicated index
	            /// </summary>
	            public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                       // BuildMemberBase.cs:302
	                                                                                                                                           // BuildMemberBase.cs:304
	            // BuildMemberBase.cs:305
	            /// <summary>
	            /// Clear all items from collection
	            /// </summary>
	            public void Clear() => this.items.Clear();                                                                                     // BuildMemberBase.cs:308
	            #endregion                                                                                                                     // BuildMemberBase.cs:330
	                                                                                                                                           // BuildMemberBase.cs:171
	            // BuildMemberBase.cs:172
	            /// <summary>
	            /// Constructor
	            /// </summary>
	            public RegionCollection(Int32 min, Int32 max) : base("Extension.extension:region", min, max)                                   // BuildMemberBase.cs:175
	            {                                                                                                                              // BuildMemberBase.cs:176
	            }                                                                                                                              // BuildMemberBase.cs:178
	                                                                                                                                           // BuildMemberBase.cs:180
	            // Methods                                                                                                                     // BuildMemberBase.cs:181
	                                                                                                                                           // BuildMemberBase.cs:314
	            // BuildMemberBase.cs:315
	            /// <summary>
	            /// Append value to collection
	            /// </summary>
	            public CodeableConcept Append(CodeableConcept value)                                                                           // BuildMemberBase.cs:318
	            {                                                                                                                              // BuildMemberBase.cs:319
	                Item item = new Item();                                                                                                    // BuildMemberBase.cs:320
	                item.Value = value;                                                                                                        // BuildMemberBase.cs:321
	                this.items.Add(item);                                                                                                      // BuildMemberBase.cs:322
	                return value;                                                                                                              // BuildMemberBase.cs:323
	            }                                                                                                                              // BuildMemberBase.cs:324
	                                                                                                                                           // BuildMemberBase.cs:334
	            // BuildMemberBase.cs:335
	            /// <summary>
	            /// Write container items.
	            /// </summary>
	            public IEnumerable<Extension> Write(BreastRadiologyDocument doc)                                                               // BuildMemberExtensionSimple.cs:98
	            {                                                                                                                              // BuildMemberExtensionSimple.cs:99
	                foreach (Item item in this.GetAllItems())                                                                                  // BuildMemberExtensionSimple.cs:100
	                    yield return item.WriteItem(doc);                                                                                      // BuildMemberExtensionSimple.cs:101
	            }                                                                                                                              // BuildMemberExtensionSimple.cs:102
	                                                                                                                                           // BuildMemberBase.cs:340
	            // BuildMemberBase.cs:341
	            /// <summary>
	            /// Read container items.
	            /// </summary>
	                                                                                                                                           // BuildMemberExtensionSimple.cs:72
	            public void Read(BreastRadiologyDocument doc, IEnumerable<Extension> extensions)                                               // BuildMemberExtensionSimple.cs:73
	            {                                                                                                                              // BuildMemberExtensionSimple.cs:74
	                List<Extension> memberExtensions = extensions                                                                              // BuildMemberExtensionSimple.cs:75
	                    .Where((a) => String.Compare(a.Url, ExtensionUrl, true) == 0)                                                          // BuildMemberExtensionSimple.cs:76
	                    .ToList()                                                                                                              // BuildMemberExtensionSimple.cs:77
	                    ;                                                                                                                      // BuildMemberExtensionSimple.cs:78
	                List<Item> items = new List<Item>();                                                                                       // BuildMemberExtensionSimple.cs:79
	                foreach (Extension memberExtension in memberExtensions)                                                                    // BuildMemberExtensionSimple.cs:80
	                {                                                                                                                          // BuildMemberExtensionSimple.cs:81
	                        Item item = new Item();                                                                                            // BuildMemberExtensionSimple.cs:82
	                        item.ReadItem(doc, memberExtension);                                                                               // BuildMemberExtensionSimple.cs:83
	                        items.Add(item);                                                                                                   // BuildMemberExtensionSimple.cs:84
	                }                                                                                                                          // BuildMemberExtensionSimple.cs:85
	                this.SetAllItems(items);                                                                                                   // BuildMemberExtensionSimple.cs:86
	            }                                                                                                                              // BuildMemberExtensionSimple.cs:87
	        }                                                                                                                                  // BuildMemberBase.cs:183
	        #endregion                                                                                                                         // BuildMemberBase.cs:184
	        #region Extension.extension:clockDirection Container Class                                                                         // BuildMemberBase.cs:158
	        // Called from BuildMemberExtensionSimple.cs, Line 121
	        // BuildMemberBase.cs:160
	        /// <summary>
	        /// Container class for Extension.extension:clockDirection.
	        /// </summary>
	        public class ClockDirectionCollection : MContainer, ITMItem<Extension>                                                             // BuildMemberBase.cs:163
	        {                                                                                                                                  // BuildMemberBase.cs:164
	            #region Extension.extension:clockDirection Item Class                                                                          // BuildMemberBase.cs:75
	            // Called from BuildMemberExtensionSimple.cs, Line 121
	            // BuildMemberBase.cs:77
	            /// <summary>
	            /// Item class for Extension.extension:clockDirection.
	            /// </summary>
	            public class Item                                                                                                              // BuildMemberBase.cs:80
	            {                                                                                                                              // BuildMemberBase.cs:81
	                // Properties                                                                                                              // BuildMemberBase.cs:82
	                // BuildMemberBase.cs:84
	                /// <summary>
	                /// Value
	                /// </summary>
	                public CodeableConcept Value { get; set; }                                                                                 // BuildMemberBase.cs:87
	                                                                                                                                           // BuildMemberBase.cs:90
	                // BuildMemberBase.cs:91
	                /// <summary>
	                /// Constructor
	                /// </summary>
	                public Item()                                                                                                              // BuildMemberBase.cs:94
	                {                                                                                                                          // BuildMemberBase.cs:95
	                }                                                                                                                          // BuildMemberBase.cs:97
	                                                                                                                                           // BuildMemberBase.cs:99
	                // Methods                                                                                                                 // BuildMemberBase.cs:100
	                                                                                                                                           // BuildMemberBase.cs:102
	                // BuildMemberBase.cs:103
	                /// <summary>
	                /// Write item.
	                /// </summary>
	                                                                                                                                           // BuildMemberExtensionSimple.cs:57
	                public Extension WriteItem(BreastRadiologyDocument doc)                                                                    // BuildMemberExtensionSimple.cs:58
	                {                                                                                                                          // BuildMemberExtensionSimple.cs:59
	                    return new Extension                                                                                                   // BuildMemberExtensionSimple.cs:60
	                    {                                                                                                                      // BuildMemberExtensionSimple.cs:61
	                        Value = this.Value,                                                                                                // BuildMemberExtensionSimple.cs:62
	                        Url = ExtensionUrl                                                                                                 // BuildMemberExtensionSimple.cs:63
	                    };                                                                                                                     // BuildMemberExtensionSimple.cs:64
	                }                                                                                                                          // BuildMemberExtensionSimple.cs:65
	                                                                                                                                           // BuildMemberBase.cs:108
	                // BuildMemberBase.cs:109
	                /// <summary>
	                /// Read item.
	                /// </summary>
	                                                                                                                                           // BuildMemberExtensionSimple.cs:46
	                public void ReadItem(BreastRadiologyDocument doc, Extension extension)                                                     // BuildMemberExtensionSimple.cs:47
	                {                                                                                                                          // BuildMemberExtensionSimple.cs:48
	                    this.Value = (CodeableConcept) extension.Value;                                                                        // BuildMemberExtensionSimple.cs:49
	                }                                                                                                                          // BuildMemberExtensionSimple.cs:50
	            }                                                                                                                              // BuildMemberBase.cs:115
	            #endregion                                                                                                                     // BuildMemberBase.cs:116
	                                                                                                                                           // BuildMemberBase.cs:167
	            // Properties                                                                                                                  // BuildMemberBase.cs:168
	            public const String ExtensionUrl = "clockDirection";                                                                           // BuildMemberExtensionSimple.cs:39
	            #region Common Singleton Properties                                                                                            // BuildMemberBase.cs:192
	                                                                                                                                           // BuildMemberBase.cs:194
	            // BuildMemberBase.cs:195
	            /// <summary>
	            /// Get All Items
	            /// </summary>
	            IEnumerable<Item> GetAllItems()                                                                                                // BuildMemberBase.cs:198
	            {                                                                                                                              // BuildMemberBase.cs:199
	                if (this.item != null) yield return this.item;                                                                             // BuildMemberBase.cs:200
	            }                                                                                                                              // BuildMemberBase.cs:201
	                                                                                                                                           // BuildMemberBase.cs:203
	            // BuildMemberBase.cs:204
	            /// <summary>
	            /// Set All Items
	            /// </summary>
	            void SetAllItems(IEnumerable<Item> items)                                                                                      // BuildMemberBase.cs:207
	            {                                                                                                                              // BuildMemberBase.cs:208
	                switch (items.Count())                                                                                                     // BuildMemberBase.cs:209
	                {                                                                                                                          // BuildMemberBase.cs:210
	                    case 0: break;                                                                                                         // BuildMemberBase.cs:211
	                    case 1: this.item = items.First(); break;                                                                              // BuildMemberBase.cs:212
	                    default: throw new Exception("Found multiple elements while reading single item");                                     // BuildMemberBase.cs:213
	                }                                                                                                                          // BuildMemberBase.cs:214
	            }                                                                                                                              // BuildMemberBase.cs:215
	                                                                                                                                           // BuildMemberBase.cs:217
	            // BuildMemberBase.cs:218
	            /// <summary>
	            /// Item
	            /// </summary>
	            Item item;                                                                                                                     // BuildMemberBase.cs:221
	                                                                                                                                           // BuildMemberBase.cs:223
	            // BuildMemberBase.cs:224
	            /// <summary>
	            /// Count property
	            /// </summary>
	            public override Int32 Count => this.item == null ? 0 : 1;                                                                      // BuildMemberBase.cs:227
	                                                                                                                                           // BuildMemberBase.cs:229
	            // BuildMemberBase.cs:230
	            /// <summary>
	            /// Get Item's Value
	            /// </summary>
	            public CodeableConcept Get()                                                                                                   // BuildMemberBase.cs:233
	            {                                                                                                                              // BuildMemberBase.cs:234
	                if (item == null)                                                                                                          // BuildMemberBase.cs:235
	                    return null;                                                                                                           // BuildMemberBase.cs:236
	                return item.Value;                                                                                                         // BuildMemberBase.cs:237
	            }                                                                                                                              // BuildMemberBase.cs:238
	                                                                                                                                           // BuildMemberBase.cs:244
	            // BuildMemberBase.cs:245
	            /// <summary>
	            /// Set Item's Value
	            /// </summary>
	            public CodeableConcept Set(CodeableConcept value)                                                                              // BuildMemberBase.cs:248
	            {                                                                                                                              // BuildMemberBase.cs:249
	                Item item = new Item();                                                                                                    // BuildMemberBase.cs:250
	                item.Value = value;                                                                                                        // BuildMemberBase.cs:251
	                this.item = item;                                                                                                          // BuildMemberBase.cs:252
	                return value;                                                                                                              // BuildMemberBase.cs:253
	            }                                                                                                                              // BuildMemberBase.cs:254
	            #endregion                                                                                                                     // BuildMemberBase.cs:330
	                                                                                                                                           // BuildMemberBase.cs:171
	            // BuildMemberBase.cs:172
	            /// <summary>
	            /// Constructor
	            /// </summary>
	            public ClockDirectionCollection(Int32 min, Int32 max) : base("Extension.extension:clockDirection", min, max)                   // BuildMemberBase.cs:175
	            {                                                                                                                              // BuildMemberBase.cs:176
	            }                                                                                                                              // BuildMemberBase.cs:178
	                                                                                                                                           // BuildMemberBase.cs:180
	            // Methods                                                                                                                     // BuildMemberBase.cs:181
	                                                                                                                                           // BuildMemberBase.cs:334
	            // BuildMemberBase.cs:335
	            /// <summary>
	            /// Write container items.
	            /// </summary>
	            public IEnumerable<Extension> Write(BreastRadiologyDocument doc)                                                               // BuildMemberExtensionSimple.cs:98
	            {                                                                                                                              // BuildMemberExtensionSimple.cs:99
	                foreach (Item item in this.GetAllItems())                                                                                  // BuildMemberExtensionSimple.cs:100
	                    yield return item.WriteItem(doc);                                                                                      // BuildMemberExtensionSimple.cs:101
	            }                                                                                                                              // BuildMemberExtensionSimple.cs:102
	                                                                                                                                           // BuildMemberBase.cs:340
	            // BuildMemberBase.cs:341
	            /// <summary>
	            /// Read container items.
	            /// </summary>
	                                                                                                                                           // BuildMemberExtensionSimple.cs:72
	            public void Read(BreastRadiologyDocument doc, IEnumerable<Extension> extensions)                                               // BuildMemberExtensionSimple.cs:73
	            {                                                                                                                              // BuildMemberExtensionSimple.cs:74
	                List<Extension> memberExtensions = extensions                                                                              // BuildMemberExtensionSimple.cs:75
	                    .Where((a) => String.Compare(a.Url, ExtensionUrl, true) == 0)                                                          // BuildMemberExtensionSimple.cs:76
	                    .ToList()                                                                                                              // BuildMemberExtensionSimple.cs:77
	                    ;                                                                                                                      // BuildMemberExtensionSimple.cs:78
	                List<Item> items = new List<Item>();                                                                                       // BuildMemberExtensionSimple.cs:79
	                foreach (Extension memberExtension in memberExtensions)                                                                    // BuildMemberExtensionSimple.cs:80
	                {                                                                                                                          // BuildMemberExtensionSimple.cs:81
	                        Item item = new Item();                                                                                            // BuildMemberExtensionSimple.cs:82
	                        item.ReadItem(doc, memberExtension);                                                                               // BuildMemberExtensionSimple.cs:83
	                        items.Add(item);                                                                                                   // BuildMemberExtensionSimple.cs:84
	                }                                                                                                                          // BuildMemberExtensionSimple.cs:85
	                this.SetAllItems(items);                                                                                                   // BuildMemberExtensionSimple.cs:86
	            }                                                                                                                              // BuildMemberExtensionSimple.cs:87
	        }                                                                                                                                  // BuildMemberBase.cs:183
	        #endregion                                                                                                                         // BuildMemberBase.cs:184
	        #region Extension.extension:depth Container Class                                                                                  // BuildMemberBase.cs:158
	        // Called from BuildMemberExtensionSimple.cs, Line 121
	        // BuildMemberBase.cs:160
	        /// <summary>
	        /// Container class for Extension.extension:depth.
	        /// </summary>
	        public class DepthCollection : MContainer, ITMItem<Extension>                                                                      // BuildMemberBase.cs:163
	        {                                                                                                                                  // BuildMemberBase.cs:164
	            #region Extension.extension:depth Item Class                                                                                   // BuildMemberBase.cs:75
	            // Called from BuildMemberExtensionSimple.cs, Line 121
	            // BuildMemberBase.cs:77
	            /// <summary>
	            /// Item class for Extension.extension:depth.
	            /// </summary>
	            public class Item                                                                                                              // BuildMemberBase.cs:80
	            {                                                                                                                              // BuildMemberBase.cs:81
	                // Properties                                                                                                              // BuildMemberBase.cs:82
	                // BuildMemberBase.cs:84
	                /// <summary>
	                /// Value
	                /// </summary>
	                public CodeableConcept Value { get; set; }                                                                                 // BuildMemberBase.cs:87
	                                                                                                                                           // BuildMemberBase.cs:90
	                // BuildMemberBase.cs:91
	                /// <summary>
	                /// Constructor
	                /// </summary>
	                public Item()                                                                                                              // BuildMemberBase.cs:94
	                {                                                                                                                          // BuildMemberBase.cs:95
	                }                                                                                                                          // BuildMemberBase.cs:97
	                                                                                                                                           // BuildMemberBase.cs:99
	                // Methods                                                                                                                 // BuildMemberBase.cs:100
	                                                                                                                                           // BuildMemberBase.cs:102
	                // BuildMemberBase.cs:103
	                /// <summary>
	                /// Write item.
	                /// </summary>
	                                                                                                                                           // BuildMemberExtensionSimple.cs:57
	                public Extension WriteItem(BreastRadiologyDocument doc)                                                                    // BuildMemberExtensionSimple.cs:58
	                {                                                                                                                          // BuildMemberExtensionSimple.cs:59
	                    return new Extension                                                                                                   // BuildMemberExtensionSimple.cs:60
	                    {                                                                                                                      // BuildMemberExtensionSimple.cs:61
	                        Value = this.Value,                                                                                                // BuildMemberExtensionSimple.cs:62
	                        Url = ExtensionUrl                                                                                                 // BuildMemberExtensionSimple.cs:63
	                    };                                                                                                                     // BuildMemberExtensionSimple.cs:64
	                }                                                                                                                          // BuildMemberExtensionSimple.cs:65
	                                                                                                                                           // BuildMemberBase.cs:108
	                // BuildMemberBase.cs:109
	                /// <summary>
	                /// Read item.
	                /// </summary>
	                                                                                                                                           // BuildMemberExtensionSimple.cs:46
	                public void ReadItem(BreastRadiologyDocument doc, Extension extension)                                                     // BuildMemberExtensionSimple.cs:47
	                {                                                                                                                          // BuildMemberExtensionSimple.cs:48
	                    this.Value = (CodeableConcept) extension.Value;                                                                        // BuildMemberExtensionSimple.cs:49
	                }                                                                                                                          // BuildMemberExtensionSimple.cs:50
	            }                                                                                                                              // BuildMemberBase.cs:115
	            #endregion                                                                                                                     // BuildMemberBase.cs:116
	                                                                                                                                           // BuildMemberBase.cs:167
	            // Properties                                                                                                                  // BuildMemberBase.cs:168
	            public const String ExtensionUrl = "depth";                                                                                    // BuildMemberExtensionSimple.cs:39
	            #region Common Singleton Properties                                                                                            // BuildMemberBase.cs:192
	                                                                                                                                           // BuildMemberBase.cs:194
	            // BuildMemberBase.cs:195
	            /// <summary>
	            /// Get All Items
	            /// </summary>
	            IEnumerable<Item> GetAllItems()                                                                                                // BuildMemberBase.cs:198
	            {                                                                                                                              // BuildMemberBase.cs:199
	                if (this.item != null) yield return this.item;                                                                             // BuildMemberBase.cs:200
	            }                                                                                                                              // BuildMemberBase.cs:201
	                                                                                                                                           // BuildMemberBase.cs:203
	            // BuildMemberBase.cs:204
	            /// <summary>
	            /// Set All Items
	            /// </summary>
	            void SetAllItems(IEnumerable<Item> items)                                                                                      // BuildMemberBase.cs:207
	            {                                                                                                                              // BuildMemberBase.cs:208
	                switch (items.Count())                                                                                                     // BuildMemberBase.cs:209
	                {                                                                                                                          // BuildMemberBase.cs:210
	                    case 0: break;                                                                                                         // BuildMemberBase.cs:211
	                    case 1: this.item = items.First(); break;                                                                              // BuildMemberBase.cs:212
	                    default: throw new Exception("Found multiple elements while reading single item");                                     // BuildMemberBase.cs:213
	                }                                                                                                                          // BuildMemberBase.cs:214
	            }                                                                                                                              // BuildMemberBase.cs:215
	                                                                                                                                           // BuildMemberBase.cs:217
	            // BuildMemberBase.cs:218
	            /// <summary>
	            /// Item
	            /// </summary>
	            Item item;                                                                                                                     // BuildMemberBase.cs:221
	                                                                                                                                           // BuildMemberBase.cs:223
	            // BuildMemberBase.cs:224
	            /// <summary>
	            /// Count property
	            /// </summary>
	            public override Int32 Count => this.item == null ? 0 : 1;                                                                      // BuildMemberBase.cs:227
	                                                                                                                                           // BuildMemberBase.cs:229
	            // BuildMemberBase.cs:230
	            /// <summary>
	            /// Get Item's Value
	            /// </summary>
	            public CodeableConcept Get()                                                                                                   // BuildMemberBase.cs:233
	            {                                                                                                                              // BuildMemberBase.cs:234
	                if (item == null)                                                                                                          // BuildMemberBase.cs:235
	                    return null;                                                                                                           // BuildMemberBase.cs:236
	                return item.Value;                                                                                                         // BuildMemberBase.cs:237
	            }                                                                                                                              // BuildMemberBase.cs:238
	                                                                                                                                           // BuildMemberBase.cs:244
	            // BuildMemberBase.cs:245
	            /// <summary>
	            /// Set Item's Value
	            /// </summary>
	            public CodeableConcept Set(CodeableConcept value)                                                                              // BuildMemberBase.cs:248
	            {                                                                                                                              // BuildMemberBase.cs:249
	                Item item = new Item();                                                                                                    // BuildMemberBase.cs:250
	                item.Value = value;                                                                                                        // BuildMemberBase.cs:251
	                this.item = item;                                                                                                          // BuildMemberBase.cs:252
	                return value;                                                                                                              // BuildMemberBase.cs:253
	            }                                                                                                                              // BuildMemberBase.cs:254
	            #endregion                                                                                                                     // BuildMemberBase.cs:330
	                                                                                                                                           // BuildMemberBase.cs:171
	            // BuildMemberBase.cs:172
	            /// <summary>
	            /// Constructor
	            /// </summary>
	            public DepthCollection(Int32 min, Int32 max) : base("Extension.extension:depth", min, max)                                     // BuildMemberBase.cs:175
	            {                                                                                                                              // BuildMemberBase.cs:176
	            }                                                                                                                              // BuildMemberBase.cs:178
	                                                                                                                                           // BuildMemberBase.cs:180
	            // Methods                                                                                                                     // BuildMemberBase.cs:181
	                                                                                                                                           // BuildMemberBase.cs:334
	            // BuildMemberBase.cs:335
	            /// <summary>
	            /// Write container items.
	            /// </summary>
	            public IEnumerable<Extension> Write(BreastRadiologyDocument doc)                                                               // BuildMemberExtensionSimple.cs:98
	            {                                                                                                                              // BuildMemberExtensionSimple.cs:99
	                foreach (Item item in this.GetAllItems())                                                                                  // BuildMemberExtensionSimple.cs:100
	                    yield return item.WriteItem(doc);                                                                                      // BuildMemberExtensionSimple.cs:101
	            }                                                                                                                              // BuildMemberExtensionSimple.cs:102
	                                                                                                                                           // BuildMemberBase.cs:340
	            // BuildMemberBase.cs:341
	            /// <summary>
	            /// Read container items.
	            /// </summary>
	                                                                                                                                           // BuildMemberExtensionSimple.cs:72
	            public void Read(BreastRadiologyDocument doc, IEnumerable<Extension> extensions)                                               // BuildMemberExtensionSimple.cs:73
	            {                                                                                                                              // BuildMemberExtensionSimple.cs:74
	                List<Extension> memberExtensions = extensions                                                                              // BuildMemberExtensionSimple.cs:75
	                    .Where((a) => String.Compare(a.Url, ExtensionUrl, true) == 0)                                                          // BuildMemberExtensionSimple.cs:76
	                    .ToList()                                                                                                              // BuildMemberExtensionSimple.cs:77
	                    ;                                                                                                                      // BuildMemberExtensionSimple.cs:78
	                List<Item> items = new List<Item>();                                                                                       // BuildMemberExtensionSimple.cs:79
	                foreach (Extension memberExtension in memberExtensions)                                                                    // BuildMemberExtensionSimple.cs:80
	                {                                                                                                                          // BuildMemberExtensionSimple.cs:81
	                        Item item = new Item();                                                                                            // BuildMemberExtensionSimple.cs:82
	                        item.ReadItem(doc, memberExtension);                                                                               // BuildMemberExtensionSimple.cs:83
	                        items.Add(item);                                                                                                   // BuildMemberExtensionSimple.cs:84
	                }                                                                                                                          // BuildMemberExtensionSimple.cs:85
	                this.SetAllItems(items);                                                                                                   // BuildMemberExtensionSimple.cs:86
	            }                                                                                                                              // BuildMemberExtensionSimple.cs:87
	        }                                                                                                                                  // BuildMemberBase.cs:183
	        #endregion                                                                                                                         // BuildMemberBase.cs:184
	        // Properties                                                                                                                      // BuildMemberExtensionComplex.cs:125
	                                                                                                                                           // BuildMemberBase.cs:375
	        // Called from BuildMemberExtensionSimple.cs, Line 121
	        // BuildMemberBase.cs:377
	        /// <summary>
	        /// Quadrant
	        /// Access fhir element 'Extension.extension:quadrant'
	        /// </summary>
	        public QuadrantCollection Quadrant { get ; protected set; }                                                                        // BuildMemberBase.cs:381
	                                                                                                                                           // BuildMemberBase.cs:375
	        // Called from BuildMemberExtensionSimple.cs, Line 121
	        // BuildMemberBase.cs:377
	        /// <summary>
	        /// Region
	        /// Access fhir element 'Extension.extension:region'
	        /// </summary>
	        public RegionCollection Region { get ; protected set; }                                                                            // BuildMemberBase.cs:381
	                                                                                                                                           // BuildMemberBase.cs:375
	        // Called from BuildMemberExtensionSimple.cs, Line 121
	        // BuildMemberBase.cs:377
	        /// <summary>
	        /// ClockDirection
	        /// Access fhir element 'Extension.extension:clockDirection'
	        /// </summary>
	        public ClockDirectionCollection ClockDirection { get ; protected set; }                                                            // BuildMemberBase.cs:381
	                                                                                                                                           // BuildMemberBase.cs:375
	        // Called from BuildMemberExtensionSimple.cs, Line 121
	        // BuildMemberBase.cs:377
	        /// <summary>
	        /// Depth
	        /// Access fhir element 'Extension.extension:depth'
	        /// </summary>
	        public DepthCollection Depth { get ; protected set; }                                                                              // BuildMemberBase.cs:381
	                                                                                                                                           // BuildMemberExtensionComplex.cs:127
	        // BuildMemberExtensionComplex.cs:128
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Members()                                                                                                                   // BuildMemberExtensionComplex.cs:131
	        {                                                                                                                                  // BuildMemberExtensionComplex.cs:132
	            // Called from BuildMemberExtensionSimple.cs, Line 121
	            this.Quadrant = new QuadrantCollection(0, 0);                                                                                  // BuildMemberBase.cs:360
	            // Called from BuildMemberExtensionSimple.cs, Line 121
	            this.Region = new RegionCollection(0, 0);                                                                                      // BuildMemberBase.cs:360
	            // Called from BuildMemberExtensionSimple.cs, Line 121
	            this.ClockDirection = new ClockDirectionCollection(0, 0);                                                                      // BuildMemberBase.cs:360
	            // Called from BuildMemberExtensionSimple.cs, Line 121
	            this.Depth = new DepthCollection(0, 0);                                                                                        // BuildMemberBase.cs:360
	        }                                                                                                                                  // BuildMemberExtensionComplex.cs:134
	                                                                                                                                           // BuildMemberExtensionComplex.cs:136
	        // Methods                                                                                                                         // BuildMemberExtensionComplex.cs:137
	                                                                                                                                           // BuildMemberExtensionComplex.cs:140
	        // BuildMemberExtensionComplex.cs:141
	        /// <summary>
	        /// Write item as a fhir element.
	        /// </summary>
	        public IEnumerable<Extension> Write(BreastRadiologyDocument doc)                                                                   // BuildMemberExtensionComplex.cs:144
	        {                                                                                                                                  // BuildMemberExtensionComplex.cs:145
	            List<Extension> items = new List<Extension>();                                                                                 // BuildMemberExtensionComplex.cs:146
	            items.AddRange(this.Quadrant.Write(doc));                                                                                      // BuildMemberExtensionSimple.cs:106
	            items.AddRange(this.Region.Write(doc));                                                                                        // BuildMemberExtensionSimple.cs:106
	            items.AddRange(this.ClockDirection.Write(doc));                                                                                // BuildMemberExtensionSimple.cs:106
	            items.AddRange(this.Depth.Write(doc));                                                                                         // BuildMemberExtensionSimple.cs:106
	            yield return new Extension                                                                                                     // BuildMemberExtensionComplex.cs:148
	            {                                                                                                                              // BuildMemberExtensionComplex.cs:149
	                Url = ExtensionUrl,                                                                                                        // BuildMemberExtensionComplex.cs:150
	                Extension = items                                                                                                          // BuildMemberExtensionComplex.cs:151
	            };                                                                                                                             // BuildMemberExtensionComplex.cs:152
	        }                                                                                                                                  // BuildMemberExtensionComplex.cs:153
	                                                                                                                                           // BuildMemberExtensionComplex.cs:155
	        // BuildMemberExtensionComplex.cs:156
	        /// <summary>
	        /// Read from fhir element into member item.
	        /// </summary>
	        public void Read(BreastRadiologyDocument doc, IEnumerable<Extension> extensions)                                                   // BuildMemberExtensionComplex.cs:159
	        {                                                                                                                                  // BuildMemberExtensionComplex.cs:160
	            this.Quadrant.Read(doc, extensions);                                                                                           // BuildMemberExtensionSimple.cs:91
	            this.Region.Read(doc, extensions);                                                                                             // BuildMemberExtensionSimple.cs:91
	            this.ClockDirection.Read(doc, extensions);                                                                                     // BuildMemberExtensionSimple.cs:91
	            this.Depth.Read(doc, extensions);                                                                                              // BuildMemberExtensionSimple.cs:91
	        }                                                                                                                                  // BuildMemberExtensionComplex.cs:162
	    }                                                                                                                                      // BuildMemberExtensionComplex.cs:164
	                                                                                                                                           // BuildMemberBase.cs:167
	    // Properties                                                                                                                          // BuildMemberBase.cs:168
	    public const String ExtensionUrl = "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/BreastBodyLocationExtension";          // BuildMemberExtensionComplex.cs:36
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
	    public IEnumerable<Members> All()                                                                                                      // BuildMemberBase.cs:286
	    {                                                                                                                                      // BuildMemberBase.cs:287
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:288
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:289
	    }                                                                                                                                      // BuildMemberBase.cs:290
	                                                                                                                                           // BuildMemberBase.cs:292
	    // BuildMemberBase.cs:293
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public Members GetAt(Int32 i) => this.items[i].Value;                                                                                  // BuildMemberBase.cs:296
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
	    public BreastBodyLocationExtensionCollection(Int32 min, Int32 max) : base("BreastBodyLocationExtension", min, max)                     // BuildMemberBase.cs:175
	    {                                                                                                                                      // BuildMemberBase.cs:176
	    }                                                                                                                                      // BuildMemberBase.cs:178
	                                                                                                                                           // BuildMemberBase.cs:180
	    // Methods                                                                                                                             // BuildMemberBase.cs:181
	                                                                                                                                           // BuildMemberBase.cs:314
	    // BuildMemberBase.cs:315
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public Members Append(Members value)                                                                                                   // BuildMemberBase.cs:318
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
	    public IEnumerable<Extension> Write(BreastRadiologyDocument doc)                                                                       // BuildMemberExtensionComplex.cs:93
	    {                                                                                                                                      // BuildMemberExtensionComplex.cs:94
	        throw new NotImplementedException("xxyyz");                                                                                        // BuildMemberExtensionComplex.cs:95
	    }                                                                                                                                      // BuildMemberExtensionComplex.cs:105
	                                                                                                                                           // BuildMemberBase.cs:340
	    // BuildMemberBase.cs:341
	    /// <summary>
	    /// Read container items.
	    /// </summary>
	                                                                                                                                           // BuildMemberExtensionComplex.cs:66
	    public void Read(BreastRadiologyDocument doc, IEnumerable<Extension> extensions)                                                       // BuildMemberExtensionComplex.cs:67
	    {                                                                                                                                      // BuildMemberExtensionComplex.cs:68
	        throw new NotImplementedException("xxyyz");                                                                                        // BuildMemberExtensionComplex.cs:70
	    }                                                                                                                                      // BuildMemberExtensionComplex.cs:82
	}                                                                                                                                          // BuildMemberBase.cs:183
	#endregion                                                                                                                                 // BuildMemberBase.cs:184
	//- LocalClassDefs
}
