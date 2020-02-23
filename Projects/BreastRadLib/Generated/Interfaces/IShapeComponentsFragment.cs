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
	public interface IShapeComponentsFragment : IBreastBodyLocationRequiredFragment

	{
		//+ Properties
		Orientation_Accessor Orientation { get ; }                                                                                                // BuildMemberListBase.cs:29
		Shape_Accessor Shape { get ; }                                                                                                            // BuildMemberListBase.cs:29
		Margin_Accessor Margin { get ; }                                                                                                          // BuildMemberListBase.cs:29
		MgDensity_Accessor MgDensity { get ; }                                                                                                    // BuildMemberListBase.cs:29
		//- Properties

		//+ Methods
		//- Methods
	}
}
