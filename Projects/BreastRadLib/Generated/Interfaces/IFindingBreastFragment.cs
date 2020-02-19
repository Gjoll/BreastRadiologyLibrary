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
		MGFinding_Accessor MGFinding { get ; }                                                                                                    // CSBuildCodedReferenceList.cs:114
		MRIFinding_Accessor MRIFinding { get ; }                                                                                                  // CSBuildCodedReferenceList.cs:114
		NMFinding_Accessor NMFinding { get ; }                                                                                                    // CSBuildCodedReferenceList.cs:114
		USFinding_Accessor USFinding { get ; }                                                                                                    // CSBuildCodedReferenceList.cs:114
		//- Fields

		//+ Methods
		//- Methods
	}
}
