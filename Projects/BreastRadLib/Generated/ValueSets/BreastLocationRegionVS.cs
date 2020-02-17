using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class BreastLocationRegionVS
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
		public static TCoding Code_Axilla = new TCoding(BreastLocationRegionCS.Code_Axilla);                                                      // CSBuilder.cs:322
		public static TCoding Code_AxillaryTail = new TCoding(BreastLocationRegionCS.Code_AxillaryTail);                                          // CSBuilder.cs:322
		public static TCoding Code_AxillaI = new TCoding(BreastLocationRegionCS.Code_AxillaI);                                                    // CSBuilder.cs:322
		public static TCoding Code_AxillaII = new TCoding(BreastLocationRegionCS.Code_AxillaII);                                                  // CSBuilder.cs:322
		public static TCoding Code_AxillaIII = new TCoding(BreastLocationRegionCS.Code_AxillaIII);                                                // CSBuilder.cs:322
		public static TCoding Code_InframammaryFold = new TCoding(BreastLocationRegionCS.Code_InframammaryFold);                                  // CSBuilder.cs:322
		public static TCoding Code_InSkin = new TCoding(BreastLocationRegionCS.Code_InSkin);                                                      // CSBuilder.cs:322
		public static TCoding Code_CentralToNipple = new TCoding(BreastLocationRegionCS.Code_CentralToNipple);                                    // CSBuilder.cs:322
		//- Fields

		//+ Methods
		public static IEnumerable<TCoding> Codes()                                                                                                // CSBuilder.cs:307
		{                                                                                                                                         // CSBuilder.cs:308
		    yield return Code_Axilla;                                                                                                             // CSBuilder.cs:325
		    yield return Code_AxillaryTail;                                                                                                       // CSBuilder.cs:325
		    yield return Code_AxillaI;                                                                                                            // CSBuilder.cs:325
		    yield return Code_AxillaII;                                                                                                           // CSBuilder.cs:325
		    yield return Code_AxillaIII;                                                                                                          // CSBuilder.cs:325
		    yield return Code_InframammaryFold;                                                                                                   // CSBuilder.cs:325
		    yield return Code_InSkin;                                                                                                             // CSBuilder.cs:325
		    yield return Code_CentralToNipple;                                                                                                    // CSBuilder.cs:325
		}                                                                                                                                         // CSBuilder.cs:331
		//- Methods
	}
}
