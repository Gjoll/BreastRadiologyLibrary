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
		public TCoding Code_DecreaseInCalcifications = new TCoding(ObservedChangesCS.Code_DecreaseInCalcifications);                              // CSBuilder.cs:345
		public TCoding Code_DecreaseInNumber = new TCoding(ObservedChangesCS.Code_DecreaseInNumber);                                              // CSBuilder.cs:345
		public TCoding Code_DecreaseInSize = new TCoding(ObservedChangesCS.Code_DecreaseInSize);                                                  // CSBuilder.cs:345
		public TCoding Code_IncreaseInCalcifications = new TCoding(ObservedChangesCS.Code_IncreaseInCalcifications);                              // CSBuilder.cs:345
		public TCoding Code_IncreaseInNumber = new TCoding(ObservedChangesCS.Code_IncreaseInNumber);                                              // CSBuilder.cs:345
		public TCoding Code_IncreaseInSize = new TCoding(ObservedChangesCS.Code_IncreaseInSize);                                                  // CSBuilder.cs:345
		public TCoding Code_LessProminent = new TCoding(ObservedChangesCS.Code_LessProminent);                                                    // CSBuilder.cs:345
		public TCoding Code_MoreProminent = new TCoding(ObservedChangesCS.Code_MoreProminent);                                                    // CSBuilder.cs:345
		public TCoding Code_New = new TCoding(ObservedChangesCS.Code_New);                                                                        // CSBuilder.cs:345
		public TCoding Code_NoLongerSeen = new TCoding(ObservedChangesCS.Code_NoLongerSeen);                                                      // CSBuilder.cs:345
		public TCoding Code_NotSignificantChanged = new TCoding(ObservedChangesCS.Code_NotSignificantChanged);                                    // CSBuilder.cs:345
		public TCoding Code_PartiallyRemoved = new TCoding(ObservedChangesCS.Code_PartiallyRemoved);                                              // CSBuilder.cs:345
		public TCoding Code_RepresentsChange = new TCoding(ObservedChangesCS.Code_RepresentsChange);                                              // CSBuilder.cs:345
		public TCoding Code_Stable = new TCoding(ObservedChangesCS.Code_Stable);                                                                  // CSBuilder.cs:345
		                                                                                                                                          // CSBuilder.cs:300
		public List<Coding> Members;                                                                                                              // CSBuilder.cs:301
		                                                                                                                                          // CSBuilder.cs:302
		public ObservedChangesVS()                                                                                                                // CSBuilder.cs:303
		{                                                                                                                                         // CSBuilder.cs:304
		    this.Members = new List<Coding>();                                                                                                    // CSBuilder.cs:305
		    this.Members.Add(this.Code_DecreaseInCalcifications);                                                                                 // CSBuilder.cs:348
		    this.Members.Add(this.Code_DecreaseInNumber);                                                                                         // CSBuilder.cs:348
		    this.Members.Add(this.Code_DecreaseInSize);                                                                                           // CSBuilder.cs:348
		    this.Members.Add(this.Code_IncreaseInCalcifications);                                                                                 // CSBuilder.cs:348
		    this.Members.Add(this.Code_IncreaseInNumber);                                                                                         // CSBuilder.cs:348
		    this.Members.Add(this.Code_IncreaseInSize);                                                                                           // CSBuilder.cs:348
		    this.Members.Add(this.Code_LessProminent);                                                                                            // CSBuilder.cs:348
		    this.Members.Add(this.Code_MoreProminent);                                                                                            // CSBuilder.cs:348
		    this.Members.Add(this.Code_New);                                                                                                      // CSBuilder.cs:348
		    this.Members.Add(this.Code_NoLongerSeen);                                                                                             // CSBuilder.cs:348
		    this.Members.Add(this.Code_NotSignificantChanged);                                                                                    // CSBuilder.cs:348
		    this.Members.Add(this.Code_PartiallyRemoved);                                                                                         // CSBuilder.cs:348
		    this.Members.Add(this.Code_RepresentsChange);                                                                                         // CSBuilder.cs:348
		    this.Members.Add(this.Code_Stable);                                                                                                   // CSBuilder.cs:348
		}                                                                                                                                         // CSBuilder.cs:307
		//- Fields
	}
}
