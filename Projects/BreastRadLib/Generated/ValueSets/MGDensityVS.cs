using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class MGDensityVS
	{
		/// <summary>
		/// This class creates a type for codings of this class, that implicitly converts to Coding
		/// Allows type checking for these codes.
		/// </summary>
		public class TCoding
		{
		    public Coding Value {get;}
			public static implicit operator Coding(TCoding tCode) => tCode.Value;
			public static implicit operator CodeableConcept(TCoding tCode) => new CodeableConcept(tCode.Value.System, tCode.Value.Code, tCode.Value.Display);

			public TCoding(Coding value)
		    {
		        this.Value= value;
		    }
		}

		//+ Fields
		public static TCoding Code_CentralLucent = new TCoding(MGDensityCS.Code_CentralLucent);                                                   // CSBuilder.cs:323
		public static TCoding Code_EqualDensity = new TCoding(MGDensityCS.Code_EqualDensity);                                                     // CSBuilder.cs:323
		public static TCoding Code_FatContaining = new TCoding(MGDensityCS.Code_FatContaining);                                                   // CSBuilder.cs:323
		public static TCoding Code_HighDensity = new TCoding(MGDensityCS.Code_HighDensity);                                                       // CSBuilder.cs:323
		public static TCoding Code_LowDensity = new TCoding(MGDensityCS.Code_LowDensity);                                                         // CSBuilder.cs:323
		//- Fields

		//+ Methods
		public static IEnumerable<TCoding> Codes()                                                                                                // CSBuilder.cs:309
		{                                                                                                                                         // CSBuilder.cs:310
		    yield return Code_CentralLucent;                                                                                                      // CSBuilder.cs:326
		    yield return Code_EqualDensity;                                                                                                       // CSBuilder.cs:326
		    yield return Code_FatContaining;                                                                                                      // CSBuilder.cs:326
		    yield return Code_HighDensity;                                                                                                        // CSBuilder.cs:326
		    yield return Code_LowDensity;                                                                                                         // CSBuilder.cs:326
		}                                                                                                                                         // CSBuilder.cs:332
		//- Methods
	}
}
