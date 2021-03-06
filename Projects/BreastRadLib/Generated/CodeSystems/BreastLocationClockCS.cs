using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class BreastLocationClockCS
	{
		//+ Fields
		const string System = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/BreastLocationClockCS";                                         // Builder.cs:377
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// Just like the hands of a clock, this is how to describe
		/// the position of the tumor
		/// in the breast.
		/// 1 o&#39;clock position is at the 1 o&#39;clock position and
		/// in the Upper Inner Quandrant
		/// (UIQ) of the breast.
		/// 
		/// 
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_1OClock = new Coding(System, "1O'clock", "1 o'clock");                                                          // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// Just like the hands of a clock, this is how to describe
		/// the position of the tumor
		/// in the breast.
		/// 2 o&#39;clock position is at the 2 o&#39;clock position and
		/// in the Upper Inner Quandrant
		/// (UIQ) of the breast.
		/// 
		/// 
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_2OClock = new Coding(System, "2O'clock", "2 o'clock");                                                          // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// Just like the hands of a clock, this is how to describe
		/// the position of the tumor
		/// in the breast.
		/// 3 o&#39;clock position is at the 3 o&#39;clock position.
		/// 
		/// 
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_3OClock = new Coding(System, "3O'clock", "3 o'clock");                                                          // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// Just like the hands of a clock, this is how to describe
		/// the position of the tumor
		/// in the breast.
		/// 4 o&#39;clock position is at the 4 o&#39;clock position and
		/// in the Lower Inner Quandrant
		/// (LIQ) of the breast.
		/// 
		/// 
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_4OClock = new Coding(System, "4O'clock", "4 o'clock");                                                          // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// Just like the hands of a clock, this is how to describe
		/// the position of the tumor
		/// in the breast.
		/// 5 o&#39;clock position is at the 5 o&#39;clock position and
		/// in the Lower Inner Quandrant
		/// (LIQ) of the breast.
		/// 
		/// 
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_5OClock = new Coding(System, "5O'clock", "5 o'clock");                                                          // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// Just like the hands of a clock, this is how to describe
		/// the position of the tumor
		/// in the breast.
		/// 6 o&#39;clock position is at the 6 o&#39;clock position.
		/// 
		/// 
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_6OClock = new Coding(System, "6O'clock", "6 o'clock");                                                          // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// Just like the hands of a clock, this is how to describe
		/// the position of the tumor
		/// in the breast.
		/// 7 o&#39;clock position is at the 7 o&#39;clock position and
		/// in the Lower Outer Quandrant
		/// (LOQ) of the breast.
		/// 
		/// 
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_7OClock = new Coding(System, "7O'clock", "7 o'clock");                                                          // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// Just like the hands of a clock, this is how to describe
		/// the position of the tumor
		/// in the breast.
		/// 8 o&#39;clock position is at the 8 o&#39;clock position and
		/// in the Lower Outer Quandrant
		/// (LOQ) of the breast.
		/// 
		/// 
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_8OClock = new Coding(System, "8O'clock", "8 o'clock");                                                          // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// Just like the hands of a clock, this is how to describe
		/// the position of the tumor
		/// in the breast.
		/// 9 o&#39;clock position is at the 9 o&#39;clock position.
		/// 
		/// 
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_9OClock = new Coding(System, "9O'clock", "9 o'clock");                                                          // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// Just like the hands of a clock, this is how to describe
		/// the position of the tumor
		/// in the breast.
		/// 10 o&#39;clock position is at the 10 o&#39;clock position
		/// and in the Upper Outer Quandrant
		/// (UOQ) of the breast.
		/// 
		/// 
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_10OClock = new Coding(System, "10O'clock", "10 o'clock");                                                       // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// Just like the hands of a clock, this is how to describe
		/// the position of the tumor
		/// in the breast.
		/// 11 o&#39;clock position is at the 11 o&#39;clock position
		/// and in the Upper Outer Quandrant
		/// (UOQ) of the breast.
		/// 
		/// 
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_11OClock = new Coding(System, "11O'clock", "11 o'clock");                                                       // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// Just like the hands of a clock, this is how to describe
		/// the position of the tumor
		/// in the breast.
		/// 12 o&#39;clock position is at the 12 o&#39;clock position.
		/// 
		/// 
		/// Valid for the following modalities: MG US.
		/// </summary>
		public static Coding Code_12OClock = new Coding(System, "12O'clock", "12 o'clock");                                                       // Builder.cs:408
		//- Fields
	}
}
