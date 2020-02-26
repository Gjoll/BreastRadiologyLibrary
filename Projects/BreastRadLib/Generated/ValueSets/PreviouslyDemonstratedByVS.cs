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
		public static TCoding Code_Aspiration = new TCoding(PreviouslyDemonstratedByCodeSystemCS.Code_Aspiration);                                // Builder.cs:344
		public static TCoding Code_Biopsy = new TCoding(PreviouslyDemonstratedByCodeSystemCS.Code_Biopsy);                                        // Builder.cs:344
		public static TCoding Code_MRI = new TCoding(PreviouslyDemonstratedByCodeSystemCS.Code_MRI);                                              // Builder.cs:344
		public static TCoding Code_US = new TCoding(PreviouslyDemonstratedByCodeSystemCS.Code_US);                                                // Builder.cs:344
		//- Fields

		//+ Methods
		public static IEnumerable<TCoding> Codes()                                                                                                // Builder.cs:330
		{                                                                                                                                         // Builder.cs:331
		    yield return Code_Aspiration;                                                                                                         // Builder.cs:347
		    yield return Code_Biopsy;                                                                                                             // Builder.cs:347
		    yield return Code_MRI;                                                                                                                // Builder.cs:347
		    yield return Code_US;                                                                                                                 // Builder.cs:347
		}                                                                                                                                         // Builder.cs:353
		//- Methods
	}
}
