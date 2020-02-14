using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class MammoCalcificationTypeCS
	{
		//+ Fields
		const string System = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/MammoCalcificationTypeCS";                                      // CSBuilder.cs:365
		                                                                                                                                          // CSBuilder.cs:377
		/// <summary>
		/// Amorphous calcifications, previously known as indistinct calcifications, are a morphological descriptor for breast calcifications that are small and/or hazy such that no clearly defined shape/form can be ascribed.
		/// Many benign and malignant conditions may be seen in association with these calcifications 1.
		/// Magnification views (specific types of views of the breast where certain areas are magnified) as part of a diagnostic mammographic evaluation are required to fully assess these calcifications.
		/// Amorphous calcifications are small (80-200 micrometer in diameter) and/or hazy/faint, such that a more specific morphologic descriptor cannot be assigned.
		/// 
		/// 
		/// [https://radiopaedia.org > articles > amorphous-calcifications-breast]
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_Amorphous = new Coding(System, "Amorphous", "Amorphous");                                                       // CSBuilder.cs:391
		                                                                                                                                          // CSBuilder.cs:377
		/// <summary>
		/// The classic large 'popcorn-like' calcifications are produced by involuting fibroadenomas.
		/// These calcifications usually do not cause a diagnostic problem.
		/// When the calcifications in an fibroadenoma are small and numerous, they may resemble malignant-type calcifications and need a biopsy.
		/// [https://radiologyassistant.nl/breast/breast-calcifications-differential-diagnosis]
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_Coarse = new Coding(System, "Coarse", "Coarse");                                                                // CSBuilder.cs:391
		                                                                                                                                          // CSBuilder.cs:377
		/// <summary>
		/// Dystrophic soft tissue calcification is a broad term that encompasses a wide range of pathologies that cause soft-tissue calcification and is caused by calcification of damaged tissues.
		/// The amorphous calcification that results may be small or large.
		/// In some cases, ossification may occur - this is characterized by cortical formation and a central medullary cavity.
		/// [https://radiopaedia.org/articles/dystrophic-soft-tissue-calcification-1?lang=us]
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_Dystrophic = new Coding(System, "Dystrophic", "Dystrophic");                                                    // CSBuilder.cs:391
		                                                                                                                                          // CSBuilder.cs:377
		/// <summary>
		/// Eggshell calcifications in the breast are benign peripheral rim like calcifications
		/// They are typically secondary to fat necrosis or calcification of oil cysts.
		/// thin rim-like calcification (<1 mm in thickness)
		/// lucent centers
		/// small to several centimeters in diameter (oil cyst)
		/// may disappear (fat necrosis)
		/// 
		/// 
		/// [https://radiopaedia.org/articles/eggshell-calcification-breast-1?lang=us]
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_Eggshell = new Coding(System, "Eggshell", "Eggshell");                                                          // CSBuilder.cs:391
		                                                                                                                                          // CSBuilder.cs:377
		/// <summary>
		/// These are thin, linear or curvilinear irregular calcifications.
		/// They may be discontinuous.
		/// 
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_Fine = new Coding(System, "Fine", "Fine");                                                                      // CSBuilder.cs:391
		                                                                                                                                          // CSBuilder.cs:377
		/// <summary>
		/// Calcification happens when calcium builds up in body tissue, blood vessels, or organs.
		/// This buildup can harden and disrupt your body's normal processes.
		/// Calcium is transported through the bloodstream.
		/// It's also found in every cell.
		/// As a result, calcification can occur in almost any part of the body.
		/// 
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_GenericCalcification = new Coding(System, "GenericCalcification", "Generic calcification");                     // CSBuilder.cs:391
		                                                                                                                                          // CSBuilder.cs:377
		/// <summary>
		/// Grouped coarse heterogeneous calcifications are a group of irregular and conspicuous microcalcifications, smaller than dystrophic calcifications.
		/// They may be associated with malignancy, but they are also present in benign conditions, as fibroadenoma, in areas of fibrosis or trauma.
		/// [https://radiopaedia.org/cases/suspicious-breast-calcifications-grouped-coarse-heterogeneous-1?lang=us]
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_CourseHeterogeneous = new Coding(System, "CourseHeterogeneous", "Course Heterogeneous");                        // CSBuilder.cs:391
		                                                                                                                                          // CSBuilder.cs:377
		/// <summary>
		/// Amorphous calcifications, previously known as indistinct calcifications, are a morphological
		/// descriptor for breast calcifications that are small and/or hazy such that no clearly
		/// defined shape/form can be ascribed.
		/// [https://radiopaedia.org > articles > amorphous-calcifications-breast]
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_Indistinct = new Coding(System, "Indistinct", "Indistinct");                                                    // CSBuilder.cs:391
		                                                                                                                                          // CSBuilder.cs:377
		/// <summary>
		/// These are formed within ectatic ducts.
		/// These benign calcifications form continuous rods that may occasionally be branching.
		/// They are different from malignant-type fine branching calcifications, because they are usually > 1 mm in diameter.
		/// They may have lucent centers if the calcium is in the wall of the duct.
		/// These calcifications follow a ductal distribution, radiating toward the nipple and are usually bilateral (in both breasts).
		/// These secretory calcifications are most often seen in women older than 60 years.
		/// Sometimes it is difficult to differentiate these from linear calcifications as seen in DCIS.
		/// 
		/// 
		/// [https://radiologyassistant.nl/breast/breast-calcifications-differential-diagnosis]
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_LargeRodlike = new Coding(System, "LargeRodlike", "Large rodlike");                                             // CSBuilder.cs:391
		                                                                                                                                          // CSBuilder.cs:377
		/// <summary>
		/// Layering of calcium within the calcification.
		/// [https://radiologyassistant.nl/breast/breast-calcifications-differential-diagnosis]
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_Layering = new Coding(System, "Layering", "Layering");                                                          // CSBuilder.cs:391
		                                                                                                                                          // CSBuilder.cs:377
		/// <summary>
		/// Also called fine linear branching.
		/// These are thin, linear, irregular calcifications, which may be discontinuous and
		/// which are
		/// smaller than 0.5 mm in caliber.
		/// Occasionally, branching forms may be seen.
		/// Their appearance
		/// suggests filling of the lumen of a duct or ducts involved irregularly by breast cancer.
		/// [Breast Imaging Reporting and Data System—Ultrasound, Second Edition page 66]
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_FineLinear = new Coding(System, "FineLinear", "Fine Linear");                                                   // CSBuilder.cs:391
		                                                                                                                                          // CSBuilder.cs:377
		/// <summary>
		/// These are round or oval calcifications that range from under 1 mm to over a centimeter.
		/// They are the result of fat necrosis, calcified debris in ducts, and occasional fibroadenomas.
		/// [https://radiologyassistant.nl/breast/breast-calcifications-differential-diagnosis]
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_LucentCentered = new Coding(System, "Lucent-centered", "Lucent-centered");                                      // CSBuilder.cs:391
		                                                                                                                                          // CSBuilder.cs:377
		/// <summary>
		/// These are benign sedimented calcifications in macro- or microcysts.
		/// On craniocaudad views (a specific type of view of the breast in radiology) they appear as fuzzy, round or amorphous.
		/// On a 90 degree lateral view  (another specific type of view of the breast in radiology) they may appear as semilunar, crescent shaped tea cups.
		/// [https://radiologyassistant.nl/breast/breast-calcifications-differential-diagnosis]
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_MilkOfCalcium = new Coding(System, "MilkOfCalcium", "Milk of calcium");                                         // CSBuilder.cs:391
		                                                                                                                                          // CSBuilder.cs:377
		/// <summary>
		/// These calcifications are usually more conspicuous than amorphous forms and are seen
		/// to have
		/// discrete shapes.
		/// These irregular calcifications are distinguished from fine linear and fine-linear
		/// branching forms by the absence of fine-linear particles.
		/// Fine pleomorphic calcifications vary in
		/// size and shape and are usually smaller than 0.5 mm in diameter.
		/// [Breast Imaging Reporting and Data System—Ultrasound, Second Edition page 64]
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_FinePleomorphic = new Coding(System, "FinePleomorphic", "Fine Pleomorphic");                                    // CSBuilder.cs:391
		                                                                                                                                          // CSBuilder.cs:377
		/// <summary>
		/// Calcification is punctate/round.
		/// It's different than a "round" calcification though as it also means the calcifications are less than .5 mm in size.
		/// May warrant a probably benign (non-cancer) assessment unless there is also a linear pattern or in a segmental distibution.
		/// This may require and imaging guided biopy or mammographic surveillance.
		/// 
		/// 
		/// [Breast Imaging Reporting and Data System—Ultrasound, Second Edition]
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_Punctate = new Coding(System, "Punctate", "Punctate");                                                          // CSBuilder.cs:391
		                                                                                                                                          // CSBuilder.cs:377
		/// <summary>
		/// Eggshell or Rim Calcifications
		/// These are very thin benign calcifications that appear as calcium is deposited on
		/// the surface of a sphere.
		/// Fat necrosis and calcifications in the walls of cysts are the most common "rim"
		/// calcifications, although more extensive (and occasionally thicker-rimmed) calcification
		/// in the
		/// walls of oil cysts or simple cysts may be seen.
		/// [Breast Imaging Reporting and Data System—Ultrasound, Second Edition page 49]
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_Rim = new Coding(System, "Rim", "Rim");                                                                         // CSBuilder.cs:391
		                                                                                                                                          // CSBuilder.cs:377
		/// <summary>
		/// Round calcifications are 0.5-1 mm in size and frequently form in the acini of the terminal duct lobular unit.
		/// When smaller than 0.5 mm, the term 'punctate' is used.
		/// 
		/// Round and punctate calcifications can be seen in fibrocystic changes or adenosis, skin calcifications, skin talc and rarely in DCIS.
		/// [https://radiologyassistant.nl/breast/breast-calcifications-differential-diagnosis]
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_Round = new Coding(System, "Round", "Round");                                                                   // CSBuilder.cs:391
		                                                                                                                                          // CSBuilder.cs:377
		/// <summary>
		/// These are usually lucent-centered and pathognomonic in their appearance.
		/// Skin calcifications are most commonly seen along the inframammary fold, parasternally, overlying the axilla and around the areola.
		/// The individual calcific particles usually are tightly grouped, with individual
		/// groups smaller than 5 mm in greatest dimension.
		/// Skin calcifications may develop from a degenerative metaplastic process.
		/// [Breast Imaging Reporting and Data System—Ultrasound, Second Edition page 36]
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_Skin = new Coding(System, "Skin", "Skin");                                                                      // CSBuilder.cs:391
		                                                                                                                                          // CSBuilder.cs:377
		/// <summary>
		/// Calcifications that have formed a  spherical shape are usually associated with benign
		/// lesions.
		/// [Breast Imaging Reporting and Data System—Ultrasound, Second Edition]
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_Spherical = new Coding(System, "Spherical", "Spherical");                                                       // CSBuilder.cs:391
		                                                                                                                                          // CSBuilder.cs:377
		/// <summary>
		/// These are typically linear or tubular in appearance, and when present in Mammogram, may show up in a knot pattern.
		/// 
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_Suture = new Coding(System, "Suture", "Suture");                                                                // CSBuilder.cs:391
		                                                                                                                                          // CSBuilder.cs:377
		/// <summary>
		/// These are linear or form parallel tracks, that are usually clearly associated with blood vessels.
		/// Vascular calcifications noted in women
		/// On the left typical vascular calcifications.
		/// 
		/// If only one side of a vessel is calcified, the calcification may simulate intraductal (across a group of milk ducts) calcification.
		/// [https://radiologyassistant.nl/breast/breast-calcifications-differential-diagnosis]
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_Vascular = new Coding(System, "Vascular", "Vascular");                                                          // CSBuilder.cs:391
		//- Fields
	}
}
