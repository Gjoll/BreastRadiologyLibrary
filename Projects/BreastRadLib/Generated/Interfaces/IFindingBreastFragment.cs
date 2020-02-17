using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.FindingBreastFragmentLocal;

namespace BreastRadLib
{
	public interface IFindingBreastFragment : IObservationBase, IHeaderFragment, IBreastRadObservationNoDeviceFragment
	{
		//+ LocalClassDefs
		//- LocalClassDefs

		//+ Fields
		//- Fields

		//+ Methods
		//- Methods
	}
}
