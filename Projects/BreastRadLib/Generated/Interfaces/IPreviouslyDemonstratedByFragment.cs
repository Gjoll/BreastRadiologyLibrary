using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.PreviouslyDemonstratedByFragmentLocal;

namespace BreastRadLib
{
	public interface IPreviouslyDemonstratedByFragment : IObservationBase
	{
		//+ LocalClassDefs
		//- LocalClassDefs

		//+ Fields
		PreviouslyDemonstratedBy_Accessor PreviouslyDemonstratedBy { get ; }                                                                      // CSBuildMemberListCodedValue.cs:208
		//- Fields

		//+ Methods
		//- Methods
	}
}
