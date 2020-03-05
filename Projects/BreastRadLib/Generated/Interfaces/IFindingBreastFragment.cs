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
		/// Access MGFinding
		/// </summary>
		TItemReferenceSingle<MGFinding> MGFinding { get ; }                                                                                 // BuildItemReference.cs:55
		/// <summary>
		/// Access MRIFinding
		/// </summary>
		TItemReferenceSingle<MRIFinding> MRIFinding { get ; }                                                                               // BuildItemReference.cs:55
		/// <summary>
		/// Access NMFinding
		/// </summary>
		TItemReferenceSingle<NMFinding> NMFinding { get ; }                                                                                 // BuildItemReference.cs:55
		/// <summary>
		/// Access USFinding
		/// </summary>
		TItemReferenceSingle<USFinding> USFinding { get ; }                                                                                 // BuildItemReference.cs:55
		//- Properties

		//+ Methods
		//- Methods
	}
}
