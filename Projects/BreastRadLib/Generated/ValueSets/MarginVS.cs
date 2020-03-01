using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class MarginVS
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
		public static TCoding Code_AngularMargin = new TCoding(MarginCS.Code_AngularMargin);                                                      // Builder.cs:347
		public static TCoding Code_CircumscribedMargin = new TCoding(MarginCS.Code_CircumscribedMargin);                                          // Builder.cs:347
		public static TCoding Code_IndistinctMargin = new TCoding(MarginCS.Code_IndistinctMargin);                                                // Builder.cs:347
		public static TCoding Code_IntraductalExtension = new TCoding(MarginCS.Code_IntraductalExtension);                                        // Builder.cs:347
		public static TCoding Code_IrregularMargin = new TCoding(MarginCS.Code_IrregularMargin);                                                  // Builder.cs:347
		public static TCoding Code_LobulatedMargin = new TCoding(MarginCS.Code_LobulatedMargin);                                                  // Builder.cs:347
		public static TCoding Code_MacrolobulatedMargin = new TCoding(MarginCS.Code_MacrolobulatedMargin);                                        // Builder.cs:347
		public static TCoding Code_MicrolobulatedMargin = new TCoding(MarginCS.Code_MicrolobulatedMargin);                                        // Builder.cs:347
		public static TCoding Code_NonCircumscribedMargin = new TCoding(MarginCS.Code_NonCircumscribedMargin);                                    // Builder.cs:347
		public static TCoding Code_ObscuredMagin = new TCoding(MarginCS.Code_ObscuredMagin);                                                      // Builder.cs:347
		public static TCoding Code_SmoothMargin = new TCoding(MarginCS.Code_SmoothMargin);                                                        // Builder.cs:347
		public static TCoding Code_SpiculatedMargin = new TCoding(MarginCS.Code_SpiculatedMargin);                                                // Builder.cs:347
		//- Fields

		//+ Methods
		public static IEnumerable<TCoding> Codes()                                                                                                // Builder.cs:333
		{                                                                                                                                         // Builder.cs:334
		    yield return Code_AngularMargin;                                                                                                      // Builder.cs:350
		    yield return Code_CircumscribedMargin;                                                                                                // Builder.cs:350
		    yield return Code_IndistinctMargin;                                                                                                   // Builder.cs:350
		    yield return Code_IntraductalExtension;                                                                                               // Builder.cs:350
		    yield return Code_IrregularMargin;                                                                                                    // Builder.cs:350
		    yield return Code_LobulatedMargin;                                                                                                    // Builder.cs:350
		    yield return Code_MacrolobulatedMargin;                                                                                               // Builder.cs:350
		    yield return Code_MicrolobulatedMargin;                                                                                               // Builder.cs:350
		    yield return Code_NonCircumscribedMargin;                                                                                             // Builder.cs:350
		    yield return Code_ObscuredMagin;                                                                                                      // Builder.cs:350
		    yield return Code_SmoothMargin;                                                                                                       // Builder.cs:350
		    yield return Code_SpiculatedMargin;                                                                                                   // Builder.cs:350
		}                                                                                                                                         // Builder.cs:356
		//- Methods
	}
}
