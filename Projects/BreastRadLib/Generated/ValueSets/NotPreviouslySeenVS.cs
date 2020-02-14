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
		public TCoding Code_ClinicalExam = new TCoding(NotPreviouslySeenCodeSystemCS.Code_ClinicalExam);                                          // CSBuilder.cs:345
		public TCoding Code_Ductogram = new TCoding(NotPreviouslySeenCodeSystemCS.Code_Ductogram);                                                // CSBuilder.cs:345
		public TCoding Code_Mammogram = new TCoding(NotPreviouslySeenCodeSystemCS.Code_Mammogram);                                                // CSBuilder.cs:345
		public TCoding Code_MRI = new TCoding(NotPreviouslySeenCodeSystemCS.Code_MRI);                                                            // CSBuilder.cs:345
		public TCoding Code_OutsideExam = new TCoding(NotPreviouslySeenCodeSystemCS.Code_OutsideExam);                                            // CSBuilder.cs:345
		public TCoding Code_Scintimammography = new TCoding(NotPreviouslySeenCodeSystemCS.Code_Scintimammography);                                // CSBuilder.cs:345
		public TCoding Code_Ultrasound = new TCoding(NotPreviouslySeenCodeSystemCS.Code_Ultrasound);                                              // CSBuilder.cs:345
		                                                                                                                                          // CSBuilder.cs:300
		public List<Coding> Members;                                                                                                              // CSBuilder.cs:301
		                                                                                                                                          // CSBuilder.cs:302
		public NotPreviouslySeenVS()                                                                                                              // CSBuilder.cs:303
		{                                                                                                                                         // CSBuilder.cs:304
		    this.Members = new List<Coding>();                                                                                                    // CSBuilder.cs:305
		    this.Members.Add(this.Code_ClinicalExam);                                                                                             // CSBuilder.cs:348
		    this.Members.Add(this.Code_Ductogram);                                                                                                // CSBuilder.cs:348
		    this.Members.Add(this.Code_Mammogram);                                                                                                // CSBuilder.cs:348
		    this.Members.Add(this.Code_MRI);                                                                                                      // CSBuilder.cs:348
		    this.Members.Add(this.Code_OutsideExam);                                                                                              // CSBuilder.cs:348
		    this.Members.Add(this.Code_Scintimammography);                                                                                        // CSBuilder.cs:348
		    this.Members.Add(this.Code_Ultrasound);                                                                                               // CSBuilder.cs:348
		}                                                                                                                                         // CSBuilder.cs:307
		//- Fields
	}
}
