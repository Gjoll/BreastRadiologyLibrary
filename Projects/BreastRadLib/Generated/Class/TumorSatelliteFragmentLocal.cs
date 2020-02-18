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
	/// Accessor class for 'tumorSatellite'
	/// [Fhir Element 'Observation.hasMember:tumorSatellite]'
	/// </summary>
	public class TumorSatellite_Accessor : ObservationBase.HasMemberMultiple<TumorSatellite>                                                   // CSDefineObservation.cs:194
	{                                                                                                                                          // CSDefineObservation.cs:195
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public TumorSatellite_Accessor(BreastRadiologyDocument doc) : base()                                                                   // CSDefineObservation.cs:199
	    {                                                                                                                                      // CSDefineObservation.cs:200
	        this.Create(doc, 0, -1);                                                                                                           // CSDefineObservation.cs:201
	    }                                                                                                                                      // CSDefineObservation.cs:202
	}                                                                                                                                          // CSDefineObservation.cs:203
	//- LocalClassDefs
}
