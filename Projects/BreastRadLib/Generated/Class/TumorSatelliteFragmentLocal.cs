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
	public class TumorSatellite_Accessor : MemberListReferenceMultiple<TumorSatellite>                                                         // BuildMemberListReference.cs:66
	{                                                                                                                                          // BuildMemberListReference.cs:67
	    /// <summary>
	    /// TumorSatellite_Accessor class constructor
	    /// </summary>
	    public TumorSatellite_Accessor(BreastRadiologyDocument doc) : base("TumorSatellite_Accessor")                                          // BuildMemberListReference.cs:72
	    {                                                                                                                                      // BuildMemberListReference.cs:73
	        this.Init(doc, 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/TumorSatellite");                               // BuildMemberListReference.cs:74
	    }                                                                                                                                      // BuildMemberListReference.cs:75
	}                                                                                                                                          // BuildMemberListReference.cs:76
	//- LocalClassDefs
}
