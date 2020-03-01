using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class CorrespondsWithCodeSystemCS
	{
		//+ Fields
		const string System = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/CorrespondsWithCodeSystemCS";                                   // Builder.cs:371
		                                                                                                                                          // Builder.cs:383
		/// <summary>
		/// A medical procedure that removes something from an area of the body.
		/// These substances can be air, body fluids, or bone fragments.
		/// [https://medlineplus.gov/ency/article/002216.htm]
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_Aspiration = new Coding(System, "Aspiration", "Aspiration");                                                    // Builder.cs:402
		                                                                                                                                          // Builder.cs:383
		/// <summary>
		/// The Mammogram and Biopsy correspond with each other.
		/// 
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_Biopsy = new Coding(System, "Biopsy", "Biopsy");                                                                // Builder.cs:402
		                                                                                                                                          // Builder.cs:383
		/// <summary>
		/// The test corresponds with the concern.
		/// 
		/// Valid for the following modalities: MG US MRI NM.
		/// </summary>
		public static Coding Code_Concern = new Coding(System, "Concern", "Concern");                                                             // Builder.cs:402
		                                                                                                                                          // Builder.cs:383
		/// <summary>
		/// A ductogram, also called a galactogram, is a special type of mammogram used for imaging
		/// the breast ducts.
		/// It can aid in diagnosing the cause of abnormal nipple discharges.
		/// Ductography (also called galactography or ductogalactography) is a special type of
		/// contrast enhanced mammography used for imaging the breast ducts.
		/// Ductography can aid in diagnosing the cause of an abnormal nipple discharge and is
		/// valuable in diagnosing intraductal papillomas and other conditions.
		/// [https://www.imaginis.com/mammography/ductogram-galactogram-imaging-the-breast-ducts]
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_Ductogram = new Coding(System, "Ductogram", "Ductogram");                                                       // Builder.cs:402
		                                                                                                                                          // Builder.cs:383
		/// <summary>
		/// A medical finding that wasn&#39;t the abnormality of the original  mammogram, MRI, nuclear
		/// medicine, or ultrasound was intended to find.
		/// 
		/// Valid for the following modalities: MG US MRI NM.
		/// </summary>
		public static Coding Code_IncidentalFinding = new Coding(System, "IncidentalFinding", "Incidental finding");                              // Builder.cs:402
		                                                                                                                                          // Builder.cs:383
		/// <summary>
		/// The original MRI, Nuclear Medicine, or Ultrasound corresponds with the findings on
		/// the Mammogram.
		/// 
		/// Valid for the following modalities: US MRI NM.
		/// </summary>
		public static Coding Code_Mammo = new Coding(System, "Mammo", "Mammo");                                                                   // Builder.cs:402
		                                                                                                                                          // Builder.cs:383
		/// <summary>
		/// The original Mammogram, Nuclear Medicine, or Ultrasound corresponds with the findings
		/// on the MRI.
		/// 
		/// Valid for the following modalities: MG US MRI NM.
		/// </summary>
		public static Coding Code_MRI = new Coding(System, "MRI", "MRI");                                                                         // Builder.cs:402
		                                                                                                                                          // Builder.cs:383
		/// <summary>
		/// The findings on the Mammogram and/or Ultrasound, correspond with the nipple discharge.
		/// 
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_NippleDischarge = new Coding(System, "NippleDischarge", "Nipple discharge");                                    // Builder.cs:402
		                                                                                                                                          // Builder.cs:383
		/// <summary>
		/// Previous exam at another clinic that took place separate from current exam.
		/// 
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_OutsideExam = new Coding(System, "OutsideExam", "Outside exam");                                                // Builder.cs:402
		                                                                                                                                          // Builder.cs:383
		/// <summary>
		/// Mammogram, MRI, Nuclear Medicine, or ultrasound corresponds with the pain the patient
		/// is experiencing.
		/// 
		/// Valid for the following modalities: MG US MRI NM.
		/// </summary>
		public static Coding Code_Pain = new Coding(System, "Pain", "Pain");                                                                      // Builder.cs:402
		                                                                                                                                          // Builder.cs:383
		/// <summary>
		/// The Mammogram, Ultrasound, Nuclear Medicine, MRI correspond with the palpated (physical
		/// exam to touch) lump.
		/// 
		/// Valid for the following modalities: MG US MRI NM.
		/// </summary>
		public static Coding Code_Palpated = new Coding(System, "Palpated", "Palpated");                                                          // Builder.cs:402
		                                                                                                                                          // Builder.cs:383
		/// <summary>
		/// The Mammogram corresponds with the post operative results of the breast incision.
		/// 
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_PostOperative = new Coding(System, "PostOperative", "Post operative");                                          // Builder.cs:402
		                                                                                                                                          // Builder.cs:383
		/// <summary>
		/// The previous biopsy results correspond with the MRI and/or Ultrasound.
		/// 
		/// Valid for the following modalities: US MRI.
		/// </summary>
		public static Coding Code_PreviousBiopsy = new Coding(System, "PreviousBiopsy", "Previous biopsy");                                       // Builder.cs:402
		                                                                                                                                          // Builder.cs:383
		/// <summary>
		/// The prior exam of the breast, corresponds with the results of the Mammogram.
		/// 
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_PriorExam = new Coding(System, "PriorExam", "Prior exam");                                                      // Builder.cs:402
		                                                                                                                                          // Builder.cs:383
		/// <summary>
		/// The redness in the breast, corresponds with the results of the Mammogram and/or Ultrasound.
		/// 
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_Redness = new Coding(System, "Redness", "Redness");                                                             // Builder.cs:402
		                                                                                                                                          // Builder.cs:383
		/// <summary>
		/// The initial Mammogram corresponds with the Scinti results.
		/// Scintigraphy definition is - a diagnostic technique in which a two-dimensional picture
		/// of internal body tissue is produced through the detection of radiation emitted by
		/// a radioactive substance administered into the body.
		/// 
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_Scinti = new Coding(System, "Scinti", "Scinti");                                                                // Builder.cs:402
		                                                                                                                                          // Builder.cs:383
		/// <summary>
		/// size &lt; mammo
		/// 
		/// Valid for the following modalities: US MRI NM.
		/// </summary>
		public static Coding Code_SizeLessThanMammo = new Coding(System, "Size<Mammo", "Size < mammo");                                           // Builder.cs:402
		                                                                                                                                          // Builder.cs:383
		/// <summary>
		/// size &lt; MRI
		/// 
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_SizeLessThanMRI = new Coding(System, "Size<MRI", "Size < MRI");                                                 // Builder.cs:402
		                                                                                                                                          // Builder.cs:383
		/// <summary>
		/// size &lt; palp
		/// 
		/// Valid for the following modalities: MG US MRI.
		/// </summary>
		public static Coding Code_SizeLessThanPalp = new Coding(System, "Size<Palp", "Size < palp");                                              // Builder.cs:402
		                                                                                                                                          // Builder.cs:383
		/// <summary>
		/// size &lt; US
		/// 
		/// Valid for the following modalities: MG US MRI NM.
		/// </summary>
		public static Coding Code_SizeLessThanUS = new Coding(System, "Size<US", "Size < US");                                                    // Builder.cs:402
		                                                                                                                                          // Builder.cs:383
		/// <summary>
		/// size &gt; mammo
		/// 
		/// Valid for the following modalities: US MRI NM.
		/// </summary>
		public static Coding Code_SizeGreaterThanMammo = new Coding(System, "Size>Mammo", "Size > mammo");                                        // Builder.cs:402
		                                                                                                                                          // Builder.cs:383
		/// <summary>
		/// size &gt; MRI
		/// 
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_SizeGreaterThanMRI = new Coding(System, "Size>MRI", "Size > MRI");                                              // Builder.cs:402
		                                                                                                                                          // Builder.cs:383
		/// <summary>
		/// size &gt; palp
		/// 
		/// Valid for the following modalities: MG US MRI.
		/// </summary>
		public static Coding Code_SizeGreaterThanPalp = new Coding(System, "Size>Palp", "Size > palp");                                           // Builder.cs:402
		                                                                                                                                          // Builder.cs:383
		/// <summary>
		/// The mammogram findings correspond with where the skin marker was placed on the breast.
		/// 
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_SkinMarker = new Coding(System, "SkinMarker", "Skin marker");                                                   // Builder.cs:402
		                                                                                                                                          // Builder.cs:383
		/// <summary>
		/// Surgery
		/// 
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_Surgery = new Coding(System, "Surgery", "Surgery");                                                             // Builder.cs:402
		                                                                                                                                          // Builder.cs:383
		/// <summary>
		/// The MRI information corresponds with the surgical site.
		/// 
		/// Valid for the following modalities: MRI.
		/// </summary>
		public static Coding Code_SurgicalSite = new Coding(System, "SurgicalSite", "Surgical site");                                             // Builder.cs:402
		                                                                                                                                          // Builder.cs:383
		/// <summary>
		/// The mammogram results correspond with where the patient feels tenderness.
		/// 
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_Tenderness = new Coding(System, "Tenderness", "Tenderness");                                                    // Builder.cs:402
		                                                                                                                                          // Builder.cs:383
		/// <summary>
		/// The results of the Ultrasound correspond with where the trigger point is around the
		/// tumor/lesion.
		/// The trigger point is the point where the site of the pain is.
		/// 
		/// Valid for the following modalities: US.
		/// </summary>
		public static Coding Code_TriggerPoint = new Coding(System, "TriggerPoint", "Trigger point");                                             // Builder.cs:402
		                                                                                                                                          // Builder.cs:383
		/// <summary>
		/// The results of the MRI, Mammogram and/or Nuclear Medicine exam, correspond with this
		/// Ultrasound.
		/// 
		/// Valid for the following modalities: MG US MRI NM.
		/// </summary>
		public static Coding Code_US = new Coding(System, "US", "US");                                                                            // Builder.cs:402
		//- Fields
	}
}
