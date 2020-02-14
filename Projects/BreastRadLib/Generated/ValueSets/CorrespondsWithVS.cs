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
		public static TCoding Code_Aspiration = new TCoding(CorrespondsWithCodeSystemCS.Code_Aspiration);                                         // CSBuilder.cs:322
		public static TCoding Code_Biopsy = new TCoding(CorrespondsWithCodeSystemCS.Code_Biopsy);                                                 // CSBuilder.cs:322
		public static TCoding Code_Concern = new TCoding(CorrespondsWithCodeSystemCS.Code_Concern);                                               // CSBuilder.cs:322
		public static TCoding Code_Ductogram = new TCoding(CorrespondsWithCodeSystemCS.Code_Ductogram);                                           // CSBuilder.cs:322
		public static TCoding Code_IncidentalFinding = new TCoding(CorrespondsWithCodeSystemCS.Code_IncidentalFinding);                           // CSBuilder.cs:322
		public static TCoding Code_Mammo = new TCoding(CorrespondsWithCodeSystemCS.Code_Mammo);                                                   // CSBuilder.cs:322
		public static TCoding Code_MRI = new TCoding(CorrespondsWithCodeSystemCS.Code_MRI);                                                       // CSBuilder.cs:322
		public static TCoding Code_NippleDischarge = new TCoding(CorrespondsWithCodeSystemCS.Code_NippleDischarge);                               // CSBuilder.cs:322
		public static TCoding Code_OutsideExam = new TCoding(CorrespondsWithCodeSystemCS.Code_OutsideExam);                                       // CSBuilder.cs:322
		public static TCoding Code_Pain = new TCoding(CorrespondsWithCodeSystemCS.Code_Pain);                                                     // CSBuilder.cs:322
		public static TCoding Code_Palpated = new TCoding(CorrespondsWithCodeSystemCS.Code_Palpated);                                             // CSBuilder.cs:322
		public static TCoding Code_PostOperative = new TCoding(CorrespondsWithCodeSystemCS.Code_PostOperative);                                   // CSBuilder.cs:322
		public static TCoding Code_PreviousBiopsy = new TCoding(CorrespondsWithCodeSystemCS.Code_PreviousBiopsy);                                 // CSBuilder.cs:322
		public static TCoding Code_PriorExam = new TCoding(CorrespondsWithCodeSystemCS.Code_PriorExam);                                           // CSBuilder.cs:322
		public static TCoding Code_Redness = new TCoding(CorrespondsWithCodeSystemCS.Code_Redness);                                               // CSBuilder.cs:322
		public static TCoding Code_Scinti = new TCoding(CorrespondsWithCodeSystemCS.Code_Scinti);                                                 // CSBuilder.cs:322
		public static TCoding Code_SizeLessThanMammo = new TCoding(CorrespondsWithCodeSystemCS.Code_SizeLessThanMammo);                           // CSBuilder.cs:322
		public static TCoding Code_SizeLessThanMRI = new TCoding(CorrespondsWithCodeSystemCS.Code_SizeLessThanMRI);                               // CSBuilder.cs:322
		public static TCoding Code_SizeLessThanPalp = new TCoding(CorrespondsWithCodeSystemCS.Code_SizeLessThanPalp);                             // CSBuilder.cs:322
		public static TCoding Code_SizeLessThanUS = new TCoding(CorrespondsWithCodeSystemCS.Code_SizeLessThanUS);                                 // CSBuilder.cs:322
		public static TCoding Code_SizeGreaterThanMammo = new TCoding(CorrespondsWithCodeSystemCS.Code_SizeGreaterThanMammo);                     // CSBuilder.cs:322
		public static TCoding Code_SizeGreaterThanMRI = new TCoding(CorrespondsWithCodeSystemCS.Code_SizeGreaterThanMRI);                         // CSBuilder.cs:322
		public static TCoding Code_SizeGreaterThanPalp = new TCoding(CorrespondsWithCodeSystemCS.Code_SizeGreaterThanPalp);                       // CSBuilder.cs:322
		public static TCoding Code_SkinMarker = new TCoding(CorrespondsWithCodeSystemCS.Code_SkinMarker);                                         // CSBuilder.cs:322
		public static TCoding Code_Surgery = new TCoding(CorrespondsWithCodeSystemCS.Code_Surgery);                                               // CSBuilder.cs:322
		public static TCoding Code_SurgicalSite = new TCoding(CorrespondsWithCodeSystemCS.Code_SurgicalSite);                                     // CSBuilder.cs:322
		public static TCoding Code_Tenderness = new TCoding(CorrespondsWithCodeSystemCS.Code_Tenderness);                                         // CSBuilder.cs:322
		public static TCoding Code_TriggerPoint = new TCoding(CorrespondsWithCodeSystemCS.Code_TriggerPoint);                                     // CSBuilder.cs:322
		public static TCoding Code_US = new TCoding(CorrespondsWithCodeSystemCS.Code_US);                                                         // CSBuilder.cs:322
		//- Fields

		//+ Methods
		public static IEnumerable<TCoding> Codes()                                                                                                // CSBuilder.cs:307
		{                                                                                                                                         // CSBuilder.cs:308
		    yield return Code_Aspiration;                                                                                                         // CSBuilder.cs:325
		    yield return Code_Biopsy;                                                                                                             // CSBuilder.cs:325
		    yield return Code_Concern;                                                                                                            // CSBuilder.cs:325
		    yield return Code_Ductogram;                                                                                                          // CSBuilder.cs:325
		    yield return Code_IncidentalFinding;                                                                                                  // CSBuilder.cs:325
		    yield return Code_Mammo;                                                                                                              // CSBuilder.cs:325
		    yield return Code_MRI;                                                                                                                // CSBuilder.cs:325
		    yield return Code_NippleDischarge;                                                                                                    // CSBuilder.cs:325
		    yield return Code_OutsideExam;                                                                                                        // CSBuilder.cs:325
		    yield return Code_Pain;                                                                                                               // CSBuilder.cs:325
		    yield return Code_Palpated;                                                                                                           // CSBuilder.cs:325
		    yield return Code_PostOperative;                                                                                                      // CSBuilder.cs:325
		    yield return Code_PreviousBiopsy;                                                                                                     // CSBuilder.cs:325
		    yield return Code_PriorExam;                                                                                                          // CSBuilder.cs:325
		    yield return Code_Redness;                                                                                                            // CSBuilder.cs:325
		    yield return Code_Scinti;                                                                                                             // CSBuilder.cs:325
		    yield return Code_SizeLessThanMammo;                                                                                                  // CSBuilder.cs:325
		    yield return Code_SizeLessThanMRI;                                                                                                    // CSBuilder.cs:325
		    yield return Code_SizeLessThanPalp;                                                                                                   // CSBuilder.cs:325
		    yield return Code_SizeLessThanUS;                                                                                                     // CSBuilder.cs:325
		    yield return Code_SizeGreaterThanMammo;                                                                                               // CSBuilder.cs:325
		    yield return Code_SizeGreaterThanMRI;                                                                                                 // CSBuilder.cs:325
		    yield return Code_SizeGreaterThanPalp;                                                                                                // CSBuilder.cs:325
		    yield return Code_SkinMarker;                                                                                                         // CSBuilder.cs:325
		    yield return Code_Surgery;                                                                                                            // CSBuilder.cs:325
		    yield return Code_SurgicalSite;                                                                                                       // CSBuilder.cs:325
		    yield return Code_Tenderness;                                                                                                         // CSBuilder.cs:325
		    yield return Code_TriggerPoint;                                                                                                       // CSBuilder.cs:325
		    yield return Code_US;                                                                                                                 // CSBuilder.cs:325
		}                                                                                                                                         // CSBuilder.cs:331
		//- Methods
	}
}
