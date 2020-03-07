using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadLib
{
	/// <summary>
	/// Interface that all Member classes implement.
	/// </summary>
	public interface IMContainer
	{
		/// <summary>
		/// Path to item in fhir resource
		/// This may include slice names.
		/// </summary>
		String FhirPath{ get; }

		/// <summary>
		/// Count of items
		/// </summary>
		Int32 Count{ get; }

		/// <summary>
		/// Minium cardinality
		/// </summary>
		Int32 Min{ get; }

		/// <summary>
		/// Maximum cardinality
		/// </summary>
		Int32 Max{ get; }

		//void SetResourceValues<T>(Base resource, IEnumerable<T> items);
		//public IEnumerable<T> GetResourceValues<T>(Base resource);
	}
}
