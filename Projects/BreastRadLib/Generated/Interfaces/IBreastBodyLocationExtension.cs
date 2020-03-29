using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.BreastBodyLocationExtensionLocal;

namespace BreastRadLib
{
	/// <summary>
	/// Interface BreastBodyLocationExtension.
	/// This interface is automatically generated.
	/// </summary>
	public interface IBreastBodyLocationExtension : IHeaderFragment

	{
		//+ Properties
		// Called from BuildMemberExtensionComplex.cs, Line 180
		// BuildMemberBase.cs:386
		/// <summary>
		/// BreastBodyLocationExtension
		/// </summary>
		MBreastBodyLocationExtension BreastBodyLocationExtension { get ; }                                                                        // BuildMemberBase.cs:389
		//- Properties

		//+ Methods
		//- Methods
	}
}
