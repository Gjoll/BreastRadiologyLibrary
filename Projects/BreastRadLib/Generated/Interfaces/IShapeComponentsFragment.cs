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
	/// <summary>
	/// Interface ShapeComponentsFragment.
	/// This interface is automatically generated.
	/// </summary>
	public interface IShapeComponentsFragment : IBreastBodyLocationRequiredFragment

	{
		//+ Properties
		// Called from BuildMemberComponents.cs, Line 179
		// BuildMemberBase.cs:341
		/// <summary>
		/// Orientation
		/// </summary>
		OrientationContainer Orientation { get ; }                                                                                                // BuildMemberBase.cs:344
		// Called from BuildMemberComponents.cs, Line 179
		// BuildMemberBase.cs:341
		/// <summary>
		/// Shape
		/// </summary>
		ShapeContainer Shape { get ; }                                                                                                            // BuildMemberBase.cs:344
		// Called from BuildMemberComponents.cs, Line 179
		// BuildMemberBase.cs:341
		/// <summary>
		/// Margin
		/// </summary>
		MarginContainer Margin { get ; }                                                                                                          // BuildMemberBase.cs:344
		// Called from BuildMemberComponents.cs, Line 179
		// BuildMemberBase.cs:341
		/// <summary>
		/// MgDensity
		/// </summary>
		MgDensityContainer MgDensity { get ; }                                                                                                    // BuildMemberBase.cs:344
		//- Properties

		//+ Methods
		//- Methods
	}
}
