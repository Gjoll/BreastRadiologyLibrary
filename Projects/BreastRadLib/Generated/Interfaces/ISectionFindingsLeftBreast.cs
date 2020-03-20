using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.SectionFindingsLeftBreastLocal;

namespace BreastRadLib
{
	/// <summary>
	/// Interface SectionFindingsLeftBreast.
	/// This interface is automatically generated.
	/// </summary>
	public interface ISectionFindingsLeftBreast : IFindingBreastFragment

	{
		//+ Properties
		// Called from BuildMemberElement.cs, Line 129
		// BuildMemberBase.cs:367
		/// <summary>
		/// BodySite
		/// </summary>
		MBodySite BodySite { get ; }                                                                                                              // BuildMemberBase.cs:370
		//- Properties

		//+ Methods
		//- Methods
	}
}
