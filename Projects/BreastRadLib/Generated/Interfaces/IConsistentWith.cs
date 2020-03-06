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
		TItemComponentSingle<CodeableConcept> Value { get ; }                                                                                     // BuildElementItemComponent.cs:64
		/// <summary>
		/// Access Qualifier
		/// </summary>
		TItemComponentMultiple<CodeableConcept> Qualifier { get ; }                                                                               // BuildElementItemComponent.cs:64
		//- Properties

		//+ Methods
		//- Methods
	}
}
