using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.SectionFindingsRightBreastLocal;

namespace BreastRadLib
{
	/// <summary>
	/// Interface SectionFindingsRightBreast.
	/// This interface is automatically generated.
	/// </summary>
	public interface ISectionFindingsRightBreast : IFindingBreastFragment

	{
		//+ Properties
		// Called from BuildMemberElement.cs, Line 123
		// BuildMemberBase.cs:386
		/// <summary>
		/// BodySite
		/// </summary>
		MBodySite BodySite { get ; }                                                                                                              // BuildMemberBase.cs:389
		//- Properties

		//+ Methods
		//- Methods
	}
}
