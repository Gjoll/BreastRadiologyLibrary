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
		/// <summary>
		/// Orientation
		/// </summary>
		OrientationContainer Orientation { get ; }                                                                                                // BuildMemberBase.cs:327
		/// <summary>
		/// Shape
		/// </summary>
		ShapeContainer Shape { get ; }                                                                                                            // BuildMemberBase.cs:327
		/// <summary>
		/// Margin
		/// </summary>
		MarginContainer Margin { get ; }                                                                                                          // BuildMemberBase.cs:327
		/// <summary>
		/// MgDensity
		/// </summary>
		MgDensityContainer MgDensity { get ; }                                                                                                    // BuildMemberBase.cs:327
		//- Properties

		//+ Methods
		//- Methods
	}
}
