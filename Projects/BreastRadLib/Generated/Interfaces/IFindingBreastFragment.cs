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
	public interface IFindingBreastFragment
	{
		//+ LocalClassDefs
		//- LocalClassDefs

		//+ Fields
		MGFinding_Accessor MGFinding { get ; }                                                                                                    // CSBuildMemberListBase.cs:34
		MRIFinding_Accessor MRIFinding { get ; }                                                                                                  // CSBuildMemberListBase.cs:34
		NMFinding_Accessor NMFinding { get ; }                                                                                                    // CSBuildMemberListBase.cs:34
		USFinding_Accessor USFinding { get ; }                                                                                                    // CSBuildMemberListBase.cs:34
		//- Fields

		//+ Methods
		//- Methods
	}
}
