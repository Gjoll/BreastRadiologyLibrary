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
		// Called from BuildMemberReferences.cs, Line 188
		// BuildMemberBase.cs:386
		/// <summary>
		/// MGFinding
		/// </summary>
		MMGFinding MGFinding { get ; }                                                                                                            // BuildMemberBase.cs:389
		// Called from BuildMemberReferences.cs, Line 188
		// BuildMemberBase.cs:386
		/// <summary>
		/// MRIFinding
		/// </summary>
		MMRIFinding MRIFinding { get ; }                                                                                                          // BuildMemberBase.cs:389
		// Called from BuildMemberReferences.cs, Line 188
		// BuildMemberBase.cs:386
		/// <summary>
		/// NMFinding
		/// </summary>
		MNMFinding NMFinding { get ; }                                                                                                            // BuildMemberBase.cs:389
		// Called from BuildMemberReferences.cs, Line 188
		// BuildMemberBase.cs:386
		/// <summary>
		/// USFinding
		/// </summary>
		MUSFinding USFinding { get ; }                                                                                                            // BuildMemberBase.cs:389
		//- Properties

		//+ Methods
		//- Methods
	}
}
