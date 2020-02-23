using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.CommonComponentsFragmentLocal;

namespace BreastRadLib
{
	public interface ICommonComponentsFragment : IBreastBodyLocationRequiredFragment,
        IObservedChangesFragment,
        IBiRadFragment

	{
		//+ Properties
		//- Properties

		//+ Methods
		//- Methods
	}
}
