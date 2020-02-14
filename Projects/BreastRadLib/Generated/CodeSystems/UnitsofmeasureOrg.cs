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
		const string System = "http://unitsofmeasure.org";                                                                                        // CSBuilder.cs:365
		                                                                                                                                          // CSBuilder.cs:377
		/// <summary>
		/// </summary>
		public static Coding Code_M = new Coding(System, "m", "meter");                                                                           // CSBuilder.cs:391
		                                                                                                                                          // CSBuilder.cs:377
		/// <summary>
		/// </summary>
		public static Coding Code_Cm = new Coding(System, "cm", "centimeter");                                                                    // CSBuilder.cs:391
		                                                                                                                                          // CSBuilder.cs:377
		/// <summary>
		/// </summary>
		public static Coding Code_Mm = new Coding(System, "mm", "millimeter");                                                                    // CSBuilder.cs:391
		//- Fields
	}
}
