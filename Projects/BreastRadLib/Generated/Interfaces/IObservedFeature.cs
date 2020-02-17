using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public interface IObservedFeature : IObservationBase, IObservationLeafFragment, IBreastRadObservationNoDeviceFragment, IBreastRadObservationNoValueFragment, IBreastRadObservationNoComponentFragment, IBreastBodyLocationRequiredFragment, IObservedCountFragment
	{
		//+ Fields
		ObservedFeature.FeatureType_Accessor FeatureType { get ; }                                                                                // CSDefineObservation.cs:374
		//- Fields

		//+ Methods
		//- Methods
	}
}
