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
	public class Report_Accessor : MemberListSectionBase<BreastRadReport>                                                                      // CSBuildMemberListSection.cs:41
	{                                                                                                                                          // CSBuildMemberListSection.cs:42
	    /// <summary>
	    /// Access propertyName
	    /// </summary>
	    public BreastRadReport Get() => this.FirstOrDefault();                                                                                 // CSBuildMemberListSection.cs:84
	                                                                                                                                           // CSBuildMemberListSection.cs:63
	    /// <summary>
	    /// Create new blank Report if one doesnt already exist, and return it
	    /// </summary>
	    public BreastRadReport Create()                                                                                                        // CSBuildMemberListSection.cs:67
	    {                                                                                                                                      // CSBuildMemberListSection.cs:68
	        if (this.Count == 0)                                                                                                               // CSBuildMemberListSection.cs:69
	        {                                                                                                                                  // CSBuildMemberListSection.cs:70
	            BreastRadReport brItem = new BreastRadReport();                                                                                // CSBuildMemberListSection.cs:71
	            brItem.Init(this.doc);                                                                                                         // CSBuildMemberListSection.cs:72
	            this.AppendItem(brItem);                                                                                                       // CSBuildMemberListSection.cs:73
	        }                                                                                                                                  // CSBuildMemberListSection.cs:74
	        return this.First();                                                                                                               // CSBuildMemberListSection.cs:75
	    }                                                                                                                                      // CSBuildMemberListSection.cs:76
	                                                                                                                                           // CSBuildMemberListSection.cs:44
	                                                                                                                                           // CSBuildMemberListSection.cs:46
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public Report_Accessor(BreastRadiologyDocument doc) : base("Report_Accessor")                                                          // CSBuildMemberListSection.cs:50
	    {                                                                                                                                      // CSBuildMemberListSection.cs:51
	        this.Init(doc, "Breast Radiology Report", 1, 1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes", "sectionReport"));// CSBuildMemberListSection.cs:52
	    }                                                                                                                                      // CSBuildMemberListSection.cs:54
	}                                                                                                                                          // CSBuildMemberListSection.cs:55
	/// <summary>
	/// Accessor class for 'Clinical Impressions'
	/// [Fhir Element 'Composition.section:impressions]'
	/// </summary>
	public class Impressions_Accessor : MemberListSectionBase<ResourceBase>                                                                    // CSBuildMemberListSection.cs:41
	{                                                                                                                                          // CSBuildMemberListSection.cs:42
	    /// <summary>
	    /// Access propertyName
	    /// </summary>
	    public IEnumerable<ResourceBase> All() => this.items;                                                                                  // CSBuildMemberListSection.cs:134
	                                                                                                                                           // CSBuildMemberListSection.cs:136
	    /// <summary>
	    /// Access item at indicated location in list
	    /// </summary>
	    public ResourceBase At(Int32 i) => base.items[i];                                                                                      // CSBuildMemberListSection.cs:140
	                                                                                                                                           // CSBuildMemberListSection.cs:142
	    /// <summary>
	    /// Access first item in list
	    /// </summary>
	    public new ResourceBase First() => base.First();                                                                                       // CSBuildMemberListSection.cs:146
	                                                                                                                                           // CSBuildMemberListSection.cs:147
	    /// <summary>
	    /// Access first item in list or default value if empty
	    /// </summary>
	    public new ResourceBase FirstOrDefault() => base.FirstOrDefault();                                                                     // CSBuildMemberListSection.cs:151
	                                                                                                                                           // CSBuildMemberListSection.cs:44
	                                                                                                                                           // CSBuildMemberListSection.cs:109
	    /// <summary>
	    /// Create new blank Impressions of type ClinicalImpression and add to end of list
	    /// </summary>
	    //If: C:\Development\HL7\BreastRadiologyLibrary\Projects\FireFragger\FireFragger\CS\CSBuildMemberListSection.cs 114                    // CodeBlockNested.cs:588
	    public ResourceBase Append(Resource r)                                                                                                 // CSBuildMemberListSection.cs:115
	    {                                                                                                                                      // CSBuildMemberListSection.cs:118
	        ResourceBase brItem = new ResourceBase();                                                                                          // CSBuildMemberListSection.cs:119
	        //If: C:\Development\HL7\BreastRadiologyLibrary\Projects\FireFragger\FireFragger\CS\CSBuildMemberListSection.cs 120                // CodeBlockNested.cs:588
	        brItem.Init(this.doc, r);                                                                                                          // CSBuildMemberListSection.cs:121
	        this.AppendItem(brItem);                                                                                                           // CSBuildMemberListSection.cs:124
	        return brItem;                                                                                                                     // CSBuildMemberListSection.cs:125
	    }                                                                                                                                      // CSBuildMemberListSection.cs:126
	                                                                                                                                           // CSBuildMemberListSection.cs:46
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public Impressions_Accessor(BreastRadiologyDocument doc) : base("Impressions_Accessor")                                                // CSBuildMemberListSection.cs:50
	    {                                                                                                                                      // CSBuildMemberListSection.cs:51
	        this.Init(doc, "Clinical Impressions", 0, -1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes", "sectionImpressions"));// CSBuildMemberListSection.cs:52
	    }                                                                                                                                      // CSBuildMemberListSection.cs:54
	}                                                                                                                                          // CSBuildMemberListSection.cs:55
	/// <summary>
	/// Accessor class for 'Findings Right Breast'
	/// [Fhir Element 'Composition.section:findingsRightBreast]'
	/// </summary>
	public class FindingsRightBreast_Accessor : MemberListSectionBase<SectionFindingsRightBreast>                                              // CSBuildMemberListSection.cs:41
	{                                                                                                                                          // CSBuildMemberListSection.cs:42
	    /// <summary>
	    /// Access propertyName
	    /// </summary>
	    public SectionFindingsRightBreast Get() => this.FirstOrDefault();                                                                      // CSBuildMemberListSection.cs:84
	                                                                                                                                           // CSBuildMemberListSection.cs:63
	    /// <summary>
	    /// Create new blank FindingsRightBreast if one doesnt already exist, and return it
	    /// </summary>
	    public SectionFindingsRightBreast Create()                                                                                             // CSBuildMemberListSection.cs:67
	    {                                                                                                                                      // CSBuildMemberListSection.cs:68
	        if (this.Count == 0)                                                                                                               // CSBuildMemberListSection.cs:69
	        {                                                                                                                                  // CSBuildMemberListSection.cs:70
	            SectionFindingsRightBreast brItem = new SectionFindingsRightBreast();                                                          // CSBuildMemberListSection.cs:71
	            brItem.Init(this.doc);                                                                                                         // CSBuildMemberListSection.cs:72
	            this.AppendItem(brItem);                                                                                                       // CSBuildMemberListSection.cs:73
	        }                                                                                                                                  // CSBuildMemberListSection.cs:74
	        return this.First();                                                                                                               // CSBuildMemberListSection.cs:75
	    }                                                                                                                                      // CSBuildMemberListSection.cs:76
	                                                                                                                                           // CSBuildMemberListSection.cs:44
	                                                                                                                                           // CSBuildMemberListSection.cs:46
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public FindingsRightBreast_Accessor(BreastRadiologyDocument doc) : base("FindingsRightBreast_Accessor")                                // CSBuildMemberListSection.cs:50
	    {                                                                                                                                      // CSBuildMemberListSection.cs:51
	        this.Init(doc, "Findings Right Breast", 0, 1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes", "sectionCodeFindingsRightBreast"));// CSBuildMemberListSection.cs:52
	    }                                                                                                                                      // CSBuildMemberListSection.cs:54
	}                                                                                                                                          // CSBuildMemberListSection.cs:55
	/// <summary>
	/// Accessor class for 'Findings Left Breast'
	/// [Fhir Element 'Composition.section:findingsLeftBreast]'
	/// </summary>
	public class FindingsLeftBreast_Accessor : MemberListSectionBase<SectionFindingsLeftBreast>                                                // CSBuildMemberListSection.cs:41
	{                                                                                                                                          // CSBuildMemberListSection.cs:42
	    /// <summary>
	    /// Access propertyName
	    /// </summary>
	    public SectionFindingsLeftBreast Get() => this.FirstOrDefault();                                                                       // CSBuildMemberListSection.cs:84
	                                                                                                                                           // CSBuildMemberListSection.cs:63
	    /// <summary>
	    /// Create new blank FindingsLeftBreast if one doesnt already exist, and return it
	    /// </summary>
	    public SectionFindingsLeftBreast Create()                                                                                              // CSBuildMemberListSection.cs:67
	    {                                                                                                                                      // CSBuildMemberListSection.cs:68
	        if (this.Count == 0)                                                                                                               // CSBuildMemberListSection.cs:69
	        {                                                                                                                                  // CSBuildMemberListSection.cs:70
	            SectionFindingsLeftBreast brItem = new SectionFindingsLeftBreast();                                                            // CSBuildMemberListSection.cs:71
	            brItem.Init(this.doc);                                                                                                         // CSBuildMemberListSection.cs:72
	            this.AppendItem(brItem);                                                                                                       // CSBuildMemberListSection.cs:73
	        }                                                                                                                                  // CSBuildMemberListSection.cs:74
	        return this.First();                                                                                                               // CSBuildMemberListSection.cs:75
	    }                                                                                                                                      // CSBuildMemberListSection.cs:76
	                                                                                                                                           // CSBuildMemberListSection.cs:44
	                                                                                                                                           // CSBuildMemberListSection.cs:46
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public FindingsLeftBreast_Accessor(BreastRadiologyDocument doc) : base("FindingsLeftBreast_Accessor")                                  // CSBuildMemberListSection.cs:50
	    {                                                                                                                                      // CSBuildMemberListSection.cs:51
	        this.Init(doc, "Findings Left Breast", 0, 1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes", "sectionCodeFindingsLeftBreast"));// CSBuildMemberListSection.cs:52
	    }                                                                                                                                      // CSBuildMemberListSection.cs:54
	}                                                                                                                                          // CSBuildMemberListSection.cs:55
	/// <summary>
	/// Accessor class for 'Related Resources'
	/// [Fhir Element 'Composition.section:relatedResources]'
	/// </summary>
	public class RelatedResources_Accessor : MemberListSectionBase<ResourceBase>                                                               // CSBuildMemberListSection.cs:41
	{                                                                                                                                          // CSBuildMemberListSection.cs:42
	    /// <summary>
	    /// Access propertyName
	    /// </summary>
	    public IEnumerable<ResourceBase> All() => this.items;                                                                                  // CSBuildMemberListSection.cs:134
	                                                                                                                                           // CSBuildMemberListSection.cs:136
	    /// <summary>
	    /// Access item at indicated location in list
	    /// </summary>
	    public ResourceBase At(Int32 i) => base.items[i];                                                                                      // CSBuildMemberListSection.cs:140
	                                                                                                                                           // CSBuildMemberListSection.cs:142
	    /// <summary>
	    /// Access first item in list
	    /// </summary>
	    public new ResourceBase First() => base.First();                                                                                       // CSBuildMemberListSection.cs:146
	                                                                                                                                           // CSBuildMemberListSection.cs:147
	    /// <summary>
	    /// Access first item in list or default value if empty
	    /// </summary>
	    public new ResourceBase FirstOrDefault() => base.FirstOrDefault();                                                                     // CSBuildMemberListSection.cs:151
	                                                                                                                                           // CSBuildMemberListSection.cs:44
	                                                                                                                                           // CSBuildMemberListSection.cs:109
	    /// <summary>
	    /// Create new blank RelatedResources of type Resource and add to end of list
	    /// </summary>
	    //If: C:\Development\HL7\BreastRadiologyLibrary\Projects\FireFragger\FireFragger\CS\CSBuildMemberListSection.cs 114                    // CodeBlockNested.cs:588
	    public ResourceBase Append(Resource r)                                                                                                 // CSBuildMemberListSection.cs:115
	    {                                                                                                                                      // CSBuildMemberListSection.cs:118
	        ResourceBase brItem = new ResourceBase();                                                                                          // CSBuildMemberListSection.cs:119
	        //If: C:\Development\HL7\BreastRadiologyLibrary\Projects\FireFragger\FireFragger\CS\CSBuildMemberListSection.cs 120                // CodeBlockNested.cs:588
	        brItem.Init(this.doc, r);                                                                                                          // CSBuildMemberListSection.cs:121
	        this.AppendItem(brItem);                                                                                                           // CSBuildMemberListSection.cs:124
	        return brItem;                                                                                                                     // CSBuildMemberListSection.cs:125
	    }                                                                                                                                      // CSBuildMemberListSection.cs:126
	                                                                                                                                           // CSBuildMemberListSection.cs:46
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public RelatedResources_Accessor(BreastRadiologyDocument doc) : base("RelatedResources_Accessor")                                      // CSBuildMemberListSection.cs:50
	    {                                                                                                                                      // CSBuildMemberListSection.cs:51
	        this.Init(doc, "Related Resources", 0, -1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes", "sectionRelatedResources"));// CSBuildMemberListSection.cs:52
	    }                                                                                                                                      // CSBuildMemberListSection.cs:54
	}                                                                                                                                          // CSBuildMemberListSection.cs:55
	/// <summary>
	/// Accessor class for 'Recommendations'
	/// [Fhir Element 'Composition.section:recommendations]'
	/// </summary>
	public class Recommendations_Accessor : MemberListSectionBase<ResourceBase>                                                                // CSBuildMemberListSection.cs:41
	{                                                                                                                                          // CSBuildMemberListSection.cs:42
	    /// <summary>
	    /// Access propertyName
	    /// </summary>
	    public IEnumerable<ResourceBase> All() => this.items;                                                                                  // CSBuildMemberListSection.cs:134
	                                                                                                                                           // CSBuildMemberListSection.cs:136
	    /// <summary>
	    /// Access item at indicated location in list
	    /// </summary>
	    public ResourceBase At(Int32 i) => base.items[i];                                                                                      // CSBuildMemberListSection.cs:140
	                                                                                                                                           // CSBuildMemberListSection.cs:142
	    /// <summary>
	    /// Access first item in list
	    /// </summary>
	    public new ResourceBase First() => base.First();                                                                                       // CSBuildMemberListSection.cs:146
	                                                                                                                                           // CSBuildMemberListSection.cs:147
	    /// <summary>
	    /// Access first item in list or default value if empty
	    /// </summary>
	    public new ResourceBase FirstOrDefault() => base.FirstOrDefault();                                                                     // CSBuildMemberListSection.cs:151
	                                                                                                                                           // CSBuildMemberListSection.cs:44
	                                                                                                                                           // CSBuildMemberListSection.cs:109
	    /// <summary>
	    /// Create new blank Recommendations of type MedicationRequest and add to end of list
	    /// </summary>
	    //If: C:\Development\HL7\BreastRadiologyLibrary\Projects\FireFragger\FireFragger\CS\CSBuildMemberListSection.cs 114                    // CodeBlockNested.cs:588
	    public ResourceBase AppendMedicationRequest(Resource r)                                                                                // CSBuildMemberListSection.cs:115
	    {                                                                                                                                      // CSBuildMemberListSection.cs:118
	        ResourceBase brItem = new ResourceBase();                                                                                          // CSBuildMemberListSection.cs:119
	        //If: C:\Development\HL7\BreastRadiologyLibrary\Projects\FireFragger\FireFragger\CS\CSBuildMemberListSection.cs 120                // CodeBlockNested.cs:588
	        brItem.Init(this.doc, r);                                                                                                          // CSBuildMemberListSection.cs:121
	        this.AppendItem(brItem);                                                                                                           // CSBuildMemberListSection.cs:124
	        return brItem;                                                                                                                     // CSBuildMemberListSection.cs:125
	    }                                                                                                                                      // CSBuildMemberListSection.cs:126
	                                                                                                                                           // CSBuildMemberListSection.cs:109
	    /// <summary>
	    /// Create new blank Recommendations of type ServiceRequest and add to end of list
	    /// </summary>
	    //If: C:\Development\HL7\BreastRadiologyLibrary\Projects\FireFragger\FireFragger\CS\CSBuildMemberListSection.cs 114                    // CodeBlockNested.cs:588
	    public ResourceBase AppendServiceRequest(Resource r)                                                                                   // CSBuildMemberListSection.cs:115
	    {                                                                                                                                      // CSBuildMemberListSection.cs:118
	        ResourceBase brItem = new ResourceBase();                                                                                          // CSBuildMemberListSection.cs:119
	        //If: C:\Development\HL7\BreastRadiologyLibrary\Projects\FireFragger\FireFragger\CS\CSBuildMemberListSection.cs 120                // CodeBlockNested.cs:588
	        brItem.Init(this.doc, r);                                                                                                          // CSBuildMemberListSection.cs:121
	        this.AppendItem(brItem);                                                                                                           // CSBuildMemberListSection.cs:124
	        return brItem;                                                                                                                     // CSBuildMemberListSection.cs:125
	    }                                                                                                                                      // CSBuildMemberListSection.cs:126
	                                                                                                                                           // CSBuildMemberListSection.cs:109
	    /// <summary>
	    /// Create new blank Recommendations of type ServiceRequest and add to end of list
	    /// </summary>
	    //Else: C:\Development\HL7\BreastRadiologyLibrary\Projects\FireFragger\FireFragger\CS\CSBuildMemberListSection.cs 114                  // CodeBlockNested.cs:594
	    public ServiceRecommendation AppendServiceRecommendation()                                                                             // CSBuildMemberListSection.cs:116
	    {                                                                                                                                      // CSBuildMemberListSection.cs:118
	        ServiceRecommendation brItem = new ServiceRecommendation();                                                                        // CSBuildMemberListSection.cs:119
	        //Else: C:\Development\HL7\BreastRadiologyLibrary\Projects\FireFragger\FireFragger\CS\CSBuildMemberListSection.cs 120              // CodeBlockNested.cs:594
	        brItem.Init(this.doc);                                                                                                             // CSBuildMemberListSection.cs:122
	        this.AppendItem(brItem);                                                                                                           // CSBuildMemberListSection.cs:124
	        return brItem;                                                                                                                     // CSBuildMemberListSection.cs:125
	    }                                                                                                                                      // CSBuildMemberListSection.cs:126
	                                                                                                                                           // CSBuildMemberListSection.cs:46
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public Recommendations_Accessor(BreastRadiologyDocument doc) : base("Recommendations_Accessor")                                        // CSBuildMemberListSection.cs:50
	    {                                                                                                                                      // CSBuildMemberListSection.cs:51
	        this.Init(doc, "Recommendations", 0, -1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes", "sectionCodeRecommendations"));// CSBuildMemberListSection.cs:52
	    }                                                                                                                                      // CSBuildMemberListSection.cs:54
	}                                                                                                                                          // CSBuildMemberListSection.cs:55
	//- LocalClassDefs
}
