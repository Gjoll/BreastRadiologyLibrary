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

namespace BreastRadLib.BodyDistanceFromExtensionLocal
{
	//+ LocalClassDefs
	#region BodyDistanceFromExtension Container Class                                                                                          // BuildMemberBase.cs:140
	// Called from BuildMemberExtensionComplex.cs, Line 167
	// BuildMemberBase.cs:142
	/// <summary>
	/// Container class for BodyDistanceFromExtension.
	/// </summary>
	public class BodyDistanceFromExtensionCollection : MContainer, ITMItem<Extension>                                                          // BuildMemberBase.cs:145
	{                                                                                                                                          // BuildMemberBase.cs:146
	    #region BodyDistanceFromExtension Item Class                                                                                           // BuildMemberBase.cs:75
	    // Called from BuildMemberExtensionComplex.cs, Line 167
	    // BuildMemberBase.cs:77
	    /// <summary>
	    /// Item class for BodyDistanceFromExtension.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:80
	    {                                                                                                                                      // BuildMemberBase.cs:81
	        // Properties                                                                                                                      // BuildMemberBase.cs:82
	        // BuildMemberBase.cs:83
	        /// <summary>
	        /// Value
	        /// </summary>
	        public BodyDistanceFromExtension Value { get; set; }                                                                               // BuildMemberBase.cs:86
	                                                                                                                                           // BuildMemberBase.cs:88
	        // BuildMemberBase.cs:89
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(BodyDistanceFromExtension value)                                                                                       // BuildMemberBase.cs:92
	        {                                                                                                                                  // BuildMemberBase.cs:93
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:94
	        }                                                                                                                                  // BuildMemberBase.cs:96
	                                                                                                                                           // BuildMemberBase.cs:98
	        // Methods                                                                                                                         // BuildMemberBase.cs:99
	    }                                                                                                                                      // BuildMemberBase.cs:101
	    #endregion                                                                                                                             // BuildMemberBase.cs:102
	    // BuildMemberExtensionComplex.cs:94
	    /// <summary>
	    /// Extension class for BodyDistanceFromExtension.
	    /// </summary>
	    public class BodyDistanceFromExtension                                                                                                 // BuildMemberExtensionComplex.cs:97
	    {                                                                                                                                      // BuildMemberExtensionComplex.cs:98
	        // Definitions                                                                                                                     // BuildMemberExtensionComplex.cs:99
	        #region Extension.extension:landMark Container Class                                                                               // BuildMemberBase.cs:140
	        // Called from BuildMemberExtensionSimple.cs, Line 97
	        // BuildMemberBase.cs:142
	        /// <summary>
	        /// Container class for Extension.extension:landMark.
	        /// </summary>
	        public class LandMarkCollection : MContainer, ITMItem<Extension>                                                                   // BuildMemberBase.cs:145
	        {                                                                                                                                  // BuildMemberBase.cs:146
	            #region Extension.extension:landMark Item Class                                                                                // BuildMemberBase.cs:75
	            // Called from BuildMemberExtensionSimple.cs, Line 97
	            // BuildMemberBase.cs:77
	            /// <summary>
	            /// Item class for Extension.extension:landMark.
	            /// </summary>
	            public class Item                                                                                                              // BuildMemberBase.cs:80
	            {                                                                                                                              // BuildMemberBase.cs:81
	                // Properties                                                                                                              // BuildMemberBase.cs:82
	                // BuildMemberBase.cs:83
	                /// <summary>
	                /// Value
	                /// </summary>
	                public CodeableConcept Value { get; set; }                                                                                 // BuildMemberBase.cs:86
	                                                                                                                                           // BuildMemberBase.cs:88
	                // BuildMemberBase.cs:89
	                /// <summary>
	                /// Constructor
	                /// </summary>
	                public Item(CodeableConcept value)                                                                                         // BuildMemberBase.cs:92
	                {                                                                                                                          // BuildMemberBase.cs:93
	                    this.Value = value;                                                                                                    // BuildMemberBase.cs:94
	                }                                                                                                                          // BuildMemberBase.cs:96
	                                                                                                                                           // BuildMemberBase.cs:98
	                // Methods                                                                                                                 // BuildMemberBase.cs:99
	            }                                                                                                                              // BuildMemberBase.cs:101
	            #endregion                                                                                                                     // BuildMemberBase.cs:102
	                                                                                                                                           // BuildMemberBase.cs:148
	            // Properties                                                                                                                  // BuildMemberBase.cs:149
	            public const String ExtensionUrl = "landMark";                                                                                 // BuildMemberExtensionSimple.cs:39
	            #region Common Singleton Properties                                                                                            // BuildMemberBase.cs:171
	                                                                                                                                           // BuildMemberBase.cs:172
	            // BuildMemberBase.cs:173
	            /// <summary>
	            /// Get All Items
	            /// </summary>
	            IEnumerable<Item> GetAllItems()                                                                                                // BuildMemberBase.cs:176
	            {                                                                                                                              // BuildMemberBase.cs:177
	                if (this.item != null) yield return this.item;                                                                             // BuildMemberBase.cs:178
	            }                                                                                                                              // BuildMemberBase.cs:179
	                                                                                                                                           // BuildMemberBase.cs:181
	            // BuildMemberBase.cs:182
	            /// <summary>
	            /// Set All Items
	            /// </summary>
	            void SetAllItems(IEnumerable<Item> items)                                                                                      // BuildMemberBase.cs:185
	            {                                                                                                                              // BuildMemberBase.cs:186
	                switch (items.Count())                                                                                                     // BuildMemberBase.cs:187
	                {                                                                                                                          // BuildMemberBase.cs:188
	                    case 0: break;                                                                                                         // BuildMemberBase.cs:189
	                    case 1: this.item = items.First(); break;                                                                              // BuildMemberBase.cs:190
	                    default: throw new Exception("Found multiple elements while reading single item");                                     // BuildMemberBase.cs:191
	                }                                                                                                                          // BuildMemberBase.cs:192
	            }                                                                                                                              // BuildMemberBase.cs:193
	                                                                                                                                           // BuildMemberBase.cs:195
	            // BuildMemberBase.cs:196
	            /// <summary>
	            /// Item
	            /// </summary>
	            Item item;                                                                                                                     // BuildMemberBase.cs:199
	                                                                                                                                           // BuildMemberBase.cs:201
	            // BuildMemberBase.cs:202
	            /// <summary>
	            /// Count property
	            /// </summary>
	            public override Int32 Count => this.item == null ? 0 : 1;                                                                      // BuildMemberBase.cs:205
	                                                                                                                                           // BuildMemberBase.cs:207
	            // BuildMemberBase.cs:208
	            /// <summary>
	            /// Get Item's Value
	            /// </summary>
	            public CodeableConcept Get()                                                                                                   // BuildMemberBase.cs:211
	            {                                                                                                                              // BuildMemberBase.cs:212
	                if (item == null)                                                                                                          // BuildMemberBase.cs:213
	                    return null;                                                                                                           // BuildMemberBase.cs:214
	                return item.Value;                                                                                                         // BuildMemberBase.cs:215
	            }                                                                                                                              // BuildMemberBase.cs:216
	                                                                                                                                           // BuildMemberBase.cs:222
	            // BuildMemberBase.cs:223
	            /// <summary>
	            /// Set Item's Value
	            /// </summary>
	            public CodeableConcept Set(CodeableConcept value)                                                                              // BuildMemberBase.cs:226
	            {                                                                                                                              // BuildMemberBase.cs:227
	                this.item = new Item(value);                                                                                               // BuildMemberBase.cs:228
	                return value;                                                                                                              // BuildMemberBase.cs:229
	            }                                                                                                                              // BuildMemberBase.cs:230
	            #endregion                                                                                                                     // BuildMemberBase.cs:304
	                                                                                                                                           // BuildMemberBase.cs:151
	            // BuildMemberBase.cs:152
	            /// <summary>
	            /// Constructor
	            /// </summary>
	            public LandMarkCollection(Int32 min, Int32 max) : base("Extension.extension:landMark", min, max)                               // BuildMemberBase.cs:155
	            {                                                                                                                              // BuildMemberBase.cs:156
	            }                                                                                                                              // BuildMemberBase.cs:158
	                                                                                                                                           // BuildMemberBase.cs:159
	            // Methods                                                                                                                     // BuildMemberBase.cs:160
	                                                                                                                                           // BuildMemberBase.cs:308
	            // BuildMemberBase.cs:309
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
	                                                                                                                                           // BuildMemberBase.cs:314
	            // BuildMemberBase.cs:315
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
	        }                                                                                                                                  // BuildMemberBase.cs:162
	        #endregion                                                                                                                         // BuildMemberBase.cs:163
	        #region Extension.extension:distanceFromLandMark Container Class                                                                   // BuildMemberBase.cs:140
	        // Called from BuildMemberExtensionSimple.cs, Line 97
	        // BuildMemberBase.cs:142
	        /// <summary>
	        /// Container class for Extension.extension:distanceFromLandMark.
	        /// </summary>
	        public class DistanceFromLandMarkCollection : MContainer, ITMItem<Extension>                                                       // BuildMemberBase.cs:145
	        {                                                                                                                                  // BuildMemberBase.cs:146
	            #region Extension.extension:distanceFromLandMark Item Class                                                                    // BuildMemberBase.cs:75
	            // Called from BuildMemberExtensionSimple.cs, Line 97
	            // BuildMemberBase.cs:77
	            /// <summary>
	            /// Item class for Extension.extension:distanceFromLandMark.
	            /// </summary>
	            public class Item                                                                                                              // BuildMemberBase.cs:80
	            {                                                                                                                              // BuildMemberBase.cs:81
	                // Properties                                                                                                              // BuildMemberBase.cs:82
	                // BuildMemberBase.cs:83
	                /// <summary>
	                /// Value
	                /// </summary>
	                public Quantity Value { get; set; }                                                                                        // BuildMemberBase.cs:86
	                                                                                                                                           // BuildMemberBase.cs:88
	                // BuildMemberBase.cs:89
	                /// <summary>
	                /// Constructor
	                /// </summary>
	                public Item(Quantity value)                                                                                                // BuildMemberBase.cs:92
	                {                                                                                                                          // BuildMemberBase.cs:93
	                    this.Value = value;                                                                                                    // BuildMemberBase.cs:94
	                }                                                                                                                          // BuildMemberBase.cs:96
	                                                                                                                                           // BuildMemberBase.cs:98
	                // Methods                                                                                                                 // BuildMemberBase.cs:99
	            }                                                                                                                              // BuildMemberBase.cs:101
	            #endregion                                                                                                                     // BuildMemberBase.cs:102
	                                                                                                                                           // BuildMemberBase.cs:148
	            // Properties                                                                                                                  // BuildMemberBase.cs:149
	            public const String ExtensionUrl = "distanceFromLandMark";                                                                     // BuildMemberExtensionSimple.cs:39
	            #region Common Singleton Properties                                                                                            // BuildMemberBase.cs:171
	                                                                                                                                           // BuildMemberBase.cs:172
	            // BuildMemberBase.cs:173
	            /// <summary>
	            /// Get All Items
	            /// </summary>
	            IEnumerable<Item> GetAllItems()                                                                                                // BuildMemberBase.cs:176
	            {                                                                                                                              // BuildMemberBase.cs:177
	                if (this.item != null) yield return this.item;                                                                             // BuildMemberBase.cs:178
	            }                                                                                                                              // BuildMemberBase.cs:179
	                                                                                                                                           // BuildMemberBase.cs:181
	            // BuildMemberBase.cs:182
	            /// <summary>
	            /// Set All Items
	            /// </summary>
	            void SetAllItems(IEnumerable<Item> items)                                                                                      // BuildMemberBase.cs:185
	            {                                                                                                                              // BuildMemberBase.cs:186
	                switch (items.Count())                                                                                                     // BuildMemberBase.cs:187
	                {                                                                                                                          // BuildMemberBase.cs:188
	                    case 0: break;                                                                                                         // BuildMemberBase.cs:189
	                    case 1: this.item = items.First(); break;                                                                              // BuildMemberBase.cs:190
	                    default: throw new Exception("Found multiple elements while reading single item");                                     // BuildMemberBase.cs:191
	                }                                                                                                                          // BuildMemberBase.cs:192
	            }                                                                                                                              // BuildMemberBase.cs:193
	                                                                                                                                           // BuildMemberBase.cs:195
	            // BuildMemberBase.cs:196
	            /// <summary>
	            /// Item
	            /// </summary>
	            Item item;                                                                                                                     // BuildMemberBase.cs:199
	                                                                                                                                           // BuildMemberBase.cs:201
	            // BuildMemberBase.cs:202
	            /// <summary>
	            /// Count property
	            /// </summary>
	            public override Int32 Count => this.item == null ? 0 : 1;                                                                      // BuildMemberBase.cs:205
	                                                                                                                                           // BuildMemberBase.cs:207
	            // BuildMemberBase.cs:208
	            /// <summary>
	            /// Get Item's Value
	            /// </summary>
	            public Quantity Get()                                                                                                          // BuildMemberBase.cs:211
	            {                                                                                                                              // BuildMemberBase.cs:212
	                if (item == null)                                                                                                          // BuildMemberBase.cs:213
	                    return null;                                                                                                           // BuildMemberBase.cs:214
	                return item.Value;                                                                                                         // BuildMemberBase.cs:215
	            }                                                                                                                              // BuildMemberBase.cs:216
	                                                                                                                                           // BuildMemberBase.cs:222
	            // BuildMemberBase.cs:223
	            /// <summary>
	            /// Set Item's Value
	            /// </summary>
	            public Quantity Set(Quantity value)                                                                                            // BuildMemberBase.cs:226
	            {                                                                                                                              // BuildMemberBase.cs:227
	                this.item = new Item(value);                                                                                               // BuildMemberBase.cs:228
	                return value;                                                                                                              // BuildMemberBase.cs:229
	            }                                                                                                                              // BuildMemberBase.cs:230
	            #endregion                                                                                                                     // BuildMemberBase.cs:304
	                                                                                                                                           // BuildMemberBase.cs:151
	            // BuildMemberBase.cs:152
	            /// <summary>
	            /// Constructor
	            /// </summary>
	            public DistanceFromLandMarkCollection(Int32 min, Int32 max) : base("Extension.extension:distanceFromLandMark", min, max)       // BuildMemberBase.cs:155
	            {                                                                                                                              // BuildMemberBase.cs:156
	            }                                                                                                                              // BuildMemberBase.cs:158
	                                                                                                                                           // BuildMemberBase.cs:159
	            // Methods                                                                                                                     // BuildMemberBase.cs:160
	                                                                                                                                           // BuildMemberBase.cs:308
	            // BuildMemberBase.cs:309
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
	                                                                                                                                           // BuildMemberBase.cs:314
	            // BuildMemberBase.cs:315
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
	                    items.Add(new Item((Quantity) myExtension.Value));                                                                     // BuildMemberExtensionSimple.cs:55
	                this.SetAllItems(items);                                                                                                   // BuildMemberExtensionSimple.cs:56
	            }                                                                                                                              // BuildMemberExtensionSimple.cs:57
	        }                                                                                                                                  // BuildMemberBase.cs:162
	        #endregion                                                                                                                         // BuildMemberBase.cs:163
	        // Properties                                                                                                                      // BuildMemberExtensionComplex.cs:101
	                                                                                                                                           // BuildMemberBase.cs:349
	        // Called from BuildMemberExtensionSimple.cs, Line 97
	        // BuildMemberBase.cs:351
	        /// <summary>
	        /// LandMark
	        /// Access fhir element 'Extension.extension:landMark'
	        /// </summary>
	        public LandMarkCollection LandMark { get ; protected set; }                                                                        // BuildMemberBase.cs:355
	                                                                                                                                           // BuildMemberBase.cs:349
	        // Called from BuildMemberExtensionSimple.cs, Line 97
	        // BuildMemberBase.cs:351
	        /// <summary>
	        /// DistanceFromLandMark
	        /// Access fhir element 'Extension.extension:distanceFromLandMark'
	        /// </summary>
	        public DistanceFromLandMarkCollection DistanceFromLandMark { get ; protected set; }                                                // BuildMemberBase.cs:355
	                                                                                                                                           // BuildMemberExtensionComplex.cs:103
	        // BuildMemberExtensionComplex.cs:104
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public BodyDistanceFromExtension()                                                                                                 // BuildMemberExtensionComplex.cs:107
	        {                                                                                                                                  // BuildMemberExtensionComplex.cs:108
	            // Called from BuildMemberExtensionSimple.cs, Line 97
	            this.LandMark = new LandMarkCollection(0, 0);                                                                                  // BuildMemberBase.cs:334
	            // Called from BuildMemberExtensionSimple.cs, Line 97
	            this.DistanceFromLandMark = new DistanceFromLandMarkCollection(0, 0);                                                          // BuildMemberBase.cs:334
	        }                                                                                                                                  // BuildMemberExtensionComplex.cs:110
	                                                                                                                                           // BuildMemberExtensionComplex.cs:112
	        // Methods                                                                                                                         // BuildMemberExtensionComplex.cs:113
	                                                                                                                                           // BuildMemberExtensionComplex.cs:116
	        // BuildMemberExtensionComplex.cs:117
	        /// <summary>
	        /// Write item as a fhir element.
	        /// </summary>
	        public IEnumerable<Extension> Write(BreastRadiologyDocument doc)                                                                   // BuildMemberExtensionComplex.cs:120
	        {                                                                                                                                  // BuildMemberExtensionComplex.cs:121
	            List<Extension> items = new List<Extension>();                                                                                 // BuildMemberExtensionComplex.cs:122
	            items.AddRange(this.LandMark.Write(doc));                                                                                      // BuildMemberExtensionSimple.cs:82
	            items.AddRange(this.DistanceFromLandMark.Write(doc));                                                                          // BuildMemberExtensionSimple.cs:82
	            yield return new Extension                                                                                                     // BuildMemberExtensionComplex.cs:124
	            {                                                                                                                              // BuildMemberExtensionComplex.cs:125
	                Url = ExtensionUrl,                                                                                                        // BuildMemberExtensionComplex.cs:126
	                Extension = items                                                                                                          // BuildMemberExtensionComplex.cs:127
	            };                                                                                                                             // BuildMemberExtensionComplex.cs:128
	        }                                                                                                                                  // BuildMemberExtensionComplex.cs:129
	                                                                                                                                           // BuildMemberExtensionComplex.cs:131
	        // BuildMemberExtensionComplex.cs:132
	        /// <summary>
	        /// Read from fhir element into member item.
	        /// </summary>
	        public void Read(BreastRadiologyDocument doc, IEnumerable<Extension> extensions)                                                   // BuildMemberExtensionComplex.cs:135
	        {                                                                                                                                  // BuildMemberExtensionComplex.cs:136
	            this.LandMark.Read(doc, extensions);                                                                                           // BuildMemberExtensionSimple.cs:61
	            this.DistanceFromLandMark.Read(doc, extensions);                                                                               // BuildMemberExtensionSimple.cs:61
	        }                                                                                                                                  // BuildMemberExtensionComplex.cs:138
	    }                                                                                                                                      // BuildMemberExtensionComplex.cs:140
	                                                                                                                                           // BuildMemberBase.cs:148
	    // Properties                                                                                                                          // BuildMemberBase.cs:149
	    public const String ExtensionUrl = "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/BodyDistanceFromExtension";            // BuildMemberExtensionComplex.cs:36
	    #region Common Non-Singleton Properties                                                                                                // BuildMemberBase.cs:237
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:238
	                                                                                                                                           // BuildMemberBase.cs:240
	    // BuildMemberBase.cs:241
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:244
	                                                                                                                                           // BuildMemberBase.cs:246
	    // BuildMemberBase.cs:247
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:250
	                                                                                                                                           // BuildMemberBase.cs:252
	    // BuildMemberBase.cs:253
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:256
	                                                                                                                                           // BuildMemberBase.cs:258
	    // BuildMemberBase.cs:259
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<BodyDistanceFromExtension> All()                                                                                    // BuildMemberBase.cs:262
	    {                                                                                                                                      // BuildMemberBase.cs:263
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:264
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:265
	    }                                                                                                                                      // BuildMemberBase.cs:266
	                                                                                                                                           // BuildMemberBase.cs:268
	    // BuildMemberBase.cs:269
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public BodyDistanceFromExtension GetAt(Int32 i) => this.items[i].Value;                                                                // BuildMemberBase.cs:272
	                                                                                                                                           // BuildMemberBase.cs:274
	    // BuildMemberBase.cs:275
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:278
	                                                                                                                                           // BuildMemberBase.cs:280
	    // BuildMemberBase.cs:281
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:284
	    #endregion                                                                                                                             // BuildMemberBase.cs:304
	                                                                                                                                           // BuildMemberBase.cs:151
	    // BuildMemberBase.cs:152
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public BodyDistanceFromExtensionCollection(Int32 min, Int32 max) : base("BodyDistanceFromExtension", min, max)                         // BuildMemberBase.cs:155
	    {                                                                                                                                      // BuildMemberBase.cs:156
	    }                                                                                                                                      // BuildMemberBase.cs:158
	                                                                                                                                           // BuildMemberBase.cs:159
	    // Methods                                                                                                                             // BuildMemberBase.cs:160
	                                                                                                                                           // BuildMemberBase.cs:290
	    // BuildMemberBase.cs:291
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public BodyDistanceFromExtension Append(BodyDistanceFromExtension value)                                                               // BuildMemberBase.cs:294
	    {                                                                                                                                      // BuildMemberBase.cs:295
	        this.items.Add(new Item(value));                                                                                                   // BuildMemberBase.cs:296
	        return value;                                                                                                                      // BuildMemberBase.cs:297
	    }                                                                                                                                      // BuildMemberBase.cs:298
	                                                                                                                                           // BuildMemberBase.cs:308
	    // BuildMemberBase.cs:309
	    /// <summary>
	    /// Write single item as a fhir element.
	    /// </summary>
	    public IEnumerable<Extension> Write(BreastRadiologyDocument doc)                                                                       // BuildMemberExtensionComplex.cs:69
	    {                                                                                                                                      // BuildMemberExtensionComplex.cs:70
	        throw new NotImplementedException();                                                                                               // BuildMemberExtensionComplex.cs:71
	    }                                                                                                                                      // BuildMemberExtensionComplex.cs:81
	                                                                                                                                           // BuildMemberBase.cs:314
	    // BuildMemberBase.cs:315
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	                                                                                                                                           // BuildMemberExtensionComplex.cs:43
	    public void Read(BreastRadiologyDocument doc, IEnumerable<Extension> extensions)                                                       // BuildMemberExtensionComplex.cs:44
	    {                                                                                                                                      // BuildMemberExtensionComplex.cs:45
	        throw new NotImplementedException();                                                                                               // BuildMemberExtensionComplex.cs:46
	    }                                                                                                                                      // BuildMemberExtensionComplex.cs:58
	}                                                                                                                                          // BuildMemberBase.cs:162
	#endregion                                                                                                                                 // BuildMemberBase.cs:163
	//- LocalClassDefs
}
