using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.MGAbnormalityDensityLocal;

namespace BreastRadLib
{
	public interface IMGAbnormalityDensity
	{
		//+ LocalClassDefs
		//- LocalClassDefs

		//+ Fields
		DensityType_Accessor DensityType { get ; }                                                                                                // CSBuildMemberListBase.cs:34
		//- Fields

		//+ Methods
		//- Methods
	}
}
