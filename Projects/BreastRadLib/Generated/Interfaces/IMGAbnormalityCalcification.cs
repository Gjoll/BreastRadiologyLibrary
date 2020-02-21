using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.MGAbnormalityCalcificationLocal;

namespace BreastRadLib
{
	public interface IMGAbnormalityCalcification
	{
		//+ LocalClassDefs
		//- LocalClassDefs

		//+ Fields
		CalcificationType_Accessor CalcificationType { get ; }                                                                                    // CSBuildMemberListBase.cs:27
		CalcificationDistribution_Accessor CalcificationDistribution { get ; }                                                                    // CSBuildMemberListBase.cs:27
		//- Fields

		//+ Methods
		//- Methods
	}
}
