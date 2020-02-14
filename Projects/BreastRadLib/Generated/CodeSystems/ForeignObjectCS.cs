using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class ForeignObjectCS
	{
		//+ Fields
		const string System = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ForeignObjectCS";                                               // CSBuilder.cs:393
		                                                                                                                                          // CSBuilder.cs:405
		/// <summary>
		/// A BB pellet is present in the body and is visible by the Mammogram, MRI and/or Ultrasound.
		/// 
		/// Valid for the following modalities: MG US MRI.
		/// </summary>
		public static Coding Code_BBPellet = new Coding(System, "BBPellet", "BB pellet");                                                         // CSBuilder.cs:419
		                                                                                                                                          // CSBuilder.cs:405
		/// <summary>
		/// BB pellets are present in the body and is visible by the Mammogram, MRI and/or Ultrasound.
		/// 
		/// Valid for the following modalities: MG US MRI.
		/// </summary>
		public static Coding Code_BBPellets = new Coding(System, "BBPellets", "BB pellets");                                                      // CSBuilder.cs:419
		                                                                                                                                          // CSBuilder.cs:405
		/// <summary>
		/// Tissue marker placement after image-guided breast biopsy has become a routine component
		/// of clinical practice.
		/// Marker placement distinguishes multiple biopsied lesions within the same breast,
		/// prevents re-biopsy of benign lesions, enables multi-modality correlation, guides
		/// pre-operative localization and helps confirm surgical target removal.
		/// Numerous breast tissue markers are currently available, with varied shapes, composition,
		/// and associated bio-absorbable components.
		/// This review serves to familiarize the breast interventionalist with the tissue markers
		/// most widely available in the United States today and to provide guidance regarding
		/// selection of appropriate markers for various clinical settings.
		/// [https://www.ncbi.nlm.nih.gov/pubmed/30059952]
		/// Valid for the following modalities: MG US MRI.
		/// </summary>
		public static Coding Code_BiopsyClip = new Coding(System, "BiopsyClip", "Biopsy clip");                                                   // CSBuilder.cs:419
		                                                                                                                                          // CSBuilder.cs:405
		/// <summary>
		/// Tissue marker placement after image-guided breast biopsy has become a routine component
		/// of clinical practice.
		/// Marker placement distinguishes multiple biopsied lesions within the same breast,
		/// prevents re-biopsy of benign lesions, enables multi-modality correlation, guides
		/// pre-operative localization and helps confirm surgical target removal.
		/// Numerous breast tissue markers are currently available, with varied shapes, composition,
		/// and associated bio-absorbable components.
		/// This review serves to familiarize the breast interventionalist with the tissue markers
		/// most widely available in the United States today and to provide guidance regarding
		/// selection of appropriate markers for various clinical settings.
		/// [https://www.ncbi.nlm.nih.gov/pubmed/30059952]
		/// Valid for the following modalities: MG US MRI.
		/// </summary>
		public static Coding Code_BiopsyClips = new Coding(System, "BiopsyClips", "Biopsy clips");                                                // CSBuilder.cs:419
		                                                                                                                                          // CSBuilder.cs:405
		/// <summary>
		/// A breast marker is present in the  breast and is viewable on the MRI.
		/// Tissue marker placement after image-guided breast biopsy has become a routine component
		/// of clinical practice.
		/// Marker placement distinguishes multiple biopsied lesions within the same breast,
		/// prevents re-biopsy of benign lesions, enables multi-modality correlation, guides
		/// pre-operative localization and helps confirm surgical target removal.
		/// Numerous breast tissue markers are currently available, with varied shapes, composition,
		/// and associated bio-absorbable components.
		/// www.ncbi.nlm.nih.gov > pubmed
		/// 
		/// Valid for the following modalities: MRI.
		/// </summary>
		public static Coding Code_BreastMarker = new Coding(System, "BreastMarker", "Breast marker");                                             // CSBuilder.cs:419
		                                                                                                                                          // CSBuilder.cs:405
		/// <summary>
		/// Tissue marker placement after image-guided breast biopsy has become a routine component
		/// of clinical practice.
		/// Marker placement distinguishes multiple biopsied lesions within the same breast,
		/// prevents re-biopsy of benign lesions, enables multi-modality correlation, guides
		/// pre-operative localization and helps confirm surgical target removal.
		/// Numerous breast tissue markers are currently available, with varied shapes, composition,
		/// and associated bio-absorbable components.
		/// This review serves to familiarize the breast interventionalist with the tissue markers
		/// most widely available in the United States today and to provide guidance regarding
		/// selection of appropriate markers for various clinical settings.
		/// www.ncbi.nlm.nih.gov > pubmed
		/// 
		/// Valid for the following modalities: MRI.
		/// </summary>
		public static Coding Code_BreastMarkers = new Coding(System, "BreastMarkers", "Breast markers");                                          // CSBuilder.cs:419
		                                                                                                                                          // CSBuilder.cs:405
		/// <summary>
		/// A catheter sleeve was viewed in the Mammogram, MRI, and/or ultrasound.
		/// A catheter is a flexible tube used to deliver fluids into or withdraw fluids from the body.
		/// 
		/// Valid for the following modalities: MG US MRI.
		/// </summary>
		public static Coding Code_CatheterSleeves = new Coding(System, "CatheterSleeves", "Catheter sleeves");                                    // CSBuilder.cs:419
		                                                                                                                                          // CSBuilder.cs:405
		/// <summary>
		/// A soft thin tube called a catheter connects the port to a large vein for administering
		/// chemotherapy is present in the MRI/Ultrasound.
		/// 
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_ChemotherapyPort = new Coding(System, "ChemotherapyPort", "Chemotherapy port");                                 // CSBuilder.cs:419
		                                                                                                                                          // CSBuilder.cs:405
		/// <summary>
		/// A titanium-based marker (also known as a "clip") is placed for most core biopsies to mark the area in case surgery will be needed in the future.
		/// ...
		/// These marker clips are placed at most facilities around the country, and are considered a standard part of the breast biopsy procedure.
		/// 
		/// Valid for the following modalities: MG US MRI.
		/// </summary>
		public static Coding Code_Clip = new Coding(System, "Clip", "Clip");                                                                      // CSBuilder.cs:419
		                                                                                                                                          // CSBuilder.cs:405
		/// <summary>
		/// A titanium-based marker (also known as a "clip") is placed for most core biopsies to mark the area in case surgery will be needed in the future.
		/// ...
		/// These marker clips are placed at most facilities around the country, and are considered a standard part of the breast biopsy procedure.
		/// 
		/// Valid for the following modalities: MG US MRI.
		/// </summary>
		public static Coding Code_Clips = new Coding(System, "Clips", "Clips");                                                                   // CSBuilder.cs:419
		                                                                                                                                          // CSBuilder.cs:405
		/// <summary>
		/// The coil acts as an antenna to receive the radio frequency signal.
		/// This is present on the Mammogram, MRI and/or Ultrasound.
		/// 
		/// Valid for the following modalities: MG US MRI.
		/// </summary>
		public static Coding Code_Coil = new Coding(System, "Coil", "Coil");                                                                      // CSBuilder.cs:419
		                                                                                                                                          // CSBuilder.cs:405
		/// <summary>
		/// Glass is present in the body and shows up on the MRI, Mammogram, and/or Ultrasound.
		/// 
		/// Valid for the following modalities: MG US MRI.
		/// </summary>
		public static Coding Code_Glass = new Coding(System, "Glass", "Glass");                                                                   // CSBuilder.cs:419
		                                                                                                                                          // CSBuilder.cs:405
		/// <summary>
		/// Tiny, gold seeds that are put in and/or around a tumor to show exactly where the
		/// tumor is are present in the ultrasound/MRI.
		/// 
		/// Valid for the following modalities: MG US MRI.
		/// </summary>
		public static Coding Code_GoldSeed = new Coding(System, "GoldSeed", "Gold seed");                                                         // CSBuilder.cs:419
		                                                                                                                                          // CSBuilder.cs:405
		/// <summary>
		/// There is a gunshot would present in the body and is viewable on the Ultrasound, Mammogram and/or MRI
		/// 
		/// Valid for the following modalities: MG US MRI.
		/// </summary>
		public static Coding Code_GunshotWound = new Coding(System, "GunshotWound", "Gunshot wound");                                             // CSBuilder.cs:419
		                                                                                                                                          // CSBuilder.cs:405
		/// <summary>
		/// A marker clip (from possible previous biopsy) is visable in the Mammogram
		/// 
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_MarkerClip = new Coding(System, "MarkerClip", "Marker clip");                                                   // CSBuilder.cs:419
		                                                                                                                                          // CSBuilder.cs:405
		/// <summary>
		/// A piece of metal is present in the body and is viewable on the MRI and/or Ultrasound.
		/// 
		/// Valid for the following modalities: MG US MRI.
		/// </summary>
		public static Coding Code_Metal = new Coding(System, "Metal", "Metal");                                                                   // CSBuilder.cs:419
		                                                                                                                                          // CSBuilder.cs:405
		/// <summary>
		/// A metallic tissue marker is present in the ultrasound/MRI.
		/// 
		/// Valid for the following modalities: MRI.
		/// </summary>
		public static Coding Code_MetallicMarker = new Coding(System, "MetallicMarker", "Metallic marker");                                       // CSBuilder.cs:419
		                                                                                                                                          // CSBuilder.cs:405
		/// <summary>
		/// Metallic tissue markers are present in the MRI/Ultrasound.
		/// 
		/// Valid for the following modalities: MRI.
		/// </summary>
		public static Coding Code_MetallicMarkers = new Coding(System, "MetallicMarkers", "Metallic markers");                                    // CSBuilder.cs:419
		                                                                                                                                          // CSBuilder.cs:405
		/// <summary>
		/// The Mammogram suggests a foreign body in the breast that appears to be a metallic
		/// object.
		/// 
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_MetallicObjects = new Coding(System, "MetallicObjects", "Metallic objects");                                    // CSBuilder.cs:419
		                                                                                                                                          // CSBuilder.cs:405
		/// <summary>
		/// The Mammogram suggests a foreign body in the breast that appears to be a needle.
		/// 
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_Needle = new Coding(System, "Needle", "Needle");                                                                // CSBuilder.cs:419
		                                                                                                                                          // CSBuilder.cs:405
		/// <summary>
		/// The Mammogram suggests a foreign body in the breast that appears to be a piece of
		/// nipple jewelry.
		/// 
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_NippleJewelry = new Coding(System, "NippleJewelry", "Nipple jewelry");                                          // CSBuilder.cs:419
		                                                                                                                                          // CSBuilder.cs:405
		/// <summary>
		/// A non-metallic foreign body was located in the breast tissue.
		/// 
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_NonMetallicBody = new Coding(System, "Non-metallicBody", "Non-metallic body");                                  // CSBuilder.cs:419
		                                                                                                                                          // CSBuilder.cs:405
		/// <summary>
		/// A pacemaker is present showing up on the MRI and/or Ultrasound.
		/// 
		/// Valid for the following modalities: MG US MRI.
		/// </summary>
		public static Coding Code_Pacemaker = new Coding(System, "Pacemaker", "Pacemaker");                                                       // CSBuilder.cs:419
		                                                                                                                                          // CSBuilder.cs:405
		/// <summary>
		/// Silicone granuloma shows up on the MRI and/or Ultrasound.
		/// Snowball like hyperechogenic axillary lymph nodes in a woman with silicone implants
		/// removed due to complications.
		/// Specialty.
		/// Dermatology.
		/// Silicone granulomas are a skin condition that occur as a reaction to liquid silicones,
		/// and are characterized by the formation of nodules.
		/// 
		/// Valid for the following modalities: MG US MRI.
		/// </summary>
		public static Coding Code_SiliconeGranuloma = new Coding(System, "SiliconeGranuloma", "Silicone granuloma");                              // CSBuilder.cs:419
		                                                                                                                                          // CSBuilder.cs:405
		/// <summary>
		/// A surgical sponge can be viewed from the images in the Mammogram, MRI and/or ultrasound.
		/// 
		/// Valid for the following modalities: MG US MRI.
		/// </summary>
		public static Coding Code_Sponge = new Coding(System, "Sponge", "Sponge");                                                                // CSBuilder.cs:419
		                                                                                                                                          // CSBuilder.cs:405
		/// <summary>
		/// A surgical clip can be viewed within the Mammogram, MRI and/or Ultrasound.
		/// A tissue marker (or clip) is placed in your breast after a breast biopsy to help locate the site for future reference.
		/// 
		/// Valid for the following modalities: MG US MRI.
		/// </summary>
		public static Coding Code_SurgicalClip = new Coding(System, "SurgicalClip", "Surgical clip");                                             // CSBuilder.cs:419
		                                                                                                                                          // CSBuilder.cs:405
		/// <summary>
		/// Surgical clips can be viewed within the Mammogram, MRI and/or Ultrasound.
		/// A tissue marker (or clip) is placed in your breast after a breast biopsy to help locate the site for future reference.
		/// 
		/// Valid for the following modalities: MG US MRI.
		/// </summary>
		public static Coding Code_SurgicalClips = new Coding(System, "SurgicalClips", "Surgical clips");                                          // CSBuilder.cs:419
		                                                                                                                                          // CSBuilder.cs:405
		/// <summary>
		/// A Retained surgical swab appears to have been idenified in the breast during the
		/// mammogram, ultrasound and/or MRI.
		/// 
		/// Valid for the following modalities: MG US MRI.
		/// </summary>
		public static Coding Code_Swab = new Coding(System, "Swab", "Swab");                                                                      // CSBuilder.cs:419
		                                                                                                                                          // CSBuilder.cs:405
		/// <summary>
		/// In review of the MRI, Ultrasound, and/or Mammogram, a titanium-based marker (also known as a "clip") can be viewed inside the breast.
		/// This is placed for most core biopsies to mark the area in case surgery will be needed in the future.
		/// 
		/// These marker clips are placed at most facilities around the country, and are considered a standard part of the breast biopsy procedure.
		/// [https://med.nyu.edu/radiology/about-nyu-langone-radiology/subspecialty-sections/breast-imaging/image-guided-procedures]
		/// Valid for the following modalities: MG US MRI.
		/// </summary>
		public static Coding Code_TitaniumClip = new Coding(System, "TitaniumClip", "Titanium clip");                                             // CSBuilder.cs:419
		                                                                                                                                          // CSBuilder.cs:405
		/// <summary>
		/// In review of the MRI, Ultrasound, and/or Mammogram, a titanium-based marker (also known as a "clip") can be viewed inside the breast.
		/// This is placed for most core biopsies to mark the area in case surgery will be needed in the future.
		/// 
		/// These marker clips are placed at most facilities around the country, and are considered a standard part of the breast biopsy procedure.
		/// [https://med.nyu.edu/radiology/about-nyu-langone-radiology/subspecialty-sections/breast-imaging/image-guided-procedures]
		/// Valid for the following modalities: MG US MRI.
		/// </summary>
		public static Coding Code_TitaniumClips = new Coding(System, "TitaniumClips", "Titanium clips");                                          // CSBuilder.cs:419
		                                                                                                                                          // CSBuilder.cs:405
		/// <summary>
		/// Guidewire is present in the body.
		/// It is viewable in the MRI and/or Ultrasound.
		/// Guidewire is used during medical procedures such as biopsy or placement of medical
		/// devices such as a catheter or pacemaker.
		/// 
		/// Valid for the following modalities: MG US MRI.
		/// </summary>
		public static Coding Code_Wire = new Coding(System, "Wire", "Wire");                                                                      // CSBuilder.cs:419
		                                                                                                                                          // CSBuilder.cs:405
		/// <summary>
		/// A fragment of a guidewire is present in the body.
		/// It is viewable in the MRI and/or Ultrasound.
		/// Guidewire is used during medical procedures such as a biopsy or  placement of medical
		/// devices such as a catheter or pacemaker.
		/// 
		/// Valid for the following modalities: MG US MRI.
		/// </summary>
		public static Coding Code_WireFragment = new Coding(System, "WireFragment", "Wire fragment");                                             // CSBuilder.cs:419
		//- Fields
	}
}
