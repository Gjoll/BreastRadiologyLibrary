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
		//+ Fields
		/// <summary>
		/// This class creates a type for codings of this class, that implicitly converts to Coding
		/// Allows type checking for these codes.
		/// </summary>
		public class TCoding                                                                                                                      // CSBuilder.cs:315
		{                                                                                                                                         // CSBuilder.cs:316
		    Coding value;                                                                                                                         // CSBuilder.cs:317
		    public static implicit operator Coding(TCoding tCode)                                                                                 // CSBuilder.cs:318
		    {                                                                                                                                     // CSBuilder.cs:319
		        return tCode.value;                                                                                                               // CSBuilder.cs:320
		    }                                                                                                                                     // CSBuilder.cs:321
		                                                                                                                                          // CSBuilder.cs:322
		    public TCoding(Coding value)                                                                                                          // CSBuilder.cs:323
		    {                                                                                                                                     // CSBuilder.cs:324
		        this.value= value;                                                                                                                // CSBuilder.cs:325
		    }                                                                                                                                     // CSBuilder.cs:326
		}                                                                                                                                         // CSBuilder.cs:327
		public TCoding Code_Aspiration = new TCoding(CorrespondsWithCodeSystemCS.Code_Aspiration);                                                // CSBuilder.cs:345
		public TCoding Code_Biopsy = new TCoding(CorrespondsWithCodeSystemCS.Code_Biopsy);                                                        // CSBuilder.cs:345
		public TCoding Code_Concern = new TCoding(CorrespondsWithCodeSystemCS.Code_Concern);                                                      // CSBuilder.cs:345
		public TCoding Code_Ductogram = new TCoding(CorrespondsWithCodeSystemCS.Code_Ductogram);                                                  // CSBuilder.cs:345
		public TCoding Code_IncidentalFinding = new TCoding(CorrespondsWithCodeSystemCS.Code_IncidentalFinding);                                  // CSBuilder.cs:345
		public TCoding Code_Mammo = new TCoding(CorrespondsWithCodeSystemCS.Code_Mammo);                                                          // CSBuilder.cs:345
		public TCoding Code_MRI = new TCoding(CorrespondsWithCodeSystemCS.Code_MRI);                                                              // CSBuilder.cs:345
		public TCoding Code_NippleDischarge = new TCoding(CorrespondsWithCodeSystemCS.Code_NippleDischarge);                                      // CSBuilder.cs:345
		public TCoding Code_OutsideExam = new TCoding(CorrespondsWithCodeSystemCS.Code_OutsideExam);                                              // CSBuilder.cs:345
		public TCoding Code_Pain = new TCoding(CorrespondsWithCodeSystemCS.Code_Pain);                                                            // CSBuilder.cs:345
		public TCoding Code_Palpated = new TCoding(CorrespondsWithCodeSystemCS.Code_Palpated);                                                    // CSBuilder.cs:345
		public TCoding Code_PostOperative = new TCoding(CorrespondsWithCodeSystemCS.Code_PostOperative);                                          // CSBuilder.cs:345
		public TCoding Code_PreviousBiopsy = new TCoding(CorrespondsWithCodeSystemCS.Code_PreviousBiopsy);                                        // CSBuilder.cs:345
		public TCoding Code_PriorExam = new TCoding(CorrespondsWithCodeSystemCS.Code_PriorExam);                                                  // CSBuilder.cs:345
		public TCoding Code_Redness = new TCoding(CorrespondsWithCodeSystemCS.Code_Redness);                                                      // CSBuilder.cs:345
		public TCoding Code_Scinti = new TCoding(CorrespondsWithCodeSystemCS.Code_Scinti);                                                        // CSBuilder.cs:345
		public TCoding Code_SizeLessThanMammo = new TCoding(CorrespondsWithCodeSystemCS.Code_SizeLessThanMammo);                                  // CSBuilder.cs:345
		public TCoding Code_SizeLessThanMRI = new TCoding(CorrespondsWithCodeSystemCS.Code_SizeLessThanMRI);                                      // CSBuilder.cs:345
		public TCoding Code_SizeLessThanPalp = new TCoding(CorrespondsWithCodeSystemCS.Code_SizeLessThanPalp);                                    // CSBuilder.cs:345
		public TCoding Code_SizeLessThanUS = new TCoding(CorrespondsWithCodeSystemCS.Code_SizeLessThanUS);                                        // CSBuilder.cs:345
		public TCoding Code_SizeGreaterThanMammo = new TCoding(CorrespondsWithCodeSystemCS.Code_SizeGreaterThanMammo);                            // CSBuilder.cs:345
		public TCoding Code_SizeGreaterThanMRI = new TCoding(CorrespondsWithCodeSystemCS.Code_SizeGreaterThanMRI);                                // CSBuilder.cs:345
		public TCoding Code_SizeGreaterThanPalp = new TCoding(CorrespondsWithCodeSystemCS.Code_SizeGreaterThanPalp);                              // CSBuilder.cs:345
		public TCoding Code_SkinMarker = new TCoding(CorrespondsWithCodeSystemCS.Code_SkinMarker);                                                // CSBuilder.cs:345
		public TCoding Code_Surgery = new TCoding(CorrespondsWithCodeSystemCS.Code_Surgery);                                                      // CSBuilder.cs:345
		public TCoding Code_SurgicalSite = new TCoding(CorrespondsWithCodeSystemCS.Code_SurgicalSite);                                            // CSBuilder.cs:345
		public TCoding Code_Tenderness = new TCoding(CorrespondsWithCodeSystemCS.Code_Tenderness);                                                // CSBuilder.cs:345
		public TCoding Code_TriggerPoint = new TCoding(CorrespondsWithCodeSystemCS.Code_TriggerPoint);                                            // CSBuilder.cs:345
		public TCoding Code_US = new TCoding(CorrespondsWithCodeSystemCS.Code_US);                                                                // CSBuilder.cs:345
		                                                                                                                                          // CSBuilder.cs:300
		public List<Coding> Members;                                                                                                              // CSBuilder.cs:301
		                                                                                                                                          // CSBuilder.cs:302
		public CorrespondsWithVS()                                                                                                                // CSBuilder.cs:303
		{                                                                                                                                         // CSBuilder.cs:304
		    this.Members = new List<Coding>();                                                                                                    // CSBuilder.cs:305
		    this.Members.Add(this.Code_Aspiration);                                                                                               // CSBuilder.cs:348
		    this.Members.Add(this.Code_Biopsy);                                                                                                   // CSBuilder.cs:348
		    this.Members.Add(this.Code_Concern);                                                                                                  // CSBuilder.cs:348
		    this.Members.Add(this.Code_Ductogram);                                                                                                // CSBuilder.cs:348
		    this.Members.Add(this.Code_IncidentalFinding);                                                                                        // CSBuilder.cs:348
		    this.Members.Add(this.Code_Mammo);                                                                                                    // CSBuilder.cs:348
		    this.Members.Add(this.Code_MRI);                                                                                                      // CSBuilder.cs:348
		    this.Members.Add(this.Code_NippleDischarge);                                                                                          // CSBuilder.cs:348
		    this.Members.Add(this.Code_OutsideExam);                                                                                              // CSBuilder.cs:348
		    this.Members.Add(this.Code_Pain);                                                                                                     // CSBuilder.cs:348
		    this.Members.Add(this.Code_Palpated);                                                                                                 // CSBuilder.cs:348
		    this.Members.Add(this.Code_PostOperative);                                                                                            // CSBuilder.cs:348
		    this.Members.Add(this.Code_PreviousBiopsy);                                                                                           // CSBuilder.cs:348
		    this.Members.Add(this.Code_PriorExam);                                                                                                // CSBuilder.cs:348
		    this.Members.Add(this.Code_Redness);                                                                                                  // CSBuilder.cs:348
		    this.Members.Add(this.Code_Scinti);                                                                                                   // CSBuilder.cs:348
		    this.Members.Add(this.Code_SizeLessThanMammo);                                                                                        // CSBuilder.cs:348
		    this.Members.Add(this.Code_SizeLessThanMRI);                                                                                          // CSBuilder.cs:348
		    this.Members.Add(this.Code_SizeLessThanPalp);                                                                                         // CSBuilder.cs:348
		    this.Members.Add(this.Code_SizeLessThanUS);                                                                                           // CSBuilder.cs:348
		    this.Members.Add(this.Code_SizeGreaterThanMammo);                                                                                     // CSBuilder.cs:348
		    this.Members.Add(this.Code_SizeGreaterThanMRI);                                                                                       // CSBuilder.cs:348
		    this.Members.Add(this.Code_SizeGreaterThanPalp);                                                                                      // CSBuilder.cs:348
		    this.Members.Add(this.Code_SkinMarker);                                                                                               // CSBuilder.cs:348
		    this.Members.Add(this.Code_Surgery);                                                                                                  // CSBuilder.cs:348
		    this.Members.Add(this.Code_SurgicalSite);                                                                                             // CSBuilder.cs:348
		    this.Members.Add(this.Code_Tenderness);                                                                                               // CSBuilder.cs:348
		    this.Members.Add(this.Code_TriggerPoint);                                                                                             // CSBuilder.cs:348
		    this.Members.Add(this.Code_US);                                                                                                       // CSBuilder.cs:348
		}                                                                                                                                         // CSBuilder.cs:307
		//- Fields
	}
}
