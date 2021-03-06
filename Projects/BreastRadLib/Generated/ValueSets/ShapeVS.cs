using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class ShapeVS
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
		public static TCoding Code_IrregularInShape = new TCoding(ShapeCS.Code_IrregularInShape);                                                 // Builder.cs:353
		public static TCoding Code_LobulatedInShape = new TCoding(ShapeCS.Code_LobulatedInShape);                                                 // Builder.cs:353
		public static TCoding Code_OvalInShape = new TCoding(ShapeCS.Code_OvalInShape);                                                           // Builder.cs:353
		public static TCoding Code_Reniform = new TCoding(ShapeCS.Code_Reniform);                                                                 // Builder.cs:353
		public static TCoding Code_RoundInShape = new TCoding(ShapeCS.Code_RoundInShape);                                                         // Builder.cs:353
		//- Fields

		//+ Methods
		public static IEnumerable<TCoding> Codes()                                                                                                // Builder.cs:339
		{                                                                                                                                         // Builder.cs:340
		    yield return Code_IrregularInShape;                                                                                                   // Builder.cs:356
		    yield return Code_LobulatedInShape;                                                                                                   // Builder.cs:356
		    yield return Code_OvalInShape;                                                                                                        // Builder.cs:356
		    yield return Code_Reniform;                                                                                                           // Builder.cs:356
		    yield return Code_RoundInShape;                                                                                                       // Builder.cs:356
		}                                                                                                                                         // Builder.cs:362
		//- Methods
	}
}
