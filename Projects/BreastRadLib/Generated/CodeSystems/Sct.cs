using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class Sct
	{
		//+ Fields
		const string System = "http://snomed.info/sct";                                                                                           // Builder.cs:377
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// </summary>
		public static Coding Code_51440002 = new Coding(System, "51440002", "Right and left");                                                    // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// </summary>
		public static Coding Code_399488007 = new Coding(System, "399488007", "Midline");                                                         // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// </summary>
		public static Coding Code_85421007 = new Coding(System, "85421007", "Structure of right half of body");                                   // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// </summary>
		public static Coding Code_31156008 = new Coding(System, "31156008", "Structure of left half of body");                                    // Builder.cs:408
		//- Fields
	}
}
