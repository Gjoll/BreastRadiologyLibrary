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
	public interface IFindingBreastFragment : IObservationBase, IHeaderFragment, IBreastRadObservationNoDeviceFragment
	{
		//+ LocalClassDefs
		//- LocalClassDefs

		//+ Fields
		MGFinding_Accessor MGFinding { get ; }                                                                                                    // CSDefineObservation.cs:276
		MRIFinding_Accessor MRIFinding { get ; }                                                                                                  // CSDefineObservation.cs:276
		NMFinding_Accessor NMFinding { get ; }                                                                                                    // CSDefineObservation.cs:276
		USFinding_Accessor USFinding { get ; }                                                                                                    // CSDefineObservation.cs:276
		//- Fields

		//+ Methods
		//- Methods
	}
}
