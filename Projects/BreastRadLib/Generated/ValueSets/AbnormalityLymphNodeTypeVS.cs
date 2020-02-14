using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class AbnormalityLymphNodeTypeVS
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
		public TCoding Code_NodeAxillary = new TCoding(AbnormalityLymphNodeTypeCS.Code_NodeAxillary);                                             // CSBuilder.cs:345
		public TCoding Code_NodeEnlarged = new TCoding(AbnormalityLymphNodeTypeCS.Code_NodeEnlarged);                                             // CSBuilder.cs:345
		public TCoding Code_NodeFocalCortex = new TCoding(AbnormalityLymphNodeTypeCS.Code_NodeFocalCortex);                                       // CSBuilder.cs:345
		public TCoding Code_NodeInfraclavicular = new TCoding(AbnormalityLymphNodeTypeCS.Code_NodeInfraclavicular);                               // CSBuilder.cs:345
		public TCoding Code_NodeIntramammary = new TCoding(AbnormalityLymphNodeTypeCS.Code_NodeIntramammary);                                     // CSBuilder.cs:345
		public TCoding Code_NodeLymph = new TCoding(AbnormalityLymphNodeTypeCS.Code_NodeLymph);                                                   // CSBuilder.cs:345
		public TCoding Code_NodeLymphNormal = new TCoding(AbnormalityLymphNodeTypeCS.Code_NodeLymphNormal);                                       // CSBuilder.cs:345
		public TCoding Code_NodeSupraclavicular = new TCoding(AbnormalityLymphNodeTypeCS.Code_NodeSupraclavicular);                               // CSBuilder.cs:345
		public TCoding Code_NodeUniformThickness = new TCoding(AbnormalityLymphNodeTypeCS.Code_NodeUniformThickness);                             // CSBuilder.cs:345
		                                                                                                                                          // CSBuilder.cs:300
		public List<Coding> Members;                                                                                                              // CSBuilder.cs:301
		                                                                                                                                          // CSBuilder.cs:302
		public AbnormalityLymphNodeTypeVS()                                                                                                       // CSBuilder.cs:303
		{                                                                                                                                         // CSBuilder.cs:304
		    this.Members = new List<Coding>();                                                                                                    // CSBuilder.cs:305
		    this.Members.Add(this.Code_NodeAxillary);                                                                                             // CSBuilder.cs:348
		    this.Members.Add(this.Code_NodeEnlarged);                                                                                             // CSBuilder.cs:348
		    this.Members.Add(this.Code_NodeFocalCortex);                                                                                          // CSBuilder.cs:348
		    this.Members.Add(this.Code_NodeInfraclavicular);                                                                                      // CSBuilder.cs:348
		    this.Members.Add(this.Code_NodeIntramammary);                                                                                         // CSBuilder.cs:348
		    this.Members.Add(this.Code_NodeLymph);                                                                                                // CSBuilder.cs:348
		    this.Members.Add(this.Code_NodeLymphNormal);                                                                                          // CSBuilder.cs:348
		    this.Members.Add(this.Code_NodeSupraclavicular);                                                                                      // CSBuilder.cs:348
		    this.Members.Add(this.Code_NodeUniformThickness);                                                                                     // CSBuilder.cs:348
		}                                                                                                                                         // CSBuilder.cs:307
		//- Fields
	}
}
