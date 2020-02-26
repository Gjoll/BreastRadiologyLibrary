using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class PreviouslyDemonstratedByCodeSystemCS
	{
		//+ Fields
		const string System = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/PreviouslyDemonstratedByCodeSystemCS";                          // Builder.cs:368
		                                                                                                                                          // Builder.cs:380
		/// <summary>
		/// A medical procedure that removes something from an area of the body.
		/// These substances can be air, body fluids, or bone fragments.
		/// [https://medlineplus.gov/ency/article/002216.htm]
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_Aspiration = new Coding(System, "Aspiration", "Aspiration");                                                    // Builder.cs:399
		                                                                                                                                          // Builder.cs:380
		/// <summary>
		/// An examination under a microscope  of the specific tissue removed from the body.
		/// The examination is used to check for abnormalities or cancer cells.
		/// 
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_Biopsy = new Coding(System, "Biopsy", "Biopsy");                                                                // Builder.cs:399
		                                                                                                                                          // Builder.cs:380
		/// <summary>
		/// Findings on the Mammogram was previously demonstrated by the MRI.
		/// 
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_MRI = new Coding(System, "MRI", "MRI");                                                                         // Builder.cs:399
		                                                                                                                                          // Builder.cs:380
		/// <summary>
		/// Findings on the Mammogram was previously demonstrated by the Ultrasound.
		/// 
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_US = new Coding(System, "US", "US");                                                                            // Builder.cs:399
		//- Fields
	}
}
