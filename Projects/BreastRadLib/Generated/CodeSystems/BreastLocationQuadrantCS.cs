using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class BreastLocationQuadrantCS
	{
		//+ Fields
		const string System = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/BreastLocationQuadrantCS";                                      // Builder.cs:377
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// The lower inside (closest to the cleavage of the
		/// breasts) quadrant of each breast.
		/// There are 4 quadrants to the anatomy of the breast.
		/// 
		/// 
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_InferiorMedialQuadrent = new Coding(System, "InferiorMedialQuadrent", "Inferior medial quadrent (lower inner)");// Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// The upper inside (closest to the armpit of each breast)
		/// quadrant of each breast.
		/// There are 4 quadrants to the anatomy of the breast.
		/// 
		/// 
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_InferiorLateralQuadrent = new Coding(System, "InferiorLateralQuadrent", "Inferior lateral quadrent (lower outer)");// Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// The upper inside (closest to the cleavage of the
		/// breasts) quadrant of each breast.
		/// There are 4 quadrants to the anatomy of the breast.
		/// 
		/// 
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_SuperiorMedialQuadrent = new Coding(System, "SuperiorMedialQuadrent", "Superior medial quadrent (upper inner)");// Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// The upper outside (closest to the armpit on each
		/// breast) quadrant of each breast.
		/// There are 4 quadrants to the anatomy of the breast.
		/// 
		/// 
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_SuperiorLateralQuadrent = new Coding(System, "SuperiorLateralQuadrent", "Superior lateral quadrent (upper outer)");// Builder.cs:408
		//- Fields
	}
}
