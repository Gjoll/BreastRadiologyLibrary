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
		Report_Accessor Report { get ; }                                                                                                          // CSDefineComposition.cs:230
		Impressions_Accessor Impressions { get ; }                                                                                                // CSDefineComposition.cs:230
		FindingsRightBreast_Accessor FindingsRightBreast { get ; }                                                                                // CSDefineComposition.cs:230
		FindingsLeftBreast_Accessor FindingsLeftBreast { get ; }                                                                                  // CSDefineComposition.cs:230
		RelatedResources_Accessor RelatedResources { get ; }                                                                                      // CSDefineComposition.cs:230
		Recommendations_Accessor Recommendations { get ; }                                                                                        // CSDefineComposition.cs:230
		//- Fields

		//+ Methods
		//- Methods
	}
}
