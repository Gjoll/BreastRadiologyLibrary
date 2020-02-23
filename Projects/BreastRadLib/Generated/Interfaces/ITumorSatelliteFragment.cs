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
	public interface ITumorSatelliteFragment : IHeaderFragment

	{
		//+ Properties
		TumorSatellite_Accessor TumorSatellite { get ; }                                                                                          // BuildMemberListBase.cs:29
		//- Properties

		//+ Methods
		//- Methods
	}
}
