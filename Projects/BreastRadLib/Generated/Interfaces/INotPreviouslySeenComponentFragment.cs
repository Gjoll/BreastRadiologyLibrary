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
		// Called from BuildMemberComponents.cs, Line 208
		// BuildMemberBase.cs:367
		/// <summary>
		/// NotPreviouslySeen
		/// </summary>
		MNotPreviouslySeen NotPreviouslySeen { get ; }                                                                                            // BuildMemberBase.cs:370
		//- Properties

		//+ Methods
		//- Methods
	}
}
