using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public interface IBiRadFragment : IObservationBase
	{
		//+ Fields
		BiRadFragment.BiRadsAssessmentCategory_Accessor BiRadsAssessmentCategory { get ; }                                                        // CSDefineObservation.cs:374
		//- Fields

		//+ Methods
		//- Methods
	}
}
