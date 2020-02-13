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
	public class FibroadenomaCodeSystemCS                                                                                                      // CSBuilder.cs:405
	//- Header
	{
		//+ Fields
		const string System = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/FibroadenomaCodeSystemCS";                                      // CSBuilder.cs:409
		                                                                                                                                          // CSBuilder.cs:421
		/// <summary>
		/// A fibroadenoma is a benign, or noncancerous, breast tumor.
		/// Unlike a breast cancer, which grows larger over time and can spread to other organs,
		/// a fibroadenoma remains in the breast tissue.
		/// They're pretty small, too.
		/// Most are only 1 or 2 centimeters in size.
		/// www.webmd.com > breast-cancer > what-are-fibroadenomas
		/// 
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_Fibroadenoma = new Coding(System, "Fibroadenoma", "Fibroadenoma");                                              // CSBuilder.cs:435
		                                                                                                                                          // CSBuilder.cs:421
		/// <summary>
		/// These are non-cancerous breast lumps.
		/// Fibroadenomas usually go away with age.
		/// By the time a woman is menopausal, they will likely experience a degeneration of
		/// the Fibroadenomas.
		/// 
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_FibroadenomaDegeneration = new Coding(System, "FibroadenomaDegeneration", "Fibroadenoma degeneration");         // CSBuilder.cs:435
		//- Fields
	}
}
