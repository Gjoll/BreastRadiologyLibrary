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
		const string System = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityDuctTypeCS";                                         // Builder.cs:371
		                                                                                                                                          // Builder.cs:383
		/// <summary>
		/// Duct is considered normal.
		/// It is surrounded by normal cells and collagen in the breast with no abnormalities.
		/// A system of ducts in your breast carries milk to the nipples.
		/// 
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_DuctNormal = new Coding(System, "DuctNormal", "Duct normal");                                                   // Builder.cs:402
		                                                                                                                                          // Builder.cs:383
		/// <summary>
		/// When it is malignant,&#160;solitary dilated duct&#160;appears to indicate the presence of DCIS.
		/// In almost all&#160;solitary dilated duct&#160;cases, the&#160;dilated duct&#160;appears to be filled with some debris, with or without accompanying fluid, as seen at ultrasound.
		/// 
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_DuctDilatedATLASSolitaryDilatedDuct = new Coding(System, "DuctDilatedATLASSolitaryDilatedDuct", "Duct dilated ATLAS solitary dilated duct");// Builder.cs:402
		                                                                                                                                          // Builder.cs:383
		/// <summary>
		/// A noncancerous condition that results in clogged ducts around the nipple.
		/// While it sometimes causes pain, irritation and discharge, it&#39;s generally not a cause
		/// for concern.
		/// If left untreated, it can eventually obliterate the breast duct.
		/// www.healthline.com &gt; health &gt; duct-ectasia-of-the-breast
		/// 
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_DuctEctasia = new Coding(System, "DuctEctasia", "Duct ectasia");                                                // Builder.cs:402
		//- Fields
	}
}
