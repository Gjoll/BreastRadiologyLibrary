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
		/// Access Orientation
		/// </summary>
		TElementItemComponentSingle<CodeableConcept> Orientation { get ; }                                                                         // BuildElementItemComponent.cs:66
		/// <summary>
		/// Access Shape
		/// </summary>
		TElementItemComponentSingle<CodeableConcept> Shape { get ; }                                                                               // BuildElementItemComponent.cs:66
		/// <summary>
		/// Access Margin
		/// </summary>
		TElementItemComponentSingle<CodeableConcept> Margin { get ; }                                                                              // BuildElementItemComponent.cs:66
		/// <summary>
		/// Access MgDensity
		/// </summary>
		TElementItemComponentSingle<CodeableConcept> MgDensity { get ; }                                                                           // BuildElementItemComponent.cs:66
		//- Properties

		//+ Methods
		//- Methods
	}
}
