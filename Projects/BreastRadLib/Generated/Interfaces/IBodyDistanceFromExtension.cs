using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.BodyDistanceFromExtensionLocal;

namespace BreastRadLib
{
	/// <summary>
	/// Interface BodyDistanceFromExtension.
	/// This interface is automatically generated.
	/// </summary>
	public interface IBodyDistanceFromExtension : IHeaderFragment

	{
		//+ Properties
		// Called from BuildMemberExtensionComplex.cs, Line 189
		// BuildMemberBase.cs:366
		/// <summary>
		/// BodyDistanceFromExtension
		/// </summary>
		BodyDistanceFromExtensionCollection BodyDistanceFromExtension { get ; }                                                                   // BuildMemberBase.cs:369
		//- Properties

		//+ Methods
		//- Methods
	}
}
