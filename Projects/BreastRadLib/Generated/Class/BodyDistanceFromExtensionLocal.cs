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
	#region BodyDistanceFromExtension Container Class                                                                                          // BuildMemberBase.cs:173
	// Called from BuildMemberExtensionComplex.cs, Line 180
	// BuildMemberBase.cs:175
	/// <summary>
	/// Container class for BodyDistanceFromExtension.
	/// </summary>
	public class MBodyDistanceFromExtension : MContainer, ITMItem<Extension>                                                                   // BuildMemberBase.cs:178
	{                                                                                                                                          // BuildMemberBase.cs:179
	    #region BodyDistanceFromExtension Item Class                                                                                           // BuildMemberBase.cs:81
	    // Called from BuildMemberExtensionComplex.cs, Line 180
	    // BuildMemberBase.cs:83
	    /// <summary>
	    /// Item class for BodyDistanceFromExtension.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:86
	    {                                                                                                                                      // BuildMemberBase.cs:87
	        // Properties                                                                                                                      // BuildMemberBase.cs:88
	        // BuildMemberBase.cs:90
	        /// <summary>
	        /// Value
	        /// </summary>
	        public Members Value { get; set; }                                                                                                 // BuildMemberBase.cs:93
	                                                                                                                                           // BuildMemberBase.cs:96
	        // BuildMemberBase.cs:97
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item()                                                                                                                      // BuildMemberBase.cs:100
	        {                                                                                                                                  // BuildMemberBase.cs:101
	        }                                                                                                                                  // BuildMemberBase.cs:103
	                                                                                                                                           // BuildMemberBase.cs:105
	        // Methods                                                                                                                         // BuildMemberBase.cs:106
	                                                                                                                                           // BuildMemberBase.cs:108
	        // BuildMemberBase.cs:109
	        /// <summary>
	        /// Write item.
	        /// </summary>
	        public Extension WriteItem(BreastRadiologyDocument doc)                                                                            // BuildMemberBase.cs:112
	        {                                                                                                                                  // BuildMemberBase.cs:113
	            Extension retVal = this.Value.WriteMember(doc);                                                                                // BuildMemberExtensionComplex.cs:51
	            return retVal;                                                                                                                 // BuildMemberBase.cs:116
	        }                                                                                                                                  // BuildMemberBase.cs:117
	                                                                                                                                           // BuildMemberBase.cs:119
	        // BuildMemberBase.cs:120
	        /// <summary>
	        /// Read item.
	        /// </summary>
	        public void ReadItem(BreastRadiologyDocument doc, Extension item)                                                                  // BuildMemberBase.cs:123
	        {                                                                                                                                  // BuildMemberBase.cs:124
	            this.Value = new Members();                                                                                                    // BuildMemberExtensionComplex.cs:43
	            this.Value.ReadMember(doc, item);                                                                                              // BuildMemberExtensionComplex.cs:44
	        }                                                                                                                                  // BuildMemberBase.cs:127
	    }                                                                                                                                      // BuildMemberBase.cs:130
	    #endregion                                                                                                                             // BuildMemberBase.cs:131
	    #region BodyDistanceFromExtension Member Class                                                                                         // BuildMemberExtensionComplex.cs:101
	    // BuildMemberExtensionComplex.cs:102
	    /// <summary>
	    /// Extension class for BodyDistanceFromExtension.
	    /// </summary>
	    public class Members                                                                                                                   // BuildMemberExtensionComplex.cs:105
	    {                                                                                                                                      // BuildMemberExtensionComplex.cs:106
	        // Definitions                                                                                                                     // BuildMemberExtensionComplex.cs:107
	        #region Extension.extension:landMark Container Class                                                                               // BuildMemberBase.cs:173
	        // Called from BuildMemberExtensionSimple.cs, Line 113
	        // BuildMemberBase.cs:175
	        /// <summary>
	        /// Container class for Extension.extension:landMark.
	        /// </summary>
	        public class MLandMark : MContainer, ITMItem<Extension>                                                                            // BuildMemberBase.cs:178
	        {                                                                                                                                  // BuildMemberBase.cs:179
	            #region Extension.extension:landMark Item Class                                                                                // BuildMemberBase.cs:81
	            // Called from BuildMemberExtensionSimple.cs, Line 113
	            // BuildMemberBase.cs:83
	            /// <summary>
	            /// Item class for Extension.extension:landMark.
	            /// </summary>
	            public class Item                                                                                                              // BuildMemberBase.cs:86
	            {                                                                                                                              // BuildMemberBase.cs:87
	                // Properties                                                                                                              // BuildMemberBase.cs:88
	                // BuildMemberBase.cs:90
	                /// <summary>
	                /// Value
	                /// </summary>
	                public CodeableConcept Value { get; set; }                                                                                 // BuildMemberBase.cs:93
	                                                                                                                                           // BuildMemberBase.cs:96
	                // BuildMemberBase.cs:97
	                /// <summary>
	                /// Constructor
	                /// </summary>
	                public Item()                                                                                                              // BuildMemberBase.cs:100
	                {                                                                                                                          // BuildMemberBase.cs:101
	                }                                                                                                                          // BuildMemberBase.cs:103
	                                                                                                                                           // BuildMemberBase.cs:105
	                // Methods                                                                                                                 // BuildMemberBase.cs:106
	                                                                                                                                           // BuildMemberBase.cs:108
	                // BuildMemberBase.cs:109
	                /// <summary>
	                /// Write item.
	                /// </summary>
	                public Extension WriteItem(BreastRadiologyDocument doc)                                                                    // BuildMemberBase.cs:112
	                {                                                                                                                          // BuildMemberBase.cs:113
	                    Extension retVal = new Extension                                                                                       // BuildMemberExtensionSimple.cs:53
	                    {                                                                                                                      // BuildMemberExtensionSimple.cs:54
	                        Value = this.Value,                                                                                                // BuildMemberExtensionSimple.cs:55
	                        Url = ExtensionUrl                                                                                                 // BuildMemberExtensionSimple.cs:56
	                    };                                                                                                                     // BuildMemberExtensionSimple.cs:57
	                    return retVal;                                                                                                         // BuildMemberBase.cs:116
	                }                                                                                                                          // BuildMemberBase.cs:117
	                                                                                                                                           // BuildMemberBase.cs:119
	                // BuildMemberBase.cs:120
	                /// <summary>
	                /// Read item.
	                /// </summary>
	                public void ReadItem(BreastRadiologyDocument doc, Extension item)                                                          // BuildMemberBase.cs:123
	                {                                                                                                                          // BuildMemberBase.cs:124
	                    this.Value = (CodeableConcept) item.Value;                                                                             // BuildMemberExtensionSimple.cs:46
	                }                                                                                                                          // BuildMemberBase.cs:127
	            }                                                                                                                              // BuildMemberBase.cs:130
	            #endregion                                                                                                                     // BuildMemberBase.cs:131
	                                                                                                                                           // BuildMemberBase.cs:182
	            // Properties                                                                                                                  // BuildMemberBase.cs:183
	            public const String ExtensionUrl = "landMark";                                                                                 // BuildMemberExtensionSimple.cs:39
	            #region Common Properties (Singleton)                                                                                          // BuildMemberBase.cs:207
	                                                                                                                                           // BuildMemberBase.cs:209
	            // BuildMemberBase.cs:210
	            /// <summary>
	            /// Get All Items
	            /// </summary>
	            IEnumerable<Item> GetAllItems()                                                                                                // BuildMemberBase.cs:213
	            {                                                                                                                              // BuildMemberBase.cs:214
	                if (this.item != null) yield return this.item;                                                                             // BuildMemberBase.cs:215
	            }                                                                                                                              // BuildMemberBase.cs:216
	                                                                                                                                           // BuildMemberBase.cs:218
	            // BuildMemberBase.cs:219
	            /// <summary>
	            /// Set All Items
	            /// </summary>
	            void SetAllItems(IEnumerable<Item> items)                                                                                      // BuildMemberBase.cs:222
	            {                                                                                                                              // BuildMemberBase.cs:223
	                switch (items.Count())                                                                                                     // BuildMemberBase.cs:224
	                {                                                                                                                          // BuildMemberBase.cs:225
	                    case 0: break;                                                                                                         // BuildMemberBase.cs:226
	                    case 1: this.item = items.First(); break;                                                                              // BuildMemberBase.cs:227
	                    default: throw new Exception("Found multiple elements while reading single item");                                     // BuildMemberBase.cs:228
	                }                                                                                                                          // BuildMemberBase.cs:229
	            }                                                                                                                              // BuildMemberBase.cs:230
	                                                                                                                                           // BuildMemberBase.cs:232
	            // BuildMemberBase.cs:233
	            /// <summary>
	            /// Item
	            /// </summary>
	            Item item;                                                                                                                     // BuildMemberBase.cs:236
	                                                                                                                                           // BuildMemberBase.cs:238
	            // BuildMemberBase.cs:239
	            /// <summary>
	            /// Count property
	            /// </summary>
	            public override Int32 Count => this.item == null ? 0 : 1;                                                                      // BuildMemberBase.cs:242
	                                                                                                                                           // BuildMemberBase.cs:244
	            // BuildMemberBase.cs:245
	            /// <summary>
	            /// Get Item's Value
	            /// </summary>
	            public CodeableConcept Get()                                                                                                   // BuildMemberBase.cs:248
	            {                                                                                                                              // BuildMemberBase.cs:249
	                if (item == null)                                                                                                          // BuildMemberBase.cs:250
	                    return null;                                                                                                           // BuildMemberBase.cs:251
	                return item.Value;                                                                                                         // BuildMemberBase.cs:252
	            }                                                                                                                              // BuildMemberBase.cs:253
	                                                                                                                                           // BuildMemberBase.cs:259
	            // BuildMemberBase.cs:260
	            /// <summary>
	            /// Set Item's Value
	            /// </summary>
	            public CodeableConcept Set(CodeableConcept value)                                                                              // BuildMemberBase.cs:263
	            {                                                                                                                              // BuildMemberBase.cs:264
	                Item item = new Item();                                                                                                    // BuildMemberBase.cs:265
	                item.Value = value;                                                                                                        // BuildMemberBase.cs:266
	                this.item = item;                                                                                                          // BuildMemberBase.cs:267
	                return value;                                                                                                              // BuildMemberBase.cs:268
	            }                                                                                                                              // BuildMemberBase.cs:269
	            #endregion                                                                                                                     // BuildMemberBase.cs:348
	                                                                                                                                           // BuildMemberBase.cs:186
	            // BuildMemberBase.cs:187
	            /// <summary>
	            /// Constructor
	            /// </summary>
	            public MLandMark(Int32 min, Int32 max) : base("Extension.extension:landMark", min, max)                                        // BuildMemberBase.cs:190
	            {                                                                                                                              // BuildMemberBase.cs:191
	            }                                                                                                                              // BuildMemberBase.cs:193
	                                                                                                                                           // BuildMemberBase.cs:195
	            // Methods                                                                                                                     // BuildMemberBase.cs:196
	                                                                                                                                           // BuildMemberBase.cs:352
	            // BuildMemberBase.cs:353
	            /// <summary>
	            /// Write container items.
	            /// </summary>
	            public IEnumerable<Extension> Write(BreastRadiologyDocument doc)                                                               // BuildMemberExtensionSimple.cs:90
	            {                                                                                                                              // BuildMemberExtensionSimple.cs:91
	                foreach (Item item in this.GetAllItems())                                                                                  // BuildMemberExtensionSimple.cs:92
	                    yield return item.WriteItem(doc);                                                                                      // BuildMemberExtensionSimple.cs:93
	            }                                                                                                                              // BuildMemberExtensionSimple.cs:94
	                                                                                                                                           // BuildMemberBase.cs:358
	            // BuildMemberBase.cs:359
	            /// <summary>
	            /// Read container items.
	            /// </summary>
	                                                                                                                                           // BuildMemberExtensionSimple.cs:64
	            public void Read(BreastRadiologyDocument doc, IEnumerable<Extension> extensions)                                               // BuildMemberExtensionSimple.cs:65
	            {                                                                                                                              // BuildMemberExtensionSimple.cs:66
	                List<Extension> memberExtensions = extensions                                                                              // BuildMemberExtensionSimple.cs:67
	                    .Where((a) => String.Compare(a.Url, ExtensionUrl, true) == 0)                                                          // BuildMemberExtensionSimple.cs:68
	                    .ToList()                                                                                                              // BuildMemberExtensionSimple.cs:69
	                    ;                                                                                                                      // BuildMemberExtensionSimple.cs:70
	                List<Item> items = new List<Item>();                                                                                       // BuildMemberExtensionSimple.cs:71
	                foreach (Extension memberExtension in memberExtensions)                                                                    // BuildMemberExtensionSimple.cs:72
	                {                                                                                                                          // BuildMemberExtensionSimple.cs:73
	                        Item item = new Item();                                                                                            // BuildMemberExtensionSimple.cs:74
	                        item.ReadItem(doc, memberExtension);                                                                               // BuildMemberExtensionSimple.cs:75
	                        items.Add(item);                                                                                                   // BuildMemberExtensionSimple.cs:76
	                }                                                                                                                          // BuildMemberExtensionSimple.cs:77
	                this.SetAllItems(items);                                                                                                   // BuildMemberExtensionSimple.cs:78
	            }                                                                                                                              // BuildMemberExtensionSimple.cs:79
	        }                                                                                                                                  // BuildMemberBase.cs:198
	        #endregion                                                                                                                         // BuildMemberBase.cs:199
	        #region Extension.extension:distanceFromLandMark Container Class                                                                   // BuildMemberBase.cs:173
	        // Called from BuildMemberExtensionSimple.cs, Line 113
	        // BuildMemberBase.cs:175
	        /// <summary>
	        /// Container class for Extension.extension:distanceFromLandMark.
	        /// </summary>
	        public class MDistanceFromLandMark : MContainer, ITMItem<Extension>                                                                // BuildMemberBase.cs:178
	        {                                                                                                                                  // BuildMemberBase.cs:179
	            #region Extension.extension:distanceFromLandMark Item Class                                                                    // BuildMemberBase.cs:81
	            // Called from BuildMemberExtensionSimple.cs, Line 113
	            // BuildMemberBase.cs:83
	            /// <summary>
	            /// Item class for Extension.extension:distanceFromLandMark.
	            /// </summary>
	            public class Item                                                                                                              // BuildMemberBase.cs:86
	            {                                                                                                                              // BuildMemberBase.cs:87
	                // Properties                                                                                                              // BuildMemberBase.cs:88
	                // BuildMemberBase.cs:90
	                /// <summary>
	                /// Value
	                /// </summary>
	                public Quantity Value { get; set; }                                                                                        // BuildMemberBase.cs:93
	                                                                                                                                           // BuildMemberBase.cs:96
	                // BuildMemberBase.cs:97
	                /// <summary>
	                /// Constructor
	                /// </summary>
	                public Item()                                                                                                              // BuildMemberBase.cs:100
	                {                                                                                                                          // BuildMemberBase.cs:101
	                }                                                                                                                          // BuildMemberBase.cs:103
	                                                                                                                                           // BuildMemberBase.cs:105
	                // Methods                                                                                                                 // BuildMemberBase.cs:106
	                                                                                                                                           // BuildMemberBase.cs:108
	                // BuildMemberBase.cs:109
	                /// <summary>
	                /// Write item.
	                /// </summary>
	                public Extension WriteItem(BreastRadiologyDocument doc)                                                                    // BuildMemberBase.cs:112
	                {                                                                                                                          // BuildMemberBase.cs:113
	                    Extension retVal = new Extension                                                                                       // BuildMemberExtensionSimple.cs:53
	                    {                                                                                                                      // BuildMemberExtensionSimple.cs:54
	                        Value = this.Value,                                                                                                // BuildMemberExtensionSimple.cs:55
	                        Url = ExtensionUrl                                                                                                 // BuildMemberExtensionSimple.cs:56
	                    };                                                                                                                     // BuildMemberExtensionSimple.cs:57
	                    return retVal;                                                                                                         // BuildMemberBase.cs:116
	                }                                                                                                                          // BuildMemberBase.cs:117
	                                                                                                                                           // BuildMemberBase.cs:119
	                // BuildMemberBase.cs:120
	                /// <summary>
	                /// Read item.
	                /// </summary>
	                public void ReadItem(BreastRadiologyDocument doc, Extension item)                                                          // BuildMemberBase.cs:123
	                {                                                                                                                          // BuildMemberBase.cs:124
	                    this.Value = (Quantity) item.Value;                                                                                    // BuildMemberExtensionSimple.cs:46
	                }                                                                                                                          // BuildMemberBase.cs:127
	            }                                                                                                                              // BuildMemberBase.cs:130
	            #endregion                                                                                                                     // BuildMemberBase.cs:131
	                                                                                                                                           // BuildMemberBase.cs:182
	            // Properties                                                                                                                  // BuildMemberBase.cs:183
	            public const String ExtensionUrl = "distanceFromLandMark";                                                                     // BuildMemberExtensionSimple.cs:39
	            #region Common Properties (Singleton)                                                                                          // BuildMemberBase.cs:207
	                                                                                                                                           // BuildMemberBase.cs:209
	            // BuildMemberBase.cs:210
	            /// <summary>
	            /// Get All Items
	            /// </summary>
	            IEnumerable<Item> GetAllItems()                                                                                                // BuildMemberBase.cs:213
	            {                                                                                                                              // BuildMemberBase.cs:214
	                if (this.item != null) yield return this.item;                                                                             // BuildMemberBase.cs:215
	            }                                                                                                                              // BuildMemberBase.cs:216
	                                                                                                                                           // BuildMemberBase.cs:218
	            // BuildMemberBase.cs:219
	            /// <summary>
	            /// Set All Items
	            /// </summary>
	            void SetAllItems(IEnumerable<Item> items)                                                                                      // BuildMemberBase.cs:222
	            {                                                                                                                              // BuildMemberBase.cs:223
	                switch (items.Count())                                                                                                     // BuildMemberBase.cs:224
	                {                                                                                                                          // BuildMemberBase.cs:225
	                    case 0: break;                                                                                                         // BuildMemberBase.cs:226
	                    case 1: this.item = items.First(); break;                                                                              // BuildMemberBase.cs:227
	                    default: throw new Exception("Found multiple elements while reading single item");                                     // BuildMemberBase.cs:228
	                }                                                                                                                          // BuildMemberBase.cs:229
	            }                                                                                                                              // BuildMemberBase.cs:230
	                                                                                                                                           // BuildMemberBase.cs:232
	            // BuildMemberBase.cs:233
	            /// <summary>
	            /// Item
	            /// </summary>
	            Item item;                                                                                                                     // BuildMemberBase.cs:236
	                                                                                                                                           // BuildMemberBase.cs:238
	            // BuildMemberBase.cs:239
	            /// <summary>
	            /// Count property
	            /// </summary>
	            public override Int32 Count => this.item == null ? 0 : 1;                                                                      // BuildMemberBase.cs:242
	                                                                                                                                           // BuildMemberBase.cs:244
	            // BuildMemberBase.cs:245
	            /// <summary>
	            /// Get Item's Value
	            /// </summary>
	            public Quantity Get()                                                                                                          // BuildMemberBase.cs:248
	            {                                                                                                                              // BuildMemberBase.cs:249
	                if (item == null)                                                                                                          // BuildMemberBase.cs:250
	                    return null;                                                                                                           // BuildMemberBase.cs:251
	                return item.Value;                                                                                                         // BuildMemberBase.cs:252
	            }                                                                                                                              // BuildMemberBase.cs:253
	                                                                                                                                           // BuildMemberBase.cs:259
	            // BuildMemberBase.cs:260
	            /// <summary>
	            /// Set Item's Value
	            /// </summary>
	            public Quantity Set(Quantity value)                                                                                            // BuildMemberBase.cs:263
	            {                                                                                                                              // BuildMemberBase.cs:264
	                Item item = new Item();                                                                                                    // BuildMemberBase.cs:265
	                item.Value = value;                                                                                                        // BuildMemberBase.cs:266
	                this.item = item;                                                                                                          // BuildMemberBase.cs:267
	                return value;                                                                                                              // BuildMemberBase.cs:268
	            }                                                                                                                              // BuildMemberBase.cs:269
	            #endregion                                                                                                                     // BuildMemberBase.cs:348
	                                                                                                                                           // BuildMemberBase.cs:186
	            // BuildMemberBase.cs:187
	            /// <summary>
	            /// Constructor
	            /// </summary>
	            public MDistanceFromLandMark(Int32 min, Int32 max) : base("Extension.extension:distanceFromLandMark", min, max)                // BuildMemberBase.cs:190
	            {                                                                                                                              // BuildMemberBase.cs:191
	            }                                                                                                                              // BuildMemberBase.cs:193
	                                                                                                                                           // BuildMemberBase.cs:195
	            // Methods                                                                                                                     // BuildMemberBase.cs:196
	                                                                                                                                           // BuildMemberBase.cs:352
	            // BuildMemberBase.cs:353
	            /// <summary>
	            /// Write container items.
	            /// </summary>
	            public IEnumerable<Extension> Write(BreastRadiologyDocument doc)                                                               // BuildMemberExtensionSimple.cs:90
	            {                                                                                                                              // BuildMemberExtensionSimple.cs:91
	                foreach (Item item in this.GetAllItems())                                                                                  // BuildMemberExtensionSimple.cs:92
	                    yield return item.WriteItem(doc);                                                                                      // BuildMemberExtensionSimple.cs:93
	            }                                                                                                                              // BuildMemberExtensionSimple.cs:94
	                                                                                                                                           // BuildMemberBase.cs:358
	            // BuildMemberBase.cs:359
	            /// <summary>
	            /// Read container items.
	            /// </summary>
	                                                                                                                                           // BuildMemberExtensionSimple.cs:64
	            public void Read(BreastRadiologyDocument doc, IEnumerable<Extension> extensions)                                               // BuildMemberExtensionSimple.cs:65
	            {                                                                                                                              // BuildMemberExtensionSimple.cs:66
	                List<Extension> memberExtensions = extensions                                                                              // BuildMemberExtensionSimple.cs:67
	                    .Where((a) => String.Compare(a.Url, ExtensionUrl, true) == 0)                                                          // BuildMemberExtensionSimple.cs:68
	                    .ToList()                                                                                                              // BuildMemberExtensionSimple.cs:69
	                    ;                                                                                                                      // BuildMemberExtensionSimple.cs:70
	                List<Item> items = new List<Item>();                                                                                       // BuildMemberExtensionSimple.cs:71
	                foreach (Extension memberExtension in memberExtensions)                                                                    // BuildMemberExtensionSimple.cs:72
	                {                                                                                                                          // BuildMemberExtensionSimple.cs:73
	                        Item item = new Item();                                                                                            // BuildMemberExtensionSimple.cs:74
	                        item.ReadItem(doc, memberExtension);                                                                               // BuildMemberExtensionSimple.cs:75
	                        items.Add(item);                                                                                                   // BuildMemberExtensionSimple.cs:76
	                }                                                                                                                          // BuildMemberExtensionSimple.cs:77
	                this.SetAllItems(items);                                                                                                   // BuildMemberExtensionSimple.cs:78
	            }                                                                                                                              // BuildMemberExtensionSimple.cs:79
	        }                                                                                                                                  // BuildMemberBase.cs:198
	        #endregion                                                                                                                         // BuildMemberBase.cs:199
	        // Properties                                                                                                                      // BuildMemberExtensionComplex.cs:109
	                                                                                                                                           // BuildMemberBase.cs:393
	        // Called from BuildMemberExtensionSimple.cs, Line 113
	        // BuildMemberBase.cs:395
	        /// <summary>
	        /// LandMark
	        /// Access fhir element 'Extension.extension:landMark'
	        /// </summary>
	        public MLandMark LandMark { get ; protected set; }                                                                                 // BuildMemberBase.cs:399
	                                                                                                                                           // BuildMemberBase.cs:393
	        // Called from BuildMemberExtensionSimple.cs, Line 113
	        // BuildMemberBase.cs:395
	        /// <summary>
	        /// DistanceFromLandMark
	        /// Access fhir element 'Extension.extension:distanceFromLandMark'
	        /// </summary>
	        public MDistanceFromLandMark DistanceFromLandMark { get ; protected set; }                                                         // BuildMemberBase.cs:399
	                                                                                                                                           // BuildMemberExtensionComplex.cs:111
	        // BuildMemberExtensionComplex.cs:112
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Members()                                                                                                                   // BuildMemberExtensionComplex.cs:115
	        {                                                                                                                                  // BuildMemberExtensionComplex.cs:116
	            // Called from BuildMemberExtensionSimple.cs, Line 113
	            this.LandMark = new MLandMark(1, 1);                                                                                           // BuildMemberBase.cs:378
	            // Called from BuildMemberExtensionSimple.cs, Line 113
	            this.DistanceFromLandMark = new MDistanceFromLandMark(1, 1);                                                                   // BuildMemberBase.cs:378
	        }                                                                                                                                  // BuildMemberExtensionComplex.cs:118
	                                                                                                                                           // BuildMemberExtensionComplex.cs:120
	        // Methods                                                                                                                         // BuildMemberExtensionComplex.cs:121
	                                                                                                                                           // BuildMemberExtensionComplex.cs:124
	        // BuildMemberExtensionComplex.cs:125
	        /// <summary>
	        /// Write item as a fhir element.
	        /// </summary>
	        public Extension WriteMember(BreastRadiologyDocument doc)                                                                          // BuildMemberExtensionComplex.cs:128
	        {                                                                                                                                  // BuildMemberExtensionComplex.cs:129
	            List<Extension> extensionList = new List<Extension>();                                                                         // BuildMemberExtensionComplex.cs:130
	            extensionList.AddRange(this.LandMark.Write(doc));                                                                              // BuildMemberExtensionSimple.cs:98
	            extensionList.AddRange(this.DistanceFromLandMark.Write(doc));                                                                  // BuildMemberExtensionSimple.cs:98
	            return new Extension                                                                                                           // BuildMemberExtensionComplex.cs:132
	            {                                                                                                                              // BuildMemberExtensionComplex.cs:133
	                Url = ExtensionUrl,                                                                                                        // BuildMemberExtensionComplex.cs:134
	                Extension = extensionList                                                                                                  // BuildMemberExtensionComplex.cs:135
	            };                                                                                                                             // BuildMemberExtensionComplex.cs:136
	        }                                                                                                                                  // BuildMemberExtensionComplex.cs:137
	                                                                                                                                           // BuildMemberExtensionComplex.cs:139
	        // BuildMemberExtensionComplex.cs:140
	        /// <summary>
	        /// Read from fhir element into member item.
	        /// </summary>
	        public void ReadMember(BreastRadiologyDocument doc, Extension extension)                                                           // BuildMemberExtensionComplex.cs:143
	        {                                                                                                                                  // BuildMemberExtensionComplex.cs:144
	            if (extension.Url != ExtensionUrl)                                                                                             // BuildMemberExtensionComplex.cs:145
	                throw new Exception($"Invalid extension url '{extension.Url}', expected '{ExtensionUrl}'");                                // BuildMemberExtensionComplex.cs:146
	            List<Extension> extensionList = extension.Extension;                                                                           // BuildMemberExtensionComplex.cs:147
	            this.LandMark.Read(doc, extensionList);                                                                                        // BuildMemberExtensionSimple.cs:83
	            this.DistanceFromLandMark.Read(doc, extensionList);                                                                            // BuildMemberExtensionSimple.cs:83
	        }                                                                                                                                  // BuildMemberExtensionComplex.cs:149
	    }                                                                                                                                      // BuildMemberExtensionComplex.cs:151
	    #endregion                                                                                                                             // BuildMemberExtensionComplex.cs:152
	                                                                                                                                           // BuildMemberBase.cs:182
	    // Properties                                                                                                                          // BuildMemberBase.cs:183
	    public const String ExtensionUrl = "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/BodyDistanceFromExtension";            // BuildMemberExtensionComplex.cs:36
	    #region Common Properties (Non-Singleton)                                                                                              // BuildMemberBase.cs:276
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:277
	                                                                                                                                           // BuildMemberBase.cs:279
	    // BuildMemberBase.cs:280
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:283
	                                                                                                                                           // BuildMemberBase.cs:285
	    // BuildMemberBase.cs:286
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:289
	                                                                                                                                           // BuildMemberBase.cs:291
	    // BuildMemberBase.cs:292
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:295
	                                                                                                                                           // BuildMemberBase.cs:297
	    // BuildMemberBase.cs:298
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<Members> All()                                                                                                      // BuildMemberBase.cs:301
	    {                                                                                                                                      // BuildMemberBase.cs:302
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:303
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:304
	    }                                                                                                                                      // BuildMemberBase.cs:305
	                                                                                                                                           // BuildMemberBase.cs:307
	    // BuildMemberBase.cs:308
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public Members GetAt(Int32 i) => this.items[i].Value;                                                                                  // BuildMemberBase.cs:311
	                                                                                                                                           // BuildMemberBase.cs:313
	    // BuildMemberBase.cs:314
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:317
	                                                                                                                                           // BuildMemberBase.cs:319
	    // BuildMemberBase.cs:320
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:323
	    #endregion                                                                                                                             // BuildMemberBase.cs:348
	                                                                                                                                           // BuildMemberBase.cs:186
	    // BuildMemberBase.cs:187
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public MBodyDistanceFromExtension(Int32 min, Int32 max) : base("BodyDistanceFromExtension", min, max)                                  // BuildMemberBase.cs:190
	    {                                                                                                                                      // BuildMemberBase.cs:191
	    }                                                                                                                                      // BuildMemberBase.cs:193
	                                                                                                                                           // BuildMemberBase.cs:195
	    // Methods                                                                                                                             // BuildMemberBase.cs:196
	                                                                                                                                           // BuildMemberBase.cs:332
	    // BuildMemberBase.cs:333
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public Members Append(Members value)                                                                                                   // BuildMemberBase.cs:336
	    {                                                                                                                                      // BuildMemberBase.cs:337
	        Item item = new Item();                                                                                                            // BuildMemberBase.cs:338
	        item.Value = value;                                                                                                                // BuildMemberBase.cs:339
	        this.items.Add(item);                                                                                                              // BuildMemberBase.cs:340
	        return value;                                                                                                                      // BuildMemberBase.cs:341
	    }                                                                                                                                      // BuildMemberBase.cs:342
	                                                                                                                                           // BuildMemberBase.cs:352
	    // BuildMemberBase.cs:353
	    /// <summary>
	    /// Write container items.
	    /// </summary>
	    public IEnumerable<Extension> Write(BreastRadiologyDocument doc)                                                                       // BuildMemberExtensionComplex.cs:84
	    {                                                                                                                                      // BuildMemberExtensionComplex.cs:85
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberExtensionComplex.cs:86
	            yield return item.WriteItem(doc);                                                                                              // BuildMemberExtensionComplex.cs:87
	    }                                                                                                                                      // BuildMemberExtensionComplex.cs:88
	                                                                                                                                           // BuildMemberBase.cs:358
	    // BuildMemberBase.cs:359
	    /// <summary>
	    /// Read container items.
	    /// </summary>
	                                                                                                                                           // BuildMemberExtensionComplex.cs:58
	    public void Read(BreastRadiologyDocument doc, IEnumerable<Extension> extensions)                                                       // BuildMemberExtensionComplex.cs:59
	    {                                                                                                                                      // BuildMemberExtensionComplex.cs:60
	        IEnumerable<Extension> memberExtensions = base.IsMember(doc,                                                                       // BuildMemberExtensionComplex.cs:62
	            extensions,                                                                                                                    // BuildMemberExtensionComplex.cs:63
	            ExtensionUrl);                                                                                                                 // BuildMemberExtensionComplex.cs:64
	        List<Item> items = new List<Item>();                                                                                               // BuildMemberExtensionComplex.cs:65
	        foreach (Extension memberExtension in memberExtensions)                                                                            // BuildMemberExtensionComplex.cs:66
	        {                                                                                                                                  // BuildMemberExtensionComplex.cs:67
	                Item item = new Item();                                                                                                    // BuildMemberExtensionComplex.cs:68
	                item.ReadItem(doc, memberExtension);                                                                                       // BuildMemberExtensionComplex.cs:69
	                items.Add(item);                                                                                                           // BuildMemberExtensionComplex.cs:70
	        }                                                                                                                                  // BuildMemberExtensionComplex.cs:71
	        this.SetAllItems(items);                                                                                                           // BuildMemberExtensionComplex.cs:72
	    }                                                                                                                                      // BuildMemberExtensionComplex.cs:73
	}                                                                                                                                          // BuildMemberBase.cs:198
	#endregion                                                                                                                                 // BuildMemberBase.cs:199
	//- LocalClassDefs
}
