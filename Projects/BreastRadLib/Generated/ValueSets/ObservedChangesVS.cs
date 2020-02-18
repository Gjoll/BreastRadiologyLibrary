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
		public static TCoding Code_DecreaseInCalcifications = new TCoding(ObservedChangesCS.Code_DecreaseInCalcifications);                       // CSBuilder.cs:321
		public static TCoding Code_DecreaseInNumber = new TCoding(ObservedChangesCS.Code_DecreaseInNumber);                                       // CSBuilder.cs:321
		public static TCoding Code_DecreaseInSize = new TCoding(ObservedChangesCS.Code_DecreaseInSize);                                           // CSBuilder.cs:321
		public static TCoding Code_IncreaseInCalcifications = new TCoding(ObservedChangesCS.Code_IncreaseInCalcifications);                       // CSBuilder.cs:321
		public static TCoding Code_IncreaseInNumber = new TCoding(ObservedChangesCS.Code_IncreaseInNumber);                                       // CSBuilder.cs:321
		public static TCoding Code_IncreaseInSize = new TCoding(ObservedChangesCS.Code_IncreaseInSize);                                           // CSBuilder.cs:321
		public static TCoding Code_LessProminent = new TCoding(ObservedChangesCS.Code_LessProminent);                                             // CSBuilder.cs:321
		public static TCoding Code_MoreProminent = new TCoding(ObservedChangesCS.Code_MoreProminent);                                             // CSBuilder.cs:321
		public static TCoding Code_New = new TCoding(ObservedChangesCS.Code_New);                                                                 // CSBuilder.cs:321
		public static TCoding Code_NoLongerSeen = new TCoding(ObservedChangesCS.Code_NoLongerSeen);                                               // CSBuilder.cs:321
		public static TCoding Code_NotSignificantChanged = new TCoding(ObservedChangesCS.Code_NotSignificantChanged);                             // CSBuilder.cs:321
		public static TCoding Code_PartiallyRemoved = new TCoding(ObservedChangesCS.Code_PartiallyRemoved);                                       // CSBuilder.cs:321
		public static TCoding Code_RepresentsChange = new TCoding(ObservedChangesCS.Code_RepresentsChange);                                       // CSBuilder.cs:321
		public static TCoding Code_Stable = new TCoding(ObservedChangesCS.Code_Stable);                                                           // CSBuilder.cs:321
		//- Fields

		//+ Methods
		public static IEnumerable<TCoding> Codes()                                                                                                // CSBuilder.cs:306
		{                                                                                                                                         // CSBuilder.cs:307
		    yield return Code_DecreaseInCalcifications;                                                                                           // CSBuilder.cs:324
		    yield return Code_DecreaseInNumber;                                                                                                   // CSBuilder.cs:324
		    yield return Code_DecreaseInSize;                                                                                                     // CSBuilder.cs:324
		    yield return Code_IncreaseInCalcifications;                                                                                           // CSBuilder.cs:324
		    yield return Code_IncreaseInNumber;                                                                                                   // CSBuilder.cs:324
		    yield return Code_IncreaseInSize;                                                                                                     // CSBuilder.cs:324
		    yield return Code_LessProminent;                                                                                                      // CSBuilder.cs:324
		    yield return Code_MoreProminent;                                                                                                      // CSBuilder.cs:324
		    yield return Code_New;                                                                                                                // CSBuilder.cs:324
		    yield return Code_NoLongerSeen;                                                                                                       // CSBuilder.cs:324
		    yield return Code_NotSignificantChanged;                                                                                              // CSBuilder.cs:324
		    yield return Code_PartiallyRemoved;                                                                                                   // CSBuilder.cs:324
		    yield return Code_RepresentsChange;                                                                                                   // CSBuilder.cs:324
		    yield return Code_Stable;                                                                                                             // CSBuilder.cs:324
		}                                                                                                                                         // CSBuilder.cs:330
		//- Methods
	}
}
