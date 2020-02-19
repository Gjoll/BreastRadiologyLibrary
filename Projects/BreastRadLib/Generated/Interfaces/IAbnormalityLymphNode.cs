using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.AbnormalityLymphNodeLocal;

namespace BreastRadLib
{
	public interface IAbnormalityLymphNode : IObservationBase, IObservationLeafFragment, ITumorSatelliteFragment, IBreastRadObservationNoDeviceFragment, IBreastRadObservationNoValueFragment, IBreastRadObservationNoComponentFragment, ICommonComponentsFragment, IShapeComponentsFragment, IObservedCountFragment, IObservedDistributionFragment, IObservedSizeFragment, INotPreviouslySeenComponentFragment, ICorrespondsWithFragment, IPreviouslyDemonstratedByFragment, IAssociatedFeaturesHasMemberFragment
	{
		//+ LocalClassDefs
		//- LocalClassDefs

		//+ Fields
		LymphNodeType_Accessor LymphNodeType { get ; }                                                                                            // CSBuildMemberListCodedValue.cs:208
		//- Fields

		//+ Methods
		//- Methods
	}
}
