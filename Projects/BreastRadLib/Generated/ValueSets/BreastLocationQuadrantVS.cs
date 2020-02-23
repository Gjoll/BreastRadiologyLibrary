using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class BreastLocationQuadrantVS
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
		public static TCoding Code_InferiorMedialQuadrent = new TCoding(BreastLocationQuadrantCS.Code_InferiorMedialQuadrent);                    // Builder.cs:349
		public static TCoding Code_InferiorLateralQuadrent = new TCoding(BreastLocationQuadrantCS.Code_InferiorLateralQuadrent);                  // Builder.cs:349
		public static TCoding Code_SuperiorMedialQuadrent = new TCoding(BreastLocationQuadrantCS.Code_SuperiorMedialQuadrent);                    // Builder.cs:349
		public static TCoding Code_SuperiorLateralQuadrent = new TCoding(BreastLocationQuadrantCS.Code_SuperiorLateralQuadrent);                  // Builder.cs:349
		//- Fields

		//+ Methods
		public static IEnumerable<TCoding> Codes()                                                                                                // Builder.cs:335
		{                                                                                                                                         // Builder.cs:336
		    yield return Code_InferiorMedialQuadrent;                                                                                             // Builder.cs:352
		    yield return Code_InferiorLateralQuadrent;                                                                                            // Builder.cs:352
		    yield return Code_SuperiorMedialQuadrent;                                                                                             // Builder.cs:352
		    yield return Code_SuperiorLateralQuadrent;                                                                                            // Builder.cs:352
		}                                                                                                                                         // Builder.cs:358
		//- Methods
	}
}
