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
	public class Report_Accessor : MemberListSectionBase<BreastRadReport>                                                                      // BuildMemberListSection.cs:41
	{                                                                                                                                          // BuildMemberListSection.cs:42
	    /// <summary>
	    /// Access propertyName
	    /// </summary>
	    public BreastRadReport Get() => this.FirstOrDefault();                                                                                 // BuildMemberListSection.cs:84
	                                                                                                                                           // BuildMemberListSection.cs:63
	    /// <summary>
	    /// Create new blank Report if one doesnt already exist, and return it
	    /// </summary>
	    public BreastRadReport Create()                                                                                                        // BuildMemberListSection.cs:67
	    {                                                                                                                                      // BuildMemberListSection.cs:68
	        if (this.Count == 0)                                                                                                               // BuildMemberListSection.cs:69
	        {                                                                                                                                  // BuildMemberListSection.cs:70
	            BreastRadReport brItem = new BreastRadReport();                                                                                // BuildMemberListSection.cs:71
	            brItem.Init(this.doc);                                                                                                         // BuildMemberListSection.cs:72
	            this.AppendItem(brItem);                                                                                                       // BuildMemberListSection.cs:73
	        }                                                                                                                                  // BuildMemberListSection.cs:74
	        return this.First();                                                                                                               // BuildMemberListSection.cs:75
	    }                                                                                                                                      // BuildMemberListSection.cs:76
	                                                                                                                                           // BuildMemberListSection.cs:44
	                                                                                                                                           // BuildMemberListSection.cs:46
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public Report_Accessor(BreastRadiologyDocument doc) : base("Report_Accessor")                                                          // BuildMemberListSection.cs:50
	    {                                                                                                                                      // BuildMemberListSection.cs:51
	        this.Init(doc, "Breast Radiology Report", 1, 1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes", "sectionReport"));// BuildMemberListSection.cs:52
	    }                                                                                                                                      // BuildMemberListSection.cs:54
	}                                                                                                                                          // BuildMemberListSection.cs:55
	/// <summary>
	/// Accessor class for 'Clinical Impressions'
	/// [Fhir Element 'Composition.section:impressions]'
	/// </summary>
	public class Impressions_Accessor : MemberListSectionBase<ResourceBase>                                                                    // BuildMemberListSection.cs:41
	{                                                                                                                                          // BuildMemberListSection.cs:42
	    /// <summary>
	    /// Access propertyName
	    /// </summary>
	    public IEnumerable<ResourceBase> All() => this.items;                                                                                  // BuildMemberListSection.cs:134
	                                                                                                                                           // BuildMemberListSection.cs:136
	    /// <summary>
	    /// Access item at indicated location in list
	    /// </summary>
	    public ResourceBase At(Int32 i) => base.items[i];                                                                                      // BuildMemberListSection.cs:140
	                                                                                                                                           // BuildMemberListSection.cs:142
	    /// <summary>
	    /// Access first item in list
	    /// </summary>
	    public new ResourceBase First() => base.First();                                                                                       // BuildMemberListSection.cs:146
	                                                                                                                                           // BuildMemberListSection.cs:147
	    /// <summary>
	    /// Access first item in list or default value if empty
	    /// </summary>
	    public new ResourceBase FirstOrDefault() => base.FirstOrDefault();                                                                     // BuildMemberListSection.cs:151
	                                                                                                                                           // BuildMemberListSection.cs:44
	                                                                                                                                           // BuildMemberListSection.cs:109
	    /// <summary>
	    /// Create new blank Impressions of type ClinicalImpression and add to end of list
	    /// </summary>
	    //If: C:\Development\HL7\BreastRadiologyLibrary\Projects\FireFragger\FireFragger\CS\BuildMemberListSection.cs 114                      // CodeBlockNested.cs:588
	    public ResourceBase Append(Resource r)                                                                                                 // BuildMemberListSection.cs:115
	    {                                                                                                                                      // BuildMemberListSection.cs:118
	        ResourceBase brItem = new ResourceBase();                                                                                          // BuildMemberListSection.cs:119
	        //If: C:\Development\HL7\BreastRadiologyLibrary\Projects\FireFragger\FireFragger\CS\BuildMemberListSection.cs 120                  // CodeBlockNested.cs:588
	        brItem.Init(this.doc, r);                                                                                                          // BuildMemberListSection.cs:121
	        this.AppendItem(brItem);                                                                                                           // BuildMemberListSection.cs:124
	        return brItem;                                                                                                                     // BuildMemberListSection.cs:125
	    }                                                                                                                                      // BuildMemberListSection.cs:126
	                                                                                                                                           // BuildMemberListSection.cs:46
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public Impressions_Accessor(BreastRadiologyDocument doc) : base("Impressions_Accessor")                                                // BuildMemberListSection.cs:50
	    {                                                                                                                                      // BuildMemberListSection.cs:51
	        this.Init(doc, "Clinical Impressions", 0, -1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes", "sectionImpressions"));// BuildMemberListSection.cs:52
	    }                                                                                                                                      // BuildMemberListSection.cs:54
	}                                                                                                                                          // BuildMemberListSection.cs:55
	/// <summary>
	/// Accessor class for 'Findings Right Breast'
	/// [Fhir Element 'Composition.section:findingsRightBreast]'
	/// </summary>
	public class FindingsRightBreast_Accessor : MemberListSectionBase<SectionFindingsRightBreast>                                              // BuildMemberListSection.cs:41
	{                                                                                                                                          // BuildMemberListSection.cs:42
	    /// <summary>
	    /// Access propertyName
	    /// </summary>
	    public SectionFindingsRightBreast Get() => this.FirstOrDefault();                                                                      // BuildMemberListSection.cs:84
	                                                                                                                                           // BuildMemberListSection.cs:63
	    /// <summary>
	    /// Create new blank FindingsRightBreast if one doesnt already exist, and return it
	    /// </summary>
	    public SectionFindingsRightBreast Create()                                                                                             // BuildMemberListSection.cs:67
	    {                                                                                                                                      // BuildMemberListSection.cs:68
	        if (this.Count == 0)                                                                                                               // BuildMemberListSection.cs:69
	        {                                                                                                                                  // BuildMemberListSection.cs:70
	            SectionFindingsRightBreast brItem = new SectionFindingsRightBreast();                                                          // BuildMemberListSection.cs:71
	            brItem.Init(this.doc);                                                                                                         // BuildMemberListSection.cs:72
	            this.AppendItem(brItem);                                                                                                       // BuildMemberListSection.cs:73
	        }                                                                                                                                  // BuildMemberListSection.cs:74
	        return this.First();                                                                                                               // BuildMemberListSection.cs:75
	    }                                                                                                                                      // BuildMemberListSection.cs:76
	                                                                                                                                           // BuildMemberListSection.cs:44
	                                                                                                                                           // BuildMemberListSection.cs:46
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public FindingsRightBreast_Accessor(BreastRadiologyDocument doc) : base("FindingsRightBreast_Accessor")                                // BuildMemberListSection.cs:50
	    {                                                                                                                                      // BuildMemberListSection.cs:51
	        this.Init(doc, "Findings Right Breast", 0, 1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes", "sectionCodeFindingsRightBreast"));// BuildMemberListSection.cs:52
	    }                                                                                                                                      // BuildMemberListSection.cs:54
	}                                                                                                                                          // BuildMemberListSection.cs:55
	/// <summary>
	/// Accessor class for 'Findings Left Breast'
	/// [Fhir Element 'Composition.section:findingsLeftBreast]'
	/// </summary>
	public class FindingsLeftBreast_Accessor : MemberListSectionBase<SectionFindingsLeftBreast>                                                // BuildMemberListSection.cs:41
	{                                                                                                                                          // BuildMemberListSection.cs:42
	    /// <summary>
	    /// Access propertyName
	    /// </summary>
	    public SectionFindingsLeftBreast Get() => this.FirstOrDefault();                                                                       // BuildMemberListSection.cs:84
	                                                                                                                                           // BuildMemberListSection.cs:63
	    /// <summary>
	    /// Create new blank FindingsLeftBreast if one doesnt already exist, and return it
	    /// </summary>
	    public SectionFindingsLeftBreast Create()                                                                                              // BuildMemberListSection.cs:67
	    {                                                                                                                                      // BuildMemberListSection.cs:68
	        if (this.Count == 0)                                                                                                               // BuildMemberListSection.cs:69
	        {                                                                                                                                  // BuildMemberListSection.cs:70
	            SectionFindingsLeftBreast brItem = new SectionFindingsLeftBreast();                                                            // BuildMemberListSection.cs:71
	            brItem.Init(this.doc);                                                                                                         // BuildMemberListSection.cs:72
	            this.AppendItem(brItem);                                                                                                       // BuildMemberListSection.cs:73
	        }                                                                                                                                  // BuildMemberListSection.cs:74
	        return this.First();                                                                                                               // BuildMemberListSection.cs:75
	    }                                                                                                                                      // BuildMemberListSection.cs:76
	                                                                                                                                           // BuildMemberListSection.cs:44
	                                                                                                                                           // BuildMemberListSection.cs:46
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public FindingsLeftBreast_Accessor(BreastRadiologyDocument doc) : base("FindingsLeftBreast_Accessor")                                  // BuildMemberListSection.cs:50
	    {                                                                                                                                      // BuildMemberListSection.cs:51
	        this.Init(doc, "Findings Left Breast", 0, 1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes", "sectionCodeFindingsLeftBreast"));// BuildMemberListSection.cs:52
	    }                                                                                                                                      // BuildMemberListSection.cs:54
	}                                                                                                                                          // BuildMemberListSection.cs:55
	/// <summary>
	/// Accessor class for 'Related Resources'
	/// [Fhir Element 'Composition.section:relatedResources]'
	/// </summary>
	public class RelatedResources_Accessor : MemberListSectionBase<ResourceBase>                                                               // BuildMemberListSection.cs:41
	{                                                                                                                                          // BuildMemberListSection.cs:42
	    /// <summary>
	    /// Access propertyName
	    /// </summary>
	    public IEnumerable<ResourceBase> All() => this.items;                                                                                  // BuildMemberListSection.cs:134
	                                                                                                                                           // BuildMemberListSection.cs:136
	    /// <summary>
	    /// Access item at indicated location in list
	    /// </summary>
	    public ResourceBase At(Int32 i) => base.items[i];                                                                                      // BuildMemberListSection.cs:140
	                                                                                                                                           // BuildMemberListSection.cs:142
	    /// <summary>
	    /// Access first item in list
	    /// </summary>
	    public new ResourceBase First() => base.First();                                                                                       // BuildMemberListSection.cs:146
	                                                                                                                                           // BuildMemberListSection.cs:147
	    /// <summary>
	    /// Access first item in list or default value if empty
	    /// </summary>
	    public new ResourceBase FirstOrDefault() => base.FirstOrDefault();                                                                     // BuildMemberListSection.cs:151
	                                                                                                                                           // BuildMemberListSection.cs:44
	                                                                                                                                           // BuildMemberListSection.cs:109
	    /// <summary>
	    /// Create new blank RelatedResources of type Resource and add to end of list
	    /// </summary>
	    //If: C:\Development\HL7\BreastRadiologyLibrary\Projects\FireFragger\FireFragger\CS\BuildMemberListSection.cs 114                      // CodeBlockNested.cs:588
	    public ResourceBase Append(Resource r)                                                                                                 // BuildMemberListSection.cs:115
	    {                                                                                                                                      // BuildMemberListSection.cs:118
	        ResourceBase brItem = new ResourceBase();                                                                                          // BuildMemberListSection.cs:119
	        //If: C:\Development\HL7\BreastRadiologyLibrary\Projects\FireFragger\FireFragger\CS\BuildMemberListSection.cs 120                  // CodeBlockNested.cs:588
	        brItem.Init(this.doc, r);                                                                                                          // BuildMemberListSection.cs:121
	        this.AppendItem(brItem);                                                                                                           // BuildMemberListSection.cs:124
	        return brItem;                                                                                                                     // BuildMemberListSection.cs:125
	    }                                                                                                                                      // BuildMemberListSection.cs:126
	                                                                                                                                           // BuildMemberListSection.cs:46
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public RelatedResources_Accessor(BreastRadiologyDocument doc) : base("RelatedResources_Accessor")                                      // BuildMemberListSection.cs:50
	    {                                                                                                                                      // BuildMemberListSection.cs:51
	        this.Init(doc, "Related Resources", 0, -1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes", "sectionRelatedResources"));// BuildMemberListSection.cs:52
	    }                                                                                                                                      // BuildMemberListSection.cs:54
	}                                                                                                                                          // BuildMemberListSection.cs:55
	/// <summary>
	/// Accessor class for 'Recommendations'
	/// [Fhir Element 'Composition.section:recommendations]'
	/// </summary>
	public class Recommendations_Accessor : MemberListSectionBase<ResourceBase>                                                                // BuildMemberListSection.cs:41
	{                                                                                                                                          // BuildMemberListSection.cs:42
	    /// <summary>
	    /// Access propertyName
	    /// </summary>
	    public IEnumerable<ResourceBase> All() => this.items;                                                                                  // BuildMemberListSection.cs:134
	                                                                                                                                           // BuildMemberListSection.cs:136
	    /// <summary>
	    /// Access item at indicated location in list
	    /// </summary>
	    public ResourceBase At(Int32 i) => base.items[i];                                                                                      // BuildMemberListSection.cs:140
	                                                                                                                                           // BuildMemberListSection.cs:142
	    /// <summary>
	    /// Access first item in list
	    /// </summary>
	    public new ResourceBase First() => base.First();                                                                                       // BuildMemberListSection.cs:146
	                                                                                                                                           // BuildMemberListSection.cs:147
	    /// <summary>
	    /// Access first item in list or default value if empty
	    /// </summary>
	    public new ResourceBase FirstOrDefault() => base.FirstOrDefault();                                                                     // BuildMemberListSection.cs:151
	                                                                                                                                           // BuildMemberListSection.cs:44
	                                                                                                                                           // BuildMemberListSection.cs:109
	    /// <summary>
	    /// Create new blank Recommendations of type MedicationRequest and add to end of list
	    /// </summary>
	    //If: C:\Development\HL7\BreastRadiologyLibrary\Projects\FireFragger\FireFragger\CS\BuildMemberListSection.cs 114                      // CodeBlockNested.cs:588
	    public ResourceBase AppendMedicationRequest(Resource r)                                                                                // BuildMemberListSection.cs:115
	    {                                                                                                                                      // BuildMemberListSection.cs:118
	        ResourceBase brItem = new ResourceBase();                                                                                          // BuildMemberListSection.cs:119
	        //If: C:\Development\HL7\BreastRadiologyLibrary\Projects\FireFragger\FireFragger\CS\BuildMemberListSection.cs 120                  // CodeBlockNested.cs:588
	        brItem.Init(this.doc, r);                                                                                                          // BuildMemberListSection.cs:121
	        this.AppendItem(brItem);                                                                                                           // BuildMemberListSection.cs:124
	        return brItem;                                                                                                                     // BuildMemberListSection.cs:125
	    }                                                                                                                                      // BuildMemberListSection.cs:126
	                                                                                                                                           // BuildMemberListSection.cs:109
	    /// <summary>
	    /// Create new blank Recommendations of type ServiceRequest and add to end of list
	    /// </summary>
	    //If: C:\Development\HL7\BreastRadiologyLibrary\Projects\FireFragger\FireFragger\CS\BuildMemberListSection.cs 114                      // CodeBlockNested.cs:588
	    public ResourceBase AppendServiceRequest(Resource r)                                                                                   // BuildMemberListSection.cs:115
	    {                                                                                                                                      // BuildMemberListSection.cs:118
	        ResourceBase brItem = new ResourceBase();                                                                                          // BuildMemberListSection.cs:119
	        //If: C:\Development\HL7\BreastRadiologyLibrary\Projects\FireFragger\FireFragger\CS\BuildMemberListSection.cs 120                  // CodeBlockNested.cs:588
	        brItem.Init(this.doc, r);                                                                                                          // BuildMemberListSection.cs:121
	        this.AppendItem(brItem);                                                                                                           // BuildMemberListSection.cs:124
	        return brItem;                                                                                                                     // BuildMemberListSection.cs:125
	    }                                                                                                                                      // BuildMemberListSection.cs:126
	                                                                                                                                           // BuildMemberListSection.cs:109
	    /// <summary>
	    /// Create new blank Recommendations of type ServiceRequest and add to end of list
	    /// </summary>
	    //Else: C:\Development\HL7\BreastRadiologyLibrary\Projects\FireFragger\FireFragger\CS\BuildMemberListSection.cs 114                    // CodeBlockNested.cs:594
	    public ServiceRecommendation AppendServiceRecommendation()                                                                             // BuildMemberListSection.cs:116
	    {                                                                                                                                      // BuildMemberListSection.cs:118
	        ServiceRecommendation brItem = new ServiceRecommendation();                                                                        // BuildMemberListSection.cs:119
	        //Else: C:\Development\HL7\BreastRadiologyLibrary\Projects\FireFragger\FireFragger\CS\BuildMemberListSection.cs 120                // CodeBlockNested.cs:594
	        brItem.Init(this.doc);                                                                                                             // BuildMemberListSection.cs:122
	        this.AppendItem(brItem);                                                                                                           // BuildMemberListSection.cs:124
	        return brItem;                                                                                                                     // BuildMemberListSection.cs:125
	    }                                                                                                                                      // BuildMemberListSection.cs:126
	                                                                                                                                           // BuildMemberListSection.cs:46
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public Recommendations_Accessor(BreastRadiologyDocument doc) : base("Recommendations_Accessor")                                        // BuildMemberListSection.cs:50
	    {                                                                                                                                      // BuildMemberListSection.cs:51
	        this.Init(doc, "Recommendations", 0, -1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes", "sectionCodeRecommendations"));// BuildMemberListSection.cs:52
	    }                                                                                                                                      // BuildMemberListSection.cs:54
	}                                                                                                                                          // BuildMemberListSection.cs:55
	//- LocalClassDefs
}
