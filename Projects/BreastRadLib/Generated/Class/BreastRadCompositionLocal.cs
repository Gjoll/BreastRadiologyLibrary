using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.CompositionLocal;

namespace BreastRadLib.BreastRadCompositionLocal
{
	//+ LocalClassDefs
	/// <summary>
	/// Accessor class for 'Breast Radiology Report'
	/// [Fhir Element 'Composition.section:report]'
	/// </summary>
	public class Report_Accessor : SectionBase<BreastRadReport>                                                                                // CSDefineComposition.cs:43
	{                                                                                                                                          // CSDefineComposition.cs:44
	    // Properties                                                                                                                          // CSDefineComposition.cs:50
	    /// <summary>
	    /// Access propertyName
	    /// </summary>
	    public BreastRadReport Get => this.FirstOrDefault();                                                                                   // CSDefineComposition.cs:100
	                                                                                                                                           // CSDefineComposition.cs:52
	    // Methods                                                                                                                             // CSDefineComposition.cs:53
	                                                                                                                                           // CSDefineComposition.cs:78
	    /// <summary>
	    /// Create new blank Report if one doesnt already exist, and return it
	    /// </summary>
	    public BreastRadReport Create => DoCreate();                                                                                           // CSDefineComposition.cs:82
	    private BreastRadReport DoCreate()                                                                                                     // CSDefineComposition.cs:83
	    {                                                                                                                                      // CSDefineComposition.cs:84
	        if (this.Count == 0)                                                                                                               // CSDefineComposition.cs:85
	        {                                                                                                                                  // CSDefineComposition.cs:86
	            BreastRadReport brItem = new BreastRadReport();                                                                                // CSDefineComposition.cs:87
	            brItem.Init(this.doc);                                                                                                         // CSDefineComposition.cs:88
	            this.AppendItem(brItem);                                                                                                       // CSDefineComposition.cs:89
	        }                                                                                                                                  // CSDefineComposition.cs:90
	        return this.First();                                                                                                               // CSDefineComposition.cs:91
	    }                                                                                                                                      // CSDefineComposition.cs:92
	                                                                                                                                           // CSDefineComposition.cs:55
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public Report_Accessor(BreastRadiologyDocument doc) : base()                                                                           // CSDefineComposition.cs:59
	    {                                                                                                                                      // CSDefineComposition.cs:60
	        this.Init(doc, "Breast Radiology Report", 1, 1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes", "sectionReport"));// CSDefineComposition.cs:61
	    }                                                                                                                                      // CSDefineComposition.cs:63
	}                                                                                                                                          // CSDefineComposition.cs:64
	/// <summary>
	/// Accessor class for 'Clinical Impressions'
	/// [Fhir Element 'Composition.section:impressions]'
	/// </summary>
	public class Impressions_Accessor : SectionBase<ResourceBase>                                                                              // CSDefineComposition.cs:43
	{                                                                                                                                          // CSDefineComposition.cs:44
	    // Properties                                                                                                                          // CSDefineComposition.cs:50
	    /// <summary>
	    /// Access propertyName
	    /// </summary>
	    public IEnumerable<ResourceBase> Items => this.items;                                                                                  // CSDefineComposition.cs:126
	                                                                                                                                           // CSDefineComposition.cs:127
	    /// <summary>
	    /// Access first item in list
	    /// </summary>
	    public new ResourceBase First() => base.First();                                                                                       // CSDefineComposition.cs:131
	                                                                                                                                           // CSDefineComposition.cs:132
	    /// <summary>
	    /// Access first item in list or default value if empty
	    /// </summary>
	    public new ResourceBase FirstOrDefault() => base.FirstOrDefault();                                                                     // CSDefineComposition.cs:136
	                                                                                                                                           // CSDefineComposition.cs:52
	    // Methods                                                                                                                             // CSDefineComposition.cs:53
	                                                                                                                                           // CSDefineComposition.cs:145
	    /// <summary>
	    /// Create new blank Impressions of type ClinicalImpression and add to end of list
	    /// </summary>
	    public ResourceBase AddClinicalImpression(ClinicalImpression fhirItem = null)                                                          // CSDefineComposition.cs:161
	    {                                                                                                                                      // CSDefineComposition.cs:162
	        if (fhirItem == null) fhirItem = new ClinicalImpression();                                                                         // CSDefineComposition.cs:163
	        ResourceBase brItem = new ResourceBase();                                                                                          // CSDefineComposition.cs:167
	        brItem.Init(this.doc, fhirItem);                                                                                                 // CSDefineComposition.cs:168
	        this.AppendItem(brItem);                                                                                                           // CSDefineComposition.cs:169
	        return brItem;                                                                                                                     // CSDefineComposition.cs:170
	    }                                                                                                                                      // CSDefineComposition.cs:171
	                                                                                                                                           // CSDefineComposition.cs:55
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public Impressions_Accessor(BreastRadiologyDocument doc) : base()                                                                      // CSDefineComposition.cs:59
	    {                                                                                                                                      // CSDefineComposition.cs:60
	        this.Init(doc, "Clinical Impressions", 0, -1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes", "sectionImpressions"));// CSDefineComposition.cs:61
	    }                                                                                                                                      // CSDefineComposition.cs:63
	}                                                                                                                                          // CSDefineComposition.cs:64
	/// <summary>
	/// Accessor class for 'Findings Right Breast'
	/// [Fhir Element 'Composition.section:findingsRightBreast]'
	/// </summary>
	public class FindingsRightBreast_Accessor : SectionBase<SectionFindingsRightBreast>                                                        // CSDefineComposition.cs:43
	{                                                                                                                                          // CSDefineComposition.cs:44
	    // Properties                                                                                                                          // CSDefineComposition.cs:50
	    /// <summary>
	    /// Access propertyName
	    /// </summary>
	    public SectionFindingsRightBreast Get => this.FirstOrDefault();                                                                        // CSDefineComposition.cs:100
	                                                                                                                                           // CSDefineComposition.cs:52
	    // Methods                                                                                                                             // CSDefineComposition.cs:53
	                                                                                                                                           // CSDefineComposition.cs:78
	    /// <summary>
	    /// Create new blank FindingsRightBreast if one doesnt already exist, and return it
	    /// </summary>
	    public SectionFindingsRightBreast Create => DoCreate();                                                                                // CSDefineComposition.cs:82
	    private SectionFindingsRightBreast DoCreate()                                                                                          // CSDefineComposition.cs:83
	    {                                                                                                                                      // CSDefineComposition.cs:84
	        if (this.Count == 0)                                                                                                               // CSDefineComposition.cs:85
	        {                                                                                                                                  // CSDefineComposition.cs:86
	            SectionFindingsRightBreast brItem = new SectionFindingsRightBreast();                                                          // CSDefineComposition.cs:87
	            brItem.Init(this.doc);                                                                                                         // CSDefineComposition.cs:88
	            this.AppendItem(brItem);                                                                                                       // CSDefineComposition.cs:89
	        }                                                                                                                                  // CSDefineComposition.cs:90
	        return this.First();                                                                                                               // CSDefineComposition.cs:91
	    }                                                                                                                                      // CSDefineComposition.cs:92
	                                                                                                                                           // CSDefineComposition.cs:55
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public FindingsRightBreast_Accessor(BreastRadiologyDocument doc) : base()                                                              // CSDefineComposition.cs:59
	    {                                                                                                                                      // CSDefineComposition.cs:60
	        this.Init(doc, "Findings Right Breast", 0, 1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes", "sectionCodeFindingsRightBreast"));// CSDefineComposition.cs:61
	    }                                                                                                                                      // CSDefineComposition.cs:63
	}                                                                                                                                          // CSDefineComposition.cs:64
	/// <summary>
	/// Accessor class for 'Findings Left Breast'
	/// [Fhir Element 'Composition.section:findingsLeftBreast]'
	/// </summary>
	public class FindingsLeftBreast_Accessor : SectionBase<SectionFindingsLeftBreast>                                                          // CSDefineComposition.cs:43
	{                                                                                                                                          // CSDefineComposition.cs:44
	    // Properties                                                                                                                          // CSDefineComposition.cs:50
	    /// <summary>
	    /// Access propertyName
	    /// </summary>
	    public SectionFindingsLeftBreast Get => this.FirstOrDefault();                                                                         // CSDefineComposition.cs:100
	                                                                                                                                           // CSDefineComposition.cs:52
	    // Methods                                                                                                                             // CSDefineComposition.cs:53
	                                                                                                                                           // CSDefineComposition.cs:78
	    /// <summary>
	    /// Create new blank FindingsLeftBreast if one doesnt already exist, and return it
	    /// </summary>
	    public SectionFindingsLeftBreast Create => DoCreate();                                                                                 // CSDefineComposition.cs:82
	    private SectionFindingsLeftBreast DoCreate()                                                                                           // CSDefineComposition.cs:83
	    {                                                                                                                                      // CSDefineComposition.cs:84
	        if (this.Count == 0)                                                                                                               // CSDefineComposition.cs:85
	        {                                                                                                                                  // CSDefineComposition.cs:86
	            SectionFindingsLeftBreast brItem = new SectionFindingsLeftBreast();                                                            // CSDefineComposition.cs:87
	            brItem.Init(this.doc);                                                                                                         // CSDefineComposition.cs:88
	            this.AppendItem(brItem);                                                                                                       // CSDefineComposition.cs:89
	        }                                                                                                                                  // CSDefineComposition.cs:90
	        return this.First();                                                                                                               // CSDefineComposition.cs:91
	    }                                                                                                                                      // CSDefineComposition.cs:92
	                                                                                                                                           // CSDefineComposition.cs:55
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public FindingsLeftBreast_Accessor(BreastRadiologyDocument doc) : base()                                                               // CSDefineComposition.cs:59
	    {                                                                                                                                      // CSDefineComposition.cs:60
	        this.Init(doc, "Findings Left Breast", 0, 1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes", "sectionCodeFindingsLeftBreast"));// CSDefineComposition.cs:61
	    }                                                                                                                                      // CSDefineComposition.cs:63
	}                                                                                                                                          // CSDefineComposition.cs:64
	/// <summary>
	/// Accessor class for 'Related Resources'
	/// [Fhir Element 'Composition.section:relatedResources]'
	/// </summary>
	public class RelatedResources_Accessor : SectionBase<ResourceBase>                                                                         // CSDefineComposition.cs:43
	{                                                                                                                                          // CSDefineComposition.cs:44
	    // Properties                                                                                                                          // CSDefineComposition.cs:50
	    /// <summary>
	    /// Access propertyName
	    /// </summary>
	    public IEnumerable<ResourceBase> Items => this.items;                                                                                  // CSDefineComposition.cs:126
	                                                                                                                                           // CSDefineComposition.cs:127
	    /// <summary>
	    /// Access first item in list
	    /// </summary>
	    public new ResourceBase First() => base.First();                                                                                       // CSDefineComposition.cs:131
	                                                                                                                                           // CSDefineComposition.cs:132
	    /// <summary>
	    /// Access first item in list or default value if empty
	    /// </summary>
	    public new ResourceBase FirstOrDefault() => base.FirstOrDefault();                                                                     // CSDefineComposition.cs:136
	                                                                                                                                           // CSDefineComposition.cs:52
	    // Methods                                                                                                                             // CSDefineComposition.cs:53
	                                                                                                                                           // CSDefineComposition.cs:145
	    /// <summary>
	    /// Create new blank RelatedResources of type Resource and add to end of list
	    /// </summary>
	    public ResourceBase AddResource(Resource fhirItem)                                                                                     // CSDefineComposition.cs:154
	    {                                                                                                                                      // CSDefineComposition.cs:155
	        ResourceBase brItem = new ResourceBase();                                                                                          // CSDefineComposition.cs:167
	        brItem.Init(this.doc, fhirItem);                                                                                                 // CSDefineComposition.cs:168
	        this.AppendItem(brItem);                                                                                                           // CSDefineComposition.cs:169
	        return brItem;                                                                                                                     // CSDefineComposition.cs:170
	    }                                                                                                                                      // CSDefineComposition.cs:171
	                                                                                                                                           // CSDefineComposition.cs:55
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public RelatedResources_Accessor(BreastRadiologyDocument doc) : base()                                                                 // CSDefineComposition.cs:59
	    {                                                                                                                                      // CSDefineComposition.cs:60
	        this.Init(doc, "Related Resources", 0, -1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes", "sectionRelatedResources"));// CSDefineComposition.cs:61
	    }                                                                                                                                      // CSDefineComposition.cs:63
	}                                                                                                                                          // CSDefineComposition.cs:64
	/// <summary>
	/// Accessor class for 'Recommendations'
	/// [Fhir Element 'Composition.section:recommendations]'
	/// </summary>
	public class Recommendations_Accessor : SectionBase<ResourceBase>                                                                          // CSDefineComposition.cs:43
	{                                                                                                                                          // CSDefineComposition.cs:44
	    // Properties                                                                                                                          // CSDefineComposition.cs:50
	    /// <summary>
	    /// Access propertyName
	    /// </summary>
	    public IEnumerable<ResourceBase> Items => this.items;                                                                                  // CSDefineComposition.cs:126
	                                                                                                                                           // CSDefineComposition.cs:127
	    /// <summary>
	    /// Access first item in list
	    /// </summary>
	    public new ResourceBase First() => base.First();                                                                                       // CSDefineComposition.cs:131
	                                                                                                                                           // CSDefineComposition.cs:132
	    /// <summary>
	    /// Access first item in list or default value if empty
	    /// </summary>
	    public new ResourceBase FirstOrDefault() => base.FirstOrDefault();                                                                     // CSDefineComposition.cs:136
	                                                                                                                                           // CSDefineComposition.cs:52
	    // Methods                                                                                                                             // CSDefineComposition.cs:53
	                                                                                                                                           // CSDefineComposition.cs:145
	    /// <summary>
	    /// Create new blank Recommendations of type MedicationRequest and add to end of list
	    /// </summary>
	    public ResourceBase AddMedicationRequest(MedicationRequest fhirItem = null)                                                            // CSDefineComposition.cs:161
	    {                                                                                                                                      // CSDefineComposition.cs:162
	        if (fhirItem == null) fhirItem = new MedicationRequest();                                                                          // CSDefineComposition.cs:163
	        ResourceBase brItem = new ResourceBase();                                                                                          // CSDefineComposition.cs:167
	        brItem.Init(this.doc, fhirItem);                                                                                                 // CSDefineComposition.cs:168
	        this.AppendItem(brItem);                                                                                                           // CSDefineComposition.cs:169
	        return brItem;                                                                                                                     // CSDefineComposition.cs:170
	    }                                                                                                                                      // CSDefineComposition.cs:171
	                                                                                                                                           // CSDefineComposition.cs:145
	    /// <summary>
	    /// Create new blank Recommendations of type ServiceRequest and add to end of list
	    /// </summary>
	    public ResourceBase AddServiceRequest(ServiceRequest fhirItem = null)                                                                  // CSDefineComposition.cs:161
	    {                                                                                                                                      // CSDefineComposition.cs:162
	        if (fhirItem == null) fhirItem = new ServiceRequest();                                                                             // CSDefineComposition.cs:163
	        ResourceBase brItem = new ResourceBase();                                                                                          // CSDefineComposition.cs:167
	        brItem.Init(this.doc, fhirItem);                                                                                                 // CSDefineComposition.cs:168
	        this.AppendItem(brItem);                                                                                                           // CSDefineComposition.cs:169
	        return brItem;                                                                                                                     // CSDefineComposition.cs:170
	    }                                                                                                                                      // CSDefineComposition.cs:171
	                                                                                                                                           // CSDefineComposition.cs:145
	    /// <summary>
	    /// Create new blank Recommendations of type ServiceRequest and add to end of list
	    /// </summary>
	    public ServiceRecommendation AddServiceRecommendation(ServiceRequest fhirItem = null)                                                  // CSDefineComposition.cs:161
	    {                                                                                                                                      // CSDefineComposition.cs:162
	        if (fhirItem == null) fhirItem = new ServiceRequest();                                                                             // CSDefineComposition.cs:163
	        ServiceRecommendation brItem = new ServiceRecommendation();                                                                        // CSDefineComposition.cs:167
	        brItem.Init(this.doc, fhirItem);                                                                                                 // CSDefineComposition.cs:168
	        this.AppendItem(brItem);                                                                                                           // CSDefineComposition.cs:169
	        return brItem;                                                                                                                     // CSDefineComposition.cs:170
	    }                                                                                                                                      // CSDefineComposition.cs:171
	                                                                                                                                           // CSDefineComposition.cs:55
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public Recommendations_Accessor(BreastRadiologyDocument doc) : base()                                                                  // CSDefineComposition.cs:59
	    {                                                                                                                                      // CSDefineComposition.cs:60
	        this.Init(doc, "Recommendations", 0, -1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes", "sectionCodeRecommendations"));// CSDefineComposition.cs:61
	    }                                                                                                                                      // CSDefineComposition.cs:63
	}                                                                                                                                          // CSDefineComposition.cs:64
	//- LocalClassDefs
}
