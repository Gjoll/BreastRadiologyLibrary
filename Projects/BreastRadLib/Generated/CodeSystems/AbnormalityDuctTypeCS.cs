using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class AbnormalityDuctTypeCS
	{
		//+ Fields
		const string System = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityDuctTypeCS";                                         // Builder.cs:373
		                                                                                                                                          // Builder.cs:385
		/// <summary>
		/// Duct is considered normal.
		/// It is surrounded by normal cells and collagen in the breast with no abnormalities.
		/// A system of ducts in your breast carries milk to the nipples.
		/// 
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_DuctNormal = new Coding(System, "DuctNormal", "Duct normal");                                                   // Builder.cs:399
		                                                                                                                                          // Builder.cs:385
		/// <summary>
		/// When it is malignant, solitary dilated duct appears to indicate the presence of DCIS.
		/// In almost all solitary dilated duct cases, the dilated duct appears to be filled with some debris, with or without accompanying fluid, as seen at ultrasound.
		/// 
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_DuctDilatedATLASSolitaryDilatedDuct = new Coding(System, "DuctDilatedATLASSolitaryDilatedDuct", "Duct dilated ATLAS solitary dilated duct");// Builder.cs:399
		                                                                                                                                          // Builder.cs:385
		/// <summary>
		/// A noncancerous condition that results in clogged ducts around the nipple.
		/// While it sometimes causes pain, irritation and discharge, it's generally not a cause
		/// for concern.
		/// If left untreated, it can eventually obliterate the breast duct.
		/// www.healthline.com > health > duct-ectasia-of-the-breast
		/// 
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_DuctEctasia = new Coding(System, "DuctEctasia", "Duct ectasia");                                                // Builder.cs:399
		//- Fields
	}
}
