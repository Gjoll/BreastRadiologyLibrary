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
	public interface IAssociatedFeaturesHasMemberFragment : IHeaderFragment

	{
		//+ Properties
		AssociatedFeatures_Accessor AssociatedFeatures { get ; }                                                                                  // BuildMemberListBase.cs:29
		//- Properties

		//+ Methods
		//- Methods
	}
}
