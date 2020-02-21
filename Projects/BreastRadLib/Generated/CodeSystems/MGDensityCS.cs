using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class MGDensityCS
	{
		//+ Fields
		const string System = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/MGDensityCS";                                                   // CSBuilder.cs:347
		                                                                                                                                          // CSBuilder.cs:359
		/// <summary>
		/// These are round or oval calcifications that range from under 1 mm to over a centimeter.
		/// They are the result of fat necrosis, calcified debris in ducts, and occasional fibroadenomas.
		/// [https://radiologyassistant.nl/breast/breast-calcifications-differential-diagnosis#benign-calcifications-lucent-centered]
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_CentralLucent = new Coding(System, "CentralLucent", "Central lucent");                                          // CSBuilder.cs:373
		                                                                                                                                          // CSBuilder.cs:359
		/// <summary>
		/// (historically, "isodense")
		/// X-ray attenuation of the mass is the same as the expected attenuation of an equal volume of
		/// 
		/// fibroglandular breast tissue.
		/// [Breast Imaging Reporting and Data System—Ultrasound, Second Edition]
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_EqualDensity = new Coding(System, "EqualDensity", "Equal density");                                             // CSBuilder.cs:373
		                                                                                                                                          // CSBuilder.cs:359
		/// <summary>
		/// This includes all masses containing fat, such as oil cyst, lipoma or galactocele, as well as mixed
		/// density masses such as hamartoma.
		/// A fat-containing mass will almost always represent a
		/// 
		/// benign mass.
		/// [Breast Imaging Reporting and Data System—Ultrasound, Second Edition]
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_FatContaining = new Coding(System, "FatContaining", "Fat containing");                                          // CSBuilder.cs:373
		                                                                                                                                          // CSBuilder.cs:359
		/// <summary>
		/// Your breast tissue may be called dense if you have a lot of fibrous or glandular
		/// tissue and not much fat in the breasts.
		/// Having dense breast tissue is common.
		/// Some women have more dense breast tissue than others.
		/// [https://www.cancer.org/cancer/breast-cancer/screening-tests-and-early-detection/mammograms/breast-density-and-your-mammogram-report.html]
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_HighDensity = new Coding(System, "HighDensity", "High density");                                                // CSBuilder.cs:373
		                                                                                                                                          // CSBuilder.cs:359
		/// <summary>
		/// X-ray attenuation of the mass is less than the expected attenuation of an equal volume of
		/// fibroglandular breast tissue.
		/// A low density mass may be a group of microcysts.
		/// If such a finding
		/// is identified at mammography, it may very well not be malignant but appropriately may
		/// 
		/// be worked up.
		/// [Breast Imaging Reporting and Data System—Ultrasound, Second Edition]
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_LowDensity = new Coding(System, "LowDensity", "Low density");                                                   // CSBuilder.cs:373
		//- Fields
	}
}
