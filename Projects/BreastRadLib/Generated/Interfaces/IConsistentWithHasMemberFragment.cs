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
	public interface IConsistentWithHasMemberFragment : IObservationBase, IHeaderFragment
	{
		//+ LocalClassDefs
		//- LocalClassDefs

		//+ Fields
		ConsistentWith_Accessor ConsistentWith { get ; }                                                                                          // CSBuildMemberListReference.cs:114
		//- Fields

		//+ Methods
		//- Methods
	}
}
