using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
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
		public class Report_Accessor : SectionBase<BreastRadReport>                                                                               // CSDefineComposition.cs:60
		{                                                                                                                                         // CSDefineComposition.cs:61
		    // Properties                                                                                                                         // CSDefineComposition.cs:67
		    /// <summary>
		    /// Access propertyName
		    /// </summary>
		    public BreastRadReport Item                                                                                                           // CSDefineComposition.cs:96
		    {                                                                                                                                     // CSDefineComposition.cs:97
		        get => this.GetSingleItem<BreastRadReport> ();                                                                                    // CSDefineComposition.cs:98
		    }                                                                                                                                     // CSDefineComposition.cs:99
		                                                                                                                                          // CSDefineComposition.cs:69
		    // Methods                                                                                                                            // CSDefineComposition.cs:70
		                                                                                                                                          // CSDefineComposition.cs:108
		    /// <summary>
		    /// Create new blank Report of type DiagnosticReport
		    /// </summary>
		    public BreastRadReport CreateBreastRadReport(DiagnosticReport fhirItem = null)                                                        // CSDefineComposition.cs:123
		    {                                                                                                                                     // CSDefineComposition.cs:124
		        if (fhirItem == null) fhirItem = new DiagnosticReport();                                                                          // CSDefineComposition.cs:125
		        BreastRadReport brItem = new BreastRadReport();                                                                                   // CSDefineComposition.cs:129
		        brItem.Create(this.doc, fhirItem);                                                                                                // CSDefineComposition.cs:130
		        this.AppendItem(brItem);                                                                                                          // CSDefineComposition.cs:131
		        return brItem;                                                                                                                    // CSDefineComposition.cs:132
		    }                                                                                                                                     // CSDefineComposition.cs:133
		                                                                                                                                          // CSDefineComposition.cs:72
		    /// <summary>
		    /// Accessor class constructor
		    /// </summary>
		    public Report_Accessor(BreastRadiologyDocument doc) : base()                                                                          // CSDefineComposition.cs:76
		    {                                                                                                                                     // CSDefineComposition.cs:77
		        this.Create(doc, "Breast Radiology Report", 1, 1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes", "sectionReport"));// CSDefineComposition.cs:78
		    }                                                                                                                                     // CSDefineComposition.cs:80
		}                                                                                                                                         // CSDefineComposition.cs:81
		/// <summary>
		/// Accessor class for 'Clinical Impressions'
		/// [Fhir Element 'Composition.section:impressions]'
		/// </summary>
		public class Impressions_Accessor : SectionBase<ResourceBase>                                                                             // CSDefineComposition.cs:60
		{                                                                                                                                         // CSDefineComposition.cs:61
		    // Properties                                                                                                                         // CSDefineComposition.cs:67
		    /// <summary>
		    /// Access propertyName
		    /// </summary>
		    public IEnumerable<ResourceBase> Items => this.items;                                                                                 // CSDefineComposition.cs:143
		                                                                                                                                          // CSDefineComposition.cs:144
		    /// <summary>
		    /// Access first item in list or defrault if no first item
		    /// </summary>
		    public ResourceBase First() => this.items.First();                                                                                    // CSDefineComposition.cs:148
		                                                                                                                                          // CSDefineComposition.cs:149
		    /// <summary>
		    /// Access first item in list
		    /// </summary>
		    public ResourceBase FirstOrDefault() => this.items.FirstOrDefault();                                                                  // CSDefineComposition.cs:153
		                                                                                                                                          // CSDefineComposition.cs:69
		    // Methods                                                                                                                            // CSDefineComposition.cs:70
		                                                                                                                                          // CSDefineComposition.cs:162
		    /// <summary>
		    /// Create new blank Impressions of type ClinicalImpression and add to end of list
		    /// </summary>
		    public ResourceBase AddClinicalImpression(ClinicalImpression fhirItem = null)                                                         // CSDefineComposition.cs:178
		    {                                                                                                                                     // CSDefineComposition.cs:179
		        if (fhirItem == null) fhirItem = new ClinicalImpression();                                                                        // CSDefineComposition.cs:180
		        ResourceBase brItem = new ResourceBase();                                                                                         // CSDefineComposition.cs:184
		        brItem.Create(this.doc, fhirItem);                                                                                                // CSDefineComposition.cs:185
		        this.AppendItem(brItem);                                                                                                          // CSDefineComposition.cs:186
		        return brItem;                                                                                                                    // CSDefineComposition.cs:187
		    }                                                                                                                                     // CSDefineComposition.cs:188
		                                                                                                                                          // CSDefineComposition.cs:72
		    /// <summary>
		    /// Accessor class constructor
		    /// </summary>
		    public Impressions_Accessor(BreastRadiologyDocument doc) : base()                                                                     // CSDefineComposition.cs:76
		    {                                                                                                                                     // CSDefineComposition.cs:77
		        this.Create(doc, "Clinical Impressions", 0, -1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes", "sectionImpressions"));// CSDefineComposition.cs:78
		    }                                                                                                                                     // CSDefineComposition.cs:80
		}                                                                                                                                         // CSDefineComposition.cs:81
		/// <summary>
		/// Accessor class for 'Related Resources'
		/// [Fhir Element 'Composition.section:relatedResources]'
		/// </summary>
		public class RelatedResources_Accessor : SectionBase<ResourceBase>                                                                        // CSDefineComposition.cs:60
		{                                                                                                                                         // CSDefineComposition.cs:61
		    // Properties                                                                                                                         // CSDefineComposition.cs:67
		    /// <summary>
		    /// Access propertyName
		    /// </summary>
		    public IEnumerable<ResourceBase> Items => this.items;                                                                                 // CSDefineComposition.cs:143
		                                                                                                                                          // CSDefineComposition.cs:144
		    /// <summary>
		    /// Access first item in list or defrault if no first item
		    /// </summary>
		    public ResourceBase First() => this.items.First();                                                                                    // CSDefineComposition.cs:148
		                                                                                                                                          // CSDefineComposition.cs:149
		    /// <summary>
		    /// Access first item in list
		    /// </summary>
		    public ResourceBase FirstOrDefault() => this.items.FirstOrDefault();                                                                  // CSDefineComposition.cs:153
		                                                                                                                                          // CSDefineComposition.cs:69
		    // Methods                                                                                                                            // CSDefineComposition.cs:70
		                                                                                                                                          // CSDefineComposition.cs:162
		    /// <summary>
		    /// Create new blank RelatedResources of type Resource and add to end of list
		    /// </summary>
		    public ResourceBase AddResource(Resource fhirItem)                                                                                    // CSDefineComposition.cs:171
		    {                                                                                                                                     // CSDefineComposition.cs:172
		        ResourceBase brItem = new ResourceBase();                                                                                         // CSDefineComposition.cs:184
		        brItem.Create(this.doc, fhirItem);                                                                                                // CSDefineComposition.cs:185
		        this.AppendItem(brItem);                                                                                                          // CSDefineComposition.cs:186
		        return brItem;                                                                                                                    // CSDefineComposition.cs:187
		    }                                                                                                                                     // CSDefineComposition.cs:188
		                                                                                                                                          // CSDefineComposition.cs:72
		    /// <summary>
		    /// Accessor class constructor
		    /// </summary>
		    public RelatedResources_Accessor(BreastRadiologyDocument doc) : base()                                                                // CSDefineComposition.cs:76
		    {                                                                                                                                     // CSDefineComposition.cs:77
		        this.Create(doc, "Related Resources", 0, -1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes", "sectionRelatedResources"));// CSDefineComposition.cs:78
		    }                                                                                                                                     // CSDefineComposition.cs:80
		}                                                                                                                                         // CSDefineComposition.cs:81
		/// <summary>
		/// Accessor class for 'Recommendations'
		/// [Fhir Element 'Composition.section:recommendations]'
		/// </summary>
		public class Recommendations_Accessor : SectionBase<ResourceBase>                                                                         // CSDefineComposition.cs:60
		{                                                                                                                                         // CSDefineComposition.cs:61
		    // Properties                                                                                                                         // CSDefineComposition.cs:67
		    /// <summary>
		    /// Access propertyName
		    /// </summary>
		    public IEnumerable<ResourceBase> Items => this.items;                                                                                 // CSDefineComposition.cs:143
		                                                                                                                                          // CSDefineComposition.cs:144
		    /// <summary>
		    /// Access first item in list or defrault if no first item
		    /// </summary>
		    public ResourceBase First() => this.items.First();                                                                                    // CSDefineComposition.cs:148
		                                                                                                                                          // CSDefineComposition.cs:149
		    /// <summary>
		    /// Access first item in list
		    /// </summary>
		    public ResourceBase FirstOrDefault() => this.items.FirstOrDefault();                                                                  // CSDefineComposition.cs:153
		                                                                                                                                          // CSDefineComposition.cs:69
		    // Methods                                                                                                                            // CSDefineComposition.cs:70
		                                                                                                                                          // CSDefineComposition.cs:162
		    /// <summary>
		    /// Create new blank Recommendations of type MedicationRequest and add to end of list
		    /// </summary>
		    public ResourceBase AddMedicationRequest(MedicationRequest fhirItem = null)                                                           // CSDefineComposition.cs:178
		    {                                                                                                                                     // CSDefineComposition.cs:179
		        if (fhirItem == null) fhirItem = new MedicationRequest();                                                                         // CSDefineComposition.cs:180
		        ResourceBase brItem = new ResourceBase();                                                                                         // CSDefineComposition.cs:184
		        brItem.Create(this.doc, fhirItem);                                                                                                // CSDefineComposition.cs:185
		        this.AppendItem(brItem);                                                                                                          // CSDefineComposition.cs:186
		        return brItem;                                                                                                                    // CSDefineComposition.cs:187
		    }                                                                                                                                     // CSDefineComposition.cs:188
		                                                                                                                                          // CSDefineComposition.cs:162
		    /// <summary>
		    /// Create new blank Recommendations of type ServiceRequest and add to end of list
		    /// </summary>
		    public ResourceBase AddServiceRequest(ServiceRequest fhirItem = null)                                                                 // CSDefineComposition.cs:178
		    {                                                                                                                                     // CSDefineComposition.cs:179
		        if (fhirItem == null) fhirItem = new ServiceRequest();                                                                            // CSDefineComposition.cs:180
		        ResourceBase brItem = new ResourceBase();                                                                                         // CSDefineComposition.cs:184
		        brItem.Create(this.doc, fhirItem);                                                                                                // CSDefineComposition.cs:185
		        this.AppendItem(brItem);                                                                                                          // CSDefineComposition.cs:186
		        return brItem;                                                                                                                    // CSDefineComposition.cs:187
		    }                                                                                                                                     // CSDefineComposition.cs:188
		                                                                                                                                          // CSDefineComposition.cs:162
		    /// <summary>
		    /// Create new blank Recommendations of type ServiceRequest and add to end of list
		    /// </summary>
		    public ServiceRecommendation AddServiceRecommendation(ServiceRequest fhirItem = null)                                                 // CSDefineComposition.cs:178
		    {                                                                                                                                     // CSDefineComposition.cs:179
		        if (fhirItem == null) fhirItem = new ServiceRequest();                                                                            // CSDefineComposition.cs:180
		        ServiceRecommendation brItem = new ServiceRecommendation();                                                                       // CSDefineComposition.cs:184
		        brItem.Create(this.doc, fhirItem);                                                                                                // CSDefineComposition.cs:185
		        this.AppendItem(brItem);                                                                                                          // CSDefineComposition.cs:186
		        return brItem;                                                                                                                    // CSDefineComposition.cs:187
		    }                                                                                                                                     // CSDefineComposition.cs:188
		                                                                                                                                          // CSDefineComposition.cs:72
		    /// <summary>
		    /// Accessor class constructor
		    /// </summary>
		    public Recommendations_Accessor(BreastRadiologyDocument doc) : base()                                                                 // CSDefineComposition.cs:76
		    {                                                                                                                                     // CSDefineComposition.cs:77
		        this.Create(doc, "Recommendations", 0, -1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes", "sectionCodeRecommendations"));// CSDefineComposition.cs:78
		    }                                                                                                                                     // CSDefineComposition.cs:80
		}                                                                                                                                         // CSDefineComposition.cs:81
		//- LocalClassDefs

		//+ Fields
		public Report_Accessor Report { get ; protected set; }                                                                                    // CSDefineComposition.cs:249
		public Impressions_Accessor Impressions { get ; protected set; }                                                                          // CSDefineComposition.cs:249
		public RelatedResources_Accessor RelatedResources { get ; protected set; }                                                                // CSDefineComposition.cs:249
		public Recommendations_Accessor Recommendations { get ; protected set; }                                                                  // CSDefineComposition.cs:249
		//- Fields

		/// <summary>
		/// No parameters constructor.
		// Caller must call Create();
		/// </summary>
		public BreastRadComposition() : base()
		{
		}

		/// <summary>
		/// Parametersize constructur.
		/// User must not call Create().
		/// </summary>
		public BreastRadComposition(BreastRadiologyDocument doc, Composition resource)
		{
			this.Create(doc, resource);
		}

		/// <summary>
		/// Parametersize constructur.
		/// User must not call Create().
		/// </summary>
		public BreastRadComposition(BreastRadiologyDocument doc)
		{
		this.Create(doc, new Composition());
		}

		/// <summary>
		/// Init object.
		/// </summary>
		public void Create(BreastRadiologyDocument doc, Composition resource)
		{
			base.Create(doc, resource);
			//+ Constructor
			this.Report = new Report_Accessor(doc);                                                                                                  // CSDefineComposition.cs:252
			this.Impressions = new Impressions_Accessor(doc);                                                                                        // CSDefineComposition.cs:252
			this.RelatedResources = new RelatedResources_Accessor(doc);                                                                              // CSDefineComposition.cs:252
			this.Recommendations = new Recommendations_Accessor(doc);                                                                                // CSDefineComposition.cs:252
			//- Constructor
		}

		public override void Write()
		{
		//+ WriteCode
		ClearSection();                                                                                                                           // CSDefineComposition.cs:209
		this.WriteSection(this.Report);                                                                                                           // CSDefineComposition.cs:260
		this.WriteSection(this.Impressions);                                                                                                      // CSDefineComposition.cs:260
		this.WriteSection(this.RelatedResources);                                                                                                 // CSDefineComposition.cs:260
		this.WriteSection(this.Recommendations);                                                                                                  // CSDefineComposition.cs:260
		//- WriteCode
		}

		public override void Read()
		{
		//+ ReadCode
		this.ReadSection(this.Report);                                                                                                            // CSDefineComposition.cs:264
		this.ReadSection(this.Impressions);                                                                                                       // CSDefineComposition.cs:264
		this.ReadSection(this.RelatedResources);                                                                                                  // CSDefineComposition.cs:264
		this.ReadSection(this.Recommendations);                                                                                                   // CSDefineComposition.cs:264
		//- ReadCode
		}

		//+ Methods
		//- Methods
	}
}
