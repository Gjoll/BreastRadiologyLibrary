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
		// Called from BuildMemberComponents.cs, Line 179
		// BuildMemberBase.cs:341
		/// <summary>
		/// ObsDistribution
		/// </summary>
		ObsDistributionContainer ObsDistribution { get ; }                                                                                        // BuildMemberBase.cs:344
		// Called from BuildMemberComponents.cs, Line 179
		// BuildMemberBase.cs:341
		/// <summary>
		/// ObsDistRegionSize
		/// </summary>
		ObsDistRegionSizeContainer ObsDistRegionSize { get ; }                                                                                    // BuildMemberBase.cs:344
		//- Properties

		//+ Methods
		//- Methods
	}
}
