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
	#region BodyDistanceFromExtension Container Class                                                                                          // BuildMemberBase.cs:137
	/// <summary>
	/// Container class for BodyDistanceFromExtension.
	/// </summary>
	public class BodyDistanceFromExtensionCollection : MContainer, ITMItem<Extension>                                                          // BuildMemberBase.cs:141
	{                                                                                                                                          // BuildMemberBase.cs:142
	    #region BodyDistanceFromExtension Item Class                                                                                           // BuildMemberBase.cs:73
	    /// <summary>
	    /// Item class for BodyDistanceFromExtension.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:77
	    {                                                                                                                                      // BuildMemberBase.cs:78
	        // Properties                                                                                                                      // BuildMemberBase.cs:79
	        /// <summary>
	        /// Value
	        /// </summary>
	        public BodyDistanceFromExtension Value { get; set; }                                                                               // BuildMemberBase.cs:83
	                                                                                                                                           // BuildMemberBase.cs:85
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public Item(BodyDistanceFromExtension value)                                                                                       // BuildMemberBase.cs:89
	        {                                                                                                                                  // BuildMemberBase.cs:90
	            this.Value = value;                                                                                                            // BuildMemberBase.cs:91
	        }                                                                                                                                  // BuildMemberBase.cs:93
	                                                                                                                                           // BuildMemberBase.cs:95
	        // Methods                                                                                                                         // BuildMemberBase.cs:96
	    }                                                                                                                                      // BuildMemberBase.cs:98
	    #endregion                                                                                                                             // BuildMemberBase.cs:99
	    /// <summary>
	    /// Extension Item class for BodyDistanceFromExtension.
	    /// </summary>
	    public class BodyDistanceFromExtension                                                                                                 // BuildMemberExtensionComplex.cs:87
	    {                                                                                                                                      // BuildMemberExtensionComplex.cs:88
	        // Definitions                                                                                                                     // BuildMemberExtensionComplex.cs:89
	        public const String ExtensionUrl = "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/BodyDistanceFromExtension";        // BuildMemberExtensionComplex.cs:90
	        #region Extension.extension:landMark Container Class                                                                               // BuildMemberBase.cs:137
	        /// <summary>
	        /// Container class for Extension.extension:landMark.
	        /// </summary>
	        public class LandMarkCollection : MContainer, ITMItem<Extension>                                                                   // BuildMemberBase.cs:141
	        {                                                                                                                                  // BuildMemberBase.cs:142
	            #region Extension.extension:landMark Item Class                                                                                // BuildMemberBase.cs:73
	            /// <summary>
	            /// Item class for Extension.extension:landMark.
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
	            public const String ExtensionUrl = "landMark";                                                                                 // BuildMemberExtensionSimple.cs:39
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
	            public LandMarkCollection(Int32 min, Int32 max) : base("Extension.extension:landMark", min, max)                               // BuildMemberBase.cs:151
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
	        #region Extension.extension:distanceFromLandMark Container Class                                                                   // BuildMemberBase.cs:137
	        /// <summary>
	        /// Container class for Extension.extension:distanceFromLandMark.
	        /// </summary>
	        public class DistanceFromLandMarkCollection : MContainer, ITMItem<Extension>                                                       // BuildMemberBase.cs:141
	        {                                                                                                                                  // BuildMemberBase.cs:142
	            #region Extension.extension:distanceFromLandMark Item Class                                                                    // BuildMemberBase.cs:73
	            /// <summary>
	            /// Item class for Extension.extension:distanceFromLandMark.
	            /// </summary>
	            public class Item                                                                                                              // BuildMemberBase.cs:77
	            {                                                                                                                              // BuildMemberBase.cs:78
	                // Properties                                                                                                              // BuildMemberBase.cs:79
	                /// <summary>
	                /// Value
	                /// </summary>
	                public Quantity Value { get; set; }                                                                                        // BuildMemberBase.cs:83
	                                                                                                                                           // BuildMemberBase.cs:85
	                /// <summary>
	                /// Constructor
	                /// </summary>
	                public Item(Quantity value)                                                                                                // BuildMemberBase.cs:89
	                {                                                                                                                          // BuildMemberBase.cs:90
	                    this.Value = value;                                                                                                    // BuildMemberBase.cs:91
	                }                                                                                                                          // BuildMemberBase.cs:93
	                                                                                                                                           // BuildMemberBase.cs:95
	                // Methods                                                                                                                 // BuildMemberBase.cs:96
	            }                                                                                                                              // BuildMemberBase.cs:98
	            #endregion                                                                                                                     // BuildMemberBase.cs:99
	                                                                                                                                           // BuildMemberBase.cs:144
	            // Properties                                                                                                                  // BuildMemberBase.cs:145
	            public const String ExtensionUrl = "distanceFromLandMark";                                                                     // BuildMemberExtensionSimple.cs:39
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
	            public Quantity Get()                                                                                                          // BuildMemberBase.cs:206
	            {                                                                                                                              // BuildMemberBase.cs:207
	                if (item == null)                                                                                                          // BuildMemberBase.cs:208
	                    return null;                                                                                                           // BuildMemberBase.cs:209
	                return item.Value;                                                                                                         // BuildMemberBase.cs:210
	            }                                                                                                                              // BuildMemberBase.cs:211
	                                                                                                                                           // BuildMemberBase.cs:217
	            /// <summary>
	            /// Set Item's Value
	            /// </summary>
	            public Quantity Set(Quantity value)                                                                                            // BuildMemberBase.cs:221
	            {                                                                                                                              // BuildMemberBase.cs:222
	                this.item = new Item(value);                                                                                               // BuildMemberBase.cs:223
	                return value;                                                                                                              // BuildMemberBase.cs:224
	            }                                                                                                                              // BuildMemberBase.cs:225
	                                                                                                                                           // BuildMemberBase.cs:147
	            /// <summary>
	            /// Constructor
	            /// </summary>
	            public DistanceFromLandMarkCollection(Int32 min, Int32 max) : base("Extension.extension:distanceFromLandMark", min, max)       // BuildMemberBase.cs:151
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
	                    items.Add(new Item((Quantity) myExtension.Value));                                                                     // BuildMemberExtensionSimple.cs:55
	                this.SetAllItems(items);                                                                                                   // BuildMemberExtensionSimple.cs:56
	            }                                                                                                                              // BuildMemberExtensionSimple.cs:57
	        }                                                                                                                                  // BuildMemberBase.cs:158
	        #endregion                                                                                                                         // BuildMemberBase.cs:159
	        // Properties                                                                                                                      // BuildMemberExtensionComplex.cs:92
	                                                                                                                                           // BuildMemberBase.cs:337
	        /// <summary>
	        /// LandMark
	        /// Access fhir element 'Extension.extension:landMark'
	        /// </summary>
	        public LandMarkCollection LandMark { get ; protected set; }                                                                        // BuildMemberBase.cs:342
	                                                                                                                                           // BuildMemberBase.cs:337
	        /// <summary>
	        /// DistanceFromLandMark
	        /// Access fhir element 'Extension.extension:distanceFromLandMark'
	        /// </summary>
	        public DistanceFromLandMarkCollection DistanceFromLandMark { get ; protected set; }                                                // BuildMemberBase.cs:342
	                                                                                                                                           // BuildMemberExtensionComplex.cs:94
	        /// <summary>
	        /// Constructor
	        /// </summary>
	        public BodyDistanceFromExtension()                                                                                                 // BuildMemberExtensionComplex.cs:98
	        {                                                                                                                                  // BuildMemberExtensionComplex.cs:99
	            this.LandMark = new LandMarkCollection(0, 0);                                                                                  // BuildMemberBase.cs:323
	            this.DistanceFromLandMark = new DistanceFromLandMarkCollection(0, 0);                                                          // BuildMemberBase.cs:323
	        }                                                                                                                                  // BuildMemberExtensionComplex.cs:101
	                                                                                                                                           // BuildMemberExtensionComplex.cs:103
	        // Methods                                                                                                                         // BuildMemberExtensionComplex.cs:104
	                                                                                                                                           // BuildMemberExtensionComplex.cs:107
	        /// <summary>
	        /// Write item as a fhir element.
	        /// </summary>
	        public IEnumerable<Extension> Write(BreastRadiologyDocument doc)                                                                   // BuildMemberExtensionComplex.cs:111
	        {                                                                                                                                  // BuildMemberExtensionComplex.cs:112
	            List<Extension> items = new List<Extension>();                                                                                 // BuildMemberExtensionComplex.cs:113
	            items.AddRange(this.LandMark.Write(doc));                                                                                      // BuildMemberExtensionSimple.cs:82
	            items.AddRange(this.DistanceFromLandMark.Write(doc));                                                                          // BuildMemberExtensionSimple.cs:82
	            yield return new Extension                                                                                                     // BuildMemberExtensionComplex.cs:115
	            {                                                                                                                              // BuildMemberExtensionComplex.cs:116
	                Url = ExtensionUrl,                                                                                                        // BuildMemberExtensionComplex.cs:117
	                Extension = items                                                                                                          // BuildMemberExtensionComplex.cs:118
	            };                                                                                                                             // BuildMemberExtensionComplex.cs:119
	        }                                                                                                                                  // BuildMemberExtensionComplex.cs:120
	                                                                                                                                           // BuildMemberExtensionComplex.cs:122
	        /// <summary>
	        /// Read from fhir element into member item.
	        /// </summary>
	        public void Read(BreastRadiologyDocument doc, IEnumerable<Extension> extensions)                                                   // BuildMemberExtensionComplex.cs:126
	        {                                                                                                                                  // BuildMemberExtensionComplex.cs:127
	            this.LandMark.Read(doc, extensions);                                                                                           // BuildMemberExtensionSimple.cs:61
	            this.DistanceFromLandMark.Read(doc, extensions);                                                                               // BuildMemberExtensionSimple.cs:61
	        }                                                                                                                                  // BuildMemberExtensionComplex.cs:129
	    }                                                                                                                                      // BuildMemberExtensionComplex.cs:131
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
	    public IEnumerable<BodyDistanceFromExtension> All()                                                                                    // BuildMemberBase.cs:256
	    {                                                                                                                                      // BuildMemberBase.cs:257
	        foreach (Item item in items)                                                                                                       // BuildMemberBase.cs:258
	           yield return item.Value;                                                                                                        // BuildMemberBase.cs:259
	    }                                                                                                                                      // BuildMemberBase.cs:260
	                                                                                                                                           // BuildMemberBase.cs:262
	    /// <summary>
	    /// Get Item's Value at indicated index
	    /// </summary>
	    public BodyDistanceFromExtension GetAt(Int32 i) => this.items[i].Value;                                                                // BuildMemberBase.cs:266
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
	    public BodyDistanceFromExtensionCollection(Int32 min, Int32 max) : base("BodyDistanceFromExtension", min, max)                         // BuildMemberBase.cs:151
	    {                                                                                                                                      // BuildMemberBase.cs:152
	    }                                                                                                                                      // BuildMemberBase.cs:154
	                                                                                                                                           // BuildMemberBase.cs:155
	    // Methods                                                                                                                             // BuildMemberBase.cs:156
	                                                                                                                                           // BuildMemberBase.cs:284
	    /// <summary>
	    /// Append value to collection
	    /// </summary>
	    public BodyDistanceFromExtension Append(BodyDistanceFromExtension value)                                                               // BuildMemberBase.cs:288
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
	        foreach (Item item in this.GetAllItems())                                                                                          // BuildMemberExtensionComplex.cs:58
	        {                                                                                                                                  // BuildMemberExtensionComplex.cs:59
	            Extension extension = new Extension                                                                                            // BuildMemberExtensionComplex.cs:61
	            {                                                                                                                              // BuildMemberExtensionComplex.cs:62
	            };                                                                                                                             // BuildMemberExtensionComplex.cs:65
	            yield return extension;                                                                                                        // BuildMemberExtensionComplex.cs:66
	        }                                                                                                                                  // BuildMemberExtensionComplex.cs:67
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
