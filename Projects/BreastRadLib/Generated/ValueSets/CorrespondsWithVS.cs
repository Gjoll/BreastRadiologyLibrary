using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class CorrespondsWithVS
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
		public static TCoding Code_Aspiration = new TCoding(CorrespondsWithCodeSystemCS.Code_Aspiration);                                         // Builder.cs:349
		public static TCoding Code_Biopsy = new TCoding(CorrespondsWithCodeSystemCS.Code_Biopsy);                                                 // Builder.cs:349
		public static TCoding Code_Concern = new TCoding(CorrespondsWithCodeSystemCS.Code_Concern);                                               // Builder.cs:349
		public static TCoding Code_Ductogram = new TCoding(CorrespondsWithCodeSystemCS.Code_Ductogram);                                           // Builder.cs:349
		public static TCoding Code_IncidentalFinding = new TCoding(CorrespondsWithCodeSystemCS.Code_IncidentalFinding);                           // Builder.cs:349
		public static TCoding Code_Mammo = new TCoding(CorrespondsWithCodeSystemCS.Code_Mammo);                                                   // Builder.cs:349
		public static TCoding Code_MRI = new TCoding(CorrespondsWithCodeSystemCS.Code_MRI);                                                       // Builder.cs:349
		public static TCoding Code_NippleDischarge = new TCoding(CorrespondsWithCodeSystemCS.Code_NippleDischarge);                               // Builder.cs:349
		public static TCoding Code_OutsideExam = new TCoding(CorrespondsWithCodeSystemCS.Code_OutsideExam);                                       // Builder.cs:349
		public static TCoding Code_Pain = new TCoding(CorrespondsWithCodeSystemCS.Code_Pain);                                                     // Builder.cs:349
		public static TCoding Code_Palpated = new TCoding(CorrespondsWithCodeSystemCS.Code_Palpated);                                             // Builder.cs:349
		public static TCoding Code_PostOperative = new TCoding(CorrespondsWithCodeSystemCS.Code_PostOperative);                                   // Builder.cs:349
		public static TCoding Code_PreviousBiopsy = new TCoding(CorrespondsWithCodeSystemCS.Code_PreviousBiopsy);                                 // Builder.cs:349
		public static TCoding Code_PriorExam = new TCoding(CorrespondsWithCodeSystemCS.Code_PriorExam);                                           // Builder.cs:349
		public static TCoding Code_Redness = new TCoding(CorrespondsWithCodeSystemCS.Code_Redness);                                               // Builder.cs:349
		public static TCoding Code_Scinti = new TCoding(CorrespondsWithCodeSystemCS.Code_Scinti);                                                 // Builder.cs:349
		public static TCoding Code_SizeLessThanMammo = new TCoding(CorrespondsWithCodeSystemCS.Code_SizeLessThanMammo);                           // Builder.cs:349
		public static TCoding Code_SizeLessThanMRI = new TCoding(CorrespondsWithCodeSystemCS.Code_SizeLessThanMRI);                               // Builder.cs:349
		public static TCoding Code_SizeLessThanPalp = new TCoding(CorrespondsWithCodeSystemCS.Code_SizeLessThanPalp);                             // Builder.cs:349
		public static TCoding Code_SizeLessThanUS = new TCoding(CorrespondsWithCodeSystemCS.Code_SizeLessThanUS);                                 // Builder.cs:349
		public static TCoding Code_SizeGreaterThanMammo = new TCoding(CorrespondsWithCodeSystemCS.Code_SizeGreaterThanMammo);                     // Builder.cs:349
		public static TCoding Code_SizeGreaterThanMRI = new TCoding(CorrespondsWithCodeSystemCS.Code_SizeGreaterThanMRI);                         // Builder.cs:349
		public static TCoding Code_SizeGreaterThanPalp = new TCoding(CorrespondsWithCodeSystemCS.Code_SizeGreaterThanPalp);                       // Builder.cs:349
		public static TCoding Code_SkinMarker = new TCoding(CorrespondsWithCodeSystemCS.Code_SkinMarker);                                         // Builder.cs:349
		public static TCoding Code_Surgery = new TCoding(CorrespondsWithCodeSystemCS.Code_Surgery);                                               // Builder.cs:349
		public static TCoding Code_SurgicalSite = new TCoding(CorrespondsWithCodeSystemCS.Code_SurgicalSite);                                     // Builder.cs:349
		public static TCoding Code_Tenderness = new TCoding(CorrespondsWithCodeSystemCS.Code_Tenderness);                                         // Builder.cs:349
		public static TCoding Code_TriggerPoint = new TCoding(CorrespondsWithCodeSystemCS.Code_TriggerPoint);                                     // Builder.cs:349
		public static TCoding Code_US = new TCoding(CorrespondsWithCodeSystemCS.Code_US);                                                         // Builder.cs:349
		//- Fields

		//+ Methods
		public static IEnumerable<TCoding> Codes()                                                                                                // Builder.cs:335
		{                                                                                                                                         // Builder.cs:336
		    yield return Code_Aspiration;                                                                                                         // Builder.cs:352
		    yield return Code_Biopsy;                                                                                                             // Builder.cs:352
		    yield return Code_Concern;                                                                                                            // Builder.cs:352
		    yield return Code_Ductogram;                                                                                                          // Builder.cs:352
		    yield return Code_IncidentalFinding;                                                                                                  // Builder.cs:352
		    yield return Code_Mammo;                                                                                                              // Builder.cs:352
		    yield return Code_MRI;                                                                                                                // Builder.cs:352
		    yield return Code_NippleDischarge;                                                                                                    // Builder.cs:352
		    yield return Code_OutsideExam;                                                                                                        // Builder.cs:352
		    yield return Code_Pain;                                                                                                               // Builder.cs:352
		    yield return Code_Palpated;                                                                                                           // Builder.cs:352
		    yield return Code_PostOperative;                                                                                                      // Builder.cs:352
		    yield return Code_PreviousBiopsy;                                                                                                     // Builder.cs:352
		    yield return Code_PriorExam;                                                                                                          // Builder.cs:352
		    yield return Code_Redness;                                                                                                            // Builder.cs:352
		    yield return Code_Scinti;                                                                                                             // Builder.cs:352
		    yield return Code_SizeLessThanMammo;                                                                                                  // Builder.cs:352
		    yield return Code_SizeLessThanMRI;                                                                                                    // Builder.cs:352
		    yield return Code_SizeLessThanPalp;                                                                                                   // Builder.cs:352
		    yield return Code_SizeLessThanUS;                                                                                                     // Builder.cs:352
		    yield return Code_SizeGreaterThanMammo;                                                                                               // Builder.cs:352
		    yield return Code_SizeGreaterThanMRI;                                                                                                 // Builder.cs:352
		    yield return Code_SizeGreaterThanPalp;                                                                                                // Builder.cs:352
		    yield return Code_SkinMarker;                                                                                                         // Builder.cs:352
		    yield return Code_Surgery;                                                                                                            // Builder.cs:352
		    yield return Code_SurgicalSite;                                                                                                       // Builder.cs:352
		    yield return Code_Tenderness;                                                                                                         // Builder.cs:352
		    yield return Code_TriggerPoint;                                                                                                       // Builder.cs:352
		    yield return Code_US;                                                                                                                 // Builder.cs:352
		}                                                                                                                                         // Builder.cs:358
		//- Methods
	}
}
