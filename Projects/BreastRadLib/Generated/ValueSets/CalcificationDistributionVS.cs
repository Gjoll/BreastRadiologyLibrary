using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class CalcificationDistributionVS
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
		public static TCoding Code_ClusteredDistribution = new TCoding(CalcificationDistributionCS.Code_ClusteredDistribution);                   // Builder.cs:353
		public static TCoding Code_DiffuseDistribution = new TCoding(CalcificationDistributionCS.Code_DiffuseDistribution);                       // Builder.cs:353
		public static TCoding Code_GroupedDistribution = new TCoding(CalcificationDistributionCS.Code_GroupedDistribution);                       // Builder.cs:353
		public static TCoding Code_LinearDistribution = new TCoding(CalcificationDistributionCS.Code_LinearDistribution);                         // Builder.cs:353
		public static TCoding Code_RegionalDistribution = new TCoding(CalcificationDistributionCS.Code_RegionalDistribution);                     // Builder.cs:353
		public static TCoding Code_ScatteredDistribution = new TCoding(CalcificationDistributionCS.Code_ScatteredDistribution);                   // Builder.cs:353
		public static TCoding Code_SegmentalDistribution = new TCoding(CalcificationDistributionCS.Code_SegmentalDistribution);                   // Builder.cs:353
		//- Fields

		//+ Methods
		public static IEnumerable<TCoding> Codes()                                                                                                // Builder.cs:339
		{                                                                                                                                         // Builder.cs:340
		    yield return Code_ClusteredDistribution;                                                                                              // Builder.cs:356
		    yield return Code_DiffuseDistribution;                                                                                                // Builder.cs:356
		    yield return Code_GroupedDistribution;                                                                                                // Builder.cs:356
		    yield return Code_LinearDistribution;                                                                                                 // Builder.cs:356
		    yield return Code_RegionalDistribution;                                                                                               // Builder.cs:356
		    yield return Code_ScatteredDistribution;                                                                                              // Builder.cs:356
		    yield return Code_SegmentalDistribution;                                                                                              // Builder.cs:356
		}                                                                                                                                         // Builder.cs:362
		//- Methods
	}
}
