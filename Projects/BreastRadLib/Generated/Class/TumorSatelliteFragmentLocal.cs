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
	/// Accessor class for slice 'tumorSatellite'
	/// [Fhir Element 'Observation.hasMember:tumorSatellite]'
	/// </summary>
	public class TumorSatellite_Accessor : MemberListCodedReferenceMultiple<TumorSatellite>                                                    // CSBuildMemberListReference.cs:66
	{                                                                                                                                          // CSBuildMemberListReference.cs:67
	    /// <summary>
	    /// TumorSatellite_Accessor class constructor
	    /// </summary>
	    public TumorSatellite_Accessor(BreastRadiologyDocument doc) : base("TumorSatellite_Accessor")                                          // CSBuildMemberListReference.cs:72
	    {                                                                                                                                      // CSBuildMemberListReference.cs:73
	        this.Init(doc, 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/TumorSatellite");                               // CSBuildMemberListReference.cs:74
	    }                                                                                                                                      // CSBuildMemberListReference.cs:75
	}                                                                                                                                          // CSBuildMemberListReference.cs:76
	//- LocalClassDefs
}
