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
		/// Access Component value Value
		/// </summary>
		Value_Accessor Value { get ; }                                                                                                            // BuildMemberListBase.cs:62
		/// <summary>
		/// Access Component value Qualifier
		/// </summary>
		Qualifier_Accessor Qualifier { get ; }                                                                                                    // BuildMemberListBase.cs:62
		//- Properties

		//+ Methods
		//- Methods
	}
}
