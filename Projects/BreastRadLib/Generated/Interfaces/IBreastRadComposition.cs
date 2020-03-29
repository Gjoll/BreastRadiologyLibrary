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
		// Called from BuildMemberSection.cs, Line 225
		// BuildMemberBase.cs:386
		/// <summary>
		/// Report
		/// </summary>
		MReport Report { get ; }                                                                                                                  // BuildMemberBase.cs:389
		// Called from BuildMemberSection.cs, Line 225
		// BuildMemberBase.cs:386
		/// <summary>
		/// Impressions
		/// </summary>
		MImpressions Impressions { get ; }                                                                                                        // BuildMemberBase.cs:389
		// Called from BuildMemberSection.cs, Line 225
		// BuildMemberBase.cs:386
		/// <summary>
		/// FindingsRightBreast
		/// </summary>
		MFindingsRightBreast FindingsRightBreast { get ; }                                                                                        // BuildMemberBase.cs:389
		// Called from BuildMemberSection.cs, Line 225
		// BuildMemberBase.cs:386
		/// <summary>
		/// FindingsLeftBreast
		/// </summary>
		MFindingsLeftBreast FindingsLeftBreast { get ; }                                                                                          // BuildMemberBase.cs:389
		// Called from BuildMemberSection.cs, Line 225
		// BuildMemberBase.cs:386
		/// <summary>
		/// RelatedResources
		/// </summary>
		MRelatedResources RelatedResources { get ; }                                                                                              // BuildMemberBase.cs:389
		// Called from BuildMemberSection.cs, Line 225
		// BuildMemberBase.cs:386
		/// <summary>
		/// Recommendations
		/// </summary>
		MRecommendations Recommendations { get ; }                                                                                                // BuildMemberBase.cs:389
		// Called from BuildMemberSection.cs, Line 225
		// BuildMemberBase.cs:386
		/// <summary>
		/// Admin
		/// </summary>
		MAdmin Admin { get ; }                                                                                                                    // BuildMemberBase.cs:389
		//- Properties

		//+ Methods
		//- Methods
	}
}
