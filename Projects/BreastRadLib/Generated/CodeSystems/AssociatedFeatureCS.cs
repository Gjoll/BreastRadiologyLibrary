using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class AssociatedFeatureCS
	{
		//+ Fields
		const string System = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/AssociatedFeatureCS";                                           // Builder.cs:377
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// Many breast masses are found within the zone of fibroglandular tissue or at a fat-fibroglandular
		/// junction.
		/// If the mass blurs a tissue plane between fat and fibroglandular tissue or if the
		/// mass produces
		/// distortion of the ducts, these findings may be termed architectural distortion.
		/// [Breast Imaging Reporting and Data System—Mammography, Fifth Edition page 139]
		/// Valid for the following modalities: MG US MRI.
		/// </summary>
		public static Coding Code_ArchitecturalDistortion = new Coding(System, "ArchitecturalDistortion", "Architectural distortion");            // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// Enlarged axillary (under the armpit) lymph nodes.
		/// Additional evaluation is needed to determine the cause.
		/// [Breast Imaging Reporting and Data System—Ultrasound, Second Edition page 110]
		/// Valid for the following modalities: MG MRI.
		/// </summary>
		public static Coding Code_AxillaryAdenopathy = new Coding(System, "AxillaryAdenopathy", "Axillary adenopathy");                           // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// Tissue marker placement after image-guided breast biopsy has become a routine component
		/// of clinical practice.
		/// Marker placement distinguishes multiple biopsied lesions within the same breast,
		/// prevents re-biopsy of benign lesions, enables multi-modality correlation, guides
		/// pre-operative localization and helps confirm surgical target removal.
		/// Numerous breast tissue markers are currently available, with varied shapes, composition,
		/// and associated bio-absorbable components.
		/// [https://www.ncbi.nlm.nih.gov/pubmed/30059952]
		/// Valid for the following modalities: MG US MRI.
		/// </summary>
		public static Coding Code_BiopsyClip = new Coding(System, "BiopsyClip", "Biopsy clip");                                                   // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// Brachytherapy may be temporary or permanent.
		/// Temporary brachytherapy places radioactive material inside a catheter for a specific
		/// amount of time and then it is removed.
		/// It is given at a low-dose rate (LDR) or high-dose rate (HDR).
		/// Permanent brachytherapy is also called seed implantation.
		/// It puts radioactive seeds (about the size of a grain of rice) in or near the tumor
		/// permanently.
		/// After several months, the seeds lose their radioactivity.
		/// [https://www.radiologyinfo.org/en/info.cfm?pg=brachy]
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_BrachytherapyTube = new Coding(System, "BrachytherapyTube", "Brachytherapy tube");                              // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// A tumor of the lung that has invaded the chest wall.
		/// 
		/// Valid for the following modalities: MG US MRI.
		/// </summary>
		public static Coding Code_ChestWallInvasion = new Coding(System, "ChestWallInvasion", "Chest wall invasion");                             // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// The cooper&#39;s ligaments are fibrous bands extending vertically from surface attached to
		/// chest wall muscles.
		/// These ligaments maintain the shape and structure of your breasts and help to prevent
		/// sagging.
		/// Cooper&#39;s ligaments support the breasts on the chest wall, maintain their contour,
		/// and keep them in position.
		/// They become distorted if cancerous tumors grow on the ligaments.
		/// The normal breast contours can be noticeably different once they are distorted.
		/// This can be because of swelling, bulges, retraction, etc.
		/// 
		/// Valid for the following modalities: US.
		/// </summary>
		public static Coding Code_CooperDistorted = new Coding(System, "CooperDistorted", "Cooper distorted");                                    // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// The cooper&#39;s ligaments are fibrous bands extending vertically from surface attached
		/// to chest wall muscles.
		/// These ligaments maintain the shape and structure of your breasts and help to prevent
		/// sagging.
		/// Cooper&#39;s ligaments support the breasts on the chest wall, maintain their contour,
		/// and keep them in position.
		/// These support breast tissue; they become contracted in cancer of breast, producing
		/// dimples in overlying skin.
		/// Thickening occurs when there are skin changes usually associated with the presence
		/// of a mass, benign or malignant, that causes shortening in the Coopers ligaments due
		/// to fibrosis.
		/// 
		/// Valid for the following modalities: US.
		/// </summary>
		public static Coding Code_CooperThickened = new Coding(System, "CooperThickened", "Cooper thickened");                                    // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// Edema (swelling of the breasts)  may be due to blockage of subdermal lymphatics by tumor cells or an inflammatory process within the breast or axilla.
		/// 
		/// Valid for the following modalities: US.
		/// </summary>
		public static Coding Code_Edema = new Coding(System, "Edema", "Edema");                                                                   // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// This is swelling of one or both breasts.
		/// A mammographic pattern of skin thickening, increased parenchymal density, and interstitial marking.
		/// 
		/// Valid for the following modalities: US.
		/// </summary>
		public static Coding Code_EdemaAdj = new Coding(System, "EdemaAdj", "Edema adj");                                                         // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// Tiny, gold seeds, about the size of a grain of rice, that are put in and/or around
		/// a tumor to show exactly where it is in the body.
		/// The tumor can then be directly targeted and be given higher doses of radiation
		/// with less harm to nearby healthy tissue.
		/// Also called gold fiducial marker seeds, gold fiducial markers, and gold-seed fiducial
		/// markers.
		/// [https://www.cancer.gov/publications/dictionaries/cancer-terms/def/gold-seeds]
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_GoldSeed = new Coding(System, "GoldSeed", "Gold Seed");                                                         // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// A&#160;hematoma is a localized bleeding outside of blood vessels, due to either disease
		/// or trauma including injury or surgery and may involve blood continuing to seep from
		/// broken capillaries.
		/// en.wikipedia.org &gt; wiki &gt; Hematoma
		/// 
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_Hematoma = new Coding(System, "Hematoma", "Hematoma");                                                          // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// Retracted nipples lie flat against the areola.
		/// The condition can be the result of inflammation or scarring of the tissue behind
		/// the nipple, and caused by numerous conditions, not just cancer.
		/// In the case of breast cancer, nipple retraction occurs when the tumor attacks the
		/// duct behind the nipple, pulling it in.
		/// 
		/// Valid for the following modalities: MG MRI.
		/// </summary>
		public static Coding Code_NippleRetraction = new Coding(System, "NippleRetraction", "Nipple retraction");                                 // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// The mass has not attached itself to the chest wall.
		/// 
		/// Valid for the following modalities: MRI.
		/// </summary>
		public static Coding Code_NOChestWallInvasion = new Coding(System, "NOChestWallInvasion", "NO Chest wall invasion");                      // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// Pectoralis muscle invasion is when a tumor has become large enough to invade into
		/// the pectoralis muscle.
		/// 
		/// Valid for the following modalities: US MRI.
		/// </summary>
		public static Coding Code_PectoralisMuscleInvasion = new Coding(System, "PectoralisMuscleInvasion", "Pectoralis muscle invasion");        // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// Pectoralis muscle involvement of the tumor has been detected on the MRI by muscle
		/// enhancement with obliteration of the fat plane between the tumor and the muscle.
		/// pubs.rsna.org &gt; doi &gt; pdf
		/// 
		/// Valid for the following modalities: MRI.
		/// </summary>
		public static Coding Code_PectoralisMuscleInvolvement = new Coding(System, "PectoralisMuscleInvolvement", "Pectoralis muscle involvement");// Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// The tent sign is a term referring to a characteristic appearance of the posterior
		/// edge of the breast parenchyma when a mass (usually an infiltrating lesion) causes
		/// its retraction and forms an inverted &quot;V&quot; that resembles the tip of a circus tent.
		/// [https://radiopaedia.org/articles/tent-sign-breast?lang=us]
		/// Valid for the following modalities: US MRI.
		/// </summary>
		public static Coding Code_PectoralisMuscleTenting = new Coding(System, "PectoralisMuscleTenting", "Pectoralis muscle tenting");           // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// Post surgical scarring happens because of the incisions needed to surgically remove
		/// tumor, cells, etc.
		/// The amount of scarring is connected to the different stages of wound healing.
		/// Surgical scar care should be continued for a year.
		/// 
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_PostSurgicalScar = new Coding(System, "PostSurgicalScar", "Post surgical scar");                                // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// A breast seroma is a collection (pocket) of serous fluid that can develop after trauma
		/// to the breast or following procedures such as breast surgery or radiation therapy.
		/// Serous fluid is a pale yellow, transparent fluid that contains protein, but no blood
		/// cells or pus.
		/// [https://www.verywellhealth.com/seroma-medical-definition-430372]
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_Seroma = new Coding(System, "Seroma", "Seroma");                                                                // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// The mass or lesion has attached itself to the skin of the breast.
		/// There are several layers of skin that the mass or lesion can penetrate and that is
		/// what determines the level of skin invasion.
		/// 
		/// Valid for the following modalities: MG US MRI.
		/// </summary>
		public static Coding Code_SkinInvolvement = new Coding(System, "SkinInvolvement", "Skin involvement");                                    // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// A skin lesion is a part of the skin that has an abnormal growth or appearance compared
		/// to the skin around it.In order to diagnose a skin lesion, a full physical exam is necessary.
		/// 
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_SkinLesion = new Coding(System, "SkinLesion", "Skin lesion");                                                   // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// Skin retraction (or inversion) or Skin retraction.
		/// Breast cancers that are located near the skin or nipple may cause scarring within
		/// the breast that pulls at the nipple or nearby skin.
		/// Skin and nipple retraction are more obvious when a woman raises her arms above her
		/// head or leans forward.
		/// [https://www.drholmesmd.com/blog/early-signs-of-breast-cancer]
		/// Valid for the following modalities: MG US MRI.
		/// </summary>
		public static Coding Code_SkinRetraction = new Coding(System, "SkinRetraction", "Skin retraction");                                       // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// The presence of skin thickening on mammography is variably defined, usually being
		/// more than 2 mm in thickness.
		/// It can result from a number of both benign and malignant causes.
		/// [https://radiopaedia.org/articles/skin-thickening-on-mammography-differential?lang=us]
		/// Valid for the following modalities: MG US MRI.
		/// </summary>
		public static Coding Code_SkinThickening = new Coding(System, "SkinThickening", "Skin thickening");                                       // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// Most surgical clips are currently made of titanium, and as many as 30 to 40 clips
		/// may be used during a single surgical procedure.
		/// They remain inside the patient&#39;s body after the wounds are healed.
		/// 
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_SurgicalClip = new Coding(System, "SurgicalClip", "Surgical clip");                                             // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// Trabecular thickening-thickening of the Cooper&#39;s ligaments and fibrous stroma-is
		/// an imaging finding of breast edema, usually secondary to dilated lymphatics.
		/// Skin thickening and trabecular thickening often occur together, and they have similar
		/// differential diagnoses.
		/// [https://oxfordmedicine.com/view/10.1093/med/9780190270261.001.0001/med-9780190270261-chapter-48]
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_TrabecularThickening = new Coding(System, "TrabecularThickening", "Trabecular thickening");                     // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// Calcifications usually can&#39;t be felt, but they appear on a mammogram.
		/// Depending on how they&#39;re clustered and their shape, size, and number, further tests may be necessary.
		/// Larger &quot;macrocalcifications&quot; are usually not associated with cancer.
		/// 
		/// Valid for the following modalities: US.
		/// </summary>
		public static Coding Code_CalcificationInMass = new Coding(System, "CalcificationInMass", "Calcification in mass");                       // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// Calcifications usually can&#39;t be felt, but they appear on a mammogram.
		/// Depending on how they&#39;re clustered and their shape, size, and number.
		/// Large   &quot;macrocalcifications&quot; are usually not associated with cancer.
		/// 
		/// Valid for the following modalities: US.
		/// </summary>
		public static Coding Code_CalcificationNotOnMammogarm = new Coding(System, "CalcificationNotOnMammogarm", "Calcification Not on mammogarm");// Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// Calcifications are small deposits of calcium that show up on mammograms as bright
		/// white specks or dots on the soft tissue background of the breasts.
		/// The calcium readily absorbs the X-rays from mammograms
		/// 
		/// Valid for the following modalities: US.
		/// </summary>
		public static Coding Code_CalcificationOnMammogram = new Coding(System, "CalcificationOnMammogram", "Calcification on mammogram");        // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// Calcifications are small deposits of calcium that show up on mammograms as bright
		/// white specks or dots on the soft tissue background of the breasts.
		/// 
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_Calcifications = new Coding(System, "Calcifications", "Calcifications");                                        // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// These show up as fine, white specks in a mammogram, similar to grains of salt.
		/// They&#39;re usually noncancerous, but certain patterns can be an early sign of cancer.
		/// 
		/// Valid for the following modalities: US.
		/// </summary>
		public static Coding Code_MicroCalcifications = new Coding(System, "MicroCalcifications", "Micro calcifications");                        // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// The term milk of calcium (MOC) is given to dependent, sedimented calcification within
		/// a cystic structure or hollow organ.
		/// This sort of colloidal calcium suspension layering can occur in various regions.
		/// [https://radiopaedia.org/articles/milk-of-calcium-disambiguation?lang=us]
		/// Valid for the following modalities: US.
		/// </summary>
		public static Coding Code_MilkOfCalcium = new Coding(System, "MilkOfCalcium", "Milk of calcium");                                         // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// These are very thin benign calcifications that appear as calcium is deposited on
		/// the surface of a sphere.
		/// Although fat necrosis can produce these thin deposits, calcifications in the wall
		/// of cysts are the most common &#39;rim&#39; calcifications.
		/// 
		/// Valid for the following modalities: US.
		/// </summary>
		public static Coding Code_RimCalcifications = new Coding(System, "RimCalcifications", "Rim calcifications");                              // Builder.cs:408
		//- Fields
	}
}
