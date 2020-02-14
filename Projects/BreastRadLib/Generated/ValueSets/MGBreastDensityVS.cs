using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class MGBreastDensityVS
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
		public TCoding Code_AlmostEntirelyFat = new TCoding(MGBreastDensityCS.Code_AlmostEntirelyFat);                                            // CSBuilder.cs:345
		public TCoding Code_ScatteredAreasOfFibroglandularDensity = new TCoding(MGBreastDensityCS.Code_ScatteredAreasOfFibroglandularDensity);    // CSBuilder.cs:345
		public TCoding Code_HeterogeneouslyDense = new TCoding(MGBreastDensityCS.Code_HeterogeneouslyDense);                                      // CSBuilder.cs:345
		public TCoding Code_ExtremelyDense = new TCoding(MGBreastDensityCS.Code_ExtremelyDense);                                                  // CSBuilder.cs:345
		                                                                                                                                          // CSBuilder.cs:300
		public List<Coding> Members;                                                                                                              // CSBuilder.cs:301
		                                                                                                                                          // CSBuilder.cs:302
		public MGBreastDensityVS()                                                                                                                // CSBuilder.cs:303
		{                                                                                                                                         // CSBuilder.cs:304
		    this.Members = new List<Coding>();                                                                                                    // CSBuilder.cs:305
		    this.Members.Add(this.Code_AlmostEntirelyFat);                                                                                        // CSBuilder.cs:348
		    this.Members.Add(this.Code_ScatteredAreasOfFibroglandularDensity);                                                                    // CSBuilder.cs:348
		    this.Members.Add(this.Code_HeterogeneouslyDense);                                                                                     // CSBuilder.cs:348
		    this.Members.Add(this.Code_ExtremelyDense);                                                                                           // CSBuilder.cs:348
		}                                                                                                                                         // CSBuilder.cs:307
		//- Fields
	}
}
