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
	    // Properties                                                                                                                          // CSDefineComposition.cs:45
	    /// <summary>
	    /// Access propertyName
	    /// </summary>
	    public BreastRadReport Get => this.FirstOrDefault();                                                                                   // CSDefineComposition.cs:89
	                                                                                                                                           // CSDefineComposition.cs:47
	    // Methods                                                                                                                             // CSDefineComposition.cs:48
	                                                                                                                                           // CSDefineComposition.cs:67
	    /// <summary>
	    /// Create new blank Report if one doesnt already exist, and return it
	    /// </summary>
	    public BreastRadReport Create => DoCreate();                                                                                           // CSDefineComposition.cs:71
	    private BreastRadReport DoCreate()                                                                                                     // CSDefineComposition.cs:72
	    {                                                                                                                                      // CSDefineComposition.cs:73
	        if (this.Count == 0)                                                                                                               // CSDefineComposition.cs:74
	        {                                                                                                                                  // CSDefineComposition.cs:75
	            BreastRadReport brItem = new BreastRadReport();                                                                                // CSDefineComposition.cs:76
	            brItem.Init(this.doc);                                                                                                         // CSDefineComposition.cs:77
	            this.AppendItem(brItem);                                                                                                       // CSDefineComposition.cs:78
	        }                                                                                                                                  // CSDefineComposition.cs:79
	        return this.First();                                                                                                               // CSDefineComposition.cs:80
	    }                                                                                                                                      // CSDefineComposition.cs:81
	                                                                                                                                           // CSDefineComposition.cs:50
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public Report_Accessor(BreastRadiologyDocument doc) : base()                                                                           // CSDefineComposition.cs:54
	    {                                                                                                                                      // CSDefineComposition.cs:55
	        this.Init(doc, "Breast Radiology Report", 1, 1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes", "sectionReport"));// CSDefineComposition.cs:56
	    }                                                                                                                                      // CSDefineComposition.cs:58
	}                                                                                                                                          // CSDefineComposition.cs:59
	/// <summary>
	/// Accessor class for 'Clinical Impressions'
	/// [Fhir Element 'Composition.section:impressions]'
	/// </summary>
	public class Impressions_Accessor : SectionBase<ResourceBase>                                                                              // CSDefineComposition.cs:43
	{                                                                                                                                          // CSDefineComposition.cs:44
	    // Properties                                                                                                                          // CSDefineComposition.cs:45
	    /// <summary>
	    /// Access propertyName
	    /// </summary>
	    public IEnumerable<ResourceBase> Items => this.items;                                                                                  // CSDefineComposition.cs:139
	                                                                                                                                           // CSDefineComposition.cs:141
	    /// <summary>
	    /// Access item at indicated location in list
	    /// </summary>
	    public ResourceBase At(Int32 i) => base.items[i];                                                                                      // CSDefineComposition.cs:145
	                                                                                                                                           // CSDefineComposition.cs:147
	    /// <summary>
	    /// Access first item in list
	    /// </summary>
	    public new ResourceBase First() => base.First();                                                                                       // CSDefineComposition.cs:151
	                                                                                                                                           // CSDefineComposition.cs:152
	    /// <summary>
	    /// Access first item in list or default value if empty
	    /// </summary>
	    public new ResourceBase FirstOrDefault() => base.FirstOrDefault();                                                                     // CSDefineComposition.cs:156
	                                                                                                                                           // CSDefineComposition.cs:47
	    // Methods                                                                                                                             // CSDefineComposition.cs:48
	                                                                                                                                           // CSDefineComposition.cs:114
	    /// <summary>
	    /// Create new blank Impressions of type ClinicalImpression and add to end of list
	    /// </summary>
	    //If: C:\Development\HL7\BreastRadiologyLibrary\Projects\FireFragger\FireFragger\CS\CSDefineComposition.cs 119                         // CodeBlockNested.cs:588
	    public ResourceBase Append(Resource r)                                                                                                 // CSDefineComposition.cs:120
	    {                                                                                                                                      // CSDefineComposition.cs:123
	        ResourceBase brItem = new ResourceBase();                                                                                          // CSDefineComposition.cs:124
	        //If: C:\Development\HL7\BreastRadiologyLibrary\Projects\FireFragger\FireFragger\CS\CSDefineComposition.cs 125                     // CodeBlockNested.cs:588
	        brItem.Init(this.doc, r);                                                                                                          // CSDefineComposition.cs:126
	        this.AppendItem(brItem);                                                                                                           // CSDefineComposition.cs:129
	        return brItem;                                                                                                                     // CSDefineComposition.cs:130
	    }                                                                                                                                      // CSDefineComposition.cs:131
	                                                                                                                                           // CSDefineComposition.cs:50
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public Impressions_Accessor(BreastRadiologyDocument doc) : base()                                                                      // CSDefineComposition.cs:54
	    {                                                                                                                                      // CSDefineComposition.cs:55
	        this.Init(doc, "Clinical Impressions", 0, -1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes", "sectionImpressions"));// CSDefineComposition.cs:56
	    }                                                                                                                                      // CSDefineComposition.cs:58
	}                                                                                                                                          // CSDefineComposition.cs:59
	/// <summary>
	/// Accessor class for 'Findings Right Breast'
	/// [Fhir Element 'Composition.section:findingsRightBreast]'
	/// </summary>
	public class FindingsRightBreast_Accessor : SectionBase<SectionFindingsRightBreast>                                                        // CSDefineComposition.cs:43
	{                                                                                                                                          // CSDefineComposition.cs:44
	    // Properties                                                                                                                          // CSDefineComposition.cs:45
	    /// <summary>
	    /// Access propertyName
	    /// </summary>
	    public SectionFindingsRightBreast Get => this.FirstOrDefault();                                                                        // CSDefineComposition.cs:89
	                                                                                                                                           // CSDefineComposition.cs:47
	    // Methods                                                                                                                             // CSDefineComposition.cs:48
	                                                                                                                                           // CSDefineComposition.cs:67
	    /// <summary>
	    /// Create new blank FindingsRightBreast if one doesnt already exist, and return it
	    /// </summary>
	    public SectionFindingsRightBreast Create => DoCreate();                                                                                // CSDefineComposition.cs:71
	    private SectionFindingsRightBreast DoCreate()                                                                                          // CSDefineComposition.cs:72
	    {                                                                                                                                      // CSDefineComposition.cs:73
	        if (this.Count == 0)                                                                                                               // CSDefineComposition.cs:74
	        {                                                                                                                                  // CSDefineComposition.cs:75
	            SectionFindingsRightBreast brItem = new SectionFindingsRightBreast();                                                          // CSDefineComposition.cs:76
	            brItem.Init(this.doc);                                                                                                         // CSDefineComposition.cs:77
	            this.AppendItem(brItem);                                                                                                       // CSDefineComposition.cs:78
	        }                                                                                                                                  // CSDefineComposition.cs:79
	        return this.First();                                                                                                               // CSDefineComposition.cs:80
	    }                                                                                                                                      // CSDefineComposition.cs:81
	                                                                                                                                           // CSDefineComposition.cs:50
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public FindingsRightBreast_Accessor(BreastRadiologyDocument doc) : base()                                                              // CSDefineComposition.cs:54
	    {                                                                                                                                      // CSDefineComposition.cs:55
	        this.Init(doc, "Findings Right Breast", 0, 1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes", "sectionCodeFindingsRightBreast"));// CSDefineComposition.cs:56
	    }                                                                                                                                      // CSDefineComposition.cs:58
	}                                                                                                                                          // CSDefineComposition.cs:59
	/// <summary>
	/// Accessor class for 'Findings Left Breast'
	/// [Fhir Element 'Composition.section:findingsLeftBreast]'
	/// </summary>
	public class FindingsLeftBreast_Accessor : SectionBase<SectionFindingsLeftBreast>                                                          // CSDefineComposition.cs:43
	{                                                                                                                                          // CSDefineComposition.cs:44
	    // Properties                                                                                                                          // CSDefineComposition.cs:45
	    /// <summary>
	    /// Access propertyName
	    /// </summary>
	    public SectionFindingsLeftBreast Get => this.FirstOrDefault();                                                                         // CSDefineComposition.cs:89
	                                                                                                                                           // CSDefineComposition.cs:47
	    // Methods                                                                                                                             // CSDefineComposition.cs:48
	                                                                                                                                           // CSDefineComposition.cs:67
	    /// <summary>
	    /// Create new blank FindingsLeftBreast if one doesnt already exist, and return it
	    /// </summary>
	    public SectionFindingsLeftBreast Create => DoCreate();                                                                                 // CSDefineComposition.cs:71
	    private SectionFindingsLeftBreast DoCreate()                                                                                           // CSDefineComposition.cs:72
	    {                                                                                                                                      // CSDefineComposition.cs:73
	        if (this.Count == 0)                                                                                                               // CSDefineComposition.cs:74
	        {                                                                                                                                  // CSDefineComposition.cs:75
	            SectionFindingsLeftBreast brItem = new SectionFindingsLeftBreast();                                                            // CSDefineComposition.cs:76
	            brItem.Init(this.doc);                                                                                                         // CSDefineComposition.cs:77
	            this.AppendItem(brItem);                                                                                                       // CSDefineComposition.cs:78
	        }                                                                                                                                  // CSDefineComposition.cs:79
	        return this.First();                                                                                                               // CSDefineComposition.cs:80
	    }                                                                                                                                      // CSDefineComposition.cs:81
	                                                                                                                                           // CSDefineComposition.cs:50
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public FindingsLeftBreast_Accessor(BreastRadiologyDocument doc) : base()                                                               // CSDefineComposition.cs:54
	    {                                                                                                                                      // CSDefineComposition.cs:55
	        this.Init(doc, "Findings Left Breast", 0, 1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes", "sectionCodeFindingsLeftBreast"));// CSDefineComposition.cs:56
	    }                                                                                                                                      // CSDefineComposition.cs:58
	}                                                                                                                                          // CSDefineComposition.cs:59
	/// <summary>
	/// Accessor class for 'Related Resources'
	/// [Fhir Element 'Composition.section:relatedResources]'
	/// </summary>
	public class RelatedResources_Accessor : SectionBase<ResourceBase>                                                                         // CSDefineComposition.cs:43
	{                                                                                                                                          // CSDefineComposition.cs:44
	    // Properties                                                                                                                          // CSDefineComposition.cs:45
	    /// <summary>
	    /// Access propertyName
	    /// </summary>
	    public IEnumerable<ResourceBase> Items => this.items;                                                                                  // CSDefineComposition.cs:139
	                                                                                                                                           // CSDefineComposition.cs:141
	    /// <summary>
	    /// Access item at indicated location in list
	    /// </summary>
	    public ResourceBase At(Int32 i) => base.items[i];                                                                                      // CSDefineComposition.cs:145
	                                                                                                                                           // CSDefineComposition.cs:147
	    /// <summary>
	    /// Access first item in list
	    /// </summary>
	    public new ResourceBase First() => base.First();                                                                                       // CSDefineComposition.cs:151
	                                                                                                                                           // CSDefineComposition.cs:152
	    /// <summary>
	    /// Access first item in list or default value if empty
	    /// </summary>
	    public new ResourceBase FirstOrDefault() => base.FirstOrDefault();                                                                     // CSDefineComposition.cs:156
	                                                                                                                                           // CSDefineComposition.cs:47
	    // Methods                                                                                                                             // CSDefineComposition.cs:48
	                                                                                                                                           // CSDefineComposition.cs:114
	    /// <summary>
	    /// Create new blank RelatedResources of type Resource and add to end of list
	    /// </summary>
	    //If: C:\Development\HL7\BreastRadiologyLibrary\Projects\FireFragger\FireFragger\CS\CSDefineComposition.cs 119                         // CodeBlockNested.cs:588
	    public ResourceBase Append(Resource r)                                                                                                 // CSDefineComposition.cs:120
	    {                                                                                                                                      // CSDefineComposition.cs:123
	        ResourceBase brItem = new ResourceBase();                                                                                          // CSDefineComposition.cs:124
	        //If: C:\Development\HL7\BreastRadiologyLibrary\Projects\FireFragger\FireFragger\CS\CSDefineComposition.cs 125                     // CodeBlockNested.cs:588
	        brItem.Init(this.doc, r);                                                                                                          // CSDefineComposition.cs:126
	        this.AppendItem(brItem);                                                                                                           // CSDefineComposition.cs:129
	        return brItem;                                                                                                                     // CSDefineComposition.cs:130
	    }                                                                                                                                      // CSDefineComposition.cs:131
	                                                                                                                                           // CSDefineComposition.cs:50
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public RelatedResources_Accessor(BreastRadiologyDocument doc) : base()                                                                 // CSDefineComposition.cs:54
	    {                                                                                                                                      // CSDefineComposition.cs:55
	        this.Init(doc, "Related Resources", 0, -1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes", "sectionRelatedResources"));// CSDefineComposition.cs:56
	    }                                                                                                                                      // CSDefineComposition.cs:58
	}                                                                                                                                          // CSDefineComposition.cs:59
	/// <summary>
	/// Accessor class for 'Recommendations'
	/// [Fhir Element 'Composition.section:recommendations]'
	/// </summary>
	public class Recommendations_Accessor : SectionBase<ResourceBase>                                                                          // CSDefineComposition.cs:43
	{                                                                                                                                          // CSDefineComposition.cs:44
	    // Properties                                                                                                                          // CSDefineComposition.cs:45
	    /// <summary>
	    /// Access propertyName
	    /// </summary>
	    public IEnumerable<ResourceBase> Items => this.items;                                                                                  // CSDefineComposition.cs:139
	                                                                                                                                           // CSDefineComposition.cs:141
	    /// <summary>
	    /// Access item at indicated location in list
	    /// </summary>
	    public ResourceBase At(Int32 i) => base.items[i];                                                                                      // CSDefineComposition.cs:145
	                                                                                                                                           // CSDefineComposition.cs:147
	    /// <summary>
	    /// Access first item in list
	    /// </summary>
	    public new ResourceBase First() => base.First();                                                                                       // CSDefineComposition.cs:151
	                                                                                                                                           // CSDefineComposition.cs:152
	    /// <summary>
	    /// Access first item in list or default value if empty
	    /// </summary>
	    public new ResourceBase FirstOrDefault() => base.FirstOrDefault();                                                                     // CSDefineComposition.cs:156
	                                                                                                                                           // CSDefineComposition.cs:47
	    // Methods                                                                                                                             // CSDefineComposition.cs:48
	                                                                                                                                           // CSDefineComposition.cs:114
	    /// <summary>
	    /// Create new blank Recommendations of type MedicationRequest and add to end of list
	    /// </summary>
	    //If: C:\Development\HL7\BreastRadiologyLibrary\Projects\FireFragger\FireFragger\CS\CSDefineComposition.cs 119                         // CodeBlockNested.cs:588
	    public ResourceBase AppendMedicationRequest(Resource r)                                                                                // CSDefineComposition.cs:120
	    {                                                                                                                                      // CSDefineComposition.cs:123
	        ResourceBase brItem = new ResourceBase();                                                                                          // CSDefineComposition.cs:124
	        //If: C:\Development\HL7\BreastRadiologyLibrary\Projects\FireFragger\FireFragger\CS\CSDefineComposition.cs 125                     // CodeBlockNested.cs:588
	        brItem.Init(this.doc, r);                                                                                                          // CSDefineComposition.cs:126
	        this.AppendItem(brItem);                                                                                                           // CSDefineComposition.cs:129
	        return brItem;                                                                                                                     // CSDefineComposition.cs:130
	    }                                                                                                                                      // CSDefineComposition.cs:131
	                                                                                                                                           // CSDefineComposition.cs:114
	    /// <summary>
	    /// Create new blank Recommendations of type ServiceRequest and add to end of list
	    /// </summary>
	    //If: C:\Development\HL7\BreastRadiologyLibrary\Projects\FireFragger\FireFragger\CS\CSDefineComposition.cs 119                         // CodeBlockNested.cs:588
	    public ResourceBase AppendServiceRequest(Resource r)                                                                                   // CSDefineComposition.cs:120
	    {                                                                                                                                      // CSDefineComposition.cs:123
	        ResourceBase brItem = new ResourceBase();                                                                                          // CSDefineComposition.cs:124
	        //If: C:\Development\HL7\BreastRadiologyLibrary\Projects\FireFragger\FireFragger\CS\CSDefineComposition.cs 125                     // CodeBlockNested.cs:588
	        brItem.Init(this.doc, r);                                                                                                          // CSDefineComposition.cs:126
	        this.AppendItem(brItem);                                                                                                           // CSDefineComposition.cs:129
	        return brItem;                                                                                                                     // CSDefineComposition.cs:130
	    }                                                                                                                                      // CSDefineComposition.cs:131
	                                                                                                                                           // CSDefineComposition.cs:114
	    /// <summary>
	    /// Create new blank Recommendations of type ServiceRequest and add to end of list
	    /// </summary>
	    //Else: C:\Development\HL7\BreastRadiologyLibrary\Projects\FireFragger\FireFragger\CS\CSDefineComposition.cs 119                       // CodeBlockNested.cs:594
	    public ServiceRecommendation AppendServiceRecommendation()                                                                             // CSDefineComposition.cs:121
	    {                                                                                                                                      // CSDefineComposition.cs:123
	        ServiceRecommendation brItem = new ServiceRecommendation();                                                                        // CSDefineComposition.cs:124
	        //Else: C:\Development\HL7\BreastRadiologyLibrary\Projects\FireFragger\FireFragger\CS\CSDefineComposition.cs 125                   // CodeBlockNested.cs:594
	        brItem.Init(this.doc);                                                                                                             // CSDefineComposition.cs:127
	        this.AppendItem(brItem);                                                                                                           // CSDefineComposition.cs:129
	        return brItem;                                                                                                                     // CSDefineComposition.cs:130
	    }                                                                                                                                      // CSDefineComposition.cs:131
	                                                                                                                                           // CSDefineComposition.cs:50
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public Recommendations_Accessor(BreastRadiologyDocument doc) : base()                                                                  // CSDefineComposition.cs:54
	    {                                                                                                                                      // CSDefineComposition.cs:55
	        this.Init(doc, "Recommendations", 0, -1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes", "sectionCodeRecommendations"));// CSDefineComposition.cs:56
	    }                                                                                                                                      // CSDefineComposition.cs:58
	}                                                                                                                                          // CSDefineComposition.cs:59
	//- LocalClassDefs
}
