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
		// Called from BuildMemberReferences.cs, Line 176
		// BuildMemberBase.cs:341
		/// <summary>
		/// MGFinding
		/// </summary>
		MGFindingContainer MGFinding { get ; }                                                                                                    // BuildMemberBase.cs:344
		// Called from BuildMemberReferences.cs, Line 176
		// BuildMemberBase.cs:341
		/// <summary>
		/// MRIFinding
		/// </summary>
		MRIFindingContainer MRIFinding { get ; }                                                                                                  // BuildMemberBase.cs:344
		// Called from BuildMemberReferences.cs, Line 176
		// BuildMemberBase.cs:341
		/// <summary>
		/// NMFinding
		/// </summary>
		NMFindingContainer NMFinding { get ; }                                                                                                    // BuildMemberBase.cs:344
		// Called from BuildMemberReferences.cs, Line 176
		// BuildMemberBase.cs:341
		/// <summary>
		/// USFinding
		/// </summary>
		USFindingContainer USFinding { get ; }                                                                                                    // BuildMemberBase.cs:344
		//- Properties

		//+ Methods
		//- Methods
	}
}
