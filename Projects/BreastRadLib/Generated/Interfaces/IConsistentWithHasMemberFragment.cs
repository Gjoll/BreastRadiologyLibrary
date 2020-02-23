using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.ConsistentWithHasMemberFragmentLocal;

namespace BreastRadLib
{
	public interface IConsistentWithHasMemberFragment : IHeaderFragment

	{
		//+ Properties
		ConsistentWith_Accessor ConsistentWith { get ; }                                                                                          // BuildMemberListBase.cs:29
		//- Properties

		//+ Methods
		//- Methods
	}
}
