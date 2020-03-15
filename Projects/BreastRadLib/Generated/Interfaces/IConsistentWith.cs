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
		/// Value
		/// </summary>
		ValueContainer Value { get ; }                                                                                                            // BuildMemberBase.cs:327
		/// <summary>
		/// Qualifier
		/// </summary>
		QualifierContainer Qualifier { get ; }                                                                                                    // BuildMemberBase.cs:327
		//- Properties

		//+ Methods
		//- Methods
	}
}
