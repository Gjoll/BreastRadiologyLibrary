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
		Report_Accessor Report { get ; }                                                                                                          // CSBuildMemberListSection.cs:233
		Impressions_Accessor Impressions { get ; }                                                                                                // CSBuildMemberListSection.cs:233
		FindingsRightBreast_Accessor FindingsRightBreast { get ; }                                                                                // CSBuildMemberListSection.cs:233
		FindingsLeftBreast_Accessor FindingsLeftBreast { get ; }                                                                                  // CSBuildMemberListSection.cs:233
		RelatedResources_Accessor RelatedResources { get ; }                                                                                      // CSBuildMemberListSection.cs:233
		Recommendations_Accessor Recommendations { get ; }                                                                                        // CSBuildMemberListSection.cs:233
		//- Fields

		//+ Methods
		//- Methods
	}
}
