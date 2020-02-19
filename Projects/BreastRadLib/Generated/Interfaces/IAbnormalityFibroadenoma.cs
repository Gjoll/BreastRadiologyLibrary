using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.AbnormalityFibroadenomaLocal;

namespace BreastRadLib
{
	public interface IAbnormalityFibroadenoma : IObservationBase, IObservationLeafFragment, IBreastRadObservationNoDeviceFragment, IBreastRadObservationNoValueFragment, IBreastRadObservationNoComponentFragment, ICommonComponentsFragment, IShapeComponentsFragment, IObservedCountFragment, IObservedDistributionFragment, IObservedSizeFragment, IPreviouslyDemonstratedByFragment, IAssociatedFeaturesHasMemberFragment
	{
		//+ LocalClassDefs
		//- LocalClassDefs

		//+ Fields
		FibroAdenomaType_Accessor FibroAdenomaType { get ; }                                                                                      // CSBuildMemberListCodedValue.cs:208
		//- Fields

		//+ Methods
		//- Methods
	}
}
