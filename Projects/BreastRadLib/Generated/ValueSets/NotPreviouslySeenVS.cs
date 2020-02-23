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
		public static TCoding Code_ClinicalExam = new TCoding(NotPreviouslySeenCodeSystemCS.Code_ClinicalExam);                                   // Builder.cs:349
		public static TCoding Code_Ductogram = new TCoding(NotPreviouslySeenCodeSystemCS.Code_Ductogram);                                         // Builder.cs:349
		public static TCoding Code_Mammogram = new TCoding(NotPreviouslySeenCodeSystemCS.Code_Mammogram);                                         // Builder.cs:349
		public static TCoding Code_MRI = new TCoding(NotPreviouslySeenCodeSystemCS.Code_MRI);                                                     // Builder.cs:349
		public static TCoding Code_OutsideExam = new TCoding(NotPreviouslySeenCodeSystemCS.Code_OutsideExam);                                     // Builder.cs:349
		public static TCoding Code_Scintimammography = new TCoding(NotPreviouslySeenCodeSystemCS.Code_Scintimammography);                         // Builder.cs:349
		public static TCoding Code_Ultrasound = new TCoding(NotPreviouslySeenCodeSystemCS.Code_Ultrasound);                                       // Builder.cs:349
		//- Fields

		//+ Methods
		public static IEnumerable<TCoding> Codes()                                                                                                // Builder.cs:335
		{                                                                                                                                         // Builder.cs:336
		    yield return Code_ClinicalExam;                                                                                                       // Builder.cs:352
		    yield return Code_Ductogram;                                                                                                          // Builder.cs:352
		    yield return Code_Mammogram;                                                                                                          // Builder.cs:352
		    yield return Code_MRI;                                                                                                                // Builder.cs:352
		    yield return Code_OutsideExam;                                                                                                        // Builder.cs:352
		    yield return Code_Scintimammography;                                                                                                  // Builder.cs:352
		    yield return Code_Ultrasound;                                                                                                         // Builder.cs:352
		}                                                                                                                                         // Builder.cs:358
		//- Methods
	}
}
