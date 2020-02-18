using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class NotPreviouslySeenVS
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
		public static TCoding Code_ClinicalExam = new TCoding(NotPreviouslySeenCodeSystemCS.Code_ClinicalExam);                                   // CSBuilder.cs:320
		public static TCoding Code_Ductogram = new TCoding(NotPreviouslySeenCodeSystemCS.Code_Ductogram);                                         // CSBuilder.cs:320
		public static TCoding Code_Mammogram = new TCoding(NotPreviouslySeenCodeSystemCS.Code_Mammogram);                                         // CSBuilder.cs:320
		public static TCoding Code_MRI = new TCoding(NotPreviouslySeenCodeSystemCS.Code_MRI);                                                     // CSBuilder.cs:320
		public static TCoding Code_OutsideExam = new TCoding(NotPreviouslySeenCodeSystemCS.Code_OutsideExam);                                     // CSBuilder.cs:320
		public static TCoding Code_Scintimammography = new TCoding(NotPreviouslySeenCodeSystemCS.Code_Scintimammography);                         // CSBuilder.cs:320
		public static TCoding Code_Ultrasound = new TCoding(NotPreviouslySeenCodeSystemCS.Code_Ultrasound);                                       // CSBuilder.cs:320
		//- Fields

		//+ Methods
		public static IEnumerable<TCoding> Codes()                                                                                                // CSBuilder.cs:305
		{                                                                                                                                         // CSBuilder.cs:306
		    yield return Code_ClinicalExam;                                                                                                       // CSBuilder.cs:323
		    yield return Code_Ductogram;                                                                                                          // CSBuilder.cs:323
		    yield return Code_Mammogram;                                                                                                          // CSBuilder.cs:323
		    yield return Code_MRI;                                                                                                                // CSBuilder.cs:323
		    yield return Code_OutsideExam;                                                                                                        // CSBuilder.cs:323
		    yield return Code_Scintimammography;                                                                                                  // CSBuilder.cs:323
		    yield return Code_Ultrasound;                                                                                                         // CSBuilder.cs:323
		}                                                                                                                                         // CSBuilder.cs:329
		//- Methods
	}
}
