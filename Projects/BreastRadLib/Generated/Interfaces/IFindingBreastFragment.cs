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
		ElementItemReferenceMultiple<MGFinding> MGFinding { get ; }                                                                               // BuildElementItemReference.cs:55
		/// <summary>
		/// Access MRIFinding
		/// </summary>
		ElementItemReferenceMultiple<MRIFinding> MRIFinding { get ; }                                                                             // BuildElementItemReference.cs:55
		/// <summary>
		/// Access NMFinding
		/// </summary>
		ElementItemReferenceMultiple<NMFinding> NMFinding { get ; }                                                                               // BuildElementItemReference.cs:55
		/// <summary>
		/// Access USFinding
		/// </summary>
		ElementItemReferenceMultiple<USFinding> USFinding { get ; }                                                                               // BuildElementItemReference.cs:55
		//- Properties

		//+ Methods
		//- Methods
	}
}
