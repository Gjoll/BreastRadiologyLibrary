using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.TumorSatelliteFragmentLocal;

namespace BreastRadLib
{
	/// <summary>
	/// Interface TumorSatelliteFragment.
	/// This interface is automatically generated.
	/// </summary>
	public interface ITumorSatelliteFragment : IHeaderFragment

	{
		//+ Properties
		// Called from BuildMemberReferences.cs, Line 176
		// BuildMemberBase.cs:341
		/// <summary>
		/// TumorSatellite
		/// </summary>
		TumorSatelliteContainer TumorSatellite { get ; }                                                                                          // BuildMemberBase.cs:344
		//- Properties

		//+ Methods
		//- Methods
	}
}
