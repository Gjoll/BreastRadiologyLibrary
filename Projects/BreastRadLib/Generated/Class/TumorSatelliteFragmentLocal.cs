using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.ObservationLocal;

namespace BreastRadLib.TumorSatelliteFragmentLocal
{
	//+ LocalClassDefs
	/// <summary>
	/// Accessor class for ObservationhasMember slice 'tumorSatellite'
	/// [Fhir Element 'Observation.hasMember:tumorSatellite]'
	/// </summary>
	public class TumorSatellite_Accessor : ObservationLocal.HasMemberMultiple<TumorSatellite>                                                  // CSDefineObservation.cs:199
	{                                                                                                                                          // CSDefineObservation.cs:200
	    /// <summary>
	    /// Accessor HasMember slice TumorSatellite_Accessor class constructor
	    /// </summary>
	    public TumorSatellite_Accessor(BreastRadiologyDocument doc) : base()                                                                   // CSDefineObservation.cs:205
	    {                                                                                                                                      // CSDefineObservation.cs:206
	        this.Init(doc, 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/TumorSatellite");                               // CSDefineObservation.cs:207
	    }                                                                                                                                      // CSDefineObservation.cs:208
	}                                                                                                                                          // CSDefineObservation.cs:209
	//- LocalClassDefs
}
