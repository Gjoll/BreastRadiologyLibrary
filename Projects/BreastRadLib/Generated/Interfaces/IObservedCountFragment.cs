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
	public interface IObservedCountFragment 
	{
		//+ Properties
		ObsCount_Accessor ObsCount { get ; }                                                                                                      // BuildMemberListBase.cs:29
		//- Properties

		//+ Methods
		//- Methods
	}
}
