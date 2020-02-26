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
		public static TCoding Code_NodeAxillary = new TCoding(AbnormalityLymphNodeTypeCS.Code_NodeAxillary);                                      // Builder.cs:344
		public static TCoding Code_NodeEnlarged = new TCoding(AbnormalityLymphNodeTypeCS.Code_NodeEnlarged);                                      // Builder.cs:344
		public static TCoding Code_NodeFocalCortex = new TCoding(AbnormalityLymphNodeTypeCS.Code_NodeFocalCortex);                                // Builder.cs:344
		public static TCoding Code_NodeInfraclavicular = new TCoding(AbnormalityLymphNodeTypeCS.Code_NodeInfraclavicular);                        // Builder.cs:344
		public static TCoding Code_NodeIntramammary = new TCoding(AbnormalityLymphNodeTypeCS.Code_NodeIntramammary);                              // Builder.cs:344
		public static TCoding Code_NodeLymph = new TCoding(AbnormalityLymphNodeTypeCS.Code_NodeLymph);                                            // Builder.cs:344
		public static TCoding Code_NodeLymphNormal = new TCoding(AbnormalityLymphNodeTypeCS.Code_NodeLymphNormal);                                // Builder.cs:344
		public static TCoding Code_NodeSupraclavicular = new TCoding(AbnormalityLymphNodeTypeCS.Code_NodeSupraclavicular);                        // Builder.cs:344
		public static TCoding Code_NodeUniformThickness = new TCoding(AbnormalityLymphNodeTypeCS.Code_NodeUniformThickness);                      // Builder.cs:344
		//- Fields

		//+ Methods
		public static IEnumerable<TCoding> Codes()                                                                                                // Builder.cs:330
		{                                                                                                                                         // Builder.cs:331
		    yield return Code_NodeAxillary;                                                                                                       // Builder.cs:347
		    yield return Code_NodeEnlarged;                                                                                                       // Builder.cs:347
		    yield return Code_NodeFocalCortex;                                                                                                    // Builder.cs:347
		    yield return Code_NodeInfraclavicular;                                                                                                // Builder.cs:347
		    yield return Code_NodeIntramammary;                                                                                                   // Builder.cs:347
		    yield return Code_NodeLymph;                                                                                                          // Builder.cs:347
		    yield return Code_NodeLymphNormal;                                                                                                    // Builder.cs:347
		    yield return Code_NodeSupraclavicular;                                                                                                // Builder.cs:347
		    yield return Code_NodeUniformThickness;                                                                                               // Builder.cs:347
		}                                                                                                                                         // Builder.cs:353
		//- Methods
	}
}
