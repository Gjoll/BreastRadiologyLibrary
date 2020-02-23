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
	public interface IObservedDistributionFragment 
	{
		//+ Properties
		ObsDistribution_Accessor ObsDistribution { get ; }                                                                                        // BuildMemberListBase.cs:29
		ObsDistRegionSize_Accessor ObsDistRegionSize { get ; }                                                                                    // BuildMemberListBase.cs:29
		//- Properties

		//+ Methods
		//- Methods
	}
}
