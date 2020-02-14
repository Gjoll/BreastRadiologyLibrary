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
		const string System = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/MGDensityCS";                                                   // CSBuilder.cs:393
		                                                                                                                                          // CSBuilder.cs:405
		/// <summary>
		/// These are round or oval calcifications that range from under 1 mm to over a centimeter.
		/// They are the result of fat necrosis, calcified debris in ducts, and occasional fibroadenomas.
		/// [https://radiologyassistant.nl/breast/breast-calcifications-differential-diagnosis#benign-calcifications-lucent-centered]
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_CentralLucent = new Coding(System, "CentralLucent", "Central lucent");                                          // CSBuilder.cs:419
		                                                                                                                                          // CSBuilder.cs:405
		/// <summary>
		/// (historically, "isodense")
		/// X-ray attenuation of the mass is the same as the expected attenuation of an equal volume of
		/// fibroglandular breast tissue.
		/// 
		/// -- -- Bi-Rads® Atlas — Mammography Fifth Ed. 2013
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_EqualDensity = new Coding(System, "EqualDensity", "Equal density");                                             // CSBuilder.cs:419
		                                                                                                                                          // CSBuilder.cs:405
		/// <summary>
		/// The mammogram shows a lot of fatty tissue  meaning the density of the breast is likely low density.
		/// 
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_FatContaining = new Coding(System, "FatContaining", "Fat containing");                                          // CSBuilder.cs:419
		                                                                                                                                          // CSBuilder.cs:405
		/// <summary>
		/// Your breast tissue may be called dense if you have a lot of fibrous or glandular
		/// tissue and not much fat in the breasts.
		/// Having dense breast tissue is common.
		/// Some women have more dense breast tissue than others.
		/// [https://www.cancer.org/cancer/breast-cancer/screening-tests-and-early-detection/mammograms/breast-density-and-your-mammogram-report.html]
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_HighDensity = new Coding(System, "HighDensity", "High density");                                                // CSBuilder.cs:419
		                                                                                                                                          // CSBuilder.cs:405
		/// <summary>
		/// The mammogram shows the breast is low density, containg a lot of fatty tissue.
		/// 
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_LowDensity = new Coding(System, "LowDensity", "Low density");                                                   // CSBuilder.cs:419
		//- Fields
	}
}
