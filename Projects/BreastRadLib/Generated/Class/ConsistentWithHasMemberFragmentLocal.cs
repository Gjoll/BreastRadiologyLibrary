using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.ObservationLocal;

namespace BreastRadLib.ConsistentWithHasMemberFragmentLocal
{
	//+ LocalClassDefs
	/// <summary>
	/// Accessor class for ObservationhasMember slice 'consistentWith'
	/// [Fhir Element 'Observation.hasMember:consistentWith]'
	/// </summary>
	public class ConsistentWith_Accessor : ObservationBase.HasMemberMultiple<ConsistentWith>                                                   // CSDefineObservation.cs:198
	{                                                                                                                                          // CSDefineObservation.cs:199
	    /// <summary>
	    /// Accessor HasMember slice ConsistentWith_Accessor class constructor
	    /// </summary>
	    public ConsistentWith_Accessor(BreastRadiologyDocument doc) : base()                                                                   // CSDefineObservation.cs:204
	    {                                                                                                                                      // CSDefineObservation.cs:205
	        this.Create(doc, 0, -1);                                                                                                           // CSDefineObservation.cs:206
	    }                                                                                                                                      // CSDefineObservation.cs:207
	}                                                                                                                                          // CSDefineObservation.cs:208
	//- LocalClassDefs
}
