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
	public interface IFindingBreastFragment : IHeaderFragment,
        IBreastRadObservationNoDeviceFragment

	{
		//+ Properties
		MGFinding_Accessor MGFinding { get ; }                                                                                                    // BuildMemberListBase.cs:29
		MRIFinding_Accessor MRIFinding { get ; }                                                                                                  // BuildMemberListBase.cs:29
		NMFinding_Accessor NMFinding { get ; }                                                                                                    // BuildMemberListBase.cs:29
		USFinding_Accessor USFinding { get ; }                                                                                                    // BuildMemberListBase.cs:29
		//- Properties

		//+ Methods
		//- Methods
	}
}
