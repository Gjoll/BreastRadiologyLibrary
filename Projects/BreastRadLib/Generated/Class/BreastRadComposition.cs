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
		                                                                                                                                          // CSDefineComposition.cs:130
		/// <summary>
		/// Section report
		/// Composition.section:report
		/// </summary>
		Coding ReportSectionCode = new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes", "sectionReport");// CSDefineComposition.cs:135
		                                                                                                                                          // CSDefineComposition.cs:141
		/// <summary>
		/// propertyName field
		/// </summary>
		BreastRadReport report;                                                                                                                   // CSDefineComposition.cs:145
		                                                                                                                                          // CSDefineComposition.cs:146
		/// <summary>
		/// Access propertyName
		/// </summary>
		public BreastRadReport Report => this.report;                                                                                             // CSDefineComposition.cs:150
		                                                                                                                                          // CSDefineComposition.cs:152
		/// <summary>
		/// Create new blank {propertyName}
		/// </summary>
		public BreastRadReport CreateReport()                                                                                                     // CSDefineComposition.cs:156
		{                                                                                                                                         // CSDefineComposition.cs:157
		    if (this.Report != null)                                                                                                              // CSDefineComposition.cs:158
		        throw new Exception("Report already has a value");                                                                                // CSDefineComposition.cs:159
		    BreastRadReport retVal = new BreastRadReport(this.doc);                                                                               // CSDefineComposition.cs:160
		    this.report = retVal;                                                                                                                 // CSDefineComposition.cs:161
		    return retVal;                                                                                                                        // CSDefineComposition.cs:162
		}                                                                                                                                         // CSDefineComposition.cs:163
		                                                                                                                                          // CSDefineComposition.cs:130
		/// <summary>
		/// Section impressions
		/// Composition.section:impressions
		/// </summary>
		Coding ImpressionsSectionCode = new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes", "sectionImpressions");// CSDefineComposition.cs:135
		                                                                                                                                          // CSDefineComposition.cs:174
		/// <summary>
		/// propertyName field
		/// </summary>
		List<ResourceBase> impressions = new List<ResourceBase>();                                                                                // CSDefineComposition.cs:178
		                                                                                                                                          // CSDefineComposition.cs:179
		/// <summary>
		/// Access propertyName
		/// </summary>
		public IEnumerable<ResourceBase> Impressions => this.impressions;                                                                         // CSDefineComposition.cs:183
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
		                                                                                                                                          // CSDefineComposition.cs:130
		/// <summary>
		/// Section relatedResources
		/// Composition.section:relatedResources
		/// </summary>
		Coding RelatedResourcesSectionCode = new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes", "sectionRelatedResources");// CSDefineComposition.cs:135
		                                                                                                                                          // CSDefineComposition.cs:174
		/// <summary>
		/// propertyName field
		/// </summary>
		List<ResourceBase> relatedResources = new List<ResourceBase>();                                                                           // CSDefineComposition.cs:178
		                                                                                                                                          // CSDefineComposition.cs:179
		/// <summary>
		/// Access propertyName
		/// </summary>
		public IEnumerable<ResourceBase> RelatedResources => this.relatedResources;                                                               // CSDefineComposition.cs:183
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
		                                                                                                                                          // CSDefineComposition.cs:130
		/// <summary>
		/// Section recommendations
		/// Composition.section:recommendations
		/// </summary>
		Coding RecommendationsSectionCode = new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes", "sectionCodeRecommendations");// CSDefineComposition.cs:135
		                                                                                                                                          // CSDefineComposition.cs:174
		/// <summary>
		/// propertyName field
		/// </summary>
		List<ResourceBase> recommendations = new List<ResourceBase>();                                                                            // CSDefineComposition.cs:178
		                                                                                                                                          // CSDefineComposition.cs:179
		/// <summary>
		/// Access propertyName
		/// </summary>
		public IEnumerable<ResourceBase> Recommendations => this.recommendations;                                                                 // CSDefineComposition.cs:183
		                                                                                                                                          // CSDefineComposition.cs:56
		/// <summary>
		/// Append new blank Recommendations
		/// </summary>
		public ResourceBase AppendRecommendations(MedicationRequest resource = null)                                                              // CSDefineComposition.cs:60
		{                                                                                                                                         // CSDefineComposition.cs:61
		    if (resource == null)                                                                                                                 // CSDefineComposition.cs:62
		        resource = new MedicationRequest();                                                                                               // CSDefineComposition.cs:63
		    ResourceBase retVal = new ResourceBase(this.doc, resource);                                                                           // CSDefineComposition.cs:64
		    this.recommendations.Add(retVal);                                                                                                     // CSDefineComposition.cs:65
		    return retVal;                                                                                                                        // CSDefineComposition.cs:66
		}                                                                                                                                         // CSDefineComposition.cs:67
		                                                                                                                                          // CSDefineComposition.cs:56
		/// <summary>
		/// Append new blank Recommendations
		/// </summary>
		public ResourceBase AppendRecommendations(ServiceRequest resource = null)                                                                 // CSDefineComposition.cs:60
		{                                                                                                                                         // CSDefineComposition.cs:61
		    if (resource == null)                                                                                                                 // CSDefineComposition.cs:62
		        resource = new ServiceRequest();                                                                                                  // CSDefineComposition.cs:63
		    ResourceBase retVal = new ResourceBase(this.doc, resource);                                                                           // CSDefineComposition.cs:64
		    this.recommendations.Add(retVal);                                                                                                     // CSDefineComposition.cs:65
		    return retVal;                                                                                                                        // CSDefineComposition.cs:66
		}                                                                                                                                         // CSDefineComposition.cs:67
		                                                                                                                                          // CSDefineComposition.cs:56
		/// <summary>
		/// Append new blank Recommendations
		/// </summary>
		public ServiceRecommendation AppendRecommendations(ServiceRequest resource = null)                                                        // CSDefineComposition.cs:60
		{                                                                                                                                         // CSDefineComposition.cs:61
		    if (resource == null)                                                                                                                 // CSDefineComposition.cs:62
		        resource = new ServiceRequest();                                                                                                  // CSDefineComposition.cs:63
		    ServiceRecommendation retVal = new ServiceRecommendation(this.doc, resource);                                                         // CSDefineComposition.cs:64
		    this.recommendations.Add(retVal);                                                                                                     // CSDefineComposition.cs:65
		    return retVal;                                                                                                                        // CSDefineComposition.cs:66
		}                                                                                                                                         // CSDefineComposition.cs:67
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
		ClearSection();                                                                                                                           // CSDefineComposition.cs:92
		WriteSection<BreastRadReport>("Breast Radiology Report", ReportSectionCode, 1, 1, this.report);                                           // CSDefineComposition.cs:214
		WriteSection<ResourceBase>("Clinical Impressions", ImpressionsSectionCode, 0, -1, this.impressions);                                      // CSDefineComposition.cs:214
		WriteSection<ResourceBase>("Related Resources", RelatedResourcesSectionCode, 0, -1, this.relatedResources);                               // CSDefineComposition.cs:214
		WriteSection<ResourceBase>("Recommendations", RecommendationsSectionCode, 0, -1, this.recommendations);                                   // CSDefineComposition.cs:214
		//- WriteCode
		}

		public override void Read()
		{
		//+ ReadCode
		                                                                                                                                          // CSDefineComposition.cs:167
		this.report = ReadSection<BreastRadReport>(this.ReportSectionCode);                                                                       // CSDefineComposition.cs:168
		ReadSection<ResourceBase>(ImpressionsSectionCode, 0, -1, this.impressions);                                                               // CSDefineComposition.cs:209
		ReadSection<ResourceBase>(RelatedResourcesSectionCode, 0, -1, this.relatedResources);                                                     // CSDefineComposition.cs:209
		ReadSection<ResourceBase>(RecommendationsSectionCode, 0, -1, this.recommendations);                                                       // CSDefineComposition.cs:209
		//- ReadCode
		}

		//+ Methods
		//- Methods
	}
}
