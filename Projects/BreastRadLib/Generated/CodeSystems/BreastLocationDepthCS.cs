using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class BreastLocationDepthCS
	{
		//+ Fields
		const string System = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/BreastLocationDepthCS";                                         // CSBuilder.cs:346
		                                                                                                                                          // CSBuilder.cs:358
		/// <summary>
		/// The breast is divided into anterior, middle and posterior depth.
		/// The location of any lesion is given when discussed in the medical profession, with
		/// reference to a quadrant or 'clock position,' and the depth within the breast.
		/// Anterior depth is the outer most depth (closest to the nipple) of the breast.
		/// 
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_AnteriorDepth = new Coding(System, "AnteriorDepth", "Anterior depth");                                          // CSBuilder.cs:372
		                                                                                                                                          // CSBuilder.cs:358
		/// <summary>
		/// Middle depth in between the anterior and posterior portion of the breast.
		/// 
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_MiddleDepth = new Coding(System, "MiddleDepth", "Middle depth");                                                // CSBuilder.cs:372
		                                                                                                                                          // CSBuilder.cs:358
		/// <summary>
		/// Posterior depth (closest to the chest wall) of the  breast.
		/// 
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_PosteriorDepth = new Coding(System, "PosteriorDepth", "Posterior depth");                                       // CSBuilder.cs:372
		//- Fields
	}
}
