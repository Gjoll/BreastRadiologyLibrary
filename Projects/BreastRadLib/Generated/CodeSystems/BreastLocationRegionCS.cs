using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class BreastLocationRegionCS
	{
		//+ Fields
		const string System = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/BreastLocationRegionCS";                                        // Builder.cs:377
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// The axilla (also, armpit, underarm or oxter) is the area on the human body directly
		/// under the joint where the arm connects to the shoulder.
		/// It also contains many sweat glands.
		/// [https://en.wikipedia.org/wiki/Axilla]
		/// 
		/// Valid for the following modalities: US.
		/// </summary>
		public static Coding Code_Axilla = new Coding(System, "Axilla", "Axilla");                                                                // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// The tail of Spence (Spence&#39;s tail, axillary process, axillary tail) is an extension
		/// of the tissue of the breast that extends into the axilla.
		/// It is actually an extension of the upper lateral quadrant of the breast.
		/// It passes into the axilla through an opening in the deep fascia called foramen of
		/// Langer.
		/// [https://en.wikipedia.org/wiki/Tail_of_Spence]
		/// 
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_AxillaryTail = new Coding(System, "AxillaryTail", "Axillary tail");                                             // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// There are three levels of axillary lymph nodes (the nodes in the underarm or &quot;axilla&quot; area): Level I is the bottom level, below the lower edge of the pectoralis minor muscle.
		/// [https://www.breastcancer.org/treatment/surgery/lymph_node_removal/axillary_dissection]
		/// </summary>
		public static Coding Code_AxillaI = new Coding(System, "AxillaI", "Axilla I");                                                            // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// There are three levels of axillary lymph nodes (the nodes in the underarm or &quot;axilla&quot; area):Level II is lying underneath the pectoralis minor muscle.
		/// [https://www.breastcancer.org/treatment/surgery/lymph_node_removal/axillary_dissection]
		/// </summary>
		public static Coding Code_AxillaII = new Coding(System, "AxillaII", "Axilla II");                                                         // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// There are three levels of axillary lymph nodes (the nodes in the underarm or &quot;axilla&quot; area): Level III is above the pectoralis minor muscle.
		/// [https://www.breastcancer.org/treatment/surgery/lymph_node_removal/axillary_dissection]
		/// </summary>
		public static Coding Code_AxillaIII = new Coding(System, "AxillaIII", "Axilla III");                                                      // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// The mass/lesion is located in the inframammary crease where the lower boundary of the breast and the chest meet.
		/// 
		/// 
		/// Valid for the following modalities: MG US MRI NM.
		/// </summary>
		public static Coding Code_InframammaryFold = new Coding(System, "InframammaryFold", "Inframammary fold");                                 // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// Located within the skin.
		/// 
		/// 
		/// Valid for the following modalities: MG US MRI NM.
		/// </summary>
		public static Coding Code_InSkin = new Coding(System, "InSkin", "In skin");                                                               // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// Central to the nipple (central portion of the breast-behind the nipple).
		/// 
		/// 
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_CentralToNipple = new Coding(System, "CentralToNipple", "Central to nipple");                                   // Builder.cs:408
		//- Fields
	}
}
