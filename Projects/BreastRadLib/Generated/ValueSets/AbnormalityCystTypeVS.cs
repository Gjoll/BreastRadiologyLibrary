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
	public class AbnormalityCystTypeVS                                                                                                         // CSBuilder.cs:344
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
		public TCoding Code_Cyst = new TCoding(AbnormalityCystTypeCS.Code_Cyst);                                                                  // CSBuilder.cs:395
		public TCoding Code_CystComplex = new TCoding(AbnormalityCystTypeCS.Code_CystComplex);                                                    // CSBuilder.cs:395
		public TCoding Code_CystComplicated = new TCoding(AbnormalityCystTypeCS.Code_CystComplicated);                                            // CSBuilder.cs:395
		public TCoding Code_CystMicro = new TCoding(AbnormalityCystTypeCS.Code_CystMicro);                                                        // CSBuilder.cs:395
		public TCoding Code_CystOil = new TCoding(AbnormalityCystTypeCS.Code_CystOil);                                                            // CSBuilder.cs:395
		public TCoding Code_CystSimple = new TCoding(AbnormalityCystTypeCS.Code_CystSimple);                                                      // CSBuilder.cs:395
		public TCoding Code_CystWithDebris = new TCoding(AbnormalityCystTypeCS.Code_CystWithDebris);                                              // CSBuilder.cs:395
		                                                                                                                                          // CSBuilder.cs:350
		public List<Coding> Members;                                                                                                              // CSBuilder.cs:351
		                                                                                                                                          // CSBuilder.cs:352
		public AbnormalityCystTypeVS()                                                                                                            // CSBuilder.cs:353
		{                                                                                                                                         // CSBuilder.cs:354
		    this.Members = new List<Coding>();                                                                                                    // CSBuilder.cs:355
		    this.Members.Add(this.Code_Cyst);                                                                                                     // CSBuilder.cs:398
		    this.Members.Add(this.Code_CystComplex);                                                                                              // CSBuilder.cs:398
		    this.Members.Add(this.Code_CystComplicated);                                                                                          // CSBuilder.cs:398
		    this.Members.Add(this.Code_CystMicro);                                                                                                // CSBuilder.cs:398
		    this.Members.Add(this.Code_CystOil);                                                                                                  // CSBuilder.cs:398
		    this.Members.Add(this.Code_CystSimple);                                                                                               // CSBuilder.cs:398
		    this.Members.Add(this.Code_CystWithDebris);                                                                                           // CSBuilder.cs:398
		}                                                                                                                                         // CSBuilder.cs:357
		//- Fields
	}
}
