using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.AbnormalityCystLocal;

namespace BreastRadLib
{
	public interface IAbnormalityCyst
	{
		//+ LocalClassDefs
		//- LocalClassDefs

		//+ Fields
		CystType_Accessor CystType { get ; }                                                                                                      // CSBuildMemberListBase.cs:34
		//- Fields

		//+ Methods
		//- Methods
	}
}
