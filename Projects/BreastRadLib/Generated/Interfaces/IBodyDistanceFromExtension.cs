using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.BodyDistanceFromExtensionLocal;

namespace BreastRadLib
{
	public interface IBodyDistanceFromExtension : IHeaderFragment

	{
		//+ Properties
		LandMark_Accessor LandMark { get ; }                                                                                                      // BuildMemberListBase.cs:29
		DistanceFromLandMark_Accessor DistanceFromLandMark { get ; }                                                                              // BuildMemberListBase.cs:29
		//- Properties

		//+ Methods
		//- Methods
	}
}
