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
		    public BreastRadReport CreateBreastRadReport(DiagnosticReport fhirItem)                                                               // CSDefineComposition.cs:112
		    {                                                                                                                                     // CSDefineComposition.cs:113
		        BreastRadReport brItem = new BreastRadReport();                                                                                   // CSDefineComposition.cs:114
		        brItem.Create(this.doc, fhirItem);                                                                                                // CSDefineComposition.cs:115
		        this.AppendItem(brItem);                                                                                                          // CSDefineComposition.cs:116
		        return brItem;                                                                                                                    // CSDefineComposition.cs:117
		    }                                                                                                                                     // CSDefineComposition.cs:118
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
		    public IEnumerable<ResourceBase> Items => this.items;                                                                                 // CSDefineComposition.cs:128
		                                                                                                                                          // CSDefineComposition.cs:69
		    // Methods                                                                                                                            // CSDefineComposition.cs:70
		                                                                                                                                          // CSDefineComposition.cs:137
		    /// <summary>
		    /// Create new blank Impressions of type ClinicalImpression and add to end of list
		    /// </summary>
		    public ResourceBase AddClinicalImpression(ClinicalImpression fhirItem)                                                                // CSDefineComposition.cs:141
		    {                                                                                                                                     // CSDefineComposition.cs:142
		        ResourceBase brItem = new ResourceBase();                                                                                         // CSDefineComposition.cs:143
		        brItem.Create(this.doc, fhirItem);                                                                                                // CSDefineComposition.cs:144
		        this.AppendItem(brItem);                                                                                                          // CSDefineComposition.cs:145
		        return brItem;                                                                                                                    // CSDefineComposition.cs:146
		    }                                                                                                                                     // CSDefineComposition.cs:147
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
		    public IEnumerable<ResourceBase> Items => this.items;                                                                                 // CSDefineComposition.cs:128
		                                                                                                                                          // CSDefineComposition.cs:69
		    // Methods                                                                                                                            // CSDefineComposition.cs:70
		                                                                                                                                          // CSDefineComposition.cs:137
		    /// <summary>
		    /// Create new blank RelatedResources of type Resource and add to end of list
		    /// </summary>
		    public ResourceBase AddResource(Resource fhirItem)                                                                                    // CSDefineComposition.cs:141
		    {                                                                                                                                     // CSDefineComposition.cs:142
		        ResourceBase brItem = new ResourceBase();                                                                                         // CSDefineComposition.cs:143
		        brItem.Create(this.doc, fhirItem);                                                                                                // CSDefineComposition.cs:144
		        this.AppendItem(brItem);                                                                                                          // CSDefineComposition.cs:145
		        return brItem;                                                                                                                    // CSDefineComposition.cs:146
		    }                                                                                                                                     // CSDefineComposition.cs:147
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
		    public IEnumerable<ResourceBase> Items => this.items;                                                                                 // CSDefineComposition.cs:128
		                                                                                                                                          // CSDefineComposition.cs:69
		    // Methods                                                                                                                            // CSDefineComposition.cs:70
		                                                                                                                                          // CSDefineComposition.cs:137
		    /// <summary>
		    /// Create new blank Recommendations of type MedicationRequest and add to end of list
		    /// </summary>
		    public ResourceBase AddMedicationRequest(MedicationRequest fhirItem)                                                                  // CSDefineComposition.cs:141
		    {                                                                                                                                     // CSDefineComposition.cs:142
		        ResourceBase brItem = new ResourceBase();                                                                                         // CSDefineComposition.cs:143
		        brItem.Create(this.doc, fhirItem);                                                                                                // CSDefineComposition.cs:144
		        this.AppendItem(brItem);                                                                                                          // CSDefineComposition.cs:145
		        return brItem;                                                                                                                    // CSDefineComposition.cs:146
		    }                                                                                                                                     // CSDefineComposition.cs:147
		                                                                                                                                          // CSDefineComposition.cs:137
		    /// <summary>
		    /// Create new blank Recommendations of type ServiceRequest and add to end of list
		    /// </summary>
		    public ResourceBase AddServiceRequest(ServiceRequest fhirItem)                                                                        // CSDefineComposition.cs:141
		    {                                                                                                                                     // CSDefineComposition.cs:142
		        ResourceBase brItem = new ResourceBase();                                                                                         // CSDefineComposition.cs:143
		        brItem.Create(this.doc, fhirItem);                                                                                                // CSDefineComposition.cs:144
		        this.AppendItem(brItem);                                                                                                          // CSDefineComposition.cs:145
		        return brItem;                                                                                                                    // CSDefineComposition.cs:146
		    }                                                                                                                                     // CSDefineComposition.cs:147
		                                                                                                                                          // CSDefineComposition.cs:137
		    /// <summary>
		    /// Create new blank Recommendations of type ServiceRequest and add to end of list
		    /// </summary>
		    public ResourceBase AddServiceRecommendation(ServiceRequest fhirItem)                                                                 // CSDefineComposition.cs:141
		    {                                                                                                                                     // CSDefineComposition.cs:142
		        ServiceRecommendation brItem = new ServiceRecommendation();                                                                       // CSDefineComposition.cs:143
		        brItem.Create(this.doc, fhirItem);                                                                                                // CSDefineComposition.cs:144
		        this.AppendItem(brItem);                                                                                                          // CSDefineComposition.cs:145
		        return brItem;                                                                                                                    // CSDefineComposition.cs:146
		    }                                                                                                                                     // CSDefineComposition.cs:147
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
		public Report_Accessor Report { get ; protected set; }                                                                                    // CSDefineComposition.cs:208
		public Impressions_Accessor Impressions { get ; protected set; }                                                                          // CSDefineComposition.cs:208
		public RelatedResources_Accessor RelatedResources { get ; protected set; }                                                                // CSDefineComposition.cs:208
		public Recommendations_Accessor Recommendations { get ; protected set; }                                                                  // CSDefineComposition.cs:208
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
		public BreastRadComposition(BreastRadiologyDocument doc, Composition resource) : base()
		{
		}

		/// <summary>
		/// Init object.
		/// </summary>
		public void Create(BreastRadiologyDocument doc, Composition resource)
		{
			base.Create(doc, resource);
			//+ Constructor
			this.Report = new Report_Accessor(doc);                                                                                                  // CSDefineComposition.cs:211
			this.Impressions = new Impressions_Accessor(doc);                                                                                        // CSDefineComposition.cs:211
			this.RelatedResources = new RelatedResources_Accessor(doc);                                                                              // CSDefineComposition.cs:211
			this.Recommendations = new Recommendations_Accessor(doc);                                                                                // CSDefineComposition.cs:211
			//- Constructor
		}

		public BreastRadComposition(BreastRadiologyDocument doc) : this(doc, new Composition())
		{
		}

		public override void Write()
		{
		//+ WriteCode
		ClearSection();                                                                                                                           // CSDefineComposition.cs:168
		this.WriteSection(this.Report);                                                                                                           // CSDefineComposition.cs:219
		this.WriteSection(this.Impressions);                                                                                                      // CSDefineComposition.cs:219
		this.WriteSection(this.RelatedResources);                                                                                                 // CSDefineComposition.cs:219
		this.WriteSection(this.Recommendations);                                                                                                  // CSDefineComposition.cs:219
		//- WriteCode
		}

		public override void Read()
		{
		//+ ReadCode
		this.ReadSection(this.Report);                                                                                                            // CSDefineComposition.cs:223
		this.ReadSection(this.Impressions);                                                                                                       // CSDefineComposition.cs:223
		this.ReadSection(this.RelatedResources);                                                                                                  // CSDefineComposition.cs:223
		this.ReadSection(this.Recommendations);                                                                                                   // CSDefineComposition.cs:223
		//- ReadCode
		}

		//+ Methods
		//- Methods
	}
}
