using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.AbnormalityDuctLocal;

namespace BreastRadLib
{
	public interface IAbnormalityDuct
	{
		//+ LocalClassDefs
		//- LocalClassDefs

		//+ Fields
		DuctType_Accessor DuctType { get ; }                                                                                                      // CSBuildMemberListBase.cs:34
		//- Fields

		//+ Methods
		//- Methods
	}
}
