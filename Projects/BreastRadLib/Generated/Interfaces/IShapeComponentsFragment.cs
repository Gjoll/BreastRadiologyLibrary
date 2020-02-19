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
		Orientation_Accessor Orientation { get ; }                                                                                                // CSBuildMemberListCodedValue.cs:208
		Shape_Accessor Shape { get ; }                                                                                                            // CSBuildMemberListCodedValue.cs:208
		Margin_Accessor Margin { get ; }                                                                                                          // CSBuildMemberListCodedValue.cs:208
		MgDensity_Accessor MgDensity { get ; }                                                                                                    // CSBuildMemberListCodedValue.cs:208
		//- Fields

		//+ Methods
		//- Methods
	}
}
