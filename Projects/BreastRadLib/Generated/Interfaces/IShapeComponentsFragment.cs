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
		Orientation_Accessor Orientation { get ; }                                                                                                // CSDefineObservation.cs:392
		Shape_Accessor Shape { get ; }                                                                                                            // CSDefineObservation.cs:392
		Margin_Accessor Margin { get ; }                                                                                                          // CSDefineObservation.cs:392
		MgDensity_Accessor MgDensity { get ; }                                                                                                    // CSDefineObservation.cs:392
		//- Fields

		//+ Methods
		//- Methods
	}
}
