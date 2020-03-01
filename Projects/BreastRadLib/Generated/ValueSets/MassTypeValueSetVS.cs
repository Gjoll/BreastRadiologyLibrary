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
		public static TCoding Code_Mass = new TCoding(MassTypeCS.Code_Mass);                                                                      // Builder.cs:347
		public static TCoding Code_MassIntraductal = new TCoding(MassTypeCS.Code_MassIntraductal);                                                // Builder.cs:347
		public static TCoding Code_MassPartiallySolid = new TCoding(MassTypeCS.Code_MassPartiallySolid);                                          // Builder.cs:347
		public static TCoding Code_MassSkinATLASIsSkinLesion = new TCoding(MassTypeCS.Code_MassSkinATLASIsSkinLesion);                            // Builder.cs:347
		public static TCoding Code_MassSolid = new TCoding(MassTypeCS.Code_MassSolid);                                                            // Builder.cs:347
		//- Fields

		//+ Methods
		public static IEnumerable<TCoding> Codes()                                                                                                // Builder.cs:333
		{                                                                                                                                         // Builder.cs:334
		    yield return Code_Mass;                                                                                                               // Builder.cs:350
		    yield return Code_MassIntraductal;                                                                                                    // Builder.cs:350
		    yield return Code_MassPartiallySolid;                                                                                                 // Builder.cs:350
		    yield return Code_MassSkinATLASIsSkinLesion;                                                                                          // Builder.cs:350
		    yield return Code_MassSolid;                                                                                                          // Builder.cs:350
		}                                                                                                                                         // Builder.cs:356
		//- Methods
	}
}
