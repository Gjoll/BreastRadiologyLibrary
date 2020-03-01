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
	/// <summary>
	/// Interface ObservedDistributionFragment.
	/// This interface is automatically generated.
	/// </summary>
	public interface IObservedDistributionFragment 
	{
		//+ Properties
		/// <summary>
		/// Access Component value ObsDistribution
		/// </summary>
		ObsDistribution_Accessor ObsDistribution { get ; }                                                                                        // BuildMemberListBase.cs:62
		/// <summary>
		/// Access Component value ObsDistRegionSize
		/// </summary>
		ObsDistRegionSize_Accessor ObsDistRegionSize { get ; }                                                                                    // BuildMemberListBase.cs:62
		//- Properties

		//+ Methods
		//- Methods
	}
}
