using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class UnitsofmeasureOrg
	{
		//+ Fields
		const string System = "http://unitsofmeasure.org";                                                                                        // Builder.cs:377
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// </summary>
		public static Coding Code_M = new Coding(System, "m", "meter");                                                                           // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// </summary>
		public static Coding Code_Cm = new Coding(System, "cm", "centimeter");                                                                    // Builder.cs:408
		                                                                                                                                          // Builder.cs:389
		/// <summary>
		/// </summary>
		public static Coding Code_Mm = new Coding(System, "mm", "millimeter");                                                                    // Builder.cs:408
		//- Fields
	}
}
