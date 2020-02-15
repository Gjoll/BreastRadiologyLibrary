using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class BreastRadComposition : CompositionBase, IHeaderFragment
	{
		//+ LocalClassDefs
		/// <summary>
		/// Accessor class for 'Breast Radiology Report'
		/// [Fhir Element 'Composition.section:report]'
		/// </summary>
		public class Report_Accessor                                                                                                              // CSDefineComposition.cs:103
		{                                                                                                                                         // CSDefineComposition.cs:104
		    // Definitions                                                                                                                        // CSDefineComposition.cs:105
		                                                                                                                                          // CSDefineComposition.cs:107
		    // Fields                                                                                                                             // CSDefineComposition.cs:108
		    /// <summary>
		    /// Parent document
		    /// </summary>
		    BreastRadiologyDocument doc;                                                                                                          // CSDefineComposition.cs:170
		                                                                                                                                          // CSDefineComposition.cs:175
		    /// <summary>
		    /// Section item
		    /// </summary>
		    BreastRadReport item;                                                                                                                 // CSDefineComposition.cs:179
		                                                                                                                                          // CSDefineComposition.cs:110
		    // Properties                                                                                                                         // CSDefineComposition.cs:111
		    /// <summary>
		    /// Access Min cardinality
		    /// </summary>
		    public Int32 Min => 1;                                                                                                                // CSDefineComposition.cs:133
		                                                                                                                                          // CSDefineComposition.cs:135
		    /// <summary>
		    /// Access Max cardinality
		    /// </summary>
		    public Int32 Max => 1;                                                                                                                // CSDefineComposition.cs:139
		                                                                                                                                          // CSDefineComposition.cs:141
		    /// <summary>
		    /// Section Title
		    /// </summary>
		    public String SectionTitle => "Breast Radiology Report";                                                                              // CSDefineComposition.cs:145
		                                                                                                                                          // CSDefineComposition.cs:147
		    /// <summary>
		    /// Section Code system
		    /// </summary>
		    public String SectionCodeSystem => "http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes";                 // CSDefineComposition.cs:151
		                                                                                                                                          // CSDefineComposition.cs:153
		    /// <summary>
		    /// Section Code
		    /// </summary>
		    public String SectionCodeCode => "sectionReport";                                                                                     // CSDefineComposition.cs:157
		                                                                                                                                          // CSDefineComposition.cs:159
		    /// <summary>
		    /// Section coding
		    /// </summary>
		    public Coding SectionCode => new Coding(SectionCodeSystem, SectionCodeCode);                                                          // CSDefineComposition.cs:163
		    /// Access propertyName
		    /// </summary>
		    public BreastRadReport Item                                                                                                           // CSDefineComposition.cs:185
		    {                                                                                                                                     // CSDefineComposition.cs:186
		        get => this.item;                                                                                                                 // CSDefineComposition.cs:187
		        set => this.item = value;                                                                                                         // CSDefineComposition.cs:188
		    }                                                                                                                                     // CSDefineComposition.cs:189
		                                                                                                                                          // CSDefineComposition.cs:113
		    // Methods                                                                                                                            // CSDefineComposition.cs:114
		                                                                                                                                          // CSDefineComposition.cs:193
		    /// <summary>
		    /// Create new blank Report
		    /// </summary>
		    public BreastRadReport Create()                                                                                                       // CSDefineComposition.cs:197
		    {                                                                                                                                     // CSDefineComposition.cs:198
		        if (this.Item != null)                                                                                                            // CSDefineComposition.cs:199
		            throw new Exception("Item already has a value");                                                                              // CSDefineComposition.cs:200
		        BreastRadReport retVal = new BreastRadReport(this.doc);                                                                           // CSDefineComposition.cs:201
		        this.item = retVal;                                                                                                               // CSDefineComposition.cs:202
		        return retVal;                                                                                                                    // CSDefineComposition.cs:203
		    }                                                                                                                                     // CSDefineComposition.cs:204
		    public void Read(List<BreastRadReport> items)                                                                                         // CSDefineComposition.cs:205
		    {                                                                                                                                     // CSDefineComposition.cs:206
		        if (this.Item != null)                                                                                                            // CSDefineComposition.cs:207
		            throw new Exception("Item already has a value");                                                                              // CSDefineComposition.cs:208
		        if (items.Count == 0)                                                                                                             // CSDefineComposition.cs:209
		            return;                                                                                                                       // CSDefineComposition.cs:210
		        if (items.Count == 1)                                                                                                             // CSDefineComposition.cs:211
		        {                                                                                                                                 // CSDefineComposition.cs:212
		            this.item = items[0];                                                                                                         // CSDefineComposition.cs:213
		        }                                                                                                                                 // CSDefineComposition.cs:214
		        throw new Exception("Unexpected multiple items. Expected single item");                                                           // CSDefineComposition.cs:215
		    }                                                                                                                                     // CSDefineComposition.cs:216
		                                                                                                                                          // CSDefineComposition.cs:116
		    /// <summary>
		    /// Accessor class constructor
		    /// </summary>
		    public Report_Accessor(BreastRadiologyDocument doc)                                                                                   // CSDefineComposition.cs:120
		    {                                                                                                                                     // CSDefineComposition.cs:121
		        this.doc = doc;
		    }                                                                                                                                     // CSDefineComposition.cs:124
		}                                                                                                                                         // CSDefineComposition.cs:125
		/// <summary>
		/// Accessor class for 'Clinical Impressions'
		/// [Fhir Element 'Composition.section:impressions]'
		/// </summary>
		public class Impressions_Accessor                                                                                                         // CSDefineComposition.cs:103
		{                                                                                                                                         // CSDefineComposition.cs:104
		    // Definitions                                                                                                                        // CSDefineComposition.cs:105
		                                                                                                                                          // CSDefineComposition.cs:107
		    // Fields                                                                                                                             // CSDefineComposition.cs:108
		    /// <summary>
		    /// Parent document
		    /// </summary>
		    BreastRadiologyDocument doc;                                                                                                          // CSDefineComposition.cs:170
		                                                                                                                                          // CSDefineComposition.cs:223
		    /// <summary>
		    /// Section items list
		    /// </summary>
		    List<ResourceBase> items = new List<ResourceBase>();                                                                                  // CSDefineComposition.cs:227
		                                                                                                                                          // CSDefineComposition.cs:32
		    /// <summary>
		    /// Append new blank Impressions of type ResourceBase
		    /// </summary>
		    public ResourceBase AppendImpressions(DomainResource resource)                                                                        // CSDefineComposition.cs:36
		    {                                                                                                                                     // CSDefineComposition.cs:37
		        ResourceBase retVal = new ResourceBase(this.doc, resource);                                                                       // CSDefineComposition.cs:38
		        this.items.Add(retVal);                                                                                                           // CSDefineComposition.cs:39
		        return retVal;                                                                                                                    // CSDefineComposition.cs:40
		    }                                                                                                                                     // CSDefineComposition.cs:41
		                                                                                                                                          // CSDefineComposition.cs:110
		    // Properties                                                                                                                         // CSDefineComposition.cs:111
		    /// <summary>
		    /// Access Min cardinality
		    /// </summary>
		    public Int32 Min => 0;                                                                                                                // CSDefineComposition.cs:133
		                                                                                                                                          // CSDefineComposition.cs:135
		    /// <summary>
		    /// Access Max cardinality
		    /// </summary>
		    public Int32 Max => -1;                                                                                                               // CSDefineComposition.cs:139
		                                                                                                                                          // CSDefineComposition.cs:141
		    /// <summary>
		    /// Section Title
		    /// </summary>
		    public String SectionTitle => "Clinical Impressions";                                                                                 // CSDefineComposition.cs:145
		                                                                                                                                          // CSDefineComposition.cs:147
		    /// <summary>
		    /// Section Code system
		    /// </summary>
		    public String SectionCodeSystem => "http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes";                 // CSDefineComposition.cs:151
		                                                                                                                                          // CSDefineComposition.cs:153
		    /// <summary>
		    /// Section Code
		    /// </summary>
		    public String SectionCodeCode => "sectionImpressions";                                                                                // CSDefineComposition.cs:157
		                                                                                                                                          // CSDefineComposition.cs:159
		    /// <summary>
		    /// Section coding
		    /// </summary>
		    public Coding SectionCode => new Coding(SectionCodeSystem, SectionCodeCode);                                                          // CSDefineComposition.cs:163
		    /// Access propertyName
		    /// </summary>
		    public IEnumerable<ResourceBase> Items => this.items;                                                                                 // CSDefineComposition.cs:233
		                                                                                                                                          // CSDefineComposition.cs:113
		    // Methods                                                                                                                            // CSDefineComposition.cs:114
		    public void Read(List<ResourceBase> items)                                                                                            // CSDefineComposition.cs:255
		    {                                                                                                                                     // CSDefineComposition.cs:256
		        if (this.items.Count > 0)                                                                                                         // CSDefineComposition.cs:257
		            throw new Exception("Item already has a value");                                                                              // CSDefineComposition.cs:258
		        if (items.Count < Min)                                                                                                            // CSDefineComposition.cs:259
		            throw new Exception("Minimum cardinality error. Expected at least {Min}, got {items.Count}");                                 // CSDefineComposition.cs:260
		        if (items.Count > Max)                                                                                                            // CSDefineComposition.cs:261
		            throw new Exception("Maximum cardinality error. Expected no more than {Max}, got {items.Count}");                             // CSDefineComposition.cs:262
		        this.items = items;                                                                                                               // CSDefineComposition.cs:263
		    }                                                                                                                                     // CSDefineComposition.cs:264
		                                                                                                                                          // CSDefineComposition.cs:116
		    /// <summary>
		    /// Accessor class constructor
		    /// </summary>
		    public Impressions_Accessor(BreastRadiologyDocument doc)                                                                              // CSDefineComposition.cs:120
		    {                                                                                                                                     // CSDefineComposition.cs:121
		        this.doc = doc;
		    }                                                                                                                                     // CSDefineComposition.cs:124
		}                                                                                                                                         // CSDefineComposition.cs:125
		/// <summary>
		/// Accessor class for 'Related Resources'
		/// [Fhir Element 'Composition.section:relatedResources]'
		/// </summary>
		public class RelatedResources_Accessor                                                                                                    // CSDefineComposition.cs:103
		{                                                                                                                                         // CSDefineComposition.cs:104
		    // Definitions                                                                                                                        // CSDefineComposition.cs:105
		                                                                                                                                          // CSDefineComposition.cs:107
		    // Fields                                                                                                                             // CSDefineComposition.cs:108
		    /// <summary>
		    /// Parent document
		    /// </summary>
		    BreastRadiologyDocument doc;                                                                                                          // CSDefineComposition.cs:170
		                                                                                                                                          // CSDefineComposition.cs:223
		    /// <summary>
		    /// Section items list
		    /// </summary>
		    List<ResourceBase> items = new List<ResourceBase>();                                                                                  // CSDefineComposition.cs:227
		                                                                                                                                          // CSDefineComposition.cs:32
		    /// <summary>
		    /// Append new blank RelatedResources of type ResourceBase
		    /// </summary>
		    public ResourceBase AppendRelatedResources(DomainResource resource)                                                                   // CSDefineComposition.cs:36
		    {                                                                                                                                     // CSDefineComposition.cs:37
		        ResourceBase retVal = new ResourceBase(this.doc, resource);                                                                       // CSDefineComposition.cs:38
		        this.items.Add(retVal);                                                                                                           // CSDefineComposition.cs:39
		        return retVal;                                                                                                                    // CSDefineComposition.cs:40
		    }                                                                                                                                     // CSDefineComposition.cs:41
		                                                                                                                                          // CSDefineComposition.cs:110
		    // Properties                                                                                                                         // CSDefineComposition.cs:111
		    /// <summary>
		    /// Access Min cardinality
		    /// </summary>
		    public Int32 Min => 0;                                                                                                                // CSDefineComposition.cs:133
		                                                                                                                                          // CSDefineComposition.cs:135
		    /// <summary>
		    /// Access Max cardinality
		    /// </summary>
		    public Int32 Max => -1;                                                                                                               // CSDefineComposition.cs:139
		                                                                                                                                          // CSDefineComposition.cs:141
		    /// <summary>
		    /// Section Title
		    /// </summary>
		    public String SectionTitle => "Related Resources";                                                                                    // CSDefineComposition.cs:145
		                                                                                                                                          // CSDefineComposition.cs:147
		    /// <summary>
		    /// Section Code system
		    /// </summary>
		    public String SectionCodeSystem => "http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes";                 // CSDefineComposition.cs:151
		                                                                                                                                          // CSDefineComposition.cs:153
		    /// <summary>
		    /// Section Code
		    /// </summary>
		    public String SectionCodeCode => "sectionRelatedResources";                                                                           // CSDefineComposition.cs:157
		                                                                                                                                          // CSDefineComposition.cs:159
		    /// <summary>
		    /// Section coding
		    /// </summary>
		    public Coding SectionCode => new Coding(SectionCodeSystem, SectionCodeCode);                                                          // CSDefineComposition.cs:163
		    /// Access propertyName
		    /// </summary>
		    public IEnumerable<ResourceBase> Items => this.items;                                                                                 // CSDefineComposition.cs:233
		                                                                                                                                          // CSDefineComposition.cs:113
		    // Methods                                                                                                                            // CSDefineComposition.cs:114
		    public void Read(List<ResourceBase> items)                                                                                            // CSDefineComposition.cs:255
		    {                                                                                                                                     // CSDefineComposition.cs:256
		        if (this.items.Count > 0)                                                                                                         // CSDefineComposition.cs:257
		            throw new Exception("Item already has a value");                                                                              // CSDefineComposition.cs:258
		        if (items.Count < Min)                                                                                                            // CSDefineComposition.cs:259
		            throw new Exception("Minimum cardinality error. Expected at least {Min}, got {items.Count}");                                 // CSDefineComposition.cs:260
		        if (items.Count > Max)                                                                                                            // CSDefineComposition.cs:261
		            throw new Exception("Maximum cardinality error. Expected no more than {Max}, got {items.Count}");                             // CSDefineComposition.cs:262
		        this.items = items;                                                                                                               // CSDefineComposition.cs:263
		    }                                                                                                                                     // CSDefineComposition.cs:264
		                                                                                                                                          // CSDefineComposition.cs:116
		    /// <summary>
		    /// Accessor class constructor
		    /// </summary>
		    public RelatedResources_Accessor(BreastRadiologyDocument doc)                                                                         // CSDefineComposition.cs:120
		    {                                                                                                                                     // CSDefineComposition.cs:121
		        this.doc = doc;
		    }                                                                                                                                     // CSDefineComposition.cs:124
		}                                                                                                                                         // CSDefineComposition.cs:125
		/// <summary>
		/// Accessor class for 'Recommendations'
		/// [Fhir Element 'Composition.section:recommendations]'
		/// </summary>
		public class Recommendations_Accessor                                                                                                     // CSDefineComposition.cs:103
		{                                                                                                                                         // CSDefineComposition.cs:104
		    // Definitions                                                                                                                        // CSDefineComposition.cs:105
		                                                                                                                                          // CSDefineComposition.cs:107
		    // Fields                                                                                                                             // CSDefineComposition.cs:108
		    /// <summary>
		    /// Parent document
		    /// </summary>
		    BreastRadiologyDocument doc;                                                                                                          // CSDefineComposition.cs:170
		                                                                                                                                          // CSDefineComposition.cs:223
		    /// <summary>
		    /// Section items list
		    /// </summary>
		    List<ResourceBase> items = new List<ResourceBase>();                                                                                  // CSDefineComposition.cs:227
		                                                                                                                                          // CSDefineComposition.cs:32
		    /// <summary>
		    /// Append new blank Recommendations of type ResourceBase
		    /// </summary>
		    public ResourceBase AppendRecommendations(MedicationRequest resource)                                                                 // CSDefineComposition.cs:36
		    {                                                                                                                                     // CSDefineComposition.cs:37
		        ResourceBase retVal = new ResourceBase(this.doc, resource);                                                                       // CSDefineComposition.cs:38
		        this.items.Add(retVal);                                                                                                           // CSDefineComposition.cs:39
		        return retVal;                                                                                                                    // CSDefineComposition.cs:40
		    }                                                                                                                                     // CSDefineComposition.cs:41
		                                                                                                                                          // CSDefineComposition.cs:32
		    /// <summary>
		    /// Append new blank Recommendations of type ResourceBase
		    /// </summary>
		    public ResourceBase AppendRecommendations(ServiceRequest resource)                                                                    // CSDefineComposition.cs:36
		    {                                                                                                                                     // CSDefineComposition.cs:37
		        ResourceBase retVal = new ResourceBase(this.doc, resource);                                                                       // CSDefineComposition.cs:38
		        this.items.Add(retVal);                                                                                                           // CSDefineComposition.cs:39
		        return retVal;                                                                                                                    // CSDefineComposition.cs:40
		    }                                                                                                                                     // CSDefineComposition.cs:41
		                                                                                                                                          // CSDefineComposition.cs:63
		    /// <summary>
		    /// Append new blank Recommendations
		    /// </summary>
		    public ServiceRecommendation AppendRecommendations(ServiceRecommendation brClass = null)                                              // CSDefineComposition.cs:67
		    {                                                                                                                                     // CSDefineComposition.cs:68
		        if (brClass == null)                                                                                                              // CSDefineComposition.cs:69
		            brClass = new ServiceRecommendation(this.doc);                                                                                // CSDefineComposition.cs:70
		        this.items.Add(brClass);                                                                                                          // CSDefineComposition.cs:71
		        return brClass;                                                                                                                   // CSDefineComposition.cs:72
		    }                                                                                                                                     // CSDefineComposition.cs:73
		                                                                                                                                          // CSDefineComposition.cs:110
		    // Properties                                                                                                                         // CSDefineComposition.cs:111
		    /// <summary>
		    /// Access Min cardinality
		    /// </summary>
		    public Int32 Min => 0;                                                                                                                // CSDefineComposition.cs:133
		                                                                                                                                          // CSDefineComposition.cs:135
		    /// <summary>
		    /// Access Max cardinality
		    /// </summary>
		    public Int32 Max => -1;                                                                                                               // CSDefineComposition.cs:139
		                                                                                                                                          // CSDefineComposition.cs:141
		    /// <summary>
		    /// Section Title
		    /// </summary>
		    public String SectionTitle => "Recommendations";                                                                                      // CSDefineComposition.cs:145
		                                                                                                                                          // CSDefineComposition.cs:147
		    /// <summary>
		    /// Section Code system
		    /// </summary>
		    public String SectionCodeSystem => "http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes";                 // CSDefineComposition.cs:151
		                                                                                                                                          // CSDefineComposition.cs:153
		    /// <summary>
		    /// Section Code
		    /// </summary>
		    public String SectionCodeCode => "sectionCodeRecommendations";                                                                        // CSDefineComposition.cs:157
		                                                                                                                                          // CSDefineComposition.cs:159
		    /// <summary>
		    /// Section coding
		    /// </summary>
		    public Coding SectionCode => new Coding(SectionCodeSystem, SectionCodeCode);                                                          // CSDefineComposition.cs:163
		    /// Access propertyName
		    /// </summary>
		    public IEnumerable<ResourceBase> Items => this.items;                                                                                 // CSDefineComposition.cs:233
		                                                                                                                                          // CSDefineComposition.cs:113
		    // Methods                                                                                                                            // CSDefineComposition.cs:114
		    public void Read(List<ResourceBase> items)                                                                                            // CSDefineComposition.cs:255
		    {                                                                                                                                     // CSDefineComposition.cs:256
		        if (this.items.Count > 0)                                                                                                         // CSDefineComposition.cs:257
		            throw new Exception("Item already has a value");                                                                              // CSDefineComposition.cs:258
		        if (items.Count < Min)                                                                                                            // CSDefineComposition.cs:259
		            throw new Exception("Minimum cardinality error. Expected at least {Min}, got {items.Count}");                                 // CSDefineComposition.cs:260
		        if (items.Count > Max)                                                                                                            // CSDefineComposition.cs:261
		            throw new Exception("Maximum cardinality error. Expected no more than {Max}, got {items.Count}");                             // CSDefineComposition.cs:262
		        this.items = items;                                                                                                               // CSDefineComposition.cs:263
		    }                                                                                                                                     // CSDefineComposition.cs:264
		                                                                                                                                          // CSDefineComposition.cs:116
		    /// <summary>
		    /// Accessor class constructor
		    /// </summary>
		    public Recommendations_Accessor(BreastRadiologyDocument doc)                                                                          // CSDefineComposition.cs:120
		    {                                                                                                                                     // CSDefineComposition.cs:121
		        this.doc = doc;
		    }                                                                                                                                     // CSDefineComposition.cs:124
		}                                                                                                                                         // CSDefineComposition.cs:125
		//- LocalClassDefs

		//+ Fields
		Report_Accessor Report { get ; }                                                                                                          // CSDefineComposition.cs:324
		Impressions_Accessor Impressions { get ; }                                                                                                // CSDefineComposition.cs:324
		RelatedResources_Accessor RelatedResources { get ; }                                                                                      // CSDefineComposition.cs:324
		Recommendations_Accessor Recommendations { get ; }                                                                                        // CSDefineComposition.cs:324
		//- Fields

		public BreastRadComposition(BreastRadiologyDocument doc, Composition resource) : base(doc, resource)
		{
			//+ Constructor
			this.Report = new Report_Accessor(doc);                                                                                                  // CSDefineComposition.cs:327
			this.Impressions = new Impressions_Accessor(doc);                                                                                        // CSDefineComposition.cs:327
			this.RelatedResources = new RelatedResources_Accessor(doc);                                                                              // CSDefineComposition.cs:327
			this.Recommendations = new Recommendations_Accessor(doc);                                                                                // CSDefineComposition.cs:327
			//- Constructor
		}

		public BreastRadComposition(BreastRadiologyDocument doc) : this(doc, new Composition())
		{
		}

		public override void Write()
		{
		//+ WriteCode
		ClearSection();                                                                                                                           // CSDefineComposition.cs:284
		//- WriteCode
		}

		public override void Read()
		{
		//+ ReadCode
		{                                                                                                                                         // CSDefineComposition.cs:339
		    var items = ReadSection<BreastRadReport>(this.Report.SectionTitle,                                                                    // CSDefineComposition.cs:340
		        this.Report.SectionCode,                                                                                                          // CSDefineComposition.cs:341
		        this.Report.Min,                                                                                                                  // CSDefineComposition.cs:342
		        this.Report.Max);                                                                                                                 // CSDefineComposition.cs:343
		    this.Report.Read(items);                                                                                                              // CSDefineComposition.cs:344
		}                                                                                                                                         // CSDefineComposition.cs:345
		{                                                                                                                                         // CSDefineComposition.cs:339
		    var items = ReadSection<ResourceBase>(this.Impressions.SectionTitle,                                                                  // CSDefineComposition.cs:340
		        this.Impressions.SectionCode,                                                                                                     // CSDefineComposition.cs:341
		        this.Impressions.Min,                                                                                                             // CSDefineComposition.cs:342
		        this.Impressions.Max);                                                                                                            // CSDefineComposition.cs:343
		    this.Impressions.Read(items);                                                                                                         // CSDefineComposition.cs:344
		}                                                                                                                                         // CSDefineComposition.cs:345
		{                                                                                                                                         // CSDefineComposition.cs:339
		    var items = ReadSection<ResourceBase>(this.RelatedResources.SectionTitle,                                                             // CSDefineComposition.cs:340
		        this.RelatedResources.SectionCode,                                                                                                // CSDefineComposition.cs:341
		        this.RelatedResources.Min,                                                                                                        // CSDefineComposition.cs:342
		        this.RelatedResources.Max);                                                                                                       // CSDefineComposition.cs:343
		    this.RelatedResources.Read(items);                                                                                                    // CSDefineComposition.cs:344
		}                                                                                                                                         // CSDefineComposition.cs:345
		{                                                                                                                                         // CSDefineComposition.cs:339
		    var items = ReadSection<ResourceBase>(this.Recommendations.SectionTitle,                                                              // CSDefineComposition.cs:340
		        this.Recommendations.SectionCode,                                                                                                 // CSDefineComposition.cs:341
		        this.Recommendations.Min,                                                                                                         // CSDefineComposition.cs:342
		        this.Recommendations.Max);                                                                                                        // CSDefineComposition.cs:343
		    this.Recommendations.Read(items);                                                                                                     // CSDefineComposition.cs:344
		}                                                                                                                                         // CSDefineComposition.cs:345
		//- ReadCode
		}

		//+ Methods
		//- Methods
	}
}
