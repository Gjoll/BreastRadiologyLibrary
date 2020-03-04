using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class RecommendationsCodeSystemCS
	{
		//+ Fields
		const string System = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/RecommendationsCodeSystemCS";                                   // Builder.cs:377
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// Advanced Technology that takes multiple images, or X-rays, of breast tissue to recreate
		/// a 3-dimensional picture of the breast.
		/// Also called breast tomosynthesis.
		/// 
		/// Valid for the following modalities: MG US MRI.
		/// </summary>
		public static Coding Code_3DImaging = new Coding(System, "3DImaging", "3D Imaging");                                                      // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// Advanced Technology that takes multiple images, or X-rays, of breast tissue to recreate
		/// a 3-dimensional picture of the breast.
		/// Cranial-Caudal (CC) is a 3D view from above the breast.
		/// 
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_3DSpotCC = new Coding(System, "3DSpotCC", "3D spot CC");                                                        // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// Advanced Technology that takes multiple images, or X-rays, of breast tissue to recreate
		/// a 3-dimensional picture of the breast.
		/// Lateral-medial (LM) is
		/// 
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_3DSpotLM = new Coding(System, "3DSpotLM", "3D spot LM");                                                        // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// Advanced Technology that takes multiple images, or X-rays, of breast tissue to recreate
		/// a 3-dimensional picture of the breast.
		/// Mediolateral (ML) is
		/// 
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_3DSpotML = new Coding(System, "3DSpotML", "3D spot ML");                                                        // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// Advanced Technology that takes multiple images, or X-rays, of breast tissue to recreate
		/// a 3-dimensional picture of the breast.
		/// Mediolateral-oblique (MLO) is
		/// 
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_3DSpotMLO = new Coding(System, "3DSpotMLO", "3D spot MLO");                                                     // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// Additional views in Mammography, MRI and US, help increase the chances of finding
		/// any possible tumors in the breast.
		/// 
		/// Valid for the following modalities: MG US MRI.
		/// </summary>
		public static Coding Code_AdditionalViews = new Coding(System, "AdditionalViews", "Additional views");                                    // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// Additional views in a Mammogram, MRI or Ultrasound are recommended.
		/// 
		/// Valid for the following modalities: MG US MRI.
		/// </summary>
		public static Coding Code_AddlitionalViewsWithPossibleUltrasound = new Coding(System, "AddlitionalViewsWithPossibleUltrasound", "Addlitional views with possible ultrasound");// Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// An&#160;axillary view&#160;(also known as a&#160;&quot;Cleopatra view&quot;) is a type of view in mammography.&#160;It&#160;is
		/// an&#160;exaggerated craniocaudal view&#160;for better imaging of the lateral portion of the
		/// breast to the axillary tail.
		/// This projection is performed whenever we want to show a lesion seen only in the axillary
		/// tail on the&#160;MLO view.
		/// An optimal axillary view require to be clearly displayed the most lateral portion
		/// of the breast including the axillary tail, as well the pectoral muscle and the nipple
		/// in profile.
		/// [https://radiopaedia.org/articles/axillary-view?lang=us]
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_AxillaView = new Coding(System, "AxillaView", "Axilla view");                                                   // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// The tail of Spence (Spence&#39;s tail, axillary process, axillary tail) is an extension
		/// of the tissue of the breast that extends into the axilla.
		/// It is actually an extension of the upper lateral quadrant of the breast.
		/// It passes into the axilla through an opening in the deep fascia called foramen of
		/// Langer.
		/// [https://en.wikipedia.org/wiki/Tail_of_Spence]
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_AxillaryTailView = new Coding(System, "AxillaryTailView", "Axillary tail view");                                // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// A biopsy is recommended.
		/// An examination under a microscope  of the specific tissue removed from the body.
		/// The examination is used to check for abnormalities or cancer cells.
		/// 
		/// Valid for the following modalities: MG US MRI NM.
		/// </summary>
		public static Coding Code_Biopsy = new Coding(System, "Biopsy", "Biopsy");                                                                // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// Based on the clinical exam, a biopsy is recommended.
		/// 
		/// Valid for the following modalities: MG US MRI.
		/// </summary>
		public static Coding Code_BiopsyBaseOnClinical = new Coding(System, "BiopsyBaseOnClinical", "Biopsy base on clinical");                   // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// It is recommended that a Caudocranial view is captured by Ultrasound and/or Mammogram.
		/// It is useful for the study of breasts in the lower quadrants.
		/// The patient will bend forward at the waist to view the underside of the breast.
		/// Also called a reverse CC view.
		/// The reversed CC view is an additional view.
		/// It is useful for the study of breasts with surgical scars in the lower quadrants.
		/// The ability to see the scar through the compressor paddle offers to the mammographer
		/// the possibility to flatten it properly, reducing the formation of scar folds as well
		/// artifacts from false parenchymal distortion.
		/// 
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_CaudocranialView = new Coding(System, "CaudocranialView", "Caudocranial view");                                 // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// The recommendation is for a CC with compression view to be completed on an Ultrasound and/or Mammogram.
		/// 
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_CCWithCompressionView = new Coding(System, "CCWithCompressionView", "CC with compression view");                // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// The recommendation is for a CC with magnification view to be completed on an Ultrasound and/or Mammogram.
		/// 
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_CCWithMagnificationView = new Coding(System, "CCWithMagnificationView", "CC with magnification view");          // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// It is recommended that a cleavage view is captured via Mammogram and/or Ultrasound.
		/// Also called &quot;valley view&quot; is a mammogram view that images the most central portions
		/// of the breasts.
		/// To get as much central tissue as possible, the mammogram technologist will place
		/// both breasts on the plate at the same time to image the medial half of both breasts.
		/// 
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_CleavageView = new Coding(System, "CleavageView", "Cleavage view");                                             // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// A clinical consultation is recommended.
		/// 
		/// Valid for the following modalities: MG US MRI.
		/// </summary>
		public static Coding Code_ClinicalConsultation = new Coding(System, "ClinicalConsultation", "Clinical consultation");                     // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// The recommendation is for a clinicial correlation and/or comparison to be completed.
		/// 
		/// Valid for the following modalities: MG US MRI.
		/// </summary>
		public static Coding Code_ClinicalCorrelation = new Coding(System, "ClinicalCorrelation", "Clinical correlation");                        // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// The recommendation is for a clinical follow-up to be completed.
		/// 
		/// Valid for the following modalities: MG US MRI.
		/// </summary>
		public static Coding Code_ClinicalFollowUp = new Coding(System, "ClinicalFollow-up", "Clinical follow-up");                               // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// The recommendation is for a compare to prior exams to be completed.
		/// 
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_CompareToPriorExams = new Coding(System, "CompareToPriorExams", "Compare to prior exams");                      // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// It is recommended that a compression view is admininstered via Mammogram or Ultrasound.
		/// All mammograms use compression of the breast.
		/// By applying compression to only a specific area of the breast, the effective pressure
		/// is increased on that spot.
		/// This results in better tissue separation and allows better visualization of the area
		/// of the breast needing additional examination.
		/// 
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_CompressionViews = new Coding(System, "CompressionViews", "Compression views");                                 // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// A cone compression is recommended to catch a specific spot or view during the mammogram
		/// and/or ultrasound.
		/// Spot views apply the compression to a smaller area of tissue using a small compression
		/// plate or &quot;cone&quot;.
		/// 
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_ConeCompression = new Coding(System, "ConeCompression", "Cone compression");                                    // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// It is recommended that a&#160;core biopsy procedure is administered.
		/// It&#160;is a procedure where a needle is passed through the skin to take a sample of tissue
		/// from a mass or lump.
		/// The tissue is then examined under a microscope for any abnormalities.
		/// 
		/// Valid for the following modalities: MG US MRI.
		/// </summary>
		public static Coding Code_CoreBiopsy = new Coding(System, "CoreBiopsy", "Core Biopsy");                                                   // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// Cranial-Caudal (CC) is a view from above the breast during a mammogram or ultrasound.
		/// 
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_CraniocaudalView = new Coding(System, "CraniocaudalView", "Craniocaudal view");                                 // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// Uses imaging guidance, a needle-like applicator called a cryoprobe, and liquid nitrogen
		/// or argon gas to create intense cold to freeze and destroy diseased tissue, including
		/// cancer cells.
		/// It may be used to treat a variety of skin conditions as well as tumors within the
		/// liver, kidneys, bones, lungs and breasts.
		/// 
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_Cryoablation = new Coding(System, "Cryoablation", "Cryoablation");                                              // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// A cyst aspiration is a procedure used to drain fluid from a breast cyst.
		/// The vast majority of cysts are benign (non-cancerous), though some are quite tender.
		/// Aspirating the fluid from a cyst may alleviate symptoms or discomfort.
		/// In some cases, specimens are sent to pathology.
		/// [www.carolmilgardbreastcenter.org &gt; Cyst_Aspiration]
		/// Valid for the following modalities: MG US MRI.
		/// </summary>
		public static Coding Code_CystAspiration = new Coding(System, "CystAspiration", "Cyst aspiration");                                       // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// One way to get relief from the pain of a cyst is to remove fluid from
		/// the cyst, thereby decreasing the pressure.
		/// This is called aspiration for relief.
		/// 
		/// Valid for the following modalities: US.
		/// </summary>
		public static Coding Code_CystAspirationForRelief = new Coding(System, "CystAspirationForRelief", "Cyst aspiration for relief");          // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// This is a fine needle aspiration and is a type of biopsy procedure.
		/// In fine needle aspiration, a thin needle is inserted into an area of abnormal-appearing
		/// tissue or body fluid.
		/// [https://www.webmd.com &gt; a-to-z-guides &gt; fine-needle-aspiration]
		/// Valid for the following modalities: MG US MRI.
		/// </summary>
		public static Coding Code_DiagnosticAspiration = new Coding(System, "DiagnosticAspiration", "Diagnostic aspiration");                     // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// While screening mammograms are used as a routine check-up for breast health,  diagnostic
		/// mammograms are used after suspicious results on a screening mammogram or after some
		/// signs of breast cancer alert the physician to check the tissue.These signs may include
		/// a lump or breast pain.
		/// [https://www.nationalbreastcancer.org/diagnostic-mammogram]
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_DiagnosticMammogram = new Coding(System, "DiagnosticMammogram", "Diagnostic Mammogram");                        // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// The recommendation is for a drainage tube to be attached to breast.
		/// A drainage tube is a tube used to remove pus, blood or other fluids from a wound.
		/// This is a common practice by surgeons or interventional radiologists.
		/// [https://en.wikipedia.org/wiki/Drain_(surgery)]
		/// Valid for the following modalities: MG US MRI.
		/// </summary>
		public static Coding Code_DrainageTube = new Coding(System, "DrainageTube", "Drainage tube");                                             // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// A ductogram, also called a galactogram, is a special type of mammogram used for imaging
		/// the breast ducts.
		/// It can aid in diagnosing the cause of abnormal nipple discharges.
		/// Ductography (also called galactography or ductogalactography) is a special type of
		/// contrast enhanced mammography used for imaging the breast ducts.
		/// Ductography can aid in diagnosing the cause of an abnormal nipple discharge and is
		/// valuable in diagnosing intraductal papillomas and other conditions.
		/// [https://www.imaginis.com/mammography/ductogram-galactogram-imaging-the-breast-ducts]
		/// Valid for the following modalities: MG US MRI.
		/// </summary>
		public static Coding Code_Ductography = new Coding(System, "Ductography", "Ductography");                                                 // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// An&#160;XCCL view&#160;is a supplementary&#160;mammographic view.
		/// It is a type of&#160;exaggerated cranio-caudal view.
		/// It is particularly good for imaging the lateral aspect of the breast.&#160;It is often
		/// done when a lesion is suspected on a&#160;MLO view&#160;but cannot be seen on the&#160;CC view.&#160;In
		/// this view, the lateral aspect of the breast is placed forward.
		/// One rationale of performing this view is that many cancers are located in the lateral
		/// aspect of the breast.
		/// An XCCM view is a supplementary mammographic view.
		/// It is a type of exaggerated cranio-caudal view.
		/// It is particularly good for imaging the medial portion of the breast.
		/// In this view, the medial portion of the breast is placed forward.
		/// A negative 15degrees tube tilt is suggested.
		/// An optimal XCCM view requires the most medial portion of the breast and the nipple
		/// in profile to be clearly displayed.
		/// [https://radiopaedia.org/articles/xccl-view?lang=us]
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_ExaggeratedCCViews = new Coding(System, "ExaggeratedCCViews", "Exaggerated CC views");                          // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// FNA stands for Fine needle aspiration and this is a type of biopsy procedure.
		/// In fine needle aspiration, a thin needle is inserted into an area of abnormal-appearing
		/// tissue or body fluid.
		/// As with other types of biopsies, the sample collected during fine needle aspiration
		/// can help make a diagnosis or rule out conditions such as cancer.
		/// [https://www.webmd.com/a-to-z-guides/fine-needle-aspiration#1]
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_FNABiopsy = new Coding(System, "FNABiopsy", "FNA biopsy");                                                      // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// It is recommended to make a follow-up appointment.
		/// 
		/// Valid for the following modalities: US.
		/// </summary>
		public static Coding Code_FollowUp = new Coding(System, "Follow-up", "Follow-up");                                                        // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// It is recommended to make a follow-up appointment in 3 months.
		/// 
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_Followup3Months = new Coding(System, "Followup3Months", "Followup 3 months");                                   // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// It is recommended to make a follow-up appointment in 6 months.
		/// 
		/// Valid for the following modalities: MG US MRI.
		/// </summary>
		public static Coding Code_Followup6Months = new Coding(System, "Followup6Months", "Followup 6 months");                                   // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// The recommendation is for a if previous show no change to be completed.
		/// 
		/// Valid for the following modalities: US MRI.
		/// </summary>
		public static Coding Code_IfPreviousShowNoChange = new Coding(System, "IfPreviousShowNoChange", "If previous show no change");            // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// The recommendation is for a Lateral magnification view to be completed on Mammogram and/or Ultrasound.
		/// 
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_LateralMagnificationView = new Coding(System, "LateralMagnificationView", "Lateral magnification view");        // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// There are different views of the breast in mammography.
		/// For the LM view, the tube is lateral and the detector is placed medially
		/// LM view is best for evaluating medial lesions.
		/// 
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_LateralMedialView = new Coding(System, "LateralMedialView", "Lateral medial view");                             // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// There are different views of the breast in mammography.
		/// The lateral view is a view obtained at virtually every diagnostic evaluation.
		/// A lateral view may be obtained as a mediolateral view (ML) or lateromedial view (LM)
		/// view depending on where the imaging tube and detector are located.
		/// 
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_LateralView = new Coding(System, "LateralView", "Lateral view");                                                // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// The recommendation is for a Lateral with compression view to be completed on Mammogram.
		/// 
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_LateralWithCompressionView = new Coding(System, "LateralWithCompressionView", "Lateral with compression view"); // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// The recommendation is for a lateromedial oblique view to be completed on Mammogram and/or Ultrasound.
		/// 
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_LateromedialOblique = new Coding(System, "LateromedialOblique", "Lateromedial oblique");                        // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// The recommendation is for a lateromedial view to be completed on Mammogram and/or Ultrasound.
		/// 
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_LateromedialView = new Coding(System, "LateromedialView", "Lateromedial view");                                 // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// Lymph Node Exam.
		/// Palpation of the lymph nodes provides information about the possible presence of
		/// a malignant or inflammatory process and the localization or generalization of that
		/// process.
		/// [https://stanfordmedicine25.stanford.edu/the25/lymph.html]
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_LymphNodeAssessment = new Coding(System, "LymphNodeAssessment", "Lymph node assessment");                       // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// A&#160;magnification view&#160;in&#160;mammography&#160;is performed to evaluate and count&#160;microcalcifications&#160;and
		/// its extension (as well the assessment of the borders and the tissue structures of
		/// a suspicious area or a mass)&#160;by using a magnification device which brings the breast
		/// away from the film plate and closer to the x-ray source.
		/// This allows the acquisition of magnified images (1.5x to 2x magnification) of the
		/// region of interest.&#160;radiopaedia.org &gt; articles &gt; magnification-view-mammography
		/// 
		/// Valid for the following modalities: MG US MRI NM.
		/// </summary>
		public static Coding Code_MagnificationViews = new Coding(System, "MagnificationViews", "Magnification views");                           // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// An X-Ray picture of the breast.
		/// It&#39;s used to look for early signs of breast cancer.
		/// 
		/// Valid for the following modalities: MRI.
		/// </summary>
		public static Coding Code_Mammogram = new Coding(System, "Mammogram", "Mammogram");                                                       // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// A three month follow-up is recommended.
		/// 
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_Mammogram3MonthFollowUp = new Coding(System, "Mammogram3MonthFollow-up", "Mammogram 3 month follow-up");        // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// A six month follow-up is recommended.
		/// 
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_Mammogram6MonthFollowUp = new Coding(System, "Mammogram6MonthFollow-up", "Mammogram 6 month follow-up");        // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// A three month follow-up with ultrasound is recommended.
		/// 
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_MammogramAndUltrasound3MonthFollowUp = new Coding(System, "MammogramAndUltrasound3MonthFollow-up", "Mammogram and ultrasound 3 month follow-up");// Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// A six month follow-up with ultrasound is recommended.
		/// 
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_MammogramAndUltrasound6MonthFollowUp = new Coding(System, "MammogramAndUltrasound6MonthFollow-up", "Mammogram and ultrasound 6 month follow-up");// Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// A mediolateral oblique view is recommended.
		/// 
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_MediolateralObliqueView = new Coding(System, "MediolateralObliqueView", "Mediolateral oblique view");           // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// A mediolateral view is recommended.
		/// 
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_MediolateralView = new Coding(System, "MediolateralView", "Mediolateral view");                                 // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// An additional MLO with compression view of the breast is recommended.
		/// 
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_MLOWithCompressionView = new Coding(System, "MLOWithCompressionView", "MLO with compression view");             // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// An additional MLO with magnification view of the breast is recommended.
		/// 
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_MLOWithMagnificationView = new Coding(System, "MLOWithMagnificationView", "MLO with magnification view");       // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// An MRI is recommended.
		/// 
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_MRI = new Coding(System, "MRI", "MRI");                                                                         // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// An MRI with biopsy is recommended.
		/// 
		/// Valid for the following modalities: MG US MRI NM.
		/// </summary>
		public static Coding Code_MRIBiopsy = new Coding(System, "MRIBiopsy", "MRI biopsy");                                                      // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// An MRI follow-up is recommended.
		/// 
		/// Valid for the following modalities: MRI NM.
		/// </summary>
		public static Coding Code_MRIFollowUp = new Coding(System, "MRIFollow-up", "MRI follow-up");                                              // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// A Needle localization and surgical biopsy is recommended.
		/// 
		/// Valid for the following modalities: MG US MRI.
		/// </summary>
		public static Coding Code_NeedleLocationAndSurgicalBiopsy = new Coding(System, "NeedleLocationAndSurgicalBiopsy", "Needle location and surgical biopsy");// Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// A technically adequate exam has the nipple in profile, allows visualization of the
		/// inframammary fold and includes the pectoralis muscle extending down to the posterior
		/// nipple line (an oblique line drawn straight back from the nipple.)
		/// [https://www.mammoguide.com/mammo-techniques.html]
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_NippleInProfileView = new Coding(System, "NippleInProfileView", "Nipple in profile view");                      // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// An additional off angle CC view of the breast is recommended.
		/// 
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_OffAngleCCView = new Coding(System, "OffAngleCCView", "Off angle CC view");                                     // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// An additional off angle MLO  view of the breast is recommended.
		/// 
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_OffAngleMLOView = new Coding(System, "OffAngleMLOView", "Off angle MLO view");                                  // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// Stereotactic breast biopsy uses mammography - a specific type of breast imaging that
		/// uses low-dose x-rays - to help locate a breast abnormality and remove a tissue sample
		/// for examination under a microscope.
		/// It&#39;s less invasive than surgical biopsy, leaves little to no scarring and can be
		/// an excellent way to evaluate calcium deposits or tiny masses that are not visible
		/// on ultrasound.
		/// [https://www.radiologyinfo.org/en/info.cfm?pg=breastbixr]
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_PossStereotacticBx = new Coding(System, "Poss.StereotacticBx", "Poss. Stereotactic Bx");                        // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// A core needle biopsy (CNB)  uses a hollow needle to take out pieces of breast tissue from
		/// a suspicious area in an imaging test.
		/// The needle may be attached to a spring-loaded tool that moves the needle in and out
		/// of the tissue quickly, or it may be attached to a suction device that helps pull
		/// breast tissue into the needle.
		/// A small cylinder (core) of tissue is taken out in the needle.
		/// Several cores are often removed.
		/// [https://www.cancer.org/cancer/breast-cancer/screening-tests-and-early-detection/breast-biopsy/core-needle-biopsy-of-the-breast.html]
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_PossibleCoreBiopsy = new Coding(System, "PossibleCoreBiopsy", "Possible core biopsy");                          // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// A possible diagnostic mammogram is recommended.
		/// 
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_PossibleDiagnosticMammogram = new Coding(System, "PossibleDiagnosticMammogram", "Possible Diagnostic Mammogram");// Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// Based on the results of the mammogram, a possible stereotactic vacuum biopsy is recommended.
		/// During this type of biopsy, small samples of tissue are removed from the breast using
		/// a hollow needle, which is precisely guided to the correct location using x-rays and
		/// computer generated coordinates of the concerning area of breast tissue.
		/// [https://www.genesishealth.com/care-treatment/cancer/treat/breast/diagnosis/sterotactic_vacuum/]
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_PossibleStereotacticVacuumBiopsy = new Coding(System, "PossibleStereotacticVacuumBiopsy", "Possible stereotactic vacuum biopsy");// Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// A possible surgical consultation may be recommended.
		/// 
		/// Valid for the following modalities: NM.
		/// </summary>
		public static Coding Code_PossibleSurgicalConsult = new Coding(System, "PossibleSurgicalConsult", "Possible surgical consult");           // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// A possible surgical evaluation is recommended.
		/// 
		/// Valid for the following modalities: NM.
		/// </summary>
		public static Coding Code_PossibleSurgicalEvaluation = new Coding(System, "PossibleSurgicalEvaluation", "Possible surgical evaluation");  // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// A possible ultrasound is recommended.
		/// 
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_PossibleUltrasound = new Coding(System, "PossibleUltrasound", "Possible ultrasound");                           // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// A possible ultrasound guided biopsy is recommended.
		/// 
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_PossibleUltrasoundGuidedBiopsy = new Coding(System, "PossibleUltrasoundGuidedBiopsy", "Possible ultrasound guided biopsy");// Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// A possible vacuum biopsy is recommended.
		/// 
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_PossibleVacuumBiopsy = new Coding(System, "PossibleVacuumBiopsy", "Possible vacuum biopsy");                    // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// Another CC view of Mammogram is recommended.
		/// 
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_RepeatCCView = new Coding(System, "RepeatCCView", "Repeat CC view");                                            // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// Another MLO view of Mammogram is recommended.
		/// 
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_RepeatMLOView = new Coding(System, "RepeatMLOView", "Repeat MLO view");                                         // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// A rolled CC lateral view is recommended.
		/// A rolled CC view Is performed to locate a lesion only visible in the cranio-caudal
		/// view, or when overlapped tissues in the standard view can simulate or partially conceal
		/// a lesion: changing of  tissues distribution  allows to determine whether or not its
		/// presence.
		/// When the lesion identified moves medially or laterally respect to the standard projection,
		/// it is possible to determine in which quadrant it is localized.
		/// The breast is positioned on the image receptor as for the cranio-caudal view, then
		/// is rotated medially or laterally around the axis of the nipple prior to applying
		/// compression.
		/// [https://radiopaedia.org/articles/rolled-cc-view-1?lang=us]
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_RolledLateralView = new Coding(System, "RolledLateralView", "Rolled lateral view");                             // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// A rolled medial view is recommended.
		/// 
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_RolledMedialView = new Coding(System, "RolledMedialView", "Rolled medial view");                                // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// A Scintimammogram guided biopsy is recommended.
		/// This is performed by taking samples of an abnormality under guidance from the Scintimammogram.
		/// Scintimammography uses small amounts of radioactive material, a special camera and a computer to help investigate a breast abnormality.
		/// 
		/// This helps to guide the radiologist&#39;s biopsy equipment to the site of the imaging abnormality.
		/// [https://www.radiologyinfo.org/en/info.cfm?pg=breastbixr]
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_ScintimammogramGuidedBiopsy = new Coding(System, "ScintimammogramGuidedBiopsy", "Scintimammogram Guided Biopsy");// Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// A scintimammogram is recommended.
		/// Scintimammography is also known as nuclear medicine breast imaging, Breast Specific
		/// Gamma Imaging (BSGI) and Molecular Breast Imaging (MBI).
		/// This type of exam is used to investigate a breast abnormality found with mammography.
		/// Scintimammography uses small amounts of radioactive material, a special camera and
		/// a computer to help investigate a breast abnormality.
		/// Scintimammography can detect cancer even when dense breast tissue and breast implants
		/// are present.
		/// It can reduce unnecessary procedures by helping determine whether a biopsy is needed.
		/// [https://www.radiologyinfo.org/en/info.cfm?pg=scintimammo]
		/// Valid for the following modalities: MG US MRI.
		/// </summary>
		public static Coding Code_Scintimammography = new Coding(System, "Scintimammography", "Scintimammography");                               // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// A spot compression is recommended.
		/// A spot view (also known as a spot compression view or focal compression view) is
		/// an additional mammographic view performed by applying the compression to a smaller
		/// area of tissue using a small compression paddle, increasing the effective pressure
		/// on that spot.
		/// This results in better tissue separation and allows better visualization of the breast
		/// tissue in that area.
		/// It is used to distinguish between the presence of a true lesion and an overlap of
		/// tissues, as well to better show the borders of an abnormality or questionable area
		/// or a little cluster of faint microcalcifications in a dense area.
		/// [https://radiopaedia.org/articles/spot-view-mammography?lang=us]
		/// Valid for the following modalities: MG US NM.
		/// </summary>
		public static Coding Code_SpotCompression = new Coding(System, "SpotCompression", "Spot compression");                                    // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// Spot magnification views are recommended.
		/// 
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_SpotMagnificationViews = new Coding(System, "SpotMagnificationViews", "Spot magnification views");              // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// A stereotactic biopsy is recommended.
		/// 
		/// Valid for the following modalities: MG US MRI NM.
		/// </summary>
		public static Coding Code_StereotacticBx = new Coding(System, "StereotacticBx", "Stereotactic bx");                                       // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// A superolateral IO view is recommended.
		/// The view of the upper outer quadrant of the breast.
		/// This is the quadrant of the breast that is closest to the armpit.
		/// There are 4 quadrants in the anatomy of a breast.
		/// 
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_SuperolateralIOView = new Coding(System, "SuperolateralIOView", "Superolateral IO view");                       // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// A surgical biopsy is recommended.
		/// A surgical biopsy is a procedure that involves the surgical removal of tissue from
		/// a lump or mass for examination under a microscope.
		/// This test may also be called an open biopsy.
		/// Surgical biopsies can be excisional (removal of an entire lump or abnormal area)
		/// or incisional (removal of a piece of a lump or abnormal area).
		/// [https://www.cancer.ca/en/cancer-information/diagnosis-and-treatment/tests-and-procedures/surgical-biopsy/?region=on]
		/// Valid for the following modalities: NM.
		/// </summary>
		public static Coding Code_SurgicalBiopsy = new Coding(System, "SurgicalBiopsy", "Surgical biopsy");                                       // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// A surgical consult is recommended.
		/// 
		/// Valid for the following modalities: MG US MRI NM.
		/// </summary>
		public static Coding Code_SurgicalConsult = new Coding(System, "SurgicalConsult", "Surgical consult");                                    // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// A surgical consult and biopsy is recommended.
		/// 
		/// Valid for the following modalities: MG US MRI.
		/// </summary>
		public static Coding Code_SurgicalConsultAndBiopsy = new Coding(System, "SurgicalConsultAndBiopsy", "Surgical consult and biopsy");       // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// The recommendation is for a surgical evaluation.
		/// 
		/// Valid for the following modalities: NM.
		/// </summary>
		public static Coding Code_SurgicalEvaluation = new Coding(System, "SurgicalEvaluation", "Surgical evaluation");                           // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// The recommendation is for a surgical excision.
		/// 
		/// Valid for the following modalities: NM.
		/// </summary>
		public static Coding Code_SurgicalExcision = new Coding(System, "SurgicalExcision", "Surgical excision");                                 // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// The recommendation is for a surgical oncologic evaluation.
		/// 
		/// Valid for the following modalities: NM.
		/// </summary>
		public static Coding Code_SurgicalOncologicEvaluation = new Coding(System, "SurgicalOncologicEvaluation", "Surgical oncologic evaluation");// Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// The recommendation is for a surgical oncologic consult.
		/// 
		/// Valid for the following modalities: MG US MRI NM.
		/// </summary>
		public static Coding Code_SurgicalOncologicalConsult = new Coding(System, "SurgicalOncologicalConsult", "Surgical oncological consult");  // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// A tangential view is recommended.
		/// 
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_TangentialView = new Coding(System, "TangentialView", "Tangential view");                                       // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// Tangential views are recommended.
		/// 
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_TangentialViews = new Coding(System, "TangentialViews", "Tangential views");                                    // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// An ultrasound is recommended.
		/// 
		/// Valid for the following modalities: MG MRI NM.
		/// </summary>
		public static Coding Code_Ultrasound = new Coding(System, "Ultrasound", "Ultrasound");                                                    // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// An additional ultrasound is recommended.
		/// 
		/// Valid for the following modalities: MG US MRI NM.
		/// </summary>
		public static Coding Code_Ultrasound2ndLook = new Coding(System, "Ultrasound2ndLook", "Ultrasound 2nd Look");                             // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// An additional ultrasound is recommended in a 3 month follow-up.
		/// 
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_Ultrasound3MonthFollowUp = new Coding(System, "Ultrasound3MonthFollow-up", "Ultrasound 3 month follow-up");     // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// An additional ultrasound is recommended in a 3 month follow-up.
		/// 
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_Ultrasound6MonthFollowUp = new Coding(System, "Ultrasound6MonthFollow-up", "Ultrasound 6 month follow-up");     // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// An ultrasound guided biopsy is recommended.
		/// 
		/// Valid for the following modalities: MG US MRI NM.
		/// </summary>
		public static Coding Code_UltrasoundGuidedBx = new Coding(System, "UltrasoundGuidedBx", "Ultrasound guided bx");                          // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// An ultrasound localized and surgical biopsy is recommended.
		/// 
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_UltrasoundLocationAndSurgicalBiopsy = new Coding(System, "UltrasoundLocationAndSurgicalBiopsy", "Ultrasound location and surgical biopsy");// Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// An ultrasound with possible additional views are recommended.
		/// 
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_UltrasoundWithPossibleAddlitonalViews = new Coding(System, "UltrasoundWithPossibleAddlitonalViews", "Ultrasound with possible addlitonal views");// Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// Unspecified / other
		/// 
		/// Valid for the following modalities: US MRI.
		/// </summary>
		public static Coding Code_UnspecifiedOther = new Coding(System, "Unspecified/Other", "Unspecified / other");                              // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// A vacuum biopsy is recommended.
		/// 
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_VacuumBx = new Coding(System, "VacuumBx", "Vacuum Bx");                                                         // Builder.cs:408
		//- Fields
	}
}
