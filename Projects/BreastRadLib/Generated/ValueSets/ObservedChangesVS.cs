using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class ObservedChangesVS
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
		public static TCoding Code_DecreaseInCalcifications = new TCoding(ObservedChangesCS.Code_DecreaseInCalcifications);                       // Builder.cs:344
		public static TCoding Code_DecreaseInNumber = new TCoding(ObservedChangesCS.Code_DecreaseInNumber);                                       // Builder.cs:344
		public static TCoding Code_DecreaseInSize = new TCoding(ObservedChangesCS.Code_DecreaseInSize);                                           // Builder.cs:344
		public static TCoding Code_IncreaseInCalcifications = new TCoding(ObservedChangesCS.Code_IncreaseInCalcifications);                       // Builder.cs:344
		public static TCoding Code_IncreaseInNumber = new TCoding(ObservedChangesCS.Code_IncreaseInNumber);                                       // Builder.cs:344
		public static TCoding Code_IncreaseInSize = new TCoding(ObservedChangesCS.Code_IncreaseInSize);                                           // Builder.cs:344
		public static TCoding Code_LessProminent = new TCoding(ObservedChangesCS.Code_LessProminent);                                             // Builder.cs:344
		public static TCoding Code_MoreProminent = new TCoding(ObservedChangesCS.Code_MoreProminent);                                             // Builder.cs:344
		public static TCoding Code_New = new TCoding(ObservedChangesCS.Code_New);                                                                 // Builder.cs:344
		public static TCoding Code_NoLongerSeen = new TCoding(ObservedChangesCS.Code_NoLongerSeen);                                               // Builder.cs:344
		public static TCoding Code_NotSignificantChanged = new TCoding(ObservedChangesCS.Code_NotSignificantChanged);                             // Builder.cs:344
		public static TCoding Code_PartiallyRemoved = new TCoding(ObservedChangesCS.Code_PartiallyRemoved);                                       // Builder.cs:344
		public static TCoding Code_RepresentsChange = new TCoding(ObservedChangesCS.Code_RepresentsChange);                                       // Builder.cs:344
		public static TCoding Code_Stable = new TCoding(ObservedChangesCS.Code_Stable);                                                           // Builder.cs:344
		//- Fields

		//+ Methods
		public static IEnumerable<TCoding> Codes()                                                                                                // Builder.cs:330
		{                                                                                                                                         // Builder.cs:331
		    yield return Code_DecreaseInCalcifications;                                                                                           // Builder.cs:347
		    yield return Code_DecreaseInNumber;                                                                                                   // Builder.cs:347
		    yield return Code_DecreaseInSize;                                                                                                     // Builder.cs:347
		    yield return Code_IncreaseInCalcifications;                                                                                           // Builder.cs:347
		    yield return Code_IncreaseInNumber;                                                                                                   // Builder.cs:347
		    yield return Code_IncreaseInSize;                                                                                                     // Builder.cs:347
		    yield return Code_LessProminent;                                                                                                      // Builder.cs:347
		    yield return Code_MoreProminent;                                                                                                      // Builder.cs:347
		    yield return Code_New;                                                                                                                // Builder.cs:347
		    yield return Code_NoLongerSeen;                                                                                                       // Builder.cs:347
		    yield return Code_NotSignificantChanged;                                                                                              // Builder.cs:347
		    yield return Code_PartiallyRemoved;                                                                                                   // Builder.cs:347
		    yield return Code_RepresentsChange;                                                                                                   // Builder.cs:347
		    yield return Code_Stable;                                                                                                             // Builder.cs:347
		}                                                                                                                                         // Builder.cs:353
		//- Methods
	}
}
