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
	public interface INotPreviouslySeenComponentFragment : IBreastBodyLocationRequiredFragment

	{
		//+ Properties
		NotPreviouslySeen_Accessor NotPreviouslySeen { get ; }                                                                                    // BuildMemberListBase.cs:29
		//- Properties

		//+ Methods
		//- Methods
	}
}
