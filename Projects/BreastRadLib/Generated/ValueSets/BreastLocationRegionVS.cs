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
		public static TCoding Code_Axilla = new TCoding(BreastLocationRegionCS.Code_Axilla);                                                      // Builder.cs:347
		public static TCoding Code_AxillaryTail = new TCoding(BreastLocationRegionCS.Code_AxillaryTail);                                          // Builder.cs:347
		public static TCoding Code_AxillaI = new TCoding(BreastLocationRegionCS.Code_AxillaI);                                                    // Builder.cs:347
		public static TCoding Code_AxillaII = new TCoding(BreastLocationRegionCS.Code_AxillaII);                                                  // Builder.cs:347
		public static TCoding Code_AxillaIII = new TCoding(BreastLocationRegionCS.Code_AxillaIII);                                                // Builder.cs:347
		public static TCoding Code_InframammaryFold = new TCoding(BreastLocationRegionCS.Code_InframammaryFold);                                  // Builder.cs:347
		public static TCoding Code_InSkin = new TCoding(BreastLocationRegionCS.Code_InSkin);                                                      // Builder.cs:347
		public static TCoding Code_CentralToNipple = new TCoding(BreastLocationRegionCS.Code_CentralToNipple);                                    // Builder.cs:347
		//- Fields

		//+ Methods
		public static IEnumerable<TCoding> Codes()                                                                                                // Builder.cs:333
		{                                                                                                                                         // Builder.cs:334
		    yield return Code_Axilla;                                                                                                             // Builder.cs:350
		    yield return Code_AxillaryTail;                                                                                                       // Builder.cs:350
		    yield return Code_AxillaI;                                                                                                            // Builder.cs:350
		    yield return Code_AxillaII;                                                                                                           // Builder.cs:350
		    yield return Code_AxillaIII;                                                                                                          // Builder.cs:350
		    yield return Code_InframammaryFold;                                                                                                   // Builder.cs:350
		    yield return Code_InSkin;                                                                                                             // Builder.cs:350
		    yield return Code_CentralToNipple;                                                                                                    // Builder.cs:350
		}                                                                                                                                         // Builder.cs:356
		//- Methods
	}
}
