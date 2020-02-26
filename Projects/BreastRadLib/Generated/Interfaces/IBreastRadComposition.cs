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
	/// <summary>
	/// Interface BreastRadComposition.
	/// This interface is automatically generated.
	/// </summary>
	public interface IBreastRadComposition : IHeaderFragment

	{
		//+ Properties
		/// <summary>
		/// Access Section value Report
		/// </summary>
		Report_Accessor Report { get ; }                                                                                                          // BuildMemberListBase.cs:40
		/// <summary>
		/// Access Section value Impressions
		/// </summary>
		Impressions_Accessor Impressions { get ; }                                                                                                // BuildMemberListBase.cs:40
		/// <summary>
		/// Access Section value FindingsRightBreast
		/// </summary>
		FindingsRightBreast_Accessor FindingsRightBreast { get ; }                                                                                // BuildMemberListBase.cs:40
		/// <summary>
		/// Access Section value FindingsLeftBreast
		/// </summary>
		FindingsLeftBreast_Accessor FindingsLeftBreast { get ; }                                                                                  // BuildMemberListBase.cs:40
		/// <summary>
		/// Access Section value RelatedResources
		/// </summary>
		RelatedResources_Accessor RelatedResources { get ; }                                                                                      // BuildMemberListBase.cs:40
		/// <summary>
		/// Access Section value Recommendations
		/// </summary>
		Recommendations_Accessor Recommendations { get ; }                                                                                        // BuildMemberListBase.cs:40
		//- Properties

		//+ Methods
		//- Methods
	}
}
