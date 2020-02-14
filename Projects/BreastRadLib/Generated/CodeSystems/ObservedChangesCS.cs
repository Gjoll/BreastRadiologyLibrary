using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class ObservedChangesCS
	{
		//+ Fields
		const string System = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservedChangesCS";                                             // CSBuilder.cs:365
		                                                                                                                                          // CSBuilder.cs:377
		/// <summary>
		/// There is a decrease in the number of calcifications found in this mammogram versus
		/// the prior mammogram.
		/// 
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_DecreaseInCalcifications = new Coding(System, "DecreaseInCalcifications", "Decrease in calcifications");        // CSBuilder.cs:391
		                                                                                                                                          // CSBuilder.cs:377
		/// <summary>
		/// There is a decrease in the number of calcifications found in this mammogram versus
		/// the prior mammogram.
		/// 
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_DecreaseInNumber = new Coding(System, "DecreaseInNumber", "Decrease in number");                                // CSBuilder.cs:391
		                                                                                                                                          // CSBuilder.cs:377
		/// <summary>
		/// The lesion/mass has decreased in size since prior MRI, Nuclear Medicine, Ultrasound and or/Mammogram.
		/// 
		/// Valid for the following modalities: MG US MRI NM.
		/// </summary>
		public static Coding Code_DecreaseInSize = new Coding(System, "DecreaseInSize", "Decrease in size");                                      // CSBuilder.cs:391
		                                                                                                                                          // CSBuilder.cs:377
		/// <summary>
		/// Calcifications have increased in number from previous Mammogram.
		/// 
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_IncreaseInCalcifications = new Coding(System, "IncreaseInCalcifications", "Increase in calcifications");        // CSBuilder.cs:391
		                                                                                                                                          // CSBuilder.cs:377
		/// <summary>
		/// There is an increase in the number of calcifications found in this mammogram versus
		/// the prior mammogram.
		/// 
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_IncreaseInNumber = new Coding(System, "IncreaseInNumber", "Increase in number");                                // CSBuilder.cs:391
		                                                                                                                                          // CSBuilder.cs:377
		/// <summary>
		/// The mass has increased in size from the last Nuclear Medicine, ultrasound, MRI or mammogram.
		/// 
		/// Valid for the following modalities: MG US MRI NM.
		/// </summary>
		public static Coding Code_IncreaseInSize = new Coding(System, "IncreaseInSize", "Increase in size");                                      // CSBuilder.cs:391
		                                                                                                                                          // CSBuilder.cs:377
		/// <summary>
		/// Valid for the following modalities: MG US MRI.
		/// </summary>
		public static Coding Code_LessProminent = new Coding(System, "LessProminent", "Less prominent");                                          // CSBuilder.cs:391
		                                                                                                                                          // CSBuilder.cs:377
		/// <summary>
		/// Valid for the following modalities: MG US MRI.
		/// </summary>
		public static Coding Code_MoreProminent = new Coding(System, "MoreProminent", "More prominent");                                          // CSBuilder.cs:391
		                                                                                                                                          // CSBuilder.cs:377
		/// <summary>
		/// There are new masses/lesions present since last Mammogram, MRI, Nuclear Medicine and/or Ultrasound.
		/// 
		/// Valid for the following modalities: MG US MRI NM.
		/// </summary>
		public static Coding Code_New = new Coding(System, "New", "New");                                                                         // CSBuilder.cs:391
		                                                                                                                                          // CSBuilder.cs:377
		/// <summary>
		/// The lesion or mass is no longer seen from previous Mammogram, Ultrasound and/or MRI.
		/// 
		/// Valid for the following modalities: MG US MRI.
		/// </summary>
		public static Coding Code_NoLongerSeen = new Coding(System, "NoLongerSeen", "No longer seen");                                            // CSBuilder.cs:391
		                                                                                                                                          // CSBuilder.cs:377
		/// <summary>
		/// The mass/lesion has not significantly changed since the last Mammogram.
		/// 
		/// Valid for the following modalities: MG US MRI NM.
		/// </summary>
		public static Coding Code_NotSignificantChanged = new Coding(System, "NotSignificantChanged", "Not significant changed");                 // CSBuilder.cs:391
		                                                                                                                                          // CSBuilder.cs:377
		/// <summary>
		/// The mass was partially removed since last mammogram.
		/// 
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_PartiallyRemoved = new Coding(System, "PartiallyRemoved", "Partially removed");                                 // CSBuilder.cs:391
		                                                                                                                                          // CSBuilder.cs:377
		/// <summary>
		/// Valid for the following modalities: MG US MRI NM.
		/// </summary>
		public static Coding Code_RepresentsChange = new Coding(System, "RepresentsChange", "Represents change");                                 // CSBuilder.cs:391
		                                                                                                                                          // CSBuilder.cs:377
		/// <summary>
		/// The condition has remained stable since the last Mammogram, Ultrasound, MRI or Nuclear
		/// Medicine exam.
		/// 
		/// Valid for the following modalities: MG US MRI.
		/// </summary>
		public static Coding Code_Stable = new Coding(System, "Stable", "Stable");                                                                // CSBuilder.cs:391
		//- Fields
	}
}
