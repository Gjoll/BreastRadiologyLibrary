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
		public static TCoding Code_CentralLucent = new TCoding(MGDensityCS.Code_CentralLucent);                                                   // Builder.cs:353
		public static TCoding Code_EqualDensity = new TCoding(MGDensityCS.Code_EqualDensity);                                                     // Builder.cs:353
		public static TCoding Code_FatContaining = new TCoding(MGDensityCS.Code_FatContaining);                                                   // Builder.cs:353
		public static TCoding Code_HighDensity = new TCoding(MGDensityCS.Code_HighDensity);                                                       // Builder.cs:353
		public static TCoding Code_LowDensity = new TCoding(MGDensityCS.Code_LowDensity);                                                         // Builder.cs:353
		//- Fields

		//+ Methods
		public static IEnumerable<TCoding> Codes()                                                                                                // Builder.cs:339
		{                                                                                                                                         // Builder.cs:340
		    yield return Code_CentralLucent;                                                                                                      // Builder.cs:356
		    yield return Code_EqualDensity;                                                                                                       // Builder.cs:356
		    yield return Code_FatContaining;                                                                                                      // Builder.cs:356
		    yield return Code_HighDensity;                                                                                                        // Builder.cs:356
		    yield return Code_LowDensity;                                                                                                         // Builder.cs:356
		}                                                                                                                                         // Builder.cs:362
		//- Methods
	}
}
