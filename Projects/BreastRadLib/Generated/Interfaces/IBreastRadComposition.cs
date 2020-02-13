using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public interface IBreastRadComposition : ICompositionBase, IHeaderFragment
	{
		//+ Fields
		BreastRadReport Report { get; set; }                                                                                                      // CSDefineComposition.cs:187
		List<ClinicalImpressionBase> Impressions { get; }                                                                                         // CSDefineComposition.cs:191
		List<ResourceBase> RelatedResources { get; }                                                                                              // CSDefineComposition.cs:191
		List<ServiceRecommendation> Recommendations { get; }                                                                                      // CSDefineComposition.cs:191
		//- Fields

		//+ Methods
		//- Methods
	}
}
