using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.CompositionLocal;
//+Usings
//-Usings

namespace BreastRadLib.BreastRadCompositionLocal
{
	//+ LocalClassDefs
	/// <summary>
	/// Accessor class for 'Breast Radiology Report'
	/// [Fhir Element 'Composition.section:report]'
	/// </summary>
	public class Report_Accessor : MemberListSection<BreastRadReport>                                                                          // BuildMemberListSection.cs:48
	{                                                                                                                                          // BuildMemberListSection.cs:49
	    /// <summary>
	    /// Access propertyName
	    /// </summary>
	    public BreastRadReport Get() => this.FirstOrDefault();                                                                                 // BuildMemberListSection.cs:91
	                                                                                                                                           // BuildMemberListSection.cs:70
	    /// <summary>
	    /// Create new blank Report if one doesnt already exist, and return it
	    /// </summary>
	    public BreastRadReport Create()                                                                                                        // BuildMemberListSection.cs:74
	    {                                                                                                                                      // BuildMemberListSection.cs:75
	        if (this.Count == 0)                                                                                                               // BuildMemberListSection.cs:76
	        {                                                                                                                                  // BuildMemberListSection.cs:77
	            BreastRadReport brItem = new BreastRadReport();                                                                                // BuildMemberListSection.cs:78
	            brItem.Init(this.doc);                                                                                                         // BuildMemberListSection.cs:79
	            this.AppendItem(brItem);                                                                                                       // BuildMemberListSection.cs:80
	        }                                                                                                                                  // BuildMemberListSection.cs:81
	        return this.First();                                                                                                               // BuildMemberListSection.cs:82
	    }                                                                                                                                      // BuildMemberListSection.cs:83
	                                                                                                                                           // BuildMemberListSection.cs:51
	                                                                                                                                           // BuildMemberListSection.cs:53
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public Report_Accessor(BreastRadiologyDocument doc) : base("Report_Accessor")                                                          // BuildMemberListSection.cs:57
	    {                                                                                                                                      // BuildMemberListSection.cs:58
	        this.Init(doc, "Breast Radiology Report", 1, 1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes", "sectionReport"));// BuildMemberListSection.cs:59
	    }                                                                                                                                      // BuildMemberListSection.cs:61
	}                                                                                                                                          // BuildMemberListSection.cs:62
	/// <summary>
	/// Accessor class for 'Clinical Impressions'
	/// [Fhir Element 'Composition.section:impressions]'
	/// </summary>
	public class Impressions_Accessor : MemberListSection<ResourceBase>                                                                        // BuildMemberListSection.cs:48
	{                                                                                                                                          // BuildMemberListSection.cs:49
	    /// <summary>
	    /// Access propertyName
	    /// </summary>
	    public IEnumerable<ResourceBase> All() => this.items;                                                                                  // BuildMemberListSection.cs:141
	                                                                                                                                           // BuildMemberListSection.cs:143
	    /// <summary>
	    /// Access item at indicated location in list
	    /// </summary>
	    public ResourceBase At(Int32 i) => base.items[i];                                                                                      // BuildMemberListSection.cs:147
	                                                                                                                                           // BuildMemberListSection.cs:149
	    /// <summary>
	    /// Access first item in list
	    /// </summary>
	    public new ResourceBase First() => base.First();                                                                                       // BuildMemberListSection.cs:153
	                                                                                                                                           // BuildMemberListSection.cs:154
	    /// <summary>
	    /// Access first item in list or default value if empty
	    /// </summary>
	    public new ResourceBase FirstOrDefault() => base.FirstOrDefault();                                                                     // BuildMemberListSection.cs:158
	                                                                                                                                           // BuildMemberListSection.cs:51
	                                                                                                                                           // BuildMemberListSection.cs:116
	    /// <summary>
	    /// Create new blank Impressions of type ClinicalImpression and add to end of list
	    /// </summary>
	    //If: C:\Development\HL7\BreastRadiologyLibrary\Projects\FireFragger\FireFragger\CS\BuildMemberListSection.cs 121                      // CodeBlockNested.cs:588
	    public ResourceBase Append(Resource r)                                                                                                 // BuildMemberListSection.cs:122
	    {                                                                                                                                      // BuildMemberListSection.cs:125
	        ResourceBase brItem = new ResourceBase();                                                                                          // BuildMemberListSection.cs:126
	        //If: C:\Development\HL7\BreastRadiologyLibrary\Projects\FireFragger\FireFragger\CS\BuildMemberListSection.cs 127                  // CodeBlockNested.cs:588
	        brItem.Init(this.doc, r);                                                                                                          // BuildMemberListSection.cs:128
	        this.AppendItem(brItem);                                                                                                           // BuildMemberListSection.cs:131
	        return brItem;                                                                                                                     // BuildMemberListSection.cs:132
	    }                                                                                                                                      // BuildMemberListSection.cs:133
	                                                                                                                                           // BuildMemberListSection.cs:53
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public Impressions_Accessor(BreastRadiologyDocument doc) : base("Impressions_Accessor")                                                // BuildMemberListSection.cs:57
	    {                                                                                                                                      // BuildMemberListSection.cs:58
	        this.Init(doc, "Clinical Impressions", 0, -1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes", "sectionImpressions"));// BuildMemberListSection.cs:59
	    }                                                                                                                                      // BuildMemberListSection.cs:61
	}                                                                                                                                          // BuildMemberListSection.cs:62
	/// <summary>
	/// Accessor class for 'Findings Right Breast'
	/// [Fhir Element 'Composition.section:findingsRightBreast]'
	/// </summary>
	public class FindingsRightBreast_Accessor : MemberListSection<SectionFindingsRightBreast>                                                  // BuildMemberListSection.cs:48
	{                                                                                                                                          // BuildMemberListSection.cs:49
	    /// <summary>
	    /// Access propertyName
	    /// </summary>
	    public SectionFindingsRightBreast Get() => this.FirstOrDefault();                                                                      // BuildMemberListSection.cs:91
	                                                                                                                                           // BuildMemberListSection.cs:70
	    /// <summary>
	    /// Create new blank FindingsRightBreast if one doesnt already exist, and return it
	    /// </summary>
	    public SectionFindingsRightBreast Create()                                                                                             // BuildMemberListSection.cs:74
	    {                                                                                                                                      // BuildMemberListSection.cs:75
	        if (this.Count == 0)                                                                                                               // BuildMemberListSection.cs:76
	        {                                                                                                                                  // BuildMemberListSection.cs:77
	            SectionFindingsRightBreast brItem = new SectionFindingsRightBreast();                                                          // BuildMemberListSection.cs:78
	            brItem.Init(this.doc);                                                                                                         // BuildMemberListSection.cs:79
	            this.AppendItem(brItem);                                                                                                       // BuildMemberListSection.cs:80
	        }                                                                                                                                  // BuildMemberListSection.cs:81
	        return this.First();                                                                                                               // BuildMemberListSection.cs:82
	    }                                                                                                                                      // BuildMemberListSection.cs:83
	                                                                                                                                           // BuildMemberListSection.cs:51
	                                                                                                                                           // BuildMemberListSection.cs:53
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public FindingsRightBreast_Accessor(BreastRadiologyDocument doc) : base("FindingsRightBreast_Accessor")                                // BuildMemberListSection.cs:57
	    {                                                                                                                                      // BuildMemberListSection.cs:58
	        this.Init(doc, "Findings Right Breast", 0, 1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes", "sectionCodeFindingsRightBreast"));// BuildMemberListSection.cs:59
	    }                                                                                                                                      // BuildMemberListSection.cs:61
	}                                                                                                                                          // BuildMemberListSection.cs:62
	/// <summary>
	/// Accessor class for 'Findings Left Breast'
	/// [Fhir Element 'Composition.section:findingsLeftBreast]'
	/// </summary>
	public class FindingsLeftBreast_Accessor : MemberListSection<SectionFindingsLeftBreast>                                                    // BuildMemberListSection.cs:48
	{                                                                                                                                          // BuildMemberListSection.cs:49
	    /// <summary>
	    /// Access propertyName
	    /// </summary>
	    public SectionFindingsLeftBreast Get() => this.FirstOrDefault();                                                                       // BuildMemberListSection.cs:91
	                                                                                                                                           // BuildMemberListSection.cs:70
	    /// <summary>
	    /// Create new blank FindingsLeftBreast if one doesnt already exist, and return it
	    /// </summary>
	    public SectionFindingsLeftBreast Create()                                                                                              // BuildMemberListSection.cs:74
	    {                                                                                                                                      // BuildMemberListSection.cs:75
	        if (this.Count == 0)                                                                                                               // BuildMemberListSection.cs:76
	        {                                                                                                                                  // BuildMemberListSection.cs:77
	            SectionFindingsLeftBreast brItem = new SectionFindingsLeftBreast();                                                            // BuildMemberListSection.cs:78
	            brItem.Init(this.doc);                                                                                                         // BuildMemberListSection.cs:79
	            this.AppendItem(brItem);                                                                                                       // BuildMemberListSection.cs:80
	        }                                                                                                                                  // BuildMemberListSection.cs:81
	        return this.First();                                                                                                               // BuildMemberListSection.cs:82
	    }                                                                                                                                      // BuildMemberListSection.cs:83
	                                                                                                                                           // BuildMemberListSection.cs:51
	                                                                                                                                           // BuildMemberListSection.cs:53
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public FindingsLeftBreast_Accessor(BreastRadiologyDocument doc) : base("FindingsLeftBreast_Accessor")                                  // BuildMemberListSection.cs:57
	    {                                                                                                                                      // BuildMemberListSection.cs:58
	        this.Init(doc, "Findings Left Breast", 0, 1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes", "sectionCodeFindingsLeftBreast"));// BuildMemberListSection.cs:59
	    }                                                                                                                                      // BuildMemberListSection.cs:61
	}                                                                                                                                          // BuildMemberListSection.cs:62
	/// <summary>
	/// Accessor class for 'Related Resources'
	/// [Fhir Element 'Composition.section:relatedResources]'
	/// </summary>
	public class RelatedResources_Accessor : MemberListSection<ResourceBase>                                                                   // BuildMemberListSection.cs:48
	{                                                                                                                                          // BuildMemberListSection.cs:49
	    /// <summary>
	    /// Access propertyName
	    /// </summary>
	    public IEnumerable<ResourceBase> All() => this.items;                                                                                  // BuildMemberListSection.cs:141
	                                                                                                                                           // BuildMemberListSection.cs:143
	    /// <summary>
	    /// Access item at indicated location in list
	    /// </summary>
	    public ResourceBase At(Int32 i) => base.items[i];                                                                                      // BuildMemberListSection.cs:147
	                                                                                                                                           // BuildMemberListSection.cs:149
	    /// <summary>
	    /// Access first item in list
	    /// </summary>
	    public new ResourceBase First() => base.First();                                                                                       // BuildMemberListSection.cs:153
	                                                                                                                                           // BuildMemberListSection.cs:154
	    /// <summary>
	    /// Access first item in list or default value if empty
	    /// </summary>
	    public new ResourceBase FirstOrDefault() => base.FirstOrDefault();                                                                     // BuildMemberListSection.cs:158
	                                                                                                                                           // BuildMemberListSection.cs:51
	                                                                                                                                           // BuildMemberListSection.cs:116
	    /// <summary>
	    /// Create new blank RelatedResources of type Resource and add to end of list
	    /// </summary>
	    //If: C:\Development\HL7\BreastRadiologyLibrary\Projects\FireFragger\FireFragger\CS\BuildMemberListSection.cs 121                      // CodeBlockNested.cs:588
	    public ResourceBase Append(Resource r)                                                                                                 // BuildMemberListSection.cs:122
	    {                                                                                                                                      // BuildMemberListSection.cs:125
	        ResourceBase brItem = new ResourceBase();                                                                                          // BuildMemberListSection.cs:126
	        //If: C:\Development\HL7\BreastRadiologyLibrary\Projects\FireFragger\FireFragger\CS\BuildMemberListSection.cs 127                  // CodeBlockNested.cs:588
	        brItem.Init(this.doc, r);                                                                                                          // BuildMemberListSection.cs:128
	        this.AppendItem(brItem);                                                                                                           // BuildMemberListSection.cs:131
	        return brItem;                                                                                                                     // BuildMemberListSection.cs:132
	    }                                                                                                                                      // BuildMemberListSection.cs:133
	                                                                                                                                           // BuildMemberListSection.cs:53
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public RelatedResources_Accessor(BreastRadiologyDocument doc) : base("RelatedResources_Accessor")                                      // BuildMemberListSection.cs:57
	    {                                                                                                                                      // BuildMemberListSection.cs:58
	        this.Init(doc, "Related Resources", 0, -1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes", "sectionRelatedResources"));// BuildMemberListSection.cs:59
	    }                                                                                                                                      // BuildMemberListSection.cs:61
	}                                                                                                                                          // BuildMemberListSection.cs:62
	/// <summary>
	/// Accessor class for 'Recommendations'
	/// [Fhir Element 'Composition.section:recommendations]'
	/// </summary>
	public class Recommendations_Accessor : MemberListSection<ResourceBase>                                                                    // BuildMemberListSection.cs:48
	{                                                                                                                                          // BuildMemberListSection.cs:49
	    /// <summary>
	    /// Access propertyName
	    /// </summary>
	    public IEnumerable<ResourceBase> All() => this.items;                                                                                  // BuildMemberListSection.cs:141
	                                                                                                                                           // BuildMemberListSection.cs:143
	    /// <summary>
	    /// Access item at indicated location in list
	    /// </summary>
	    public ResourceBase At(Int32 i) => base.items[i];                                                                                      // BuildMemberListSection.cs:147
	                                                                                                                                           // BuildMemberListSection.cs:149
	    /// <summary>
	    /// Access first item in list
	    /// </summary>
	    public new ResourceBase First() => base.First();                                                                                       // BuildMemberListSection.cs:153
	                                                                                                                                           // BuildMemberListSection.cs:154
	    /// <summary>
	    /// Access first item in list or default value if empty
	    /// </summary>
	    public new ResourceBase FirstOrDefault() => base.FirstOrDefault();                                                                     // BuildMemberListSection.cs:158
	                                                                                                                                           // BuildMemberListSection.cs:51
	                                                                                                                                           // BuildMemberListSection.cs:116
	    /// <summary>
	    /// Create new blank Recommendations of type MedicationRequest and add to end of list
	    /// </summary>
	    //If: C:\Development\HL7\BreastRadiologyLibrary\Projects\FireFragger\FireFragger\CS\BuildMemberListSection.cs 121                      // CodeBlockNested.cs:588
	    public ResourceBase AppendMedicationRequest(Resource r)                                                                                // BuildMemberListSection.cs:122
	    {                                                                                                                                      // BuildMemberListSection.cs:125
	        ResourceBase brItem = new ResourceBase();                                                                                          // BuildMemberListSection.cs:126
	        //If: C:\Development\HL7\BreastRadiologyLibrary\Projects\FireFragger\FireFragger\CS\BuildMemberListSection.cs 127                  // CodeBlockNested.cs:588
	        brItem.Init(this.doc, r);                                                                                                          // BuildMemberListSection.cs:128
	        this.AppendItem(brItem);                                                                                                           // BuildMemberListSection.cs:131
	        return brItem;                                                                                                                     // BuildMemberListSection.cs:132
	    }                                                                                                                                      // BuildMemberListSection.cs:133
	                                                                                                                                           // BuildMemberListSection.cs:116
	    /// <summary>
	    /// Create new blank Recommendations of type ServiceRequest and add to end of list
	    /// </summary>
	    //If: C:\Development\HL7\BreastRadiologyLibrary\Projects\FireFragger\FireFragger\CS\BuildMemberListSection.cs 121                      // CodeBlockNested.cs:588
	    public ResourceBase AppendServiceRequest(Resource r)                                                                                   // BuildMemberListSection.cs:122
	    {                                                                                                                                      // BuildMemberListSection.cs:125
	        ResourceBase brItem = new ResourceBase();                                                                                          // BuildMemberListSection.cs:126
	        //If: C:\Development\HL7\BreastRadiologyLibrary\Projects\FireFragger\FireFragger\CS\BuildMemberListSection.cs 127                  // CodeBlockNested.cs:588
	        brItem.Init(this.doc, r);                                                                                                          // BuildMemberListSection.cs:128
	        this.AppendItem(brItem);                                                                                                           // BuildMemberListSection.cs:131
	        return brItem;                                                                                                                     // BuildMemberListSection.cs:132
	    }                                                                                                                                      // BuildMemberListSection.cs:133
	                                                                                                                                           // BuildMemberListSection.cs:116
	    /// <summary>
	    /// Create new blank Recommendations of type ServiceRequest and add to end of list
	    /// </summary>
	    //Else: C:\Development\HL7\BreastRadiologyLibrary\Projects\FireFragger\FireFragger\CS\BuildMemberListSection.cs 121                    // CodeBlockNested.cs:594
	    public ServiceRecommendation AppendServiceRecommendation()                                                                             // BuildMemberListSection.cs:123
	    {                                                                                                                                      // BuildMemberListSection.cs:125
	        ServiceRecommendation brItem = new ServiceRecommendation();                                                                        // BuildMemberListSection.cs:126
	        //Else: C:\Development\HL7\BreastRadiologyLibrary\Projects\FireFragger\FireFragger\CS\BuildMemberListSection.cs 127                // CodeBlockNested.cs:594
	        brItem.Init(this.doc);                                                                                                             // BuildMemberListSection.cs:129
	        this.AppendItem(brItem);                                                                                                           // BuildMemberListSection.cs:131
	        return brItem;                                                                                                                     // BuildMemberListSection.cs:132
	    }                                                                                                                                      // BuildMemberListSection.cs:133
	                                                                                                                                           // BuildMemberListSection.cs:53
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public Recommendations_Accessor(BreastRadiologyDocument doc) : base("Recommendations_Accessor")                                        // BuildMemberListSection.cs:57
	    {                                                                                                                                      // BuildMemberListSection.cs:58
	        this.Init(doc, "Recommendations", 0, -1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes", "sectionCodeRecommendations"));// BuildMemberListSection.cs:59
	    }                                                                                                                                      // BuildMemberListSection.cs:61
	}                                                                                                                                          // BuildMemberListSection.cs:62
	//- LocalClassDefs
}
