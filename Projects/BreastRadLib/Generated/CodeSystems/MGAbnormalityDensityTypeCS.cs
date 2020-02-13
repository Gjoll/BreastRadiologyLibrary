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
	public class MGAbnormalityDensityTypeCS                                                                                                    // CSBuilder.cs:405
	//- Header
	{
		//+ Fields
		const string System = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/MGAbnormalityDensityTypeCS";                                    // CSBuilder.cs:409
		                                                                                                                                          // CSBuilder.cs:421
		/// <summary>
		/// The density types are referring to the amount of  glandular tissue and fibrous connective tissue versus levels of fatty tissue.
		/// 
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_Density = new Coding(System, "Density", "Density");                                                             // CSBuilder.cs:435
		                                                                                                                                          // CSBuilder.cs:421
		/// <summary>
		/// The density is focal asymmetry on two mammographic views.
		/// 
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_DensityFocalAsymmetry = new Coding(System, "DensityFocalAsymmetry", "Density focal asymmetry");                 // CSBuilder.cs:435
		                                                                                                                                          // CSBuilder.cs:421
		/// <summary>
		/// The nodule found on Mammogram is dense.
		/// 
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_DensityNodular = new Coding(System, "DensityNodular", "Density nodular");                                       // CSBuilder.cs:435
		                                                                                                                                          // CSBuilder.cs:421
		/// <summary>
		/// The milk ducts have formed a tubular appearing dense structure.
		/// 
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_DensityTubular = new Coding(System, "DensityTubular", "Density tubular");                                       // CSBuilder.cs:435
		//- Fields
	}
}
