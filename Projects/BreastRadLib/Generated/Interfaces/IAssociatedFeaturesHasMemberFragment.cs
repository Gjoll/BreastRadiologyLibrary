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
	public interface IAssociatedFeaturesHasMemberFragment : IObservationBase, IHeaderFragment
	{
		//+ LocalClassDefs
		//- LocalClassDefs

		//+ Fields
		AssociatedFeatures_Accessor AssociatedFeatures { get ; }                                                                                  // CSBuildCodedReferenceList.cs:114
		//- Fields

		//+ Methods
		//- Methods
	}
}
