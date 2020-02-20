using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.ObservedCountFragmentLocal;

namespace BreastRadLib
{
	public interface IObservedCountFragment : IObservationBase
	{
		//+ LocalClassDefs
		//- LocalClassDefs

		//+ Fields
		ObsCount_Accessor ObsCount { get ; }                                                                                                      // CSBuildMemberListBase.cs:34
		//- Fields

		//+ Methods
		//- Methods
	}
}
