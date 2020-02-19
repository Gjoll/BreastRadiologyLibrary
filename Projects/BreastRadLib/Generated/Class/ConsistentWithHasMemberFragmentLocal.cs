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
	public class ConsistentWith_Accessor : ObservationLocal.HasMemberMultiple<ConsistentWith>                                                  // CSDefineObservation.cs:263
	{                                                                                                                                          // CSDefineObservation.cs:264
	    /// <summary>
	    /// Accessor HasMember slice ConsistentWith_Accessor class constructor
	    /// </summary>
	    public ConsistentWith_Accessor(BreastRadiologyDocument doc) : base()                                                                   // CSDefineObservation.cs:269
	    {                                                                                                                                      // CSDefineObservation.cs:270
	        this.Init(doc, 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/ConsistentWith");                               // CSDefineObservation.cs:271
	    }                                                                                                                                      // CSDefineObservation.cs:272
	}                                                                                                                                          // CSDefineObservation.cs:273
	//- LocalClassDefs
}
