using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.BiRadFragmentLocal;

namespace BreastRadLib
{
	public interface IBiRadFragment : IObservationBase
	{
		//+ LocalClassDefs
		//- LocalClassDefs

		//+ Fields
		BiRadsAssessmentCategory_Accessor BiRadsAssessmentCategory { get ; }                                                                      // CSBuildMemberListCodedValue.cs:208
		//- Fields

		//+ Methods
		//- Methods
	}
}
