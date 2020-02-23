using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.ObservedFeatureLocal;

namespace BreastRadLib
{
	public interface IObservedFeature : IObservationLeafFragment,
        IBreastRadObservationNoDeviceFragment,
        IBreastRadObservationNoValueFragment,
        IBreastRadObservationNoComponentFragment,
        IBreastBodyLocationRequiredFragment,
        IObservedCountFragment

	{
		//+ Properties
		FeatureType_Accessor FeatureType { get ; }                                                                                                // BuildMemberListBase.cs:29
		//- Properties

		//+ Methods
		//- Methods
	}
}
