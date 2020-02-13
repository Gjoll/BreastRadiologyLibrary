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
	public class MassTypeCS                                                                                                                    // CSBuilder.cs:405
	//- Header
	{
		//+ Fields
		const string System = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/MassTypeCS";                                                    // CSBuilder.cs:409
		                                                                                                                                          // CSBuilder.cs:421
		/// <summary>
		/// A breast mass has been identified in the breast.
		/// This is also known as a breast lump.
		/// It feels different from the surrounding tissue.
		/// Breast pain, nipple discharge, or skin changes may be present.
		/// 
		/// Valid for the following modalities: MG US MRI.
		/// </summary>
		public static Coding Code_Mass = new Coding(System, "Mass", "Mass");                                                                      // CSBuilder.cs:435
		                                                                                                                                          // CSBuilder.cs:421
		/// <summary>
		/// An intraductal mass has been identified in the breast.
		/// It is a lump that originates in one or more of the milk ducts in the breast.
		/// 
		/// Valid for the following modalities: US.
		/// </summary>
		public static Coding Code_MassIntraductal = new Coding(System, "MassIntraductal", "Mass intraductal");                                    // CSBuilder.cs:435
		                                                                                                                                          // CSBuilder.cs:421
		/// <summary>
		/// A mass that is partially solid has been identified in the breast.
		/// 
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_MassPartiallySolid = new Coding(System, "MassPartiallySolid", "Mass partially solid");                          // CSBuilder.cs:435
		                                                                                                                                          // CSBuilder.cs:421
		/// <summary>
		/// The mammogram and/or ultrasound show a skin lesion.
		/// 
		/// This finding may be described in the mammography report or annotated on the mammographic image when it projects over the breast (especially on two different projections) and may be mistaken for an intramammary lesion.
		/// 
		/// -- Breast Imaging Reporting and Data System—Ultrasound, Second Edition
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_MassSkinATLASIsSkinLesion = new Coding(System, "MassSkinATLASIsSkinLesion", "Mass skin ATLAS is skin lesion");  // CSBuilder.cs:435
		                                                                                                                                          // CSBuilder.cs:421
		/// <summary>
		/// The mammogram and/or ultrasound show solid mass of the breast.
		/// This can be nodules, fibrocystic tissue, phylloides tumor, breast cancer or metastatic.
		/// May need a biopsy confirmation.
		/// 
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_MassSolid = new Coding(System, "MassSolid", "Mass solid");                                                      // CSBuilder.cs:435
		//- Fields
	}
}
