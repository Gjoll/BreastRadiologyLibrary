using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.AbnormalityMassLocal;

namespace BreastRadLib
{
	public interface IAbnormalityMass : IObservationBase, IObservationLeafFragment, ITumorSatelliteFragment, IBreastRadObservationNoDeviceFragment, IBreastRadObservationNoValueFragment, IBreastRadObservationNoComponentFragment, ICommonComponentsFragment, IShapeComponentsFragment, IObservedCountFragment, IObservedSizeFragment, IObservedDistributionFragment, INotPreviouslySeenComponentFragment, ICorrespondsWithFragment, IPreviouslyDemonstratedByFragment, IAssociatedFeaturesHasMemberFragment, IConsistentWithHasMemberFragment
	{
		//+ LocalClassDefs
		//- LocalClassDefs

		//+ Fields
		MassType_Accessor MassType { get ; }                                                                                                      // CSBuildMemberListBase.cs:34
		//- Fields

		//+ Methods
		//- Methods
	}
}
