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
	/// <summary>
	/// Interface ConsistentWith.
	/// This interface is automatically generated.
	/// </summary>
	public interface IConsistentWith : IObservationLeafFragment,
        IBreastRadObservationNoDeviceFragment,
        IBreastRadObservationNoValueFragment,
        IBreastRadObservationNoComponentFragment

	{
		//+ Properties
		/// <summary>
		/// Access Value
		/// </summary>
		TElementItemComponentSingle<CodeableConcept> Value { get ; }                                                                               // BuildElementItemComponent.cs:66
		/// <summary>
		/// Access Qualifier
		/// </summary>
		TElementItemComponentMultiple<CodeableConcept> Qualifier { get ; }                                                                         // BuildElementItemComponent.cs:66
		//- Properties

		//+ Methods
		//- Methods
	}
}
