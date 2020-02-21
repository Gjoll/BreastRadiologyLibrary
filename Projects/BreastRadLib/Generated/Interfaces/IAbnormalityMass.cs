using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.AbnormalityMassLocal;

namespace BreastRadLib
{
	public interface IAbnormalityMass
	{
		//+ LocalClassDefs
		//- LocalClassDefs

		//+ Fields
		MassType_Accessor MassType { get ; }                                                                                                      // CSBuildMemberListBase.cs:27
		//- Fields

		//+ Methods
		//- Methods
	}
}
