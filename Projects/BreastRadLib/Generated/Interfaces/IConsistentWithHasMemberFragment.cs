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
		// Called from BuildMemberReferences.cs, Line 197
		// BuildMemberBase.cs:366
		/// <summary>
		/// ConsistentWith
		/// </summary>
		ConsistentWithContainer ConsistentWith { get ; }                                                                                          // BuildMemberBase.cs:369
		//- Properties

		//+ Methods
		//- Methods
	}
}
