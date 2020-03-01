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
		public static TCoding Code_Category0 = new TCoding(BiRadsAssessmentCategoriesCS.Code_Category0);                                          // Builder.cs:347
		public static TCoding Code_Category2 = new TCoding(BiRadsAssessmentCategoriesCS.Code_Category2);                                          // Builder.cs:347
		public static TCoding Code_Category3 = new TCoding(BiRadsAssessmentCategoriesCS.Code_Category3);                                          // Builder.cs:347
		public static TCoding Code_Category4 = new TCoding(BiRadsAssessmentCategoriesCS.Code_Category4);                                          // Builder.cs:347
		public static TCoding Code_Category4A = new TCoding(BiRadsAssessmentCategoriesCS.Code_Category4A);                                        // Builder.cs:347
		public static TCoding Code_Category4B = new TCoding(BiRadsAssessmentCategoriesCS.Code_Category4B);                                        // Builder.cs:347
		public static TCoding Code_Category4C = new TCoding(BiRadsAssessmentCategoriesCS.Code_Category4C);                                        // Builder.cs:347
		public static TCoding Code_Category5 = new TCoding(BiRadsAssessmentCategoriesCS.Code_Category5);                                          // Builder.cs:347
		public static TCoding Code_Category6 = new TCoding(BiRadsAssessmentCategoriesCS.Code_Category6);                                          // Builder.cs:347
		//- Fields

		//+ Methods
		public static IEnumerable<TCoding> Codes()                                                                                                // Builder.cs:333
		{                                                                                                                                         // Builder.cs:334
		    yield return Code_Category0;                                                                                                          // Builder.cs:350
		    yield return Code_Category2;                                                                                                          // Builder.cs:350
		    yield return Code_Category3;                                                                                                          // Builder.cs:350
		    yield return Code_Category4;                                                                                                          // Builder.cs:350
		    yield return Code_Category4A;                                                                                                         // Builder.cs:350
		    yield return Code_Category4B;                                                                                                         // Builder.cs:350
		    yield return Code_Category4C;                                                                                                         // Builder.cs:350
		    yield return Code_Category5;                                                                                                          // Builder.cs:350
		    yield return Code_Category6;                                                                                                          // Builder.cs:350
		}                                                                                                                                         // Builder.cs:356
		//- Methods
	}
}
