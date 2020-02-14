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
		public static TCoding Code_DifferentialDiagnosis = new TCoding(ConsistentWithQualifierCS.Code_DifferentialDiagnosis);                     // CSBuilder.cs:322
		public static TCoding Code_LikelyRepresents = new TCoding(ConsistentWithQualifierCS.Code_LikelyRepresents);                               // CSBuilder.cs:322
		public static TCoding Code_MostLikely = new TCoding(ConsistentWithQualifierCS.Code_MostLikely);                                           // CSBuilder.cs:322
		public static TCoding Code_Resembles = new TCoding(ConsistentWithQualifierCS.Code_Resembles);                                             // CSBuilder.cs:322
		//- Fields

		//+ Methods
		public static IEnumerable<TCoding> Codes()                                                                                                // CSBuilder.cs:307
		{                                                                                                                                         // CSBuilder.cs:308
		    yield return Code_DifferentialDiagnosis;                                                                                              // CSBuilder.cs:325
		    yield return Code_LikelyRepresents;                                                                                                   // CSBuilder.cs:325
		    yield return Code_MostLikely;                                                                                                         // CSBuilder.cs:325
		    yield return Code_Resembles;                                                                                                          // CSBuilder.cs:325
		}                                                                                                                                         // CSBuilder.cs:331
		//- Methods
	}
}
