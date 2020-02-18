using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class BiRadsAssessmentCategoriesVS
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
		public static TCoding Code_Category0 = new TCoding(BiRadsAssessmentCategoriesCS.Code_Category0);                                          // CSBuilder.cs:320
		public static TCoding Code_Category2 = new TCoding(BiRadsAssessmentCategoriesCS.Code_Category2);                                          // CSBuilder.cs:320
		public static TCoding Code_Category3 = new TCoding(BiRadsAssessmentCategoriesCS.Code_Category3);                                          // CSBuilder.cs:320
		public static TCoding Code_Category4 = new TCoding(BiRadsAssessmentCategoriesCS.Code_Category4);                                          // CSBuilder.cs:320
		public static TCoding Code_Category4A = new TCoding(BiRadsAssessmentCategoriesCS.Code_Category4A);                                        // CSBuilder.cs:320
		public static TCoding Code_Category4B = new TCoding(BiRadsAssessmentCategoriesCS.Code_Category4B);                                        // CSBuilder.cs:320
		public static TCoding Code_Category4C = new TCoding(BiRadsAssessmentCategoriesCS.Code_Category4C);                                        // CSBuilder.cs:320
		public static TCoding Code_Category5 = new TCoding(BiRadsAssessmentCategoriesCS.Code_Category5);                                          // CSBuilder.cs:320
		public static TCoding Code_Category6 = new TCoding(BiRadsAssessmentCategoriesCS.Code_Category6);                                          // CSBuilder.cs:320
		//- Fields

		//+ Methods
		public static IEnumerable<TCoding> Codes()                                                                                                // CSBuilder.cs:305
		{                                                                                                                                         // CSBuilder.cs:306
		    yield return Code_Category0;                                                                                                          // CSBuilder.cs:323
		    yield return Code_Category2;                                                                                                          // CSBuilder.cs:323
		    yield return Code_Category3;                                                                                                          // CSBuilder.cs:323
		    yield return Code_Category4;                                                                                                          // CSBuilder.cs:323
		    yield return Code_Category4A;                                                                                                         // CSBuilder.cs:323
		    yield return Code_Category4B;                                                                                                         // CSBuilder.cs:323
		    yield return Code_Category4C;                                                                                                         // CSBuilder.cs:323
		    yield return Code_Category5;                                                                                                          // CSBuilder.cs:323
		    yield return Code_Category6;                                                                                                          // CSBuilder.cs:323
		}                                                                                                                                         // CSBuilder.cs:329
		//- Methods
	}
}
