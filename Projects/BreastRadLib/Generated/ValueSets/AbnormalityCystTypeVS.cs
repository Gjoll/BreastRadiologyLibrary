using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class AbnormalityCystTypeVS
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
		public TCoding Code_Cyst = new TCoding(AbnormalityCystTypeCS.Code_Cyst);                                                                  // CSBuilder.cs:345
		public TCoding Code_CystComplex = new TCoding(AbnormalityCystTypeCS.Code_CystComplex);                                                    // CSBuilder.cs:345
		public TCoding Code_CystComplicated = new TCoding(AbnormalityCystTypeCS.Code_CystComplicated);                                            // CSBuilder.cs:345
		public TCoding Code_CystMicro = new TCoding(AbnormalityCystTypeCS.Code_CystMicro);                                                        // CSBuilder.cs:345
		public TCoding Code_CystOil = new TCoding(AbnormalityCystTypeCS.Code_CystOil);                                                            // CSBuilder.cs:345
		public TCoding Code_CystSimple = new TCoding(AbnormalityCystTypeCS.Code_CystSimple);                                                      // CSBuilder.cs:345
		public TCoding Code_CystWithDebris = new TCoding(AbnormalityCystTypeCS.Code_CystWithDebris);                                              // CSBuilder.cs:345
		                                                                                                                                          // CSBuilder.cs:300
		public List<Coding> Members;                                                                                                              // CSBuilder.cs:301
		                                                                                                                                          // CSBuilder.cs:302
		public AbnormalityCystTypeVS()                                                                                                            // CSBuilder.cs:303
		{                                                                                                                                         // CSBuilder.cs:304
		    this.Members = new List<Coding>();                                                                                                    // CSBuilder.cs:305
		    this.Members.Add(this.Code_Cyst);                                                                                                     // CSBuilder.cs:348
		    this.Members.Add(this.Code_CystComplex);                                                                                              // CSBuilder.cs:348
		    this.Members.Add(this.Code_CystComplicated);                                                                                          // CSBuilder.cs:348
		    this.Members.Add(this.Code_CystMicro);                                                                                                // CSBuilder.cs:348
		    this.Members.Add(this.Code_CystOil);                                                                                                  // CSBuilder.cs:348
		    this.Members.Add(this.Code_CystSimple);                                                                                               // CSBuilder.cs:348
		    this.Members.Add(this.Code_CystWithDebris);                                                                                           // CSBuilder.cs:348
		}                                                                                                                                         // CSBuilder.cs:307
		//- Fields
	}
}
