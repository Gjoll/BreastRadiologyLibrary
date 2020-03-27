using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class LateralityVS
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
		public static TCoding Code_51440002 = new TCoding(Sct.Code_51440002);                                                                     // Builder.cs:353
		public static TCoding Code_399488007 = new TCoding(Sct.Code_399488007);                                                                   // Builder.cs:353
		public static TCoding Code_85421007 = new TCoding(Sct.Code_85421007);                                                                     // Builder.cs:353
		public static TCoding Code_31156008 = new TCoding(Sct.Code_31156008);                                                                     // Builder.cs:353
		//- Fields

		//+ Methods
		public static IEnumerable<TCoding> Codes()                                                                                                // Builder.cs:339
		{                                                                                                                                         // Builder.cs:340
		    yield return Code_51440002;                                                                                                           // Builder.cs:356
		    yield return Code_399488007;                                                                                                          // Builder.cs:356
		    yield return Code_85421007;                                                                                                           // Builder.cs:356
		    yield return Code_31156008;                                                                                                           // Builder.cs:356
		}                                                                                                                                         // Builder.cs:362
		//- Methods
	}
}
