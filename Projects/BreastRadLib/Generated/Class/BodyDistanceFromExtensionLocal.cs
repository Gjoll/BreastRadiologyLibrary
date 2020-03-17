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
	#region BodyDistanceFromExtension Container Class                                                                                          // BuildMemberBase.cs:157
	// Called from BuildMemberExtensionComplex.cs, Line 189
	// BuildMemberBase.cs:159
	/// <summary>
	/// Container class for BodyDistanceFromExtension.
	/// </summary>
	public class BodyDistanceFromExtensionCollection : MContainer, ITMItem<Extension>                                                          // BuildMemberBase.cs:162
	{                                                                                                                                          // BuildMemberBase.cs:163
	    #region BodyDistanceFromExtension Item Class                                                                                           // BuildMemberBase.cs:75
	    // Called from BuildMemberExtensionComplex.cs, Line 189
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
	                                                                                                                                           // BuildMemberExtensionComplex.cs:54
	        public void Write(BreastRadiologyDocument doc, Extension component)                                                                // BuildMemberExtensionComplex.cs:55
	        {                                                                                                                                  // BuildMemberExtensionComplex.cs:56
	            throw new NotImplementedException("xxyyz");                                                                                    // BuildMemberExtensionComplex.cs:57
	        }                                                                                                                                  // BuildMemberExtensionComplex.cs:58
	                                                                                                                                           // BuildMemberBase.cs:107
	        // BuildMemberBase.cs:108
	        /// <summary>
	        /// Read item.
	        /// </summary>
	                                                                                                                                           // BuildMemberExtensionComplex.cs:43
	        public void Read(BreastRadiologyDocument doc, Extension component)                                                                 // BuildMemberExtensionComplex.cs:44
	        {                                                                                                                                  // BuildMemberExtensionComplex.cs:45
	            throw new NotImplementedException("xxyyz");                                                                                    // BuildMemberExtensionComplex.cs:46
	        }                                                                                                                                  // BuildMemberExtensionComplex.cs:47
	    }                                                                                                                                      // BuildMemberBase.cs:114
	    #endregion                                                                                                                             // BuildMemberBase.cs:115
	    // BuildMemberExtensionComplex.cs:116
	    /// <summary>
	    /// Extension class for BodyDistanceFromExtension.
	    /// </summary>
	    public class BodyDistanceFromExtension                                                                                                 // BuildMemberExtensionComplex.cs:119
	    {                                                                                                                                      // BuildMemberExtensionComplex.cs:120
	        // Definitions                                                                                                                     // BuildMemberExtensionComplex.cs:121
	        #region Extension.extension:landMark Container Class                                                                               // BuildMemberBase.cs:157
	        // Called from BuildMemberExtensionSimple.cs, Line 121
	        // BuildMemberBase.cs:159
	        /// <summary>
	        /// Container class for Extension.extension:landMark.
	        /// </summary>
	        public class LandMarkCollection : MContainer, ITMItem<Extension>                                                                   // BuildMemberBase.cs:162
	        {                                                                                                                                  // BuildMemberBase.cs:163
	            #region Extension.extension:landMark Item Class                                                                                // BuildMemberBase.cs:75
	            // Called from BuildMemberExtensionSimple.cs, Line 121
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
	                                                                                                                                           // BuildMemberBase.cs:89
	                // BuildMemberBase.cs:90
	                /// <summary>
	                /// Constructor
	                /// </summary>
	                public Item()                                                                                                              // BuildMemberBase.cs:93
	                {                                                                                                                          // BuildMemberBase.cs:94
	                }                                                                                                                          // BuildMemberBase.cs:96
	                                                                                                                                           // BuildMemberBase.cs:98
	                // Methods                                                                                                                 // BuildMemberBase.cs:99
	                                                                                                                                           // BuildMemberBase.cs:101
	                // BuildMemberBase.cs:102
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
	                                                                                                                                           // BuildMemberBase.cs:107
	                // BuildMemberBase.cs:108
	                /// <summary>
	                /// Read item.
	                /// </summary>
	                                                                                                                                           // BuildMemberExtensionSimple.cs:46
	                public void ReadItem(BreastRadiologyDocument doc, Extension extension)                                                     // BuildMemberExtensionSimple.cs:47
	                {                                                                                                                          // BuildMemberExtensionSimple.cs:48
	                    this.Value = (CodeableConcept) extension.Value;                                                                        // BuildMemberExtensionSimple.cs:49
	                }                                                                                                                          // BuildMemberExtensionSimple.cs:50
	            }                                                                                                                              // BuildMemberBase.cs:114
	            #endregion                                                                                                                     // BuildMemberBase.cs:115
	                                                                                                                                           // BuildMemberBase.cs:166
	            // Properties                                                                                                                  // BuildMemberBase.cs:167
	            public const String ExtensionUrl = "landMark";                                                                                 // BuildMemberExtensionSimple.cs:39
	            #region Common Singleton Properties                                                                                            // BuildMemberBase.cs:191
	                                                                                                                                           // BuildMemberBase.cs:193
	            // BuildMemberBase.cs:194
	            /// <summary>
	            /// Get All Items
	            /// </summary>
	            IEnumerable<Item> GetAllItems()                                                                                                // BuildMemberBase.cs:197
	            {                                                                                                                              // BuildMemberBase.cs:198
	                if (this.item != null) yield return this.item;                                                                             // BuildMemberBase.cs:199
	            }                                                                                                                              // BuildMemberBase.cs:200
	                                                                                                                                           // BuildMemberBase.cs:202
	            // BuildMemberBase.cs:203
	            /// <summary>
	            /// Set All Items
	            /// </summary>
	            void SetAllItems(IEnumerable<Item> items)                                                                                      // BuildMemberBase.cs:206
	            {                                                                                                                              // BuildMemberBase.cs:207
	                switch (items.Count())                                                                                                     // BuildMemberBase.cs:208
	                {                                                                                                                          // BuildMemberBase.cs:209
	                    case 0: break;                                                                                                         // BuildMemberBase.cs:210
	                    case 1: this.item = items.First(); break;                                                                              // BuildMemberBase.cs:211
	                    default: throw new Exception("Found multiple elements while reading single item");                                     // BuildMemberBase.cs:212
	                }                                                                                                                          // BuildMemberBase.cs:213
	            }                                                                                                                              // BuildMemberBase.cs:214
	                                                                                                                                           // BuildMemberBase.cs:216
	            // BuildMemberBase.cs:217
	            /// <summary>
	            /// Item
	            /// </summary>
	            Item item;                                                                                                                     // BuildMemberBase.cs:220
	                                                                                                                                           // BuildMemberBase.cs:222
	            // BuildMemberBase.cs:223
	            /// <summary>
	            /// Count property
	            /// </summary>
	            public override Int32 Count => this.item == null ? 0 : 1;                                                                      // BuildMemberBase.cs:226
	                                                                                                                                           // BuildMemberBase.cs:228
	            // BuildMemberBase.cs:229
	            /// <summary>
	            /// Get Item's Value
	            /// </summary>
	            public CodeableConcept Get()                                                                                                   // BuildMemberBase.cs:232
	            {                                                                                                                              // BuildMemberBase.cs:233
	                if (item == null)                                                                                                          // BuildMemberBase.cs:234
	                    return null;                                                                                                           // BuildMemberBase.cs:235
	                return item.Value;                                                                                                         // BuildMemberBase.cs:236
	            }                                                                                                                              // BuildMemberBase.cs:237
	                                                                                                                                           // BuildMemberBase.cs:243
	            // BuildMemberBase.cs:244
	            /// <summary>
	            /// Set Item's Value
	            /// </summary>
	            public CodeableConcept Set(CodeableConcept value)                                                                              // BuildMemberBase.cs:247
	            {                                                                                                                              // BuildMemberBase.cs:248
	                Item item = new Item();                                                                                                    // BuildMemberBase.cs:249
	                item.Value = value;                                                                                                        // BuildMemberBase.cs:250
	                this.item = item;                                                                                                          // BuildMemberBase.cs:251
	                return value;                                                                                                              // BuildMemberBase.cs:252
	            }                                                                                                                              // BuildMemberBase.cs:253
	            #endregion                                                                                                                     // BuildMemberBase.cs:329
	                                                                                                                                           // BuildMemberBase.cs:170
	            // BuildMemberBase.cs:171
	            /// <summary>
	            /// Constructor
	            /// </summary>
	            public LandMarkCollection(Int32 min, Int32 max) : base("Extension.extension:landMark", min, max)                               // BuildMemberBase.cs:174
	            {                                                                                                                              // BuildMemberBase.cs:175
	            }                                                                                                                              // BuildMemberBase.cs:177
	                                                                                                                                           // BuildMemberBase.cs:179
	            // Methods                                                                                                                     // BuildMemberBase.cs:180
	                                                                                                                                           // BuildMemberBase.cs:333
	            // BuildMemberBase.cs:334
	            /// <summary>
	            /// Write container items.
	            /// </summary>
	            public IEnumerable<Extension> Write(BreastRadiologyDocument doc)                                                               // BuildMemberExtensionSimple.cs:98
	            {                                                                                                                              // BuildMemberExtensionSimple.cs:99
	                foreach (Item item in this.GetAllItems())                                                                                  // BuildMemberExtensionSimple.cs:100
	                    yield return item.WriteItem(doc);                                                                                      // BuildMemberExtensionSimple.cs:101
	            }                                                                                                                              // BuildMemberExtensionSimple.cs:102
	                                                                                                                                           // BuildMemberBase.cs:339
	            // BuildMemberBase.cs:340
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
	        }                                                                                                                                  // BuildMemberBase.cs:182
	        #endregion                                                                                                                         // BuildMemberBase.cs:183
	        #region Extension.extension:distanceFromLandMark Container Class                                                                   // BuildMemberBase.cs:157
	        // Called from BuildMemberExtensionSimple.cs, Line 121
	        // BuildMemberBase.cs:159
	        /// <summary>
	        /// Container class for Extension.extension:distanceFromLandMark.
	        /// </summary>
	        public class DistanceFromLandMarkCollection : MContainer, ITMItem<Extension>                                                       // BuildMemberBase.cs:162
	        {                                                                                                                                  // BuildMemberBase.cs:163
	            #region Extension.extension:distanceFromLandMark Item Class                                                                    // BuildMemberBase.cs:75
	            // Called from BuildMemberExtensionSimple.cs, Line 121
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
	                                                                                                                                           // BuildMemberBase.cs:89
	                // BuildMemberBase.cs:90
	                /// <summary>
	                /// Constructor
	                /// </summary>
	                public Item()                                                                                                              // BuildMemberBase.cs:93
	                {                                                                                                                          // BuildMemberBase.cs:94
	                }                                                                                                                          // BuildMemberBase.cs:96
	                                                                                                                                           // BuildMemberBase.cs:98
	                // Methods                                                                                                                 // BuildMemberBase.cs:99
	                                                                                                                                           // BuildMemberBase.cs:101
	                // BuildMemberBase.cs:102
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
	                                                                                                                                           // BuildMemberBase.cs:107
	                // BuildMemberBase.cs:108
	                /// <summary>
	                /// Read item.
	                /// </summary>
	                                                                                                                                           // BuildMemberExtensionSimple.cs:46
	                public void ReadItem(BreastRadiologyDocument doc, Extension extension)                                                     // BuildMemberExtensionSimple.cs:47
	                {                                                                                                                          // BuildMemberExtensionSimple.cs:48
	                    this.Value = (Quantity) extension.Value;                                                                               // BuildMemberExtensionSimple.cs:49
	                }                                                                                                                          // BuildMemberExtensionSimple.cs:50
	            }                                                                                                                              // BuildMemberBase.cs:114
	            #endregion                                                                                                                     // BuildMemberBase.cs:115
	                                                                                                                                           // BuildMemberBase.cs:166
	            // Properties                                                                                                                  // BuildMemberBase.cs:167
	            public const String ExtensionUrl = "distanceFromLandMark";                                                                     // BuildMemberExtensionSimple.cs:39
	            #region Common Singleton Properties                                                                                            // BuildMemberBase.cs:191
	                                                                                                                                           // BuildMemberBase.cs:193
	            // BuildMemberBase.cs:194
	            /// <summary>
	            /// Get All Items
	            /// </summary>
	            IEnumerable<Item> GetAllItems()                                                                                                // BuildMemberBase.cs:197
	            {                                                                                                                              // BuildMemberBase.cs:198
	                if (this.item != null) yield return this.item;                                                                             // BuildMemberBase.cs:199
	            }                                                                                                                              // BuildMemberBase.cs:200
	                                                                                                                                           // BuildMemberBase.cs:202
	            // BuildMemberBase.cs:203
	            /// <summary>
	            /// Set All Items
	            /// </summary>
	            void SetAllItems(IEnumerable<Item> items)                                                                                      // BuildMemberBase.cs:206
	            {                                                                                                                              // BuildMemberBase.cs:207
	                switch (items.Count())                                                                                                     // BuildMemberBase.cs:208
	                {                                                                                                                          // BuildMemberBase.cs:209
	                    case 0: break;                                                                                                         // BuildMemberBase.cs:210
	                    case 1: this.item = items.First(); break;                                                                              // BuildMemberBase.cs:211
	                    default: throw new Exception("Found multiple elements while reading single item");                                     // BuildMemberBase.cs:212
	                }                                                                                                                          // BuildMemberBase.cs:213
	            }                                                                                                                              // BuildMemberBase.cs:214
	                                                                                                                                           // BuildMemberBase.cs:216
	            // BuildMemberBase.cs:217
	            /// <summary>
	            /// Item
	            /// </summary>
	            Item item;                                                                                                                     // BuildMemberBase.cs:220
	                                                                                                                                           // BuildMemberBase.cs:222
	            // BuildMemberBase.cs:223
	            /// <summary>
	            /// Count property
	            /// </summary>
	            public override Int32 Count => this.item == null ? 0 : 1;                                                                      // BuildMemberBase.cs:226
	                                                                                                                                           // BuildMemberBase.cs:228
	            // BuildMemberBase.cs:229
	            /// <summary>
	            /// Get Item's Value
	            /// </summary>
	            public Quantity Get()                                                                                                          // BuildMemberBase.cs:232
	            {                                                                                                                              // BuildMemberBase.cs:233
	                if (item == null)                                                                                                          // BuildMemberBase.cs:234
	                    return null;                                                                                                           // BuildMemberBase.cs:235
	                return item.Value;                                                                                                         // BuildMemberBase.cs:236
	            }                                                                                                                              // BuildMemberBase.cs:237
	                                                                                                                                           // BuildMemberBase.cs:243
	            // BuildMemberBase.cs:244
	            /// <summary>
	            /// Set Item's Value
	            /// </summary>
	            public Quantity Set(Quantity value)                                                                                            // BuildMemberBase.cs:247
	            {                                                                                                                              // BuildMemberBase.cs:248
	                Item item = new Item();                                                                                                    // BuildMemberBase.cs:249
	                item.Value = value;                                                                                                        // BuildMemberBase.cs:250
	                this.item = item;                                                                                                          // BuildMemberBase.cs:251
	                return value;                                                                                                              // BuildMemberBase.cs:252
	            }                                                                                                                              // BuildMemberBase.cs:253
	            #endregion                                                                                                                     // BuildMemberBase.cs:329
	                                                                                                                                           // BuildMemberBase.cs:170
	            // BuildMemberBase.cs:171
	            /// <summary>
	            /// Constructor
	            /// </summary>
	            public DistanceFromLandMarkCollection(Int32 min, Int32 max) : base("Extension.extension:distanceFromLandMark", min, max)       // BuildMemberBase.cs:174
	            {                                                                                                                              // BuildMemberBase.cs:175
	            }                                                                                                                              // BuildMemberBase.cs:177
	                                                                                                                                           // BuildMemberBase.cs:179
	            // Methods                                                                                                                     // BuildMemberBase.cs:180
	                                                                                                                                           // BuildMemberBase.cs:333
	            // BuildMemberBase.cs:334
	            /// <summary>
	            /// Write container items.
	            /// </summary>
	            public IEnumerable<Extension> Write(BreastRadiologyDocument doc)                                                               // BuildMemberExtensionSimple.cs:98
	            {                                                                                                                              // BuildMemberExtensionSimple.cs:99
	                foreach (Item item in this.GetAllItems())                                                                                  // BuildMemberExtensionSimple.cs:100
	                    yield return item.WriteItem(doc);                                                                                      // BuildMemberExtensionSimple.cs:101
	            }                                                                                                                              // BuildMemberExtensionSimple.cs:102
	                                                                                                                                           // BuildMemberBase.cs:339
	            // BuildMemberBase.cs:340
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
	        }                                                                                                                                  // BuildMemberBase.cs:182
	        #endregion                                                                                                                         // BuildMemberBase.cs:183
	        // Properties                                                                                                                      // BuildMemberExtensionComplex.cs:123
	                                                                                                                                           // BuildMemberBase.cs:374
	        // Called from BuildMemberExtensionSimple.cs, Line 121
	        // BuildMemberBase.cs:376
	        /// <summary>
	        /// LandMark
	        /// Access fhir element 'Extension.extension:landMark'
	        /// </summary>
	        public LandMarkCollection LandMark { get ; protected set; }                                                                        // BuildMemberBase.cs:380
	                                                                                                                                           // BuildMemberBase.cs:374
	        // Called from BuildMemberExtensionSimple.cs, Line 121
	        // BuildMemberBase.cs:376
	        /// <summary>
	        /// DistanceFromLandMark
	        /// Access fhir element 'Extension.extension:distanceFromLandMark'
	        /// </summary>
	        public DistanceFromLandMarkCollection DistanceFromLandMark { get ; protected set; }                                                // BuildMemberBase.cs:380
	                                                                                                                                           // BuildMemberExtensionComplex.cs:125
	        // BuildMemberExtensionComplex.cs:126
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public BodyDistanceFromExtension()                                                                                                 // BuildMemberExtensionComplex.cs:129
	        {                                                                                                                                  // BuildMemberExtensionComplex.cs:130
	            // Called from BuildMemberExtensionSimple.cs, Line 121
	            this.LandMark = new LandMarkCollection(0, 0);                                                                                  // BuildMemberBase.cs:359
	            // Called from BuildMemberExtensionSimple.cs, Line 121
	            this.DistanceFromLandMark = new DistanceFromLandMarkCollection(0, 0);                                                          // BuildMemberBase.cs:359
	        }                                                                                                                                  // BuildMemberExtensionComplex.cs:132
	                                                                                                                                           // BuildMemberExtensionComplex.cs:134
	        // Methods                                                                                                                         // BuildMemberExtensionComplex.cs:135
	                                                                                                                                           // BuildMemberExtensionComplex.cs:138
	        // BuildMemberExtensionComplex.cs:139
	        /// <summary>
	        /// Write item as a fhir element.
	        /// </summary>
	        public IEnumerable<Extension> Write(BreastRadiologyDocument doc)                                                                   // BuildMemberExtensionComplex.cs:142
	        {                                                                                                                                  // BuildMemberExtensionComplex.cs:143
	            List<Extension> items = new List<Extension>();                                                                                 // BuildMemberExtensionComplex.cs:144
	            items.AddRange(this.LandMark.Write(doc));                                                                                      // BuildMemberExtensionSimple.cs:106
	            items.AddRange(this.DistanceFromLandMark.Write(doc));                                                                          // BuildMemberExtensionSimple.cs:106
	            yield return new Extension                                                                                                     // BuildMemberExtensionComplex.cs:146
	            {                                                                                                                              // BuildMemberExtensionComplex.cs:147
	                Url = ExtensionUrl,                                                                                                        // BuildMemberExtensionComplex.cs:148
	                Extension = items                                                                                                          // BuildMemberExtensionComplex.cs:149
	            };                                                                                                                             // BuildMemberExtensionComplex.cs:150
	        }                                                                                                                                  // BuildMemberExtensionComplex.cs:151
	                                                                                                                                           // BuildMemberExtensionComplex.cs:153
	        // BuildMemberExtensionComplex.cs:154
	        /// <summary>
	        /// Read from fhir element into member item.
	        /// </summary>
	        public void Read(BreastRadiologyDocument doc, IEnumerable<Extension> extensions)                                                   // BuildMemberExtensionComplex.cs:157
	        {                                                                                                                                  // BuildMemberExtensionComplex.cs:158
	            this.LandMark.Read(doc, extensions);                                                                                           // BuildMemberExtensionSimple.cs:91
	            this.DistanceFromLandMark.Read(doc, extensions);                                                                               // BuildMemberExtensionSimple.cs:91
	        }                                                                                                                                  // BuildMemberExtensionComplex.cs:160
	    }                                                                                                                                      // BuildMemberExtensionComplex.cs:162
	                                                                                                                                           // BuildMemberBase.cs:166
	    // Properties                                                                                                                          // BuildMemberBase.cs:167
	    public const String ExtensionUrl = "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/BodyDistanceFromExtension";            // BuildMemberExtensionComplex.cs:36
	    #region Common Non-Singleton Properties                                                                                                // BuildMemberBase.cs:260
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:261
	                                                                                                                                           // BuildMemberBase.cs:263
	    // BuildMemberBase.cs:264
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:267
	                                                                                                                                           // BuildMemberBase.cs:269
	    // BuildMemberBase.cs:270
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:273
	                                                                                                                                           // BuildMemberBase.cs:275
	    // BuildMemberBase.cs:276
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:279
	                                                                                                                                           // BuildMemberBase.cs:281
	    // BuildMemberBase.cs:282
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<BodyDistanceFromExtension> All()                                                                                    // BuildMemberBase.cs:285
	    {                                                                                                                                      // BuildMemberBase.cs:286
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:287
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:288
	    }                                                                                                                                      // BuildMemberBase.cs:289
	                                                                                                                                           // BuildMemberBase.cs:291
	    // BuildMemberBase.cs:292
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public BodyDistanceFromExtension GetAt(Int32 i) => this.items[i].Value;                                                                // BuildMemberBase.cs:295
	                                                                                                                                           // BuildMemberBase.cs:297
	    // BuildMemberBase.cs:298
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:301
	                                                                                                                                           // BuildMemberBase.cs:303
	    // BuildMemberBase.cs:304
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:307
	    #endregion                                                                                                                             // BuildMemberBase.cs:329
	                                                                                                                                           // BuildMemberBase.cs:170
	    // BuildMemberBase.cs:171
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public BodyDistanceFromExtensionCollection(Int32 min, Int32 max) : base("BodyDistanceFromExtension", min, max)                         // BuildMemberBase.cs:174
	    {                                                                                                                                      // BuildMemberBase.cs:175
	    }                                                                                                                                      // BuildMemberBase.cs:177
	                                                                                                                                           // BuildMemberBase.cs:179
	    // Methods                                                                                                                             // BuildMemberBase.cs:180
	                                                                                                                                           // BuildMemberBase.cs:313
	    // BuildMemberBase.cs:314
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public BodyDistanceFromExtension Append(BodyDistanceFromExtension value)                                                               // BuildMemberBase.cs:317
	    {                                                                                                                                      // BuildMemberBase.cs:318
	        Item item = new Item();                                                                                                            // BuildMemberBase.cs:319
	        item.Value = value;                                                                                                                // BuildMemberBase.cs:320
	        this.items.Add(item);                                                                                                              // BuildMemberBase.cs:321
	        return value;                                                                                                                      // BuildMemberBase.cs:322
	    }                                                                                                                                      // BuildMemberBase.cs:323
	                                                                                                                                           // BuildMemberBase.cs:333
	    // BuildMemberBase.cs:334
	    /// <summary>
	    /// Write container items.
	    /// </summary>
	    public IEnumerable<Extension> Write(BreastRadiologyDocument doc)                                                                       // BuildMemberExtensionComplex.cs:91
	    {                                                                                                                                      // BuildMemberExtensionComplex.cs:92
	        throw new NotImplementedException("xxyyz");                                                                                        // BuildMemberExtensionComplex.cs:93
	    }                                                                                                                                      // BuildMemberExtensionComplex.cs:103
	                                                                                                                                           // BuildMemberBase.cs:339
	    // BuildMemberBase.cs:340
	    /// <summary>
	    /// Read container items.
	    /// </summary>
	                                                                                                                                           // BuildMemberExtensionComplex.cs:65
	    public void Read(BreastRadiologyDocument doc, IEnumerable<Extension> extensions)                                                       // BuildMemberExtensionComplex.cs:66
	    {                                                                                                                                      // BuildMemberExtensionComplex.cs:67
	        throw new NotImplementedException("xxyyz");                                                                                        // BuildMemberExtensionComplex.cs:68
	    }                                                                                                                                      // BuildMemberExtensionComplex.cs:80
	}                                                                                                                                          // BuildMemberBase.cs:182
	#endregion                                                                                                                                 // BuildMemberBase.cs:183
	//- LocalClassDefs
}
