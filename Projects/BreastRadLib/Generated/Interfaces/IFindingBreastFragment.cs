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
		ElementItemReferenceSingle<MGFinding> MGFinding { get ; }                                                                                 // BuildElementItemReference.cs:55
		/// <summary>
		/// Access MRIFinding
		/// </summary>
		ElementItemReferenceSingle<MRIFinding> MRIFinding { get ; }                                                                               // BuildElementItemReference.cs:55
		/// <summary>
		/// Access NMFinding
		/// </summary>
		ElementItemReferenceSingle<NMFinding> NMFinding { get ; }                                                                                 // BuildElementItemReference.cs:55
		/// <summary>
		/// Access USFinding
		/// </summary>
		ElementItemReferenceSingle<USFinding> USFinding { get ; }                                                                                 // BuildElementItemReference.cs:55
		//- Properties

		//+ Methods
		//- Methods
	}
}
