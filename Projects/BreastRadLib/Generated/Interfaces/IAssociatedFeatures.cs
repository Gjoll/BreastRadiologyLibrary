using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public interface IAssociatedFeatures : IObservationBase, IObservationSectionFragment
	{
		//+ Fields
		MemberList<IMGAbnormalityArchitecturalDistortion> MGAbnormalityArchitecturalDistortion {get;}                                             // CSDefineObservation.cs:162
		MemberList<IMGAbnormalityCalcification> MGAbnormalityCalcification {get;}                                                                 // CSDefineObservation.cs:162
		MemberList<IObservedFeature> ObservedFeature {get;}                                                                                       // CSDefineObservation.cs:162
		//- Fields

		//+ Methods
		//- Methods
	}
}
