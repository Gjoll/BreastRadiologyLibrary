using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.BreastBodyLocationRequiredFragmentLocal;

namespace BreastRadLib
{
	/// <summary>
	/// Interface BreastBodyLocationRequiredFragment.
	/// This interface is automatically generated.
	/// </summary>
	public interface IBreastBodyLocationRequiredFragment : IHeaderFragment

	{
		//+ Properties
		// Called from BuildMemberElement.cs, Line 123
		// BuildMemberBase.cs:382
		/// <summary>
		/// BodySite
		/// </summary>
		MBodySite BodySite { get ; }                                                                                                              // BuildMemberBase.cs:385
		//- Properties

		//+ Methods
		//- Methods
	}
}
