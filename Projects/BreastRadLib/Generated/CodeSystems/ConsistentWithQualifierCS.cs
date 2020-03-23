using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class ConsistentWithQualifierCS
	{
		//+ Fields
		const string System = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithQualifierCS";                                     // Builder.cs:377
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// More than one possibility for your diagnosis.
		/// The process of weighing the probability of one disease versus that of other diseases
		/// possibly accounting for a patient&#39;s illness.
		/// 
		/// 
		/// Valid for the following modalities: MG US MRI NM.
		/// </summary>
		public static Coding Code_DifferentialDiagnosis = new Coding(System, "DifferentialDiagnosis", "Differential diagnosis");                  // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// Likely represents
		/// 
		/// 
		/// Valid for the following modalities: MG US MRI NM.
		/// </summary>
		public static Coding Code_LikelyRepresents = new Coding(System, "LikelyRepresents", "Likely represents");                                 // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// Most likely
		/// 
		/// 
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_MostLikely = new Coding(System, "MostLikely", "Most likely");                                                   // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// Resembles
		/// 
		/// 
		/// Valid for the following modalities: MG US MRI NM.
		/// </summary>
		public static Coding Code_Resembles = new Coding(System, "Resembles", "Resembles");                                                       // Builder.cs:408
		//- Fields
	}
}
