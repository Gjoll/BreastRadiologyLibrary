using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.ObservationSectionFragmentLocal;

namespace BreastRadLib
{
	public interface IObservationSectionFragment : IObservationBase, IBreastRadObservationFragment, IBreastRadObservationNoComponentFragment, IBreastRadObservationNoValueFragment
	{
		//+ LocalClassDefs
		//- LocalClassDefs

		//+ Fields
		//- Fields

		//+ Methods
		//- Methods
	}
}
