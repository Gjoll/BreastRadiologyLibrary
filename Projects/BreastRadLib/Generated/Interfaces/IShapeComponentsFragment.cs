using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.ShapeComponentsFragmentLocal;

namespace BreastRadLib
{
	public interface IShapeComponentsFragment
	{
		//+ LocalClassDefs
		//- LocalClassDefs

		//+ Fields
		Orientation_Accessor Orientation { get ; }                                                                                                // CSBuildMemberListBase.cs:27
		Shape_Accessor Shape { get ; }                                                                                                            // CSBuildMemberListBase.cs:27
		Margin_Accessor Margin { get ; }                                                                                                          // CSBuildMemberListBase.cs:27
		MgDensity_Accessor MgDensity { get ; }                                                                                                    // CSBuildMemberListBase.cs:27
		//- Fields

		//+ Methods
		//- Methods
	}
}
