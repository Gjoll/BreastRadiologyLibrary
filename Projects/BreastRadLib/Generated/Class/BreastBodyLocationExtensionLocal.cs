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
using BreastRadLib.BodyDistanceFromExtensionLocal;
//-Usings

namespace BreastRadLib.BreastBodyLocationExtensionLocal
{
	//+ LocalClassDefs
	#region BreastBodyLocationExtension Container Class                                                                                        // BuildMemberBase.cs:174
	// Called from BuildMemberExtensionComplex.cs, Line 180
	// BuildMemberBase.cs:176
	/// <summary>
	/// Container class for BreastBodyLocationExtension.
	/// </summary>
	public class MBreastBodyLocationExtension : MContainer, ITMItem<Extension>                                                                 // BuildMemberBase.cs:179
	{                                                                                                                                          // BuildMemberBase.cs:180
	    #region BreastBodyLocationExtension Item Class                                                                                         // BuildMemberBase.cs:81
	    // Called from BuildMemberExtensionComplex.cs, Line 180
	    // BuildMemberBase.cs:83
	    /// <summary>
	    /// Item class for BreastBodyLocationExtension.
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
	    #region BreastBodyLocationExtension Member Class                                                                                       // BuildMemberExtensionComplex.cs:101
	    // BuildMemberExtensionComplex.cs:102
	    /// <summary>
	    /// Extension class for BreastBodyLocationExtension.
	    /// </summary>
	    public class Members                                                                                                                   // BuildMemberExtensionComplex.cs:105
	    {                                                                                                                                      // BuildMemberExtensionComplex.cs:106
	        // Definitions                                                                                                                     // BuildMemberExtensionComplex.cs:107
	        #region Extension.extension:laterality Container Class                                                                             // BuildMemberBase.cs:174
	        // Called from BuildMemberExtensionSimple.cs, Line 113
	        // BuildMemberBase.cs:176
	        /// <summary>
	        /// Container class for Extension.extension:laterality.
	        /// </summary>
	        public class MLaterality : MContainer, ITMItem<Extension>                                                                          // BuildMemberBase.cs:179
	        {                                                                                                                                  // BuildMemberBase.cs:180
	            #region Extension.extension:laterality Item Class                                                                              // BuildMemberBase.cs:81
	            // Called from BuildMemberExtensionSimple.cs, Line 113
	            // BuildMemberBase.cs:83
	            /// <summary>
	            /// Item class for Extension.extension:laterality.
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
	                                                                                                                                           // BuildMemberBase.cs:183
	            // Properties                                                                                                                  // BuildMemberBase.cs:184
	            public const String ExtensionUrl = "laterality";                                                                               // BuildMemberExtensionSimple.cs:39
	            #region Common Properties (Singleton)                                                                                          // BuildMemberBase.cs:208
	                                                                                                                                           // BuildMemberBase.cs:210
	            // BuildMemberBase.cs:211
	            /// <summary>
	            /// Get All Items
	            /// </summary>
	            IEnumerable<Item> GetAllItems()                                                                                                // BuildMemberBase.cs:214
	            {                                                                                                                              // BuildMemberBase.cs:215
	                if (this.item != null) yield return this.item;                                                                             // BuildMemberBase.cs:216
	            }                                                                                                                              // BuildMemberBase.cs:217
	                                                                                                                                           // BuildMemberBase.cs:219
	            // BuildMemberBase.cs:220
	            /// <summary>
	            /// Set All Items
	            /// </summary>
	            void SetAllItems(IEnumerable<Item> items)                                                                                      // BuildMemberBase.cs:223
	            {                                                                                                                              // BuildMemberBase.cs:224
	                switch (items.Count())                                                                                                     // BuildMemberBase.cs:225
	                {                                                                                                                          // BuildMemberBase.cs:226
	                    case 0: break;                                                                                                         // BuildMemberBase.cs:227
	                    case 1: this.item = items.First(); break;                                                                              // BuildMemberBase.cs:228
	                    default: throw new Exception("Found multiple elements while reading single item");                                     // BuildMemberBase.cs:229
	                }                                                                                                                          // BuildMemberBase.cs:230
	            }                                                                                                                              // BuildMemberBase.cs:231
	                                                                                                                                           // BuildMemberBase.cs:233
	            // BuildMemberBase.cs:234
	            /// <summary>
	            /// Item
	            /// </summary>
	            Item item;                                                                                                                     // BuildMemberBase.cs:237
	                                                                                                                                           // BuildMemberBase.cs:239
	            // BuildMemberBase.cs:240
	            /// <summary>
	            /// Count property
	            /// </summary>
	            public override Int32 Count => this.item == null ? 0 : 1;                                                                      // BuildMemberBase.cs:243
	                                                                                                                                           // BuildMemberBase.cs:245
	            // BuildMemberBase.cs:246
	            /// <summary>
	            /// Get Item's Value
	            /// </summary>
	            public CodeableConcept Get()                                                                                                   // BuildMemberBase.cs:249
	            {                                                                                                                              // BuildMemberBase.cs:250
	                if (item == null)                                                                                                          // BuildMemberBase.cs:251
	                    return null;                                                                                                           // BuildMemberBase.cs:252
	                return item.Value;                                                                                                         // BuildMemberBase.cs:253
	            }                                                                                                                              // BuildMemberBase.cs:254
	                                                                                                                                           // BuildMemberBase.cs:260
	            // BuildMemberBase.cs:261
	            /// <summary>
	            /// Set Item's Value
	            /// </summary>
	            public CodeableConcept Set(CodeableConcept value)                                                                              // BuildMemberBase.cs:264
	            {                                                                                                                              // BuildMemberBase.cs:265
	                Item item = new Item();                                                                                                    // BuildMemberBase.cs:266
	                item.Value = value;                                                                                                        // BuildMemberBase.cs:267
	                this.item = item;                                                                                                          // BuildMemberBase.cs:268
	                return value;                                                                                                              // BuildMemberBase.cs:269
	            }                                                                                                                              // BuildMemberBase.cs:270
	            #endregion                                                                                                                     // BuildMemberBase.cs:349
	                                                                                                                                           // BuildMemberBase.cs:187
	            // BuildMemberBase.cs:188
	            /// <summary>
	            /// Constructor
	            /// </summary>
	            public MLaterality(Int32 min = 0, Int32 max = 1) : base("Extension.extension:laterality", min, max)                            // BuildMemberBase.cs:191
	            {                                                                                                                              // BuildMemberBase.cs:192
	            }                                                                                                                              // BuildMemberBase.cs:194
	                                                                                                                                           // BuildMemberBase.cs:196
	            // Methods                                                                                                                     // BuildMemberBase.cs:197
	                                                                                                                                           // BuildMemberBase.cs:353
	            // BuildMemberBase.cs:354
	            /// <summary>
	            /// Write container items.
	            /// </summary>
	            public IEnumerable<Extension> Write(BreastRadiologyDocument doc)                                                               // BuildMemberExtensionSimple.cs:90
	            {                                                                                                                              // BuildMemberExtensionSimple.cs:91
	                foreach (Item item in this.GetAllItems())                                                                                  // BuildMemberExtensionSimple.cs:92
	                    yield return item.WriteItem(doc);                                                                                      // BuildMemberExtensionSimple.cs:93
	            }                                                                                                                              // BuildMemberExtensionSimple.cs:94
	                                                                                                                                           // BuildMemberBase.cs:359
	            // BuildMemberBase.cs:360
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
	        }                                                                                                                                  // BuildMemberBase.cs:199
	        #endregion                                                                                                                         // BuildMemberBase.cs:200
	        #region Extension.extension:quadrant Container Class                                                                               // BuildMemberBase.cs:174
	        // Called from BuildMemberExtensionSimple.cs, Line 113
	        // BuildMemberBase.cs:176
	        /// <summary>
	        /// Container class for Extension.extension:quadrant.
	        /// </summary>
	        public class MQuadrant : MContainer, ITMItem<Extension>                                                                            // BuildMemberBase.cs:179
	        {                                                                                                                                  // BuildMemberBase.cs:180
	            #region Extension.extension:quadrant Item Class                                                                                // BuildMemberBase.cs:81
	            // Called from BuildMemberExtensionSimple.cs, Line 113
	            // BuildMemberBase.cs:83
	            /// <summary>
	            /// Item class for Extension.extension:quadrant.
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
	                                                                                                                                           // BuildMemberBase.cs:183
	            // Properties                                                                                                                  // BuildMemberBase.cs:184
	            public const String ExtensionUrl = "quadrant";                                                                                 // BuildMemberExtensionSimple.cs:39
	            #region Common Properties (Singleton)                                                                                          // BuildMemberBase.cs:208
	                                                                                                                                           // BuildMemberBase.cs:210
	            // BuildMemberBase.cs:211
	            /// <summary>
	            /// Get All Items
	            /// </summary>
	            IEnumerable<Item> GetAllItems()                                                                                                // BuildMemberBase.cs:214
	            {                                                                                                                              // BuildMemberBase.cs:215
	                if (this.item != null) yield return this.item;                                                                             // BuildMemberBase.cs:216
	            }                                                                                                                              // BuildMemberBase.cs:217
	                                                                                                                                           // BuildMemberBase.cs:219
	            // BuildMemberBase.cs:220
	            /// <summary>
	            /// Set All Items
	            /// </summary>
	            void SetAllItems(IEnumerable<Item> items)                                                                                      // BuildMemberBase.cs:223
	            {                                                                                                                              // BuildMemberBase.cs:224
	                switch (items.Count())                                                                                                     // BuildMemberBase.cs:225
	                {                                                                                                                          // BuildMemberBase.cs:226
	                    case 0: break;                                                                                                         // BuildMemberBase.cs:227
	                    case 1: this.item = items.First(); break;                                                                              // BuildMemberBase.cs:228
	                    default: throw new Exception("Found multiple elements while reading single item");                                     // BuildMemberBase.cs:229
	                }                                                                                                                          // BuildMemberBase.cs:230
	            }                                                                                                                              // BuildMemberBase.cs:231
	                                                                                                                                           // BuildMemberBase.cs:233
	            // BuildMemberBase.cs:234
	            /// <summary>
	            /// Item
	            /// </summary>
	            Item item;                                                                                                                     // BuildMemberBase.cs:237
	                                                                                                                                           // BuildMemberBase.cs:239
	            // BuildMemberBase.cs:240
	            /// <summary>
	            /// Count property
	            /// </summary>
	            public override Int32 Count => this.item == null ? 0 : 1;                                                                      // BuildMemberBase.cs:243
	                                                                                                                                           // BuildMemberBase.cs:245
	            // BuildMemberBase.cs:246
	            /// <summary>
	            /// Get Item's Value
	            /// </summary>
	            public CodeableConcept Get()                                                                                                   // BuildMemberBase.cs:249
	            {                                                                                                                              // BuildMemberBase.cs:250
	                if (item == null)                                                                                                          // BuildMemberBase.cs:251
	                    return null;                                                                                                           // BuildMemberBase.cs:252
	                return item.Value;                                                                                                         // BuildMemberBase.cs:253
	            }                                                                                                                              // BuildMemberBase.cs:254
	                                                                                                                                           // BuildMemberBase.cs:260
	            // BuildMemberBase.cs:261
	            /// <summary>
	            /// Set Item's Value
	            /// </summary>
	            public CodeableConcept Set(CodeableConcept value)                                                                              // BuildMemberBase.cs:264
	            {                                                                                                                              // BuildMemberBase.cs:265
	                Item item = new Item();                                                                                                    // BuildMemberBase.cs:266
	                item.Value = value;                                                                                                        // BuildMemberBase.cs:267
	                this.item = item;                                                                                                          // BuildMemberBase.cs:268
	                return value;                                                                                                              // BuildMemberBase.cs:269
	            }                                                                                                                              // BuildMemberBase.cs:270
	            #endregion                                                                                                                     // BuildMemberBase.cs:349
	                                                                                                                                           // BuildMemberBase.cs:187
	            // BuildMemberBase.cs:188
	            /// <summary>
	            /// Constructor
	            /// </summary>
	            public MQuadrant(Int32 min = 0, Int32 max = 1) : base("Extension.extension:quadrant", min, max)                                // BuildMemberBase.cs:191
	            {                                                                                                                              // BuildMemberBase.cs:192
	            }                                                                                                                              // BuildMemberBase.cs:194
	                                                                                                                                           // BuildMemberBase.cs:196
	            // Methods                                                                                                                     // BuildMemberBase.cs:197
	                                                                                                                                           // BuildMemberBase.cs:353
	            // BuildMemberBase.cs:354
	            /// <summary>
	            /// Write container items.
	            /// </summary>
	            public IEnumerable<Extension> Write(BreastRadiologyDocument doc)                                                               // BuildMemberExtensionSimple.cs:90
	            {                                                                                                                              // BuildMemberExtensionSimple.cs:91
	                foreach (Item item in this.GetAllItems())                                                                                  // BuildMemberExtensionSimple.cs:92
	                    yield return item.WriteItem(doc);                                                                                      // BuildMemberExtensionSimple.cs:93
	            }                                                                                                                              // BuildMemberExtensionSimple.cs:94
	                                                                                                                                           // BuildMemberBase.cs:359
	            // BuildMemberBase.cs:360
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
	        }                                                                                                                                  // BuildMemberBase.cs:199
	        #endregion                                                                                                                         // BuildMemberBase.cs:200
	        #region Extension.extension:region Container Class                                                                                 // BuildMemberBase.cs:174
	        // Called from BuildMemberExtensionSimple.cs, Line 113
	        // BuildMemberBase.cs:176
	        /// <summary>
	        /// Container class for Extension.extension:region.
	        /// </summary>
	        public class MRegion : MContainer, ITMItem<Extension>                                                                              // BuildMemberBase.cs:179
	        {                                                                                                                                  // BuildMemberBase.cs:180
	            #region Extension.extension:region Item Class                                                                                  // BuildMemberBase.cs:81
	            // Called from BuildMemberExtensionSimple.cs, Line 113
	            // BuildMemberBase.cs:83
	            /// <summary>
	            /// Item class for Extension.extension:region.
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
	                                                                                                                                           // BuildMemberBase.cs:183
	            // Properties                                                                                                                  // BuildMemberBase.cs:184
	            public const String ExtensionUrl = "region";                                                                                   // BuildMemberExtensionSimple.cs:39
	            #region Common Properties (Non-Singleton)                                                                                      // BuildMemberBase.cs:277
	            List<Item> items = new List<Item>();                                                                                           // BuildMemberBase.cs:278
	                                                                                                                                           // BuildMemberBase.cs:280
	            // BuildMemberBase.cs:281
	            /// <summary>
	            /// Get All Items
	            /// </summary>
	            IEnumerable<Item> GetAllItems() => this.items;                                                                                 // BuildMemberBase.cs:284
	                                                                                                                                           // BuildMemberBase.cs:286
	            // BuildMemberBase.cs:287
	            /// <summary>
	            /// Set All Items
	            /// </summary>
	            void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                      // BuildMemberBase.cs:290
	                                                                                                                                           // BuildMemberBase.cs:292
	            // BuildMemberBase.cs:293
	            /// <summary>
	            /// Count property
	            /// </summary>
	            public override Int32 Count => items.Count;                                                                                    // BuildMemberBase.cs:296
	                                                                                                                                           // BuildMemberBase.cs:298
	            // BuildMemberBase.cs:299
	            /// <summary>
	            /// Return all items
	            /// </summary>
	            public IEnumerable<CodeableConcept> All()                                                                                      // BuildMemberBase.cs:302
	            {                                                                                                                              // BuildMemberBase.cs:303
	                foreach (Item item in items)                                                                                               // BuildMemberBase.cs:304
	                   yield return item.Value;                                                                                                // BuildMemberBase.cs:305
	            }                                                                                                                              // BuildMemberBase.cs:306
	                                                                                                                                           // BuildMemberBase.cs:308
	            // BuildMemberBase.cs:309
	            /// <summary>
	            /// Get Item's Value at indicated index
	            /// </summary>
	            public CodeableConcept GetAt(Int32 i) => this.items[i].Value;                                                                  // BuildMemberBase.cs:312
	                                                                                                                                           // BuildMemberBase.cs:314
	            // BuildMemberBase.cs:315
	            /// <summary>
	            /// Remove Item at indicated index
	            /// </summary>
	            public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                       // BuildMemberBase.cs:318
	                                                                                                                                           // BuildMemberBase.cs:320
	            // BuildMemberBase.cs:321
	            /// <summary>
	            /// Clear all items from collection
	            /// </summary>
	            public void Clear() => this.items.Clear();                                                                                     // BuildMemberBase.cs:324
	            #endregion                                                                                                                     // BuildMemberBase.cs:349
	                                                                                                                                           // BuildMemberBase.cs:187
	            // BuildMemberBase.cs:188
	            /// <summary>
	            /// Constructor
	            /// </summary>
	            public MRegion(Int32 min = 0, Int32 max = -1) : base("Extension.extension:region", min, max)                                   // BuildMemberBase.cs:191
	            {                                                                                                                              // BuildMemberBase.cs:192
	            }                                                                                                                              // BuildMemberBase.cs:194
	                                                                                                                                           // BuildMemberBase.cs:196
	            // Methods                                                                                                                     // BuildMemberBase.cs:197
	                                                                                                                                           // BuildMemberBase.cs:333
	            // BuildMemberBase.cs:334
	            /// <summary>
	            /// Append value to collection
	            /// </summary>
	            public CodeableConcept Append(CodeableConcept value)                                                                           // BuildMemberBase.cs:337
	            {                                                                                                                              // BuildMemberBase.cs:338
	                Item item = new Item();                                                                                                    // BuildMemberBase.cs:339
	                item.Value = value;                                                                                                        // BuildMemberBase.cs:340
	                this.items.Add(item);                                                                                                      // BuildMemberBase.cs:341
	                return value;                                                                                                              // BuildMemberBase.cs:342
	            }                                                                                                                              // BuildMemberBase.cs:343
	                                                                                                                                           // BuildMemberBase.cs:353
	            // BuildMemberBase.cs:354
	            /// <summary>
	            /// Write container items.
	            /// </summary>
	            public IEnumerable<Extension> Write(BreastRadiologyDocument doc)                                                               // BuildMemberExtensionSimple.cs:90
	            {                                                                                                                              // BuildMemberExtensionSimple.cs:91
	                foreach (Item item in this.GetAllItems())                                                                                  // BuildMemberExtensionSimple.cs:92
	                    yield return item.WriteItem(doc);                                                                                      // BuildMemberExtensionSimple.cs:93
	            }                                                                                                                              // BuildMemberExtensionSimple.cs:94
	                                                                                                                                           // BuildMemberBase.cs:359
	            // BuildMemberBase.cs:360
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
	        }                                                                                                                                  // BuildMemberBase.cs:199
	        #endregion                                                                                                                         // BuildMemberBase.cs:200
	        #region Extension.extension:clockDirection Container Class                                                                         // BuildMemberBase.cs:174
	        // Called from BuildMemberExtensionSimple.cs, Line 113
	        // BuildMemberBase.cs:176
	        /// <summary>
	        /// Container class for Extension.extension:clockDirection.
	        /// </summary>
	        public class MClockDirection : MContainer, ITMItem<Extension>                                                                      // BuildMemberBase.cs:179
	        {                                                                                                                                  // BuildMemberBase.cs:180
	            #region Extension.extension:clockDirection Item Class                                                                          // BuildMemberBase.cs:81
	            // Called from BuildMemberExtensionSimple.cs, Line 113
	            // BuildMemberBase.cs:83
	            /// <summary>
	            /// Item class for Extension.extension:clockDirection.
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
	                                                                                                                                           // BuildMemberBase.cs:183
	            // Properties                                                                                                                  // BuildMemberBase.cs:184
	            public const String ExtensionUrl = "clockDirection";                                                                           // BuildMemberExtensionSimple.cs:39
	            #region Common Properties (Singleton)                                                                                          // BuildMemberBase.cs:208
	                                                                                                                                           // BuildMemberBase.cs:210
	            // BuildMemberBase.cs:211
	            /// <summary>
	            /// Get All Items
	            /// </summary>
	            IEnumerable<Item> GetAllItems()                                                                                                // BuildMemberBase.cs:214
	            {                                                                                                                              // BuildMemberBase.cs:215
	                if (this.item != null) yield return this.item;                                                                             // BuildMemberBase.cs:216
	            }                                                                                                                              // BuildMemberBase.cs:217
	                                                                                                                                           // BuildMemberBase.cs:219
	            // BuildMemberBase.cs:220
	            /// <summary>
	            /// Set All Items
	            /// </summary>
	            void SetAllItems(IEnumerable<Item> items)                                                                                      // BuildMemberBase.cs:223
	            {                                                                                                                              // BuildMemberBase.cs:224
	                switch (items.Count())                                                                                                     // BuildMemberBase.cs:225
	                {                                                                                                                          // BuildMemberBase.cs:226
	                    case 0: break;                                                                                                         // BuildMemberBase.cs:227
	                    case 1: this.item = items.First(); break;                                                                              // BuildMemberBase.cs:228
	                    default: throw new Exception("Found multiple elements while reading single item");                                     // BuildMemberBase.cs:229
	                }                                                                                                                          // BuildMemberBase.cs:230
	            }                                                                                                                              // BuildMemberBase.cs:231
	                                                                                                                                           // BuildMemberBase.cs:233
	            // BuildMemberBase.cs:234
	            /// <summary>
	            /// Item
	            /// </summary>
	            Item item;                                                                                                                     // BuildMemberBase.cs:237
	                                                                                                                                           // BuildMemberBase.cs:239
	            // BuildMemberBase.cs:240
	            /// <summary>
	            /// Count property
	            /// </summary>
	            public override Int32 Count => this.item == null ? 0 : 1;                                                                      // BuildMemberBase.cs:243
	                                                                                                                                           // BuildMemberBase.cs:245
	            // BuildMemberBase.cs:246
	            /// <summary>
	            /// Get Item's Value
	            /// </summary>
	            public CodeableConcept Get()                                                                                                   // BuildMemberBase.cs:249
	            {                                                                                                                              // BuildMemberBase.cs:250
	                if (item == null)                                                                                                          // BuildMemberBase.cs:251
	                    return null;                                                                                                           // BuildMemberBase.cs:252
	                return item.Value;                                                                                                         // BuildMemberBase.cs:253
	            }                                                                                                                              // BuildMemberBase.cs:254
	                                                                                                                                           // BuildMemberBase.cs:260
	            // BuildMemberBase.cs:261
	            /// <summary>
	            /// Set Item's Value
	            /// </summary>
	            public CodeableConcept Set(CodeableConcept value)                                                                              // BuildMemberBase.cs:264
	            {                                                                                                                              // BuildMemberBase.cs:265
	                Item item = new Item();                                                                                                    // BuildMemberBase.cs:266
	                item.Value = value;                                                                                                        // BuildMemberBase.cs:267
	                this.item = item;                                                                                                          // BuildMemberBase.cs:268
	                return value;                                                                                                              // BuildMemberBase.cs:269
	            }                                                                                                                              // BuildMemberBase.cs:270
	            #endregion                                                                                                                     // BuildMemberBase.cs:349
	                                                                                                                                           // BuildMemberBase.cs:187
	            // BuildMemberBase.cs:188
	            /// <summary>
	            /// Constructor
	            /// </summary>
	            public MClockDirection(Int32 min = 0, Int32 max = 1) : base("Extension.extension:clockDirection", min, max)                    // BuildMemberBase.cs:191
	            {                                                                                                                              // BuildMemberBase.cs:192
	            }                                                                                                                              // BuildMemberBase.cs:194
	                                                                                                                                           // BuildMemberBase.cs:196
	            // Methods                                                                                                                     // BuildMemberBase.cs:197
	                                                                                                                                           // BuildMemberBase.cs:353
	            // BuildMemberBase.cs:354
	            /// <summary>
	            /// Write container items.
	            /// </summary>
	            public IEnumerable<Extension> Write(BreastRadiologyDocument doc)                                                               // BuildMemberExtensionSimple.cs:90
	            {                                                                                                                              // BuildMemberExtensionSimple.cs:91
	                foreach (Item item in this.GetAllItems())                                                                                  // BuildMemberExtensionSimple.cs:92
	                    yield return item.WriteItem(doc);                                                                                      // BuildMemberExtensionSimple.cs:93
	            }                                                                                                                              // BuildMemberExtensionSimple.cs:94
	                                                                                                                                           // BuildMemberBase.cs:359
	            // BuildMemberBase.cs:360
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
	        }                                                                                                                                  // BuildMemberBase.cs:199
	        #endregion                                                                                                                         // BuildMemberBase.cs:200
	        #region Extension.extension:depth Container Class                                                                                  // BuildMemberBase.cs:174
	        // Called from BuildMemberExtensionSimple.cs, Line 113
	        // BuildMemberBase.cs:176
	        /// <summary>
	        /// Container class for Extension.extension:depth.
	        /// </summary>
	        public class MDepth : MContainer, ITMItem<Extension>                                                                               // BuildMemberBase.cs:179
	        {                                                                                                                                  // BuildMemberBase.cs:180
	            #region Extension.extension:depth Item Class                                                                                   // BuildMemberBase.cs:81
	            // Called from BuildMemberExtensionSimple.cs, Line 113
	            // BuildMemberBase.cs:83
	            /// <summary>
	            /// Item class for Extension.extension:depth.
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
	                                                                                                                                           // BuildMemberBase.cs:183
	            // Properties                                                                                                                  // BuildMemberBase.cs:184
	            public const String ExtensionUrl = "depth";                                                                                    // BuildMemberExtensionSimple.cs:39
	            #region Common Properties (Singleton)                                                                                          // BuildMemberBase.cs:208
	                                                                                                                                           // BuildMemberBase.cs:210
	            // BuildMemberBase.cs:211
	            /// <summary>
	            /// Get All Items
	            /// </summary>
	            IEnumerable<Item> GetAllItems()                                                                                                // BuildMemberBase.cs:214
	            {                                                                                                                              // BuildMemberBase.cs:215
	                if (this.item != null) yield return this.item;                                                                             // BuildMemberBase.cs:216
	            }                                                                                                                              // BuildMemberBase.cs:217
	                                                                                                                                           // BuildMemberBase.cs:219
	            // BuildMemberBase.cs:220
	            /// <summary>
	            /// Set All Items
	            /// </summary>
	            void SetAllItems(IEnumerable<Item> items)                                                                                      // BuildMemberBase.cs:223
	            {                                                                                                                              // BuildMemberBase.cs:224
	                switch (items.Count())                                                                                                     // BuildMemberBase.cs:225
	                {                                                                                                                          // BuildMemberBase.cs:226
	                    case 0: break;                                                                                                         // BuildMemberBase.cs:227
	                    case 1: this.item = items.First(); break;                                                                              // BuildMemberBase.cs:228
	                    default: throw new Exception("Found multiple elements while reading single item");                                     // BuildMemberBase.cs:229
	                }                                                                                                                          // BuildMemberBase.cs:230
	            }                                                                                                                              // BuildMemberBase.cs:231
	                                                                                                                                           // BuildMemberBase.cs:233
	            // BuildMemberBase.cs:234
	            /// <summary>
	            /// Item
	            /// </summary>
	            Item item;                                                                                                                     // BuildMemberBase.cs:237
	                                                                                                                                           // BuildMemberBase.cs:239
	            // BuildMemberBase.cs:240
	            /// <summary>
	            /// Count property
	            /// </summary>
	            public override Int32 Count => this.item == null ? 0 : 1;                                                                      // BuildMemberBase.cs:243
	                                                                                                                                           // BuildMemberBase.cs:245
	            // BuildMemberBase.cs:246
	            /// <summary>
	            /// Get Item's Value
	            /// </summary>
	            public CodeableConcept Get()                                                                                                   // BuildMemberBase.cs:249
	            {                                                                                                                              // BuildMemberBase.cs:250
	                if (item == null)                                                                                                          // BuildMemberBase.cs:251
	                    return null;                                                                                                           // BuildMemberBase.cs:252
	                return item.Value;                                                                                                         // BuildMemberBase.cs:253
	            }                                                                                                                              // BuildMemberBase.cs:254
	                                                                                                                                           // BuildMemberBase.cs:260
	            // BuildMemberBase.cs:261
	            /// <summary>
	            /// Set Item's Value
	            /// </summary>
	            public CodeableConcept Set(CodeableConcept value)                                                                              // BuildMemberBase.cs:264
	            {                                                                                                                              // BuildMemberBase.cs:265
	                Item item = new Item();                                                                                                    // BuildMemberBase.cs:266
	                item.Value = value;                                                                                                        // BuildMemberBase.cs:267
	                this.item = item;                                                                                                          // BuildMemberBase.cs:268
	                return value;                                                                                                              // BuildMemberBase.cs:269
	            }                                                                                                                              // BuildMemberBase.cs:270
	            #endregion                                                                                                                     // BuildMemberBase.cs:349
	                                                                                                                                           // BuildMemberBase.cs:187
	            // BuildMemberBase.cs:188
	            /// <summary>
	            /// Constructor
	            /// </summary>
	            public MDepth(Int32 min = 0, Int32 max = 1) : base("Extension.extension:depth", min, max)                                      // BuildMemberBase.cs:191
	            {                                                                                                                              // BuildMemberBase.cs:192
	            }                                                                                                                              // BuildMemberBase.cs:194
	                                                                                                                                           // BuildMemberBase.cs:196
	            // Methods                                                                                                                     // BuildMemberBase.cs:197
	                                                                                                                                           // BuildMemberBase.cs:353
	            // BuildMemberBase.cs:354
	            /// <summary>
	            /// Write container items.
	            /// </summary>
	            public IEnumerable<Extension> Write(BreastRadiologyDocument doc)                                                               // BuildMemberExtensionSimple.cs:90
	            {                                                                                                                              // BuildMemberExtensionSimple.cs:91
	                foreach (Item item in this.GetAllItems())                                                                                  // BuildMemberExtensionSimple.cs:92
	                    yield return item.WriteItem(doc);                                                                                      // BuildMemberExtensionSimple.cs:93
	            }                                                                                                                              // BuildMemberExtensionSimple.cs:94
	                                                                                                                                           // BuildMemberBase.cs:359
	            // BuildMemberBase.cs:360
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
	        }                                                                                                                                  // BuildMemberBase.cs:199
	        #endregion                                                                                                                         // BuildMemberBase.cs:200
	        // Properties                                                                                                                      // BuildMemberExtensionComplex.cs:109
	                                                                                                                                           // BuildMemberBase.cs:394
	        // Called from BuildMemberExtensionSimple.cs, Line 113
	        // BuildMemberBase.cs:396
	        /// <summary>
	        /// Laterality
	        /// Access fhir element 'Extension.extension:laterality'
	        /// </summary>
	        public MLaterality Laterality { get ; protected set; }                                                                             // BuildMemberBase.cs:400
	                                                                                                                                           // BuildMemberBase.cs:394
	        // Called from BuildMemberExtensionSimple.cs, Line 113
	        // BuildMemberBase.cs:396
	        /// <summary>
	        /// Quadrant
	        /// Access fhir element 'Extension.extension:quadrant'
	        /// </summary>
	        public MQuadrant Quadrant { get ; protected set; }                                                                                 // BuildMemberBase.cs:400
	                                                                                                                                           // BuildMemberBase.cs:394
	        // Called from BuildMemberExtensionSimple.cs, Line 113
	        // BuildMemberBase.cs:396
	        /// <summary>
	        /// Region
	        /// Access fhir element 'Extension.extension:region'
	        /// </summary>
	        public MRegion Region { get ; protected set; }                                                                                     // BuildMemberBase.cs:400
	                                                                                                                                           // BuildMemberBase.cs:394
	        // Called from BuildMemberExtensionSimple.cs, Line 113
	        // BuildMemberBase.cs:396
	        /// <summary>
	        /// ClockDirection
	        /// Access fhir element 'Extension.extension:clockDirection'
	        /// </summary>
	        public MClockDirection ClockDirection { get ; protected set; }                                                                     // BuildMemberBase.cs:400
	                                                                                                                                           // BuildMemberBase.cs:394
	        // Called from BuildMemberExtensionSimple.cs, Line 113
	        // BuildMemberBase.cs:396
	        /// <summary>
	        /// Depth
	        /// Access fhir element 'Extension.extension:depth'
	        /// </summary>
	        public MDepth Depth { get ; protected set; }                                                                                       // BuildMemberBase.cs:400
	        MBodyDistanceFromExtension DistanceFromLandmark;                                                                                   // BuildMemberExtension.cs:82
	                                                                                                                                           // BuildMemberExtensionComplex.cs:111
	        // BuildMemberExtensionComplex.cs:112
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Members()                                                                                                                   // BuildMemberExtensionComplex.cs:115
	        {                                                                                                                                  // BuildMemberExtensionComplex.cs:116
	            // Called from BuildMemberExtensionSimple.cs, Line 113
	            this.Laterality = new MLaterality(0, 1);                                                                                       // BuildMemberBase.cs:379
	            // Called from BuildMemberExtensionSimple.cs, Line 113
	            this.Quadrant = new MQuadrant(0, 1);                                                                                           // BuildMemberBase.cs:379
	            // Called from BuildMemberExtensionSimple.cs, Line 113
	            this.Region = new MRegion(0, -1);                                                                                              // BuildMemberBase.cs:379
	            // Called from BuildMemberExtensionSimple.cs, Line 113
	            this.ClockDirection = new MClockDirection(0, 1);                                                                               // BuildMemberBase.cs:379
	            // Called from BuildMemberExtensionSimple.cs, Line 113
	            this.Depth = new MDepth(0, 1);                                                                                                 // BuildMemberBase.cs:379
	            this.DistanceFromLandmark = new MBodyDistanceFromExtension(0, -1);                                                             // BuildMemberExtension.cs:88
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
	            extensionList.AddRange(this.Laterality.Write(doc));                                                                            // BuildMemberExtensionSimple.cs:98
	            extensionList.AddRange(this.Quadrant.Write(doc));                                                                              // BuildMemberExtensionSimple.cs:98
	            extensionList.AddRange(this.Region.Write(doc));                                                                                // BuildMemberExtensionSimple.cs:98
	            extensionList.AddRange(this.ClockDirection.Write(doc));                                                                        // BuildMemberExtensionSimple.cs:98
	            extensionList.AddRange(this.Depth.Write(doc));                                                                                 // BuildMemberExtensionSimple.cs:98
	            extensionList.AddRange(this.DistanceFromLandmark.Write(doc));                                                                  // BuildMemberExtension.cs:92
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
	            this.Laterality.Read(doc, extensionList);                                                                                      // BuildMemberExtensionSimple.cs:83
	            this.Quadrant.Read(doc, extensionList);                                                                                        // BuildMemberExtensionSimple.cs:83
	            this.Region.Read(doc, extensionList);                                                                                          // BuildMemberExtensionSimple.cs:83
	            this.ClockDirection.Read(doc, extensionList);                                                                                  // BuildMemberExtensionSimple.cs:83
	            this.Depth.Read(doc, extensionList);                                                                                           // BuildMemberExtensionSimple.cs:83
	            this.DistanceFromLandmark.Read(doc, extensionList);                                                                            // BuildMemberExtension.cs:96
	        }                                                                                                                                  // BuildMemberExtensionComplex.cs:149
	    }                                                                                                                                      // BuildMemberExtensionComplex.cs:151
	    #endregion                                                                                                                             // BuildMemberExtensionComplex.cs:152
	                                                                                                                                           // BuildMemberBase.cs:183
	    // Properties                                                                                                                          // BuildMemberBase.cs:184
	    public const String ExtensionUrl = "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/BreastBodyLocationExtension";          // BuildMemberExtensionComplex.cs:36
	    #region Common Properties (Non-Singleton)                                                                                              // BuildMemberBase.cs:277
	    List<Item> items = new List<Item>();                                                                                                   // BuildMemberBase.cs:278
	                                                                                                                                           // BuildMemberBase.cs:280
	    // BuildMemberBase.cs:281
	    /// <summary>
	    /// Get All Items
	    /// </summary>
	    IEnumerable<Item> GetAllItems() => this.items;                                                                                         // BuildMemberBase.cs:284
	                                                                                                                                           // BuildMemberBase.cs:286
	    // BuildMemberBase.cs:287
	    /// <summary>
	    /// Set All Items
	    /// </summary>
	    void SetAllItems(IEnumerable<Item> items) => this.items = items.ToList();                                                              // BuildMemberBase.cs:290
	                                                                                                                                           // BuildMemberBase.cs:292
	    // BuildMemberBase.cs:293
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:296
	                                                                                                                                           // BuildMemberBase.cs:298
	    // BuildMemberBase.cs:299
	    /// <summary>
	    /// Return all items
	    /// </summary>
	    public IEnumerable<Members> All()                                                                                                      // BuildMemberBase.cs:302
	    {                                                                                                                                      // BuildMemberBase.cs:303
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:304
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:305
	    }                                                                                                                                      // BuildMemberBase.cs:306
	                                                                                                                                           // BuildMemberBase.cs:308
	    // BuildMemberBase.cs:309
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public Members GetAt(Int32 i) => this.items[i].Value;                                                                                  // BuildMemberBase.cs:312
	                                                                                                                                           // BuildMemberBase.cs:314
	    // BuildMemberBase.cs:315
	    /// <summary>
	    /// Remove Item at indicated index
	    /// </summary>
	    public void RemoveAt(Int32 i) => this.items.RemoveAt(i);                                                                               // BuildMemberBase.cs:318
	                                                                                                                                           // BuildMemberBase.cs:320
	    // BuildMemberBase.cs:321
	    /// <summary>
	    /// Clear all items from collection
	    /// </summary>
	    public void Clear() => this.items.Clear();                                                                                             // BuildMemberBase.cs:324
	    #endregion                                                                                                                             // BuildMemberBase.cs:349
	                                                                                                                                           // BuildMemberBase.cs:187
	    // BuildMemberBase.cs:188
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public MBreastBodyLocationExtension(Int32 min = 0, Int32 max = -1) : base("BreastBodyLocationExtension", min, max)                     // BuildMemberBase.cs:191
	    {                                                                                                                                      // BuildMemberBase.cs:192
	    }                                                                                                                                      // BuildMemberBase.cs:194
	                                                                                                                                           // BuildMemberBase.cs:196
	    // Methods                                                                                                                             // BuildMemberBase.cs:197
	                                                                                                                                           // BuildMemberBase.cs:333
	    // BuildMemberBase.cs:334
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public Members Append(Members value)                                                                                                   // BuildMemberBase.cs:337
	    {                                                                                                                                      // BuildMemberBase.cs:338
	        Item item = new Item();                                                                                                            // BuildMemberBase.cs:339
	        item.Value = value;                                                                                                                // BuildMemberBase.cs:340
	        this.items.Add(item);                                                                                                              // BuildMemberBase.cs:341
	        return value;                                                                                                                      // BuildMemberBase.cs:342
	    }                                                                                                                                      // BuildMemberBase.cs:343
	                                                                                                                                           // BuildMemberBase.cs:353
	    // BuildMemberBase.cs:354
	    /// <summary>
	    /// Write container items.
	    /// </summary>
	    public IEnumerable<Extension> Write(BreastRadiologyDocument doc)                                                                       // BuildMemberExtensionComplex.cs:84
	    {                                                                                                                                      // BuildMemberExtensionComplex.cs:85
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberExtensionComplex.cs:86
	            yield return item.WriteItem(doc);                                                                                              // BuildMemberExtensionComplex.cs:87
	    }                                                                                                                                      // BuildMemberExtensionComplex.cs:88
	                                                                                                                                           // BuildMemberBase.cs:359
	    // BuildMemberBase.cs:360
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
	}                                                                                                                                          // BuildMemberBase.cs:199
	#endregion                                                                                                                                 // BuildMemberBase.cs:200
	//- LocalClassDefs
}
