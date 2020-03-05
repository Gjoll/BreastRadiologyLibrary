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
		/// Access Report
		/// </summary>
		TElementItemSectionSingle<BreastRadReport> Report { get ; }                                                                                // BuildElementItemSection.cs:67
		/// <summary>
		/// Access Impressions
		/// </summary>
		TElementItemSectionMultiple<ClinicalImpressionBase> Impressions { get ; }                                                                  // BuildElementItemSection.cs:67
		/// <summary>
		/// Access FindingsRightBreast
		/// </summary>
		TElementItemSectionSingle<SectionFindingsRightBreast> FindingsRightBreast { get ; }                                                        // BuildElementItemSection.cs:67
		/// <summary>
		/// Access FindingsLeftBreast
		/// </summary>
		TElementItemSectionSingle<SectionFindingsLeftBreast> FindingsLeftBreast { get ; }                                                          // BuildElementItemSection.cs:67
		/// <summary>
		/// Access RelatedResources
		/// </summary>
		TElementItemSectionMultiple<ResourceBase> RelatedResources { get ; }                                                                       // BuildElementItemSection.cs:67
		/// <summary>
		/// Access Recommendations
		/// </summary>
		TElementItemSectionMultiple<MedicationRequestBase, ServiceRequestBase, ServiceRecommendation> Recommendations { get ; }                    // BuildElementItemSection.cs:67
		//- Properties

		//+ Methods
		//- Methods
	}
}
