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
	public interface IBodyDistanceFromExtension
	{
		//+ LocalClassDefs
		//- LocalClassDefs

		//+ Fields
		LandMark_Accessor LandMark { get ; }                                                                                                      // CSBuildMemberListBase.cs:27
		DistanceFromLandMark_Accessor DistanceFromLandMark { get ; }                                                                              // CSBuildMemberListBase.cs:27
		//- Fields

		//+ Methods
		//- Methods
	}
}
