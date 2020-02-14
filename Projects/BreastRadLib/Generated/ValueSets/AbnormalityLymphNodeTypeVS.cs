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
		public class TCoding                                                                                                                      // CSBuilder.cs:343
		{                                                                                                                                         // CSBuilder.cs:344
		    Coding value;                                                                                                                         // CSBuilder.cs:345
		    public static implicit operator Coding(TCoding tCode)                                                                                 // CSBuilder.cs:346
		    {                                                                                                                                     // CSBuilder.cs:347
		        return tCode.value;                                                                                                               // CSBuilder.cs:348
		    }                                                                                                                                     // CSBuilder.cs:349
		                                                                                                                                          // CSBuilder.cs:350
		    public TCoding(Coding value)                                                                                                          // CSBuilder.cs:351
		    {                                                                                                                                     // CSBuilder.cs:352
		        this.value= value;                                                                                                                // CSBuilder.cs:353
		    }                                                                                                                                     // CSBuilder.cs:354
		}                                                                                                                                         // CSBuilder.cs:355
		public TCoding Code_NodeAxillary = new TCoding(AbnormalityLymphNodeTypeCS.Code_NodeAxillary);                                             // CSBuilder.cs:373
		public TCoding Code_NodeEnlarged = new TCoding(AbnormalityLymphNodeTypeCS.Code_NodeEnlarged);                                             // CSBuilder.cs:373
		public TCoding Code_NodeFocalCortex = new TCoding(AbnormalityLymphNodeTypeCS.Code_NodeFocalCortex);                                       // CSBuilder.cs:373
		public TCoding Code_NodeInfraclavicular = new TCoding(AbnormalityLymphNodeTypeCS.Code_NodeInfraclavicular);                               // CSBuilder.cs:373
		public TCoding Code_NodeIntramammary = new TCoding(AbnormalityLymphNodeTypeCS.Code_NodeIntramammary);                                     // CSBuilder.cs:373
		public TCoding Code_NodeLymph = new TCoding(AbnormalityLymphNodeTypeCS.Code_NodeLymph);                                                   // CSBuilder.cs:373
		public TCoding Code_NodeLymphNormal = new TCoding(AbnormalityLymphNodeTypeCS.Code_NodeLymphNormal);                                       // CSBuilder.cs:373
		public TCoding Code_NodeSupraclavicular = new TCoding(AbnormalityLymphNodeTypeCS.Code_NodeSupraclavicular);                               // CSBuilder.cs:373
		public TCoding Code_NodeUniformThickness = new TCoding(AbnormalityLymphNodeTypeCS.Code_NodeUniformThickness);                             // CSBuilder.cs:373
		                                                                                                                                          // CSBuilder.cs:328
		public List<Coding> Members;                                                                                                              // CSBuilder.cs:329
		                                                                                                                                          // CSBuilder.cs:330
		public AbnormalityLymphNodeTypeVS()                                                                                                       // CSBuilder.cs:331
		{                                                                                                                                         // CSBuilder.cs:332
		    this.Members = new List<Coding>();                                                                                                    // CSBuilder.cs:333
		    this.Members.Add(this.Code_NodeAxillary);                                                                                             // CSBuilder.cs:376
		    this.Members.Add(this.Code_NodeEnlarged);                                                                                             // CSBuilder.cs:376
		    this.Members.Add(this.Code_NodeFocalCortex);                                                                                          // CSBuilder.cs:376
		    this.Members.Add(this.Code_NodeInfraclavicular);                                                                                      // CSBuilder.cs:376
		    this.Members.Add(this.Code_NodeIntramammary);                                                                                         // CSBuilder.cs:376
		    this.Members.Add(this.Code_NodeLymph);                                                                                                // CSBuilder.cs:376
		    this.Members.Add(this.Code_NodeLymphNormal);                                                                                          // CSBuilder.cs:376
		    this.Members.Add(this.Code_NodeSupraclavicular);                                                                                      // CSBuilder.cs:376
		    this.Members.Add(this.Code_NodeUniformThickness);                                                                                     // CSBuilder.cs:376
		}                                                                                                                                         // CSBuilder.cs:335
		//- Fields
	}
}
