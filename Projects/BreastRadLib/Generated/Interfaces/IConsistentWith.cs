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
		// Called from BuildMemberComponents.cs, Line 202
		// BuildMemberBase.cs:382
		/// <summary>
		/// Value
		/// </summary>
		MValue Value { get ; }                                                                                                                    // BuildMemberBase.cs:385
		// Called from BuildMemberComponents.cs, Line 202
		// BuildMemberBase.cs:382
		/// <summary>
		/// Qualifier
		/// </summary>
		MQualifier Qualifier { get ; }                                                                                                            // BuildMemberBase.cs:385
		//- Properties

		//+ Methods
		//- Methods
	}
}
