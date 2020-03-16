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
		// Called from BuildMemberExtensionComplex.cs, Line 167
		// BuildMemberBase.cs:341
		/// <summary>
		/// BreastBodyLocationExtension
		/// </summary>
		BreastBodyLocationExtensionCollection BreastBodyLocationExtension { get ; }                                                               // BuildMemberBase.cs:344
		//- Properties

		//+ Methods
		//- Methods
	}
}
