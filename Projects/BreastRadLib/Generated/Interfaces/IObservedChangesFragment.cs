using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.ObservedChangesFragmentLocal;

namespace BreastRadLib
{
	public interface IObservedChangesFragment
	{
		//+ LocalClassDefs
		//- LocalClassDefs

		//+ Fields
		ObsChanges_Accessor ObsChanges { get ; }                                                                                                  // CSBuildMemberListBase.cs:27
		//- Fields

		//+ Methods
		//- Methods
	}
}
