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
	public interface IBreastRadComposition : IHeaderFragment

	{
		//+ Properties
		Report_Accessor Report { get ; }                                                                                                          // BuildMemberListBase.cs:29
		Impressions_Accessor Impressions { get ; }                                                                                                // BuildMemberListBase.cs:29
		FindingsRightBreast_Accessor FindingsRightBreast { get ; }                                                                                // BuildMemberListBase.cs:29
		FindingsLeftBreast_Accessor FindingsLeftBreast { get ; }                                                                                  // BuildMemberListBase.cs:29
		RelatedResources_Accessor RelatedResources { get ; }                                                                                      // BuildMemberListBase.cs:29
		Recommendations_Accessor Recommendations { get ; }                                                                                        // BuildMemberListBase.cs:29
		//- Properties

		//+ Methods
		//- Methods
	}
}
