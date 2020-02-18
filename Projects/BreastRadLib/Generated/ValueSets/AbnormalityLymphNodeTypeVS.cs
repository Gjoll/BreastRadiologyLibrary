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
		public static TCoding Code_NodeAxillary = new TCoding(AbnormalityLymphNodeTypeCS.Code_NodeAxillary);                                      // CSBuilder.cs:320
		public static TCoding Code_NodeEnlarged = new TCoding(AbnormalityLymphNodeTypeCS.Code_NodeEnlarged);                                      // CSBuilder.cs:320
		public static TCoding Code_NodeFocalCortex = new TCoding(AbnormalityLymphNodeTypeCS.Code_NodeFocalCortex);                                // CSBuilder.cs:320
		public static TCoding Code_NodeInfraclavicular = new TCoding(AbnormalityLymphNodeTypeCS.Code_NodeInfraclavicular);                        // CSBuilder.cs:320
		public static TCoding Code_NodeIntramammary = new TCoding(AbnormalityLymphNodeTypeCS.Code_NodeIntramammary);                              // CSBuilder.cs:320
		public static TCoding Code_NodeLymph = new TCoding(AbnormalityLymphNodeTypeCS.Code_NodeLymph);                                            // CSBuilder.cs:320
		public static TCoding Code_NodeLymphNormal = new TCoding(AbnormalityLymphNodeTypeCS.Code_NodeLymphNormal);                                // CSBuilder.cs:320
		public static TCoding Code_NodeSupraclavicular = new TCoding(AbnormalityLymphNodeTypeCS.Code_NodeSupraclavicular);                        // CSBuilder.cs:320
		public static TCoding Code_NodeUniformThickness = new TCoding(AbnormalityLymphNodeTypeCS.Code_NodeUniformThickness);                      // CSBuilder.cs:320
		//- Fields

		//+ Methods
		public static IEnumerable<TCoding> Codes()                                                                                                // CSBuilder.cs:305
		{                                                                                                                                         // CSBuilder.cs:306
		    yield return Code_NodeAxillary;                                                                                                       // CSBuilder.cs:323
		    yield return Code_NodeEnlarged;                                                                                                       // CSBuilder.cs:323
		    yield return Code_NodeFocalCortex;                                                                                                    // CSBuilder.cs:323
		    yield return Code_NodeInfraclavicular;                                                                                                // CSBuilder.cs:323
		    yield return Code_NodeIntramammary;                                                                                                   // CSBuilder.cs:323
		    yield return Code_NodeLymph;                                                                                                          // CSBuilder.cs:323
		    yield return Code_NodeLymphNormal;                                                                                                    // CSBuilder.cs:323
		    yield return Code_NodeSupraclavicular;                                                                                                // CSBuilder.cs:323
		    yield return Code_NodeUniformThickness;                                                                                               // CSBuilder.cs:323
		}                                                                                                                                         // CSBuilder.cs:329
		//- Methods
	}
}
