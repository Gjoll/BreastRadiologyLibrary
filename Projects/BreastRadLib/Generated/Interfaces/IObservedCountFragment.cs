using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public interface IObservedCountFragment : IObservationBase
	{
		//+ Fields
		ObservedCountFragment.ObsCount_Accessor ObsCount { get ; }                                                                                // CSDefineObservation.cs:374
		//- Fields

		//+ Methods
		//- Methods
	}
}
