using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class ShapeCS
	{
		//+ Fields
		const string System = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ShapeCS";                                                       // Builder.cs:368
		                                                                                                                                          // Builder.cs:380
		/// <summary>
		/// A mass that can&#39;t be characterized by any specific shape.
		/// 
		/// Valid for the following modalities: MG US MRI.
		/// </summary>
		public static Coding Code_IrregularInShape = new Coding(System, "IrregularInShape", "Irregular in shape");                                // Builder.cs:399
		                                                                                                                                          // Builder.cs:380
		/// <summary>
		/// A mass that has an undulating  (having a smoothly rising and falling form or outline)
		/// contour.
		/// 
		/// Valid for the following modalities: MG US MRI.
		/// </summary>
		public static Coding Code_LobulatedInShape = new Coding(System, "LobulatedInShape", "Lobulated in shape");                                // Builder.cs:399
		                                                                                                                                          // Builder.cs:380
		/// <summary>
		/// There is a mass that is elliptical or egg-shaped.
		/// 
		/// Valid for the following modalities: MG US MRI.
		/// </summary>
		public static Coding Code_OvalInShape = new Coding(System, "OvalInShape", "Oval in shape");                                               // Builder.cs:399
		                                                                                                                                          // Builder.cs:380
		/// <summary>
		/// There is a mass that is reniform (kidney shape) in shape.
		/// 
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_Reniform = new Coding(System, "Reniform", "Reniform");                                                          // Builder.cs:399
		                                                                                                                                          // Builder.cs:380
		/// <summary>
		/// There is a mass that is spherical, ball-shaped, circular or global.
		/// 
		/// Valid for the following modalities: MG US MRI.
		/// </summary>
		public static Coding Code_RoundInShape = new Coding(System, "RoundInShape", "Round in shape");                                            // Builder.cs:399
		//- Fields
	}
}
