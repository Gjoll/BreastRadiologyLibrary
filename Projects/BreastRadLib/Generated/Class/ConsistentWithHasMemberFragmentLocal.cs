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
	/// Accessor class for 'consistentWith'
	/// [Fhir Element 'Observation.hasMember:consistentWith]'
	/// </summary>
	public class ConsistentWith_Accessor : ObservationBase.HasMemberMultiple<ConsistentWith>                                                   // CSDefineObservation.cs:194
	{                                                                                                                                          // CSDefineObservation.cs:195
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public ConsistentWith_Accessor(BreastRadiologyDocument doc) : base()                                                                   // CSDefineObservation.cs:199
	    {                                                                                                                                      // CSDefineObservation.cs:200
	        this.Create(doc, 0, -1);                                                                                                           // CSDefineObservation.cs:201
	    }                                                                                                                                      // CSDefineObservation.cs:202
	}                                                                                                                                          // CSDefineObservation.cs:203
	//- LocalClassDefs
}
