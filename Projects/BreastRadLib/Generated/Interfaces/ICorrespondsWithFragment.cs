using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.CorrespondsWithFragmentLocal;

namespace BreastRadLib
{
	public interface ICorrespondsWithFragment : IObservationBase
	{
		//+ LocalClassDefs
		//- LocalClassDefs

		//+ Fields
		CorrespondsWith_Accessor CorrespondsWith { get ; }                                                                                        // CSBuildMemberListCodedValue.cs:208
		//- Fields

		//+ Methods
		//- Methods
	}
}
