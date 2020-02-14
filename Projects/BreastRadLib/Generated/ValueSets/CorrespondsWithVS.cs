using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	//+ Header
	public class CorrespondsWithVS                                                                                                             // CSBuilder.cs:344
	//- Header
	{
		//+ Fields
		/// <summary>
		/// This class creates a type for codings of this class, that implicitly converts to Coding
		/// Allows type checking for these codes.
		/// </summary>
		public class TCoding                                                                                                                      // CSBuilder.cs:365
		{                                                                                                                                         // CSBuilder.cs:366
		    Coding value;                                                                                                                         // CSBuilder.cs:367
		    public static implicit operator Coding(TCoding tCode)                                                                                 // CSBuilder.cs:368
		    {                                                                                                                                     // CSBuilder.cs:369
		        return tCode.value;                                                                                                               // CSBuilder.cs:370
		    }                                                                                                                                     // CSBuilder.cs:371
		                                                                                                                                          // CSBuilder.cs:372
		    public TCoding(Coding value)                                                                                                          // CSBuilder.cs:373
		    {                                                                                                                                     // CSBuilder.cs:374
		        this.value= value;                                                                                                                // CSBuilder.cs:375
		    }                                                                                                                                     // CSBuilder.cs:376
		}                                                                                                                                         // CSBuilder.cs:377
		public TCoding Code_Aspiration = new TCoding(CorrespondsWithCodeSystemCS.Code_Aspiration);                                                // CSBuilder.cs:395
		public TCoding Code_Biopsy = new TCoding(CorrespondsWithCodeSystemCS.Code_Biopsy);                                                        // CSBuilder.cs:395
		public TCoding Code_Concern = new TCoding(CorrespondsWithCodeSystemCS.Code_Concern);                                                      // CSBuilder.cs:395
		public TCoding Code_Ductogram = new TCoding(CorrespondsWithCodeSystemCS.Code_Ductogram);                                                  // CSBuilder.cs:395
		public TCoding Code_IncidentalFinding = new TCoding(CorrespondsWithCodeSystemCS.Code_IncidentalFinding);                                  // CSBuilder.cs:395
		public TCoding Code_Mammo = new TCoding(CorrespondsWithCodeSystemCS.Code_Mammo);                                                          // CSBuilder.cs:395
		public TCoding Code_MRI = new TCoding(CorrespondsWithCodeSystemCS.Code_MRI);                                                              // CSBuilder.cs:395
		public TCoding Code_NippleDischarge = new TCoding(CorrespondsWithCodeSystemCS.Code_NippleDischarge);                                      // CSBuilder.cs:395
		public TCoding Code_OutsideExam = new TCoding(CorrespondsWithCodeSystemCS.Code_OutsideExam);                                              // CSBuilder.cs:395
		public TCoding Code_Pain = new TCoding(CorrespondsWithCodeSystemCS.Code_Pain);                                                            // CSBuilder.cs:395
		public TCoding Code_Palpated = new TCoding(CorrespondsWithCodeSystemCS.Code_Palpated);                                                    // CSBuilder.cs:395
		public TCoding Code_PostOperative = new TCoding(CorrespondsWithCodeSystemCS.Code_PostOperative);                                          // CSBuilder.cs:395
		public TCoding Code_PreviousBiopsy = new TCoding(CorrespondsWithCodeSystemCS.Code_PreviousBiopsy);                                        // CSBuilder.cs:395
		public TCoding Code_PriorExam = new TCoding(CorrespondsWithCodeSystemCS.Code_PriorExam);                                                  // CSBuilder.cs:395
		public TCoding Code_Redness = new TCoding(CorrespondsWithCodeSystemCS.Code_Redness);                                                      // CSBuilder.cs:395
		public TCoding Code_Scinti = new TCoding(CorrespondsWithCodeSystemCS.Code_Scinti);                                                        // CSBuilder.cs:395
		public TCoding Code_SizeLessThanMammo = new TCoding(CorrespondsWithCodeSystemCS.Code_SizeLessThanMammo);                                  // CSBuilder.cs:395
		public TCoding Code_SizeLessThanMRI = new TCoding(CorrespondsWithCodeSystemCS.Code_SizeLessThanMRI);                                      // CSBuilder.cs:395
		public TCoding Code_SizeLessThanPalp = new TCoding(CorrespondsWithCodeSystemCS.Code_SizeLessThanPalp);                                    // CSBuilder.cs:395
		public TCoding Code_SizeLessThanUS = new TCoding(CorrespondsWithCodeSystemCS.Code_SizeLessThanUS);                                        // CSBuilder.cs:395
		public TCoding Code_SizeGreaterThanMammo = new TCoding(CorrespondsWithCodeSystemCS.Code_SizeGreaterThanMammo);                            // CSBuilder.cs:395
		public TCoding Code_SizeGreaterThanMRI = new TCoding(CorrespondsWithCodeSystemCS.Code_SizeGreaterThanMRI);                                // CSBuilder.cs:395
		public TCoding Code_SizeGreaterThanPalp = new TCoding(CorrespondsWithCodeSystemCS.Code_SizeGreaterThanPalp);                              // CSBuilder.cs:395
		public TCoding Code_SkinMarker = new TCoding(CorrespondsWithCodeSystemCS.Code_SkinMarker);                                                // CSBuilder.cs:395
		public TCoding Code_Surgery = new TCoding(CorrespondsWithCodeSystemCS.Code_Surgery);                                                      // CSBuilder.cs:395
		public TCoding Code_SurgicalSite = new TCoding(CorrespondsWithCodeSystemCS.Code_SurgicalSite);                                            // CSBuilder.cs:395
		public TCoding Code_Tenderness = new TCoding(CorrespondsWithCodeSystemCS.Code_Tenderness);                                                // CSBuilder.cs:395
		public TCoding Code_TriggerPoint = new TCoding(CorrespondsWithCodeSystemCS.Code_TriggerPoint);                                            // CSBuilder.cs:395
		public TCoding Code_US = new TCoding(CorrespondsWithCodeSystemCS.Code_US);                                                                // CSBuilder.cs:395
		                                                                                                                                          // CSBuilder.cs:350
		public List<Coding> Members;                                                                                                              // CSBuilder.cs:351
		                                                                                                                                          // CSBuilder.cs:352
		public CorrespondsWithVS()                                                                                                                // CSBuilder.cs:353
		{                                                                                                                                         // CSBuilder.cs:354
		    this.Members = new List<Coding>();                                                                                                    // CSBuilder.cs:355
		    this.Members.Add(this.Code_Aspiration);                                                                                               // CSBuilder.cs:398
		    this.Members.Add(this.Code_Biopsy);                                                                                                   // CSBuilder.cs:398
		    this.Members.Add(this.Code_Concern);                                                                                                  // CSBuilder.cs:398
		    this.Members.Add(this.Code_Ductogram);                                                                                                // CSBuilder.cs:398
		    this.Members.Add(this.Code_IncidentalFinding);                                                                                        // CSBuilder.cs:398
		    this.Members.Add(this.Code_Mammo);                                                                                                    // CSBuilder.cs:398
		    this.Members.Add(this.Code_MRI);                                                                                                      // CSBuilder.cs:398
		    this.Members.Add(this.Code_NippleDischarge);                                                                                          // CSBuilder.cs:398
		    this.Members.Add(this.Code_OutsideExam);                                                                                              // CSBuilder.cs:398
		    this.Members.Add(this.Code_Pain);                                                                                                     // CSBuilder.cs:398
		    this.Members.Add(this.Code_Palpated);                                                                                                 // CSBuilder.cs:398
		    this.Members.Add(this.Code_PostOperative);                                                                                            // CSBuilder.cs:398
		    this.Members.Add(this.Code_PreviousBiopsy);                                                                                           // CSBuilder.cs:398
		    this.Members.Add(this.Code_PriorExam);                                                                                                // CSBuilder.cs:398
		    this.Members.Add(this.Code_Redness);                                                                                                  // CSBuilder.cs:398
		    this.Members.Add(this.Code_Scinti);                                                                                                   // CSBuilder.cs:398
		    this.Members.Add(this.Code_SizeLessThanMammo);                                                                                        // CSBuilder.cs:398
		    this.Members.Add(this.Code_SizeLessThanMRI);                                                                                          // CSBuilder.cs:398
		    this.Members.Add(this.Code_SizeLessThanPalp);                                                                                         // CSBuilder.cs:398
		    this.Members.Add(this.Code_SizeLessThanUS);                                                                                           // CSBuilder.cs:398
		    this.Members.Add(this.Code_SizeGreaterThanMammo);                                                                                     // CSBuilder.cs:398
		    this.Members.Add(this.Code_SizeGreaterThanMRI);                                                                                       // CSBuilder.cs:398
		    this.Members.Add(this.Code_SizeGreaterThanPalp);                                                                                      // CSBuilder.cs:398
		    this.Members.Add(this.Code_SkinMarker);                                                                                               // CSBuilder.cs:398
		    this.Members.Add(this.Code_Surgery);                                                                                                  // CSBuilder.cs:398
		    this.Members.Add(this.Code_SurgicalSite);                                                                                             // CSBuilder.cs:398
		    this.Members.Add(this.Code_Tenderness);                                                                                               // CSBuilder.cs:398
		    this.Members.Add(this.Code_TriggerPoint);                                                                                             // CSBuilder.cs:398
		    this.Members.Add(this.Code_US);                                                                                                       // CSBuilder.cs:398
		}                                                                                                                                         // CSBuilder.cs:357
		//- Fields
	}
}
