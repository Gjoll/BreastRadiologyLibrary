using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.NotPreviouslySeenComponentFragmentLocal;

namespace BreastRadLib
{
	public interface INotPreviouslySeenComponentFragment : IObservationBase, IBreastBodyLocationRequiredFragment
	{
		//+ LocalClassDefs
		//- LocalClassDefs

		//+ Fields
		NotPreviouslySeen_Accessor NotPreviouslySeen { get ; }                                                                                    // CSDefineObservation.cs:205
		//- Fields

		//+ Methods
		//- Methods
	}
}
