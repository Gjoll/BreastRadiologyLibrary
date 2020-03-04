using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.ConsistentWithHasMemberFragmentLocal;

namespace BreastRadLib
{
	/// <summary>
	/// Interface ConsistentWithHasMemberFragment.
	/// This interface is automatically generated.
	/// </summary>
	public interface IConsistentWithHasMemberFragment : IHeaderFragment

	{
		//+ Properties
		/// <summary>
		/// Access ConsistentWith
		/// </summary>
		ElementItemReferenceMultiple<ConsistentWith> ConsistentWith { get ; }                                                                     // BuildElementItemReference.cs:55
		//- Properties

		//+ Methods
		//- Methods
	}
}
