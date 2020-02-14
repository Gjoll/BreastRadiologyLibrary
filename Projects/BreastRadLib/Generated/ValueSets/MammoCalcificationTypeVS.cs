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
		//+ Fields
		/// <summary>
		/// This class creates a type for codings of this class, that implicitly converts to Coding
		/// Allows type checking for these codes.
		/// </summary>
		public class TCoding                                                                                                                      // CSBuilder.cs:343
		{                                                                                                                                         // CSBuilder.cs:344
		    Coding value;                                                                                                                         // CSBuilder.cs:345
		    public static implicit operator Coding(TCoding tCode)                                                                                 // CSBuilder.cs:346
		    {                                                                                                                                     // CSBuilder.cs:347
		        return tCode.value;                                                                                                               // CSBuilder.cs:348
		    }                                                                                                                                     // CSBuilder.cs:349
		                                                                                                                                          // CSBuilder.cs:350
		    public TCoding(Coding value)                                                                                                          // CSBuilder.cs:351
		    {                                                                                                                                     // CSBuilder.cs:352
		        this.value= value;                                                                                                                // CSBuilder.cs:353
		    }                                                                                                                                     // CSBuilder.cs:354
		}                                                                                                                                         // CSBuilder.cs:355
		public TCoding Code_Amorphous = new TCoding(MammoCalcificationTypeCS.Code_Amorphous);                                                     // CSBuilder.cs:373
		public TCoding Code_Coarse = new TCoding(MammoCalcificationTypeCS.Code_Coarse);                                                           // CSBuilder.cs:373
		public TCoding Code_Dystrophic = new TCoding(MammoCalcificationTypeCS.Code_Dystrophic);                                                   // CSBuilder.cs:373
		public TCoding Code_Eggshell = new TCoding(MammoCalcificationTypeCS.Code_Eggshell);                                                       // CSBuilder.cs:373
		public TCoding Code_Fine = new TCoding(MammoCalcificationTypeCS.Code_Fine);                                                               // CSBuilder.cs:373
		public TCoding Code_GenericCalcification = new TCoding(MammoCalcificationTypeCS.Code_GenericCalcification);                               // CSBuilder.cs:373
		public TCoding Code_CourseHeterogeneous = new TCoding(MammoCalcificationTypeCS.Code_CourseHeterogeneous);                                 // CSBuilder.cs:373
		public TCoding Code_Indistinct = new TCoding(MammoCalcificationTypeCS.Code_Indistinct);                                                   // CSBuilder.cs:373
		public TCoding Code_LargeRodlike = new TCoding(MammoCalcificationTypeCS.Code_LargeRodlike);                                               // CSBuilder.cs:373
		public TCoding Code_Layering = new TCoding(MammoCalcificationTypeCS.Code_Layering);                                                       // CSBuilder.cs:373
		public TCoding Code_FineLinear = new TCoding(MammoCalcificationTypeCS.Code_FineLinear);                                                   // CSBuilder.cs:373
		public TCoding Code_LucentCentered = new TCoding(MammoCalcificationTypeCS.Code_LucentCentered);                                           // CSBuilder.cs:373
		public TCoding Code_MilkOfCalcium = new TCoding(MammoCalcificationTypeCS.Code_MilkOfCalcium);                                             // CSBuilder.cs:373
		public TCoding Code_FinePleomorphic = new TCoding(MammoCalcificationTypeCS.Code_FinePleomorphic);                                         // CSBuilder.cs:373
		public TCoding Code_Punctate = new TCoding(MammoCalcificationTypeCS.Code_Punctate);                                                       // CSBuilder.cs:373
		public TCoding Code_Rim = new TCoding(MammoCalcificationTypeCS.Code_Rim);                                                                 // CSBuilder.cs:373
		public TCoding Code_Round = new TCoding(MammoCalcificationTypeCS.Code_Round);                                                             // CSBuilder.cs:373
		public TCoding Code_Skin = new TCoding(MammoCalcificationTypeCS.Code_Skin);                                                               // CSBuilder.cs:373
		public TCoding Code_Spherical = new TCoding(MammoCalcificationTypeCS.Code_Spherical);                                                     // CSBuilder.cs:373
		public TCoding Code_Suture = new TCoding(MammoCalcificationTypeCS.Code_Suture);                                                           // CSBuilder.cs:373
		public TCoding Code_Vascular = new TCoding(MammoCalcificationTypeCS.Code_Vascular);                                                       // CSBuilder.cs:373
		                                                                                                                                          // CSBuilder.cs:328
		public List<Coding> Members;                                                                                                              // CSBuilder.cs:329
		                                                                                                                                          // CSBuilder.cs:330
		public MammoCalcificationTypeVS()                                                                                                         // CSBuilder.cs:331
		{                                                                                                                                         // CSBuilder.cs:332
		    this.Members = new List<Coding>();                                                                                                    // CSBuilder.cs:333
		    this.Members.Add(this.Code_Amorphous);                                                                                                // CSBuilder.cs:376
		    this.Members.Add(this.Code_Coarse);                                                                                                   // CSBuilder.cs:376
		    this.Members.Add(this.Code_Dystrophic);                                                                                               // CSBuilder.cs:376
		    this.Members.Add(this.Code_Eggshell);                                                                                                 // CSBuilder.cs:376
		    this.Members.Add(this.Code_Fine);                                                                                                     // CSBuilder.cs:376
		    this.Members.Add(this.Code_GenericCalcification);                                                                                     // CSBuilder.cs:376
		    this.Members.Add(this.Code_CourseHeterogeneous);                                                                                      // CSBuilder.cs:376
		    this.Members.Add(this.Code_Indistinct);                                                                                               // CSBuilder.cs:376
		    this.Members.Add(this.Code_LargeRodlike);                                                                                             // CSBuilder.cs:376
		    this.Members.Add(this.Code_Layering);                                                                                                 // CSBuilder.cs:376
		    this.Members.Add(this.Code_FineLinear);                                                                                               // CSBuilder.cs:376
		    this.Members.Add(this.Code_LucentCentered);                                                                                           // CSBuilder.cs:376
		    this.Members.Add(this.Code_MilkOfCalcium);                                                                                            // CSBuilder.cs:376
		    this.Members.Add(this.Code_FinePleomorphic);                                                                                          // CSBuilder.cs:376
		    this.Members.Add(this.Code_Punctate);                                                                                                 // CSBuilder.cs:376
		    this.Members.Add(this.Code_Rim);                                                                                                      // CSBuilder.cs:376
		    this.Members.Add(this.Code_Round);                                                                                                    // CSBuilder.cs:376
		    this.Members.Add(this.Code_Skin);                                                                                                     // CSBuilder.cs:376
		    this.Members.Add(this.Code_Spherical);                                                                                                // CSBuilder.cs:376
		    this.Members.Add(this.Code_Suture);                                                                                                   // CSBuilder.cs:376
		    this.Members.Add(this.Code_Vascular);                                                                                                 // CSBuilder.cs:376
		}                                                                                                                                         // CSBuilder.cs:335
		//- Fields
	}
}
