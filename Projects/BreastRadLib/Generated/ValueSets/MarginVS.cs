using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class MarginVS
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
		public TCoding Code_AngularMargin = new TCoding(MarginCS.Code_AngularMargin);                                                             // CSBuilder.cs:345
		public TCoding Code_CircumscribedMargin = new TCoding(MarginCS.Code_CircumscribedMargin);                                                 // CSBuilder.cs:345
		public TCoding Code_IndistinctMargin = new TCoding(MarginCS.Code_IndistinctMargin);                                                       // CSBuilder.cs:345
		public TCoding Code_IntraductalExtension = new TCoding(MarginCS.Code_IntraductalExtension);                                               // CSBuilder.cs:345
		public TCoding Code_IrregularMargin = new TCoding(MarginCS.Code_IrregularMargin);                                                         // CSBuilder.cs:345
		public TCoding Code_LobulatedMargin = new TCoding(MarginCS.Code_LobulatedMargin);                                                         // CSBuilder.cs:345
		public TCoding Code_MacrolobulatedMargin = new TCoding(MarginCS.Code_MacrolobulatedMargin);                                               // CSBuilder.cs:345
		public TCoding Code_MicrolobulatedMargin = new TCoding(MarginCS.Code_MicrolobulatedMargin);                                               // CSBuilder.cs:345
		public TCoding Code_NonCircumscribedMargin = new TCoding(MarginCS.Code_NonCircumscribedMargin);                                           // CSBuilder.cs:345
		public TCoding Code_ObscuredMagin = new TCoding(MarginCS.Code_ObscuredMagin);                                                             // CSBuilder.cs:345
		public TCoding Code_SmoothMargin = new TCoding(MarginCS.Code_SmoothMargin);                                                               // CSBuilder.cs:345
		public TCoding Code_SpiculatedMargin = new TCoding(MarginCS.Code_SpiculatedMargin);                                                       // CSBuilder.cs:345
		                                                                                                                                          // CSBuilder.cs:300
		public List<Coding> Members;                                                                                                              // CSBuilder.cs:301
		                                                                                                                                          // CSBuilder.cs:302
		public MarginVS()                                                                                                                         // CSBuilder.cs:303
		{                                                                                                                                         // CSBuilder.cs:304
		    this.Members = new List<Coding>();                                                                                                    // CSBuilder.cs:305
		    this.Members.Add(this.Code_AngularMargin);                                                                                            // CSBuilder.cs:348
		    this.Members.Add(this.Code_CircumscribedMargin);                                                                                      // CSBuilder.cs:348
		    this.Members.Add(this.Code_IndistinctMargin);                                                                                         // CSBuilder.cs:348
		    this.Members.Add(this.Code_IntraductalExtension);                                                                                     // CSBuilder.cs:348
		    this.Members.Add(this.Code_IrregularMargin);                                                                                          // CSBuilder.cs:348
		    this.Members.Add(this.Code_LobulatedMargin);                                                                                          // CSBuilder.cs:348
		    this.Members.Add(this.Code_MacrolobulatedMargin);                                                                                     // CSBuilder.cs:348
		    this.Members.Add(this.Code_MicrolobulatedMargin);                                                                                     // CSBuilder.cs:348
		    this.Members.Add(this.Code_NonCircumscribedMargin);                                                                                   // CSBuilder.cs:348
		    this.Members.Add(this.Code_ObscuredMagin);                                                                                            // CSBuilder.cs:348
		    this.Members.Add(this.Code_SmoothMargin);                                                                                             // CSBuilder.cs:348
		    this.Members.Add(this.Code_SpiculatedMargin);                                                                                         // CSBuilder.cs:348
		}                                                                                                                                         // CSBuilder.cs:307
		//- Fields
	}
}
