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
	public class TumorSatellite_Accessor : ObservationBase.HasMemberMultiple<TumorSatellite>                                                   // CSDefineObservation.cs:198
	{                                                                                                                                          // CSDefineObservation.cs:199
	    /// <summary>
	    /// Accessor HasMember slice TumorSatellite_Accessor class constructor
	    /// </summary>
	    public TumorSatellite_Accessor(BreastRadiologyDocument doc) : base()                                                                   // CSDefineObservation.cs:204
	    {                                                                                                                                      // CSDefineObservation.cs:205
	        this.Create(doc, 0, -1);                                                                                                           // CSDefineObservation.cs:206
	    }                                                                                                                                      // CSDefineObservation.cs:207
	}                                                                                                                                          // CSDefineObservation.cs:208
	//- LocalClassDefs
}
