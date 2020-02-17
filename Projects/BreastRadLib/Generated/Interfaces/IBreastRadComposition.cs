using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.BreastRadCompositionLocal;

namespace BreastRadLib
{
	public interface IBreastRadComposition : ICompositionBase, IHeaderFragment
	{
		//+ LocalClassDefs
		//- LocalClassDefs

		//+ Fields
		Report_Accessor Report { get ; }                                                                                                          // CSDefineComposition.cs:232
		Impressions_Accessor Impressions { get ; }                                                                                                // CSDefineComposition.cs:232
		RelatedResources_Accessor RelatedResources { get ; }                                                                                      // CSDefineComposition.cs:232
		Recommendations_Accessor Recommendations { get ; }                                                                                        // CSDefineComposition.cs:232
		//- Fields

		//+ Methods
		//- Methods
	}
}
