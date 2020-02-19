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
	public class Report_Accessor : MemberListSectionBase<BreastRadReport>                                                                      // CSBuildMemberListSection.cs:46
	{                                                                                                                                          // CSBuildMemberListSection.cs:47
	    /// <summary>
	    /// Access propertyName
	    /// </summary>
	    public BreastRadReport Get() => this.FirstOrDefault();                                                                                 // CSBuildMemberListSection.cs:89
	                                                                                                                                           // CSBuildMemberListSection.cs:68
	    /// <summary>
	    /// Create new blank Report if one doesnt already exist, and return it
	    /// </summary>
	    public BreastRadReport Create()                                                                                                        // CSBuildMemberListSection.cs:72
	    {                                                                                                                                      // CSBuildMemberListSection.cs:73
	        if (this.Count == 0)                                                                                                               // CSBuildMemberListSection.cs:74
	        {                                                                                                                                  // CSBuildMemberListSection.cs:75
	            BreastRadReport brItem = new BreastRadReport();                                                                                // CSBuildMemberListSection.cs:76
	            brItem.Init(this.doc);                                                                                                         // CSBuildMemberListSection.cs:77
	            this.AppendItem(brItem);                                                                                                       // CSBuildMemberListSection.cs:78
	        }                                                                                                                                  // CSBuildMemberListSection.cs:79
	        return this.First();                                                                                                               // CSBuildMemberListSection.cs:80
	    }                                                                                                                                      // CSBuildMemberListSection.cs:81
	                                                                                                                                           // CSBuildMemberListSection.cs:49
	                                                                                                                                           // CSBuildMemberListSection.cs:51
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public Report_Accessor(BreastRadiologyDocument doc) : base("Report_Accessor")                                                          // CSBuildMemberListSection.cs:55
	    {                                                                                                                                      // CSBuildMemberListSection.cs:56
	        this.Init(doc, "Breast Radiology Report", 1, 1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes", "sectionReport"));// CSBuildMemberListSection.cs:57
	    }                                                                                                                                      // CSBuildMemberListSection.cs:59
	}                                                                                                                                          // CSBuildMemberListSection.cs:60
	/// <summary>
	/// Accessor class for 'Clinical Impressions'
	/// [Fhir Element 'Composition.section:impressions]'
	/// </summary>
	public class Impressions_Accessor : MemberListSectionBase<ResourceBase>                                                                    // CSBuildMemberListSection.cs:46
	{                                                                                                                                          // CSBuildMemberListSection.cs:47
	    /// <summary>
	    /// Access propertyName
	    /// </summary>
	    public IEnumerable<ResourceBase> All() => this.items;                                                                                  // CSBuildMemberListSection.cs:139
	                                                                                                                                           // CSBuildMemberListSection.cs:141
	    /// <summary>
	    /// Access item at indicated location in list
	    /// </summary>
	    public ResourceBase At(Int32 i) => base.items[i];                                                                                      // CSBuildMemberListSection.cs:145
	                                                                                                                                           // CSBuildMemberListSection.cs:147
	    /// <summary>
	    /// Access first item in list
	    /// </summary>
	    public new ResourceBase First() => base.First();                                                                                       // CSBuildMemberListSection.cs:151
	                                                                                                                                           // CSBuildMemberListSection.cs:152
	    /// <summary>
	    /// Access first item in list or default value if empty
	    /// </summary>
	    public new ResourceBase FirstOrDefault() => base.FirstOrDefault();                                                                     // CSBuildMemberListSection.cs:156
	                                                                                                                                           // CSBuildMemberListSection.cs:49
	                                                                                                                                           // CSBuildMemberListSection.cs:114
	    /// <summary>
	    /// Create new blank Impressions of type ClinicalImpression and add to end of list
	    /// </summary>
	    //If: C:\Development\HL7\BreastRadiologyLibrary\Projects\FireFragger\FireFragger\CS\CSBuildMemberListSection.cs 119                    // CodeBlockNested.cs:588
	    public ResourceBase Append(Resource r)                                                                                                 // CSBuildMemberListSection.cs:120
	    {                                                                                                                                      // CSBuildMemberListSection.cs:123
	        ResourceBase brItem = new ResourceBase();                                                                                          // CSBuildMemberListSection.cs:124
	        //If: C:\Development\HL7\BreastRadiologyLibrary\Projects\FireFragger\FireFragger\CS\CSBuildMemberListSection.cs 125                // CodeBlockNested.cs:588
	        brItem.Init(this.doc, r);                                                                                                          // CSBuildMemberListSection.cs:126
	        this.AppendItem(brItem);                                                                                                           // CSBuildMemberListSection.cs:129
	        return brItem;                                                                                                                     // CSBuildMemberListSection.cs:130
	    }                                                                                                                                      // CSBuildMemberListSection.cs:131
	                                                                                                                                           // CSBuildMemberListSection.cs:51
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public Impressions_Accessor(BreastRadiologyDocument doc) : base("Impressions_Accessor")                                                // CSBuildMemberListSection.cs:55
	    {                                                                                                                                      // CSBuildMemberListSection.cs:56
	        this.Init(doc, "Clinical Impressions", 0, -1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes", "sectionImpressions"));// CSBuildMemberListSection.cs:57
	    }                                                                                                                                      // CSBuildMemberListSection.cs:59
	}                                                                                                                                          // CSBuildMemberListSection.cs:60
	/// <summary>
	/// Accessor class for 'Findings Right Breast'
	/// [Fhir Element 'Composition.section:findingsRightBreast]'
	/// </summary>
	public class FindingsRightBreast_Accessor : MemberListSectionBase<SectionFindingsRightBreast>                                              // CSBuildMemberListSection.cs:46
	{                                                                                                                                          // CSBuildMemberListSection.cs:47
	    /// <summary>
	    /// Access propertyName
	    /// </summary>
	    public SectionFindingsRightBreast Get() => this.FirstOrDefault();                                                                      // CSBuildMemberListSection.cs:89
	                                                                                                                                           // CSBuildMemberListSection.cs:68
	    /// <summary>
	    /// Create new blank FindingsRightBreast if one doesnt already exist, and return it
	    /// </summary>
	    public SectionFindingsRightBreast Create()                                                                                             // CSBuildMemberListSection.cs:72
	    {                                                                                                                                      // CSBuildMemberListSection.cs:73
	        if (this.Count == 0)                                                                                                               // CSBuildMemberListSection.cs:74
	        {                                                                                                                                  // CSBuildMemberListSection.cs:75
	            SectionFindingsRightBreast brItem = new SectionFindingsRightBreast();                                                          // CSBuildMemberListSection.cs:76
	            brItem.Init(this.doc);                                                                                                         // CSBuildMemberListSection.cs:77
	            this.AppendItem(brItem);                                                                                                       // CSBuildMemberListSection.cs:78
	        }                                                                                                                                  // CSBuildMemberListSection.cs:79
	        return this.First();                                                                                                               // CSBuildMemberListSection.cs:80
	    }                                                                                                                                      // CSBuildMemberListSection.cs:81
	                                                                                                                                           // CSBuildMemberListSection.cs:49
	                                                                                                                                           // CSBuildMemberListSection.cs:51
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public FindingsRightBreast_Accessor(BreastRadiologyDocument doc) : base("FindingsRightBreast_Accessor")                                // CSBuildMemberListSection.cs:55
	    {                                                                                                                                      // CSBuildMemberListSection.cs:56
	        this.Init(doc, "Findings Right Breast", 0, 1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes", "sectionCodeFindingsRightBreast"));// CSBuildMemberListSection.cs:57
	    }                                                                                                                                      // CSBuildMemberListSection.cs:59
	}                                                                                                                                          // CSBuildMemberListSection.cs:60
	/// <summary>
	/// Accessor class for 'Findings Left Breast'
	/// [Fhir Element 'Composition.section:findingsLeftBreast]'
	/// </summary>
	public class FindingsLeftBreast_Accessor : MemberListSectionBase<SectionFindingsLeftBreast>                                                // CSBuildMemberListSection.cs:46
	{                                                                                                                                          // CSBuildMemberListSection.cs:47
	    /// <summary>
	    /// Access propertyName
	    /// </summary>
	    public SectionFindingsLeftBreast Get() => this.FirstOrDefault();                                                                       // CSBuildMemberListSection.cs:89
	                                                                                                                                           // CSBuildMemberListSection.cs:68
	    /// <summary>
	    /// Create new blank FindingsLeftBreast if one doesnt already exist, and return it
	    /// </summary>
	    public SectionFindingsLeftBreast Create()                                                                                              // CSBuildMemberListSection.cs:72
	    {                                                                                                                                      // CSBuildMemberListSection.cs:73
	        if (this.Count == 0)                                                                                                               // CSBuildMemberListSection.cs:74
	        {                                                                                                                                  // CSBuildMemberListSection.cs:75
	            SectionFindingsLeftBreast brItem = new SectionFindingsLeftBreast();                                                            // CSBuildMemberListSection.cs:76
	            brItem.Init(this.doc);                                                                                                         // CSBuildMemberListSection.cs:77
	            this.AppendItem(brItem);                                                                                                       // CSBuildMemberListSection.cs:78
	        }                                                                                                                                  // CSBuildMemberListSection.cs:79
	        return this.First();                                                                                                               // CSBuildMemberListSection.cs:80
	    }                                                                                                                                      // CSBuildMemberListSection.cs:81
	                                                                                                                                           // CSBuildMemberListSection.cs:49
	                                                                                                                                           // CSBuildMemberListSection.cs:51
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public FindingsLeftBreast_Accessor(BreastRadiologyDocument doc) : base("FindingsLeftBreast_Accessor")                                  // CSBuildMemberListSection.cs:55
	    {                                                                                                                                      // CSBuildMemberListSection.cs:56
	        this.Init(doc, "Findings Left Breast", 0, 1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes", "sectionCodeFindingsLeftBreast"));// CSBuildMemberListSection.cs:57
	    }                                                                                                                                      // CSBuildMemberListSection.cs:59
	}                                                                                                                                          // CSBuildMemberListSection.cs:60
	/// <summary>
	/// Accessor class for 'Related Resources'
	/// [Fhir Element 'Composition.section:relatedResources]'
	/// </summary>
	public class RelatedResources_Accessor : MemberListSectionBase<ResourceBase>                                                               // CSBuildMemberListSection.cs:46
	{                                                                                                                                          // CSBuildMemberListSection.cs:47
	    /// <summary>
	    /// Access propertyName
	    /// </summary>
	    public IEnumerable<ResourceBase> All() => this.items;                                                                                  // CSBuildMemberListSection.cs:139
	                                                                                                                                           // CSBuildMemberListSection.cs:141
	    /// <summary>
	    /// Access item at indicated location in list
	    /// </summary>
	    public ResourceBase At(Int32 i) => base.items[i];                                                                                      // CSBuildMemberListSection.cs:145
	                                                                                                                                           // CSBuildMemberListSection.cs:147
	    /// <summary>
	    /// Access first item in list
	    /// </summary>
	    public new ResourceBase First() => base.First();                                                                                       // CSBuildMemberListSection.cs:151
	                                                                                                                                           // CSBuildMemberListSection.cs:152
	    /// <summary>
	    /// Access first item in list or default value if empty
	    /// </summary>
	    public new ResourceBase FirstOrDefault() => base.FirstOrDefault();                                                                     // CSBuildMemberListSection.cs:156
	                                                                                                                                           // CSBuildMemberListSection.cs:49
	                                                                                                                                           // CSBuildMemberListSection.cs:114
	    /// <summary>
	    /// Create new blank RelatedResources of type Resource and add to end of list
	    /// </summary>
	    //If: C:\Development\HL7\BreastRadiologyLibrary\Projects\FireFragger\FireFragger\CS\CSBuildMemberListSection.cs 119                    // CodeBlockNested.cs:588
	    public ResourceBase Append(Resource r)                                                                                                 // CSBuildMemberListSection.cs:120
	    {                                                                                                                                      // CSBuildMemberListSection.cs:123
	        ResourceBase brItem = new ResourceBase();                                                                                          // CSBuildMemberListSection.cs:124
	        //If: C:\Development\HL7\BreastRadiologyLibrary\Projects\FireFragger\FireFragger\CS\CSBuildMemberListSection.cs 125                // CodeBlockNested.cs:588
	        brItem.Init(this.doc, r);                                                                                                          // CSBuildMemberListSection.cs:126
	        this.AppendItem(brItem);                                                                                                           // CSBuildMemberListSection.cs:129
	        return brItem;                                                                                                                     // CSBuildMemberListSection.cs:130
	    }                                                                                                                                      // CSBuildMemberListSection.cs:131
	                                                                                                                                           // CSBuildMemberListSection.cs:51
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public RelatedResources_Accessor(BreastRadiologyDocument doc) : base("RelatedResources_Accessor")                                      // CSBuildMemberListSection.cs:55
	    {                                                                                                                                      // CSBuildMemberListSection.cs:56
	        this.Init(doc, "Related Resources", 0, -1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes", "sectionRelatedResources"));// CSBuildMemberListSection.cs:57
	    }                                                                                                                                      // CSBuildMemberListSection.cs:59
	}                                                                                                                                          // CSBuildMemberListSection.cs:60
	/// <summary>
	/// Accessor class for 'Recommendations'
	/// [Fhir Element 'Composition.section:recommendations]'
	/// </summary>
	public class Recommendations_Accessor : MemberListSectionBase<ResourceBase>                                                                // CSBuildMemberListSection.cs:46
	{                                                                                                                                          // CSBuildMemberListSection.cs:47
	    /// <summary>
	    /// Access propertyName
	    /// </summary>
	    public IEnumerable<ResourceBase> All() => this.items;                                                                                  // CSBuildMemberListSection.cs:139
	                                                                                                                                           // CSBuildMemberListSection.cs:141
	    /// <summary>
	    /// Access item at indicated location in list
	    /// </summary>
	    public ResourceBase At(Int32 i) => base.items[i];                                                                                      // CSBuildMemberListSection.cs:145
	                                                                                                                                           // CSBuildMemberListSection.cs:147
	    /// <summary>
	    /// Access first item in list
	    /// </summary>
	    public new ResourceBase First() => base.First();                                                                                       // CSBuildMemberListSection.cs:151
	                                                                                                                                           // CSBuildMemberListSection.cs:152
	    /// <summary>
	    /// Access first item in list or default value if empty
	    /// </summary>
	    public new ResourceBase FirstOrDefault() => base.FirstOrDefault();                                                                     // CSBuildMemberListSection.cs:156
	                                                                                                                                           // CSBuildMemberListSection.cs:49
	                                                                                                                                           // CSBuildMemberListSection.cs:114
	    /// <summary>
	    /// Create new blank Recommendations of type MedicationRequest and add to end of list
	    /// </summary>
	    //If: C:\Development\HL7\BreastRadiologyLibrary\Projects\FireFragger\FireFragger\CS\CSBuildMemberListSection.cs 119                    // CodeBlockNested.cs:588
	    public ResourceBase AppendMedicationRequest(Resource r)                                                                                // CSBuildMemberListSection.cs:120
	    {                                                                                                                                      // CSBuildMemberListSection.cs:123
	        ResourceBase brItem = new ResourceBase();                                                                                          // CSBuildMemberListSection.cs:124
	        //If: C:\Development\HL7\BreastRadiologyLibrary\Projects\FireFragger\FireFragger\CS\CSBuildMemberListSection.cs 125                // CodeBlockNested.cs:588
	        brItem.Init(this.doc, r);                                                                                                          // CSBuildMemberListSection.cs:126
	        this.AppendItem(brItem);                                                                                                           // CSBuildMemberListSection.cs:129
	        return brItem;                                                                                                                     // CSBuildMemberListSection.cs:130
	    }                                                                                                                                      // CSBuildMemberListSection.cs:131
	                                                                                                                                           // CSBuildMemberListSection.cs:114
	    /// <summary>
	    /// Create new blank Recommendations of type ServiceRequest and add to end of list
	    /// </summary>
	    //If: C:\Development\HL7\BreastRadiologyLibrary\Projects\FireFragger\FireFragger\CS\CSBuildMemberListSection.cs 119                    // CodeBlockNested.cs:588
	    public ResourceBase AppendServiceRequest(Resource r)                                                                                   // CSBuildMemberListSection.cs:120
	    {                                                                                                                                      // CSBuildMemberListSection.cs:123
	        ResourceBase brItem = new ResourceBase();                                                                                          // CSBuildMemberListSection.cs:124
	        //If: C:\Development\HL7\BreastRadiologyLibrary\Projects\FireFragger\FireFragger\CS\CSBuildMemberListSection.cs 125                // CodeBlockNested.cs:588
	        brItem.Init(this.doc, r);                                                                                                          // CSBuildMemberListSection.cs:126
	        this.AppendItem(brItem);                                                                                                           // CSBuildMemberListSection.cs:129
	        return brItem;                                                                                                                     // CSBuildMemberListSection.cs:130
	    }                                                                                                                                      // CSBuildMemberListSection.cs:131
	                                                                                                                                           // CSBuildMemberListSection.cs:114
	    /// <summary>
	    /// Create new blank Recommendations of type ServiceRequest and add to end of list
	    /// </summary>
	    //Else: C:\Development\HL7\BreastRadiologyLibrary\Projects\FireFragger\FireFragger\CS\CSBuildMemberListSection.cs 119                  // CodeBlockNested.cs:594
	    public ServiceRecommendation AppendServiceRecommendation()                                                                             // CSBuildMemberListSection.cs:121
	    {                                                                                                                                      // CSBuildMemberListSection.cs:123
	        ServiceRecommendation brItem = new ServiceRecommendation();                                                                        // CSBuildMemberListSection.cs:124
	        //Else: C:\Development\HL7\BreastRadiologyLibrary\Projects\FireFragger\FireFragger\CS\CSBuildMemberListSection.cs 125              // CodeBlockNested.cs:594
	        brItem.Init(this.doc);                                                                                                             // CSBuildMemberListSection.cs:127
	        this.AppendItem(brItem);                                                                                                           // CSBuildMemberListSection.cs:129
	        return brItem;                                                                                                                     // CSBuildMemberListSection.cs:130
	    }                                                                                                                                      // CSBuildMemberListSection.cs:131
	                                                                                                                                           // CSBuildMemberListSection.cs:51
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public Recommendations_Accessor(BreastRadiologyDocument doc) : base("Recommendations_Accessor")                                        // CSBuildMemberListSection.cs:55
	    {                                                                                                                                      // CSBuildMemberListSection.cs:56
	        this.Init(doc, "Recommendations", 0, -1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes", "sectionCodeRecommendations"));// CSBuildMemberListSection.cs:57
	    }                                                                                                                                      // CSBuildMemberListSection.cs:59
	}                                                                                                                                          // CSBuildMemberListSection.cs:60
	//- LocalClassDefs
}
