using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class ConsistentWithQualifierVS
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
		public static TCoding Code_DifferentialDiagnosis = new TCoding(ConsistentWithQualifierCS.Code_DifferentialDiagnosis);                     // CSBuilder.cs:323
		public static TCoding Code_LikelyRepresents = new TCoding(ConsistentWithQualifierCS.Code_LikelyRepresents);                               // CSBuilder.cs:323
		public static TCoding Code_MostLikely = new TCoding(ConsistentWithQualifierCS.Code_MostLikely);                                           // CSBuilder.cs:323
		public static TCoding Code_Resembles = new TCoding(ConsistentWithQualifierCS.Code_Resembles);                                             // CSBuilder.cs:323
		//- Fields

		//+ Methods
		public static IEnumerable<TCoding> Codes()                                                                                                // CSBuilder.cs:309
		{                                                                                                                                         // CSBuilder.cs:310
		    yield return Code_DifferentialDiagnosis;                                                                                              // CSBuilder.cs:326
		    yield return Code_LikelyRepresents;                                                                                                   // CSBuilder.cs:326
		    yield return Code_MostLikely;                                                                                                         // CSBuilder.cs:326
		    yield return Code_Resembles;                                                                                                          // CSBuilder.cs:326
		}                                                                                                                                         // CSBuilder.cs:332
		//- Methods
	}
}
