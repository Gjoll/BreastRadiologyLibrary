using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class MGBreastDensityVS
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
		public static TCoding Code_AlmostEntirelyFat = new TCoding(MGBreastDensityCS.Code_AlmostEntirelyFat);                                     // CSBuilder.cs:321
		public static TCoding Code_ScatteredAreasOfFibroglandularDensity = new TCoding(MGBreastDensityCS.Code_ScatteredAreasOfFibroglandularDensity);// CSBuilder.cs:321
		public static TCoding Code_HeterogeneouslyDense = new TCoding(MGBreastDensityCS.Code_HeterogeneouslyDense);                               // CSBuilder.cs:321
		public static TCoding Code_ExtremelyDense = new TCoding(MGBreastDensityCS.Code_ExtremelyDense);                                           // CSBuilder.cs:321
		//- Fields

		//+ Methods
		public static IEnumerable<TCoding> Codes()                                                                                                // CSBuilder.cs:306
		{                                                                                                                                         // CSBuilder.cs:307
		    yield return Code_AlmostEntirelyFat;                                                                                                  // CSBuilder.cs:324
		    yield return Code_ScatteredAreasOfFibroglandularDensity;                                                                              // CSBuilder.cs:324
		    yield return Code_HeterogeneouslyDense;                                                                                               // CSBuilder.cs:324
		    yield return Code_ExtremelyDense;                                                                                                     // CSBuilder.cs:324
		}                                                                                                                                         // CSBuilder.cs:330
		//- Methods
	}
}
