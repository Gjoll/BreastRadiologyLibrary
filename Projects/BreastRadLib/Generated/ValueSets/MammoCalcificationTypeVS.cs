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
		public static TCoding Code_Amorphous = new TCoding(MammoCalcificationTypeCS.Code_Amorphous);                                              // Builder.cs:353
		public static TCoding Code_Coarse = new TCoding(MammoCalcificationTypeCS.Code_Coarse);                                                    // Builder.cs:353
		public static TCoding Code_Dystrophic = new TCoding(MammoCalcificationTypeCS.Code_Dystrophic);                                            // Builder.cs:353
		public static TCoding Code_Eggshell = new TCoding(MammoCalcificationTypeCS.Code_Eggshell);                                                // Builder.cs:353
		public static TCoding Code_Fine = new TCoding(MammoCalcificationTypeCS.Code_Fine);                                                        // Builder.cs:353
		public static TCoding Code_GenericCalcification = new TCoding(MammoCalcificationTypeCS.Code_GenericCalcification);                        // Builder.cs:353
		public static TCoding Code_CourseHeterogeneous = new TCoding(MammoCalcificationTypeCS.Code_CourseHeterogeneous);                          // Builder.cs:353
		public static TCoding Code_Indistinct = new TCoding(MammoCalcificationTypeCS.Code_Indistinct);                                            // Builder.cs:353
		public static TCoding Code_LargeRodlike = new TCoding(MammoCalcificationTypeCS.Code_LargeRodlike);                                        // Builder.cs:353
		public static TCoding Code_Layering = new TCoding(MammoCalcificationTypeCS.Code_Layering);                                                // Builder.cs:353
		public static TCoding Code_FineLinear = new TCoding(MammoCalcificationTypeCS.Code_FineLinear);                                            // Builder.cs:353
		public static TCoding Code_LucentCentered = new TCoding(MammoCalcificationTypeCS.Code_LucentCentered);                                    // Builder.cs:353
		public static TCoding Code_MilkOfCalcium = new TCoding(MammoCalcificationTypeCS.Code_MilkOfCalcium);                                      // Builder.cs:353
		public static TCoding Code_FinePleomorphic = new TCoding(MammoCalcificationTypeCS.Code_FinePleomorphic);                                  // Builder.cs:353
		public static TCoding Code_Punctate = new TCoding(MammoCalcificationTypeCS.Code_Punctate);                                                // Builder.cs:353
		public static TCoding Code_Rim = new TCoding(MammoCalcificationTypeCS.Code_Rim);                                                          // Builder.cs:353
		public static TCoding Code_Round = new TCoding(MammoCalcificationTypeCS.Code_Round);                                                      // Builder.cs:353
		public static TCoding Code_Skin = new TCoding(MammoCalcificationTypeCS.Code_Skin);                                                        // Builder.cs:353
		public static TCoding Code_Spherical = new TCoding(MammoCalcificationTypeCS.Code_Spherical);                                              // Builder.cs:353
		public static TCoding Code_Suture = new TCoding(MammoCalcificationTypeCS.Code_Suture);                                                    // Builder.cs:353
		public static TCoding Code_Vascular = new TCoding(MammoCalcificationTypeCS.Code_Vascular);                                                // Builder.cs:353
		//- Fields

		//+ Methods
		public static IEnumerable<TCoding> Codes()                                                                                                // Builder.cs:339
		{                                                                                                                                         // Builder.cs:340
		    yield return Code_Amorphous;                                                                                                          // Builder.cs:356
		    yield return Code_Coarse;                                                                                                             // Builder.cs:356
		    yield return Code_Dystrophic;                                                                                                         // Builder.cs:356
		    yield return Code_Eggshell;                                                                                                           // Builder.cs:356
		    yield return Code_Fine;                                                                                                               // Builder.cs:356
		    yield return Code_GenericCalcification;                                                                                               // Builder.cs:356
		    yield return Code_CourseHeterogeneous;                                                                                                // Builder.cs:356
		    yield return Code_Indistinct;                                                                                                         // Builder.cs:356
		    yield return Code_LargeRodlike;                                                                                                       // Builder.cs:356
		    yield return Code_Layering;                                                                                                           // Builder.cs:356
		    yield return Code_FineLinear;                                                                                                         // Builder.cs:356
		    yield return Code_LucentCentered;                                                                                                     // Builder.cs:356
		    yield return Code_MilkOfCalcium;                                                                                                      // Builder.cs:356
		    yield return Code_FinePleomorphic;                                                                                                    // Builder.cs:356
		    yield return Code_Punctate;                                                                                                           // Builder.cs:356
		    yield return Code_Rim;                                                                                                                // Builder.cs:356
		    yield return Code_Round;                                                                                                              // Builder.cs:356
		    yield return Code_Skin;                                                                                                               // Builder.cs:356
		    yield return Code_Spherical;                                                                                                          // Builder.cs:356
		    yield return Code_Suture;                                                                                                             // Builder.cs:356
		    yield return Code_Vascular;                                                                                                           // Builder.cs:356
		}                                                                                                                                         // Builder.cs:362
		//- Methods
	}
}
