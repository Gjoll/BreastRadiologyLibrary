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
		// Called from BuildMemberReferences.cs, Line 191
		// BuildMemberBase.cs:382
		/// <summary>
		/// ConsistentWith
		/// </summary>
		MConsistentWith ConsistentWith { get ; }                                                                                                  // BuildMemberBase.cs:385
		//- Properties

		//+ Methods
		//- Methods
	}
}
