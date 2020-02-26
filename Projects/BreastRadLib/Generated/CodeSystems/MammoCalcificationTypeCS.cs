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
		const string System = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/MammoCalcificationTypeCS";                                      // Builder.cs:368
		                                                                                                                                          // Builder.cs:380
		/// <summary>
		/// (historically, &quot;indistinct&quot;)
		/// These are sufficiently small and/or hazy in appearance that a more specific particle shape
		/// cannot be determined.
		/// Amorphous calcifications in a grouped, linear, or segmental distribution
		/// are suspicious and generally warrant biopsy.
		/// Bilateral, diffuse amorphous calcifications
		/// usually may be dismissed as benign, although baseline magnification views may be helpful.
		/// The positive predictive value (PPV) of amorphous calcifications is reported to be
		/// approximately 20%.
		/// Therefore, calcifications of this morphology appropriately
		/// should be placed into BI-RADS  assessment category 4B (PPV range &gt; 10% to ? 50%).
		/// [Breast Imaging Reporting and Data System—Ultrasound, Second Edition]
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_Amorphous = new Coding(System, "Amorphous", "Amorphous");                                                       // Builder.cs:399
		                                                                                                                                          // Builder.cs:380
		/// <summary>
		/// The classic large &#39;popcorn-like&#39; calcifications are produced by involuting fibroadenomas.
		/// These calcifications usually do not cause a diagnostic problem.
		/// When the calcifications in an fibroadenoma are small and numerous, they may resemble malignant-type calcifications and need a biopsy.
		/// These are the classic large (&gt; 2 to 3 mm in greatest diameter) calcifications produced by an involuting fibroadenoma.
		/// [Breast Imaging Reporting and Data System—Ultrasound, Second Edition]
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_Coarse = new Coding(System, "Coarse", "Coarse");                                                                // Builder.cs:399
		                                                                                                                                          // Builder.cs:380
		/// <summary>
		/// Dystrophic soft tissue calcification is a broad term that encompasses a wide range of pathologies that cause soft-tissue calcification and is caused by calcification of damaged tissues.
		/// The amorphous calcification that results may be small or large.
		/// In some cases, ossification may occur - this is characterized by cortical formation and a central medullary cavity.
		/// [https://radiopaedia.org/articles/dystrophic-soft-tissue-calcification-1?lang=us]
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_Dystrophic = new Coding(System, "Dystrophic", "Dystrophic");                                                    // Builder.cs:399
		                                                                                                                                          // Builder.cs:380
		/// <summary>
		/// Eggshell calcifications in the breast are benign peripheral rim like calcifications
		/// They are typically secondary to fat necrosis or calcification of oil cysts.
		/// thin rim-like calcification (&lt;1 mm in thickness)
		/// lucent centers
		/// small to several centimeters in diameter (oil cyst)
		/// may disappear (fat necrosis)
		/// 
		/// 
		/// [https://radiopaedia.org/articles/eggshell-calcification-breast-1?lang=us]
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_Eggshell = new Coding(System, "Eggshell", "Eggshell");                                                          // Builder.cs:399
		                                                                                                                                          // Builder.cs:380
		/// <summary>
		/// These are thin, linear or curvilinear irregular calcifications.
		/// They may be discontinuous.
		/// 
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_Fine = new Coding(System, "Fine", "Fine");                                                                      // Builder.cs:399
		                                                                                                                                          // Builder.cs:380
		/// <summary>
		/// Calcification happens when calcium builds up in body tissue, blood vessels, or organs.
		/// This buildup can harden and disrupt your body&#39;s normal processes.
		/// Calcium is transported through the bloodstream.
		/// It&#39;s also found in every cell.
		/// As a result, calcification can occur in almost any part of the body.
		/// 
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_GenericCalcification = new Coding(System, "GenericCalcification", "Generic calcification");                     // Builder.cs:399
		                                                                                                                                          // Builder.cs:380
		/// <summary>
		/// These are irregular, conspicuous calcifications that are generally between 0.5 mm and 1 mm
		/// and tend to coalesce, but are smaller than dystrophic calcifications.
		/// They may be associated
		/// with malignancy but more frequently are present in a fibroadenoma or in areas of fibrosis or
		/// trauma representing evolving dystrophic calcifications.
		/// Numerous bilateral groups of coarse
		/// heterogeneous calcifications usually may be dismissed as benign, although baseline magnification
		/// views may be helpful.
		/// However, a single group of coarse heterogeneous calcifications has a positive
		/// predictive value of slightly less than 15%, and therefore this finding should be
		/// 
		/// placed in BI-RADS  assessment category 4B (PPV range &gt; 10% to ? 50%).
		/// [Breast Imaging Reporting and Data System—Ultrasound, Second Edition]
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_CourseHeterogeneous = new Coding(System, "CourseHeterogeneous", "Course Heterogeneous");                        // Builder.cs:399
		                                                                                                                                          // Builder.cs:380
		/// <summary>
		/// Amorphous calcifications, previously known as indistinct calcifications, are a morphological
		/// descriptor for breast calcifications that are small and/or hazy such that no clearly
		/// defined shape/form can be ascribed.
		/// [https://radiopaedia.org &gt; articles &gt; amorphous-calcifications-breast]
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_Indistinct = new Coding(System, "Indistinct", "Indistinct");                                                    // Builder.cs:399
		                                                                                                                                          // Builder.cs:380
		/// <summary>
		/// These benign calcifications associated with ductal ectasia may form solid or discontinuous
		/// smooth linear rods, most of which are 0.5 mm or larger in diameter.
		/// A small percentage of
		/// these calcifications may have lucent centers if the calcium is in the wall of the duct (periductal),
		/// but most are intraductal, when calcification forms within the lumen of the duct.
		/// All large
		/// rod-like calcifications follow a ductal distribution, radiating toward the nipple, occasionally
		/// branching.
		/// The calcifications usually are bilateral, although they may be seen in only one
		/// breast, especially when few calcific particles are visible.
		/// These calcifications usually are seen
		/// 
		/// in women older than 60 years.
		/// [Breast Imaging Reporting and Data System—Ultrasound, Second Edition]
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_LargeRodlike = new Coding(System, "LargeRodlike", "Large rodlike");                                             // Builder.cs:399
		                                                                                                                                          // Builder.cs:380
		/// <summary>
		/// Layering of calcium within the calcification.
		/// [https://radiologyassistant.nl/breast/breast-calcifications-differential-diagnosis]
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_Layering = new Coding(System, "Layering", "Layering");                                                          // Builder.cs:399
		                                                                                                                                          // Builder.cs:380
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
		public static Coding Code_FineLinear = new Coding(System, "FineLinear", "Fine Linear");                                                   // Builder.cs:399
		                                                                                                                                          // Builder.cs:380
		/// <summary>
		/// These are round or oval calcifications that range from under 1 mm to over a centimeter.
		/// They are the result of fat necrosis, calcified debris in ducts, and occasional fibroadenomas.
		/// [https://radiologyassistant.nl/breast/breast-calcifications-differential-diagnosis]
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_LucentCentered = new Coding(System, "Lucent-centered", "Lucent-centered");                                      // Builder.cs:399
		                                                                                                                                          // Builder.cs:380
		/// <summary>
		/// This is a manifestation of sedimented calcifications in macro- or microcysts, usually but not
		/// always grouped.
		/// On the craniocaudal image they are often less evident and appear as round,
		/// smudgy deposits, while occasionally on MLO and especially on 90  lateral (LM/ML) views,
		/// they are more clearly defined and often semilunar, crescent shaped, curvilinear (concave up),
		/// or linear, defining the dependent portion of cysts.
		/// The most important feature of these calcifications
		/// is the apparent change in shape of the calcific particles on different mammographic
		/// projections (craniocaudal versus occasionally the MLO view and especially LM/ML views).
		/// At
		/// times milk of calcium calcifications are seen adjacent to other types of calcifications that may
		/// be associated with malignancy, so it is important to search for more suspicious forms, especially
		/// 
		/// those that do not change shape from the 90  lateral projection to the CC projection.
		/// [Breast Imaging Reporting and Data System—Ultrasound, Second Edition]
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_MilkOfCalcium = new Coding(System, "MilkOfCalcium", "Milk of calcium");                                         // Builder.cs:399
		                                                                                                                                          // Builder.cs:380
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
		public static Coding Code_FinePleomorphic = new Coding(System, "FinePleomorphic", "Fine Pleomorphic");                                    // Builder.cs:399
		                                                                                                                                          // Builder.cs:380
		/// <summary>
		/// Calcification is punctate/round.
		/// It&#39;s different than a &quot;round&quot; calcification though as it also means the calcifications are less than .5 mm in size.
		/// May warrant a probably benign (non-cancer) assessment unless there is also a linear pattern or in a segmental distibution.
		/// This may require and imaging guided biopy or mammographic surveillance.
		/// 
		/// 
		/// [Breast Imaging Reporting and Data System—Ultrasound, Second Edition]
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_Punctate = new Coding(System, "Punctate", "Punctate");                                                          // Builder.cs:399
		                                                                                                                                          // Builder.cs:380
		/// <summary>
		/// Eggshell or Rim Calcifications
		/// These are very thin benign calcifications that appear as calcium is deposited on
		/// the surface of a sphere.
		/// Fat necrosis and calcifications in the walls of cysts are the most common &quot;rim&quot;
		/// calcifications, although more extensive (and occasionally thicker-rimmed) calcification
		/// in the
		/// walls of oil cysts or simple cysts may be seen.
		/// [Breast Imaging Reporting and Data System—Ultrasound, Second Edition page 49]
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_Rim = new Coding(System, "Rim", "Rim");                                                                         // Builder.cs:399
		                                                                                                                                          // Builder.cs:380
		/// <summary>
		/// When multiple, they may vary in size and therefore also in opacity.
		/// They may be considered
		/// benign when diffuse and small (&lt; 1 mm), and are frequently formed in the acini of lobules.
		/// When
		/// smaller than 0.5 mm, the term &quot;punctate&quot; should be used.
		/// An isolated group of punctate calcifications may warrant probably benign assessment and
		/// mammographic surveillance if no prior examinations are available for comparison, or
		/// image-guided biopsy if the group is new, increasing, linear or segmental in distribution, or if
		/// 
		/// adjacent to a known cancer.
		/// [Breast Imaging Reporting and Data System—Ultrasound, Second Edition]
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_Round = new Coding(System, "Round", "Round");                                                                   // Builder.cs:399
		                                                                                                                                          // Builder.cs:380
		/// <summary>
		/// These are usually lucent-centered and pathognomonic in their appearance.
		/// Skin calcifications are most commonly seen along the inframammary fold, parasternally, overlying the axilla and around the areola.
		/// The individual calcific particles usually are tightly grouped, with individual
		/// groups smaller than 5 mm in greatest dimension.
		/// Skin calcifications may develop from a degenerative metaplastic process.
		/// [Breast Imaging Reporting and Data System—Ultrasound, Second Edition page 36]
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_Skin = new Coding(System, "Skin", "Skin");                                                                      // Builder.cs:399
		                                                                                                                                          // Builder.cs:380
		/// <summary>
		/// Calcifications that have formed a  spherical shape are usually associated with benign
		/// lesions.
		/// [Breast Imaging Reporting and Data System—Ultrasound, Second Edition]
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_Spherical = new Coding(System, "Spherical", "Spherical");                                                       // Builder.cs:399
		                                                                                                                                          // Builder.cs:380
		/// <summary>
		/// These are typically linear or tubular in appearance, and when present in Mammogram, may show up in a knot pattern.
		/// 
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_Suture = new Coding(System, "Suture", "Suture");                                                                // Builder.cs:399
		                                                                                                                                          // Builder.cs:380
		/// <summary>
		/// These are linear or form parallel tracks, that are usually clearly associated with blood vessels.
		/// Vascular calcifications noted in women
		/// On the left typical vascular calcifications.
		/// 
		/// If only one side of a vessel is calcified, the calcification may simulate intraductal (across a group of milk ducts) calcification.
		/// [https://radiologyassistant.nl/breast/breast-calcifications-differential-diagnosis]
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_Vascular = new Coding(System, "Vascular", "Vascular");                                                          // Builder.cs:399
		//- Fields
	}
}
