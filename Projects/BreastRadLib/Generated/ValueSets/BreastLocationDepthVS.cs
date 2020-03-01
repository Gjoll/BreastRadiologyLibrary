using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class BreastLocationDepthVS
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
		public static TCoding Code_AnteriorDepth = new TCoding(BreastLocationDepthCS.Code_AnteriorDepth);                                         // Builder.cs:347
		public static TCoding Code_MiddleDepth = new TCoding(BreastLocationDepthCS.Code_MiddleDepth);                                             // Builder.cs:347
		public static TCoding Code_PosteriorDepth = new TCoding(BreastLocationDepthCS.Code_PosteriorDepth);                                       // Builder.cs:347
		//- Fields

		//+ Methods
		public static IEnumerable<TCoding> Codes()                                                                                                // Builder.cs:333
		{                                                                                                                                         // Builder.cs:334
		    yield return Code_AnteriorDepth;                                                                                                      // Builder.cs:350
		    yield return Code_MiddleDepth;                                                                                                        // Builder.cs:350
		    yield return Code_PosteriorDepth;                                                                                                     // Builder.cs:350
		}                                                                                                                                         // Builder.cs:356
		//- Methods
	}
}
