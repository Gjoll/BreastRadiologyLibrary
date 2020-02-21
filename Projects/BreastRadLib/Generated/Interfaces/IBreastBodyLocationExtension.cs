using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.BreastBodyLocationExtensionLocal;

namespace BreastRadLib
{
	public interface IBreastBodyLocationExtension
	{
		//+ LocalClassDefs
		//- LocalClassDefs

		//+ Fields
		Quadrant_Accessor Quadrant { get ; }                                                                                                      // CSBuildMemberListBase.cs:27
		Region_Accessor Region { get ; }                                                                                                          // CSBuildMemberListBase.cs:27
		ClockDirection_Accessor ClockDirection { get ; }                                                                                          // CSBuildMemberListBase.cs:27
		Depth_Accessor Depth { get ; }                                                                                                            // CSBuildMemberListBase.cs:27
		//- Fields

		//+ Methods
		//- Methods
	}
}
