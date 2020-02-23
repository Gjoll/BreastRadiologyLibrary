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
	public interface IConsistentWith : IObservationLeafFragment,
        IBreastRadObservationNoDeviceFragment,
        IBreastRadObservationNoValueFragment,
        IBreastRadObservationNoComponentFragment

	{
		//+ Properties
		Value_Accessor Value { get ; }                                                                                                            // BuildMemberListBase.cs:29
		Qualifier_Accessor Qualifier { get ; }                                                                                                    // BuildMemberListBase.cs:29
		//- Properties

		//+ Methods
		//- Methods
	}
}
