using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	//+ Header
	public class AbnormalityLymphNodeTypeCS                                                                                                    // CSBuilder.cs:416
	//- Header
	{
		//+ Fields
		const string System = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityLymphNodeTypeCS";                                    // CSBuilder.cs:420
		                                                                                                                                          // CSBuilder.cs:432
		/// <summary>
		/// Axillary Nodes.
		/// The axillary nodes are a group of lymph nodes located in the axillary (or armpit)
		/// region of the body.
		/// They perform the vital function of filtration and conduction of lymph from the upper
		/// limbs, pectoral region, and upper back.There are five axillary lymph node groups,
		/// namely the lateral (humeral), anterior (pectoral), posterior (subscapular), central
		/// and apical nodes.
		/// 
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_NodeAxillary = new Coding(System, "NodeAxillary", "Node axillary");                                             // CSBuilder.cs:446
		                                                                                                                                          // CSBuilder.cs:432
		/// <summary>
		/// Swollen lymph nodes usually occur as a result of infection from bacteria or viruses.
		/// Rarely, swollen lymph nodes are caused by cancer.
		/// Your lymph nodes, also called lymph glands, play a vital role in your body's ability
		/// to fight off infections.
		/// They function as filters, trapping viruses, bacteria and other causes of illnesses
		/// before they can infect other parts of your body.
		/// Common areas where you might notice swollen lymph nodes include your neck, under
		/// your chin, in your armpits and in your groin.
		/// 
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_NodeEnlarged = new Coding(System, "NodeEnlarged", "Node enlarged");                                             // CSBuilder.cs:446
		                                                                                                                                          // CSBuilder.cs:432
		/// <summary>
		/// The mammogram and/or ultrasound show enlargement of the cortex.
		/// Metastatic deposits accumulate in the lymph node peripheral area, causing enlargement of the cortex, usually focal (at early stages), or uniform.
		/// [www.ncbi.nlm.nih.gov > pmc > articles > PMC4337126]
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_NodeFocalCortex = new Coding(System, "NodeFocalCortex", "Node focal cortex");                                   // CSBuilder.cs:446
		                                                                                                                                          // CSBuilder.cs:432
		/// <summary>
		/// (Infraclavicular labeled at upper left.) One or two deltopectoral lymph nodes (or
		/// infraclavicular nodes) are found beside the cephalic vein, between the pectoralis
		/// major and deltoideus, immediately below the clavicle .
		/// They are situated in the course of the external collecting trunks of the arm.
		/// 
		/// Valid for the following modalities: US.
		/// </summary>
		public static Coding Code_NodeInfraclavicular = new Coding(System, "NodeInfraclavicular", "Node infraclavicular");                        // CSBuilder.cs:446
		                                                                                                                                          // CSBuilder.cs:432
		/// <summary>
		/// Intramammary lymph nodes are defined as lymph nodes surrounded by breast tissue.
		/// 
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_NodeIntramammary = new Coding(System, "NodeIntramammary", "Node intramammary");                                 // CSBuilder.cs:446
		                                                                                                                                          // CSBuilder.cs:432
		/// <summary>
		/// Abnormal lymph node viewed on ultrasound and/or ultrasound.
		/// Enlarged lymph nodes may warrant comment, clinical correlation and additional evaluation, especially if new or considerably larger or rounder when compared to previous examination.
		/// [Breast Imaging Reporting and Data System—Ultrasound, Second Edition]
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_NodeLymph = new Coding(System, "NodeLymph", "Node lymph");                                                      // CSBuilder.cs:446
		                                                                                                                                          // CSBuilder.cs:432
		/// <summary>
		/// The normal lymph node findings are probably benign.
		/// 
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_NodeLymphNormal = new Coding(System, "NodeLymphNormal", "Node lymph normal");                                   // CSBuilder.cs:446
		                                                                                                                                          // CSBuilder.cs:432
		/// <summary>
		/// The supraclavicular lymph nodes are a set of lymph nodes found just above the clavicle
		/// or collarbone, toward the hollow of the neck.
		/// Lymph nodes are responsible for filtering the lymphatic fluid of unwanted debris
		/// and bacteria.
		/// 
		/// Valid for the following modalities: US.
		/// </summary>
		public static Coding Code_NodeSupraclavicular = new Coding(System, "NodeSupraclavicular", "Node supraclavicular");                        // CSBuilder.cs:446
		                                                                                                                                          // CSBuilder.cs:432
		/// <summary>
		/// The mammogram and/or ultrasound shows thickening of the cortex is an indicator of an early change in metastasis.
		/// The qualitative methods used for the diagnosis of lymph node metastases on US include a round morphology, hypoechogenicity, loss of central hilum, or eccentric cortical hypertrophy.
		/// 
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_NodeUniformThickness = new Coding(System, "NodeUniformThickness", "Node uniform thickness");                    // CSBuilder.cs:446
		//- Fields
	}
}
