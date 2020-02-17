using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public interface IObservedDistributionFragment : IObservationBase
	{
		//+ Fields
		ObservedDistributionFragment.ObsDistribution_Accessor ObsDistribution { get ; }                                                           // CSDefineObservation.cs:374
		ObservedDistributionFragment.ObsDistRegionSize_Accessor ObsDistRegionSize { get ; }                                                       // CSDefineObservation.cs:374
		//- Fields

		//+ Methods
		//- Methods
	}
}
