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
		public static TCoding Code_Mass = new TCoding(MassTypeCS.Code_Mass);                                                                      // CSBuilder.cs:321
		public static TCoding Code_MassIntraductal = new TCoding(MassTypeCS.Code_MassIntraductal);                                                // CSBuilder.cs:321
		public static TCoding Code_MassPartiallySolid = new TCoding(MassTypeCS.Code_MassPartiallySolid);                                          // CSBuilder.cs:321
		public static TCoding Code_MassSkinATLASIsSkinLesion = new TCoding(MassTypeCS.Code_MassSkinATLASIsSkinLesion);                            // CSBuilder.cs:321
		public static TCoding Code_MassSolid = new TCoding(MassTypeCS.Code_MassSolid);                                                            // CSBuilder.cs:321
		//- Fields

		//+ Methods
		public static IEnumerable<TCoding> Codes()                                                                                                // CSBuilder.cs:306
		{                                                                                                                                         // CSBuilder.cs:307
		    yield return Code_Mass;                                                                                                               // CSBuilder.cs:324
		    yield return Code_MassIntraductal;                                                                                                    // CSBuilder.cs:324
		    yield return Code_MassPartiallySolid;                                                                                                 // CSBuilder.cs:324
		    yield return Code_MassSkinATLASIsSkinLesion;                                                                                          // CSBuilder.cs:324
		    yield return Code_MassSolid;                                                                                                          // CSBuilder.cs:324
		}                                                                                                                                         // CSBuilder.cs:330
		//- Methods
	}
}
