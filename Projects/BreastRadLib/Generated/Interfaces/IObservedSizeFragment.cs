using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.ObservedSizeFragmentLocal;

namespace BreastRadLib
{
	public interface IObservedSizeFragment : IObservationBase
	{
		//+ LocalClassDefs
		//- LocalClassDefs

		//+ Fields
		ObsSize_Accessor ObsSize { get ; }                                                                                                        // CSDefineObservation.cs:392
		//- Fields

		//+ Methods
		//- Methods
	}
}
