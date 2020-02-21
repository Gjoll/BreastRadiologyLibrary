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
		//+ LocalClassDefs
		//- LocalClassDefs

		//+ Fields
		ObsDistribution_Accessor ObsDistribution { get ; }                                                                                        // CSBuildMemberListBase.cs:27
		ObsDistRegionSize_Accessor ObsDistRegionSize { get ; }                                                                                    // CSBuildMemberListBase.cs:27
		//- Fields

		//+ Methods
		//- Methods
	}
}
