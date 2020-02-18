using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class MammoCalcificationTypeVS
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
		public static TCoding Code_Amorphous = new TCoding(MammoCalcificationTypeCS.Code_Amorphous);                                              // CSBuilder.cs:321
		public static TCoding Code_Coarse = new TCoding(MammoCalcificationTypeCS.Code_Coarse);                                                    // CSBuilder.cs:321
		public static TCoding Code_Dystrophic = new TCoding(MammoCalcificationTypeCS.Code_Dystrophic);                                            // CSBuilder.cs:321
		public static TCoding Code_Eggshell = new TCoding(MammoCalcificationTypeCS.Code_Eggshell);                                                // CSBuilder.cs:321
		public static TCoding Code_Fine = new TCoding(MammoCalcificationTypeCS.Code_Fine);                                                        // CSBuilder.cs:321
		public static TCoding Code_GenericCalcification = new TCoding(MammoCalcificationTypeCS.Code_GenericCalcification);                        // CSBuilder.cs:321
		public static TCoding Code_CourseHeterogeneous = new TCoding(MammoCalcificationTypeCS.Code_CourseHeterogeneous);                          // CSBuilder.cs:321
		public static TCoding Code_Indistinct = new TCoding(MammoCalcificationTypeCS.Code_Indistinct);                                            // CSBuilder.cs:321
		public static TCoding Code_LargeRodlike = new TCoding(MammoCalcificationTypeCS.Code_LargeRodlike);                                        // CSBuilder.cs:321
		public static TCoding Code_Layering = new TCoding(MammoCalcificationTypeCS.Code_Layering);                                                // CSBuilder.cs:321
		public static TCoding Code_FineLinear = new TCoding(MammoCalcificationTypeCS.Code_FineLinear);                                            // CSBuilder.cs:321
		public static TCoding Code_LucentCentered = new TCoding(MammoCalcificationTypeCS.Code_LucentCentered);                                    // CSBuilder.cs:321
		public static TCoding Code_MilkOfCalcium = new TCoding(MammoCalcificationTypeCS.Code_MilkOfCalcium);                                      // CSBuilder.cs:321
		public static TCoding Code_FinePleomorphic = new TCoding(MammoCalcificationTypeCS.Code_FinePleomorphic);                                  // CSBuilder.cs:321
		public static TCoding Code_Punctate = new TCoding(MammoCalcificationTypeCS.Code_Punctate);                                                // CSBuilder.cs:321
		public static TCoding Code_Rim = new TCoding(MammoCalcificationTypeCS.Code_Rim);                                                          // CSBuilder.cs:321
		public static TCoding Code_Round = new TCoding(MammoCalcificationTypeCS.Code_Round);                                                      // CSBuilder.cs:321
		public static TCoding Code_Skin = new TCoding(MammoCalcificationTypeCS.Code_Skin);                                                        // CSBuilder.cs:321
		public static TCoding Code_Spherical = new TCoding(MammoCalcificationTypeCS.Code_Spherical);                                              // CSBuilder.cs:321
		public static TCoding Code_Suture = new TCoding(MammoCalcificationTypeCS.Code_Suture);                                                    // CSBuilder.cs:321
		public static TCoding Code_Vascular = new TCoding(MammoCalcificationTypeCS.Code_Vascular);                                                // CSBuilder.cs:321
		//- Fields

		//+ Methods
		public static IEnumerable<TCoding> Codes()                                                                                                // CSBuilder.cs:306
		{                                                                                                                                         // CSBuilder.cs:307
		    yield return Code_Amorphous;                                                                                                          // CSBuilder.cs:324
		    yield return Code_Coarse;                                                                                                             // CSBuilder.cs:324
		    yield return Code_Dystrophic;                                                                                                         // CSBuilder.cs:324
		    yield return Code_Eggshell;                                                                                                           // CSBuilder.cs:324
		    yield return Code_Fine;                                                                                                               // CSBuilder.cs:324
		    yield return Code_GenericCalcification;                                                                                               // CSBuilder.cs:324
		    yield return Code_CourseHeterogeneous;                                                                                                // CSBuilder.cs:324
		    yield return Code_Indistinct;                                                                                                         // CSBuilder.cs:324
		    yield return Code_LargeRodlike;                                                                                                       // CSBuilder.cs:324
		    yield return Code_Layering;                                                                                                           // CSBuilder.cs:324
		    yield return Code_FineLinear;                                                                                                         // CSBuilder.cs:324
		    yield return Code_LucentCentered;                                                                                                     // CSBuilder.cs:324
		    yield return Code_MilkOfCalcium;                                                                                                      // CSBuilder.cs:324
		    yield return Code_FinePleomorphic;                                                                                                    // CSBuilder.cs:324
		    yield return Code_Punctate;                                                                                                           // CSBuilder.cs:324
		    yield return Code_Rim;                                                                                                                // CSBuilder.cs:324
		    yield return Code_Round;                                                                                                              // CSBuilder.cs:324
		    yield return Code_Skin;                                                                                                               // CSBuilder.cs:324
		    yield return Code_Spherical;                                                                                                          // CSBuilder.cs:324
		    yield return Code_Suture;                                                                                                             // CSBuilder.cs:324
		    yield return Code_Vascular;                                                                                                           // CSBuilder.cs:324
		}                                                                                                                                         // CSBuilder.cs:330
		//- Methods
	}
}
