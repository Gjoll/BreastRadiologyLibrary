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
		//+ Fields
		                                                                                                                                          // CSDefineComposition.cs:84
		/// <summary>
		/// Section report
		/// Composition.section:report
		/// </summary>
		Coding ReportSectionCode = new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes", "sectionReport");// CSDefineComposition.cs:89
		                                                                                                                                          // CSDefineComposition.cs:95
		/// <summary>
		/// propertyName field
		/// </summary>
		BreastRadReport report;                                                                                                                   // CSDefineComposition.cs:99
		                                                                                                                                          // CSDefineComposition.cs:100
		/// <summary>
		/// Access propertyName
		/// </summary>
		public BreastRadReport Report => this.report;                                                                                             // CSDefineComposition.cs:104
		                                                                                                                                          // CSDefineComposition.cs:106
		/// <summary>
		/// Create new blank {propertyName}
		/// </summary>
		public BreastRadReport CreateReport()                                                                                                     // CSDefineComposition.cs:110
		{                                                                                                                                         // CSDefineComposition.cs:111
		    if (this.Report != null)                                                                                                              // CSDefineComposition.cs:112
		        throw new Exception("Report already has a value");                                                                                // CSDefineComposition.cs:113
		    BreastRadReport retVal = new BreastRadReport(this.doc);                                                                               // CSDefineComposition.cs:114
		    this.report = retVal;                                                                                                                 // CSDefineComposition.cs:115
		    return retVal;                                                                                                                        // CSDefineComposition.cs:116
		}                                                                                                                                         // CSDefineComposition.cs:117
		                                                                                                                                          // CSDefineComposition.cs:84
		/// <summary>
		/// Section impressions
		/// Composition.section:impressions
		/// </summary>
		Coding ImpressionsSectionCode = new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes", "sectionImpressions");// CSDefineComposition.cs:89
		                                                                                                                                          // CSDefineComposition.cs:128
		/// <summary>
		/// propertyName field
		/// </summary>
		List<ClinicalImpressionBase> impressions = new List<ClinicalImpressionBase>();                                                            // CSDefineComposition.cs:132
		                                                                                                                                          // CSDefineComposition.cs:133
		/// <summary>
		/// Access propertyName
		/// </summary>
		public IEnumerable<ClinicalImpressionBase> Impressions => this.impressions;                                                               // CSDefineComposition.cs:137
		                                                                                                                                          // CSDefineComposition.cs:143
		/// <summary>
		/// Append new blank {propertyName}
		/// </summary>
		public ClinicalImpressionBase AppendImpressions()                                                                                         // CSDefineComposition.cs:147
		{                                                                                                                                         // CSDefineComposition.cs:148
		    ClinicalImpressionBase retVal = new ClinicalImpressionBase(this.doc);                                                                 // CSDefineComposition.cs:149
		    this.impressions.Add(retVal);                                                                                                         // CSDefineComposition.cs:150
		    return retVal;                                                                                                                        // CSDefineComposition.cs:151
		}                                                                                                                                         // CSDefineComposition.cs:152
		                                                                                                                                          // CSDefineComposition.cs:84
		/// <summary>
		/// Section relatedResources
		/// Composition.section:relatedResources
		/// </summary>
		Coding RelatedResourcesSectionCode = new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes", "sectionRelatedResources");// CSDefineComposition.cs:89
		                                                                                                                                          // CSDefineComposition.cs:128
		/// <summary>
		/// propertyName field
		/// </summary>
		List<ResourceBase> relatedResources = new List<ResourceBase>();                                                                           // CSDefineComposition.cs:132
		                                                                                                                                          // CSDefineComposition.cs:133
		/// <summary>
		/// Access propertyName
		/// </summary>
		public IEnumerable<ResourceBase> RelatedResources => this.relatedResources;                                                               // CSDefineComposition.cs:137
		                                                                                                                                          // CSDefineComposition.cs:143
		/// <summary>
		/// Append new blank {propertyName}
		/// </summary>
		public ResourceBase AppendRelatedResources()                                                                                              // CSDefineComposition.cs:147
		{                                                                                                                                         // CSDefineComposition.cs:148
		    ResourceBase retVal = new ResourceBase(this.doc);                                                                                     // CSDefineComposition.cs:149
		    this.relatedResources.Add(retVal);                                                                                                    // CSDefineComposition.cs:150
		    return retVal;                                                                                                                        // CSDefineComposition.cs:151
		}                                                                                                                                         // CSDefineComposition.cs:152
		                                                                                                                                          // CSDefineComposition.cs:84
		/// <summary>
		/// Section recommendations
		/// Composition.section:recommendations
		/// </summary>
		Coding RecommendationsSectionCode = new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes", "sectionCodeRecommendations");// CSDefineComposition.cs:89
		                                                                                                                                          // CSDefineComposition.cs:128
		/// <summary>
		/// propertyName field
		/// </summary>
		List<ResourceBase> recommendations = new List<ResourceBase>();                                                                            // CSDefineComposition.cs:132
		                                                                                                                                          // CSDefineComposition.cs:133
		/// <summary>
		/// Access propertyName
		/// </summary>
		public IEnumerable<ResourceBase> Recommendations => this.recommendations;                                                                 // CSDefineComposition.cs:137
		                                                                                                                                          // CSDefineComposition.cs:162
		/// <summary>
		/// Append new blank Recommendations of type MedicationRequestBase
		/// </summary>
		public MedicationRequestBase AppendRecommendations(MedicationRequestBase resource)                                                        // CSDefineComposition.cs:166
		{                                                                                                                                         // CSDefineComposition.cs:167
		    MedicationRequestBase retVal = new MedicationRequestBase(this.doc, resource);                                                         // CSDefineComposition.cs:168
		    this.recommendations.Add(retVal);                                                                                                     // CSDefineComposition.cs:169
		    return retVal;                                                                                                                        // CSDefineComposition.cs:170
		}                                                                                                                                         // CSDefineComposition.cs:171
		                                                                                                                                          // CSDefineComposition.cs:162
		/// <summary>
		/// Append new blank Recommendations of type ServiceRequestBase
		/// </summary>
		public ServiceRequestBase AppendRecommendations(ServiceRequestBase resource)                                                              // CSDefineComposition.cs:166
		{                                                                                                                                         // CSDefineComposition.cs:167
		    ServiceRequestBase retVal = new ServiceRequestBase(this.doc, resource);                                                               // CSDefineComposition.cs:168
		    this.recommendations.Add(retVal);                                                                                                     // CSDefineComposition.cs:169
		    return retVal;                                                                                                                        // CSDefineComposition.cs:170
		}                                                                                                                                         // CSDefineComposition.cs:171
		                                                                                                                                          // CSDefineComposition.cs:162
		/// <summary>
		/// Append new blank Recommendations of type ServiceRecommendation
		/// </summary>
		public ServiceRecommendation AppendRecommendations(ServiceRecommendation resource)                                                        // CSDefineComposition.cs:166
		{                                                                                                                                         // CSDefineComposition.cs:167
		    ServiceRecommendation retVal = new ServiceRecommendation(this.doc, resource);                                                         // CSDefineComposition.cs:168
		    this.recommendations.Add(retVal);                                                                                                     // CSDefineComposition.cs:169
		    return retVal;                                                                                                                        // CSDefineComposition.cs:170
		}                                                                                                                                         // CSDefineComposition.cs:171
		//- Fields

		public BreastRadComposition(BreastRadiologyDocument doc, Composition resource) : base(doc, resource)
		{
			//+ Constructor
			//- Constructor
		}

		public BreastRadComposition(BreastRadiologyDocument doc) : this(doc, new Composition())
		{
		}

		public override void Write()
		{
		//+ WriteCode
		SetProfileUrl("http://hl7.org/fhir/us/breast-radiology/StructureDefinition/BreastRadComposition");                                        // CSDefineBase.cs:109
		ClearSection();                                                                                                                           // CSDefineComposition.cs:38
		WriteSection<BreastRadReport>("Breast Radiology Report", ReportSectionCode, 1, 1, this.report);                                           // CSDefineComposition.cs:182
		WriteSection<ClinicalImpressionBase>("Clinical Impressions", ImpressionsSectionCode, 0, -1, this.impressions);                            // CSDefineComposition.cs:182
		WriteSection<ResourceBase>("Related Resources", RelatedResourcesSectionCode, 0, -1, this.relatedResources);                               // CSDefineComposition.cs:182
		WriteSection<ServiceRecommendation>("Recommendations", RecommendationsSectionCode, 0, -1, this.recommendations);                          // CSDefineComposition.cs:182
		//- WriteCode
		}

		public override void Read()
		{
		//+ ReadCode
		                                                                                                                                          // CSDefineComposition.cs:121
		this.report = ReadSection<BreastRadReport>(this.ReportSectionCode);                                                                       // CSDefineComposition.cs:122
		ReadSection<ClinicalImpressionBase>(ImpressionsSectionCode, 0, -1, this.impressions);                                                     // CSDefineComposition.cs:177
		ReadSection<ResourceBase>(RelatedResourcesSectionCode, 0, -1, this.relatedResources);                                                     // CSDefineComposition.cs:177
		ReadSection<ServiceRecommendation>(RecommendationsSectionCode, 0, -1, this.recommendations);                                              // CSDefineComposition.cs:177
		//- ReadCode
		}

		//+ Methods
		//- Methods
	}
}
