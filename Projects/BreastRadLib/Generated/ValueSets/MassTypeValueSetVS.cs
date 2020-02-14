using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class MassTypeValueSetVS
	{
		//+ Fields
		/// <summary>
		/// This class creates a type for codings of this class, that implicitly converts to Coding
		/// Allows type checking for these codes.
		/// </summary>
		public class TCoding                                                                                                                      // CSBuilder.cs:343
		{                                                                                                                                         // CSBuilder.cs:344
		    Coding value;                                                                                                                         // CSBuilder.cs:345
		    public static implicit operator Coding(TCoding tCode)                                                                                 // CSBuilder.cs:346
		    {                                                                                                                                     // CSBuilder.cs:347
		        return tCode.value;                                                                                                               // CSBuilder.cs:348
		    }                                                                                                                                     // CSBuilder.cs:349
		                                                                                                                                          // CSBuilder.cs:350
		    public TCoding(Coding value)                                                                                                          // CSBuilder.cs:351
		    {                                                                                                                                     // CSBuilder.cs:352
		        this.value= value;                                                                                                                // CSBuilder.cs:353
		    }                                                                                                                                     // CSBuilder.cs:354
		}                                                                                                                                         // CSBuilder.cs:355
		public TCoding Code_Mass = new TCoding(MassTypeCS.Code_Mass);                                                                             // CSBuilder.cs:373
		public TCoding Code_MassIntraductal = new TCoding(MassTypeCS.Code_MassIntraductal);                                                       // CSBuilder.cs:373
		public TCoding Code_MassPartiallySolid = new TCoding(MassTypeCS.Code_MassPartiallySolid);                                                 // CSBuilder.cs:373
		public TCoding Code_MassSkinATLASIsSkinLesion = new TCoding(MassTypeCS.Code_MassSkinATLASIsSkinLesion);                                   // CSBuilder.cs:373
		public TCoding Code_MassSolid = new TCoding(MassTypeCS.Code_MassSolid);                                                                   // CSBuilder.cs:373
		                                                                                                                                          // CSBuilder.cs:328
		public List<Coding> Members;                                                                                                              // CSBuilder.cs:329
		                                                                                                                                          // CSBuilder.cs:330
		public MassTypeValueSetVS()                                                                                                               // CSBuilder.cs:331
		{                                                                                                                                         // CSBuilder.cs:332
		    this.Members = new List<Coding>();                                                                                                    // CSBuilder.cs:333
		    this.Members.Add(this.Code_Mass);                                                                                                     // CSBuilder.cs:376
		    this.Members.Add(this.Code_MassIntraductal);                                                                                          // CSBuilder.cs:376
		    this.Members.Add(this.Code_MassPartiallySolid);                                                                                       // CSBuilder.cs:376
		    this.Members.Add(this.Code_MassSkinATLASIsSkinLesion);                                                                                // CSBuilder.cs:376
		    this.Members.Add(this.Code_MassSolid);                                                                                                // CSBuilder.cs:376
		}                                                                                                                                         // CSBuilder.cs:335
		//- Fields
	}
}
