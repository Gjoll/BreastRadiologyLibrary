using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.MGAbnormalityArchitecturalDistortionLocal;

namespace BreastRadLib
{
	/// <summary>
	/// Interface MGAbnormalityArchitecturalDistortion.
	/// This interface is automatically generated.
	/// </summary>
	public interface IMGAbnormalityArchitecturalDistortion : IObservationLeafFragment,
        IBreastRadObservationNoDeviceFragment,
        IBreastRadObservationNoComponentFragment,
        IBreastRadObservationNoValueFragment,
        ICommonComponentsFragment,
        IShapeComponentsFragment,
        INotPreviouslySeenComponentFragment,
        ICorrespondsWithFragment,
        IPreviouslyDemonstratedByFragment,
        IAssociatedFeaturesHasMemberFragment,
        IConsistentWithHasMemberFragment

	{
		//+ Properties
		//- Properties

		//+ Methods
		//- Methods
	}
}
