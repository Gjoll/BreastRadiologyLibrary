using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.AbnormalityLymphNodeLocal;

namespace BreastRadLib
{
	public interface IAbnormalityLymphNode
	{
		//+ LocalClassDefs
		//- LocalClassDefs

		//+ Fields
		LymphNodeType_Accessor LymphNodeType { get ; }                                                                                            // CSBuildMemberListBase.cs:27
		//- Fields

		//+ Methods
		//- Methods
	}
}
