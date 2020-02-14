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
		                                                                                                                                          // CSDefineComposition.cs:131
		/// <summary>
		/// Section report
		/// Composition.section:report
		/// </summary>
		Coding ReportSectionCode = new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes", "sectionReport");// CSDefineComposition.cs:136
		                                                                                                                                          // CSDefineComposition.cs:142
		/// <summary>
		/// propertyName field
		/// </summary>
		BreastRadReport report;                                                                                                                   // CSDefineComposition.cs:146
		                                                                                                                                          // CSDefineComposition.cs:147
		/// <summary>
		/// Access propertyName
		/// </summary>
		public BreastRadReport Report => this.report;                                                                                             // CSDefineComposition.cs:151
		                                                                                                                                          // CSDefineComposition.cs:153
		/// <summary>
		/// Create new blank {propertyName}
		/// </summary>
		public BreastRadReport CreateReport()                                                                                                     // CSDefineComposition.cs:157
		{                                                                                                                                         // CSDefineComposition.cs:158
		    if (this.Report != null)                                                                                                              // CSDefineComposition.cs:159
		        throw new Exception("Report already has a value");                                                                                // CSDefineComposition.cs:160
		    BreastRadReport retVal = new BreastRadReport(this.doc);                                                                               // CSDefineComposition.cs:161
		    this.report = retVal;                                                                                                                 // CSDefineComposition.cs:162
		    return retVal;                                                                                                                        // CSDefineComposition.cs:163
		}                                                                                                                                         // CSDefineComposition.cs:164
		                                                                                                                                          // CSDefineComposition.cs:131
		/// <summary>
		/// Section impressions
		/// Composition.section:impressions
		/// </summary>
		Coding ImpressionsSectionCode = new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes", "sectionImpressions");// CSDefineComposition.cs:136
		                                                                                                                                          // CSDefineComposition.cs:175
		/// <summary>
		/// propertyName field
		/// </summary>
		List<ResourceBase> impressions = new List<ResourceBase>();                                                                                // CSDefineComposition.cs:179
		                                                                                                                                          // CSDefineComposition.cs:180
		/// <summary>
		/// Access propertyName
		/// </summary>
		public IEnumerable<ResourceBase> Impressions => this.impressions;                                                                         // CSDefineComposition.cs:184
		                                                                                                                                          // CSDefineComposition.cs:28
		/// <summary>
		/// Append new blank Impressions of type ResourceBase
		/// </summary>
		public ResourceBase AppendImpressions(DomainResource resource)                                                                            // CSDefineComposition.cs:32
		{                                                                                                                                         // CSDefineComposition.cs:33
		    ResourceBase retVal = new ResourceBase(this.doc, resource);                                                                           // CSDefineComposition.cs:34
		    this.impressions.Add(retVal);                                                                                                         // CSDefineComposition.cs:35
		    return retVal;                                                                                                                        // CSDefineComposition.cs:36
		}                                                                                                                                         // CSDefineComposition.cs:37
		                                                                                                                                          // CSDefineComposition.cs:131
		/// <summary>
		/// Section relatedResources
		/// Composition.section:relatedResources
		/// </summary>
		Coding RelatedResourcesSectionCode = new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes", "sectionRelatedResources");// CSDefineComposition.cs:136
		                                                                                                                                          // CSDefineComposition.cs:175
		/// <summary>
		/// propertyName field
		/// </summary>
		List<ResourceBase> relatedResources = new List<ResourceBase>();                                                                           // CSDefineComposition.cs:179
		                                                                                                                                          // CSDefineComposition.cs:180
		/// <summary>
		/// Access propertyName
		/// </summary>
		public IEnumerable<ResourceBase> RelatedResources => this.relatedResources;                                                               // CSDefineComposition.cs:184
		                                                                                                                                          // CSDefineComposition.cs:28
		/// <summary>
		/// Append new blank RelatedResources of type ResourceBase
		/// </summary>
		public ResourceBase AppendRelatedResources(DomainResource resource)                                                                       // CSDefineComposition.cs:32
		{                                                                                                                                         // CSDefineComposition.cs:33
		    ResourceBase retVal = new ResourceBase(this.doc, resource);                                                                           // CSDefineComposition.cs:34
		    this.relatedResources.Add(retVal);                                                                                                    // CSDefineComposition.cs:35
		    return retVal;                                                                                                                        // CSDefineComposition.cs:36
		}                                                                                                                                         // CSDefineComposition.cs:37
		                                                                                                                                          // CSDefineComposition.cs:131
		/// <summary>
		/// Section recommendations
		/// Composition.section:recommendations
		/// </summary>
		Coding RecommendationsSectionCode = new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes", "sectionCodeRecommendations");// CSDefineComposition.cs:136
		                                                                                                                                          // CSDefineComposition.cs:175
		/// <summary>
		/// propertyName field
		/// </summary>
		List<ResourceBase> recommendations = new List<ResourceBase>();                                                                            // CSDefineComposition.cs:179
		                                                                                                                                          // CSDefineComposition.cs:180
		/// <summary>
		/// Access propertyName
		/// </summary>
		public IEnumerable<ResourceBase> Recommendations => this.recommendations;                                                                 // CSDefineComposition.cs:184
		                                                                                                                                          // CSDefineComposition.cs:28
		/// <summary>
		/// Append new blank Recommendations of type ResourceBase
		/// </summary>
		public ResourceBase AppendRecommendations(MedicationRequest resource)                                                                     // CSDefineComposition.cs:32
		{                                                                                                                                         // CSDefineComposition.cs:33
		    ResourceBase retVal = new ResourceBase(this.doc, resource);                                                                           // CSDefineComposition.cs:34
		    this.recommendations.Add(retVal);                                                                                                     // CSDefineComposition.cs:35
		    return retVal;                                                                                                                        // CSDefineComposition.cs:36
		}                                                                                                                                         // CSDefineComposition.cs:37
		                                                                                                                                          // CSDefineComposition.cs:28
		/// <summary>
		/// Append new blank Recommendations of type ResourceBase
		/// </summary>
		public ResourceBase AppendRecommendations(ServiceRequest resource)                                                                        // CSDefineComposition.cs:32
		{                                                                                                                                         // CSDefineComposition.cs:33
		    ResourceBase retVal = new ResourceBase(this.doc, resource);                                                                           // CSDefineComposition.cs:34
		    this.recommendations.Add(retVal);                                                                                                     // CSDefineComposition.cs:35
		    return retVal;                                                                                                                        // CSDefineComposition.cs:36
		}                                                                                                                                         // CSDefineComposition.cs:37
		                                                                                                                                          // CSDefineComposition.cs:58
		/// <summary>
		/// Append new blank Recommendations
		/// </summary>
		public ServiceRecommendation AppendRecommendations(ServiceRecommendation brClass = null)                                                  // CSDefineComposition.cs:62
		{                                                                                                                                         // CSDefineComposition.cs:63
		    if (brClass == null)                                                                                                                  // CSDefineComposition.cs:64
		        brClass = new ServiceRecommendation(this.doc);                                                                                    // CSDefineComposition.cs:65
		    this.recommendations.Add(brClass);                                                                                                    // CSDefineComposition.cs:66
		    return brClass;                                                                                                                       // CSDefineComposition.cs:67
		}                                                                                                                                         // CSDefineComposition.cs:68
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
		ClearSection();                                                                                                                           // CSDefineComposition.cs:93
		WriteSection<BreastRadReport>("Breast Radiology Report", ReportSectionCode, 1, 1, this.report);                                           // CSDefineComposition.cs:211
		WriteSection<ResourceBase>("Clinical Impressions", ImpressionsSectionCode, 0, -1, this.impressions);                                      // CSDefineComposition.cs:211
		WriteSection<ResourceBase>("Related Resources", RelatedResourcesSectionCode, 0, -1, this.relatedResources);                               // CSDefineComposition.cs:211
		WriteSection<ResourceBase>("Recommendations", RecommendationsSectionCode, 0, -1, this.recommendations);                                   // CSDefineComposition.cs:211
		//- WriteCode
		}

		public override void Read()
		{
		//+ ReadCode
		                                                                                                                                          // CSDefineComposition.cs:168
		this.report = ReadSection<BreastRadReport>("Breast Radiology Report", this.ReportSectionCode, 1);                                         // CSDefineComposition.cs:169
		ReadSection<ResourceBase>("Clinical Impressions", ImpressionsSectionCode, 0, -1, this.impressions);                                       // CSDefineComposition.cs:206
		ReadSection<ResourceBase>("Related Resources", RelatedResourcesSectionCode, 0, -1, this.relatedResources);                                // CSDefineComposition.cs:206
		ReadSection<ResourceBase>("Recommendations", RecommendationsSectionCode, 0, -1, this.recommendations);                                    // CSDefineComposition.cs:206
		//- ReadCode
		}

		//+ Methods
		//- Methods
	}
}
