using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class FibroadenomaCodeSystemCS
	{
		//+ Fields
		const string System = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/FibroadenomaCodeSystemCS";                                      // Builder.cs:377
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// A fibroadenoma is a benign, or noncancerous, breast
		/// tumor.
		/// Unlike a breast cancer, which grows larger over time
		/// and can spread to other organs,
		/// a fibroadenoma remains in the breast tissue.
		/// Most are only 1 or 2 centimeters in size.
		/// [www.webmd.com &gt; breast-cancer &gt; what-are-fibroadenomas]
		/// 
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_Fibroadenoma = new Coding(System, "Fibroadenoma", "Fibroadenoma");                                              // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// These are non-cancerous breast lumps.
		/// Fibroadenomas usually go away with age.
		/// By the time an individual is menopausal, Fibroadenomas
		/// degenerate.
		/// 
		/// 
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_FibroadenomaDegeneration = new Coding(System, "FibroadenomaDegeneration", "Fibroadenoma degeneration");         // Builder.cs:408
		//- Fields
	}
}
