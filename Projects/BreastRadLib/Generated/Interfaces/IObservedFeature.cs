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
	public interface IObservedFeature : IObservationBase, IObservationLeafFragment, IBreastRadObservationNoDeviceFragment, IBreastRadObservationNoValueFragment, IBreastRadObservationNoComponentFragment, IBreastBodyLocationRequiredFragment, IObservedCountFragment
	{
		//+ LocalClassDefs
		//- LocalClassDefs

		//+ Fields
		FeatureType_Accessor FeatureType { get ; }                                                                                                // CSDefineObservation.cs:205
		//- Fields

		//+ Methods
		//- Methods
	}
}
