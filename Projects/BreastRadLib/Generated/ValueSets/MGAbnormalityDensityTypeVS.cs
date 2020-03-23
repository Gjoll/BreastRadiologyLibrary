using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class MGAbnormalityDensityTypeVS
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
		public static TCoding Code_Density = new TCoding(MGAbnormalityDensityTypeCS.Code_Density);                                                // Builder.cs:353
		public static TCoding Code_DensityFocalAsymmetry = new TCoding(MGAbnormalityDensityTypeCS.Code_DensityFocalAsymmetry);                    // Builder.cs:353
		public static TCoding Code_DensityNodular = new TCoding(MGAbnormalityDensityTypeCS.Code_DensityNodular);                                  // Builder.cs:353
		public static TCoding Code_DensityTubular = new TCoding(MGAbnormalityDensityTypeCS.Code_DensityTubular);                                  // Builder.cs:353
		//- Fields

		//+ Methods
		public static IEnumerable<TCoding> Codes()                                                                                                // Builder.cs:339
		{                                                                                                                                         // Builder.cs:340
		    yield return Code_Density;                                                                                                            // Builder.cs:356
		    yield return Code_DensityFocalAsymmetry;                                                                                              // Builder.cs:356
		    yield return Code_DensityNodular;                                                                                                     // Builder.cs:356
		    yield return Code_DensityTubular;                                                                                                     // Builder.cs:356
		}                                                                                                                                         // Builder.cs:362
		//- Methods
	}
}
