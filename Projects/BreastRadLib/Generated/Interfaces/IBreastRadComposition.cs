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
		// Called from BuildMemberSection.cs, Line 224
		// BuildMemberBase.cs:366
		/// <summary>
		/// Report
		/// </summary>
		ReportContainer Report { get ; }                                                                                                          // BuildMemberBase.cs:369
		// Called from BuildMemberSection.cs, Line 224
		// BuildMemberBase.cs:366
		/// <summary>
		/// Impressions
		/// </summary>
		ImpressionsContainer Impressions { get ; }                                                                                                // BuildMemberBase.cs:369
		// Called from BuildMemberSection.cs, Line 224
		// BuildMemberBase.cs:366
		/// <summary>
		/// FindingsRightBreast
		/// </summary>
		FindingsRightBreastContainer FindingsRightBreast { get ; }                                                                                // BuildMemberBase.cs:369
		// Called from BuildMemberSection.cs, Line 224
		// BuildMemberBase.cs:366
		/// <summary>
		/// FindingsLeftBreast
		/// </summary>
		FindingsLeftBreastContainer FindingsLeftBreast { get ; }                                                                                  // BuildMemberBase.cs:369
		// Called from BuildMemberSection.cs, Line 224
		// BuildMemberBase.cs:366
		/// <summary>
		/// RelatedResources
		/// </summary>
		RelatedResourcesContainer RelatedResources { get ; }                                                                                      // BuildMemberBase.cs:369
		// Called from BuildMemberSection.cs, Line 224
		// BuildMemberBase.cs:366
		/// <summary>
		/// Recommendations
		/// </summary>
		RecommendationsContainer Recommendations { get ; }                                                                                        // BuildMemberBase.cs:369
		//- Properties

		//+ Methods
		//- Methods
	}
}
