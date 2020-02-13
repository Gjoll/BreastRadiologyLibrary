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
		BreastRadReport Report { get; set; }                                                                                                      // CSDefineComposition.cs:216
		List<ResourceBase> Impressions { get; }                                                                                                   // CSDefineComposition.cs:220
		List<ResourceBase> RelatedResources { get; }                                                                                              // CSDefineComposition.cs:220
		List<ResourceBase> Recommendations { get; }                                                                                               // CSDefineComposition.cs:220
		//- Fields

		//+ Methods
		//- Methods
	}
}
