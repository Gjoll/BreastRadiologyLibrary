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
	public interface IShapeComponentsFragment : IObservationBase, IBreastBodyLocationRequiredFragment
	{
		//+ LocalClassDefs
		//- LocalClassDefs

		//+ Fields
		Orientation_Accessor Orientation { get ; }                                                                                                // CSBuildMemberListBase.cs:34
		Shape_Accessor Shape { get ; }                                                                                                            // CSBuildMemberListBase.cs:34
		Margin_Accessor Margin { get ; }                                                                                                          // CSBuildMemberListBase.cs:34
		MgDensity_Accessor MgDensity { get ; }                                                                                                    // CSBuildMemberListBase.cs:34
		//- Fields

		//+ Methods
		//- Methods
	}
}
