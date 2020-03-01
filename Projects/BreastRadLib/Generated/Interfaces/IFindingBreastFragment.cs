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
	/// <summary>
	/// Interface FindingBreastFragment.
	/// This interface is automatically generated.
	/// </summary>
	public interface IFindingBreastFragment : IHeaderFragment,
        IBreastRadObservationNoDeviceFragment

	{
		//+ Properties
		/// <summary>
		/// Access HasMembers value MGFinding
		/// </summary>
		MGFinding_Accessor MGFinding { get ; }                                                                                                    // BuildMemberListBase.cs:62
		/// <summary>
		/// Access HasMembers value MRIFinding
		/// </summary>
		MRIFinding_Accessor MRIFinding { get ; }                                                                                                  // BuildMemberListBase.cs:62
		/// <summary>
		/// Access HasMembers value NMFinding
		/// </summary>
		NMFinding_Accessor NMFinding { get ; }                                                                                                    // BuildMemberListBase.cs:62
		/// <summary>
		/// Access HasMembers value USFinding
		/// </summary>
		USFinding_Accessor USFinding { get ; }                                                                                                    // BuildMemberListBase.cs:62
		//- Properties

		//+ Methods
		//- Methods
	}
}
