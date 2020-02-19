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
	public interface ITumorSatelliteFragment : IObservationBase, IHeaderFragment
	{
		//+ LocalClassDefs
		//- LocalClassDefs

		//+ Fields
		TumorSatellite_Accessor TumorSatellite { get ; }                                                                                          // CSDefineObservation.cs:316
		//- Fields

		//+ Methods
		//- Methods
	}
}
