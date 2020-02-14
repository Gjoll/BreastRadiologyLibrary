using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class MGBreastDensityCS
	{
		//+ Fields
		const string System = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/MGBreastDensityCS";                                             // CSBuilder.cs:365
		                                                                                                                                          // CSBuilder.cs:377
		/// <summary>
		/// A term used to describe breast tissue that is made up of almost all fatty tissue.
		/// Fatty breast tissue does not look dense on a mammogram, which may make it easier
		/// to find tumors or other changes in the breast.
		/// Fatty breast tissue is more common in older women than in younger women.
		/// Fatty breast tissue is one of four categories used to describe a level of breast
		/// density seen on a mammogram.
		/// [https://www.cancer.gov/publications/dictionaries/cancer-terms/search?contains=false&q=fatty]
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_AlmostEntirelyFat = new Coding(System, "AlmostEntirelyFat", "Almost entirely fat");                             // CSBuilder.cs:391
		                                                                                                                                          // CSBuilder.cs:377
		/// <summary>
		/// A term used to describe breast tissue that is made up of mostly fatty tissue and
		/// also has some dense fibrous tissue and glandular tissue.
		/// On a mammogram, the dense areas of the breast make it harder to find tumors or other
		/// changes.
		/// Scattered fibroglandular breast tissue is one of four categories used to describe
		/// a level of breast density seen on a mammogram.
		/// About 40% of women have this type of breast tissue.
		/// [https://www.cancer.gov/publications/dictionaries/cancer-terms/def/scattered-fibroglandular-breast-tissue]
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_ScatteredAreasOfFibroglandularDensity = new Coding(System, "ScatteredAreasOfFibroglandularDensity", "Scattered areas of fibroglandular density");// CSBuilder.cs:391
		                                                                                                                                          // CSBuilder.cs:377
		/// <summary>
		/// A term used to describe breast tissue that has large areas of dense fibrous tissue
		/// and glandular tissue and also has some fatty tissue.
		/// The dense areas of the breast make it harder to find tumors or other changes on a
		/// mammogram.
		/// Heterogeneously dense breast tissue is one of four categories used to describe a
		/// level of breast density seen on a mammogram.
		/// About 40% of women have this type of breast tissue.
		/// [https://www.cancer.gov/publications/dictionaries/cancer-terms/def/heterogeneously-dense-breast-tissue]
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_HeterogeneouslyDense = new Coding(System, "HeterogeneouslyDense", "Heterogeneously dense");                     // CSBuilder.cs:391
		                                                                                                                                          // CSBuilder.cs:377
		/// <summary>
		/// Also called extremely dense breast tissue.
		/// A term used to describe breast tissue that is made up of almost all dense fibrous
		/// tissue and glandular tissue.
		/// On a mammogram, the dense areas of the breast make it harder to find tumors or other
		/// changes.
		/// Women who have extremely dense breast tissue have a higher risk of breast cancer
		/// than those who have little or no dense breast tissue.
		/// Extremely dense breast tissue is one of four categories used to describe a level
		/// of breast density seen on a mammogram.
		/// About 10% of women have this type of breast tissue.
		/// [https://www.cancer.gov/publications/dictionaries/cancer-terms/def/extremely-dense-breast-tissue]
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_ExtremelyDense = new Coding(System, "ExtremelyDense", "Extremely dense");                                       // CSBuilder.cs:391
		//- Fields
	}
}
