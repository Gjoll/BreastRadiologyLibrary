using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class OrientationCS
	{
		//+ Fields
		const string System = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/OrientationCS";                                                 // Builder.cs:371
		                                                                                                                                          // Builder.cs:383
		/// <summary>
		/// The lesion/mass is oriented parellel to skin.
		/// 
		/// Valid for the following modalities: MG US MRI NM.
		/// </summary>
		public static Coding Code_ParallelToSkin = new Coding(System, "ParallelToSkin", "Parallel to skin");                                      // Builder.cs:402
		                                                                                                                                          // Builder.cs:383
		/// <summary>
		/// The lesion/mass is oriented perpendicular to skin.
		/// 
		/// Valid for the following modalities: MG US MRI NM.
		/// </summary>
		public static Coding Code_PerpendicularToSkin = new Coding(System, "PerpendicularToSkin", "Perpendicular to skin (not parallel)");        // Builder.cs:402
		                                                                                                                                          // Builder.cs:383
		/// <summary>
		/// The nodule is taller than wide.
		/// A nodule is said to be taller than wide when it is greater in the direction normal to the skin than in the parallel ones.
		/// 
		/// Valid for the following modalities: US MRI.
		/// </summary>
		public static Coding Code_TallerThanWide = new Coding(System, "TallerThanWide", "Taller than wide");                                      // Builder.cs:402
		                                                                                                                                          // Builder.cs:383
		/// <summary>
		/// The nodule is wider than tall.
		/// A nodule is said to be wider than tall when it is larger in the direction not parallel to the direction of the skin.
		/// 
		/// Valid for the following modalities: US MRI.
		/// </summary>
		public static Coding Code_WiderThanTall = new Coding(System, "WiderThanTall", "Wider than tall");                                         // Builder.cs:402
		//- Fields
	}
}
