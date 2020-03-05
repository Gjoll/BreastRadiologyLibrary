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
		TItemSectionSingle<BreastRadReport> Report { get ; }                                                                                      // BuildElementItemSection.cs:67
		/// <summary>
		/// Access Impressions
		/// </summary>
		TItemSectionMultiple<ClinicalImpressionBase> Impressions { get ; }                                                                        // BuildElementItemSection.cs:67
		/// <summary>
		/// Access FindingsRightBreast
		/// </summary>
		TItemSectionSingle<SectionFindingsRightBreast> FindingsRightBreast { get ; }                                                              // BuildElementItemSection.cs:67
		/// <summary>
		/// Access FindingsLeftBreast
		/// </summary>
		TItemSectionSingle<SectionFindingsLeftBreast> FindingsLeftBreast { get ; }                                                                // BuildElementItemSection.cs:67
		/// <summary>
		/// Access RelatedResources
		/// </summary>
		TItemSectionMultiple<ResourceBase> RelatedResources { get ; }                                                                             // BuildElementItemSection.cs:67
		/// <summary>
		/// Access Recommendations
		/// </summary>
		TItemSectionMultiple<MedicationRequestBase, ServiceRequestBase, ServiceRecommendation> Recommendations { get ; }                          // BuildElementItemSection.cs:67
		//- Properties

		//+ Methods
		//- Methods
	}
}
