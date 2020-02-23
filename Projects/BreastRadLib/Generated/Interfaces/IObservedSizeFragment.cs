using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.ObservedSizeFragmentLocal;

namespace BreastRadLib
{
	public interface IObservedSizeFragment 
	{
		//+ Properties
		ObsSize_Accessor ObsSize { get ; }                                                                                                        // BuildMemberListBase.cs:29
		//- Properties

		//+ Methods
		//- Methods
	}
}
