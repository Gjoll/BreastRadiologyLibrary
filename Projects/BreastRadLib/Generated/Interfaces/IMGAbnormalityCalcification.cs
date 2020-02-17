using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public interface IMGAbnormalityCalcification : IObservationBase, IObservationLeafFragment, IBreastRadObservationNoDeviceFragment, IBreastRadObservationNoComponentFragment, IBreastRadObservationNoValueFragment, ICommonComponentsFragment, INotPreviouslySeenComponentFragment, IObservedCountFragment, IObservedSizeFragment, IObservedDistributionFragment, ICorrespondsWithFragment, IPreviouslyDemonstratedByFragment, IAssociatedFeaturesHasMemberFragment, IConsistentWithHasMemberFragment
	{
		//+ Fields
		MGAbnormalityCalcification.CalcificationType_Accessor CalcificationType { get ; }                                                         // CSDefineObservation.cs:374
		MGAbnormalityCalcification.CalcificationDistribution_Accessor CalcificationDistribution { get ; }                                         // CSDefineObservation.cs:374
		//- Fields

		//+ Methods
		//- Methods
	}
}
