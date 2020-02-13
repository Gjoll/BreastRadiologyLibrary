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
		                                                                                                                                          // CSDefineComposition.cs:80
		/// <summary>
		/// Section report
		/// Composition.section:report
		/// </summary>
		Coding ReportSectionCode = new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes", "sectionReport");// CSDefineComposition.cs:85
		                                                                                                                                          // CSDefineComposition.cs:91
		/// <summary>
		/// propertyName field
		/// </summary>
		BreastRadReport report;                                                                                                                   // CSDefineComposition.cs:95
		                                                                                                                                          // CSDefineComposition.cs:96
		/// <summary>
		/// Access propertyName
		/// </summary>
		public BreastRadReport Report => this.report;                                                                                             // CSDefineComposition.cs:100
		                                                                                                                                          // CSDefineComposition.cs:102
		/// <summary>
		/// Create new blank {propertyName}
		/// </summary>
		public BreastRadReport CreateReport()                                                                                                     // CSDefineComposition.cs:106
		{                                                                                                                                         // CSDefineComposition.cs:107
		    if (this.Report != null)                                                                                                              // CSDefineComposition.cs:108
		        throw new Exception("Report already has a value");                                                                                // CSDefineComposition.cs:109
		    BreastRadReport retVal = new BreastRadReport(this.doc);                                                                               // CSDefineComposition.cs:110
		    this.report = retVal;                                                                                                                 // CSDefineComposition.cs:111
		    return retVal;                                                                                                                        // CSDefineComposition.cs:112
		}                                                                                                                                         // CSDefineComposition.cs:113
		                                                                                                                                          // CSDefineComposition.cs:80
		/// <summary>
		/// Section impressions
		/// Composition.section:impressions
		/// </summary>
		Coding ImpressionsSectionCode = new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes", "sectionImpressions");// CSDefineComposition.cs:85
		                                                                                                                                          // CSDefineComposition.cs:124
		/// <summary>
		/// propertyName field
		/// </summary>
		List<ClinicalImpressionBase> impressions = new List<ClinicalImpressionBase>();                                                            // CSDefineComposition.cs:128
		                                                                                                                                          // CSDefineComposition.cs:129
		/// <summary>
		/// Access propertyName
		/// </summary>
		public IEnumerable<ClinicalImpressionBase> Impressions => this.impressions;                                                               // CSDefineComposition.cs:133
		                                                                                                                                          // CSDefineComposition.cs:135
		/// <summary>
		/// Append new blank {propertyName}
		/// </summary>
		public ClinicalImpressionBase AppendImpressions()                                                                                         // CSDefineComposition.cs:139
		{                                                                                                                                         // CSDefineComposition.cs:140
		    ClinicalImpressionBase retVal = new ClinicalImpressionBase(this.doc);                                                                 // CSDefineComposition.cs:141
		    this.impressions.Add(retVal);                                                                                                         // CSDefineComposition.cs:142
		    return retVal;                                                                                                                        // CSDefineComposition.cs:143
		}                                                                                                                                         // CSDefineComposition.cs:144
		                                                                                                                                          // CSDefineComposition.cs:80
		/// <summary>
		/// Section relatedResources
		/// Composition.section:relatedResources
		/// </summary>
		Coding RelatedResourcesSectionCode = new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes", "sectionRelatedResources");// CSDefineComposition.cs:85
		                                                                                                                                          // CSDefineComposition.cs:124
		/// <summary>
		/// propertyName field
		/// </summary>
		List<ResourceBase> relatedResources = new List<ResourceBase>();                                                                           // CSDefineComposition.cs:128
		                                                                                                                                          // CSDefineComposition.cs:129
		/// <summary>
		/// Access propertyName
		/// </summary>
		public IEnumerable<ResourceBase> RelatedResources => this.relatedResources;                                                               // CSDefineComposition.cs:133
		                                                                                                                                          // CSDefineComposition.cs:135
		/// <summary>
		/// Append new blank {propertyName}
		/// </summary>
		public ResourceBase AppendRelatedResources()                                                                                              // CSDefineComposition.cs:139
		{                                                                                                                                         // CSDefineComposition.cs:140
		    ResourceBase retVal = new ResourceBase(this.doc);                                                                                     // CSDefineComposition.cs:141
		    this.relatedResources.Add(retVal);                                                                                                    // CSDefineComposition.cs:142
		    return retVal;                                                                                                                        // CSDefineComposition.cs:143
		}                                                                                                                                         // CSDefineComposition.cs:144
		                                                                                                                                          // CSDefineComposition.cs:80
		/// <summary>
		/// Section recommendations
		/// Composition.section:recommendations
		/// </summary>
		Coding RecommendationsSectionCode = new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes", "sectionCodeRecommendations");// CSDefineComposition.cs:85
		                                                                                                                                          // CSDefineComposition.cs:124
		/// <summary>
		/// propertyName field
		/// </summary>
		List<ResourceBase> recommendations = new List<ResourceBase>();                                                                            // CSDefineComposition.cs:128
		                                                                                                                                          // CSDefineComposition.cs:129
		/// <summary>
		/// Access propertyName
		/// </summary>
		public IEnumerable<ResourceBase> Recommendations => this.recommendations;                                                                 // CSDefineComposition.cs:133
		                                                                                                                                          // CSDefineComposition.cs:135
		/// <summary>
		/// Append new blank {propertyName}
		/// </summary>
		public ResourceBase AppendRecommendations()                                                                                               // CSDefineComposition.cs:139
		{                                                                                                                                         // CSDefineComposition.cs:140
		    ResourceBase retVal = new ResourceBase(this.doc);                                                                                     // CSDefineComposition.cs:141
		    this.recommendations.Add(retVal);                                                                                                     // CSDefineComposition.cs:142
		    return retVal;                                                                                                                        // CSDefineComposition.cs:143
		}                                                                                                                                         // CSDefineComposition.cs:144
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
		WriteSection<BreastRadReport>("Breast Radiology Report", ReportSectionCode, 1, 1, this.report);                                           // CSDefineComposition.cs:153
		WriteSection<ClinicalImpressionBase>("Clinical Impressions", ImpressionsSectionCode, 0, -1, this.impressions);                            // CSDefineComposition.cs:153
		WriteSection<ResourceBase>("Related Resources", RelatedResourcesSectionCode, 0, -1, this.relatedResources);                               // CSDefineComposition.cs:153
		WriteSection<ResourceBase>("Recommendations", RecommendationsSectionCode, 0, -1, this.recommendations);                                   // CSDefineComposition.cs:153
		//- WriteCode
		}

		public override void Read()
		{
		//+ ReadCode
		                                                                                                                                          // CSDefineComposition.cs:117
		this.report = ReadSection<BreastRadReport>(this.ReportSectionCode);                                                                       // CSDefineComposition.cs:118
		ReadSection<ClinicalImpressionBase>(ImpressionsSectionCode, 0, -1, this.impressions);                                                     // CSDefineComposition.cs:148
		ReadSection<ResourceBase>(RelatedResourcesSectionCode, 0, -1, this.relatedResources);                                                     // CSDefineComposition.cs:148
		ReadSection<ResourceBase>(RecommendationsSectionCode, 0, -1, this.recommendations);                                                       // CSDefineComposition.cs:148
		//- ReadCode
		}

		//+ Methods
		//- Methods
	}
}
