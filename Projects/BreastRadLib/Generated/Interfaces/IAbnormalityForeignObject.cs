using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.AbnormalityForeignObjectLocal;

namespace BreastRadLib
{
	public interface IAbnormalityForeignObject
	{
		//+ LocalClassDefs
		//- LocalClassDefs

		//+ Fields
		AbnormalityForeignObjectType_Accessor AbnormalityForeignObjectType { get ; }                                                              // CSBuildMemberListBase.cs:27
		//- Fields

		//+ Methods
		//- Methods
	}
}
