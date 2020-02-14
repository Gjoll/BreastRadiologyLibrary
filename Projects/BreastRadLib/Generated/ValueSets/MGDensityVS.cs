using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class MGDensityVS
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
		public TCoding Code_CentralLucent = new TCoding(MGDensityCS.Code_CentralLucent);                                                          // CSBuilder.cs:345
		public TCoding Code_EqualDensity = new TCoding(MGDensityCS.Code_EqualDensity);                                                            // CSBuilder.cs:345
		public TCoding Code_FatContaining = new TCoding(MGDensityCS.Code_FatContaining);                                                          // CSBuilder.cs:345
		public TCoding Code_HighDensity = new TCoding(MGDensityCS.Code_HighDensity);                                                              // CSBuilder.cs:345
		public TCoding Code_LowDensity = new TCoding(MGDensityCS.Code_LowDensity);                                                                // CSBuilder.cs:345
		                                                                                                                                          // CSBuilder.cs:300
		public List<Coding> Members;                                                                                                              // CSBuilder.cs:301
		                                                                                                                                          // CSBuilder.cs:302
		public MGDensityVS()                                                                                                                      // CSBuilder.cs:303
		{                                                                                                                                         // CSBuilder.cs:304
		    this.Members = new List<Coding>();                                                                                                    // CSBuilder.cs:305
		    this.Members.Add(this.Code_CentralLucent);                                                                                            // CSBuilder.cs:348
		    this.Members.Add(this.Code_EqualDensity);                                                                                             // CSBuilder.cs:348
		    this.Members.Add(this.Code_FatContaining);                                                                                            // CSBuilder.cs:348
		    this.Members.Add(this.Code_HighDensity);                                                                                              // CSBuilder.cs:348
		    this.Members.Add(this.Code_LowDensity);                                                                                               // CSBuilder.cs:348
		}                                                                                                                                         // CSBuilder.cs:307
		//- Fields
	}
}
