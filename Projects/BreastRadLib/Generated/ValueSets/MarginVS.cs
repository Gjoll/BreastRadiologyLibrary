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
		public static TCoding Code_AngularMargin = new TCoding(MarginCS.Code_AngularMargin);                                                      // CSBuilder.cs:322
		public static TCoding Code_CircumscribedMargin = new TCoding(MarginCS.Code_CircumscribedMargin);                                          // CSBuilder.cs:322
		public static TCoding Code_IndistinctMargin = new TCoding(MarginCS.Code_IndistinctMargin);                                                // CSBuilder.cs:322
		public static TCoding Code_IntraductalExtension = new TCoding(MarginCS.Code_IntraductalExtension);                                        // CSBuilder.cs:322
		public static TCoding Code_IrregularMargin = new TCoding(MarginCS.Code_IrregularMargin);                                                  // CSBuilder.cs:322
		public static TCoding Code_LobulatedMargin = new TCoding(MarginCS.Code_LobulatedMargin);                                                  // CSBuilder.cs:322
		public static TCoding Code_MacrolobulatedMargin = new TCoding(MarginCS.Code_MacrolobulatedMargin);                                        // CSBuilder.cs:322
		public static TCoding Code_MicrolobulatedMargin = new TCoding(MarginCS.Code_MicrolobulatedMargin);                                        // CSBuilder.cs:322
		public static TCoding Code_NonCircumscribedMargin = new TCoding(MarginCS.Code_NonCircumscribedMargin);                                    // CSBuilder.cs:322
		public static TCoding Code_ObscuredMagin = new TCoding(MarginCS.Code_ObscuredMagin);                                                      // CSBuilder.cs:322
		public static TCoding Code_SmoothMargin = new TCoding(MarginCS.Code_SmoothMargin);                                                        // CSBuilder.cs:322
		public static TCoding Code_SpiculatedMargin = new TCoding(MarginCS.Code_SpiculatedMargin);                                                // CSBuilder.cs:322
		//- Fields

		//+ Methods
		public static IEnumerable<TCoding> Codes()                                                                                                // CSBuilder.cs:307
		{                                                                                                                                         // CSBuilder.cs:308
		    yield return Code_AngularMargin;                                                                                                      // CSBuilder.cs:325
		    yield return Code_CircumscribedMargin;                                                                                                // CSBuilder.cs:325
		    yield return Code_IndistinctMargin;                                                                                                   // CSBuilder.cs:325
		    yield return Code_IntraductalExtension;                                                                                               // CSBuilder.cs:325
		    yield return Code_IrregularMargin;                                                                                                    // CSBuilder.cs:325
		    yield return Code_LobulatedMargin;                                                                                                    // CSBuilder.cs:325
		    yield return Code_MacrolobulatedMargin;                                                                                               // CSBuilder.cs:325
		    yield return Code_MicrolobulatedMargin;                                                                                               // CSBuilder.cs:325
		    yield return Code_NonCircumscribedMargin;                                                                                             // CSBuilder.cs:325
		    yield return Code_ObscuredMagin;                                                                                                      // CSBuilder.cs:325
		    yield return Code_SmoothMargin;                                                                                                       // CSBuilder.cs:325
		    yield return Code_SpiculatedMargin;                                                                                                   // CSBuilder.cs:325
		}                                                                                                                                         // CSBuilder.cs:331
		//- Methods
	}
}
