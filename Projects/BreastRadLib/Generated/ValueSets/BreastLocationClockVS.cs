using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class BreastLocationClockVS
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
		public static TCoding Code_1OClock = new TCoding(BreastLocationClockCS.Code_1OClock);                                                     // CSBuilder.cs:322
		public static TCoding Code_2OClock = new TCoding(BreastLocationClockCS.Code_2OClock);                                                     // CSBuilder.cs:322
		public static TCoding Code_3OClock = new TCoding(BreastLocationClockCS.Code_3OClock);                                                     // CSBuilder.cs:322
		public static TCoding Code_4OClock = new TCoding(BreastLocationClockCS.Code_4OClock);                                                     // CSBuilder.cs:322
		public static TCoding Code_5OClock = new TCoding(BreastLocationClockCS.Code_5OClock);                                                     // CSBuilder.cs:322
		public static TCoding Code_6OClock = new TCoding(BreastLocationClockCS.Code_6OClock);                                                     // CSBuilder.cs:322
		public static TCoding Code_7OClock = new TCoding(BreastLocationClockCS.Code_7OClock);                                                     // CSBuilder.cs:322
		public static TCoding Code_8OClock = new TCoding(BreastLocationClockCS.Code_8OClock);                                                     // CSBuilder.cs:322
		public static TCoding Code_9OClock = new TCoding(BreastLocationClockCS.Code_9OClock);                                                     // CSBuilder.cs:322
		public static TCoding Code_10OClock = new TCoding(BreastLocationClockCS.Code_10OClock);                                                   // CSBuilder.cs:322
		public static TCoding Code_11OClock = new TCoding(BreastLocationClockCS.Code_11OClock);                                                   // CSBuilder.cs:322
		public static TCoding Code_12OClock = new TCoding(BreastLocationClockCS.Code_12OClock);                                                   // CSBuilder.cs:322
		//- Fields

		//+ Methods
		public static IEnumerable<TCoding> Codes()                                                                                                // CSBuilder.cs:307
		{                                                                                                                                         // CSBuilder.cs:308
		    yield return Code_1OClock;                                                                                                            // CSBuilder.cs:325
		    yield return Code_2OClock;                                                                                                            // CSBuilder.cs:325
		    yield return Code_3OClock;                                                                                                            // CSBuilder.cs:325
		    yield return Code_4OClock;                                                                                                            // CSBuilder.cs:325
		    yield return Code_5OClock;                                                                                                            // CSBuilder.cs:325
		    yield return Code_6OClock;                                                                                                            // CSBuilder.cs:325
		    yield return Code_7OClock;                                                                                                            // CSBuilder.cs:325
		    yield return Code_8OClock;                                                                                                            // CSBuilder.cs:325
		    yield return Code_9OClock;                                                                                                            // CSBuilder.cs:325
		    yield return Code_10OClock;                                                                                                           // CSBuilder.cs:325
		    yield return Code_11OClock;                                                                                                           // CSBuilder.cs:325
		    yield return Code_12OClock;                                                                                                           // CSBuilder.cs:325
		}                                                                                                                                         // CSBuilder.cs:331
		//- Methods
	}
}
