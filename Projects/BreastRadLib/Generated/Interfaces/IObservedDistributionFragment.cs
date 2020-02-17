using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.ObservedDistributionFragmentLocal;

namespace BreastRadLib
{
	public interface IObservedDistributionFragment : IObservationBase
	{
		//+ LocalClassDefs
		//- LocalClassDefs

		//+ Fields
		ObsDistribution_Accessor ObsDistribution { get ; }                                                                                        // CSDefineObservation.cs:392
		ObsDistRegionSize_Accessor ObsDistRegionSize { get ; }                                                                                    // CSDefineObservation.cs:392
		//- Fields

		//+ Methods
		//- Methods
	}
}
