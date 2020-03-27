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
		// Called from BuildMemberSection.cs, Line 222
		// BuildMemberBase.cs:385
		/// <summary>
		/// Report
		/// </summary>
		MReport Report { get ; }                                                                                                                  // BuildMemberBase.cs:388
		// Called from BuildMemberSection.cs, Line 222
		// BuildMemberBase.cs:385
		/// <summary>
		/// Impressions
		/// </summary>
		MImpressions Impressions { get ; }                                                                                                        // BuildMemberBase.cs:388
		// Called from BuildMemberSection.cs, Line 222
		// BuildMemberBase.cs:385
		/// <summary>
		/// FindingsRightBreast
		/// </summary>
		MFindingsRightBreast FindingsRightBreast { get ; }                                                                                        // BuildMemberBase.cs:388
		// Called from BuildMemberSection.cs, Line 222
		// BuildMemberBase.cs:385
		/// <summary>
		/// FindingsLeftBreast
		/// </summary>
		MFindingsLeftBreast FindingsLeftBreast { get ; }                                                                                          // BuildMemberBase.cs:388
		// Called from BuildMemberSection.cs, Line 222
		// BuildMemberBase.cs:385
		/// <summary>
		/// RelatedResources
		/// </summary>
		MRelatedResources RelatedResources { get ; }                                                                                              // BuildMemberBase.cs:388
		// Called from BuildMemberSection.cs, Line 222
		// BuildMemberBase.cs:385
		/// <summary>
		/// Recommendations
		/// </summary>
		MRecommendations Recommendations { get ; }                                                                                                // BuildMemberBase.cs:388
		// Called from BuildMemberSection.cs, Line 222
		// BuildMemberBase.cs:385
		/// <summary>
		/// Admin
		/// </summary>
		MAdmin Admin { get ; }                                                                                                                    // BuildMemberBase.cs:388
		//- Properties

		//+ Methods
		//- Methods
	}
}
