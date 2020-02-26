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
		/// Access Component value Orientation
		/// </summary>
		Orientation_Accessor Orientation { get ; }                                                                                                // BuildMemberListBase.cs:40
		/// <summary>
		/// Access Component value Shape
		/// </summary>
		Shape_Accessor Shape { get ; }                                                                                                            // BuildMemberListBase.cs:40
		/// <summary>
		/// Access Component value Margin
		/// </summary>
		Margin_Accessor Margin { get ; }                                                                                                          // BuildMemberListBase.cs:40
		/// <summary>
		/// Access Component value MgDensity
		/// </summary>
		MgDensity_Accessor MgDensity { get ; }                                                                                                    // BuildMemberListBase.cs:40
		//- Properties

		//+ Methods
		//- Methods
	}
}
