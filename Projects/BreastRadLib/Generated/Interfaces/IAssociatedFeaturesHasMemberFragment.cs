using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.AssociatedFeaturesHasMemberFragmentLocal;

namespace BreastRadLib
{
	/// <summary>
	/// Interface AssociatedFeaturesHasMemberFragment.
	/// This interface is automatically generated.
	/// </summary>
	public interface IAssociatedFeaturesHasMemberFragment : IHeaderFragment

	{
		//+ Properties
		// Called from BuildMemberReferences.cs, Line 191
		// BuildMemberBase.cs:382
		/// <summary>
		/// AssociatedFeature
		/// </summary>
		MAssociatedFeature AssociatedFeature { get ; }                                                                                            // BuildMemberBase.cs:385
		//- Properties

		//+ Methods
		//- Methods
	}
}
