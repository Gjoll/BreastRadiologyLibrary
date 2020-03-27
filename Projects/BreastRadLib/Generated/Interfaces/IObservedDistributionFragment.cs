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
		// Called from BuildMemberComponents.cs, Line 202
		// BuildMemberBase.cs:385
		/// <summary>
		/// ObsDistribution
		/// </summary>
		MObsDistribution ObsDistribution { get ; }                                                                                                // BuildMemberBase.cs:388
		// Called from BuildMemberComponents.cs, Line 202
		// BuildMemberBase.cs:385
		/// <summary>
		/// ObsDistRegionSize
		/// </summary>
		MObsDistRegionSize ObsDistRegionSize { get ; }                                                                                            // BuildMemberBase.cs:388
		//- Properties

		//+ Methods
		//- Methods
	}
}
