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
		/// <summary>
		/// Access AssociatedFeatures
		/// </summary>
		TItemReferenceSingle<AssociatedFeatures> AssociatedFeatures { get ; }                                                                     // BuildElementItemReference.cs:55
		//- Properties

		//+ Methods
		//- Methods
	}
}
