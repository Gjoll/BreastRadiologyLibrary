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
		BreastRadComposition.Report_Accessor Report { get ; }                                                                                     // CSDefineComposition.cs:256
		BreastRadComposition.Impressions_Accessor Impressions { get ; }                                                                           // CSDefineComposition.cs:256
		BreastRadComposition.RelatedResources_Accessor RelatedResources { get ; }                                                                 // CSDefineComposition.cs:256
		BreastRadComposition.Recommendations_Accessor Recommendations { get ; }                                                                   // CSDefineComposition.cs:256
		//- Fields

		//+ Methods
		//- Methods
	}
}
