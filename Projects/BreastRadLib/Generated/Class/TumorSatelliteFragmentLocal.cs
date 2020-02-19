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
	public class TumorSatellite_Accessor : ObservationLocal.HasMemberMultiple<TumorSatellite>                                                  // CSDefineObservation.cs:265
	{                                                                                                                                          // CSDefineObservation.cs:266
	    /// <summary>
	    /// Accessor HasMember slice TumorSatellite_Accessor class constructor
	    /// </summary>
	    public TumorSatellite_Accessor(BreastRadiologyDocument doc) : base()                                                                   // CSDefineObservation.cs:271
	    {                                                                                                                                      // CSDefineObservation.cs:272
	        this.Init(doc, 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/TumorSatellite");                               // CSDefineObservation.cs:273
	    }                                                                                                                                      // CSDefineObservation.cs:274
	}                                                                                                                                          // CSDefineObservation.cs:275
	//- LocalClassDefs
}
