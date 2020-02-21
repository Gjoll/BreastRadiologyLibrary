using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.ObservedFeatureLocal;

namespace BreastRadLib
{
	public interface IObservedFeature
	{
		//+ LocalClassDefs
		//- LocalClassDefs

		//+ Fields
		FeatureType_Accessor FeatureType { get ; }                                                                                                // CSBuildMemberListBase.cs:27
		//- Fields

		//+ Methods
		//- Methods
	}
}
