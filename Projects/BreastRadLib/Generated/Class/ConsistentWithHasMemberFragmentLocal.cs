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
	public class ConsistentWith_Accessor : ObservationLocal.HasMemberMultiple<ConsistentWith>                                                  // CSDefineObservation.cs:199
	{                                                                                                                                          // CSDefineObservation.cs:200
	    /// <summary>
	    /// Accessor HasMember slice ConsistentWith_Accessor class constructor
	    /// </summary>
	    public ConsistentWith_Accessor(BreastRadiologyDocument doc) : base()                                                                   // CSDefineObservation.cs:205
	    {                                                                                                                                      // CSDefineObservation.cs:206
	        this.Init(doc, 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/ConsistentWith");                               // CSDefineObservation.cs:207
	    }                                                                                                                                      // CSDefineObservation.cs:208
	}                                                                                                                                          // CSDefineObservation.cs:209
	//- LocalClassDefs
}
