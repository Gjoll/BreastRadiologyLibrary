using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.BreastRadObservationFragmentLocal;

namespace BreastRadLib
{
	public interface IBreastRadObservationFragment : IObservationBase, IHeaderFragment, ICategoryFragment
	{
		//+ LocalClassDefs
		//- LocalClassDefs

		//+ Fields
		//- Fields

		//+ Methods
		//- Methods
	}
}
