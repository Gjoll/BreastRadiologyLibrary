using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public interface IConsistentWith : IObservationBase, IObservationLeafFragment, IBreastRadObservationNoDeviceFragment, IBreastRadObservationNoValueFragment, IBreastRadObservationNoComponentFragment
	{
		//+ Fields
		ConsistentWith.Value_Accessor Value { get ; }                                                                                             // CSDefineObservation.cs:374
		ConsistentWith.Qualifier_Accessor Qualifier { get ; }                                                                                     // CSDefineObservation.cs:374
		//- Fields

		//+ Methods
		//- Methods
	}
}
