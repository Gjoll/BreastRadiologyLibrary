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
	/// <summary>
	/// Interface NotPreviouslySeenComponentFragment.
	/// This interface is automatically generated.
	/// </summary>
	public interface INotPreviouslySeenComponentFragment : IBreastBodyLocationRequiredFragment

	{
		//+ Properties
		/// <summary>
		/// Access Component value NotPreviouslySeen
		/// </summary>
		NotPreviouslySeen_Accessor NotPreviouslySeen { get ; }                                                                                    // BuildMemberListBase.cs:63
		//- Properties

		//+ Methods
		//- Methods
	}
}
