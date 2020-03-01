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
		public static TCoding Code_Cyst = new TCoding(AbnormalityCystTypeCS.Code_Cyst);                                                           // Builder.cs:347
		public static TCoding Code_CystComplex = new TCoding(AbnormalityCystTypeCS.Code_CystComplex);                                             // Builder.cs:347
		public static TCoding Code_CystComplicated = new TCoding(AbnormalityCystTypeCS.Code_CystComplicated);                                     // Builder.cs:347
		public static TCoding Code_CystMicro = new TCoding(AbnormalityCystTypeCS.Code_CystMicro);                                                 // Builder.cs:347
		public static TCoding Code_CystOil = new TCoding(AbnormalityCystTypeCS.Code_CystOil);                                                     // Builder.cs:347
		public static TCoding Code_CystSimple = new TCoding(AbnormalityCystTypeCS.Code_CystSimple);                                               // Builder.cs:347
		public static TCoding Code_CystWithDebris = new TCoding(AbnormalityCystTypeCS.Code_CystWithDebris);                                       // Builder.cs:347
		//- Fields

		//+ Methods
		public static IEnumerable<TCoding> Codes()                                                                                                // Builder.cs:333
		{                                                                                                                                         // Builder.cs:334
		    yield return Code_Cyst;                                                                                                               // Builder.cs:350
		    yield return Code_CystComplex;                                                                                                        // Builder.cs:350
		    yield return Code_CystComplicated;                                                                                                    // Builder.cs:350
		    yield return Code_CystMicro;                                                                                                          // Builder.cs:350
		    yield return Code_CystOil;                                                                                                            // Builder.cs:350
		    yield return Code_CystSimple;                                                                                                         // Builder.cs:350
		    yield return Code_CystWithDebris;                                                                                                     // Builder.cs:350
		}                                                                                                                                         // Builder.cs:356
		//- Methods
	}
}
