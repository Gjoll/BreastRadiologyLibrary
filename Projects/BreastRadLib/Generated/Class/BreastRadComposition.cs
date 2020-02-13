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
		                                                                                                                                          // CSDefineComposition.cs:116
		/// <summary>
		/// Section report
		/// Composition.section:report
		/// </summary>
		Coding ReportSectionCode = new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes", "sectionReport");// CSDefineComposition.cs:121
		                                                                                                                                          // CSDefineComposition.cs:127
		/// <summary>
		/// propertyName field
		/// </summary>
		BreastRadReport report;                                                                                                                   // CSDefineComposition.cs:131
		                                                                                                                                          // CSDefineComposition.cs:132
		/// <summary>
		/// Access propertyName
		/// </summary>
		public BreastRadReport Report => this.report;                                                                                             // CSDefineComposition.cs:136
		                                                                                                                                          // CSDefineComposition.cs:138
		/// <summary>
		/// Create new blank {propertyName}
		/// </summary>
		public BreastRadReport CreateReport()                                                                                                     // CSDefineComposition.cs:142
		{                                                                                                                                         // CSDefineComposition.cs:143
		    if (this.Report != null)                                                                                                              // CSDefineComposition.cs:144
		        throw new Exception("Report already has a value");                                                                                // CSDefineComposition.cs:145
		    BreastRadReport retVal = new BreastRadReport(this.doc);                                                                               // CSDefineComposition.cs:146
		    this.report = retVal;                                                                                                                 // CSDefineComposition.cs:147
		    return retVal;                                                                                                                        // CSDefineComposition.cs:148
		}                                                                                                                                         // CSDefineComposition.cs:149
		                                                                                                                                          // CSDefineComposition.cs:116
		/// <summary>
		/// Section impressions
		/// Composition.section:impressions
		/// </summary>
		Coding ImpressionsSectionCode = new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes", "sectionImpressions");// CSDefineComposition.cs:121
		                                                                                                                                          // CSDefineComposition.cs:160
		/// <summary>
		/// propertyName field
		/// </summary>
		List<ClinicalImpressionBase> impressions = new List<ClinicalImpressionBase>();                                                            // CSDefineComposition.cs:164
		                                                                                                                                          // CSDefineComposition.cs:165
		/// <summary>
		/// Access propertyName
		/// </summary>
		public IEnumerable<ClinicalImpressionBase> Impressions => this.impressions;                                                               // CSDefineComposition.cs:169
		                                                                                                                                          // CSDefineComposition.cs:44
		/// <summary>
		/// Append new blank Impressions
		/// </summary>
		public ClinicalImpressionBase AppendImpressions()                                                                                         // CSDefineComposition.cs:48
		{                                                                                                                                         // CSDefineComposition.cs:49
		    ClinicalImpressionBase retVal = new ClinicalImpressionBase(this.doc);                                                                 // CSDefineComposition.cs:50
		    this.impressions.Add(retVal);                                                                                                         // CSDefineComposition.cs:51
		    return retVal;                                                                                                                        // CSDefineComposition.cs:52
		}                                                                                                                                         // CSDefineComposition.cs:53
		                                                                                                                                          // CSDefineComposition.cs:116
		/// <summary>
		/// Section relatedResources
		/// Composition.section:relatedResources
		/// </summary>
		Coding RelatedResourcesSectionCode = new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes", "sectionRelatedResources");// CSDefineComposition.cs:121
		                                                                                                                                          // CSDefineComposition.cs:160
		/// <summary>
		/// propertyName field
		/// </summary>
		List<ResourceBase> relatedResources = new List<ResourceBase>();                                                                           // CSDefineComposition.cs:164
		                                                                                                                                          // CSDefineComposition.cs:165
		/// <summary>
		/// Access propertyName
		/// </summary>
		public IEnumerable<ResourceBase> RelatedResources => this.relatedResources;                                                               // CSDefineComposition.cs:169
		                                                                                                                                          // CSDefineComposition.cs:44
		/// <summary>
		/// Append new blank RelatedResources
		/// </summary>
		public ResourceBase AppendRelatedResources()                                                                                              // CSDefineComposition.cs:48
		{                                                                                                                                         // CSDefineComposition.cs:49
		    ResourceBase retVal = new ResourceBase(this.doc);                                                                                     // CSDefineComposition.cs:50
		    this.relatedResources.Add(retVal);                                                                                                    // CSDefineComposition.cs:51
		    return retVal;                                                                                                                        // CSDefineComposition.cs:52
		}                                                                                                                                         // CSDefineComposition.cs:53
		                                                                                                                                          // CSDefineComposition.cs:116
		/// <summary>
		/// Section recommendations
		/// Composition.section:recommendations
		/// </summary>
		Coding RecommendationsSectionCode = new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes", "sectionCodeRecommendations");// CSDefineComposition.cs:121
		                                                                                                                                          // CSDefineComposition.cs:160
		/// <summary>
		/// propertyName field
		/// </summary>
		List<ResourceBase> recommendations = new List<ResourceBase>();                                                                            // CSDefineComposition.cs:164
		                                                                                                                                          // CSDefineComposition.cs:165
		/// <summary>
		/// Access propertyName
		/// </summary>
		public IEnumerable<ResourceBase> Recommendations => this.recommendations;                                                                 // CSDefineComposition.cs:169
		                                                                                                                                          // CSDefineComposition.cs:28
		/// <summary>
		/// Append new blank Recommendations_MedicationRequest of type MedicationRequestBase
		/// </summary>
		public MedicationRequestBase AppendRecommendations_MedicationRequest(xxyyz resource)                                                      // CSDefineComposition.cs:32
		{                                                                                                                                         // CSDefineComposition.cs:33
		    MedicationRequestBase retVal = new MedicationRequestBase(this.doc, resource);                                                         // CSDefineComposition.cs:34
		    this.recommendations.Add(retVal);                                                                                                     // CSDefineComposition.cs:35
		    return retVal;                                                                                                                        // CSDefineComposition.cs:36
		}                                                                                                                                         // CSDefineComposition.cs:37
		                                                                                                                                          // CSDefineComposition.cs:28
		/// <summary>
		/// Append new blank Recommendations_ServiceRequest of type ServiceRequestBase
		/// </summary>
		public ServiceRequestBase AppendRecommendations_ServiceRequest(xxyyz resource)                                                            // CSDefineComposition.cs:32
		{                                                                                                                                         // CSDefineComposition.cs:33
		    ServiceRequestBase retVal = new ServiceRequestBase(this.doc, resource);                                                               // CSDefineComposition.cs:34
		    this.recommendations.Add(retVal);                                                                                                     // CSDefineComposition.cs:35
		    return retVal;                                                                                                                        // CSDefineComposition.cs:36
		}                                                                                                                                         // CSDefineComposition.cs:37
		                                                                                                                                          // CSDefineComposition.cs:28
		/// <summary>
		/// Append new blank Recommendations_ServiceRecommendation of type ServiceRecommendationBase
		/// </summary>
		public ServiceRecommendationBase AppendRecommendations_ServiceRecommendation(xxyyz resource)                                              // CSDefineComposition.cs:32
		{                                                                                                                                         // CSDefineComposition.cs:33
		    ServiceRecommendationBase retVal = new ServiceRecommendationBase(this.doc, resource);                                                 // CSDefineComposition.cs:34
		    this.recommendations.Add(retVal);                                                                                                     // CSDefineComposition.cs:35
		    return retVal;                                                                                                                        // CSDefineComposition.cs:36
		}                                                                                                                                         // CSDefineComposition.cs:37
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
		ClearSection();                                                                                                                           // CSDefineComposition.cs:70
		WriteSection<BreastRadReport>("Breast Radiology Report", ReportSectionCode, 1, 1, this.report);                                           // CSDefineComposition.cs:196
		WriteSection<ClinicalImpressionBase>("Clinical Impressions", ImpressionsSectionCode, 0, -1, this.impressions);                            // CSDefineComposition.cs:196
		WriteSection<ResourceBase>("Related Resources", RelatedResourcesSectionCode, 0, -1, this.relatedResources);                               // CSDefineComposition.cs:196
		WriteSection<ResourceBase>("Recommendations", RecommendationsSectionCode, 0, -1, this.recommendations);                                   // CSDefineComposition.cs:196
		//- WriteCode
		}

		public override void Read()
		{
		//+ ReadCode
		                                                                                                                                          // CSDefineComposition.cs:153
		this.report = ReadSection<BreastRadReport>(this.ReportSectionCode);                                                                       // CSDefineComposition.cs:154
		ReadSection<ClinicalImpressionBase>(ImpressionsSectionCode, 0, -1, this.impressions);                                                     // CSDefineComposition.cs:191
		ReadSection<ResourceBase>(RelatedResourcesSectionCode, 0, -1, this.relatedResources);                                                     // CSDefineComposition.cs:191
		ReadSection<ResourceBase>(RecommendationsSectionCode, 0, -1, this.recommendations);                                                       // CSDefineComposition.cs:191
		//- ReadCode
		}

		//+ Methods
		//- Methods
	}
}
