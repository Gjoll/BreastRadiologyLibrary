using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class PreviouslyDemonstratedByVS
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
		public static TCoding Code_Aspiration = new TCoding(PreviouslyDemonstratedByCodeSystemCS.Code_Aspiration);                                // CSBuilder.cs:320
		public static TCoding Code_Biopsy = new TCoding(PreviouslyDemonstratedByCodeSystemCS.Code_Biopsy);                                        // CSBuilder.cs:320
		public static TCoding Code_MRI = new TCoding(PreviouslyDemonstratedByCodeSystemCS.Code_MRI);                                              // CSBuilder.cs:320
		public static TCoding Code_US = new TCoding(PreviouslyDemonstratedByCodeSystemCS.Code_US);                                                // CSBuilder.cs:320
		//- Fields

		//+ Methods
		public static IEnumerable<TCoding> Codes()                                                                                                // CSBuilder.cs:305
		{                                                                                                                                         // CSBuilder.cs:306
		    yield return Code_Aspiration;                                                                                                         // CSBuilder.cs:323
		    yield return Code_Biopsy;                                                                                                             // CSBuilder.cs:323
		    yield return Code_MRI;                                                                                                                // CSBuilder.cs:323
		    yield return Code_US;                                                                                                                 // CSBuilder.cs:323
		}                                                                                                                                         // CSBuilder.cs:329
		//- Methods
	}
}
