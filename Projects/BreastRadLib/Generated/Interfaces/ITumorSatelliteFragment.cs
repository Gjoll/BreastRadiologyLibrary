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
		// Called from BuildMemberReferences.cs, Line 199
		// BuildMemberBase.cs:366
		/// <summary>
		/// TumorSatellite
		/// </summary>
		TumorSatelliteContainer TumorSatellite { get ; }                                                                                          // BuildMemberBase.cs:369
		//- Properties

		//+ Methods
		//- Methods
	}
}
