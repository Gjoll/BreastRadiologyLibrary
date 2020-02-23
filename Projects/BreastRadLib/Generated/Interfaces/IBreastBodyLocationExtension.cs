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
	public interface IBreastBodyLocationExtension : IHeaderFragment

	{
		//+ Properties
		Quadrant_Accessor Quadrant { get ; }                                                                                                      // BuildMemberListBase.cs:29
		Region_Accessor Region { get ; }                                                                                                          // BuildMemberListBase.cs:29
		ClockDirection_Accessor ClockDirection { get ; }                                                                                          // BuildMemberListBase.cs:29
		Depth_Accessor Depth { get ; }                                                                                                            // BuildMemberListBase.cs:29
		//- Properties

		//+ Methods
		//- Methods
	}
}
