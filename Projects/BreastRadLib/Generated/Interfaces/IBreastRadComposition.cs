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
	public interface IBreastRadComposition
	{
		//+ LocalClassDefs
		//- LocalClassDefs

		//+ Fields
		Report_Accessor Report { get ; }                                                                                                          // CSBuildMemberListBase.cs:27
		Impressions_Accessor Impressions { get ; }                                                                                                // CSBuildMemberListBase.cs:27
		FindingsRightBreast_Accessor FindingsRightBreast { get ; }                                                                                // CSBuildMemberListBase.cs:27
		FindingsLeftBreast_Accessor FindingsLeftBreast { get ; }                                                                                  // CSBuildMemberListBase.cs:27
		RelatedResources_Accessor RelatedResources { get ; }                                                                                      // CSBuildMemberListBase.cs:27
		Recommendations_Accessor Recommendations { get ; }                                                                                        // CSBuildMemberListBase.cs:27
		//- Fields

		//+ Methods
		//- Methods
	}
}
