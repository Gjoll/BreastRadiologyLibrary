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
		// Called from BuildMemberReferences.cs, Line 176
		// BuildMemberBase.cs:341
		/// <summary>
		/// ConsistentWith
		/// </summary>
		ConsistentWithContainer ConsistentWith { get ; }                                                                                          // BuildMemberBase.cs:344
		//- Properties

		//+ Methods
		//- Methods
	}
}
