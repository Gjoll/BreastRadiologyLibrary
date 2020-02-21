using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.ConsistentWithLocal;

namespace BreastRadLib
{
	public interface IConsistentWith
	{
		//+ LocalClassDefs
		//- LocalClassDefs

		//+ Fields
		Value_Accessor Value { get ; }                                                                                                            // CSBuildMemberListBase.cs:27
		Qualifier_Accessor Qualifier { get ; }                                                                                                    // CSBuildMemberListBase.cs:27
		//- Fields

		//+ Methods
		//- Methods
	}
}
