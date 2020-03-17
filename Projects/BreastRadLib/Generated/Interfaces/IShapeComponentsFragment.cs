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
		// Called from BuildMemberComponents.cs, Line 208
		// BuildMemberBase.cs:367
		/// <summary>
		/// Orientation
		/// </summary>
		MOrientation Orientation { get ; }                                                                                                        // BuildMemberBase.cs:370
		// Called from BuildMemberComponents.cs, Line 208
		// BuildMemberBase.cs:367
		/// <summary>
		/// Shape
		/// </summary>
		MShape Shape { get ; }                                                                                                                    // BuildMemberBase.cs:370
		// Called from BuildMemberComponents.cs, Line 208
		// BuildMemberBase.cs:367
		/// <summary>
		/// Margin
		/// </summary>
		MMargin Margin { get ; }                                                                                                                  // BuildMemberBase.cs:370
		// Called from BuildMemberComponents.cs, Line 208
		// BuildMemberBase.cs:367
		/// <summary>
		/// MgDensity
		/// </summary>
		MMgDensity MgDensity { get ; }                                                                                                            // BuildMemberBase.cs:370
		//- Properties

		//+ Methods
		//- Methods
	}
}
