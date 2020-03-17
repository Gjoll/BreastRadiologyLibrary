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
		// Called from BuildMemberReferences.cs, Line 199
		// BuildMemberBase.cs:366
		/// <summary>
		/// AssociatedFeature
		/// </summary>
		AssociatedFeatureContainer AssociatedFeature { get ; }                                                                                    // BuildMemberBase.cs:369
		//- Properties

		//+ Methods
		//- Methods
	}
}
