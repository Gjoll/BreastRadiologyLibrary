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
		const string System = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes";                                  // Builder.cs:377
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// Slicing CompositionSection Code - Report.
		/// </summary>
		public static Coding Code_SectionReport = new Coding(System, "sectionReport", "Code to identify the 'Report' section slice");             // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// Slicing CompositionSection Code - Impressions.
		/// </summary>
		public static Coding Code_SectionImpressions = new Coding(System, "sectionImpressions", "Code to identify the 'Impressions' section slice");// Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// Slicing CompositionSection Code - Related Resources.
		/// </summary>
		public static Coding Code_SectionRelatedResources = new Coding(System, "sectionRelatedResources", "Code to identify the 'RelatedResources' section slice");// Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// Slicing CompositionSection Code - Recommendations.
		/// </summary>
		public static Coding Code_SectionCodeRecommendations = new Coding(System, "sectionCodeRecommendations", "Code to identify the 'Recommendations' section slice");// Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// Slicing CompositionSection Code - Findings Left Breast.
		/// </summary>
		public static Coding Code_SectionCodeFindingsLeftBreast = new Coding(System, "sectionCodeFindingsLeftBreast", "Code to identify the 'Findings Left Breast' section slice");// Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// Slicing CompositionSection Code - Findings Right Breast.
		/// </summary>
		public static Coding Code_SectionCodeFindingsRightBreast = new Coding(System, "sectionCodeFindingsRightBreast", "Code to identify the 'Findings Right Breast' section slice");// Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// Slicing CompositionSection Code - Admin.
		/// </summary>
		public static Coding Code_SectionCodeAdmin = new Coding(System, "sectionCodeAdmin", "Code to identify the 'Admin' section slice");        // Builder.cs:408
		//- Fields
	}
}
