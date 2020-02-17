using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.ConsistentWithLocal;

namespace BreastRadLib
{
	public interface IConsistentWith : IObservationBase, IObservationLeafFragment, IBreastRadObservationNoDeviceFragment, IBreastRadObservationNoValueFragment, IBreastRadObservationNoComponentFragment
	{
		//+ LocalClassDefs
		//- LocalClassDefs

		//+ Fields
		Value_Accessor Value { get ; }                                                                                                            // CSDefineObservation.cs:392
		Qualifier_Accessor Qualifier { get ; }                                                                                                    // CSDefineObservation.cs:392
		//- Fields

		//+ Methods
		//- Methods
	}
}
