using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class CompositionSectionSliceCodes
	{
		//+ Fields
		const string System = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes";                                  // CSBuilder.cs:365
		                                                                                                                                          // CSBuilder.cs:377
		/// <summary>
		/// Slicing CompositionSection Code - Report
		/// </summary>
		public static Coding Code_SectionReport = new Coding(System, "sectionReport", "Code to identify the 'Report' section slice");             // CSBuilder.cs:391
		                                                                                                                                          // CSBuilder.cs:377
		/// <summary>
		/// Slicing CompositionSection Code - Impressions
		/// </summary>
		public static Coding Code_SectionImpressions = new Coding(System, "sectionImpressions", "Code to identify the 'Impressions' section slice");// CSBuilder.cs:391
		                                                                                                                                          // CSBuilder.cs:377
		/// <summary>
		/// Slicing CompositionSection Code - Related Resources
		/// </summary>
		public static Coding Code_SectionRelatedResources = new Coding(System, "sectionRelatedResources", "Code to identify the 'RelatedResources' section slice");// CSBuilder.cs:391
		                                                                                                                                          // CSBuilder.cs:377
		/// <summary>
		/// Slicing CompositionSection Code - Recommendations
		/// </summary>
		public static Coding Code_SectionCodeRecommendations = new Coding(System, "sectionCodeRecommendations", "Code to identify the 'Recommendations' section slice");// CSBuilder.cs:391
		                                                                                                                                          // CSBuilder.cs:377
		/// <summary>
		/// Slicing CompositionSection Code - Findings
		/// </summary>
		public static Coding Code_SectionCodeFindings = new Coding(System, "sectionCodeFindings", "Code to identify the 'Findings' section slice");// CSBuilder.cs:391
		//- Fields
	}
}
