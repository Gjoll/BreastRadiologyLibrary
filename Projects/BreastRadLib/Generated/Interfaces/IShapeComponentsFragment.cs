using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public interface IShapeComponentsFragment : IObservationBase, IBreastBodyLocationRequiredFragment
	{
		//+ Fields
		ShapeComponentsFragment.Orientation_Accessor Orientation { get ; }                                                                        // CSDefineObservation.cs:374
		ShapeComponentsFragment.Shape_Accessor Shape { get ; }                                                                                    // CSDefineObservation.cs:374
		ShapeComponentsFragment.Margin_Accessor Margin { get ; }                                                                                  // CSDefineObservation.cs:374
		ShapeComponentsFragment.MgDensity_Accessor MgDensity { get ; }                                                                            // CSDefineObservation.cs:374
		//- Fields

		//+ Methods
		//- Methods
	}
}
