using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class CalcificationDistributionCS
	{
		//+ Fields
		const string System = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/CalcificationDistributionCS";                                   // Builder.cs:373
		                                                                                                                                          // Builder.cs:385
		/// <summary>
		/// Grouped (historically, "clustered")
		/// This term should be used when relatively few calcifications occupy a small portion
		/// of breast
		/// tissue.
		/// The lower limit for use of this descriptor is usually when 5 calcifications are grouped
		/// within 1 cm of each other or when a definable pattern is identified.
		/// The upper limit for use
		/// of this descriptor is when larger numbers of calcifications are grouped within 2
		/// cm of each
		/// other.
		/// [Breast Imaging Reporting and Data System—Ultrasound, Second Edition page 73]
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_ClusteredDistribution = new Coding(System, "ClusteredDistribution", "Clustered distribution");                  // Builder.cs:399
		                                                                                                                                          // Builder.cs:385
		/// <summary>
		/// Diffuse or Scattered: diffuse calcifications may be scattered calcifications or multiple similar appearing clusters of calcifications throughout the whole breast.
		/// Diffuse or scattered distribution is typically seen in benign entities.
		/// Even when clusters of calcifications are scattered throughout the breast, this favors a benign entity.
		/// [https://radiologyassistant.nl/breast/breast-calcifications-differential-diagnosis]
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_DiffuseDistribution = new Coding(System, "DiffuseDistribution", "Diffuse distribution");                        // Builder.cs:399
		                                                                                                                                          // Builder.cs:385
		/// <summary>
		/// This term should be used when relatively few calcifications occupy a
		/// small portion of breast tissue.
		/// The lower limit for use of this descriptor is usually when 5 calcifications
		/// are grouped within 1 cm of each other or when a definable pattern is identified.
		/// The upper limit for use of this descriptor is when larger numbers of
		/// 
		/// calcifications are grouped within 2 cm of each other.
		/// [Breast Imaging Reporting and Data System—Ultrasound, Second Edition page 74]
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_GroupedDistribution = new Coding(System, "GroupedDistribution", "Grouped distribution");                        // Builder.cs:399
		                                                                                                                                          // Builder.cs:385
		/// <summary>
		/// These are calcifications arrayed in a line.
		/// This distribution may elevate suspicion for malignancy, as it suggests deposits in a duct.
		/// Note that both vascular and large rod-like calcifications also are usually linear in distribution, but that these typically
		/// 
		/// benign calcifications have a characteristically benign morphology.
		/// [Breast Imaging Reporting and Data System—Ultrasound, Second Edition]
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_LinearDistribution = new Coding(System, "LinearDistribution", "Linear distribution");                           // Builder.cs:399
		                                                                                                                                          // Builder.cs:385
		/// <summary>
		/// Scattered in a larger volume (> 2 cc) of breast tissue and not in the expected ductal distribution.
		/// Regional distribution according to the BI-RADS atlas would favor a non-ductal distribution (i.e.
		/// 
		/// benignity)
		/// [https://radiologyassistant.nl/breast/breast-calcifications-differential-diagnosis]
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_RegionalDistribution = new Coding(System, "RegionalDistribution", "Regional distribution");                     // Builder.cs:399
		                                                                                                                                          // Builder.cs:385
		/// <summary>
		/// Scattered distributions are also called diffuse distributions.
		/// These are calcifications that are distributed randomly throughout the breast.
		/// Punctate and amorphous calcifications in this distribution are almost always benign, especially
		/// if bilateral (in both breasts).
		/// [Breast Imaging Reporting and Data System—Ultrasound, Second Edition page 70]
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_ScatteredDistribution = new Coding(System, "ScatteredDistribution", "Scattered distribution");                  // Builder.cs:399
		                                                                                                                                          // Builder.cs:385
		/// <summary>
		/// Segmental: calcium deposits in ducts and branches of a segment or lobe.
		/// Segmental distribution would favor a ductal distribution (i.e.
		/// malignancy).
		/// Sometimes this differentiation can be made, but in many cases the differentiation between 'regional' and 'segmental' is problematic, because it is not clear on a mammogram or MRI where the bounderies of a segment (or a lobe) exactly are.
		/// [https://radiologyassistant.nl/breast/breast-calcifications-differential-diagnosis]
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_SegmentalDistribution = new Coding(System, "SegmentalDistribution", "Segmental distribution");                  // Builder.cs:399
		//- Fields
	}
}
