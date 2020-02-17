using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.MGAbnormalityCalcificationLocal;

namespace BreastRadLib
{
	public interface IMGAbnormalityCalcification : IObservationBase, IObservationLeafFragment, IBreastRadObservationNoDeviceFragment, IBreastRadObservationNoComponentFragment, IBreastRadObservationNoValueFragment, ICommonComponentsFragment, INotPreviouslySeenComponentFragment, IObservedCountFragment, IObservedSizeFragment, IObservedDistributionFragment, ICorrespondsWithFragment, IPreviouslyDemonstratedByFragment, IAssociatedFeaturesHasMemberFragment, IConsistentWithHasMemberFragment
	{
		//+ LocalClassDefs
		//- LocalClassDefs

		//+ Fields
		CalcificationType_Accessor CalcificationType { get ; }                                                                                    // CSDefineObservation.cs:392
		CalcificationDistribution_Accessor CalcificationDistribution { get ; }                                                                    // CSDefineObservation.cs:392
		//- Fields

		//+ Methods
		//- Methods
	}
}
